using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float Speed;
    private Transform backPoint;
    private Animator anim;
    private Rigidbody2D rig;

    // Start is called before the first frame update
    void Start() {
        backPoint = GameObject.Find("BackPoint").GetComponent<Transform>();
        anim = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        //transform.Translate(Vector3.left * Speed * Time.deltaTime);
        rig.velocity = new Vector2(-Speed, rig.velocity.y);

        if (transform.position.x < backPoint.position.x) {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Bullet") {
            anim.SetTrigger("destroy");
            Destroy(gameObject, 2f);
        }
    }
}
