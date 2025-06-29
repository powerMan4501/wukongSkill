using System;
using System.Collections.Generic;
using System.Linq;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp")]
public class BUS_SpawnMultiPointComp : UActorEditCompBase
{
	private static bool bDefaultStartSpawn_IsValid;

	private static int bDefaultStartSpawn_Offset;

	private static FFieldAddress bDefaultStartSpawn_PropertyAddress;

	private static bool GeneratePointsEQSTemplate_IsValid;

	private static int GeneratePointsEQSTemplate_Offset;

	private static bool QueryConfig_IsValid;

	private static int QueryConfig_Offset;

	private static FFieldAddress QueryConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSEnvNamedValue> QueryConfig_Marshaler;

	private static bool PreviewMesh_IsValid;

	private static int PreviewMesh_Offset;

	private static bool Material_IsValid;

	private static int Material_Offset;

	private static bool DiffuseColor_IsValid;

	private static int DiffuseColor_Offset;

	private static bool SpawnPoints_IsValid;

	private static int SpawnPoints_Offset;

	private static FFieldAddress SpawnPoints_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> SpawnPoints_Marshaler;

	private static bool SpawnPointsRot_IsValid;

	private static int SpawnPointsRot_Offset;

	private static FFieldAddress SpawnPointsRot_PropertyAddress;

	private TArrayReadWriteMarshaler<FRotator> SpawnPointsRot_Marshaler;

	private static bool UseSpawnPointsRot_IsValid;

	private static int UseSpawnPointsRot_Offset;

	private static FFieldAddress UseSpawnPointsRot_PropertyAddress;

	private static bool SpawnNum_IsValid;

	private static int SpawnNum_Offset;

	private static bool ReSpawnThreshold_IsValid;

	private static int ReSpawnThreshold_Offset;

	private static bool IsLRU_IsValid;

	private static int IsLRU_Offset;

	private static FFieldAddress IsLRU_PropertyAddress;

	private static bool IsNotSpawnedInPlayerSight_IsValid;

	private static int IsNotSpawnedInPlayerSight_Offset;

	private static FFieldAddress IsNotSpawnedInPlayerSight_PropertyAddress;

	private static bool LowerLimitNum_IsValid;

	private static int LowerLimitNum_Offset;

	private static bool ReSpawnNum_IsValid;

	private static int ReSpawnNum_Offset;

	private static bool ReSpawnTestInterval_IsValid;

	private static int ReSpawnTestInterval_Offset;

	private static bool Type_IsValid;

	private static int Type_Offset;

	private static FFieldAddress Type_PropertyAddress;

	private static bool SpawnedTag_IsValid;

	private static int SpawnedTag_Offset;

	private static bool SpawnRule_IsValid;

	private static int SpawnRule_Offset;

	private static FFieldAddress SpawnRule_PropertyAddress;

	private static bool SpawnActorList_IsValid;

	private static int SpawnActorList_Offset;

	private static FFieldAddress SpawnActorList_PropertyAddress;

	private TArrayReadWriteMarshaler<TSubclassOf<AActor>> SpawnActorList_Marshaler;

	private static bool SpawnHeight_IsValid;

	private static int SpawnHeight_Offset;

	private static bool SpawnMontages_IsValid;

	private static int SpawnMontages_Offset;

	private static FFieldAddress SpawnMontages_PropertyAddress;

	private TArrayReadWriteMarshaler<UAnimMontage> SpawnMontages_Marshaler;

	private static bool bIsFacePlayer_IsValid;

	private static int bIsFacePlayer_Offset;

	private static FFieldAddress bIsFacePlayer_PropertyAddress;

	private static bool bIsCatchPlayer_IsValid;

	private static int bIsCatchPlayer_Offset;

	private static FFieldAddress bIsCatchPlayer_PropertyAddress;

	private static bool TamerMaster_IsValid;

	private static int TamerMaster_Offset;

	private static bool OlineConfig_IsValid;

	private static int OlineConfig_Offset;

	private static bool SpawnMaster_IsValid;

	private static int SpawnMaster_Offset;

