using UnityEngine;

public class Mouvement : MonoBehaviour {
    public Rigidbody rb;

    private const float VELOCITY = 0.03f;
    private const float JUMP_FORCE = 5f;
    private const float GROUND_DISTANCE = 0.00001f;

    private bool jump_is_enable;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump_is_enable = true;
    }

    bool IsGrounded()
    {
        return Physics.Raycast(transform.position, -Vector3.up, GROUND_DISTANCE + transform.lossyScale.y) && rb.linearVelocity.y==0;
    }

    void Update()
    {
        float velocity = Input.GetKey(KeyCode.LeftShift) ? VELOCITY * 2.5f : VELOCITY;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * velocity);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.back * velocity);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.up, -2);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up, 2);
        }

        if (Input.GetKey(KeyCode.Space) && IsGrounded())
        {
            if (jump_is_enable)
            {
                jump_is_enable = false;
                rb.AddForce(transform.up * JUMP_FORCE, ForceMode.VelocityChange);
            }
        }
        else
        {
            jump_is_enable = true;
        }
    }
}
