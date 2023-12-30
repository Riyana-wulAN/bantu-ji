using UnityEngine;
using UnityEngine.UI;

public class OpenURLOnClick : MonoBehaviour
{
    public Button button;
    public string url;

    private void Start()
    {
        button.onClick.AddListener(OpenURL);
    }

    private void OpenURL()
    {
        Application.OpenURL(url);
    }
}