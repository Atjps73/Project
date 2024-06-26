using UnityEngine;

namespace Molochka.Movement
{
	public class Movement : IMovable
	{
		private readonly Transform _transform;
		private readonly Rigidbody _rigidbody;
		private readonly float _speed;

		public Movement(Rigidbody rigidbody, Transform transform, float speed)
		{
			_rigidbody = rigidbody;
			_transform = transform;
			_speed = speed;
		}

		public void Move(Vector3 direction)
		{
			_rigidbody.velocity = direction * _speed;
		}

		public void SetPosition(Vector3 position)
		{
			_transform.position += position;
		}
	}
}