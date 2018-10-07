using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class CatStats : MonoBehaviour
    {

        public int Score = 100;
        public int Life = 9;
        public int Age = 92;

        public float Health = 5.5f;
        [Range(0,10)] public float CatPower = 9.9f;

        //public Boolean alive = true;
        public Vector3 Movement = new Vector3(1.5f, 2.1f, 3.0f);
 
        public Color CatColor = Color.blue;

        public Animation Anims;

        //public UnityEvent Event;
	
        void Start()

        {
            print("I am an apex predator.");
        }

        void Update()
        {
            if (CatColor != Color.blue)
            {
                CatColor = Color.blue;
            }
            else
            {
                CatColor = Color.grey;
                print("All cats are grey in the dark.");
            }
            //transform.Rotate(Movement);
            transform.Rotate(Vector3.right * 10.0f);

        }
    }