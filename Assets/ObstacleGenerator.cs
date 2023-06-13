using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ObstacleControll
{
    public class ObstacleGenerator : MonoBehaviour
    {
        public GameObject Obs;
        public float timeDiff=1.0f;
        float timer = 0;
        // Start is called before the first frame update
        public GameObject SetObPos(int input,GameObject Ob)
        {
            switch (input)
            {
                case (1):Ob.transform.position = new Vector3(6.69000006f, 2.18000007f, 0);
                    {
                        Ob.transform.position = new Vector3(6.69000006f, 2.18000007f, 0);
                        timer = 0;
                        break;
                    }
                case (2):
                    {
                        Ob.transform.position = new Vector3(6.9000001f, 0.05f, 0);
                        timer = 0;
                        break;
                    }
                case (3):
                    {
                        Ob.transform.position = new Vector3(6.69000006f, -1.32000005f, 0);
                        timer = 0;
                        break;
                    }
            }
            return Ob;
        }
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
                Destroy(newSpike, 10.0f);
            }

        }
    }
}
