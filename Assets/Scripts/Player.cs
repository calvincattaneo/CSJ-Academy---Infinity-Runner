﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float Speed;
    public float JumpForce;
    private Rigidbody2D rig;
    private bool isJumping;
    void Start() {
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() {
        //Movimenta o player para frente (direita)
        rig.velocity = new Vector2(Time.deltaTime * Speed, rig.velocity.y);

        //Pular
        if(Input.GetKeyDown(KeyCode.Space) && !isJumping) {
            rig.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.layer == 8) {
            isJumping = false;
        }
    }
}