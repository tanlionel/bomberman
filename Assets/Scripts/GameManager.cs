using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public string[] sceneName;
    private int m_indexCurrentScene = 0;
    public GameObject[] players;
    public GameObject[] enemies;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void CheckWinState()
    {
        int aliveCount = 0;
        int enemyCount = 0;
        foreach (GameObject player in players)
        {
            if (player.activeSelf)
            {
                aliveCount++;
            }
        }

        foreach (GameObject enemy in enemies)
        {
            if (enemy.activeSelf)
            {
                enemyCount++;
            }
        }

        //LOSE
        if (aliveCount <= 0)
        {
            Invoke(nameof(NewRound), 3f);
        }
        //WIN
        if (enemyCount <= 0)
        {
            m_indexCurrentScene++;
            if (m_indexCurrentScene == sceneName.Length)
                m_indexCurrentScene = 0;
            Invoke(nameof(NewRound), 3f);
        }
    }

    private void NewRound()
    {
        TrasitionSceneUI.Instance.LoadScene(sceneName[m_indexCurrentScene]);
    }
}
