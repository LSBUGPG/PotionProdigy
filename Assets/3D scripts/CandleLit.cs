using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandleLit : MonoBehaviour
{
    public int power;
    public GameObject powabar;
    public GameObject particles;
    public string soundName;

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
                    Powerbar.CurrentPower += power;
                    FindObjectOfType<AudioManager>().Play(soundName);
                    particles.SetActive(true);

                }
            }
        }


    }
}
