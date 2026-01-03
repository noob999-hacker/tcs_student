using UnityEngine;

public class GenericBullet : MonoBehaviour

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


    void OnCollisionEnter(Collision collision)
    {
      if (collision.gameObject.GetComponent<Empty_warrior>() != null)
    {
       Empty_warrior Enemy = collision.gameObject.GetComponent<Empty_warrior>();
       Enemy.Damage(100);
      Destroy(gameObject);

    }
     
    }
}
