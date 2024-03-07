using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrasitionSceneUI : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [HideInInspector] public static TrasitionSceneUI Instance;
    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void PlayTransitionOut()
    {
        animator.Play("PlayTransitionOut");
    }
    public void PlayTransitionIn()
    {
        animator.Play("PlayTransitionIn");
    }
    public void LoadScene(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            StartCoroutine(SmoothChangScene(sceneName));
        }
    }
    private IEnumerator SmoothChangScene(string sceneName)
    {
        PlayTransitionOut();
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync(sceneName).completed += (asd) => { PlayTransitionIn(); };
    }
}
