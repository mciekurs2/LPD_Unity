using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{


    public Interactable focus;

    public LayerMask movementMask;

    new Camera camera;
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

                RemoveFocus();

            }

        }

        if (Input.GetMouseButtonDown(1)) //1 - right mouse button
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                //parbauda, vai patiesham atrast interactable
                if (interactable != null)
                {
                    //uzstāda kaa focus objektu
                    SetFocus(interactable);

                }

                //Debug.Log("We hit " + hit.collider.name + " " + hit.point);
                //motor.MoveToPoint(hit.point);

            }

        }

    }

    void SetFocus(Interactable newFocus)
    {
        //deFocused ja jau eksistee iepriekshejais
        if (newFocus != focus)
        {
            if (focus != null)
            {
               focus.OnDefocused();
            }
            focus = newFocus;
            motor.FollowTarget(newFocus);
        }

        newFocus.OnFocused(transform);
    }

    void RemoveFocus()
    {
        if (focus != null)
        {
            focus.OnDefocused();
        }

        focus = null;
        motor.StopFollowingTarget();
    }

}
