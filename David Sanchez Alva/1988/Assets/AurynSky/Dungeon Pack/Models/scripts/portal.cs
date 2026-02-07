using UnityEngine;

public class portal : MonoBehaviour

{
    private float timer;
    private float spawnTimer = 15;
    [SerializeField] GameObject enemy;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        
            if (timer >= spawnTimer)
            {
                timer = 0;
                Spawn();
            }
        
    }

    void Spawn()
    {
         GameObject bullet = Instantiate(enemy, transform.position, Quaternion.identity);
    }

}
