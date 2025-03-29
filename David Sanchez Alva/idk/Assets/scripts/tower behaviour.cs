using System.Globalization;
using System.Collections;
using UnityEngine;

public class towerbehaviour : Generic_Tower
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
           var target = Findclosest(); 
           if (target!=null){
            var b= Instantiate(bullet,transform.position, transform.rotation);
            b.GetComponent < bulletbehavior >().settarget(target);
           }
            yield return new WaitForSeconds(0.5f);
        }
    }
}
