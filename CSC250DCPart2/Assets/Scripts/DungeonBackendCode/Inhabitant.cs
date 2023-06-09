using System;

public class Inhabitant
{
    protected int hp;
    protected int ac;
    protected int damage;
    protected string name;

    public Inhabitant(string name)
    {
        this.name = name;
        Random r = new Random();
        this.hp = r.Next(10, 21);
        this.ac = r.Next(10, 18);
        this.damage = r.Next(1, 6);
    }

    public int getHp()
    {
        return this.hp;
    }

    public void changeHp(int hp, int damage)
    {
        this.hp = hp - damage;
    }

    public int getAc()
    {
        return this.ac;
    }

    public int getDamage()
    {
        return this.damage;
    }

    public string getData()
    {
        string s = this.name;
        s = s + " - " + this.hp + " / " + this.ac + " / " + this.damage;
        return s;
    }

    public string getName()
    {
        return this.name;
    }
}
