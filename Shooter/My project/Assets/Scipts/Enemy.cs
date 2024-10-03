using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform player;
    public float speed = 5f;

    void Start()
    {
        GameObject playerGameObject = GameObject.FindWithTag("Player");
        if (playerGameObject != null)
        {
            player = playerGameObject.transform;
        }
        else
        {
            Debug.LogError("Player not found! Make sure your player GameObject has the tag 'Player'.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            // Move our position a step closer to the target.
            float step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            Debug.Log("Collision");
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
    
}
