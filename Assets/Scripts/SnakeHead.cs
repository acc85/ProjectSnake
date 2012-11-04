using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SnakeHead : MonoBehaviour {
	
	List<Vector3> targets;
	Vector3 currentTarget;
	int currentIndex;
	
	Vector3 currentPosition;
	
	float speed = 3.0f;
	
	
	// Use this for initialization
	void Start () {
			
		currentPosition = transform.position;
		
		targets = new List<Vector3>();
		targets.Add(new Vector3(currentPosition.x + 8.0f, currentPosition.y + 8.0f, currentPosition.z));
		targets.Add(new Vector3(currentPosition.x - 8.0f, currentPosition.y + 8.0f, currentPosition.z));
		targets.Add(new Vector3(currentPosition.x + 8.0f, currentPosition.y - 8.0f, currentPosition.z));
		targets.Add(new Vector3(currentPosition.x - 8.0f, currentPosition.y - 8.0f, currentPosition.z));
		
		currentIndex = 0;
		currentTarget = targets[currentIndex];
	
	}
	
	// Update is called once per frame
	void Update () {
		currentPosition = transform.position;

		if (Vector3.Distance(currentPosition, currentTarget) > 1) {
			
			Vector2 directionVector = new Vector2(currentTarget.x - currentPosition.x, currentTarget.y - currentPosition.y);
			
			float x = currentPosition.x + (directionVector.x * speed * Time.deltaTime);
			float y = currentPosition.y + (directionVector.y * speed * Time.deltaTime);
			
			Vector3 newPosition = new Vector3(x, y, currentPosition.z);
			
			transform.position = newPosition;

        } else {

			if (currentIndex == (targets.Count - 1)) {
				currentIndex = 0;
			} else {
				currentIndex++;
			}
			
			currentTarget = targets[currentIndex];	
		}
		
	}
}
