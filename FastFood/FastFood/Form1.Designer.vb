<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFastFood
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
        Dim radChickenSandwicha As System.Windows.Forms.RadioButton
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.radOnion = New System.Windows.Forms.CheckBox()
        Me.radFries = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadPepsi = New System.Windows.Forms.RadioButton()
        Me.radNoDrink = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTomato = New System.Windows.Forms.CheckBox()
        Me.chkCheese = New System.Windows.Forms.CheckBox()
        Me.radEggSandwich = New System.Windows.Forms.RadioButton()
        Me.radHamburger = New System.Windows.Forms.RadioButton()
        Me.radNoSandwich = New System.Windows.Forms.RadioButton()
        radChickenSandwicha = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'radChickenSandwicha
        '
        radChickenSandwicha.AutoSize = True
        radChickenSandwicha.Location = New System.Drawing.Point(6, 95)
        radChickenSandwicha.Name = "radChickenSandwicha"
        radChickenSandwicha.Size = New System.Drawing.Size(147, 17)
        radChickenSandwicha.TabIndex = 2
        radChickenSandwicha.TabStop = True
        radChickenSandwicha.Text = "20php Chicken Sandwich"
        radChickenSandwicha.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"1stTotal"})
        Me.ListBox2.Location = New System.Drawing.Point(549, 458)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(291, 82)
        Me.ListBox2.TabIndex = 19
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"1stOrderReceipt"})
        Me.ListBox1.Location = New System.Drawing.Point(549, 312)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(291, 134)
        Me.ListBox1.TabIndex = 13
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(198, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 54)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(91, 376)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 54)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(91, 290)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(90, 54)
        Me.btnEnter.TabIndex = 16
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.radOnion)
        Me.GroupBox3.Controls.Add(Me.radFries)
        Me.GroupBox3.Location = New System.Drawing.Point(549, 217)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(291, 77)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Extras"
        '
        'radOnion
        '
        Me.radOnion.AutoSize = True
        Me.radOnion.Location = New System.Drawing.Point(3, 54)
        Me.radOnion.Name = "radOnion"
        Me.radOnion.Size = New System.Drawing.Size(107, 17)
        Me.radOnion.TabIndex = 1
        Me.radOnion.Text = "25php Onion-ring"
        Me.radOnion.UseVisualStyleBackColor = True
        '
        'radFries
        '
        Me.radFries.AutoSize = True
        Me.radFries.Location = New System.Drawing.Point(0, 19)
        Me.radFries.Name = "radFries"
        Me.radFries.Size = New System.Drawing.Size(81, 17)
        Me.radFries.TabIndex = 0
        Me.radFries.Text = "20php Fries"
        Me.radFries.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadPepsi)
        Me.GroupBox2.Controls.Add(Me.radNoDrink)
        Me.GroupBox2.Location = New System.Drawing.Point(549, 30)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 157)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Drinks 15php"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(6, 127)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(94, 17)
        Me.RadioButton5.TabIndex = 3
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Mountain Dew"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Location = New System.Drawing.Point(6, 95)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(74, 17)
        Me.RadioButton6.TabIndex = 2
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "Coca-Cola"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadPepsi
        '
        Me.RadPepsi.AutoSize = True
        Me.RadPepsi.Location = New System.Drawing.Point(6, 63)
        Me.RadPepsi.Name = "RadPepsi"
        Me.RadPepsi.Size = New System.Drawing.Size(51, 17)
        Me.RadPepsi.TabIndex = 1
        Me.RadPepsi.TabStop = True
        Me.RadPepsi.Text = "Pepsi"
        Me.RadPepsi.UseVisualStyleBackColor = True
        '
        'radNoDrink
        '
        Me.radNoDrink.AutoSize = True
        Me.radNoDrink.Location = New System.Drawing.Point(6, 30)
        Me.radNoDrink.Name = "radNoDrink"
        Me.radNoDrink.Size = New System.Drawing.Size(51, 17)
        Me.radNoDrink.TabIndex = 0
        Me.radNoDrink.TabStop = True
        Me.radNoDrink.Text = "None"
        Me.radNoDrink.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTomato)
        Me.GroupBox1.Controls.Add(Me.chkCheese)
        Me.GroupBox1.Controls.Add(Me.radEggSandwich)
        Me.GroupBox1.Controls.Add(radChickenSandwicha)
        Me.GroupBox1.Controls.Add(Me.radHamburger)
        Me.GroupBox1.Controls.Add(Me.radNoSandwich)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 220)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SandWiches"
        '
        'chkTomato
        '
        Me.chkTomato.AutoSize = True
        Me.chkTomato.Location = New System.Drawing.Point(6, 197)
        Me.chkTomato.Name = "chkTomato"
        Me.chkTomato.Size = New System.Drawing.Size(89, 17)
        Me.chkTomato.TabIndex = 5
        Me.chkTomato.Text = "7php Tomato"
        Me.chkTomato.UseVisualStyleBackColor = True
        '
        'chkCheese
        '
        Me.chkCheese.AutoSize = True
        Me.chkCheese.Location = New System.Drawing.Point(6, 160)
        Me.chkCheese.Name = "chkCheese"
        Me.chkCheese.Size = New System.Drawing.Size(89, 17)
        Me.chkCheese.TabIndex = 4
        Me.chkCheese.Text = "5php Cheese"
        Me.chkCheese.UseVisualStyleBackColor = True
        '
        'radEggSandwich
        '
        Me.radEggSandwich.AutoSize = True
        Me.radEggSandwich.Location = New System.Drawing.Point(6, 127)
        Me.radEggSandwich.Name = "radEggSandwich"
        Me.radEggSandwich.Size = New System.Drawing.Size(127, 17)
        Me.radEggSandwich.TabIndex = 3
        Me.radEggSandwich.TabStop = True
        Me.radEggSandwich.Text = "15php Egg Sandwich"
        Me.radEggSandwich.UseVisualStyleBackColor = True
        '
        'radHamburger
        '
        Me.radHamburger.AutoSize = True
        Me.radHamburger.Location = New System.Drawing.Point(6, 63)
        Me.radHamburger.Name = "radHamburger"
        Me.radHamburger.Size = New System.Drawing.Size(110, 17)
        Me.radHamburger.TabIndex = 1
        Me.radHamburger.TabStop = True
        Me.radHamburger.Text = "25php Hamburger"
        Me.radHamburger.UseVisualStyleBackColor = True
        '
        'radNoSandwich
        '
        Me.radNoSandwich.AutoSize = True
        Me.radNoSandwich.Location = New System.Drawing.Point(6, 30)
        Me.radNoSandwich.Name = "radNoSandwich"
        Me.radNoSandwich.Size = New System.Drawing.Size(51, 17)
        Me.radNoSandwich.TabIndex = 0
        Me.radNoSandwich.TabStop = True
        Me.radNoSandwich.Text = "None"
        Me.radNoSandwich.UseVisualStyleBackColor = True
        '
        'frmFastFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FastFood.My.Resources.Resources.Kyle1
        Me.ClientSize = New System.Drawing.Size(925, 571)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmFastFood"
        Me.Text = "Form1"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnEnter As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents radOnion As System.Windows.Forms.CheckBox
    Friend WithEvents radFries As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents RadPepsi As System.Windows.Forms.RadioButton
    Friend WithEvents radNoDrink As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chkTomato As System.Windows.Forms.CheckBox
    Friend WithEvents chkCheese As System.Windows.Forms.CheckBox
    Friend WithEvents radEggSandwich As System.Windows.Forms.RadioButton
    Friend WithEvents radHamburger As System.Windows.Forms.RadioButton
    Friend WithEvents radNoSandwich As System.Windows.Forms.RadioButton

End Class
