using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class User_NewPost : System.Web.UI.Page
{
    BlogDataContext db = new BlogDataContext(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mdodg\source\repos\malorydodge\MaloryDodge\App_Data\Blog.mdf;Integrated Security=True;Connect Timeout=30");

    protected void Page_Load(object sender, EventArgs e)
    {
        //check if logged in
        if (User.Identity.IsAuthenticated == false)
        {
            Response.Redirect("~/Account/Login");
        }
        //var status = from user in db.Users where user.UserName == User.Identity.Name.ToString() select user.Admin;
        //bool isAdmin = status.Equals(1);
        //check if admin user
        //if (isAdmin)
        //{
          //  Response.Redirect("~/");
        //}
    }

    protected void btnPost_Click(object sender, EventArgs e)
    {
        //check if post has required fields
        if ((txtTitle.Text != string.Empty)&& (txtCategory.Text != string.Empty) && (txtPost.Text != string.Empty) && (txtSnippet.Text != string.Empty))
        {
            //publish the post
            db.CreateBlog(DateTime.Now, txtTitle.Text, txtSnippet.Text, txtPost.Text, txtCategory.Text, true, User.Identity.Name);
            Response.Redirect("~/User/Blog.cshtml");
        }

        else ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please fill in all required fields!')", true);
 }

    protected void btnAddKeyword_Click(object sender, EventArgs e)
    {
        //create the keyword(s)
        if(txtTitle.Text != string.Empty)
        {
            db.CreateKeyword(txtTitle.Text, txtKeyword.Text);
            txtKeyword.Text = string.Empty;
            txtKeyword.Focus();
        }
        else ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Please enter your blog title first!')", true);
    }

    protected void txtKeyword_TextChanged(object sender, EventArgs e)
    {
        if (this.IsPostBack){
            lbKeywords.Items.Add(txtKeyword.Text);
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/User/Blog.cshtml");
    }
}