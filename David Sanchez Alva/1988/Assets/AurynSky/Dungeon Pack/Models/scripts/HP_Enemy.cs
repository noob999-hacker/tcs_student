using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class HP_Enemy : MonoBehaviour
{
    private Image Hp_image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Hp_image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
