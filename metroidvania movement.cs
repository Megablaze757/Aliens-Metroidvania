using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metroidvaniamovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float gravity = 1.0f;
    [SerializeField]
    private float jumpheight = 15.0f;
    private float yvelocity;
    private bool candoublejump = false;

    private CharacterController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 direction = new Vector2(horizontalInput, 0);
        Vector2 velocity = direction * speed;
        if (controller.isGrounded == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                yvelocity = jumpheight; ;
                candoublejump = true;
            }
            else
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    yvelocity += jumpheight;
                    candoublejump = false;


                }

            }
            
            


            
                
             

        }
        else
        {
            yvelocity -= gravity;
        }
        yvelocity = velocity.y;
        controller.Move(velocity * Time.deltaTime);
    }
}
