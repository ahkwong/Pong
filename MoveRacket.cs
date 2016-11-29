using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class MoveRacket : MonoBehaviour {

	public float speed = 30;
	public string player;

	void FixedUpdate () {
		float v = Input.GetAxisRaw (player);
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, v) * speed;
	}
}
