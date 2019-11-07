using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ohrizon.Dependancy
{
    public class Hello : MonoBehaviour
    {
        public int speed;

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            this.transform.position = new Vector3(speed, 0, 0) + this.transform.position;
        }
    }
}