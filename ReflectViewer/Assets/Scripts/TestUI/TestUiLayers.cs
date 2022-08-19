using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TestUi;



public class TestUiLayers : MonoBehaviour
{
    public GameObject layerPanel;


    private List<Dictionary<bool, string>> _layerDictionaryList;

    private Dictionary<bool, string> _layerDictionary;


    private GameObject _layerForDict;


    public TestInitLayer newlayer;



    void Start()
    {
        newlayer = GetComponent<TestInitLayer>();

        _layerDictionaryList = new List<Dictionary<bool, string>>(10);

        _layerDictionary = new Dictionary<bool, string>();

        _layerDictionary.Add(newlayer.Checkbox, newlayer.LayerName.text);

        //new newlayer.LayerStart(_layerDictionary);
    }
}
