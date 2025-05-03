using System.Runtime.CompilerServices;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private float move_speed = 5f;
    [SerializeField] private float mouse_rotation = 100f;
    private float Yrotation = 0f;
    
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X")*Time.deltaTime*mouse_rotation; 
        float mouseY = Input.GetAxis("Mouse Y")*Time.deltaTime*mouse_rotation; 

        Yrotation+=mouseX;

        transform.rotation = Quaternion.Euler(0f,Yrotation,0f);
    }

    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal")*move_speed;
        float z = Input.GetAxis("Vertical")*move_speed;
        Vector3 move = (transform.right*x + transform.forward*z);
        rb.linearVelocity = new Vector3(move.x,rb.linearVelocity.y,move.z);

    }
}
