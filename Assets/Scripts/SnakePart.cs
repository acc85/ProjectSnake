using UnityEngine;
using System.Collections;

public class SnakePart : MonoBehaviour {
	
	public GameObject objectToFollow;
	
	Vector3 currentTarget;
	
	float speed = 5.0f;
	
	
	// Use this for initialization
	void Start () {
		currentTarget = objectToFollow.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
		currentTarget = objectToFollow.transform.position;
	
		if (Vector3.Distance(currentPosition, currentTarget) > 1) {
			
			Vector2 directionVector = new Vector2(currentTarget.x - currentPosition.x, currentTarget.y - currentPosition.y);
			
			float x = currentPosition.x + (directionVector.x * speed * Time.deltaTime);
			float y = currentPosition.y + (directionVector.y * speed * Time.deltaTime);
			
			Vector3 newPosition = new Vector3(x, y, currentPosition.z);
			
			transform.position = newPosition;	
		}
		
	}
}
