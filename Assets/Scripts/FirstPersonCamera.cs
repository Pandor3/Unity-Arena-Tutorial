using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    // Initialisation de la sensibilité de la souris et attachement au modèle du joueur
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float xRotation = 0f;

    void Start()
    {
        // Ceci va cacher le curseur et le bloquer au centre de l'écran
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Ceci va s'occuper de la direction de la caméra lorsque le joueur bouge la souris
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
