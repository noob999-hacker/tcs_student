using System.Globalization;
using System.Collections;
using UnityEngine;

public class towerbehaviour : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(Shoot());
    }
        [SerializeField]
        private GameObject bullet;

    void Update()
    {
        
    }

    private IEnumerator Shoot(){
        while(true){
            Instantiate(bullet,transform.position, transform.rotation);   
            yield return new WaitForSeconds(0.5f);
        }
    }
}
