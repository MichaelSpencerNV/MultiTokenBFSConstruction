Public Class BFSTree
    Private mBFSNeighbors As New Collection 'collection of list of BFSNeighbors
    Private mBFSTreesToDiscover As New List(Of BFSFormation.TreeToDiscover)
    Private mbfsSearchCompleteForMyTree As Boolean = False
    Private mBFSRequestCount(1000) As Integer
    Private mBFSTokenTreeID As Integer = -1
    Public mshowDebugMessages As Boolean

    Private myNode As Node
    Public Property theNode As Node
        Get
            Return myNode
        End Get
        Set(value As Node)
            myNode = value
        End Set
    End Property

    Public Function BFSNeighborsForAllTrees() As Collection
        Return mBFSNeighbors
    End Function

    Public Function DoIHaveAnyBFSNeighbors(bfsTreeID As Integer) As Boolean
        Return mBFSNeighbors.Contains(CStr(bfsTreeID))
    End Function

    Public Function GetMainBFSTree() As List(Of BFSFormation.BFSNeighbor)
        Return MyBFSNeighbors(1)
    End Function

    Public Function MyBFSNeighbors(BFSTreeID As Integer) As List(Of BFSFormation.BFSNeighbor)
        If mBFSNeighbors.Contains(CStr(BFSTreeID)) = True Then
            Return CType(mBFSNeighbors(CStr(BFSTreeID)), List(Of BFSFormation.BFSNeighbor))
        Else
            Throw New Exception("Requested a bfs tree that hasnt been added to this node's bfs list.")
        End If
    End Function

    Public Function GetBFSRequestCounts() As Integer
        Return mBFSRequestCount.Sum
    End Function

    Public Function IsBFSFormationInProgess(BFSTreeID As Integer) As Boolean
        If mBFSNeighbors.Contains(CStr(BFSTreeID)) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Property IsBFSearchCompleteForMyTree() As Boolean
        Get
            Return mbfsSearchCompleteForMyTree
        End Get
        Set(value As Boolean)
            mbfsSearchCompleteForMyTree = value
        End Set
    End Property

    Public Function ProcessRound(round As Integer) As Boolean
        Call ProcessQueuedBFSDiscoveries(round)
        Call BFSFormation.ProcessConvergeCasts(round, myNode, mshowDebugMessages)

        If mBFSTreesToDiscover.Count = 0 AndAlso mbfsSearchCompleteForMyTree = True Then
            Return False
        End If
        Return True
    End Function

    Public Sub UpdateConvergeCastReceived(ByRef bfsNeighbors As List(Of BFSFormation.BFSNeighbor), aNeighbor As BFSFormation.BFSNeighbor, bfsTreeID As Integer)
        mBFSNeighbors.Remove(CStr(bfsTreeID))
        bfsNeighbors.Remove(aNeighbor)
        aNeighbor.convergeCastReceivedForBFSFormation = True
        bfsNeighbors.Add(aNeighbor)
        mBFSNeighbors.Add(bfsNeighbors, CStr(bfsTreeID))
    End Sub

    Public Sub AddNewBFSNeighbor(bfsTreeID As Integer, neighbor As Node.networkNeighbor)
        Dim bfsNeighbors As List(Of BFSFormation.BFSNeighbor) = GetOrCreateBFSNeighborList(bfsTreeID)
        bfsNeighbors = BFSFormation.AddNewNeighbor(neighbor.theNode, bfsTreeID, bfsNeighbors)

        If mBFSNeighbors.Contains(CStr(bfsTreeID)) = False Then
            mBFSNeighbors.Add(bfsNeighbors, CStr(bfsTreeID))
        End If
    End Sub

    Public Function IsThisBFSTreeQueuedForDiscovery(BFSTreeID As Integer) As Boolean
        Dim aTree As BFSFormation.TreeToDiscover

        For Each aTree In mBFSTreesToDiscover
            If aTree.bfsTreeID = BFSTreeID Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub ProcessQueuedBFSDiscoveries(round As Integer)
        If mBFSTreesToDiscover.Count > 0 Then
            Dim newCollection As New List(Of BFSFormation.TreeToDiscover)
            Dim discoverThisTree As BFSFormation.TreeToDiscover

            For Each discoverThisTree In mBFSTreesToDiscover
                If discoverThisTree.roundToDiscover <= round Then
                    Call BFSFormation.BFSQueryNeighbors(discoverThisTree.bfsTreeID, round, myNode.NodeID, myNode, mshowDebugMessages)
                Else
                    newCollection.Add(discoverThisTree)
                End If
            Next
            mBFSTreesToDiscover = newCollection
        End If
    End Sub

    Public Function GetOrCreateBFSNeighborList(bfsTreeID As Integer) As List(Of BFSFormation.BFSNeighbor)
        If mBFSNeighbors.Contains(CStr(bfsTreeID)) = True Then
            Return CType(mBFSNeighbors(CStr(bfsTreeID)), List(Of BFSFormation.BFSNeighbor))
        Else
            Return New List(Of BFSFormation.BFSNeighbor)
        End If
    End Function

    Private Function DoIHaveAParentInThisBFSTree(bfsTreeID As Integer) As Boolean
        If mBFSNeighbors.Count = 0 Then
            Return False
        End If

        If mBFSNeighbors.Contains(CStr(bfsTreeID)) = False Then
            Return False
        End If

        Dim theNeighbor As BFSFormation.BFSNeighbor
        Dim bfsNeighbors As List(Of BFSFormation.BFSNeighbor) = CType(mBFSNeighbors(CStr(bfsTreeID)), List(Of BFSFormation.BFSNeighbor))

        For Each theNeighbor In CType(mBFSNeighbors(CStr(bfsTreeID)), List(Of BFSFormation.BFSNeighbor))
            If theNeighbor.isParent = True Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function CanIBeYourParent(parentNode As Node, bfsTreeID As Integer, round As Integer) As Boolean
        mBFSRequestCount(round) += 1

        If DoIHaveAParentInThisBFSTree(bfsTreeID) = False Then
            Dim newParent As New BFSFormation.BFSNeighbor
            Dim bfsNeighbors As List(Of BFSFormation.BFSNeighbor)

            If mBFSNeighbors.Contains(CStr(bfsTreeID)) = True Then
                bfsNeighbors = CType(mBFSNeighbors(CStr(bfsTreeID)), List(Of BFSFormation.BFSNeighbor))
            Else
                bfsNeighbors = New List(Of BFSFormation.BFSNeighbor)
            End If
            newParent.isParent = True
            newParent.bfsTreeID = bfsTreeID
            newParent.theNode = parentNode
            bfsNeighbors.Add(newParent)

            If mBFSNeighbors.Contains(CStr(bfsTreeID)) = False Then
                mBFSNeighbors.Add(bfsNeighbors, CStr(bfsTreeID))
            End If

            Dim newTreeToDiscover As New BFSFormation.TreeToDiscover
            newTreeToDiscover.bfsTreeID = bfsTreeID
            newTreeToDiscover.roundToDiscover = round + 1
            mBFSTreesToDiscover.Add(newTreeToDiscover)
            Return True
        Else
            Return False
        End If
    End Function

End Class
