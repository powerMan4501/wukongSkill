using System;
using System.Collections.Generic;
using System.Text;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

[UClass]
[EditInlineNew]
[CollapseCategories(true)]
[USharpPath("/Script/b1-Managed.BossRushLevelConfig")]
public class UBossRushLevelConfig : UBGWObjectExtend
{
	private static bool ConfigGuid_IsValid;

	private static int ConfigGuid_Offset;

	private static bool PersistentLevelAssetName_IsValid;

	private static int PersistentLevelAssetName_Offset;

	private static bool PersistentLevelLongPackageName_IsValid;

	private static int PersistentLevelLongPackageName_Offset;

	private static bool PersistentLevel_IsValid;

	private static int PersistentLevel_Offset;

	private static bool LevelNamePrefix_IsValid;

	private static int LevelNamePrefix_Offset;

	private static bool bRefreshLevelList_IsValid;

	private static int bRefreshLevelList_Offset;

	private static FFieldAddress bRefreshLevelList_PropertyAddress;

	private static bool SubLevelList_IsValid;

	private static int SubLevelList_Offset;

	private static FFieldAddress SubLevelList_PropertyAddress;

	private TArrayReadWriteMarshaler<string> SubLevelList_Marshaler;

	private static bool BossRushLevelsLoadSetting_IsValid;

	private static int BossRushLevelsLoadSetting_Offset;

	private static FFieldAddress BossRushLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, FBossRushLevelState> BossRushLevelsLoadSetting_Marshaler;

	private static bool GeometryLevelsLoadSetting_IsValid;

	private static int GeometryLevelsLoadSetting_Offset;

	private static FFieldAddress GeometryLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, FBossRushLevelState> GeometryLevelsLoadSetting_Marshaler;

	private static bool OtherLevelsLoadSetting_IsValid;

	private static int OtherLevelsLoadSetting_Offset;

	private static FFieldAddress OtherLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, FBossRushLevelState> OtherLevelsLoadSetting_Marshaler;

	private static bool SeqLevelsLoadSetting_IsValid;

	private static int SeqLevelsLoadSetting_Offset;

	private static FFieldAddress SeqLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, FBossRushLevelState> SeqLevelsLoadSetting_Marshaler;

	private static bool ItemLevelsLoadSetting_IsValid;

	private static int ItemLevelsLoadSetting_Offset;

	private static FFieldAddress ItemLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, FBossRushLevelState> ItemLevelsLoadSetting_Marshaler;

	private static bool LightLevelsLoadSetting_IsValid;

	private static int LightLevelsLoadSetting_Offset;

	private static FFieldAddress LightLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, FBossRushLevelState> LightLevelsLoadSetting_Marshaler;

	private static bool SupportLevelsLoadSetting_IsValid;

	private static int SupportLevelsLoadSetting_Offset;

	private static FFieldAddress SupportLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, FBossRushLevelState> SupportLevelsLoadSetting_Marshaler;

	private static bool MonsterLevelsLoadSetting_IsValid;

	private static int MonsterLevelsLoadSetting_Offset;

	private static FFieldAddress MonsterLevelsLoadSetting_PropertyAddress;

	private TMapReadWriteMarshaler<string, FBossRushLevelState> MonsterLevelsLoadSetting_Marshaler;

	private static bool bFixBRLevelTransactionalActors_IsValid;

	private static int bFixBRLevelTransactionalActors_Offset;

	private static FFieldAddress bFixBRLevelTransactionalActors_PropertyAddress;

	private static bool bSetAllBRLevelLayer_IsValid;

	private static int bSetAllBRLevelLayer_Offset;

	private static FFieldAddress bSetAllBRLevelLayer_PropertyAddress;

	private static bool bCheckTamerPlaceLevel_IsValid;

	private static int bCheckTamerPlaceLevel_Offset;

