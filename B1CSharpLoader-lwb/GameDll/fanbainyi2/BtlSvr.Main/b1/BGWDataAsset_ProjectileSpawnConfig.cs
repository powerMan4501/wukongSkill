using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig")]
public class BGWDataAsset_ProjectileSpawnConfig : UBGWDataAsset
{
	private static bool SpawnerType_IsValid;

	private static int SpawnerType_Offset;

	private static FFieldAddress SpawnerType_PropertyAddress;

	private static bool bNeedHandleStopReq_IsValid;

	private static int bNeedHandleStopReq_Offset;

	private static FFieldAddress bNeedHandleStopReq_PropertyAddress;

	private static bool BuffIDList_IsValid;

	private static int BuffIDList_Offset;

	private static FFieldAddress BuffIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BuffIDList_Marshaler;

	private static bool ProjectileID_IsValid;

	private static int ProjectileID_Offset;

	private static bool ProjectileWave_IsValid;

	private static int ProjectileWave_Offset;

	private static bool ProjectileNumInOneWave_IsValid;

	private static int ProjectileNumInOneWave_Offset;

	private static bool SpawnBase_IsValid;

	private static int SpawnBase_Offset;

	private static bool SpawnPosOffsetInfo_IsValid;

	private static int SpawnPosOffsetInfo_Offset;

	private static bool AttachToSpawnBase_IsValid;

	private static int AttachToSpawnBase_Offset;

	private static FFieldAddress AttachToSpawnBase_PropertyAddress;

	private static bool AttachRule_Rot_IsValid;

	private static int AttachRule_Rot_Offset;

	private static FFieldAddress AttachRule_Rot_PropertyAddress;

	private static bool TargetBase_IsValid;

	private static int TargetBase_Offset;

	private static bool TargetPosOffsetInfo_IsValid;

	private static int TargetPosOffsetInfo_Offset;

	private static bool BornDirBaseInfo_IsValid;

	private static int BornDirBaseInfo_Offset;

	private static bool BornDirOffset_IsValid;

	private static int BornDirOffset_Offset;

	private static bool BulletFlySpd_IsValid;

	private static int BulletFlySpd_Offset;

	private static bool BulletRotSpd_IsValid;

	private static int BulletRotSpd_Offset;

	private static bool bEnableMultiTargetMode_IsValid;

	private static int bEnableMultiTargetMode_Offset;

	private static FFieldAddress bEnableMultiTargetMode_PropertyAddress;

	private static bool MutilTargetRule_IsValid;

	private static int MutilTargetRule_Offset;

	private static bool bEnableSpawnBase_NoneTarget_IsValid;

	private static int bEnableSpawnBase_NoneTarget_Offset;

	private static FFieldAddress bEnableSpawnBase_NoneTarget_PropertyAddress;

	private static bool SpawnBase_NoneTarget_IsValid;

	private static int SpawnBase_NoneTarget_Offset;

	private static bool SpawnPosOffsetInfo_NoneTarget_IsValid;

	private static int SpawnPosOffsetInfo_NoneTarget_Offset;

	private static bool bEnableTargetBase_NoneTarget_IsValid;

	private static int bEnableTargetBase_NoneTarget_Offset;

	private static FFieldAddress bEnableTargetBase_NoneTarget_PropertyAddress;

	private static bool TargetBase_NoneTarget_IsValid;

	private static int TargetBase_NoneTarget_Offset;

	private static bool TargetPosOffsetInfo_NoneTarget_IsValid;

	private static int TargetPosOffsetInfo_NoneTarget_Offset;

	private static bool AboutEffectCaster_IsValid;

	private static IntPtr AboutEffectCaster_FunctionAddress;

	private static int AboutEffectCaster_ParamsSize;

	private static bool AboutEffectCaster_ReturnValue_IsValid;

	private static int AboutEffectCaster_ReturnValue_Offset;

