using System;

using Discuz.Common;

namespace Discuz.Web.Admin
{
    public class searchuser : System.Web.UI.UserControl
    {
        public string userListTable = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string searchinfo = DNTRequest.GetString("searchinf");
            if (searchinfo != "")
            {
                userListTable = Forum.Users.GetSearchUserList(searchinfo);
            }
            else
            { 
                userListTable = "您未输入任何搜索关键字"; 
            }
        }
    }
}