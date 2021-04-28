using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectThreeD : MonoBehaviour
{
    public int power;
    public GameObject powabar;
    public string soundName;
    public GameObject panel;
    public GameObject particles;

    // Start is called before the first frame update
    void Start()
    {
        powabar.GetComponent<Powerbar>();
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10000.0f))
            {
                if (hit.transform != null)
                {
                    if (gameObject.name == "stick")
                    {
                        Powerbar.CurrentPower += power;
                        GameObject.Find("Lavender UI").GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                        this.gameObject.SetActive(false);
                        FindObjectOfType<AudioManager>().Play(soundName);
                        particles.SetActive(false);
                        panel.SetActive(true);
                    }

                    if (gameObject.name == "Petal")
                    {
                        Powerbar.CurrentPower += power;
                        GameObject.Find("Petal UI").GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                        this.gameObject.SetActive(false);
                        FindObjectOfType<AudioManager>().Play(soundName);
                        panel.SetActive(true);
                        particles.SetActive(false);
                    }

                    if (gameObject.name == "Collect Jar")
                    {
                        Powerbar.CurrentPower += power;
                        GameObject.Find("Jar UI").GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
                        this.gameObject.SetActive(false);
                        FindObjectOfType<AudioManager>().Play(soundName);
                        panel.SetActive(true);
                        
                    }

                }


            }
        }


    }
}
