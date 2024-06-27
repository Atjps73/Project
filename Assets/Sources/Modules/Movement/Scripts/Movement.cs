using UnityEngine;

namespace Molochka.Movement
{
	internal class Movement : IMovable
	{
		private readonly Rigidbody _rigidbody;
		private readonly float _speed;

		internal Movement(Rigidbody rigidbody, float speed)
		{
			_rigidbody = rigidbody;
			_speed = speed;
		}

		public void Move(float movementInput)
		{
			_rigidbody.velocity = new Vector2(movementInput, 0) * _speed;
		}
	}
}
