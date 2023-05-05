Public Class Form2

    Private textFile As String = Application.StartupPath & "\textfile.text"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbcourse.Items.Add("BSCS")
        cbcourse.Items.Add("BSIT")
        cbcourse.Items.Add("BSIS")
        cbcourse.Items.Add("BSCpE")

        cbyear.Items.Add("First")
        cbyear.Items.Add("Second")
        cbyear.Items.Add("Third")
        cbyear.Items.Add("Fourth")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ListView1.Items.Count = 0 Then
            Dim item1 As ListViewItem
            item1 = ListView1.Items.Add(TextBox1.Text)
            item1.SubItems.Add(TextBox2.Text)
            item1.SubItems.Add(cbcourse.Text)
            item1.SubItems.Add(cbyear.Text)
            item1 = Nothing
        Else
            With ListView1
                Dim additem As ListViewItem
                additem = .FindItemWithText(TextBox1.Text, True, 0, True)
                If Not additem Is Nothing Then
                    MessageBox.Show("Student " & TextBox1.Text & " already in the course", "course list", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                Else

                    Dim item1 As ListViewItem
                    item1 = ListView1.Items.Add(TextBox1.Text)
                    item1.SubItems.Add(TextBox2.Text)
                    item1.SubItems.Add(cbcourse.Text)
                    item1.SubItems.Add(cbyear.Text)
                    item1 = Nothing
                End If
            End With
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cbcourse.Text = ""
        cbyear.Text = ""
        TextBox1.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit?", "close application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iExit = Windows.Forms.DialogResult.Yes Then
            Application.Exit()

        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            btnRemove.Enabled = True
        Else
            btnRemove.Enabled = False
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim itemToRemove As ListViewItem = ListView1.SelectedItems(0)
            ListView1.Items.Remove(itemToRemove)
        Else
            MessageBox.Show("Please select an item to remove.")
        End If
        For Each item As ListViewItem In ListView1.Items
            item.Selected = True
        Next

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim mywriter As New IO.StreamWriter(textFile)
        For Each item1 As ListViewItem In ListView1.Items
            mywriter.WriteLine(item1.Text & " * " & item1.SubItems(1).Text & " * " & item1.SubItems(2).Text & " * " & item1.SubItems(3).Text)
        Next
        mywriter.Close()

        MessageBox.Show("Data saved successfully.")
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class