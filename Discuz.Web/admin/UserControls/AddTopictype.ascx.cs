using System;

using Discuz.Common;
using Discuz.Forum;
using Discuz.Cache;

namespace Discuz.Web.Admin
{
    public class addtopictype : System.Web.UI.UserControl
    {
        public bool result = true;
        public int maxId = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            string typename = DNTRequest.GetString("typename");
            string typeorder = DNTRequest.GetString("typeorder");
            string typedescription = DNTRequest.GetString("typedescription");

            //检查是否有同名分类存在
            if (TopicTypes.IsExistTopicType(typename))
            {
                result = false;
                return;
            }

            //增加分类到dnt_topictypes,并写日志
            TopicTypes.CreateTopicTypes(typename, int.Parse(typeorder), typedescription);
            maxId = TopicTypes.GetMaxTopicTypesId();
            //更新分类缓存
            DNTCache.GetCacheService().RemoveObject("/Forum/TopicTypes");
            return;
        }
    }
}