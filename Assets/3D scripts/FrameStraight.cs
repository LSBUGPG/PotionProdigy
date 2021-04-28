using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameStraight : MonoBehaviour
{
    public GameObject Frame;
    public int power;
    public GameObject powabar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        if (enabled)
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10000.0f))
            {
                if (hit.transform != null)
                {
                    Frame.transform.Rotate(new Vector3(145.0f, 0, 0));
                    enabled = false;
                    Powerbar.CurrentPower += power;

                }
            }
        }


    }
}
