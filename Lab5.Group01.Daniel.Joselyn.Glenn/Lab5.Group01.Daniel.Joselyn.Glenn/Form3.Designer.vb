<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblFilterTable = New System.Windows.Forms.Label()
        Me.cbxProjectName = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lblWorkCategory = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ckbxMulti = New System.Windows.Forms.CheckBox()
        Me.btnAddTimeEntry = New System.Windows.Forms.Button()
        Me.dgvTimeReport = New System.Windows.Forms.DataGridView()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgvTimeReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Location = New System.Drawing.Point(32, 53)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(71, 13)
        Me.lblProjectName.TabIndex = 0
        Me.lblProjectName.Text = "Project Name"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(32, 92)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date"
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(32, 126)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(35, 13)
        Me.lblHours.TabIndex = 2
        Me.lblHours.Text = "Hours"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(32, 160)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(60, 13)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = "Description"
        '
        'lblFilterTable
        '
        Me.lblFilterTable.AutoSize = True
        Me.lblFilterTable.Location = New System.Drawing.Point(32, 247)
        Me.lblFilterTable.Name = "lblFilterTable"
        Me.lblFilterTable.Size = New System.Drawing.Size(72, 13)
        Me.lblFilterTable.TabIndex = 4
        Me.lblFilterTable.Text = "Filter table by:"
        '
        'cbxProjectName
        '
        Me.cbxProjectName.FormattingEnabled = True
        Me.cbxProjectName.Location = New System.Drawing.Point(140, 50)
        Me.cbxProjectName.Name = "cbxProjectName"
        Me.cbxProjectName.Size = New System.Drawing.Size(121, 21)
        Me.cbxProjectName.TabIndex = 5
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(140, 92)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpDate.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(140, 129)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(60, 20)
        Me.TextBox1.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 160)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(284, 20)
        Me.TextBox2.TabIndex = 8
        '
        'lblWorkCategory
        '
        Me.lblWorkCategory.AutoSize = True
        Me.lblWorkCategory.Location = New System.Drawing.Point(222, 132)
        Me.lblWorkCategory.Name = "lblWorkCategory"
        Me.lblWorkCategory.Size = New System.Drawing.Size(78, 13)
        Me.lblWorkCategory.TabIndex = 9
        Me.lblWorkCategory.Text = "Work Category"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(303, 127)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'ckbxMulti
        '
        Me.ckbxMulti.AutoSize = True
        Me.ckbxMulti.Location = New System.Drawing.Point(355, 95)
        Me.ckbxMulti.Name = "ckbxMulti"
        Me.ckbxMulti.Size = New System.Drawing.Size(84, 17)
        Me.ckbxMulti.TabIndex = 11
        Me.ckbxMulti.Text = "Multiple Day"
        Me.ckbxMulti.UseVisualStyleBackColor = True
        '
        'btnAddTimeEntry
        '
        Me.btnAddTimeEntry.Location = New System.Drawing.Point(364, 222)
        Me.btnAddTimeEntry.Name = "btnAddTimeEntry"
        Me.btnAddTimeEntry.Size = New System.Drawing.Size(135, 27)
        Me.btnAddTimeEntry.TabIndex = 12
        Me.btnAddTimeEntry.Text = "Add Time Entry"
        Me.btnAddTimeEntry.UseVisualStyleBackColor = True
        '
        'dgvTimeReport
        '
        Me.dgvTimeReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimeReport.Location = New System.Drawing.Point(35, 278)
        Me.dgvTimeReport.Name = "dgvTimeReport"
        Me.dgvTimeReport.Size = New System.Drawing.Size(721, 120)
        Me.dgvTimeReport.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(111, 247)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 14
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(776, 416)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.dgvTimeReport)
        Me.Controls.Add(Me.btnAddTimeEntry)
        Me.Controls.Add(Me.ckbxMulti)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lblWorkCategory)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.cbxProjectName)
        Me.Controls.Add(Me.lblFilterTable)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblProjectName)
        Me.Name = "Form3"
        Me.Text = "Time Report"
        CType(Me.dgvTimeReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblProjectName As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblHours As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblFilterTable As System.Windows.Forms.Label
    Friend WithEvents cbxProjectName As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lblWorkCategory As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ckbxMulti As System.Windows.Forms.CheckBox
    Friend WithEvents btnAddTimeEntry As System.Windows.Forms.Button
    Friend WithEvents dgvTimeReport As System.Windows.Forms.DataGridView
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
End Class
