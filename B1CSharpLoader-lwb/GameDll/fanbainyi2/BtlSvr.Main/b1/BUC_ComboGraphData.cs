using System;
using System.Collections.Generic;
using Google.Protobuf;

namespace b1;

public class BUC_ComboGraphData
{
	public bool bEnableDebug { get; set; }

	public List<string> Templates { get; } = new List<string>();

	public string DefaultTemplate { get; set; }

	public FCalliopeAssetReference CurrentInstance { get; set; }

	public FCalliopeGraph CurrentGraph { get; set; }

	public FCalliopeNode CurrentNode { get; set; }

	public Dictionary<string, Action<FCalliopeNode, string>> NodeActions { get; } = new Dictionary<string, Action<FCalliopeNode, string>>();

	public Dictionary<string, float> DeferredCommandDictionary { get; } = new Dictionary<string, float>();

	public List<string> ProcessingCommands { get; } = new List<string>();

	public bool bRestart { get; set; }

	public List<string> RestartCommandList { get; } = new List<string>();

	public Dictionary<Guid, IMessage> NodeCustomDataCache { get; } = new Dictionary<Guid, IMessage>();

	public bool bHasOutputPin { get; set; } = true;

	public bool bTriggerSkillResult { get; set; } = true;

	public bool bTriggerConditionResult { get; set; } = true;
}
