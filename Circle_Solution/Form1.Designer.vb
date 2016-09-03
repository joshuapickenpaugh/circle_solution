<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDiameter = New System.Windows.Forms.TextBox()
        Me.lblCircumference = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(149, 132)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'txtDiameter
        '
        Me.txtDiameter.Location = New System.Drawing.Point(26, 52)
        Me.txtDiameter.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiameter.Name = "txtDiameter"
        Me.txtDiameter.Size = New System.Drawing.Size(114, 24)
        Me.txtDiameter.TabIndex = 1
        '
        'lblCircumference
        '
        Me.lblCircumference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCircumference.Location = New System.Drawing.Point(200, 52)
        Me.lblCircumference.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCircumference.Name = "lblCircumference"
        Me.lblCircumference.Size = New System.Drawing.Size(114, 24)
        Me.lblCircumference.TabIndex = 2
        Me.lblCircumference.Text = " "
        Me.lblCircumference.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Diameter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(197, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Circumference:"
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(393, 17)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(114, 42)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(393, 65)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(114, 42)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 353)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCircumference)
        Me.Controls.Add(Me.txtDiameter)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circle Circumference"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtDiameter As TextBox
    Friend WithEvents lblCircumference As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
