// #FrameworkScript

using System.Collections.Generic;
using UnityEngine;

namespace Fierclash.Core
{
	/// <summary>
	/// Interface for load control.
	/// </summary>
	public interface ILoad
	{
		public void Load();
	}

	/// <summary>
	/// Interface for unload control.
	/// </summary>
	public interface IUnload
	{
		public void Unload();
	}

	/// <summary>
	/// MonoBehaviour framework for load logic.
	/// </summary>
	public abstract class LoaderBehaviour : MonoBehaviour, ILoad, IUnload
	{
		/// <summary>
		/// Loads data..
		/// </summary>
		public abstract void Load();

		/// <summary>
		/// Unloads data.
		/// </summary>
		public abstract void Unload();
	}
}