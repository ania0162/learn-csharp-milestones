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
        //RollDice();

        //lists
        //PartyMember();

        //dictionaries
        //Dictionaries();

        //forloops
        //FindPartyMember();

        //foreachloops
        //ItemInvetoryValue();

        //whileloops
        HealthStatus();

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
                break;
            default:
                Debug.Log("You completely missed and fell on your face.");
                break;

        }
    }

    // arrays
    int[] topPlayerScores = new int[3];
    /*
     Longhand Initializer : int[] top PlayerScores = new int[] {713,549,984};
     Shortcut Initializer: int [] topPlayerScores = {712,549,984};
     */

    //lists
    //blueprint: List<elementType> name = new List<elementType>() {value1, value2};
    public void PartyMember()
    {
        List<string> QuestPartyMembers = new List<string>()
            { "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
            };
        //add to list
        QuestPartyMembers.Add("Craven the Necromancer");
        //add at a specific spot
        QuestPartyMembers.Insert(1, "Tanis the Thief");
        // remove the required elements: QuestPartyMembers.RemoveAt(0); QuestPartyMembers.Remove("Grim the Barbarian");

        Debug.LogFormat("Party Members: {0}", QuestPartyMembers.Count);

    }

    //dictionaries
    //blueprint: Dictionary<keyType, valueType> name = new Dictionary<keyType,valueType>();
    public void Dictionaries()
    {
        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5},
            { "Antidote", 7},
            { "Aspirin", 1}
        };
        Debug.LogFormat("Items: {0}", ItemInventory.Count);
        //update method: ItemInventory["Potion"] = 10
        //add items: ItemInventory.Add("Throwing Knife", 3);
        //remove items: ItemInventory.Remove("Antidote");
    }

    //for loops
    public void FindPartyMember()
    {
        List<string> QuestPartyMember = new List<string>()
        { "Frim the Barbarian", "Merlin the Wise", "Sterling the Knight"};

        Debug.LogFormat("Party Members: {0}", QuestPartyMember.Count);

        for (int i = 0; i < QuestPartyMember.Count; i++)
        {
            if (QuestPartyMember[i] == "Merlin the Wise")
            {
                Debug.Log("Glad you're here Merlin!");
            }
            
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMember[i]);
        }   
        foreach (string partyMember in QuestPartyMember)
        {
            Debug.LogFormat("{0} - Here!", partyMember);
        };

    }

    //foreach
    public void ItemInvetoryValue()
    {
        Dictionary<string, int> ItemInventory = new Dictionary<string, int>()
        {
            { "Potion", 5},
            { "Antidote", 7},
            { "Aspirin", 1}
        };

        foreach(KeyValuePair<string, int> kvp in ItemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }
    }

    //whileloops
    public void HealthStatus()
    {
        int PlayerLives = 3;
        while(PlayerLives > 0)
        {
            Debug.Log("Still alive!");
            PlayerLives--;
        }
        Debug.Log("Player KO'd...");
    }
    


    // Update is called once per frame
    void Update()
    {
        
    }
}
