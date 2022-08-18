using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TestUi
{

    public class TestUiLayers : MonoBehaviour
    {
        public GameObject layerPanel;


        private List<Dictionary<bool, string>> _layerDictionaryList;

        private Dictionary<bool, string> _layerDictionary;


        private GameObject _layerForDict;


        public TestInitLayer newlayer;



        void Start()
        {
            _layerDictionaryList = new List<Dictionary<bool, string>>(10);

            _layerDictionary = new Dictionary<bool, string>();

            //AddNewLayer();

        }

        //void AddNewLayer()
        //{

        //    for (int i = 0; i < 10; i++)

        //    {
        //        newlayer = GetComponent<TestInitLayer>();

        //        newlayer.layer = Instantiate(_layerForDict);

        //        //_layerDictionary = newlayer.Checkbox, newlayer.LayerName

        //        //_layerDictionaryList.Add(_layerDictionary);
        //    }
        //}
    }
}
