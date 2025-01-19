using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tornado_movement : MonoBehaviour
{
    public GameObject pointA, pointB, pointC, nextPosition;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = pointA.transform.position;
        nextPosition.transform.position = pointB.transform.position;
        Move();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (this.transform.position == pointA.transform.position)
        {
            nextPosition.transform.position = pointB.transform.position;
        }
        if (this.transform.position == pointB.transform.position)
        {
            nextPosition.transform.position = pointC.transform.position;
        }
        if (this.transform.position == pointC.transform.position)
        {
            nextPosition.transform.position = pointA.transform.position;
        }
        Move();
    }
    void Move()
    {
        this.transform.position = Vector3.MoveTowards(this.transform.position, nextPosition.transform.position, speed/25f);
    }
}
