﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBubble : MonoBehaviour
{
    public float theta = 0;

    public enum Direction
    {
        Right,
        Up,
        Forward,
    }

    public Direction rotationAxis;
    public float speed = 0.5f;
	// Update is called once per frame
	void Update ()
	{
        Vector3 dir;
	    switch (rotationAxis)
	    {
            case Direction.Forward:
                dir = Vector3.forward;
                break;
            case Direction.Right:
                dir = Vector3.right;
                break;
            case Direction.Up:
                dir = Vector3.up;
                break;
	        default:
	            throw new ArgumentOutOfRangeException();
	    }

	    theta += Time.deltaTime * speed;
	    transform.Rotate(dir, theta * Time.deltaTime);
    }
}
