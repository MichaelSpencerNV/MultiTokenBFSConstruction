Public Class BFSFormation

    Public Structure TreeToDiscover
        Public bfsTreeID As Integer
        Public roundToDiscover As Integer
        Public okToRemove As Boolean
    End Structure

    Public Structure BFSNeighbor
        Public theNode As Node
        Public isParent As Boolean
        Public convergeCastReceivedForBFSFormation As Boolean
        Public bfsTreeID As Integer
        Public numberOfTimesTokenSent As Integer
    End Structure

    Public Shared Function AddNewNeighbor(theNode As Node, bfsTreeID As Integer, ByRef bfsNeighbors As List(Of BFSFormation.BFSNeighbor)) As List(Of BFSFormation.BFSNeighbor)
        Dim newNeighbor As New BFSFormation.BFSNeighbor
        newNeighbor.isParent = False
        newNeighbor.theNode = theNode
        newNeighbor.bfsTreeID = bfsTreeID
        bfsNeighbors.Add(newNeighbor)
        Return bfsNeighbors
    End Function

    Public Shared Function GetMyParentInThisBFSTree(bfsTreeID As Integer, theNode As Node) As BFSFormation.BFSNeighbor
        If theNode.myBFSTree.MyBFSNeighbors(bfsTreeID).Count = 0 Then
            Throw New Exception(CStr(theNode.NodeID) & " no BFS neighbors at all.")
        End If

        If theNode.myBFSTree.MyBFSNeighbors(bfsTreeID).Count = 0 Then
            Throw New Exception(CStr(theNode.NodeID) & " no BFS neighbors for BFSTreeID " & bfsTreeID)
        End If

        Dim theNeighbor As BFSFormation.BFSNeighbor
        For Each theNeighbor In theNode.myBFSTree.MyBFSNeighbors(bfsTreeID)
            If theNeighbor.isParent = True Then
                Return theNeighbor
            End If
        Next
        Throw New Exception(CStr(theNode.NodeID) & " no parent found for BFSTreeID " & bfsTreeID)
    End Function

    Public Shared Sub BFSQueryNeighbors(bfsTreeID As Integer, round As Integer, myID As Integer, theNode As Node, showDebugMessages As Boolean)
        Dim neighbor As Node.networkNeighbor
        For Each neighbor In theNode.MyNetworkNeighbors
            If IsThisMyBFSParent(bfsTreeID, theNode, neighbor.theNode) = False Then
                If neighbor.theNode.myBFSTree.CanIBeYourParent(theNode, bfsTreeID, round) = True Then
                    theNode.myBFSTree.AddNewBFSNeighbor(bfsTreeID, neighbor)
                End If
            End If
        Next

        If bfsTreeID <> myID Then
            If theNode.MyNetworkNeighbors.Count = 1 Then
                'I am a leaf node, send convergecast for end of BFS formation
                Dim myParent As BFSFormation.BFSNeighbor = GetMyParentInThisBFSTree(bfsTreeID, theNode)
                CommunicateConvergeCast(myParent, myID, bfsTreeID, round, showDebugMessages)
                Exit Sub
            End If

            'If theNode.myBFSTree.MyBFSNeighbors(bfsTreeID).Count = 1 Then
            '    Dim myParent As BFSFormation.BFSNeighbor = GetMyParentInThisBFSTree(bfsTreeID, theNode)
            '    CommunicateConvergeCast(myParent, myID, bfsTreeID, round)
            'End If
        End If
    End Sub

    Public Shared Function IsThisMyBFSParent(bfsTreeID As Integer, theNode As Node, theNeighbor As Node) As Boolean
        If theNode.myBFSTree.DoIHaveAnyBFSNeighbors(bfsTreeID) = False Then
            Return False
        End If

        Dim bfsNeighbor As BFSFormation.BFSNeighbor
        For Each bfsNeighbor In theNode.myBFSTree.MyBFSNeighbors(bfsTreeID)
            If bfsNeighbor.theNode.NodeID = theNeighbor.NodeID Then
                If bfsNeighbor.isParent = True Then
                    Return True
                Else
                    Return False
                End If
            End If
        Next
        Return False
    End Function

    Private Shared Function AmIYourParent(BFSTreeID As Integer, theNode As Node, aBFSNeighbor As BFSNeighbor) As Boolean
        Return IsThisMyBFSParent(BFSTreeID, aBFSNeighbor.theNode, theNode)
    End Function

    Private Shared Function HaveAllChildrenSentConvergeCastForBFSFormation(bfsTreeID As Integer, theNode As Node) As Boolean
        Dim aBFSNeighbor As BFSNeighbor
        For Each aBFSNeighbor In theNode.myBFSTree.MyBFSNeighbors(bfsTreeID)
            If AmIYourParent(bfsTreeID, theNode, aBFSNeighbor) = True Then
                If aBFSNeighbor.convergeCastReceivedForBFSFormation = False Then
                    Return False
                End If
            End If
        Next
        Return True
    End Function

    Private Shared Function WasConvergeCastSentToParent(bfsTreeID As Integer, theNode As Node) As Boolean
        Dim myParent As BFSNeighbor = GetMyParentInThisBFSTree(bfsTreeID, theNode)
        Return myParent.convergeCastReceivedForBFSFormation
    End Function

    Public Shared Sub ProcessConvergeCasts(round As Integer, theNode As Node, showDebugMessages As Boolean)
        Dim bfsNeighborsForThisTree As List(Of BFSFormation.BFSNeighbor)
        Dim bfsTreeID As Integer
        For Each bfsNeighborsForThisTree In theNode.myBFSTree.BFSNeighborsForAllTrees
            bfsTreeID = bfsNeighborsForThisTree(0).bfsTreeID
            If bfsTreeID = theNode.NodeID AndAlso theNode.myBFSTree.IsBFSearchCompleteForMyTree = True Then
                Continue For
            End If

            If theNode.myBFSTree.IsThisBFSTreeQueuedForDiscovery(bfsTreeID) = True Then
                Continue For
            End If

            'If bfsTreeID = theNode.NodeID AndAlso bfsNeighborsForThisTree.Count = 1 Then 'leaf node and is root of this bfs tree
            '    'theNode.IsBFSearchCompleteForMyTree = True
            '    'Debug.Print(theNode.NodeID & " completed BFS Tree for bfsTreeID " & bfsTreeID & " in round " & round)
            '    Continue For
            'End If

            'If bfsNeighborsForThisTree.Count > 1 Then 'Skip leaf nodes
            If HaveAllChildrenSentConvergeCastForBFSFormation(bfsTreeID, theNode) = True Then
                If bfsTreeID = theNode.NodeID Then
                    theNode.myBFSTree.IsBFSearchCompleteForMyTree = True
                    If showDebugMessages = True Then
                        Debug.Print(theNode.NodeID & " completed BFS Tree for bfsTreeID " & bfsTreeID & " in round " & round)
                    End If
                ElseIf WasConvergeCastSentToParent(bfsTreeID, theNode) = False Then
                    Dim myParent As BFSFormation.BFSNeighbor = BFSFormation.GetMyParentInThisBFSTree(bfsTreeID, theNode)
                    CommunicateConvergeCast(myParent, theNode.NodeID, bfsTreeID, round, showDebugMessages)
                End If
            End If
            'End If
        Next
    End Sub

    Public Shared Sub CommunicateConvergeCast(receivingNode As BFSNeighbor, sendingNodeID As Integer, bfsTreeID As Integer, round As Integer, showDebugMessages As Boolean)
        If showDebugMessages = True Then
            Debug.Print(receivingNode.theNode.NodeID & " received convergecast from node " & sendingNodeID & " for bfsTreeID " & bfsTreeID & " in round " & round)
        End If

        Dim bfsNeighbors As List(Of BFSFormation.BFSNeighbor) = receivingNode.theNode.myBFSTree.MyBFSNeighbors(bfsTreeID)
        Dim aNeighbor As BFSFormation.BFSNeighbor
        For Each aNeighbor In bfsNeighbors
            If aNeighbor.theNode.NodeID = sendingNodeID Then
                Call receivingNode.theNode.myBFSTree.UpdateConvergeCastReceived(bfsNeighbors, aNeighbor, bfsTreeID)
                Exit Sub
            End If
        Next
    End Sub

End Class
