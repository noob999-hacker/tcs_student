using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour

{
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(new Vector3(0, 100, 0), ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnCollision(Collision collision)
    {

      Destroy(gameObject);
    }
}
