<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim ProductNameLabel As System.Windows.Forms.Label
        Dim DateofOrderLabel As System.Windows.Forms.Label
        Dim PhoneNumberLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DeliveryLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Receipt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ClearItems = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.ClearPrimary = New System.Windows.Forms.Button()
        Me.DeliveryTextBox = New System.Windows.Forms.TextBox()
        Me.PrimaryConfirm = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.DateofOrderDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PhoneNumberTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        QuantityLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        ProductNameLabel = New System.Windows.Forms.Label()
        DateofOrderLabel = New System.Windows.Forms.Label()
        PhoneNumberLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DeliveryLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(244, 390)
        QuantityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(66, 18)
        QuantityLabel.TabIndex = 12
        QuantityLabel.Text = "Quantity:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(244, 319)
        PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(46, 18)
        PriceLabel.TabIndex = 10
        PriceLabel.Text = "Price:"
        '
        'ProductNameLabel
        '
        ProductNameLabel.AutoSize = True
        ProductNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ProductNameLabel.Location = New System.Drawing.Point(8, 319)
        ProductNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ProductNameLabel.Name = "ProductNameLabel"
        ProductNameLabel.Size = New System.Drawing.Size(108, 18)
        ProductNameLabel.TabIndex = 8
        ProductNameLabel.Text = "Product Name:"
        '
        'DateofOrderLabel
        '
        DateofOrderLabel.AutoSize = True
        DateofOrderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DateofOrderLabel.Location = New System.Drawing.Point(244, 137)
        DateofOrderLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DateofOrderLabel.Name = "DateofOrderLabel"
        DateofOrderLabel.Size = New System.Drawing.Size(102, 18)
        DateofOrderLabel.TabIndex = 6
        DateofOrderLabel.Text = "Date of Order:"
        '
        'PhoneNumberLabel
        '
        PhoneNumberLabel.AutoSize = True
        PhoneNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PhoneNumberLabel.Location = New System.Drawing.Point(8, 137)
        PhoneNumberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PhoneNumberLabel.Name = "PhoneNumberLabel"
        PhoneNumberLabel.Size = New System.Drawing.Size(112, 18)
        PhoneNumberLabel.TabIndex = 2
        PhoneNumberLabel.Text = "Phone Number:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.Location = New System.Drawing.Point(8, 78)
        NameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(52, 18)
        NameLabel.TabIndex = 0
        NameLabel.Text = "Name:"
        '
        'DeliveryLabel
        '
        DeliveryLabel.AutoSize = True
        DeliveryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DeliveryLabel.Location = New System.Drawing.Point(244, 78)
        DeliveryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DeliveryLabel.Name = "DeliveryLabel"
        DeliveryLabel.Size = New System.Drawing.Size(122, 18)
        DeliveryLabel.TabIndex = 18
        DeliveryLabel.Text = "Delivery Address:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.73109!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(63, 34)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(163, 30)
        Label2.TabIndex = 21
        Label2.Text = "Primary Info"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.73109!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(63, 273)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(88, 30)
        Label3.TabIndex = 22
        Label3.Text = "Item/s"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.HighlightText
        Me.GroupBox1.Controls.Add(Me.RadioButton5)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.ClearItems)
        Me.GroupBox1.Controls.Add(Me.SaveButton)
        Me.GroupBox1.Controls.Add(Label3)
        Me.GroupBox1.Controls.Add(Label2)
        Me.GroupBox1.Controls.Add(Me.ClearPrimary)
        Me.GroupBox1.Controls.Add(Me.DeliveryTextBox)
        Me.GroupBox1.Controls.Add(DeliveryLabel)
        Me.GroupBox1.Controls.Add(Me.PrimaryConfirm)
        Me.GroupBox1.Controls.Add(Me.AddButton)
        Me.GroupBox1.Controls.Add(QuantityLabel)
        Me.GroupBox1.Controls.Add(Me.QuantityTextBox)
        Me.GroupBox1.Controls.Add(PriceLabel)
        Me.GroupBox1.Controls.Add(Me.PriceTextBox)
        Me.GroupBox1.Controls.Add(ProductNameLabel)
        Me.GroupBox1.Controls.Add(DateofOrderLabel)
        Me.GroupBox1.Controls.Add(Me.DateofOrderDateTimePicker)
        Me.GroupBox1.Controls.Add(PhoneNumberLabel)
        Me.GroupBox1.Controls.Add(Me.PhoneNumberTextBox)
        Me.GroupBox1.Controls.Add(NameLabel)
        Me.GroupBox1.Controls.Add(Me.NameTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(371, 71)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(683, 646)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Transaction Details"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(8, 458)
        Me.RadioButton5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(140, 21)
        Me.RadioButton5.TabIndex = 29
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Extra Throw Pillow"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(8, 431)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(102, 21)
        Me.RadioButton4.TabIndex = 28
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Thomas Set"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(8, 404)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(81, 21)
        Me.RadioButton3.TabIndex = 27
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Polly Set"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(8, 377)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(124, 21)
        Me.RadioButton2.TabIndex = 26
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Billy Kimber Set"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 350)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 21)
        Me.RadioButton1.TabIndex = 25
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Arthur Set"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ClearItems
        '
        Me.ClearItems.Location = New System.Drawing.Point(329, 505)
        Me.ClearItems.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearItems.Name = "ClearItems"
        Me.ClearItems.Size = New System.Drawing.Size(100, 28)
        Me.ClearItems.TabIndex = 24
        Me.ClearItems.Text = "Clear"
        Me.ClearItems.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(575, 505)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(100, 28)
        Me.SaveButton.TabIndex = 23
        Me.SaveButton.Text = "Save"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'ClearPrimary
        '
        Me.ClearPrimary.Location = New System.Drawing.Point(421, 220)
        Me.ClearPrimary.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearPrimary.Name = "ClearPrimary"
        Me.ClearPrimary.Size = New System.Drawing.Size(100, 28)
        Me.ClearPrimary.TabIndex = 20
        Me.ClearPrimary.Text = "Clear"
        Me.ClearPrimary.UseVisualStyleBackColor = True
        '
        'DeliveryTextBox
        '
        Me.DeliveryTextBox.Location = New System.Drawing.Point(247, 98)
        Me.DeliveryTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DeliveryTextBox.Name = "DeliveryTextBox"
        Me.DeliveryTextBox.Size = New System.Drawing.Size(428, 22)
        Me.DeliveryTextBox.TabIndex = 19
        '
        'PrimaryConfirm
        '
        Me.PrimaryConfirm.Location = New System.Drawing.Point(551, 220)
        Me.PrimaryConfirm.Margin = New System.Windows.Forms.Padding(4)
        Me.PrimaryConfirm.Name = "PrimaryConfirm"
        Me.PrimaryConfirm.Size = New System.Drawing.Size(100, 28)
        Me.PrimaryConfirm.TabIndex = 17
        Me.PrimaryConfirm.Text = "Confirm"
        Me.PrimaryConfirm.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(453, 505)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(100, 28)
        Me.AddButton.TabIndex = 14
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(247, 412)
        Me.QuantityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(207, 22)
        Me.QuantityTextBox.TabIndex = 13
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(247, 341)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(207, 22)
        Me.PriceTextBox.TabIndex = 11
        '
        'DateofOrderDateTimePicker
        '
        Me.DateofOrderDateTimePicker.Location = New System.Drawing.Point(247, 159)
        Me.DateofOrderDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DateofOrderDateTimePicker.Name = "DateofOrderDateTimePicker"
        Me.DateofOrderDateTimePicker.Size = New System.Drawing.Size(307, 22)
        Me.DateofOrderDateTimePicker.TabIndex = 7
        '
        'PhoneNumberTextBox
        '
        Me.PhoneNumberTextBox.Location = New System.Drawing.Point(8, 159)
        Me.PhoneNumberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneNumberTextBox.Name = "PhoneNumberTextBox"
        Me.PhoneNumberTextBox.Size = New System.Drawing.Size(153, 22)
        Me.PhoneNumberTextBox.TabIndex = 3
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(8, 98)
        Me.NameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(209, 22)
        Me.NameTextBox.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Controls.Add(Me.TabControl1)
        Me.GroupBox2.Location = New System.Drawing.Point(1061, 111)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(628, 592)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.96639!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(657, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(396, 39)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Create your Receipt here"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(336, 749)
        Me.TextBox1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 533)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 39)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = " Receipt"
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(13, 26)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(311, 142)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 11
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.System.My.Resources.Resources.receipt_vector_icon_png_253188
        Me.PictureBox1.Location = New System.Drawing.Point(29, 230)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 299)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = Global.System.My.Resources.Resources.v960_ning_30
        Me.PictureBox2.Location = New System.Drawing.Point(332, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1371, 750)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(604, 527)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Information"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableDataGridView
        '
        Me.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableDataGridView.Location = New System.Drawing.Point(9, 12)
        Me.TableDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TableDataGridView.Name = "TableDataGridView"
        Me.TableDataGridView.Size = New System.Drawing.Size(587, 505)
        Me.TableDataGridView.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.RichTextBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(604, 527)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "Receipt"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 10)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(588, 506)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 25)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(612, 556)
        Me.TabControl1.TabIndex = 0
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1702, 751)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.TableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrimaryConfirm As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents DateofOrderDateTimePicker As DateTimePicker
    Friend WithEvents PhoneNumberTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ClearPrimary As Button
    Friend WithEvents DeliveryTextBox As TextBox
    Friend WithEvents SaveButton As Button
    Friend WithEvents ClearItems As Button
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TableDataGridView As DataGridView
End Class
