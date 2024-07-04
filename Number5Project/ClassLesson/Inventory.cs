class Inventory{
    public int capacity {get; set;}
    public string[] list_of_item;
    public Inventory(int capacity){
        this.capacity = capacity;
        this.list_of_item = new string[capacity];
    }
    public Inventory(){
        this.capacity = 12;
        this.list_of_item = new string[capacity];
    }
    public void add(string item){
        for (int i = 0; i < this.list_of_item.Length; i++)
        {
            if(this.list_of_item[i] == null)
            {
                this.list_of_item[i] = item;
                Console.WriteLine($"{item} is added to inventory");
                return;
            }
        }
        Console.WriteLine("Inventory is full! Need remove more of item.");
    }

    public void remove(string item){
        for(int i = 0; i < this.list_of_item.Length; i++){
            if(this.list_of_item[i] == item){
                this.list_of_item[i] = null;
                Console.WriteLine($"{item} is removed from inventory");
                return;
            }
        }
        Console.WriteLine($"{item} is not found");
    }

    public void use(string item){
        for(int i = 0; i < this.list_of_item.Length; i++){
            if(this.list_of_item[i] == item){
                this.list_of_item[i] = null;
                Console.WriteLine($"{item} is used");
                return;
            }
        }
        Console.WriteLine($"{item} is not found");
    }
}