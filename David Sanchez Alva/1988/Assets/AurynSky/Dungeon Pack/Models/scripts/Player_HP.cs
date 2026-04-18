using UnityEngine;

public class Player_HP : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int playing_hp;
    [SerializeField] private int max_hp;
        void Start()
    {
        playing_hp = max_hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Health(int damage)
    {
        playing_hp -= damage;
      if (playing_hp <= 0)
      Debug.Log ("Player died");
        {
            //Destroy(gameObject);
        } 
    }
}
