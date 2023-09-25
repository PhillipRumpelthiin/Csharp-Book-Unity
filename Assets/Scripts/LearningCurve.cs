using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    //C-sharp book
    public bool pureOfHeart = true;
    public bool hasSecretIncantation = false;
    public string rareItem = "Relic Stone";
    public string CharacterAction = "Attack";

    public int diceRoll = 7;


    // Start is called before the first frame update
    void Start()
    {
        OpenTreasureChamber();
        PrintCharacterAction();
        RollDice();
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5 },
            {"Antidote", 7 },
            {"Aspirin", 1 }
        };

        Debug.LogFormat("Items: {0}", itemInventory.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenTreasureChamber()
    {
        if (pureOfHeart && rareItem == "Relic Stone")
        {
            if (!hasSecretIncantation)
            {
                Debug.Log("You have the spirit, but not the knowledge");
            }
            else
            {
                Debug.Log("The tresure is yours!");
            }
        }
        else
        {
            Debug.Log("Come back when you have what it takes");
        }
    }

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
                Debug.Log("Shields up");
                break;
        }
    }

    public void RollDice()
    {
        switch (diceRoll)
        {
            case 7: 
            case 15:
                Debug.Log("Mediocre damage");
                break;
            case 20:
                Debug.Log("Critical Hit!");
                break;
            default:
                Debug.Log("Missed!");
                break;

        }
    }
}
