using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TestUi
{

    public class TestInitLayer : MonoBehaviour
    {
        [SerializeField] private Transform parent;


        public GameObject layer;

        private string _layerName;

        private bool _checkbox;

        public Text LayerName;

        public Toggle Checkbox;



        [ContextMenu("LayerStartTest")]

        void LayerStartTest()
        {
            for (int i = 0; i < 5; i++)
            {
                LayerStart(true, "TestLayer1");

                Debug.Log("LayerStartTest" + i);
            }
        }


        void Start()
        {
            LayerStart(_checkbox, _layerName);
        }


        public void LayerStart(bool _checkbox, string _layerName)
        {
            layer = Instantiate(layer, parent);

            layer.SetActive(true);

            LayerName.text = _layerName;

            Checkbox.isOn = _checkbox;
        }
    }
}
