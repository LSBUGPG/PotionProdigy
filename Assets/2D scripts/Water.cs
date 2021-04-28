using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    public GameObject powabar;
    public ChangeSprite changeSprite;
    public bool watered;

    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Water"))
        {
            if (watered == false) 
            {
                watered = true;
                changeSprite.change();
                Powerbar.CurrentPower += 1;
                FindObjectOfType<AudioManager>().Play("Can");
            }
        }
    }
}
