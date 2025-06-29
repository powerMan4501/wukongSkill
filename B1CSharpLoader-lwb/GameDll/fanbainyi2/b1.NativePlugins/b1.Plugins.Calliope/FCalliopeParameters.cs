using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeParameters", "Calliope", UnrealModuleType.GamePlugin)]
public struct FCalliopeParameters
{
	private static bool FollowPartnerConfigIDCollection_IsValid;

	private static FFieldAddress FollowPartnerConfigIDCollection_PropertyAddress;

	private static int FollowPartnerConfigIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:FollowPartnerConfigIDCollection")]
	public List<FGsManagedFollowPartnerConfigID> FollowPartnerConfigIDCollection;

	private static bool AssociationUnitConfigIDCollection_IsValid;

	private static FFieldAddress AssociationUnitConfigIDCollection_PropertyAddress;

	private static int AssociationUnitConfigIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:AssociationUnitConfigIDCollection")]
	public List<FGsManagedAssociationUnitConfigID> AssociationUnitConfigIDCollection;

	private static bool AssociationOnFightSkillIDCollection_IsValid;

	private static FFieldAddress AssociationOnFightSkillIDCollection_PropertyAddress;

	private static int AssociationOnFightSkillIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:AssociationOnFightSkillIDCollection")]
	public List<FGsManagedAssociationOnFightSkillID> AssociationOnFightSkillIDCollection;

	private static bool SequenceIDCollection_IsValid;

	private static FFieldAddress SequenceIDCollection_PropertyAddress;

	private static int SequenceIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:SequenceIDCollection")]
	public List<FGsManagedSequenceID> SequenceIDCollection;

	private static bool TaskStageCollection_IsValid;

	private static FFieldAddress TaskStageCollection_PropertyAddress;

	private static int TaskStageCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:TaskStageCollection")]
	public List<FGsManagedTaskStage> TaskStageCollection;

	private static bool TaskLineCollection_IsValid;

	private static FFieldAddress TaskLineCollection_PropertyAddress;

	private static int TaskLineCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:TaskLineCollection")]
	public List<FGsManagedTaskLine> TaskLineCollection;

	private static bool BuffIDCollection_IsValid;

	private static FFieldAddress BuffIDCollection_PropertyAddress;

	private static int BuffIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:BuffIDCollection")]
	public List<FGsManagedBuffID> BuffIDCollection;

	private static bool ArchiveLabelCollection_IsValid;

	private static FFieldAddress ArchiveLabelCollection_PropertyAddress;

	private static int ArchiveLabelCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:ArchiveLabelCollection")]
	public List<FGsManagedArchiveLabel> ArchiveLabelCollection;

	private static bool GroupIDCollection_IsValid;

	private static FFieldAddress GroupIDCollection_PropertyAddress;

	private static int GroupIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:GroupIDCollection")]
	public List<FGsManagedGroupID> GroupIDCollection;

	private static bool AiConversationIDCollection_IsValid;

	private static FFieldAddress AiConversationIDCollection_PropertyAddress;

	private static int AiConversationIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:AiConversationIDCollection")]
	public List<FGsManagedAiConversationID> AiConversationIDCollection;

	private static bool TeamIDCollection_IsValid;

	private static FFieldAddress TeamIDCollection_PropertyAddress;

	private static int TeamIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:TeamIDCollection")]
	public List<FGsManagedTeamID> TeamIDCollection;

	private static bool IdleAMIdxCollection_IsValid;

	private static FFieldAddress IdleAMIdxCollection_PropertyAddress;

	private static int IdleAMIdxCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:IdleAMIdxCollection")]
	public List<FGsManagedIdleAMIdx> IdleAMIdxCollection;

	private static bool LeisureAnimIndexCollection_IsValid;

	private static FFieldAddress LeisureAnimIndexCollection_PropertyAddress;

	private static int LeisureAnimIndexCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:LeisureAnimIndexCollection")]
	public List<FGsManagedLeisureAnimIndex> LeisureAnimIndexCollection;

	private static bool InteractGroupIDCollection_IsValid;

	private static FFieldAddress InteractGroupIDCollection_PropertyAddress;

	private static int InteractGroupIDCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:InteractGroupIDCollection")]
	public List<FGsManagedInteractGroupID> InteractGroupIDCollection;

	private static bool DynamicObstacleCollection_IsValid;

	private static FFieldAddress DynamicObstacleCollection_PropertyAddress;

	private static int DynamicObstacleCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:DynamicObstacleCollection")]
	public List<FGsManagedDynamicObstacle> DynamicObstacleCollection;

