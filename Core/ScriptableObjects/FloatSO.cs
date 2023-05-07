// #DataStructScript

using UnityEngine;

namespace Fierclash.Core
{
	/// <summary>
	/// ScriptableObject containing float data.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[CreateAssetMenu(fileName = "FloatSO_", menuName = "Fierclash/Data Struct/float")]
	public sealed class FloatSO : BaseSO<float> { }
}
