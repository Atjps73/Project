using Molochka.Movement;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
	[SerializeField] private EnemyMovement _enemyMovement;

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<PlayerMovement>())
			_enemyMovement.Move();
	}
}