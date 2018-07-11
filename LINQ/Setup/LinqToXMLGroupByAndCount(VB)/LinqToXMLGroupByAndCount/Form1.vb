Public Class Form1

    Private Sub btnCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCount.Click
        Dim users As XDocument = XDocument.Load("users.xml")
        Dim q = From u In users.Descendants("row")
                Group u By key = u.Attribute("address").Value
                    Into Group
                    Select Address = key, Count = Group.Count()

        DataGridView1.DataSource = q.ToList()
    End Sub
End Class
