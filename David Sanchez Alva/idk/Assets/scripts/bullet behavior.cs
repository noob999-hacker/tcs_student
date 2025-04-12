using UnityEngine;

public class bulletbehavior : MonoBehaviour
{
    private GameObject target;
    private AudioSource[] audio;
    [SerializeField] private AudioClip Shoot_noise;
    [SerializeField] private AudioClip hit_noise;

    void OnCollisionEnter2D(Collision2D other){
        Destroy(gameObject);
    }

    void OnDestroy()
    {
        GameObject death_sfx = new GameObject("death_sfx");
        death_sfx.AddComponent<AudioSource>();
        death_sfx.GetComponent<AudioSource>().clip = hit_noise;
        death_sfx.GetComponent<AudioSource>().Play();
    }

    void Start()
    {
        audio = GetComponents<AudioSource>();    
        audio[0].PlayOneShot(Shoot_noise);
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
