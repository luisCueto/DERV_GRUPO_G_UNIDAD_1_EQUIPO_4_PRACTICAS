using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{ 

    public float angulo = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.G))
        {
            Quaternion origen = transform.rotation;
            Quaternion destino = Quaternion.Euler(new Vector3(0, angulo, 0));

            transform.transform.rotation = Quaternion.Slerp(origen, destino, 0.1f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.F))
        {
            Quaternion origen = transform.rotation;
            Quaternion destino = Quaternion.Euler(new Vector3(0, -angulo, -1f));

            transform.transform.rotation = Quaternion.Slerp(origen, destino, 0.1f * Time.deltaTime);
        }
    }
}
