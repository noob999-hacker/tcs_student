using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEditor;
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
        int index = barhp.Count - Mathf.RoundToInt(playing_hp * barhp.Count);
        
        Debug.Log (index);
        heals.sprite = barhp[index];
    }
}
