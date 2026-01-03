using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class Empty_warrior : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] GameObject target;
    [SerializeField] private int health;
    [SerializeField] private List<Sprite> Hpbars;
    [SerializeField] private Image HP_UI;
    private int index;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        index = 0;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);
    }

    public void Damage(int damage)
    {
        health -= damage;
        Debug.Log($"{health}");
        minusHPbar();
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void minusHPbar()
    {
        index +=1;
        if(index < Hpbars.Count)
        {
             HP_UI.sprite = Hpbars[index];
        }   
       
        
    }
}
