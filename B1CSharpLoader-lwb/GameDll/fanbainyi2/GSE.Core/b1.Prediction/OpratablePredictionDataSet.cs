using System;
using System.Collections.Generic;

namespace b1.Prediction;

public class OpratablePredictionDataSet<T> : IPredictableObject
{
	private Dictionary<int, OpratablePredictionDataDeltaOne<T>> DeltaData = new Dictionary<int, OpratablePredictionDataDeltaOne<T>>();

	public Action<T, bool> ActionOnPredictionChg;

	public void OnConfirm(GSPredictionKey PredictionKey)
	{
		OnRollback(PredictionKey);
	}

	public void AddPrediction(GSPredictionKey PredictionKey, T Delta)
	{
		if (!DeltaData.TryGetValue(PredictionKey.Id, out var value))
		{
			value = new OpratablePredictionDataDeltaOne<T>();
			DeltaData[PredictionKey.Id] = value;
		}
		value.Delta.Add(Delta);
		PredictionKey.AddRelatedObject(this);
		ActionOnPredictionChg?.Invoke(GetFinalPredictionDelta(), HasPrediction());
	}

	public void OnRollback(GSPredictionKey PredictionKey)
	{
		if (DeltaData.Remove(PredictionKey.Id))
		{
			ActionOnPredictionChg?.Invoke(GetFinalPredictionDelta(), HasPrediction());
		}
	}

	public bool HasPrediction()
	{
		return DeltaData.Count > 0;
	}

	public T GetFinalPredictionDelta()
	{
		bool flag = false;
		T val = default(T);
		foreach (KeyValuePair<int, OpratablePredictionDataDeltaOne<T>> deltaDatum in DeltaData)
		{
			foreach (T deltum in deltaDatum.Value.Delta)
			{
				if (!flag)
				{
					val = deltum;
					flag = true;
				}
				else
				{
					dynamic val2 = val;
					val2 += deltum;
					val = val2;
				}
			}
		}
		return val;
	}
}
