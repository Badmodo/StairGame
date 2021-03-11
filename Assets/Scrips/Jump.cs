using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float gravity = -9.8f;
    public float jumpForce = 15.0f;


    private float verticalVelocity;
    private float gravityJump = 14.0f;

    private CharacterController _charController;


    void Start()
    {
        _charController = GetComponent<CharacterController>();
    }

    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
         {
             verticalVelocity = jumpForce;
         }

        Vector3 jumpVector = new Vector3(0, verticalVelocity, 0);
        _charController.Move(jumpVector * Time.deltaTime);
    }
}
