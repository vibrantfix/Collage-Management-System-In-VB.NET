﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Teacher
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Teacher))
        Me.AddFacultyButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LoadButton1 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AddFacultyButton1
        '
        Me.AddFacultyButton1.AutoRoundedCorners = True
        Me.AddFacultyButton1.BorderRadius = 17
        Me.AddFacultyButton1.CheckedState.Parent = Me.AddFacultyButton1
        Me.AddFacultyButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddFacultyButton1.CustomImages.Parent = Me.AddFacultyButton1
        Me.AddFacultyButton1.FillColor = System.Drawing.Color.SlateBlue
        Me.AddFacultyButton1.FillColor2 = System.Drawing.Color.SlateBlue
        Me.AddFacultyButton1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFacultyButton1.ForeColor = System.Drawing.Color.White
        Me.AddFacultyButton1.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.AddFacultyButton1.HoverState.FillColor2 = System.Drawing.Color.Orchid
        Me.AddFacultyButton1.HoverState.Parent = Me.AddFacultyButton1
        Me.AddFacultyButton1.Location = New System.Drawing.Point(737, 81)
        Me.AddFacultyButton1.Name = "AddFacultyButton1"
        Me.AddFacultyButton1.PressedColor = System.Drawing.Color.Turquoise
        Me.AddFacultyButton1.PressedDepth = 100
        Me.AddFacultyButton1.ShadowDecoration.Parent = Me.AddFacultyButton1
        Me.AddFacultyButton1.Size = New System.Drawing.Size(157, 37)
        Me.AddFacultyButton1.TabIndex = 7
        Me.AddFacultyButton1.Text = "ADD"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel5.Controls.Add(Me.LoadButton1)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Controls.Add(Me.AddFacultyButton1)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1152, 131)
        Me.Panel5.TabIndex = 6
        '
        'LoadButton1
        '
        Me.LoadButton1.AutoRoundedCorners = True
        Me.LoadButton1.BorderRadius = 16
        Me.LoadButton1.CheckedState.Parent = Me.LoadButton1
        Me.LoadButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LoadButton1.CustomImages.Parent = Me.LoadButton1
        Me.LoadButton1.FillColor = System.Drawing.Color.DarkTurquoise
        Me.LoadButton1.FillColor2 = System.Drawing.Color.RoyalBlue
        Me.LoadButton1.Font = New System.Drawing.Font("Open Sans Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadButton1.ForeColor = System.Drawing.Color.White
        Me.LoadButton1.HoverState.FillColor = System.Drawing.Color.Orchid
        Me.LoadButton1.HoverState.FillColor2 = System.Drawing.Color.SlateBlue
        Me.LoadButton1.HoverState.Parent = Me.LoadButton1
        Me.LoadButton1.Location = New System.Drawing.Point(461, 83)
        Me.LoadButton1.Name = "LoadButton1"
        Me.LoadButton1.PressedColor = System.Drawing.Color.Teal
        Me.LoadButton1.PressedDepth = 50
        Me.LoadButton1.ShadowDecoration.Parent = Me.LoadButton1
        Me.LoadButton1.Size = New System.Drawing.Size(142, 35)
        Me.LoadButton1.TabIndex = 19
        Me.LoadButton1.Text = "Refresh"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label1.Location = New System.Drawing.Point(586, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Faculty List"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 59)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label8.Location = New System.Drawing.Point(92, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 37)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Faculties"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 131)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1152, 523)
        Me.DataGridView1.TabIndex = 18
        '
        'Teacher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1152, 654)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Teacher"
        Me.Text = "Teacher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddFacultyButton1 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LoadButton1 As Guna.UI2.WinForms.Guna2GradientButton
End Class
