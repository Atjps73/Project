using UnityEngine;

namespace Molochka.Movement
{
	[RequireComponent(typeof(Rigidbody))]
	public class PlayerMovement : MonoBehaviour
	{
		[SerializeField] private Vector3 _position;
		[SerializeField] private float _speed;

		private Rigidbody _rigidbody;
		private IMovable _movable;
		private bool _defaultPosition;

		private void FixedUpdate()
		{
			_rigidbody.velocity = Vector3.up * _speed;
		}

		private void OnClick()
		{
			if (_defaultPosition)
				_movable.SetPosition(-_position, ref _defaultPosition);
			else
				_movable.SetPosition(_position, ref _defaultPosition);
		}

		public void Init()
		{
			_rigidbody = GetComponent<Rigidbody>();
			_movable = new Movement(transform);
			_defaultPosition = true;
		}
	}
}