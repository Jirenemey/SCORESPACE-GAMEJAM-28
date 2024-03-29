using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour {

	public Animator animator;

	private string levelToLoad;

	public void FadeToGame ()
	{
		Time.timeScale = 1f;
		FadeToLevel("Game");
	}

    public void FadeToMenu()
    {
		Time.timeScale = 1f;
        FadeToLevel("MainMenu");
    }

	public void FadeToLevel (string levelIndex)
	{
		levelToLoad = levelIndex;
		animator.SetTrigger("FadeOut");
	}

	public void OnFadeComplete ()
	{
		SceneManager.LoadScene(levelToLoad);
	}
}