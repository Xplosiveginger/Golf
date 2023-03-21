using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private float horizontal;
    private float vertical;
    private Rigidbody rb;

    [SerializeField] private float speed = 2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if(Input.GetAxis("Horizontal") != 0)
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z + horizontal * speed * Time.deltaTime);
        }

        if(Input.GetAxisRaw("Vertical") != 0)
        {
            rb.velocity = new Vector3(rb.velocity.x + vertical * -1 * speed * Time.deltaTime, rb.velocity.y, rb.velocity.z);
        }
    }
}
