using System.Collections.Generic;

namespace b1;

public class BPC_PredictionKeyServerStateData : IBPC_PredictionKeyServerStateData
{
	private const float PREDICTIONKEY_CACHE_TIME = 5f;

	private Dictionary<int, KeyServerState> PredictionKeyStates = new Dictionary<int, KeyServerState>();

	private static List<int> sPredicntionKetRemoveCache = new List<int>();

	public void AddPredictionKeyState(int KeyId, EPredictionKeyServerState State)
	{
		if (!PredictionKeyStates.ContainsKey(KeyId))
		{
			PredictionKeyStates[KeyId] = new KeyServerState
			{
				State = State,
				CacheTimeLeft = 5f
			};
		}
		else
		{
			BGW_LogUtil.LogError($"{KeyId} Add State MultiTimes {State} {PredictionKeyStates[KeyId].State}");
		}
	}

	public EPredictionKeyServerState GetPrediciotnKeyState(int PredictionKeyId)
	{
		if (PredictionKeyStates.TryGetValue(PredictionKeyId, out var value))
		{
			return value.State;
		}
		return EPredictionKeyServerState.Unknow;
	}

	public void TickRemovePredictionKey(float DeltaTime)
	{
		sPredicntionKetRemoveCache.Clear();
		foreach (KeyValuePair<int, KeyServerState> predictionKeyState in PredictionKeyStates)
		{
			predictionKeyState.Value.CacheTimeLeft -= DeltaTime;
			if (predictionKeyState.Value.CacheTimeLeft <= 0f)
			{
				sPredicntionKetRemoveCache.Add(predictionKeyState.Key);
			}
		}
		foreach (int item in sPredicntionKetRemoveCache)
		{
			PredictionKeyStates.Remove(item);
		}
	}
}
