using Unity.VisualScripting;
using UnityEngine;

public class ATK_Script : MonoBehaviour

{
    public Transform player;
    [SerializeField] private float ATK_Range;
    [SerializeField] private Animator animator;
    public GameObject trigger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = playermovement.Instance.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) < ATK_Range)
        {
            animator.SetTrigger("ATK_trigger");
        }
    }
    public void Activation()
    {
        trigger.SetActive(true);
    }
    public void Deactivation()
    {
        trigger.SetActive(false);
    }
}
