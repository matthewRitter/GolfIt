using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform PlayerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    public bool RotateAroundPlayer = true;

    public float RotationsSpeed = 2f;

	// Use this for initialization
	void Start () {
        _cameraOffset = transform.position - PlayerTransform.position;	
	}
	
	// LateUpdate is called after Update methods
	void LateUpdate () {

        if(RotateAroundPlayer)
        {
            Quaternion camTurnAngle =
                Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationsSpeed, Vector3.up);


            _cameraOffset = camTurnAngle * _cameraOffset;

            camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * RotationsSpeed, Vector3.right);
            //print(camTurnAngle + " is the cam turn angle");
            //print("cam turn angle: " + camTurnAngle);
            Vector3 temp = _cameraOffset;
            temp = camTurnAngle * _cameraOffset;

            if ((temp.y < 2) && (temp.y > -2)){
                _cameraOffset = camTurnAngle * _cameraOffset;
            }
            /*
            if (((camTurnAngle.y * _cameraOffset.y) < 6) && ((_cameraOffset.y * camTurnAngle.y) > -6))
            {
                print("The cameraOffset Y is: " + camTurnAngle.y * _cameraOffset.y);
                //print("it goes into this");
                _cameraOffset = camTurnAngle * _cameraOffset;
            }
            */

            //print("The camera offset is: " + _cameraOffset.y);

        }

        Vector3 newPos = PlayerTransform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtPlayer || RotateAroundPlayer)
            transform.LookAt(PlayerTransform);
	}
}
