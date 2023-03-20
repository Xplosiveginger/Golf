using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] GameObject golfBall;
    private Transform camPos;

    [Range (2, 10)]
    [SerializeField] private float zoomAmount = 2f;

    // Start is called before the first frame update
    void Start()
    {
        transform.parent = golfBall.transform;
        camPos = transform;
    }

    // Update is called once per frame
    void Update()
    {


        camPos.position = new Vector3(golfBall.transform.position.x + 3, golfBall.transform.position.y + 1f, golfBall.transform.position.z);
        transform.rotation = Quaternion.Euler(0f, -90f, 0f);
    }
}
