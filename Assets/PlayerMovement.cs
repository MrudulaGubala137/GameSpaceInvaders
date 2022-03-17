using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public int playerSpeed;
    private Vector2 movement;
    Rigidbody2D rb;
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        
        
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position+movement*playerSpeed*Time.fixedDeltaTime);
    }
}
