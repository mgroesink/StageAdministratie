namespace StageLib
{
    public class Student
    {
        private string _studentnummer;
        private string _voornaam;
        private string _achternaam;
        private DateTime _geboortedatum;

        public Student(string studentnummer,string voornaam , string achternaam)
        { 
            _studentnummer = studentnummer;
            _voornaam = voornaam;   
            _achternaam = achternaam;
        }
        public Student()
        {

        }

        public string Voornaam
        {
            get { return _voornaam; }
        }
    }
}