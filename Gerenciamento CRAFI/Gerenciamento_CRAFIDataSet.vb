Partial Public Class Gerenciamento_CRAFIDataSet
End Class

Namespace Gerenciamento_CRAFIDataSetTableAdapters

    Partial Class QueriesTableAdapter

        Public Sub changeConnection(ByVal strConn As String)
            Dim i As Integer
            For i = 0 To 16
                Me.CommandCollection(i).Connection.ConnectionString = strConn
            Next
        End Sub

    End Class
End Namespace
