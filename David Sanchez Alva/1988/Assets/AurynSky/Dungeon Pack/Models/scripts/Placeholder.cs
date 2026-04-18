using UnityEngine;

public class Placeholder : MonoBehaviour

{
    [SerializeField] public int damage;
    private float timer;
    public float dmg_cd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        Player_HP PlayerHealth = other.gameObject.GetComponentInParent<Player_HP>();
        if(PlayerHealth != null)
        {
            if (timer >= dmg_cd)
            {
                PlayerHealth.Health(damage);
                Debug.Log ("atk player");
                timer = 0;
            }
            
        }
    }
}
