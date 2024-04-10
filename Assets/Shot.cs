using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Shot : MonoBehaviour
{
    public float pushForce = 10f;
    private Camera cam1;

    // Use this for initialization
    void Start () {
        cam1 = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(cam1.pixelWidth / 2, cam1.pixelHeight / 2 + 60, 0);
            Ray ray = cam1.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {

                string hitObject = hit.collider.gameObject.name;

                GameObject TargetObject = hit.collider.gameObject;
                Debug.Log(hitObject);

                Rigidbody hitRigidbody = TargetObject.GetComponent<Rigidbody>();

                if (hitObject == "t1")
                {
                    Vector3 pushDirection = TargetObject.transform.position - transform.position;
                    hitRigidbody.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
                }
                if (hitObject == "t2")
                {
                    Vector3 pushDirection = TargetObject.transform.position - transform.position;
                    hitRigidbody.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
                }
                if (hitObject == "t3")
                {
                    Vector3 pushDirection = TargetObject.transform.position - transform.position;
                    hitRigidbody.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
                }

            }
        }
    }
}
