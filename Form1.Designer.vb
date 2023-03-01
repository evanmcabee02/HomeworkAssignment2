<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayrollCalculator
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPayrollCalculator = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPaycheckCalculation = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFICAAmount = New System.Windows.Forms.Label()
        Me.lblFederalAmount = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStateAmount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNetPaycheckIncome = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HomeworkAssignment2.My.Resources.Resources.payroll
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(362, 239)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblPayrollCalculator
        '
        Me.lblPayrollCalculator.AutoSize = True
        Me.lblPayrollCalculator.Font = New System.Drawing.Font("Segoe UI Black", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrollCalculator.Location = New System.Drawing.Point(402, 29)
        Me.lblPayrollCalculator.Name = "lblPayrollCalculator"
        Me.lblPayrollCalculator.Size = New System.Drawing.Size(368, 54)
        Me.lblPayrollCalculator.TabIndex = 1
        Me.lblPayrollCalculator.Text = "Payroll Calculator"
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompute.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCompute.Location = New System.Drawing.Point(122, 321)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(151, 41)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "Compute Taxes"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(335, 321)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(151, 41)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(552, 321)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblPaycheckCalculation
        '
        Me.lblPaycheckCalculation.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaycheckCalculation.Location = New System.Drawing.Point(460, 108)
        Me.lblPaycheckCalculation.Name = "lblPaycheckCalculation"
        Me.lblPaycheckCalculation.Size = New System.Drawing.Size(219, 104)
        Me.lblPaycheckCalculation.TabIndex = 6
        Me.lblPaycheckCalculation.Text = "Paycheck Calculation"
        Me.lblPaycheckCalculation.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(491, 269)
        Me.txtGrossPay.Multiline = True
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(112, 36)
        Me.txtGrossPay.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 267)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 38)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Enter Gross Pay:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(117, 390)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 28)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "FICA:"
        '
        'lblFICAAmount
        '
        Me.lblFICAAmount.AutoSize = True
        Me.lblFICAAmount.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICAAmount.Location = New System.Drawing.Point(187, 390)
        Me.lblFICAAmount.Name = "lblFICAAmount"
        Me.lblFICAAmount.Size = New System.Drawing.Size(46, 28)
        Me.lblFICAAmount.TabIndex = 11
        Me.lblFICAAmount.Text = "123"
        '
        'lblFederalAmount
        '
        Me.lblFederalAmount.AutoSize = True
        Me.lblFederalAmount.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFederalAmount.Location = New System.Drawing.Point(452, 390)
        Me.lblFederalAmount.Name = "lblFederalAmount"
        Me.lblFederalAmount.Size = New System.Drawing.Size(48, 28)
        Me.lblFederalAmount.TabIndex = 13
        Me.lblFederalAmount.Text = "456"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 390)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 28)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Federal Tax:"
        '
        'lblStateAmount
        '
        Me.lblStateAmount.AutoSize = True
        Me.lblStateAmount.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateAmount.Location = New System.Drawing.Point(662, 390)
        Me.lblStateAmount.Name = "lblStateAmount"
        Me.lblStateAmount.Size = New System.Drawing.Size(48, 28)
        Me.lblStateAmount.TabIndex = 15
        Me.lblStateAmount.Text = "789"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Black", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(547, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 28)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "State Tax:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(185, 444)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(274, 32)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Net Paycheck Income:"
        '
        'lblNetPaycheckIncome
        '
        Me.lblNetPaycheckIncome.AutoSize = True
        Me.lblNetPaycheckIncome.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPaycheckIncome.Location = New System.Drawing.Point(545, 444)
        Me.lblNetPaycheckIncome.Name = "lblNetPaycheckIncome"
        Me.lblNetPaycheckIncome.Size = New System.Drawing.Size(134, 32)
        Me.lblNetPaycheckIncome.TabIndex = 17
        Me.lblNetPaycheckIncome.Text = "$12345.67"
        '
        'frmPayrollCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 508)
        Me.Controls.Add(Me.lblNetPaycheckIncome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblStateAmount)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFederalAmount)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblFICAAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblPaycheckCalculation)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblPayrollCalculator)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmPayrollCalculator"
        Me.Text = "Payroll Every Two Weeks"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblPayrollCalculator As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPaycheckCalculation As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFICAAmount As Label
    Friend WithEvents lblFederalAmount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblStateAmount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNetPaycheckIncome As Label
End Class
