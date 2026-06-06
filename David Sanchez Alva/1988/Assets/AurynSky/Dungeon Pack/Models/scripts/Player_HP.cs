using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor;
using Unity.VisualScripting;
public class Player_HP : MonoBehaviour

{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private int playing_hp;
    [SerializeField] private int max_hp;
    [SerializeField] private List<Sprite> barhp;
    [SerializeField] private Image heals;

        void Start()
    {
        playing_hp = max_hp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Health(int damage)
    {
        playing_hp -= damage;
        Debug.Log($"player hp = {playing_hp}");
        changeHPbar();
      if (playing_hp <= 0)
      Debug.Log ("Player died");
        {
            //Destroy(gameObject);
        } 
    }
    
    private void changeHPbar()
    {
        float hp_percent = (float)playing_hp / max_hp;
        int index = barhp.Count - Mathf.RoundToInt(hp_percent * barhp.Count);
        index = Mathf.Clamp(index, 0, barhp.Count -1);
        Debug.Log (index);
        heals.sprite = barhp[index];
    }
}
