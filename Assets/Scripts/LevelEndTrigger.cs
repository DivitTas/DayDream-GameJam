using UnityEngine;

public class LevelEndTrigger : MonoBehaviour
{
    [SerializeField] private GameObject Canvas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {   
            
            Time.timeScale = 0f; // pause game
            Canvas.SetActive(true);
        }
    }
}
