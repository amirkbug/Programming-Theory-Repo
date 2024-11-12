using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float speedIntial = 1;
    public float speed
    {
        get { return speedIntial; }
        set
        {
            if (value <= 0)
            {

                Debug.LogError("you cant set zero or negative numbers for speed");

            }
            else
            {
                speedIntial = value;
            }
        }
    }

    private int healthIntial = 10;
    public int health
    {
        get { return healthIntial; }
        set
        {
            if (value < 0)
            {

                Debug.LogError("you cant set zero or negative numbers for health");
            }
            else
            {
                healthIntial = value;
            }
        }

    }
    [SerializeField]
    private TextMeshProUGUI healthBar;


    public virtual void Move()
    {
        transform.Translate(Vector3.back * speedIntial * Time.deltaTime);
    }



    public virtual void HealthBar()
    {
        healthIntial -= 1;
        healthBar.text = health.ToString();
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }

    private void OnMouseDown()
    {
        HealthBar();
    }

    private void Update()
    {
        Move();
    }
}
