using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {

    public float rotspeed;

    // Update is called once per frame
    void Update()
    {
        Vector3 rotate = transform.localEulerAngles;
        rotate.x += Input.GetAxis("Camara Y") * rotspeed * Time.deltaTime;
        if (rotate.x>30 &&rotate.x<40) {
            rotate.x = Mathf.Clamp(rotate.x, 0f, 30f);
        }  
        if(rotate.x<=330 && rotate.x>300)
        {
            rotate.x = Mathf.Clamp(rotate.x, 330f, 360f);
        }
        transform.localEulerAngles = rotate;
    }
}
