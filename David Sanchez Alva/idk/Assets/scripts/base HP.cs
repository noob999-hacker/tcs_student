using UnityEngine;

public class baseHP : MonoBehaviour
{
    private int health=100;

    public void TakeDamage(int damage){
        health -= 10;
        Debug.Log("base took" + damage + ":current HP is " + health);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
