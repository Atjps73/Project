using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
	[SerializeField] private int _indexScene;

	private LevelRestart _levelRestart;

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<EnemyMovement>())
			_levelRestart.Restart(_indexScene);
	}

	public void Init()
	{
		_levelRestart = new LevelRestart();
	}
}