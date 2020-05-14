using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class RestartSceneButton : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // On ajoute une fonction à l’event OnClick
        GetComponent<Button>().onClick.AddListener(ReloadScene);
    }

    /// <summary>
    /// Fonction utilisée pour recharger la scène
    /// </summary>
    private void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}