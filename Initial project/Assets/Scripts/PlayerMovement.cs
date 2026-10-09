using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int speed;
    private Rigidbody rb;
    public int jumpForce;
    public int dashForce;
    private bool canJump = true;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (UnityEngine.Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        if (UnityEngine.Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * speed * Time.deltaTime;
        }
        if (UnityEngine.Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
        if (UnityEngine.Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.Space) && canJump == true)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            canJump = false;
        }
        if (UnityEngine.Input.GetKeyDown(KeyCode.LeftShift))
        {
            rb.AddForce(transform.forward * dashForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
        }
    }
}
