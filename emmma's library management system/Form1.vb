Imports System.Data.SqlClient




Public Class Form1
        Dim sqlconn As SqlConnection
        Dim sqlcmd As SqlCommand
        Dim sqlRd As SqlDataReader
        Dim sqlDt As New DataTable
        Dim DtA As New SqlDataAdapter
        Dim sqlQuery As String

    Dim Server As String = "JENNINGS"
    Dim Database As String = "emmma"

    Private bitmap As Bitmap

        Private Sub updatetable()
            Try
                sqlconn = New SqlConnection()
                sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"

                sqlconn.Open()
                sqlcmd = New SqlCommand("SELECT * FROM Books", sqlconn)
                sqlRd = sqlcmd.ExecuteReader()

                sqlDt.Clear()
                sqlDt.Load(sqlRd)
                sqlRd.Close()
                sqlconn.Close()
                dvgBooks.DataSource = sqlDt

            Catch ex As Exception
                MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                End If
            End Try
        End Sub


        Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            updatetable()
        End Sub

        Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
            Try
                sqlconn = New SqlConnection()
                sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"

                sqlconn.Open()

                sqlQuery = "INSERT INTO Books (Title, Author, YearPublished, Genre) VALUES (@Title, @Author, @YearPublished, @Genre)"

                sqlcmd = New SqlCommand(sqlQuery, sqlconn)
                sqlcmd.Parameters.AddWithValue("@Title", Title.Text)
                sqlcmd.Parameters.AddWithValue("@Author", Author.Text)
            sqlcmd.Parameters.AddWithValue("@YearPublished", txtYearPublished.Text)
            sqlcmd.Parameters.AddWithValue("@Genre", Genre.Text)
                sqlcmd.ExecuteNonQuery()
                sqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                End If
            End Try

            updatetable()
        End Sub



        ' Fixing the btnUpdate_Click method
        Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


            updatetable()
        End Sub

        Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
            Try
                sqlconn = New SqlConnection()
                sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"

                sqlconn.Open()

                sqlQuery = "DELETE FROM Books WHERE Title = @Title"

                sqlcmd = New SqlCommand(sqlQuery, sqlconn)
                sqlcmd.Parameters.AddWithValue("@Author", Author.Text)
                sqlcmd.Parameters.AddWithValue("@Genre", Genre.Text)
            sqlcmd.Parameters.AddWithValue("@YearPublished", Integer.Parse(txtYearPublished.Text))
            sqlcmd.Parameters.AddWithValue("@Title", Title.Text)
                sqlcmd.ExecuteNonQuery()
                sqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                End If
            End Try

            updatetable()
        End Sub


        Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
            Try
                sqlconn = New SqlConnection()
                sqlconn.ConnectionString = $"Server={Server};Database={Database};Integrated Security=True;"

                sqlconn.Open()

                sqlQuery = "DELETE FROM Books"

                sqlcmd = New SqlCommand(sqlQuery, sqlconn)
                sqlcmd.ExecuteNonQuery()
                sqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "MSSQL Connector", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If sqlconn IsNot Nothing AndAlso sqlconn.State = ConnectionState.Open Then
                    sqlconn.Close()
                End If
            End Try

            updatetable()
        End Sub

    End Class

