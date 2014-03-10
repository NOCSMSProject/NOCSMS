using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///BasePage 的摘要说明
/// </summary>
public class BasePage : System.Web.UI.Page
{
    public const string userName = "userName";
	
    public BasePage()
	{
        
        if (Session[userName] == null)
        {
            HttpContext.Current.Response.Redirect("Login.aspx");
        }
	}
}