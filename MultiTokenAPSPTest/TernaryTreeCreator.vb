Public Class TernaryTreeCreator
    Public mShowBFSDebugMessages As Boolean

    Public Function CreateTreeNetwork(intLevels As Integer) As List(Of Node)
        Dim networkFunctions As New Network
        networkFunctions.mShowBFSDebugMessages = mShowBFSDebugMessages
        Dim someNodes() As Node = networkFunctions.GenerateSomeNodesAsArray(CInt(((3 ^ intLevels) - 1) / 2))

        Dim currentLevel As Integer
        Dim nodeId As Integer
        For currentLevel = 2 To intLevels
            Dim firstNodeInLevel As Integer = CInt(((3 ^ (currentLevel - 1)) - 1) / 2) + 1
            Dim LastNodeInLevel As Integer = CInt(((3 ^ (currentLevel)) - 1) / 2)
            Dim currentParent As Integer = CInt(((3 ^ (currentLevel - 2)) - 1) / 2) + 1
            Dim newParent As Node = someNodes(currentParent)
            Dim childCounter As Integer = 0
            For nodeId = firstNodeInLevel To LastNodeInLevel
                networkFunctions.AttachNeighbors(someNodes(nodeId), newParent)
                childCounter += 1
                If childCounter = 3 Then
                    currentParent += 1
                    newParent = someNodes(currentParent)
                    childCounter = 0
                End If
            Next
        Next

        'For nodeID = 3 To someNodes.Count - 1
        '    Dim newParent As Node = someNodes(CInt(Math.Floor(nodeID / 3)))
        '    networkFunctions.AttachNeighbors(someNodes(nodeID), newParent)
        'Next
        Return ConvertArrayToList(someNodes)

    End Function

    Private Function ConvertArrayToList(nodes() As Node) As List(Of Node)
        Dim someNodes As New List(Of Node)

        Dim nodeID As Integer
        For nodeID = 1 To nodes.Count - 1
            someNodes.Add(nodes(nodeID))
        Next

        Return someNodes
    End Function

End Class
