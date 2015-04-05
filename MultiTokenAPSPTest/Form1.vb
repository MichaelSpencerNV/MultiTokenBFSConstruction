Public Class Form1

    Private Sub DisplayInitialNetwork(someNodes As List(Of Node))
        Dim iLoop As Integer
        Dim networkNeighbors As List(Of Node.networkNeighbor)
        Dim neighbor As Node.networkNeighbor
        For iLoop = 0 To someNodes.Count - 1
            TextBox1.Text = TextBox1.Text & "node " & someNodes(iLoop).NodeID & "="
            networkNeighbors = someNodes(iLoop).MyNetworkNeighbors
            For Each neighbor In networkNeighbors
                TextBox1.Text = TextBox1.Text & " " & neighbor.theNode.NodeID
            Next neighbor
            TextBox1.Text = TextBox1.Text & vbNewLine
        Next iLoop
    End Sub

    Private Function PerformSimulation(someNodes As List(Of Node), tokenCount As Integer, parallel As Boolean) As Integer
        Dim roundCount As Integer = 0
        Dim didWork As Boolean = True
        Dim syncer As New Synchronizer
        syncer.AddNodes(someNodes)

        Dim iLoop As Integer
        If parallel = False Then
            For iLoop = 1 To CInt(txtTokenCount.Text)
                someNodes(0).tokenTracking.ReceiveACreateBFSToken(roundCount)
            Next
        Else
            For iLoop = 0 To CInt(someNodes.Count) - 1
                someNodes(iLoop).tokenTracking.ReceiveACreateBFSToken(roundCount)
                someNodes(iLoop).tokenTracking.IsParallel = True
            Next
        End If

        Do While didWork = True
            roundCount += 1
            didWork = syncer.ProcessNextRound(roundCount)
            Threading.Thread.Sleep(0)
        Loop

        Return roundCount
    End Function

    Private Sub DisplayResults(someNodes As List(Of Node), roundCount As Integer)
        Dim BFSNeighbors As List(Of BFSFormation.BFSNeighbor)
        Dim BFSTreeID As Integer = 1
        Dim neighborLoop As Integer
        Dim round As Integer

        'For BFSTreeID = 1 To someNodes.Count
        TextBox1.Text = TextBox1.Text & "Tree = " & BFSTreeID & vbNewLine
        For neighborLoop = 0 To someNodes.Count - 1
            BFSNeighbors = someNodes(neighborLoop).myBFSTree.MyBFSNeighbors(BFSTreeID)
            Dim neighbor As BFSFormation.BFSNeighbor

            TextBox1.Text = TextBox1.Text & "node " & someNodes(neighborLoop).NodeID & "="
            For Each neighbor In BFSNeighbors
                TextBox1.Text = TextBox1.Text & " " & neighbor.theNode.NodeID
            Next neighbor
            TextBox1.Text = TextBox1.Text & vbNewLine

        Next neighborLoop
        TextBox1.Text = TextBox1.Text & vbNewLine & vbNewLine
        'Next BFSTreeID

        Dim requestCount As Integer
        Dim totalRequests As Integer

        For BFSTreeID = 0 To someNodes.Count - 1
            'For round = 1 To roundCount
            'TextBox2.Text = TextBox2.Text & "Node " & BFSTreeID & ". round " & round & " BFSRequestCount = " & someNodes(BFSTreeID).myBFSTree.GetBFSRequestCounts(round) & vbNewLine
            requestCount += someNodes(BFSTreeID).myBFSTree.GetBFSRequestCounts '(round)
            'Next
        Next

        TextBox2.Text = TextBox2.Text & roundCount & " rounds" & vbNewLine
        'TextBox2.Text = TextBox2.Text & "Avg Requests per round per node = " & requestCount / totalRequests
        TextBox2.Text = TextBox2.Text & "Avg Requests per round per node = " & requestCount / roundCount / someNodes.Count

    End Sub

    Private Function CreateTestNetwork() As List(Of Node)
        Dim networkFunctions As New Network
        Dim someNodes As List(Of Node) = networkFunctions.GenerateSomeNodes(5)
        networkFunctions.AttachNeighbors(someNodes, networkFunctions.GetNodeByID(someNodes, 1), networkFunctions.GetNodeByID(someNodes, 2))
        networkFunctions.AttachNeighbors(someNodes, networkFunctions.GetNodeByID(someNodes, 1), networkFunctions.GetNodeByID(someNodes, 4))
        networkFunctions.AttachNeighbors(someNodes, networkFunctions.GetNodeByID(someNodes, 1), networkFunctions.GetNodeByID(someNodes, 5))
        networkFunctions.AttachNeighbors(someNodes, networkFunctions.GetNodeByID(someNodes, 2), networkFunctions.GetNodeByID(someNodes, 3))
        networkFunctions.AttachNeighbors(someNodes, networkFunctions.GetNodeByID(someNodes, 2), networkFunctions.GetNodeByID(someNodes, 4))
        networkFunctions.AttachNeighbors(someNodes, networkFunctions.GetNodeByID(someNodes, 3), networkFunctions.GetNodeByID(someNodes, 4))
        networkFunctions.AttachNeighbors(someNodes, networkFunctions.GetNodeByID(someNodes, 4), networkFunctions.GetNodeByID(someNodes, 5))
        Return someNodes
    End Function

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""

        Dim networkFunctions As New Network
        Dim someNodes As List(Of Node) = CreateTestNetwork()

        If optBinary.Checked = True Then
            Dim Tree As New BinaryTreeCreator
            Tree.mShowBFSDebugMessages = False
            someNodes = Tree.CreateTreeNetwork(CInt(txtTreeLevels.Text))
        ElseIf optTernary.Checked = True Then
            Dim Tree As New TernaryTreeCreator
            Tree.mShowBFSDebugMessages = False
            someNodes = Tree.CreateTreeNetwork(CInt(txtTreeLevels.Text))
        ElseIf optStar.Checked = True Then
            Dim Star As New StarNetwork
            someNodes = Star.CreateStarNetwork(CInt(txtTreeLevels.Text))
        ElseIf optSmallSparseMesh.Checked = True Then
            Dim mesh As New MeshNetwork
            someNodes = mesh.CreateSmallSparseNetwork()
        ElseIf optSmallDenseMesh.Checked = True Then
            Dim mesh As New MeshNetwork
            someNodes = mesh.CreateSmallDenseNetwork()
        ElseIf optLargeSparseMesh.Checked = True Then
            Dim mesh As New MeshNetwork
            someNodes = mesh.CreateLargeSparseNetwork()
        ElseIf optLargeDenseMesh.Checked = True Then
            Dim mesh As New MeshNetwork
            someNodes = mesh.CreateLargeDenseNetwork()
        Else
            someNodes = networkFunctions.GenerateSomeNodes(20)
            someNodes = networkFunctions.ConnectNodesRandomly(someNodes, 6, 5)
            someNodes = networkFunctions.ConnectNodesRandomly(someNodes, 30, 4)
        End If

        Application.DoEvents()
        Dim roundCount As Integer = PerformSimulation(someNodes, CInt(txtTokenCount.Text), chkParallel.Checked)
        Call DisplayInitialNetwork(someNodes)
        Call DisplayResults(someNodes, roundCount)
    End Sub

    Private Sub chkParallel_CheckedChanged(sender As Object, e As EventArgs) Handles chkParallel.CheckedChanged
        If txtTokenCount.Text = "" Then
            txtTokenCount.Text = "0"
        End If
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If IsNumeric(txtTokenCount.Text) = True Then
            txtTokenCount.Text = CStr(CInt(txtTokenCount.Text) + 1)
        End If
    End Sub
End Class
