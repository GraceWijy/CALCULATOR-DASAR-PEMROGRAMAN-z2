<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        txtDisplay = New TextBox()
        btn3 = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btnsub = New Button()
        btnadd = New Button()
        btndiv = New Button()
        btnmul = New Button()
        btnequal = New Button()
        btndot = New Button()
        btn0 = New Button()
        btndel = New Button()
        btnclear = New Button()
        SuspendLayout()
        ' 
        ' txtDisplay
        ' 
        txtDisplay.Font = New Font("Century", 15F)
        txtDisplay.Location = New Point(17, 28)
        txtDisplay.Margin = New Padding(4)
        txtDisplay.Multiline = True
        txtDisplay.Name = "txtDisplay"
        txtDisplay.ReadOnly = True
        txtDisplay.Size = New Size(555, 78)
        txtDisplay.TabIndex = 0
        txtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' btn3
        ' 
        btn3.Font = New Font("Century", 15F)
        btn3.Location = New Point(229, 138)
        btn3.Name = "btn3"
        btn3.Size = New Size(100, 100)
        btn3.TabIndex = 3
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Font = New Font("Century", 15F)
        btn4.Location = New Point(17, 244)
        btn4.Name = "btn4"
        btn4.Size = New Size(100, 100)
        btn4.TabIndex = 4
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Font = New Font("Century", 15F)
        btn5.Location = New Point(123, 244)
        btn5.Name = "btn5"
        btn5.Size = New Size(100, 100)
        btn5.TabIndex = 5
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Font = New Font("Century", 15F)
        btn6.Location = New Point(229, 244)
        btn6.Name = "btn6"
        btn6.Size = New Size(100, 100)
        btn6.TabIndex = 6
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Font = New Font("Century", 15F)
        btn9.Location = New Point(229, 350)
        btn9.Name = "btn9"
        btn9.Size = New Size(100, 100)
        btn9.TabIndex = 9
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Font = New Font("Century", 15F)
        btn8.Location = New Point(123, 350)
        btn8.Name = "btn8"
        btn8.Size = New Size(100, 100)
        btn8.TabIndex = 8
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.Font = New Font("Century", 15F)
        btn7.Location = New Point(17, 350)
        btn7.Name = "btn7"
        btn7.Size = New Size(100, 100)
        btn7.TabIndex = 7
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Font = New Font("Century", 15F)
        btn1.Location = New Point(17, 138)
        btn1.Name = "btn1"
        btn1.Size = New Size(100, 100)
        btn1.TabIndex = 1
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Font = New Font("Century", 15F)
        btn2.Location = New Point(123, 138)
        btn2.Name = "btn2"
        btn2.Size = New Size(100, 100)
        btn2.TabIndex = 2
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btnsub
        ' 
        btnsub.Font = New Font("Century", 15F)
        btnsub.Location = New Point(472, 244)
        btnsub.Name = "btnsub"
        btnsub.Size = New Size(100, 100)
        btnsub.TabIndex = 11
        btnsub.Text = "-"
        btnsub.UseVisualStyleBackColor = True
        ' 
        ' btnadd
        ' 
        btnadd.Font = New Font("Century", 15F)
        btnadd.Location = New Point(366, 244)
        btnadd.Name = "btnadd"
        btnadd.Size = New Size(100, 100)
        btnadd.TabIndex = 10
        btnadd.Text = "+"
        btnadd.UseVisualStyleBackColor = True
        ' 
        ' btndiv
        ' 
        btndiv.Font = New Font("Century", 15F)
        btndiv.Location = New Point(472, 350)
        btndiv.Name = "btndiv"
        btndiv.Size = New Size(100, 100)
        btndiv.TabIndex = 13
        btndiv.Text = "÷"
        btndiv.UseVisualStyleBackColor = True
        ' 
        ' btnmul
        ' 
        btnmul.Font = New Font("Century", 15F)
        btnmul.Location = New Point(366, 350)
        btnmul.Name = "btnmul"
        btnmul.Size = New Size(100, 100)
        btnmul.TabIndex = 12
        btnmul.Text = "x"
        btnmul.UseVisualStyleBackColor = True
        ' 
        ' btnequal
        ' 
        btnequal.Font = New Font("Century", 15F)
        btnequal.Location = New Point(366, 456)
        btnequal.Name = "btnequal"
        btnequal.Size = New Size(206, 100)
        btnequal.TabIndex = 15
        btnequal.Text = "="
        btnequal.UseVisualStyleBackColor = True
        ' 
        ' btndot
        ' 
        btndot.Font = New Font("Century", 15F)
        btndot.Location = New Point(229, 456)
        btndot.Name = "btndot"
        btndot.Size = New Size(100, 100)
        btndot.TabIndex = 18
        btndot.Text = "."
        btndot.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Font = New Font("Century", 15F)
        btn0.Location = New Point(17, 456)
        btn0.Name = "btn0"
        btn0.Size = New Size(206, 100)
        btn0.TabIndex = 16
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btndel
        ' 
        btndel.Font = New Font("Century", 15F)
        btndel.Location = New Point(366, 138)
        btndel.Name = "btndel"
        btndel.Size = New Size(100, 100)
        btndel.TabIndex = 20
        btndel.Text = "Delete"
        btndel.UseVisualStyleBackColor = True
        ' 
        ' btnclear
        ' 
        btnclear.Font = New Font("Century", 15F)
        btnclear.Location = New Point(472, 138)
        btnclear.Name = "btnclear"
        btnclear.Size = New Size(100, 100)
        btnclear.TabIndex = 19
        btnclear.Text = "C"
        btnclear.UseVisualStyleBackColor = True
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(13F, 26F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(596, 582)
        Controls.Add(btndel)
        Controls.Add(btnclear)
        Controls.Add(btndot)
        Controls.Add(btn0)
        Controls.Add(btnequal)
        Controls.Add(btndiv)
        Controls.Add(btnmul)
        Controls.Add(btnsub)
        Controls.Add(btnadd)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(txtDisplay)
        Font = New Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        MinimizeBox = False
        Name = "Calculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btn3 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btnsub As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btndiv As Button
    Friend WithEvents btnmul As Button
    Friend WithEvents btnequal As Button
    Friend WithEvents btndot As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnclear As Button

End Class
