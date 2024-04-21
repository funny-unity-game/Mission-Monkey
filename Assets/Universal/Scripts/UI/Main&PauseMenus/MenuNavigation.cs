using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuNavigation : MonoBehaviour
{
    public void HideUI(GameObject uiToHide)
    {
        uiToHide.SetActive(false);
    }

    public void ShowUI(GameObject uiToShow)
    {
        uiToShow.SetActive(true);
    }

    public void SwitchOptionsMenuPage(GameObject uiToSwitchTo)
    {
        GameObject.FindGameObjectWithTag("OptionsMenuPage").SetActive(false);
        uiToSwitchTo.SetActive(true);
    }

    public void QuitGame()
    {
        Cursor.lockState = CursorLockMode.None;
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void OpenLink(string webAddress)
    {
        Application.OpenURL(webAddress);
    }

    public void LoadSceneFromBuildNumber(int sceneToLoad)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Single);
    }
    
    
}