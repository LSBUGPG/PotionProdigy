using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eyeMonster : MonoBehaviour
{
    public DialogueTrigger dialogue;
    public ChangeSprite changeSprite;
    public GameObject particles;
    public GameObject Scene;
    public GameObject room;
    public string soundName;

    bool awake = false;

    public void wakeUp()
    {
        dialogue.TriggerDialogue();
        changeSprite.change();
        awake = true;
    }
    void OnMouseDown()
    {
        if (awake && Input.GetMouseButton(0))

            {
                Destroy(room);
            Scene.SetActive(true);
            particles.SetActive(true);
            FindObjectOfType<AudioManager>().Play(soundName);

        }
    }

}
