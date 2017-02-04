using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MatrixMultiplication : Page
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
        Master.SetMatrix(Service.PerformOperation(new MultiplicationMatrix(Master.GetMatrix("A"), GetMatrix("B"))));
    }

    protected void Page_PreInit(object sender, EventArgs e)
    {
        Master.ContentCallEvent += new EventHandler(Master_CalculateBtn_Click);
    }

    private List<int> GetMatrix(string matrixIndex)
    {
        var Matrix = new List<int>();

        var mpContentPlaceHolder = (ContentPlaceHolder)Master.FindControl("ContentPlaceHolder1");
        TextBox mpTextBox;

            var textBoxIndex = 1;
            for (int i = 0; i < 9; i++)
            {
                try
                {
                    mpTextBox = (TextBox)mpContentPlaceHolder.FindControl("TextBox" + textBoxIndex.ToString() + "_matrix" + matrixIndex);

                    if (mpTextBox.Text == "")
                    {
                        Matrix.Add(0);
                    }
                    else
                    {
                        Matrix.Add(Int32.Parse(mpTextBox.Text));
                    }

                    textBoxIndex++;
                }
                catch (Exception)
                {
                    Response.Redirect("Default.aspx");
                }
            }
        return Matrix;
    }
}