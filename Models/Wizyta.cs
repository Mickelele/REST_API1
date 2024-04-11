namespace REST_API1;

public class Wizyta
{
    public Wizyta(string dataWizyty, int animalId, string opisWizyty, double cenaWizyty)
    {
        this.dataWizyty = dataWizyty;
        this.animalID = animalId;
        this.opisWizyty = opisWizyty;
        this.cenaWizyty = cenaWizyty;
    }

    public  string dataWizyty { get; set; }
    public int animalID { get; set; }
    public string opisWizyty { get; set; }
    public double cenaWizyty { get; set; }
    
    



}