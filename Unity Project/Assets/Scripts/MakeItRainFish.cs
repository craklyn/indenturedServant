using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NewtonVR;
using UnityEngine;


public class MakeItRainFish : MonoBehaviour
{
    public GameObject[] FishPrefab;
    public float timeBetweenSpawn;

    private float spawnTimer;


    // Use this for initialization
    void Start() {}

    // Update is called once per frame
    void Update()
    {
        //	Rigidbody rb = RocketInstance.GetComponent<Rigidbody>();
        //	rb.velocity = new Vector3(0,-10,0);
        // Debug.Log("Make it Rain Script");

        if (spawnTimer > 0)
        {
            spawnTimer -= Time.deltaTime;
            return;
        }

        spawnTimer = timeBetweenSpawn;

        int randomGen = Random.Range(0, FishPrefab.Length);
        GameObject fish = GameObject.Instantiate(FishPrefab[randomGen], transform.position, transform.rotation);
       

       
    }
}