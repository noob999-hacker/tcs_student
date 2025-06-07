using UnityEngine;

public class ray : MonoBehaviour


{
    [SerializeField] private Camera playerCam;
    [SerializeField] private float maxDistance = 50f;
    [SerializeField] private GameObject[] tower;

    public LineRenderer lineRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = playerCam.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
        RaycastHit hit;
        Vector3 start = ray.origin;
        Vector3 end = ray.origin + ray.direction * maxDistance;
        lineRenderer.SetPosition(0, start);
        lineRenderer.SetPosition(1, end);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit, maxDistance))
            {
                Quaternion rotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
                if (!(hit.collider.gameObject.tag == "tower"))
                {
                    Instantiate(tower[0], hit.point, rotation);
                }
                else
                {
                    Debug.Log("tryimg to add a tower on a tower: Adding tower cancelled");
                 }

             }



         }




    }
}
