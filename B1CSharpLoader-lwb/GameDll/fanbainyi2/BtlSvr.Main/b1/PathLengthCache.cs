using System;
using System.Collections.Generic;

namespace b1;

public class PathLengthCache
{
	private Dictionary<(int, int), float> LengthCache;

	private LinkedList<(int, int)> LRUList;

	private int Capacity;

	public PathLengthCache(int capacity)
	{
		Capacity = capacity;
		LengthCache = new Dictionary<(int, int), float>();
		LRUList = new LinkedList<(int, int)>();
	}

	public bool ContainsKey(int StartPoly, int EndPoly)
	{
		return LengthCache.ContainsKey((StartPoly, EndPoly));
	}

	public float GetOrAddPathLength(int StartPoly, int EndPoly, Func<float> computePathLength)
	{
		if (LengthCache.ContainsKey((StartPoly, EndPoly)))
		{
			LRUList.Remove((StartPoly, EndPoly));
			LRUList.AddFirst((StartPoly, EndPoly));
			return LengthCache[(StartPoly, EndPoly)];
		}
		float num = computePathLength();
		if (LengthCache.Count >= Capacity)
		{
			(int, int) value = LRUList.Last.Value;
			LengthCache.Remove(value);
			LRUList.RemoveLast();
		}
		LengthCache[(StartPoly, EndPoly)] = num;
		LRUList.AddFirst((StartPoly, EndPoly));
		return num;
	}

	public void Clear()
	{
		LengthCache.Clear();
		LRUList.Clear();
	}
}