	private static FFieldAddress AboutEffectCaster_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Tooltip("即为子弹的Master")]
	[BlueprintReadWrite]
	[Category("额外")]
	[DisplayName("子弹生成者类型")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnerType")]
	public EProjectileSpawnerType SpawnerType
	{
		get
		{
			CheckDestroyed();
			if (!SpawnerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnerType");
				return EProjectileSpawnerType.EffectCaster;
			}
			return EnumMarshaler<EProjectileSpawnerType>.FromNative(IntPtr.Add(base.Address, SpawnerType_Offset), 0, SpawnerType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnerType");
			}
			else
			{
				EnumMarshaler<EProjectileSpawnerType>.ToNative(IntPtr.Add(base.Address, SpawnerType_Offset), 0, SpawnerType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SpawnProjectile")]
	[DisplayName("效果打断时中断生成")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("目前只有Buff有用")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bNeedHandleStopReq")]
	public bool bNeedHandleStopReq
	{
		get
		{
			CheckDestroyed();
			if (!bNeedHandleStopReq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bNeedHandleStopReq");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNeedHandleStopReq_Offset), 0, bNeedHandleStopReq_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNeedHandleStopReq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bNeedHandleStopReq");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNeedHandleStopReq_Offset), 0, bNeedHandleStopReq_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BuffIDList")]
	public TArrayReadWrite<int> BuffIDList
	{
		get
		{
			CheckDestroyed();
			if (!BuffIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BuffIDList");
				return null;
			}
			if (BuffIDList_Marshaler == null)
			{
				BuffIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, BuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BuffIDList_Marshaler.FromNative(IntPtr.Add(base.Address, BuffIDList_Offset));
		}
	}

	[EditAnywhere]
	[Category("SpawnProjectile")]
	[BlueprintReadWrite]
	[DisplayName("ProjectileID")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileID")]
	public int ProjectileID
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ProjectileID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ProjectileID_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("ProjectileWave")]
	[Category("SpawnProjectile")]
	[Tooltip("暂时没有波数的配置，后续再考虑要不要加")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileWave")]
	public int ProjectileWave
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileWave");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ProjectileWave_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileWave");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ProjectileWave_Offset), value);
			}
		}
	}

	[Category("SpawnProjectile")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("ProjectileNumInOneWave")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileNumInOneWave")]
	public int ProjectileNumInOneWave
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileNumInOneWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileNumInOneWave");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ProjectileNumInOneWave_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileNumInOneWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:ProjectileNumInOneWave");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ProjectileNumInOneWave_Offset), value);
			}
		}
	}

	[DisplayName("生成基准")]
	[Category("SpawnProjectile")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnBase")]
	public ProjectileBaseStruct SpawnBase
	{
		get
		{
			CheckDestroyed();
			if (!SpawnBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnBase");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, SpawnBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnBase");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, SpawnBase_Offset), value);
			}
		}
	}

	[Tooltip("目前仅供NormalSpawn类型子弹使用")]
	[DisplayName("生成偏移")]
	[Category("SpawnProjectile")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnPosOffsetInfo")]
	public ProjectilePosOffsetStruct SpawnPosOffsetInfo
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnPosOffsetInfo");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, SpawnPosOffsetInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnPosOffsetInfo");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, SpawnPosOffsetInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[DisplayName("Attach在生成基准上")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AttachToSpawnBase")]
	public bool AttachToSpawnBase
	{
		get
		{
			CheckDestroyed();
			if (!AttachToSpawnBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AttachToSpawnBase");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AttachToSpawnBase_Offset), 0, AttachToSpawnBase_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachToSpawnBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AttachToSpawnBase");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AttachToSpawnBase_Offset), 0, AttachToSpawnBase_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("SpawnProjectile")]
	[DisplayName("Rotation_AttachmentRule")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AttachRule_Rot")]
	public EAttachmentRule AttachRule_Rot
	{
		get
		{
			CheckDestroyed();
			if (!AttachRule_Rot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AttachRule_Rot");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachRule_Rot_Offset), 0, AttachRule_Rot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachRule_Rot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AttachRule_Rot");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachRule_Rot_Offset), 0, AttachRule_Rot_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("目标基准")]
	[Category("SpawnProjectile")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetBase")]
	public ProjectileBaseStruct TargetBase
	{
		get
		{
			CheckDestroyed();
			if (!TargetBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetBase");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, TargetBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetBase");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, TargetBase_Offset), value);
			}
		}
	}

	[Category("SpawnProjectile")]
	[DisplayName("目标偏移")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetPosOffsetInfo")]
	public ProjectilePosOffsetStruct TargetPosOffsetInfo
	{
		get
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetPosOffsetInfo");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetPosOffsetInfo");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[DisplayName("生成朝向")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BornDirBaseInfo")]
	public ProjectileBornDirStruct BornDirBaseInfo
	{
		get
		{
			CheckDestroyed();
			if (!BornDirBaseInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BornDirBaseInfo");
				return default(ProjectileBornDirStruct);
			}
			return ProjectileBornDirStruct.FromNative(IntPtr.Add(base.Address, BornDirBaseInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornDirBaseInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BornDirBaseInfo");
			}
			else
			{
				ProjectileBornDirStruct.ToNative(IntPtr.Add(base.Address, BornDirBaseInfo_Offset), value);
			}
		}
	}

	[DisplayName("生成朝向偏移")]
	[Category("SpawnProjectile")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BornDirOffset")]
	public ProjectileBornDirOffsetStruct BornDirOffset
	{
		get
		{
			CheckDestroyed();
			if (!BornDirOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BornDirOffset");
				return default(ProjectileBornDirOffsetStruct);
			}
			return ProjectileBornDirOffsetStruct.FromNative(IntPtr.Add(base.Address, BornDirOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornDirOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BornDirOffset");
			}
			else
			{
				ProjectileBornDirOffsetStruct.ToNative(IntPtr.Add(base.Address, BornDirOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BulletFlySpd")]
	public FSpawnBulletSpeed BulletFlySpd
	{
		get
		{
			CheckDestroyed();
			if (!BulletFlySpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BulletFlySpd");
				return default(FSpawnBulletSpeed);
			}
			return FSpawnBulletSpeed.FromNative(IntPtr.Add(base.Address, BulletFlySpd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletFlySpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BulletFlySpd");
			}
			else
			{
				FSpawnBulletSpeed.ToNative(IntPtr.Add(base.Address, BulletFlySpd_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("SpawnProjectile")]
	[Tooltip("追踪模式下用")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BulletRotSpd")]
	public FSpawnBulletSpeed BulletRotSpd
	{
		get
		{
			CheckDestroyed();
			if (!BulletRotSpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BulletRotSpd");
				return default(FSpawnBulletSpeed);
			}
			return FSpawnBulletSpeed.FromNative(IntPtr.Add(base.Address, BulletRotSpd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletRotSpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:BulletRotSpd");
			}
			else
			{
				FSpawnBulletSpeed.ToNative(IntPtr.Add(base.Address, BulletRotSpd_Offset), value);
			}
		}
	}

	[Category("SpawnProjectile|多目标模式")]
	[DisplayName("使用多目标模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableMultiTargetMode")]
	public bool bEnableMultiTargetMode
	{
		get
		{
			CheckDestroyed();
			if (!bEnableMultiTargetMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableMultiTargetMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableMultiTargetMode_Offset), 0, bEnableMultiTargetMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableMultiTargetMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableMultiTargetMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableMultiTargetMode_Offset), 0, bEnableMultiTargetMode_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("多目标筛选规则")]
	[Category("SpawnProjectile|多目标模式")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "bEnableMultiTargetMode")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:MutilTargetRule")]
	public FProjectileMulTargetRule MutilTargetRule
	{
		get
		{
			CheckDestroyed();
			if (!MutilTargetRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:MutilTargetRule");
				return default(FProjectileMulTargetRule);
			}
			return BlittableTypeMarshaler<FProjectileMulTargetRule>.FromNative(IntPtr.Add(base.Address, MutilTargetRule_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MutilTargetRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:MutilTargetRule");
			}
			else
			{
				BlittableTypeMarshaler<FProjectileMulTargetRule>.ToNative(IntPtr.Add(base.Address, MutilTargetRule_Offset), value);
			}
		}
	}

	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("启用生成基准缺省保底")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableSpawnBase_NoneTarget")]
	public bool bEnableSpawnBase_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!bEnableSpawnBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableSpawnBase_NoneTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableSpawnBase_NoneTarget_Offset), 0, bEnableSpawnBase_NoneTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableSpawnBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableSpawnBase_NoneTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableSpawnBase_NoneTarget_Offset), 0, bEnableSpawnBase_NoneTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[DisplayName("生成基准_缺省")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnBase_NoneTarget")]
	public ProjectileBaseStruct SpawnBase_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!SpawnBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnBase_NoneTarget");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, SpawnBase_NoneTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnBase_NoneTarget");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, SpawnBase_NoneTarget_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[DisplayName("生成偏移_缺省")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnPosOffsetInfo_NoneTarget")]
	public ProjectilePosOffsetStruct SpawnPosOffsetInfo_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPosOffsetInfo_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnPosOffsetInfo_NoneTarget");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, SpawnPosOffsetInfo_NoneTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPosOffsetInfo_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:SpawnPosOffsetInfo_NoneTarget");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, SpawnPosOffsetInfo_NoneTarget_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[EditAnywhere]
	[DisplayName("启用目标基准缺省保底")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableTargetBase_NoneTarget")]
	public bool bEnableTargetBase_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!bEnableTargetBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableTargetBase_NoneTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableTargetBase_NoneTarget_Offset), 0, bEnableTargetBase_NoneTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableTargetBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:bEnableTargetBase_NoneTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableTargetBase_NoneTarget_Offset), 0, bEnableTargetBase_NoneTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("目标基准_缺省")]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetBase_NoneTarget")]
	public ProjectileBaseStruct TargetBase_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!TargetBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetBase_NoneTarget");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, TargetBase_NoneTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetBase_NoneTarget");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, TargetBase_NoneTarget_Offset), value);
			}
		}
	}

	[DisplayName("目标偏移_缺省")]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetPosOffsetInfo_NoneTarget")]
	public ProjectilePosOffsetStruct TargetPosOffsetInfo_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetPosOffsetInfo_NoneTarget");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_NoneTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:TargetPosOffsetInfo_NoneTarget");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_NoneTarget_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		AttachRule_Rot = EAttachmentRule.SnapToTarget;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AboutEffectCaster")]
	public bool AboutEffectCaster()
	{
		if (SpawnBase.BaseType == ProjectileBaseType.EffectCaster || TargetBase.BaseType == ProjectileBaseType.EffectCaster)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AboutEffectCaster")]
	private static void AboutEffectCaster__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGWDataAsset_ProjectileSpawnConfig bGWDataAsset_ProjectileSpawnConfig = GCHelper.Find<BGWDataAsset_ProjectileSpawnConfig>(obj);
		bool value = bGWDataAsset_ProjectileSpawnConfig.AboutEffectCaster();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, AboutEffectCaster_ReturnValue_Offset), 0, AboutEffectCaster_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig");
		NativeReflection.GetPropertyRef(ref SpawnerType_PropertyAddress, intPtr, "SpawnerType");
		SpawnerType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnerType");
		SpawnerType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnerType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bNeedHandleStopReq_PropertyAddress, intPtr, "bNeedHandleStopReq");
		bNeedHandleStopReq_Offset = NativeReflection.GetPropertyOffset(intPtr, "bNeedHandleStopReq");
		bNeedHandleStopReq_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bNeedHandleStopReq", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BuffIDList_PropertyAddress, intPtr, "BuffIDList");
		BuffIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffIDList");
		BuffIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffIDList", Classes.FArrayProperty);
		ProjectileID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileID");
		ProjectileID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileID", Classes.FIntProperty);
		ProjectileWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileWave");
		ProjectileWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileWave", Classes.FIntProperty);
		ProjectileNumInOneWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileNumInOneWave");
		ProjectileNumInOneWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileNumInOneWave", Classes.FIntProperty);
		SpawnBase_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnBase");
		SpawnBase_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnBase", Classes.FStructProperty);
		SpawnPosOffsetInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPosOffsetInfo");
		SpawnPosOffsetInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPosOffsetInfo", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref AttachToSpawnBase_PropertyAddress, intPtr, "AttachToSpawnBase");
		AttachToSpawnBase_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachToSpawnBase");
		AttachToSpawnBase_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachToSpawnBase", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AttachRule_Rot_PropertyAddress, intPtr, "AttachRule_Rot");
		AttachRule_Rot_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachRule_Rot");
		AttachRule_Rot_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachRule_Rot", Classes.FEnumProperty);
		TargetBase_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetBase");
		TargetBase_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetBase", Classes.FStructProperty);
		TargetPosOffsetInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetPosOffsetInfo");
		TargetPosOffsetInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetPosOffsetInfo", Classes.FStructProperty);
		BornDirBaseInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirBaseInfo");
		BornDirBaseInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirBaseInfo", Classes.FStructProperty);
		BornDirOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "BornDirOffset");
		BornDirOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BornDirOffset", Classes.FStructProperty);
		BulletFlySpd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BulletFlySpd");
		BulletFlySpd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BulletFlySpd", Classes.FStructProperty);
		BulletRotSpd_Offset = NativeReflection.GetPropertyOffset(intPtr, "BulletRotSpd");
		BulletRotSpd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BulletRotSpd", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bEnableMultiTargetMode_PropertyAddress, intPtr, "bEnableMultiTargetMode");
		bEnableMultiTargetMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableMultiTargetMode");
		bEnableMultiTargetMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableMultiTargetMode", Classes.FBoolProperty);
		MutilTargetRule_Offset = NativeReflection.GetPropertyOffset(intPtr, "MutilTargetRule");
		MutilTargetRule_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MutilTargetRule", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bEnableSpawnBase_NoneTarget_PropertyAddress, intPtr, "bEnableSpawnBase_NoneTarget");
		bEnableSpawnBase_NoneTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableSpawnBase_NoneTarget");
		bEnableSpawnBase_NoneTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableSpawnBase_NoneTarget", Classes.FBoolProperty);
		SpawnBase_NoneTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnBase_NoneTarget");
		SpawnBase_NoneTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnBase_NoneTarget", Classes.FStructProperty);
		SpawnPosOffsetInfo_NoneTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPosOffsetInfo_NoneTarget");
		SpawnPosOffsetInfo_NoneTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPosOffsetInfo_NoneTarget", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bEnableTargetBase_NoneTarget_PropertyAddress, intPtr, "bEnableTargetBase_NoneTarget");
		bEnableTargetBase_NoneTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableTargetBase_NoneTarget");
		bEnableTargetBase_NoneTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableTargetBase_NoneTarget", Classes.FBoolProperty);
		TargetBase_NoneTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetBase_NoneTarget");
		TargetBase_NoneTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetBase_NoneTarget", Classes.FStructProperty);
		TargetPosOffsetInfo_NoneTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetPosOffsetInfo_NoneTarget");
		TargetPosOffsetInfo_NoneTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetPosOffsetInfo_NoneTarget", Classes.FStructProperty);
		AboutEffectCaster_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AboutEffectCaster");
		AboutEffectCaster_ParamsSize = NativeReflection.GetFunctionParamsSize(AboutEffectCaster_FunctionAddress);
		NativeReflection.GetPropertyRef(ref AboutEffectCaster_ReturnValue_PropertyAddress, AboutEffectCaster_FunctionAddress, "ReturnValue");
		AboutEffectCaster_ReturnValue_Offset = NativeReflection.GetPropertyOffset(AboutEffectCaster_FunctionAddress, "ReturnValue");
		AboutEffectCaster_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(AboutEffectCaster_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AboutEffectCaster_IsValid = AboutEffectCaster_FunctionAddress != IntPtr.Zero && AboutEffectCaster_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGWDataAsset_ProjectileSpawnConfig:AboutEffectCaster", AboutEffectCaster_IsValid);
	}

	static BGWDataAsset_ProjectileSpawnConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_ProjectileSpawnConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_ProjectileSpawnConfig));
	}
}
