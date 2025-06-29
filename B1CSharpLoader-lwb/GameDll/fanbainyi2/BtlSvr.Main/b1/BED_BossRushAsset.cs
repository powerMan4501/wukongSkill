using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.BGW;
using b1.Plugins.Calliope;
using CommB1;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BED_BossRushAsset")]
public class BED_BossRushAsset : BED_CalliopeAssetBase
{
	private const string GlobalDAPath = "BGWDataAsset_BossRushLevelConfig'/Game/00Main/DataAsset/DA_BossRushLevelConfig.DA_BossRushLevelConfig'";

	private static bool bCheck1_IsValid;

	private static int bCheck1_Offset;

	private static FFieldAddress bCheck1_PropertyAddress;

	private static bool bCheck2_IsValid;

	private static int bCheck2_Offset;

	private static FFieldAddress bCheck2_PropertyAddress;

	private static bool bCheck3_IsValid;

	private static int bCheck3_Offset;

	private static FFieldAddress bCheck3_PropertyAddress;

	private static bool bCheck4_IsValid;

	private static int bCheck4_Offset;

	private static FFieldAddress bCheck4_PropertyAddress;

	private static bool bCheck5_IsValid;

	private static int bCheck5_Offset;

	private static FFieldAddress bCheck5_PropertyAddress;

	private static bool bCheck6_IsValid;

	private static int bCheck6_Offset;

	private static FFieldAddress bCheck6_PropertyAddress;

	private static bool bRefreshLevel_IsValid;

	private static int bRefreshLevel_Offset;

	private static FFieldAddress bRefreshLevel_PropertyAddress;

	private static bool bCanModifyPersistentLevel_IsValid;

	private static int bCanModifyPersistentLevel_Offset;

	private static FFieldAddress bCanModifyPersistentLevel_PropertyAddress;

	private static bool PersistentLevel_IsValid;

	private static int PersistentLevel_Offset;

	private static bool LevelTag_IsValid;

	private static int LevelTag_Offset;

	private static bool BossRushLevelsLoadSetting_IsValid;

	private static int BossRushLevelsLoadSetting_Offset;

	private static FFieldAddress BossRushLevelsLoadSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<FBossRushLevelState> BossRushLevelsLoadSetting_Marshaler;

	private static bool GeometryLevelsLoadSetting_IsValid;

	private static int GeometryLevelsLoadSetting_Offset;

	private static FFieldAddress GeometryLevelsLoadSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<FBossRushLevelState> GeometryLevelsLoadSetting_Marshaler;

	private static bool SeqLevelsLoadSetting_IsValid;

	private static int SeqLevelsLoadSetting_Offset;

	private static FFieldAddress SeqLevelsLoadSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<FBossRushLevelState> SeqLevelsLoadSetting_Marshaler;

	private static bool ItemLevelsLoadSetting_IsValid;

	private static int ItemLevelsLoadSetting_Offset;

	private static FFieldAddress ItemLevelsLoadSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<FBossRushLevelState> ItemLevelsLoadSetting_Marshaler;

	private static bool LightLevelsLoadSetting_IsValid;

	private static int LightLevelsLoadSetting_Offset;

	private static FFieldAddress LightLevelsLoadSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<FBossRushLevelState> LightLevelsLoadSetting_Marshaler;

	private static bool SupportLevelsLoadSetting_IsValid;

	private static int SupportLevelsLoadSetting_Offset;

	private static FFieldAddress SupportLevelsLoadSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<FBossRushLevelState> SupportLevelsLoadSetting_Marshaler;

	private static bool OtherLevelsLoadSetting_IsValid;

	private static int OtherLevelsLoadSetting_Offset;

	private static FFieldAddress OtherLevelsLoadSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<FBossRushLevelState> OtherLevelsLoadSetting_Marshaler;

	private static bool MonsterLevelsLoadSetting_IsValid;

	private static int MonsterLevelsLoadSetting_Offset;

	private static FFieldAddress MonsterLevelsLoadSetting_PropertyAddress;

	private TArrayReadWriteMarshaler<FBossRushLevelState> MonsterLevelsLoadSetting_Marshaler;

	private static bool bRefreshSeqLevelState_IsValid;

	private static int bRefreshSeqLevelState_Offset;

	private static FFieldAddress bRefreshSeqLevelState_PropertyAddress;

	private static bool RelationSeqLevelList_IsValid;

	private static int RelationSeqLevelList_Offset;

	private static FFieldAddress RelationSeqLevelList_PropertyAddress;

	private TArrayReadWriteMarshaler<string> RelationSeqLevelList_Marshaler;

	private static bool bRefreshPlayerStart_IsValid;

	private static int bRefreshPlayerStart_Offset;

	private static FFieldAddress bRefreshPlayerStart_PropertyAddress;

	private static bool PlayerStartForSingle_IsValid;

	private static int PlayerStartForSingle_Offset;

	private static bool PlayerStartForGroup_IsValid;

	private static int PlayerStartForGroup_Offset;

	private static bool bSyncTamerList_IsValid;

	private static int bSyncTamerList_Offset;

	private static FFieldAddress bSyncTamerList_PropertyAddress;

	private static bool GroupConfigs_IsValid;

	private static int GroupConfigs_Offset;

	private static FFieldAddress GroupConfigs_PropertyAddress;

	private TMapReadWriteMarshaler<int, FBossRushBattleConfigForGroup> GroupConfigs_Marshaler;

	private static bool OverrideDeadDelayDestroyTime_IsValid;

	private static int OverrideDeadDelayDestroyTime_Offset;

	private static FFieldAddress OverrideDeadDelayDestroyTime_PropertyAddress;

	private TMapReadWriteMarshaler<int, float> OverrideDeadDelayDestroyTime_Marshaler;

	private static bool bNote_IsValid;

	private static int bNote_Offset;

	private static FFieldAddress bNote_PropertyAddress;

	private static bool bOpenNeedLevel_IsValid;

	private static int bOpenNeedLevel_Offset;

	private static FFieldAddress bOpenNeedLevel_PropertyAddress;

	private static bool HasRevertCondition_IsValid;

	private static IntPtr HasRevertCondition_FunctionAddress;

	private static int HasRevertCondition_ParamsSize;

	private static bool HasRevertCondition_ReturnValue_IsValid;

	private static int HasRevertCondition_ReturnValue_Offset;

	private static FFieldAddress HasRevertCondition_ReturnValue_PropertyAddress;

	private static bool GetViewType_IsValid;

	private static IntPtr GetViewType_FunctionAddress;

	private static int GetViewType_ParamsSize;

	private static bool GetViewType_ReturnValue_IsValid;

	private static int GetViewType_ReturnValue_Offset;

	private static FFieldAddress GetViewType_ReturnValue_PropertyAddress;

	private static bool IsEditorOnlyCS_IsValid;

	private static IntPtr IsEditorOnlyCS_FunctionAddress;

	private static int IsEditorOnlyCS_ParamsSize;

	private static bool IsEditorOnlyCS_ReturnValue_IsValid;

	private static int IsEditorOnlyCS_ReturnValue_Offset;

	private static FFieldAddress IsEditorOnlyCS_ReturnValue_PropertyAddress;

	private static bool CanManageStates_IsValid;

	private static IntPtr CanManageStates_FunctionAddress;

	private static int CanManageStates_ParamsSize;

	private static bool CanManageStates_ReturnValue_IsValid;

	private static int CanManageStates_ReturnValue_Offset;

	private static FFieldAddress CanManageStates_ReturnValue_PropertyAddress;

	private static bool GetStartNodeClass_IsValid;

	private static IntPtr GetStartNodeClass_FunctionAddress;

	private static int GetStartNodeClass_ParamsSize;

	private static bool GetStartNodeClass_ReturnValue_IsValid;

	private static int GetStartNodeClass_ReturnValue_Offset;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static bool OnRefreshAssetInCS_IsValid;

	private static IntPtr OnRefreshAssetInCS_FunctionAddress;

	private static int OnRefreshAssetInCS_ParamsSize;

	private static bool GetRerouteNodeClass_IsValid;

	private static IntPtr GetRerouteNodeClass_FunctionAddress;

	private static int GetRerouteNodeClass_ParamsSize;

	private static bool GetRerouteNodeClass_ReturnValue_IsValid;

	private static int GetRerouteNodeClass_ReturnValue_Offset;

	private static bool GetPossibleParamsCS_IsValid;

	private static IntPtr GetPossibleParamsCS_FunctionAddress;

	private static int GetPossibleParamsCS_ParamsSize;

	private static bool GetPossibleParamsCS_ParentPropertyName_IsValid;

	private static int GetPossibleParamsCS_ParentPropertyName_Offset;

	private static FFieldAddress GetPossibleParamsCS_ParentPropertyName_PropertyAddress;

	private static bool GetPossibleParamsCS_PropertyName_IsValid;

	private static int GetPossibleParamsCS_PropertyName_Offset;

	private static FFieldAddress GetPossibleParamsCS_PropertyName_PropertyAddress;

	private static bool GetPossibleParamsCS_OutParamArray_IsValid;

	private static int GetPossibleParamsCS_OutParamArray_Offset;

	private static FFieldAddress GetPossibleParamsCS_OutParamArray_PropertyAddress;

	private static bool GetPossibleParamsCS_ReturnValue_IsValid;

	private static int GetPossibleParamsCS_ReturnValue_Offset;

	private static FFieldAddress GetPossibleParamsCS_ReturnValue_PropertyAddress;

	private static bool PostRefreshAssetInCS_IsValid;

	private static IntPtr PostRefreshAssetInCS_FunctionAddress;

	private static int PostRefreshAssetInCS_ParamsSize;

	private static bool GetParamDisplayNameCS_IsValid;

	private static IntPtr GetParamDisplayNameCS_FunctionAddress;

	private static int GetParamDisplayNameCS_ParamsSize;

	private static bool GetParamDisplayNameCS_PropertyName_IsValid;

	private static int GetParamDisplayNameCS_PropertyName_Offset;

	private static FFieldAddress GetParamDisplayNameCS_PropertyName_PropertyAddress;

	private static bool GetParamDisplayNameCS_InConfigGuid_IsValid;

