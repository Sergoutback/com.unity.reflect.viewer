using UnityEngine;
using UnityEngine.UI;

public class TestUiInfo : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;

    [SerializeField] private Text infoTestUIText;

    [SerializeField] private Text descriptionTestUIText;

    [SerializeField] private Button cancel_Button;
    

    private string _infoTestUIText = ("Info");

    private string _descriptionTestUIText = ("Description");



    void Start()
    {
        TextStart(_infoTestUIText, _descriptionTestUIText);
    }

    public void TextStart(string _infoTestUIText, string _descriptionTestUIText)
    {
        infoTestUIText.text = _infoTestUIText;

        descriptionTestUIText.text = _descriptionTestUIText;
    }

    public void CancelButton()
    {
        infoPanel.SetActive(false);
    }

    public void ActivateInfoPanel()
    {
        infoPanel.SetActive(true);
    }
}
