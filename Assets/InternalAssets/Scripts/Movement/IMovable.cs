using UnityEngine;

namespace Molochka.Movement
{
	public interface IMovable
	{
		public void SetPosition(Vector3 position, ref bool defaultPosition);
	}
}