using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObstacleControll
{
    public class bombGenerator : ObstacleGenerator
    {
        //Vector3(6.69000006,2.18000007,0) bomb pos high
        //Vector3(6.69000006,-0.170000002,0) bomb pos mid
        public GameObject bomb;
        new float timeDiff=1.0f;
        new float timer=0;
        static public int isPosHigh = 1;
        static int postIPH=-1;
        // Start is called before the first frame update
        //override
        void Start()
        {
            base.Start();
        }
        public int GetPosHigh()
        {
            return isPosHigh;
        }
        // Update is called once per frame
        void Update()
        {
            timer += Time.deltaTime;
            if (timer > timeDiff)
            {   
                //GameObject newSpike = new GameObject();

                //newSpike.transform.position = new Vector3(3.72000003f, -2.98000002f, 0);
                var newBomb1 = Instantiate(bomb);

                //do{
                while (true)
                {
                    isPosHigh = Random.Range(1, 4);
                    if (isPosHigh != postIPH) break;
                }
                 
                 Debug.Log(isPosHigh + " " + postIPH);
                postIPH = isPosHigh;
                //}while (isPosHigh != postIPH);

                

                newBomb1 =base.SetObPos(isPosHigh, newBomb1);
                //newBomb.transform.position = new Vector3(6.69000006f, Random.Range(-1.32000005f, 2.18000007f), 0);
                timer = 0;

                Destroy(newBomb1, 5.0f);
            }

        }
    }
}
