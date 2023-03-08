using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetMethod : MonoBehaviour
{
    [SerializeField] 
    public TMP_Text _title1;

    public void OnButtonClick()
    {
        StartCoroutine(GetData_Coroutine());
        Debug.Log("Inside button click");
    }
    IEnumerator GetData_Coroutine()
    {
        Debug.Log("Inside iteration click");
        _title1.text = "Loading...";
        string uri = "https://dummy.restapiexample.com/api/v1/employee/1";
        using(UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();
            if (request.isNetworkError || request.isHttpError)
                _title1.text = request.error;
            else
                _title1.text = request.downloadHandler.text;
        }
    }
}