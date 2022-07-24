using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Класс UI
/// </summary>
public class MyUI : MonoBehaviour
{
    MainClass mainClass; // "Ссылки"
    MyClass myClass; // "Ссылки"
    // Поля типа Text для MainPlayer
    Text name_Player_1; // Имя Главного персонажа
    Text text_HP_Max; // Жизни (Макс)
    Text text_HP; // Жизни (Текущие)
    Text text_DMG; // Урок
    Text text_END; // Защита
    // Поля типа Text для Player_2
    Text name_Player_2;
    Text text_HP_Max_2;
    Text text_HP_2;
    Text text_DMG_2;
    Text text_END_2;
    // Поле типа Text(other)
    Text text_Point;
    // пути для Player_Main
    string pathName_Player_Main = "Canvas/Player_Main/Panel_Class/Text_Player_Value";
    string pathHPMax =            "Canvas/Player_Main/Panel_HP/Text_HP_Max_Value";
    string pathHP =               "Canvas/Player_Main/Panel_HP/Text_HP_Value";
    string pathDMG =              "Canvas/Player_Main/Panel_DMG/Text_DMG_Value";
    string pathEND =              "Canvas/Player_Main/Panel_END/Text_END_Value";
    // Пути для Player_2
    string pathName_Player_2 =    "Canvas/Player_2/Panel_Class/Text_Player_Value";
    string pathHPMax_2 =          "Canvas/Player_2/Panel_HP/Text_HP_Max_Value";
    string pathHP_2 =             "Canvas/Player_2/Panel_HP/Text_HP_Value";
    string pathDMG_2 =            "Canvas/Player_2/Panel_DMG/Text_DMG_Value";
    string pathEND_2 =            "Canvas/Player_2/Panel_END/Text_END_Value";
    // (Other)
    string pathPoint =            "Canvas/Panel_Point/Text_Point";

    private void Awake()
    {
        mainClass = GameObject.Find("Canvas/Player_Main").GetComponent<MainClass>();
        myClass =   GameObject.Find("Canvas/Player_2").GetComponent<MyClass>();
    }

    void Start()
    {
        Initialization_Player_1();
        Initialization_Player_2();
    }

    void Update()
    {
        Show_Player_1();
        Show_Player_2();
    }
    /// <summary>
    /// Инициализация полей Главного персонажа
    /// </summary>
    void Initialization_Player_1()
    {
        name_Player_1 = GameObject.Find(pathName_Player_Main).GetComponent<Text>();
        text_HP_Max = GameObject.Find(pathHPMax).GetComponent<Text>();
        text_HP = GameObject.Find(pathHP).GetComponent<Text>();
        text_DMG = GameObject.Find(pathDMG).GetComponent<Text>();
        text_END = GameObject.Find(pathEND).GetComponent<Text>();

        text_Point = GameObject.Find(pathPoint).GetComponent<Text>();
    }
    /// <summary>
    /// Визуализация характеристик главного персонажа
    /// </summary>
    void Show_Player_1()
    {
        name_Player_1.text = mainClass.GetName();
        text_HP_Max.text = mainClass.pr_HP_Max.ToString();
        text_HP.text = mainClass.pr_HP.ToString();
        text_DMG.text = mainClass.GetDamage().ToString();
        text_END.text = mainClass.GetEndurance().ToString();

        text_Point.text = MainClass.point.ToString();
    }

    /// <summary>
    /// Инициализация полей второго персонажа
    /// </summary>
    void Initialization_Player_2()
    {
        name_Player_2 = GameObject.Find(pathName_Player_2).GetComponent<Text>();
        text_HP_Max_2 = GameObject.Find(pathHPMax_2).GetComponent<Text>();
        text_HP_2 = GameObject.Find(pathHP_2).GetComponent<Text>();
        text_DMG_2 = GameObject.Find(pathDMG_2).GetComponent<Text>();
        text_END_2 = GameObject.Find(pathEND_2).GetComponent<Text>(); 
    }

    /// <summary>
    /// Визуализация характеристик второго персонажа
    /// </summary>
    void Show_Player_2()
    {
        name_Player_2.text = myClass.GetName();
        text_HP_Max_2.text = myClass.pr_HP_Max.ToString();
        text_HP_2.text = myClass.pr_HP.ToString();
        text_DMG_2.text = myClass.GetDamage().ToString();
        text_END_2.text = myClass.GetEndurance().ToString();
    }
}
