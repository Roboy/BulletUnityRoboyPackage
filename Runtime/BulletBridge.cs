using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Roboy.BulletBridge
{
    public class BulletBridge : MonoBehaviour
    {
        public static string Version = "0.1.0";
        public GameObject Roboy_Model;

        void Start()
        {
            InitializeBridge();
        }


        void Update()
        {
            SynchStates();
        }

        private void InitializeBridge()
        {
            //TODO
            //Create Instances
            //Spawn Objects
        }

        private void SynchStates()
        {
            //TODO
            //Synch Object Positions and Rotations

        }
    }
}
