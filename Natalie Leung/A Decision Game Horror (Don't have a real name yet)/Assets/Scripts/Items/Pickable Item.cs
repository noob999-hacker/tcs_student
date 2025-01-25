using UnityEngine;
 
public class Item_Behavior : MonoBehaviour
{
    [SerializeField] Item item;
 
    private void Start(){
        GetComponent<SpriteRenderer>().sprite = item.itemIcon;
    }
 
    private void OnCollisionEnter2D(Collision2D other){
        if (other.gameObject.tag=="Player"){
            PlayerInvetory inv = other.gameObject.GetComponent<PlayerInvetory>(); 
            inv.Add_Item(item);
            Destroy(gameObject);
        }
  
    }
}