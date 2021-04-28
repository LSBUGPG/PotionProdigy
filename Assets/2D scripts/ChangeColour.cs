using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    
    // Start is called before the first frame update
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(spriteRenderer != null)
        {
            if (gameObject.name == "Shaft")
            {
                Color newColor = Color.Lerp(new Color(1f, 1f, 1f, 0.1f), new Color(1f, 1f, 1f, 0.5f), Mathf.PingPong(Time.time, 4));
                spriteRenderer.color = newColor;
            }

            if (gameObject.name == "Ball")
            {
                Color newColor = Color.Lerp(new Color(1f, 1f, 1f, 0.1f), new Color(1f, 1f, 1f, 0.7f), Mathf.PingPong(Time.time, 1));
                spriteRenderer.color = newColor;
            }

            if (gameObject.name == "Light")
            {
                Color newColor = Color.Lerp(new Color(1f, 1f, 1f, 0.1f), new Color(1f, 1f, 1f, 0.9f), Mathf.PingPong(Time.time, 1));
                spriteRenderer.color = newColor;
            }
        }
    }

}
