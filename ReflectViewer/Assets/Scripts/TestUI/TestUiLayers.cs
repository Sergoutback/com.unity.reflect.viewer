using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUiLayers : MonoBehaviour
{
    [SerializeField] private GameObject layerPanel;

    [SerializeField] private GameObject newlayer;

    private List<Dictionary<bool, string>> _layerDictionaryList;

    private Dictionary<bool, string> _layerDictionary;

    void Start()
    {
        _layerDictionaryList = new List<Dictionary<bool, string>>(10);

        //layerDictionary = TestInitLayer.layerDictionary;

        //_layerDictionaryList.Add(layerDictionary);

        //InstantiateLayer();
    }

    


}
