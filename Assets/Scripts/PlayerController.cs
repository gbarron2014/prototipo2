using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horInput;
    public float speed = 30.0f;
    private float rango = 15;
    public GameObject proyectil;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -rango) {
            transform.position = new Vector3(-rango, transform.position.y, transform.position.z);
        }

        if (transform.position.x > rango) {
            transform.position = new Vector3(rango, transform.position.y, transform.position.z);
        }
        horInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime*speed*horInput);

        if (Input.GetKeyDown(KeyCode.Space)) {
            //Debug.Log("Presiono Barra espaciadora");
            Instantiate(proyectil, transform.position, proyectil.transform.rotation);
        }
    }
}
