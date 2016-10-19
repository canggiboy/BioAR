using UnityEngine;
using System.Collections;

public class joystickController : MonoBehaviour {

	private const float Y_ANGLE_MIN = 0.0f;
	private const float Y_ANGLE_MAX = 180.0f;

	public virtualJoystick joyStick{ set; get;}

	private Transform thisTransform;
	private Camera cam;
	public Transform CamTransform{ set; get;}

	private float distance = 10.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensivityX = 4.0f;
	private float sensivityY = 1.0f;

	private void Start(){
		CamTransform = new GameObject ("Camera Container").transform;
		cam = CamTransform.gameObject.AddComponent<Camera> ();
		cam.tag = "MainCamera";

		thisTransform = transform;
	}

	private void Update(){
		currentX += joyStick.Horizontal () * sensivityX;
		currentY += joyStick.Vertical () * sensivityY;

		currentY = ClampAngle (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);
	}

	private void LateUpdate(){
		Vector3 dir = new Vector3 (0, 0, -distance);
		Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
		CamTransform.position = thisTransform.position + rotation * dir;
		CamTransform.LookAt (thisTransform.position);
	}

	private float ClampAngle(float angle,float min,float max)
	{
		do {
			if (angle < -360)
				angle += 360;
			if (angle > 360)
				angle -= 360;
		} while(angle < -360 || angle > 360);

		return Mathf.Clamp (angle, min, max);
	}
}