	private static bool OverlapCollection_IsValid;

	private static FFieldAddress OverlapCollection_PropertyAddress;

	private static int OverlapCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:OverlapCollection")]
	public List<FGsManagedOverlap> OverlapCollection;

	private static bool InteractorCollection_IsValid;

	private static FFieldAddress InteractorCollection_PropertyAddress;

	private static int InteractorCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:InteractorCollection")]
	public List<FGsManagedInteractor> InteractorCollection;

	private static bool SpawnerCollection_IsValid;

	private static FFieldAddress SpawnerCollection_PropertyAddress;

	private static int SpawnerCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:SpawnerCollection")]
	public List<FGsManagedSpawner> SpawnerCollection;

	private static bool UnitCollection_IsValid;

	private static FFieldAddress UnitCollection_PropertyAddress;

	private static int UnitCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:UnitCollection")]
	public List<FGsManagedUnit> UnitCollection;

	private static bool GroupUnitCollection_IsValid;

	private static FFieldAddress GroupUnitCollection_PropertyAddress;

	private static int GroupUnitCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:GroupUnitCollection")]
	public List<FGsManagedGroupUnit> GroupUnitCollection;

	private static bool NPCUnitCollection_IsValid;

	private static FFieldAddress NPCUnitCollection_PropertyAddress;

	private static int NPCUnitCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:NPCUnitCollection")]
	public List<FGsManagedNPCUnit> NPCUnitCollection;

	private static bool StreamingLevelCollection_IsValid;

	private static FFieldAddress StreamingLevelCollection_PropertyAddress;

	private static int StreamingLevelCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:StreamingLevelCollection")]
	public List<FGsManagedStreamingLevel> StreamingLevelCollection;

	private static bool StreamingLevelStateConfigCollection_IsValid;

	private static FFieldAddress StreamingLevelStateConfigCollection_PropertyAddress;

	private static int StreamingLevelStateConfigCollection_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameters:StreamingLevelStateConfigCollection")]
	public List<FGsManagedStreamingLevelStateConfig> StreamingLevelStateConfigCollection;

	private static bool FCalliopeParameters_IsValid;

	private static int FCalliopeParameters_StructSize;

	public FCalliopeParameters Copy()
	{
		FCalliopeParameters result = this;
		if (FollowPartnerConfigIDCollection != null)
		{
			result.FollowPartnerConfigIDCollection = new List<FGsManagedFollowPartnerConfigID>(FollowPartnerConfigIDCollection);
		}
		if (AssociationUnitConfigIDCollection != null)
		{
			result.AssociationUnitConfigIDCollection = new List<FGsManagedAssociationUnitConfigID>(AssociationUnitConfigIDCollection);
		}
		if (AssociationOnFightSkillIDCollection != null)
		{
			result.AssociationOnFightSkillIDCollection = new List<FGsManagedAssociationOnFightSkillID>(AssociationOnFightSkillIDCollection);
		}
		if (SequenceIDCollection != null)
		{
			result.SequenceIDCollection = new List<FGsManagedSequenceID>(SequenceIDCollection);
		}
		if (TaskStageCollection != null)
		{
			result.TaskStageCollection = new List<FGsManagedTaskStage>(TaskStageCollection);
		}
		if (TaskLineCollection != null)
		{
			result.TaskLineCollection = new List<FGsManagedTaskLine>(TaskLineCollection);
		}
		if (BuffIDCollection != null)
		{
			result.BuffIDCollection = new List<FGsManagedBuffID>(BuffIDCollection);
		}
		if (ArchiveLabelCollection != null)
		{
			result.ArchiveLabelCollection = new List<FGsManagedArchiveLabel>(ArchiveLabelCollection);
		}
		if (GroupIDCollection != null)
		{
			result.GroupIDCollection = new List<FGsManagedGroupID>(GroupIDCollection);
		}
		if (AiConversationIDCollection != null)
		{
			result.AiConversationIDCollection = new List<FGsManagedAiConversationID>(AiConversationIDCollection);
		}
		if (TeamIDCollection != null)
		{
			result.TeamIDCollection = new List<FGsManagedTeamID>(TeamIDCollection);
		}
		if (IdleAMIdxCollection != null)
		{
			result.IdleAMIdxCollection = new List<FGsManagedIdleAMIdx>(IdleAMIdxCollection);
		}
		if (LeisureAnimIndexCollection != null)
		{
			result.LeisureAnimIndexCollection = new List<FGsManagedLeisureAnimIndex>(LeisureAnimIndexCollection);
		}
		if (InteractGroupIDCollection != null)
		{
			result.InteractGroupIDCollection = new List<FGsManagedInteractGroupID>(InteractGroupIDCollection);
		}
		if (DynamicObstacleCollection != null)
		{
			result.DynamicObstacleCollection = new List<FGsManagedDynamicObstacle>(DynamicObstacleCollection);
		}
		if (OverlapCollection != null)
		{
			result.OverlapCollection = new List<FGsManagedOverlap>(OverlapCollection);
		}
		if (InteractorCollection != null)
		{
			result.InteractorCollection = new List<FGsManagedInteractor>(InteractorCollection);
		}
		if (SpawnerCollection != null)
		{
			result.SpawnerCollection = new List<FGsManagedSpawner>(SpawnerCollection);
		}
		if (UnitCollection != null)
		{
			result.UnitCollection = new List<FGsManagedUnit>(UnitCollection);
		}
		if (GroupUnitCollection != null)
		{
			result.GroupUnitCollection = new List<FGsManagedGroupUnit>(GroupUnitCollection);
		}
		if (NPCUnitCollection != null)
		{
			result.NPCUnitCollection = new List<FGsManagedNPCUnit>(NPCUnitCollection);
		}
		if (StreamingLevelCollection != null)
		{
			result.StreamingLevelCollection = new List<FGsManagedStreamingLevel>(StreamingLevelCollection);
		}
		if (StreamingLevelStateConfigCollection != null)
		{
			result.StreamingLevelStateConfigCollection = new List<FGsManagedStreamingLevelStateConfig>(StreamingLevelStateConfigCollection);
		}
		return result;
	}

