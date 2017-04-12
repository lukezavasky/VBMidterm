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
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblPrint = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(35, 68)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(90, 13)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Amount Invested:"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(35, 141)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(81, 13)
        Me.lblYears.TabIndex = 1
        Me.lblYears.Text = "Years Invested:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(153, 65)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 2
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(153, 138)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(100, 20)
        Me.txtYear.TabIndex = 3
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(153, 218)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 4
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(130, 271)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(137, 13)
        Me.lblRate.TabIndex = 5
        Me.lblRate.Text = "Interest rate is 10% per year"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Location = New System.Drawing.Point(141, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(126, 13)
        Me.lblHeader.TabIndex = 6
        Me.lblHeader.Text = "Simple Interest Calculator"
        '
        'lblPrint
        '
        Me.lblPrint.AutoSize = True
        Me.lblPrint.Location = New System.Drawing.Point(114, 314)
        Me.lblPrint.Name = "lblPrint"
        Me.lblPrint.Size = New System.Drawing.Size(79, 13)
        Me.lblPrint.TabIndex = 7
        Me.lblPrint.Text = "Interest Earned"
        Me.lblPrint.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 361)
        Me.Controls.Add(Me.lblPrint)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblAmount)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAmount As Label
    Friend WithEvents lblYears As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtYear As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblRate As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblPrint As Label
End Class
