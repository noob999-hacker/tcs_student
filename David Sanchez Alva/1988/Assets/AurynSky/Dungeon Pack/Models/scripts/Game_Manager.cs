using TMPro;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public int enemy_kill;
    public TextMeshProUGUI kill_count;
    public int money;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        money = 100;
    }

    // Update is called once per frame
    void Update()
    {
        kill_count.text = enemy_kill.ToString();
    }
}
