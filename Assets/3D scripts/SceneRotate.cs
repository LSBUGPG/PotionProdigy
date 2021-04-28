using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneRotate : MonoBehaviour
{
    float time;
    public float speed;
    public float ofset;
    public GameObject particles;
    public DialogueTrigger dialogue;

    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        anim.enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * speed;
        if (time > 1f)
        {
            dialogue.TriggerDialogue();
            anim.enabled = true;
            enabled = false;
            time = 1f;
        }
        transform.rotation = Quaternion.Euler(0, ofset + time * 360f, 0);

    }



}
