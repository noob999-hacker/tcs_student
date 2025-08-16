using System;
using UnityEngine;
using UnityEngine.Rendering;

public class GenericEnemy : MonoBehaviour
{

    [SerializeField] private float maxRange;
    [SerializeField] private GameObject projectile;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GameObject target = findClosest();
        if (target != null)
        {
            shoot(projectile);
        }
    }

    private GameObject findClosest()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, maxRange);
        float closestDistance = Mathf.Infinity;
        GameObject target = null;
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
        return target;
    }

    private void shoot(GameObject target)
    {
        GameObject bullet = Instantiate(target, transform.position, transform.rotation);
        
    }
}

