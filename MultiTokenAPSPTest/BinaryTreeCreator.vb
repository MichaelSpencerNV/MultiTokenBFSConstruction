Public Class BinaryTreeCreator
    Public mShowBFSDebugMessages As Boolean

    Public Function CreateTreeNetwork(intLevels As Integer) As List(Of Node)
        Dim networkFunctions As New Network
        networkFunctions.mShowBFSDebugMessages = mShowBFSDebugMessages
        Dim someNodes() As Node = networkFunctions.GenerateSomeNodesAsArray(CInt((2 ^ intLevels)) - 1)

        Dim nodeID As Integer
        For nodeID = 2 To someNodes.Count - 1
            Dim newParent As Node = someNodes(CInt(Math.Floor(nodeID / 2)))
            networkFunctions.AttachNeighbors(someNodes(nodeID), newParent)
        Next
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
