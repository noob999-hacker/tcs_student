using System.Collections.Generic;
using UnityEngine;

public class genericenemy : MonoBehaviour
{


    [SerializeField] private float move_speed = -5000000000000f;
    [SerializeField] private float health = 100f;
    [SerializeField] private float attack = 100f;
    [SerializeField] private GameObject Pathway;
    [SerializeField] private List<Transform> nodes = new List<Transform>();


    private int current_node = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach(Transform node in Pathway.transform){
            nodes.Add(node);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void FixedUpdate()
    {
        if(current_node < nodes.Count){
            transform.position = Vector3.MoveTowards(transform.position, nodes[current_node].position, move_speed);
            if(transform.position == nodes[current_node].position){
                current_node++;
            }
        }
    }
}
