using UnityEngine.SceneManagement;

public class LevelRestart
{
	public void Restart(int indexScene)
	{
		SceneManager.LoadScene(indexScene);
	}
}