using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    
    public GameObject powabar;
    public string soundName;
    public int power;
    public string icon;
    public GameObject particles;


    // Start is called before the first frame update
    void Start()
    {

        powabar.GetComponent<Powerbar>();
        powabar.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
    
        Powerbar.CurrentPower += power;
        powabar.GetComponent<Animator>().enabled = true;
        GameObject.Find(icon).GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        this.gameObject.SetActive(false);
        FindObjectOfType<AudioManager>().Play(soundName);
        particles.SetActive(true);


    }

}
