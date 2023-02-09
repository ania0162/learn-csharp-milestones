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

    //switch
    public string CharacterAction = "Attack";

    //fall-through cases
    public int DiceRoll = 7;

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
        //if (weaponEquipped)
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
        //OpenTreasureChamber();

        //switch
        //PrintCharacterAction();

        //fall-through cases
        RollDice();



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
            if (!HasSecretIncantation)
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

    //switch
    public void PrintCharacterAction()
    {
        switch (CharacterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
            default:
                Debug.Log("Shields up.");
                break;
        }
    }

    //fall-through
    public void RollDice()
    {
        switch (DiceRoll)
        {
            case 7:

            case 15:
                Debug.Log("Mediocre damage,not bad.");
                break;
            case 20:
                Debug.Log("Critical Hit, the creature goes down");

            default:
                Debug.Log("You completely missed and fell on your face.");
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
