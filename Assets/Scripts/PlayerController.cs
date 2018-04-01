using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour {

    public LayerMask movementMask;
    Camera camera;
    PlayerMotor motor;
   

	// Use this for initialization
	void Start () {
        camera = Camera.main;
        motor = GetComponent<PlayerMotor>();

   
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) { // 0 - left mouse button
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask)) {

                //Debug.Log("We hit " + hit.collider.name + " " + hit.point);
                motor.MoveToPoint(hit.point);

            }

        }

        if (Input.GetMouseButtonDown(1)) //1 - right mouse button
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100, movementMask))
            {

                //Debug.Log("We hit " + hit.collider.name + " " + hit.point);
                //motor.MoveToPoint(hit.point);

            }

        }

    }
}