	private static FFieldAddress bCheckTamerPlaceLevel_PropertyAddress;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:ConfigGuid")]
	public FCalliopeGuid ConfigGuid
	{
		get
		{
			CheckDestroyed();
			if (!ConfigGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:ConfigGuid");
				return default(FCalliopeGuid);
			}
			return FCalliopeGuid.FromNative(IntPtr.Add(base.Address, ConfigGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:ConfigGuid");
			}
			else
			{
				FCalliopeGuid.ToNative(IntPtr.Add(base.Address, ConfigGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:PersistentLevelAssetName")]
	public string PersistentLevelAssetName
	{
		get
		{
			CheckDestroyed();
			if (!PersistentLevelAssetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:PersistentLevelAssetName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PersistentLevelAssetName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PersistentLevelAssetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:PersistentLevelAssetName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PersistentLevelAssetName_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:PersistentLevelLongPackageName")]
	public string PersistentLevelLongPackageName
	{
		get
		{
			CheckDestroyed();
			if (!PersistentLevelLongPackageName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:PersistentLevelLongPackageName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PersistentLevelLongPackageName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PersistentLevelLongPackageName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:PersistentLevelLongPackageName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PersistentLevelLongPackageName_Offset), value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("当前持久关卡")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:PersistentLevel")]
	public string PersistentLevel
	{
		get
		{
			CheckDestroyed();
			if (!PersistentLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:PersistentLevel");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, PersistentLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PersistentLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:PersistentLevel");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, PersistentLevel_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("关卡前缀")]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:LevelNamePrefix")]
	public string LevelNamePrefix
	{
		get
		{
			CheckDestroyed();
			if (!LevelNamePrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:LevelNamePrefix");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, LevelNamePrefix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LevelNamePrefix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:LevelNamePrefix");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, LevelNamePrefix_Offset), value);
			}
		}
	}

	[DisplayName("更新当前关卡列表")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:bRefreshLevelList")]
	public bool bRefreshLevelList
	{
		get
		{
			CheckDestroyed();
			if (!bRefreshLevelList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:bRefreshLevelList");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bRefreshLevelList_Offset), 0, bRefreshLevelList_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bRefreshLevelList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:bRefreshLevelList");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bRefreshLevelList_Offset), 0, bRefreshLevelList_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("当前子关卡列表")]
	[UMeta(MDFunc.AdvancedDisplay)]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:SubLevelList")]
	public TArrayReadWrite<string> SubLevelList
	{
		get
		{
			CheckDestroyed();
			if (!SubLevelList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:SubLevelList");
				return null;
			}
			if (SubLevelList_Marshaler == null)
			{
				SubLevelList_Marshaler = new TArrayReadWriteMarshaler<string>(1, SubLevelList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return SubLevelList_Marshaler.FromNative(IntPtr.Add(base.Address, SubLevelList_Offset));
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("BR关卡加载配置")]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:BossRushLevelsLoadSetting")]
	public TMapReadWrite<string, FBossRushLevelState> BossRushLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!BossRushLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:BossRushLevelsLoadSetting");
				return null;
			}
			if (BossRushLevelsLoadSetting_Marshaler == null)
			{
				BossRushLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, FBossRushLevelState>(1, BossRushLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return BossRushLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, BossRushLevelsLoadSetting_Offset));
		}
	}

	[DisplayName("场景关卡加载配置")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:GeometryLevelsLoadSetting")]
	public TMapReadWrite<string, FBossRushLevelState> GeometryLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!GeometryLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:GeometryLevelsLoadSetting");
				return null;
			}
			if (GeometryLevelsLoadSetting_Marshaler == null)
			{
				GeometryLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, FBossRushLevelState>(1, GeometryLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return GeometryLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, GeometryLevelsLoadSetting_Offset));
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("其他关卡加载配置")]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:OtherLevelsLoadSetting")]
	public TMapReadWrite<string, FBossRushLevelState> OtherLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!OtherLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:OtherLevelsLoadSetting");
				return null;
			}
			if (OtherLevelsLoadSetting_Marshaler == null)
			{
				OtherLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, FBossRushLevelState>(1, OtherLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return OtherLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, OtherLevelsLoadSetting_Offset));
		}
	}

	[DisplayName("Seq关卡加载配置")]
	[BlueprintReadWrite]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:SeqLevelsLoadSetting")]
	public TMapReadWrite<string, FBossRushLevelState> SeqLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!SeqLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:SeqLevelsLoadSetting");
				return null;
			}
			if (SeqLevelsLoadSetting_Marshaler == null)
			{
				SeqLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, FBossRushLevelState>(1, SeqLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return SeqLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, SeqLevelsLoadSetting_Offset));
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Item关卡加载配置")]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:ItemLevelsLoadSetting")]
	public TMapReadWrite<string, FBossRushLevelState> ItemLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!ItemLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:ItemLevelsLoadSetting");
				return null;
			}
			if (ItemLevelsLoadSetting_Marshaler == null)
			{
				ItemLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, FBossRushLevelState>(1, ItemLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return ItemLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, ItemLevelsLoadSetting_Offset));
		}
	}

