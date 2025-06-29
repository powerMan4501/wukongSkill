using System;
using System.Collections.Generic;

namespace b1;

public class BUC_MovementModes
{
	private Dictionary<Type, BUC_MoveModeBase> Movers = new Dictionary<Type, BUC_MoveModeBase>();

	public BUS_MovementSystem Parent { get; set; }

	public BUC_MoveModeBase ActiveMover { get; set; }

	private T CreateMoveMode<T>() where T : BUC_MoveModeBase, new()
	{
		T val = new T();
		val.Init(Parent);
		return val;
	}

	public T GetMoveMode<T>() where T : BUC_MoveModeBase, new()
	{
		if (Movers.TryGetValue(typeof(T), out var value))
		{
			return value as T;
		}
		T val = CreateMoveMode<T>();
		if (val == null)
		{
			return null;
		}
		Movers.Add(typeof(T), val);
		return val;
	}

	public void ReleaseMoveMode()
	{
		foreach (KeyValuePair<Type, BUC_MoveModeBase> mover in Movers)
		{
			mover.Value?.Release();
		}
		Movers.Clear();
	}
}
