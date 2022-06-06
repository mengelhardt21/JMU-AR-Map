using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMap : MonoBehaviour
{

    private void OnMouseDown()
    {
        Application.OpenURL("https://www.jmu.edu/map/");
    }
}
