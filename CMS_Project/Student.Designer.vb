﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Student
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Student))
        Me.AddStudentButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RefreshButton = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddStudentButton
        '
        Me.AddStudentButton.AutoRoundedCorners = True
        Me.AddStudentButton.BorderRadius = 17
        Me.AddStudentButton.CheckedState.Parent = Me.AddStudentButton
        Me.AddStudentButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddStudentButton.CustomImages.Parent = Me.AddStudentButton
        Me.AddStudentButton.FillColor = System.Drawing.Color.SlateBlue
        Me.AddStudentButton.FillColor2 = System.Drawing.Color.SlateBlue
        Me.AddStudentButton.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentButton.ForeColor = System.Drawing.Color.White
        Me.AddStudentButton.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.AddStudentButton.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.AddStudentButton.HoverState.Parent = Me.AddStudentButton
        Me.AddStudentButton.Location = New System.Drawing.Point(662, 81)
        Me.AddStudentButton.Name = "AddStudentButton"
        Me.AddStudentButton.PressedColor = System.Drawing.Color.Turquoise
        Me.AddStudentButton.PressedDepth = 100
        Me.AddStudentButton.ShadowDecoration.Parent = Me.AddStudentButton
        Me.AddStudentButton.Size = New System.Drawing.Size(157, 37)
        Me.AddStudentButton.TabIndex = 7
        Me.AddStudentButton.Text = "ADD"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.RefreshButton)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.AddStudentButton)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1100, 131)
        Me.Panel5.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(532, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 37)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Student List"
        '
        'RefreshButton
        '
        Me.RefreshButton.Animated = True
        Me.RefreshButton.AutoRoundedCorners = True
        Me.RefreshButton.BorderRadius = 16
        Me.RefreshButton.CheckedState.Parent = Me.RefreshButton
        Me.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RefreshButton.CustomImages.Parent = Me.RefreshButton
        Me.RefreshButton.FillColor = System.Drawing.Color.DarkTurquoise
        Me.RefreshButton.FillColor2 = System.Drawing.Color.RoyalBlue
        Me.RefreshButton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshButton.ForeColor = System.Drawing.Color.White
        Me.RefreshButton.HoverState.FillColor = System.Drawing.Color.Turquoise
        Me.RefreshButton.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.RefreshButton.HoverState.Parent = Me.RefreshButton
        Me.RefreshButton.Location = New System.Drawing.Point(429, 81)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.PressedColor = System.Drawing.Color.Teal
        Me.RefreshButton.PressedDepth = 50
        Me.RefreshButton.ShadowDecoration.Parent = Me.RefreshButton
        Me.RefreshButton.Size = New System.Drawing.Size(130, 35)
        Me.RefreshButton.TabIndex = 13
        Me.RefreshButton.Text = "Refresh"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 61)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label8.Location = New System.Drawing.Point(80, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 37)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Students"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1100, 523)
        Me.DataGridView1.TabIndex = 7
        '
        'Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 654)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Student"
        Me.Text = "Student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AddStudentButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RefreshButton As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
