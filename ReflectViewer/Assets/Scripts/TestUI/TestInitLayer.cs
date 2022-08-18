using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInitLayer : MonoBehaviour
{
    public GameObject layer;

    private string _layerName;

    private bool _checkbox;

    //public Dictionary<bool, string> layerDictionary;

    public string LayerName;

    public bool Checkbox;



    [ContextMenu("LayerStartTest")]

    void LayerStartTest()
    {
        for(int i = 0; i < 5; i++)
        {
            LayerStart(true, "TestLayer1");

            Debug.Log("LayerStartTest");
        }
    }


    void Start()
    {
        for (int i = 0; i < 10; i++)

            LayerStart(Checkbox, LayerName);
    }
     

    public void LayerStart(bool _checkbox, string _layerName)
    {
        LayerName = _layerName;

        Checkbox = _checkbox;

        if (Checkbox)

            layer = Instantiate(layer, new Vector3(0, transform.position.y - 60, 0), Quaternion.identity);

            layer.SetActive(true);

            //layerDictionary = new Dictionary<bool, string>();

            //LayerName = _layerName;

            //Checkbox = _checkbox;
    }
}
