namespace Studentska.Data
{
    public class VrstaUplate
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Oznaka { get; set; }
        public bool Aktivan { get; set; }//
        public override string ToString()
        {
            return Naziv;
        }
    }
}
