Imports MySql.Data.MySqlClient

Public Class Form1

    Dim dataAt As String

    Sub listarAgendadas()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Try
            Abrir()
            da = New MySqlDataAdapter("SELECT * FROM agendamento WHERE situacao = 0", con)
            da.Fill(dt)
            dgAgendadas.DataSource = dt

            formataAg()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar" + ex.Message)
            Fechar()
        End Try
    End Sub

    Sub listarConcluidas()
        Dim dt As New DataTable
        Dim da As New MySqlDataAdapter

        Try
            Abrir()
            da = New MySqlDataAdapter("SELECT * FROM agendamento WHERE situacao = 1", con)
            da.Fill(dt)
            dgConcluidas.DataSource = dt

            formataCo()
        Catch ex As Exception
            MessageBox.Show("Erro ao listar" + ex.Message)
            Fechar()
        End Try
    End Sub

    Sub formataAg()
        dgAgendadas.Columns(0).Visible = False
        dgAgendadas.Columns(4).Visible = False

        dgAgendadas.Columns(1).HeaderText = "Tarefa"
        dgAgendadas.Columns(2).HeaderText = "Descrição"
        dgAgendadas.Columns(3).HeaderText = "Data"
    End Sub

    Sub formataCo()
        dgConcluidas.Columns(0).Visible = False
        dgConcluidas.Columns(4).Visible = False

        dgConcluidas.Columns(1).HeaderText = "Tarefa"
        dgConcluidas.Columns(2).HeaderText = "Descrição"
        dgConcluidas.Columns(3).HeaderText = "Conclusão"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarAgendadas()
        listarConcluidas()

        dataAt = Now.ToShortDateString

        btnConcluir.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        Form2.ShowDialog()

        listarAgendadas()
        listarConcluidas()

        txtId.Text = ""
        btnConcluir.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        idTask = txtId.Text
        tarefa = dgAgendadas.CurrentRow.Cells(1).Value
        descricao = dgAgendadas.CurrentRow.Cells(2).Value
        data = dgAgendadas.CurrentRow.Cells(3).Value
        Form2.ShowDialog()

        listarAgendadas()
        listarConcluidas()
        txtId.Text = ""

        btnConcluir.Enabled = False
        btnEditar.Enabled = False
        btnExcluir.Enabled = False
    End Sub

    Private Sub btnConcluir_Click(sender As Object, e As EventArgs) Handles btnConcluir.Click

        Dim cmd As MySqlCommand
        Dim sql As String

        Try
            Abrir()
            sql = "UPDATE agendamento SET data = '" & dataAt & "', situacao = '" & "1" & "' WHERE id = '" & txtId.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Tarefa Concluída com Sucesso!")

            listarAgendadas()
            listarConcluidas()

            txtId.Text = ""
            btnConcluir.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Erro ao Salvar" + ex.Message)
            Fechar()
        End Try

    End Sub

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Dim cmd As MySqlCommand
        Dim sql As String

        Try
            Abrir()
            sql = "DELETE FROM agendamento WHERE id = '" & txtId.Text & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Tarefa Excluída com Sucesso!")

            listarAgendadas()
            listarConcluidas()

            txtId.Text = ""
            btnConcluir.Enabled = False
            btnEditar.Enabled = False
            btnExcluir.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Erro ao Salvar" + ex.Message)
            Fechar()
        End Try
    End Sub

    Private Sub dgAgendadas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgAgendadas.CellClick
        txtId.Text = dgAgendadas.CurrentRow.Cells(0).Value

        btnConcluir.Enabled = True
        btnEditar.Enabled = True
        btnExcluir.Enabled = True
    End Sub

    Private Sub dgConcluidas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgConcluidas.CellClick
        txtId.Text = dgConcluidas.CurrentRow.Cells(0).Value

        btnExcluir.Enabled = True
    End Sub
End Class
