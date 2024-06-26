using Molochka.Movement;
using UnityEngine;

public class GameRoot : MonoBehaviour
{
	[SerializeField] private MovementRoot _movementRoot;

	private void Start()
	{
		_movementRoot.Init();
	}
}