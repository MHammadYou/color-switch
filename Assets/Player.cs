using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Player : MonoBehaviour
{

    public float jumpForce = 10f;

    public Rigidbody2D rb;
    public string currentColor;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }
    
    public void OnTriggerEnter2D(Collider2D self)
    {
        SetRandomColor();
    }

    private void SetRandomColor()
    {
        var index = Random.Range(0, 3);

        switch (index) 
        {
            case 0:
                currentColor = "Cyan";
                break;
            case 1:
                currentColor = "Yellow";
                break;
            case 2:
                currentColor = "Magenta";
                break;
            case 3:
                currentColor = "Pink";
                break;
        }
    }

}
