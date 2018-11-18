using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerMove : MonoBehaviour {
    
    public float smooth = 1f;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Quaternion lookLeft;
    private Quaternion lookRight;
    private Vector3 moveDirection = Vector3.zero;

    void Start(){
        Cursor.visible = false;
       
        Time.timeScale = 1;

        lookRight = transform.rotation;
        lookLeft = lookRight * Quaternion.Euler(0, 180, 0); 
    }

    void Update() {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded) {
            moveDirection = new Vector3(-(Input.GetAxis("Horizontal")), 0, 0);

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

            if (Input.GetKey(KeyCode.LeftArrow)){

                transform.rotation = lookLeft;
                moveDirection = transform.TransformDirection(-moveDirection);
                moveDirection *= speed;
            }

            if (Input.GetKey(KeyCode.RightArrow)){
                transform.rotation = lookRight;
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
            }
			
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}

