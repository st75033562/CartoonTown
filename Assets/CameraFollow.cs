using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform follow;        //the position of Player

    private float distanceAway = 15.0f;
    private float distanceUp = 5.0f;
    private float smooth = 2f;               // how smooth the camera movement is

    private Vector3 m_TargetPosition;       // the position the camera is trying to be in)

    void Start()
    {
        transform.LookAt(follow);
    }

    void LateUpdate()
    {
        m_TargetPosition = follow.position + Vector3.up * distanceUp + Vector3.forward * distanceAway;

        transform.position = Vector3.Lerp(transform.position, m_TargetPosition, Time.deltaTime * smooth);
        
    }
}