	public static FCalliopeParameters FromNative(IntPtr nativeBuffer)
	{
		return new FCalliopeParameters(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCalliopeParameters value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCalliopeParameters FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCalliopeParameters(nativeBuffer + arrayIndex * FCalliopeParameters_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCalliopeParameters value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCalliopeParameters_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCalliopeParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeParameters");
			return;
		}
		new TArrayCopyMarshaler<FGsManagedFollowPartnerConfigID>(1, FollowPartnerConfigIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedFollowPartnerConfigID, FGsManagedFollowPartnerConfigID>.FromNative, CachedMarshalingDelegates<FGsManagedFollowPartnerConfigID, FGsManagedFollowPartnerConfigID>.ToNative).ToNative(IntPtr.Add(nativeStruct, FollowPartnerConfigIDCollection_Offset), FollowPartnerConfigIDCollection);
		new TArrayCopyMarshaler<FGsManagedAssociationUnitConfigID>(1, AssociationUnitConfigIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedAssociationUnitConfigID, FGsManagedAssociationUnitConfigID>.FromNative, CachedMarshalingDelegates<FGsManagedAssociationUnitConfigID, FGsManagedAssociationUnitConfigID>.ToNative).ToNative(IntPtr.Add(nativeStruct, AssociationUnitConfigIDCollection_Offset), AssociationUnitConfigIDCollection);
		new TArrayCopyMarshaler<FGsManagedAssociationOnFightSkillID>(1, AssociationOnFightSkillIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedAssociationOnFightSkillID, FGsManagedAssociationOnFightSkillID>.FromNative, CachedMarshalingDelegates<FGsManagedAssociationOnFightSkillID, FGsManagedAssociationOnFightSkillID>.ToNative).ToNative(IntPtr.Add(nativeStruct, AssociationOnFightSkillIDCollection_Offset), AssociationOnFightSkillIDCollection);
		new TArrayCopyMarshaler<FGsManagedSequenceID>(1, SequenceIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedSequenceID, FGsManagedSequenceID>.FromNative, CachedMarshalingDelegates<FGsManagedSequenceID, FGsManagedSequenceID>.ToNative).ToNative(IntPtr.Add(nativeStruct, SequenceIDCollection_Offset), SequenceIDCollection);
		new TArrayCopyMarshaler<FGsManagedTaskStage>(1, TaskStageCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedTaskStage, FGsManagedTaskStage>.FromNative, CachedMarshalingDelegates<FGsManagedTaskStage, FGsManagedTaskStage>.ToNative).ToNative(IntPtr.Add(nativeStruct, TaskStageCollection_Offset), TaskStageCollection);
		new TArrayCopyMarshaler<FGsManagedTaskLine>(1, TaskLineCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedTaskLine, FGsManagedTaskLine>.FromNative, CachedMarshalingDelegates<FGsManagedTaskLine, FGsManagedTaskLine>.ToNative).ToNative(IntPtr.Add(nativeStruct, TaskLineCollection_Offset), TaskLineCollection);
		new TArrayCopyMarshaler<FGsManagedBuffID>(1, BuffIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedBuffID, FGsManagedBuffID>.FromNative, CachedMarshalingDelegates<FGsManagedBuffID, FGsManagedBuffID>.ToNative).ToNative(IntPtr.Add(nativeStruct, BuffIDCollection_Offset), BuffIDCollection);
		new TArrayCopyMarshaler<FGsManagedArchiveLabel>(1, ArchiveLabelCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedArchiveLabel, FGsManagedArchiveLabel>.FromNative, CachedMarshalingDelegates<FGsManagedArchiveLabel, FGsManagedArchiveLabel>.ToNative).ToNative(IntPtr.Add(nativeStruct, ArchiveLabelCollection_Offset), ArchiveLabelCollection);
		new TArrayCopyMarshaler<FGsManagedGroupID>(1, GroupIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedGroupID, FGsManagedGroupID>.FromNative, CachedMarshalingDelegates<FGsManagedGroupID, FGsManagedGroupID>.ToNative).ToNative(IntPtr.Add(nativeStruct, GroupIDCollection_Offset), GroupIDCollection);
		new TArrayCopyMarshaler<FGsManagedAiConversationID>(1, AiConversationIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedAiConversationID, FGsManagedAiConversationID>.FromNative, CachedMarshalingDelegates<FGsManagedAiConversationID, FGsManagedAiConversationID>.ToNative).ToNative(IntPtr.Add(nativeStruct, AiConversationIDCollection_Offset), AiConversationIDCollection);
		new TArrayCopyMarshaler<FGsManagedTeamID>(1, TeamIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedTeamID, FGsManagedTeamID>.FromNative, CachedMarshalingDelegates<FGsManagedTeamID, FGsManagedTeamID>.ToNative).ToNative(IntPtr.Add(nativeStruct, TeamIDCollection_Offset), TeamIDCollection);
		new TArrayCopyMarshaler<FGsManagedIdleAMIdx>(1, IdleAMIdxCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedIdleAMIdx, FGsManagedIdleAMIdx>.FromNative, CachedMarshalingDelegates<FGsManagedIdleAMIdx, FGsManagedIdleAMIdx>.ToNative).ToNative(IntPtr.Add(nativeStruct, IdleAMIdxCollection_Offset), IdleAMIdxCollection);
		new TArrayCopyMarshaler<FGsManagedLeisureAnimIndex>(1, LeisureAnimIndexCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedLeisureAnimIndex, FGsManagedLeisureAnimIndex>.FromNative, CachedMarshalingDelegates<FGsManagedLeisureAnimIndex, FGsManagedLeisureAnimIndex>.ToNative).ToNative(IntPtr.Add(nativeStruct, LeisureAnimIndexCollection_Offset), LeisureAnimIndexCollection);
		new TArrayCopyMarshaler<FGsManagedInteractGroupID>(1, InteractGroupIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedInteractGroupID, FGsManagedInteractGroupID>.FromNative, CachedMarshalingDelegates<FGsManagedInteractGroupID, FGsManagedInteractGroupID>.ToNative).ToNative(IntPtr.Add(nativeStruct, InteractGroupIDCollection_Offset), InteractGroupIDCollection);
		new TArrayCopyMarshaler<FGsManagedDynamicObstacle>(1, DynamicObstacleCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedDynamicObstacle, FGsManagedDynamicObstacle>.FromNative, CachedMarshalingDelegates<FGsManagedDynamicObstacle, FGsManagedDynamicObstacle>.ToNative).ToNative(IntPtr.Add(nativeStruct, DynamicObstacleCollection_Offset), DynamicObstacleCollection);
		new TArrayCopyMarshaler<FGsManagedOverlap>(1, OverlapCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedOverlap, FGsManagedOverlap>.FromNative, CachedMarshalingDelegates<FGsManagedOverlap, FGsManagedOverlap>.ToNative).ToNative(IntPtr.Add(nativeStruct, OverlapCollection_Offset), OverlapCollection);
		new TArrayCopyMarshaler<FGsManagedInteractor>(1, InteractorCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedInteractor, FGsManagedInteractor>.FromNative, CachedMarshalingDelegates<FGsManagedInteractor, FGsManagedInteractor>.ToNative).ToNative(IntPtr.Add(nativeStruct, InteractorCollection_Offset), InteractorCollection);
		new TArrayCopyMarshaler<FGsManagedSpawner>(1, SpawnerCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedSpawner, FGsManagedSpawner>.FromNative, CachedMarshalingDelegates<FGsManagedSpawner, FGsManagedSpawner>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnerCollection_Offset), SpawnerCollection);
		new TArrayCopyMarshaler<FGsManagedUnit>(1, UnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedUnit, FGsManagedUnit>.FromNative, CachedMarshalingDelegates<FGsManagedUnit, FGsManagedUnit>.ToNative).ToNative(IntPtr.Add(nativeStruct, UnitCollection_Offset), UnitCollection);
		new TArrayCopyMarshaler<FGsManagedGroupUnit>(1, GroupUnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedGroupUnit, FGsManagedGroupUnit>.FromNative, CachedMarshalingDelegates<FGsManagedGroupUnit, FGsManagedGroupUnit>.ToNative).ToNative(IntPtr.Add(nativeStruct, GroupUnitCollection_Offset), GroupUnitCollection);
		new TArrayCopyMarshaler<FGsManagedNPCUnit>(1, NPCUnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedNPCUnit, FGsManagedNPCUnit>.FromNative, CachedMarshalingDelegates<FGsManagedNPCUnit, FGsManagedNPCUnit>.ToNative).ToNative(IntPtr.Add(nativeStruct, NPCUnitCollection_Offset), NPCUnitCollection);
		new TArrayCopyMarshaler<FGsManagedStreamingLevel>(1, StreamingLevelCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedStreamingLevel, FGsManagedStreamingLevel>.FromNative, CachedMarshalingDelegates<FGsManagedStreamingLevel, FGsManagedStreamingLevel>.ToNative).ToNative(IntPtr.Add(nativeStruct, StreamingLevelCollection_Offset), StreamingLevelCollection);
		new TArrayCopyMarshaler<FGsManagedStreamingLevelStateConfig>(1, StreamingLevelStateConfigCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedStreamingLevelStateConfig, FGsManagedStreamingLevelStateConfig>.FromNative, CachedMarshalingDelegates<FGsManagedStreamingLevelStateConfig, FGsManagedStreamingLevelStateConfig>.ToNative).ToNative(IntPtr.Add(nativeStruct, StreamingLevelStateConfigCollection_Offset), StreamingLevelStateConfigCollection);
	}

