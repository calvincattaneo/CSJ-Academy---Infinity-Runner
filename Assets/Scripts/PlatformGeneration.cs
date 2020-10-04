﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGeneration : MonoBehaviour {

    public GameObject Platform;
    public Transform point;
    public float Distance;

    private float platformWidth;

    // Start is called before the first frame update
    void Start() {
        if (Platform.GetComponent<BoxCollider2D>()) {
            platformWidth = Platform.GetComponent<BoxCollider2D>().size.x;
        } else {
            platformWidth = Platform.GetComponent<PolygonCollider2D>().bounds.size.x;
        }
        
    }

    // Update is called once per frame
    void Update() {
        if(transform.position.x < point.position.x) {
            Distance = Random.Range(2f, 5f);
            transform.position = new Vector3(transform.position.x + platformWidth + Distance, transform.position.y, transform.position.z);
            Instantiate(Platform, transform.position, transform.rotation);
        }
    }
}
