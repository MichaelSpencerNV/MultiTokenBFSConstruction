<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.txtTokenCount = New System.Windows.Forms.TextBox()
        Me.lblTokenCount = New System.Windows.Forms.Label()
        Me.optBinary = New System.Windows.Forms.RadioButton()
        Me.txtTreeLevels = New System.Windows.Forms.TextBox()
        Me.lblTreeLevels = New System.Windows.Forms.Label()
        Me.chkParallel = New System.Windows.Forms.CheckBox()
        Me.optTernary = New System.Windows.Forms.RadioButton()
        Me.optStar = New System.Windows.Forms.RadioButton()
        Me.optSmallSparseMesh = New System.Windows.Forms.RadioButton()
        Me.optSmallDenseMesh = New System.Windows.Forms.RadioButton()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.optLargeSparseMesh = New System.Windows.Forms.RadioButton()
        Me.optLargeDenseMesh = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(405, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 38)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Go"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(382, 536)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(529, 12)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox2.Size = New System.Drawing.Size(298, 536)
        Me.TextBox2.TabIndex = 2
        '
        'txtTokenCount
        '
        Me.txtTokenCount.Location = New System.Drawing.Point(405, 337)
        Me.txtTokenCount.Name = "txtTokenCount"
        Me.txtTokenCount.Size = New System.Drawing.Size(55, 20)
        Me.txtTokenCount.TabIndex = 3
        '
        'lblTokenCount
        '
        Me.lblTokenCount.AutoSize = True
        Me.lblTokenCount.Location = New System.Drawing.Point(405, 321)
        Me.lblTokenCount.Name = "lblTokenCount"
        Me.lblTokenCount.Size = New System.Drawing.Size(95, 13)
        Me.lblTokenCount.TabIndex = 4
        Me.lblTokenCount.Text = "Number of Tokens"
        '
        'optBinary
        '
        Me.optBinary.AutoSize = True
        Me.optBinary.Location = New System.Drawing.Point(405, 129)
        Me.optBinary.Name = "optBinary"
        Me.optBinary.Size = New System.Drawing.Size(54, 17)
        Me.optBinary.TabIndex = 5
        Me.optBinary.TabStop = True
        Me.optBinary.Text = "Binary"
        Me.optBinary.UseVisualStyleBackColor = True
        '
        'txtTreeLevels
        '
        Me.txtTreeLevels.Location = New System.Drawing.Point(405, 209)
        Me.txtTreeLevels.Name = "txtTreeLevels"
        Me.txtTreeLevels.Size = New System.Drawing.Size(94, 20)
        Me.txtTreeLevels.TabIndex = 6
        '
        'lblTreeLevels
        '
        Me.lblTreeLevels.AutoSize = True
        Me.lblTreeLevels.Location = New System.Drawing.Point(405, 193)
        Me.lblTreeLevels.Name = "lblTreeLevels"
        Me.lblTreeLevels.Size = New System.Drawing.Size(121, 13)
        Me.lblTreeLevels.TabIndex = 7
        Me.lblTreeLevels.Text = "Tree Levels/Star Nodes"
        '
        'chkParallel
        '
        Me.chkParallel.AutoSize = True
        Me.chkParallel.Location = New System.Drawing.Point(405, 363)
        Me.chkParallel.Name = "chkParallel"
        Me.chkParallel.Size = New System.Drawing.Size(60, 17)
        Me.chkParallel.TabIndex = 8
        Me.chkParallel.Text = "Parallel"
        Me.chkParallel.UseVisualStyleBackColor = True
        '
        'optTernary
        '
        Me.optTernary.AutoSize = True
        Me.optTernary.Location = New System.Drawing.Point(405, 151)
        Me.optTernary.Name = "optTernary"
        Me.optTernary.Size = New System.Drawing.Size(61, 17)
        Me.optTernary.TabIndex = 9
        Me.optTernary.TabStop = True
        Me.optTernary.Text = "Ternary"
        Me.optTernary.UseVisualStyleBackColor = True
        '
        'optStar
        '
        Me.optStar.AutoSize = True
        Me.optStar.Location = New System.Drawing.Point(405, 173)
        Me.optStar.Name = "optStar"
        Me.optStar.Size = New System.Drawing.Size(44, 17)
        Me.optStar.TabIndex = 10
        Me.optStar.TabStop = True
        Me.optStar.Text = "Star"
        Me.optStar.UseVisualStyleBackColor = True
        '
        'optSmallSparseMesh
        '
        Me.optSmallSparseMesh.AutoSize = True
        Me.optSmallSparseMesh.Location = New System.Drawing.Point(405, 79)
        Me.optSmallSparseMesh.Name = "optSmallSparseMesh"
        Me.optSmallSparseMesh.Size = New System.Drawing.Size(115, 17)
        Me.optSmallSparseMesh.TabIndex = 11
        Me.optSmallSparseMesh.TabStop = True
        Me.optSmallSparseMesh.Text = "Small Sparse Mesh"
        Me.optSmallSparseMesh.UseVisualStyleBackColor = True
        '
        'optSmallDenseMesh
        '
        Me.optSmallDenseMesh.AutoSize = True
        Me.optSmallDenseMesh.Location = New System.Drawing.Point(405, 57)
        Me.optSmallDenseMesh.Name = "optSmallDenseMesh"
        Me.optSmallDenseMesh.Size = New System.Drawing.Size(113, 17)
        Me.optSmallDenseMesh.TabIndex = 12
        Me.optSmallDenseMesh.TabStop = True
        Me.optSmallDenseMesh.Text = "Small Dense Mesh"
        Me.optSmallDenseMesh.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Location = New System.Drawing.Point(465, 335)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(34, 23)
        Me.btnPlus.TabIndex = 13
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'optLargeSparseMesh
        '
        Me.optLargeSparseMesh.AutoSize = True
        Me.optLargeSparseMesh.Location = New System.Drawing.Point(405, 35)
        Me.optLargeSparseMesh.Name = "optLargeSparseMesh"
        Me.optLargeSparseMesh.Size = New System.Drawing.Size(117, 17)
        Me.optLargeSparseMesh.TabIndex = 14
        Me.optLargeSparseMesh.TabStop = True
        Me.optLargeSparseMesh.Text = "Large Sparse Mesh"
        Me.optLargeSparseMesh.UseVisualStyleBackColor = True
        '
        'optLargeDenseMesh
        '
        Me.optLargeDenseMesh.AutoSize = True
        Me.optLargeDenseMesh.Location = New System.Drawing.Point(405, 13)
        Me.optLargeDenseMesh.Name = "optLargeDenseMesh"
        Me.optLargeDenseMesh.Size = New System.Drawing.Size(115, 17)
        Me.optLargeDenseMesh.TabIndex = 15
        Me.optLargeDenseMesh.TabStop = True
        Me.optLargeDenseMesh.Text = "Large Dense Mesh"
        Me.optLargeDenseMesh.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 559)
        Me.Controls.Add(Me.optLargeDenseMesh)
        Me.Controls.Add(Me.optLargeSparseMesh)
        Me.Controls.Add(Me.btnPlus)
        Me.Controls.Add(Me.optSmallDenseMesh)
        Me.Controls.Add(Me.optSmallSparseMesh)
        Me.Controls.Add(Me.optStar)
        Me.Controls.Add(Me.optTernary)
        Me.Controls.Add(Me.chkParallel)
        Me.Controls.Add(Me.lblTreeLevels)
        Me.Controls.Add(Me.txtTreeLevels)
        Me.Controls.Add(Me.optBinary)
        Me.Controls.Add(Me.lblTokenCount)
        Me.Controls.Add(Me.txtTokenCount)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Multi Token BFS Simulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents txtTokenCount As System.Windows.Forms.TextBox
    Friend WithEvents lblTokenCount As System.Windows.Forms.Label
    Friend WithEvents optBinary As System.Windows.Forms.RadioButton
    Friend WithEvents txtTreeLevels As System.Windows.Forms.TextBox
    Friend WithEvents lblTreeLevels As System.Windows.Forms.Label
    Friend WithEvents chkParallel As System.Windows.Forms.CheckBox
    Friend WithEvents optTernary As System.Windows.Forms.RadioButton
    Friend WithEvents optStar As System.Windows.Forms.RadioButton
    Friend WithEvents optSmallSparseMesh As System.Windows.Forms.RadioButton
    Friend WithEvents optSmallDenseMesh As System.Windows.Forms.RadioButton
    Friend WithEvents btnPlus As System.Windows.Forms.Button
    Friend WithEvents optLargeSparseMesh As System.Windows.Forms.RadioButton
    Friend WithEvents optLargeDenseMesh As System.Windows.Forms.RadioButton

End Class
