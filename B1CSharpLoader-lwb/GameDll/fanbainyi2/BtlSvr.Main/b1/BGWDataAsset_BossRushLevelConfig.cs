using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.Plugins.Calliope;
using BtlB1;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EditorScriptingUtilities;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig")]
public class BGWDataAsset_BossRushLevelConfig : UBGWConfigDataAsset
{
	private static bool BattleReadyTime_IsValid;

	private static int BattleReadyTime_Offset;

	private static bool bRefreshAllLevelList_IsValid;

	private static int bRefreshAllLevelList_Offset;

	private static FFieldAddress bRefreshAllLevelList_PropertyAddress;

	private static bool PersistentLevelPaths_IsValid;

	private static int PersistentLevelPaths_Offset;

	private static FFieldAddress PersistentLevelPaths_PropertyAddress;

	private TArrayReadWriteMarshaler<string> PersistentLevelPaths_Marshaler;

	private static bool LevelConfigs_IsValid;

	private static int LevelConfigs_Offset;

	private static FFieldAddress LevelConfigs_PropertyAddress;

	private TArrayReadWriteMarshaler<UBossRushLevelConfig> LevelConfigs_Marshaler;

	private static bool bClearAllConfig_IsValid;

	private static int bClearAllConfig_Offset;

	private static FFieldAddress bClearAllConfig_PropertyAddress;

	private static bool bBatchCreateBRLevel_IsValid;

	private static int bBatchCreateBRLevel_Offset;

	private static FFieldAddress bBatchCreateBRLevel_PropertyAddress;

	private static bool bRunCustomCreate_IsValid;

	private static int bRunCustomCreate_Offset;

	private static FFieldAddress bRunCustomCreate_PropertyAddress;

	private static bool CustomCreateID_IsValid;

	private static int CustomCreateID_Offset;

	private static bool bCreateTamer_IsValid;

	private static int bCreateTamer_Offset;

	private static FFieldAddress bCreateTamer_PropertyAddress;

	private static bool bCreateBRGraphAndLevel_IsValid;

	private static int bCreateBRGraphAndLevel_Offset;

	private static FFieldAddress bCreateBRGraphAndLevel_PropertyAddress;

	private static bool bCheckLevelNameHasRepeatable_IsValid;

	private static int bCheckLevelNameHasRepeatable_Offset;

	private static FFieldAddress bCheckLevelNameHasRepeatable_PropertyAddress;

	private static bool bCheckTamerPlaceLevel_IsValid;

	private static int bCheckTamerPlaceLevel_Offset;

	private static FFieldAddress bCheckTamerPlaceLevel_PropertyAddress;

	private static bool bFixBRLevelTransactionalActors_IsValid;

	private static int bFixBRLevelTransactionalActors_Offset;

	private static FFieldAddress bFixBRLevelTransactionalActors_PropertyAddress;

	private static bool bSetAllBRLevelLayer_IsValid;

	private static int bSetAllBRLevelLayer_Offset;

