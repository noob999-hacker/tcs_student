using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField]private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 camera_pos = transform.position;
       Vector3 target_pos = target.transform.position;
        camera_pos.x = target_pos.x;
        camera_pos.y = target_pos.y;
        transform.position= camera_pos;
    }
}
