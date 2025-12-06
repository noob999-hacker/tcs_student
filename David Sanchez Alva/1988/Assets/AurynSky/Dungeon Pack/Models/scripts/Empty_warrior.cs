using UnityEngine;
using UnityEngine.AI;

public class Empty_warrior : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }
}
