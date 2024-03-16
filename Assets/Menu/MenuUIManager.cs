using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    [SerializeField] private Button btStart;
    [SerializeField] private Button btPvP;
    [SerializeField] private Button btQuit;
    private void Start()
    {
        if (btStart != null)
            btStart.onClick.AddListener(OnButtonStartClick);
        if (btQuit != null)
            btQuit.onClick.AddListener(OnButtonQuitClick);
        if(btPvP != null)
            btPvP.onClick.AddListener(OnButtonPvPClick);

    }
    private void OnButtonStartClick()
    {
        TrasitionSceneUI.Instance.LoadScene("HelpScreen");
    }
    private void OnButtonPvPClick()
    {
        TrasitionSceneUI.Instance.LoadScene("Stage PvP");
    }
    private void OnButtonQuitClick()
    {
        Application.Quit();
    }
}
