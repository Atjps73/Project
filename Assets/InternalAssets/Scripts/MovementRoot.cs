using UnityEngine;

namespace Molochka.Movement
{
	[RequireComponent(typeof(Rigidbody))]
	public class MovementRoot : MonoBehaviour
	{
		[SerializeField] private Vector3 _position;
		[SerializeField] private float _speed;

		private Rigidbody _rigidbody;
		private IMovable _movable;
		private bool _defalutPosition;

		private void FixedUpdate()
		{
			_movable.Move(Vector3.up);
		}

		private void OnClick()
		{
			if (_defalutPosition)
				_movable.SetPosition(-_position);
			else
				_movable.SetPosition(_position);

			_defalutPosition = !_defalutPosition;
		}

		public void Init()
		{
			_rigidbody = GetComponent<Rigidbody>();
			_defalutPosition = true;	
			_movable = new Movement(_rigidbody, transform, _speed);
		}
	}
}