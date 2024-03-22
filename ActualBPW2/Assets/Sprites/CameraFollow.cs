using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float FollowSpeed = 2f;
    public Transform target;
    public Vector3 offset;


    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x + offset.x, target.position.y + offset.y,-10f + offset.z);
        transform.position = Vector3.Slerp(transform.position,newPos,FollowSpeed*Time.deltaTime);
    }

} 