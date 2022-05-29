using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class NPSMoving : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D body;
    public float horizontalMoving;
    public float verticalMoving;
    public Vector2 direction;
    private string typeOfMove;
    public float scale;
    private Animator anim;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        var moving = -1 * speed * Time.deltaTime;
        horizontalMoving = moving;
        verticalMoving = body.velocity.y;
        direction = -transform.right;
        Debug.DrawRay(transform.position, direction);
        typeOfMove = "horizontal";
        scale = transform.localScale.x;
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        Ray2D ray = new Ray2D();
        ray.origin = transform.position;
        ray.direction = direction;
        anim.SetInteger("stay", 1);
        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, 0.5f);
        if(hit!=null && hit.collider!=null && hit.collider.gameObject.GetComponent<PolygonCollider2D>()!=null)
        {
            if(typeOfMove=="vertical")
            {
                if (Random.Range(0, 2) == 0)
                {
                    horizontalMoving = -1;
                    verticalMoving = 0;
                    direction = -transform.right;
                    typeOfMove = "horizontal";
                    transform.localScale = new Vector2(scale, transform.localScale.y);
                }
                else
                {
                    horizontalMoving = 1;
                    verticalMoving = 0;
                    direction = transform.right;
                    typeOfMove = "horizontal";
                    transform.localScale = new Vector2(-scale, transform.localScale.y);
                }
            }
            else
            {
                if (Random.Range(0, 2) == 0)
                {
                    horizontalMoving = 0;
                    verticalMoving = -1;
                    direction = -transform.up;
                    typeOfMove = "vertical";
                }
                else
                {
                    horizontalMoving = 0;
                    verticalMoving = 1;
                    direction = transform.up;
                    typeOfMove = "vertical";
                   
                }
            }
        }
        Vector2 movement = new Vector2(horizontalMoving, verticalMoving);
        body.velocity = movement;
    }
}
