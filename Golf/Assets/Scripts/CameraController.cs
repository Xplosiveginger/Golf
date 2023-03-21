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

    private Vector3 targetPosition;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        zoomAmount = Mathf.Clamp(zoomAmount + (Input.mouseScrollDelta.y * -1f), 3f, 10f);

        targetPosition = new Vector3(cameraAnchor.position.x + 3f, cameraAnchor.position.y + 3f, cameraAnchor.position.z);

        transform.position = Vector3.Lerp(transform.position, targetPosition, smoothFactor);
    }
}
