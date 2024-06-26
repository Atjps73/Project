using UnityEngine;

namespace Molochka.Movement
{
	public class Movement : IMovable
	{
		private readonly Transform _transform;

		public Movement(Transform transform)
		{
			_transform = transform;
		}

		public void SetPosition(Vector3 position, ref bool defaultPosition)
		{
			_transform.position += position;
			defaultPosition = !defaultPosition;
		}
	}
}