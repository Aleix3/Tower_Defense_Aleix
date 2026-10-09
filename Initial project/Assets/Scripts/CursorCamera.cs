using UnityEngine;

public class CursorCamera : MonoBehaviour
{
    public float sensivity = 2f;

    public Transform player;

    private float verticalRotation = 0f;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensivity;

        verticalRotation -= mouseY;

        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        player.Rotate(Vector3.up * mouseX);
    }
}
