using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraRaycast : MonoBehaviour
{
    private RaycastHit hit;
    public Slider loading;
    public GameObject canvas;
    private bool active;
    private int timer;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 20, Color.red);
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 20) && hit.transform.gameObject.tag == "Wall")
        {
            loading.value++;
            //if (active == true) { timer = 0; }
        }
        else
        {
            //if (active == false)
            //{
                loading.value = 0;
                canvas.SetActive(false);
            //}
            //if (timer >= 100) { active = false; timer = 0; }
            //if (active == true) { timer++; loading.value--; }

        }
        if (loading.value == 100)
        {
            canvas.SetActive(true);
            active = true;
        }
    }
}
