using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Spawn Projectiles")]
[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets")]
public class BANS_GSSpawnBullets : BANS_GSBase
{
	private static bool bNeedHandleStopReq_IsValid;

	private static int bNeedHandleStopReq_Offset;

	private static FFieldAddress bNeedHandleStopReq_PropertyAddress;

	private static bool bNeedDestorySpawnedBullet_IsValid;

	private static int bNeedDestorySpawnedBullet_Offset;

	private static FFieldAddress bNeedDestorySpawnedBullet_PropertyAddress;

	private static bool BuffIDList_IsValid;

	private static int BuffIDList_Offset;

	private static FFieldAddress BuffIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BuffIDList_Marshaler;

	private static bool BulletID_IsValid;

	private static int BulletID_Offset;

	private static bool BulletWave_IsValid;

	private static int BulletWave_Offset;

	private static bool WaveIntervalNoise_IsValid;

	private static int WaveIntervalNoise_Offset;

	private static bool BulletNumInOneWave_IsValid;

	private static int BulletNumInOneWave_Offset;

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

	private static bool MarkDirty_IsValid;

	private static IntPtr MarkDirty_FunctionAddress;

	private static int MarkDirty_ParamsSize;

	private static bool MarkDirty_ReturnValue_IsValid;

	private static int MarkDirty_ReturnValue_Offset;

	private static FFieldAddress MarkDirty_ReturnValue_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_InActor_IsValid;

	private static int GSValidateInputCS_InActor_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[DisplayName("Notify打断时中断生成")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:bNeedHandleStopReq")]
	public bool bNeedHandleStopReq
	{
		get
		{
			CheckDestroyed();
			if (!bNeedHandleStopReq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bNeedHandleStopReq");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNeedHandleStopReq_Offset), 0, bNeedHandleStopReq_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNeedHandleStopReq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bNeedHandleStopReq");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNeedHandleStopReq_Offset), 0, bNeedHandleStopReq_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("Notify打断时销毁生成出的子弹（激光子弹用）")]
	[Category("SpawnProjectile")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:bNeedDestorySpawnedBullet")]
	public bool bNeedDestorySpawnedBullet
	{
		get
		{
			CheckDestroyed();
			if (!bNeedDestorySpawnedBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bNeedDestorySpawnedBullet");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNeedDestorySpawnedBullet_Offset), 0, bNeedDestorySpawnedBullet_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNeedDestorySpawnedBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bNeedDestorySpawnedBullet");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNeedDestorySpawnedBullet_Offset), 0, bNeedDestorySpawnedBullet_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:BuffIDList")]
	public TArrayReadWrite<int> BuffIDList
	{
		get
		{
			CheckDestroyed();
			if (!BuffIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BuffIDList");
				return null;
			}
			if (BuffIDList_Marshaler == null)
			{
				BuffIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, BuffIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BuffIDList_Marshaler.FromNative(IntPtr.Add(base.Address, BuffIDList_Offset));
		}
	}

	[DisplayName("ProjectileID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("SpawnProjectile")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:BulletID")]
	public int BulletID
	{
		get
		{
			CheckDestroyed();
			if (!BulletID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BulletID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BulletID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[DisplayName("波数")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:BulletWave")]
	public int BulletWave
	{
		get
		{
			CheckDestroyed();
			if (!BulletWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletWave");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BulletWave_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletWave");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BulletWave_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[DisplayName("波数间隔扰动")]
	[Tooltip("0为不扰动，即每波间隔一致")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:WaveIntervalNoise")]
	public float WaveIntervalNoise
	{
		get
		{
			CheckDestroyed();
			if (!WaveIntervalNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:WaveIntervalNoise");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WaveIntervalNoise_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WaveIntervalNoise_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:WaveIntervalNoise");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WaveIntervalNoise_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[DisplayName("每波数量")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:BulletNumInOneWave")]
	public int BulletNumInOneWave
	{
		get
		{
			CheckDestroyed();
			if (!BulletNumInOneWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletNumInOneWave");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BulletNumInOneWave_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletNumInOneWave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletNumInOneWave");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BulletNumInOneWave_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[DisplayName("生成基准")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnBase")]
	public ProjectileBaseStruct SpawnBase
	{
		get
		{
			CheckDestroyed();
			if (!SpawnBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnBase");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, SpawnBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnBase");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, SpawnBase_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("SpawnProjectile")]
	[DisplayName("生成偏移")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnPosOffsetInfo")]
	public ProjectilePosOffsetStruct SpawnPosOffsetInfo
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnPosOffsetInfo");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, SpawnPosOffsetInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnPosOffsetInfo");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, SpawnPosOffsetInfo_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile|Attach")]
	[DisplayName("Attach在生成基准上")]
	[Tooltip("目前仅供NormalSpawn类型子弹使用")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:AttachToSpawnBase")]
	public bool AttachToSpawnBase
	{
		get
		{
			CheckDestroyed();
			if (!AttachToSpawnBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:AttachToSpawnBase");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AttachToSpawnBase_Offset), 0, AttachToSpawnBase_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachToSpawnBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:AttachToSpawnBase");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AttachToSpawnBase_Offset), 0, AttachToSpawnBase_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SpawnProjectile|Attach")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Rotation_AttachmentRule")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:AttachRule_Rot")]
	public EAttachmentRule AttachRule_Rot
	{
		get
		{
			CheckDestroyed();
			if (!AttachRule_Rot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:AttachRule_Rot");
				return EAttachmentRule.KeepRelative;
			}
			return EnumMarshaler<EAttachmentRule>.FromNative(IntPtr.Add(base.Address, AttachRule_Rot_Offset), 0, AttachRule_Rot_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AttachRule_Rot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:AttachRule_Rot");
			}
			else
			{
				EnumMarshaler<EAttachmentRule>.ToNative(IntPtr.Add(base.Address, AttachRule_Rot_Offset), 0, AttachRule_Rot_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[DisplayName("目标基准")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:TargetBase")]
	public ProjectileBaseStruct TargetBase
	{
		get
		{
			CheckDestroyed();
			if (!TargetBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:TargetBase");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, TargetBase_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetBase_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:TargetBase");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, TargetBase_Offset), value);
			}
		}
	}

	[DisplayName("目标偏移")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SpawnProjectile")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:TargetPosOffsetInfo")]
	public ProjectilePosOffsetStruct TargetPosOffsetInfo
	{
		get
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:TargetPosOffsetInfo");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:TargetPosOffsetInfo");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_Offset), value);
			}
		}
	}

	[DisplayName("生成朝向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("SpawnProjectile")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:BornDirBaseInfo")]
	public ProjectileBornDirStruct BornDirBaseInfo
	{
		get
		{
			CheckDestroyed();
			if (!BornDirBaseInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BornDirBaseInfo");
				return default(ProjectileBornDirStruct);
			}
			return ProjectileBornDirStruct.FromNative(IntPtr.Add(base.Address, BornDirBaseInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornDirBaseInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BornDirBaseInfo");
			}
			else
			{
				ProjectileBornDirStruct.ToNative(IntPtr.Add(base.Address, BornDirBaseInfo_Offset), value);
			}
		}
	}

	[DisplayName("生成朝向偏移")]
	[Category("SpawnProjectile")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:BornDirOffset")]
	public ProjectileBornDirOffsetStruct BornDirOffset
	{
		get
		{
			CheckDestroyed();
			if (!BornDirOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BornDirOffset");
				return default(ProjectileBornDirOffsetStruct);
			}
			return ProjectileBornDirOffsetStruct.FromNative(IntPtr.Add(base.Address, BornDirOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornDirOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BornDirOffset");
			}
			else
			{
				ProjectileBornDirOffsetStruct.ToNative(IntPtr.Add(base.Address, BornDirOffset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("SpawnProjectile")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:BulletFlySpd")]
	public FSpawnBulletSpeed BulletFlySpd
	{
		get
		{
			CheckDestroyed();
			if (!BulletFlySpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletFlySpd");
				return default(FSpawnBulletSpeed);
			}
			return FSpawnBulletSpeed.FromNative(IntPtr.Add(base.Address, BulletFlySpd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletFlySpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletFlySpd");
			}
			else
			{
				FSpawnBulletSpeed.ToNative(IntPtr.Add(base.Address, BulletFlySpd_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("追踪模式下用")]
	[Category("SpawnProjectile")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:BulletRotSpd")]
	public FSpawnBulletSpeed BulletRotSpd
	{
		get
		{
			CheckDestroyed();
			if (!BulletRotSpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletRotSpd");
				return default(FSpawnBulletSpeed);
			}
			return FSpawnBulletSpeed.FromNative(IntPtr.Add(base.Address, BulletRotSpd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletRotSpd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:BulletRotSpd");
			}
			else
			{
				FSpawnBulletSpeed.ToNative(IntPtr.Add(base.Address, BulletRotSpd_Offset), value);
			}
		}
	}

	[DisplayName("使用多目标模式")]
	[Category("SpawnProjectile|多目标模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableMultiTargetMode")]
	public bool bEnableMultiTargetMode
	{
		get
		{
			CheckDestroyed();
			if (!bEnableMultiTargetMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableMultiTargetMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableMultiTargetMode_Offset), 0, bEnableMultiTargetMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableMultiTargetMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableMultiTargetMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableMultiTargetMode_Offset), 0, bEnableMultiTargetMode_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SpawnProjectile|多目标模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("多目标筛选规则")]
	[UMeta(MDProp.EditCondition, "bEnableMultiTargetMode")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:MutilTargetRule")]
	public FProjectileMulTargetRule MutilTargetRule
	{
		get
		{
			CheckDestroyed();
			if (!MutilTargetRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:MutilTargetRule");
				return default(FProjectileMulTargetRule);
			}
			return BlittableTypeMarshaler<FProjectileMulTargetRule>.FromNative(IntPtr.Add(base.Address, MutilTargetRule_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MutilTargetRule_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:MutilTargetRule");
			}
			else
			{
				BlittableTypeMarshaler<FProjectileMulTargetRule>.ToNative(IntPtr.Add(base.Address, MutilTargetRule_Offset), value);
			}
		}
	}

	[DisplayName("启用生成基准缺省保底")]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableSpawnBase_NoneTarget")]
	public bool bEnableSpawnBase_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!bEnableSpawnBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableSpawnBase_NoneTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableSpawnBase_NoneTarget_Offset), 0, bEnableSpawnBase_NoneTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableSpawnBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableSpawnBase_NoneTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableSpawnBase_NoneTarget_Offset), 0, bEnableSpawnBase_NoneTarget_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("生成基准_缺省")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnBase_NoneTarget")]
	public ProjectileBaseStruct SpawnBase_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!SpawnBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnBase_NoneTarget");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, SpawnBase_NoneTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnBase_NoneTarget");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, SpawnBase_NoneTarget_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[DisplayName("生成偏移_缺省")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnPosOffsetInfo_NoneTarget")]
	public ProjectilePosOffsetStruct SpawnPosOffsetInfo_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPosOffsetInfo_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnPosOffsetInfo_NoneTarget");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, SpawnPosOffsetInfo_NoneTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPosOffsetInfo_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:SpawnPosOffsetInfo_NoneTarget");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, SpawnPosOffsetInfo_NoneTarget_Offset), value);
			}
		}
	}

	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("启用目标基准缺省保底")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableTargetBase_NoneTarget")]
	public bool bEnableTargetBase_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!bEnableTargetBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableTargetBase_NoneTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableTargetBase_NoneTarget_Offset), 0, bEnableTargetBase_NoneTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableTargetBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:bEnableTargetBase_NoneTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableTargetBase_NoneTarget_Offset), 0, bEnableTargetBase_NoneTarget_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("目标基准_缺省")]
	[BlueprintReadWrite]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:TargetBase_NoneTarget")]
	public ProjectileBaseStruct TargetBase_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!TargetBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:TargetBase_NoneTarget");
				return default(ProjectileBaseStruct);
			}
			return ProjectileBaseStruct.FromNative(IntPtr.Add(base.Address, TargetBase_NoneTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetBase_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:TargetBase_NoneTarget");
			}
			else
			{
				ProjectileBaseStruct.ToNative(IntPtr.Add(base.Address, TargetBase_NoneTarget_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("目标偏移_缺省")]
	[BlueprintReadWrite]
	[Category("SpawnProjectile|无目标时启用缺省配置")]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:TargetPosOffsetInfo_NoneTarget")]
	public ProjectilePosOffsetStruct TargetPosOffsetInfo_NoneTarget
	{
		get
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:TargetPosOffsetInfo_NoneTarget");
				return default(ProjectilePosOffsetStruct);
			}
			return ProjectilePosOffsetStruct.FromNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_NoneTarget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetPosOffsetInfo_NoneTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSpawnBullets:TargetPosOffsetInfo_NoneTarget");
			}
			else
			{
				ProjectilePosOffsetStruct.ToNative(IntPtr.Add(base.Address, TargetPosOffsetInfo_NoneTarget_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		BulletWave = 1;
		BulletNumInOneWave = 1;
		bEnableMultiTargetMode = false;
		bNeedHandleStopReq = true;
		bNeedDestorySpawnedBullet = false;
		AttachRule_Rot = EAttachmentRule.SnapToTarget;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!owner.IsNullOrDestroyed() && owner is ABGUCharacter && BulletWave > 0)
		{
			FGSProjecttileObjSpawnNSInfo SpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
			CopyNSConfigDataToStruct(owner, NotifyParam.FromInstanceID, ref SpawnNSInfo, TotalDuration);
			int uniqueID = (int)GetUniqueID();
			BUS_EventCollectionCS.Get(owner).Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref SpawnNSInfo, bNeedHandleStopReq, EProjectileSpawnMethod.SpawnByNotifyState, uniqueID);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner.IsNullOrDestroyed())
		{
			return;
		}
		int uniqueID = (int)GetUniqueID();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObjEnd.Invoke(EProjectileSpawnMethod.SpawnByNotifyState, uniqueID);
			if (bNeedDestorySpawnedBullet)
			{
				List<int> projectileID = new List<int> { BulletID };
				bUS_GSEventCollection.Evt_DestroyProjectileByID.Invoke(projectileID);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor InActor)
	{
		CheckBulletId(InActor, BulletID);
	}

	protected void CheckBulletId(AActor InActor, int InBulletId)
	{
		BGW_ValiDateMgr bGW_ValiDateMgr = BGW_ValiDateMgr.Get(InActor.World);
		string pathName = GetOuter().GetPathName();
		string name = GetName();
		if (BGW_GameDB.GetProjectileCommDesc(InBulletId, InActor) == null)
		{
			string logStr = $"Montage（{pathName}）中的Notify（{name}）的BulletID（{InBulletId}）未在Bullet表中找到索引";
			bGW_ValiDateMgr.ShowValidateWindow(logStr);
		}
		else
		{
			if (InBulletId < 10100)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = InActor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				int resID = bGUCharacterCS.GetResID();
				int num = ((resID > 100) ? (InBulletId / 10000) : (InBulletId / 100000));
				if (num != resID)
				{
					string logStr2 = $"Montage（{pathName}）中的Notify（{name}）的BulletID（{InBulletId}）未对应单位的ResID（{resID}）";
					bGW_ValiDateMgr.ShowValidateWindow(logStr2);
				}
			}
		}
	}

	public virtual int GetBulletID()
	{
		return BulletID;
	}

	protected void CopyNSConfigDataToStruct(AActor Owner, int MontageID, ref FGSProjecttileObjSpawnNSInfo SpawnNSInfo, float NSTotalDuration)
	{
		SpawnNSInfo.ProjectileType = EProjectileType.Bullet;
		SpawnNSInfo.BuffIDList = BuffIDList.ToList();
		SpawnNSInfo.ProjectileID = GetBulletID();
		SpawnNSInfo.SpawnWave = BulletWave;
		SpawnNSInfo.SpawnNumPerWave = BulletNumInOneWave;
		SpawnNSInfo.SetWaveDurationList(NSTotalDuration, BulletWave, WaveIntervalNoise);
		SpawnNSInfo.InitSpawnInfo(SpawnBase, SpawnPosOffsetInfo, bEnableSpawnBase_NoneTarget, SpawnBase_NoneTarget, SpawnPosOffsetInfo_NoneTarget, Owner, Owner, null, null, default(FEffectInstReq));
		SpawnNSInfo.AttachToSpawnBase = AttachToSpawnBase;
		SpawnNSInfo.AttachRule_Rot = AttachRule_Rot;
		SpawnNSInfo.InitTargetInfo(TargetBase, TargetPosOffsetInfo, bEnableTargetBase_NoneTarget, TargetBase_NoneTarget, TargetPosOffsetInfo_NoneTarget, Owner, Owner, null, null, default(FEffectInstReq));
		SpawnNSInfo.BornDirBaseInfo = BornDirBaseInfo;
		SpawnNSInfo.BornDirOffset = BornDirOffset;
		SpawnNSInfo.ProjectileFlySpd = BulletFlySpd;
		SpawnNSInfo.ProjectileRotSpd = BulletRotSpd;
		SpawnNSInfo.MontageID = MontageID;
		SpawnNSInfo.SpawnWaveDuration = ((BulletWave > 1) ? (NSTotalDuration / (float)(BulletWave - 1)) : 0f);
		SpawnNSInfo.SpawnCounter = 0;
		SpawnNSInfo.SpawnWaveCounter = 0;
		SpawnNSInfo.ANSTotalTime = NSTotalDuration;
		SpawnNSInfo.bEnableMultiTargetMode = bEnableMultiTargetMode;
		SpawnNSInfo.MutilTargetRule = MutilTargetRule;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANS_GSSpawnBullets:MarkDirty")]
	public bool MarkDirty()
	{
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSpawnBullets:MarkDirty")]
	private static void MarkDirty__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSpawnBullets bANS_GSSpawnBullets = GCHelper.Find<BANS_GSSpawnBullets>(obj);
		bool value = bANS_GSSpawnBullets.MarkDirty();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, MarkDirty_ReturnValue_Offset), 0, MarkDirty_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSpawnBullets:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSpawnBullets bANS_GSSpawnBullets = GCHelper.Find<BANS_GSSpawnBullets>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSpawnBullets.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSpawnBullets:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSpawnBullets bANS_GSSpawnBullets = GCHelper.Find<BANS_GSSpawnBullets>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSpawnBullets.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSpawnBullets:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSpawnBullets bANS_GSSpawnBullets = GCHelper.Find<BANS_GSSpawnBullets>(obj);
		AActor inActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_InActor_Offset));
		bANS_GSSpawnBullets.GSValidateInputCS_Implementation(inActor);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSpawnBullets");
		NativeReflection.GetPropertyRef(ref bNeedHandleStopReq_PropertyAddress, intPtr, "bNeedHandleStopReq");
		bNeedHandleStopReq_Offset = NativeReflection.GetPropertyOffset(intPtr, "bNeedHandleStopReq");
		bNeedHandleStopReq_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bNeedHandleStopReq", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bNeedDestorySpawnedBullet_PropertyAddress, intPtr, "bNeedDestorySpawnedBullet");
		bNeedDestorySpawnedBullet_Offset = NativeReflection.GetPropertyOffset(intPtr, "bNeedDestorySpawnedBullet");
		bNeedDestorySpawnedBullet_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bNeedDestorySpawnedBullet", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BuffIDList_PropertyAddress, intPtr, "BuffIDList");
		BuffIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffIDList");
		BuffIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffIDList", Classes.FArrayProperty);
		BulletID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BulletID");
		BulletID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BulletID", Classes.FIntProperty);
		BulletWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "BulletWave");
		BulletWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BulletWave", Classes.FIntProperty);
		WaveIntervalNoise_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaveIntervalNoise");
		WaveIntervalNoise_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaveIntervalNoise", Classes.FFloatProperty);
		BulletNumInOneWave_Offset = NativeReflection.GetPropertyOffset(intPtr, "BulletNumInOneWave");
		BulletNumInOneWave_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BulletNumInOneWave", Classes.FIntProperty);
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
		MarkDirty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MarkDirty");
		MarkDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirty_FunctionAddress);
		NativeReflection.GetPropertyRef(ref MarkDirty_ReturnValue_PropertyAddress, MarkDirty_FunctionAddress, "ReturnValue");
		MarkDirty_ReturnValue_Offset = NativeReflection.GetPropertyOffset(MarkDirty_FunctionAddress, "ReturnValue");
		MarkDirty_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(MarkDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MarkDirty_IsValid = MarkDirty_FunctionAddress != IntPtr.Zero && MarkDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSpawnBullets:MarkDirty", MarkDirty_IsValid);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSpawnBullets:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSpawnBullets:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_InActor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "InActor");
		GSValidateInputCS_InActor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "InActor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_InActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSpawnBullets:GSValidateInputCS", GSValidateInputCS_IsValid);
	}

	static BANS_GSSpawnBullets()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSSpawnBullets)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSSpawnBullets));
	}
}
