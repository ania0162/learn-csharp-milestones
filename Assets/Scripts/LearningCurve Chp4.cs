using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurveChp4 : MonoBehaviour
{
    //if-else statement
    public int CurrentGold = 32;

    //not operator
    public bool hasDungeonKey = false;
    public string weaponType = "Longsword";

    //nesting statements
    public bool weaponEquipped = true;

    //multiple conditions
    public bool PureOfHeart = true;
    public bool HasSecretIncantation = false;
    public string RareItem = "Relic Stone";

    // Start is called before the first frame update
    void Start()
    {
        //if-else statement
        //Thievery();

        //not operator
        //if(!hasDungeonKey)
        //{
        //    Debug.Log("You may not enter without the sacred key.");
        //}
        //if(weaponType != "Longsword")
        //{
        //    Debug.Log("You don't appear to have the right weapon...");
        //}

        //nesting statements
        if (weaponEquipped)
            //{
            //    if(weaponType == "Longsword")
            //    {
            //        Debug.Log("For the Queen!");
            //    }
            //    else
            //    {
            //        Debug.Log("Fists aren't going to wor against armor...");
            //    }    
            //}

            //multiple conditions
            OpenTreasureChamber();

    }

    //if-else statement
    public void Thievery()
        {
            if (CurrentGold > 50)
            {
                Debug.Log("You're rolling in it!");
            }
            else if (CurrentGold < 15)
            {
                Debug.Log("Not much there to steal...");
            }
            else
            {
                Debug.Log("Looks like your purse is in the sweet spot.");
            }
        }

    //multiple conditions
    public void OpenTreasureChamber()
        {
        if (PureOfHeart && RareItem == "Relic Stone")
        {
            if(!HasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge.");
            }
            else
            {
                Debug.Log("The treasure is yours, worth hero!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes.");
        }
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}