	[VisibleAnywhere]
	[DisplayName("灯光关卡加载配置")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:LightLevelsLoadSetting")]
	public TMapReadWrite<string, FBossRushLevelState> LightLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!LightLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:LightLevelsLoadSetting");
				return null;
			}
			if (LightLevelsLoadSetting_Marshaler == null)
			{
				LightLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, FBossRushLevelState>(1, LightLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return LightLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, LightLevelsLoadSetting_Offset));
		}
	}

	[DisplayName("功能关卡加载配置")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:SupportLevelsLoadSetting")]
	public TMapReadWrite<string, FBossRushLevelState> SupportLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!SupportLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:SupportLevelsLoadSetting");
				return null;
			}
			if (SupportLevelsLoadSetting_Marshaler == null)
			{
				SupportLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, FBossRushLevelState>(1, SupportLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return SupportLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, SupportLevelsLoadSetting_Offset));
		}
	}

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Monster关卡加载配置")]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:MonsterLevelsLoadSetting")]
	public TMapReadWrite<string, FBossRushLevelState> MonsterLevelsLoadSetting
	{
		get
		{
			CheckDestroyed();
			if (!MonsterLevelsLoadSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:MonsterLevelsLoadSetting");
				return null;
			}
			if (MonsterLevelsLoadSetting_Marshaler == null)
			{
				MonsterLevelsLoadSetting_Marshaler = new TMapReadWriteMarshaler<string, FBossRushLevelState>(1, MonsterLevelsLoadSetting_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.FromNative, CachedMarshalingDelegates<FBossRushLevelState, FBossRushLevelState>.ToNative);
			}
			return MonsterLevelsLoadSetting_Marshaler.FromNative(IntPtr.Add(base.Address, MonsterLevelsLoadSetting_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("修复BR关卡不可删除Actor(程序用)")]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:bFixBRLevelTransactionalActors")]
	public bool bFixBRLevelTransactionalActors
	{
		get
		{
			CheckDestroyed();
			if (!bFixBRLevelTransactionalActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:bFixBRLevelTransactionalActors");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFixBRLevelTransactionalActors_Offset), 0, bFixBRLevelTransactionalActors_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFixBRLevelTransactionalActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:bFixBRLevelTransactionalActors");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFixBRLevelTransactionalActors_Offset), 0, bFixBRLevelTransactionalActors_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("修复BR关卡加载策略(程序用)")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:bSetAllBRLevelLayer")]
	public bool bSetAllBRLevelLayer
	{
		get
		{
			CheckDestroyed();
			if (!bSetAllBRLevelLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:bSetAllBRLevelLayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSetAllBRLevelLayer_Offset), 0, bSetAllBRLevelLayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSetAllBRLevelLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:bSetAllBRLevelLayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSetAllBRLevelLayer_Offset), 0, bSetAllBRLevelLayer_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty(PropFlags.Transient)]
	[EditAnywhere]
	[UMeta(MDFunc.AdvancedDisplay)]
	[DisplayName("检查Tamer关卡规范(程序用)")]
	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:bCheckTamerPlaceLevel")]
	public bool bCheckTamerPlaceLevel
	{
		get
		{
			CheckDestroyed();
			if (!bCheckTamerPlaceLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:bCheckTamerPlaceLevel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCheckTamerPlaceLevel_Offset), 0, bCheckTamerPlaceLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCheckTamerPlaceLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BossRushLevelConfig:bCheckTamerPlaceLevel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCheckTamerPlaceLevel_Offset), 0, bCheckTamerPlaceLevel_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ConfigGuid = GameplayTagExtension.ConvertToCalliopeGuid(Guid.NewGuid());
	}

	[USharpPath("/Script/b1-Managed.BossRushLevelConfig:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (PropertyName == "bRefreshLevelList" && bRefreshLevelList)
		{
			bRefreshLevelList = false;
			RefreshCurrentLevelNames();
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
		else if (PropertyName == "bCheckTamerPlaceLevel" && bCheckTamerPlaceLevel)
		{
			bCheckTamerPlaceLevel = false;
			CheckTamerPlaceLevel(out var _);
		}
	}

	private void UpdateLevels(IList<string> CurrentLevels, (ELevelLoadState, IDictionary<string, FBossRushLevelState>) OtherConfig, params (string, ELevelLoadState, IDictionary<string, FBossRushLevelState>, bool)[] ConfigList)
	{
		Dictionary<string, ELevelLoadState> OldConfig = new Dictionary<string, ELevelLoadState>();
		(string, ELevelLoadState, IDictionary<string, FBossRushLevelState>, bool)[] array = ConfigList;
		for (int i = 0; i < array.Length; i++)
		{
			SaveOldConfigAndClear(array[i].Item3);
		}
		SaveOldConfigAndClear(OtherConfig.Item2);
		foreach (string CurrentLevel in CurrentLevels)
		{
			string LevelName = CurrentLevel;
			string text = LevelName.ToLower();
			bool flag = true;
			array = ConfigList;
			for (int i = 0; i < array.Length; i++)
			{
				(string, ELevelLoadState, IDictionary<string, FBossRushLevelState>, bool) tuple = array[i];
				if (text.Contains(tuple.Item1))
				{
					flag = false;
					Add2LoadSetting(tuple.Item3, tuple.Item2, tuple.Item4);
					break;
				}
			}
			if (flag)
			{
				Add2LoadSetting(OtherConfig.Item2, OtherConfig.Item1, bUseKeyword: true);
			}
			void Add2LoadSetting(IDictionary<string, FBossRushLevelState> LoadSetting, ELevelLoadState DefaultState, bool bUseKeyword)
			{
				if (!LoadSetting.ContainsKey(LevelName))
				{
					FBossRushLevelState value = new FBossRushLevelState
					{
						LevelName = LevelName,
						OriginLevelState = DefaultState,
						ModifyLevelState = DefaultState,
						bHasKeywords = bUseKeyword
					};
					if (OldConfig.TryGetValue(LevelName, out var value2))
					{
						value.bModify = true;
						value.ModifyLevelState = value2;
					}
					OldConfig.Remove(LevelName);
					LoadSetting[LevelName] = value;
				}
			}
		}
		if (OldConfig.Count > 0)
		{
			string text2 = "检测到配置丢失，请及时确认：\n";
			foreach (KeyValuePair<string, ELevelLoadState> item in OldConfig)
			{
				text2 += $"{item.Key}:{item.Value}\n";
			}
			BGW_LogUtil.LogError(text2);
			FMessage.OpenDialog(text2);
		}
		OldConfig.Clear();
		void SaveOldConfigAndClear(IDictionary<string, FBossRushLevelState> LoadSetting)
		{
			foreach (KeyValuePair<string, FBossRushLevelState> item2 in LoadSetting)
			{
				if (item2.Value.bModify)
				{
					OldConfig[item2.Key] = item2.Value.ModifyLevelState;
				}
			}
			LoadSetting.Clear();
		}
	}

	public void RefreshCurrentLevelNames()
	{
		if (!UGSE_EditorFuncLib.OpenLevelInEditor(PersistentLevelLongPackageName))
		{
			return;
		}
		if (string.IsNullOrEmpty(LevelNamePrefix))
		{
			LevelNamePrefix = PersistentLevel.Substring(0, PersistentLevel.LastIndexOf('_'));
		}
		UGSEditorLevelLibrary.GetCurrentAllWCLevelsName(out var OutLevelsName);
		if (OutLevelsName == null)
		{
			return;
		}
		foreach (string item in OutLevelsName)
		{
			if (!SubLevelList.Contains(item))
			{
				SubLevelList.Add(item);
			}
		}
		List<string> list = new List<string>();
		foreach (string subLevel in SubLevelList)
		{
			if (!OutLevelsName.Contains(subLevel))
			{
				list.Add(subLevel);
			}
		}
		foreach (string item2 in list)
		{
			SubLevelList.Remove(item2);
		}
		UpdateLevels(SubLevelList, (ELevelLoadState.Auto, OtherLevelsLoadSetting), ("volume", ELevelLoadState.Load, OtherLevelsLoadSetting, false), ("pv05", ELevelLoadState.Unload, OtherLevelsLoadSetting, false), ("audio", ELevelLoadState.Load, OtherLevelsLoadSetting, false), ("nav", ELevelLoadState.Auto, SupportLevelsLoadSetting, false), ("graybox", ELevelLoadState.Auto, SupportLevelsLoadSetting, false), ("light", ELevelLoadState.Load, LightLevelsLoadSetting, false), ("rtx", ELevelLoadState.Load, LightLevelsLoadSetting, false), ("seq", ELevelLoadState.Unload, SeqLevelsLoadSetting, false), ("item_rzd", ELevelLoadState.Unload, ItemLevelsLoadSetting, false), ("item_yyy", ELevelLoadState.Unload, ItemLevelsLoadSetting, false), ("collections", ELevelLoadState.Unload, ItemLevelsLoadSetting, false), ("dazuo", ELevelLoadState.Unload, ItemLevelsLoadSetting, false), ("meditation", ELevelLoadState.Unload, ItemLevelsLoadSetting, false), ("treasure", ELevelLoadState.Unload, ItemLevelsLoadSetting, false), ("quest", ELevelLoadState.Unload, ItemLevelsLoadSetting, false), ("item", ELevelLoadState.Auto, ItemLevelsLoadSetting, false), ("yj", ELevelLoadState.Auto, GeometryLevelsLoadSetting, false), ("yuanjing", ELevelLoadState.Auto, GeometryLevelsLoadSetting, false), ("map", ELevelLoadState.Auto, GeometryLevelsLoadSetting, true), ("18diyu", ELevelLoadState.Unload, GeometryLevelsLoadSetting, false), ("neutralanimals", ELevelLoadState.Unload, MonsterLevelsLoadSetting, false), ("monster", ELevelLoadState.Unload, MonsterLevelsLoadSetting, false), ("br", ELevelLoadState.Unload, BossRushLevelsLoadSetting, false));
	}

	public void FixBRLevelTransactionalActors()
	{
		RefreshCurrentLevelNames();
		List<string> list = new List<string>();
		foreach (KeyValuePair<string, FBossRushLevelState> item in BossRushLevelsLoadSetting)
		{
			list.Add(item.Key);
		}
		if (list.Count == 0)
		{
			return;
		}
		UGSEditorWCLibrary.LoadSubLevels(list);
		UWorld PersistentLevelWorld = UGSEditorLevelLibrary.GetCurrentPersistentLevelWorld();
		HashSet<ULevel> NeedSaveLevels = new HashSet<ULevel>();
		FixActors<BUTamerActor>();
		FixActors<BGUOverlapArea>();
		FixActors<ABossRushPlayerStart>();
		foreach (ULevel item2 in NeedSaveLevels)
		{
			UGSEditorLevelLibrary.SaveLevel(item2);
		}
		void FixActors<T>() where T : AActor
		{
			T[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<T>(PersistentLevelWorld);
			foreach (T val in allActorsOfClass)
			{
				if (!val.HasAllFlags(EObjectFlags.Transactional))
				{
					UClass uClass = val.GetClass();
					ULevel uLevel = val.GetOuter() as ULevel;
					if (uLevel != null)
					{
						T val2 = UGSEditorLevelLibrary.SpawnActor2SubLevel(uLevel, uClass, val.GetActorTransform(), FName.None) as T;
						if (val2 != null)
						{
							val2.SetActorLabel(val.GetActorLabel());
							if (val2 is BUTamerActor bUTamerActor && val is BUTamerActor tamerActor)
							{
								bUTamerActor.CopyPropertiesFromTamerActor(tamerActor);
							}
							else if (val2 is ABossRushPlayerStart aBossRushPlayerStart && val is ABossRushPlayerStart aBossRushPlayerStart2)
							{
								aBossRushPlayerStart.LevelTag = aBossRushPlayerStart2.LevelTag;
							}
							else if (val2 is BGUOverlapArea bGUOverlapArea && val is BGUOverlapArea bGUOverlapArea2)
							{
								FCopyPropertiesForUnrelatedObjectsParams parameters = FCopyPropertiesForUnrelatedObjectsParams.Default;
								Native_UEngine.CopyPropertiesForUnrelatedObjects(bGUOverlapArea2.GuidComp.Address, bGUOverlapArea.GuidComp.Address, ref parameters);
								Native_UEngine.CopyPropertiesForUnrelatedObjects(bGUOverlapArea2.ActorConfigInfoComp.Address, bGUOverlapArea.ActorConfigInfoComp.Address, ref parameters);
							}
							AActor attachParentActor = val.GetAttachParentActor();
							if (attachParentActor != null)
							{
								FName attachParentSocketName = val.GetAttachParentSocketName();
								val2.AttachToActor(attachParentActor, attachParentSocketName, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
							}
							val.GetAttachedActors(out var OutActors);
							foreach (AActor item3 in OutActors)
							{
								FName attachParentSocketName2 = item3.GetAttachParentSocketName();
								item3.AttachToActor(val2, attachParentSocketName2, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
							}
							val.DestroyActor();
							uLevel.MarkPackageDirty();
							NeedSaveLevels.Add(uLevel);
						}
					}
				}
			}
		}
	}

	private void SetAllBRLevelLayer()
	{
		UGSEditorLevelLibrary.SetAllBossRushLevelLayer(new List<string> { PersistentLevelLongPackageName });
	}

	public bool CheckTamerPlaceLevel(out string ErrorMsg)
	{
		ErrorMsg = "";
		if (!UGSE_EditorFuncLib.OpenLevelInEditor(PersistentLevelLongPackageName))
		{
			return false;
		}
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		UWorld currentPersistentLevelWorld = UGSEditorLevelLibrary.GetCurrentPersistentLevelWorld();
		UGSEditorLevelLibrary.LoadAllWCLevels(currentPersistentLevelWorld);
		BUTamerActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BUTamerActor>(currentPersistentLevelWorld);
		foreach (BUTamerActor bUTamerActor in allActorsOfClass)
		{
			string text = bUTamerActor.GetOuter().GetOuter().GetName()
				.ToLowerInvariant();
			if (!text.Contains("_monster") && !text.Contains("_br") && !text.Contains("_quest"))
			{
				num++;
				stringBuilder.AppendLine("Tamer:" + bUTamerActor.GetName() + "放置在了" + text + "关卡中");
			}
		}
		if (num > 0)
		{
			ErrorMsg = $"{PersistentLevel}中存在{num}个Tamer关卡不规范:\n{stringBuilder}";
			BGW_LogUtil.LogError(ErrorMsg);
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BossRushLevelConfig:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		UBossRushLevelConfig uBossRushLevelConfig = GCHelper.Find<UBossRushLevelConfig>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		uBossRushLevelConfig.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BossRushLevelConfig");
		ConfigGuid_Offset = NativeReflection.GetPropertyOffset(intPtr, "ConfigGuid");
		ConfigGuid_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ConfigGuid", Classes.FStructProperty);
		PersistentLevelAssetName_Offset = NativeReflection.GetPropertyOffset(intPtr, "PersistentLevelAssetName");
		PersistentLevelAssetName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PersistentLevelAssetName", Classes.FStrProperty);
		PersistentLevelLongPackageName_Offset = NativeReflection.GetPropertyOffset(intPtr, "PersistentLevelLongPackageName");
		PersistentLevelLongPackageName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PersistentLevelLongPackageName", Classes.FStrProperty);
		PersistentLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "PersistentLevel");
		PersistentLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PersistentLevel", Classes.FStrProperty);
		LevelNamePrefix_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelNamePrefix");
		LevelNamePrefix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelNamePrefix", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref bRefreshLevelList_PropertyAddress, intPtr, "bRefreshLevelList");
		bRefreshLevelList_Offset = NativeReflection.GetPropertyOffset(intPtr, "bRefreshLevelList");
		bRefreshLevelList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bRefreshLevelList", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SubLevelList_PropertyAddress, intPtr, "SubLevelList");
		SubLevelList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SubLevelList");
		SubLevelList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SubLevelList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BossRushLevelsLoadSetting_PropertyAddress, intPtr, "BossRushLevelsLoadSetting");
		BossRushLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "BossRushLevelsLoadSetting");
		BossRushLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BossRushLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref GeometryLevelsLoadSetting_PropertyAddress, intPtr, "GeometryLevelsLoadSetting");
		GeometryLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeometryLevelsLoadSetting");
		GeometryLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeometryLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref OtherLevelsLoadSetting_PropertyAddress, intPtr, "OtherLevelsLoadSetting");
		OtherLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "OtherLevelsLoadSetting");
		OtherLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OtherLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SeqLevelsLoadSetting_PropertyAddress, intPtr, "SeqLevelsLoadSetting");
		SeqLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "SeqLevelsLoadSetting");
		SeqLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SeqLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref ItemLevelsLoadSetting_PropertyAddress, intPtr, "ItemLevelsLoadSetting");
		ItemLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ItemLevelsLoadSetting");
		ItemLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ItemLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref LightLevelsLoadSetting_PropertyAddress, intPtr, "LightLevelsLoadSetting");
		LightLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "LightLevelsLoadSetting");
		LightLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LightLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SupportLevelsLoadSetting_PropertyAddress, intPtr, "SupportLevelsLoadSetting");
		SupportLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "SupportLevelsLoadSetting");
		SupportLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SupportLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref MonsterLevelsLoadSetting_PropertyAddress, intPtr, "MonsterLevelsLoadSetting");
		MonsterLevelsLoadSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "MonsterLevelsLoadSetting");
		MonsterLevelsLoadSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MonsterLevelsLoadSetting", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref bFixBRLevelTransactionalActors_PropertyAddress, intPtr, "bFixBRLevelTransactionalActors");
		bFixBRLevelTransactionalActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFixBRLevelTransactionalActors");
		bFixBRLevelTransactionalActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFixBRLevelTransactionalActors", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bSetAllBRLevelLayer_PropertyAddress, intPtr, "bSetAllBRLevelLayer");
		bSetAllBRLevelLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSetAllBRLevelLayer");
		bSetAllBRLevelLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSetAllBRLevelLayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCheckTamerPlaceLevel_PropertyAddress, intPtr, "bCheckTamerPlaceLevel");
		bCheckTamerPlaceLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCheckTamerPlaceLevel");
		bCheckTamerPlaceLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCheckTamerPlaceLevel", Classes.FBoolProperty);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BossRushLevelConfig:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static UBossRushLevelConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UBossRushLevelConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBossRushLevelConfig));
	}
}
