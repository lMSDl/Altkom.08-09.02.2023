namespace Models
{
    public struct ItemStruct
    {

        public ItemStruct()
        {
            value = 0;
            Quantity = 0;
            Description = "";
        }

        public ItemStruct(string description, int value)
        {
            Description = description;
            this.value = value;
            Quantity = 0;
        }

        public ItemStruct(string description)
        {
            Description = description;
            Quantity = 0;
            value = 0;
        }

        private int value;
        public int GetValue()
        {
            return value;
        }
        public void SetValue(int value)
        {
            this.value = value;
        }

        public string Description { get; set; }
        public int Quantity { get; set; }
    }
}