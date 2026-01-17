using UnityEngine;

public class GenericBullet : MonoBehaviour

{
    private Rigidbody rb;
    public int shootvelocity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
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
    public void Shoot(Vector3 shootdirection)
  {
          rb.AddRelativeForce(shootdirection * shootvelocity, ForceMode.Impulse);
          transform.LookAt(shootdirection);
  }
}
