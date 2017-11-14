<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAirplane
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
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LocationBox = New System.Windows.Forms.TextBox()
        Me.AddPassengerButton = New System.Windows.Forms.Button()
        Me.DeletePassengerButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SeatListBox = New System.Windows.Forms.ListBox()
        Me.WaitListBox = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.NameBox.Location = New System.Drawing.Point(88, 32)
        Me.NameBox.Name = "TextBox1"
        Me.NameBox.Size = New System.Drawing.Size(100, 20)
        Me.NameBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.Location = New System.Drawing.Point(33, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.Location = New System.Drawing.Point(294, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seat:"
        '
        'TextBox3
        '
        Me.LocationBox.Location = New System.Drawing.Point(341, 32)
        Me.LocationBox.Name = "TextBox3"
        Me.LocationBox.Size = New System.Drawing.Size(43, 20)
        Me.LocationBox.TabIndex = 4
        '
        'Button1
        '
        Me.AddPassengerButton.Location = New System.Drawing.Point(49, 88)
        Me.AddPassengerButton.Name = "Button1"
        Me.AddPassengerButton.Size = New System.Drawing.Size(93, 47)
        Me.AddPassengerButton.TabIndex = 5
        Me.AddPassengerButton.Text = "Add Passenger"
        Me.AddPassengerButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.DeletePassengerButton.Location = New System.Drawing.Point(49, 174)
        Me.DeletePassengerButton.Name = "Button2"
        Me.DeletePassengerButton.Size = New System.Drawing.Size(93, 43)
        Me.DeletePassengerButton.TabIndex = 6
        Me.DeletePassengerButton.Text = "Delete Passenger"
        Me.DeletePassengerButton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(296, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "(1A, 1B, 1C, 1D, 2A, ... , 10D)"
        '
        'ListBox1
        '
        Me.SeatListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.SeatListBox.FormattingEnabled = True
        Me.SeatListBox.ItemHeight = 29
        Me.SeatListBox.Location = New System.Drawing.Point(297, 88)
        Me.SeatListBox.Name = "ListBox1"
        Me.SeatListBox.Size = New System.Drawing.Size(140, 294)
        Me.SeatListBox.TabIndex = 11
        '
        'ListBox2
        '
        Me.WaitListBox.FormattingEnabled = True
        Me.WaitListBox.Location = New System.Drawing.Point(299, 431)
        Me.WaitListBox.Name = "ListBox2"
        Me.WaitListBox.Size = New System.Drawing.Size(138, 134)
        Me.WaitListBox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(344, 400)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "waitlist"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 582)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.WaitListBox)
        Me.Controls.Add(Me.SeatListBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DeletePassengerButton)
        Me.Controls.Add(Me.AddPassengerButton)
        Me.Controls.Add(Me.LocationBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NameBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NameBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LocationBox As System.Windows.Forms.TextBox
    Friend WithEvents AddPassengerButton As System.Windows.Forms.Button
    Friend WithEvents DeletePassengerButton As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SeatListBox As System.Windows.Forms.ListBox
    Friend WithEvents WaitListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
