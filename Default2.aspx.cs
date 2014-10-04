using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Default2 : System.Web.UI.Page
{
    //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
    //SqlConnection con = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Hello;Integrated Security=True");
    SqlConnection con = new SqlConnection(@"Server=8c077aa3-4c9f-40fa-8653-a3b9012cf1a7.sqlserver.sequelizer.com;Database=db8c077aa34c9f40fa8653a3b9012cf1a7;User ID=nngqkiwdklvnsdob;Password=ZQBteW2YU5pWggSFWCMkMka3VGBdRLXFWQ8a5xmSLy3AfdatRsRoBwyPPGFDtWhi;");
    SqlCommand cmd;
    SqlDataAdapter da;
    DataTable dt;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            FillGridview();
        }
    }

    public void FillGridview()
    {
        cmd = new SqlCommand("select * from tblProducts;", con);
        da = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}