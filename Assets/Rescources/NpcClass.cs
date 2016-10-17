using UnityEngine;
using System.Collections;
using System; 

public class NpcClass
{
    public string name;
    public int sentenceID;
    public string mood;
    public string dialog;

    public NpcClass(string newName, int NewsentenceID, string newMood, string newDialog)
    {
        name = newName;
        sentenceID = NewsentenceID;
        mood = newMood;
        dialog = newDialog; 
    }
}