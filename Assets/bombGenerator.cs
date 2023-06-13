using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObstacleControll
{
    public class bombGenerator : ObstacleGenerator
    {
        public GameObject bomb;
        new public float timeDiff;
        new float timer = 0;
        // Start is called before the first frame update
        //override
        void Start()
        {
            base.Start();
        }

        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer > timeDiff)
            {
                //GameObject newSpike = new GameObject();

                //newSpike.transform.position = new Vector3(3.72000003f, -2.98000002f, 0);
                var newSpike = Instantiate(bomb);
                newSpike.transform.position = new Vector3(5.44000006f, -2.98000002f, 0);
                timer = 0;
            }

        }
    }
}
