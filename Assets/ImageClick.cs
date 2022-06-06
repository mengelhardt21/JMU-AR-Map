using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageClick : MonoBehaviour {

    bool mat1 = true;
    bool mat2 = false;

    //Switches the AR image from one to the other.
    private void OnMouseDown()
    {
        Material material1 = Resources.Load("JMU Lakeview Hall Pin", typeof(Material)) as Material;
        Material material2 = Resources.Load("JMU Map Lakeside Highlight", typeof(Material)) as Material;
        Renderer renderer = GetComponent<Renderer>();

        if(mat1)
        {
            renderer.material = material2;
            mat2 = true;
            mat1 = false;
        }

        else if(mat2)
        {
            renderer.material = material1;
            mat1 = true;
            mat2 = false;
        }
    }
}
