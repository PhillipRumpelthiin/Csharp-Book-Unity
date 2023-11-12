using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    int heroGold = 5;
    public int playerLives = 3; 
    // Start is called before the first frame update
    void Start()
    {
        HealthStatus();
        Dictionary<string, int> itemInventory = new Dictionary<string, int>()
        {
            {"Potion", 5 },
            {"Antidote", 7 },
            {"Aspirin", 1 }
        };

        foreach (KeyValuePair<string, int> kvp in itemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);

            if (kvp.Value >= heroGold)
            {
                Debug.LogFormat("You can afford the  {0}", kvp.Key);
            }
        }


    }

    public void HealthStatus()
    {
        while (playerLives > 0)
        {
            Debug.Log("Still alive!");
            playerLives--;
        }
        Debug.Log("Player dead");
    }
}