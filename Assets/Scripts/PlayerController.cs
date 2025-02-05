using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 5f;
    public float jumpHeight = 2f;
    public float gravity = -9.8f;
    public Camera playerCamera;
    public float shootRange = 50f;
    public LayerMask targetLayer;
    
    private Vector3 velocity;
    private bool isGrounded;
    // Ceci fera en sorte que la caméra suive l'orientation
    public Transform cameraTransform;

    public GameObject projectilePrefab;
    public Transform firePoint;



    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Shoot()
    {
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }

    void Update()
    {
        isGrounded = controller.isGrounded;

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveDirection = cameraTransform.forward * moveZ + cameraTransform.right * moveX;
        moveDirection.y = 0f; // Afin que le joueur reste cloué au sol
        controller.Move(moveDirection.normalized * speed * Time.deltaTime);

        if (isGrounded)
        {
            velocity.y = -2f;

            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            }
    }
    else
    {
        velocity.y += gravity * Time.deltaTime;
    }
    controller.Move(velocity * Time.deltaTime);
    if (Input.GetButtonDown("Fire1"))
    {
        Shoot();
    }
    }
}
