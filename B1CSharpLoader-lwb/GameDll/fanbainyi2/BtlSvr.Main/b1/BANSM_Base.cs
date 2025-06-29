using System;
using System.Collections.Generic;
using BtlB1;
using BtlShare;
using UnrealEngine.AnimationBlueprintLibrary;
using UnrealEngine.Blutility;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.BANSM_Base")]
internal class BANSM_Base : UAssetActionUtility
{
	private static bool NotifyStateClass_IsValid;

	private static int NotifyStateClass_Offset;

	private static bool NotifyClass_IsValid;

	private static int NotifyClass_Offset;

	private static bool NotifyTrackName_IsValid;

	private static int NotifyTrackName_Offset;

	private static bool NotifyTrackName_SweepCheck_IsValid;

	private static int NotifyTrackName_SweepCheck_Offset;

	private static bool NotifyTrackName_Socket_IsValid;

	private static int NotifyTrackName_Socket_Offset;

	private static bool AWTag_GenerateBySweepCheck_IsValid;

	private static int AWTag_GenerateBySweepCheck_Offset;

	private static bool AWTag_GenerateWithSocket_IsValid;

	private static int AWTag_GenerateWithSocket_Offset;

	private static bool MarkNotify_IsValid;

	private static IntPtr MarkNotify_FunctionAddress;

	private static int MarkNotify_ParamsSize;

	private static bool MarkNotify_AnimSeq_IsValid;

	private static int MarkNotify_AnimSeq_Offset;

	private static bool MarkNotify_StartTime_IsValid;

	private static int MarkNotify_StartTime_Offset;

	private IntPtr MarkNotify_InstanceFunctionAddressInstance;

	private static bool CheckState_IsValid;

	private static IntPtr CheckState_FunctionAddress;

	private static int CheckState_ParamsSize;

	private static bool CheckState_AnimBase_IsValid;

	private static int CheckState_AnimBase_Offset;

	private static bool CheckState_CurTime_IsValid;

	private static int CheckState_CurTime_Offset;

	private static bool CheckState_ReturnValue_IsValid;

	private static int CheckState_ReturnValue_Offset;

	private static FFieldAddress CheckState_ReturnValue_PropertyAddress;

	private IntPtr CheckState_InstanceFunctionAddressInstance;

	private static bool GenerateNotify_IsValid;

	private static IntPtr GenerateNotify_FunctionAddress;

	private static int GenerateNotify_ParamsSize;

	private static bool MarkNotifyState_IsValid;

	private static IntPtr MarkNotifyState_FunctionAddress;

	private static int MarkNotifyState_ParamsSize;

	private static bool MarkNotifyState_AnimSeq_IsValid;

	private static int MarkNotifyState_AnimSeq_Offset;

	private static bool MarkNotifyState_StartTime_IsValid;

	private static int MarkNotifyState_StartTime_Offset;

	private static bool MarkNotifyState_EndTime_IsValid;

	private static int MarkNotifyState_EndTime_Offset;

	private IntPtr MarkNotifyState_InstanceFunctionAddressInstance;

	private static bool GenerateNotifyState_IsValid;

	private static IntPtr GenerateNotifyState_FunctionAddress;

	private static int GenerateNotifyState_ParamsSize;

	private static bool RefreshAttackWarning_IsValid;

	private static IntPtr RefreshAttackWarning_FunctionAddress;

	private static int RefreshAttackWarning_ParamsSize;

	private static bool RefreshAttackWarning_AnimMontage_IsValid;

	private static int RefreshAttackWarning_AnimMontage_Offset;

	private static bool RefreshAttackWarning_PreTimeSeconds_IsValid;

	private static int RefreshAttackWarning_PreTimeSeconds_Offset;

	private static bool RefreshAttackWarning_PostTimeSeconds_IsValid;

	private static int RefreshAttackWarning_PostTimeSeconds_Offset;

	private static bool AddSweepCheckAttackWarning_IsValid;

	private static IntPtr AddSweepCheckAttackWarning_FunctionAddress;

	private static int AddSweepCheckAttackWarning_ParamsSize;

	private static bool AddSweepCheckAttackWarning_AnimMontage_IsValid;

	private static int AddSweepCheckAttackWarning_AnimMontage_Offset;

	private static bool AddSweepCheckAttackWarning_CheckSphereRadiusIncrease_IsValid;

	private static int AddSweepCheckAttackWarning_CheckSphereRadiusIncrease_Offset;

	private static bool AddExtraSocketAttackWarning_IsValid;

	private static IntPtr AddExtraSocketAttackWarning_FunctionAddress;

	private static int AddExtraSocketAttackWarning_ParamsSize;

	private static bool AddExtraSocketAttackWarning_AnimMontage_IsValid;

	private static int AddExtraSocketAttackWarning_AnimMontage_Offset;

	private static bool AddExtraSocketAttackWarning_SocketNum_IsValid;

	private static int AddExtraSocketAttackWarning_SocketNum_Offset;

	private static bool AddExtraSocketAttackWarning_SocketRadius_IsValid;

	private static int AddExtraSocketAttackWarning_SocketRadius_Offset;

	private static bool AddExtraSocketAttackWarning_LengthFrame_IsValid;

	private static int AddExtraSocketAttackWarning_LengthFrame_Offset;

	private static bool UpdateExtraSocketAttackWarning_IsValid;

	private static IntPtr UpdateExtraSocketAttackWarning_FunctionAddress;

	private static int UpdateExtraSocketAttackWarning_ParamsSize;

	private static bool UpdateExtraSocketAttackWarning_AnimMontage_IsValid;

	private static int UpdateExtraSocketAttackWarning_AnimMontage_Offset;

	private static bool UpdateExtraSocketAttackWarning_LengthFrame_IsValid;

	private static int UpdateExtraSocketAttackWarning_LengthFrame_Offset;

	private static bool GetSupportedClass_IsValid;

	private static IntPtr GetSupportedClass_FunctionAddress;

	private static int GetSupportedClass_ParamsSize;

	private static bool GetSupportedClass_ReturnValue_IsValid;

	private static int GetSupportedClass_ReturnValue_Offset;

	private static bool AddPlayerWaterSplash_BySweepCheck_IsValid;

	private static IntPtr AddPlayerWaterSplash_BySweepCheck_FunctionAddress;

	private static int AddPlayerWaterSplash_BySweepCheck_ParamsSize;

	private static bool AddPlayerWaterSplash_BySweepCheck_AnimMontage_IsValid;

	private static int AddPlayerWaterSplash_BySweepCheck_AnimMontage_Offset;

	private static bool AddPlayerWaterSplash_BySweepCheck__SocketName_IsValid;

	private static int AddPlayerWaterSplash_BySweepCheck__SocketName_Offset;

	private static bool AddPlayerWaterSplash_BySweepCheck_SweepRadius_IsValid;

	private static int AddPlayerWaterSplash_BySweepCheck_SweepRadius_Offset;

	private static bool AddPlayerWaterSplash_BySweepCheck_PointBetweenMin_IsValid;

	private static int AddPlayerWaterSplash_BySweepCheck_PointBetweenMin_Offset;

	private static bool AddPlayerWaterSplash_BySweepCheck_SampleStep_IsValid;

	private static int AddPlayerWaterSplash_BySweepCheck_SampleStep_Offset;

	private static bool ClearGeneratedAttackWarningsByTrack_IsValid;

	private static IntPtr ClearGeneratedAttackWarningsByTrack_FunctionAddress;

	private static int ClearGeneratedAttackWarningsByTrack_ParamsSize;

