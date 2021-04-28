using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOff : MonoBehaviour
{
    public GameObject myLight;
    public GameObject particles;
    public bool off;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10000.0f))
            {
                if (hit.transform.tag == "Switch" && off == false)
                {
                    myLight.SetActive(false);
                    particles.SetActive(true);
                    off = true;

                }
                else if (hit.transform.tag == "Switch" && off == true)
                {
                    myLight.SetActive(true);
                    particles.SetActive(false);
                    off = false;
                }
            }
        }
    }
}
