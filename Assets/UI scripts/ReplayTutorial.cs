using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplayTutorial : MonoBehaviour
{
    public DialogueTrigger dialogue;
    public bool closed;



    public void replay ()
    {
        dialogue.TriggerDialogue();
        closed = true;
    }
}
