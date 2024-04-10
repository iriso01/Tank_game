using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb_Down : MonoBehaviour {


    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public GameObject prefab;


    // Use this for initialization
    void Start()
    {

        MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
         minX = renderer.bounds.min.x;
         maxX = renderer.bounds.max.x;
         minZ = renderer.bounds.min.z;
         maxZ = renderer.bounds.max.z;

    }

    // Update is called once per frame
    void Update()
    {
/*        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefab, new Vector3(25 + Random.Range(minX, maxX), 20,25 + Random.Range(minZ, maxZ)), Quaternion.identity);

        }*/
    }
}
