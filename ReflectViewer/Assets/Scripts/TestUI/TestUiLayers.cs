using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUiLayers : MonoBehaviour
{
    [SerializeField] private GameObject layerPanel;

    //[SerializeField] private GameObject layer;

    private List<Dictionary<bool, string>> _layerDictionaryList;

    private Dictionary<bool, string> layerDictionary;

    void Start()
    {
        layerDictionary = TestInitLayer.layerDictionary;

        _layerDictionaryList = new List<Dictionary<bool, string>>();

        _layerDictionaryList.Add(layerDictionary);

        //InstantiateLayer();
    }

    


}