	private static int GetParamDisplayNameCS_InConfigGuid_Offset;

	private static FFieldAddress GetParamDisplayNameCS_InConfigGuid_PropertyAddress;

	private static bool GetParamDisplayNameCS_OutDisplayName_IsValid;

	private static int GetParamDisplayNameCS_OutDisplayName_Offset;

	private static FFieldAddress GetParamDisplayNameCS_OutDisplayName_PropertyAddress;

	private static bool GetParamDisplayNameCS_ReturnValue_IsValid;

	private static int GetParamDisplayNameCS_ReturnValue_Offset;

	private static FFieldAddress GetParamDisplayNameCS_ReturnValue_PropertyAddress;

	private static bool GetExtraDefaultInputNodes_IsValid;

	private static IntPtr GetExtraDefaultInputNodes_FunctionAddress;

	private static int GetExtraDefaultInputNodes_ParamsSize;

	private static bool GetExtraDefaultInputNodes_OutClasses_IsValid;

	private static int GetExtraDefaultInputNodes_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultInputNodes_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultInputNodes_ReturnValue_IsValid;

	private static int GetExtraDefaultInputNodes_ReturnValue_Offset;

	private static bool GetExtraDefaultOutputNodes_IsValid;

	private static IntPtr GetExtraDefaultOutputNodes_FunctionAddress;

	private static int GetExtraDefaultOutputNodes_ParamsSize;

	private static bool GetExtraDefaultOutputNodes_OutClasses_IsValid;

	private static int GetExtraDefaultOutputNodes_OutClasses_Offset;

	private static FFieldAddress GetExtraDefaultOutputNodes_OutClasses_PropertyAddress;

	private static bool GetExtraDefaultOutputNodes_ReturnValue_IsValid;

	private static int GetExtraDefaultOutputNodes_ReturnValue_Offset;

	public Dictionary<string, BED_BossRushNode_ResetGroup> GroupNodes { get; } = new Dictionary<string, BED_BossRushNode_ResetGroup>();

