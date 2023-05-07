// #FrameworkScript

using UnityEngine;
using UnityEngine.Events;

namespace Fierclash.Core
{
	#region Primitives
	/// <summary>
	/// Event inheritance for bool argument.
	/// </summary>
	[System.Serializable]
	public sealed class BoolUnityEvent: UnityEvent<bool> { }

	/// <summary>
	/// Event inheritance for int argument.
	/// </summary>
	[System.Serializable]
	public sealed class IntUnityEvent : UnityEvent<int> { }

	/// <summary>
	/// Event inheritance for float argument.
	/// </summary>
	[System.Serializable]
	public sealed class FloatUnityEvent : UnityEvent<float> { }

	/// <summary>
	/// Event inheritance for double argument.
	/// </summary>
	[System.Serializable]
	public sealed class DoubleUnityEvent : UnityEvent<double> { }

	/// <summary>
	/// Event inheritance for a string-argument.
	/// </summary>
	[System.Serializable]
	public sealed class StringUnityEvent : UnityEvent<string> { }
	#endregion

	#region Vectors
	/// <summary>
	/// Event inheritance for Vector2 argument.
	/// </summary>
	[System.Serializable]
	public sealed class Vector2UnityEvent : UnityEvent<Vector2> { }

	/// <summary>
	/// Event inheritance for Vector3 argument.
	/// </summary>
	[System.Serializable]
	public sealed class Vector3UnityEvent : UnityEvent<Vector3> { }

	/// <summary>
	/// Event inheritance for Vector4 argument.
	/// </summary>
	[System.Serializable]
	public sealed class Vector4UnityEvent : UnityEvent<Vector4> { }

	/// <summary>
	/// Event inheritance for Vector2Int argument.
	/// </summary>
	[System.Serializable]
	public sealed class Vector2IntUnityEvent : UnityEvent<Vector2Int> { }

	/// <summary>
	/// Event inheritance for Vector3Int argument.
	/// </summary>
	[System.Serializable]
	public sealed class Vector3IntUnityEvent : UnityEvent<Vector3Int> { }

	/// <summary>
	/// Event inheritance for Quaternion argument.
	/// </summary>
	[System.Serializable]
	public sealed class QuaternionUnityEvent : UnityEvent<Quaternion> { }
	#endregion

	#region Unity
	/// <summary>
	/// Event inheritance for GameObject argument.
	/// </summary>
	[System.Serializable]
	public sealed class GameObjectUnityEvent: UnityEvent<GameObject> { }

	/// <summary>
	/// Event inheritance for Transform argument.
	/// </summary>
	[System.Serializable]
	public sealed class TransformUnityEvent : UnityEvent<Transform> { }

	/// <summary>
	/// Event inheritance for Sprite argument.
	/// </summary>
	[System.Serializable]
	public sealed class SpriteUnityEvent : UnityEvent<Sprite> { }
	#endregion
}
