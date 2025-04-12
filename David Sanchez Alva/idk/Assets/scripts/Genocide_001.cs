using System.Collections;
using UnityEngine;

public class Genocide_001 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      StartCoroutine(SelfDestruct());  
    }

    // Update is called once per frame
    IEnumerator SelfDestuct(){
        yield return new WaitForSeconds(1);
        Destroy(GameObject);
} 
    }
    
