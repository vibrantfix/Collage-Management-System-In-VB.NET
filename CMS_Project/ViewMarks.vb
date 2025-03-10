﻿Imports MySql.Data.MySqlClient

Public Class ViewMarks
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CalcalculateMarks_Click(sender As Object, e As EventArgs) Handles CalcalculateMarks.Click
        TotalTheory.Text = Convert.ToInt32(SubTMax1.Text) + Convert.ToInt32(SubTMax2.Text) + Convert.ToInt32(SubTMax3.Text) + Convert.ToInt32(SubTMax4.Text) + Convert.ToInt32(SubTMax5.Text) + Convert.ToInt32(SubTMax6.Text)
        TotalPractical.Text = Convert.ToInt32(SubPMax1.Text) + Convert.ToInt32(SubPMax2.Text) + Convert.ToInt32(SubPMax3.Text) + Convert.ToInt32(SubPMax4.Text) + Convert.ToInt32(SubPMax5.Text) + Convert.ToInt32(SubPMax6.Text)
        TotalObtainMarks.Text = Convert.ToInt32(SubOMarks1.Text) + Convert.ToInt32(SubOMarks2.Text) + Convert.ToInt32(SubOMarks3.Text) + Convert.ToInt32(SubOMarks4.Text) + Convert.ToInt32(SubOMarks5.Text) + Convert.ToInt32(SubOMarks6.Text)
        TotalObtinedPMarks.Text = Convert.ToInt32(SubOPMarks1.Text) + Convert.ToInt32(SubOPMarks2.Text) + Convert.ToInt32(SubOPMarks3.Text) + Convert.ToInt32(SubOPMarks4.Text) + Convert.ToInt32(SubOPMarks5.Text) + Convert.ToInt32(SubOPMarks6.Text)
        If TotalObtainMarks.Text < 210 Then
            MessageBox.Show(" Candidate Has FAILED ", "Result Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(" Candidate Has PASSED ", "Result Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If StudentID.Text = "" Or
                    StuNameTB.Text = "" Or
                    stuLastNameTB.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Delete the Record !", "Record Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "delete from cmsdbx.marks where studentid='" & StudentID.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Deleted in database", MsgBoxStyle.Information, "Record Deleted")
                    Me.Close()

                Else
                    MessageBox.Show("Operation Cancelled")
                End If

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Try
            If StudentID.Text = "" Or
                    StuNameTB.Text = "" Or
                    stuLastNameTB.Text = "" Then
                MessageBox.Show("Missing Information. Please load the data ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Update the Record !", "Record Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "update marks set subject1_max_theory_marks='" & SubTMax1.Text & "',subject1_theory_marks='" & SubOMarks1.Text & "',subject1_max_practical_marks='" & SubPMax1.Text & "',subject1_practical_marks='" & SubOPMarks1.Text & "',subject2_max_theory_marks='" & SubTMax2.Text & "',subject2_theory_marks='" & SubOMarks2.Text & "',subject2_max_practical_marks='" & SubPMax2.Text & "',subject2_practical_marks='" & SubOPMarks2.Text & "',subject3_max_theory_marks='" & SubTMax3.Text & "',subject3_theory_marks='" & SubOMarks3.Text & "',subject3_max_practical_marks='" & SubPMax3.Text & "',subject3_practical_marks='" & SubOPMarks3.Text & "',subject4_max_theory_marks='" & SubTMax4.Text & "',subject4_theory_marks='" & SubOMarks4.Text & "',subject4_max_practical_marks='" & SubPMax4.Text & "',subject4_practical_marks='" & SubOPMarks4.Text & "',subject5_max_theory_marks='" & SubTMax5.Text & "',subject5_theory_marks='" & SubOMarks5.Text & "',subject5_max_practical_marks='" & SubPMax5.Text & "',subject5_practical_marks='" & SubOPMarks5.Text & "',subject6_max_theory_marks='" & SubTMax6.Text & "',subject6_theory_marks='" & SubOMarks6.Text & "',subject6_max_practical_marks='" & SubPMax6.Text & "',subject6_practical_marks='" & SubOPMarks6.Text & "',total_max_theory_marks='" & TotalTheory.Text & "',total_theory_marks='" & TotalObtainMarks.Text & "',total_max_practical_marks='" & TotalPractical.Text & "',total_practical_marks='" & TotalObtinedPMarks.Text & "' where studentid='" & StudentID.Text & "'"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Updated in database", MsgBoxStyle.Information, "Record Updated")
                    Me.Close()
                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try

    End Sub

    Private Sub ViewMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentID.Enabled = False
        StuNameTB.Enabled = False
        stuLastNameTB.Enabled = False
        CourseTB.Enabled = False
        SemorYear.Enabled = False
        SubTB1.Enabled = False
        SubTB2.Enabled = False
        SubTB3.Enabled = False
        SubTB4.Enabled = False
        SubTB5.Enabled = False
        SubTB6.Enabled = False
    End Sub

    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click
        MessageBox.Show("OOPS! Something Went Wrong  ¯\_(ツ)_/¯ ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub SubOMarks1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOMarks1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOMarks2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOMarks2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOMarks3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOMarks3.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOMarks4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOMarks4.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOMarks5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOMarks5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOMarks6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOMarks6.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub SubOPMarks1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOPMarks1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOPMarks2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOPMarks2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOPMarks3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOPMarks3.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOPMarks4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOPMarks4.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOPMarks5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOPMarks5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubOPMarks6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubOPMarks6.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubTMax1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubTMax1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub SubTMax2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubTMax2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub SubTMax3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubTMax3.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub SubTMax4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubTMax4.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub SubTMax5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubTMax5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub SubTMax6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubTMax6.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubPMax1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubPMax1.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubPMax2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubPMax2.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubPMax3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubPMax3.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubPMax4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubPMax4.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubPMax5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubPMax5.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub SubPMax6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles SubPMax6.KeyPress
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Char.IsNumber(e.KeyChar) Then
            Else
                MessageBox.Show("Invalid Input ! Enter Number Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                e.Handled = True
            End If
        End If
    End Sub

End Class