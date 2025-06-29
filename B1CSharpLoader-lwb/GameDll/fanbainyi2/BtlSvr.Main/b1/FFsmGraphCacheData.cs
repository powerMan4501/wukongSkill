using System;
using System.Collections.Generic;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

public class FFsmGraphCacheData
{
	public Dictionary<Guid, FGameplayTag> NodeStateTagCache { get; } = new Dictionary<Guid, FGameplayTag>();

	public Dictionary<Guid, StateCustom_Single> SingleNodeCustomDataCache { get; } = new Dictionary<Guid, StateCustom_Single>();

	public FGameplayTag GetNodeStateTag(FCalliopeNode InNode)
	{
		if (!NodeStateTagCache.TryGetValue(InNode.NodeGuid, out var value))
		{
			value = GameplayTagExtension.MakeGameplayTag(GetStateCustom_SingleCache(InNode).StateName);
			NodeStateTagCache[InNode.NodeGuid] = value;
		}
		return value;
	}

	public StateCustom_Single GetStateCustom_SingleCache(FCalliopeNode InNode)
	{
		if (!SingleNodeCustomDataCache.TryGetValue(InNode.NodeGuid, out var value))
		{
			value = new StateCustom_Single();
			value.MergeFrom(InNode.NodeData);
			SingleNodeCustomDataCache[InNode.NodeGuid] = value;
		}
		return value;
	}
}
