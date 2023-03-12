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
        Me.dtGrid1 = New System.Windows.Forms.DataGridView()
        Me.dtDesc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtPrices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtQuant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbProd = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtQuant = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtTotals = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.mainFrame = New System.Windows.Forms.Panel()
        Me.panelMain = New System.Windows.Forms.Panel()
        CType(Me.dtGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.mainFrame.SuspendLayout()
        Me.panelMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtGrid1
        '
        Me.dtGrid1.AllowUserToAddRows = False
        Me.dtGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtGrid1.BackgroundColor = System.Drawing.Color.Beige
        Me.dtGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtDesc, Me.dtPrices, Me.dtQuant, Me.dtTotal})
        Me.dtGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtGrid1.GridColor = System.Drawing.Color.Beige
        Me.dtGrid1.Location = New System.Drawing.Point(20, 26)
        Me.dtGrid1.Name = "dtGrid1"
        Me.dtGrid1.RowTemplate.Height = 25
        Me.dtGrid1.Size = New System.Drawing.Size(417, 191)
        Me.dtGrid1.TabIndex = 0
        '
        'dtDesc
        '
        Me.dtDesc.HeaderText = "Description"
        Me.dtDesc.Name = "dtDesc"
        Me.dtDesc.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dtPrices
        '
        Me.dtPrices.HeaderText = "Prices"
        Me.dtPrices.Name = "dtPrices"
        Me.dtPrices.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dtQuant
        '
        Me.dtQuant.HeaderText = "Quantity"
        Me.dtQuant.Name = "dtQuant"
        Me.dtQuant.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'dtTotal
        '
        Me.dtTotal.HeaderText = "Totals"
        Me.dtTotal.Name = "dtTotal"
        Me.dtTotal.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Roboto", 13.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(447, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Grid View"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(10, 15)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel11.Size = New System.Drawing.Size(457, 32)
        Me.Panel11.TabIndex = 9
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Beige
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel10.Controls.Add(Me.GroupBox1)
        Me.Panel10.Controls.Add(Me.Panel11)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(358, 2)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(10, 15, 10, 15)
        Me.Panel10.Size = New System.Drawing.Size(479, 370)
        Me.Panel10.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.dtGrid1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(10, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.GroupBox1.Size = New System.Drawing.Size(457, 227)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'cmbProd
        '
        Me.cmbProd.BackColor = System.Drawing.Color.Beige
        Me.cmbProd.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmbProd.FormattingEnabled = True
        Me.cmbProd.Items.AddRange(New Object() {"banana1", "banana2", "banana3", "banana4", "banana5", "banana6", "banana7", "banana8", "banana9"})
        Me.cmbProd.Location = New System.Drawing.Point(117, 5)
        Me.cmbProd.Name = "cmbProd"
        Me.cmbProd.Size = New System.Drawing.Size(132, 23)
        Me.cmbProd.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmbProd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(20, 26)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel2.Size = New System.Drawing.Size(254, 32)
        Me.Panel2.TabIndex = 10
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.Beige
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesc.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtDesc.Location = New System.Drawing.Point(117, 5)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(132, 23)
        Me.txtDesc.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Description"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtDesc)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(20, 58)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(254, 32)
        Me.Panel3.TabIndex = 11
        '
        'txtPrice
        '
        Me.txtPrice.BackColor = System.Drawing.Color.Beige
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtPrice.Location = New System.Drawing.Point(117, 5)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 23)
        Me.txtPrice.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(5, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.txtPrice)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(20, 90)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel6.Size = New System.Drawing.Size(254, 32)
        Me.Panel6.TabIndex = 12
        '
        'txtQuant
        '
        Me.txtQuant.BackColor = System.Drawing.Color.Beige
        Me.txtQuant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuant.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtQuant.Location = New System.Drawing.Point(117, 5)
        Me.txtQuant.Name = "txtQuant"
        Me.txtQuant.Size = New System.Drawing.Size(132, 23)
        Me.txtQuant.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(5, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantity"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtQuant)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(20, 122)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel7.Size = New System.Drawing.Size(254, 32)
        Me.Panel7.TabIndex = 14
        '
        'txtTotals
        '
        Me.txtTotals.BackColor = System.Drawing.Color.Beige
        Me.txtTotals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotals.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtTotals.Enabled = False
        Me.txtTotals.Location = New System.Drawing.Point(117, 5)
        Me.txtTotals.Name = "txtTotals"
        Me.txtTotals.ReadOnly = True
        Me.txtTotals.Size = New System.Drawing.Size(132, 23)
        Me.txtTotals.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Roboto", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(5, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 22)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Totals"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.txtTotals)
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(20, 154)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel8.Size = New System.Drawing.Size(254, 32)
        Me.Panel8.TabIndex = 15
        '
        'btnCompute
        '
        Me.btnCompute.BackColor = System.Drawing.Color.Transparent
        Me.btnCompute.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnCompute.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompute.Location = New System.Drawing.Point(5, 5)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(107, 38)
        Me.btnCompute.TabIndex = 10
        Me.btnCompute.Text = "Process"
        Me.btnCompute.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btnAdd)
        Me.Panel4.Controls.Add(Me.btnCompute)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(20, 186)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel4.Size = New System.Drawing.Size(254, 48)
        Me.Panel4.TabIndex = 16
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnAdd.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(142, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 38)
        Me.btnAdd.TabIndex = 11
        Me.btnAdd.Text = "Add to Grid"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.Panel8)
        Me.GroupBox2.Controls.Add(Me.Panel7)
        Me.GroupBox2.Controls.Add(Me.Panel6)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(10, 87)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.GroupBox2.Size = New System.Drawing.Size(294, 266)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Roboto", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(5, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Inventory"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(10, 15)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel5.Size = New System.Drawing.Size(294, 32)
        Me.Panel5.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Beige
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(2, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(10, 15, 10, 15)
        Me.Panel1.Size = New System.Drawing.Size(316, 370)
        Me.Panel1.TabIndex = 16
        '
        'mainFrame
        '
        Me.mainFrame.BackColor = System.Drawing.Color.Azure
        Me.mainFrame.Controls.Add(Me.panelMain)
        Me.mainFrame.Dock = System.Windows.Forms.DockStyle.Fill
        Me.mainFrame.ForeColor = System.Drawing.SystemColors.ControlText
        Me.mainFrame.Location = New System.Drawing.Point(0, 0)
        Me.mainFrame.Name = "mainFrame"
        Me.mainFrame.Padding = New System.Windows.Forms.Padding(10)
        Me.mainFrame.Size = New System.Drawing.Size(859, 394)
        Me.mainFrame.TabIndex = 1
        '
        'panelMain
        '
        Me.panelMain.AutoSize = True
        Me.panelMain.BackColor = System.Drawing.Color.Beige
        Me.panelMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panelMain.Controls.Add(Me.Panel10)
        Me.panelMain.Controls.Add(Me.Panel1)
        Me.panelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMain.Location = New System.Drawing.Point(10, 10)
        Me.panelMain.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.panelMain.Name = "panelMain"
        Me.panelMain.Padding = New System.Windows.Forms.Padding(2)
        Me.panelMain.Size = New System.Drawing.Size(839, 374)
        Me.panelMain.TabIndex = 16
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 394)
        Me.Controls.Add(Me.mainFrame)
        Me.Name = "Form1"
        Me.Text = "Main Form"
        CType(Me.dtGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.mainFrame.ResumeLayout(False)
        Me.mainFrame.PerformLayout()
        Me.panelMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtGrid1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbProd As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtQuant As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtTotals As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btnCompute As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents mainFrame As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents panelMain As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents dtDesc As DataGridViewTextBoxColumn
    Friend WithEvents dtPrices As DataGridViewTextBoxColumn
    Friend WithEvents dtQuant As DataGridViewTextBoxColumn
    Friend WithEvents dtTotal As DataGridViewTextBoxColumn
End Class