	private static bool ClearGeneratedAttackWarningsByTrack_AnimMontage_IsValid;

	private static int ClearGeneratedAttackWarningsByTrack_AnimMontage_Offset;

	private static bool AddPreciseDodgeAttackWarningAndSocket_IsValid;

	private static IntPtr AddPreciseDodgeAttackWarningAndSocket_FunctionAddress;

	private static int AddPreciseDodgeAttackWarningAndSocket_ParamsSize;

	private static bool AddPreciseDodgeAttackWarningAndSocket_AnimMontage_IsValid;

	private static int AddPreciseDodgeAttackWarningAndSocket_AnimMontage_Offset;

	private static bool AddPreciseDodgeAttackWarningAndSocket_PreTimeSeconds_IsValid;

	private static int AddPreciseDodgeAttackWarningAndSocket_PreTimeSeconds_Offset;

	private static bool AddPreciseDodgeAttackWarningAndSocket_PostTimeSeconds_IsValid;

	private static int AddPreciseDodgeAttackWarningAndSocket_PostTimeSeconds_Offset;

	private static bool AddPreciseDodgeAttackWarningAndSocket_CheckSphereRadius_IsValid;

	private static int AddPreciseDodgeAttackWarningAndSocket_CheckSphereRadius_Offset;

	private static bool AddPreciseDodgeAttackWarningAndSocket_AddSocketNumPerAnim_IsValid;

