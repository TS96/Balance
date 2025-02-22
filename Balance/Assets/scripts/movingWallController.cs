﻿using UnityEngine;
using System.Collections;

public class movingWallController : MonoBehaviour {

    Rigidbody2D rigid;
    float speed = 9.0f;
	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void FixedUpdate()
    {
        if (transform.position.y > 4) 
            speed *= -1;
        if (transform.position.y < -15)
            speed = Mathf.Abs(speed);
        rigid.velocity = new Vector2(0, speed);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
            GetComponent<AudioSource>().Play();

    }
}
