//namespace - przestrzeń nazw, czyli adres pod którym "mieszka" klasa
namespace Models
{
    //class - szablon opisujący zachowania i wartości obiektów (instancji klas), które są wytwarzane na jej postawie
    //pełna nazwa klasy: namespace + nazwa klasy 
    //public - modyfikator dotępu oznaczający, ze klasa jest dostępna wszędzie
    public class Item
    {

        //konstruktor bezparametrowy
        //kontruktor jest metodą (jak każda inna), którą charakteryzuje brak zwracanego typu
        //nazwa tej metody konstrukcyjnej MUSI być taka sama jak nazwa klasy
        //jeśli w klasie nie ma zadnego konstruktora, to niejawnie zostanie wygenerowany konstruktor domyślny, wyglądający jak ponizej
        public Item()
        {

        }


        //konstruktor parametrowy - służy do zapewnienia klasie wartości początkowych dla pól i właściwości
        //jeśli w klasie występuje konstruktor z parametrami, to domyślny konstruktor nie zostanie wygenerowany
        //chcąć posiadać też konstruktor bezparametrowy należy go dodatkowo utworzyć
        public Item(string description, int value)
        {
            Description = description;
            this.value = value;
        }

        public Item(string description)
        {
            Description = description;
        }




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