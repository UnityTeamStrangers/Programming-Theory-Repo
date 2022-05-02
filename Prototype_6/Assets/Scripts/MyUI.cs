using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyUI : MonoBehaviour
{
    MainClass mainClass;
    MyClass myClass;
    // Поля типа Text для MainPlayer
    Text name_Player_Main;
    Text text_HP_Max;
    Text text_HP;
    Text text_DMG;
    Text text_END;
    // Поля типа Text для Player_2
    Text name_Player_2;
    Text text_HP_Max_2;
    Text text_HP_2;
    Text text_DMG_2;
    Text text_END_2;
    // пути для Player_Main
    string pathName_Player_Main = "Canvas/Player_Main/Panel_Class/Text_Player_Value";
    string pathHPMax = "Canvas/Player_Main/Panel_HP/Text_HP_Max_Value";
    string pathHP = "Canvas/Player_Main/Panel_HP/Text_HP_Value";
    string pathDMG = "Canvas/Player_Main/Panel_DMG/Text_DMG_Value";
    string pathEND = "Canvas/Player_Main/Panel_END/Text_END_Value";
    // Пути для Player_2
    string pathName_Player_2 = "Canvas/Player_2/Panel_Class/Text_Player_Value";
    string pathHPMax_2 = "Canvas/Player_2/Panel_HP/Text_HP_Max_Value";
    string pathHP_2 = "Canvas/Player_2/Panel_HP/Text_HP_Value";
    string pathDMG_2 = "Canvas/Player_2/Panel_DMG/Text_DMG_Value";
    string pathEND_2 = "Canvas/Player_2/Panel_END/Text_END_Value";

    void Start()
    {
        mainClass = GameObject.Find("Canvas/Player_Main").GetComponent<MainClass>();
        myClass = GameObject.Find("Canvas/Player_2").GetComponent<MyClass>();
        // Инициализациия текстовых полей MainPlayer
        name_Player_Main = GameObject.Find(pathName_Player_Main).GetComponent<Text>();
        name_Player_Main.text = MainClass.nameClass;
        text_HP_Max = GameObject.Find(pathHPMax).GetComponent<Text>();
        text_HP_Max.text = mainClass.HP_Max.ToString();
        text_HP = GameObject.Find(pathHP).GetComponent<Text>();
        text_HP.text = mainClass.pr_HP.ToString();
        text_DMG = GameObject.Find(pathDMG).GetComponent<Text>();
        text_DMG.text = MainClass.DMG.ToString();
        text_END = GameObject.Find(pathEND).GetComponent<Text>();
        text_END.text = MainClass.END.ToString();

        // Инициализациия текстовых полей Player_2
        name_Player_2 = GameObject.Find(pathName_Player_2).GetComponent<Text>();
        name_Player_2.text = MyClass.nameClass;
        text_HP_Max_2 = GameObject.Find(pathHPMax_2).GetComponent<Text>();
        text_HP_Max_2.text = myClass.HP_Max_2.ToString();
        text_HP = GameObject.Find(pathHP_2).GetComponent<Text>();
        text_HP.text = myClass.pr_HP.ToString();
        text_DMG = GameObject.Find(pathDMG_2).GetComponent<Text>();
        text_DMG.text = MyClass.DMG.ToString();
        text_END = GameObject.Find(pathEND_2).GetComponent<Text>();
        text_END.text = MyClass.END.ToString();
    }
}
