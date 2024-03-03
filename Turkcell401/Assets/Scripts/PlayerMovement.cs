using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float jumpValue = 2;
    [SerializeField] float moveSpeed = 2;


    Rigidbody2D rb;
    Animator animator;
    Joystick joyStick;
    JoystickButton joystickButton;


    [field:SerializeField] public int JumpRight { get; set; } = 3;
    [field: SerializeField] public int JumpNumber { get; set; } = 0;

    bool isJump;


    private void Awake()
    {
        joystickButton = FindObjectOfType<JoystickButton>();
        joyStick = FindObjectOfType<Joystick>();
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space") || joystickButton.ButtonPressed && !isJump) //space e basinca JumpNumber cok artiyor,neden??
                                                                                  //buttonpressedte oyle bir sikinti yok
        {
            isJump = true;
            PlayerJumpStart();
        }

        if (Input.GetKeyUp("space") || !joystickButton.ButtonPressed && isJump)
        {
            isJump = false;
            PlayerJumpEnd();
        }
    }

    private void FixedUpdate()
    {
#if UNITY_EDITOR
        PlayerHorizontalMovementWithKeyboard();
#else
        PlayerHorizontalMovementWithJoystick();
#endif
    }

    private void PlayerJumpStart()
    {
        if (JumpNumber < JumpRight)
        {
            rb.velocity = new Vector2(0, jumpValue);
            //rb.AddForce(new Vector2(0, jumpValue), ForceMode2D.Impulse);
            animator.SetBool("Jump", true);
            FindObjectOfType<SliderControl>().SliderValue(JumpRight, JumpNumber);
        }
            
    }

    void PlayerJumpEnd()
    {
        animator.SetBool("Jump", false);
        JumpNumber++;
        FindObjectOfType<SliderControl>().SliderValue(JumpRight, JumpNumber);

    }
    private void PlayerHorizontalMovementWithKeyboard()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        if (horizontal != 0)
        {
            transform.Translate(new Vector2(horizontal * moveSpeed, 0));
            //rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(horizontal * 0.3f, 0.3f);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }

    private void PlayerHorizontalMovementWithJoystick()
    {
        float joystickMovement = joyStick.Horizontal;

        if (joystickMovement != 0)
        {
            transform.Translate(new Vector2(joystickMovement * moveSpeed, 0));
            //rb.velocity = new Vector2(horizontal * moveSpeed, rb.velocity.y);
            transform.localScale = new Vector2(Mathf.Sign(joystickMovement) * 0.3f, 0.3f);
            animator.SetBool("Walk", true);
        }
        else
        {
            animator.SetBool("Walk", false);
        }
    }
}
