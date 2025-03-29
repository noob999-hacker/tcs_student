 using UnityEngine;
 using TMPro;

public class blackj_market : MonoBehaviour
{
    public int unpaid_taxes;
    [SerializeField]
    private TextMeshProUGUI uiText;
    [SerializeField]
    private GameObject[] towers; 
    private int selection = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiText.text = "unpaid taxes:" + unpaid_taxes;
    }

    // Update is called once per frame
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            selection = 1;
        }
        if(Input.GetKeyDown(KeyCode.Alpha2)){
            selection = 2;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (unpaid_taxes >= 150)
            {
                switch(selection){
                    case 1:
                        AddTower("skull tower");
                        unpaid_taxes -= 150;
                        break;
                    case 2:
                        AddTower("Blood moon tower");
                        unpaid_taxes -= 200;
                        break;
                }
            }
        }
        uiText.text = "unpaid taxes:" + unpaid_taxes;

    }

    void AddTower(string type)
    {
        Vector3 mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse_pos.z = 0;
        switch(type){
            case "skull tower":
                Instantiate(towers[0], mouse_pos, Quaternion.identity);
                break;
            case "Blood moon tower":
                Instantiate(towers[1], mouse_pos, Quaternion.identity);
                break;
        }
    }
}
