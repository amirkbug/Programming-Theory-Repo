using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Sphere : Cube
{
    private void Start()
    {
        health = 30;
        speed = 0.5f;
    }

    // POLYMORPHISM
    public override void Move()
    {

        base.Move();
    }


    // POLYMORPHISM
    public override void HealthBar()
    {
        base.HealthBar();
    }
}
