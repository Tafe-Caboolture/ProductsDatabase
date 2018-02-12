using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace ProductsDatabase
{
    public partial class Default : System.Web.UI.Page
    {

        // don't add any instance variables either
        //they wont work the way you expect them to
        //will be explained in a coming lesson

        protected void Page_Load(object sender, EventArgs e)
        {
            // don't put anything in here for todays lesson
        }

        protected void btnFirst_Click(object sender, EventArgs e)
        {
            // get file path of database using server side functions
            var dbFile = Server.MapPath("~/App_Data/Products.accdb");
            //server map Path accepts relative paths
            //it will return where the path specified is on the server
            // with the ~ representing the root of our web site
            var constring = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFile}";
            var query = "SELECT TOP 1 * FROM tblProducts";
            // using statements like this one will automatically dispose of objects
            // that are created (such as our db object
            //objects that implement the Disposable interface may have special
            //behaviour for when they are disposed for example
            // ADO.NET connection objects will usually disconnect when they're done
            using (var db = new OleDbConnection(constring))
            {
                db.Open();

                // we dont really need the command object
                // so we can combine the using statement with the method chaining
                //to only get a useful reader object
                using (var reader = new OleDbCommand(query, db).ExecuteReader())
                {
                    reader.Read();
                    lblID.Text = reader["ProductID"].ToString();
                    txtName.Text = reader["ProductName"].ToString();
                    txtPrice.Text = reader["ProductPrice"].ToString();
                }
            }
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {

        }

        protected void btnLast_Click(object sender, EventArgs e)
        {
            // get file path of database using server side functions
            var dbFile = Server.MapPath("~/App_Data/Products.accdb");
            //server map Path accepts relative paths
            //it will return where the path specified is on the server
            // with the ~ representing the root of our web site
            var constring = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={dbFile}";
            var query = "SELECT * FROM tblProducts ORDER BY ProductID DESC";
            // using statements like this one will automatically dispose of objects
            // that are created (such as our db object
            //objects that implement the Disposable interface may have special
            //behaviour for when they are disposed for example
            // ADO.NET connection objects will usually disconnect when they're done
            using (var db = new OleDbConnection(constring))
            {
                db.Open();

                // we dont really need the command object
                // so we can combine the using statement with the method chaining
                //to only get a useful reader object
                using (var reader = new OleDbCommand(query, db).ExecuteReader())
                {
                    reader.Read();
                    lblID.Text = reader["ProductID"].ToString();
                    txtName.Text = reader["ProductName"].ToString();
                    txtPrice.Text = reader["ProductPrice"].ToString();
                }
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {

        }

        protected void btnNew_Click(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}