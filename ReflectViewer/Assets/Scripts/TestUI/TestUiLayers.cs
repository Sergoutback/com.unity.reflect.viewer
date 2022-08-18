using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUiLayers : MonoBehaviour
{
    [SerializeField] private GameObject layerPanel;

    [SerializeField] private GameObject layer;

    [SerializeField] private string _layerName;

    [SerializeField] private bool _checkbox;

    private Dictionary<bool, string> _layerDictionary;



    void Start()
    {
        LayerStart(_checkbox, _layerName);

        InstantiateLayer();
    }

    public void LayerStart(bool _checkbox, string _layerName)
    {
        if (_checkbox)

            _layerDictionary = new Dictionary<bool, string>();
    }

    private void InstantiateLayer()

    {
        layer = Instantiate(layer, new Vector3(0, -60, 0), Quaternion.identity);
    }
}