	private static int AddPreciseDodgeAttackWarningAndSocket_AddSocketNumPerAnim_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANSM_Base:NotifyStateClass")]
	public TSubclassOf<UAnimNotifyState> NotifyStateClass
	{
		get
		{
			CheckDestroyed();
			if (!NotifyStateClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyStateClass");
				return default(TSubclassOf<UAnimNotifyState>);
			}
			return TSubclassOfMarshaler<UAnimNotifyState>.FromNative(IntPtr.Add(base.Address, NotifyStateClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyStateClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyStateClass");
			}
			else
			{
				TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(base.Address, NotifyStateClass_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANSM_Base:NotifyClass")]
	public TSubclassOf<UAnimNotify> NotifyClass
	{
		get
		{
			CheckDestroyed();
			if (!NotifyClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyClass");
				return default(TSubclassOf<UAnimNotify>);
			}
			return TSubclassOfMarshaler<UAnimNotify>.FromNative(IntPtr.Add(base.Address, NotifyClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyClass");
			}
			else
			{
				TSubclassOfMarshaler<UAnimNotify>.ToNative(IntPtr.Add(base.Address, NotifyClass_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANSM_Base:NotifyTrackName")]
	public FName NotifyTrackName
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTrackName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyTrackName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyTrackName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTrackName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyTrackName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyTrackName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANSM_Base:NotifyTrackName_SweepCheck")]
	public FName NotifyTrackName_SweepCheck
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTrackName_SweepCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyTrackName_SweepCheck");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyTrackName_SweepCheck_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTrackName_SweepCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyTrackName_SweepCheck");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyTrackName_SweepCheck_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANSM_Base:NotifyTrackName_Socket")]
	public FName NotifyTrackName_Socket
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTrackName_Socket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyTrackName_Socket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, NotifyTrackName_Socket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTrackName_Socket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:NotifyTrackName_Socket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, NotifyTrackName_Socket_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANSM_Base:AWTag_GenerateBySweepCheck")]
	public FName AWTag_GenerateBySweepCheck
	{
		get
		{
			CheckDestroyed();
			if (!AWTag_GenerateBySweepCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:AWTag_GenerateBySweepCheck");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AWTag_GenerateBySweepCheck_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AWTag_GenerateBySweepCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:AWTag_GenerateBySweepCheck");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AWTag_GenerateBySweepCheck_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANSM_Base:AWTag_GenerateWithSocket")]
	public FName AWTag_GenerateWithSocket
	{
		get
		{
			CheckDestroyed();
			if (!AWTag_GenerateWithSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:AWTag_GenerateWithSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AWTag_GenerateWithSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AWTag_GenerateWithSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_Base:AWTag_GenerateWithSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AWTag_GenerateWithSocket_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANSM_Base:GetSupportedClass")]
	protected override TSubclassOf<UObject> GetSupportedClass_Implementation()
	{
		return UClass.GetClass<UAnimSequenceBase>();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANSM_Base:GenerateNotifyState")]
	protected void GenerateNotifyState()
	{
		foreach (UAnimSequenceBase selectedAsset in UEditorUtilityLibrary.GetSelectedAssets())
		{
			float playLength = selectedAsset.GetPlayLength();
			float num = 1f / 30f;
			float num2 = 0f;
			float num3 = 0f;
			bool flag = false;
			for (float num4 = 0f; num4 < playLength; num4 += num)
			{
				if (!flag && CheckState(selectedAsset, num4))
				{
					flag = true;
					num2 = num4;
				}
				else if (flag && !CheckState(selectedAsset, num4))
				{
					flag = false;
					num3 = num4;
					MarkNotifyState(selectedAsset, num2, num3);
				}
			}
			if (flag && num2 < playLength)
			{
				MarkNotifyState(selectedAsset, num2, playLength);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANSM_Base:GenerateNotify")]
	protected void GenerateNotify()
	{
		foreach (UAnimSequenceBase selectedAsset in UEditorUtilityLibrary.GetSelectedAssets())
		{
			float playLength = selectedAsset.GetPlayLength();
			float num = 1f / 30f;
			for (float num2 = 0f; num2 <= playLength; num2 += num)
			{
				if (CheckState(selectedAsset, num2))
				{
					MarkNotify(selectedAsset, num2);
				}
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintEvent]
	[USharpPath("/Script/b1-Managed.BANSM_Base:CheckState")]
	protected unsafe bool CheckState(UAnimSequenceBase AnimBase, float CurTime)
	{
		CheckDestroyed();
		if (!CheckState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BANSM_Base:CheckState");
			return false;
		}
		if (CheckState_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			CheckState_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "CheckState");
		}
		byte* value = stackalloc byte[(int)(uint)CheckState_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, CheckState_ParamsSize);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, CheckState_AnimBase_Offset), AnimBase);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, CheckState_CurTime_Offset), CurTime);
		NativeReflection.InvokeFunction(base.Address, CheckState_InstanceFunctionAddressInstance, intPtr, CheckState_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckState_ReturnValue_Offset), 0, CheckState_ReturnValue_PropertyAddress.Address);
	}

	protected virtual bool CheckState_Implementation(UAnimSequenceBase AnimBase, float CurTime)
	{
		return true;
	}

	[BlueprintEvent]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANSM_Base:MarkNotifyState")]
	protected unsafe void MarkNotifyState(UAnimSequenceBase AnimSeq, float StartTime, float EndTime)
	{
		CheckDestroyed();
		if (!MarkNotifyState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BANSM_Base:MarkNotifyState");
			return;
		}
		if (MarkNotifyState_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			MarkNotifyState_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "MarkNotifyState");
		}
		byte* value = stackalloc byte[(int)(uint)MarkNotifyState_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, MarkNotifyState_ParamsSize);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, MarkNotifyState_AnimSeq_Offset), AnimSeq);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MarkNotifyState_StartTime_Offset), StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MarkNotifyState_EndTime_Offset), EndTime);
		NativeReflection.InvokeFunction(base.Address, MarkNotifyState_InstanceFunctionAddressInstance, intPtr, MarkNotifyState_ParamsSize);
	}

	protected virtual void MarkNotifyState_Implementation(UAnimSequenceBase AnimSeq, float StartTime, float EndTime)
	{
		UAnimationLibrary.GetAnimationNotifyTrackNames(AnimSeq, out var TrackNames);
		if (!TrackNames.Contains(NotifyTrackName))
		{
			UAnimationLibrary.AddAnimationNotifyTrack(AnimSeq, NotifyTrackName, FLinearColor.AliceBlue);
		}
		UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(AnimSeq, NotifyTrackName, StartTime, EndTime - StartTime, NotifyStateClass);
	}

	[UFunction]
	[BlueprintCallable]
	[BlueprintEvent]
	[USharpPath("/Script/b1-Managed.BANSM_Base:MarkNotify")]
	protected unsafe void MarkNotify(UAnimSequenceBase AnimSeq, float StartTime)
	{
		CheckDestroyed();
		if (!MarkNotify_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BANSM_Base:MarkNotify");
			return;
		}
		if (MarkNotify_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			MarkNotify_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "MarkNotify");
		}
		byte* value = stackalloc byte[(int)(uint)MarkNotify_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, MarkNotify_ParamsSize);
		UObjectMarshaler<UAnimSequenceBase>.ToNative(IntPtr.Add(intPtr, MarkNotify_AnimSeq_Offset), AnimSeq);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MarkNotify_StartTime_Offset), StartTime);
		NativeReflection.InvokeFunction(base.Address, MarkNotify_InstanceFunctionAddressInstance, intPtr, MarkNotify_ParamsSize);
	}

	protected virtual void MarkNotify_Implementation(UAnimSequenceBase AnimSeq, float StartTime)
	{
		UAnimationLibrary.GetAnimationNotifyTrackNames(AnimSeq, out var TrackNames);
		if (!TrackNames.Contains(NotifyTrackName))
		{
			UAnimationLibrary.AddAnimationNotifyTrack(AnimSeq, NotifyTrackName, FLinearColor.AliceBlue);
		}
		UAnimationLibrary.AddAnimationNotifyEvent(AnimSeq, NotifyTrackName, StartTime, NotifyClass);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANSM_Base:ClearGeneratedAttackWarningsByTrack")]
	private void ClearGeneratedAttackWarningsByTrack(UAnimMontage AnimMontage)
	{
		UGSE_AnimFuncLib.RemoveAllAnimationNotifyStateEventInNamedTrack(AnimMontage, NotifyTrackName);
		UGSE_AnimFuncLib.RemoveAllAnimationNotifyStateEventInNamedTrack(AnimMontage, NotifyTrackName_SweepCheck);
		UGSE_AnimFuncLib.RemoveAllAnimationNotifyStateEventInNamedTrack(AnimMontage, NotifyTrackName_Socket);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BANSM_Base:AddSweepCheckAttackWarning")]
	private void AddSweepCheckAttackWarning(UAnimMontage AnimMontage, float CheckSphereRadiusIncrease = 0f)
	{
		if (AnimMontage == null)
		{
			return;
		}
		UGSE_AnimFuncLib.GetAnimationNotifyEvents(AnimMontage, out var NotifyEvents);
		FName notifyTrackName_SweepCheck = NotifyTrackName_SweepCheck;
		foreach (FAnimNotifyEventSimple item3 in NotifyEvents)
		{
			BANS_GSSweepCheck bANS_GSSweepCheck = item3.NotifyStateClass as BANS_GSSweepCheck;
			if (bANS_GSSweepCheck == null || item3.Duration <= 1E-08f || bANS_GSSweepCheck.EffectIDList.Count == 0)
			{
				continue;
			}
			bool flag = false;
			foreach (int effectID in bANS_GSSweepCheck.EffectIDList)
			{
				FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc == null)
				{
					BGW_GameDB.Init(ProjNames.B1.ToString());
				}
				originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc != null && originalSkillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				continue;
			}
			b1.BANS_GSAttackWarnning bANS_GSAttackWarnning = UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(AnimMontage, notifyTrackName_SweepCheck, FMath.Max(item3.StartTime, 0f), item3.Duration, UClass.GetClass(typeof(b1.BANS_GSAttackWarnning))) as b1.BANS_GSAttackWarnning;
			if (bANS_GSAttackWarnning == null)
			{
				continue;
			}
			foreach (FUStCheckShape item4 in bANS_GSSweepCheck.SweepCheckShape)
			{
				FUStCheckShape item = new FUStCheckShape
				{
					IsCapsuleShape = item4.IsCapsuleShape,
					Rotation = item4.Rotation,
					Scale = item4.Scale,
					SocketName = item4.SocketName,
					Radius = Math.Max(1f, item4.Radius + CheckSphereRadiusIncrease)
				};
				bANS_GSAttackWarnning.AttackWarnningCheckShape.Add(item);
			}
			foreach (int item5 in bANS_GSSweepCheck.SweepCheckShapeExtend)
			{
				FUStSweepCheckDesc sweepCheckDesc = BGW_GameDB.GetSweepCheckDesc(item5);
				if (sweepCheckDesc != null)
				{
					FUStCheckShape item2 = new FUStCheckShape
					{
						IsCapsuleShape = false,
						Rotation = FVector.ZeroVector,
						Scale = FVector.ZeroVector,
						SocketName = new FName(sweepCheckDesc.SocketName),
						Radius = Math.Max(1f, sweepCheckDesc.Radius + CheckSphereRadiusIncrease)
					};
					bANS_GSAttackWarnning.AttackWarnningCheckShape.Add(item2);
				}
			}
			bANS_GSAttackWarnning.ResultFilterType = bANS_GSSweepCheck.HitCheckConf.ResultFilterType;
			bANS_GSAttackWarnning.WeaponIndex = bANS_GSSweepCheck.WeaponIndex;
			bANS_GSAttackWarnning.Tags.Add(AWTag_GenerateBySweepCheck);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANSM_Base:AddExtraSocketAttackWarning")]
	private void AddExtraSocketAttackWarning(UAnimMontage AnimMontage, int SocketNum = 1, float SocketRadius = 200f, int LengthFrame = 4)
	{
		FName notifyTrackName_Socket = NotifyTrackName_Socket;
		UGSE_AnimFuncLib.GetAnimationNotifyEvents(AnimMontage, out var NotifyEvents);
		foreach (FAnimNotifyEventSimple item2 in NotifyEvents)
		{
			BANS_GSSweepCheck bANS_GSSweepCheck = item2.NotifyStateClass as BANS_GSSweepCheck;
			if (bANS_GSSweepCheck == null || item2.Duration <= 1E-08f || bANS_GSSweepCheck.EffectIDList.Count == 0)
			{
				continue;
			}
			bool flag = false;
			foreach (int effectID in bANS_GSSweepCheck.EffectIDList)
			{
				FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc == null)
				{
					BGW_GameDB.Init(ProjNames.B1.ToString());
				}
				originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc != null && originalSkillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				continue;
			}
			b1.BANS_GSAttackWarnning bANS_GSAttackWarnning = UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(AnimMontage, notifyTrackName_Socket, FMath.Max(item2.StartTime, 0f), (float)LengthFrame / 30f, UClass.GetClass(typeof(b1.BANS_GSAttackWarnning))) as b1.BANS_GSAttackWarnning;
			if (bANS_GSAttackWarnning == null)
			{
				continue;
			}
			USkeleton skeleton = UGSE_AnimFuncLib.GetSkeleton(AnimMontage);
			if (skeleton == null)
			{
				continue;
			}
			string name = AnimMontage.GetName();
			string arg = "PD_" + name.Substring("AM_".Length, name.Length - "AM_".Length);
			for (int i = 0; i < SocketNum; i++)
			{
				string text = $"{arg}_{i + 1}";
				FTransform identity = FTransform.Identity;
				switch (i)
				{
				case 0:
					identity.SetLocation(new FVector(400.0, 0.0, 0.0));
					break;
				case 1:
					identity.SetLocation(new FVector(350.0, 350.0, 0.0));
					break;
				case 2:
					identity.SetLocation(new FVector(350.0, -350.0, 0.0));
					break;
				}
				UGSE_AnimFuncLib.AddSocketToSkeleton(skeleton, "root", text, identity);
				FUStCheckShape item = new FUStCheckShape
				{
					SocketName = new FName(text),
					Radius = SocketRadius,
					IsCapsuleShape = false,
					Rotation = FVector.ZeroVector,
					Scale = FVector.OneVector
				};
				bANS_GSAttackWarnning.AttackWarnningCheckShape.Add(item);
			}
			bANS_GSAttackWarnning.ResultFilterType = bANS_GSSweepCheck.HitCheckConf.ResultFilterType;
			bANS_GSAttackWarnning.WeaponIndex = -1;
			bANS_GSAttackWarnning.Tags.Add(AWTag_GenerateWithSocket);
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BANSM_Base:UpdateExtraSocketAttackWarning")]
	private void UpdateExtraSocketAttackWarning(UAnimMontage AnimMontage, int LengthFrame = 6)
	{
		UGSE_AnimFuncLib.GetAnimationNotifyEvents(AnimMontage, out var NotifyEvents);
		foreach (FAnimNotifyEventSimple item in NotifyEvents)
		{
			b1.BANS_GSAttackWarnning bANS_GSAttackWarnning = item.NotifyStateClass as b1.BANS_GSAttackWarnning;
			if (bANS_GSAttackWarnning == null)
			{
				continue;
			}
			bool flag = false;
			foreach (FName tag in bANS_GSAttackWarnning.Tags)
			{
				if (tag.Equals(AWTag_GenerateWithSocket))
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				UGSE_AnimFuncLib.SetAnimationNotifyDuration(AnimMontage, item.GuidString, (float)LengthFrame / 30f);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANSM_Base:AddPreciseDodgeAttackWarningAndSocket")]
	protected void AddPreciseDodgeAttackWarningAndSocket(UAnimMontage AnimMontage, float PreTimeSeconds, float PostTimeSeconds, float CheckSphereRadius, int AddSocketNumPerAnim = 3)
	{
		FName notifyTrackName_SweepCheck = NotifyTrackName_SweepCheck;
		if (PreTimeSeconds < 0f || PostTimeSeconds < 0f)
		{
			return;
		}
		UGSE_AnimFuncLib.RemoveAllAnimationNotifyStateEventInNamedTrack(AnimMontage, notifyTrackName_SweepCheck);
		UGSE_AnimFuncLib.GetAnimationNotifyEvents(AnimMontage, out var NotifyEvents);
		foreach (FAnimNotifyEventSimple item2 in NotifyEvents)
		{
			BANS_GSSweepCheck bANS_GSSweepCheck = item2.NotifyStateClass as BANS_GSSweepCheck;
			if (bANS_GSSweepCheck == null || item2.Duration <= 1E-08f || bANS_GSSweepCheck.EffectIDList.Count == 0)
			{
				continue;
			}
			bool flag = false;
			foreach (int effectID in bANS_GSSweepCheck.EffectIDList)
			{
				FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc == null)
				{
					BGW_GameDB.Init(ProjNames.B1.ToString());
				}
				originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc != null && originalSkillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				continue;
			}
			b1.BANS_GSAttackWarnning bANS_GSAttackWarnning = UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(AnimMontage, notifyTrackName_SweepCheck, FMath.Max(item2.StartTime - PreTimeSeconds, 0f), item2.Duration + PostTimeSeconds, UClass.GetClass(typeof(b1.BANS_GSAttackWarnning))) as b1.BANS_GSAttackWarnning;
			if (bANS_GSAttackWarnning == null)
			{
				continue;
			}
			USkeleton skeleton = UGSE_AnimFuncLib.GetSkeleton(AnimMontage);
			if (!(skeleton == null))
			{
				string name = AnimMontage.GetName();
				string arg = "PD_" + name.Substring("AM_".Length, name.Length - "AM_".Length);
				for (int i = 0; i < AddSocketNumPerAnim; i++)
				{
					string text = $"{arg}_{i + 1}";
					UGSE_AnimFuncLib.AddSocketToSkeleton(skeleton, "root", text, FTransform.Identity);
					FUStCheckShape item = new FUStCheckShape
					{
						SocketName = new FName(text),
						Radius = CheckSphereRadius
					};
					bANS_GSAttackWarnning.AttackWarnningCheckShape.Add(item);
					bANS_GSAttackWarnning.ResultFilterType = bANS_GSSweepCheck.HitCheckConf.ResultFilterType;
					bANS_GSAttackWarnning.WeaponIndex = -1;
				}
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANSM_Base:RefreshAttackWarning")]
	protected void RefreshAttackWarning(UAnimMontage AnimMontage, float PreTimeSeconds, float PostTimeSeconds)
	{
		FName notifyTrackName_SweepCheck = NotifyTrackName_SweepCheck;
		if (PreTimeSeconds < 0f || PostTimeSeconds < 0f)
		{
			return;
		}
		UGSE_AnimFuncLib.RemoveAllAnimationNotifyStateEventInNamedTrack(AnimMontage, notifyTrackName_SweepCheck);
		UGSE_AnimFuncLib.GetAnimationNotifyEvents(AnimMontage, out var NotifyEvents);
		foreach (FAnimNotifyEventSimple item3 in NotifyEvents)
		{
			BANS_GSSweepCheck bANS_GSSweepCheck = item3.NotifyStateClass as BANS_GSSweepCheck;
			if (bANS_GSSweepCheck == null || item3.Duration <= 1E-08f || bANS_GSSweepCheck.EffectIDList.Count == 0)
			{
				continue;
			}
			bool flag = false;
			foreach (int effectID in bANS_GSSweepCheck.EffectIDList)
			{
				FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc == null)
				{
					BGW_GameDB.Init(ProjNames.B1.ToString());
				}
				originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc != null && originalSkillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				continue;
			}
			b1.BANS_GSAttackWarnning bANS_GSAttackWarnning = UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(AnimMontage, notifyTrackName_SweepCheck, FMath.Max(item3.StartTime - PreTimeSeconds, 0f), item3.Duration + PostTimeSeconds, UClass.GetClass(typeof(b1.BANS_GSAttackWarnning))) as b1.BANS_GSAttackWarnning;
			if (bANS_GSAttackWarnning == null)
			{
				continue;
			}
			foreach (FUStCheckShape item4 in bANS_GSSweepCheck.SweepCheckShape)
			{
				FUStCheckShape item = new FUStCheckShape
				{
					SocketName = item4.SocketName,
					Radius = item4.Radius
				};
				bANS_GSAttackWarnning.AttackWarnningCheckShape.Add(item);
			}
			foreach (int item5 in bANS_GSSweepCheck.SweepCheckShapeExtend)
			{
				FUStSweepCheckDesc sweepCheckDesc = BGW_GameDB.GetSweepCheckDesc(item5);
				if (sweepCheckDesc != null)
				{
					FUStCheckShape item2 = new FUStCheckShape
					{
						SocketName = new FName(sweepCheckDesc.SocketName),
						Radius = sweepCheckDesc.Radius
					};
					bANS_GSAttackWarnning.AttackWarnningCheckShape.Add(item2);
				}
			}
			bANS_GSAttackWarnning.ResultFilterType = bANS_GSSweepCheck.HitCheckConf.ResultFilterType;
			bANS_GSAttackWarnning.WeaponIndex = bANS_GSSweepCheck.WeaponIndex;
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANSM_Base:AddPlayerWaterSplash_BySweepCheck")]
	private void AddPlayerWaterSplash_BySweepCheck(UAnimMontage AnimMontage, FName _SocketName, float SweepRadius = 50f, float PointBetweenMin = 50f, float SampleStep = 0.0333f)
	{
		if (AnimMontage == null)
		{
			return;
		}
		BGUFuncLibNonRuntime.LoadProtobufData<FUStSkillEffectDesc>();
		UGSE_AnimFuncLib.GetAnimationNotifyEvents(AnimMontage, out var NotifyEvents);
		FName waterSplash = B1GlobalFNames.WaterSplash;
		UGSE_AnimFuncLib.RemoveAllAnimationNotifyStateEventInNamedTrack(AnimMontage, waterSplash);
		List<FAnimNotifyEventSimple> list = new List<FAnimNotifyEventSimple>();
		foreach (FAnimNotifyEventSimple item in NotifyEvents)
		{
			BANS_GSSweepCheck bANS_GSSweepCheck = item.NotifyStateClass as BANS_GSSweepCheck;
			if (bANS_GSSweepCheck == null || item.Duration <= 1E-08f || bANS_GSSweepCheck.EffectIDList.Count == 0)
			{
				continue;
			}
			bool flag = false;
			foreach (int effectID in bANS_GSSweepCheck.EffectIDList)
			{
				FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc == null)
				{
					BGW_GameDB.Init(ProjNames.B1.ToString());
				}
				originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(effectID);
				if (originalSkillEffectDesc != null && originalSkillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage && originalSkillEffectDesc.TargetFilter == 4)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				continue;
			}
			if (list.Count > 0)
			{
				bool flag2 = false;
				for (int i = 0; i < list.Count; i++)
				{
					FAnimNotifyEventSimple fAnimNotifyEventSimple = list[i];
					if ((fAnimNotifyEventSimple.StartTime <= item.StartTime && fAnimNotifyEventSimple.StartTime + fAnimNotifyEventSimple.Duration >= item.StartTime) || (fAnimNotifyEventSimple.StartTime <= item.StartTime + item.Duration && fAnimNotifyEventSimple.StartTime + fAnimNotifyEventSimple.Duration >= item.StartTime + item.Duration))
					{
						if (item.Duration > fAnimNotifyEventSimple.Duration)
						{
							list[i] = item;
						}
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					list.Add(item);
				}
			}
			else
			{
				list.Add(item);
			}
		}
		foreach (FAnimNotifyEventSimple item2 in list)
		{
			List<FVector> SweepTangentArray;
			Dictionary<float, FVector> dictionary = BGUGenWaterSplashPoints(AnimMontage, _SocketName, item2.StartTime, item2.StartTime + item2.Duration, PointBetweenMin, out SweepTangentArray, SampleStep);
			if (dictionary.Count <= 0)
			{
				continue;
			}
			b1.BANS_PlayWaterSplash bANS_PlayWaterSplash = UGSE_AnimFuncLib.AddAnimationNotifyStateEvent(AnimMontage, waterSplash, FMath.Max(item2.StartTime, 0f), item2.Duration, UClass.GetClass(typeof(b1.BANS_PlayWaterSplash))) as b1.BANS_PlayWaterSplash;
			if (!(bANS_PlayWaterSplash != null))
			{
				continue;
			}
			bANS_PlayWaterSplash.SweepRadius = SweepRadius;
			foreach (KeyValuePair<float, FVector> item3 in dictionary)
			{
				bANS_PlayWaterSplash.PresetLocalPoints.Add(item3.Key - item2.StartTime, item3.Value);
			}
			foreach (FVector item4 in SweepTangentArray)
			{
				bANS_PlayWaterSplash.PresetLocalSweepTangentArray.Add(item4);
			}
		}
	}

	public static Dictionary<float, FVector> BGUGenWaterSplashPoints(UAnimSequenceBase _AnimSeq, FName _SocketName, float BeginTime, float EndTime, float PointBetweenMin, out List<FVector> SweepTangentArray, float step = 0.016f)
	{
		Dictionary<float, FVector> dictionary = new Dictionary<float, FVector>();
		SweepTangentArray = new List<FVector>();
		if (_AnimSeq == null || _SocketName == FName.None || step <= 0.001f)
		{
			return dictionary;
		}
		float num = BeginTime;
		FVector fVector = FVector.ZeroVector;
		for (; num <= EndTime; num += step)
		{
			FVector location = GetSocketCompTransformByTime(_AnimSeq, _SocketName, num).GetLocation();
			if (dictionary.Count == 0)
			{
				dictionary.Add(num, location);
				fVector = location;
				float time = FMath.Max(0f, num - 0.02f);
				FVector location2 = GetSocketCompTransformByTime(_AnimSeq, _SocketName, time).GetLocation();
				FVector safeNormal2D = (location - location2).GetSafeNormal2D();
				SweepTangentArray.Add(safeNormal2D);
			}
			else if (FVector.Dist2D(fVector, location) >= PointBetweenMin)
			{
				dictionary.Add(num, location);
				FVector safeNormal2D2 = (location - fVector).GetSafeNormal2D();
				SweepTangentArray.Add(safeNormal2D2);
				fVector = location;
			}
		}
		return dictionary;
		static FTransform GetSocketCompTransformByTime(UAnimSequenceBase AnimSeq, FName SocketName, float Time)
		{
			if (AnimSeq.IsA<UAnimSequence>())
			{
				return UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(AnimSeq as UAnimSequence, Time, SocketName, bExtractRootMotion: true);
			}
			return UGSE_AnimFuncLib.Montage_GetBoneTransformCS(AnimSeq as UAnimMontage, Time, SocketName, FName.None, bExtractRootMotion: true);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:MarkNotify")]
	private static void MarkNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimSequenceBase animSeq = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(buffer, MarkNotify_AnimSeq_Offset));
		float startTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, MarkNotify_StartTime_Offset));
		bANSM_Base.MarkNotify_Implementation(animSeq, startTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:CheckState")]
	private static void CheckState__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimSequenceBase animBase = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(buffer, CheckState_AnimBase_Offset));
		float curTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CheckState_CurTime_Offset));
		bool value = bANSM_Base.CheckState_Implementation(animBase, curTime);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckState_ReturnValue_Offset), 0, CheckState_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:GenerateNotify")]
	private static void GenerateNotify__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		bANSM_Base.GenerateNotify();
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:MarkNotifyState")]
	private static void MarkNotifyState__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimSequenceBase animSeq = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(buffer, MarkNotifyState_AnimSeq_Offset));
		float startTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, MarkNotifyState_StartTime_Offset));
		float endTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, MarkNotifyState_EndTime_Offset));
		bANSM_Base.MarkNotifyState_Implementation(animSeq, startTime, endTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:GenerateNotifyState")]
	private static void GenerateNotifyState__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		bANSM_Base.GenerateNotifyState();
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:RefreshAttackWarning")]
	private static void RefreshAttackWarning__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimMontage animMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, RefreshAttackWarning_AnimMontage_Offset));
		float preTimeSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, RefreshAttackWarning_PreTimeSeconds_Offset));
		float postTimeSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, RefreshAttackWarning_PostTimeSeconds_Offset));
		bANSM_Base.RefreshAttackWarning(animMontage, preTimeSeconds, postTimeSeconds);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:AddSweepCheckAttackWarning")]
	private static void AddSweepCheckAttackWarning__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimMontage animMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, AddSweepCheckAttackWarning_AnimMontage_Offset));
		float checkSphereRadiusIncrease = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddSweepCheckAttackWarning_CheckSphereRadiusIncrease_Offset));
		bANSM_Base.AddSweepCheckAttackWarning(animMontage, checkSphereRadiusIncrease);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:AddExtraSocketAttackWarning")]
	private static void AddExtraSocketAttackWarning__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimMontage animMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, AddExtraSocketAttackWarning_AnimMontage_Offset));
		int socketNum = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, AddExtraSocketAttackWarning_SocketNum_Offset));
		float socketRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddExtraSocketAttackWarning_SocketRadius_Offset));
		int lengthFrame = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, AddExtraSocketAttackWarning_LengthFrame_Offset));
		bANSM_Base.AddExtraSocketAttackWarning(animMontage, socketNum, socketRadius, lengthFrame);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:UpdateExtraSocketAttackWarning")]
	private static void UpdateExtraSocketAttackWarning__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimMontage animMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, UpdateExtraSocketAttackWarning_AnimMontage_Offset));
		int lengthFrame = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, UpdateExtraSocketAttackWarning_LengthFrame_Offset));
		bANSM_Base.UpdateExtraSocketAttackWarning(animMontage, lengthFrame);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:GetSupportedClass")]
	private static void GetSupportedClass__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		TSubclassOf<UObject> supportedClass_Implementation = bANSM_Base.GetSupportedClass_Implementation();
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(buffer, GetSupportedClass_ReturnValue_Offset), supportedClass_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:AddPlayerWaterSplash_BySweepCheck")]
	private static void AddPlayerWaterSplash_BySweepCheck__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimMontage animMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, AddPlayerWaterSplash_BySweepCheck_AnimMontage_Offset));
		FName socketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, AddPlayerWaterSplash_BySweepCheck__SocketName_Offset));
		float sweepRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddPlayerWaterSplash_BySweepCheck_SweepRadius_Offset));
		float pointBetweenMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddPlayerWaterSplash_BySweepCheck_PointBetweenMin_Offset));
		float sampleStep = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddPlayerWaterSplash_BySweepCheck_SampleStep_Offset));
		bANSM_Base.AddPlayerWaterSplash_BySweepCheck(animMontage, socketName, sweepRadius, pointBetweenMin, sampleStep);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:ClearGeneratedAttackWarningsByTrack")]
	private static void ClearGeneratedAttackWarningsByTrack__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimMontage animMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, ClearGeneratedAttackWarningsByTrack_AnimMontage_Offset));
		bANSM_Base.ClearGeneratedAttackWarningsByTrack(animMontage);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_Base:AddPreciseDodgeAttackWarningAndSocket")]
	private static void AddPreciseDodgeAttackWarningAndSocket__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_Base bANSM_Base = GCHelper.Find<b1.BANSM_Base>(obj);
		UAnimMontage animMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, AddPreciseDodgeAttackWarningAndSocket_AnimMontage_Offset));
		float preTimeSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddPreciseDodgeAttackWarningAndSocket_PreTimeSeconds_Offset));
		float postTimeSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddPreciseDodgeAttackWarningAndSocket_PostTimeSeconds_Offset));
		float checkSphereRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddPreciseDodgeAttackWarningAndSocket_CheckSphereRadius_Offset));
		int addSocketNumPerAnim = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, AddPreciseDodgeAttackWarningAndSocket_AddSocketNumPerAnim_Offset));
		bANSM_Base.AddPreciseDodgeAttackWarningAndSocket(animMontage, preTimeSeconds, postTimeSeconds, checkSphereRadius, addSocketNumPerAnim);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANSM_Base");
		NotifyStateClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyStateClass");
		NotifyStateClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyStateClass", Classes.FClassProperty);
		NotifyClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyClass");
		NotifyClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyClass", Classes.FClassProperty);
		NotifyTrackName_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyTrackName");
		NotifyTrackName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyTrackName", Classes.FNameProperty);
		NotifyTrackName_SweepCheck_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyTrackName_SweepCheck");
		NotifyTrackName_SweepCheck_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyTrackName_SweepCheck", Classes.FNameProperty);
		NotifyTrackName_Socket_Offset = NativeReflection.GetPropertyOffset(intPtr, "NotifyTrackName_Socket");
		NotifyTrackName_Socket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NotifyTrackName_Socket", Classes.FNameProperty);
		AWTag_GenerateBySweepCheck_Offset = NativeReflection.GetPropertyOffset(intPtr, "AWTag_GenerateBySweepCheck");
		AWTag_GenerateBySweepCheck_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AWTag_GenerateBySweepCheck", Classes.FNameProperty);
		AWTag_GenerateWithSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "AWTag_GenerateWithSocket");
		AWTag_GenerateWithSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AWTag_GenerateWithSocket", Classes.FNameProperty);
		MarkNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MarkNotify");
		MarkNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkNotify_FunctionAddress);
		MarkNotify_AnimSeq_Offset = NativeReflection.GetPropertyOffset(MarkNotify_FunctionAddress, "AnimSeq");
		MarkNotify_AnimSeq_IsValid = NativeReflection.ValidatePropertyClass(MarkNotify_FunctionAddress, "AnimSeq", Classes.FObjectProperty);
		MarkNotify_StartTime_Offset = NativeReflection.GetPropertyOffset(MarkNotify_FunctionAddress, "StartTime");
		MarkNotify_StartTime_IsValid = NativeReflection.ValidatePropertyClass(MarkNotify_FunctionAddress, "StartTime", Classes.FFloatProperty);
		MarkNotify_IsValid = MarkNotify_FunctionAddress != IntPtr.Zero && MarkNotify_AnimSeq_IsValid && MarkNotify_StartTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:MarkNotify", MarkNotify_IsValid);
		CheckState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CheckState");
		CheckState_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckState_FunctionAddress);
		CheckState_AnimBase_Offset = NativeReflection.GetPropertyOffset(CheckState_FunctionAddress, "AnimBase");
		CheckState_AnimBase_IsValid = NativeReflection.ValidatePropertyClass(CheckState_FunctionAddress, "AnimBase", Classes.FObjectProperty);
		CheckState_CurTime_Offset = NativeReflection.GetPropertyOffset(CheckState_FunctionAddress, "CurTime");
		CheckState_CurTime_IsValid = NativeReflection.ValidatePropertyClass(CheckState_FunctionAddress, "CurTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CheckState_ReturnValue_PropertyAddress, CheckState_FunctionAddress, "ReturnValue");
		CheckState_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckState_FunctionAddress, "ReturnValue");
		CheckState_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckState_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckState_IsValid = CheckState_FunctionAddress != IntPtr.Zero && CheckState_AnimBase_IsValid && CheckState_CurTime_IsValid && CheckState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:CheckState", CheckState_IsValid);
		GenerateNotify_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateNotify");
		GenerateNotify_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateNotify_FunctionAddress);
		GenerateNotify_IsValid = GenerateNotify_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:GenerateNotify", GenerateNotify_IsValid);
		MarkNotifyState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MarkNotifyState");
		MarkNotifyState_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkNotifyState_FunctionAddress);
		MarkNotifyState_AnimSeq_Offset = NativeReflection.GetPropertyOffset(MarkNotifyState_FunctionAddress, "AnimSeq");
		MarkNotifyState_AnimSeq_IsValid = NativeReflection.ValidatePropertyClass(MarkNotifyState_FunctionAddress, "AnimSeq", Classes.FObjectProperty);
		MarkNotifyState_StartTime_Offset = NativeReflection.GetPropertyOffset(MarkNotifyState_FunctionAddress, "StartTime");
		MarkNotifyState_StartTime_IsValid = NativeReflection.ValidatePropertyClass(MarkNotifyState_FunctionAddress, "StartTime", Classes.FFloatProperty);
		MarkNotifyState_EndTime_Offset = NativeReflection.GetPropertyOffset(MarkNotifyState_FunctionAddress, "EndTime");
		MarkNotifyState_EndTime_IsValid = NativeReflection.ValidatePropertyClass(MarkNotifyState_FunctionAddress, "EndTime", Classes.FFloatProperty);
		MarkNotifyState_IsValid = MarkNotifyState_FunctionAddress != IntPtr.Zero && MarkNotifyState_AnimSeq_IsValid && MarkNotifyState_StartTime_IsValid && MarkNotifyState_EndTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:MarkNotifyState", MarkNotifyState_IsValid);
		GenerateNotifyState_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GenerateNotifyState");
		GenerateNotifyState_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateNotifyState_FunctionAddress);
		GenerateNotifyState_IsValid = GenerateNotifyState_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:GenerateNotifyState", GenerateNotifyState_IsValid);
		RefreshAttackWarning_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshAttackWarning");
		RefreshAttackWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshAttackWarning_FunctionAddress);
		RefreshAttackWarning_AnimMontage_Offset = NativeReflection.GetPropertyOffset(RefreshAttackWarning_FunctionAddress, "AnimMontage");
		RefreshAttackWarning_AnimMontage_IsValid = NativeReflection.ValidatePropertyClass(RefreshAttackWarning_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		RefreshAttackWarning_PreTimeSeconds_Offset = NativeReflection.GetPropertyOffset(RefreshAttackWarning_FunctionAddress, "PreTimeSeconds");
		RefreshAttackWarning_PreTimeSeconds_IsValid = NativeReflection.ValidatePropertyClass(RefreshAttackWarning_FunctionAddress, "PreTimeSeconds", Classes.FFloatProperty);
		RefreshAttackWarning_PostTimeSeconds_Offset = NativeReflection.GetPropertyOffset(RefreshAttackWarning_FunctionAddress, "PostTimeSeconds");
		RefreshAttackWarning_PostTimeSeconds_IsValid = NativeReflection.ValidatePropertyClass(RefreshAttackWarning_FunctionAddress, "PostTimeSeconds", Classes.FFloatProperty);
		RefreshAttackWarning_IsValid = RefreshAttackWarning_FunctionAddress != IntPtr.Zero && RefreshAttackWarning_AnimMontage_IsValid && RefreshAttackWarning_PreTimeSeconds_IsValid && RefreshAttackWarning_PostTimeSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:RefreshAttackWarning", RefreshAttackWarning_IsValid);
		AddSweepCheckAttackWarning_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddSweepCheckAttackWarning");
		AddSweepCheckAttackWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSweepCheckAttackWarning_FunctionAddress);
		AddSweepCheckAttackWarning_AnimMontage_Offset = NativeReflection.GetPropertyOffset(AddSweepCheckAttackWarning_FunctionAddress, "AnimMontage");
		AddSweepCheckAttackWarning_AnimMontage_IsValid = NativeReflection.ValidatePropertyClass(AddSweepCheckAttackWarning_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		AddSweepCheckAttackWarning_CheckSphereRadiusIncrease_Offset = NativeReflection.GetPropertyOffset(AddSweepCheckAttackWarning_FunctionAddress, "CheckSphereRadiusIncrease");
		AddSweepCheckAttackWarning_CheckSphereRadiusIncrease_IsValid = NativeReflection.ValidatePropertyClass(AddSweepCheckAttackWarning_FunctionAddress, "CheckSphereRadiusIncrease", Classes.FFloatProperty);
		AddSweepCheckAttackWarning_IsValid = AddSweepCheckAttackWarning_FunctionAddress != IntPtr.Zero && AddSweepCheckAttackWarning_AnimMontage_IsValid && AddSweepCheckAttackWarning_CheckSphereRadiusIncrease_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:AddSweepCheckAttackWarning", AddSweepCheckAttackWarning_IsValid);
		AddExtraSocketAttackWarning_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddExtraSocketAttackWarning");
		AddExtraSocketAttackWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(AddExtraSocketAttackWarning_FunctionAddress);
		AddExtraSocketAttackWarning_AnimMontage_Offset = NativeReflection.GetPropertyOffset(AddExtraSocketAttackWarning_FunctionAddress, "AnimMontage");
		AddExtraSocketAttackWarning_AnimMontage_IsValid = NativeReflection.ValidatePropertyClass(AddExtraSocketAttackWarning_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		AddExtraSocketAttackWarning_SocketNum_Offset = NativeReflection.GetPropertyOffset(AddExtraSocketAttackWarning_FunctionAddress, "SocketNum");
		AddExtraSocketAttackWarning_SocketNum_IsValid = NativeReflection.ValidatePropertyClass(AddExtraSocketAttackWarning_FunctionAddress, "SocketNum", Classes.FIntProperty);
		AddExtraSocketAttackWarning_SocketRadius_Offset = NativeReflection.GetPropertyOffset(AddExtraSocketAttackWarning_FunctionAddress, "SocketRadius");
		AddExtraSocketAttackWarning_SocketRadius_IsValid = NativeReflection.ValidatePropertyClass(AddExtraSocketAttackWarning_FunctionAddress, "SocketRadius", Classes.FFloatProperty);
		AddExtraSocketAttackWarning_LengthFrame_Offset = NativeReflection.GetPropertyOffset(AddExtraSocketAttackWarning_FunctionAddress, "LengthFrame");
		AddExtraSocketAttackWarning_LengthFrame_IsValid = NativeReflection.ValidatePropertyClass(AddExtraSocketAttackWarning_FunctionAddress, "LengthFrame", Classes.FIntProperty);
		AddExtraSocketAttackWarning_IsValid = AddExtraSocketAttackWarning_FunctionAddress != IntPtr.Zero && AddExtraSocketAttackWarning_AnimMontage_IsValid && AddExtraSocketAttackWarning_SocketNum_IsValid && AddExtraSocketAttackWarning_SocketRadius_IsValid && AddExtraSocketAttackWarning_LengthFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:AddExtraSocketAttackWarning", AddExtraSocketAttackWarning_IsValid);
		UpdateExtraSocketAttackWarning_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateExtraSocketAttackWarning");
		UpdateExtraSocketAttackWarning_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateExtraSocketAttackWarning_FunctionAddress);
		UpdateExtraSocketAttackWarning_AnimMontage_Offset = NativeReflection.GetPropertyOffset(UpdateExtraSocketAttackWarning_FunctionAddress, "AnimMontage");
		UpdateExtraSocketAttackWarning_AnimMontage_IsValid = NativeReflection.ValidatePropertyClass(UpdateExtraSocketAttackWarning_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		UpdateExtraSocketAttackWarning_LengthFrame_Offset = NativeReflection.GetPropertyOffset(UpdateExtraSocketAttackWarning_FunctionAddress, "LengthFrame");
		UpdateExtraSocketAttackWarning_LengthFrame_IsValid = NativeReflection.ValidatePropertyClass(UpdateExtraSocketAttackWarning_FunctionAddress, "LengthFrame", Classes.FIntProperty);
		UpdateExtraSocketAttackWarning_IsValid = UpdateExtraSocketAttackWarning_FunctionAddress != IntPtr.Zero && UpdateExtraSocketAttackWarning_AnimMontage_IsValid && UpdateExtraSocketAttackWarning_LengthFrame_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:UpdateExtraSocketAttackWarning", UpdateExtraSocketAttackWarning_IsValid);
		GetSupportedClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSupportedClass");
		GetSupportedClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportedClass_FunctionAddress);
		GetSupportedClass_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSupportedClass_FunctionAddress, "ReturnValue");
		GetSupportedClass_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSupportedClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetSupportedClass_IsValid = GetSupportedClass_FunctionAddress != IntPtr.Zero && GetSupportedClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:GetSupportedClass", GetSupportedClass_IsValid);
		AddPlayerWaterSplash_BySweepCheck_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPlayerWaterSplash_BySweepCheck");
		AddPlayerWaterSplash_BySweepCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPlayerWaterSplash_BySweepCheck_FunctionAddress);
		AddPlayerWaterSplash_BySweepCheck_AnimMontage_Offset = NativeReflection.GetPropertyOffset(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "AnimMontage");
		AddPlayerWaterSplash_BySweepCheck_AnimMontage_IsValid = NativeReflection.ValidatePropertyClass(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		AddPlayerWaterSplash_BySweepCheck__SocketName_Offset = NativeReflection.GetPropertyOffset(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "_SocketName");
		AddPlayerWaterSplash_BySweepCheck__SocketName_IsValid = NativeReflection.ValidatePropertyClass(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "_SocketName", Classes.FNameProperty);
		AddPlayerWaterSplash_BySweepCheck_SweepRadius_Offset = NativeReflection.GetPropertyOffset(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "SweepRadius");
		AddPlayerWaterSplash_BySweepCheck_SweepRadius_IsValid = NativeReflection.ValidatePropertyClass(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "SweepRadius", Classes.FFloatProperty);
		AddPlayerWaterSplash_BySweepCheck_PointBetweenMin_Offset = NativeReflection.GetPropertyOffset(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "PointBetweenMin");
		AddPlayerWaterSplash_BySweepCheck_PointBetweenMin_IsValid = NativeReflection.ValidatePropertyClass(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "PointBetweenMin", Classes.FFloatProperty);
		AddPlayerWaterSplash_BySweepCheck_SampleStep_Offset = NativeReflection.GetPropertyOffset(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "SampleStep");
		AddPlayerWaterSplash_BySweepCheck_SampleStep_IsValid = NativeReflection.ValidatePropertyClass(AddPlayerWaterSplash_BySweepCheck_FunctionAddress, "SampleStep", Classes.FFloatProperty);
		AddPlayerWaterSplash_BySweepCheck_IsValid = AddPlayerWaterSplash_BySweepCheck_FunctionAddress != IntPtr.Zero && AddPlayerWaterSplash_BySweepCheck_AnimMontage_IsValid && AddPlayerWaterSplash_BySweepCheck__SocketName_IsValid && AddPlayerWaterSplash_BySweepCheck_SweepRadius_IsValid && AddPlayerWaterSplash_BySweepCheck_PointBetweenMin_IsValid && AddPlayerWaterSplash_BySweepCheck_SampleStep_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:AddPlayerWaterSplash_BySweepCheck", AddPlayerWaterSplash_BySweepCheck_IsValid);
		ClearGeneratedAttackWarningsByTrack_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGeneratedAttackWarningsByTrack");
		ClearGeneratedAttackWarningsByTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGeneratedAttackWarningsByTrack_FunctionAddress);
		ClearGeneratedAttackWarningsByTrack_AnimMontage_Offset = NativeReflection.GetPropertyOffset(ClearGeneratedAttackWarningsByTrack_FunctionAddress, "AnimMontage");
		ClearGeneratedAttackWarningsByTrack_AnimMontage_IsValid = NativeReflection.ValidatePropertyClass(ClearGeneratedAttackWarningsByTrack_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		ClearGeneratedAttackWarningsByTrack_IsValid = ClearGeneratedAttackWarningsByTrack_FunctionAddress != IntPtr.Zero && ClearGeneratedAttackWarningsByTrack_AnimMontage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:ClearGeneratedAttackWarningsByTrack", ClearGeneratedAttackWarningsByTrack_IsValid);
		AddPreciseDodgeAttackWarningAndSocket_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddPreciseDodgeAttackWarningAndSocket");
		AddPreciseDodgeAttackWarningAndSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress);
		AddPreciseDodgeAttackWarningAndSocket_AnimMontage_Offset = NativeReflection.GetPropertyOffset(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "AnimMontage");
		AddPreciseDodgeAttackWarningAndSocket_AnimMontage_IsValid = NativeReflection.ValidatePropertyClass(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		AddPreciseDodgeAttackWarningAndSocket_PreTimeSeconds_Offset = NativeReflection.GetPropertyOffset(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "PreTimeSeconds");
		AddPreciseDodgeAttackWarningAndSocket_PreTimeSeconds_IsValid = NativeReflection.ValidatePropertyClass(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "PreTimeSeconds", Classes.FFloatProperty);
		AddPreciseDodgeAttackWarningAndSocket_PostTimeSeconds_Offset = NativeReflection.GetPropertyOffset(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "PostTimeSeconds");
		AddPreciseDodgeAttackWarningAndSocket_PostTimeSeconds_IsValid = NativeReflection.ValidatePropertyClass(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "PostTimeSeconds", Classes.FFloatProperty);
		AddPreciseDodgeAttackWarningAndSocket_CheckSphereRadius_Offset = NativeReflection.GetPropertyOffset(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "CheckSphereRadius");
		AddPreciseDodgeAttackWarningAndSocket_CheckSphereRadius_IsValid = NativeReflection.ValidatePropertyClass(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "CheckSphereRadius", Classes.FFloatProperty);
		AddPreciseDodgeAttackWarningAndSocket_AddSocketNumPerAnim_Offset = NativeReflection.GetPropertyOffset(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "AddSocketNumPerAnim");
		AddPreciseDodgeAttackWarningAndSocket_AddSocketNumPerAnim_IsValid = NativeReflection.ValidatePropertyClass(AddPreciseDodgeAttackWarningAndSocket_FunctionAddress, "AddSocketNumPerAnim", Classes.FIntProperty);
		AddPreciseDodgeAttackWarningAndSocket_IsValid = AddPreciseDodgeAttackWarningAndSocket_FunctionAddress != IntPtr.Zero && AddPreciseDodgeAttackWarningAndSocket_AnimMontage_IsValid && AddPreciseDodgeAttackWarningAndSocket_PreTimeSeconds_IsValid && AddPreciseDodgeAttackWarningAndSocket_PostTimeSeconds_IsValid && AddPreciseDodgeAttackWarningAndSocket_CheckSphereRadius_IsValid && AddPreciseDodgeAttackWarningAndSocket_AddSocketNumPerAnim_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_Base:AddPreciseDodgeAttackWarningAndSocket", AddPreciseDodgeAttackWarningAndSocket_IsValid);
	}

	static BANSM_Base()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANSM_Base)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANSM_Base));
	}
}
