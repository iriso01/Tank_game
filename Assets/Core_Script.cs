using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core_Script : MonoBehaviour {

    float speed_bullet = 0.3f;

    public GameObject explosion;

    // Use this for initialization
    void Start () {
        Destroy(gameObject, 5f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.position += transform.TransformDirection(Vector3.forward * speed_bullet);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "goal")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            Instantiate(explosion, other.transform.position, Quaternion.identity);
            other.gameObject.GetComponent<AudioSource>().PlayOneShot(other.gameObject.GetComponent<AudioSource>().clip);
        }
    }

}
