
internal class Program
{
    public static void Main(string[] args){
        //Question 1
        Player player = new Player();
        player.ShowInfo();
        player.gain_exp(240);
        player.ShowInfo();
        player.heal(30);
        player.ShowInfo();

        //Question 2
        Enemy enemy = new Enemy();
        enemy.take_damage(player);
        player.ShowInfo();
        player.heal(10);
        player.ShowInfo();
        enemy.ShowInfo();
        enemy.update_HP(30);
        enemy.ShowInfo();
        enemy.update_HP(30);
        enemy.ShowInfo();
        enemy.update_HP(30);
        enemy.ShowInfo();
        enemy.update_HP(30);
        enemy.ShowInfo();

        //Question 3
        Potion hpPotion = new Potion("Health Potion",40,5);
        hpPotion.heal(player);
        player.ShowInfo();
        hpPotion.potionStatus();

        //Question 4
        Quest quest = new Quest();
        quest.start_the_quest();
        quest.complete_the_quest();
        quest.claim_the_reward();

        //Question 5
        Inventory inventory = new Inventory();
        inventory.add("Katana");
        inventory.add("Kunai");
        inventory.add("Samurai outfit");
        inventory.use("Katana");
        inventory.remove("Kunai");

        //Question 6
        Spell spell = new Spell();
        spell.cast_the_spell();
        spell.describe_the_spell();
    }
}