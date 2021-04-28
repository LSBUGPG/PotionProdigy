using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    private SpriteRenderer rend;
    public Sprite overSprite;
    public GameObject powabar;
    public bool clicked;
    public string soundName;
    public int power;
    public GameObject particles;
    public bool useMouse = true;

    // Start is called before the first frame update
    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {

    }
        void OnMouseDown()
    {
        if (useMouse && Input.GetMouseButton(0))
        {
            change();
        }
    } 
    public void change()
    {
        if (clicked == false)
        {
            clicked = true;
            rend.sprite = overSprite;
            Powerbar.CurrentPower += power;
            particles.SetActive(true);
            FindObjectOfType<AudioManager>().Play(soundName);

        }
    }
}
