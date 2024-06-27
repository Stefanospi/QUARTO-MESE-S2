namespace ES_G3_G4.Class
{
    public class Sala : EntityBase
    {
        public enum name
        {
            NORD,
            SUD,
            EST,
            OVEST
        }
        public int capacity { get; set; } = 120;


    }
}
