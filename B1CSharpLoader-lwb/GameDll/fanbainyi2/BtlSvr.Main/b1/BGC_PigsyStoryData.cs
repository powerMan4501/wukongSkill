using System;
using System.Collections.Generic;
using b1.ECS;
using GUR.Runtime;

namespace b1;

public class BGC_PigsyStoryData : IBGC_PigsyStoryData, IPersistentECSData
{
	public Dictionary<string, FStoryAreaInfo> AreaDic;

	public uint CurAiConversationEventReqID;

	public uint CurAiConversationChainID;

	public bool bSuccess_LastReqPlayStory;

	public Dictionary<int, List<int>> StoryLib;

	private bool bAllStoryFinished_CurLevel;

	private BindListInt __FinishedStoryMemory_Raw;

	public int CurrentLevelID { get; set; }

	public int CurrentAreaID { get; set; }

	public EStoryConversationType StoryConversationType { get; set; }

	public int AiConversationStartID { get; set; }

	public int LastAiConversationID { get; set; }

	[GSPersistent]
	public BindListInt FinishedStoryMemory
	{
		get
		{
			return __FinishedStoryMemory_Raw;
		}
		set
		{
			BindListInt _FinishedStoryMemory_Raw = __FinishedStoryMemory_Raw;
			__FinishedStoryMemory_Raw = value;
			OnFinishedStoryMemoryChg_Invoke(_FinishedStoryMemory_Raw, value);
		}
	}

	public event Action<BindListInt, BindListInt> OnFinishedStoryMemoryChg;

	public BGC_PigsyStoryData()
	{
		AreaDic = new Dictionary<string, FStoryAreaInfo>();
		StoryLib = new Dictionary<int, List<int>>();
		FinishedStoryMemory = new BindListInt();
	}

	public int GetStoryID(int StoryIndex)
	{
		return CurrentLevelID * 10000 + CurrentAreaID * 100 + StoryIndex;
	}

	public bool IsFinished(int AiConversationStartID)
	{
		return FinishedStoryMemory.Contains(AiConversationStartID);
	}

	public void StoryComplete()
	{
		FinishedStoryMemory.Add(AiConversationStartID);
		AiConversationStartID = 0;
	}

	public bool IsSuccess_LastReqPlayStory()
	{
		return bSuccess_LastReqPlayStory;
	}

	public bool IsPlayingStory()
	{
		if (CurAiConversationEventReqID != 0)
		{
			return StoryConversationType == EStoryConversationType.Story;
		}
		return false;
	}

	public bool IsPlayingResumeStory()
	{
		return StoryConversationType == EStoryConversationType.Resume;
	}

	public bool Update_AllStoryFinished_CurLevel()
	{
		bool flag = true;
		foreach (KeyValuePair<int, List<int>> item in StoryLib)
		{
			bool flag2 = false;
			foreach (int item2 in item.Value)
			{
				if (!FinishedStoryMemory.Contains(item2))
				{
					flag = false;
					flag2 = true;
					break;
				}
			}
			if (flag2)
			{
				break;
			}
		}
		if (flag)
		{
			bAllStoryFinished_CurLevel = true;
		}
		return flag;
	}

	public bool HasStoryCanTalk_CurArea()
	{
		if (bAllStoryFinished_CurLevel)
		{
			return false;
		}
		if (StoryLib.TryGetValue(0, out var value))
		{
			foreach (int item in value)
			{
				if (!FinishedStoryMemory.Contains(item))
				{
					return true;
				}
			}
		}
		if (CurrentAreaID != 0 && StoryLib.TryGetValue(CurrentAreaID, out var value2))
		{
			foreach (int item2 in value2)
			{
				if (!FinishedStoryMemory.Contains(item2))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void OnFinishedStoryMemoryChg_Invoke(BindListInt OldValue, BindListInt NewValue)
	{
		if ((NewValue != null || OldValue != null) && ((NewValue == null && OldValue != null) || !NewValue.Equals(OldValue)))
		{
			this.OnFinishedStoryMemoryChg?.Invoke(OldValue, NewValue);
		}
	}
}
