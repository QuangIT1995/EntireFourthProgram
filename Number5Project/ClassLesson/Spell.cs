class Spell{
    public string spell_name{get; set;}
    public int damage{get; set;}
    public int mana_cost{get; set;}
    string description{get; set;}
    public Spell(string spell_name, int damage, int mana_cost, string description){
        this.spell_name = spell_name;
        this.damage = damage;
        this.mana_cost = mana_cost;
        this.description = description;
    }
    public Spell(){
        this.spell_name = "Ice Crystal";
        this.damage = 40;
        this.mana_cost = 20;
        this.description = $"Freeze the enemy and take {this.damage} damage";
    }
    public void cast_the_spell(){
        Console.WriteLine($"{this.spell_name} was casted with {this.damage} damage");
    }
    public void describe_the_spell(){
        Console.WriteLine("Spell Description");
        Console.WriteLine($"Spell name: {this.spell_name}");
        Console.WriteLine($"Damage: {this.damage}");
        Console.WriteLine($"Mana cost: {this.mana_cost}");
        Console.WriteLine($"Description: {this.description}");
    }
}