using System;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp")]
public class BUS_ProjectileConfigInfoComp : UActorEditCompBase
{
	private static ECollisionChannel temp_SweepCheckChannel;

	private static bool CheckShapeType_IsValid;

	private static int CheckShapeType_Offset;

	private static FFieldAddress CheckShapeType_PropertyAddress;

	private static bool SpecificFlags_IsValid;

	private static int SpecificFlags_Offset;

	private static bool LocalTrans_LineTracePoint_IsValid;

	private static int LocalTrans_LineTracePoint_Offset;

	private static bool Interact_Start_SphereRadius_IsValid;

	private static int Interact_Start_SphereRadius_Offset;

	private static bool Interact_Start_LocalTransform_IsValid;

	private static int Interact_Start_LocalTransform_Offset;

	private static bool Interact_End_SphereRadius_IsValid;

	private static int Interact_End_SphereRadius_Offset;

	private static bool Interact_End_LocalTransform_IsValid;

	private static int Interact_End_LocalTransform_Offset;

	private static bool WindBrokenAudio_IsValid;

	private static int WindBrokenAudio_Offset;

	private static bool TriggerDist_WindBroken_IsValid;

	private static int TriggerDist_WindBroken_Offset;

	private static bool bEnableDebug_WindBrokenAudio_IsValid;

	private static int bEnableDebug_WindBrokenAudio_Offset;

	private static FFieldAddress bEnableDebug_WindBrokenAudio_PropertyAddress;

	private static bool DonutAudio_IsValid;

	private static int DonutAudio_Offset;

	private static bool DonutAudioLocationType_IsValid;

	private static int DonutAudioLocationType_Offset;

	private static FFieldAddress DonutAudioLocationType_PropertyAddress;

	private static bool DonutAudioStopMode_IsValid;

	private static int DonutAudioStopMode_Offset;

	private static FFieldAddress DonutAudioStopMode_PropertyAddress;

	private static bool DonutAudioStopTimeMs_IsValid;

	private static int DonutAudioStopTimeMs_Offset;

	private static bool DonutAudioFadeOutTimeMs_IsValid;

	private static int DonutAudioFadeOutTimeMs_Offset;

	private static bool DonutAudioCurveInterpolation_IsValid;

	private static int DonutAudioCurveInterpolation_Offset;

	private static FFieldAddress DonutAudioCurveInterpolation_PropertyAddress;

	private static bool LoopEvent_IsValid;

	private static int LoopEvent_Offset;

	private static bool DeadEvent_IsValid;

	private static int DeadEvent_Offset;

	private static bool bEnable_IsValid;

	private static int bEnable_Offset;

	private static FFieldAddress bEnable_PropertyAddress;

	private static bool TraceDelay_IsValid;

	private static int TraceDelay_Offset;

	private static bool TraceLength_IsValid;

	private static int TraceLength_Offset;

	private static bool Size_IsValid;

	private static int Size_Offset;

	private static bool SampleCollectionProtectTime_IsValid;

	private static int SampleCollectionProtectTime_Offset;

	private static bool OverrideSurfaceType_IsValid;

	private static int OverrideSurfaceType_Offset;

	private static FFieldAddress OverrideSurfaceType_PropertyAddress;

	private static bool OverrideSurfacePersistTime_IsValid;

	private static int OverrideSurfacePersistTime_Offset;

	private static bool OverrideSurfaceFXActorTag_IsValid;

	private static int OverrideSurfaceFXActorTag_Offset;

	private static bool bDrawDebug_IsValid;

	private static int bDrawDebug_Offset;

	private static FFieldAddress bDrawDebug_PropertyAddress;

	private static bool DebugDrawOffset_IsValid;

	private static int DebugDrawOffset_Offset;

	private static bool DestructibleTag_IsValid;

	private static int DestructibleTag_Offset;

	private static bool EffectIDs_IsValid;

	private static int EffectIDs_Offset;

	private static FFieldAddress EffectIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> EffectIDs_Marshaler;

	private static bool BuffIDs_IsValid;

	private static int BuffIDs_Offset;

	private static FFieldAddress BuffIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BuffIDs_Marshaler;

	private static bool NeedCheckWorldStatic_IsValid;

	private static int NeedCheckWorldStatic_Offset;

	private static FFieldAddress NeedCheckWorldStatic_PropertyAddress;

	private static bool SweepCheckChannel_IsValid;

	private static int SweepCheckChannel_Offset;

	private static FFieldAddress SweepCheckChannel_PropertyAddress;

	private static bool CheckCompProfileName_Bullet_IsValid;

	private static int CheckCompProfileName_Bullet_Offset;

	private static FFieldAddress CheckCompProfileName_Bullet_PropertyAddress;

	private static bool HitCheckConf_IsValid;

	private static int HitCheckConf_Offset;

	private static bool bEnableAttackWarning_IsValid;

	private static int bEnableAttackWarning_Offset;

	private static FFieldAddress bEnableAttackWarning_PropertyAddress;

	private static bool AttackWarningExtendSize_IsValid;

	private static int AttackWarningExtendSize_Offset;

	private static bool AttackWarningOffset_IsValid;

	private static int AttackWarningOffset_Offset;

	private static bool bEnableDebug_IsValid;

	private static int bEnableDebug_Offset;

	private static FFieldAddress bEnableDebug_PropertyAddress;

	private static bool bHitChrAttach_IsValid;

	private static int bHitChrAttach_Offset;

	private static FFieldAddress bHitChrAttach_PropertyAddress;

	private static bool HitChrAttachTime_IsValid;

	private static int HitChrAttachTime_Offset;

	private static bool bHitItemAttach_IsValid;

	private static int bHitItemAttach_Offset;

	private static FFieldAddress bHitItemAttach_PropertyAddress;

	private static bool HitItemAttachTime_IsValid;

	private static int HitItemAttachTime_Offset;

	private static bool AttachOffset_IsValid;

	private static int AttachOffset_Offset;

	private static bool MPC_IsValid;

	private static int MPC_Offset;

	private static bool bDrawDebug_Laser_IsValid;

	private static int bDrawDebug_Laser_Offset;

	private static FFieldAddress bDrawDebug_Laser_PropertyAddress;

	private static bool AkEvent_LaserEnd_IsValid;

	private static int AkEvent_LaserEnd_Offset;

	private static bool FadeOut_AkEvent_LaserEnd_IsValid;

	private static int FadeOut_AkEvent_LaserEnd_Offset;

	private static bool AkEvent_LaserHitItem_IsValid;

	private static int AkEvent_LaserHitItem_Offset;

	private static bool CheckCompProfileName_MagicField_IsValid;

	private static int CheckCompProfileName_MagicField_Offset;

	private static FFieldAddress CheckCompProfileName_MagicField_PropertyAddress;

	private static bool MagicFieldOverlapType_IsValid;

	private static int MagicFieldOverlapType_Offset;

	private static FFieldAddress MagicFieldOverlapType_PropertyAddress;

	private static bool bDebug_IsValid;

	private static int bDebug_Offset;

	private static FFieldAddress bDebug_PropertyAddress;

	private static bool bCanHandleAvoidance_IsValid;

	private static int bCanHandleAvoidance_Offset;

	private static FFieldAddress bCanHandleAvoidance_PropertyAddress;

	private static bool bUseSoftEdge_IsValid;

	private static int bUseSoftEdge_Offset;

	private static FFieldAddress bUseSoftEdge_PropertyAddress;

	private static bool FieldBuffList_IsValid;

	private static int FieldBuffList_Offset;

	private static FFieldAddress FieldBuffList_PropertyAddress;

	private TArrayReadWriteMarshaler<FFieldBuffInfo> FieldBuffList_Marshaler;

	private static bool BornEffectDelayTime_IsValid;

	private static int BornEffectDelayTime_Offset;

	private static bool BornAttackWarningTime_IsValid;

	private static int BornAttackWarningTime_Offset;

	private static bool bAttackWarningTriggerPreciseDodge_IsValid;

	private static int bAttackWarningTriggerPreciseDodge_Offset;

	private static FFieldAddress bAttackWarningTriggerPreciseDodge_PropertyAddress;

	private static bool bPreciseDodgeFilterTeammate_IsValid;

	private static int bPreciseDodgeFilterTeammate_Offset;

	private static FFieldAddress bPreciseDodgeFilterTeammate_PropertyAddress;

	private static bool EnterEvents_IsValid;

	private static int EnterEvents_Offset;

	private static FFieldAddress EnterEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<MFEvent> EnterEvents_Marshaler;

	private static bool ExitEvents_IsValid;

	private static int ExitEvents_Offset;

	private static FFieldAddress ExitEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<MFEvent> ExitEvents_Marshaler;

	private static bool BirthEvents_IsValid;

	private static int BirthEvents_Offset;

	private static FFieldAddress BirthEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<MFEvent> BirthEvents_Marshaler;

	private static bool DieEvents_IsValid;

	private static int DieEvents_Offset;

	private static FFieldAddress DieEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<MFEvent> DieEvents_Marshaler;

	private static bool HitDestructibleStrengthLevel_IsValid;

	private static int HitDestructibleStrengthLevel_Offset;

	private static FFieldAddress HitDestructibleStrengthLevel_PropertyAddress;

	private static bool HitDestructibleDirectionType_IsValid;

	private static int HitDestructibleDirectionType_Offset;

	private static FFieldAddress HitDestructibleDirectionType_PropertyAddress;

	private static bool HitDestructibleEffectsTriggerForSelf_IsValid;

	private static int HitDestructibleEffectsTriggerForSelf_Offset;

	private static FFieldAddress HitDestructibleEffectsTriggerForSelf_PropertyAddress;

	private TArrayReadWriteMarshaler<int> HitDestructibleEffectsTriggerForSelf_Marshaler;

	private static bool OverlapBeginEvents_IsValid;

	private static int OverlapBeginEvents_Offset;

	private static FFieldAddress OverlapBeginEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<MFOverlapEvent> OverlapBeginEvents_Marshaler;

	private static bool OverlapEndEvents_IsValid;

	private static int OverlapEndEvents_Offset;

	private static FFieldAddress OverlapEndEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<MFOverlapEvent> OverlapEndEvents_Marshaler;

	private static bool BornEvents_IsValid;

	private static int BornEvents_Offset;

	private static FFieldAddress BornEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<MFOverlapEvent> BornEvents_Marshaler;

	private static bool DeadEvents_IsValid;

	private static int DeadEvents_Offset;

