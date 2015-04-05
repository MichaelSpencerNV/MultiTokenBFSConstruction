Public Class Node
    Private minternalID As Integer
    Private mNetworkNeighbors As New List(Of networkNeighbor)
    'Private msynchronizer As Synchronizer
    'Private mbfsCompleteByTreeID(20) As Boolean
    'Private mConvergeCastSent As New Collection

    Public myBFSTree As New BFSTree
    Public tokenTracking As New TokenControl

    Public Structure networkNeighbor
        Public theNode As Node
    End Structure

    Public Sub New(newID As Integer, mShowBFSFormationDebugMessages As Boolean)
        minternalID = newID
        tokenTracking.theNode = Me
        myBFSTree.theNode = Me
        myBFSTree.mshowDebugMessages = mShowBFSFormationDebugMessages
    End Sub

    'Public Sub SetSynchronizer(sync As Synchronizer)
    '    msynchronizer = sync
    'End Sub

    Public Function EndRound(round As Integer) As Boolean
        Return tokenTracking.ProcessEndOfRound(round)
    End Function

    Public Function BeginRound(round As Integer) As Boolean
        Dim bfsWork As Boolean = myBFSTree.ProcessRound(round)
        'Dim tokenWork As Boolean = tokenTracking.ProcessRound(round)
        Call tokenTracking.ProcessRound(round)

        Return bfsWork
        'Return tokenWork OrElse bfsWork
    End Function

    Public ReadOnly Property NetworkNeighborCount As Integer
        Get
            Return mNetworkNeighbors.Count
        End Get
    End Property

    Public Sub SetNodeAsNetworkNeighbor(newNeighborNode As Node)
        Dim newNeighbor As New networkNeighbor
        newNeighbor.theNode = newNeighborNode
        mNetworkNeighbors.Add(newNeighbor)
    End Sub

    Public ReadOnly Property NodeID As Integer
        Get
            Return minternalID
        End Get
    End Property

    Public Function MyNetworkNeighbors() As List(Of networkNeighbor)
        Return mNetworkNeighbors
    End Function

End Class
