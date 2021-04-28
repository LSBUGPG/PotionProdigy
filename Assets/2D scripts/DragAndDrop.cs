using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    private bool selected;
    public string soundName;
    public GameObject particles;

    private void Update()
    {

        if (selected == true)
        {


            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000.0f))
            {

                transform.position = hit.point;
            }
            particles.SetActive(true);
        }
        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
            particles.SetActive(false);
        }
    }
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selected = true;
            FindObjectOfType<AudioManager>().Play(soundName);
        }
    }
}
