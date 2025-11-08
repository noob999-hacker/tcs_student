using System;
using Mono.Cecil;
using UnityEditor;
using UnityEngine;

public class towercode2 : MonoBehaviour
{
    [SerializeField] private float maxrangeRaidius = 10f;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float firerate = 1f;
    private Transform target;
    private float firecooldown = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(firecooldown);
        FindEnemy();
        if (target != null)
        {
            Quaternion targetrotation = Quaternion.LookRotation(target.position - transform.position, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetrotation, 1f * Time.deltaTime);


            if (firecooldown < 0)
            {
                
                //Debug.Log("guh");
                firecooldown = 1f / firerate;
            }
        }
        firecooldown -= Time.deltaTime;
    }

    void FindEnemy()
    {
        float nearest = maxrangeRaidius * 5;
        target = null;
        Collider[] hit = Physics.OverlapSphere(transform.position, maxrangeRaidius);
        foreach (var hitcollider in hit)
        {
            float distance = Vector3.Distance(transform.position, hitcollider.transform.position);
            //Debug.Log("Distance " + distance);
            //Debug.Log("Nearest " + nearest);
            if (distance < nearest) {
                if (hitcollider.CompareTag("Enemy"))
                {
                    Debug.Log(hitcollider.name);
                    nearest = distance;
                    target = hitcollider.transform;
                    
                }
            }
        }
    }
}
