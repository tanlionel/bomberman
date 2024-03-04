using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private Button btStart;
    [SerializeField] private Button btQuit;
    private void Start()
    {
        if (btStart != null)
            btStart.onClick.AddListener(OnButtonStartClick);
        if (btQuit != null)
            btQuit.onClick.AddListener(OnButtonQuitClick);

    }
    private void OnButtonStartClick()
    {
        TrasitionSceneUI.Instance.LoadScene("Stage 2");
    }
    private void OnButtonQuitClick()
    {
        Application.Quit();
    }
}
