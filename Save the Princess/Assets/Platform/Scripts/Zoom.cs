using UnityEngine;
using System.Collections;

public class Zoom : MonoBehaviour {

	public float zoomSpeed = 0.05f;
	private float minSize = 6.0f;
	private float maxSize = 20.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount == 2) {
			// If using two fingers and pulling towards or away on a mobile device it will activate a camera zooming feature
			Touch touchZero = Input.GetTouch(0);
			Touch touchOne = Input.GetTouch(1);
			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;
			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;
			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;
			Camera.main.orthographicSize += deltaMagnitudeDiff * zoomSpeed;            
			Camera.main.orthographicSize = Mathf.Clamp(GetComponent<Camera>().orthographicSize, minSize, maxSize);
		}

	}
}
