namespace Hylian.RIS.API.Domain
{
    public class CrewMember
    {
        public Guid EventId { get; set; }
        public Guid PersonID { get; set; }
        public Guid CrewTypeID { get; set; }

        public virtual RaceEvent Event { get; set; }
        public virtual Person Person { get; set; }
        public virtual CrewType CrewType { get; set; }
    }
}
