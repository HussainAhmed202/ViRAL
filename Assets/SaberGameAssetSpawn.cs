using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaberGameAssetSpawn : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = (60/130)* 5;  // spawn rate the number defines the speed of spawning
    private float timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        if (timer > beat)
        {
            GameObject cube = Instantiate(cubes[Random.Range(0, 2)], points[Random.Range(0, 2)]);
            cube.transform.localPosition = Vector3.zero;
            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 2));
            timer -= beat;
        }



        timer += Time.deltaTime;

    }
}
