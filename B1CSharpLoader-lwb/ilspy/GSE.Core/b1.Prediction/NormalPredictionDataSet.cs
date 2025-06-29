using System;
using System.Collections.Generic;

namespace b1.Prediction;

public class NormalPredictionDataSet<T> : IPredictableObject
{
	private Dictionary<int, NormalPredictionDataDeltaOne<T>> Datas = new Dictionary<int, NormalPredictionDataDeltaOne<T>>();

	private List<NormalPredictionDataDeltaOne<T>> DataQueue = new List<NormalPredictionDataDeltaOne<T>>();

	public Action<T, bool> ActionOnPredictionChg;

	public void OnConfirm(GSPredictionKey PredictionKey)
	{
		OnRollback(PredictionKey);
	}

	public void AddPrediction(GSPredictionKey PredictionKey, T Value)
	{
		if (!Datas.TryGetValue(PredictionKey.Id, out var value))
		{
			value = new NormalPredictionDataDeltaOne<T>();
			Datas[PredictionKey.Id] = value;
			DataQueue.Add(value);
		}
		value.Value.Add(Value);
		ActionOnPredictionChg?.Invoke(GetFinalPredictionData(), HasPrediction());
		PredictionKey.AddRelatedObject(this);
	}

	public void OnRollback(GSPredictionKey PredictionKey)
	{
		if (Datas.ContainsKey(PredictionKey.Id))
		{
			DataQueue.Remove(Datas[PredictionKey.Id]);
			Datas.Remove(PredictionKey.Id);
			ActionOnPredictionChg?.Invoke(GetFinalPredictionData(), HasPrediction());
		}
	}

	public bool HasPrediction()
	{
		return Datas.Count > 0;
	}

	public T GetFinalPredictionData()
	{
		if (HasPrediction())
		{
			List<T> value = DataQueue[DataQueue.Count - 1].Value;
			return value[value.Count - 1];
		}
		return default(T);
	}
}
