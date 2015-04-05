Public Class StarNetwork
    Public mShowBFSDebugMessages As Boolean

    Public Function CreateStarNetwork(intNodes As Integer) As List(Of Node)
        Dim networkFunctions As New Network
        networkFunctions.mShowBFSDebugMessages = mShowBFSDebugMessages
        Dim someNodes() As Node = networkFunctions.GenerateSomeNodesAsArray(intNodes)

        Dim nodeID As Integer
        Dim parent As Node = someNodes(1)
        For nodeID = 2 To someNodes.Count - 1
            networkFunctions.AttachNeighbors(someNodes(nodeID), parent)
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
