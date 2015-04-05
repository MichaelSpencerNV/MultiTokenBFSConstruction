Public Class Network
    Public mShowBFSDebugMessages As Boolean

    Public Function GenerateSomeNodes(howMany As Integer) As List(Of Node)
        Dim count As Integer
        Dim nodes As New List(Of Node)

        For count = 1 To howMany
            Dim newNode As New Node(count, mShowBFSDebugMessages)
            nodes.Add(newNode)
        Next

        Return nodes
    End Function

    Public Function GenerateSomeNodesAsArray(howMany As Integer) As Node()
        Dim count As Integer
        Dim nodes(howMany) As Node

        For count = 1 To howMany
            nodes(count) = New Node(count, mShowBFSDebugMessages)
        Next

        Return nodes
    End Function

    Private Function IsAlreadyNeighbor(ByRef node1 As Node, ByRef node2 As Node) As Boolean
        Dim iLoop As Integer

        For iLoop = 0 To node1.MyNetworkNeighbors.Count - 1
            If node1.MyNetworkNeighbors(iLoop).theNode.NodeID = node2.NodeID Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Function IsAlreadyNeighbor(ByRef nodes As List(Of Node), ByRef node1 As Node, ByRef node2 As Node) As Boolean
        Dim iLoop As Integer

        For iLoop = 0 To node1.MyNetworkNeighbors.Count - 1
            If node1.MyNetworkNeighbors(iLoop).theNode.NodeID = node2.NodeID Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub AttachNeighbors(ByRef node1 As Node, ByRef node2 As Node)
        If IsAlreadyNeighbor(node1, node2) = True Then
            Exit Sub
        End If

        MakeNodesNeighbors(node1, node2)
    End Sub

    Public Sub AttachNeighbors(ByRef nodes As List(Of Node), ByRef node1 As Node, ByRef node2 As Node)
        If IsAlreadyNeighbor(nodes, node1, node2) = True Then
            Exit Sub
        End If

        nodes.Remove(node1)
        nodes.Remove(node2)
        MakeNodesNeighbors(node1, node2)
        nodes.Add(node1)
        nodes.Add(node2)
    End Sub

    Public Function GetNodeByID(someNodes As List(Of Node), nodeID As Integer) As Node
        Dim theNode As Node

        For Each theNode In someNodes
            If theNode.NodeID = nodeID Then
                Return theNode
            End If
        Next

        Throw New Exception("Unable to find node " & nodeID & " in node list.")
    End Function


    Public Function ConnectNodesRandomly(nodes As List(Of Node), numberOfEdges As Integer, maxDegree As Integer) As List(Of Node)
        Dim aNode As Node
        Dim anotherNode As Node
        Dim count As Integer

        'must ensure each node has at least one connection
        For count = 0 To nodes.Count - 1
            aNode = nodes(0)
            If aNode.NetworkNeighborCount = 0 Then
                anotherNode = PickARandomNode(nodes, maxDegree, aNode.NodeID)
                AttachNeighbors(nodes, aNode, anotherNode)
            End If
        Next

        'While DoesAnUnconnectedNodeExist(nodes) = True
        '    aNode = PickARandomNode(nodes, 0)
        '    anotherNode = PickARandomNode(nodes, 3, aNode.NodeID)
        '    AttachNeighbors(nodes, aNode, anotherNode)
        'End While

        'For count = 1 To EdgeCount(nodes) - nodes.Count
        While EdgeCount(nodes) < numberOfEdges
            aNode = PickARandomNode(nodes, maxDegree)
            anotherNode = PickARandomNode(nodes, maxDegree, aNode.NodeID)
            AttachNeighbors(nodes, aNode, anotherNode)
        End While

        Return nodes
    End Function

    Private Sub MakeNodesNeighbors(node1 As Node, node2 As Node)
        node1.SetNodeAsNetworkNeighbor(node2)
        node2.SetNodeAsNetworkNeighbor(node1)
    End Sub

    Private Function PickARandomNode(nodes As List(Of Node), maxDegree As Integer, Optional notThisNodeID As Integer = -1) As Node
        Dim randomGenerator As New Random
        Dim number As Integer = randomGenerator.Next(nodes.Count)
        Dim Attempts As Integer = 1

        While nodes(number).NetworkNeighborCount > maxDegree OrElse nodes(number).NodeID = notThisNodeID
            number = randomGenerator.Next(nodes.Count)
            If (Attempts * 2) > nodes.Count Then
                Dim intLoop As Integer
                For intLoop = 0 To nodes.Count - 1
                    If nodes(intLoop).NetworkNeighborCount <= maxDegree AndAlso nodes(intLoop).NodeID <> notThisNodeID Then
                        Return nodes(intLoop)
                    End If
                Next
                Throw New Exception("Asked to pick a random node with max degree of " & maxDegree & " but no nodes match that criteria.")
            End If
            Attempts += 1
        End While
        Return nodes(number)
    End Function

    Private Function DoesAnUnconnectedNodeExist(nodes As List(Of Node)) As Boolean
        Dim aNode As Node

        For Each aNode In nodes
            If aNode.NetworkNeighborCount = 0 Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Function EdgeCount(nodes As List(Of Node)) As Integer
        Dim aNode As Node
        Dim countOfEdges As Integer = 0

        For Each aNode In nodes
            countOfEdges += aNode.NetworkNeighborCount
        Next

        Return CInt(countOfEdges / 2)
    End Function


End Class
