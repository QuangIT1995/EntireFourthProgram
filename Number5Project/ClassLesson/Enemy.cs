class Enemy{
    public string enemy_name {get; set;}
    public int health_point{get; set;}
    public int attack_power{get; set;}
    public int defense{get; set;}
    public Enemy(string enemy_name, int health_point, int attack_power, int defense)
    {
        this.enemy_name = enemy_name;
        this.health_point = health_point;
        this.attack_power = attack_power;
        this.defense = defense;
    }
    public Enemy()
    {
        this.enemy_name = "Toast";
        this.health_point = 90;
        this.attack_power = 75;
        this.defense = 20;
    }
    //tan cong nguoi choi
    public void take_damage(Player player){
        int damage = this.attack_power - player.defense;
        //khong gay ra hieu ung sat thuong nao
        if(damage <= 0) damage = 0;
        //khi bi tan cong, mau cua nguoi choi se giam
        player.health_point -= damage;
        Console.WriteLine($"{this.enemy_name} attack {player.playerName} with {damage} damage");
    }

    public void update_HP(int damage){
        this.health_point -= damage;
        if(this.health_point < 0){
            this.health_point = 0;
            dead();
        }
        Console.WriteLine($"{this.enemy_name} take {damage} damage. Remaining health point: {this.health_point}");
    }

    public void dead(){
        Console.WriteLine($"{this.enemy_name} has been defeated");
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{this.enemy_name}");
        Console.WriteLine($"HP: {this.health_point}");
        Console.WriteLine($"ATK: {this.attack_power}");
        Console.WriteLine($"DEF: {this.defense}");
    }
}