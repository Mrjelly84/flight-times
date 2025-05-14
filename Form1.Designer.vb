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
        Me.components = New System.ComponentModel.Container()
        Me.cboDepartureAirport = New System.Windows.Forms.ComboBox()
        Me.cboArrivalAirport = New System.Windows.Forms.ComboBox()
        Me.txtDepartureTime = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblArriveWhen = New System.Windows.Forms.Label()
        Me.dtpDepartureDate = New System.Windows.Forms.DateTimePicker()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDepartureAirport
        '
        Me.cboDepartureAirport.FormattingEnabled = True
        Me.cboDepartureAirport.Location = New System.Drawing.Point(33, 34)
        Me.cboDepartureAirport.Name = "cboDepartureAirport"
        Me.cboDepartureAirport.Size = New System.Drawing.Size(121, 21)
        Me.cboDepartureAirport.TabIndex = 0
        '
        'cboArrivalAirport
        '
        Me.cboArrivalAirport.FormattingEnabled = True
        Me.cboArrivalAirport.Location = New System.Drawing.Point(238, 34)
        Me.cboArrivalAirport.Name = "cboArrivalAirport"
        Me.cboArrivalAirport.Size = New System.Drawing.Size(121, 21)
        Me.cboArrivalAirport.TabIndex = 1
        '
        'txtDepartureTime
        '
        Me.txtDepartureTime.Location = New System.Drawing.Point(33, 174)
        Me.txtDepartureTime.Name = "txtDepartureTime"
        Me.txtDepartureTime.Size = New System.Drawing.Size(100, 20)
        Me.txtDepartureTime.TabIndex = 3
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(167, 215)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 4
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Depart from"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Departure Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Departure Time"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(235, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Arrive at:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Arrival Date/Time:"
        '
        'lblArriveWhen
        '
        Me.lblArriveWhen.AutoSize = True
        Me.lblArriveWhen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblArriveWhen.Location = New System.Drawing.Point(239, 116)
        Me.lblArriveWhen.Name = "lblArriveWhen"
        Me.lblArriveWhen.Size = New System.Drawing.Size(120, 67)
        Me.lblArriveWhen.TabIndex = 10
        Me.lblArriveWhen.Text = "                                     " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "                  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'dtpDepartureDate
        '
        Me.dtpDepartureDate.CustomFormat = "14/05/2025"
        Me.dtpDepartureDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDepartureDate.Location = New System.Drawing.Point(33, 116)
        Me.dtpDepartureDate.Name = "dtpDepartureDate"
        Me.dtpDepartureDate.Size = New System.Drawing.Size(179, 20)
        Me.dtpDepartureDate.TabIndex = 11
        Me.dtpDepartureDate.Value = New Date(2025, 5, 14, 0, 0, 0, 0)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 256)
        Me.Controls.Add(Me.dtpDepartureDate)
        Me.Controls.Add(Me.lblArriveWhen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtDepartureTime)
        Me.Controls.Add(Me.cboArrivalAirport)
        Me.Controls.Add(Me.cboDepartureAirport)
        Me.Name = "Form1"
        Me.Text = "Flight times"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboDepartureAirport As ComboBox
    Friend WithEvents cboArrivalAirport As ComboBox
    Friend WithEvents txtDepartureTime As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblArriveWhen As Label
    Friend WithEvents dtpDepartureDate As DateTimePicker
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
