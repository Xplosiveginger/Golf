using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnchor : MonoBehaviour
{
    [SerializeField] private Transform golfBall;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(golfBall.position.x, golfBall.position.y - 0.25f, golfBall.position.z);
    }
}
