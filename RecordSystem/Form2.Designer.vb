<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        btnAdd = New Button()
        btnClear = New Button()
        btnExit = New Button()
        btnRemove = New Button()
        btnSave = New Button()
        ListView1 = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        cbcourse = New ComboBox()
        cbyear = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(29, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 17)
        Label1.TabIndex = 0
        Label1.Text = "Roll No."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.Navy
        Label2.Location = New Point(30, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 17)
        Label2.TabIndex = 1
        Label2.Text = "Name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.Navy
        Label3.Location = New Point(30, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 17)
        Label3.TabIndex = 2
        Label3.Text = "Degree"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.Navy
        Label4.Location = New Point(35, 269)
        Label4.Name = "Label4"
        Label4.Size = New Size(38, 17)
        Label4.TabIndex = 3
        Label4.Text = "Year"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.Navy
        Label5.Location = New Point(25, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(223, 20)
        Label5.TabIndex = 4
        Label5.Text = "Record Management System"
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnAdd.ForeColor = Color.Navy
        btnAdd.Location = New Point(122, 310)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 33)
        btnAdd.TabIndex = 6
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnClear.ForeColor = Color.Navy
        btnClear.Location = New Point(122, 355)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 33)
        btnClear.TabIndex = 7
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.Navy
        btnExit.Location = New Point(122, 401)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 30)
        btnExit.TabIndex = 8
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnRemove.ForeColor = Color.Navy
        btnRemove.Location = New Point(668, 365)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(75, 33)
        btnRemove.TabIndex = 9
        btnRemove.Text = "REMOVE"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnSave.ForeColor = Color.Navy
        btnSave.Location = New Point(428, 365)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(75, 33)
        btnSave.TabIndex = 10
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        ListView1.Location = New Point(428, 30)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(315, 329)
        ListView1.TabIndex = 11
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "Roll No."
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Name"
        ColumnHeader2.Width = 130
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Degree"
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "Year"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(98, 100)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(121, 23)
        TextBox1.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(98, 149)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(121, 23)
        TextBox2.TabIndex = 13
        ' 
        ' cbcourse
        ' 
        cbcourse.FormattingEnabled = True
        cbcourse.Location = New Point(98, 207)
        cbcourse.Name = "cbcourse"
        cbcourse.Size = New Size(121, 23)
        cbcourse.TabIndex = 14
        ' 
        ' cbyear
        ' 
        cbyear.FormattingEnabled = True
        cbyear.Location = New Point(98, 266)
        cbyear.Name = "cbyear"
        cbyear.Size = New Size(121, 23)
        cbyear.TabIndex = 15
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Aquamarine
        ClientSize = New Size(800, 450)
        Controls.Add(cbyear)
        Controls.Add(cbcourse)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ListView1)
        Controls.Add(btnSave)
        Controls.Add(btnRemove)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnAdd)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cbcourse As ComboBox
    Friend WithEvents cbyear As ComboBox
    Friend WithEvents items1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
