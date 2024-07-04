class Potion{
    public string potion_name {get; set;}
    public int healing_power {get; set;}
    public int quantity{get; set;}
    public Potion(string potion_name, int healing_power, int quantity){
        this.potion_name = potion_name;
        this.healing_power = healing_power;
        this.quantity = quantity;
    }
    public void heal(Player player){
        if(this.quantity > 0){
            player.health_point += this.healing_power;
            this.quantity--;
            Console.WriteLine($"{this.potion_name} used for {player.playerName}, heal {this.healing_power} HP");
        }
        else if(this.quantity <= 0){
            Console.WriteLine($"No more {this.potion_name} left to uses");
        }
    }
    public void potionStatus(){
        Console.WriteLine($"Name: {this.potion_name}");
        Console.WriteLine($"Healing: {this.healing_power}");
        Console.WriteLine($"Quantity: {this.quantity}");
    }
}