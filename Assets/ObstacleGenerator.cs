using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObstacleControll
{
    public class ObstacleGenerator : MonoBehaviour
    {
        public GameObject Obs;
        public float timeDiff;
        float timer = 0;
        // Start is called before the first frame update
        public void Start()
        {

        }

        // Update is called once per frame
        public void Update()
        {
            timer += Time.deltaTime;
            if (timer > timeDiff)
            {
                //GameObject newSpike = new GameObject();

                //newSpike.transform.position = new Vector3(3.72000003f, -2.98000002f, 0);
                var newSpike = Instantiate(Obs);
                newSpike.transform.position = new Vector3(5.44000006f, -2.98000002f, 0);
                timer = 0;
            }

        }
    }
}