	public FCalliopeParameters(IntPtr nativeStruct)
	{
		if (!FCalliopeParameters_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Calliope.CalliopeParameters");
			FollowPartnerConfigIDCollection = null;
			AssociationUnitConfigIDCollection = null;
			AssociationOnFightSkillIDCollection = null;
			SequenceIDCollection = null;
			TaskStageCollection = null;
			TaskLineCollection = null;
			BuffIDCollection = null;
			ArchiveLabelCollection = null;
			GroupIDCollection = null;
			AiConversationIDCollection = null;
			TeamIDCollection = null;
			IdleAMIdxCollection = null;
			LeisureAnimIndexCollection = null;
			InteractGroupIDCollection = null;
			DynamicObstacleCollection = null;
			OverlapCollection = null;
			InteractorCollection = null;
			SpawnerCollection = null;
			UnitCollection = null;
			GroupUnitCollection = null;
			NPCUnitCollection = null;
			StreamingLevelCollection = null;
			StreamingLevelStateConfigCollection = null;
		}
		else
		{
			FollowPartnerConfigIDCollection = new TArrayCopyMarshaler<FGsManagedFollowPartnerConfigID>(1, FollowPartnerConfigIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedFollowPartnerConfigID, FGsManagedFollowPartnerConfigID>.FromNative, CachedMarshalingDelegates<FGsManagedFollowPartnerConfigID, FGsManagedFollowPartnerConfigID>.ToNative).FromNative(IntPtr.Add(nativeStruct, FollowPartnerConfigIDCollection_Offset));
			AssociationUnitConfigIDCollection = new TArrayCopyMarshaler<FGsManagedAssociationUnitConfigID>(1, AssociationUnitConfigIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedAssociationUnitConfigID, FGsManagedAssociationUnitConfigID>.FromNative, CachedMarshalingDelegates<FGsManagedAssociationUnitConfigID, FGsManagedAssociationUnitConfigID>.ToNative).FromNative(IntPtr.Add(nativeStruct, AssociationUnitConfigIDCollection_Offset));
			AssociationOnFightSkillIDCollection = new TArrayCopyMarshaler<FGsManagedAssociationOnFightSkillID>(1, AssociationOnFightSkillIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedAssociationOnFightSkillID, FGsManagedAssociationOnFightSkillID>.FromNative, CachedMarshalingDelegates<FGsManagedAssociationOnFightSkillID, FGsManagedAssociationOnFightSkillID>.ToNative).FromNative(IntPtr.Add(nativeStruct, AssociationOnFightSkillIDCollection_Offset));
			SequenceIDCollection = new TArrayCopyMarshaler<FGsManagedSequenceID>(1, SequenceIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedSequenceID, FGsManagedSequenceID>.FromNative, CachedMarshalingDelegates<FGsManagedSequenceID, FGsManagedSequenceID>.ToNative).FromNative(IntPtr.Add(nativeStruct, SequenceIDCollection_Offset));
			TaskStageCollection = new TArrayCopyMarshaler<FGsManagedTaskStage>(1, TaskStageCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedTaskStage, FGsManagedTaskStage>.FromNative, CachedMarshalingDelegates<FGsManagedTaskStage, FGsManagedTaskStage>.ToNative).FromNative(IntPtr.Add(nativeStruct, TaskStageCollection_Offset));
			TaskLineCollection = new TArrayCopyMarshaler<FGsManagedTaskLine>(1, TaskLineCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedTaskLine, FGsManagedTaskLine>.FromNative, CachedMarshalingDelegates<FGsManagedTaskLine, FGsManagedTaskLine>.ToNative).FromNative(IntPtr.Add(nativeStruct, TaskLineCollection_Offset));
			BuffIDCollection = new TArrayCopyMarshaler<FGsManagedBuffID>(1, BuffIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedBuffID, FGsManagedBuffID>.FromNative, CachedMarshalingDelegates<FGsManagedBuffID, FGsManagedBuffID>.ToNative).FromNative(IntPtr.Add(nativeStruct, BuffIDCollection_Offset));
			ArchiveLabelCollection = new TArrayCopyMarshaler<FGsManagedArchiveLabel>(1, ArchiveLabelCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedArchiveLabel, FGsManagedArchiveLabel>.FromNative, CachedMarshalingDelegates<FGsManagedArchiveLabel, FGsManagedArchiveLabel>.ToNative).FromNative(IntPtr.Add(nativeStruct, ArchiveLabelCollection_Offset));
			GroupIDCollection = new TArrayCopyMarshaler<FGsManagedGroupID>(1, GroupIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedGroupID, FGsManagedGroupID>.FromNative, CachedMarshalingDelegates<FGsManagedGroupID, FGsManagedGroupID>.ToNative).FromNative(IntPtr.Add(nativeStruct, GroupIDCollection_Offset));
			AiConversationIDCollection = new TArrayCopyMarshaler<FGsManagedAiConversationID>(1, AiConversationIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedAiConversationID, FGsManagedAiConversationID>.FromNative, CachedMarshalingDelegates<FGsManagedAiConversationID, FGsManagedAiConversationID>.ToNative).FromNative(IntPtr.Add(nativeStruct, AiConversationIDCollection_Offset));
			TeamIDCollection = new TArrayCopyMarshaler<FGsManagedTeamID>(1, TeamIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedTeamID, FGsManagedTeamID>.FromNative, CachedMarshalingDelegates<FGsManagedTeamID, FGsManagedTeamID>.ToNative).FromNative(IntPtr.Add(nativeStruct, TeamIDCollection_Offset));
			IdleAMIdxCollection = new TArrayCopyMarshaler<FGsManagedIdleAMIdx>(1, IdleAMIdxCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedIdleAMIdx, FGsManagedIdleAMIdx>.FromNative, CachedMarshalingDelegates<FGsManagedIdleAMIdx, FGsManagedIdleAMIdx>.ToNative).FromNative(IntPtr.Add(nativeStruct, IdleAMIdxCollection_Offset));
			LeisureAnimIndexCollection = new TArrayCopyMarshaler<FGsManagedLeisureAnimIndex>(1, LeisureAnimIndexCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedLeisureAnimIndex, FGsManagedLeisureAnimIndex>.FromNative, CachedMarshalingDelegates<FGsManagedLeisureAnimIndex, FGsManagedLeisureAnimIndex>.ToNative).FromNative(IntPtr.Add(nativeStruct, LeisureAnimIndexCollection_Offset));
			InteractGroupIDCollection = new TArrayCopyMarshaler<FGsManagedInteractGroupID>(1, InteractGroupIDCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedInteractGroupID, FGsManagedInteractGroupID>.FromNative, CachedMarshalingDelegates<FGsManagedInteractGroupID, FGsManagedInteractGroupID>.ToNative).FromNative(IntPtr.Add(nativeStruct, InteractGroupIDCollection_Offset));
			DynamicObstacleCollection = new TArrayCopyMarshaler<FGsManagedDynamicObstacle>(1, DynamicObstacleCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedDynamicObstacle, FGsManagedDynamicObstacle>.FromNative, CachedMarshalingDelegates<FGsManagedDynamicObstacle, FGsManagedDynamicObstacle>.ToNative).FromNative(IntPtr.Add(nativeStruct, DynamicObstacleCollection_Offset));
			OverlapCollection = new TArrayCopyMarshaler<FGsManagedOverlap>(1, OverlapCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedOverlap, FGsManagedOverlap>.FromNative, CachedMarshalingDelegates<FGsManagedOverlap, FGsManagedOverlap>.ToNative).FromNative(IntPtr.Add(nativeStruct, OverlapCollection_Offset));
			InteractorCollection = new TArrayCopyMarshaler<FGsManagedInteractor>(1, InteractorCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedInteractor, FGsManagedInteractor>.FromNative, CachedMarshalingDelegates<FGsManagedInteractor, FGsManagedInteractor>.ToNative).FromNative(IntPtr.Add(nativeStruct, InteractorCollection_Offset));
			SpawnerCollection = new TArrayCopyMarshaler<FGsManagedSpawner>(1, SpawnerCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedSpawner, FGsManagedSpawner>.FromNative, CachedMarshalingDelegates<FGsManagedSpawner, FGsManagedSpawner>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnerCollection_Offset));
			UnitCollection = new TArrayCopyMarshaler<FGsManagedUnit>(1, UnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedUnit, FGsManagedUnit>.FromNative, CachedMarshalingDelegates<FGsManagedUnit, FGsManagedUnit>.ToNative).FromNative(IntPtr.Add(nativeStruct, UnitCollection_Offset));
			GroupUnitCollection = new TArrayCopyMarshaler<FGsManagedGroupUnit>(1, GroupUnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedGroupUnit, FGsManagedGroupUnit>.FromNative, CachedMarshalingDelegates<FGsManagedGroupUnit, FGsManagedGroupUnit>.ToNative).FromNative(IntPtr.Add(nativeStruct, GroupUnitCollection_Offset));
			NPCUnitCollection = new TArrayCopyMarshaler<FGsManagedNPCUnit>(1, NPCUnitCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedNPCUnit, FGsManagedNPCUnit>.FromNative, CachedMarshalingDelegates<FGsManagedNPCUnit, FGsManagedNPCUnit>.ToNative).FromNative(IntPtr.Add(nativeStruct, NPCUnitCollection_Offset));
			StreamingLevelCollection = new TArrayCopyMarshaler<FGsManagedStreamingLevel>(1, StreamingLevelCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedStreamingLevel, FGsManagedStreamingLevel>.FromNative, CachedMarshalingDelegates<FGsManagedStreamingLevel, FGsManagedStreamingLevel>.ToNative).FromNative(IntPtr.Add(nativeStruct, StreamingLevelCollection_Offset));
			StreamingLevelStateConfigCollection = new TArrayCopyMarshaler<FGsManagedStreamingLevelStateConfig>(1, StreamingLevelStateConfigCollection_PropertyAddress, CachedMarshalingDelegates<FGsManagedStreamingLevelStateConfig, FGsManagedStreamingLevelStateConfig>.FromNative, CachedMarshalingDelegates<FGsManagedStreamingLevelStateConfig, FGsManagedStreamingLevelStateConfig>.ToNative).FromNative(IntPtr.Add(nativeStruct, StreamingLevelStateConfigCollection_Offset));
		}
	}

	static FCalliopeParameters()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCalliopeParameters)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCalliopeParameters));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Calliope.CalliopeParameters");
		FCalliopeParameters_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FollowPartnerConfigIDCollection_PropertyAddress, intPtr, "FollowPartnerConfigIDCollection");
		FollowPartnerConfigIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FollowPartnerConfigIDCollection");
		FollowPartnerConfigIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FollowPartnerConfigIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AssociationUnitConfigIDCollection_PropertyAddress, intPtr, "AssociationUnitConfigIDCollection");
		AssociationUnitConfigIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssociationUnitConfigIDCollection");
		AssociationUnitConfigIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssociationUnitConfigIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AssociationOnFightSkillIDCollection_PropertyAddress, intPtr, "AssociationOnFightSkillIDCollection");
		AssociationOnFightSkillIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssociationOnFightSkillIDCollection");
		AssociationOnFightSkillIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssociationOnFightSkillIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceIDCollection_PropertyAddress, intPtr, "SequenceIDCollection");
		SequenceIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SequenceIDCollection");
		SequenceIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SequenceIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TaskStageCollection_PropertyAddress, intPtr, "TaskStageCollection");
		TaskStageCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TaskStageCollection");
		TaskStageCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TaskStageCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TaskLineCollection_PropertyAddress, intPtr, "TaskLineCollection");
		TaskLineCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TaskLineCollection");
		TaskLineCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TaskLineCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BuffIDCollection_PropertyAddress, intPtr, "BuffIDCollection");
		BuffIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BuffIDCollection");
		BuffIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BuffIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ArchiveLabelCollection_PropertyAddress, intPtr, "ArchiveLabelCollection");
		ArchiveLabelCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ArchiveLabelCollection");
		ArchiveLabelCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ArchiveLabelCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GroupIDCollection_PropertyAddress, intPtr, "GroupIDCollection");
		GroupIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupIDCollection");
		GroupIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AiConversationIDCollection_PropertyAddress, intPtr, "AiConversationIDCollection");
		AiConversationIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AiConversationIDCollection");
		AiConversationIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AiConversationIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TeamIDCollection_PropertyAddress, intPtr, "TeamIDCollection");
		TeamIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TeamIDCollection");
		TeamIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TeamIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IdleAMIdxCollection_PropertyAddress, intPtr, "IdleAMIdxCollection");
		IdleAMIdxCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IdleAMIdxCollection");
		IdleAMIdxCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IdleAMIdxCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LeisureAnimIndexCollection_PropertyAddress, intPtr, "LeisureAnimIndexCollection");
		LeisureAnimIndexCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeisureAnimIndexCollection");
		LeisureAnimIndexCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeisureAnimIndexCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref InteractGroupIDCollection_PropertyAddress, intPtr, "InteractGroupIDCollection");
		InteractGroupIDCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractGroupIDCollection");
		InteractGroupIDCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractGroupIDCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DynamicObstacleCollection_PropertyAddress, intPtr, "DynamicObstacleCollection");
		DynamicObstacleCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DynamicObstacleCollection");
		DynamicObstacleCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DynamicObstacleCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OverlapCollection_PropertyAddress, intPtr, "OverlapCollection");
		OverlapCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverlapCollection");
		OverlapCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverlapCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref InteractorCollection_PropertyAddress, intPtr, "InteractorCollection");
		InteractorCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InteractorCollection");
		InteractorCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InteractorCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnerCollection_PropertyAddress, intPtr, "SpawnerCollection");
		SpawnerCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnerCollection");
		SpawnerCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnerCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UnitCollection_PropertyAddress, intPtr, "UnitCollection");
		UnitCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnitCollection");
		UnitCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnitCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GroupUnitCollection_PropertyAddress, intPtr, "GroupUnitCollection");
		GroupUnitCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupUnitCollection");
		GroupUnitCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupUnitCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref NPCUnitCollection_PropertyAddress, intPtr, "NPCUnitCollection");
		NPCUnitCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NPCUnitCollection");
		NPCUnitCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NPCUnitCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StreamingLevelCollection_PropertyAddress, intPtr, "StreamingLevelCollection");
		StreamingLevelCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingLevelCollection");
		StreamingLevelCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingLevelCollection", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StreamingLevelStateConfigCollection_PropertyAddress, intPtr, "StreamingLevelStateConfigCollection");
		StreamingLevelStateConfigCollection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StreamingLevelStateConfigCollection");
		StreamingLevelStateConfigCollection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StreamingLevelStateConfigCollection", Classes.FArrayProperty);
		FCalliopeParameters_IsValid = intPtr != IntPtr.Zero && FollowPartnerConfigIDCollection_IsValid && AssociationUnitConfigIDCollection_IsValid && AssociationOnFightSkillIDCollection_IsValid && SequenceIDCollection_IsValid && TaskStageCollection_IsValid && TaskLineCollection_IsValid && BuffIDCollection_IsValid && ArchiveLabelCollection_IsValid && GroupIDCollection_IsValid && AiConversationIDCollection_IsValid && TeamIDCollection_IsValid && IdleAMIdxCollection_IsValid && LeisureAnimIndexCollection_IsValid && InteractGroupIDCollection_IsValid && DynamicObstacleCollection_IsValid && OverlapCollection_IsValid && InteractorCollection_IsValid && SpawnerCollection_IsValid && UnitCollection_IsValid && GroupUnitCollection_IsValid && NPCUnitCollection_IsValid && StreamingLevelCollection_IsValid && StreamingLevelStateConfigCollection_IsValid;
		NativeReflection.LogStructIsValid("/Script/Calliope.CalliopeParameters", FCalliopeParameters_IsValid);
	}
}
