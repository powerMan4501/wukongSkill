using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_BeAttackPerformData
{
	private static int MaxSize = 8;

	public Dictionary<RenderTargetType, Dictionary<int, RTParams>> RTParamsList;

	private Dictionary<RenderTargetType, LinkedList<int>> RTParamsTimeSequencer;

	public bool bBeHitFXNeedAttach;

	public BUC_BeAttackPerformData()
	{
		Init();
	}

	public void Init()
	{
		RTParamsList = new Dictionary<RenderTargetType, Dictionary<int, RTParams>>
		{
			{
				RenderTargetType.BeAttacked,
				new Dictionary<int, RTParams>()
			},
			{
				RenderTargetType.TTTB,
				new Dictionary<int, RTParams>()
			}
		};
		RTParamsTimeSequencer = new Dictionary<RenderTargetType, LinkedList<int>>
		{
			{
				RenderTargetType.BeAttacked,
				new LinkedList<int>()
			},
			{
				RenderTargetType.TTTB,
				new LinkedList<int>()
			}
		};
	}

	public int SetRTParams(RenderTargetType RTType, FTransform _HitTransform, float _Strength, float _BeginAnimTime, float _Duration, FVector _HitDir)
	{
		if (RTParamsList[RTType].Count < MaxSize)
		{
			List<int> list = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 };
			foreach (int key2 in RTParamsList[RTType].Keys)
			{
				if (list.Contains(key2))
				{
					list.Remove(key2);
				}
			}
			if (list.Count > 0)
			{
				int num = list[0];
				RTParamsList[RTType].Add(num, new RTParams
				{
					RemainingUpdateTime = _Duration,
					HitTransform = _HitTransform,
					Strength = _Strength,
					BeginAnimTime = _BeginAnimTime,
					HitDir = _HitDir
				});
				if (RTParamsTimeSequencer[RTType].Find(num) == null)
				{
					RTParamsTimeSequencer[RTType].AddLast(num);
				}
				return num;
			}
		}
		else
		{
			foreach (KeyValuePair<int, RTParams> item in RTParamsList[RTType])
			{
				int key = item.Key;
				if (!(item.Value.RemainingUpdateTime <= 0f))
				{
					continue;
				}
				RTParamsList[RTType][key] = new RTParams
				{
					RemainingUpdateTime = _Duration,
					HitTransform = _HitTransform,
					Strength = _Strength,
					BeginAnimTime = _BeginAnimTime,
					HitDir = _HitDir
				};
				for (int i = 0; i < RTParamsTimeSequencer[RTType].Count; i++)
				{
					LinkedListNode<int> linkedListNode = RTParamsTimeSequencer[RTType].Find(i);
					if (linkedListNode != null && linkedListNode.Value == key)
					{
						RTParamsTimeSequencer[RTType].Remove(i);
						break;
					}
				}
				RTParamsTimeSequencer[RTType].AddLast(key);
				return key;
			}
			int value = RTParamsTimeSequencer[RTType].First.Value;
			if (RTParamsList[RTType].TryGetValue(value, out var value2))
			{
				value2.RemainingUpdateTime = _Duration;
				value2.HitTransform = _HitTransform;
				value2.Strength = _Strength;
				value2.BeginAnimTime = _BeginAnimTime;
				value2.HitDir = _HitDir;
				RTParamsList[RTType][value] = value2;
				RTParamsTimeSequencer[RTType].RemoveFirst();
				RTParamsTimeSequencer[RTType].AddLast(value);
				return value;
			}
		}
		return -1;
	}
}
