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

    void Findclosest(){
        GameObject[] enemy=GameObject.FindGameObjectsWithTag(target_tag);
        GameObject Closest_enemy = null;
        float Closest_distance = Math.f;
    }
}
