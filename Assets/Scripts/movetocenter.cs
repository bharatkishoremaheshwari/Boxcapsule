using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetocenter : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 targetPosition;
    public float speed = 10;
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
