using Molochka.Movement;
using UnityEngine;

public class Finish : MonoBehaviour
{
	[SerializeField] private int _indexScene;

	private LevelRestart _levelRestart;

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<PlayerMovement>())
			_levelRestart.Restart(_indexScene);
	}

	public void Init()
	{
		_levelRestart = new LevelRestart();
	}
}