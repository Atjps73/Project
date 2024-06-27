using UnityEngine;
using Molochka.Enemy;

namespace Molochka.Shooting
{
    internal class Weopon : MonoBehaviour
    {
		[SerializeField] private Transform _point;
		[SerializeField, Min(0)] private int _damage;

		private RaycastHit _hitInfo;

		internal void Shoot()
		{
			if (Physics.Raycast(_point.position, _point.forward, out _hitInfo))
			{
				if (_hitInfo.collider.TryGetComponent(out IDamagable enemy))
				{
					enemy.TakeDamage(_damage);
				}
			}
		}
	}
}
