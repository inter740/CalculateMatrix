using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MatrixInt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel panel = (Panel)Master.FindControl("Panel1");
        Panel panel2 = (Panel)Master.FindControl("Panel2");
        panel.Visible = true;
        panel2.Visible = true;
    }

    protected void Master_CalculateBtn_Click(object sender, EventArgs e)
    {
        Master.SetMatrix(Service.PerformOperation(new ProductMatrixAndInt(Master.GetMatrix("A"), GetNumber())));
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Master.ContentCallEvent += new EventHandler(Master_CalculateBtn_Click);
    }

    public List<int> GetNumber()
    {
        TextBox mpTextBox;
        var mpContentPlaceHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
        var number = new List<int>();

            try
            {
                mpTextBox = (TextBox)mpContentPlaceHolder.FindControl("number");

                if (mpTextBox.Text == "")
                {
                    number.Add(0);
                }
                else
                {
                    number.Add(Int32.Parse(mpTextBox.Text));
                }
            }
            catch (Exception)
            {
                Response.Redirect("Default.aspx");
            }
        return number;
    }

}