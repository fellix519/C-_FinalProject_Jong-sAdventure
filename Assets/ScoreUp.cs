using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUp : MonoBehaviour
{
    private void OnCollision2D(Collider2D other)
    {

        Score.score++;
        Debug.Log(Score.score);
    }
}
