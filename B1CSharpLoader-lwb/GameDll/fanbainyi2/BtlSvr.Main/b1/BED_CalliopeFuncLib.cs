using Google.Protobuf;
using GurCalliopeState;
using UnrealEngine.Runtime;

namespace b1;

public static class BED_CalliopeFuncLib
{
	public static CalliopeCustom_FTamerFamilyMatchChildInfo SerializeToCustomData(this FTamerFamilyMatchChildInfo Data)
	{
		return new CalliopeCustom_FTamerFamilyMatchChildInfo
		{
			Filter = (int)Data.Filter,
			MatchSocketType = (int)Data.MatchSocketType,
			SocketName = Data.SocketName.ToString(),
			ResId = Data.ResId,
			NickName = Data.NickName.TagName.PlainName,
			BuffId = Data.BuffId
		};
	}

	public static ByteString Serialize(this FTamerFamilyMatchChildInfo Data)
	{
		return SerializeToCustomData(Data).ToByteString();
	}

	public static FTamerFamilyMatchChildInfo Deserialize(this CalliopeCustom_FTamerFamilyMatchChildInfo CustomData)
	{
		return new FTamerFamilyMatchChildInfo
		{
			Filter = (EChildActorFilterType)CustomData.Filter,
			MatchSocketType = (ESocketMatchTamerType)CustomData.MatchSocketType,
			SocketName = new FName(CustomData.SocketName),
			ResId = CustomData.ResId,
			NickName = ((string.IsNullOrEmpty(CustomData.NickName) || CustomData.NickName == "None") ? default(FGameplayTag) : GameplayTagExtension.MakeGameplayTag(new FName(CustomData.NickName))),
			BuffId = CustomData.BuffId
		};
	}

	public static FTamerFamilyMatchChildInfo DeserializeTamerFamilyMatchChildInfo(this ByteString Data)
	{
		return Deserialize(CalliopeCustom_FTamerFamilyMatchChildInfo.Parser.ParseFrom(Data));
	}

	public static CalliopeCustom_FChildActorActionInfo SerializeToCustomData(this FChildActorActionInfo Data)
	{
		return new CalliopeCustom_FChildActorActionInfo
		{
			ActionType = (int)Data.ActionType,
			SkillId = Data.SkillId,
			NeedCheckSkillCanCast = Data.NeedCheckSkillCanCast,
			MontageStartSectionName = Data.MontageStartSectionName.ToString(),
			BuffId = Data.BuffId,
			BuffLayer = Data.BuffLayer,
			BuffDuration = Data.BuffDuration,
			TriggerRemoveEffect = Data.TriggerRemoveEffect
		};
	}

	public static ByteString Serialize(this FChildActorActionInfo Data)
	{
		return SerializeToCustomData(Data).ToByteString();
	}

	public static FChildActorActionInfo Deserialize(this CalliopeCustom_FChildActorActionInfo CustomData)
	{
		return new FChildActorActionInfo
		{
			ActionType = (EChildActorActionType)CustomData.ActionType,
			SkillId = CustomData.SkillId,
			NeedCheckSkillCanCast = CustomData.NeedCheckSkillCanCast,
			MontageStartSectionName = new FName(CustomData.MontageStartSectionName),
			BuffId = CustomData.BuffId,
			BuffLayer = CustomData.BuffLayer,
			BuffDuration = CustomData.BuffDuration,
			TriggerRemoveEffect = CustomData.TriggerRemoveEffect
		};
	}

	public static FChildActorActionInfo DeserializeChildActorActionInfo(this ByteString Data)
	{
		return Deserialize(CalliopeCustom_FChildActorActionInfo.Parser.ParseFrom(Data));
	}

	public static CalliopeCustom_FBossPhaseInfo SerializeToCustomData(this FBossPhaseInfo Data)
	{
		return new CalliopeCustom_FBossPhaseInfo
		{
			HasPhasePerformance = Data.HasPhasePerformance
		};
	}

	public static ByteString Serialize(this FBossPhaseInfo Data)
	{
		return SerializeToCustomData(Data).ToByteString();
	}

	public static FBossPhaseInfo Deserialize(this CalliopeCustom_FBossPhaseInfo CustomData)
	{
		return new FBossPhaseInfo
		{
			HasPhasePerformance = CustomData.HasPhasePerformance
		};
	}

	public static FBossPhaseInfo DeserializeBossPhaseInfo(this ByteString Data)
	{
		return Deserialize(CalliopeCustom_FBossPhaseInfo.Parser.ParseFrom(Data));
	}

	public static void RegisterCustomizationDetails()
	{
		FDetectCondition.RegisterCustomizeChildren();
		FTamerFamilyMatchChildInfo.RegisterCustomizeChildren();
		FChildActorActionInfo.RegisterCustomizeChildren();
	}
}
