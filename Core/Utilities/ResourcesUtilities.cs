// #LogicScript

using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Fierclash.Core
{
	/// <summary>
	/// Loads SOs from the Resource folder.
	/// </summary>
    public static class ResourcesUtilities
    {
		/// <summary>
		/// Loads a ScriptableObject.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="path"></param>
		/// <returns></returns>
		public static T LoadSO<T>(string path) where T : ScriptableObject
		{
			// Retrieve SO from Resources folder
			T SO = Resources.Load(path) as T;
			if (SO == null)
			{
				Debug.LogError($"Could not load ScriptableObject at Assets/Resources/{path}.");
				return null;
			}

			Debug.Log($"Loaded SO from Assets/Resources/{path}.");
			return SO;
		}

		/// <summary>
		/// Loads a list of ScriptableObjects.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="path"></param>
		/// <returns></returns>
		public static T[] LoadSOAll<T>(string path) where T : ScriptableObject
		{
			// Retrieve SO from Resources folder
			object[] objects = Resources.LoadAll(path);
			if (objects == null || objects.Length == 0)
			{
				Debug.LogError($"Could not load ScriptableObjects at Assets/Resources/{path}.");
				return null;
			}

			// Convert objects to TaskToolLinkSOs
			Debug.Log($"Loaded SOs from Assets/Resources/{path}.");
			T[] SOs = objects.Cast<T>().ToArray();
			return SOs;
		}

		/// <summary>
		/// Unloads a list of ScriptableObjects
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="SOs"></param>
		public static void UnloadSOAll<T>(List<T> SOs) where T : ScriptableObject
		{
			foreach (T SO in SOs)
			{
				Resources.UnloadAsset(SO);
			}
			Debug.Log($"Unloaded list of SOs.");
		}
	}
}
