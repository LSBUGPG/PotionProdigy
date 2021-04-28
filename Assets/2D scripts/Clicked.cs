using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour
{
    public GameObject particles;
    public string soundName;
    public int power;
    public GameObject powabar;
    public bool clicked;


    // Start is called before the first frame update
    void Start()
    {
        powabar.GetComponent<Powerbar>();
    }

    // Update is called once per frame
    void Update()
    {
       
     }

    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))

            if (clicked == false)
        {
                clicked = true;
                particles.SetActive(true);
                FindObjectOfType<AudioManager>().Play(soundName);
                Powerbar.CurrentPower += power;

            }


    }
}
