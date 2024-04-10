using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {


    public GameObject core;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float spawnPoint = gameObject.GetComponent<Renderer>().bounds.size.z;
            Vector3 ForwardObj = transform.position + transform.TransformDirection(Vector3.forward * spawnPoint * 2f);
            GameObject newBullet = Instantiate(core, ForwardObj, transform.rotation);
            newBullet.transform.Rotate(new Vector3(90, 0, 0));
            gameObject.GetComponent<AudioSource>().PlayOneShot(gameObject.GetComponent<AudioSource>().clip);
        }
    }
}
