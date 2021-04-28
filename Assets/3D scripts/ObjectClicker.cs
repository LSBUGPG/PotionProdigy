using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    public GameObject Tidy;
    public int power;
    public GameObject powabar;
    public GameObject clickMe;
    public string soundName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnMouseDown()
    { if (enabled)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10000.0f))
            {
                if (hit.transform != null)
                {
                    Destroy(gameObject);
                    Powerbar.CurrentPower += power;
                    Tidy.SetActive(true);
                    clickMe.SetActive(true);
                    FindObjectOfType<AudioManager>().Play(soundName);

                }
            }
        }


    }
}
