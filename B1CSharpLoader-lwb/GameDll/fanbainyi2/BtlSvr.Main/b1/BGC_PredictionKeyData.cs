using System;
using System.Collections.Generic;
using b1.ECS;
using b1.Prediction;
using UnrealEngine.Engine;

namespace b1;

public class BGC_PredictionKeyData : IBGC_PredictionKeyData, IPersistentECSData
{
	public int PredictionKeyAlloc = 1;

	public Dictionary<int, GSPredictionKey> PredictionKeySet = new Dictionary<int, GSPredictionKey>();

	public Stack<GSPredictionKey> PredictingingPredictionKeyStack = new Stack<GSPredictionKey>();

	public Stack<EPredictionState> PredictionState = new Stack<EPredictionState>();

	public IntPtr ActiveFunctionAddr = IntPtr.Zero;

	public static Dictionary<string, IntPtr> sPredictableFunctionCache = new Dictionary<string, IntPtr>();

	public APlayerState PridictOriginator;

	public GSPredictionKey ConfirmmingPredictionKey { get; set; }

	public GSPredictionKey PredictingingPredictionKey
	{
		get
		{
			if (PredictingingPredictionKeyStack.Count == 0)
			{
				return null;
			}
			return PredictingingPredictionKeyStack.Peek();
		}
	}

	public bool ServerRecvingOrClientCueing()
	{
		foreach (EPredictionState item in PredictionState)
		{
			if (item == EPredictionState.ClientCueing || item == EPredictionState.ServerRecving)
			{
				return true;
			}
		}
		return false;
	}

	public bool ServerRecving()
	{
		foreach (EPredictionState item in PredictionState)
		{
			if (item == EPredictionState.ServerRecving)
			{
				return true;
			}
		}
		return false;
	}

	public bool ClientPredicting()
	{
		foreach (EPredictionState item in PredictionState)
		{
			if (item == EPredictionState.ClientPredicting)
			{
				return true;
			}
		}
		return false;
	}
}
