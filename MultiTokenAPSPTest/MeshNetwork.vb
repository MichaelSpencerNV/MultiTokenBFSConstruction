Public Class MeshNetwork
    Public mShowBFSDebugMessages As Boolean

    Public Function CreateSmallSparseNetwork() As List(Of Node)
        Dim networkFunctions As New Network
        networkFunctions.mShowBFSDebugMessages = mShowBFSDebugMessages
        Dim someNodes() As Node = networkFunctions.GenerateSomeNodesAsArray(12)

        networkFunctions.AttachNeighbors(someNodes(1), someNodes(2))
        networkFunctions.AttachNeighbors(someNodes(1), someNodes(3))
        networkFunctions.AttachNeighbors(someNodes(2), someNodes(6))
        networkFunctions.AttachNeighbors(someNodes(3), someNodes(4))
        networkFunctions.AttachNeighbors(someNodes(3), someNodes(5))
        networkFunctions.AttachNeighbors(someNodes(5), someNodes(8))
        networkFunctions.AttachNeighbors(someNodes(5), someNodes(9))
        networkFunctions.AttachNeighbors(someNodes(6), someNodes(7))
        networkFunctions.AttachNeighbors(someNodes(6), someNodes(8))
        networkFunctions.AttachNeighbors(someNodes(9), someNodes(10))
        networkFunctions.AttachNeighbors(someNodes(9), someNodes(11))
        networkFunctions.AttachNeighbors(someNodes(10), someNodes(12))

        Return ConvertArrayToList(someNodes)

    End Function

    Public Function CreateLargeSparseNetwork() As List(Of Node)
        Dim networkFunctions As New Network
        networkFunctions.mShowBFSDebugMessages = mShowBFSDebugMessages
        Dim someNodes() As Node = networkFunctions.GenerateSomeNodesAsArray(84)

        Dim scaler As Integer = 0
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))
        scaler = 12
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes(4), someNodes(scaler + 7))


        scaler = 24
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes(12), someNodes(scaler + 1))


        scaler = 36
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes((2 * 12) + 10), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes((12) + 4), someNodes(scaler + 4))

        scaler = 48
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes((2 * 12) + 11), someNodes(scaler + 7)) '3-11 5-7
        networkFunctions.AttachNeighbors(someNodes((3 * 12) + 12), someNodes(scaler + 4)) '4-12 5-4

        scaler = 60
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes((4 * 12) + 11), someNodes(scaler + 4)) '5-11 6-4
        networkFunctions.AttachNeighbors(someNodes((2 * 12) + 7), someNodes(scaler + 7)) '3-7 6-7

        scaler = 72
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes((4 * 12) + 10), someNodes(scaler + 2)) '5-10 7-2
        networkFunctions.AttachNeighbors(someNodes((5 * 12) + 9), someNodes(scaler + 11)) '6-9 7-11

        Return ConvertArrayToList(someNodes)

    End Function

    Public Function CreateLargeDenseNetwork() As List(Of Node)
        Dim networkFunctions As New Network
        networkFunctions.mShowBFSDebugMessages = mShowBFSDebugMessages
        Dim someNodes() As Node = networkFunctions.GenerateSomeNodesAsArray(84)

        Dim scaler As Integer = 0
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 8), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 11), someNodes(scaler + 12))

        scaler = 12
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 8), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 11), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes(4), someNodes(scaler + 7)) '1-4 2-7
        networkFunctions.AttachNeighbors(someNodes(12), someNodes(scaler + 11)) '1-12 2-11
        networkFunctions.AttachNeighbors(someNodes(1), someNodes(scaler + 1)) '1-1 2-1

        scaler = 24
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 8), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 11), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes(7), someNodes(scaler + 2)) '1-7 3-2
        networkFunctions.AttachNeighbors(someNodes(11), someNodes(scaler + 1)) '1-11 3-1
        networkFunctions.AttachNeighbors(someNodes(12), someNodes(scaler + 3)) '1-12 3-3

        scaler = 36
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 8), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 11), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes(12 + 8), someNodes(scaler + 7)) '2-8 4-7
        networkFunctions.AttachNeighbors(someNodes(12 + 4), someNodes(scaler + 4)) '2-4 4-4
        networkFunctions.AttachNeighbors(someNodes(12 + 12), someNodes(scaler + 3)) '2-12 4-3

        networkFunctions.AttachNeighbors(someNodes((12 * 2) + 4), someNodes(scaler + 7)) '3-4 4-7
        networkFunctions.AttachNeighbors(someNodes((12 * 2) + 12), someNodes(scaler + 8)) '3-12 4-8
        networkFunctions.AttachNeighbors(someNodes((12 * 2) + 10), someNodes(scaler + 6)) '3-10 4-6

        scaler = 48
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 8), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 11), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes((12 * 2) + 7), someNodes(scaler + 11)) '3-7 5-11
        networkFunctions.AttachNeighbors(someNodes((12 * 2) + 12), someNodes(scaler + 2)) '3-12 5-2
        networkFunctions.AttachNeighbors(someNodes((12 * 2) + 10), someNodes(scaler + 1)) '3-10 5-1

        networkFunctions.AttachNeighbors(someNodes((12 * 3) + 8), someNodes(scaler + 3)) '4-8 5-3
        networkFunctions.AttachNeighbors(someNodes((12 * 3) + 11), someNodes(scaler + 4)) '4-11 5-4
        networkFunctions.AttachNeighbors(someNodes((12 * 3) + 12), someNodes(scaler + 12)) '4-12 5-12

        scaler = 60
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 8), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 11), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes((12 * 2) + 6), someNodes(scaler + 7)) '3-6 6-7
        networkFunctions.AttachNeighbors(someNodes((12 * 4) + 7), someNodes(scaler + 2)) '5-7 6-2
        networkFunctions.AttachNeighbors(someNodes((12 * 4) + 8), someNodes(scaler + 1)) '5-8 6-1

        scaler = 72
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 2))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 3))
        networkFunctions.AttachNeighbors(someNodes(scaler + 1), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 6))
        networkFunctions.AttachNeighbors(someNodes(scaler + 2), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 4))
        networkFunctions.AttachNeighbors(someNodes(scaler + 3), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 5))
        networkFunctions.AttachNeighbors(someNodes(scaler + 4), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 5), someNodes(scaler + 9))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 7))
        networkFunctions.AttachNeighbors(someNodes(scaler + 6), someNodes(scaler + 8))
        networkFunctions.AttachNeighbors(someNodes(scaler + 8), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 10))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 11))
        networkFunctions.AttachNeighbors(someNodes(scaler + 9), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 10), someNodes(scaler + 12))
        networkFunctions.AttachNeighbors(someNodes(scaler + 11), someNodes(scaler + 12))

        networkFunctions.AttachNeighbors(someNodes((12 * 5) + 3), someNodes(scaler + 2)) '6-3 7-2
        networkFunctions.AttachNeighbors(someNodes((12 * 5) + 12), someNodes(scaler + 11)) '6-12 7-11
        networkFunctions.AttachNeighbors(someNodes((12 * 5) + 10), someNodes(scaler + 8)) '6-10 7-8

        networkFunctions.AttachNeighbors(someNodes((12 * 3) + 4), someNodes(scaler + 3)) '4-4 7-4
        networkFunctions.AttachNeighbors(someNodes((12 * 4) + 10), someNodes(scaler + 4)) '5-10 7-2
        networkFunctions.AttachNeighbors(someNodes((12 * 4) + 4), someNodes(scaler + 12)) '5-4 7-1

        Return ConvertArrayToList(someNodes)

    End Function

    Public Function CreateSmallDenseNetwork() As List(Of Node)
        Dim networkFunctions As New Network
        networkFunctions.mShowBFSDebugMessages = mShowBFSDebugMessages
        Dim someNodes() As Node = networkFunctions.GenerateSomeNodesAsArray(12)

        networkFunctions.AttachNeighbors(someNodes(1), someNodes(2))
        networkFunctions.AttachNeighbors(someNodes(1), someNodes(3))
        networkFunctions.AttachNeighbors(someNodes(1), someNodes(5))
        networkFunctions.AttachNeighbors(someNodes(2), someNodes(5))
        networkFunctions.AttachNeighbors(someNodes(2), someNodes(6))
        networkFunctions.AttachNeighbors(someNodes(2), someNodes(7))
        networkFunctions.AttachNeighbors(someNodes(3), someNodes(4))
        networkFunctions.AttachNeighbors(someNodes(3), someNodes(5))
        networkFunctions.AttachNeighbors(someNodes(4), someNodes(5))
        networkFunctions.AttachNeighbors(someNodes(4), someNodes(10))
        networkFunctions.AttachNeighbors(someNodes(5), someNodes(8))
        networkFunctions.AttachNeighbors(someNodes(5), someNodes(9))
        networkFunctions.AttachNeighbors(someNodes(6), someNodes(7))
        networkFunctions.AttachNeighbors(someNodes(6), someNodes(8))
        networkFunctions.AttachNeighbors(someNodes(8), someNodes(11))
        networkFunctions.AttachNeighbors(someNodes(9), someNodes(10))
        networkFunctions.AttachNeighbors(someNodes(9), someNodes(11))
        networkFunctions.AttachNeighbors(someNodes(9), someNodes(12))
        networkFunctions.AttachNeighbors(someNodes(10), someNodes(12))
        networkFunctions.AttachNeighbors(someNodes(11), someNodes(12))

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
