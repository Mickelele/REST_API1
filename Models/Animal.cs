namespace REST_API1;

public class Animal
{
        public Animal(int id, string imie, string kategoria, double masa, string colorSiersci)
        {
                this.id = id;
                this.imie = imie;
                this.kategoria = kategoria;
                this.masa = masa;
                this.colorSiersci = colorSiersci;
        }

        public int id { get; set; }
        public string imie { get; set; }
        public string kategoria { get; set; }
        public double masa { get; set; }
        public string colorSiersci { get; set; }


        


}