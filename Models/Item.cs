//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
namespace Models
{
    //class - szablon opisujący zachowania i wartości obiektów (instancji klas), które są wytwarzane na jej postawie
    //pełna nazwa klasy: namespace + nazwa klasy 
    //public - modyfikator dotępu oznaczający, ze klasa jest dostępna wszędzie
    public class Item
    {
        //brak modyfikatora dostępu == private - oznacza dostęp tylko dla klasy w której się znajduje
        //prywatna zmienna globalna / pole
        private int value;

        //getter do pobierania wartości pola - metoda zracająca typ zgodny z typem pola
        public int GetValue()
        {
            //return - kończy metodę i zwraca wartość (obowiązkowy gry metoda nie jest void)
            return value;
        }

        public void SetValue(int value)
        {
            //w związku ze zbieżnością nazw pola i parametru metody
            //musimy odwołać się do klasy przez "this" żeby rozróżnić te zmienne
            this.value = value;
        }

        //backfield dla full-property
        private string description;

        //Full-Property
        public string Description
        {
            //getter wbudowany w property
            get
            {
                return description;
            }

            //setter wbudowany w property - posiada niejawny parametr o nazwie value
            /*private*/
            set
            {
                description = value;
            }
        }

        //Auto-Property
        //właściwość integruje w sobie pole i metody dostępowe
        public int Quantity { /*private*/ get; set; }
    }
}