	private static bool GeneratedActors_IsValid;

	private static int GeneratedActors_Offset;

	private static FFieldAddress GeneratedActors_PropertyAddress;

	private TArrayReadWriteMarshaler<AActor> GeneratedActors_Marshaler;

	private static bool RunEQSQuery_IsValid;

	private static IntPtr RunEQSQuery_FunctionAddress;

	private static int RunEQSQuery_ParamsSize;

	private static bool RecordSpawnPoints_IsValid;

	private static IntPtr RecordSpawnPoints_FunctionAddress;

	private static int RecordSpawnPoints_ParamsSize;

	private static bool ClearGenerateActors_IsValid;

	private static IntPtr ClearGenerateActors_FunctionAddress;

	private static int ClearGenerateActors_ParamsSize;

	private static bool PreviewRecordSpawnPoints_IsValid;

	private static IntPtr PreviewRecordSpawnPoints_FunctionAddress;

	private static int PreviewRecordSpawnPoints_ParamsSize;

	[EditAnywhere]
	[UProperty]
	[DisplayName("默认刷怪")]
	[Category("SpawnMultiPoint")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:bDefaultStartSpawn")]
	public bool bDefaultStartSpawn
	{
		get
		{
			CheckDestroyed();
			if (!bDefaultStartSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:bDefaultStartSpawn");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDefaultStartSpawn_Offset), 0, bDefaultStartSpawn_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDefaultStartSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:bDefaultStartSpawn");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDefaultStartSpawn_Offset), 0, bDefaultStartSpawn_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("SpawnMultiPoint")]
	[DisplayName("生成刷新点的EQS模板")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:GeneratePointsEQSTemplate")]
	public UEnvQuery GeneratePointsEQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!GeneratePointsEQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:GeneratePointsEQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, GeneratePointsEQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GeneratePointsEQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:GeneratePointsEQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, GeneratePointsEQSTemplate_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("SpawnMultiPoint")]
	[DisplayName("EQS模板参数")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:QueryConfig")]
	public TArrayReadWrite<FGSEnvNamedValue> QueryConfig
	{
		get
		{
			CheckDestroyed();
			if (!QueryConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:QueryConfig");
				return null;
			}
			if (QueryConfig_Marshaler == null)
			{
				QueryConfig_Marshaler = new TArrayReadWriteMarshaler<FGSEnvNamedValue>(1, QueryConfig_PropertyAddress, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.FromNative, CachedMarshalingDelegates<FGSEnvNamedValue, FGSEnvNamedValue>.ToNative);
			}
			return QueryConfig_Marshaler.FromNative(IntPtr.Add(base.Address, QueryConfig_Offset));
		}
	}

	[DisplayName("预览刷新点的Mesh")]
	[Category("SpawnMultiPoint")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:PreviewMesh")]
	public UStaticMesh PreviewMesh
	{
		get
		{
			CheckDestroyed();
			if (!PreviewMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:PreviewMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(base.Address, PreviewMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviewMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:PreviewMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(base.Address, PreviewMesh_Offset), value);
			}
		}
	}

	[DisplayName("刷新点Mesh的材质")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnMultiPoint")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:Material")]
	public UMaterialInterface Material
	{
		get
		{
			CheckDestroyed();
			if (!Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:Material");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, Material_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Material_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:Material");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, Material_Offset), value);
			}
		}
	}

	[DisplayName("刷新点Mesh的Color")]
	[Category("SpawnMultiPoint")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:DiffuseColor")]
	public FLinearColor DiffuseColor
	{
		get
		{
			CheckDestroyed();
			if (!DiffuseColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:DiffuseColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, DiffuseColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DiffuseColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:DiffuseColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, DiffuseColor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnMultiPoint")]
	[DisplayName("刷新点列表")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnPoints")]
	public TArrayReadWrite<FVector> SpawnPoints
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnPoints");
				return null;
			}
			if (SpawnPoints_Marshaler == null)
			{
				SpawnPoints_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, SpawnPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return SpawnPoints_Marshaler.FromNative(IntPtr.Add(base.Address, SpawnPoints_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnMultiPoint")]
	[DisplayName("刷新点朝向")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnPointsRot")]
	public TArrayReadWrite<FRotator> SpawnPointsRot
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPointsRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnPointsRot");
				return null;
			}
			if (SpawnPointsRot_Marshaler == null)
			{
				SpawnPointsRot_Marshaler = new TArrayReadWriteMarshaler<FRotator>(1, SpawnPointsRot_PropertyAddress, CachedMarshalingDelegates<FRotator, BlittableTypeMarshaler<FRotator>>.FromNative, CachedMarshalingDelegates<FRotator, BlittableTypeMarshaler<FRotator>>.ToNative);
			}
			return SpawnPointsRot_Marshaler.FromNative(IntPtr.Add(base.Address, SpawnPointsRot_Offset));
		}
	}

	[Category("SpawnMultiPoint")]
	[DisplayName("使用刷新点朝向")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:UseSpawnPointsRot")]
	public bool UseSpawnPointsRot
	{
		get
		{
			CheckDestroyed();
			if (!UseSpawnPointsRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:UseSpawnPointsRot");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSpawnPointsRot_Offset), 0, UseSpawnPointsRot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSpawnPointsRot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:UseSpawnPointsRot");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSpawnPointsRot_Offset), 0, UseSpawnPointsRot_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("数量上限")]
	[Category("SpawnMultiPoint")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnNum")]
	public int SpawnNum
	{
		get
		{
			CheckDestroyed();
			if (!SpawnNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpawnNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpawnNum_Offset), value);
			}
		}
	}

	[Category("SpawnMultiPoint")]
	[DisplayName("刷新阈值")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnThreshold")]
	public int ReSpawnThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ReSpawnThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnThreshold");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ReSpawnThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReSpawnThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnThreshold");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ReSpawnThreshold_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("不会连续生成在同一点")]
	[Tooltip("使用LRU的刷新逻辑")]
	[Category("SpawnMultiPoint")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:IsLRU")]
	public bool IsLRU
	{
		get
		{
			CheckDestroyed();
			if (!IsLRU_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:IsLRU");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsLRU_Offset), 0, IsLRU_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsLRU_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:IsLRU");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsLRU_Offset), 0, IsLRU_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("如果所有点都在玩家视角内，使用距离玩家最远的点")]
	[Category("SpawnMultiPoint")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("避免玩家视角内刷新")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:IsNotSpawnedInPlayerSight")]
	public bool IsNotSpawnedInPlayerSight
	{
		get
		{
			CheckDestroyed();
			if (!IsNotSpawnedInPlayerSight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:IsNotSpawnedInPlayerSight");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNotSpawnedInPlayerSight_Offset), 0, IsNotSpawnedInPlayerSight_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNotSpawnedInPlayerSight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:IsNotSpawnedInPlayerSight");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNotSpawnedInPlayerSight_Offset), 0, IsNotSpawnedInPlayerSight_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("保底数量")]
	[Category("SpawnMultiPoint")]
	[Tooltip("小于此数量时会即刻刷新生成单位，直到不在小于此数量")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:LowerLimitNum")]
	public int LowerLimitNum
	{
		get
		{
			CheckDestroyed();
			if (!LowerLimitNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:LowerLimitNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LowerLimitNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LowerLimitNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:LowerLimitNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LowerLimitNum_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("单次检测补充的数量")]
	[Category("SpawnMultiPoint")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnNum")]
	public int ReSpawnNum
	{
		get
		{
			CheckDestroyed();
			if (!ReSpawnNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ReSpawnNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReSpawnNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ReSpawnNum_Offset), value);
			}
		}
	}

	[DisplayName("补充检测的时间间隔")]
	[Category("SpawnMultiPoint")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnTestInterval")]
	public float ReSpawnTestInterval
	{
		get
		{
			CheckDestroyed();
			if (!ReSpawnTestInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnTestInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ReSpawnTestInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReSpawnTestInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:ReSpawnTestInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ReSpawnTestInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成的单位类型")]
	[Category("SpawnMultiPoint")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:Type")]
	public ESpawnType Type
	{
		get
		{
			CheckDestroyed();
			if (!Type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:Type");
				return ESpawnType.Weapon;
			}
			return EnumMarshaler<ESpawnType>.FromNative(IntPtr.Add(base.Address, Type_Offset), 0, Type_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:Type");
			}
			else
			{
				EnumMarshaler<ESpawnType>.ToNative(IntPtr.Add(base.Address, Type_Offset), 0, Type_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("生成单位需要打上的Tag")]
	[EditAnywhere]
	[Category("SpawnMultiPoint")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnedTag")]
	public FName SpawnedTag
	{
		get
		{
			CheckDestroyed();
			if (!SpawnedTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnedTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SpawnedTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnedTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnedTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SpawnedTag_Offset), value);
			}
		}
	}

	[Category("SpawnMultiPoint")]
	[EditAnywhere]
	[DisplayName("生成单位选取规则")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnRule")]
	public ESpawnRule SpawnRule
	{
		get
		{
			CheckDestroyed();
			if (!SpawnRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnRule");
				return ESpawnRule.Random;
			}
			return EnumMarshaler<ESpawnRule>.FromNative(IntPtr.Add(base.Address, SpawnRule_Offset), 0, SpawnRule_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnRule");
			}
			else
			{
				EnumMarshaler<ESpawnRule>.ToNative(IntPtr.Add(base.Address, SpawnRule_Offset), 0, SpawnRule_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("单位类")]
	[EditAnywhere]
	[Category("SpawnMultiPoint")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnActorList")]
	public TArrayReadWrite<TSubclassOf<AActor>> SpawnActorList
	{
		get
		{
			CheckDestroyed();
			if (!SpawnActorList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnActorList");
				return null;
			}
			if (SpawnActorList_Marshaler == null)
			{
				SpawnActorList_Marshaler = new TArrayReadWriteMarshaler<TSubclassOf<AActor>>(1, SpawnActorList_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<AActor>, TSubclassOfMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<AActor>, TSubclassOfMarshaler<AActor>>.ToNative);
			}
			return SpawnActorList_Marshaler.FromNative(IntPtr.Add(base.Address, SpawnActorList_Offset));
		}
	}

	[EditAnywhere]
	[Category("SpawnMultiPoint")]
	[DisplayName("单位胶囊体半高")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnHeight")]
	public float SpawnHeight
	{
		get
		{
			CheckDestroyed();
			if (!SpawnHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpawnHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpawnHeight_Offset), value);
			}
		}
	}

	[Category("SpawnMultiPoint")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("单位出生动画")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnMontages")]
	public TArrayReadWrite<UAnimMontage> SpawnMontages
	{
		get
		{
			CheckDestroyed();
			if (!SpawnMontages_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnMontages");
				return null;
			}
			if (SpawnMontages_Marshaler == null)
			{
				SpawnMontages_Marshaler = new TArrayReadWriteMarshaler<UAnimMontage>(1, SpawnMontages_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return SpawnMontages_Marshaler.FromNative(IntPtr.Add(base.Address, SpawnMontages_Offset));
		}
	}

	[DisplayName("单位出生时是否面向玩家")]
	[EditAnywhere]
	[Category("SpawnMultiPoint")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "Type==SpawnType::Character")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:bIsFacePlayer")]
	public bool bIsFacePlayer
	{
		get
		{
			CheckDestroyed();
			if (!bIsFacePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:bIsFacePlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsFacePlayer_Offset), 0, bIsFacePlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsFacePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:bIsFacePlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsFacePlayer_Offset), 0, bIsFacePlayer_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SpawnMultiPoint")]
	[UMeta(MDProp.EditCondition, "Type==SpawnType::Character")]
	[UProperty]
	[DisplayName("单位出生时是否设置玩家为目标")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:bIsCatchPlayer")]
	public bool bIsCatchPlayer
	{
		get
		{
			CheckDestroyed();
			if (!bIsCatchPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:bIsCatchPlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsCatchPlayer_Offset), 0, bIsCatchPlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsCatchPlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:bIsCatchPlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsCatchPlayer_Offset), 0, bIsCatchPlayer_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("单位Master")]
	[EditAnywhere]
	[Category("SpawnMultiPoint")]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "Type==SpawnType::Character")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:TamerMaster")]
	public TSoftObject<BUTamerActor> TamerMaster
	{
		get
		{
			CheckDestroyed();
			if (!TamerMaster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:TamerMaster");
				return default(TSoftObject<BUTamerActor>);
			}
			return TSoftObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(base.Address, TamerMaster_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TamerMaster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:TamerMaster");
			}
			else
			{
				TSoftObjectMarshaler<BUTamerActor>.ToNative(IntPtr.Add(base.Address, TamerMaster_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("SpawnMultiPoint")]
	[DisplayName("联机多人配置")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:OlineConfig")]
	public FOnlineSpawnConfig OlineConfig
	{
		get
		{
			CheckDestroyed();
			if (!OlineConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:OlineConfig");
				return default(FOnlineSpawnConfig);
			}
			return BlittableTypeMarshaler<FOnlineSpawnConfig>.FromNative(IntPtr.Add(base.Address, OlineConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OlineConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:OlineConfig");
			}
			else
			{
				BlittableTypeMarshaler<FOnlineSpawnConfig>.ToNative(IntPtr.Add(base.Address, OlineConfig_Offset), value);
			}
		}
	}

	[UMeta(MDFunc.AdvancedDisplay)]
	[UProperty]
	[VisibleAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnMaster")]
	public TSoftObject<BGUCharacterCS> SpawnMaster
	{
		get
		{
			CheckDestroyed();
			if (!SpawnMaster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnMaster");
				return default(TSoftObject<BGUCharacterCS>);
			}
			return TSoftObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(base.Address, SpawnMaster_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnMaster_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:SpawnMaster");
			}
			else
			{
				TSoftObjectMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(base.Address, SpawnMaster_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:GeneratedActors")]
	public TArrayReadWrite<AActor> GeneratedActors
	{
		get
		{
			CheckDestroyed();
			if (!GeneratedActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SpawnMultiPointComp:GeneratedActors");
				return null;
			}
			if (GeneratedActors_Marshaler == null)
			{
				GeneratedActors_Marshaler = new TArrayReadWriteMarshaler<AActor>(1, GeneratedActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return GeneratedActors_Marshaler.FromNative(IntPtr.Add(base.Address, GeneratedActors_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SpawnHeight = 100f;
	}

	public override void OnDataConvert(AActor Owner)
	{
		ClearGenerateActors();
		BUC_SpawnMultiPointData bUC_SpawnMultiPointData = RequireWritableData<BUC_SpawnMultiPointData>();
		bUC_SpawnMultiPointData.bDefaultStartSpawn = bDefaultStartSpawn;
		bUC_SpawnMultiPointData.SpawnPoints = SpawnPoints.ToArray();
		bUC_SpawnMultiPointData.SpawnPointsRot = SpawnPointsRot.ToArray();
		bUC_SpawnMultiPointData.UseSpawnPointsRot = UseSpawnPointsRot;
		bUC_SpawnMultiPointData.PointNum = SpawnPoints.Count;
		bUC_SpawnMultiPointData.SpawnMaxNum = SpawnNum;
		bUC_SpawnMultiPointData.ReSpawnThreshold = ReSpawnThreshold;
		bUC_SpawnMultiPointData.SpawnActorList = SpawnActorList.ToList();
		bUC_SpawnMultiPointData.SpawnHeight = SpawnHeight;
		bUC_SpawnMultiPointData.SpawnMaxNumAlone = SpawnNum;
		bUC_SpawnMultiPointData.SpawnMaxNumOnline = OlineConfig.SpawnNumOnline;
		bUC_SpawnMultiPointData.LowerLimitNumAlone = LowerLimitNum;
		bUC_SpawnMultiPointData.LowerLimitNumOnline = OlineConfig.LowerLimitNumOnline;
		bUC_SpawnMultiPointData.ReSpawnLimitAlone = ReSpawnNum;
		bUC_SpawnMultiPointData.ReSpawnLimitOnline = OlineConfig.ReSpawnNumOnline;
		for (int i = 0; i < SpawnActorList.Count; i++)
		{
			UAnimMontage spawnMontage = null;
			if (SpawnMontages.Count > i && SpawnMontages[i] != null)
			{
				spawnMontage = SpawnMontages[i];
			}
			FUnitSpawnInfo fUnitSpawnInfo = new FUnitSpawnInfo
			{
				SpawnMontage = spawnMontage,
				bFacePlayer = bIsFacePlayer,
				bCatchPlayer = bIsCatchPlayer
			};
			fUnitSpawnInfo.ActorTags.Add(SpawnedTag);
			if (TamerMaster.IsValid && !TamerMaster.IsNull)
			{
				fUnitSpawnInfo.SpawnMasterGuid = TamerMaster.Value.GetFinalGuid();
			}
			bUC_SpawnMultiPointData.UnitSpawnInfoList.Add(fUnitSpawnInfo);
		}
		bUC_SpawnMultiPointData.SpawnedTag = SpawnedTag;
		bUC_SpawnMultiPointData.ReSpawnLimit = ReSpawnNum;
		bUC_SpawnMultiPointData.ReSpawnTestInterval = ReSpawnTestInterval;
		bUC_SpawnMultiPointData.SpawnType = Type;
		bUC_SpawnMultiPointData.IsLRU = IsLRU;
		bUC_SpawnMultiPointData.IsNotSpawnedInPlayerSight = IsNotSpawnedInPlayerSight;
		bUC_SpawnMultiPointData.LowerLimitNum = LowerLimitNum;
		bUC_SpawnMultiPointData.SpawnRule = SpawnRule;
	}

	[UFunction]
	[UMeta(MDFunc.CallInEditor)]
	[BlueprintCallable]
	[Category("SpawnMultiPoint")]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:RunEQSQuery")]
	public void RunEQSQuery()
	{
		UBGUEQSObject uBGUEQSObject = UObject.NewObject<UBGUEQSObject>(GetOwner());
		if (GeneratedActors.Count > 0)
		{
			ClearGenerateActors();
		}
		List<FVector> Locations;
		List<float> Scores;
		if (QueryConfig.Count > 0)
		{
			uBGUEQSObject.EQSObjRunInstantWithCustomParams(GeneratePointsEQSTemplate, GetOwner(), QueryConfig.ToList(), out Locations, out Scores);
		}
		else
		{
			uBGUEQSObject.EQSObjRunInstant(GeneratePointsEQSTemplate, GetOwner(), out Locations, out Scores);
		}
		GeneratePreviewMesh(Locations);
	}

	private void GeneratePreviewMesh(List<FVector> Locations)
	{
		UWorld world = GetOwner().World;
		FVector4 value = new FVector4(DiffuseColor);
		foreach (FVector Location in Locations)
		{
			AStaticMeshActor aStaticMeshActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay<AStaticMeshActor>(world);
			aStaticMeshActor.StaticMeshComponent.SetStaticMesh(PreviewMesh);
			aStaticMeshActor.StaticMeshComponent.SetMaterial(0, Material);
			aStaticMeshActor.StaticMeshComponent.SetCustomPrimitiveDataVector4(0, value);
			aStaticMeshActor.SetActorEnableCollision(bNewActorEnableCollision: false);
			aStaticMeshActor.AttachToActor(GetOwner(), FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
			BGUFuncLibActorTransformCS.BGUSetActorLocation(aStaticMeshActor, Location, bSweep: false, bTeleport: false);
			GeneratedActors.Add(aStaticMeshActor);
		}
	}

	[BlueprintCallable]
	[Category("SpawnMultiPoint")]
	[UFunction]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:ClearGenerateActors")]
	public void ClearGenerateActors()
	{
		foreach (AActor generatedActor in GeneratedActors)
		{
			if (!(generatedActor == null))
			{
				generatedActor.DetachFromActor();
				BGU_UnrealWorldUtil.DestroyActor(generatedActor);
			}
		}
		GeneratedActors.Clear();
	}

	[Category("SpawnMultiPoint")]
	[BlueprintCallable]
	[UMeta(MDFunc.CallInEditor)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:PreviewRecordSpawnPoints")]
	public void PreviewRecordSpawnPoints()
	{
		GeneratePreviewMesh(SpawnPoints.ToList());
	}

	[UFunction]
	[BlueprintCallable]
	[Category("SpawnMultiPoint")]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.BUS_SpawnMultiPointComp:RecordSpawnPoints")]
	public void RecordSpawnPoints()
	{
		if (GeneratedActors.Count == 0)
		{
			return;
		}
		SpawnPoints.Clear();
		SpawnPointsRot.Clear();
		foreach (AActor generatedActor in GeneratedActors)
		{
			SpawnPoints.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(generatedActor));
			SpawnPointsRot.Add(BGUFuncLibActorTransformCS.BGUGetActorRotation(generatedActor));
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SpawnMultiPointComp:RunEQSQuery")]
	private static void RunEQSQuery__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SpawnMultiPointComp bUS_SpawnMultiPointComp = GCHelper.Find<BUS_SpawnMultiPointComp>(obj);
		bUS_SpawnMultiPointComp.RunEQSQuery();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SpawnMultiPointComp:RecordSpawnPoints")]
	private static void RecordSpawnPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SpawnMultiPointComp bUS_SpawnMultiPointComp = GCHelper.Find<BUS_SpawnMultiPointComp>(obj);
		bUS_SpawnMultiPointComp.RecordSpawnPoints();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SpawnMultiPointComp:ClearGenerateActors")]
	private static void ClearGenerateActors__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SpawnMultiPointComp bUS_SpawnMultiPointComp = GCHelper.Find<BUS_SpawnMultiPointComp>(obj);
		bUS_SpawnMultiPointComp.ClearGenerateActors();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SpawnMultiPointComp:PreviewRecordSpawnPoints")]
	private static void PreviewRecordSpawnPoints__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SpawnMultiPointComp bUS_SpawnMultiPointComp = GCHelper.Find<BUS_SpawnMultiPointComp>(obj);
		bUS_SpawnMultiPointComp.PreviewRecordSpawnPoints();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SpawnMultiPointComp");
		NativeReflection.GetPropertyRef(ref bDefaultStartSpawn_PropertyAddress, intPtr, "bDefaultStartSpawn");
		bDefaultStartSpawn_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDefaultStartSpawn");
		bDefaultStartSpawn_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDefaultStartSpawn", Classes.FBoolProperty);
		GeneratePointsEQSTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeneratePointsEQSTemplate");
		GeneratePointsEQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeneratePointsEQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref QueryConfig_PropertyAddress, intPtr, "QueryConfig");
		QueryConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "QueryConfig");
		QueryConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QueryConfig", Classes.FArrayProperty);
		PreviewMesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "PreviewMesh");
		PreviewMesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PreviewMesh", Classes.FObjectProperty);
		Material_Offset = NativeReflection.GetPropertyOffset(intPtr, "Material");
		Material_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Material", Classes.FObjectProperty);
		DiffuseColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "DiffuseColor");
		DiffuseColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DiffuseColor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SpawnPoints_PropertyAddress, intPtr, "SpawnPoints");
		SpawnPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPoints");
		SpawnPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPoints", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SpawnPointsRot_PropertyAddress, intPtr, "SpawnPointsRot");
		SpawnPointsRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPointsRot");
		SpawnPointsRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPointsRot", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UseSpawnPointsRot_PropertyAddress, intPtr, "UseSpawnPointsRot");
		UseSpawnPointsRot_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseSpawnPointsRot");
		UseSpawnPointsRot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseSpawnPointsRot", Classes.FBoolProperty);
		SpawnNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnNum");
		SpawnNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnNum", Classes.FIntProperty);
		ReSpawnThreshold_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReSpawnThreshold");
		ReSpawnThreshold_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReSpawnThreshold", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsLRU_PropertyAddress, intPtr, "IsLRU");
		IsLRU_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsLRU");
		IsLRU_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsLRU", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsNotSpawnedInPlayerSight_PropertyAddress, intPtr, "IsNotSpawnedInPlayerSight");
		IsNotSpawnedInPlayerSight_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsNotSpawnedInPlayerSight");
		IsNotSpawnedInPlayerSight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsNotSpawnedInPlayerSight", Classes.FBoolProperty);
		LowerLimitNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "LowerLimitNum");
		LowerLimitNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LowerLimitNum", Classes.FIntProperty);
		ReSpawnNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReSpawnNum");
		ReSpawnNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReSpawnNum", Classes.FIntProperty);
		ReSpawnTestInterval_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReSpawnTestInterval");
		ReSpawnTestInterval_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReSpawnTestInterval", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflection.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		SpawnedTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnedTag");
		SpawnedTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnedTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref SpawnRule_PropertyAddress, intPtr, "SpawnRule");
		SpawnRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnRule");
		SpawnRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnRule", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpawnActorList_PropertyAddress, intPtr, "SpawnActorList");
		SpawnActorList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnActorList");
		SpawnActorList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnActorList", Classes.FArrayProperty);
		SpawnHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnHeight");
		SpawnHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnHeight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpawnMontages_PropertyAddress, intPtr, "SpawnMontages");
		SpawnMontages_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnMontages");
		SpawnMontages_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnMontages", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bIsFacePlayer_PropertyAddress, intPtr, "bIsFacePlayer");
		bIsFacePlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsFacePlayer");
		bIsFacePlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsFacePlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bIsCatchPlayer_PropertyAddress, intPtr, "bIsCatchPlayer");
		bIsCatchPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsCatchPlayer");
		bIsCatchPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsCatchPlayer", Classes.FBoolProperty);
		TamerMaster_Offset = NativeReflection.GetPropertyOffset(intPtr, "TamerMaster");
		TamerMaster_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TamerMaster", Classes.FSoftObjectProperty);
		OlineConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "OlineConfig");
		OlineConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OlineConfig", Classes.FStructProperty);
		SpawnMaster_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnMaster");
		SpawnMaster_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnMaster", Classes.FSoftObjectProperty);
		NativeReflection.GetPropertyRef(ref GeneratedActors_PropertyAddress, intPtr, "GeneratedActors");
		GeneratedActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "GeneratedActors");
		GeneratedActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GeneratedActors", Classes.FArrayProperty);
		RunEQSQuery_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RunEQSQuery");
		RunEQSQuery_ParamsSize = NativeReflection.GetFunctionParamsSize(RunEQSQuery_FunctionAddress);
		RunEQSQuery_IsValid = RunEQSQuery_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SpawnMultiPointComp:RunEQSQuery", RunEQSQuery_IsValid);
		RecordSpawnPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RecordSpawnPoints");
		RecordSpawnPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordSpawnPoints_FunctionAddress);
		RecordSpawnPoints_IsValid = RecordSpawnPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SpawnMultiPointComp:RecordSpawnPoints", RecordSpawnPoints_IsValid);
		ClearGenerateActors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGenerateActors");
		ClearGenerateActors_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGenerateActors_FunctionAddress);
		ClearGenerateActors_IsValid = ClearGenerateActors_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SpawnMultiPointComp:ClearGenerateActors", ClearGenerateActors_IsValid);
		PreviewRecordSpawnPoints_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PreviewRecordSpawnPoints");
		PreviewRecordSpawnPoints_ParamsSize = NativeReflection.GetFunctionParamsSize(PreviewRecordSpawnPoints_FunctionAddress);
		PreviewRecordSpawnPoints_IsValid = PreviewRecordSpawnPoints_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SpawnMultiPointComp:PreviewRecordSpawnPoints", PreviewRecordSpawnPoints_IsValid);
	}

	static BUS_SpawnMultiPointComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SpawnMultiPointComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SpawnMultiPointComp));
	}
}
