using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using b1.Prediction;

namespace b1;

public class GSBindList<T> : IPredictableObject, IEnumerable<T>, IEnumerable
{
	private class ElementDelta
	{
		public T Delta;

		public int EleIdx;

		public int DeltaIndex;

		public int ValueListIdx;

		public EPredictCollectionOPType OPType;
	}

	public Action OnClear;

	public List<T> ValueList = new List<T>();

	public bool PredictElementOperable;

	protected int PredictDeltaIndexAloc;

	protected int PredictEleIndexAloc;

	protected bool Predictable;

	private GSPredictionKey ConfirmingPredictionKey;

	private Dictionary<int, List<ElementDelta>> PredictionDeltaList;

	private List<int> EleIndexList;

	private List<List<int>> LastPredictIndexList;

	public int Count => ValueList.Count;

	public bool IsReadOnly { get; private set; }

	public T this[int Index]
	{
		get
		{
			return ValueList[Index];
		}
		set
		{
			if (!object.Equals(ValueList[Index], value))
			{
				T arg = ValueList[Index];
				ValueList[Index] = value;
				this.OnSetIdxValue?.Invoke(Index, arg, value);
			}
		}
	}

	public event Action<int, T, T> OnSetIdxValue;

	public event Action<T> OnAdd;

	public event Action<int, T> OnRemove;

	public bool IsEmpty()
	{
		return ValueList.Count == 0;
	}

	public void BindConfirmingPredictionKey(GSPredictionKey ConfirmingPredictionKey)
	{
		this.ConfirmingPredictionKey = ConfirmingPredictionKey;
		if (!PredictElementOperable)
		{
			return;
		}
		foreach (KeyValuePair<int, List<ElementDelta>> predictionDelta in PredictionDeltaList)
		{
			foreach (ElementDelta item in predictionDelta.Value)
			{
				for (int i = 0; i < EleIndexList.Count; i++)
				{
					if (EleIndexList[i] == item.EleIdx)
					{
						dynamic val = item.Delta;
						val += ValueList[i];
						ValueList[i] = val;
					}
				}
			}
		}
	}

	public void AddRange(GSBindList<T> collection)
	{
		foreach (T item in collection)
		{
			Add(item);
		}
	}

	public void UnBindConfirmingPredictionKey()
	{
		ConfirmingPredictionKey = null;
		if (!PredictElementOperable)
		{
			return;
		}
		foreach (KeyValuePair<int, List<ElementDelta>> predictionDelta in PredictionDeltaList)
		{
			foreach (ElementDelta item in predictionDelta.Value)
			{
				for (int i = 0; i < EleIndexList.Count; i++)
				{
					if (EleIndexList[i] == item.EleIdx)
					{
						dynamic val = item.Delta;
						val = ValueList[i] - val;
						ValueList[i] = val;
					}
				}
			}
		}
	}

	public GSBindList(bool Predictable = false, bool PredictElementOperable = false)
	{
		this.Predictable = Predictable;
		this.PredictElementOperable = PredictElementOperable;
		if (Predictable)
		{
			EleIndexList = new List<int>();
			LastPredictIndexList = new List<List<int>>();
		}
	}

	public void InitialListLength(int ListLength)
	{
		ValueList = new T[ListLength].ToList();
	}

	public void ClearByRemove()
	{
		T[] array = ValueList.ToArray();
		foreach (T oneItem in array)
		{
			Remove(oneItem);
		}
	}

	public void Clear()
	{
		OnClear?.Invoke();
		ValueList.Clear();
		if (Predictable)
		{
			EleIndexList.Clear();
		}
	}

	public bool Contains(T OneItem)
	{
		return ValueList.Contains(OneItem);
	}

	public void CopyTo(T[] Array, int ArrayIndex)
	{
		ValueList.CopyTo(Array, ArrayIndex);
	}

