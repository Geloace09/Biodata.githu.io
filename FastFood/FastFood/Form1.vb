Public Class frmFastFood
    Const TAX_RATE As Decimal = 0.0875
    Const PRICE_HAMBURGER As Decimal = 2.75
    Const PRICE_CHICKEN_SANDWICH As Decimal = 3.25
    Const PRICE_EGG_SANDWICH As Decimal = 2.49
    Const PRICE_CHEESE As Decimal = 0.1
    Const PRICE_TOMATO As Decimal = 0.2
    Const PRICE_PEPSI As Decimal = 0.2
    Const PRICE_Coca_Cola As Decimal = 0.2
    Const PRICE_Mountain_Dew As Decimal = 0.2
    Const PRICE_FRIES As Decimal = 0.2
    Const PRICE_ONION_RING As Decimal = 0.2

    Dim subtotal As Decimal
    Dim tax As Decimal
    Dim total As Decimal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ComputeCurrentSelection()
        UpdateStatus()
        ClearTheCustomerSelections()
    End Sub
    Private Sub ComputeCurrentSelection()
        If radHamburger.Checked Then
            subtotal += PRICE_HAMBURGER
            Dim HamburgerItem As String = _
            PRICE_HAMBURGER.ToString("C") & "Hamburger"
            ListBox1.Items.Add(HamburgerItem)
        End If
        If radEggSandwich.Checked Then
            subtotal += PRICE_CHICKEN_SANDWICH
            Dim ChickenSandwichItem As String = _
            PRICE_CHICKEN_SANDWICH.ToString("C") & " Chicken Sandwich"
            ListBox1.Items.Add(ChickenSandwichItem)
        End If
        If radEggSandwich.Checked Then
            subtotal += PRICE_EGG_SANDWICH
            Dim EggSandwichItem As String = _
            PRICE_EGG_SANDWICH.ToString("C") & " Egg Sandwich"
            ListBox1.Items.Add(EggSandwichItem)
        End If
        If RadPepsi.Checked Then
            subtotal += PRICE_PEPSI
            Dim PepsiItem As String = _
            PRICE_PEPSI.ToString("C") & " Pepsi"
            ListBox1.Items.Add(PepsiItem)
        End If
        If chkTomato.Checked Then
            subtotal += PRICE_TOMATO
            Dim TomatoItem As String = _
            PRICE_TOMATO.ToString("C") & " Tomato"
            ListBox1.Items.Add(TomatoItem)
        End If
        If RadioButton6.Checked Then
            subtotal += PRICE_Coca_Cola
            Dim Coca_Cola As String = _
           PRICE_Coca_Cola.ToString("C") & " Coca-Cola"
            ListBox1.Items.Add(Coca_Cola)
        End If

        If RadioButton5.Checked Then
            subtotal += PRICE_Mountain_Dew
            Dim Mountain_Dew As String = _
          PRICE_Mountain_Dew.ToString("C") & " Mountain Dew"
            ListBox1.Items.Add(Mountain_Dew)
        End If
        If chkCheese.Checked Then
            subtotal += PRICE_CHEESE
            Dim Cheese As String = _
          PRICE_CHEESE.ToString("C") & " Cheese"
            ListBox1.Items.Add(Cheese)
        End If
        If radFries.Checked Then
            subtotal += PRICE_FRIES
            Dim FRIES As String = _
          PRICE_FRIES.ToString("C") & " FRIES"
            ListBox1.Items.Add(FRIES)
        End If
        If radOnion.Checked Then
            subtotal += PRICE_ONION_RING
            Dim ONION As String = _
          PRICE_ONION_RING.ToString("C") & " ONION"
            ListBox1.Items.Add(ONION)
        End If
    End Sub

    Private Sub UpdateStatus()
        ListBox2.Items.Clear()
        ListBox2.Items.Add("SUB TOTAL = " & subtotal.ToString("C"))
        tax = subtotal * TAX_RATE
        ListBox2.Items.Add("   TAX = " & tax.ToString("C"))
        total = subtotal + tax
        ListBox2.Items.Add("    TOTAL = " & total.ToString("C"))
        ListBox1.Items.Add("-------------------------")
    End Sub

    Private Sub ClearTheCustomerSelections()
        radNoSandwich.Checked = True
        chkCheese.Checked = False
        chkTomato.Checked = False
        radNoDrink.Checked = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        InitializeVariables()
        ClearTheCustomerSelections()
        ClearTheReceipt()
    End Sub

    Private Sub InitializeVariables()
        subtotal = 0
        tax = 0
        total = 0
    End Sub

    Private Sub ClearTheReceipt()
        ListBox2.Items.Clear()
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
Private Sub frmFastFood_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    InitializeVariables()
    ClearTheCustomerSelections()
    ClearTheReceipt()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class



