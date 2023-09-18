using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour {
	public float move_speed;
	public float jump_speed;

	private Rigidbody2D player_rigidbody;


	/* Start is called before the first frame update. */
	void Start() {
		player_rigidbody = GetComponent<Rigidbody2D>();
	}

	/* Update is called once per frame. */
	void Update() {
		movement_horizontal();
		movement_jump();
	}


	private void movement_horizontal() {
		float input_horizontal = Input.GetAxisRaw("Horizontal");

		player_rigidbody.velocity = new Vector2(
			move_speed * input_horizontal,
			player_rigidbody.velocity.y
		);
	}

	private void movement_jump() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			player_rigidbody.velocity = new Vector2(
				player_rigidbody.velocity.x,
				player_rigidbody.velocity.y + jump_speed
			);
		}
	}
}
