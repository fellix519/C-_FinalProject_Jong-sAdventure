using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public static int score;
    public static int Life = 3;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        Life = 3;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = new string("Score : "+score.ToString()+"\n"+ "LIfe : " + Life.ToString());
     
    }
}
