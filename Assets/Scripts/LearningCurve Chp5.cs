using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurveChp5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        Character hero2 = hero;
        //reference type
        hero2.name = "Sir Krane the Brave";

        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        hero2.Reset();
        

        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
