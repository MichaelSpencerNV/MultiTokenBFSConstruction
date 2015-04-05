Public Class Synchronizer
    Private mnodes As New List(Of Node)

    Public Sub AddNode(newNode As Node)
        mnodes.Add(newNode)
    End Sub

    Public Sub AddNodes(someNodes As List(Of Node))
        mnodes = someNodes
    End Sub

    Public Function ProcessNextRound(round As Integer) As Boolean
        Dim aNode As Node
        Dim didWork As Boolean

        For Each aNode In mnodes
            If aNode.BeginRound(round) = True Then
                didWork = True
            End If
        Next

        For Each aNode In mnodes
            Call aNode.EndRound(round)
        Next

        Return didWork
    End Function

    Public Sub AlgorithmComplete()

    End Sub


End Class
