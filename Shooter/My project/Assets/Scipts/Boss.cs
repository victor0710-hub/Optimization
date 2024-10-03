using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    // Start is called before the first frame update

    private Transform player;
    public GameObject enemies;
    public float speed = 5f;
    private float life = 1;
    public RectTransform lifeImage;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
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
        lifeImage.localScale = new Vector3(life,lifeImage.localScale.y,lifeImage.localScale.z);
        if (player != null)
        {
            // Move our position a step closer to the target.
            float step = speed * Time.deltaTime; // calculate distance to move
           // transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            if (life > 0)
            {
                life -= 0.02f;
            }
            else

            {
                SceneManager.LoadScene("Win");
            }
        }
    }
    private IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(3.5f);
        Instantiate(enemies, transform.position , Quaternion.identity);

        StartCoroutine(SpawnEnemies());
    }
}
