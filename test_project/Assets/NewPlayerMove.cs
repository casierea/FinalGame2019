using UnityEngine;
using System.Collections;

public class NewPlayerMove : MonoBehaviour
{
    public float Smooth = 1f;
    public float Speed = 10.0f;
    public float JumpSpeed = 100.0f;
    public float Gravity = 15.0f;

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

    void update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        MoveLeftRight();

        if (controller.isGrounded & Input.GetButton("Jump"))
        {
            Jump();
        }

        moveDirection.y -= Gravity * Gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void Jump()
    {
        moveDirection.y = JumpSpeed;
    }

    void MoveLeftRight()
    {
        moveDirection = new Vector3((Input.GetAxis("Horizontal")), 0, 0);

        if (Input.GetKey(KeyCode.A) | Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = lookLeft;
            moveDirection = transform.TransformDirection(-moveDirection);
            moveDirection *= Speed;
        }

        if (Input.GetKey(KeyCode.D) | Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = lookRight;
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= Speed;
        }
    }
}