using UnityEngine;

namespace Molochka.Shooting
{
    public class WeoponInput : MonoBehaviour
    {
		[SerializeField] private Weopon _weopon;

		private bool _active = false;

		private void OnFire()
		{
			if (_active)
				_weopon.Shoot();
		}

		public void Enable()
		{
			_active = true;
		}

		public void Disable()
		{
			_active = false;
		}
	}
}
