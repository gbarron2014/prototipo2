using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[ ] animalPrefabs; 
    private int animalIndex;
    private float posX = 15;
    private float posZ = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            Vector3 pos = new Vector3(Random.Range(-posX, posX), 0, Random.Range(-posZ, posZ));
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], pos, animalPrefabs[animalIndex].transform.rotation);
        }
    }
}
