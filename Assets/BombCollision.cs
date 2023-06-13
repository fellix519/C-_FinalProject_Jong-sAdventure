using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "bird" && other.gameObject.name != "bomb")
        {
            Score.score--;

            Destroy(this.gameObject);
            Debug.Log("dddddsss");
        }
    }
}
