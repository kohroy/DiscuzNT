
using Discuz.Forum.ScheduledEvents;
using System.IO;
using Discuz.Common;
using Discuz.Config;

namespace Discuz.Event
{
    public class ClearCatchEvent : IEvent
    {
        public void Execute(object state)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Utils.GetMapPath(BaseConfigs.GetForumPath + "cache/showtopic"));
                foreach (FileSystemInfo file in dirInfo.GetFileSystemInfos())
                {
                    file.Delete();
                }
            }
            catch
            {
                
            }
        }
    }
}
