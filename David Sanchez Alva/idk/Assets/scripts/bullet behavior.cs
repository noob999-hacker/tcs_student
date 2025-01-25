using UnityEngine;

public class bulletbehavior : MonoBehaviour
{
    private GameObject target;

    void OnCollisionEnter2D(Collision2D other){
        Destroy(gameObject);
    }
    void Start()
    {
      target=GameObject.FindWithTag("enemy");   
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=Vector3.MoveTowards(
            transform.position,target.transform.position,5*Time.deltaTime
        );
    }


}
