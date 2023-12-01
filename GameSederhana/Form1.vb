Public Class Form1
    Dim varX As Integer
    Dim rnd As Random = New Random

    Private Sub KeyDownEvent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Praktikum TIK 3"
        Label1.Text = "Tekan ENTER untuk memulai GAME"
        Shooter.Visible = False
        misil.Visible = False
    End Sub

    Private Sub KeyDownEvent1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            'MsgBox("And")
            panel1.Visible = False
            Shooter.Visible = True
            Shooter.Location = New Point(0, 300)
            misil.Location = New Point(40, 290)
            enemy.Location = New Point(rnd.Next(578), 10)
            Timer1.Enabled = True
        End If
        'keypad
        If e.KeyCode = Keys.Right Then
            Shooter.Left += 5
            varX = Shooter.Left + 40
            misil.Visible = False
        End If

        If e.KeyCode = Keys.Left Then
            Shooter.Left -= 5
            varX = Shooter.Left + 40
            misil.Visible = False
        End If

        If e.KeyCode = Keys.Space Then
            misil.Location = New Point(varX, 280)
            misil.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        misilShot()
        hit()
    End Sub

    Private Sub misilShot()
        If misil.Visible = True Then
            misil.Top -= 10
        End If

        If misil.Top = misil.Height < Me.ClientRectangle.Top Then
            misil.Visible = False
        End If
    End Sub

    Private Sub hit()

        If misil.Location = enemy.Location Then
            enemy.Location = New Point(rnd.Next(578), 10)
            misil.Visible = False
        End If

    End Sub

End Class
