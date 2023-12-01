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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy = New System.Windows.Forms.PictureBox()
        Me.Shooter = New System.Windows.Forms.PictureBox()
        Me.misil = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.enemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.misil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'enemy
        '
        Me.enemy.BackColor = System.Drawing.Color.Transparent
        Me.enemy.Image = CType(resources.GetObject("enemy.Image"), System.Drawing.Image)
        Me.enemy.Location = New System.Drawing.Point(307, 12)
        Me.enemy.Name = "enemy"
        Me.enemy.Size = New System.Drawing.Size(51, 52)
        Me.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemy.TabIndex = 4
        Me.enemy.TabStop = False
        '
        'Shooter
        '
        Me.Shooter.BackColor = System.Drawing.Color.Transparent
        Me.Shooter.Image = CType(resources.GetObject("Shooter.Image"), System.Drawing.Image)
        Me.Shooter.Location = New System.Drawing.Point(280, 288)
        Me.Shooter.Name = "Shooter"
        Me.Shooter.Size = New System.Drawing.Size(100, 113)
        Me.Shooter.TabIndex = 0
        Me.Shooter.TabStop = False
        '
        'misil
        '
        Me.misil.BackColor = System.Drawing.Color.Transparent
        Me.misil.Image = CType(resources.GetObject("misil.Image"), System.Drawing.Image)
        Me.misil.InitialImage = CType(resources.GetObject("misil.InitialImage"), System.Drawing.Image)
        Me.misil.Location = New System.Drawing.Point(324, 288)
        Me.misil.Name = "misil"
        Me.misil.Size = New System.Drawing.Size(19, 18)
        Me.misil.TabIndex = 1
        Me.misil.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Playbill", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(572, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tekan ENTER untuk memulai game"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(637, 417)
        Me.Panel1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(628, 413)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.misil)
        Me.Controls.Add(Me.Shooter)
        Me.Controls.Add(Me.enemy)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.enemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Shooter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.misil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents enemy As System.Windows.Forms.PictureBox
    Friend WithEvents Shooter As System.Windows.Forms.PictureBox
    Friend WithEvents misil As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
