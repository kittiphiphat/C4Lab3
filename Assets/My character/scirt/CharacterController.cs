using UnityEngine;

public class CharacterController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // ดึง Animator มาจาก component
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // กด S เพื่อเปลี่ยนไปสถานะนั่ง
        if (Input.GetKeyDown(KeyCode.S)) 
        {
            UpdateAnimator(true, false, false);  
        }

        // กด W เพื่อเปลี่ยนไปสถานะเดิน
        if (Input.GetKeyDown(KeyCode.W)) 
        {
            UpdateAnimator(false, true, false);
        }

        // กด D เพื่อเปลี่ยนไปสถานะเต้น
        if (Input.GetKeyDown(KeyCode.D)) 
        {
            UpdateAnimator(false, false, true);
        }
    }

    // ฟังก์ชันนี้จะอัปเดตสถานะใน Animator โดยตรงตามค่าที่ส่งเข้ามา
    void UpdateAnimator(bool isSitting, bool isWalking, bool isDancing)
    {
        // อัปเดตสถานะไปยัง Animator
        animator.SetBool("IsSitting", isSitting);
        animator.SetBool("IsWalking", isWalking);
        animator.SetBool("IsDancing", isDancing);
    }
}
