using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInitLayer : MonoBehaviour
{
    [SerializeField] private GameObject layer;

    [SerializeField] private string _layerName;

    [SerializeField] private bool _checkbox;

    private Dictionary<bool, string> _layerDictionary;

    public string LayerName;

    public bool Checkbox;



    [ContextMenu("LayerStartTest")]

    void LayerStartTest()
    {
        LayerStart(true, "TestLayer1");

        Debug.Log("LayerStartTest");
    }


    void Start()
    {
        InstantiateLayer();
    }


    public void LayerStart(bool _checkbox, string _layerName)
    {
        if (_checkbox)

            _layerDictionary = new Dictionary<bool, string>();

            LayerName = _layerName;

            Checkbox = _checkbox;
    }

    private void InstantiateLayer()

    {
        layer = Instantiate(layer, new Vector3(0, -60, 0), Quaternion.identity);
    }


}
