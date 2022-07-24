using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Базовый класс персонажа, который реализует интерфейс
/// </summary>
public class MainClass : MonoBehaviour, IMyInterface
{
    protected string nameClass = "Player_1";
    int hP;
    int hP_Max;

    public int pr_HP
    {
        get
        {
            if (hP <= 0) hP = 0;
            else if (hP >= hP_Max) hP = hP_Max;
            return hP;
        }
        set
        {
            hP += value; //(скорее всего здесь ошибка (множителя на 2) не проверял)
            if (hP >= hP_Max) hP = hP_Max;
        }
    } 
    public int pr_HP_Max { get { return hP_Max; } }
    public void Set_HP_Max(int value) { hP_Max += value; }

    protected int Damage;
    protected int Endurance;
    
    public string GetName() { return nameClass; }
    public int GetDamage() { return Damage; }
    public int GetEndurance() { return Endurance; }

    public static int point; 

    public virtual void DMG_Plus() { if (point != 0) { Damage++;  point--; } }
    public virtual void END_Plus() { if (point != 0) { Endurance++; point--; } }

    public virtual void SetParams(int hp,int dmg,int end)
    {
        hP = hP_Max = hp;
        Damage = dmg;
        Endurance = end;
    }

    void Awake()
    {
        SetParams(100, 10, 10);
    }
    void Start()
    {
        point = 10;
    }
}
