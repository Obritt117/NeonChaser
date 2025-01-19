using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado_rotate : MonoBehaviour
{
    [SerializeField] private int speed;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0,0,speed);
    }
}
