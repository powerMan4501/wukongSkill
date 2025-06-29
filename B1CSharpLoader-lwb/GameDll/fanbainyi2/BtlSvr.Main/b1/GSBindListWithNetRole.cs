using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using b1.Prediction;

namespace b1;

public class GSBindListWithNetRole<T> : IPredictableObject, IEnumerable<T>, IEnumerable
{
	private EGSBindRepType[] StateRepFlag;

	private int NetRole;

	private GSBindList<T> BindList { get; set; }

	private List<Action<int, T, T>> BindOneList { get; set; }

	public string DebugStr { get; set; }

	public int Count => BindList.Count;

	public T this[int Index]
	{
		get
		{
			return BindList[Index];
		}
		set
		{
			SetByNetMode(Index, value);
		}
	}

	public GSBindList<T> RawData => BindList;

	public event Action<int, T, T> OnSetIdxValue;

	public void FreshNetRole(int NewNetRole)
	{
		NetRole = NewNetRole;
	}

	public GSBindListWithNetRole(EGSBindRepType[] StateRepFlag = null, int NetRole = 0, bool Predictable = false, bool PredictElementOperable = false)
	{
		BindList = new GSBindList<T>(Predictable, PredictElementOperable);
		BindOneList = new Action<int, T, T>[StateRepFlag.Count()].ToList();
		BindList.InitialListLength(StateRepFlag.Count());
		BindList.OnSetIdxValue += OnGSBindListWithNetRoleSetIdxValue;
		this.StateRepFlag = StateRepFlag;
		this.NetRole = NetRole;
	}

	private void OnGSBindListWithNetRoleSetIdxValue(int idx, T oldVal, T newVal)
	{
		this.OnSetIdxValue?.Invoke(idx, oldVal, newVal);
		if (BindOneList.Count > idx)
		{
			BindOneList[idx]?.Invoke(idx, oldVal, newVal);
		}
	}

	public EGSBindRepType GetReplicateType(int Index)
	{
		if (StateRepFlag == null || StateRepFlag.Length <= Index)
		{
			return EGSBindRepType.ServerAuthority;
		}
		return StateRepFlag[Index];
	}

	public bool IsEmpty()
	{
		return Count == 0;
	}

	public bool SetByNetMode(int Index, T OneItem)
	{
		int netRole = NetRole;
		bool result = false;
		if ((netRole & 4) <= 0 && (netRole & 8) <= 0)
		{
			BindList[Index] = OneItem;
			return true;
		}
		if (StateRepFlag != null && StateRepFlag.Length > Index)
		{
			switch (StateRepFlag[Index])
			{
			case EGSBindRepType.ServerAuthority:
				if ((netRole & 0x80) > 0)
				{
					BindList[Index] = OneItem;
					result = true;
				}
				break;
			case EGSBindRepType.Local:
				BindList[Index] = OneItem;
				result = true;
				break;
			}
		}
		return result;
	}

	public IEnumerator<T> GetEnumerator()
	{
		return BindList.ValueList.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return BindList.ValueList.GetEnumerator();
	}

	public void OnRollback(GSPredictionKey PredictionKey)
	{
		BindList.OnRollback(PredictionKey);
	}

	public void OnConfirm(GSPredictionKey PredictionKey)
	{
		BindList.OnConfirm(PredictionKey);
	}

	public T GetValue(int Index)
	{
		return BindList[Index];
	}

	public void BindOnSetIdxValue(Action<int, T, T> Action)
	{
		BindList.OnSetIdxValue += Action;
	}

	public void UnBindOnSetIdxValue(Action<int, T, T> Action)
	{
		BindList.OnSetIdxValue -= Action;
	}

	public void BindOneValueChange(int BindId, Action<int, T, T> Action)
	{
		List<Action<int, T, T>> bindOneList = BindOneList;
		bindOneList[BindId] = (Action<int, T, T>)Delegate.Combine(bindOneList[BindId], Action);
	}

	public void UnBindOneValueChange(int BindId, Action<int, T, T> Action)
	{
		List<Action<int, T, T>> bindOneList = BindOneList;
		bindOneList[BindId] = (Action<int, T, T>)Delegate.Remove(bindOneList[BindId], Action);
	}
}
