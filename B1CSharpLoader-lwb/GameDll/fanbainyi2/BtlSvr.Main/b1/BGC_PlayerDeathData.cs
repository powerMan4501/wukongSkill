using System;
using b1.ECS;
using GUR.Runtime;

namespace b1;

public class BGC_PlayerDeathData : IPersistentECSData, b1.IBGC_PlayerDeathData
{
	private int __PlayerDeathCount_Raw;

	private BindDictInt_Int __ChapterDeathDict_Raw;

	[GSPersistent]
	public int PlayerDeathCount
	{
		get
		{
			return __PlayerDeathCount_Raw;
		}
		set
		{
			int _PlayerDeathCount_Raw = __PlayerDeathCount_Raw;
			__PlayerDeathCount_Raw = value;
			OnPlayerDeathCountChg_Invoke(_PlayerDeathCount_Raw, value);
		}
	}

	[GSPersistent]
	public BindDictInt_Int ChapterDeathDict
	{
		get
		{
			return __ChapterDeathDict_Raw;
		}
		set
		{
			BindDictInt_Int _ChapterDeathDict_Raw = __ChapterDeathDict_Raw;
			__ChapterDeathDict_Raw = value;
			OnChapterDeathDictChg_Invoke(_ChapterDeathDict_Raw, value);
		}
	}

	public event Action<int, int> OnPlayerDeathCountChg;

	public event Action<BindDictInt_Int, BindDictInt_Int> OnChapterDeathDictChg;

	public BGC_PlayerDeathData()
	{
		PlayerDeathCount = 0;
		ChapterDeathDict = new BindDictInt_Int();
	}

	public int GetDeathCount(int ChapterId)
	{
		if (ChapterDeathDict.TryGetValue(ChapterId, out var OutValue))
		{
			return OutValue;
		}
		return 0;
	}

	private void OnPlayerDeathCountChg_Invoke(int OldValue, int NewValue)
	{
		if (!NewValue.Equals(OldValue))
		{
			this.OnPlayerDeathCountChg?.Invoke(OldValue, NewValue);
		}
	}

	private void OnChapterDeathDictChg_Invoke(BindDictInt_Int OldValue, BindDictInt_Int NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnChapterDeathDictChg?.Invoke(OldValue, NewValue);
		}
	}
}
