using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public static int coins = 0, totalCoins = 5;
    [SerializeField] public Enemy enemy;

    private void Awake()
    {
        if (instance == null) instance = this;
        else Destroy(gameObject);
    }

    

    public static void AddCoin(int qty)
	{
        coins += qty;
        Debug.Log($"coins: {coins}");
	}
    public static void LoadScreen(string nextScene) {
		SceneManager.LoadScene(nextScene);
	}
}