using System.Collections.Generic;
using System.Text;

namespace b1;

public class UIMgrBlockHelper
{
	private readonly Dictionary<int, int> WaitAnimShowPageRefDic = new Dictionary<int, int>();

	public readonly GSBindProp<bool> IsWaitAnimShow = new GSBindProp<bool>();

	public readonly GSBindProp<bool> IsWaitNet = new GSBindProp<bool>();

	public readonly GSBindProp<bool> IsBlockInput = new GSBindProp<bool>();

	public readonly GSBindProp<bool> IsUseWhiteList = new GSBindProp<bool>();

	private List<GSUIActionEn> InputWhiteList = new List<GSUIActionEn>();

	public void RegWaitAnimShowPage(int PageId)
	{
		if (!WaitAnimShowPageRefDic.ContainsKey(PageId))
		{
			WaitAnimShowPageRefDic.Add(PageId, 1);
		}
		else
		{
			BGW_LogUtil.LogError($"[GSUIMgr] RegWaitAnimShow Duplicate, Id = {PageId}");
		}
		CheckWaitAnimShow();
	}

	public void RemoveWaitAnimShowPage(int PageId)
	{
		if (WaitAnimShowPageRefDic.ContainsKey(PageId))
		{
			WaitAnimShowPageRefDic.Remove(PageId);
		}
		CheckWaitAnimShow();
	}

	private void CheckWaitAnimShow()
	{
		IsWaitAnimShow.SetValue(EChangeReason.ManualSet, WaitAnimShowPageRefDic.Count > 0);
	}

	public bool GetIsWaitAnimShow(int PageId)
	{
		if (WaitAnimShowPageRefDic.ContainsKey(PageId))
		{
			return true;
		}
		return false;
	}

	public void SetWaitNet(bool InIsWaitNet)
	{
		IsWaitNet.SetValue(EChangeReason.ManualSet, InIsWaitNet);
	}

	public void SetBlockInput(bool InIsBlockInput)
	{
		IsBlockInput.SetValue(EChangeReason.ManualSet, InIsBlockInput);
	}

	public void SetUseWhiteList(bool InUseWhiteList)
	{
		IsUseWhiteList.SetValue(EChangeReason.ManualSet, InUseWhiteList);
	}

	public bool GetCanInput()
	{
		if (!IsWaitNet.Value)
		{
			return !IsBlockInput.Value;
		}
		return false;
	}

	public string GetBlockInputReason()
	{
		StringBuilder stringBuilder = new StringBuilder("[");
		bool flag = false;
		if (IsWaitNet.Value)
		{
			stringBuilder.Append("WaitNet");
			flag = true;
		}
		if (IsBlockInput.Value)
		{
			if (flag)
			{
				stringBuilder.Append("、");
			}
			stringBuilder.Append("BlockInput");
		}
		stringBuilder.Append("]");
		return stringBuilder.ToString();
	}

	public void SetInputWhiteList(List<GSUIActionEn> InWhiteList)
	{
		InputWhiteList = InWhiteList;
	}

	public bool CheckInputWithWhiteList(GSUIActionEn UIAction)
	{
		if (IsUseWhiteList.Value && (InputWhiteList == null || !InputWhiteList.Contains(UIAction)))
		{
			return false;
		}
		return true;
	}

	public void Reset()
	{
		WaitAnimShowPageRefDic.Clear();
		IsWaitAnimShow.SetValue(EChangeReason.Init, value: false);
		IsWaitNet.SetValue(EChangeReason.Init, value: false);
		IsBlockInput.SetValue(EChangeReason.Init, value: false);
		IsUseWhiteList.SetValue(EChangeReason.Init, value: false);
	}
}
