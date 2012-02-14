namespace PkwPolice
{
    public class PkwPolice
    {
        private const double Versicherungssteuersatz = 0.19;
        private const double AufpreissatzFuerFrauen = 0.10;
        private readonly int _leistungInKw;

        public PkwPolice(int leistungInKw)
        {
            _leistungInKw = leistungInKw;
        }

        public double BerechneGrundbeitrag()
        {
            return _leistungInKw * 1.3;
        }

        public double BerechneEndbeitrag()
        {
            var versicherungssteuer = BerechneGrundbeitrag() * Versicherungssteuersatz;
            return BerechneGrundbeitrag() + versicherungssteuer;
        }

        public double BerechneEndbeitragFuerFrau()
        {
            var aufpreis = BerechneGrundbeitrag() * AufpreissatzFuerFrauen;
            return BerechneEndbeitrag() + aufpreis;
        }
    }
}