using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GO_textScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = new string("Score : " + Score.score.ToString()+"\nCLICK THE MOUSE TO PLAY AGAIN");
    }
    
}
