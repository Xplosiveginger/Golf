using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnchor : MonoBehaviour
{
    [SerializeField] private Transform golfBall;
    [SerializeField] private Quaternion currentRotation;
    [Range(1f, 10f)]
    [SerializeField] private float sens = 1f;
    [Range(6.1f, 30f)]
    [SerializeField] private float zoomAmount = 6.13f;

    private float sensitivity;
    private float hRotation;
    private float vRotation;

    void Update()
    {
        sensitivity = sens / 10f;

        hRotation = Input.mousePosition.x;
        vRotation = Input.mousePosition.y;

        transform.position = new Vector3(golfBall.position.x, golfBall.position.y - 0.25f, golfBall.position.z);

        currentRotation.eulerAngles = new Vector3(transform.rotation.x, 
                                                    transform.rotation.y + hRotation * sensitivity,
                                                    transform.rotation.z + vRotation * -1 * sensitivity);

        if(!golfBall.GetComponent<BallController>().isShootingMode)
        {
            transform.localRotation.eulerAngles = new Vector3(currentRotation.x, currentRotation.y, Mathf.Clamp(currentRotation.z, 30f, 130f));
            transform.eulerAngles.z = Mathf.Clamp(currentRotation.z, 30f, 130f);
        }
    }
}
