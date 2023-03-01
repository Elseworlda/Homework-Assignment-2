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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pctPayroll = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.txtGrossPay = New System.Windows.Forms.TextBox()
        Me.btnComputeTaxes = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFICA = New System.Windows.Forms.Label()
        Me.lblFederalTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblFICAAmount = New System.Windows.Forms.Label()
        Me.lblFederalTaxAmount = New System.Windows.Forms.Label()
        Me.lblStateTaxAmount = New System.Windows.Forms.Label()
        Me.lblNetIncome = New System.Windows.Forms.Label()
        Me.lblNetIncomeAmount = New System.Windows.Forms.Label()
        CType(Me.pctPayroll, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pctPayroll
        '
        Me.pctPayroll.BackgroundImage = CType(resources.GetObject("pctPayroll.BackgroundImage"), System.Drawing.Image)
        Me.pctPayroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctPayroll.Location = New System.Drawing.Point(4, 3)
        Me.pctPayroll.Name = "pctPayroll"
        Me.pctPayroll.Size = New System.Drawing.Size(273, 188)
        Me.pctPayroll.TabIndex = 0
        Me.pctPayroll.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(402, 21)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(335, 46)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Payroll Calculator"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(489, 113)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(163, 72)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Payroll " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Calculation"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.Location = New System.Drawing.Point(134, 214)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(249, 36)
        Me.lblGrossPay.TabIndex = 3
        Me.lblGrossPay.Text = "Enter Gross Pay: "
        '
        'txtGrossPay
        '
        Me.txtGrossPay.Location = New System.Drawing.Point(505, 227)
        Me.txtGrossPay.Name = "txtGrossPay"
        Me.txtGrossPay.Size = New System.Drawing.Size(95, 22)
        Me.txtGrossPay.TabIndex = 4
        '
        'btnComputeTaxes
        '
        Me.btnComputeTaxes.Location = New System.Drawing.Point(122, 281)
        Me.btnComputeTaxes.Name = "btnComputeTaxes"
        Me.btnComputeTaxes.Size = New System.Drawing.Size(122, 50)
        Me.btnComputeTaxes.TabIndex = 5
        Me.btnComputeTaxes.Text = "Compute Taxes"
        Me.btnComputeTaxes.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(350, 281)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 50)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(591, 281)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(115, 50)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFICA
        '
        Me.lblFICA.AutoSize = True
        Me.lblFICA.Location = New System.Drawing.Point(119, 350)
        Me.lblFICA.Name = "lblFICA"
        Me.lblFICA.Size = New System.Drawing.Size(41, 17)
        Me.lblFICA.TabIndex = 8
        Me.lblFICA.Text = "FICA:"
        '
        'lblFederalTax
        '
        Me.lblFederalTax.AutoSize = True
        Me.lblFederalTax.Location = New System.Drawing.Point(347, 350)
        Me.lblFederalTax.Name = "lblFederalTax"
        Me.lblFederalTax.Size = New System.Drawing.Size(87, 17)
        Me.lblFederalTax.TabIndex = 9
        Me.lblFederalTax.Text = "Federal Tax:"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Location = New System.Drawing.Point(588, 350)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(72, 17)
        Me.lblStateTax.TabIndex = 10
        Me.lblStateTax.Text = "State Tax:"
        '
        'lblFICAAmount
        '
        Me.lblFICAAmount.AutoSize = True
        Me.lblFICAAmount.Location = New System.Drawing.Point(203, 350)
        Me.lblFICAAmount.Name = "lblFICAAmount"
        Me.lblFICAAmount.Size = New System.Drawing.Size(24, 17)
        Me.lblFICAAmount.TabIndex = 11
        Me.lblFICAAmount.Text = "$0"
        '
        'lblFederalTaxAmount
        '
        Me.lblFederalTaxAmount.AutoSize = True
        Me.lblFederalTaxAmount.Location = New System.Drawing.Point(462, 350)
        Me.lblFederalTaxAmount.Name = "lblFederalTaxAmount"
        Me.lblFederalTaxAmount.Size = New System.Drawing.Size(24, 17)
        Me.lblFederalTaxAmount.TabIndex = 12
        Me.lblFederalTaxAmount.Text = "$0"
        '
        'lblStateTaxAmount
        '
        Me.lblStateTaxAmount.AutoSize = True
        Me.lblStateTaxAmount.Location = New System.Drawing.Point(695, 350)
        Me.lblStateTaxAmount.Name = "lblStateTaxAmount"
        Me.lblStateTaxAmount.Size = New System.Drawing.Size(24, 17)
        Me.lblStateTaxAmount.TabIndex = 13
        Me.lblStateTaxAmount.Text = "$0"
        '
        'lblNetIncome
        '
        Me.lblNetIncome.AutoSize = True
        Me.lblNetIncome.Location = New System.Drawing.Point(263, 407)
        Me.lblNetIncome.Name = "lblNetIncome"
        Me.lblNetIncome.Size = New System.Drawing.Size(148, 17)
        Me.lblNetIncome.TabIndex = 14
        Me.lblNetIncome.Text = "Net Paycheck Income:"
        '
        'lblNetIncomeAmount
        '
        Me.lblNetIncomeAmount.AutoSize = True
        Me.lblNetIncomeAmount.Location = New System.Drawing.Point(524, 407)
        Me.lblNetIncomeAmount.Name = "lblNetIncomeAmount"
        Me.lblNetIncomeAmount.Size = New System.Drawing.Size(24, 17)
        Me.lblNetIncomeAmount.TabIndex = 15
        Me.lblNetIncomeAmount.Text = "$0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblNetIncomeAmount)
        Me.Controls.Add(Me.lblNetIncome)
        Me.Controls.Add(Me.lblStateTaxAmount)
        Me.Controls.Add(Me.lblFederalTaxAmount)
        Me.Controls.Add(Me.lblFICAAmount)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFederalTax)
        Me.Controls.Add(Me.lblFICA)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnComputeTaxes)
        Me.Controls.Add(Me.txtGrossPay)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pctPayroll)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pctPayroll, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pctPayroll As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents txtGrossPay As TextBox
    Friend WithEvents btnComputeTaxes As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFICA As Label
    Friend WithEvents lblFederalTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblFICAAmount As Label
    Friend WithEvents lblFederalTaxAmount As Label
    Friend WithEvents lblStateTaxAmount As Label
    Friend WithEvents lblNetIncome As Label
    Friend WithEvents lblNetIncomeAmount As Label
End Class
