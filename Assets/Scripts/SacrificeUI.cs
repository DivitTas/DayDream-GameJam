using UnityEngine;
using UnityEngine.SceneManagement;

public class SacrificeUI : MonoBehaviour
{
    [SerializeField] private Abilities abilities; // drag your player’s Abilities script here


    public void SacrificeDash()
    {
        //abilities.enableDash = false;

        CloseUI();
    }

    public void SacrificeSuperJump()
    {
        //abilities.enableSuperJump = false;
        
        CloseUI();
    }

    private void CloseUI()
    {
        gameObject.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f; // unpause game
    }
}