	private static FFieldAddress DeadEvents_PropertyAddress;

	private TArrayReadWriteMarshaler<MFOverlapEvent> DeadEvents_Marshaler;

	private static bool DirectionUsage_IsValid;

	private static int DirectionUsage_Offset;

	private static FFieldAddress DirectionUsage_PropertyAddress;

	private static bool DirectionType_IsValid;

	private static int DirectionType_Offset;

	private static FFieldAddress DirectionType_PropertyAddress;

	private static bool DirectionTypeDetail_IsValid;

	private static int DirectionTypeDetail_Offset;

	private static FFieldAddress DirectionTypeDetail_PropertyAddress;

	private static bool AnchorPointTag_IsValid;

	private static int AnchorPointTag_Offset;

	private static bool DirectionEffects_IsValid;

	private static int DirectionEffects_Offset;

	private static FFieldAddress DirectionEffects_PropertyAddress;

	private TArrayReadWriteMarshaler<MFDirectionEffect> DirectionEffects_Marshaler;

	private static bool bEnableShelterRT_IsValid;

	private static int bEnableShelterRT_Offset;

	private static FFieldAddress bEnableShelterRT_PropertyAddress;

	private static bool bEnableGlobalFX_IsValid;

	private static int bEnableGlobalFX_Offset;

	private static FFieldAddress bEnableGlobalFX_PropertyAddress;

	private static bool GlobalFXTag_IsValid;

	private static int GlobalFXTag_Offset;

	private static bool ExtAbilityMask_IsValid;

	private static int ExtAbilityMask_Offset;

	private static bool DisableAbilityMask_IsValid;

	private static int DisableAbilityMask_Offset;

	private static bool bForceUseProjectileMovementComp_IsValid;

	private static int bForceUseProjectileMovementComp_Offset;

	private static FFieldAddress bForceUseProjectileMovementComp_PropertyAddress;

	private static bool bNotify_SpawnFinished_IsValid;

	private static int bNotify_SpawnFinished_Offset;

	private static FFieldAddress bNotify_SpawnFinished_PropertyAddress;

	private static bool bEnable_DBCComp_IsValid;

	private static int bEnable_DBCComp_Offset;

