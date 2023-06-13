using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObstacleControll
{
    public class StarGenerator : ObstacleGenerator
    {
        //Vector3(6.69000006,-0.170000002,0) bomb pos mid
        public GameObject star;
        new float timeDiff=1.0f;
        new float timer = 0;
        public bool isPosHigh = true;
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
                var newStar = Instantiate(star);
                //switch (isPosHigh)
                //{
                //    case (true):
                //    {
                //        newSpike.transform.position = new Vector3(6.69000006f, 2.18000007f, 0);
                //        timer = 0;
                //        break;
                //    }
                //    case (false):
                //    {
                //            newSpike.transform.position = new Vector3(6.69000006f, -0.170000002f, 0);
                //            timer = 0;
                //            break;
                //    }Vector3(6.69000006,-1.32000005,0)
                //}
                
                newStar.transform.position = new Vector3(6.69000006f, Random.Range(-1.32000005f, 2.18000007f), 0);
                timer = 0;


            }

        }
    }
}

    