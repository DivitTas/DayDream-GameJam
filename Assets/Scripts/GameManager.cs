using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool enableDash = true;
    public bool enableWallRun = true;
    public bool enableDoubleJump = true;

    private void Awake()
    {
        // If there’s already a GameManager, kill the duplicate
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject); // survive scene reloads
    }
}
