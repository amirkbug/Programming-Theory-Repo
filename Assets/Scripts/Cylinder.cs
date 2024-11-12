using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

//INHERITANCE
public class Cylinder : Cube
{

    private void Start()
    {
        health = 20;
        speed = 5;
    }

    // POLYMORPHISM
    public override void HealthBar()
    {

        health -= 1;
        base.HealthBar();


    }


    // POLYMORPHISM
    public override void Move()
    {
        base.Move();
    }
}
