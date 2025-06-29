using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_AiConversationMgrData : IBGC_AiConversationMgrData, IPersistentECSData
{
	public List<uint> CurPlayingChainList = new List<uint>();

	public List<uint> ChainEndList = new List<uint>();

	public List<uint> ChainInterruptList = new List<uint>();

	public Dictionary<int, FAiConversationContentCDData> CDMap = new Dictionary<int, FAiConversationContentCDData>();

	private TStrongObjectPtr<BGUNarrator> mNarrator { get; set; }

	public BGUNarrator Narrator
	{
		get
		{
			return mNarrator.Get();
		}
		set
		{
			mNarrator.Set(value);
		}
	}

	private TStrongObjectPtr<BGUDialogueProxyActor> mDialogueProxyActor { get; set; }

	public BGUDialogueProxyActor DialogueProxyActor
	{
		get
		{
			return mDialogueProxyActor.Get();
		}
		set
		{
			mDialogueProxyActor.Set(value);
		}
	}

	public uint UniqueChainID { get; set; }

	public uint UniqueEventID { get; set; }

	public int CurSpeakerCount { get; set; }

	public uint Last_ChainRootID { get; set; }

	public uint Last_AiConversationReqID { get; set; }

	public int Last_AiConversationDescID { get; set; }

	public bool Last_bPocessSuccess { get; set; }

	public BGUNarrator GetNarrator()
	{
		return Narrator;
	}

	public BGUDialogueProxyActor GetDialogueProxyActor()
	{
		return DialogueProxyActor;
	}

	public bool bIsAiConversationChainEnd(uint ChainRootID)
	{
		return ChainEndList.Contains(ChainRootID);
	}

	public bool bIsAiConversationChainEnd_CPG(uint ChainRootID)
	{
		if (!CurPlayingChainList.Contains(ChainRootID))
		{
			return true;
		}
		if (!ChainEndList.Contains(ChainRootID))
		{
			return ChainInterruptList.Contains(ChainRootID);
		}
		return true;
	}

	public bool bHasAiConversationPlaying()
	{
		return CurSpeakerCount > 0;
	}

	public uint GetLast_ChainRootID()
	{
		return Last_ChainRootID;
	}

	public uint GetLast_AiConversationReqID()
	{
		return Last_AiConversationReqID;
	}

	public int GetLast_AiConversationDescID()
	{
		return Last_AiConversationDescID;
	}

	public bool GetLast_bPocessSuccess()
	{
		return Last_bPocessSuccess;
	}

	public BGC_AiConversationMgrData()
	{
		mNarrator = new TStrongObjectPtr<BGUNarrator>();
		mDialogueProxyActor = new TStrongObjectPtr<BGUDialogueProxyActor>();
	}
}
