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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnAddNumber = New System.Windows.Forms.Button()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstSortedNumbers = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(28, 53)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(254, 20)
        Me.txtInput.TabIndex = 0
        '
        'btnAddNumber
        '
        Me.btnAddNumber.Location = New System.Drawing.Point(28, 79)
        Me.btnAddNumber.Name = "btnAddNumber"
        Me.btnAddNumber.Size = New System.Drawing.Size(64, 30)
        Me.btnAddNumber.TabIndex = 1
        Me.btnAddNumber.Text = "Write"
        Me.btnAddNumber.UseVisualStyleBackColor = True
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(135, 318)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(64, 30)
        Me.btnRead.TabIndex = 2
        Me.btnRead.Text = "Sort"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstSortedNumbers
        '
        Me.lstSortedNumbers.FormattingEnabled = True
        Me.lstSortedNumbers.Location = New System.Drawing.Point(28, 139)
        Me.lstSortedNumbers.Name = "lstSortedNumbers"
        Me.lstSortedNumbers.Size = New System.Drawing.Size(171, 173)
        Me.lstSortedNumbers.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input Numbers:"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(28, 318)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 30)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Read"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 385)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstSortedNumbers)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnAddNumber)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnAddNumber As Button
    Friend WithEvents btnRead As Button
    Friend WithEvents lstSortedNumbers As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
End Class
