using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Производный класс
/// </summary>
public class MyClass : MainClass
{
    new public static string nameClass = "Player_2";
    int HP_2;
    public int HP_Max_2;
    new public int pr_HP
    {
        get
        {
            if (HP_2 <= 0) HP_2 = 0;
            else if (HP_2 >= HP_Max_2) HP_2 = HP_Max_2;
            return HP_2;
        }
        set
        {
            HP_2 += value;
            if (HP_2 >= HP_Max_2) HP_2 = HP_Max_2;
        }
    }
    new public static int DMG;
    new public static int END;

    public void HP_Plus()
    {
        if (point != 0)
        {
            HP_Max_2+=10;
            base.HP_Max += 10;
            point--;
        }        
    }
    public override void DMG_Plus()
    {
        if (point != 0) { DMG++; point--; }
    }
    public override void END_Plus()
    {
        if (point != 0) { END++; point--; }
    }
    public override void set(int hp, int dmg, int end)
    {
        HP_Max_2 = hp;
        HP_2 = HP_Max_2;
        DMG = dmg;
        END = end;
    }
    void Awake()
    {
        set(200, 20, 20);
    }
}
