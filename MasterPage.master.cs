using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void CalculateBtn_Click(object sender, EventArgs e)
    {
        if (ContentCallEvent != null)
            ContentCallEvent(this, EventArgs.Empty);
    }

    public event EventHandler ContentCallEvent;

    public List<int> GetMatrix(string matrixIndex)
    {
        var Matrix = new List<int>();

        var mpContentPanel = (Panel)FindControl("Panel1");
        TextBox mpTextBox;

        if (mpContentPanel != null)
        {
            var textBoxIndex = 1;
            for (int i = 0; i < 9; i++)
            {
                try
                {
                    mpTextBox = (TextBox)mpContentPanel.FindControl("TextBox" + textBoxIndex.ToString() + "_matrix" + matrixIndex);

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
        }
        return Matrix;
    }

    public void SetMatrix(List<int> matrixC)
    {
        var mpContentPanel = (Panel)FindControl("Panel2");
        TextBox mpTextBox;

        if (mpContentPanel != null)
        {
            var textBoxIndex = 1;
            for (int i = 0; i < 9; i++)
            {
                try
                {
                    mpTextBox =
                        (TextBox)mpContentPanel.FindControl("TextBox" + textBoxIndex.ToString() + "_matrixC");
                    mpTextBox.Text = matrixC[i].ToString();
                    textBoxIndex++;
                }
                catch (Exception)
                {
                    Response.Redirect("Default.aspx");
                }
            }
        }
    }
}

