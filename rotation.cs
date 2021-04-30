using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float angle=10;
    public float speed;
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        speed+=Time.deltaTime*angle;
        transform.rotation=Quaternion.Euler(speed,0,0);
    }
}
