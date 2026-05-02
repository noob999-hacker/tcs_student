using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.Rendering;

public class GenericEnemy : MonoBehaviour
{

    [SerializeField] private float maxRange;
    [SerializeField] private GameObject projectile;
    [SerializeField] private float shootSpeed = 1f;
    [SerializeField] private Transform firepoint;
    private GameObject target = null;
    [SerializeField] bool is_enemy;
    private string target_tag;

    IEnumerator shootCoroutine()
    {
        while (true){
            if (target != null)
            {
                shoot(projectile);
            }
            yield return new WaitForSeconds(shootSpeed);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (is_enemy)
        {
            target_tag = "Player";

        }
        else
        {
            target_tag = "Enemy";
        }
            
        
        StartCoroutine(shootCoroutine());
    }



    // Update is called once per frame
    void Update()
    {
        findClosest();
         if (target != null)
        {
            transform.LookAt(target.transform.position);
        }
        
    }

    private void findClosest()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, maxRange);
        float closestDistance = Mathf.Infinity;
        target = null;
        foreach (var collider in colliders)
        {
            if (collider.CompareTag(target_tag))
            {
                float distance = Vector3.Distance(transform.position, collider.gameObject.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    target = collider.gameObject;
                }
            }
        }
        //Debug.Log("closest enemy is" + target.gameObject.name + "" + closestDistance);
    }

    private void shoot(GameObject projectile)
    {
        GameObject bullet = Instantiate(projectile, firepoint.position, Quaternion.identity);
        Vector3 shootdirection = target.transform.position - transform.position;
        bullet.GetComponent<GenericBullet>().Shoot(shootdirection);
        Debug.Log ("enemy shot");
    }
}

