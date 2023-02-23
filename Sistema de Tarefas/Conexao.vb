Imports MySql.Data.MySqlClient

Module Conexao

    Public con As New MySqlConnection("Server=localhost;Database=tarefas;userid=root;password=;")

    Sub Abrir()
        If con.State = 0 Then
            con.Open()
        End If
    End Sub

    Sub Fechar()
        If con.State = 1 Then
            con.Close()
        End If
    End Sub
End Module
