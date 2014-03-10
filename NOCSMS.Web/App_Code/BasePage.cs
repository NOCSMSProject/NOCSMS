using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
/// <summary>
///BasePage 的摘要说明
/// </summary>
public class BasePage : System.Web.UI.Page
{
    public const string userName = "userName";
	
    public BasePage()
	{
        if (HttpContext.Current.Response.Cookies[userName] != null)
        {
            if (Session[userName] == null)
            {
                Session[userName] = HttpContext.Current.Response.Cookies[userName];
            }
        }
        else
        {
            if (Session[userName] == null)
            {
                HttpContext.Current.Response.Redirect("Login.aspx");
            }
        }
	}


    /// <summary>
    /// 获取公共JS和CSS
    /// </summary>
    /// <returns></returns>
    public string GetCommonJSAndCSSFile() 
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("<script type='text/javascript' src='JScript/jquery-1.7.1.js'");
        sb.Append("<script type='text/javascript' src='JScript/jquery-1.7.1.min.js'");
        sb.Append("<link href='CSS/bootstrap-theme.css' rel='stylesheet' type='text/css'");
        sb.Append("<link href='CSS/bootstrap-theme.min.css' rel='stylesheet' type='text/css'");
        sb.Append("<link href='CSS/bootstrap.css' rel='stylesheet' type='text/css'");
        sb.Append("<link href='CSS/bootstrap.min.css' rel='stylesheet' type='text/css'");
        return sb.ToString();
    }
}