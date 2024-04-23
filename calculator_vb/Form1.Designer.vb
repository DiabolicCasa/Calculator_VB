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
        TxtDisplay = New TextBox()
        BtnBackspace = New Button()
        BtnCE = New Button()
        Btnplus_minus = New Button()
        BtnC = New Button()
        Btnplus = New Button()
        Btn9 = New Button()
        Button8 = New Button()
        btn7 = New Button()
        Btnminus = New Button()
        Btn4 = New Button()
        Btn5 = New Button()
        Btn6 = New Button()
        BtnMultiply = New Button()
        Btn1 = New Button()
        Btn2 = New Button()
        Btn3 = New Button()
        Btndivide = New Button()
        BtnEqual = New Button()
        BtnDotOperator = New Button()
        Btn0 = New Button()
        SuspendLayout()
        ' 
        ' TxtDisplay
        ' 
        TxtDisplay.BackColor = SystemColors.ButtonFace
        TxtDisplay.BorderStyle = BorderStyle.None
        TxtDisplay.Cursor = Cursors.IBeam
        TxtDisplay.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        TxtDisplay.Location = New Point(12, 12)
        TxtDisplay.Multiline = True
        TxtDisplay.Name = "TxtDisplay"
        TxtDisplay.Size = New Size(418, 61)
        TxtDisplay.TabIndex = 0
        TxtDisplay.Text = "0"
        TxtDisplay.TextAlign = HorizontalAlignment.Right
        ' 
        ' BtnBackspace
        ' 
        BtnBackspace.Font = New Font("Wingdings", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBackspace.Location = New Point(12, 79)
        BtnBackspace.Name = "BtnBackspace"
        BtnBackspace.Size = New Size(100, 78)
        BtnBackspace.TabIndex = 1
        BtnBackspace.Text = ""
        BtnBackspace.UseVisualStyleBackColor = True
        ' 
        ' BtnCE
        ' 
        BtnCE.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnCE.Location = New Point(118, 79)
        BtnCE.Name = "BtnCE"
        BtnCE.Size = New Size(100, 78)
        BtnCE.TabIndex = 2
        BtnCE.Text = "CE"
        BtnCE.UseVisualStyleBackColor = True
        ' 
        ' Btnplus_minus
        ' 
        Btnplus_minus.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btnplus_minus.Location = New Point(330, 79)
        Btnplus_minus.Name = "Btnplus_minus"
        Btnplus_minus.Size = New Size(100, 78)
        Btnplus_minus.TabIndex = 4
        Btnplus_minus.Text = "±"
        Btnplus_minus.UseVisualStyleBackColor = True
        ' 
        ' BtnC
        ' 
        BtnC.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnC.Location = New Point(224, 79)
        BtnC.Name = "BtnC"
        BtnC.Size = New Size(100, 78)
        BtnC.TabIndex = 3
        BtnC.Text = "C"
        BtnC.UseVisualStyleBackColor = True
        ' 
        ' Btnplus
        ' 
        Btnplus.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btnplus.Location = New Point(330, 163)
        Btnplus.Name = "Btnplus"
        Btnplus.Size = New Size(100, 78)
        Btnplus.TabIndex = 8
        Btnplus.Text = "+"
        Btnplus.UseVisualStyleBackColor = True
        ' 
        ' Btn9
        ' 
        Btn9.FlatAppearance.BorderSize = 0
        Btn9.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btn9.Location = New Point(224, 163)
        Btn9.Name = "Btn9"
        Btn9.Size = New Size(100, 78)
        Btn9.TabIndex = 7
        Btn9.Text = "9"
        Btn9.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.FlatAppearance.BorderSize = 0
        Button8.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Button8.Location = New Point(118, 163)
        Button8.Name = "Button8"
        Button8.Size = New Size(100, 78)
        Button8.TabIndex = 6
        Button8.Text = "8"
        Button8.UseVisualStyleBackColor = True
        ' 
        ' btn7
        ' 
        btn7.FlatAppearance.BorderSize = 0
        btn7.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        btn7.Location = New Point(12, 163)
        btn7.Name = "btn7"
        btn7.Size = New Size(100, 78)
        btn7.TabIndex = 5
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' Btnminus
        ' 
        Btnminus.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btnminus.Location = New Point(330, 247)
        Btnminus.Name = "Btnminus"
        Btnminus.Size = New Size(100, 78)
        Btnminus.TabIndex = 12
        Btnminus.Text = "-"
        Btnminus.UseVisualStyleBackColor = True
        ' 
        ' Btn4
        ' 
        Btn4.FlatAppearance.BorderSize = 0
        Btn4.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btn4.Location = New Point(12, 247)
        Btn4.Name = "Btn4"
        Btn4.Size = New Size(100, 78)
        Btn4.TabIndex = 11
        Btn4.Text = "4"
        Btn4.UseVisualStyleBackColor = True
        ' 
        ' Btn5
        ' 
        Btn5.FlatAppearance.BorderSize = 0
        Btn5.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btn5.Location = New Point(118, 247)
        Btn5.Name = "Btn5"
        Btn5.Size = New Size(100, 78)
        Btn5.TabIndex = 10
        Btn5.Text = "5"
        Btn5.UseVisualStyleBackColor = True
        ' 
        ' Btn6
        ' 
        Btn6.FlatAppearance.BorderSize = 0
        Btn6.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btn6.Location = New Point(224, 247)
        Btn6.Name = "Btn6"
        Btn6.Size = New Size(100, 78)
        Btn6.TabIndex = 9
        Btn6.Text = "6"
        Btn6.UseVisualStyleBackColor = True
        ' 
        ' BtnMultiply
        ' 
        BtnMultiply.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnMultiply.Location = New Point(330, 331)
        BtnMultiply.Name = "BtnMultiply"
        BtnMultiply.Size = New Size(100, 78)
        BtnMultiply.TabIndex = 16
        BtnMultiply.Text = "*"
        BtnMultiply.UseVisualStyleBackColor = True
        ' 
        ' Btn1
        ' 
        Btn1.FlatAppearance.BorderSize = 0
        Btn1.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btn1.Location = New Point(12, 331)
        Btn1.Name = "Btn1"
        Btn1.Size = New Size(100, 78)
        Btn1.TabIndex = 15
        Btn1.Text = "1"
        Btn1.UseVisualStyleBackColor = True
        ' 
        ' Btn2
        ' 
        Btn2.FlatAppearance.BorderSize = 0
        Btn2.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btn2.Location = New Point(118, 331)
        Btn2.Name = "Btn2"
        Btn2.Size = New Size(100, 78)
        Btn2.TabIndex = 14
        Btn2.Text = "2"
        Btn2.UseVisualStyleBackColor = True
        ' 
        ' Btn3
        ' 
        Btn3.FlatAppearance.BorderSize = 0
        Btn3.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btn3.Location = New Point(224, 331)
        Btn3.Name = "Btn3"
        Btn3.Size = New Size(100, 78)
        Btn3.TabIndex = 13
        Btn3.Text = "3"
        Btn3.UseVisualStyleBackColor = True
        ' 
        ' Btndivide
        ' 
        Btndivide.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btndivide.Location = New Point(330, 415)
        Btndivide.Name = "Btndivide"
        Btndivide.Size = New Size(100, 78)
        Btndivide.TabIndex = 20
        Btndivide.Text = "/"
        Btndivide.UseVisualStyleBackColor = True
        ' 
        ' BtnEqual
        ' 
        BtnEqual.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnEqual.Location = New Point(224, 415)
        BtnEqual.Name = "BtnEqual"
        BtnEqual.Size = New Size(100, 78)
        BtnEqual.TabIndex = 19
        BtnEqual.Text = "="
        BtnEqual.UseVisualStyleBackColor = True
        ' 
        ' BtnDotOperator
        ' 
        BtnDotOperator.FlatAppearance.BorderSize = 0
        BtnDotOperator.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        BtnDotOperator.Location = New Point(118, 415)
        BtnDotOperator.Name = "BtnDotOperator"
        BtnDotOperator.Size = New Size(100, 78)
        BtnDotOperator.TabIndex = 18
        BtnDotOperator.Text = "."
        BtnDotOperator.UseVisualStyleBackColor = True
        ' 
        ' Btn0
        ' 
        Btn0.FlatAppearance.BorderSize = 0
        Btn0.Font = New Font("Inter", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Btn0.Location = New Point(12, 415)
        Btn0.Name = "Btn0"
        Btn0.Size = New Size(100, 78)
        Btn0.TabIndex = 17
        Btn0.Text = "0"
        Btn0.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(438, 505)
        Controls.Add(Btndivide)
        Controls.Add(BtnEqual)
        Controls.Add(BtnDotOperator)
        Controls.Add(Btn0)
        Controls.Add(BtnMultiply)
        Controls.Add(Btn1)
        Controls.Add(Btn2)
        Controls.Add(Btn3)
        Controls.Add(Btnminus)
        Controls.Add(Btn4)
        Controls.Add(Btn5)
        Controls.Add(Btn6)
        Controls.Add(Btnplus)
        Controls.Add(Btn9)
        Controls.Add(Button8)
        Controls.Add(btn7)
        Controls.Add(Btnplus_minus)
        Controls.Add(BtnC)
        Controls.Add(BtnCE)
        Controls.Add(BtnBackspace)
        Controls.Add(TxtDisplay)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtDisplay As TextBox
    Friend WithEvents BtnBackspace As Button
    Friend WithEvents BtnCE As Button
    Friend WithEvents Btnplus_minus As Button
    Friend WithEvents BtnC As Button
    Friend WithEvents Btnplus As Button
    Friend WithEvents Btn9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents Btnminus As Button
    Friend WithEvents Btn4 As Button
    Friend WithEvents Btn5 As Button
    Friend WithEvents Btn6 As Button
    Friend WithEvents BtnMultiply As Button
    Friend WithEvents Btn1 As Button
    Friend WithEvents Btn2 As Button
    Friend WithEvents Btn3 As Button
    Friend WithEvents Btndivide As Button
    Friend WithEvents BtnEqual As Button
    Friend WithEvents BtnDotOperator As Button
    Friend WithEvents Btn0 As Button
End Class
