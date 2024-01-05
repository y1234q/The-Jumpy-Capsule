using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float sensitivity = 0.5f;

    private void Update()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up * mouseX * sensitivity);

        float currentRotationX = transform.rotation.eulerAngles.x;
        float newRotationX = Mathf.Clamp(currentRotationX - mouseY * sensitivity, 0f, 90f);

        transform.rotation = Quaternion.Euler(newRotationX, transform.rotation.eulerAngles.y, 0f);
    }
}
