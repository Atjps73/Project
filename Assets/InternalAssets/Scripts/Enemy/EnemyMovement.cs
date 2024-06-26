using Molochka.Movement;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	[SerializeField] private Vector3 _position;
	[SerializeField] private float _defaultPositionValue;

	private IMovable _movable;
	private bool _defaultPosition;

	private bool CheckDefaultPosition()
	{
		return transform.position.x == _defaultPositionValue;
	}

	public void Move()
	{
		_movable.SetPosition(_position, ref _defaultPosition);
	}

	public void Init()
	{
		_movable = new Movement(transform);
		_defaultPosition = CheckDefaultPosition();
	}
}
