using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LearningCurveChp5 : MonoBehaviour
{
    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        Character hero2 = hero;
        //reference type
        hero2.name = "Sir Krane the Brave";

        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        //hero2.Reset();


        Character heroine = new Character("Agatha");
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 105);
        Weapon warBow = huntingBow;
        warBow.name = "War Bow";
        warBow.damage = 155;

        huntingBow.PrintWeaponStats();
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Guklhiem", huntingBow);
        knight.PrintStatsInfo();

        

        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);

        //DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);

        // You can break down the code > Gameobject.Find("Directional Light").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
