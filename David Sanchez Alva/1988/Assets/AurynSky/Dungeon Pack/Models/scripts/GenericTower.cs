using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

public class GenericEnemy : MonoBehaviour
{

    [SerializeField] private float maxRange;
    [SerializeField] private GameObject projectile;
    [SerializeField] private float shootSpeed = 1f;
    [SerializeField] private Transform firepoint;
    private GameObject target = null;

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
        StartCoroutine(shootCoroutine());
    }



    // Update is called once per frame
    void Update()
    {
        findClosest();
        transform.LookAt(target.transform.position);
    }

    private void findClosest()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, maxRange);
        float closestDistance = Mathf.Infinity;
        target = null;
        foreach (var collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                float distance = Vector3.Distance(transform.position, collider.gameObject.transform.position);
                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    target = collider.gameObject;
                }
            }
        }
        Debug.Log("closest enemy is" + target.gameObject.name + "" + closestDistance);
    }

    private void shoot(GameObject target)
    {
        GameObject bullet = Instantiate(target, firepoint.position, transform.rotation);
        
    }
}

