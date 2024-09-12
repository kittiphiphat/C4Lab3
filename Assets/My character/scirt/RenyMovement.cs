using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenyMovement : MonoBehaviour
{
    Animator anim;
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public float force = 700.0f;
    public float jumpForce = 700.0f;
    public float gravity = 20.0f;
    public bool isGrounded = false;
    Vector3 moveDirection = Vector3.zero;
    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // ดึงค่าการกดปุ่ม W, S, D
        if (Input.GetKey(KeyCode.W))
        {
            anim.SetBool("isWalking", true);  // เงื่อนไขสำหรับเดิน
            anim.SetBool("isDancing", false); // หยุดเต้นเมื่อกดเดิน
            anim.SetBool("isDef", false);     // ปิดสถานะอื่น
        }
        else if (Input.GetKey(KeyCode.S))
        {
            anim.SetBool("isWalking", false); // หยุดเดิน
            anim.SetBool("isDancing", false); // ปิดเต้น
            anim.SetBool("isDef", true);      // กำหนดท่าเริ่มต้น (sitting)
        }
        else if (Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isWalking", false); // หยุดเดิน
            anim.SetBool("isDancing", true);  // กดเต้นเมื่อกด D
            anim.SetBool("isDef", false);     // ปิดท่านั่งหรือท่าเริ่มต้น
        }
        else
        {
            // กรณีที่ไม่กดอะไร
            anim.SetBool("isWalking", false);
            anim.SetBool("isDancing", false);
            anim.SetBool("isDef", true);      // กลับไปท่าพัก
        }

        // ระบบการเคลื่อนไหว (ยังไม่เปิดใช้งานในตัวอย่างนี้)
        // if (controller.isGrounded)
        // {
        //     moveDirection = transform.TransformDirection(new Vector3(-Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal")));
        //     moveDirection *= speed;
        //     if (Input.GetButton("Jump"))
        //     {
        //         moveDirection.y = jumpForce;
        //     }
        // }
    }
}
