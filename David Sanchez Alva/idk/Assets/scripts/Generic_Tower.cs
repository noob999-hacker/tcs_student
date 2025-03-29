using System;
using UnityEngine;

public class Generic_Tower : MonoBehaviour
{
    [SerializeField]private int Max_detection_range;
    [SerializeField]private string target_tag;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public GameObject Findclosest(){
        GameObject[] enemy=GameObject.FindGameObjectsWithTag(target_tag);
        GameObject Closest_enemy = null;
        float Closest_distance = float.MaxValue;
        foreach (var item in enemy)
        {
            float Distance = Vector3.Distance(item.transform.position, transform.position);
            if( Distance < Closest_distance){
                Closest_distance = Distance;
                Closest_enemy = item;
            }
        }
        return Closest_enemy;
    }
}

