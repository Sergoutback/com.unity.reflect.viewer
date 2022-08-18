using UnityEngine;
using UnityEngine.UI;

public class TestUiInfo : MonoBehaviour
{
    [SerializeField] private GameObject infoPanel;

    [SerializeField] private Text descriptionTestUIText;

    [SerializeField] private Button cancel_Button;
    

    private string _descriptionTestUIText;



    [ContextMenu("TextTest")]

    void TextTest()
    {
        TextStart("descriptionTestdescriptionTestdescriptionTestdescriptionTestdescriptionTest" +
            "" +
            "descriptionTestdescriptionTestdescriptionTestdescriptionTestdescriptionTest" +

            "descriptionTestdescriptionTestdescriptionTestdescriptionTestdescriptionTest" +
            "" +
            "descriptionTestdescriptionTestdescriptionTestdescriptionTestdescriptionTest" +
            "" +
            "descriptionTestdescriptionTestdescriptionTestdescriptionTestdescriptionTest");

        Debug.Log("TextTest descriptionTest");
    }

    [ContextMenu("CancelTest")]

    void CancelTest()
    {
        CancelButton();

        Debug.Log("CancelTest");
    }



    private void Start()
    {
        descriptionTestUIText.text = ("DescriptionFromScript");
    }



    //void Update()
    //{
    //    TextStart(_descriptionTestUIText);
    //}

    public void TextStart(string _descriptionTestUIText)
    {
        descriptionTestUIText.text = _descriptionTestUIText;
    }

    public void CancelButton()
    {
        infoPanel.SetActive(false);
    }

    //public void ActivateInfoPanel()
    //{
    //    infoPanel.SetActive(true);
    //}
}
