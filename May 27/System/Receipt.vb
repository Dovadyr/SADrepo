Imports MySql.Data.MySqlClient

Public Class Receipt
    Dim pInfo As Boolean = False    'checks if Primary Info is filled up
    Dim quan As Integer             'quantity value holder (Int)
    Dim prc As Integer              'price value holder (Int)
    Dim pctotal As Integer          'total price per item (Int)
    Dim pctString As String         'pctotal's String variable
    Dim ftotal As Integer           'total amount to pay
    Dim ftString As String          'ftotal' String variable
    Dim pName As String             'product name
    Dim timeformat As String = "MM-dd-yyyy"
    Dim itemA As Integer
    Dim itemB As Integer
    Dim itemC As Integer
    Dim itemD As Integer
    Dim itemE As Integer

    'database related below
    Dim conn As New MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=dbforproj")

    Private Sub txtButton4_Click(sender As Object, e As EventArgs) Handles PrimaryConfirm.Click
        itemA = 0
        itemB = 0
        itemC = 0
        itemD = 0
        itemE = 0
        pctotal = 0
        ftotal = 0

        TabControl1.SelectedTab = TabPage1

        If (String.IsNullOrEmpty(NameTextBox.Text) Or String.IsNullOrEmpty(PhoneNumberTextBox.Text) Or String.IsNullOrEmpty(DeliveryTextBox.Text)) Then
            MsgBox("Please properly fill out the Primary Information")

        Else
            RichTextBox1.AppendText(vbTab + vbTab + " Welcome to the 4 Ace's sofa set" + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + " *********************** " + vbNewLine)
            RichTextBox1.AppendText(" " + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "Name: " + NameTextBox.Text + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "Phone Number: " + PhoneNumberTextBox.Text + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "Delivery Address: " + DeliveryTextBox.Text + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "Date of Order: " + DateofOrderDateTimePicker.Text + vbNewLine)
            RichTextBox1.AppendText(vbTab + vbTab + "Item/s: " + vbNewLine)
            pInfo = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If (pInfo = False) Then
            MsgBox("Please properly fill out the PRIMARY INFORMATION first")

        ElseIf (String.IsNullOrEmpty(pName) Or String.IsNullOrEmpty(QuantityTextBox.Text) Or String.IsNullOrEmpty(PriceTextBox.Text)) Then
            MsgBox("Please properly fill out the ITEM/S details properly")

        Else

            quan = QuantityTextBox.Text
            prc = PriceTextBox.Text
            pctotal = quan * prc
            pctString = pctotal.ToString()

            If (RadioButton1.Checked) Then
                itemA += quan
            ElseIf (RadioButton2.Checked) Then
                itemB += quan
            ElseIf (RadioButton3.Checked) Then
                itemC += quan
            ElseIf (RadioButton4.Checked) Then
                itemD += quan
            Else
                itemE += quan
            End If

            RichTextBox1.AppendText(vbTab + vbTab + QuantityTextBox.Text + " x ")
            RichTextBox1.AppendText(pName + vbTab)
            RichTextBox1.AppendText(vbTab + "Price: ₱" + PriceTextBox.Text)
            RichTextBox1.AppendText(vbTab + "Total: ₱" + pctString + vbNewLine)

            ftotal = ftotal + pctotal
        End If
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        ftString = ftotal.ToString()
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + "Amount To Pay: ₱" + ftString + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + " *********************** " + vbNewLine)
        RichTextBox1.AppendText(" " + vbNewLine)
        RichTextBox1.AppendText(vbTab + vbTab + " THANKS FOR BUYING :) ")
        Dim command As New MySqlCommand("INSERT INTO `receiptdb`( `cus_name`, `phone_num`, `deli_address`, `trans_date`, `item1`, `item2`, `item3`, `item4`, `item5`, `total`) VALUES (@cn, @pn, @deli, @date, @i1, @i2, @i3, @i4, @i5, @tot)", conn)


        command.Parameters.Add("@cn", MySqlDbType.VarChar).Value = NameTextBox.Text
        command.Parameters.Add("@pn", MySqlDbType.VarChar).Value = PhoneNumberTextBox.Text
        command.Parameters.Add("@deli", MySqlDbType.VarChar).Value = DeliveryTextBox.Text
        command.Parameters.Add("@date", MySqlDbType.Date).Value = DateofOrderDateTimePicker.Value
        command.Parameters.Add("@i1", MySqlDbType.Int16).Value = itemA
        command.Parameters.Add("@i2", MySqlDbType.Int16).Value = itemB
        command.Parameters.Add("@i3", MySqlDbType.Int16).Value = itemC
        command.Parameters.Add("@i4", MySqlDbType.Int16).Value = itemD
        command.Parameters.Add("@i5", MySqlDbType.Int16).Value = itemE
        command.Parameters.Add("@tot", MySqlDbType.Int64).Value = ftotal

        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Transaction Saved!")
        Else
            MsgBox("Error!")

        End If
        conn.Close()
    End Sub

    Private Sub ClearPrimary_Click(sender As Object, e As EventArgs) Handles ClearPrimary.Click
        NameTextBox.Clear()
        PhoneNumberTextBox.Clear()
        DeliveryTextBox.Clear()
    End Sub

    Private Sub ClearItems_Click(sender As Object, e As EventArgs) Handles ClearItems.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        pName = ""
        PriceTextBox.Clear()
        QuantityTextBox.Clear()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        pName = RadioButton1.Text
        PriceTextBox.Text = "5400"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        pName = RadioButton2.Text
        PriceTextBox.Text = "7600"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        pName = RadioButton3.Text
        PriceTextBox.Text = "9999"
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        pName = RadioButton4.Text
        PriceTextBox.Text = "15000"
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        pName = RadioButton5.Text
        PriceTextBox.Text = "250"
    End Sub

End Class