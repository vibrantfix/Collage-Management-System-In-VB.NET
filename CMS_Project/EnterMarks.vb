﻿Imports System.Windows.Controls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class EnterMarks
    Dim myconnection As New DTconnection
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
    Dim bSource As New BindingSource

    Private Sub Subject_load()
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                Dim subName = READER.GetString("subjectname")
                SubComboBox1.Items.Add(subName)
                SubComboBox2.Items.Add(subName)
                SubComboBox3.Items.Add(subName)
                SubComboBox4.Items.Add(subName)
                SubComboBox5.Items.Add(subName)
                SubComboBox6.Items.Add(subName)
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub StudentID_load()
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.students"
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                Dim sidName = READER.GetString("studentid")
                StudentIDCB.Items.Add(sidName)
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub EnterMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StudentID_load()
        Subject_load()
    End Sub
    Private Sub StudentIDCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentIDCB.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.students where studentid='" & StudentIDCB.Text & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                StuNameTB.Text = READER.GetString("firstname")
                stuLastNameTB.Text = READER.GetString("lastname")
                CourseTB.Text = READER.GetString("coursename")
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubComboBox1.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject where subjectname='" & SubComboBox1.Text & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                SubTMax1.Text = READER.GetString("theorymarks")
                SubPMax1.Text = READER.GetString("practicalmarks")
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubComboBox2.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject where subjectname='" & SubComboBox2.Text & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                SubTMax2.Text = READER.GetString("theorymarks")
                SubPMax2.Text = READER.GetString("practicalmarks")
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubComboBox3.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject where subjectname='" & SubComboBox3.Text & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                SubTMax3.Text = READER.GetString("theorymarks")
                SubPMax3.Text = READER.GetString("practicalmarks")
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubComboBox4.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject where subjectname='" & SubComboBox4.Text & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                SubTMax4.Text = READER.GetString("theorymarks")
                SubPMax4.Text = READER.GetString("practicalmarks")
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubComboBox5.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject where subjectname='" & SubComboBox5.Text & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                SubTMax5.Text = READER.GetString("theorymarks")
                SubPMax5.Text = READER.GetString("practicalmarks")
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SubComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubComboBox6.SelectedIndexChanged
        Dim READER As MySqlDataReader
        Try
            Dim query As String
            query = "SELECT * FROM cmsdbx.subject where subjectname='" & SubComboBox6.Text & "' "
            Dim cmd As MySqlCommand
            cmd = New MySqlCommand(query, myconnection.open)
            READER = cmd.ExecuteReader
            While READER.Read
                SubTMax6.Text = READER.GetString("theorymarks")
                SubPMax6.Text = READER.GetString("practicalmarks")
            End While
            myconnection.close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CalcalculateMarks_Click(sender As Object, e As EventArgs) Handles CalcalculateMarks.Click
        TotalTheory.Text = Convert.ToInt32(SubTMax1.Text) + Convert.ToInt32(SubTMax2.Text) + Convert.ToInt32(SubTMax3.Text) + Convert.ToInt32(SubTMax4.Text) + Convert.ToInt32(SubTMax5.Text) + Convert.ToInt32(SubTMax6.Text)
        TotalPractical.Text = Convert.ToInt32(SubPMax1.Text) + Convert.ToInt32(SubPMax2.Text) + Convert.ToInt32(SubPMax3.Text) + Convert.ToInt32(SubPMax4.Text) + Convert.ToInt32(SubPMax5.Text) + Convert.ToInt32(SubPMax6.Text)
        TotalObtainMarks.Text = Convert.ToInt32(SubOMarks1.Text) + Convert.ToInt32(SubOMarks2.Text) + Convert.ToInt32(SubOMarks3.Text) + Convert.ToInt32(SubOMarks4.Text) + Convert.ToInt32(SubOMarks5.Text) + Convert.ToInt32(SubOMarks6.Text)
        TotalObtinedPMarks.Text = Convert.ToInt32(SubOPMarks1.Text) + Convert.ToInt32(SubOPMarks2.Text) + Convert.ToInt32(SubOPMarks3.Text) + Convert.ToInt32(SubOPMarks4.Text) + Convert.ToInt32(SubOPMarks5.Text) + Convert.ToInt32(SubOPMarks6.Text)
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            If StudentIDCB.Text = "" Or
                    StuNameTB.Text = "" Then
                MessageBox.Show("Missing Information. Please fill all the fields ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim dialog As DialogResult
                dialog = MessageBox.Show("Do you want Save the Record !", "Record Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If dialog = DialogResult.Yes Then
                    Dim query = "insert into marks ( studentid, firstname, lastname, coursename, semoryear, subject1, subject1_theory_marks, subject1_practical_marks, subject2, subject2_theory_marks, subject2_practical_marks, subject3, subject3_theory_marks, subject3_practical_marks, subject4, subject4_theory_marks, subject4_practical_marks, subject5, subject5_theory_marks, subject5_practical_marks, subject6, subject6_theory_marks, subject6_practical_marks, total_theory_marks, total_practical_marks )value
                                                 ('" & StudentIDCB.Text & "','" & StuNameTB.Text & "','" & stuLastNameTB.Text & "','" & CourseTB.Text & "','" & SemYearCB.Text & "','" & SubComboBox1.Text & "','" & SubOMarks1.Text & "','" & SubOPMarks1.Text & "','" & SubComboBox2.Text & "','" & SubOMarks2.Text & "','" & SubOPMarks2.Text & "','" & SubComboBox3.Text & "','" & SubOMarks3.Text & "','" & SubOPMarks3.Text & "','" & SubComboBox4.Text & "','" & SubOMarks4.Text & "','" & SubOPMarks4.Text & "','" & SubComboBox5.Text & "','" & SubOMarks5.Text & "','" & SubOPMarks5.Text & "','" & SubComboBox6.Text & "','" & SubOMarks6.Text & "','" & SubOPMarks6.Text & "','" & TotalObtainMarks.Text & "','" & TotalObtinedPMarks.Text & "')"
                    Dim cmd As MySqlCommand
                    cmd = New MySqlCommand(query, myconnection.open)
                    cmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("Successfully Saved in database", MsgBoxStyle.Information, "Record Saved")

                Else
                    MessageBox.Show("Operation Cancelled")
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
        End Try
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class