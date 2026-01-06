namespace Studentska.Data.Entiteti
{
    public class StudentUplata
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int AkademskaGodinaId { get; set; }
        public AkademskaGodina AkademskaGodina { get; set; }
        public int VrstaUplateId { get; set; }
        public VrstaUplate VrstaUplate { get; set; }
        public DateTime DatumUplate { get; set; }
        public decimal Iznos { get; set; }
    }


}
