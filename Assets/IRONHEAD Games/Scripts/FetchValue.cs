using UnityEngine;
using TMPro;

public class FetchValue : MonoBehaviour
{
    [SerializeField] 
    private TMP_Text _title1, _title2, _title3;

    public void OnButtonClick()
    {
            _title1.text = "Thiru";
            _title2.text = "23";
            _title3.text = "Developer";
    }
}