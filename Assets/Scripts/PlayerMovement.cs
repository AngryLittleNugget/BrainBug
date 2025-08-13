using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 2;
    Vector2 movement;
    Rigidbody2D rb;
    GameObject player;
    float movementHorizontal;
    float movementVertical;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        movementHorizontal = Input.GetAxisRaw("Horizontal");
        movementVertical = Input.GetAxisRaw("Vertical");

        rb.linearVelocityX = movementHorizontal * speed;
        rb.linearVelocityY = movementVertical * speed;

        if (movementHorizontal != 0 || movementVertical != 0)
        {
            DisplayAxis();
        }

        /* if (Input.GetKey(KeyCode.LeftArrow))
         {
             rb.linearVelocityX = -speed;
         }
          if (Input.GetKey(KeyCode.RightArrow))
         {
             rb.linearVelocityX = speed;
         }
          if (Input.GetKey(KeyCode.UpArrow))
         {
             rb.linearVelocityY = speed;
         }
          if (Input.GetKey(KeyCode.DownArrow))
         {
             rb.linearVelocityY = -speed;
         }*/

    }

    void DisplayAxis()
    {
        Debug.Log($" Horizontal axis: {movementHorizontal} Vertical Axis: {movementVertical}");
    }
}
