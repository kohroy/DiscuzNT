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

            //����Ƿ���ͬ���������
            if (TopicTypes.IsExistTopicType(typename))
            {
                result = false;
                return;
            }

            //���ӷ��ൽdnt_topictypes,��д��־
            TopicTypes.CreateTopicTypes(typename, int.Parse(typeorder), typedescription);
            maxId = TopicTypes.GetMaxTopicTypesId();
            //���·��໺��
            DNTCache.GetCacheService().RemoveObject("/Forum/TopicTypes");
            return;
        }
    }
}