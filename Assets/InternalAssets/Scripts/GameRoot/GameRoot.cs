using Molochka.Movement;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
	[SerializeField] private PlayerMovement _playerMovement;
	[SerializeField] private PlayerDeath _playerDeath;
	[SerializeField] private EnemyMovement _enemyMovement;
	[SerializeField] private Finish _finish;

	private void Start()
	{
		_playerMovement.Init();
		_playerDeath.Init();
		_enemyMovement.Init();
		_finish.Init();
	}
}