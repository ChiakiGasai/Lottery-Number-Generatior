<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Num1 = New System.Windows.Forms.Label()
        Me.Num2 = New System.Windows.Forms.Label()
        Me.Num3 = New System.Windows.Forms.Label()
        Me.Num4 = New System.Windows.Forms.Label()
        Me.Num5 = New System.Windows.Forms.Label()
        Me.Num6 = New System.Windows.Forms.Label()
        Me.butgen = New System.Windows.Forms.Button()
        Me.butreset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Num1
        '
        Me.Num1.AutoSize = True
        Me.Num1.Location = New System.Drawing.Point(18, 14)
        Me.Num1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(57, 20)
        Me.Num1.TabIndex = 0
        Me.Num1.Text = "Label1"
        '
        'Num2
        '
        Me.Num2.AutoSize = True
        Me.Num2.Location = New System.Drawing.Point(86, 14)
        Me.Num2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(57, 20)
        Me.Num2.TabIndex = 1
        Me.Num2.Text = "Label1"
        '
        'Num3
        '
        Me.Num3.AutoSize = True
        Me.Num3.Location = New System.Drawing.Point(153, 14)
        Me.Num3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Num3.Name = "Num3"
        Me.Num3.Size = New System.Drawing.Size(57, 20)
        Me.Num3.TabIndex = 2
        Me.Num3.Text = "Label1"
        '
        'Num4
        '
        Me.Num4.AutoSize = True
        Me.Num4.Location = New System.Drawing.Point(220, 14)
        Me.Num4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Num4.Name = "Num4"
        Me.Num4.Size = New System.Drawing.Size(57, 20)
        Me.Num4.TabIndex = 3
        Me.Num4.Text = "Label1"
        '
        'Num5
        '
        Me.Num5.AutoSize = True
        Me.Num5.Location = New System.Drawing.Point(288, 14)
        Me.Num5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Num5.Name = "Num5"
        Me.Num5.Size = New System.Drawing.Size(57, 20)
        Me.Num5.TabIndex = 4
        Me.Num5.Text = "Label1"
        '
        'Num6
        '
        Me.Num6.AutoSize = True
        Me.Num6.Location = New System.Drawing.Point(356, 14)
        Me.Num6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Num6.Name = "Num6"
        Me.Num6.Size = New System.Drawing.Size(57, 20)
        Me.Num6.TabIndex = 5
        Me.Num6.Text = "Label1"
        '
        'butgen
        '
        Me.butgen.AutoSize = True
        Me.butgen.Location = New System.Drawing.Point(22, 78)
        Me.butgen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.butgen.Name = "butgen"
        Me.butgen.Size = New System.Drawing.Size(201, 35)
        Me.butgen.TabIndex = 6
        Me.butgen.Text = "Generate New Numbers"
        Me.butgen.UseVisualStyleBackColor = True
        '
        'butreset
        '
        Me.butreset.AutoSize = True
        Me.butreset.Location = New System.Drawing.Point(233, 78)
        Me.butreset.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.butreset.Name = "butreset"
        Me.butreset.Size = New System.Drawing.Size(112, 35)
        Me.butreset.TabIndex = 7
        Me.butreset.Text = "Reset"
        Me.butreset.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 127)
        Me.Controls.Add(Me.butreset)
        Me.Controls.Add(Me.butgen)
        Me.Controls.Add(Me.Num6)
        Me.Controls.Add(Me.Num5)
        Me.Controls.Add(Me.Num4)
        Me.Controls.Add(Me.Num3)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Random Number Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Num1 As Label
    Friend WithEvents Num2 As Label
    Friend WithEvents Num3 As Label
    Friend WithEvents Num4 As Label
    Friend WithEvents Num5 As Label
    Friend WithEvents Num6 As Label
    Friend WithEvents butgen As Button
    Friend WithEvents butreset As Button
End Class
