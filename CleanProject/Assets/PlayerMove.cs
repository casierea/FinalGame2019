using UnityEngine;
using System.Collections;

public class PlayerMoves : MonoBehaviour
{

   public float smooth = 1f;
   public float speed = 10.0F;
   public float jumpSpeed = 15.0F;
   public float gravity = 20.0F;
   private Quaternion lookLeft;
   private Quaternion lookRight;
   private Vector3 moveDirection = Vector3.zero;

   void Start()
   {
      Cursor.visible = false;
      Time.timeScale = 1;

      lookRight = transform.rotation;
      lookLeft = lookRight * Quaternion.Euler(0, 180, 0);
   }

   void Update()
   {
      CharacterController controller = GetComponent<CharacterController>();
      moveDirection = new Vector3((Input.GetAxis("Horizontal")), 0, 0);
      if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
      {

         transform.rotation = lookLeft;
         moveDirection = transform.TransformDirection(-moveDirection);
         moveDirection *= speed;

      }

      if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
      {
         transform.rotation = lookRight;
         moveDirection = transform.TransformDirection(moveDirection);
         moveDirection *= speed;
      }
      
      //Only jump if controller is grounded
      if (controller.isGrounded & Input.GetButton("Jump"))
      {
         jump();
      }

      moveDirection.y -= gravity * Time.deltaTime;
      controller.Move(moveDirection * Time.deltaTime); //move character
   }

   void jump()
   {
      moveDirection.y = jumpSpeed;
   }

}