	private static FFieldAddress bSetAllBRLevelLayer_PropertyAddress;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[Category("全局配置")]
	[UMeta(MDProp.ClampMin, 0f)]
	[BlueprintReadWrite]
	[UMeta(MDProp.UIMax, 10f)]
	[DisplayName("战斗开始前倒计时时间")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:BattleReadyTime")]
	public float BattleReadyTime
	{
		get
		{
			CheckDestroyed();
			if (!BattleReadyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:BattleReadyTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BattleReadyTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleReadyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:BattleReadyTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BattleReadyTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("刷新所有关卡列表")]
	[UProperty(PropFlags.Transient)]
	[Category("关卡配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bRefreshAllLevelList")]
	public bool bRefreshAllLevelList
	{
		get
		{
			CheckDestroyed();
			if (!bRefreshAllLevelList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bRefreshAllLevelList");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRefreshAllLevelList_Offset), 0, bRefreshAllLevelList_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRefreshAllLevelList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bRefreshAllLevelList");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRefreshAllLevelList_Offset), 0, bRefreshAllLevelList_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("关卡列表")]
	[Category("关卡配置")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:PersistentLevelPaths")]
	public TArrayReadWrite<string> PersistentLevelPaths
	{
		get
		{
			CheckDestroyed();
			if (!PersistentLevelPaths_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:PersistentLevelPaths");
				return null;
			}
			if (PersistentLevelPaths_Marshaler == null)
			{
				PersistentLevelPaths_Marshaler = new TArrayReadWriteMarshaler<string>(1, PersistentLevelPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return PersistentLevelPaths_Marshaler.FromNative(IntPtr.Add(base.Address, PersistentLevelPaths_Offset));
		}
	}

	[VisibleAnywhere]
	[UProperty(PropFlags.Instanced)]
	[DisplayName("关卡加载配置")]
	[Category("关卡配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:LevelConfigs")]
	public TArrayReadWrite<UBossRushLevelConfig> LevelConfigs
	{
		get
		{
			CheckDestroyed();
			if (!LevelConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:LevelConfigs");
				return null;
			}
			if (LevelConfigs_Marshaler == null)
			{
				LevelConfigs_Marshaler = new TArrayReadWriteMarshaler<UBossRushLevelConfig>(1, LevelConfigs_PropertyAddress, CachedMarshalingDelegates<UBossRushLevelConfig, UObjectMarshaler<UBossRushLevelConfig>>.FromNative, CachedMarshalingDelegates<UBossRushLevelConfig, UObjectMarshaler<UBossRushLevelConfig>>.ToNative);
			}
			return LevelConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, LevelConfigs_Offset));
		}
	}

	[UProperty(PropFlags.Transient)]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("清空所有配置")]
	[Category("关卡配置")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bClearAllConfig")]
	public bool bClearAllConfig
	{
		get
		{
			CheckDestroyed();
			if (!bClearAllConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bClearAllConfig");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bClearAllConfig_Offset), 0, bClearAllConfig_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bClearAllConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bClearAllConfig");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bClearAllConfig_Offset), 0, bClearAllConfig_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[BlueprintReadWrite]
	[DisplayName("自动创建关卡和BRG")]
	[Category("自动化工具 | 批量生成")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bBatchCreateBRLevel")]
	public bool bBatchCreateBRLevel
	{
		get
		{
			CheckDestroyed();
			if (!bBatchCreateBRLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bBatchCreateBRLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bBatchCreateBRLevel_Offset), 0, bBatchCreateBRLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bBatchCreateBRLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bBatchCreateBRLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bBatchCreateBRLevel_Offset), 0, bBatchCreateBRLevel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("执行自定义生成")]
	[Category("自动化工具 | 自定义生成")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bRunCustomCreate")]
	public bool bRunCustomCreate
	{
		get
		{
			CheckDestroyed();
			if (!bRunCustomCreate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bRunCustomCreate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRunCustomCreate_Offset), 0, bRunCustomCreate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRunCustomCreate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bRunCustomCreate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRunCustomCreate_Offset), 0, bRunCustomCreate_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[Category("自动化工具 | 自定义生成")]
	[DisplayName("自定义生成指定ID（填0表示生成所有ID）")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:CustomCreateID")]
	public int CustomCreateID
	{
		get
		{
			CheckDestroyed();
			if (!CustomCreateID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:CustomCreateID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CustomCreateID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CustomCreateID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:CustomCreateID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CustomCreateID_Offset), value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成Tamer并放置到关卡（自定义生成）")]
	[Category("自动化工具 | 自定义生成")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCreateTamer")]
	public bool bCreateTamer
	{
		get
		{
			CheckDestroyed();
			if (!bCreateTamer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCreateTamer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCreateTamer_Offset), 0, bCreateTamer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCreateTamer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCreateTamer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCreateTamer_Offset), 0, bCreateTamer_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成BRG和关卡（自定义生成）")]
	[Category("自动化工具 | 自定义生成")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCreateBRGraphAndLevel")]
	public bool bCreateBRGraphAndLevel
	{
		get
		{
			CheckDestroyed();
			if (!bCreateBRGraphAndLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCreateBRGraphAndLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCreateBRGraphAndLevel_Offset), 0, bCreateBRGraphAndLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCreateBRGraphAndLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCreateBRGraphAndLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCreateBRGraphAndLevel_Offset), 0, bCreateBRGraphAndLevel_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("检查关卡重名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("检查工具")]
	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCheckLevelNameHasRepeatable")]
	public bool bCheckLevelNameHasRepeatable
	{
		get
		{
			CheckDestroyed();
			if (!bCheckLevelNameHasRepeatable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCheckLevelNameHasRepeatable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheckLevelNameHasRepeatable_Offset), 0, bCheckLevelNameHasRepeatable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheckLevelNameHasRepeatable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCheckLevelNameHasRepeatable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheckLevelNameHasRepeatable_Offset), 0, bCheckLevelNameHasRepeatable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("检查Tamer关卡规范")]
	[Category("检查工具")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCheckTamerPlaceLevel")]
	public bool bCheckTamerPlaceLevel
	{
		get
		{
			CheckDestroyed();
			if (!bCheckTamerPlaceLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCheckTamerPlaceLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheckTamerPlaceLevel_Offset), 0, bCheckTamerPlaceLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheckTamerPlaceLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bCheckTamerPlaceLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheckTamerPlaceLevel_Offset), 0, bCheckTamerPlaceLevel_PropertyAddress.Address, value);
			}
		}
	}

	[Category("修复工具")]
	[DisplayName("修复BR关卡不可删除Actor")]
	[EditAnywhere]
	[UProperty(PropFlags.Transient)]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bFixBRLevelTransactionalActors")]
	public bool bFixBRLevelTransactionalActors
	{
		get
		{
			CheckDestroyed();
			if (!bFixBRLevelTransactionalActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bFixBRLevelTransactionalActors");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFixBRLevelTransactionalActors_Offset), 0, bFixBRLevelTransactionalActors_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFixBRLevelTransactionalActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bFixBRLevelTransactionalActors");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFixBRLevelTransactionalActors_Offset), 0, bFixBRLevelTransactionalActors_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("设置所有BR关卡加载策略")]
	[Category("修复工具")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bSetAllBRLevelLayer")]
	public bool bSetAllBRLevelLayer
	{
		get
		{
			CheckDestroyed();
			if (!bSetAllBRLevelLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bSetAllBRLevelLayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSetAllBRLevelLayer_Offset), 0, bSetAllBRLevelLayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSetAllBRLevelLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:bSetAllBRLevelLayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSetAllBRLevelLayer_Offset), 0, bSetAllBRLevelLayer_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		CustomCreateID = 0;
		bCreateBRGraphAndLevel = true;
		bCreateTamer = true;
		BattleReadyTime = 3f;
	}

	[USharpPath("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName == "bRefreshAllLevelList" && bRefreshAllLevelList)
		{
			bRefreshAllLevelList = false;
			RefreshAllLevelList();
		}
		else if (PropertyName == "bBatchCreateBRLevel" && bBatchCreateBRLevel)
		{
			bBatchCreateBRLevel = false;
			BatchCreateBRLevel();
		}
		else if (PropertyName == "bClearAllConfig" && bClearAllConfig)
		{
			bClearAllConfig = false;
			LevelConfigs.Clear();
		}
		else if (PropertyName == "bRunCustomCreate" && bRunCustomCreate)
		{
			bRunCustomCreate = false;
			RunCustomCreate();
		}
		else if (PropertyName == "bFixBRLevelTransactionalActors" && bFixBRLevelTransactionalActors)
		{
			bFixBRLevelTransactionalActors = false;
			FixBRLevelTransactionalActors();
		}
		else if (PropertyName == "bSetAllBRLevelLayer" && bSetAllBRLevelLayer)
		{
			bSetAllBRLevelLayer = false;
			SetAllBRLevelLayer();
		}
		else if (PropertyName == "bCheckLevelNameHasRepeatable" && bCheckLevelNameHasRepeatable)
		{
			bCheckLevelNameHasRepeatable = false;
			CheckLevelNameHasRepeatable();
		}
		else if (PropertyName == "bCheckTamerPlaceLevel" && bCheckTamerPlaceLevel)
		{
			bCheckTamerPlaceLevel = false;
			CheckTamerPlaceLevel();
		}
	}

	private void RefreshAllLevelList()
	{
		List<UBossRushLevelConfig> list = LevelConfigs.ToList();
		LevelConfigs.Clear();
		foreach (string persistentLevelPath in PersistentLevelPaths)
		{
			FSoftObjectPath fSoftObjectPath = default(FSoftObjectPath);
			fSoftObjectPath.SetPath(persistentLevelPath);
			string assetName = fSoftObjectPath.AssetName;
			bool flag = true;
			foreach (UBossRushLevelConfig item in list)
			{
				if (item != null && item.PersistentLevel == assetName)
				{
					flag = false;
					item.PersistentLevelAssetName = fSoftObjectPath.AssetName;
					item.PersistentLevelLongPackageName = fSoftObjectPath.LongPackageName;
					LevelConfigs.Add(item);
					break;
				}
			}
			if (flag)
			{
				UBossRushLevelConfig uBossRushLevelConfig = UObject.NewObject<UBossRushLevelConfig>(this);
				uBossRushLevelConfig.PersistentLevel = assetName;
				uBossRushLevelConfig.PersistentLevelAssetName = fSoftObjectPath.AssetName;
				uBossRushLevelConfig.PersistentLevelLongPackageName = fSoftObjectPath.LongPackageName;
				LevelConfigs.Add(uBossRushLevelConfig);
			}
		}
		foreach (UBossRushLevelConfig levelConfig in LevelConfigs)
		{
			if (UGSEditorLevelLibrary.GetCurrentPersistentLevelName() == levelConfig.PersistentLevelAssetName || UGSE_EditorFuncLib.OpenLevelInEditor(levelConfig.PersistentLevelLongPackageName))
			{
				levelConfig.RefreshCurrentLevelNames();
			}
		}
	}

	private bool CheckLevelNameHasRepeatable()
	{
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		foreach (KeyValuePair<int, FUStBossRushConfigDesc> item in BGW_GameDB.GetAllBossRushConfigDesc())
		{
			int key = item.Key;
			string text = item.Value.LevelName.ToLowerInvariant();
			if (dictionary.TryGetValue(text, out var value))
			{
				num++;
				stringBuilder.AppendLine($"Repeat Name:{text} ID:{key} OriginID:{value}");
			}
			else
			{
				dictionary[text] = key;
			}
		}
		string text2 = stringBuilder.ToString();
		if (num > 0)
		{
			BGW_LogUtil.LogError("Find Repeat LevelName：\n" + text2);
			FMessage.OpenDialog(text2);
			return true;
		}
		return false;
	}

	private void BatchCreateBRLevel()
	{
		if (LevelConfigs.Count != PersistentLevelPaths.Count)
		{
			return;
		}
		Dictionary<int, string> dictionary = new Dictionary<int, string>();
		BGW_GameDB.Init("B1");
		if (CheckLevelNameHasRepeatable())
		{
			return;
		}
		Dictionary<int, FUStBossRushConfigDesc> allBossRushConfigDesc = BGW_GameDB.GetAllBossRushConfigDesc();
		MultiMap<int, FUStBossRushConfigDesc> multiMap = new MultiMap<int, FUStBossRushConfigDesc>();
		foreach (KeyValuePair<int, FUStBossRushConfigDesc> item2 in allBossRushConfigDesc)
		{
			FUStBossRushConfigDesc value = item2.Value;
			multiMap.Add(value.LevelID, value);
			dictionary[value.ID] = value.GraphPath;
		}
		BED_CalliopeAssetBase.bIgnoreExportErrorDialogue = true;
		foreach (KeyValuePair<int, List<FUStBossRushConfigDesc>> item3 in multiMap)
		{
			LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(item3.Key);
			UBossRushLevelConfig uBossRushLevelConfig = null;
			for (int i = 0; i < LevelConfigs.Count; i++)
			{
				UBossRushLevelConfig uBossRushLevelConfig2 = LevelConfigs[i];
				if (uBossRushLevelConfig2.PersistentLevel == levelDesc.Path)
				{
					uBossRushLevelConfig = uBossRushLevelConfig2;
					break;
				}
			}
			if (uBossRushLevelConfig == null)
			{
				continue;
			}
			uBossRushLevelConfig.RefreshCurrentLevelNames();
			List<string> list = new List<string>();
			List<UWorld> list2 = new List<UWorld>();
			List<int> list3 = new List<int>();
			foreach (FUStBossRushConfigDesc item4 in item3.Value)
			{
				string LevelTag = item4.LevelName;
				string text = uBossRushLevelConfig.LevelNamePrefix + "_BR_" + LevelTag.ToLowerInvariant();
				if (uBossRushLevelConfig.SubLevelList.Contains(text))
				{
					continue;
				}
				UWorld uWorld = UGSEditorWCLibrary.CreateNewLevelPackageAndReturn(FPaths.Combine(FPaths.GetPath(uBossRushLevelConfig.PersistentLevelLongPackageName), "BossRush"), text);
				if (uWorld == null)
				{
					continue;
				}
				list3.Add(item4.ID);
				UGSEditorLevelLibrary.SetBossRushLevelLayer(uWorld);
				ULevel SubLevel = UGSEditorLevelLibrary.ConvertWorld2LevelObject(uWorld);
				bool flag = item4.TamerPath.Count != 1;
				List<AActor> list4 = new List<AActor>();
				foreach (string item5 in item4.TamerPath)
				{
					string text2 = ((flag ? FPaths.GetBaseFilename(item5).Substring(6) : uBossRushLevelConfig.LevelNamePrefix) + "_" + LevelTag).ToLowerInvariant();
					UClass uClass = null;
					UBlueprint uBlueprint = UEditorAssetLibrary.LoadAsset(item5) as UBlueprint;
					if (uBlueprint != null)
					{
						string text3 = "/Game/00MainHZ/BossRush/Tamer/BRT_" + text2;
						if (UEditorAssetLibrary.DoesAssetExist(text3))
						{
							uClass = UEditorAssetLibrary.LoadBlueprintClass(text3).Value;
						}
						else
						{
							UBlueprint uBlueprint2 = UEditorAssetLibrary.DuplicateLoadedAsset(uBlueprint, text3) as UBlueprint;
							if (uBlueprint2 != null)
							{
								UGSFuncLibForEditor.CopyThumbnailBetweenBlueprint(uBlueprint, uBlueprint2);
								uClass = uBlueprint2.GeneratedClass;
							}
						}
					}
					if (uClass != null)
					{
						AActor aActor = UGSEditorLevelLibrary.SpawnActor2SubLevel(SubLevel, uClass, FTransform.Identity, FName.None);
						if (aActor != null)
						{
							list4.Add(aActor);
						}
					}
				}
				string text4 = "BROB_BattleStart_" + LevelTag;
				FTransform inTransform = default(FTransform);
				inTransform.SetScale3D(new FVector(20f));
				BGUOverlapArea bGUOverlapArea = UGSEditorLevelLibrary.SpawnActor2SubLevel(SubLevel, UEditorAssetLibrary.LoadBlueprintClass("Blueprint'/Game/00Main/BPLibrary/SceneObj/BP_OverlapBox.BP_OverlapBox'").Value, inTransform, new FName(text4)) as BGUOverlapArea;
				UGSFuncLibForEditor.SetActorLabel(bGUOverlapArea, text4);
				CreatePlayerStart<ABossRushPlayerStart_Single>("BRPS_" + LevelTag + "_Single");
				CreatePlayerStart<ABossRushPlayerStart_Group>("BRPS_" + LevelTag + "_Group");
				list.Add(text);
				list2.Add(uWorld);
				BED_BossRushAsset bED_BossRushAsset = UGSEditorAssetLibrary.CreateBossRushGraphAsset("/Game/00MainHZ/BossRush/Graph/", "BRG_" + uBossRushLevelConfig.LevelNamePrefix.ToLowerInvariant() + "_" + LevelTag, UClass.GetClass<BED_BossRushAsset>()) as BED_BossRushAsset;
				if (bED_BossRushAsset == null)
				{
					continue;
				}
				dictionary[item4.ID] = "BED_BossRushAsset\\'" + bED_BossRushAsset.GetPathName() + "\\'";
				UGSEditorAssetLibrary.OpenAsset(bED_BossRushAsset);
				List<FCalliopeGuid> list5 = new List<FCalliopeGuid>();
				foreach (AActor item6 in list4)
				{
					if (bED_BossRushAsset.AddParameter(EGsManagedParamType.Unit, item6.GetPathName(), BGU_DataUtil.GetActorGuid(item6, bFindFromComponent: true), new FName(item6.GetName()), 3, out var OutConfigGuid))
					{
						list5.Add(OutConfigGuid);
					}
				}
				BUS_GuidComp guidComp = bGUOverlapArea.GuidComp;
				if (guidComp == null)
				{
					return;
				}
				string unitRandomGuid = guidComp.UnitRandomGuid;
				bED_BossRushAsset.AddParameter(EGsManagedParamType.Overlap, bGUOverlapArea.GetPathName(), unitRandomGuid, new FName("接战触发盒"), 0, out var OutConfigGuid2);
				UCalliopeNode fromNode = null;
				if (bED_BossRushAsset.Nodes.Count > 0)
				{
					fromNode = bED_BossRushAsset.Nodes.Values.First();
				}
				UCalliopeNode fromNode2 = UGSEditorAssetLibrary.AddCalliopeNode(bED_BossRushAsset, UClass.GetClass<BED_BossRushNode_Wait>(), new FVector2D(300.0, 0.0), fromNode, "out");
				BED_BossRushNode_Battle bED_BossRushNode_Battle = UGSEditorAssetLibrary.AddCalliopeNode(bED_BossRushAsset, UClass.GetClass<BED_BossRushNode_Battle>(), new FVector2D(600.0, 0.0), fromNode2, "out") as BED_BossRushNode_Battle;
				if (bED_BossRushNode_Battle != null)
				{
					FBattleStartCondition startCondition = bED_BossRushNode_Battle.StartCondition;
					startCondition.Overlap.ConfigGuid = GameplayTagExtension.ConvertToGuid(OutConfigGuid2);
					startCondition.StartConditionType = EBattleStartConditionType.EnterOverlap;
					bED_BossRushNode_Battle.StartCondition = startCondition;
					FUnitsAndSpawners battleStartActiveList = bED_BossRushNode_Battle.BattleStartActiveList;
					battleStartActiveList.UnitList.ConfigGuides = new List<Guid>();
					foreach (FCalliopeGuid item7 in list5)
					{
						battleStartActiveList.UnitList.ConfigGuides.Add(GameplayTagExtension.ConvertToGuid(item7));
					}
					bED_BossRushNode_Battle.BattleStartActiveList = battleStartActiveList;
					FTransitionCondition_Battle single = new FTransitionCondition_Battle
					{
						ConditionType = ETransitionConditionType_Battle.UnitsDead,
						UnitList = 
						{
							ConfigGuides = new List<Guid>()
						}
					};
					foreach (FCalliopeGuid item8 in list5)
					{
						single.UnitList.ConfigGuides.Add(GameplayTagExtension.ConvertToGuid(item8));
					}
					FCompositeTransitionCondition_Battle item = new FCompositeTransitionCondition_Battle
					{
						Single = single,
						Comment = "所有怪物死亡"
					};
					bED_BossRushNode_Battle.TransitionConditions.Add(item);
				}
				UGSEditorAssetLibrary.AddCalliopeNode(bED_BossRushAsset, UClass.GetClass<BED_BossRushNode_End>(), new FVector2D(900.0, 0.0), bED_BossRushNode_Battle, "所有怪物死亡");
				UGSEditorAssetLibrary.SaveAsset(bED_BossRushAsset);
				UGSEditorAssetLibrary.CloseAllEditorsForAsset(bED_BossRushAsset);
				T CreatePlayerStart<T>(string InActorName) where T : ABossRushPlayerStart
				{
					T val = UGSEditorLevelLibrary.SpawnActor2SubLevel(SubLevel, UClass.GetClass<T>(), FTransform.Identity, new FName(InActorName)) as T;
					if (val != null)
					{
						val.LevelTag = new FName(LevelTag);
						UGSFuncLibForEditor.SetActorLabel(val, InActorName);
					}
					return val;
				}
			}
			if (list2.Count <= 0)
			{
				continue;
			}
			uBossRushLevelConfig.RefreshCurrentLevelNames();
			UGSEditorWCLibrary.LoadSubLevels(list);
			foreach (UWorld item9 in list2)
			{
				UGSEditorWCLibrary.SaveAndDestroyLevelPackage(item9);
			}
			list2.Clear();
			list.Clear();
			foreach (FUStBossRushConfigDesc item10 in item3.Value)
			{
				if (!list3.Contains(item10.ID))
				{
					continue;
				}
				string text5 = item10.LevelName.ToLowerInvariant();
				string text6 = uBossRushLevelConfig.LevelNamePrefix + "_BR_" + text5.ToLowerInvariant();
				BED_BossRushAsset bED_BossRushAsset2 = UEditorAssetLibrary.LoadAsset("/Game/00MainHZ/BossRush/Graph/BRG_" + uBossRushLevelConfig.LevelNamePrefix.ToLowerInvariant() + "_" + text5) as BED_BossRushAsset;
				if (bED_BossRushAsset2 == null)
				{
					continue;
				}
				UGSEditorAssetLibrary.OpenAsset(bED_BossRushAsset2);
				FGsSmartParam persistentLevel = new FGsSmartParam
				{
					ConfigGuid = GameplayTagExtension.ConvertToGuid(uBossRushLevelConfig.ConfigGuid)
				};
				bED_BossRushAsset2.PersistentLevel = persistentLevel;
				bED_BossRushAsset2.LevelTag = new FName(text5);
				bED_BossRushAsset2.RefreshLevel();
				for (int j = 0; j < bED_BossRushAsset2.BossRushLevelsLoadSetting.Count; j++)
				{
					FBossRushLevelState value2 = bED_BossRushAsset2.BossRushLevelsLoadSetting[j];
					if (value2.LevelName == text6)
					{
						value2.bModify = true;
						value2.ModifyLevelState = ELevelLoadState.Load;
						bED_BossRushAsset2.BossRushLevelsLoadSetting[j] = value2;
						break;
					}
				}
				bED_BossRushAsset2.ExportToData();
				UGSEditorAssetLibrary.SaveAsset(bED_BossRushAsset2);
				UGSEditorAssetLibrary.CloseAllEditorsForAsset(bED_BossRushAsset2);
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("------------GraphPath------------");
		foreach (KeyValuePair<int, string> item11 in dictionary)
		{
			stringBuilder.AppendLine($"{item11.Key}\t\t{item11.Value}");
		}
		BED_CalliopeAssetBase.bIgnoreExportErrorDialogue = false;
	}

	private void RunCustomCreate()
	{
		if (CustomCreateID <= 0)
		{
			BatchCreateBRLevel();
			return;
		}
		BGW_GameDB.Init("B1");
		FUStBossRushConfigDesc bossRushConfigDesc = BGW_GameDB.GetBossRushConfigDesc(CustomCreateID);
		BED_CalliopeAssetBase.bIgnoreExportErrorDialogue = true;
		LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(bossRushConfigDesc.LevelID);
		UBossRushLevelConfig uBossRushLevelConfig = null;
		foreach (UBossRushLevelConfig levelConfig in LevelConfigs)
		{
			if (levelConfig.PersistentLevel == levelDesc.Path)
			{
				uBossRushLevelConfig = levelConfig;
				break;
			}
		}
		if (uBossRushLevelConfig == null)
		{
			return;
		}
		string LevelTag = bossRushConfigDesc.LevelName;
		List<UClass> list = new List<UClass>();
		if (bCreateTamer)
		{
			bool flag = bossRushConfigDesc.TamerPath.Count != 1;
			foreach (string item2 in bossRushConfigDesc.TamerPath)
			{
				string text = ((flag ? FPaths.GetBaseFilename(item2).Substring(6) : uBossRushLevelConfig.LevelNamePrefix) + "_" + LevelTag).ToLowerInvariant();
				UBlueprint uBlueprint = UEditorAssetLibrary.LoadAsset(item2) as UBlueprint;
				if (!(uBlueprint != null))
				{
					continue;
				}
				string text2 = "/Game/00MainHZ/BossRush/Tamer/BRT_" + text;
				if (UEditorAssetLibrary.DoesAssetExist(text2))
				{
					list.Add(UEditorAssetLibrary.LoadBlueprintClass(text2).Value);
					continue;
				}
				UBlueprint uBlueprint2 = UEditorAssetLibrary.DuplicateLoadedAsset(uBlueprint, text2) as UBlueprint;
				if (uBlueprint2 != null)
				{
					UGSFuncLibForEditor.CopyThumbnailBetweenBlueprint(uBlueprint, uBlueprint2);
					list.Add(uBlueprint2.GeneratedClass);
				}
			}
		}
		ULevel SubLevel;
		if (bCreateBRGraphAndLevel)
		{
			uBossRushLevelConfig.RefreshCurrentLevelNames();
			List<string> list2 = new List<string>();
			List<UWorld> list3 = new List<UWorld>();
			string text3 = uBossRushLevelConfig.LevelNamePrefix + "_BR_" + LevelTag.ToLowerInvariant();
			if (uBossRushLevelConfig.SubLevelList.Contains(text3))
			{
				return;
			}
			UWorld uWorld = UGSEditorWCLibrary.CreateNewLevelPackageAndReturn(FPaths.Combine(FPaths.GetPath(uBossRushLevelConfig.PersistentLevelLongPackageName), "BossRush"), text3);
			if (uWorld != null)
			{
				UGSEditorLevelLibrary.SetBossRushLevelLayer(uWorld);
				SubLevel = UGSEditorLevelLibrary.ConvertWorld2LevelObject(uWorld);
				List<AActor> list4 = new List<AActor>();
				foreach (UClass item3 in list)
				{
					AActor aActor = UGSEditorLevelLibrary.SpawnActor2SubLevel(SubLevel, item3, FTransform.Identity, FName.None);
					if (aActor != null)
					{
						list4.Add(aActor);
					}
				}
				string text4 = "BROB_BattleStart_" + LevelTag;
				FTransform inTransform = default(FTransform);
				inTransform.SetScale3D(new FVector(20f));
				BGUOverlapArea bGUOverlapArea = UGSEditorLevelLibrary.SpawnActor2SubLevel(SubLevel, UEditorAssetLibrary.LoadBlueprintClass("Blueprint'/Game/00Main/BPLibrary/SceneObj/BP_OverlapBox.BP_OverlapBox'").Value, inTransform, new FName(text4)) as BGUOverlapArea;
				UGSFuncLibForEditor.SetActorLabel(bGUOverlapArea, text4);
				CreatePlayerStart<ABossRushPlayerStart_Single>("BRPS_" + LevelTag + "_Single");
				CreatePlayerStart<ABossRushPlayerStart_Group>("BRPS_" + LevelTag + "_Group");
				list2.Add(text3);
				list3.Add(uWorld);
				BED_BossRushAsset bED_BossRushAsset = UGSEditorAssetLibrary.CreateBossRushGraphAsset("/Game/00MainHZ/BossRush/Graph/", "BRG_" + uBossRushLevelConfig.LevelNamePrefix.ToLowerInvariant() + "_" + LevelTag, UClass.GetClass<BED_BossRushAsset>()) as BED_BossRushAsset;
				if (bED_BossRushAsset != null)
				{
					UGSEditorAssetLibrary.OpenAsset(bED_BossRushAsset);
					List<FCalliopeGuid> list5 = new List<FCalliopeGuid>();
					foreach (AActor item4 in list4)
					{
						if (bED_BossRushAsset.AddParameter(EGsManagedParamType.Unit, item4.GetPathName(), BGU_DataUtil.GetActorGuid(item4, bFindFromComponent: true), new FName(item4.GetName()), 3, out var OutConfigGuid))
						{
							list5.Add(OutConfigGuid);
						}
					}
					FCalliopeGuid OutConfigGuid2 = default(FCalliopeGuid);
					if (bGUOverlapArea != null)
					{
						BUS_GuidComp guidComp = bGUOverlapArea.GuidComp;
						if (guidComp != null)
						{
							string unitRandomGuid = guidComp.UnitRandomGuid;
							bED_BossRushAsset.AddParameter(EGsManagedParamType.Overlap, bGUOverlapArea.GetPathName(), unitRandomGuid, new FName("接战触发盒"), 0, out OutConfigGuid2);
						}
					}
					UCalliopeNode fromNode = null;
					if (bED_BossRushAsset.Nodes.Count > 0)
					{
						fromNode = bED_BossRushAsset.Nodes.Values.First();
					}
					UCalliopeNode fromNode2 = UGSEditorAssetLibrary.AddCalliopeNode(bED_BossRushAsset, UClass.GetClass<BED_BossRushNode_Wait>(), new FVector2D(300.0, 0.0), fromNode, "out");
					BED_BossRushNode_Battle bED_BossRushNode_Battle = UGSEditorAssetLibrary.AddCalliopeNode(bED_BossRushAsset, UClass.GetClass<BED_BossRushNode_Battle>(), new FVector2D(600.0, 0.0), fromNode2, "out") as BED_BossRushNode_Battle;
					if (bED_BossRushNode_Battle != null)
					{
						FBattleStartCondition startCondition = bED_BossRushNode_Battle.StartCondition;
						startCondition.Overlap.ConfigGuid = GameplayTagExtension.ConvertToGuid(OutConfigGuid2);
						startCondition.StartConditionType = EBattleStartConditionType.EnterOverlap;
						bED_BossRushNode_Battle.StartCondition = startCondition;
						FUnitsAndSpawners battleStartActiveList = bED_BossRushNode_Battle.BattleStartActiveList;
						battleStartActiveList.UnitList.ConfigGuides = new List<Guid>();
						foreach (FCalliopeGuid item5 in list5)
						{
							battleStartActiveList.UnitList.ConfigGuides.Add(GameplayTagExtension.ConvertToGuid(item5));
						}
						bED_BossRushNode_Battle.BattleStartActiveList = battleStartActiveList;
						FTransitionCondition_Battle single = new FTransitionCondition_Battle
						{
							ConditionType = ETransitionConditionType_Battle.UnitsDead,
							UnitList = 
							{
								ConfigGuides = new List<Guid>()
							}
						};
						foreach (FCalliopeGuid item6 in list5)
						{
							single.UnitList.ConfigGuides.Add(GameplayTagExtension.ConvertToGuid(item6));
						}
						FCompositeTransitionCondition_Battle item = new FCompositeTransitionCondition_Battle
						{
							Single = single,
							Comment = "所有怪物死亡"
						};
						bED_BossRushNode_Battle.TransitionConditions.Add(item);
					}
					UGSEditorAssetLibrary.AddCalliopeNode(bED_BossRushAsset, UClass.GetClass<BED_BossRushNode_End>(), new FVector2D(900.0, 0.0), bED_BossRushNode_Battle, "所有怪物死亡");
					UGSEditorAssetLibrary.SaveAsset(bED_BossRushAsset);
					UGSEditorAssetLibrary.CloseAllEditorsForAsset(bED_BossRushAsset);
					uBossRushLevelConfig.RefreshCurrentLevelNames();
					UGSEditorWCLibrary.LoadSubLevels(list2);
					foreach (UWorld item7 in list3)
					{
						UGSEditorWCLibrary.SaveAndDestroyLevelPackage(item7);
					}
					list3.Clear();
					list2.Clear();
					UGSEditorAssetLibrary.OpenAsset(bED_BossRushAsset);
					FGsSmartParam persistentLevel = new FGsSmartParam
					{
						ConfigGuid = GameplayTagExtension.ConvertToGuid(uBossRushLevelConfig.ConfigGuid)
					};
					bED_BossRushAsset.PersistentLevel = persistentLevel;
					bED_BossRushAsset.LevelTag = new FName(LevelTag);
					bED_BossRushAsset.RefreshLevel();
					for (int i = 0; i < bED_BossRushAsset.BossRushLevelsLoadSetting.Count; i++)
					{
						FBossRushLevelState value = bED_BossRushAsset.BossRushLevelsLoadSetting[i];
						if (value.LevelName == text3)
						{
							value.bModify = true;
							value.ModifyLevelState = ELevelLoadState.Load;
							bED_BossRushAsset.BossRushLevelsLoadSetting[i] = value;
							break;
						}
					}
					bED_BossRushAsset.ExportToData();
					UGSEditorAssetLibrary.SaveAsset(bED_BossRushAsset);
					UGSEditorAssetLibrary.CloseAllEditorsForAsset(bED_BossRushAsset);
				}
			}
		}
		BED_CalliopeAssetBase.bIgnoreExportErrorDialogue = false;
		T CreatePlayerStart<T>(string InActorName) where T : ABossRushPlayerStart
		{
			T val = UGSEditorLevelLibrary.SpawnActor2SubLevel(SubLevel, UClass.GetClass<T>(), FTransform.Identity, new FName(InActorName)) as T;
			if (val != null)
			{
				val.LevelTag = new FName(LevelTag);
				UGSFuncLibForEditor.SetActorLabel(val, InActorName);
			}
			return val;
		}
	}

	private void FixBRLevelTransactionalActors()
	{
		foreach (UBossRushLevelConfig levelConfig in LevelConfigs)
		{
			levelConfig.FixBRLevelTransactionalActors();
		}
	}

	private void SetAllBRLevelLayer()
	{
		List<string> list = new List<string>();
		foreach (UBossRushLevelConfig levelConfig in LevelConfigs)
		{
			list.Add(levelConfig.PersistentLevelLongPackageName);
		}
		UGSEditorLevelLibrary.SetAllBossRushLevelLayer(list);
	}

	private void CheckTamerPlaceLevel()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (UBossRushLevelConfig levelConfig in LevelConfigs)
		{
			if (levelConfig.CheckTamerPlaceLevel(out var ErrorMsg))
			{
				stringBuilder.AppendLine(ErrorMsg);
			}
		}
		FMessage.OpenDialog(stringBuilder.ToString());
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_BossRushLevelConfig bGWDataAsset_BossRushLevelConfig = GCHelper.Find<BGWDataAsset_BossRushLevelConfig>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		bGWDataAsset_BossRushLevelConfig.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig");
		BattleReadyTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleReadyTime");
		BattleReadyTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleReadyTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bRefreshAllLevelList_PropertyAddress, intPtr, "bRefreshAllLevelList");
		bRefreshAllLevelList_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRefreshAllLevelList");
		bRefreshAllLevelList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRefreshAllLevelList", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PersistentLevelPaths_PropertyAddress, intPtr, "PersistentLevelPaths");
		PersistentLevelPaths_Offset = NativeReflection.GetPropertyOffset(intPtr, "PersistentLevelPaths");
		PersistentLevelPaths_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PersistentLevelPaths", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref LevelConfigs_PropertyAddress, intPtr, "LevelConfigs");
		LevelConfigs_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelConfigs");
		LevelConfigs_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelConfigs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bClearAllConfig_PropertyAddress, intPtr, "bClearAllConfig");
		bClearAllConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "bClearAllConfig");
		bClearAllConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bClearAllConfig", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bBatchCreateBRLevel_PropertyAddress, intPtr, "bBatchCreateBRLevel");
		bBatchCreateBRLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bBatchCreateBRLevel");
		bBatchCreateBRLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bBatchCreateBRLevel", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bRunCustomCreate_PropertyAddress, intPtr, "bRunCustomCreate");
		bRunCustomCreate_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRunCustomCreate");
		bRunCustomCreate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRunCustomCreate", Classes.FBoolProperty);
		CustomCreateID_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomCreateID");
		CustomCreateID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomCreateID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bCreateTamer_PropertyAddress, intPtr, "bCreateTamer");
		bCreateTamer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCreateTamer");
		bCreateTamer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCreateTamer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCreateBRGraphAndLevel_PropertyAddress, intPtr, "bCreateBRGraphAndLevel");
		bCreateBRGraphAndLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCreateBRGraphAndLevel");
		bCreateBRGraphAndLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCreateBRGraphAndLevel", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheckLevelNameHasRepeatable_PropertyAddress, intPtr, "bCheckLevelNameHasRepeatable");
		bCheckLevelNameHasRepeatable_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheckLevelNameHasRepeatable");
		bCheckLevelNameHasRepeatable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheckLevelNameHasRepeatable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheckTamerPlaceLevel_PropertyAddress, intPtr, "bCheckTamerPlaceLevel");
		bCheckTamerPlaceLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheckTamerPlaceLevel");
		bCheckTamerPlaceLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheckTamerPlaceLevel", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFixBRLevelTransactionalActors_PropertyAddress, intPtr, "bFixBRLevelTransactionalActors");
		bFixBRLevelTransactionalActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFixBRLevelTransactionalActors");
		bFixBRLevelTransactionalActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFixBRLevelTransactionalActors", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSetAllBRLevelLayer_PropertyAddress, intPtr, "bSetAllBRLevelLayer");
		bSetAllBRLevelLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSetAllBRLevelLayer");
		bSetAllBRLevelLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSetAllBRLevelLayer", Classes.FBoolProperty);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_BossRushLevelConfig:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static BGWDataAsset_BossRushLevelConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BossRushLevelConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BossRushLevelConfig));
	}
}
