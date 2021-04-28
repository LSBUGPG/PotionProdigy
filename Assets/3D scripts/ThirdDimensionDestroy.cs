using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdDimensionDestroy : MonoBehaviour
{
    public int power;
    public GameObject powabar;

    // Start is called before the first frame update
    void Start()
    {

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
                    Destroy(gameObject);
                    Powerbar.CurrentPower += power;

                }
            }
        }


    }
}
