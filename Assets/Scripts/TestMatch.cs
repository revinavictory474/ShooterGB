using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Script : MonoBehaviour
    {
        #region Public objects on Unity
        public GameObject circle;
        public GameObject square;
        public List<GameObject> circels = new List<GameObject>();
        GameObject[] ArrCircels;

        //string [][] array = new string[2][];
        #endregion

        private void Start()
        {

            //Vector2 pos = new Vector2(0, 0);
            //var red = Instantiate(circels[0], pos, Quaternion.identity);
            LoadMassive(-3, 0);
            //Destroy(ArrayWaveCircels[0]);
        }
        private void Update()
        {

        }
        void Init()
        {

        }

        void LoadMassive(float posX, float posY)
        {
            List<GameObject> ArrayWaveCircels = new List<GameObject>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int rnd = Random.Range(0, 4);
                    Vector2 pos = new Vector2(posX, posY);
                    GameObject somecircles = Instantiate(circels[rnd], pos, Quaternion.identity);
                    ArrayWaveCircels.Add(somecircles);
                    posX++;
                }
                posX = -3;
                posY++;
            }
            ArrCircels = ArrayWaveCircels.ToArray();
        }
    }
}