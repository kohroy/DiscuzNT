using Newtonsoft.Json;

namespace Discuz.Web.Services.API
{
    public class Reply
    {
        [JsonPropertyAttribute("tid")]
        public int Tid;

        [JsonPropertyAttribute("fid")]
        public int Fid;

        [JsonPropertyAttribute("message")]
        public string Message;


        [JsonPropertyAttribute("title")]
        public string Title;


    }
}
