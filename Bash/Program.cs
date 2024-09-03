
Enemy Adidas = new()
{
    Name = "Adidas",
    HP = 100,
    EnemySkill = new Skill{

        Name ="3Stripes",
        Manacost = 10,
        Damage = 8

    }

};

Player kanye = new()
{
    Name = "Kanye",
    HP = 100,
    Mana = 10000,
    ManaMax = 10000,
    ManaRegen = 10000/10,
    PlayerSkill = new Skill
    {
        Name = "You ain't got the answeres SWAYY",
        Manacost = 1000,
        Damage = 20
    },

    PlayerSkill2 = new Skill
    {
        Name = "He wasn't that bad",
        Manacost = 10000,
    }

};



while (Adidas.HP !<= 0)
{
    Console.WriteLine("Choose an Attack 1 or 2");

    Skill Active;
    string choice = Console.ReadLine();


    if ( choice == "1" )
    {
        Active = kanye.PlayerSkill;
        Console.WriteLine($"{kanye.PlayerSkill.Name}");
    }
    else if(choice == "2")
    {
        Active = kanye.PlayerSkill2;
        Console.WriteLine($"{kanye.PlayerSkill2.Name}");
    }


}







Console.ReadLine();