using UnityEngine;

public class bulletbehavior : MonoBehaviour
{
    private GameObject target;

    void OnCollisionEnter2D(Collision2D other){
        Destroy(gameObject);
    }
    void Start()
    {
      //target=GameObject.FindWithTag("enemy");   
    }
    public void settarget(GameObject newtarget){
        target = newtarget;
    }

    // Update is called once per frame
    void Update()
    {
        if(target==null){
            Destroy(gameObject);
        }
        transform.position=Vector3.MoveTowards(
            transform.position,target.transform.position,5*Time.deltaTime
        );
    }


}
