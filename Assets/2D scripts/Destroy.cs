using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject powabar;

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Glass"))
        {
            Destroy(collision.gameObject);
            Powerbar.CurrentPower += 1;
            FindObjectOfType<AudioManager>().Play("Glass");
        }
    }
}
