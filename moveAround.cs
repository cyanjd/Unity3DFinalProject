using UnityEngine;
using System.Collections;
public class moveAround : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rigidBody;
    public int jumpHeight;
    private bool canJump;

    public int maxJumps;
    private int numJumps;
    public bool lookRight = true;

    // Use this for initialization
    void Start()
    {
        moveSpeed = .08f;
        rigidBody = GetComponent<Rigidbody2D>(); // to work with rigid body component of the thing this is attached to
        jumpHeight = 10;
        numJumps = 0;
        maxJumps = 3; 
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -7.93){
            transform.position = new Vector3((float)-7.93, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 7.93)
        {
            transform.position = new Vector3((float)7.93, transform.position.y, transform.position.z);
        }
        if (Input.GetKey("right"))
        {
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

        if (Input.GetKey("up") && (numJumps <= maxJumps))
        //if (Input.GetKey("up"))
        {
            rigidBody.velocity = new Vector2(0,jumpHeight);
            ++numJumps;
        }
    }

    void Flip()
    {
        lookRight = !lookRight;
        Vector3 charscale = transform.localScale;
        charscale.x *= -1;
        transform.localScale = charscale;
    }

   private void OnCollisionEnter2D(Collision2D collision)
    {
       /* if (collision.gameObject.CompareTag("Ground")){
            numJumps = 0; 
        }*/
       //Debug.Log("hit ground");
        numJumps = 0;
    }
}

//http://ericholsinger.com/jumping-and-double-jumping-in-unity-2d
//info on jumping