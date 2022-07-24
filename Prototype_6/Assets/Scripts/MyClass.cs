using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Производный класс
/// </summary>
public class MyClass : MainClass
{
    public void HP_Plus()
    {
        if (point != 0)
        {
            Set_HP_Max(10);    
            point--;
        }
    }
    public override void DMG_Plus() { Damage++; base.DMG_Plus(); }
    public override void END_Plus() { if (point != 0) { Endurance+=2; point--; } }
    public override void SetParams(int hp, int dmg, int end)
    {
        Set_HP_Max(hp);
        pr_HP = hp;
        Damage = dmg;
        Endurance = end;
    }
    public void SetNameClass(string name) { nameClass = name; }

    void Awake()
    {
        SetNameClass("Player_2");
        SetParams(200, 20, 20);
    }
}
