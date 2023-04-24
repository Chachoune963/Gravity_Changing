using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityChangerScript : MonoBehaviour
{
    public Transform playerTransform;
    public Transform aimPoint;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Test(aimPoint.position);
        }
    }

    void Test(Vector3 position)
    {
        var ray = position - playerTransform.position;
        var angle = Vector3.Angle(ray, Vector3.down);
        Debug.Log(angle);
        transform.RotateAround(playerTransform.position, playerTransform.right, angle);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(playerTransform.position, aimPoint.position);
        Gizmos.DrawLine(playerTransform.position, Vector3.down);
    }
}
