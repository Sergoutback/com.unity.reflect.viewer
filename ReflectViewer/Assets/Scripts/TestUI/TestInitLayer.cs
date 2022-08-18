using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInitLayer : MonoBehaviour
{
    [SerializeField] private GameObject layer;

    private string _layerName;

    private bool _checkbox;

    public Dictionary<bool, string> layerDictionary;

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
        for (int i = 0; i < 5; i++)

            InstantiateLayer();
    }


    public void LayerStart(bool _checkbox, string _layerName)
    {
        if (_checkbox)

            layerDictionary = new Dictionary<bool, string>();

            LayerName = _layerName;

            Checkbox = _checkbox;
    }

    private void InstantiateLayer()

    {
        layer = Instantiate(layer, new Vector3(0, transform.position.y-60, 0), Quaternion.identity);

        layer.SetActive(true);
    }


}
