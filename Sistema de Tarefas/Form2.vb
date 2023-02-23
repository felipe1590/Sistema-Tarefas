Imports MySql.Data.MySqlClient

Public Class Form2

    Sub limparCampos()
        txtId.Text = ""
        txtTarefa.Text = ""
        txtDescricao.Text = ""
        txtData.Text = Now.ToShortDateString
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtId.Text = idTask
        If txtId.Text <> "" Then
            txtTarefa.Text = tarefa
            txtDescricao.Text = descricao
            txtData.Text = data
        End If
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Dim cmd As MySqlCommand
        Dim sql As String

        If txtTarefa.Text = "" Then
            MessageBox.Show("Preenxa a tarefa para Salvar!")
            txtTarefa.Focus()
        ElseIf txtDescricao.Text = "" Then
            MessageBox.Show("Preenxa a descrição para Salvar!")
            txtDescricao.Focus()
        End If

        If txtId.Text = "" Then
            Try
                Abrir()
                sql = "INSERT INTO agendamento (tarefa, descricao, data, situacao) VALUES ('" & txtTarefa.Text & "', '" & txtDescricao.Text & "','" & txtData.Text & "','" & "0" & "')"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Tarefa Salva com Sucesso!")

                limparCampos()
                idTask = ""
            Catch ex As Exception
                MessageBox.Show("Erro ao Salvar" + ex.Message)
            End Try
        Else
            Try
                Abrir()
                sql = "UPDATE agendamento SET tarefa = '" & txtTarefa.Text & "', descricao = '" & txtDescricao.Text & "',data = '" & txtData.Text & "', situacao = '" & "0" & "' WHERE id = '" & txtId.Text & "'"
                cmd = New MySqlCommand(sql, con)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Tarefa Editada com Sucesso!")

                limparCampos()
                idTask = ""
            Catch ex As Exception
                MessageBox.Show("Erro ao Salvar" + ex.Message)
                Fechar()
            End Try
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limparCampos()
        idTask = ""
        Me.Close()
    End Sub
End Class