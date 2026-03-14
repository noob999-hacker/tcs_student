using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour

{
    private float timer;
    private float spawnTimer = 15;
    [SerializeField] List<GameObject> enemy_list;

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
        int spawn_index = UnityEngine.Random.Range(0,enemy_list.Count);
         GameObject bullet = Instantiate(enemy_list[spawn_index], transform.position, Quaternion.identity);
    }

}
