using UnityEngine;

namespace Molochka.Movement
{
	public interface IMovable
	{
		public void Move(Vector3 vector);

		public void SetPosition(Vector3 position);
	}
}