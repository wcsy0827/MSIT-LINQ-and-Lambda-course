Public Class Form1

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Dim dc As New DataClasses1DataContext

        dc.Log = Console.Out

        Dim query = From c In dc.Customers() _
                    Where Not (From o In dc.Orders _
                    Select o.CustomerID).Contains(c.CustomerID) _
                    Select c

        DataGridView1.DataSource = query.ToList()
    End Sub
End Class
