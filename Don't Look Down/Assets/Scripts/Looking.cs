using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    public Transform Player;

    float lookSensitivity = 500f;

    float updownLookRotation = 0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // looking on x axis
        float mouseX = Input.GetAxis("Mouse X") * lookSensitivity * Time.deltaTime;
        Player.Rotate(Vector3.up * mouseX);


        // looking oin y axis
        float mouseY = Input.GetAxis("Mouse Y") * lookSensitivity * Time.deltaTime;
        updownLookRotation -= mouseY;
        updownLookRotation = Mathf.Clamp(updownLookRotation, -4f, 20f);// restriction look angle
        transform.localRotation = Quaternion.Euler(updownLookRotation, 0f, 0f);

    }



}
