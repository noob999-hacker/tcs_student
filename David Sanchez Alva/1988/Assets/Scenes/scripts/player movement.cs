using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] private float move_speed = 5f;
    
    private Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
