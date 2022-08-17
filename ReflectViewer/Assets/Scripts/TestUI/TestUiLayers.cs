using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUiLayers : MonoBehaviour
{
    [SerializeField] private GameObject layersPanel;

    [SerializeField] private string _layersName;

    private bool _checkbox;



    void Start()
    {
        LayersStart(_layersName, _checkbox);
    }

    public void LayersStart(string _infoTestUIText, bool _checkbox)
    {
        Dictionary<string, bool> layerDictionary = new Dictionary<string, bool>();
    }
}
