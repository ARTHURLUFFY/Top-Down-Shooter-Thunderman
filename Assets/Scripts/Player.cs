using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveAmount;

    //Animator
    private Animator anim;

    public static float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 1;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxis("Vertical"));
        moveAmount = moveInput.normalized * speed;

        if (moveInput != Vector2.zero)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveAmount * Time.fixedDeltaTime);
    }

    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