	[UProperty(PropFlags.Transient)]
	[Category("策划检查项")]
	[DisplayName("检查场景关卡都配置成加载(关键词匹配）")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bCheck1")]
	public bool bCheck1
	{
		get
		{
			CheckDestroyed();
			if (!bCheck1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck1");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheck1_Offset), 0, bCheck1_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheck1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck1");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheck1_Offset), 0, bCheck1_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("检查出生点、战斗触发盒放置正确")]
	[UProperty(PropFlags.Transient)]
	[VisibleAnywhere]
	[Category("策划检查项")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bCheck2")]
	public bool bCheck2
	{
		get
		{
			CheckDestroyed();
			if (!bCheck2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck2");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheck2_Offset), 0, bCheck2_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheck2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck2");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheck2_Offset), 0, bCheck2_PropertyAddress.Address, value);
			}
		}
	}

	[Category("策划检查项")]
	[DisplayName("检查出生点位置是否同步")]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bCheck3")]
	public bool bCheck3
	{
		get
		{
			CheckDestroyed();
			if (!bCheck3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck3");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheck3_Offset), 0, bCheck3_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheck3_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck3");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheck3_Offset), 0, bCheck3_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检查动态阻挡是否配置成不可通过")]
	[Category("策划检查项")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bCheck4")]
	public bool bCheck4
	{
		get
		{
			CheckDestroyed();
			if (!bCheck4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck4");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheck4_Offset), 0, bCheck4_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheck4_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck4");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheck4_Offset), 0, bCheck4_PropertyAddress.Address, value);
			}
		}
	}

	[Category("策划检查项")]
	[UProperty(PropFlags.Transient)]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检查连战（如有）ExtendID是否需要配置")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bCheck5")]
	public bool bCheck5
	{
		get
		{
			CheckDestroyed();
			if (!bCheck5_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck5");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheck5_Offset), 0, bCheck5_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheck5_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck5");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheck5_Offset), 0, bCheck5_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[BlueprintReadWrite]
	[DisplayName("检查Seq（如有）关联是否更新")]
	[Category("策划检查项")]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bCheck6")]
	public bool bCheck6
	{
		get
		{
			CheckDestroyed();
			if (!bCheck6_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck6");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheck6_Offset), 0, bCheck6_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheck6_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCheck6");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheck6_Offset), 0, bCheck6_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("关卡配置")]
	[EditAnywhere]
	[DisplayName("更新当前关卡列表")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bRefreshLevel")]
	public bool bRefreshLevel
	{
		get
		{
			CheckDestroyed();
			if (!bRefreshLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bRefreshLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRefreshLevel_Offset), 0, bRefreshLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRefreshLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bRefreshLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRefreshLevel_Offset), 0, bRefreshLevel_PropertyAddress.Address, value);
			}
		}
	}

	[Category("关卡配置")]
	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("可修改当前关卡")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bCanModifyPersistentLevel")]
	public bool bCanModifyPersistentLevel
	{
		get
		{
			CheckDestroyed();
			if (!bCanModifyPersistentLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCanModifyPersistentLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanModifyPersistentLevel_Offset), 0, bCanModifyPersistentLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanModifyPersistentLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bCanModifyPersistentLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanModifyPersistentLevel_Offset), 0, bCanModifyPersistentLevel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("关卡配置")]
	[UMeta(MDProp.EditCondition, "bCanModifyPersistentLevel")]
	[DisplayName("当前持久关卡")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:PersistentLevel")]
	public FGsSmartParam PersistentLevel
	{
		get
		{
			CheckDestroyed();
			if (!PersistentLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:PersistentLevel");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, PersistentLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PersistentLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:PersistentLevel");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, PersistentLevel_Offset), value);
			}
		}
	}

	[Category("关卡配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("关卡标记")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:LevelTag")]
	public FName LevelTag
	{
		get
		{
			CheckDestroyed();
			if (!LevelTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:LevelTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LevelTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:LevelTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LevelTag_Offset), value);
			}
		}
	}

	[DisplayName("BR关卡加载配置")]
	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[Category("关卡配置")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:BossRushLevelsLoadSetting")]
	public TArrayReadWrite<FBossRushLevelState> BossRushLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!BossRushLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:BossRushLevelsLoadSetting");
				return null;
			}
			if (BossRushLevelsLoadSetting_Marshaler == null)
			{
				BossRushLevelsLoadSetting_Marshaler = new TArrayReadWriteMarshaler<FBossRushLevelState>(1, BossRushLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return BossRushLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, BossRushLevelsLoadSetting_Offset));
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("场景关卡加载配置")]
	[Category("关卡配置")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GeometryLevelsLoadSetting")]
	public TArrayReadWrite<FBossRushLevelState> GeometryLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!GeometryLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:GeometryLevelsLoadSetting");
				return null;
			}
			if (GeometryLevelsLoadSetting_Marshaler == null)
			{
				GeometryLevelsLoadSetting_Marshaler = new TArrayReadWriteMarshaler<FBossRushLevelState>(1, GeometryLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return GeometryLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, GeometryLevelsLoadSetting_Offset));
		}
	}

	[Category("关卡配置")]
	[DisplayName("Seq关卡加载配置")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:SeqLevelsLoadSetting")]
	public TArrayReadWrite<FBossRushLevelState> SeqLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!SeqLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:SeqLevelsLoadSetting");
				return null;
			}
			if (SeqLevelsLoadSetting_Marshaler == null)
			{
				SeqLevelsLoadSetting_Marshaler = new TArrayReadWriteMarshaler<FBossRushLevelState>(1, SeqLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return SeqLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, SeqLevelsLoadSetting_Offset));
		}
	}

	[Category("关卡配置")]
	[DisplayName("Item关卡加载配置")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:ItemLevelsLoadSetting")]
	public TArrayReadWrite<FBossRushLevelState> ItemLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!ItemLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:ItemLevelsLoadSetting");
				return null;
			}
			if (ItemLevelsLoadSetting_Marshaler == null)
			{
				ItemLevelsLoadSetting_Marshaler = new TArrayReadWriteMarshaler<FBossRushLevelState>(1, ItemLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return ItemLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, ItemLevelsLoadSetting_Offset));
		}
	}

	[UProperty]
	[Category("关卡配置")]
	[DisplayName("灯光关卡加载配置")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:LightLevelsLoadSetting")]
	public TArrayReadWrite<FBossRushLevelState> LightLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!LightLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:LightLevelsLoadSetting");
				return null;
			}
			if (LightLevelsLoadSetting_Marshaler == null)
			{
				LightLevelsLoadSetting_Marshaler = new TArrayReadWriteMarshaler<FBossRushLevelState>(1, LightLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return LightLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, LightLevelsLoadSetting_Offset));
		}
	}

	[DisplayName("功能关卡加载配置")]
	[UProperty]
	[Category("关卡配置")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:SupportLevelsLoadSetting")]
	public TArrayReadWrite<FBossRushLevelState> SupportLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!SupportLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:SupportLevelsLoadSetting");
				return null;
			}
			if (SupportLevelsLoadSetting_Marshaler == null)
			{
				SupportLevelsLoadSetting_Marshaler = new TArrayReadWriteMarshaler<FBossRushLevelState>(1, SupportLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return SupportLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, SupportLevelsLoadSetting_Offset));
		}
	}

	[Category("关卡配置")]
	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("其他关卡加载配置")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:OtherLevelsLoadSetting")]
	public TArrayReadWrite<FBossRushLevelState> OtherLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!OtherLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:OtherLevelsLoadSetting");
				return null;
			}
			if (OtherLevelsLoadSetting_Marshaler == null)
			{
				OtherLevelsLoadSetting_Marshaler = new TArrayReadWriteMarshaler<FBossRushLevelState>(1, OtherLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return OtherLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, OtherLevelsLoadSetting_Offset));
		}
	}

	[BlueprintReadWrite]
	[VisibleAnywhere]
	[DisplayName("Monster关卡加载配置")]
	[Category("关卡配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:MonsterLevelsLoadSetting")]
	public TArrayReadWrite<FBossRushLevelState> MonsterLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!MonsterLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:MonsterLevelsLoadSetting");
				return null;
			}
			if (MonsterLevelsLoadSetting_Marshaler == null)
			{
				MonsterLevelsLoadSetting_Marshaler = new TArrayReadWriteMarshaler<FBossRushLevelState>(1, MonsterLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return MonsterLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, MonsterLevelsLoadSetting_Offset));
		}
	}

	[Category("Seq关卡关联")]
	[DisplayName("更新Seq加载配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bRefreshSeqLevelState")]
	public bool bRefreshSeqLevelState
	{
		get
		{
			CheckDestroyed();
			if (!bRefreshSeqLevelState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bRefreshSeqLevelState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRefreshSeqLevelState_Offset), 0, bRefreshSeqLevelState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRefreshSeqLevelState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bRefreshSeqLevelState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRefreshSeqLevelState_Offset), 0, bRefreshSeqLevelState_PropertyAddress.Address, value);
			}
		}
	}

	[VisibleAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("关联的Seq关卡")]
	[Category("Seq关卡关联")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:RelationSeqLevelList")]
	public TArrayReadWrite<string> RelationSeqLevelList
	{
		get
		{
			CheckDestroyed();
			if (!RelationSeqLevelList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:RelationSeqLevelList");
				return null;
			}
			if (RelationSeqLevelList_Marshaler == null)
			{
				RelationSeqLevelList_Marshaler = new TArrayReadWriteMarshaler<string>(1, RelationSeqLevelList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return RelationSeqLevelList_Marshaler.FromNative(IntPtr.Add(base.Address, RelationSeqLevelList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("更新出生点位置")]
	[Category("出生点配置")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bRefreshPlayerStart")]
	public bool bRefreshPlayerStart
	{
		get
		{
			CheckDestroyed();
			if (!bRefreshPlayerStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bRefreshPlayerStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRefreshPlayerStart_Offset), 0, bRefreshPlayerStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRefreshPlayerStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bRefreshPlayerStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRefreshPlayerStart_Offset), 0, bRefreshPlayerStart_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("再战出生点")]
	[Category("出生点配置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:PlayerStartForSingle")]
	public FTransform PlayerStartForSingle
	{
		get
		{
			CheckDestroyed();
			if (!PlayerStartForSingle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:PlayerStartForSingle");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, PlayerStartForSingle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerStartForSingle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:PlayerStartForSingle");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, PlayerStartForSingle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("连战出生点")]
	[Category("出生点配置")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:PlayerStartForGroup")]
	public FTransform PlayerStartForGroup
	{
		get
		{
			CheckDestroyed();
			if (!PlayerStartForGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:PlayerStartForGroup");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, PlayerStartForGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerStartForGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:PlayerStartForGroup");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, PlayerStartForGroup_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("同步Tamer列表")]
	[Category("连战配置")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bSyncTamerList")]
	public bool bSyncTamerList
	{
		get
		{
			CheckDestroyed();
			if (!bSyncTamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bSyncTamerList");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSyncTamerList_Offset), 0, bSyncTamerList_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSyncTamerList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bSyncTamerList");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSyncTamerList_Offset), 0, bSyncTamerList_PropertyAddress.Address, value);
			}
		}
	}

	[Category("连战配置")]
	[DisplayName("连战配置列表")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GroupConfigs")]
	public TMapReadWrite<int, FBossRushBattleConfigForGroup> GroupConfigs
	{
		get
		{
			CheckDestroyed();
			if (!GroupConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:GroupConfigs");
				return null;
			}
			if (GroupConfigs_Marshaler == null)
			{
				GroupConfigs_Marshaler = new TMapReadWriteMarshaler<int, FBossRushBattleConfigForGroup>(1, GroupConfigs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FBossRushBattleConfigForGroup, FBossRushBattleConfigForGroup>.FromNative, CachedMarshalingDelegates<FBossRushBattleConfigForGroup, FBossRushBattleConfigForGroup>.ToNative);
			}
			return GroupConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, GroupConfigs_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("死亡销毁时间覆盖（表格ID-时间）")]
	[Category("表格数据覆盖")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:OverrideDeadDelayDestroyTime")]
	public TMapReadWrite<int, float> OverrideDeadDelayDestroyTime
	{
		get
		{
			CheckDestroyed();
			if (!OverrideDeadDelayDestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:OverrideDeadDelayDestroyTime");
				return null;
			}
			if (OverrideDeadDelayDestroyTime_Marshaler == null)
			{
				OverrideDeadDelayDestroyTime_Marshaler = new TMapReadWriteMarshaler<int, float>(1, OverrideDeadDelayDestroyTime_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return OverrideDeadDelayDestroyTime_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideDeadDelayDestroyTime_Offset));
		}
	}

	[VisibleAnywhere]
	[Category("编辑器便捷操作")]
	[DisplayName("上面关卡手动配置成加载后，可以在这里一键加载")]
	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bNote")]
	public bool bNote
	{
		get
		{
			CheckDestroyed();
			if (!bNote_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bNote");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNote_Offset), 0, bNote_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNote_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bNote");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNote_Offset), 0, bNote_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty(PropFlags.Transient)]
	[Category("编辑器便捷操作")]
	[DisplayName("一键加载关卡")]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:bOpenNeedLevel")]
	public bool bOpenNeedLevel
	{
		get
		{
			CheckDestroyed();
			if (!bOpenNeedLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bOpenNeedLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bOpenNeedLevel_Offset), 0, bOpenNeedLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bOpenNeedLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BossRushAsset:bOpenNeedLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bOpenNeedLevel_Offset), 0, bOpenNeedLevel_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:IsEditorOnlyCS")]
	protected override bool IsEditorOnlyCS_Implementation()
	{
		return true;
	}

	public override bool HasDeleteNodeLimit()
	{
		return false;
	}

	protected override bool CorrectnessCheck(out string OutErrorMessage)
	{
		OutErrorMessage = "";
		bool flag = false;
		StringBuilder stringBuilder = new StringBuilder();
		List<UCalliopeNode> validNodes = GetValidNodes();
		foreach (UCalliopeNode item in validNodes)
		{
			if (item.NodeHasError)
			{
				item.NodeHasError = false;
			}
		}
		if (CorrectnessCheckForBossRush(out var OutErrorMessage2))
		{
			flag = true;
			stringBuilder.AppendLine(OutErrorMessage2);
		}
		if (CheckUnitInfo(validNodes, out var OutErrorMessage3))
		{
			flag = true;
			stringBuilder.AppendLine(OutErrorMessage3);
		}
		if (CheckInputConnections(validNodes, out var OutErrorMessage4))
		{
			flag = true;
			stringBuilder.AppendLine(OutErrorMessage4);
		}
		if (flag)
		{
			OutErrorMessage = stringBuilder.ToString();
			return false;
		}
		return true;
	}

	private bool CheckUnitInfo(List<UCalliopeNode> CheckNodes, out string OutErrorMessage)
	{
		bool result = false;
		OutErrorMessage = "";
		StringBuilder stringBuilder = new StringBuilder();
		foreach (FGsManagedNPCUnit item in base.CalliopeParameters.NPCUnitCollection)
		{
			if (item.NPCInstanceGroup.Count <= 0)
			{
				continue;
			}
			HashSet<FName> hashSet = new HashSet<FName>();
			bool flag = false;
			foreach (FGsNPCReferenceInfo item2 in item.NPCInstanceGroup)
			{
				if (item2.AliasName == FName.None || hashSet.Contains(item2.AliasName))
				{
					flag = true;
					break;
				}
				hashSet.Add(item2.AliasName);
			}
			if (flag)
			{
				result = true;
				stringBuilder.AppendLine($"CPG管理的NPC({item.AliasName})，其NPC实例组内的实例名不能为\"None\"或重复");
			}
		}
		List<UCalliopeNode> list = base.Nodes.Values.ToList();
		for (int i = 0; i < CheckNodes.Count; i++)
		{
			UCalliopeNode Node = CheckNodes[i];
			BED_BossRushNode_TemplateBase bED_BossRushNode_TemplateBase = Node as BED_BossRushNode_TemplateBase;
			if (bED_BossRushNode_TemplateBase == null)
			{
				continue;
			}
			int num = list.FindIndex((UCalliopeNode r) => r == Node);
			foreach (FGsNPCUnitPoliceConfig NpcUnit in bED_BossRushNode_TemplateBase.SceneObjPoliceConfig.NPCUnitCollection)
			{
				FName aliasName = base.CalliopeParameters.NPCUnitCollection.Find((FGsManagedNPCUnit r) => r.ConfigGuid == NpcUnit.ConfigGuid).AliasName;
				int TeamID;
				bool teamIDBySmartParam = GetTeamIDBySmartParam(NpcUnit.ManagedTeamIDParam.ActualParam, out TeamID);
				if (!teamIDBySmartParam || TeamID <= 0)
				{
					result = true;
					if (teamIDBySmartParam)
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})队伍不正确(值:{TeamID} <= 0)");
					}
					else
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})队伍【配置丢失】");
					}
				}
				int IdleAMIdx;
				bool idleAMIdxBySmartParam = GetIdleAMIdxBySmartParam(NpcUnit.ManagedIdleAMIdxParam.ActualParam, out IdleAMIdx);
				if (!idleAMIdxBySmartParam || IdleAMIdx < 0)
				{
					result = true;
					if (idleAMIdxBySmartParam)
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})待机动画不正确(值:{NpcUnit.ManagedIdleAMIdx.ActualParam} < 0)");
					}
					else
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})待机动画【配置丢失】");
					}
				}
				int LeisureAnimIndex;
				bool leisureAnimIndexBySmartParam = GetLeisureAnimIndexBySmartParam(NpcUnit.ManagedLeisureAnimIndexParam.ActualParam, out LeisureAnimIndex);
				if (!leisureAnimIndexBySmartParam || LeisureAnimIndex < -1)
				{
					result = true;
					if (leisureAnimIndexBySmartParam)
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})Leisure动画不正确(值:{NpcUnit.ManagedLeisureAnimIndex.ActualParam} < -1)");
					}
					else
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})Leisure动画【配置丢失】");
					}
				}
				int InteractGroupID;
				bool interactGroupIDBySmartParam = GetInteractGroupIDBySmartParam(NpcUnit.ManagedInteractGroupIDParam.ActualParam, out InteractGroupID);
				if (!interactGroupIDBySmartParam || InteractGroupID < -1)
				{
					result = true;
					if (interactGroupIDBySmartParam)
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})交互动作组不正确(值:{NpcUnit.ManagedInteractGroupID.ActualParam} < -1)");
					}
					else
					{
						stringBuilder.AppendLine($"节点[{num}]管理的NPC({aliasName})交互动作组【配置丢失】");
					}
				}
			}
		}
		OutErrorMessage = stringBuilder.ToString();
		return result;
	}

	private bool CheckInputConnections(List<UCalliopeNode> CheckNodes, out string OutErrorMessage)
	{
		bool result = false;
		OutErrorMessage = "";
		StringBuilder stringBuilder = new StringBuilder();
		Dictionary<FCalliopeGuid, List<FName>> dictionary = new Dictionary<FCalliopeGuid, List<FName>>();
		foreach (UCalliopeNode CheckNode in CheckNodes)
		{
			foreach (KeyValuePair<FName, FCalliopeConnectedPin> connection in CheckNode.GetConnections())
			{
				if (dictionary.ContainsKey(connection.Value.NodeGuid))
				{
					dictionary[connection.Value.NodeGuid].Add(connection.Key);
					continue;
				}
				dictionary.Add(connection.Value.NodeGuid, new List<FName> { connection.Key });
			}
		}
		foreach (KeyValuePair<FCalliopeGuid, List<FName>> item in dictionary)
		{
			if (item.Value.Count <= 1)
			{
				continue;
			}
			BED_BossRushNode_TemplateBase Node = GetNode(item.Key) as BED_BossRushNode_TemplateBase;
			if (Node != null && !GetNodes().ContainsKey(Node.ParentNode.NodeGuid) && !CheckNodeManagedItemsAllModified(Node, out var OutErrorMessage2))
			{
				result = true;
				stringBuilder.AppendLine($"节点[{base.Nodes.Values.ToList().FindIndex((UCalliopeNode r) => r == Node)}]存在{item.Value.Count}个输入状态，其管理的物件与单位{OutErrorMessage2}不可使用“与前状态保持一致”配置");
			}
		}
		OutErrorMessage += stringBuilder.ToString();
		return result;
	}

	private bool CheckNodeManagedItemsAllModified(BED_BossRushNode_TemplateBase Node, out string OutErrorMessage)
	{
		bool result = true;
		OutErrorMessage = "";
		foreach (FGsDynamicObstaclePoliceConfig item in Node.SceneObjPoliceConfig.DynamicObstacleCollection)
		{
			if (item.ManagePolice == EGsDynamicObstacleManagePolice.SameAsPrevious)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item.ConfigGuid), "", out var OutDisplayName))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName + " ";
				}
			}
		}
		foreach (FGsOverlapPoliceConfig item2 in Node.SceneObjPoliceConfig.OverlapCollection)
		{
			if (item2.ManagePolice == EGsOverlapManagePolice.SameAsPrevious)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item2.ConfigGuid), "", out var OutDisplayName2))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName2 + " ";
				}
			}
		}
		foreach (FGsInteractorPoliceConfig item3 in Node.SceneObjPoliceConfig.InteractorCollection)
		{
			if (!item3.CanModify)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item3.ConfigGuid), "", out var OutDisplayName3))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName3 + " ";
				}
			}
		}
		foreach (FGsSpawnerPoliceConfig item4 in Node.SceneObjPoliceConfig.SpawnerCollection)
		{
			if (item4.ManagePolice == EGsSpawnerManagePolice.SameAsPrevious)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item4.ConfigGuid), "", out var OutDisplayName4))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName4 + " ";
				}
			}
		}
		foreach (FGsUnitPoliceConfig item5 in Node.SceneObjPoliceConfig.UnitCollection)
		{
			if (item5.ManagePolice == EGsUnitManagePolice.SameAsPrevious)
			{
				result = false;
				if (GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item5.ConfigGuid), "", out var OutDisplayName5))
				{
					OutErrorMessage = OutErrorMessage + OutDisplayName5 + " ";
				}
			}
		}
		foreach (FGsNPCUnitPoliceConfig item6 in Node.SceneObjPoliceConfig.NPCUnitCollection)
		{
			bool flag = false;
			foreach (FGsManagedNPCUnit item7 in base.CalliopeParameters.NPCUnitCollection)
			{
				if (item7.ConfigGuid == item6.ConfigGuid)
				{
					flag = item7.NPCInstanceGroup.Count > 0;
					break;
				}
			}
			if ((!item6.ManagedTeamIDParam.CanModify || !item6.ManagedIdleAMIdxParam.CanModify || !item6.ManagedInteractGroupIDParam.CanModify || !(flag ? item6.ManagedActiveInstance.CanModify : item6.ManagedShowState.CanModify)) && GetParameterDisplayNameByConfigGuid(GameplayTagExtension.ConvertToCalliopeGuid(item6.ConfigGuid), "", out var OutDisplayName6))
			{
				OutErrorMessage = OutErrorMessage + OutDisplayName6 + " ";
			}
		}
		OutErrorMessage = "( " + OutErrorMessage + ")";
		return result;
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:OnRefreshAssetInCS")]
	protected override void OnRefreshAssetInCS_Implementation()
	{
		GroupNodes.Clear();
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:PostRefreshAssetInCS")]
	protected override void PostRefreshAssetInCS_Implementation()
	{
		foreach (UCalliopeNode value in base.Nodes.Values)
		{
			if (value is BED_BossRushNode_Initial bED_BossRushNode_Initial)
			{
				bED_BossRushNode_Initial.RefreshTemplateNodeState();
				break;
			}
		}
		foreach (UCalliopeNode value2 in base.Nodes.Values)
		{
			if (value2 is BED_BossRushNode_GroupStart bED_BossRushNode_GroupStart)
			{
				bED_BossRushNode_GroupStart.RefreshTemplateNodeState();
			}
		}
	}

	public void RegisterGroup(string GroupName, BED_BossRushNode_ResetGroup GroupNode)
	{
		if (!string.IsNullOrEmpty(GroupName) && !GroupNodes.ContainsKey(GroupName))
		{
			GroupNodes.Add(GroupName, GroupNode);
		}
	}

	public bool TryGetGroupNode(string GroupName, out BED_BossRushNode_ResetGroup OutGroupNode)
	{
		OutGroupNode = null;
		if (string.IsNullOrEmpty(GroupName))
		{
			return false;
		}
		return GroupNodes.TryGetValue(GroupName, out OutGroupNode);
	}

	public string GetUnitGuidDisplayName(string Guid)
	{
		return Guid;
	}

	public string GetObjGuidDisplayName(string Guid)
	{
		return Guid;
	}

	public List<UCalliopeNode> GetValidNodes()
	{
		List<UCalliopeNode> list = new List<UCalliopeNode>();
		List<UCalliopeNode> list2 = new List<UCalliopeNode>();
		foreach (UCalliopeNode item in GetNodes().Values.ToList())
		{
			if (item is BED_BossRushNode_Initial)
			{
				list.Add(item);
				list2.Add(item);
			}
		}
		while (list2.Count > 0)
		{
			foreach (KeyValuePair<FName, FCalliopeConnectedPin> connection in list2[0].GetConnections())
			{
				UCalliopeNode node = GetNode(connection.Value.NodeGuid);
				if (!list.Contains(node))
				{
					list.Add(node);
					list2.Add(node);
				}
			}
			list2.RemoveAt(0);
		}
		return list;
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:CanManageStates")]
	public override bool CanManageStates_Implementation()
	{
		return true;
	}

	protected override bool CanCalliopeAssetNodeLog()
	{
		return true;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:HasRevertCondition")]
	public bool HasRevertCondition()
	{
		foreach (UCalliopeNode value in base.Nodes.Values)
		{
			if (value is BED_BossRushNode_Idle bED_BossRushNode_Idle)
			{
				foreach (FCompositeTransitionCondition_Idle transitionCondition in bED_BossRushNode_Idle.TransitionConditions)
				{
					if (transitionCondition.bReverseCondition)
					{
						return true;
					}
					if (transitionCondition.bUseCompositeCondition)
					{
						foreach (FTransitionCondition_Idle condition in transitionCondition.Conditions)
						{
							if (condition.bReverseCondition)
							{
								return true;
							}
						}
					}
					if (transitionCondition.Single.bReverseCondition)
					{
						return true;
					}
				}
			}
			if (value is BED_BossRushNode_Battle bED_BossRushNode_Battle)
			{
				foreach (FCompositeTransitionCondition_Battle transitionCondition2 in bED_BossRushNode_Battle.TransitionConditions)
				{
					if (transitionCondition2.bReverseCondition)
					{
						return true;
					}
					if (transitionCondition2.bUseCompositeCondition)
					{
						foreach (FTransitionCondition_Battle condition2 in transitionCondition2.Conditions)
						{
							if (condition2.bReverseCondition)
							{
								return true;
							}
						}
					}
					if (transitionCondition2.Single.bReverseCondition)
					{
						return true;
					}
				}
			}
			if (!(value is BED_BossRushNode_ResetGroup bED_BossRushNode_ResetGroup))
			{
				continue;
			}
			foreach (FCompositeTransitionCondition_Group transitionCondition3 in bED_BossRushNode_ResetGroup.TransitionConditions)
			{
				if (transitionCondition3.bReverseCondition)
				{
					return true;
				}
				if (transitionCondition3.bUseCompositeCondition)
				{
					foreach (FTransitionCondition_Group condition3 in transitionCondition3.Conditions)
					{
						if (condition3.bReverseCondition)
						{
							return true;
						}
					}
				}
				if (transitionCondition3.Single.bReverseCondition)
				{
					return true;
				}
			}
		}
		return false;
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GetViewType")]
	protected override ECalliopeViewType GetViewType_Implementation()
	{
		return ECalliopeViewType.BossRush;
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GetRerouteNodeClass")]
	protected override TSubclassOf<UObject> GetRerouteNodeClass_Implementation()
	{
		return UClass.GetClass<BED_BossRushNode_Reroute>();
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GetStartNodeClass")]
	protected override TSubclassOf<UObject> GetStartNodeClass_Implementation()
	{
		return UClass.GetClass<BED_BossRushNode_Initial>();
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GetExtraDefaultInputNodes")]
	protected override int GetExtraDefaultInputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GetExtraDefaultOutputNodes")]
	protected override int GetExtraDefaultOutputNodes_Implementation(out List<TSubclassOf<UObject>> OutClasses)
	{
		OutClasses = new List<TSubclassOf<UObject>>();
		return 0;
	}

	protected bool CorrectnessCheckForBossRush(out string OutErrorMessage)
	{
		bool result = false;
		OutErrorMessage = "";
		BED_BossRushNode_Wait bED_BossRushNode_Wait = null;
		BED_BossRushNode_Initial bED_BossRushNode_Initial = null;
		foreach (KeyValuePair<FCalliopeGuid, UCalliopeNode> node in base.Nodes)
		{
			UCalliopeNode value = node.Value;
			if (value is BED_BossRushNode_Wait bED_BossRushNode_Wait2)
			{
				if (bED_BossRushNode_Wait != null)
				{
					result = true;
					OutErrorMessage += "Wait节点只能有一个！";
					break;
				}
				bED_BossRushNode_Wait = bED_BossRushNode_Wait2;
			}
			else if (value is BED_BossRushNode_Initial bED_BossRushNode_Initial2)
			{
				if (bED_BossRushNode_Initial != null)
				{
					result = true;
					OutErrorMessage += "Initial节点只能有一个";
					break;
				}
				bED_BossRushNode_Initial = bED_BossRushNode_Initial2;
			}
		}
		if (bED_BossRushNode_Initial == null || bED_BossRushNode_Wait == null)
		{
			result = true;
			OutErrorMessage += "未找到Initial节点或Wait节点";
		}
		else if (!bED_BossRushNode_Initial.IsOutputConnectTo(GameplayTagExtension.ConvertToCalliopeGuid(bED_BossRushNode_Wait.NodeGuid)))
		{
			result = true;
			OutErrorMessage += "Wait节点必须连接Initial节点";
		}
		bool flag = true;
		Guid configGuid = PersistentLevel.ConfigGuid;
		BGWDataAsset_BossRushLevelConfig globalLevelConfigDA = GetGlobalLevelConfigDA();
		if (globalLevelConfigDA != null)
		{
			foreach (UBossRushLevelConfig levelConfig in globalLevelConfigDA.LevelConfigs)
			{
				if (levelConfig != null && GameplayTagExtension.ConvertToGuid(levelConfig.ConfigGuid) == configGuid)
				{
					flag = false;
					break;
				}
			}
		}
		if (flag)
		{
			result = true;
			OutErrorMessage += "DA中未找到对应的关卡配置，请检查关卡加载配置！";
		}
		return result;
	}

	public BossRushCustom_InitialV2 GetInitialNodeData()
	{
		BossRushCustom_InitialV2 bossRushCustom_InitialV = new BossRushCustom_InitialV2();
		bossRushCustom_InitialV.AssetParams.AddRange(GetAssetParams());
		Guid configGuid = PersistentLevel.ConfigGuid;
		BGWDataAsset_BossRushLevelConfig globalLevelConfigDA = GetGlobalLevelConfigDA();
		if (globalLevelConfigDA != null)
		{
			foreach (UBossRushLevelConfig levelConfig in globalLevelConfigDA.LevelConfigs)
			{
				if (levelConfig != null && GameplayTagExtension.ConvertToGuid(levelConfig.ConfigGuid) == configGuid)
				{
					bossRushCustom_InitialV.LevelName = levelConfig.PersistentLevel;
					break;
				}
			}
		}
		bossRushCustom_InitialV.ModifiedLevelState.Clear();
		SaveLevelLoadConfig(bossRushCustom_InitialV.ModifiedLevelState, new IList<FBossRushLevelState>[8] { BossRushLevelsLoadSetting, GeometryLevelsLoadSetting, SeqLevelsLoadSetting, ItemLevelsLoadSetting, LightLevelsLoadSetting, SupportLevelsLoadSetting, OtherLevelsLoadSetting, MonsterLevelsLoadSetting });
		bossRushCustom_InitialV.PlayerStartForSingle = CalliopeExtension.ToCalliopeTransform(PlayerStartForSingle);
		bossRushCustom_InitialV.PlayerStartForGroup = CalliopeExtension.ToCalliopeTransform(PlayerStartForGroup);
		foreach (KeyValuePair<int, FBossRushBattleConfigForGroup> groupConfig in GroupConfigs)
		{
			BossRushCustom_GroupBattleConfigV2 bossRushCustom_GroupBattleConfigV = new BossRushCustom_GroupBattleConfigV2
			{
				GroupId = groupConfig.Key
			};
			FBossRushBattleConfigForGroup value = groupConfig.Value;
			bossRushCustom_GroupBattleConfigV.LevelNumericalStrength = value.OverrideLevelNumericalStrength;
			foreach (FTamerOverridePropertyCollection overridePropertyCollection in value.OverridePropertyCollections)
			{
				bossRushCustom_GroupBattleConfigV.TamerOverrideProperties.Add(new BossRushCustom_TamerOverrideProperty
				{
					ExtendId = overridePropertyCollection.BattleExtendID,
					UnitConfigGuid = overridePropertyCollection.Unit.ConfigGuid.ToString()
				});
			}
			foreach (FServantOverridePropertyCollection item3 in value.OverrideServantExtendID)
			{
				bossRushCustom_GroupBattleConfigV.ServantOverrideProperties.Add(new BossRushCustom_ServantOverrideProperty
				{
					ExtendId = item3.BattleExtendID,
					SummonId = item3.SummonID
				});
			}
			bossRushCustom_InitialV.GroupBattleConfigs.Add(bossRushCustom_GroupBattleConfigV);
		}
		foreach (KeyValuePair<int, float> item4 in OverrideDeadDelayDestroyTime)
		{
			BossRushCustom_TableOverride item = new BossRushCustom_TableOverride
			{
				ModifyMethod = EBossRushModifyTableMethod.DeadDelayDestroyTime,
				MainId = item4.Key,
				FloatValue = item4.Value
			};
			bossRushCustom_InitialV.TableOverrides.Add(item);
		}
		return bossRushCustom_InitialV;
		static void SaveLevelLoadConfig(IList<BossRushCustom_LevelLoadState> LevelLoadStateList, IList<FBossRushLevelState>[] LoadConfigs)
		{
			for (int i = 0; i < LoadConfigs.Length; i++)
			{
				foreach (FBossRushLevelState item5 in LoadConfigs[i])
				{
					if (item5.bModify || item5.bHasSeqControl)
					{
						BossRushCustom_LevelLoadState item2 = new BossRushCustom_LevelLoadState
						{
							LevelName = item5.LevelName,
							LoadState = (int)item5.GetFinalBossRushLevelLoadState()
						};
						LevelLoadStateList.Add(item2);
					}
				}
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName == "bRefreshLevel" && bRefreshLevel)
		{
			bRefreshLevel = false;
			RefreshLevel();
		}
		else if (PropertyName == "bRefreshPlayerStart" && bRefreshPlayerStart)
		{
			bRefreshPlayerStart = false;
			RefreshPlayerStart();
		}
		else if (PropertyName == "bRefreshSeqLevelState" && bRefreshSeqLevelState)
		{
			bRefreshSeqLevelState = false;
			UpdateSeqLevelControl();
		}
		else if (PropertyName == "bSyncTamerList" && bSyncTamerList)
		{
			bSyncTamerList = false;
			UpdateGroupConfigTamerList();
		}
		else if (PropertyName == "bOpenNeedLevel" && bOpenNeedLevel)
		{
			bOpenNeedLevel = false;
			OpenNeedLevels();
		}
	}

	private void OpenNeedLevels()
	{
		UBossRushLevelConfig uBossRushLevelConfig = null;
		BGWDataAsset_BossRushLevelConfig globalLevelConfigDA = GetGlobalLevelConfigDA();
		if (globalLevelConfigDA != null)
		{
			Guid configGuid = PersistentLevel.ConfigGuid;
			foreach (UBossRushLevelConfig levelConfig in globalLevelConfigDA.LevelConfigs)
			{
				if (levelConfig != null && configGuid == GameplayTagExtension.ConvertToGuid(levelConfig.ConfigGuid))
				{
					uBossRushLevelConfig = levelConfig;
				}
			}
		}
		if (!(uBossRushLevelConfig == null) && UGSE_EditorFuncLib.OpenLevelInEditor(uBossRushLevelConfig.PersistentLevelLongPackageName))
		{
			HashSet<string> hashSet = new HashSet<string>();
			GetNeedLoadLevelList(hashSet, new IList<FBossRushLevelState>[8] { SeqLevelsLoadSetting, GeometryLevelsLoadSetting, ItemLevelsLoadSetting, OtherLevelsLoadSetting, LightLevelsLoadSetting, SupportLevelsLoadSetting, BossRushLevelsLoadSetting, MonsterLevelsLoadSetting });
			UGSEditorWCLibrary.LoadSubLevelsIncludeWcTile(hashSet.ToList());
			if (PlayerStartForSingle != FTransform.Identity)
			{
				UGSE_EditorFuncLib.SetViewportTransform(PlayerStartForSingle);
			}
			else if (PlayerStartForGroup != FTransform.Identity)
			{
				UGSE_EditorFuncLib.SetViewportTransform(PlayerStartForGroup);
			}
		}
		static void GetNeedLoadLevelList(ISet<string> InResultLevels, IList<FBossRushLevelState>[] LevelStateConfigs)
		{
			for (int i = 0; i < LevelStateConfigs.Length; i++)
			{
				foreach (FBossRushLevelState item in LevelStateConfigs[i])
				{
					if (item.bModify && item.ModifyLevelState == ELevelLoadState.Load)
					{
						InResultLevels.Add(item.LevelName);
					}
				}
			}
		}
	}

	private void ClearAllConfig()
	{
		PersistentLevel = default(FGsSmartParam);
		BossRushLevelsLoadSetting.Clear();
		GeometryLevelsLoadSetting.Clear();
		SeqLevelsLoadSetting.Clear();
		ItemLevelsLoadSetting.Clear();
		OtherLevelsLoadSetting.Clear();
		MonsterLevelsLoadSetting.Clear();
	}

	private void UpdateGroupConfigTamerList()
	{
		Dictionary<int, FBossRushBattleConfigForGroup> dictionary = new Dictionary<int, FBossRushBattleConfigForGroup>(GroupConfigs);
		GroupConfigs.Clear();
		foreach (KeyValuePair<int, FBossRushBattleConfigForGroup> item2 in dictionary)
		{
			FBossRushBattleConfigForGroup value = item2.Value;
			List<FTamerOverridePropertyCollection> list = new List<FTamerOverridePropertyCollection>(value.OverridePropertyCollections);
			value.OverridePropertyCollections.Clear();
			foreach (FGsManagedUnit item3 in base.CalliopeParameters.UnitCollection)
			{
				Guid configGuid = item3.ConfigGuid;
				bool flag = false;
				foreach (FTamerOverridePropertyCollection item4 in list)
				{
					if (item4.Unit.ConfigGuid == item3.ConfigGuid)
					{
						flag = true;
						value.OverridePropertyCollections.Add(item4);
						break;
					}
				}
				if (!flag)
				{
					FTamerOverridePropertyCollection item = new FTamerOverridePropertyCollection
					{
						Unit = new FGsSmartParam
						{
							ConfigGuid = configGuid
						}
					};
					value.OverridePropertyCollections.Add(item);
				}
			}
			GroupConfigs[item2.Key] = value;
		}
	}

	private void UpdateSeqLevelControl()
	{
		RelationSeqLevelList.Clear();
		HashSet<string> hashSet = new HashSet<string>();
		BGW_GameDB.Init("B1");
		foreach (FGsManagedSequenceID item2 in base.CalliopeParameters.SequenceIDCollection)
		{
			BED_MovieAsset bED_MovieAsset = BGW_PreloadAssetMgr.RequestSyncLoadObjectInEditor<BED_MovieAsset>(BGW_GameDB.GetMovieSequenceDesc(item2.SequenceID).MovieGraphPath);
			if (bED_MovieAsset == null)
			{
				continue;
			}
			UAssetDataArray assetDataFromPackageObj = UGSE_AssetUtilFuncLib.GetAssetDataFromPackageObj(new List<UObject> { bED_MovieAsset });
			assetDataFromPackageObj = UGSE_AssetUtilFuncLib.GetDependenciesAssetsFromAssets(assetDataFromPackageObj);
			while (assetDataFromPackageObj.AssetDataArr.Count > 0)
			{
				int num = assetDataFromPackageObj.AssetDataArr.Count;
				for (int i = 0; i < num; i++)
				{
					FAssetData fAssetData = assetDataFromPackageObj.AssetDataArr[i];
					UClass uClass = UClass.GetClass(fAssetData.AssetClass.ToString());
					if (uClass == UClass.GetClass<UWorld>())
					{
						string item = fAssetData.AssetName.ToString();
						hashSet.Add(item);
					}
					if (uClass != UClass.GetClass<ULevelSequence>())
					{
						assetDataFromPackageObj.AssetDataArr.RemoveAt(i--);
						num--;
					}
				}
				assetDataFromPackageObj = UGSE_AssetUtilFuncLib.GetDependenciesAssetsFromAssets(assetDataFromPackageObj);
			}
		}
		Update(hashSet, new IList<FBossRushLevelState>[8] { SeqLevelsLoadSetting, GeometryLevelsLoadSetting, ItemLevelsLoadSetting, OtherLevelsLoadSetting, LightLevelsLoadSetting, SupportLevelsLoadSetting, BossRushLevelsLoadSetting, MonsterLevelsLoadSetting });
		void Update(IEnumerable<string> SeqLevelList, IList<FBossRushLevelState>[] CurrentConfigs)
		{
			IList<FBossRushLevelState>[] array = CurrentConfigs;
			foreach (IList<FBossRushLevelState> list in array)
			{
				for (int k = 0; k < list.Count; k++)
				{
					FBossRushLevelState value = list[k];
					value.bHasSeqControl = false;
					list[k] = value;
				}
			}
			foreach (string SeqLevel in SeqLevelList)
			{
				bool flag = false;
				array = CurrentConfigs;
				foreach (IList<FBossRushLevelState> list2 in array)
				{
					for (int l = 0; l < list2.Count; l++)
					{
						FBossRushLevelState value2 = list2[l];
						if (value2.LevelName == SeqLevel)
						{
							flag = true;
							value2.bHasSeqControl = true;
							value2.SeqControlLevelState = ELevelLoadState.Load;
							list2[l] = value2;
							break;
						}
					}
					if (flag)
					{
						break;
					}
				}
				RelationSeqLevelList.Add(SeqLevel);
			}
		}
	}

	public void RefreshLevel()
	{
		if (PersistentLevel.ConfigGuid == Guid.Empty)
		{
			return;
		}
		Dictionary<string, FBossRushLevelState> TempLevelStates = new Dictionary<string, FBossRushLevelState>();
		Guid configGuid = PersistentLevel.ConfigGuid;
		BGWDataAsset_BossRushLevelConfig globalLevelConfigDA = GetGlobalLevelConfigDA();
		if (!(globalLevelConfigDA != null))
		{
			return;
		}
		foreach (UBossRushLevelConfig levelConfig in globalLevelConfigDA.LevelConfigs)
		{
			if (levelConfig != null && GameplayTagExtension.ConvertToGuid(levelConfig.ConfigGuid) == configGuid)
			{
				Update(BossRushLevelsLoadSetting, levelConfig.BossRushLevelsLoadSetting);
				Update(GeometryLevelsLoadSetting, levelConfig.GeometryLevelsLoadSetting);
				Update(SeqLevelsLoadSetting, levelConfig.SeqLevelsLoadSetting);
				Update(ItemLevelsLoadSetting, levelConfig.ItemLevelsLoadSetting);
				Update(SupportLevelsLoadSetting, levelConfig.SupportLevelsLoadSetting);
				Update(LightLevelsLoadSetting, levelConfig.LightLevelsLoadSetting);
				Update(OtherLevelsLoadSetting, levelConfig.OtherLevelsLoadSetting);
				Update(MonsterLevelsLoadSetting, levelConfig.MonsterLevelsLoadSetting);
				break;
			}
		}
		void Update(IList<FBossRushLevelState> NeedConfig, IDictionary<string, FBossRushLevelState> OriginConfig)
		{
			TempLevelStates.Clear();
			foreach (KeyValuePair<string, FBossRushLevelState> item in OriginConfig)
			{
				ELevelLoadState finalLevelState = item.Value.GetFinalLevelState();
				FBossRushLevelState value = new FBossRushLevelState
				{
					LevelName = item.Key,
					OriginLevelState = finalLevelState,
					ModifyLevelState = finalLevelState
				};
				TempLevelStates[item.Key] = value;
			}
			foreach (FBossRushLevelState item2 in NeedConfig)
			{
				FBossRushLevelState fBossRushLevelState = item2;
				if (fBossRushLevelState.bModify)
				{
					string levelName = item2.LevelName;
					if (TempLevelStates.TryGetValue(levelName, out var value2))
					{
						FBossRushLevelState value3 = new FBossRushLevelState
						{
							LevelName = levelName,
							OriginLevelState = value2.OriginLevelState,
							ModifyLevelState = fBossRushLevelState.ModifyLevelState,
							bModify = true
						};
						TempLevelStates[levelName] = value3;
					}
				}
			}
			NeedConfig.Clear();
			foreach (KeyValuePair<string, FBossRushLevelState> item3 in TempLevelStates)
			{
				NeedConfig.Add(item3.Value);
			}
		}
	}

	public void RefreshPlayerStart()
	{
		string currentPersistentLevelName = UGSEditorLevelLibrary.GetCurrentPersistentLevelName();
		UBossRushLevelConfig uBossRushLevelConfig = null;
		BGWDataAsset_BossRushLevelConfig globalLevelConfigDA = GetGlobalLevelConfigDA();
		if (globalLevelConfigDA != null)
		{
			Guid configGuid = PersistentLevel.ConfigGuid;
			foreach (UBossRushLevelConfig levelConfig in globalLevelConfigDA.LevelConfigs)
			{
				if (levelConfig != null && configGuid == GameplayTagExtension.ConvertToGuid(levelConfig.ConfigGuid))
				{
					uBossRushLevelConfig = levelConfig;
				}
			}
		}
		if (uBossRushLevelConfig == null || uBossRushLevelConfig.PersistentLevel != currentPersistentLevelName)
		{
			return;
		}
		List<string> list = new List<string>();
		foreach (FBossRushLevelState item in BossRushLevelsLoadSetting)
		{
			if (item.bModify && item.ModifyLevelState == ELevelLoadState.Load)
			{
				list.Add(item.LevelName);
				break;
			}
		}
		if (list.Count == 0)
		{
			return;
		}
		UGSEditorWCLibrary.LoadSubLevels(list);
		UWorld currentPersistentLevelWorld = UGSEditorLevelLibrary.GetCurrentPersistentLevelWorld();
		if (!(currentPersistentLevelWorld != null))
		{
			return;
		}
		ABossRushPlayerStart[] allActorsOfClass = currentPersistentLevelWorld.GetAllActorsOfClass<ABossRushPlayerStart>();
		if (allActorsOfClass == null)
		{
			return;
		}
		ABossRushPlayerStart[] array = allActorsOfClass;
		foreach (ABossRushPlayerStart aBossRushPlayerStart in array)
		{
			if (aBossRushPlayerStart.LevelTag == LevelTag)
			{
				if (aBossRushPlayerStart.UseType == EBossRushPlayerStartType.Single)
				{
					PlayerStartForSingle = aBossRushPlayerStart.GetActorTransform();
				}
				else if (aBossRushPlayerStart.UseType == EBossRushPlayerStartType.Group)
				{
					PlayerStartForGroup = aBossRushPlayerStart.GetActorTransform();
				}
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GetParamDisplayNameCS")]
	protected override bool GetParamDisplayNameCS_Implementation(string PropertyName, FCalliopeGuid InConfigGuid, out string OutDisplayName)
	{
		OutDisplayName = null;
		if (PropertyName == "PersistentLevel")
		{
			BGWDataAsset_BossRushLevelConfig globalLevelConfigDA = GetGlobalLevelConfigDA();
			if (globalLevelConfigDA != null)
			{
				Guid guid = GameplayTagExtension.ConvertToGuid(InConfigGuid);
				foreach (UBossRushLevelConfig levelConfig in globalLevelConfigDA.LevelConfigs)
				{
					if (levelConfig != null && guid == GameplayTagExtension.ConvertToGuid(levelConfig.ConfigGuid))
					{
						OutDisplayName = levelConfig.PersistentLevel;
						return true;
					}
				}
			}
		}
		return false;
	}

	[USharpPath("/Script/b1-Managed.BED_BossRushAsset:GetPossibleParamsCS")]
	protected override bool GetPossibleParamsCS_Implementation(string ParentPropertyName, string PropertyName, out List<FCalliopeGuid> OutParamArray)
	{
		OutParamArray = null;
		if (PropertyName == "PersistentLevel")
		{
			BGWDataAsset_BossRushLevelConfig globalLevelConfigDA = GetGlobalLevelConfigDA();
			if (globalLevelConfigDA != null)
			{
				OutParamArray = new List<FCalliopeGuid>();
				foreach (UBossRushLevelConfig levelConfig in globalLevelConfigDA.LevelConfigs)
				{
					if (levelConfig != null)
					{
						OutParamArray.Add(levelConfig.ConfigGuid);
					}
				}
				return true;
			}
		}
		return false;
	}

	private BGWDataAsset_BossRushLevelConfig GetGlobalLevelConfigDA()
	{
		return BGW_PreloadAssetMgr.RequestSyncLoadObjectInEditor<BGWDataAsset_BossRushLevelConfig>("BGWDataAsset_BossRushLevelConfig'/Game/00Main/DataAsset/DA_BossRushLevelConfig.DA_BossRushLevelConfig'");
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:HasRevertCondition")]
	private static void HasRevertCondition__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		bool value = bED_BossRushAsset.HasRevertCondition();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, HasRevertCondition_ReturnValue_Offset), 0, HasRevertCondition_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:GetViewType")]
	private static void GetViewType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		ECalliopeViewType viewType_Implementation = bED_BossRushAsset.GetViewType_Implementation();
		EnumMarshaler<ECalliopeViewType>.ToNative(IntPtr.Add(buffer, GetViewType_ReturnValue_Offset), 0, GetViewType_ReturnValue_PropertyAddress.Address, viewType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:IsEditorOnlyCS")]
	private static void IsEditorOnlyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		bool value = bED_BossRushAsset.IsEditorOnlyCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, IsEditorOnlyCS_ReturnValue_Offset), 0, IsEditorOnlyCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:CanManageStates")]
	private static void CanManageStates__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		bool value = bED_BossRushAsset.CanManageStates_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CanManageStates_ReturnValue_Offset), 0, CanManageStates_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:GetStartNodeClass")]
	private static void GetStartNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		TSubclassOf<UObject> startNodeClass_Implementation = bED_BossRushAsset.GetStartNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetStartNodeClass_ReturnValue_Offset), startNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		bED_BossRushAsset.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:OnRefreshAssetInCS")]
	private static void OnRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		bED_BossRushAsset.OnRefreshAssetInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:GetRerouteNodeClass")]
	private static void GetRerouteNodeClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		TSubclassOf<UObject> rerouteNodeClass_Implementation = bED_BossRushAsset.GetRerouteNodeClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetRerouteNodeClass_ReturnValue_Offset), rerouteNodeClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:GetPossibleParamsCS")]
	private static void GetPossibleParamsCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		string parentPropertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetPossibleParamsCS_ParentPropertyName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetPossibleParamsCS_PropertyName_Offset));
		TArrayCopyMarshaler<FCalliopeGuid> tArrayCopyMarshaler = new TArrayCopyMarshaler<FCalliopeGuid>(1, GetPossibleParamsCS_OutParamArray_PropertyAddress, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.FromNative, CachedMarshalingDelegates<FCalliopeGuid, FCalliopeGuid>.ToNative);
		List<FCalliopeGuid> OutParamArray = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetPossibleParamsCS_OutParamArray_Offset));
		bool possibleParamsCS_Implementation = bED_BossRushAsset.GetPossibleParamsCS_Implementation(parentPropertyName, propertyName, out OutParamArray);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetPossibleParamsCS_ReturnValue_Offset), 0, GetPossibleParamsCS_ReturnValue_PropertyAddress.Address, possibleParamsCS_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetPossibleParamsCS_OutParamArray_Offset), OutParamArray);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:PostRefreshAssetInCS")]
	private static void PostRefreshAssetInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		bED_BossRushAsset.PostRefreshAssetInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:GetParamDisplayNameCS")]
	private static void GetParamDisplayNameCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, GetParamDisplayNameCS_PropertyName_Offset));
		FCalliopeGuid inConfigGuid = FCalliopeGuid.FromNative(IntPtr.Add(buffer, GetParamDisplayNameCS_InConfigGuid_Offset));
		string OutDisplayName;
		bool paramDisplayNameCS_Implementation = bED_BossRushAsset.GetParamDisplayNameCS_Implementation(propertyName, inConfigGuid, out OutDisplayName);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GetParamDisplayNameCS_ReturnValue_Offset), 0, GetParamDisplayNameCS_ReturnValue_PropertyAddress.Address, paramDisplayNameCS_Implementation);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetParamDisplayNameCS_OutDisplayName_Offset), OutDisplayName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:GetExtraDefaultInputNodes")]
	private static void GetExtraDefaultInputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultInputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset));
		int extraDefaultInputNodes_Implementation = bED_BossRushAsset.GetExtraDefaultInputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_ReturnValue_Offset), extraDefaultInputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultInputNodes_OutClasses_Offset), OutClasses);
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BossRushAsset:GetExtraDefaultOutputNodes")]
	private static void GetExtraDefaultOutputNodes__Invoker(IntPtr buffer, IntPtr obj)
	{
		BED_BossRushAsset bED_BossRushAsset = GCHelper.Find<BED_BossRushAsset>(obj);
		TArrayCopyMarshaler<TSubclassOf<UObject>> tArrayCopyMarshaler = new TArrayCopyMarshaler<TSubclassOf<UObject>>(1, GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSubclassOf<UObject>, TSubclassOfMarshaler<UObject>>.ToNative);
		List<TSubclassOf<UObject>> OutClasses = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset));
		int extraDefaultOutputNodes_Implementation = bED_BossRushAsset.GetExtraDefaultOutputNodes_Implementation(out OutClasses);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_ReturnValue_Offset), extraDefaultOutputNodes_Implementation);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetExtraDefaultOutputNodes_OutClasses_Offset), OutClasses);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BossRushAsset");
		NativeReflection.GetPropertyRef(ref bCheck1_PropertyAddress, intPtr, "bCheck1");
		bCheck1_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheck1");
		bCheck1_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheck1", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheck2_PropertyAddress, intPtr, "bCheck2");
		bCheck2_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheck2");
		bCheck2_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheck2", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheck3_PropertyAddress, intPtr, "bCheck3");
		bCheck3_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheck3");
		bCheck3_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheck3", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheck4_PropertyAddress, intPtr, "bCheck4");
		bCheck4_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheck4");
		bCheck4_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheck4", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheck5_PropertyAddress, intPtr, "bCheck5");
		bCheck5_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheck5");
		bCheck5_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheck5", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheck6_PropertyAddress, intPtr, "bCheck6");
		bCheck6_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheck6");
		bCheck6_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheck6", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRefreshLevel_PropertyAddress, intPtr, "bRefreshLevel");
		bRefreshLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRefreshLevel");
		bRefreshLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRefreshLevel", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCanModifyPersistentLevel_PropertyAddress, intPtr, "bCanModifyPersistentLevel");
		bCanModifyPersistentLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanModifyPersistentLevel");
		bCanModifyPersistentLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanModifyPersistentLevel", Classes.FBoolProperty);
		PersistentLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "PersistentLevel");
		PersistentLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PersistentLevel", Classes.FStructProperty);
		LevelTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelTag");
		LevelTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref BossRushLevelsLoadSetting_PropertyAddress, intPtr, "BossRushLevelsLoadSetting");
		BossRushLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "BossRushLevelsLoadSetting");
		BossRushLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BossRushLevelsLoadSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref GeometryLevelsLoadSetting_PropertyAddress, intPtr, "GeometryLevelsLoadSetting");
		GeometryLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeometryLevelsLoadSetting");
		GeometryLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeometryLevelsLoadSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SeqLevelsLoadSetting_PropertyAddress, intPtr, "SeqLevelsLoadSetting");
		SeqLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "SeqLevelsLoadSetting");
		SeqLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SeqLevelsLoadSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ItemLevelsLoadSetting_PropertyAddress, intPtr, "ItemLevelsLoadSetting");
		ItemLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemLevelsLoadSetting");
		ItemLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemLevelsLoadSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LightLevelsLoadSetting_PropertyAddress, intPtr, "LightLevelsLoadSetting");
		LightLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "LightLevelsLoadSetting");
		LightLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LightLevelsLoadSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SupportLevelsLoadSetting_PropertyAddress, intPtr, "SupportLevelsLoadSetting");
		SupportLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "SupportLevelsLoadSetting");
		SupportLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SupportLevelsLoadSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OtherLevelsLoadSetting_PropertyAddress, intPtr, "OtherLevelsLoadSetting");
		OtherLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "OtherLevelsLoadSetting");
		OtherLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OtherLevelsLoadSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref MonsterLevelsLoadSetting_PropertyAddress, intPtr, "MonsterLevelsLoadSetting");
		MonsterLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "MonsterLevelsLoadSetting");
		MonsterLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MonsterLevelsLoadSetting", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bRefreshSeqLevelState_PropertyAddress, intPtr, "bRefreshSeqLevelState");
		bRefreshSeqLevelState_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRefreshSeqLevelState");
		bRefreshSeqLevelState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRefreshSeqLevelState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref RelationSeqLevelList_PropertyAddress, intPtr, "RelationSeqLevelList");
		RelationSeqLevelList_Offset = NativeReflection.GetPropertyOffset(intPtr, "RelationSeqLevelList");
		RelationSeqLevelList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RelationSeqLevelList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bRefreshPlayerStart_PropertyAddress, intPtr, "bRefreshPlayerStart");
		bRefreshPlayerStart_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRefreshPlayerStart");
		bRefreshPlayerStart_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRefreshPlayerStart", Classes.FBoolProperty);
		PlayerStartForSingle_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerStartForSingle");
		PlayerStartForSingle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerStartForSingle", Classes.FStructProperty);
		PlayerStartForGroup_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerStartForGroup");
		PlayerStartForGroup_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerStartForGroup", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bSyncTamerList_PropertyAddress, intPtr, "bSyncTamerList");
		bSyncTamerList_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSyncTamerList");
		bSyncTamerList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSyncTamerList", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref GroupConfigs_PropertyAddress, intPtr, "GroupConfigs");
		GroupConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupConfigs");
		GroupConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupConfigs", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref OverrideDeadDelayDestroyTime_PropertyAddress, intPtr, "OverrideDeadDelayDestroyTime");
		OverrideDeadDelayDestroyTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideDeadDelayDestroyTime");
		OverrideDeadDelayDestroyTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideDeadDelayDestroyTime", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref bNote_PropertyAddress, intPtr, "bNote");
		bNote_Offset = NativeReflection.GetPropertyOffset(intPtr, "bNote");
		bNote_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bNote", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bOpenNeedLevel_PropertyAddress, intPtr, "bOpenNeedLevel");
		bOpenNeedLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bOpenNeedLevel");
		bOpenNeedLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bOpenNeedLevel", Classes.FBoolProperty);
		HasRevertCondition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasRevertCondition");
		HasRevertCondition_ParamsSize = NativeReflection.GetFunctionParamsSize(HasRevertCondition_FunctionAddress);
		NativeReflection.GetPropertyRef(ref HasRevertCondition_ReturnValue_PropertyAddress, HasRevertCondition_FunctionAddress, "ReturnValue");
		HasRevertCondition_ReturnValue_Offset = NativeReflection.GetPropertyOffset(HasRevertCondition_FunctionAddress, "ReturnValue");
		HasRevertCondition_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(HasRevertCondition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasRevertCondition_IsValid = HasRevertCondition_FunctionAddress != IntPtr.Zero && HasRevertCondition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:HasRevertCondition", HasRevertCondition_IsValid);
		GetViewType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewType");
		GetViewType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetViewType_ReturnValue_PropertyAddress, GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetViewType_FunctionAddress, "ReturnValue");
		GetViewType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetViewType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetViewType_IsValid = GetViewType_FunctionAddress != IntPtr.Zero && GetViewType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:GetViewType", GetViewType_IsValid);
		IsEditorOnlyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsEditorOnlyCS");
		IsEditorOnlyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsEditorOnlyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref IsEditorOnlyCS_ReturnValue_PropertyAddress, IsEditorOnlyCS_FunctionAddress, "ReturnValue");
		IsEditorOnlyCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(IsEditorOnlyCS_FunctionAddress, "ReturnValue");
		IsEditorOnlyCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(IsEditorOnlyCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsEditorOnlyCS_IsValid = IsEditorOnlyCS_FunctionAddress != IntPtr.Zero && IsEditorOnlyCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:IsEditorOnlyCS", IsEditorOnlyCS_IsValid);
		CanManageStates_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanManageStates");
		CanManageStates_ParamsSize = NativeReflection.GetFunctionParamsSize(CanManageStates_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CanManageStates_ReturnValue_PropertyAddress, CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CanManageStates_FunctionAddress, "ReturnValue");
		CanManageStates_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CanManageStates_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanManageStates_IsValid = CanManageStates_FunctionAddress != IntPtr.Zero && CanManageStates_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:CanManageStates", CanManageStates_IsValid);
		GetStartNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStartNodeClass");
		GetStartNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartNodeClass_FunctionAddress);
		GetStartNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetStartNodeClass_FunctionAddress, "ReturnValue");
		GetStartNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetStartNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetStartNodeClass_IsValid = GetStartNodeClass_FunctionAddress != IntPtr.Zero && GetStartNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:GetStartNodeClass", GetStartNodeClass_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:OnPropertyChanged", OnPropertyChanged_IsValid);
		OnRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnRefreshAssetInCS");
		OnRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRefreshAssetInCS_FunctionAddress);
		OnRefreshAssetInCS_IsValid = OnRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:OnRefreshAssetInCS", OnRefreshAssetInCS_IsValid);
		GetRerouteNodeClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRerouteNodeClass");
		GetRerouteNodeClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRerouteNodeClass_FunctionAddress);
		GetRerouteNodeClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetRerouteNodeClass_FunctionAddress, "ReturnValue");
		GetRerouteNodeClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetRerouteNodeClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetRerouteNodeClass_IsValid = GetRerouteNodeClass_FunctionAddress != IntPtr.Zero && GetRerouteNodeClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:GetRerouteNodeClass", GetRerouteNodeClass_IsValid);
		GetPossibleParamsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPossibleParamsCS");
		GetPossibleParamsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPossibleParamsCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetPossibleParamsCS_ParentPropertyName_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "ParentPropertyName");
		GetPossibleParamsCS_ParentPropertyName_Offset = NativeReflection.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "ParentPropertyName");
		GetPossibleParamsCS_ParentPropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "ParentPropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetPossibleParamsCS_PropertyName_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "PropertyName");
		GetPossibleParamsCS_PropertyName_Offset = NativeReflection.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "PropertyName");
		GetPossibleParamsCS_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetPossibleParamsCS_OutParamArray_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "OutParamArray");
		GetPossibleParamsCS_OutParamArray_Offset = NativeReflection.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "OutParamArray");
		GetPossibleParamsCS_OutParamArray_IsValid = NativeReflection.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "OutParamArray", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref GetPossibleParamsCS_ReturnValue_PropertyAddress, GetPossibleParamsCS_FunctionAddress, "ReturnValue");
		GetPossibleParamsCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetPossibleParamsCS_FunctionAddress, "ReturnValue");
		GetPossibleParamsCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetPossibleParamsCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPossibleParamsCS_IsValid = GetPossibleParamsCS_FunctionAddress != IntPtr.Zero && GetPossibleParamsCS_ParentPropertyName_IsValid && GetPossibleParamsCS_PropertyName_IsValid && GetPossibleParamsCS_OutParamArray_IsValid && GetPossibleParamsCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:GetPossibleParamsCS", GetPossibleParamsCS_IsValid);
		PostRefreshAssetInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostRefreshAssetInCS");
		PostRefreshAssetInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostRefreshAssetInCS_FunctionAddress);
		PostRefreshAssetInCS_IsValid = PostRefreshAssetInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:PostRefreshAssetInCS", PostRefreshAssetInCS_IsValid);
		GetParamDisplayNameCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParamDisplayNameCS");
		GetParamDisplayNameCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParamDisplayNameCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetParamDisplayNameCS_PropertyName_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "PropertyName");
		GetParamDisplayNameCS_PropertyName_Offset = NativeReflection.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "PropertyName");
		GetParamDisplayNameCS_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "PropertyName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetParamDisplayNameCS_InConfigGuid_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "InConfigGuid");
		GetParamDisplayNameCS_InConfigGuid_Offset = NativeReflection.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "InConfigGuid");
		GetParamDisplayNameCS_InConfigGuid_IsValid = NativeReflection.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "InConfigGuid", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetParamDisplayNameCS_OutDisplayName_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "OutDisplayName");
		GetParamDisplayNameCS_OutDisplayName_Offset = NativeReflection.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "OutDisplayName");
		GetParamDisplayNameCS_OutDisplayName_IsValid = NativeReflection.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "OutDisplayName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref GetParamDisplayNameCS_ReturnValue_PropertyAddress, GetParamDisplayNameCS_FunctionAddress, "ReturnValue");
		GetParamDisplayNameCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetParamDisplayNameCS_FunctionAddress, "ReturnValue");
		GetParamDisplayNameCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetParamDisplayNameCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetParamDisplayNameCS_IsValid = GetParamDisplayNameCS_FunctionAddress != IntPtr.Zero && GetParamDisplayNameCS_PropertyName_IsValid && GetParamDisplayNameCS_InConfigGuid_IsValid && GetParamDisplayNameCS_OutDisplayName_IsValid && GetParamDisplayNameCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:GetParamDisplayNameCS", GetParamDisplayNameCS_IsValid);
		GetExtraDefaultInputNodes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultInputNodes");
		GetExtraDefaultInputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultInputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultInputNodes_OutClasses_PropertyAddress, GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultInputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultInputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultInputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultInputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultInputNodes_IsValid = GetExtraDefaultInputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultInputNodes_OutClasses_IsValid && GetExtraDefaultInputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:GetExtraDefaultInputNodes", GetExtraDefaultInputNodes_IsValid);
		GetExtraDefaultOutputNodes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetExtraDefaultOutputNodes");
		GetExtraDefaultOutputNodes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtraDefaultOutputNodes_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetExtraDefaultOutputNodes_OutClasses_PropertyAddress, GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses");
		GetExtraDefaultOutputNodes_OutClasses_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "OutClasses", Classes.FArrayProperty);
		GetExtraDefaultOutputNodes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue");
		GetExtraDefaultOutputNodes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetExtraDefaultOutputNodes_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetExtraDefaultOutputNodes_IsValid = GetExtraDefaultOutputNodes_FunctionAddress != IntPtr.Zero && GetExtraDefaultOutputNodes_OutClasses_IsValid && GetExtraDefaultOutputNodes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BossRushAsset:GetExtraDefaultOutputNodes", GetExtraDefaultOutputNodes_IsValid);
	}

	static BED_BossRushAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_BossRushAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_BossRushAsset));
	}
}
