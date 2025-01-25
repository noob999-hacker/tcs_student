using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Playermovement : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movevertical = Input.GetAxis("Vertical")*15;
        float movehorizontal=Input.GetAxis("Horizontal")*15;
        rb.velocity = new Vector2(movehorizontal, movevertical);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "poor guy gets yeeted")
        {
            Destroy(gameObject);
        }

    }

    private void FixedUpdate()
    {

    }
}
