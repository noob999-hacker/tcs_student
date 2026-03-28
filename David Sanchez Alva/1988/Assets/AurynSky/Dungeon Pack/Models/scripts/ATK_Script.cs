using UnityEngine;

public class ATK_Script : MonoBehaviour

{
    public Transform player;
    [SerializeField] private float ATK_Range;
    [SerializeField] private Animator animator;
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
}
