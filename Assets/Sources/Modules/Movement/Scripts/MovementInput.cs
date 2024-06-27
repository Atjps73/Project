using UnityEngine;
using UnityEngine.InputSystem;

namespace Molochka.Movement
{
    [RequireComponent(typeof(Rigidbody))]
    public class MovementInput : MonoBehaviour
    {
		[SerializeField] private float _speed;

		private Rigidbody _rigidbody;
		private IMovable _movable;
		private float _movementInput;

		private void FixedUpdate()
		{
			_movable.Move(_movementInput);
		}

		private void OnMove(InputValue inputValue)
		{
			_movementInput = inputValue.Get<Vector2>().x;
		}

		public void Init()
		{
			_rigidbody = GetComponent<Rigidbody>();
			_movable = new Movement(_rigidbody, _speed);
		}
	}
}
