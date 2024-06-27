using UnityEngine;

namespace Molochka.Enemy
{
    public class EnemyCharacter : MonoBehaviour, IDamagable
    {
        [SerializeField, Min(0)] private int _startHealth;

        private EnemyHealth _enemyHealth;

		private void OnDisable()
		{
			_enemyHealth.Died -= Died;
		}

		private void Died()
		{
			Destroy(gameObject);
		}

		public void TakeDamage(int damage)
        {
			_enemyHealth.TakeDamage(damage);
		}

        public void Init()
        {
			_enemyHealth = new EnemyHealth(_startHealth);
			_enemyHealth.Died += Died;
		}
	}
}
