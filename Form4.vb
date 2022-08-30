Public Class employee
    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlClient.SqlConnection("Data Source=LAPTOP-7MT6MDDS\SQLEXPRESS;Initial Catalog=connectiondb;Integrated Security=True;MultipleActiveResultSets=true;")

        conn.Open()
        query = "select pincode,count(username) as number_of_orders from dbo.Datasheet_Prices_adress group by pincode;"

        cmd = New SqlClient.SqlCommand(query, conn)
        adapter.SelectCommand = cmd
        adapter.Fill(dbDataSet)
        bsource.DataSource = dbDataSet
        DataGridView1.DataSource = bsource


        query = " select comboID,count(comboID) from dbo.projorders group by comboID;"
        cmd = New SqlClient.SqlCommand(query, conn)
        adapter.SelectCommand = cmd
        adapter.Fill(dbDataSet)
        bsource.DataSource = dbDataSet
        DataGridView2.DataSource = bsource
        conn.Close()

    End Sub
End Class
