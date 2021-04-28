using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugDestroy : MonoBehaviour
{
    public bool clicked;
    public GameObject particles;
    public GameObject powabar;
    public int power;
    public string soundName;

    // Start is called before the first frame update
    void Start()
    {
        
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
                Destroy(gameObject);
                particles.SetActive(true);
                Powerbar.CurrentPower += power;
                FindObjectOfType<AudioManager>().Play(soundName);

            }
    }
}
