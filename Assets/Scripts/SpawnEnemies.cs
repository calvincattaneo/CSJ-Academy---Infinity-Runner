using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour {

    public float initialTime;
    public float minTime;
    public float maxTime;
    private float dioz = 3;
    public List<GameObject> EnemiesLiest = new List<GameObject>();

    float timeControl;
    // Update is called once per frame
    void Update() {
        if (GameController.current.PlayerIsAlive) {
            timeControl += Time.deltaTime;
            if (timeControl >= initialTime) {
                Instantiate(EnemiesLiest[Random.Range(0, EnemiesLiest.Count)], transform.position + new Vector3(0, Random.Range(0, 4), 10), transform.rotation);
                initialTime = Random.Range(minTime, maxTime);
                timeControl = 0;
            }
        }      
    }
    //new Vector3(transform.position.x, transform.position.y, dioz)
}
