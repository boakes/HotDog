using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogSpin : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left, speed * Time.deltaTime);
    }
}
