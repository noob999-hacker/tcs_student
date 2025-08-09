using System;
using UnityEngine;
using UnityEngine.Rendering;

public class GenericEnemy : MonoBehaviour
{

    [SerializeField] private float maxRange;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
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
        Instantiate(target, transform.position, transform.rotation);
    }
}

