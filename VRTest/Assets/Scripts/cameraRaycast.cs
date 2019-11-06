using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraRaycast : MonoBehaviour
{
    private RaycastHit hit;
    public Slider loading;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 20, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20) && hit.transform.gameObject.tag == "Wall")
        {
            loading.value++;
        }
        else
        {
            loading.value = 0;
        }
        if (loading.value == 300)
        {
            canvas.SetActive(true);
        }
    }
}
