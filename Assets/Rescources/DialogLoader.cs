using UnityEngine;
using System.Collections.Generic;

public class DialogLoader : MonoBehaviour
{
    public string path = "Assets/Rescources/dialogs.xml";

    List<NpcClass> NPC = new List<NpcClass>();


    // Use this for initialization
    void Start()
    {
        DialogContainer dc = DialogContainer.Load(path);

        foreach (DialogsClass dialog in dc.dialogs)
        {
            //print(dialog.name);
            //print(dialog.sentenceNumber);
            //print(dialog.mood);
            //print(dialog.dialog);
            NPCLoader(dialog.name, dialog.sentenceNumber, dialog.mood, dialog.dialog);

        }
    }
    /*Needs a better Name*/
    public void NPCLoader(string NPCName, int NPCConversationID, string NPCMood, string NPCDialog)
    {
        Debug.Log(NPCConversationID + "\n" + NPCName + "\n" + NPCMood + "\n " + NPCDialog);
    }
}
