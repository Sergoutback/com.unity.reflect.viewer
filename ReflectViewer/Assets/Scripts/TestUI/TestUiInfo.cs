using System;
using System.Collections;
using SharpFlux.Dispatching;
using Unity.TouchFramework;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Reflect.Viewer.Core.Actions;
using UnityEngine.UI;

public class TestUiInfo : MonoBehaviour
{
    [SerializeField] private Text infoTestUIText;
    [SerializeField] private Text descriptionTestUIText;
    [SerializeField] private Button cancel_Button;

    public event Action buttonClicked;
    public event Action buttonLongPressed;

    private string _infoTestUIText;
    private string _descriptionTestUIText;

    void Start()
    {
        cancel_Button.onClick.AddListener(OnButtonClicked);
    }

    public void TextStart()
    {
        infoTestUIText.text = _infoTestUIText;
        descriptionTestUIText.text = _descriptionTestUIText;
    }

    public void CancelButton()
    {

    }

    void OnButtonClicked()
    {
        if (!cancel_Button)
        {
            Dispatcher.Dispatch(SetDeltaDNAButtonAction.From($"{transform.parent.name}_{transform.name}"));
            buttonClicked?.Invoke();
        }
    }


}
