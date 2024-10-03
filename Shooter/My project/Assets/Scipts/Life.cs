using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update

        public TextMeshProUGUI LifeText;

    private int lifeAmount = 3;
    void Start()
    {
        LifeText.text = lifeAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("Collision");
            if (lifeAmount > 0)
            {
                lifeAmount -=1;
                LifeText.text = lifeAmount.ToString();
                Destroy(other.gameObject);
               
            }
            else
            {
                //deadsc
                SceneManager.LoadScene("Loose");
            }
        }
    }
}
