<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompare
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
        Me.panel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCompare = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImageDes = New System.Windows.Forms.Button()
        Me.btnImageSrc = New System.Windows.Forms.Button()
        Me.destinationLabel = New System.Windows.Forms.Label()
        Me.destinationPictureBox = New System.Windows.Forms.PictureBox()
        Me.sourceLabel = New System.Windows.Forms.Label()
        Me.sourcePictureBox = New System.Windows.Forms.PictureBox()
        Me.panel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.destinationPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sourcePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel
        '
        Me.panel.Controls.Add(Me.GroupBox1)
        Me.panel.Controls.Add(Me.btnImageDes)
        Me.panel.Controls.Add(Me.btnImageSrc)
        Me.panel.Controls.Add(Me.destinationLabel)
        Me.panel.Controls.Add(Me.destinationPictureBox)
        Me.panel.Controls.Add(Me.sourceLabel)
        Me.panel.Controls.Add(Me.sourcePictureBox)
        Me.panel.Location = New System.Drawing.Point(12, 9)
        Me.panel.Name = "panel"
        Me.panel.Size = New System.Drawing.Size(517, 335)
        Me.panel.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCompare)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 58)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Result"
        '
        'btnCompare
        '
        Me.btnCompare.Location = New System.Drawing.Point(6, 21)
        Me.btnCompare.Name = "btnCompare"
        Me.btnCompare.Size = New System.Drawing.Size(75, 23)
        Me.btnCompare.TabIndex = 16
        Me.btnCompare.Text = "Comapre"
        Me.btnCompare.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Difference (%): "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(313, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "The images are identical."
        '
        'btnImageDes
        '
        Me.btnImageDes.Location = New System.Drawing.Point(325, 225)
        Me.btnImageDes.Name = "btnImageDes"
        Me.btnImageDes.Size = New System.Drawing.Size(75, 23)
        Me.btnImageDes.TabIndex = 19
        Me.btnImageDes.Text = "Image 2"
        Me.btnImageDes.UseVisualStyleBackColor = True
        '
        'btnImageSrc
        '
        Me.btnImageSrc.Location = New System.Drawing.Point(95, 226)
        Me.btnImageSrc.Name = "btnImageSrc"
        Me.btnImageSrc.Size = New System.Drawing.Size(75, 23)
        Me.btnImageSrc.TabIndex = 18
        Me.btnImageSrc.Text = "Image 1"
        Me.btnImageSrc.UseVisualStyleBackColor = True
        '
        'destinationLabel
        '
        Me.destinationLabel.AutoSize = True
        Me.destinationLabel.Location = New System.Drawing.Point(270, 4)
        Me.destinationLabel.Name = "destinationLabel"
        Me.destinationLabel.Size = New System.Drawing.Size(60, 13)
        Me.destinationLabel.TabIndex = 15
        Me.destinationLabel.Text = "Destination"
        '
        'destinationPictureBox
        '
        Me.destinationPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.destinationPictureBox.Location = New System.Drawing.Point(267, 20)
        Me.destinationPictureBox.Name = "destinationPictureBox"
        Me.destinationPictureBox.Size = New System.Drawing.Size(180, 199)
        Me.destinationPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.destinationPictureBox.TabIndex = 14
        Me.destinationPictureBox.TabStop = False
        '
        'sourceLabel
        '
        Me.sourceLabel.AutoSize = True
        Me.sourceLabel.Location = New System.Drawing.Point(59, 4)
        Me.sourceLabel.Name = "sourceLabel"
        Me.sourceLabel.Size = New System.Drawing.Size(41, 13)
        Me.sourceLabel.TabIndex = 13
        Me.sourceLabel.Text = "Source"
        '
        'sourcePictureBox
        '
        Me.sourcePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.sourcePictureBox.Location = New System.Drawing.Point(56, 20)
        Me.sourcePictureBox.Name = "sourcePictureBox"
        Me.sourcePictureBox.Size = New System.Drawing.Size(180, 199)
        Me.sourcePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.sourcePictureBox.TabIndex = 12
        Me.sourcePictureBox.TabStop = False
        '
        'frmCompare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 351)
        Me.Controls.Add(Me.panel)
        Me.Name = "frmCompare"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Compare Image in .NET"
        Me.panel.ResumeLayout(False)
        Me.panel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.destinationPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sourcePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImageDes As System.Windows.Forms.Button
    Friend WithEvents btnImageSrc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCompare As System.Windows.Forms.Button
    Private WithEvents destinationLabel As System.Windows.Forms.Label
    Private WithEvents destinationPictureBox As System.Windows.Forms.PictureBox
    Private WithEvents sourceLabel As System.Windows.Forms.Label
    Private WithEvents sourcePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
