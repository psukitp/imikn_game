using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPerson : MonoBehaviour
{
    public float speed;
    private Vector2 direction;
    private Rigidbody2D rigidBody;
    public float scale;
    private Animator anim;
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        speed = 30;
        scale = transform.localScale.x;
        anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        if (direction.x == 1) transform.localScale = new Vector2(-scale, transform.localScale.y);
        else if (direction.x == -1) transform.localScale = new Vector2(scale, transform.localScale.y);
        direction.y = Input.GetAxisRaw("Vertical");
        if (direction.x != 0 || direction.y != 0)
        {
            anim.SetInteger("moving", 1);
        }
        else anim.SetInteger("moving", 0);

        rigidBody.MovePosition(rigidBody.position + direction * speed*Time.deltaTime);
    }
}