	private static FFieldAddress bEnable_DBCComp_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("检测形状类型")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckShapeType")]
	public EProjectileCheckShapeType CheckShapeType
	{
		get
		{
			CheckDestroyed();
			if (!CheckShapeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckShapeType");
				return EProjectileCheckShapeType.DefaultShape;
			}
			return EnumMarshaler<EProjectileCheckShapeType>.FromNative(IntPtr.Add(base.Address, CheckShapeType_Offset), 0, CheckShapeType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CheckShapeType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckShapeType");
			}
			else
			{
				EnumMarshaler<EProjectileCheckShapeType>.ToNative(IntPtr.Add(base.Address, CheckShapeType_Offset), 0, CheckShapeType_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDEnum.BitmaskEnum, "ProjectileSpecificFlags")]
	[UMeta(MDEnum.Bitmask)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SpecificFlags")]
	public int SpecificFlags
	{
		get
		{
			CheckDestroyed();
			if (!SpecificFlags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SpecificFlags");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpecificFlags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpecificFlags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SpecificFlags");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpecificFlags_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("LineTracePoint")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:LocalTrans_LineTracePoint")]
	public FTransform LocalTrans_LineTracePoint
	{
		get
		{
			CheckDestroyed();
			if (!LocalTrans_LineTracePoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:LocalTrans_LineTracePoint");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, LocalTrans_LineTracePoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocalTrans_LineTracePoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:LocalTrans_LineTracePoint");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, LocalTrans_LineTracePoint_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Interact")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_Start_SphereRadius")]
	public float Interact_Start_SphereRadius
	{
		get
		{
			CheckDestroyed();
			if (!Interact_Start_SphereRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_Start_SphereRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Interact_Start_SphereRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interact_Start_SphereRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_Start_SphereRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Interact_Start_SphereRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Interact")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_Start_LocalTransform")]
	public FTransform Interact_Start_LocalTransform
	{
		get
		{
			CheckDestroyed();
			if (!Interact_Start_LocalTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_Start_LocalTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Interact_Start_LocalTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interact_Start_LocalTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_Start_LocalTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Interact_Start_LocalTransform_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Interact")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_End_SphereRadius")]
	public float Interact_End_SphereRadius
	{
		get
		{
			CheckDestroyed();
			if (!Interact_End_SphereRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_End_SphereRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Interact_End_SphereRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interact_End_SphereRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_End_SphereRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Interact_End_SphereRadius_Offset), value);
			}
		}
	}

	[Category("Interact")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_End_LocalTransform")]
	public FTransform Interact_End_LocalTransform
	{
		get
		{
			CheckDestroyed();
			if (!Interact_End_LocalTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_End_LocalTransform");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, Interact_End_LocalTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interact_End_LocalTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Interact_End_LocalTransform");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, Interact_End_LocalTransform_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("破风音效")]
	[BlueprintReadWrite]
	[DisplayName("破风音效资源")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:WindBrokenAudio")]
	public UAkAudioEvent WindBrokenAudio
	{
		get
		{
			CheckDestroyed();
			if (!WindBrokenAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:WindBrokenAudio");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, WindBrokenAudio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindBrokenAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:WindBrokenAudio");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, WindBrokenAudio_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("破风音效")]
	[EditAnywhere]
	[DisplayName("破风音效触发距离")]
	[Tooltip("离本地相机的距离")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TriggerDist_WindBroken")]
	public float TriggerDist_WindBroken
	{
		get
		{
			CheckDestroyed();
			if (!TriggerDist_WindBroken_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TriggerDist_WindBroken");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TriggerDist_WindBroken_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerDist_WindBroken_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TriggerDist_WindBroken");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TriggerDist_WindBroken_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("破风音效触发位置Debug")]
	[EditAnywhere]
	[Category("破风音效")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableDebug_WindBrokenAudio")]
	public bool bEnableDebug_WindBrokenAudio
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebug_WindBrokenAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableDebug_WindBrokenAudio");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebug_WindBrokenAudio_Offset), 0, bEnableDebug_WindBrokenAudio_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebug_WindBrokenAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableDebug_WindBrokenAudio");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebug_WindBrokenAudio_Offset), 0, bEnableDebug_WindBrokenAudio_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("环形子弹音效")]
	[UProperty]
	[Category("环形子弹音效")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudio")]
	public UAkAudioEvent DonutAudio
	{
		get
		{
			CheckDestroyed();
			if (!DonutAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudio");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, DonutAudio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DonutAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudio");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, DonutAudio_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("环形子弹音效")]
	[DisplayName("播放位置")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioLocationType")]
	public EDonutBulletAudioLocationType DonutAudioLocationType
	{
		get
		{
			CheckDestroyed();
			if (!DonutAudioLocationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioLocationType");
				return EDonutBulletAudioLocationType.None;
			}
			return EnumMarshaler<EDonutBulletAudioLocationType>.FromNative(IntPtr.Add(base.Address, DonutAudioLocationType_Offset), 0, DonutAudioLocationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DonutAudioLocationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioLocationType");
			}
			else
			{
				EnumMarshaler<EDonutBulletAudioLocationType>.ToNative(IntPtr.Add(base.Address, DonutAudioLocationType_Offset), 0, DonutAudioLocationType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("结束模式")]
	[Category("环形子弹音效")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioStopMode")]
	public EAkEventStopMode DonutAudioStopMode
	{
		get
		{
			CheckDestroyed();
			if (!DonutAudioStopMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioStopMode");
				return EAkEventStopMode.Auto;
			}
			return EnumMarshaler<EAkEventStopMode>.FromNative(IntPtr.Add(base.Address, DonutAudioStopMode_Offset), 0, DonutAudioStopMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DonutAudioStopMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioStopMode");
			}
			else
			{
				EnumMarshaler<EAkEventStopMode>.ToNative(IntPtr.Add(base.Address, DonutAudioStopMode_Offset), 0, DonutAudioStopMode_PropertyAddress.Address, value);
			}
		}
	}

	[Category("环形子弹音效")]
	[DisplayName("结束时间（毫秒）")]
	[UMeta(MDProp.EditCondition, "StopMode == EAkEventStopMode::ByTime")]
	[Tooltip("根据不同的结束模式，时间的意义不同")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioStopTimeMs")]
	public int DonutAudioStopTimeMs
	{
		get
		{
			CheckDestroyed();
			if (!DonutAudioStopTimeMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioStopTimeMs");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DonutAudioStopTimeMs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DonutAudioStopTimeMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioStopTimeMs");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DonutAudioStopTimeMs_Offset), value);
			}
		}
	}

	[DisplayName("淡出时间（毫秒）")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("环形子弹音效")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioFadeOutTimeMs")]
	public int DonutAudioFadeOutTimeMs
	{
		get
		{
			CheckDestroyed();
			if (!DonutAudioFadeOutTimeMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioFadeOutTimeMs");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DonutAudioFadeOutTimeMs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DonutAudioFadeOutTimeMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioFadeOutTimeMs");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DonutAudioFadeOutTimeMs_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("环形子弹音效")]
	[DisplayName("淡出曲线")]
	[UMeta(MDProp.EditCondition, "FadeOutTimeMs > 0")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioCurveInterpolation")]
	public EAkCurveInterpolationCS DonutAudioCurveInterpolation
	{
		get
		{
			CheckDestroyed();
			if (!DonutAudioCurveInterpolation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioCurveInterpolation");
				return EAkCurveInterpolationCS.Log3;
			}
			return EnumMarshaler<EAkCurveInterpolationCS>.FromNative(IntPtr.Add(base.Address, DonutAudioCurveInterpolation_Offset), 0, DonutAudioCurveInterpolation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DonutAudioCurveInterpolation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DonutAudioCurveInterpolation");
			}
			else
			{
				EnumMarshaler<EAkCurveInterpolationCS>.ToNative(IntPtr.Add(base.Address, DonutAudioCurveInterpolation_Offset), 0, DonutAudioCurveInterpolation_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("出生时开始播放的音效")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Audio")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:LoopEvent")]
	public UAkEventConfig LoopEvent
	{
		get
		{
			CheckDestroyed();
			if (!LoopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:LoopEvent");
				return default(UAkEventConfig);
			}
			return UAkEventConfig.FromNative(IntPtr.Add(base.Address, LoopEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoopEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:LoopEvent");
			}
			else
			{
				UAkEventConfig.ToNative(IntPtr.Add(base.Address, LoopEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Audio")]
	[Tooltip("死亡时开始播放的音效")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DeadEvent")]
	public UAkEventConfig DeadEvent
	{
		get
		{
			CheckDestroyed();
			if (!DeadEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DeadEvent");
				return default(UAkEventConfig);
			}
			return UAkEventConfig.FromNative(IntPtr.Add(base.Address, DeadEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeadEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DeadEvent");
			}
			else
			{
				UAkEventConfig.ToNative(IntPtr.Add(base.Address, DeadEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("启用\ud83d\ude4f")]
	[Category("ProceduralEnvInteractionTrigger")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnable")]
	public bool bEnable
	{
		get
		{
			CheckDestroyed();
			if (!bEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnable_Offset), 0, bEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnable_Offset), 0, bEnable_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("ProceduralEnvInteractionTrigger")]
	[DisplayName("检测延迟\ud83d\ude32")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TraceDelay")]
	public float TraceDelay
	{
		get
		{
			CheckDestroyed();
			if (!TraceDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TraceDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TraceDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceDelay_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("ProceduralEnvInteractionTrigger")]
	[DisplayName("检测射线长度\ud83d\ude33")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TraceLength")]
	public float TraceLength
	{
		get
		{
			CheckDestroyed();
			if (!TraceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TraceLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TraceLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TraceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:TraceLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TraceLength_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("ProceduralEnvInteractionTrigger")]
	[DisplayName("大小\ud83d\ude31")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Size")]
	public float Size
	{
		get
		{
			CheckDestroyed();
			if (!Size_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Size");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Size_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Size_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:Size");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Size_Offset), value);
			}
		}
	}

	[DisplayName("样本获取保护时间\ud83d\ude31")]
	[UProperty]
	[Category("ProceduralEnvInteractionTrigger")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SampleCollectionProtectTime")]
	public float SampleCollectionProtectTime
	{
		get
		{
			CheckDestroyed();
			if (!SampleCollectionProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SampleCollectionProtectTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SampleCollectionProtectTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SampleCollectionProtectTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SampleCollectionProtectTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SampleCollectionProtectTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("覆盖表面类型\ud83d\ude30")]
	[Category("ProceduralEnvInteractionTrigger")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfaceType")]
	public ESceneItemSurfaceType OverrideSurfaceType
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfaceType");
				return ESceneItemSurfaceType.DefaultSurface;
			}
			return EnumMarshaler<ESceneItemSurfaceType>.FromNative(IntPtr.Add(base.Address, OverrideSurfaceType_Offset), 0, OverrideSurfaceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSurfaceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfaceType");
			}
			else
			{
				EnumMarshaler<ESceneItemSurfaceType>.ToNative(IntPtr.Add(base.Address, OverrideSurfaceType_Offset), 0, OverrideSurfaceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("ProceduralEnvInteractionTrigger")]
	[DisplayName("覆盖表面持续时间\ud83d\ude22")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfacePersistTime")]
	public float OverrideSurfacePersistTime
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSurfacePersistTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfacePersistTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverrideSurfacePersistTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSurfacePersistTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfacePersistTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverrideSurfacePersistTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("ProceduralEnvInteractionTrigger")]
	[DisplayName("覆盖表面特效ActorTag\ud83d\ude22")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfaceFXActorTag")]
	public FName OverrideSurfaceFXActorTag
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSurfaceFXActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfaceFXActorTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OverrideSurfaceFXActorTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSurfaceFXActorTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverrideSurfaceFXActorTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OverrideSurfaceFXActorTag_Offset), value);
			}
		}
	}

	[DisplayName("debug画出来\ud83d\ude4f")]
	[Category("ProceduralEnvInteractionTrigger")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDrawDebug")]
	public bool bDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("ProceduralEnvInteractionTrigger")]
	[DisplayName("debug画的偏移\ud83d\ude4f")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DebugDrawOffset")]
	public float DebugDrawOffset
	{
		get
		{
			CheckDestroyed();
			if (!DebugDrawOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DebugDrawOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugDrawOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugDrawOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DebugDrawOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugDrawOffset_Offset), value);
			}
		}
	}

	[DisplayName("破碎物Tag")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("DestructibleDestroyConfig")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DestructibleTag")]
	public FName DestructibleTag
	{
		get
		{
			CheckDestroyed();
			if (!DestructibleTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DestructibleTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DestructibleTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestructibleTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DestructibleTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DestructibleTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DestructibleDestroyConfig")]
	[DisplayName("破碎触发EffectID")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:EffectIDs")]
	public TArrayReadWrite<int> EffectIDs
	{
		get
		{
			CheckDestroyed();
			if (!EffectIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:EffectIDs");
				return null;
			}
			if (EffectIDs_Marshaler == null)
			{
				EffectIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, EffectIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return EffectIDs_Marshaler.FromNative(IntPtr.Add(base.Address, EffectIDs_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("DestructibleDestroyConfig")]
	[DisplayName("破碎添加BuffID")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BuffIDs")]
	public TArrayReadWrite<int> BuffIDs
	{
		get
		{
			CheckDestroyed();
			if (!BuffIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BuffIDs");
				return null;
			}
			if (BuffIDs_Marshaler == null)
			{
				BuffIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, BuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BuffIDs_Marshaler.FromNative(IntPtr.Add(base.Address, BuffIDs_Offset));
		}
	}

	[BlueprintReadWrite]
	[DisplayName("需要检测WorldStatic")]
	[UProperty]
	[Category("SweepCheck")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:NeedCheckWorldStatic")]
	public bool NeedCheckWorldStatic
	{
		get
		{
			CheckDestroyed();
			if (!NeedCheckWorldStatic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:NeedCheckWorldStatic");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedCheckWorldStatic_Offset), 0, NeedCheckWorldStatic_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedCheckWorldStatic_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:NeedCheckWorldStatic");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedCheckWorldStatic_Offset), 0, NeedCheckWorldStatic_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SweepCheck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SweepCheckChannel")]
	public ECollisionChannel SweepCheckChannel
	{
		get
		{
			CheckDestroyed();
			if (!SweepCheckChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SweepCheckChannel");
				return ECollisionChannel.ECC_WorldStatic;
			}
			return EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(base.Address, SweepCheckChannel_Offset), 0, SweepCheckChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SweepCheckChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:SweepCheckChannel");
			}
			else
			{
				EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(base.Address, SweepCheckChannel_Offset), 0, SweepCheckChannel_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("子弹检测载体的碰撞预设")]
	[Category("SweepCheck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckCompProfileName_Bullet")]
	public Type_CheckCompProfileName_Bullet CheckCompProfileName_Bullet
	{
		get
		{
			CheckDestroyed();
			if (!CheckCompProfileName_Bullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckCompProfileName_Bullet");
				return Type_CheckCompProfileName_Bullet.NormalBullet;
			}
			return EnumMarshaler<Type_CheckCompProfileName_Bullet>.FromNative(IntPtr.Add(base.Address, CheckCompProfileName_Bullet_Offset), 0, CheckCompProfileName_Bullet_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CheckCompProfileName_Bullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckCompProfileName_Bullet");
			}
			else
			{
				EnumMarshaler<Type_CheckCompProfileName_Bullet>.ToNative(IntPtr.Add(base.Address, CheckCompProfileName_Bullet_Offset), 0, CheckCompProfileName_Bullet_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("SweepCheck")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitCheckConf")]
	public FHitCheckConf HitCheckConf
	{
		get
		{
			CheckDestroyed();
			if (!HitCheckConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitCheckConf");
				return default(FHitCheckConf);
			}
			return FHitCheckConf.FromNative(IntPtr.Add(base.Address, HitCheckConf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitCheckConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitCheckConf");
			}
			else
			{
				FHitCheckConf.ToNative(IntPtr.Add(base.Address, HitCheckConf_Offset), value);
			}
		}
	}

	[Category("SweepCheck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("启用AttackWarning（精准闪避）")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableAttackWarning")]
	public bool bEnableAttackWarning
	{
		get
		{
			CheckDestroyed();
			if (!bEnableAttackWarning_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableAttackWarning");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableAttackWarning_Offset), 0, bEnableAttackWarning_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableAttackWarning_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableAttackWarning");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableAttackWarning_Offset), 0, bEnableAttackWarning_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("SweepCheck")]
	[Tooltip("AttackWarning范围扩大的大小，单位uu")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttackWarningExtendSize")]
	public float AttackWarningExtendSize
	{
		get
		{
			CheckDestroyed();
			if (!AttackWarningExtendSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttackWarningExtendSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttackWarningExtendSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackWarningExtendSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttackWarningExtendSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttackWarningExtendSize_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SweepCheck")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttackWarningOffset")]
	public FVector AttackWarningOffset
	{
		get
		{
			CheckDestroyed();
			if (!AttackWarningOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttackWarningOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, AttackWarningOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttackWarningOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttackWarningOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, AttackWarningOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("SweepCheck")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableDebug")]
	public bool bEnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("命中附着残留")]
	[DisplayName("命中角色时附着残留在物体上")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bHitChrAttach")]
	public bool bHitChrAttach
	{
		get
		{
			CheckDestroyed();
			if (!bHitChrAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bHitChrAttach");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHitChrAttach_Offset), 0, bHitChrAttach_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHitChrAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bHitChrAttach");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHitChrAttach_Offset), 0, bHitChrAttach_PropertyAddress.Address, value);
			}
		}
	}

	[Category("命中附着残留")]
	[DisplayName("命中角色时附着残留时间")]
	[BlueprintReadWrite]
	[Tooltip("单位:秒")]
	[UMeta(MDProp.EditCondition, "bHitChrAttach")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitChrAttachTime")]
	public float HitChrAttachTime
	{
		get
		{
			CheckDestroyed();
			if (!HitChrAttachTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitChrAttachTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitChrAttachTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitChrAttachTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitChrAttachTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitChrAttachTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("命中附着残留")]
	[DisplayName("命中物体时附着残留在物体上")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bHitItemAttach")]
	public bool bHitItemAttach
	{
		get
		{
			CheckDestroyed();
			if (!bHitItemAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bHitItemAttach");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHitItemAttach_Offset), 0, bHitItemAttach_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHitItemAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bHitItemAttach");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHitItemAttach_Offset), 0, bHitItemAttach_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("命中物体时附着残留时间")]
	[Category("命中附着残留")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "bHitItemAttach")]
	[EditAnywhere]
	[Tooltip("单位:秒")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitItemAttachTime")]
	public float HitItemAttachTime
	{
		get
		{
			CheckDestroyed();
			if (!HitItemAttachTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitItemAttachTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HitItemAttachTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitItemAttachTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitItemAttachTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HitItemAttachTime_Offset), value);
			}
		}
	}

	[DisplayName("附着深度偏移")]
	[BlueprintReadWrite]
	[Category("命中附着残留")]
	[EditAnywhere]
	[UProperty]
	[Tooltip("沿子弹X轴方向做偏移")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttachOffset")]
	public float AttachOffset
	{
		get
		{
			CheckDestroyed();
			if (!AttachOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttachOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttachOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AttachOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttachOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("MatMgr")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:MPC")]
	public UMaterialParameterCollection MPC
	{
		get
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:MPC");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPC_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPC_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:MPC");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPC_Offset), value);
			}
		}
	}

	[Category("激光")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("Debug开关")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDrawDebug_Laser")]
	public bool bDrawDebug_Laser
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebug_Laser_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDrawDebug_Laser");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebug_Laser_Offset), 0, bDrawDebug_Laser_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebug_Laser_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDrawDebug_Laser");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebug_Laser_Offset), 0, bDrawDebug_Laser_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("音源位置为激光线段上离Listener最近的点")]
	[Category("激光")]
	[DisplayName("激光常驻音效")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AkEvent_LaserEnd")]
	public UAkAudioEvent AkEvent_LaserEnd
	{
		get
		{
			CheckDestroyed();
			if (!AkEvent_LaserEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AkEvent_LaserEnd");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEvent_LaserEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEvent_LaserEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AkEvent_LaserEnd");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEvent_LaserEnd_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("激光")]
	[DisplayName("激光常驻音效淡出时长（毫秒）")]
	[Tooltip("子弹死亡时淡出")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:FadeOut_AkEvent_LaserEnd")]
	public int FadeOut_AkEvent_LaserEnd
	{
		get
		{
			CheckDestroyed();
			if (!FadeOut_AkEvent_LaserEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:FadeOut_AkEvent_LaserEnd");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, FadeOut_AkEvent_LaserEnd_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeOut_AkEvent_LaserEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:FadeOut_AkEvent_LaserEnd");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, FadeOut_AkEvent_LaserEnd_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("激光")]
	[DisplayName("激光命中场景音效")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AkEvent_LaserHitItem")]
	public UAkAudioEvent AkEvent_LaserHitItem
	{
		get
		{
			CheckDestroyed();
			if (!AkEvent_LaserHitItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AkEvent_LaserHitItem");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEvent_LaserHitItem_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEvent_LaserHitItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AkEvent_LaserHitItem");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEvent_LaserHitItem_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("法术场检测载体的碰撞预设")]
	[EditAnywhere]
	[Category("法术场通用配置")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckCompProfileName_MagicField")]
	public Type_CheckCompProfileName_MagicField CheckCompProfileName_MagicField
	{
		get
		{
			CheckDestroyed();
			if (!CheckCompProfileName_MagicField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckCompProfileName_MagicField");
				return Type_CheckCompProfileName_MagicField.NormalMagicField;
			}
			return EnumMarshaler<Type_CheckCompProfileName_MagicField>.FromNative(IntPtr.Add(base.Address, CheckCompProfileName_MagicField_Offset), 0, CheckCompProfileName_MagicField_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CheckCompProfileName_MagicField_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:CheckCompProfileName_MagicField");
			}
			else
			{
				EnumMarshaler<Type_CheckCompProfileName_MagicField>.ToNative(IntPtr.Add(base.Address, CheckCompProfileName_MagicField_Offset), 0, CheckCompProfileName_MagicField_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("法术场通用配置")]
	[EditAnywhere]
	[DisplayName("法术场检测类型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:MagicFieldOverlapType")]
	public EMagicFieldOverlapType MagicFieldOverlapType
	{
		get
		{
			CheckDestroyed();
			if (!MagicFieldOverlapType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:MagicFieldOverlapType");
				return EMagicFieldOverlapType.Normal;
			}
			return EnumMarshaler<EMagicFieldOverlapType>.FromNative(IntPtr.Add(base.Address, MagicFieldOverlapType_Offset), 0, MagicFieldOverlapType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MagicFieldOverlapType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:MagicFieldOverlapType");
			}
			else
			{
				EnumMarshaler<EMagicFieldOverlapType>.ToNative(IntPtr.Add(base.Address, MagicFieldOverlapType_Offset), 0, MagicFieldOverlapType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("法术场通用配置|事件配置")]
	[EditAnywhere]
	[DisplayName("开启调试")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDebug")]
	public bool bDebug
	{
		get
		{
			CheckDestroyed();
			if (!bDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDebug_Offset), 0, bDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDebug_Offset), 0, bDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否处理避让法术场")]
	[Category("法术场通用配置")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bCanHandleAvoidance")]
	public bool bCanHandleAvoidance
	{
		get
		{
			CheckDestroyed();
			if (!bCanHandleAvoidance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bCanHandleAvoidance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanHandleAvoidance_Offset), 0, bCanHandleAvoidance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanHandleAvoidance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bCanHandleAvoidance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanHandleAvoidance_Offset), 0, bCanHandleAvoidance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("是否启用软边界")]
	[Category("法术场通用配置")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bUseSoftEdge")]
	public bool bUseSoftEdge
	{
		get
		{
			CheckDestroyed();
			if (!bUseSoftEdge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bUseSoftEdge");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseSoftEdge_Offset), 0, bUseSoftEdge_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseSoftEdge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bUseSoftEdge");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseSoftEdge_Offset), 0, bUseSoftEdge_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("领域Buff列表")]
	[Category("法术场通用配置")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:FieldBuffList")]
	public TArrayReadWrite<FFieldBuffInfo> FieldBuffList
	{
		get
		{
			CheckDestroyed();
			if (!FieldBuffList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:FieldBuffList");
				return null;
			}
			if (FieldBuffList_Marshaler == null)
			{
				FieldBuffList_Marshaler = new TArrayReadWriteMarshaler<FFieldBuffInfo>(1, FieldBuffList_PropertyAddress, CachedMarshalingDelegates<FFieldBuffInfo, FFieldBuffInfo>.FromNative, CachedMarshalingDelegates<FFieldBuffInfo, FFieldBuffInfo>.ToNative);
			}
			return FieldBuffList_Marshaler.FromNative(IntPtr.Add(base.Address, FieldBuffList_Offset));
		}
	}

	[UProperty]
	[Category("法术场通用配置|出生预警")]
	[EditAnywhere]
	[DisplayName("出生效果延迟触发时长")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BornEffectDelayTime")]
	public float BornEffectDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!BornEffectDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BornEffectDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BornEffectDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornEffectDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BornEffectDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BornEffectDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("出生效果预警时长")]
	[Category("法术场通用配置|出生预警")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BornAttackWarningTime")]
	public float BornAttackWarningTime
	{
		get
		{
			CheckDestroyed();
			if (!BornAttackWarningTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BornAttackWarningTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BornAttackWarningTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BornAttackWarningTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BornAttackWarningTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BornAttackWarningTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("攻击预警可触发精准闪避")]
	[Category("法术场通用配置|出生预警")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bAttackWarningTriggerPreciseDodge")]
	public bool bAttackWarningTriggerPreciseDodge
	{
		get
		{
			CheckDestroyed();
			if (!bAttackWarningTriggerPreciseDodge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bAttackWarningTriggerPreciseDodge");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAttackWarningTriggerPreciseDodge_Offset), 0, bAttackWarningTriggerPreciseDodge_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAttackWarningTriggerPreciseDodge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bAttackWarningTriggerPreciseDodge");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAttackWarningTriggerPreciseDodge_Offset), 0, bAttackWarningTriggerPreciseDodge_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("精准闪避过滤队友伤害")]
	[Category("法术场通用配置|出生预警")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bPreciseDodgeFilterTeammate")]
	public bool bPreciseDodgeFilterTeammate
	{
		get
		{
			CheckDestroyed();
			if (!bPreciseDodgeFilterTeammate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bPreciseDodgeFilterTeammate");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bPreciseDodgeFilterTeammate_Offset), 0, bPreciseDodgeFilterTeammate_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bPreciseDodgeFilterTeammate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bPreciseDodgeFilterTeammate");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bPreciseDodgeFilterTeammate_Offset), 0, bPreciseDodgeFilterTeammate_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("进入事件")]
	[Category("法术场通用配置|事件配置")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:EnterEvents")]
	public TArrayReadWrite<MFEvent> EnterEvents
	{
		get
		{
			CheckDestroyed();
			if (!EnterEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:EnterEvents");
				return null;
			}
			if (EnterEvents_Marshaler == null)
			{
				EnterEvents_Marshaler = new TArrayReadWriteMarshaler<MFEvent>(1, EnterEvents_PropertyAddress, CachedMarshalingDelegates<MFEvent, MFEvent>.FromNative, CachedMarshalingDelegates<MFEvent, MFEvent>.ToNative);
			}
			return EnterEvents_Marshaler.FromNative(IntPtr.Add(base.Address, EnterEvents_Offset));
		}
	}

	[Category("法术场通用配置|事件配置")]
	[DisplayName("退出事件")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:ExitEvents")]
	public TArrayReadWrite<MFEvent> ExitEvents
	{
		get
		{
			CheckDestroyed();
			if (!ExitEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:ExitEvents");
				return null;
			}
			if (ExitEvents_Marshaler == null)
			{
				ExitEvents_Marshaler = new TArrayReadWriteMarshaler<MFEvent>(1, ExitEvents_PropertyAddress, CachedMarshalingDelegates<MFEvent, MFEvent>.FromNative, CachedMarshalingDelegates<MFEvent, MFEvent>.ToNative);
			}
			return ExitEvents_Marshaler.FromNative(IntPtr.Add(base.Address, ExitEvents_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("出生事件")]
	[Category("法术场通用配置|事件配置")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BirthEvents")]
	public TArrayReadWrite<MFEvent> BirthEvents
	{
		get
		{
			CheckDestroyed();
			if (!BirthEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BirthEvents");
				return null;
			}
			if (BirthEvents_Marshaler == null)
			{
				BirthEvents_Marshaler = new TArrayReadWriteMarshaler<MFEvent>(1, BirthEvents_PropertyAddress, CachedMarshalingDelegates<MFEvent, MFEvent>.FromNative, CachedMarshalingDelegates<MFEvent, MFEvent>.ToNative);
			}
			return BirthEvents_Marshaler.FromNative(IntPtr.Add(base.Address, BirthEvents_Offset));
		}
	}

	[Category("法术场通用配置|事件配置")]
	[EditAnywhere]
	[DisplayName("消亡事件")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DieEvents")]
	public TArrayReadWrite<MFEvent> DieEvents
	{
		get
		{
			CheckDestroyed();
			if (!DieEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DieEvents");
				return null;
			}
			if (DieEvents_Marshaler == null)
			{
				DieEvents_Marshaler = new TArrayReadWriteMarshaler<MFEvent>(1, DieEvents_PropertyAddress, CachedMarshalingDelegates<MFEvent, MFEvent>.FromNative, CachedMarshalingDelegates<MFEvent, MFEvent>.ToNative);
			}
			return DieEvents_Marshaler.FromNative(IntPtr.Add(base.Address, DieEvents_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("法术场通用配置|命中破碎物效果")]
	[DisplayName("打击力度")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitDestructibleStrengthLevel")]
	public EGSHitDestructibleStrengthLevel HitDestructibleStrengthLevel
	{
		get
		{
			CheckDestroyed();
			if (!HitDestructibleStrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitDestructibleStrengthLevel");
				return EGSHitDestructibleStrengthLevel.None;
			}
			return EnumMarshaler<EGSHitDestructibleStrengthLevel>.FromNative(IntPtr.Add(base.Address, HitDestructibleStrengthLevel_Offset), 0, HitDestructibleStrengthLevel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitDestructibleStrengthLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitDestructibleStrengthLevel");
			}
			else
			{
				EnumMarshaler<EGSHitDestructibleStrengthLevel>.ToNative(IntPtr.Add(base.Address, HitDestructibleStrengthLevel_Offset), 0, HitDestructibleStrengthLevel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("法术场通用配置|命中破碎物效果")]
	[EditAnywhere]
	[DisplayName("打击方向类型")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitDestructibleDirectionType")]
	public EGSHitDestructibleDirection HitDestructibleDirectionType
	{
		get
		{
			CheckDestroyed();
			if (!HitDestructibleDirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitDestructibleDirectionType");
				return EGSHitDestructibleDirection.DestructibleDirection;
			}
			return EnumMarshaler<EGSHitDestructibleDirection>.FromNative(IntPtr.Add(base.Address, HitDestructibleDirectionType_Offset), 0, HitDestructibleDirectionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HitDestructibleDirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitDestructibleDirectionType");
			}
			else
			{
				EnumMarshaler<EGSHitDestructibleDirection>.ToNative(IntPtr.Add(base.Address, HitDestructibleDirectionType_Offset), 0, HitDestructibleDirectionType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("法术场通用配置|命中破碎物效果")]
	[DisplayName("对自身触发效果")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitDestructibleEffectsTriggerForSelf")]
	public TArrayReadWrite<int> HitDestructibleEffectsTriggerForSelf
	{
		get
		{
			CheckDestroyed();
			if (!HitDestructibleEffectsTriggerForSelf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:HitDestructibleEffectsTriggerForSelf");
				return null;
			}
			if (HitDestructibleEffectsTriggerForSelf_Marshaler == null)
			{
				HitDestructibleEffectsTriggerForSelf_Marshaler = new TArrayReadWriteMarshaler<int>(1, HitDestructibleEffectsTriggerForSelf_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return HitDestructibleEffectsTriggerForSelf_Marshaler.FromNative(IntPtr.Add(base.Address, HitDestructibleEffectsTriggerForSelf_Offset));
		}
	}

	[DisplayName("进入触发事件列表")]
	[UProperty]
	[EditAnywhere]
	[Category("法术场通用配置|已废弃")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverlapBeginEvents")]
	public TArrayReadWrite<MFOverlapEvent> OverlapBeginEvents
	{
		get
		{
			CheckDestroyed();
			if (!OverlapBeginEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverlapBeginEvents");
				return null;
			}
			if (OverlapBeginEvents_Marshaler == null)
			{
				OverlapBeginEvents_Marshaler = new TArrayReadWriteMarshaler<MFOverlapEvent>(1, OverlapBeginEvents_PropertyAddress, CachedMarshalingDelegates<MFOverlapEvent, MFOverlapEvent>.FromNative, CachedMarshalingDelegates<MFOverlapEvent, MFOverlapEvent>.ToNative);
			}
			return OverlapBeginEvents_Marshaler.FromNative(IntPtr.Add(base.Address, OverlapBeginEvents_Offset));
		}
	}

	[EditAnywhere]
	[DisplayName("退出触发事件列表")]
	[UProperty]
	[Category("法术场通用配置|已废弃")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverlapEndEvents")]
	public TArrayReadWrite<MFOverlapEvent> OverlapEndEvents
	{
		get
		{
			CheckDestroyed();
			if (!OverlapEndEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:OverlapEndEvents");
				return null;
			}
			if (OverlapEndEvents_Marshaler == null)
			{
				OverlapEndEvents_Marshaler = new TArrayReadWriteMarshaler<MFOverlapEvent>(1, OverlapEndEvents_PropertyAddress, CachedMarshalingDelegates<MFOverlapEvent, MFOverlapEvent>.FromNative, CachedMarshalingDelegates<MFOverlapEvent, MFOverlapEvent>.ToNative);
			}
			return OverlapEndEvents_Marshaler.FromNative(IntPtr.Add(base.Address, OverlapEndEvents_Offset));
		}
	}

	[UProperty]
	[Category("法术场通用配置|已废弃")]
	[DisplayName("出生触发事件列表")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BornEvents")]
	public TArrayReadWrite<MFOverlapEvent> BornEvents
	{
		get
		{
			CheckDestroyed();
			if (!BornEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:BornEvents");
				return null;
			}
			if (BornEvents_Marshaler == null)
			{
				BornEvents_Marshaler = new TArrayReadWriteMarshaler<MFOverlapEvent>(1, BornEvents_PropertyAddress, CachedMarshalingDelegates<MFOverlapEvent, MFOverlapEvent>.FromNative, CachedMarshalingDelegates<MFOverlapEvent, MFOverlapEvent>.ToNative);
			}
			return BornEvents_Marshaler.FromNative(IntPtr.Add(base.Address, BornEvents_Offset));
		}
	}

	[DisplayName("消亡触发事件列表")]
	[UProperty]
	[EditAnywhere]
	[Category("法术场通用配置|已废弃")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DeadEvents")]
	public TArrayReadWrite<MFOverlapEvent> DeadEvents
	{
		get
		{
			CheckDestroyed();
			if (!DeadEvents_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DeadEvents");
				return null;
			}
			if (DeadEvents_Marshaler == null)
			{
				DeadEvents_Marshaler = new TArrayReadWriteMarshaler<MFOverlapEvent>(1, DeadEvents_PropertyAddress, CachedMarshalingDelegates<MFOverlapEvent, MFOverlapEvent>.FromNative, CachedMarshalingDelegates<MFOverlapEvent, MFOverlapEvent>.ToNative);
			}
			return DeadEvents_Marshaler.FromNative(IntPtr.Add(base.Address, DeadEvents_Offset));
		}
	}

	[Category("Magic Field Direction Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionUsage")]
	public EMagicFieldDirectionUsage DirectionUsage
	{
		get
		{
			CheckDestroyed();
			if (!DirectionUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionUsage");
				return EMagicFieldDirectionUsage.None;
			}
			return EnumMarshaler<EMagicFieldDirectionUsage>.FromNative(IntPtr.Add(base.Address, DirectionUsage_Offset), 0, DirectionUsage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DirectionUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionUsage");
			}
			else
			{
				EnumMarshaler<EMagicFieldDirectionUsage>.ToNative(IntPtr.Add(base.Address, DirectionUsage_Offset), 0, DirectionUsage_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "DirectionUsage != EMagicFieldDirectionUsage::None")]
	[Category("Magic Field Direction Config")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionType")]
	public EMagicFieldDirectionType DirectionType
	{
		get
		{
			CheckDestroyed();
			if (!DirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionType");
				return EMagicFieldDirectionType.None;
			}
			return EnumMarshaler<EMagicFieldDirectionType>.FromNative(IntPtr.Add(base.Address, DirectionType_Offset), 0, DirectionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DirectionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionType");
			}
			else
			{
				EnumMarshaler<EMagicFieldDirectionType>.ToNative(IntPtr.Add(base.Address, DirectionType_Offset), 0, DirectionType_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "DirectionType == EMagicFieldDirectionType::Radial || DirectionType == EMagicFieldDirectionType::Spiral")]
	[Category("Magic Field Direction Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionTypeDetail")]
	public EMagicFieldDirectionTypeDetail DirectionTypeDetail
	{
		get
		{
			CheckDestroyed();
			if (!DirectionTypeDetail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionTypeDetail");
				return EMagicFieldDirectionTypeDetail.Positive;
			}
			return EnumMarshaler<EMagicFieldDirectionTypeDetail>.FromNative(IntPtr.Add(base.Address, DirectionTypeDetail_Offset), 0, DirectionTypeDetail_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DirectionTypeDetail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionTypeDetail");
			}
			else
			{
				EnumMarshaler<EMagicFieldDirectionTypeDetail>.ToNative(IntPtr.Add(base.Address, DirectionTypeDetail_Offset), 0, DirectionTypeDetail_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Magic Field Direction Config")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AnchorPointTag")]
	public FName AnchorPointTag
	{
		get
		{
			CheckDestroyed();
			if (!AnchorPointTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AnchorPointTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AnchorPointTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnchorPointTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:AnchorPointTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AnchorPointTag_Offset), value);
			}
		}
	}

	[Category("Magic Field Direction Config")]
	[DisplayName("任意方向单位效果列表")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionEffects")]
	public TArrayReadWrite<MFDirectionEffect> DirectionEffects
	{
		get
		{
			CheckDestroyed();
			if (!DirectionEffects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DirectionEffects");
				return null;
			}
			if (DirectionEffects_Marshaler == null)
			{
				DirectionEffects_Marshaler = new TArrayReadWriteMarshaler<MFDirectionEffect>(1, DirectionEffects_PropertyAddress, CachedMarshalingDelegates<MFDirectionEffect, MFDirectionEffect>.FromNative, CachedMarshalingDelegates<MFDirectionEffect, MFDirectionEffect>.ToNative);
			}
			return DirectionEffects_Marshaler.FromNative(IntPtr.Add(base.Address, DirectionEffects_Offset));
		}
	}

	[Category("RT Config")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("是否启用安身术RT")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableShelterRT")]
	public bool bEnableShelterRT
	{
		get
		{
			CheckDestroyed();
			if (!bEnableShelterRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableShelterRT");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableShelterRT_Offset), 0, bEnableShelterRT_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableShelterRT_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableShelterRT");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableShelterRT_Offset), 0, bEnableShelterRT_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("是否使用全局特效")]
	[Category("Disp")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableGlobalFX")]
	public bool bEnableGlobalFX
	{
		get
		{
			CheckDestroyed();
			if (!bEnableGlobalFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableGlobalFX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableGlobalFX_Offset), 0, bEnableGlobalFX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableGlobalFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnableGlobalFX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableGlobalFX_Offset), 0, bEnableGlobalFX_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("全局特效标识Tag")]
	[Category("Disp")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:GlobalFXTag")]
	public FGameplayTag GlobalFXTag
	{
		get
		{
			CheckDestroyed();
			if (!GlobalFXTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:GlobalFXTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, GlobalFXTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GlobalFXTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:GlobalFXTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, GlobalFXTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("附加功能Mask")]
	[Category("Optimize")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:ExtAbilityMask")]
	public FProjectileExtAbilityMask ExtAbilityMask
	{
		get
		{
			CheckDestroyed();
			if (!ExtAbilityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:ExtAbilityMask");
				return default(FProjectileExtAbilityMask);
			}
			return BlittableTypeMarshaler<FProjectileExtAbilityMask>.FromNative(IntPtr.Add(base.Address, ExtAbilityMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtAbilityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:ExtAbilityMask");
			}
			else
			{
				BlittableTypeMarshaler<FProjectileExtAbilityMask>.ToNative(IntPtr.Add(base.Address, ExtAbilityMask_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("屏蔽功能Mask")]
	[Category("Optimize")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DisableAbilityMask")]
	public FProjectileDisableAbilityMask DisableAbilityMask
	{
		get
		{
			CheckDestroyed();
			if (!DisableAbilityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DisableAbilityMask");
				return default(FProjectileDisableAbilityMask);
			}
			return BlittableTypeMarshaler<FProjectileDisableAbilityMask>.FromNative(IntPtr.Add(base.Address, DisableAbilityMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DisableAbilityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:DisableAbilityMask");
			}
			else
			{
				BlittableTypeMarshaler<FProjectileDisableAbilityMask>.ToNative(IntPtr.Add(base.Address, DisableAbilityMask_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Optimize")]
	[UProperty]
	[DisplayName("强制使用ProjectileMovementComp作为移动组件")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bForceUseProjectileMovementComp")]
	public bool bForceUseProjectileMovementComp
	{
		get
		{
			CheckDestroyed();
			if (!bForceUseProjectileMovementComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bForceUseProjectileMovementComp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bForceUseProjectileMovementComp_Offset), 0, bForceUseProjectileMovementComp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bForceUseProjectileMovementComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bForceUseProjectileMovementComp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bForceUseProjectileMovementComp_Offset), 0, bForceUseProjectileMovementComp_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Optimize")]
	[DisplayName("启用SpawnFinished蓝图事件")]
	[UProperty]
	[Tooltip("默认关闭，开启会增加Spawn的性能消耗，非必要不开启")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bNotify_SpawnFinished")]
	public bool bNotify_SpawnFinished
	{
		get
		{
			CheckDestroyed();
			if (!bNotify_SpawnFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bNotify_SpawnFinished");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bNotify_SpawnFinished_Offset), 0, bNotify_SpawnFinished_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bNotify_SpawnFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bNotify_SpawnFinished");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bNotify_SpawnFinished_Offset), 0, bNotify_SpawnFinished_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Optimize")]
	[DisplayName("启用DBC组件")]
	[Tooltip("默认关闭，开启会增加Spawn的性能消耗，非必要不开启")]
	[USharpPath("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnable_DBCComp")]
	public bool bEnable_DBCComp
	{
		get
		{
			CheckDestroyed();
			if (!bEnable_DBCComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnable_DBCComp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnable_DBCComp_Offset), 0, bEnable_DBCComp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnable_DBCComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProjectileConfigInfoComp:bEnable_DBCComp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnable_DBCComp_Offset), 0, bEnable_DBCComp_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		CheckCompProfileName_Bullet = Type_CheckCompProfileName_Bullet.NormalBullet;
		if (temp_SweepCheckChannel == ECollisionChannel.ECC_WorldStatic)
		{
			temp_SweepCheckChannel = ECollisionChannel.ECC_GameTraceChannel1;
		}
		SweepCheckChannel = temp_SweepCheckChannel;
		HitCheckConf = new FHitCheckConf(EHitActionDir.Default, ESweepCheckHitFilterType.NotInSameTeam, IsRenderDebugShape: false);
		AttackWarningExtendSize = 0f;
		bEnableAttackWarning = true;
		NeedCheckWorldStatic = true;
		CheckCompProfileName_MagicField = Type_CheckCompProfileName_MagicField.NormalMagicField;
		BornEffectDelayTime = 0f;
		BornAttackWarningTime = 0f;
		bAttackWarningTriggerPreciseDodge = false;
		bPreciseDodgeFilterTeammate = true;
		FadeOut_AkEvent_LaserEnd = 500;
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_ProjectileBasicData bUC_ProjectileBasicData = RequireWritableData<BUC_ProjectileBasicData>(Owner);
		if (bUC_ProjectileBasicData != null)
		{
			bUC_ProjectileBasicData.CheckShapeType = CheckShapeType;
			bUC_ProjectileBasicData.ProjectileSpecificFlags = SpecificFlags;
			bUC_ProjectileBasicData.bNotify_SpawnFinished = bNotify_SpawnFinished;
		}
		b1.BUC_ProjectileDispInteractData bUC_ProjectileDispInteractData = RequireWritableData<b1.BUC_ProjectileDispInteractData>(Owner);
		if (bUC_ProjectileDispInteractData != null)
		{
			bUC_ProjectileDispInteractData.Interact_Start_SphereRadius = Interact_Start_SphereRadius;
			bUC_ProjectileDispInteractData.Interact_Start_LocalTransform = Interact_Start_LocalTransform;
			bUC_ProjectileDispInteractData.Interact_End_SphereRadius = Interact_End_SphereRadius;
			bUC_ProjectileDispInteractData.Interact_End_LocalTransform = Interact_End_LocalTransform;
		}
		BUC_ProjectileAudioData bUC_ProjectileAudioData = RequireWritableData<BUC_ProjectileAudioData>(Owner);
		if (bUC_ProjectileAudioData != null)
		{
			bUC_ProjectileAudioData.LoopEvent = LoopEvent;
			bUC_ProjectileAudioData.DeadEvent = DeadEvent;
		}
		BUC_ProjectileWindBrokenAudioData bUC_ProjectileWindBrokenAudioData = RequireWritableData<BUC_ProjectileWindBrokenAudioData>(Owner);
		if (bUC_ProjectileWindBrokenAudioData != null)
		{
			bUC_ProjectileWindBrokenAudioData.AkEvent = WindBrokenAudio;
			bUC_ProjectileWindBrokenAudioData.TriggerDist = TriggerDist_WindBroken;
			bUC_ProjectileWindBrokenAudioData.bEnableDebug_WindBrokenAudio = bEnableDebug_WindBrokenAudio;
		}
		RequireWritableData<b1.BUC_ProceduralEnvInteractionTriggerData>(Owner)?.CopyBPDataToData(bEnable, TraceDelay, TraceLength, Size, SampleCollectionProtectTime, OverrideSurfaceType, OverrideSurfacePersistTime, OverrideSurfaceFXActorTag, bDrawDebug, DebugDrawOffset);
		BUC_DestructibleDestroyEffectTriggerData bUC_DestructibleDestroyEffectTriggerData = RequireWritableData<BUC_DestructibleDestroyEffectTriggerData>(Owner);
		if (bUC_DestructibleDestroyEffectTriggerData != null)
		{
			bUC_DestructibleDestroyEffectTriggerData.DestructibleTag = DestructibleTag;
			bUC_DestructibleDestroyEffectTriggerData.EffectIDs = EffectIDs.ToList();
			bUC_DestructibleDestroyEffectTriggerData.BuffIDs = BuffIDs.ToList();
		}
		BUC_ProjectilePhysicData bUC_ProjectilePhysicData = RequireWritableData<BUC_ProjectilePhysicData>(Owner);
		if (bUC_ProjectilePhysicData != null)
		{
			bUC_ProjectilePhysicData.Default_ProfileName_Bullet = ProjectileConfigConst.TypeMap_CheckCompProfileName_Bullet[CheckCompProfileName_Bullet];
			bUC_ProjectilePhysicData.Default_ProfileName_MagicField = ProjectileConfigConst.TypeMap_CheckCompProfileName_MagicField[CheckCompProfileName_MagicField];
		}
		BUC_ObjActorMovementData bUC_ObjActorMovementData = RequireWritableData<BUC_ObjActorMovementData>(Owner);
		if (bUC_ObjActorMovementData != null)
		{
			bUC_ObjActorMovementData.bForceUseProjectileMovementComp = bForceUseProjectileMovementComp;
		}
		if (Owner is BGUBulletBaseCS)
		{
			BUC_BulletMatMergeData bUC_BulletMatMergeData = RequireWritableData<BUC_BulletMatMergeData>(Owner);
			if (MPC != null)
			{
				bUC_BulletMatMergeData.MPC = MPC;
			}
			BUC_ProjectileLaserData bUC_ProjectileLaserData = RequireWritableData<BUC_ProjectileLaserData>(Owner);
			if (bUC_ProjectileLaserData != null)
			{
				bUC_ProjectileLaserData.bDrawDebug = bDrawDebug_Laser;
				bUC_ProjectileLaserData.AkEvent_Laser = AkEvent_LaserEnd;
				bUC_ProjectileLaserData.FadeOut_AkEvent_LaserEnd = FadeOut_AkEvent_LaserEnd;
				bUC_ProjectileLaserData.AkEvent_LaserHitItem = AkEvent_LaserHitItem;
			}
			BUC_BulletSweepCheckData bUC_BulletSweepCheckData = RequireWritableData<BUC_BulletSweepCheckData>(Owner);
			if (bUC_BulletSweepCheckData != null)
			{
				bUC_BulletSweepCheckData.NeedCheckWorldStatic_BP = NeedCheckWorldStatic;
				bUC_BulletSweepCheckData.SweepCheckChannel = SweepCheckChannel;
				bUC_BulletSweepCheckData.HitCheckConf = HitCheckConf;
				bUC_BulletSweepCheckData.AttackWarningExtendSize = AttackWarningExtendSize;
				bUC_BulletSweepCheckData.AttackWarningOffset = AttackWarningOffset;
				bUC_BulletSweepCheckData.bEnableAttackWarning = bEnableAttackWarning;
				bUC_BulletSweepCheckData.bEnableDebug = bEnableDebug;
				bUC_BulletSweepCheckData.bHitItemAttach = bHitItemAttach;
				bUC_BulletSweepCheckData.HitItemAttachTime = HitItemAttachTime;
				bUC_BulletSweepCheckData.bHitChrAttach = bHitChrAttach;
				bUC_BulletSweepCheckData.HitChrAttachTime = HitChrAttachTime;
				bUC_BulletSweepCheckData.AttachOffset = AttachOffset;
			}
			BUC_BulletDispData bUC_BulletDispData = RequireWritableData<BUC_BulletDispData>(Owner);
			if (bUC_BulletDispData != null)
			{
				bUC_BulletDispData.bUseGlobalFX = bEnableGlobalFX;
				bUC_BulletDispData.FXTag = GlobalFXTag.TagName;
			}
			BUC_BulletDonutAudioData bUC_BulletDonutAudioData = RequireWritableData<BUC_BulletDonutAudioData>(Owner);
			if (bUC_BulletDonutAudioData != null)
			{
				bUC_BulletDonutAudioData.DonutAudio = DonutAudio;
				bUC_BulletDonutAudioData.DonutAudioLocationType = DonutAudioLocationType;
				bUC_BulletDonutAudioData.StopMode = DonutAudioStopMode;
				bUC_BulletDonutAudioData.StopTimeMs = DonutAudioStopTimeMs;
				bUC_BulletDonutAudioData.FadeOutTimeMs = DonutAudioFadeOutTimeMs;
				bUC_BulletDonutAudioData.CurveInterpolation = DonutAudioCurveInterpolation;
			}
		}
		if (!(Owner is BGUMagicFieldBaseCS))
		{
			return;
		}
		BUC_MFEffectData bUC_MFEffectData = RequireWritableData<BUC_MFEffectData>(Owner);
		if (bUC_MFEffectData != null)
		{
			bUC_MFEffectData.bDebug = bDebug;
		}
		BUC_MFOverlapData bUC_MFOverlapData = RequireWritableData<BUC_MFOverlapData>(Owner);
		if (bUC_MFOverlapData != null)
		{
			foreach (MFEvent enterEvent in EnterEvents)
			{
				MFEvent InEvent = enterEvent;
				bUC_MFOverlapData.EnterEvents.Add(new MFEventForData(in InEvent));
			}
			foreach (MFEvent exitEvent in ExitEvents)
			{
				MFEvent InEvent2 = exitEvent;
				bUC_MFOverlapData.ExitEvents.Add(new MFEventForData(in InEvent2));
			}
			foreach (MFEvent birthEvent in BirthEvents)
			{
				MFEvent InEvent3 = birthEvent;
				bUC_MFOverlapData.BirthEvents.Add(new MFEventForData(in InEvent3));
			}
			foreach (MFEvent dieEvent in DieEvents)
			{
				MFEvent InEvent4 = dieEvent;
				bUC_MFOverlapData.DieEvents.Add(new MFEventForData(in InEvent4));
			}
			bUC_MFOverlapData.FieldBuffList.AddRange(FieldBuffList);
			if (BornEffectDelayTime < 0f)
			{
				BornEffectDelayTime = 0f;
			}
			if (BornAttackWarningTime < 0f)
			{
				BornAttackWarningTime = 0f;
			}
			else if (BornAttackWarningTime > BornEffectDelayTime)
			{
				BornAttackWarningTime = BornEffectDelayTime;
			}
			bUC_MFOverlapData.OverlapType = MagicFieldOverlapType;
			bUC_MFOverlapData.bNeedAvoid = bCanHandleAvoidance;
			bUC_MFOverlapData.BornEffectDelayTime = BornEffectDelayTime;
			bUC_MFOverlapData.BornAttackWarningStartTime = BornEffectDelayTime - BornAttackWarningTime;
			bUC_MFOverlapData.bAttackWarningTriggerPreciseDodge = bAttackWarningTriggerPreciseDodge;
			bUC_MFOverlapData.bPreciseDodgeFilterTeammate = bPreciseDodgeFilterTeammate;
			bUC_MFOverlapData.bUseSoftEdge = bUseSoftEdge;
			bUC_MFOverlapData.HitDestructibleStrengthLevel = HitDestructibleStrengthLevel;
			bUC_MFOverlapData.HitDestructibleDirectionType = HitDestructibleDirectionType;
			foreach (int item in HitDestructibleEffectsTriggerForSelf.ToList())
			{
				bUC_MFOverlapData.HitDestructibleEffectsTriggerForSelf.Add(item);
			}
		}
		b1.BUC_MFDirectionData bUC_MFDirectionData = RequireWritableData<b1.BUC_MFDirectionData>(Owner);
		if (bUC_MFDirectionData != null)
		{
			bUC_MFDirectionData.MFDirectionUsage = DirectionUsage;
			bUC_MFDirectionData.MFDirectionType = DirectionType;
			bUC_MFDirectionData.MFDirectionTypeDetail = DirectionTypeDetail;
			bUC_MFDirectionData.AnchorPointTag = AnchorPointTag;
			foreach (MFDirectionEffect directionEffect in DirectionEffects)
			{
				MFDirectionEffect DirectionEffect = directionEffect;
				bUC_MFDirectionData.DirectionEffects.Add(DirectionEffect.TriggerEvent, new MFDirectionEffectForData(in DirectionEffect));
			}
		}
		BUC_MFDispData bUC_MFDispData = RequireWritableData<BUC_MFDispData>(Owner);
		if (bUC_MFDispData != null)
		{
			bUC_MFDispData.bEnableShelterRT = bEnableShelterRT;
			bUC_MFDispData.bUseGlobalFX = bEnableGlobalFX;
			bUC_MFDispData.FXTag = GlobalFXTag.TagName;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProjectileConfigInfoComp");
		NativeReflection.GetPropertyRef(ref CheckShapeType_PropertyAddress, unrealStruct, "CheckShapeType");
		CheckShapeType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckShapeType");
		CheckShapeType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckShapeType", Classes.FEnumProperty);
		SpecificFlags_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecificFlags");
		SpecificFlags_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecificFlags", Classes.FIntProperty);
		LocalTrans_LineTracePoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LocalTrans_LineTracePoint");
		LocalTrans_LineTracePoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LocalTrans_LineTracePoint", Classes.FStructProperty);
		Interact_Start_SphereRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Interact_Start_SphereRadius");
		Interact_Start_SphereRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Interact_Start_SphereRadius", Classes.FFloatProperty);
		Interact_Start_LocalTransform_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Interact_Start_LocalTransform");
		Interact_Start_LocalTransform_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Interact_Start_LocalTransform", Classes.FStructProperty);
		Interact_End_SphereRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Interact_End_SphereRadius");
		Interact_End_SphereRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Interact_End_SphereRadius", Classes.FFloatProperty);
		Interact_End_LocalTransform_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Interact_End_LocalTransform");
		Interact_End_LocalTransform_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Interact_End_LocalTransform", Classes.FStructProperty);
		WindBrokenAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WindBrokenAudio");
		WindBrokenAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WindBrokenAudio", Classes.FObjectProperty);
		TriggerDist_WindBroken_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerDist_WindBroken");
		TriggerDist_WindBroken_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerDist_WindBroken", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebug_WindBrokenAudio_PropertyAddress, unrealStruct, "bEnableDebug_WindBrokenAudio");
		bEnableDebug_WindBrokenAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDebug_WindBrokenAudio");
		bEnableDebug_WindBrokenAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDebug_WindBrokenAudio", Classes.FBoolProperty);
		DonutAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DonutAudio");
		DonutAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DonutAudio", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DonutAudioLocationType_PropertyAddress, unrealStruct, "DonutAudioLocationType");
		DonutAudioLocationType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DonutAudioLocationType");
		DonutAudioLocationType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DonutAudioLocationType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DonutAudioStopMode_PropertyAddress, unrealStruct, "DonutAudioStopMode");
		DonutAudioStopMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DonutAudioStopMode");
		DonutAudioStopMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DonutAudioStopMode", Classes.FEnumProperty);
		DonutAudioStopTimeMs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DonutAudioStopTimeMs");
		DonutAudioStopTimeMs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DonutAudioStopTimeMs", Classes.FIntProperty);
		DonutAudioFadeOutTimeMs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DonutAudioFadeOutTimeMs");
		DonutAudioFadeOutTimeMs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DonutAudioFadeOutTimeMs", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref DonutAudioCurveInterpolation_PropertyAddress, unrealStruct, "DonutAudioCurveInterpolation");
		DonutAudioCurveInterpolation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DonutAudioCurveInterpolation");
		DonutAudioCurveInterpolation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DonutAudioCurveInterpolation", Classes.FEnumProperty);
		LoopEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LoopEvent");
		LoopEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LoopEvent", Classes.FStructProperty);
		DeadEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DeadEvent");
		DeadEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DeadEvent", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bEnable_PropertyAddress, unrealStruct, "bEnable");
		bEnable_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnable");
		bEnable_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnable", Classes.FBoolProperty);
		TraceDelay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceDelay");
		TraceDelay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceDelay", Classes.FFloatProperty);
		TraceLength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceLength");
		TraceLength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceLength", Classes.FFloatProperty);
		Size_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Size");
		Size_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Size", Classes.FFloatProperty);
		SampleCollectionProtectTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SampleCollectionProtectTime");
		SampleCollectionProtectTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SampleCollectionProtectTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref OverrideSurfaceType_PropertyAddress, unrealStruct, "OverrideSurfaceType");
		OverrideSurfaceType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverrideSurfaceType");
		OverrideSurfaceType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverrideSurfaceType", Classes.FEnumProperty);
		OverrideSurfacePersistTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverrideSurfacePersistTime");
		OverrideSurfacePersistTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverrideSurfacePersistTime", Classes.FFloatProperty);
		OverrideSurfaceFXActorTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverrideSurfaceFXActorTag");
		OverrideSurfaceFXActorTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverrideSurfaceFXActorTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bDrawDebug_PropertyAddress, unrealStruct, "bDrawDebug");
		bDrawDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDrawDebug");
		bDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDrawDebug", Classes.FBoolProperty);
		DebugDrawOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DebugDrawOffset");
		DebugDrawOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DebugDrawOffset", Classes.FFloatProperty);
		DestructibleTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestructibleTag");
		DestructibleTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestructibleTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref EffectIDs_PropertyAddress, unrealStruct, "EffectIDs");
		EffectIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EffectIDs");
		EffectIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EffectIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BuffIDs_PropertyAddress, unrealStruct, "BuffIDs");
		BuffIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffIDs");
		BuffIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref NeedCheckWorldStatic_PropertyAddress, unrealStruct, "NeedCheckWorldStatic");
		NeedCheckWorldStatic_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedCheckWorldStatic");
		NeedCheckWorldStatic_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedCheckWorldStatic", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SweepCheckChannel_PropertyAddress, unrealStruct, "SweepCheckChannel");
		SweepCheckChannel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SweepCheckChannel");
		SweepCheckChannel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SweepCheckChannel", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CheckCompProfileName_Bullet_PropertyAddress, unrealStruct, "CheckCompProfileName_Bullet");
		CheckCompProfileName_Bullet_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckCompProfileName_Bullet");
		CheckCompProfileName_Bullet_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckCompProfileName_Bullet", Classes.FEnumProperty);
		HitCheckConf_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitCheckConf");
		HitCheckConf_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitCheckConf", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bEnableAttackWarning_PropertyAddress, unrealStruct, "bEnableAttackWarning");
		bEnableAttackWarning_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableAttackWarning");
		bEnableAttackWarning_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableAttackWarning", Classes.FBoolProperty);
		AttackWarningExtendSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttackWarningExtendSize");
		AttackWarningExtendSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttackWarningExtendSize", Classes.FFloatProperty);
		AttackWarningOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttackWarningOffset");
		AttackWarningOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttackWarningOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebug_PropertyAddress, unrealStruct, "bEnableDebug");
		bEnableDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableDebug");
		bEnableDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHitChrAttach_PropertyAddress, unrealStruct, "bHitChrAttach");
		bHitChrAttach_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bHitChrAttach");
		bHitChrAttach_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bHitChrAttach", Classes.FBoolProperty);
		HitChrAttachTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitChrAttachTime");
		HitChrAttachTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitChrAttachTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bHitItemAttach_PropertyAddress, unrealStruct, "bHitItemAttach");
		bHitItemAttach_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bHitItemAttach");
		bHitItemAttach_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bHitItemAttach", Classes.FBoolProperty);
		HitItemAttachTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitItemAttachTime");
		HitItemAttachTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitItemAttachTime", Classes.FFloatProperty);
		AttachOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttachOffset");
		AttachOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttachOffset", Classes.FFloatProperty);
		MPC_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MPC");
		MPC_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MPC", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bDrawDebug_Laser_PropertyAddress, unrealStruct, "bDrawDebug_Laser");
		bDrawDebug_Laser_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDrawDebug_Laser");
		bDrawDebug_Laser_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDrawDebug_Laser", Classes.FBoolProperty);
		AkEvent_LaserEnd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEvent_LaserEnd");
		AkEvent_LaserEnd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEvent_LaserEnd", Classes.FObjectProperty);
		FadeOut_AkEvent_LaserEnd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FadeOut_AkEvent_LaserEnd");
		FadeOut_AkEvent_LaserEnd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FadeOut_AkEvent_LaserEnd", Classes.FIntProperty);
		AkEvent_LaserHitItem_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkEvent_LaserHitItem");
		AkEvent_LaserHitItem_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkEvent_LaserHitItem", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CheckCompProfileName_MagicField_PropertyAddress, unrealStruct, "CheckCompProfileName_MagicField");
		CheckCompProfileName_MagicField_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckCompProfileName_MagicField");
		CheckCompProfileName_MagicField_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckCompProfileName_MagicField", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MagicFieldOverlapType_PropertyAddress, unrealStruct, "MagicFieldOverlapType");
		MagicFieldOverlapType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MagicFieldOverlapType");
		MagicFieldOverlapType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MagicFieldOverlapType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bDebug_PropertyAddress, unrealStruct, "bDebug");
		bDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDebug");
		bDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bCanHandleAvoidance_PropertyAddress, unrealStruct, "bCanHandleAvoidance");
		bCanHandleAvoidance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bCanHandleAvoidance");
		bCanHandleAvoidance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bCanHandleAvoidance", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseSoftEdge_PropertyAddress, unrealStruct, "bUseSoftEdge");
		bUseSoftEdge_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseSoftEdge");
		bUseSoftEdge_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseSoftEdge", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref FieldBuffList_PropertyAddress, unrealStruct, "FieldBuffList");
		FieldBuffList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FieldBuffList");
		FieldBuffList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FieldBuffList", Classes.FArrayProperty);
		BornEffectDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BornEffectDelayTime");
		BornEffectDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BornEffectDelayTime", Classes.FFloatProperty);
		BornAttackWarningTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BornAttackWarningTime");
		BornAttackWarningTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BornAttackWarningTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bAttackWarningTriggerPreciseDodge_PropertyAddress, unrealStruct, "bAttackWarningTriggerPreciseDodge");
		bAttackWarningTriggerPreciseDodge_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAttackWarningTriggerPreciseDodge");
		bAttackWarningTriggerPreciseDodge_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAttackWarningTriggerPreciseDodge", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bPreciseDodgeFilterTeammate_PropertyAddress, unrealStruct, "bPreciseDodgeFilterTeammate");
		bPreciseDodgeFilterTeammate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bPreciseDodgeFilterTeammate");
		bPreciseDodgeFilterTeammate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bPreciseDodgeFilterTeammate", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnterEvents_PropertyAddress, unrealStruct, "EnterEvents");
		EnterEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnterEvents");
		EnterEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnterEvents", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ExitEvents_PropertyAddress, unrealStruct, "ExitEvents");
		ExitEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExitEvents");
		ExitEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExitEvents", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BirthEvents_PropertyAddress, unrealStruct, "BirthEvents");
		BirthEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BirthEvents");
		BirthEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BirthEvents", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DieEvents_PropertyAddress, unrealStruct, "DieEvents");
		DieEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DieEvents");
		DieEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DieEvents", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref HitDestructibleStrengthLevel_PropertyAddress, unrealStruct, "HitDestructibleStrengthLevel");
		HitDestructibleStrengthLevel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitDestructibleStrengthLevel");
		HitDestructibleStrengthLevel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitDestructibleStrengthLevel", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref HitDestructibleDirectionType_PropertyAddress, unrealStruct, "HitDestructibleDirectionType");
		HitDestructibleDirectionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitDestructibleDirectionType");
		HitDestructibleDirectionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitDestructibleDirectionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref HitDestructibleEffectsTriggerForSelf_PropertyAddress, unrealStruct, "HitDestructibleEffectsTriggerForSelf");
		HitDestructibleEffectsTriggerForSelf_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitDestructibleEffectsTriggerForSelf");
		HitDestructibleEffectsTriggerForSelf_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitDestructibleEffectsTriggerForSelf", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverlapBeginEvents_PropertyAddress, unrealStruct, "OverlapBeginEvents");
		OverlapBeginEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverlapBeginEvents");
		OverlapBeginEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverlapBeginEvents", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverlapEndEvents_PropertyAddress, unrealStruct, "OverlapEndEvents");
		OverlapEndEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverlapEndEvents");
		OverlapEndEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverlapEndEvents", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BornEvents_PropertyAddress, unrealStruct, "BornEvents");
		BornEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BornEvents");
		BornEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BornEvents", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DeadEvents_PropertyAddress, unrealStruct, "DeadEvents");
		DeadEvents_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DeadEvents");
		DeadEvents_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DeadEvents", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DirectionUsage_PropertyAddress, unrealStruct, "DirectionUsage");
		DirectionUsage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionUsage");
		DirectionUsage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionUsage", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DirectionType_PropertyAddress, unrealStruct, "DirectionType");
		DirectionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionType");
		DirectionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref DirectionTypeDetail_PropertyAddress, unrealStruct, "DirectionTypeDetail");
		DirectionTypeDetail_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionTypeDetail");
		DirectionTypeDetail_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionTypeDetail", Classes.FEnumProperty);
		AnchorPointTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnchorPointTag");
		AnchorPointTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnchorPointTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref DirectionEffects_PropertyAddress, unrealStruct, "DirectionEffects");
		DirectionEffects_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DirectionEffects");
		DirectionEffects_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DirectionEffects", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bEnableShelterRT_PropertyAddress, unrealStruct, "bEnableShelterRT");
		bEnableShelterRT_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableShelterRT");
		bEnableShelterRT_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableShelterRT", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableGlobalFX_PropertyAddress, unrealStruct, "bEnableGlobalFX");
		bEnableGlobalFX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableGlobalFX");
		bEnableGlobalFX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableGlobalFX", Classes.FBoolProperty);
		GlobalFXTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GlobalFXTag");
		GlobalFXTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GlobalFXTag", Classes.FStructProperty);
		ExtAbilityMask_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExtAbilityMask");
		ExtAbilityMask_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExtAbilityMask", Classes.FStructProperty);
		DisableAbilityMask_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DisableAbilityMask");
		DisableAbilityMask_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DisableAbilityMask", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bForceUseProjectileMovementComp_PropertyAddress, unrealStruct, "bForceUseProjectileMovementComp");
		bForceUseProjectileMovementComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bForceUseProjectileMovementComp");
		bForceUseProjectileMovementComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bForceUseProjectileMovementComp", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bNotify_SpawnFinished_PropertyAddress, unrealStruct, "bNotify_SpawnFinished");
		bNotify_SpawnFinished_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bNotify_SpawnFinished");
		bNotify_SpawnFinished_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bNotify_SpawnFinished", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnable_DBCComp_PropertyAddress, unrealStruct, "bEnable_DBCComp");
		bEnable_DBCComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnable_DBCComp");
		bEnable_DBCComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnable_DBCComp", Classes.FBoolProperty);
	}

	static BUS_ProjectileConfigInfoComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProjectileConfigInfoComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProjectileConfigInfoComp));
	}
}
