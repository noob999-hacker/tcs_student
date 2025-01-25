 using UnityEngine;
 using TMPro;

public class blackj_market : MonoBehaviour
{
    public int unpaid_taxes;
    [SerializeField]
    private TextMeshProUGUI uiText;
    [SerializeField]
    private GameObject[] towers; 


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiText.text = "unpaid taxes:" + unpaid_taxes;
    }

    // Update is called once per frame
    void Update() 
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (unpaid_taxes >= 150)
            {
                AddTower("skull tower");
                unpaid_taxes -= 150;
            }
        }
        uiText.text = "unpaid taxes:" + unpaid_taxes;

    }

    void AddTower(string type)
    {
        if(type == "skull tower")
        {
            Vector3 mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouse_pos.z = 0;
            Instantiate(towers[0], mouse_pos, Quaternion.identity);
        }
    }
}
