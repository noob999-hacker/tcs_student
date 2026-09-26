using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour

{
    private float timer;
    private float spawnTimer = 15;
    [SerializeField] List<GameObject> enemy_list;
    public int active_threshold;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(active_threshold > Empty_warrior.enemy_count)
        {
            return;
        }
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
