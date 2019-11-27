using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotate : MonoBehaviour
{
    public bool UseMouse;
    public int speed;
    public float horizontal;
    private float yaw = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (UseMouse)
        {
            yaw += horizontal + Input.GetAxis("Mouse X");
            transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        }
    }
}
