using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_tank : MonoBehaviour
{

    AudioSource zvtank;
    bool isPlaying = false;

    float get_x;
    float get_z;

    float mouse_x;
    float mouse_y;

    float Barrel_rotation_x;

    GameObject tower = new GameObject();
    GameObject barrel = new GameObject();

    // Use this for initialization
    void Start()
    {
        tower = GameObject.Find("башня");
        barrel = GameObject.Find("ствол");

        zvtank = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        get_z = Input.GetAxis("Vertical");

        transform.Translate(0, 0, get_z/16);

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -0.5f, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0.5f, 0);
        }
        
        mouse_y = Input.GetAxis("Mouse X");

        tower.transform.Rotate(0, mouse_y, 0);

        mouse_x = Input.GetAxis("Mouse Y");

        Barrel_rotation_x += -mouse_x;

        Barrel_rotation_x = Mathf.Clamp(Barrel_rotation_x, -20f, 5f);
        
        barrel.transform.rotation = Quaternion.Euler(Barrel_rotation_x, barrel.transform.rotation.eulerAngles.y, barrel.transform.rotation.eulerAngles.z);

        //Debug.Log(barrel.transform.rotation.x);

        if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) && !isPlaying)
        { zvtank.Play(); isPlaying = true; }


        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0 && isPlaying)
        { zvtank.Stop(); isPlaying = false; }


    }
}
