using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private Vector3 cameraPosition = new Vector3(0, 1, -10);
    private int health = 10;
    public TextMeshProUGUI cubeHealthBar;


    protected void Move(float speed)
    {
        transform.Translate((cameraPosition - gameObject.transform.position).normalized * speed * Time.deltaTime);
    }


    protected virtual void OnMouseDown()
    {
        health -= 1;
        cubeHealthBar.text = health.ToString();
    }


    private void Update()
    {
        Move(0.5f);
        OnMouseDown();
        
    }

    


}
