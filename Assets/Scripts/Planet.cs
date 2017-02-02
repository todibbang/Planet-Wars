using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

	public float Radius;
	public float DistanceFromSun;
	public float YearDuration;
	public GameObject Sun;
	float angle = 0f;

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector2 (Radius, Radius);

	}

	// Update is called once per frame
	void Update () {
		
		float x = Sun.transform.position.x + DistanceFromSun * Mathf.Cos(Mathf.Deg2Rad*angle);
		float y = Sun.transform.position.y + DistanceFromSun * Mathf.Sin(Mathf.Deg2Rad*angle);
		angle += (Time.deltaTime * 360) / YearDuration;
		if (angle >= 360)
			angle = 0;
		transform.position = new Vector2 (x, y);


	}
}
