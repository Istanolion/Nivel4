using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prueba : MonoBehaviour {
    public float speed;
    public float rotspeed;
	
	// Update is called once per frame
	void Update () {
        float translationx = Input.GetAxis("Horizontal") * speed*Time.deltaTime;
        transform.Translate(0, 0, translationx);
        float translationy = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.Translate(translationy,0, 0);
        Vector3 rotate = transform.localEulerAngles;
        rotate.y += Input.GetAxis("Camara X") * rotspeed * Time.deltaTime;
        transform.localEulerAngles = rotate;
    }
}
