using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour {
    public float moveSpeed;

    public float jumpSpeed = 8f;
    private float movement = 0f;
    private Rigidbody2D rigidBody;

    // Use this for initialization
    void Start () {
        moveSpeed = .08f;
        rigidBody = GetComponent<Rigidbody2D>();

    }
    public bool lookRight = true;


    // Update is called once per frame
    void Update () {

        movement = Input.GetAxis("Horizontal");
        if (Input.GetKey("right")){
            transform.Translate(new Vector3(moveSpeed, 0, 0));
            if (!lookRight)
            {
                Flip();
            }
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(new Vector3(-moveSpeed, 0, 0));
            if (lookRight)
            {
                Flip();
            }
        }
       /* if (Input.GetKey("left"))
        {
            rigidBody.velocity = new Vector2(rigidBody.velocity.x, jumpSpeed);
        }*/
    }

    void Flip(){
        lookRight = !lookRight;
        Vector3 charscale = transform.localScale;
        charscale.x *= -1;
        transform.localScale = charscale;
    }

}
