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
        firecooldown -= Time.deltaTime;
        if (firecooldown < 0)
        {
            Debug.Log("guh");
            firecooldown = 1f / firerate;
        }
    }

    void FindEnemy()
    {
        float nearest = maxrangeRaidius * 2;
        target = null;
        Collider[] hit = Physics.OverlapSphere(transform.position, maxrangeRaidius);
        foreach (var hitcollider in hit)
        {
            float distance = Vector3.Distance(transform.position, hitcollider.transform.position);
            if (nearest < distance)
            {
                nearest = distance;
                target = hitcollider.transform;
            }
        }
    }
}
