using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] private Camera camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Graze();
    }

    void Graze()
    {
        Debug.DrawRay(camera.transform.position, camera.transform.up * 5, Color.blue);
        RaycastHit2D hit = Physics2D.Raycast(camera.transform.position, camera.transform.up, 5);
        if (hit.collider)
        {
            Debug.Log(hit.collider.name);
        }
    }

}
