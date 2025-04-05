using UnityEngine;

public class Ambiance : MonoBehaviour
{
   private AudioSource ambiance;
    void Start()
    {
        ambiance = GetComponent<AudioSource>();
        ambiance.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
