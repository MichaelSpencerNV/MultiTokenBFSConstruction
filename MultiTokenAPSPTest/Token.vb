Public Class TokenControl
    'Private mfirstNodeIDBFSTokenReceivedFrom As Integer
    'Private mEarliestRoundToReturnTokenToSender As Integer
    'Private mhavePreviouslyReceivedToken As Boolean
    Private mtokenPossessionCount As Integer
    'Private mnextRoundToSendToken As Integer
    'Private mNodeIDThatOwnsTokens As Integer
    Public mShowDebugMessages As Boolean
    Private mTokensInDockedBay As Integer

    Private myNode As Node
    Public Property theNode As Node
        Get
            Return myNode
        End Get
        Set(value As Node)
            myNode = value
        End Set
    End Property

    Public Property IsParallel As Boolean

    Public Function ProcessEndOfRound(round As Integer) As Boolean
        Call MoveDockedTokensToReadyStatus()

        If mtokenPossessionCount = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub ProcessRound(round As Integer)
        If mtokenPossessionCount > 0 Then
            If myNode.myBFSTree.IsBFSFormationInProgess(myNode.NodeID) = False Then
                Call BFSFormation.BFSQueryNeighbors(myNode.NodeID, round, myNode.NodeID, myNode, mShowDebugMessages)
            End If

            If IsParallel = True Then
                Exit Sub
            End If
        End If

        While mtokenPossessionCount > 0 'AndAlso mnextRoundToSendToken <= round
            Call SendTokenToANeighbor(round)
        End While
    End Sub

    Private Sub MoveDockedTokensToReadyStatus()
        mtokenPossessionCount += mTokensInDockedBay
        mTokensInDockedBay = 0
    End Sub

    Public Sub ReceiveACreateBFSToken(round As Integer, Optional tokenSender As Node = Nothing) 'Optional NodeIDThatOwnsTokens As Integer = -1,
        mTokensInDockedBay += 1
        'mtokenPossessionCount += 1
        If IsNothing(tokenSender) = False Then
            Debug.Print("round " & round & ". " & myNode.NodeID & " received a token from " & tokenSender.NodeID & ". Total tokens in bay = " & mTokensInDockedBay & ". Total tokens ready to send = " & mtokenPossessionCount)
        Else
            Debug.Print("round " & round & ". " & myNode.NodeID & " received a token with no sender. Total tokens in bay = " & mTokensInDockedBay & ". Total tokens ready to send = " & mtokenPossessionCount)
        End If

        'mnextRoundToSendToken = round + 1

        'If mhavePreviouslyReceivedToken = True Then
        '    If IsNothing(tokenSender) = False Then
        '        'If tokenSender.NodeID = mfirstNodeIDBFSTokenReceivedFrom Then
        '        '    mEarliestRoundToReturnTokenToSender = round + 2
        '        'End If
        '        TrackTokenReception(tokenSender.NodeID)
        '    End If
        '    Exit Sub
        'End If

        'mhavePreviouslyReceivedToken = True
        If IsNothing(tokenSender) = False Then
            'mfirstNodeIDBFSTokenReceivedFrom = tokenSender.NodeID
            'mNodeIDThatOwnsTokens = NodeIDThatOwnsTokens
            'mEarliestRoundToReturnTokenToSender = round + 2
            TrackTokenReception(tokenSender.NodeID)
        Else
            'if no token sender, then I am the first one to receive a token
            Call MoveDockedTokensToReadyStatus()
            'mNodeIDThatOwnsTokens = myNode.NodeID
        End If

    End Sub


    Private Sub TrackTokenReception(nodeID As Integer)
        Dim bfsNeighbor As BFSFormation.BFSNeighbor
        For Each bfsNeighbor In myNode.myBFSTree.GetMainBFSTree
            If bfsNeighbor.theNode.NodeID = nodeID Then
                TrackTokenReception(bfsNeighbor)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub TrackTokenReception(bfsNeighbor As BFSFormation.BFSNeighbor)
        If myNode.myBFSTree.GetMainBFSTree.Contains(bfsNeighbor) Then
            myNode.myBFSTree.GetMainBFSTree.Remove(bfsNeighbor)
            bfsNeighbor.numberOfTimesTokenSent += 1
            myNode.myBFSTree.GetMainBFSTree.Add(bfsNeighbor)
        Else
            Throw New Exception("Attempt to track token on a non existent neighbor.")
        End If
    End Sub

    'Private Sub ReturnTokenToSender(round As Integer)
    '    Dim bfsNeighbor As BFSFormation.BFSNeighbor
    '    For Each bfsNeighbor In myNode.myBFSTree.GetMainBFSTree
    '        If bfsNeighbor.theNode.NodeID = mfirstNodeIDBFSTokenReceivedFrom Then
    '            TrackTokenReception(bfsNeighbor)
    '            bfsNeighbor.theNode.tokenTracking.ReceiveACreateBFSToken(round, myNode)
    '            Exit Sub
    '        End If
    '    Next
    'End Sub

    Private Function NeighborWithFewestReceptions(round As Integer) As BFSFormation.BFSNeighbor
        Dim minNode As BFSFormation.BFSNeighbor = New BFSFormation.BFSNeighbor()
        Dim minCount As Integer = 30000

        Dim bfsNeighbor As BFSFormation.BFSNeighbor
        For Each bfsNeighbor In myNode.myBFSTree.GetMainBFSTree
            'If bfsNeighbor.theNode.NodeID = mfirstNodeIDBFSTokenReceivedFrom AndAlso round >= mEarliestRoundToReturnTokenToSender Then
            '    If bfsNeighbor.numberOfTimesTokenSent < minCount Then
            '        minNode = bfsNeighbor
            '        minCount = bfsNeighbor.numberOfTimesTokenSent
            '    End If
            'ElseIf bfsNeighbor.theNode.NodeID <> mfirstNodeIDBFSTokenReceivedFrom Then
            If bfsNeighbor.numberOfTimesTokenSent < minCount Then
                minNode = bfsNeighbor
                minCount = bfsNeighbor.numberOfTimesTokenSent
            End If
            'End If

        Next
        Return minNode
    End Function

    Private Sub SendTokenToNeighborWithFewestReceptions(round As Integer)
        Dim nodeWithFewestReceptions As BFSFormation.BFSNeighbor = NeighborWithFewestReceptions(round)
        TrackTokenReception(nodeWithFewestReceptions)
        nodeWithFewestReceptions.theNode.tokenTracking.ReceiveACreateBFSToken(round, myNode)
    End Sub

    Private Sub SendTokenToANeighbor(round As Integer)
        If myNode.myBFSTree.GetMainBFSTree.Count = 1 Then
            myNode.myBFSTree.GetMainBFSTree(0).theNode.tokenTracking.ReceiveACreateBFSToken(round, myNode)
            mtokenPossessionCount -= 1
            Exit Sub
        End If

        Call SendTokenToNeighborWithFewestReceptions(round)
        mtokenPossessionCount -= 1
    End Sub

End Class
