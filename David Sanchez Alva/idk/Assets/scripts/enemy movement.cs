using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    [SerializeField] private Transform[] nodes;
    [SerializeField] private float movespeed = 2f;
    [SerializeField]
    private int health=100;
    private int current_node = 0;
    [SerializeField] private GameObject market;
    void Update()
    {
        Transform target_node = nodes[current_node];
        transform.position = Vector3.MoveTowards(
            transform.position,target_node.position,movespeed*Time.deltaTime
        );
        if(Vector3.Distance(transform.position,target_node.position) < 0.1){
            current_node += 1;
            if(current_node>=nodes.Length){
                GameObject.Find("bass").GetComponent<baseHP>().TakeDamage(10);
                Destroy(gameObject);
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other){
        health -=5;
        if(health<=0){
            market.GetComponent<blackj_market>().unpaid_taxes += 50;
            
            Destroy(gameObject);
        }
    }
    void Start()
    {
        transform.position = new Vector3(8.14f,1.28f,0.00f);
        market=GameObject.FindAnyObjectByType<blackj_market>().gameObject;
    }



    // Update is called once per frame
    
    
        
    
}
