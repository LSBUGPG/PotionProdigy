using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIMasking : MonoBehaviour
{
    private bool ClickUI;
    public string Test;

             private void OnMouseUp()
    {
        ClickUI = false;
        if (EventSystem.current.IsPointerOverGameObject())
        {
            if (EventSystem.current.currentSelectedGameObject.name == Test)
            {
                ClickUI = true;
            }
        }

        if (ClickUI)
        {
            Debug.Log("Click UI button");
        }
    }
}
