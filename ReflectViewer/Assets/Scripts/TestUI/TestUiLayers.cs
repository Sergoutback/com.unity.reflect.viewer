using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUiLayers : MonoBehaviour
{
    [SerializeField] private GameObject layerPanel;

    [SerializeField] private string _layerName;

    private bool _checkbox;

    private Dictionary<string, bool> _layerDictionary;



    void Start()
    {
        LayerStart(_layerName, _checkbox);
    }

    public void LayerStart(string _layersName, bool _checkbox)
    {
        _layerDictionary = new Dictionary<string, bool>();
    }
}
