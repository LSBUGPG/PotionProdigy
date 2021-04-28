using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Powerbar : MonoBehaviour
{
    private Image PowerBar;
    public static int CurrentPower;
    private int MaxPower = 100;
    Collect col;
    public GameObject[] pickUp;
    bool triggered = false;
    public eyeMonster monster;

    // Start is called before the first frame update
    void Start()
    {
        pickUp = GameObject.FindGameObjectsWithTag("PickUp");
        PowerBar = GetComponent<Image>();
        col = FindObjectOfType<Collect>();
    }



    // Update is called once per frame
    void Update()
    {
     
        PowerBar.fillAmount = (float)CurrentPower / (float)MaxPower;

        if (!triggered && CurrentPower >= 25)
        {
            triggered = true;
            monster.wakeUp();
        }
    }
}
