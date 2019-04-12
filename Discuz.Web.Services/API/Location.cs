#if NET1
#else
#endif
using System.Xml.Serialization;

namespace Discuz.Web.Services.API
{
    public class Location
    {
        [XmlElement("street")]
        public string Street;

        [XmlElement("city")]
        public string City;

        [XmlElement("state")]
        public string State;

        [XmlElement("country")]
        public string Country;

        [XmlElement("zip")]
        public string Zip;
    }
}
