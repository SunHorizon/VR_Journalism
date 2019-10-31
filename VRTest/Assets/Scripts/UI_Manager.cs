using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;

    //[SerializeField]private Camera camera;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ray = Camera.main.ViewportPointToRay(new Vector2(Screen.height / 2, Screen.width / 2));
    
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("testing");
            Debug.Log(hit.collider.name);
        }

        Debug.DrawRay(ray.origin, ray.direction, Color.red);
    }

    
}
