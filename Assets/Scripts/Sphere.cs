using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Cube
{
    private void Start()
    {
        health = 30;
        speed = 0.5f;
    }

    public override void Move()
    {

        base.Move();
    }



    public override void HealthBar()
    {
        base.HealthBar();
    }
}
