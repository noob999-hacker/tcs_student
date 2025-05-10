using UnityEngine;
using System.Collections.Generic;
public class Pathfinding : MonoBehaviour
{

    private List<Transform> nodes = new List<Transform>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       foreach(Transform child in gameObject.transform){
            nodes.Add(child);
       } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
