using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Базовый класс персонажа
/// </summary>
public class MainClass : MonoBehaviour, myInterface
{
    public static string nameClass = "Player_1";
    int HP;
    public int HP_Max;
    public int pr_HP
    {
        get
        {
            if (HP <= 0) HP = 0;
            else if (HP >= HP_Max) HP = HP_Max;
            return HP;
        }
        set
        {
            HP += value;
            if (HP >= HP_Max) HP = HP_Max;
        }
    }
    public static int DMG;
    public static int END;
    public int point;

    public virtual void DMG_Plus() { if (point != 0) { DMG++; point--; } }
    public virtual void END_Plus() { if (point != 0) { END++; point--; } }

    public virtual void set(int hp,int dmg,int end)
    {
        HP_Max = hp;
        HP = HP_Max;
        DMG = dmg;
        END = end;
    }
    void Awake()
    {
        set(100, 10, 10);  
    }
}
