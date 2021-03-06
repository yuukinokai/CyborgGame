﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFlow : MonoBehaviour {

	[SerializeField] private float minX = 0f;
	[SerializeField] private float minY = 0f;
	[SerializeField] private float maxX = 0f;
	[SerializeField] private float maxY = 0f;

	private Transform target;

	// Use this for initialization
	void Start () 
	{
		target = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = new Vector3(Mathf.Clamp(target.position.x, minX, maxX), Mathf.Clamp(target.position.y, minY, maxY), transform.position.z);
	}
}
