using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public static playermovement Instance;
    public static bool start_menu = true;

    [SerializeField] private float move_speed = 5f;
    [SerializeField] private float mouse_rotation = 100f;
    [SerializeField] private Transform camera;
    private float Xrotation = 0f;
    private float Yrotation = 0f;
    private float jump;
    private bool is_dead;

    private bool isGrounded;

    private Rigidbody rb;

    [SerializeField] private GameObject menu;

    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        is_dead = false;
        menu.SetActive(start_menu);
        Debug.Log(start_menu);
    }

    void Unlock()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (is_dead)
        {
            return; 
        }
        float mouseX = Input.GetAxis("Mouse X")*Time.deltaTime*mouse_rotation; 
        float mouseY = Input.GetAxis("Mouse Y")*Time.deltaTime*mouse_rotation; 


        Xrotation -= mouseY;
        Xrotation = Mathf.Clamp(Xrotation, -90f, 90f);


        Yrotation+=mouseX;

        transform.rotation = Quaternion.Euler(0f,Yrotation,0f);
        camera.localRotation = Quaternion.Euler(Xrotation,0,0);

    }

    void FixedUpdate()
    {
        if (is_dead)
        {
            return; 
        }
        float x = Input.GetAxis("Horizontal") * move_speed;
        float z = Input.GetAxis("Vertical") * move_speed;
        Vector3 move = (transform.right * x + transform.forward * z);
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            isGrounded = false;
        }

        RaycastHit Hit;
        if (Physics.Raycast(transform.position, -Vector3.up, out Hit, (-rb.linearVelocity.y)))
        {
            Debug.DrawLine(transform.position, Hit.point, Color.black);

            if (Hit.collider.gameObject.tag == "Floor")
            {
                isGrounded = true;
            }

         }



    }

    public void DeathUnlock()
    {
        is_dead = true;
        Cursor.lockState = CursorLockMode.None;
    }
}


