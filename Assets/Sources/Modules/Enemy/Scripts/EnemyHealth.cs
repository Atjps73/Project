using System;

namespace Molochka.Enemy
{
	internal class EnemyHealth
	{
        private int _health;

        public event Action Died;

		internal EnemyHealth(int health)
        {
			_health = health;
		}

        internal void TakeDamage(int damage)
        {
            if (_health < damage)
                throw new ArgumentException();

            _health -= damage;

            if (_health == 0)
			    Died?.Invoke();
		}
    }
}
