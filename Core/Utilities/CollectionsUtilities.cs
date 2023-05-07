// #LogicScript

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Fierclash.Core
{
	/// <summary>
	/// Utility functions for collections.
	/// </summary>
	public static class CollectionUtilities
	{
		/// <summary>
		/// Determines if an index is within the list's range.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <param name="x"></param>
		/// <returns></returns>
		public static bool InRange<T>(this List<T> list, int x) =>
			x > -1 && x < list.Count;

		/// <summary>
		/// Determines if a bit layer is within a bit mask.
		/// </summary>
		/// <param name="mask"></param>
		/// <param name="layer"></param>
		/// <returns></returns>
		public static bool WithinBitMask(int mask, int layer) => 
			Convert.ToBoolean(mask & (1 << layer));

		/// <summary>
		/// Determines if a position is contained within a bounds.
		/// </summary>
		/// <param name="position"></param>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <param name="lower"></param>
		/// <param name="upper"></param>
		/// <returns></returns>
		public static bool WithinBounds(Vector2 position, int left, int right, int lower, int upper) =>
			position.x >= left && position.x <= right && position.y >= lower && position.y <= upper;

		/// <summary>
		/// Retrieves a random element from a list.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="list"></param>
		/// <returns></returns>
		public static T GetRandom<T>(this List<T> list)
		{
			int index = UnityEngine.Random.Range(0, list.Count);
			return list[index];
		}
	}
}
