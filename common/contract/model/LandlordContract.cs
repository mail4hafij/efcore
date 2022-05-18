using System.Runtime.Serialization;


namespace common.contract.model
{
    [DataContract]
    public class LandlordContract
    {
        [DataMember]
        public long LandlordId { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
