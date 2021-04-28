using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatNoise : MonoBehaviour
{
    public string soundName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            {
                FindObjectOfType<AudioManager>().Play(soundName);
            }
        }
    }
}
