using UnityEngine;
using Molochka.Movement;
using Molochka.Enemy;
using Molochka.Shooting;

namespace GameRoot
{
    public class GameRoot : MonoBehaviour
    {
        [SerializeField] private MovementInput _movementInput;
		[SerializeField] private WeoponInput _weoponInput;
		[SerializeField] private EnemyCharacter _enemyCharacter;

		private void Start()
		{
			_movementInput.Init();
			_weoponInput.Enable();
			_enemyCharacter.Init();
		}
	}
}
