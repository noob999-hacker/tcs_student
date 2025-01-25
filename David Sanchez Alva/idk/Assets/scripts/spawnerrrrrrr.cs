using UnityEngine;
using System.Collections;

public class spawnerrrrrrr : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    
    void Start()
    {
        StartCoroutine(spawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator spawn(){
        while(true){
            Instantiate(enemy,transform.position, transform.rotation);   
            yield return new WaitForSeconds(5);
        }
    }
}
