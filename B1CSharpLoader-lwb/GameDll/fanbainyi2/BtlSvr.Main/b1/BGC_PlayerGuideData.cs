using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using b1.ECS;
using BtlShare;
using GUR.Runtime;

namespace b1;

public class BGC_PlayerGuideData : IBGC_PlayerGuideData, IPersistentECSData
{
	private class FGuideGroupFinishTracker
	{
		public readonly EGuideGroupType GuideGroupType;

		public readonly List<FUStGuideNodeDesc> NodeDescList;

		private readonly EGuideGroupFinishType _finishType;

		private float _timer;

		private const float ChecklistCompleteTime = 12f;

		private Dictionary<int, List<int>> CacheFinishParam_CastSkill;

		public FGuideGroupFinishTracker(FUStGuideGroupDesc Desc)
		{
			GuideGroupType = Desc.GuideGroupType;
			_finishType = ((Desc.IsShowHud != EGSYesNo.Yes) ? EGuideGroupFinishType.CountDown : Desc.FinishType);
			NodeDescList = Desc.GuideId.Select(GameDBRuntime.GetGuideNodeDesc).ToList();
			_timer = ((Desc.IsShowHud != EGSYesNo.Yes) ? 0f : ((_finishType == EGuideGroupFinishType.CountDown) ? ((float)Desc.FinishParam) : ((_finishType == EGuideGroupFinishType.ChecklistCompleted) ? 12f : 0f)));
			CacheFinishParam_CastSkill = new Dictionary<int, List<int>>();
			foreach (FUStGuideNodeDesc nodeDesc in NodeDescList)
			{
				if (nodeDesc.FinishType == EGuideNodeFinishType.CastSkill)
				{
					CacheFinishParam_CastSkill.Add(nodeDesc.ID, ExtractNumbers(nodeDesc.FinishParam));
				}
			}
		}

		public bool Update(float DeltaTime)
		{
			if (_finishType == EGuideGroupFinishType.CountDown || _finishType == EGuideGroupFinishType.ChecklistCompleted)
			{
				_timer -= DeltaTime;
				if (_timer < 0f)
				{
					NodeDescList.Clear();
					return true;
				}
			}
			if (!NodeDescList.Any())
			{
				return true;
			}
			return false;
		}

		public void TriggerFinishEvent(EGuideNodeFinishType NodeFinishType, out List<int> FinishedGuideNodeList, out bool IsFinishGuideGroup)
		{
			if (_finishType == EGuideGroupFinishType.ChecklistCompleted)
			{
				FinishedGuideNodeList = (from Desc in NodeDescList
					where Desc.FinishType == NodeFinishType
					select Desc.ID).ToList();
				NodeDescList.RemoveAll((FUStGuideNodeDesc Desc) => Desc.FinishType == NodeFinishType);
				IsFinishGuideGroup = !NodeDescList.Any();
			}
			else
			{
				FinishedGuideNodeList = new List<int>();
				IsFinishGuideGroup = false;
			}
		}

		public void TriggerFinishEvent_WithIntParam(EGuideNodeFinishType NodeFinishType, int IntParam, out List<int> FinishedGuideNodeList, out bool IsFinishGuideGroup)
		{
			if (_finishType == EGuideGroupFinishType.ChecklistCompleted && NodeFinishType == EGuideNodeFinishType.CastSkill)
			{
				List<int> TempFinishedGuideNodeList = (from Desc in NodeDescList
					where Desc.FinishType == NodeFinishType && CacheFinishParam_CastSkill[Desc.ID].Contains(IntParam)
					select Desc.ID).ToList();
				FinishedGuideNodeList = TempFinishedGuideNodeList;
				NodeDescList.RemoveAll((FUStGuideNodeDesc Desc) => TempFinishedGuideNodeList.Contains(Desc.ID));
				IsFinishGuideGroup = !NodeDescList.Any();
			}
			else
			{
				FinishedGuideNodeList = new List<int>();
				IsFinishGuideGroup = false;
			}
		}

		private List<int> ExtractNumbers(string InputString)
		{
			List<int> list = new List<int>();
			bool num = new Regex("^\\d+(?:-\\d+)*$").IsMatch(InputString);
			GSEUtil.Check(num, "教学点完成参数" + InputString + "不符合规范（使用‘-’分隔数字）！！！");
			if (num)
			{
				string[] array = InputString.Split('-');
				for (int i = 0; i < array.Length; i++)
				{
					if (int.TryParse(array[i], out var result))
					{
						list.Add(result);
					}
				}
			}
			return list;
		}
	}

	private BindListInt __FinishedGroupGuideList_Raw;

	private Dictionary<int, FGuideGroupFinishTracker> GuideGroupFinishTrackers { get; }

	public BindListInt CheckListNodeGuideList { get; set; }

	public BindListInt ProceedGroupGuideList { get; set; }

	[GSPersistent(MarkDelaySaveArchiveSource = "FinishPlayerGuide")]
	public BindListInt FinishedGroupGuideList
	{
		get
		{
			return __FinishedGroupGuideList_Raw;
		}
		set
		{
			BindListInt _FinishedGroupGuideList_Raw = __FinishedGroupGuideList_Raw;
			__FinishedGroupGuideList_Raw = value;
			OnFinishedGroupGuideListChg_Invoke(_FinishedGroupGuideList_Raw, value);
		}
	}

	public event Action<BindListInt, BindListInt> OnFinishedGroupGuideListChg;

