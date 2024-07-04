class Player
{
    public string playerName {get; set; }
    public int level {get; set;}
    public int health_point{get; set;}
    public int mana_point{get; set;}
    public int exp_point{get; set;}
    public int defense{get; set;}

    public Player(string playerName, int level, int health_point, int mana_point, int exp_point,int defense)
    {
        this.playerName = playerName;
        this.level = level;
        this.health_point = health_point;
        this.mana_point = mana_point;
        this.exp_point = exp_point;
        this.defense = defense;        
    }

    public Player(){
        this.playerName = "Louis Vuiton";
        this.level = 1;
        this.health_point = 100;
        this.mana_point = 50;
        this.exp_point = 13;
        this.defense = 60;
    }
    //tang level
    public void level_up(){
        this.level++;
        this.health_point += 5;
        this.mana_point += 10;
    }

    public void heal(int amount){
        this.health_point += amount;
    }

    public void gain_exp(int amount){
        this.exp_point += amount;
        //Khi so diem kinh nghiem cua nguoi choi bang hoac lon hon diem kinh nghiem can thiet level cua nguoi choi tang len
        if(this.exp_point >= ExpNeededForNextLevel()){
            this.exp_point -= ExpNeededForNextLevel();
            level_up();
        }
    }
    //Luong exp can thiet de tang level
    private int ExpNeededForNextLevel(){
        return 100 * this.level;
    }

    public void ShowInfo(){
        Console.WriteLine("Player");
        Console.WriteLine($"Name: {this.playerName}");
        Console.WriteLine($"Level: {this.level}");
        Console.WriteLine($"HP: {this.health_point}");
        Console.WriteLine($"MP: {this.mana_point}");
        Console.WriteLine($"XP: {this.exp_point}");
        Console.WriteLine($"DEF: {this.defense}");
    }
}