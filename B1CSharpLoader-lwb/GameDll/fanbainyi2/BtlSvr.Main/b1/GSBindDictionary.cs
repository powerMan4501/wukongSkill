using System;
using System.Collections;
using System.Collections.Generic;
using b1.Prediction;

namespace b1;

public class GSBindDictionary<TKey, TValue> : IPredictableObject, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	private class ElementDelta
	{
		public TValue Delta;

		public TKey Key;

		public EPredictCollectionOPType OPType;

		public int DeltaIndex;
	}

	public Action<TKey, TValue> OnRemove;

	private GSPredictionKey ConfirmingPredictionKey;

	protected bool Predictable;

	protected bool PredictElementOperable;

	private const int mArrayLen = 4;

	private int mItrIdx;

	private Dictionary<TKey, int> mKey2Idx = new Dictionary<TKey, int>();

	private TKey[] mIdx2Key = new TKey[4];

	private int PredictDeltaIndexAloc;

	private Dictionary<TKey, TValue> MValueDic = new Dictionary<TKey, TValue>();

	private Dictionary<TKey, Action<TKey, TValue, TValue>> MValueChgDelDic = new Dictionary<TKey, Action<TKey, TValue, TValue>>();

	private Dictionary<int, List<ElementDelta>> PredictionDeltas;

	private Dictionary<TKey, List<int>> LastPredictionDeltas;

	public Dictionary<TKey, TValue>.KeyCollection Keys => MValueDic.Keys;

	public Dictionary<TKey, TValue> RawData
	{
		get
		{
			return MValueDic;
		}
		set
		{
			if (object.Equals(MValueDic, value))
			{
				return;
			}
			_ = MValueDic;
			MValueDic = value;
			if (mIdx2Key.Length <= MValueDic.Count)
			{
				ExpandArray();
			}
			foreach (KeyValuePair<TKey, TValue> item in MValueDic)
			{
				mKey2Idx.Add(item.Key, mKey2Idx.Count);
			}
		}
	}

	public int Count => MValueDic.Count;

	public bool IsReadOnly { get; private set; }

	public TValue this[TKey KeyItem]
	{
		get
		{
			return MValueDic[KeyItem];
		}
		set
		{
			if (MValueDic.TryGetValue(KeyItem, out var value2))
			{
				if (!object.Equals(value2, value))
				{
					MValueDic[KeyItem] = value;
					this.OnAnyValueChanged?.Invoke(KeyItem, value2, value);
					if (MValueChgDelDic.TryGetValue(KeyItem, out var value3))
					{
						value3?.Invoke(KeyItem, value2, value);
					}
				}
			}
			else
			{
				Add(KeyItem, value);
			}
		}
	}

	public event Action<TKey, TValue> OnAdd;

	public event Action<TKey, TValue, TValue> OnAnyValueChanged;

	public event Action OnClear;

	public bool IsEmpty()
	{
		return false;
	}

	public GSBindDictionary(bool Predictable = false, bool PredictElementOperable = false)
	{
		this.Predictable = Predictable;
		this.PredictElementOperable = PredictElementOperable;
		mIdx2Key = new TKey[4];
	}

	public void BindConfirmingPredictionKey(GSPredictionKey PredictionKey)
	{
		ConfirmingPredictionKey = PredictionKey;
		if (!PredictElementOperable)
		{
			return;
		}
		foreach (KeyValuePair<int, List<ElementDelta>> predictionDelta in PredictionDeltas)
		{
			foreach (ElementDelta item in predictionDelta.Value)
			{
				dynamic val = item.Delta;
				val += MValueDic[item.Key];
				MValueDic[item.Key] = val;
			}
		}
	}

	public void UnBindConfirmingPredictionKey()
	{
		ConfirmingPredictionKey = null;
		if (!PredictElementOperable)
		{
			return;
		}
		foreach (KeyValuePair<int, List<ElementDelta>> predictionDelta in PredictionDeltas)
		{
			foreach (ElementDelta item in predictionDelta.Value)
			{
				dynamic val = item.Delta;
				val = MValueDic[item.Key] - val;
				MValueDic[item.Key] = val;
			}
		}
	}

	public void Add(TKey KeyItem, TValue ValueItem)
	{
		mKey2Idx[KeyItem] = MValueDic.Count;
		if (MValueDic.Count >= mIdx2Key.Length)
		{
			ExpandArray();
		}
		mIdx2Key[MValueDic.Count] = KeyItem;
		MValueDic.Add(KeyItem, ValueItem);
		this.OnAdd?.Invoke(KeyItem, ValueItem);
	}

	public void Clear()
	{
		this.OnClear?.Invoke();
		MValueDic.Clear();
		mItrIdx = 0;
	}

	public bool ContainsKey(TKey KeyItem)
	{
		return MValueDic.ContainsKey(KeyItem);
	}

	public bool ContainsValue(TValue ValueItem)
	{
		return MValueDic.ContainsValue(ValueItem);
	}

	public bool Remove(TKey KeyItem)
	{
		if (MValueDic.ContainsKey(KeyItem))
		{
			if (mIdx2Key.Length <= MValueDic.Count)
			{
				ExpandArray();
			}
			TKey val = mIdx2Key[MValueDic.Count - 1];
			if (mKey2Idx.ContainsKey(KeyItem))
			{
				int num = mKey2Idx[KeyItem];
				mIdx2Key[num] = val;
				mIdx2Key[MValueDic.Count - 1] = default(TKey);
				mKey2Idx[val] = num;
				mKey2Idx.Remove(KeyItem);
				if (num < mItrIdx)
				{
					mItrIdx--;
				}
			}
			TValue arg = MValueDic[KeyItem];
			if (MValueDic.Remove(KeyItem))
			{
				OnRemove?.Invoke(KeyItem, arg);
				LastPredictionDeltas?.Remove(KeyItem);
				return true;
			}
		}
		return false;
	}

	public void Set(TKey KeyItem, TValue ValueItem, GSPredictionKey PredictionKey = null)
	{
		if (KeyItem == null)
		{
			return;
		}
		if (ValueItem == null)
		{
			Remove(KeyItem);
			return;
		}
		if (PredictionKey != null)
		{
			if (!ContainsKey(KeyItem))
			{
				throw new Exception("Not Allow Predict Add To Dictionary");
			}
			PredictionKey.AddRelatedObject(this);
			PriditionChg(PredictionKey, KeyItem, ValueItem, EPredictCollectionOPType.Modify);
		}
		if (ContainsKey(KeyItem))
		{
			this[KeyItem] = ValueItem;
		}
		else
		{
			Add(KeyItem, ValueItem);
		}
	}

	private void PriditionChg(GSPredictionKey PredictionKey, TKey Key, TValue Value, EPredictCollectionOPType OPType)
	{
		if (!Predictable)
		{
			throw new Exception("Predict Change On Unpredictable List!!!");
		}
		BGW_LogUtil.LogError($"GSBindDictionary PricitionChg {Key} {Value} {PredictionKey}");
		PredictionKey.AddRelatedObject(this);
		if (PredictionDeltas == null)
		{
			PredictionDeltas = new Dictionary<int, List<ElementDelta>>();
		}
		if (LastPredictionDeltas == null)
		{
			LastPredictionDeltas = new Dictionary<TKey, List<int>>();
		}
		if (!LastPredictionDeltas.TryGetValue(Key, out var value))
		{
			value = new List<int>();
		}
		if (!PredictionDeltas.TryGetValue(PredictionKey.Id, out var value2))
		{
			value2 = new List<ElementDelta>();
			PredictionDeltas[PredictionKey.Id] = value2;
		}
		dynamic val = Value;
		if (PredictElementOperable)
		{
			val = MValueDic[Key] - val;
		}
		PredictDeltaIndexAloc++;
		ElementDelta item = new ElementDelta
		{
			Key = Key,
			Delta = val,
			OPType = OPType,
			DeltaIndex = PredictDeltaIndexAloc
		};
		value.Add(PredictDeltaIndexAloc);
		value2.Add(item);
	}

	public bool TryGetValue(TKey KeyItem, out TValue OutValue)
	{
		return MValueDic.TryGetValue(KeyItem, out OutValue);
	}

	public void BindAdd(Action<TKey, TValue> ActionAdd)
	{
		OnAdd += ActionAdd;
	}

	public void UnBindAdd(Action<TKey, TValue> ActionAdd)
	{
		OnAdd -= ActionAdd;
	}

	public void BindRemove(Action<TKey, TValue> ActionRemove)
	{
		OnRemove = (Action<TKey, TValue>)Delegate.Combine(OnRemove, ActionRemove);
	}

	public void UnBindRemove(Action<TKey, TValue> ActionRemove)
	{
		OnRemove = (Action<TKey, TValue>)Delegate.Remove(OnRemove, ActionRemove);
	}

	public void BindClear(Action ActionClear)
	{
		OnClear += ActionClear;
	}

	public void UnBindClear(Action ActionClear)
	{
		OnClear -= ActionClear;
	}

	public void BindOneValueChange(TKey BindKey, Action<TKey, TValue, TValue> ActionChange)
	{
		if (!MValueChgDelDic.ContainsKey(BindKey))
		{
			MValueChgDelDic[BindKey] = ActionChange;
			return;
		}
		Dictionary<TKey, Action<TKey, TValue, TValue>> mValueChgDelDic = MValueChgDelDic;
		mValueChgDelDic[BindKey] = (Action<TKey, TValue, TValue>)Delegate.Combine(mValueChgDelDic[BindKey], ActionChange);
	}

	public void UnBindOneValueChange(TKey BindKey, Action<TKey, TValue, TValue> ActionChange)
	{
		if (MValueChgDelDic.ContainsKey(BindKey))
		{
			Dictionary<TKey, Action<TKey, TValue, TValue>> mValueChgDelDic = MValueChgDelDic;
			mValueChgDelDic[BindKey] = (Action<TKey, TValue, TValue>)Delegate.Remove(mValueChgDelDic[BindKey], ActionChange);
		}
	}

	public void BindAnyOneValueChange(Action<TKey, TValue, TValue> ActionChange)
	{
		OnAnyValueChanged += ActionChange;
	}

	public void UnBindAnyOneValueChange(Action<TKey, TValue, TValue> ActionChange)
	{
		OnAnyValueChanged -= ActionChange;
	}

	public void OnRollback(GSPredictionKey PredictionKey)
	{
		BGW_LogUtil.LogError($"GSBindDict RollBack Begin {PredictionKey} {this}");
		if (PredictionDeltas.TryGetValue(PredictionKey.Id, out var value))
		{
			foreach (ElementDelta item in value)
			{
				dynamic val = item.Delta;
				if (Predictable)
				{
					val += MValueDic[item.Key];
				}
				else
				{
					List<int> list = LastPredictionDeltas[item.Key];
					if (list[list.Count - 1] != item.DeltaIndex)
					{
						val = MValueDic[item.Key];
					}
					list.Remove(item.DeltaIndex);
				}
				MValueDic[item.Key] = val;
			}
		}
		BGW_LogUtil.LogError($"GSBindDict RollBack End {PredictionKey} {this}");
	}

	public void OnConfirm(GSPredictionKey PredictionKey)
	{
		OnRollback(PredictionKey);
	}

	public Dictionary<TKey, TValue>.Enumerator GetEnumerator()
	{
		return MValueDic.GetEnumerator();
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return MValueDic.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return MValueDic.GetEnumerator();
	}

	public override string ToString()
	{
		string text = "{ ";
		using (Dictionary<TKey, TValue>.Enumerator enumerator = GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				KeyValuePair<TKey, TValue> current = enumerator.Current;
				text = ((text.Length > 2) ? $"{text}, {current.Key}:{current.Value}" : $"{text}{current.Key}:{current.Value}");
			}
		}
		return text + " }";
	}

	public void BeginItr()
	{
		mItrIdx = 0;
	}

	public bool NextItr(ref int CurIdx, out TKey oKey, out TValue oVal)
	{
		bool result = false;
		if (CurIdx >= MValueDic.Count)
		{
			oKey = default(TKey);
			oVal = default(TValue);
		}
		else
		{
			oKey = mIdx2Key[CurIdx];
			oVal = MValueDic[oKey];
			result = true;
		}
		CurIdx++;
		return result;
	}

	public bool NextItr(out TKey oKey, out TValue oVal)
	{
		bool result = false;
		if (mItrIdx >= MValueDic.Count)
		{
			oKey = default(TKey);
			oVal = default(TValue);
		}
		else
		{
			oKey = mIdx2Key[mItrIdx];
			oVal = MValueDic[oKey];
			result = true;
		}
		mItrIdx++;
		return result;
	}

	public bool NextItr(out TValue output)
	{
		bool result = false;
		if (mItrIdx >= MValueDic.Count)
		{
			output = default(TValue);
		}
		else
		{
			TKey key = mIdx2Key[mItrIdx];
			output = MValueDic[key];
			result = true;
		}
		mItrIdx++;
		return result;
	}

	public bool Find(TKey key, out TValue output)
	{
		if (MValueDic.TryGetValue(key, out var value))
		{
			output = value;
			return true;
		}
		output = default(TValue);
		return false;
	}

	public void Remove()
	{
		if (mItrIdx > 0 && mItrIdx <= MValueDic.Count)
		{
			Remove(mIdx2Key[mItrIdx - 1]);
		}
	}

	private void ExpandArray()
	{
		TKey[] destinationArray = new TKey[MValueDic.Count + 4];
		Array.Copy(mIdx2Key, destinationArray, mIdx2Key.Length);
		mIdx2Key = destinationArray;
	}

	public int GetSize()
	{
		return MValueDic.Count;
	}
}
