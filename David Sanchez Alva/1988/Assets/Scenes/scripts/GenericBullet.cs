using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector3(100, 0, 0), ForceMode.Impulse);
    }
}
