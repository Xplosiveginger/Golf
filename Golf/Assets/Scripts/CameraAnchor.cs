using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnchor : MonoBehaviour
{
    [SerializeField] private Transform golfBall;

    // Update is called once per frame
    void Update()
    {
        transform.position = golfBall.position;
    }
}
