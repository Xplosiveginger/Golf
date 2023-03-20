using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    [SerializeField] Transform cameraAnchor;

    [Range (3, 10)]
    [SerializeField] private float zoomAmount = 3f;
    [Range(3, 10)]
    [SerializeField] private float smoothFactor = 10f;

    //private Transform camPos;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        //transform.parent = golfBall.transform;
        //camPos = transform;
    }

    // Update is called once per frame
    void Update()
    {
        zoomAmount = Mathf.Clamp(zoomAmount + (Input.mouseScrollDelta.y * -1f), 3f, 10f);

        targetPosition = new Vector3(cameraAnchor.position.x + 3f, cameraAnchor.position.y + 3f, cameraAnchor.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothFactor);

        //camPos.position = new Vector3(golfBall.transform.position.x + zoomAmount, golfBall.transform.position.y + 1f, golfBall.transform.position.z);
        //transform.rotation = Quaternion.Euler(0f, -90f, 0f);
    }
}
