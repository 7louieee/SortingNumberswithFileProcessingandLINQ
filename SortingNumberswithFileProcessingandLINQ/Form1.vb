Imports System.IO
Imports System.Linq

Public Class Form1

    Dim filePath As String = "numbers.txt"
    Private Sub btnAddNumber_Click(sender As Object, e As EventArgs) Handles btnAddNumber.Click
        Try

            Dim userInput As String = txtInput.Text.Trim()

            Dim number As Integer
            If Integer.TryParse(userInput, number) Then


                Using writer As New StreamWriter(filePath, True)
                    writer.WriteLine(number)
                End Using

                MessageBox.Show("Number added successfully.", "Input Sucess.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                txtInput.Clear()
            Else
                MessageBox.Show("Please enter a valid number.")
            End If

        Catch ex As Exception
            MessageBox.Show("Error while adding number: " & ex.Message, "Error Has Occured!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnSort_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Try

            Dim numbers As List(Of Integer) = New List(Of Integer)()

            Using reader As New StreamReader(filePath)
                While Not reader.EndOfStream
                    Dim line As String = reader.ReadLine()
                    If Integer.TryParse(line, Nothing) Then
                        numbers.Add(Integer.Parse(line))
                    End If
                End While
            End Using

            Dim sortedNumbers = numbers.OrderBy(Function(n) n).ToList()

            lstSortedNumbers.Items.Clear()
            For Each number In sortedNumbers
                lstSortedNumbers.Items.Add(number)
            Next

            MessageBox.Show("Numbers sorted and displayed.")

        Catch ex As Exception
            MessageBox.Show("Error while reading or sorting numbers: " & ex.Message)
        End Try

    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lstSortedNumbers.Items.Clear()

        Using reader As New StreamReader(filePath)
            Dim line As String = reader.ReadLine()
            While (line IsNot Nothing)
                lstSortedNumbers.Items.Add(line)
                line = reader.ReadLine()
            End While
        End Using


    End Sub
End Class