	private void PriditionChg(GSPredictionKey PredictionKey, int Index, T OneItem, EPredictCollectionOPType OPType)
	{
		if (!Predictable)
		{
			throw new Exception("Predict Change On Unpredictable List!!!");
		}
		BGW_LogUtil.LogError($"GSBindList PricitionChg {Index} {OneItem} {PredictionKey}");
		PredictionKey.AddRelatedObject(this);
		if (PredictionDeltaList == null)
		{
			PredictionDeltaList = new Dictionary<int, List<ElementDelta>>();
		}
		if (!PredictionDeltaList.TryGetValue(PredictionKey.Id, out var value))
		{
			value = new List<ElementDelta>();
			PredictionDeltaList[PredictionKey.Id] = value;
		}
		dynamic val = OneItem;
		if (PredictElementOperable)
		{
			val = ValueList[Index] - val;
		}
		ElementDelta item = new ElementDelta
		{
			EleIdx = EleIndexList[Index],
			Delta = val,
			OPType = OPType,
			DeltaIndex = ++PredictDeltaIndexAloc,
			ValueListIdx = Index
		};
		value.Add(item);
		LastPredictIndexList[Index].Add(PredictDeltaIndexAloc);
	}

	public void Add(T OneItem, GSPredictionKey PredictionKey = null)
	{
		if (PredictionKey != null)
		{
			throw new Exception("GSBindList Not Support Add Predict Now");
		}
		ValueList.Add(OneItem);
		if (Predictable)
		{
			PredictEleIndexAloc++;
			EleIndexList.Add(PredictEleIndexAloc);
			LastPredictIndexList.Add(new List<int>());
		}
		this.OnAdd?.Invoke(OneItem);
	}

	public bool Remove(T OneItem, GSPredictionKey PredictionKey = null)
	{
		for (int i = 0; i < ValueList.Count; i++)
		{
			if (ValueList[i].Equals(OneItem))
			{
				if (PredictionKey != null)
				{
					throw new Exception("GSBindList Not Support Remove Predict Now");
				}
				ValueList.RemoveAt(i);
				if (Predictable)
				{
					EleIndexList.RemoveAt(i);
					LastPredictIndexList.RemoveAt(i);
				}
				this.OnRemove?.Invoke(i, OneItem);
				return true;
			}
		}
		return false;
	}

	public void RemoveAt(int Index, GSPredictionKey PredictionKey = null)
	{
		T arg = ValueList[Index];
		if (PredictionKey != null)
		{
			throw new Exception("GSBindList Not Support Remove Predict Now");
		}
		ValueList.RemoveAt(Index);
		if (Predictable)
		{
			EleIndexList.RemoveAt(Index);
			LastPredictIndexList.RemoveAt(Index);
		}
		this.OnRemove?.Invoke(Index, arg);
	}

	public void Set(int Index, T OneItem, GSPredictionKey PredictionKey = null)
	{
		if (PredictionKey != null)
		{
			PriditionChg(PredictionKey, Index, OneItem, EPredictCollectionOPType.Modify);
		}
		this[Index] = OneItem;
	}

	public int IndexOf(T OneItem)
	{
		return ValueList.IndexOf(OneItem);
	}

	public int FindIndex(Predicate<T> match)
	{
		return ValueList.FindIndex(match);
	}

	public void OnRollback(GSPredictionKey PredictionKey)
	{
		BGW_LogUtil.LogError($"GSBindList OnRollback Begin {PredictionKey} {this}");
		if (!PredictionDeltaList.TryGetValue(PredictionKey.Id, out var value))
		{
			return;
		}
		foreach (ElementDelta item in value)
		{
			for (int i = 0; i < EleIndexList.Count; i++)
			{
				if (EleIndexList[i] != item.EleIdx)
				{
					continue;
				}
				dynamic val = item.Delta;
				if (PredictElementOperable)
				{
					val += ValueList[i];
				}
				else
				{
					if (LastPredictIndexList[i][LastPredictIndexList[i].Count - 1] != item.DeltaIndex)
					{
						val = ValueList[i];
					}
					LastPredictIndexList[i].Remove(item.DeltaIndex);
				}
				ValueList[i] = val;
			}
		}
		PredictionDeltaList.Remove(PredictionKey.Id);
		BGW_LogUtil.LogError($"GSBindList OnRollback End {PredictionKey} {this}");
	}

	public void OnConfirm(GSPredictionKey PredictionKey)
	{
		OnRollback(PredictionKey);
	}

	public IEnumerator<T> GetEnumerator()
	{
		return ValueList.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ValueList.GetEnumerator();
	}

	public override string ToString()
	{
		string text = "{ ";
		using (IEnumerator<T> enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				T current = enumerator.Current;
				text = ((text.Length > 2) ? $"{text},{current}" : $"{text}{current}");
			}
		}
		return text + " }";
	}
}
