using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chageCol : MonoBehaviour
{

    public GameObject Button;
    public bool clicked;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {

        if (clicked)
        {
            var cubeRenderer = Button.GetComponent<Renderer>();
            cubeRenderer.material.SetColor("_Color", Color.red);
        }
    }


    private void OnMouseDown()
    {
        clicked = true;
    }


}
