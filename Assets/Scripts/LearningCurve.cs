using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    private int myNumber = 1;
    public string myName = "Phillip Rumpelthiin";

    // Start is called before the first frame update
    void Start()
    {
        FindPartyMember(myName, myNumber);

    }

    public void FindPartyMember(string name, int number)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };
        QuestPartyMembers.Insert(number, name);
        int listLength = QuestPartyMembers.Count; 

        Debug.LogFormat("Party Members: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

        }
    }
}