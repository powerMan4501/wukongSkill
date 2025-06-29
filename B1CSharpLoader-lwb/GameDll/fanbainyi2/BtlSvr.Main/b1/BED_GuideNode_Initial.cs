using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using Google.Protobuf.Collections;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Initial")]
[Placeable(false)]
[UClass]
[USharpPath("/Script/b1-Managed.BED_GuideNode_Initial")]
public class BED_GuideNode_Initial : BED_GuideNode_Base
{
	public override string GetNodeName()
	{
		return B1CalliopeDef.GuideNode.Initial;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.Category = "Guide";
		base.NodeStyle = ECalliopeNodeStyle.InOut;
		base.InputPins.Clear();
	}

	public override byte[] GetCustomData()
	{
		GuideCustom_Initial guideCustom_Initial = new GuideCustom_Initial();
		FCalliopeParameters calliopeParameters = GetCalliopeAsset().CalliopeParameters;
		foreach (FGsManagedDynamicObstacle item in calliopeParameters.DynamicObstacleCollection)
		{
			ProcessCustom_Param processCustom_Param = new ProcessCustom_Param();
			processCustom_Param.ParamType = (int)item.ParamType;
			Guid configGuid = item.ConfigGuid;
			processCustom_Param.ParamGuid = configGuid.ToString();
			processCustom_Param.ParamString = item.ActorGuid;
			processCustom_Param.ParamInt = (int)item.State;
			FName aliasName = item.AliasName;
			processCustom_Param.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param);
		}
		foreach (FGsManagedOverlap item2 in calliopeParameters.OverlapCollection)
		{
			ProcessCustom_Param processCustom_Param2 = new ProcessCustom_Param();
			processCustom_Param2.ParamType = (int)item2.ParamType;
			Guid configGuid = item2.ConfigGuid;
			processCustom_Param2.ParamGuid = configGuid.ToString();
			processCustom_Param2.ParamString = item2.ActorGuid;
			processCustom_Param2.ParamInt = (int)item2.State;
			FName aliasName = item2.AliasName;
			processCustom_Param2.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param2);
		}
		foreach (FGsManagedInteractor item3 in calliopeParameters.InteractorCollection)
		{
			ProcessCustom_Param processCustom_Param3 = new ProcessCustom_Param();
			processCustom_Param3.ParamType = (int)item3.ParamType;
			Guid configGuid = item3.ConfigGuid;
			processCustom_Param3.ParamGuid = configGuid.ToString();
			processCustom_Param3.ParamString = item3.ActorGuid;
			processCustom_Param3.ParamLinkInt = item3.GroupID.ConfigGuid.ToString();
			FName aliasName = item3.AliasName;
			processCustom_Param3.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param3);
		}
		foreach (FGsManagedSpawner item4 in calliopeParameters.SpawnerCollection)
		{
			ProcessCustom_Param processCustom_Param4 = new ProcessCustom_Param();
			processCustom_Param4.ParamType = (int)item4.ParamType;
			Guid configGuid = item4.ConfigGuid;
			processCustom_Param4.ParamGuid = configGuid.ToString();
			processCustom_Param4.ParamString = item4.ActorGuid;
			processCustom_Param4.ParamInt = (int)item4.State;
			FName aliasName = item4.AliasName;
			processCustom_Param4.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param4);
		}
		foreach (FGsManagedStreamingLevel item5 in calliopeParameters.StreamingLevelCollection)
		{
			ProcessCustom_Param processCustom_Param5 = new ProcessCustom_Param();
			processCustom_Param5.ParamType = (int)item5.ParamType;
			Guid configGuid = item5.ConfigGuid;
			processCustom_Param5.ParamGuid = configGuid.ToString();
			processCustom_Param5.ParamString = $"{item5.PersistentLevelName}.{item5.StreamingLevelName}";
			processCustom_Param5.ParamInt = (int)item5.State;
			FName aliasName = item5.AliasName;
			processCustom_Param5.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param5);
		}
		foreach (FGsManagedUnit item6 in calliopeParameters.UnitCollection)
		{
			ProcessCustom_Param processCustom_Param6 = new ProcessCustom_Param();
			processCustom_Param6.ParamType = (int)item6.ParamType;
			Guid configGuid = item6.ConfigGuid;
			processCustom_Param6.ParamGuid = configGuid.ToString();
			processCustom_Param6.ParamString = item6.ActorGuid;
			processCustom_Param6.ParamInt = (int)item6.State;
			FName aliasName = item6.AliasName;
			processCustom_Param6.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param6);
		}
		foreach (FGsManagedSequenceID item7 in calliopeParameters.SequenceIDCollection)
		{
			ProcessCustom_Param processCustom_Param7 = new ProcessCustom_Param();
			processCustom_Param7.ParamType = (int)item7.ParamType;
			Guid configGuid = item7.ConfigGuid;
			processCustom_Param7.ParamGuid = configGuid.ToString();
			processCustom_Param7.ParamInt = item7.SequenceID;
			FName aliasName = item7.AliasName;
			processCustom_Param7.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param7);
		}
		foreach (FGsManagedTaskStage item8 in calliopeParameters.TaskStageCollection)
		{
			ProcessCustom_Param processCustom_Param8 = new ProcessCustom_Param();
			processCustom_Param8.ParamType = (int)item8.ParamType;
			Guid configGuid = item8.ConfigGuid;
			processCustom_Param8.ParamGuid = configGuid.ToString();
			processCustom_Param8.ParamInt = item8.TaskStage;
			FName aliasName = item8.AliasName;
			processCustom_Param8.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param8);
		}
		foreach (FGsManagedTaskLine item9 in calliopeParameters.TaskLineCollection)
		{
			ProcessCustom_Param processCustom_Param9 = new ProcessCustom_Param();
			processCustom_Param9.ParamType = (int)item9.ParamType;
			Guid configGuid = item9.ConfigGuid;
			processCustom_Param9.ParamGuid = configGuid.ToString();
			processCustom_Param9.ParamInt = item9.TaskLineID;
			FName aliasName = item9.AliasName;
			processCustom_Param9.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param9);
		}
		foreach (FGsManagedBuffID item10 in calliopeParameters.BuffIDCollection)
		{
			ProcessCustom_Param processCustom_Param10 = new ProcessCustom_Param();
			processCustom_Param10.ParamType = (int)item10.ParamType;
			Guid configGuid = item10.ConfigGuid;
			processCustom_Param10.ParamGuid = configGuid.ToString();
			processCustom_Param10.ParamInt = item10.BuffID;
			FName aliasName = item10.AliasName;
			processCustom_Param10.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param10);
		}
		foreach (FGsManagedArchiveLabel item11 in calliopeParameters.ArchiveLabelCollection)
		{
			ProcessCustom_Param processCustom_Param11 = new ProcessCustom_Param();
			processCustom_Param11.ParamType = (int)item11.ParamType;
			Guid configGuid = item11.ConfigGuid;
			processCustom_Param11.ParamGuid = configGuid.ToString();
			FName aliasName = item11.ArchiveLabel;
			processCustom_Param11.ParamString = aliasName.PlainName;
			aliasName = item11.AliasName;
			processCustom_Param11.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param11);
		}
		foreach (FGsManagedNPCUnit item12 in calliopeParameters.NPCUnitCollection)
		{
			ProcessCustom_Param processCustom_Param12 = new ProcessCustom_Param();
			processCustom_Param12.ParamType = (int)item12.ParamType;
			Guid configGuid = item12.ConfigGuid;
			processCustom_Param12.ParamGuid = configGuid.ToString();
			processCustom_Param12.ParamString = item12.ActorGuid;
			FName aliasName = item12.AliasName;
			processCustom_Param12.ParamAliasName = aliasName.PlainName;
			foreach (FGsNPCReferenceInfo item13 in item12.NPCInstanceGroup)
			{
				RepeatedField<ProcessCustom_SubParam> paramSubList = processCustom_Param12.ParamSubList;
				ProcessCustom_SubParam processCustom_SubParam = new ProcessCustom_SubParam();
				configGuid = item13.ConfigGuid;
				processCustom_SubParam.ParamGuid = configGuid.ToString();
				processCustom_SubParam.ParamString = item13.ActorGuid;
				aliasName = item13.AliasName;
				processCustom_SubParam.ParamAliasName = aliasName.PlainName;
				paramSubList.Add(processCustom_SubParam);
			}
			guideCustom_Initial.AssetParams.Add(processCustom_Param12);
		}
		foreach (FGsManagedGroupID item14 in calliopeParameters.GroupIDCollection)
		{
			ProcessCustom_Param processCustom_Param13 = new ProcessCustom_Param();
			processCustom_Param13.ParamType = (int)item14.ParamType;
			Guid configGuid = item14.ConfigGuid;
			processCustom_Param13.ParamGuid = configGuid.ToString();
			processCustom_Param13.ParamInt = item14.InteractorGroupID;
			FName aliasName = item14.AliasName;
			processCustom_Param13.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param13);
		}
		foreach (FGsManagedAiConversationID item15 in calliopeParameters.AiConversationIDCollection)
		{
			ProcessCustom_Param processCustom_Param14 = new ProcessCustom_Param();
			processCustom_Param14.ParamType = (int)item15.ParamType;
			Guid configGuid = item15.ConfigGuid;
			processCustom_Param14.ParamGuid = configGuid.ToString();
			processCustom_Param14.ParamString = string.Join(",", item15.AiConversationIDList);
			FName aliasName = item15.AliasName;
			processCustom_Param14.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param14);
		}
		foreach (FGsManagedAssociationUnitConfigID item16 in calliopeParameters.AssociationUnitConfigIDCollection)
		{
			ProcessCustom_Param processCustom_Param15 = new ProcessCustom_Param();
			processCustom_Param15.ParamType = (int)item16.ParamType;
			Guid configGuid = item16.ConfigGuid;
			processCustom_Param15.ParamGuid = configGuid.ToString();
			processCustom_Param15.ParamInt = item16.ConfigID;
			FName aliasName = item16.AliasName;
			processCustom_Param15.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param15);
		}
		foreach (FGsManagedAssociationOnFightSkillID item17 in calliopeParameters.AssociationOnFightSkillIDCollection)
		{
			ProcessCustom_Param processCustom_Param16 = new ProcessCustom_Param();
			processCustom_Param16.ParamType = (int)item17.ParamType;
			Guid configGuid = item17.ConfigGuid;
			processCustom_Param16.ParamGuid = configGuid.ToString();
			processCustom_Param16.ParamInt = item17.OnFightSkillID;
			FName aliasName = item17.AliasName;
			processCustom_Param16.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param16);
		}
		foreach (FGsManagedFollowPartnerConfigID item18 in calliopeParameters.FollowPartnerConfigIDCollection)
		{
			ProcessCustom_Param processCustom_Param17 = new ProcessCustom_Param();
			processCustom_Param17.ParamType = (int)item18.ParamType;
			Guid configGuid = item18.ConfigGuid;
			processCustom_Param17.ParamGuid = configGuid.ToString();
			processCustom_Param17.ParamInt = item18.ConfigID;
			FName aliasName = item18.AliasName;
			processCustom_Param17.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param17);
		}
		foreach (FGsManagedTeamID item19 in calliopeParameters.TeamIDCollection)
		{
			ProcessCustom_Param processCustom_Param18 = new ProcessCustom_Param();
			processCustom_Param18.ParamType = (int)item19.ParamType;
			Guid configGuid = item19.ConfigGuid;
			processCustom_Param18.ParamGuid = configGuid.ToString();
			processCustom_Param18.ParamInt = item19.TeamID;
			FName aliasName = item19.AliasName;
			processCustom_Param18.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param18);
		}
		foreach (FGsManagedIdleAMIdx item20 in calliopeParameters.IdleAMIdxCollection)
		{
			ProcessCustom_Param processCustom_Param19 = new ProcessCustom_Param();
			processCustom_Param19.ParamType = (int)item20.ParamType;
			Guid configGuid = item20.ConfigGuid;
			processCustom_Param19.ParamGuid = configGuid.ToString();
			processCustom_Param19.ParamInt = item20.IdleAMIdx;
			FName aliasName = item20.AliasName;
			processCustom_Param19.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param19);
		}
		foreach (FGsManagedLeisureAnimIndex item21 in calliopeParameters.LeisureAnimIndexCollection)
		{
			ProcessCustom_Param processCustom_Param20 = new ProcessCustom_Param();
			processCustom_Param20.ParamType = (int)item21.ParamType;
			Guid configGuid = item21.ConfigGuid;
			processCustom_Param20.ParamGuid = configGuid.ToString();
			processCustom_Param20.ParamInt = item21.LeisureAnimIndex;
			FName aliasName = item21.AliasName;
			processCustom_Param20.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param20);
		}
		foreach (FGsManagedInteractGroupID item22 in calliopeParameters.InteractGroupIDCollection)
		{
			ProcessCustom_Param processCustom_Param21 = new ProcessCustom_Param();
			processCustom_Param21.ParamType = (int)item22.ParamType;
			Guid configGuid = item22.ConfigGuid;
			processCustom_Param21.ParamGuid = configGuid.ToString();
			processCustom_Param21.ParamInt = item22.InteractGroupID;
			FName aliasName = item22.AliasName;
			processCustom_Param21.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param21);
		}
		foreach (FGsManagedStreamingLevelStateConfig item23 in calliopeParameters.StreamingLevelStateConfigCollection)
		{
			ProcessCustom_Param processCustom_Param22 = new ProcessCustom_Param();
			processCustom_Param22.ParamType = (int)item23.ParamType;
			Guid configGuid = item23.ConfigGuid;
			processCustom_Param22.ParamGuid = configGuid.ToString();
			processCustom_Param22.ParamInt = item23.LevelID;
			FName aliasName = item23.AliasName;
			processCustom_Param22.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param22);
		}
		foreach (FGsManagedGroupUnit item24 in calliopeParameters.GroupUnitCollection)
		{
			ProcessCustom_Param processCustom_Param23 = new ProcessCustom_Param();
			processCustom_Param23.ParamType = (int)item24.ParamType;
			Guid configGuid = item24.ConfigGuid;
			processCustom_Param23.ParamGuid = configGuid.ToString();
			processCustom_Param23.ParamString = item24.GroupTag.TagName.PlainName;
			processCustom_Param23.ParamInt = (int)item24.State;
			FName aliasName = item24.AliasName;
			processCustom_Param23.ParamAliasName = aliasName.PlainName;
			guideCustom_Initial.AssetParams.Add(processCustom_Param23);
		}
		return guideCustom_Initial.ToByteArray();
	}

	public override uint GetCustomDataVersion()
	{
		return 1u;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_GuideNode_Initial");
	}

	static BED_GuideNode_Initial()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_GuideNode_Initial)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_GuideNode_Initial));
	}
}
