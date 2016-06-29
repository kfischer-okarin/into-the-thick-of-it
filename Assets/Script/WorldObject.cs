﻿using UnityEngine;
using System.Collections;

public class WorldObject : MonoBehaviour {

	public GameObject body;
	private SpriteRenderer rend;

	void Awake () {
		rend = body.GetComponent<SpriteRenderer>();
	}
	
	void LateUpdate () {
		if (rend.isVisible) {
			rend.sortingOrder = (int) (body.transform.position.y * 64.0 * -1.0f);
		}
	}
}