	public BGC_PlayerGuideData()
	{
		GuideGroupFinishTrackers = new Dictionary<int, FGuideGroupFinishTracker>();
		FinishedGroupGuideList = new BindListInt();
		CheckListNodeGuideList = new BindListInt();
		ProceedGroupGuideList = new BindListInt();
	}

	public void RevertCurrentProceedGuide()
	{
		PrintData("RevertCurrentProceedGuide");
		foreach (int proceedGroupGuide in ProceedGroupGuideList)
		{
			FinishedGroupGuideList.Remove(proceedGroupGuide);
			GuideGroupFinishTrackers.Remove(proceedGroupGuide);
		}
		ProceedGroupGuideList.ClearByRemove();
		CheckListNodeGuideList.ClearByRemove();
	}

	public void PrintData(string Reason)
	{
	}

	public void RemoveTracker(FUStGuideGroupDesc Desc, out List<int> OutFinishedGuideGroupIdList)
	{
		OutFinishedGuideGroupIdList = new List<int>();
		if (GuideGroupFinishTrackers.ContainsKey(Desc.ID))
		{
			return;
		}
		OutFinishedGuideGroupIdList = (from pair in GuideGroupFinishTrackers
			where pair.Value.GuideGroupType != EGuideGroupType.Pause
			select pair.Key).ToList();
		foreach (int OutFinishedGuideGroupId in OutFinishedGuideGroupIdList)
		{
			foreach (FUStGuideNodeDesc nodeDesc in GuideGroupFinishTrackers[OutFinishedGuideGroupId].NodeDescList)
			{
				CheckListNodeGuideList.Remove(nodeDesc.ID);
			}
			GuideGroupFinishTrackers.Remove(OutFinishedGuideGroupId);
		}
	}

	public void AddTracker(FUStGuideGroupDesc Desc)
	{
		if (GuideGroupFinishTrackers.ContainsKey(Desc.ID))
		{
			return;
		}
		if (Desc.IsShowHud == EGSYesNo.No)
		{
			GuideGroupFinishTrackers.Add(Desc.ID, new FGuideGroupFinishTracker(Desc));
		}
		else
		{
			if (Desc.FinishType == EGuideGroupFinishType.Confirm)
			{
				return;
			}
			GuideGroupFinishTrackers.Add(Desc.ID, new FGuideGroupFinishTracker(Desc));
			if (Desc.FinishType != EGuideGroupFinishType.ChecklistCompleted)
			{
				return;
			}
			foreach (int item in Desc.GuideId)
			{
				CheckListNodeGuideList.Add(item);
			}
		}
	}

	public void TriggerGuideNodeFinishType(EGuideNodeFinishType FinishType, out List<int> OutFinishedGuideGroupIdList)
	{
		OutFinishedGuideGroupIdList = new List<int>();
		foreach (KeyValuePair<int, FGuideGroupFinishTracker> guideGroupFinishTracker in GuideGroupFinishTrackers)
		{
			guideGroupFinishTracker.Value.TriggerFinishEvent(FinishType, out var FinishedGuideNodeList, out var IsFinishGuideGroup);
			foreach (int item in FinishedGuideNodeList)
			{
				CheckListNodeGuideList.Remove(item);
			}
			if (IsFinishGuideGroup)
			{
				OutFinishedGuideGroupIdList.Add(guideGroupFinishTracker.Key);
			}
		}
	}

	public void TriggerGuideNodeFinishType_WithIntParam(EGuideNodeFinishType FinishType, int IntParam, out List<int> OutFinishedGuideGroupIdList)
	{
		OutFinishedGuideGroupIdList = new List<int>();
		foreach (KeyValuePair<int, FGuideGroupFinishTracker> guideGroupFinishTracker in GuideGroupFinishTrackers)
		{
			guideGroupFinishTracker.Value.TriggerFinishEvent_WithIntParam(FinishType, IntParam, out var FinishedGuideNodeList, out var IsFinishGuideGroup);
			foreach (int item in FinishedGuideNodeList)
			{
				CheckListNodeGuideList.Remove(item);
			}
			if (IsFinishGuideGroup)
			{
				OutFinishedGuideGroupIdList.Add(guideGroupFinishTracker.Key);
			}
		}
	}

	public void OnTick(float DeltaTime, out List<int> OutFinishedGuideGroupIdList)
	{
		List<int> FinishedGuideGroupIdList = (from pair in GuideGroupFinishTrackers
			where pair.Value.Update(DeltaTime)
			select pair.Key).ToList();
		OutFinishedGuideGroupIdList = FinishedGuideGroupIdList;
		foreach (int OutFinishedGuideGroupId in OutFinishedGuideGroupIdList)
		{
			GuideGroupFinishTrackers.Remove(OutFinishedGuideGroupId);
		}
		foreach (int item in CheckListNodeGuideList.Where((int Id) => FinishedGuideGroupIdList.Contains(Id / 100)).ToList())
		{
			CheckListNodeGuideList.Remove(item);
		}
	}

	public bool IsGroupGuideCompleted(IList<int> InGroupGuideList)
	{
		return InGroupGuideList.All(IsGroupGuideCompleted);
	}

	public bool IsGroupGuideCompleted(int InGroupGuideId)
	{
		if (FinishedGroupGuideList.Contains(InGroupGuideId))
		{
			return !ProceedGroupGuideList.Contains(InGroupGuideId);
		}
		return false;
	}

	private void OnFinishedGroupGuideListChg_Invoke(BindListInt OldValue, BindListInt NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnFinishedGroupGuideListChg?.Invoke(OldValue, NewValue);
		}
	}
}
