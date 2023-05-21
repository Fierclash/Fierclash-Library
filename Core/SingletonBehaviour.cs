using UnityEngine;

namespace Fierclash.Core
{
	/// <summary>
	/// Monobehaviour that implements the Singleton pattern.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		/// <summary>
		/// Static reference to a singleton instance.
		/// </summary>
		public static T Instance
		{
			get;
			private set;
		}

		private void Awake()
		{
			// Set this object as the singleton instance
			if (Instance == null) Instance = this as T;
			// Otherwise, destroy this object
			else Destroy(this);
		}
	}

	/// <summary>
	/// Monobehavior that implements singleton pattern with persisting behavior.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public abstract class PersistentSingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		/// <summary>
		/// Static reference to a singleton instance.
		/// </summary>
		public static T Instance
		{
			get;
			private set;
		}

		private void Awake()
		{
			// Set this object as the singleton instance
			if (Instance == null)
			{
				Instance = this as T;
				DontDestroyOnLoad(this);
			}
			// Destroy this object
			else
			{
				Destroy(this);
			}
		}
	}
}
