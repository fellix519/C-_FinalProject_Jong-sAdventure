using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BombCollision : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "bird" && this.gameObject.name != "bomb")
        {
            Score.Life--;
          
            Destroy(this.gameObject);

            if (Score.Life == 0)
            {
                Debug.Log("itsin, life : " + Score.Life);
                SceneManager.LoadScene("GameOverScene");
            }
            
            Debug.Log("dddddsss");
        }
    }
}
