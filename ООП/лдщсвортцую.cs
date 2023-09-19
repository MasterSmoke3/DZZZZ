public class Hitman{
    int stealth;
    int Damage;
    int intelligence;

    public Hitman(int stealth, int damage, int intelligence){
        this.Damage = damage;
        this.stealth = stealth;
        this.intelligence = intelligence;
    }

    public int GetDamage(){
        return stealth * damage;
    }

    public int GetArmor(){
        return intelligence;
    }
}

public class Simple {
    public static void Main(){
        Hitman firstHitman = new Hitman(34, 13, 5);
        Console.WriteLine("Урон: " + firstHitman.GetDamage() + "Защита: " + firstHitman.Getintelligence());
    }
}