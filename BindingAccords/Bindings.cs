using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BindingAccords
{
    [DataContract]
    public class Bindings
    {
        public class BundledScrolls
        {
            public BundledScrolls()
            { 
                Scrolls = new List<RequestScroll>();
            }

            [DataMember(Order = 1)]
            public List<RequestScroll> Scrolls { get; set; }

            [DataMember(Order = 2)]
            public CastingStatus Status { get; set; }
        }

        public class RequestScroll
        {
            [DataMember(Order = 1)]
            public string UniqueGlyph { get; set; }

            [DataMember(Order = 2)]
            public string CastingPhrase { get; set; }

            [DataMember(Order = 3)]
            public int MagicType { get; set; }

            [DataMember(Order = 4)]
            public int SpellType { get; set; }
        }

        public class ResponseStatus
        {
            [DataMember(Order = 1)]
            public CastingStatus Status { get; set; }

            [DataMember(Order = 2)]
            public string Message { get; set; }
        }

        public enum CastingStatus
        {
            Success = 0,
            Failure = 1,
            Unknown = 2
        }
    }
}