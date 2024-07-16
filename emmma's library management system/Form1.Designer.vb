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
        Me.Title = New System.Windows.Forms.Label()
        Me.Author = New System.Windows.Forms.Label()
        Me.YearPublished = New System.Windows.Forms.Label()
        Me.Genre = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtYearPublished = New System.Windows.Forms.TextBox()
        Me.txtGenre = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.dvgBooks = New System.Windows.Forms.DataGridView()
        CType(Me.dvgBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Location = New System.Drawing.Point(12, 27)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(34, 20)
        Me.Title.TabIndex = 0
        Me.Title.Text = "title"
        '
        'Author
        '
        Me.Author.AutoSize = True
        Me.Author.Location = New System.Drawing.Point(12, 76)
        Me.Author.Name = "Author"
        Me.Author.Size = New System.Drawing.Size(57, 20)
        Me.Author.TabIndex = 1
        Me.Author.Text = "Author"
        '
        'YearPublished
        '
        Me.YearPublished.AutoSize = True
        Me.YearPublished.Location = New System.Drawing.Point(12, 111)
        Me.YearPublished.Name = "YearPublished"
        Me.YearPublished.Size = New System.Drawing.Size(112, 20)
        Me.YearPublished.TabIndex = 2
        Me.YearPublished.Text = "YearPublished"
        '
        'Genre
        '
        Me.Genre.AutoSize = True
        Me.Genre.Location = New System.Drawing.Point(12, 154)
        Me.Genre.Name = "Genre"
        Me.Genre.Size = New System.Drawing.Size(54, 20)
        Me.Genre.TabIndex = 3
        Me.Genre.Text = "Genre"
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(172, 70)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(100, 26)
        Me.txtAuthor.TabIndex = 4
        '
        'txtYearPublished
        '
        Me.txtYearPublished.Location = New System.Drawing.Point(172, 108)
        Me.txtYearPublished.Name = "txtYearPublished"
        Me.txtYearPublished.Size = New System.Drawing.Size(100, 26)
        Me.txtYearPublished.TabIndex = 5
        '
        'txtGenre
        '
        Me.txtGenre.Location = New System.Drawing.Point(172, 151)
        Me.txtGenre.Name = "txtGenre"
        Me.txtGenre.Size = New System.Drawing.Size(100, 26)
        Me.txtGenre.TabIndex = 6
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(172, 21)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(100, 26)
        Me.txtTitle.TabIndex = 7
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(369, 21)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 26)
        Me.btnAdd.TabIndex = 8
        Me.btnAdd.Text = "add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(369, 70)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 35)
        Me.btnUpdate.TabIndex = 9
        Me.btnUpdate.Text = "update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(369, 111)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 34)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(369, 151)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 35)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'dvgBooks
        '
        Me.dvgBooks.AllowUserToAddRows = False
        Me.dvgBooks.AllowUserToDeleteRows = False
        Me.dvgBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dvgBooks.Location = New System.Drawing.Point(91, 238)
        Me.dvgBooks.Name = "dvgBooks"
        Me.dvgBooks.ReadOnly = True
        Me.dvgBooks.RowHeadersWidth = 62
        Me.dvgBooks.RowTemplate.Height = 28
        Me.dvgBooks.Size = New System.Drawing.Size(459, 150)
        Me.dvgBooks.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dvgBooks)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtGenre)
        Me.Controls.Add(Me.txtYearPublished)
        Me.Controls.Add(Me.txtAuthor)
        Me.Controls.Add(Me.Genre)
        Me.Controls.Add(Me.YearPublished)
        Me.Controls.Add(Me.Author)
        Me.Controls.Add(Me.Title)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dvgBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents Author As Label
    Friend WithEvents YearPublished As Label
    Friend WithEvents Genre As Label
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYearPublished As TextBox
    Friend WithEvents txtGenre As TextBox
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dvgBooks As DataGridView
End Class
