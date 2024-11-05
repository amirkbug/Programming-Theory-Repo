using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sphere : Cube
{
    private int sphereHealth = 20;
    public TextMeshProUGUI sphereHealthBar;


    protected override void OnMouseDown()
    {
        sphereHealth -= 5;
    }



    // Update is called once per frame
    void Update()
    {
        Move(0.2f);
        OnMouseDown();
    }
}
