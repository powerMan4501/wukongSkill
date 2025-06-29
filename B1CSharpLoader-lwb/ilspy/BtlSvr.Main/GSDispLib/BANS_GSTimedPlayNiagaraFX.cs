using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[DisplayName("BANS DispLib Timed Play Niagara FX")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX")]
internal class BANS_GSTimedPlayNiagaraFX : BANS_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool template_IsValid;

	private static int template_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool DestroyTiming_IsValid;

	private static int DestroyTiming_Offset;

	private static FFieldAddress DestroyTiming_PropertyAddress;

	private static bool OverrideSKMTagName_IsValid;

	private static int OverrideSKMTagName_Offset;

	private static bool attached_IsValid;

	private static int attached_Offset;

	private static FFieldAddress attached_PropertyAddress;

	private static bool socketName_IsValid;

	private static int socketName_Offset;

	private static bool offsetInLocaSpace_IsValid;

	private static int offsetInLocaSpace_Offset;

	private static FFieldAddress offsetInLocaSpace_PropertyAddress;

	private static bool locationOffset_IsValid;

	private static int locationOffset_Offset;

	private static bool rotationOffset_IsValid;

	private static int rotationOffset_Offset;

	private static bool scale_IsValid;

	private static int scale_Offset;

	private static bool SnapGround_IsValid;

	private static int SnapGround_Offset;

	private static FFieldAddress SnapGround_PropertyAddress;

	private static bool SnapGroundRotationMode_IsValid;

	private static int SnapGroundRotationMode_Offset;

	private static FFieldAddress SnapGroundRotationMode_PropertyAddress;

	private static bool ignoreRootBoneScale_IsValid;

	private static int ignoreRootBoneScale_Offset;

	private static FFieldAddress ignoreRootBoneScale_PropertyAddress;

	private static bool SetSelfMeshParam_IsValid;

	private static int SetSelfMeshParam_Offset;

	private static FFieldAddress SetSelfMeshParam_PropertyAddress;

	private static bool OverrideSKMBones_IsValid;

	private static int OverrideSKMBones_Offset;

	private static FFieldAddress OverrideSKMBones_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> OverrideSKMBones_Marshaler;

	private static bool OverrideSKMSockets_IsValid;

	private static int OverrideSKMSockets_Offset;

	private static FFieldAddress OverrideSKMSockets_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> OverrideSKMSockets_Marshaler;

	private static bool customParams_IsValid;

	private static int customParams_Offset;

	private static FFieldAddress customParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSNiagaraSysParam> customParams_Marshaler;

	private static bool DetachOnEndDispStageBegin_IsValid;

	private static int DetachOnEndDispStageBegin_Offset;

	private static FFieldAddress DetachOnEndDispStageBegin_PropertyAddress;

	private static bool EnableShadow_IsValid;

	private static int EnableShadow_Offset;

	private static FFieldAddress EnableShadow_PropertyAddress;

	private static bool translucentSortPriority_IsValid;

	private static int translucentSortPriority_Offset;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	private static bool PauseMode_IsValid;

	private static int PauseMode_Offset;

	private static FFieldAddress PauseMode_PropertyAddress;

	private static bool EndStagePriority_IsValid;

	private static int EndStagePriority_Offset;

	private static bool ForceChangeVisibleStateDEFPriority_IsValid;

	private static int ForceChangeVisibleStateDEFPriority_Offset;

	private static bool ForceVisibleStateDefaultMode_IsValid;

	private static int ForceVisibleStateDefaultMode_Offset;

	private static FFieldAddress ForceVisibleStateDefaultMode_PropertyAddress;

	private static bool CompTag_IsValid;

	private static int CompTag_Offset;

	private static bool ScalabilitySettings_IsValid;

	private static int ScalabilitySettings_Offset;

	private static bool hasAttachedSocket_IsValid;

	private static int hasAttachedSocket_Offset;

	private static FFieldAddress hasAttachedSocket_PropertyAddress;

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

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[UProperty]
	[UMeta(MD.ToolTip, "关闭后编辑器下不会播放当前效果，不影响运行时")]
	[DisplayName("Editor Active")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EditorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:template")]
	public TSoftObject<UNiagaraSystem> template
	{
		get
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:template");
				return default(TSoftObject<UNiagaraSystem>);
			}
			return TSoftObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:template");
			}
			else
			{
				TSoftObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, template_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[UMeta(MD.ToolTip, "逻辑通知特效可以结束或固定持续时间过后，设置特效参数 GS_EfxStop = true，此时若此参数不为0则将此值设置到特效参数 GS_EfxEndDispStageTime; EndMode 是 AutoRelease 时此参数视为0")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DelayTimeAfterStop")]
	public float DelayTimeAfterStop
	{
		get
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DelayTimeAfterStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DelayTimeAfterStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("销毁时机")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "逻辑在何时通知特效销毁")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DestroyTiming")]
	public DispLibDBCEffectDestroyTiming DestroyTiming
	{
		get
		{
			CheckDestroyed();
			if (!DestroyTiming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DestroyTiming");
				return DispLibDBCEffectDestroyTiming.OnEndDispStageEnd;
			}
			return EnumMarshaler<DispLibDBCEffectDestroyTiming>.FromNative(IntPtr.Add(base.Address, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DestroyTiming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DestroyTiming");
			}
			else
			{
				EnumMarshaler<DispLibDBCEffectDestroyTiming>.ToNative(IntPtr.Add(base.Address, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标MeshComp")]
	[UMeta(MD.ToolTip, "填写目标Comp的tag，为None表示以master作为目标骨骼，否则查找tag对应的骨骼，多个结果只取第一个; 编辑器预览时忽略此参数因为MeshTag仅在运行时由逻辑注入")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:OverrideSKMTagName")]
	public FName OverrideSKMTagName
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSKMTagName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:OverrideSKMTagName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OverrideSKMTagName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSKMTagName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:OverrideSKMTagName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OverrideSKMTagName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:attached")]
	public bool attached
	{
		get
		{
			CheckDestroyed();
			if (!attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:attached");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, attached_Offset), 0, attached_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:attached");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, attached_Offset), 0, attached_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta("AnimNotifyBoneName", "true")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:socketName")]
	public FName socketName
	{
		get
		{
			CheckDestroyed();
			if (!socketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:socketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, socketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!socketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:socketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, socketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("偏移是否基于本地空间")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:offsetInLocaSpace")]
	public bool offsetInLocaSpace
	{
		get
		{
			CheckDestroyed();
			if (!offsetInLocaSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:offsetInLocaSpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, offsetInLocaSpace_Offset), 0, offsetInLocaSpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!offsetInLocaSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:offsetInLocaSpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, offsetInLocaSpace_Offset), 0, offsetInLocaSpace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:locationOffset")]
	public FVector locationOffset
	{
		get
		{
			CheckDestroyed();
			if (!locationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:locationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, locationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!locationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:locationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, locationOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:rotationOffset")]
	public FRotator rotationOffset
	{
		get
		{
			CheckDestroyed();
			if (!rotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:rotationOffset");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, rotationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!rotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:rotationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, rotationOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:scale")]
	public FVector scale
	{
		get
		{
			CheckDestroyed();
			if (!scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:scale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, scale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:scale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, scale_Offset), value);
			}
		}
	}

	[DisplayName("吸附地面")]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "勾选此参数，特效强制不跟随挂点且忽略 DBCOverrideTransform\r\n勾选此参数后，\r\nLocation如何计算：从配置的挂点位置（不计算配置的offset）向世界空间负Z轴打射线，命中地面后在命中点的 Location 基础上计算配置的 LocationOffset，如果勾选了【偏移是否基于本地空间】，LocationOffset 是在配置的挂点空间计算的\r\n   Rotation如何计算：命中地面后根据【吸附地面时特效朝向】决定特效朝向，但无论哪种方式都会完全忽略配置的 RotationOffset")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SnapGround")]
	public bool SnapGround
	{
		get
		{
			CheckDestroyed();
			if (!SnapGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SnapGround");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SnapGround");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("吸附地面时特效朝向")]
	[UMeta(MDProp.EditCondition, "SnapGround == true")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SnapGroundRotationMode")]
	public DispLibDBCSnapGroundRotationMode SnapGroundRotationMode
	{
		get
		{
			CheckDestroyed();
			if (!SnapGroundRotationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SnapGroundRotationMode");
				return DispLibDBCSnapGroundRotationMode.HitPointNormalProjected;
			}
			return EnumMarshaler<DispLibDBCSnapGroundRotationMode>.FromNative(IntPtr.Add(base.Address, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapGroundRotationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SnapGroundRotationMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCSnapGroundRotationMode>.ToNative(IntPtr.Add(base.Address, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MD.DisplayName, "Ignore Root Bone Scale")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ignoreRootBoneScale")]
	public bool ignoreRootBoneScale
	{
		get
		{
			CheckDestroyed();
			if (!ignoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ignoreRootBoneScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ignoreRootBoneScale_Offset), 0, ignoreRootBoneScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ignoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ignoreRootBoneScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ignoreRootBoneScale_Offset), 0, ignoreRootBoneScale_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MD.ToolTip, "当【目标MeshComp】有效时，设置重定向后的Mesh到特效")]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置自身Mesh参数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SetSelfMeshParam")]
	public bool SetSelfMeshParam
	{
		get
		{
			CheckDestroyed();
			if (!SetSelfMeshParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SetSelfMeshParam");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SetSelfMeshParam_Offset), 0, SetSelfMeshParam_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SetSelfMeshParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:SetSelfMeshParam");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SetSelfMeshParam_Offset), 0, SetSelfMeshParam_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "SetSelfMeshParam")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Override SKM Bones")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:OverrideSKMBones")]
	public TArrayReadWrite<FName> OverrideSKMBones
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSKMBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:OverrideSKMBones");
				return null;
			}
			if (OverrideSKMBones_Marshaler == null)
			{
				OverrideSKMBones_Marshaler = new TArrayReadWriteMarshaler<FName>(1, OverrideSKMBones_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return OverrideSKMBones_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideSKMBones_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Override SKM Sockets")]
	[UMeta(MDProp.EditCondition, "SetSelfMeshParam")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:OverrideSKMSockets")]
	public TArrayReadWrite<FName> OverrideSKMSockets
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSKMSockets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:OverrideSKMSockets");
				return null;
			}
			if (OverrideSKMSockets_Marshaler == null)
			{
				OverrideSKMSockets_Marshaler = new TArrayReadWriteMarshaler<FName>(1, OverrideSKMSockets_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return OverrideSKMSockets_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideSKMSockets_Offset));
		}
	}

	[UMeta(MD.DisplayName, "Set Custom Params ")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:customParams")]
	public TArrayReadWrite<FGSNiagaraSysParam> customParams
	{
		get
		{
			CheckDestroyed();
			if (!customParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:customParams");
				return null;
			}
			if (customParams_Marshaler == null)
			{
				customParams_Marshaler = new TArrayReadWriteMarshaler<FGSNiagaraSysParam>(1, customParams_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.FromNative, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.ToNative);
			}
			return customParams_Marshaler.FromNative(IntPtr.Add(base.Address, customParams_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现阶段与挂点分离")]
	[UMeta(MDProp.EditCondition, "attached")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DetachOnEndDispStageBegin")]
	public bool DetachOnEndDispStageBegin
	{
		get
		{
			CheckDestroyed();
			if (!DetachOnEndDispStageBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DetachOnEndDispStageBegin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachOnEndDispStageBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:DetachOnEndDispStageBegin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("阴影")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EnableShadow")]
	public bool EnableShadow
	{
		get
		{
			CheckDestroyed();
			if (!EnableShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EnableShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EnableShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:translucentSortPriority")]
	public int translucentSortPriority
	{
		get
		{
			CheckDestroyed();
			if (!translucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:translucentSortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, translucentSortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!translucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:translucentSortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, translucentSortPriority_Offset), value);
			}
		}
	}

	[DisplayName("暂停优先级")]
	[UProperty]
	[UMeta(MD.ToolTip, "当触发暂停时请求方会给定一个优先级，如果此参数大于优先级则不会进入暂停逻辑")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:PausePriority")]
	public int PausePriority
	{
		get
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:PausePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PausePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:PausePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PausePriority_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "进入暂停逻辑后，此配置项决定了特效的行为")]
	[DisplayName("暂停模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:PauseMode")]
	public DispLibDBCPauseMode PauseMode
	{
		get
		{
			CheckDestroyed();
			if (!PauseMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:PauseMode");
				return DispLibDBCPauseMode.Pause;
			}
			return EnumMarshaler<DispLibDBCPauseMode>.FromNative(IntPtr.Add(base.Address, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PauseMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:PauseMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCPauseMode>.ToNative(IntPtr.Add(base.Address, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MD.ToolTip, "角色死亡时各种效果默认不进入结束表现阶段，如果此效果需要进入则填写1")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现阶段优先级")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EndStagePriority")]
	public int EndStagePriority
	{
		get
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EndStagePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EndStagePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:EndStagePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EndStagePriority_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("强制可见性优先级")]
	[UMeta(MD.ToolTip, "当外部请求强制设置可见性时会给定一个优先级，如果此参数大于优先级则不会受此请求的影响；\n主角因为释放人种袋变身而强制隐藏所有特效时逻辑给出的优先级是 100\n主角因为进入Seq而监听宿主Actor的Hidden状态而隐藏所有特效时逻辑给出的优先级是 50\n主角因为进入Seq而强制隐藏所有特效时逻辑给出的优先级是 10")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ForceChangeVisibleStateDEFPriority")]
	public int ForceChangeVisibleStateDEFPriority
	{
		get
		{
			CheckDestroyed();
			if (!ForceChangeVisibleStateDEFPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ForceChangeVisibleStateDEFPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForceChangeVisibleStateDEFPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceChangeVisibleStateDEFPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ForceChangeVisibleStateDEFPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForceChangeVisibleStateDEFPriority_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("强制可见性默认行为")]
	[UMeta(MD.ToolTip, "如果强制设置可见性的请求允许执行，此配置决定特效的默认行为。如果需要对指定优先级的请求有不同的行为，可改为 DataAseet 形式的 AdvanceNiagara，设置【强制可见性自定义模式】")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ForceVisibleStateDefaultMode")]
	public DispLibDBCNiagaraForceVisibleStateMode ForceVisibleStateDefaultMode
	{
		get
		{
			CheckDestroyed();
			if (!ForceVisibleStateDefaultMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ForceVisibleStateDefaultMode");
				return DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState;
			}
			return EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.FromNative(IntPtr.Add(base.Address, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceVisibleStateDefaultMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ForceVisibleStateDefaultMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.ToNative(IntPtr.Add(base.Address, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:CompTag")]
	public FName CompTag
	{
		get
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:CompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:CompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CompTag_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "DBC性能控制")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DBC Scalability")]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ScalabilitySettings")]
	public BUC_DispLibDBC_NiagaraEventScalabilitySettings ScalabilitySettings
	{
		get
		{
			CheckDestroyed();
			if (!ScalabilitySettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ScalabilitySettings");
				return default(BUC_DispLibDBC_NiagaraEventScalabilitySettings);
			}
			return BUC_DispLibDBC_NiagaraEventScalabilitySettings.FromNative(IntPtr.Add(base.Address, ScalabilitySettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScalabilitySettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:ScalabilitySettings");
			}
			else
			{
				BUC_DispLibDBC_NiagaraEventScalabilitySettings.ToNative(IntPtr.Add(base.Address, ScalabilitySettings_Offset), value);
			}
		}
	}

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:hasAttachedSocket")]
	public bool hasAttachedSocket
	{
		get
		{
			CheckDestroyed();
			if (!hasAttachedSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:hasAttachedSocket");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, hasAttachedSocket_Offset), 0, hasAttachedSocket_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!hasAttachedSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:hasAttachedSocket");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, hasAttachedSocket_Offset), 0, hasAttachedSocket_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize()
	{
	}

	protected bool ValidateParameters(USkeletalMeshComponent MeshComp)
	{
		bool result = true;
		if (template.IsNull || MeshComp == null)
		{
			result = false;
			hasAttachedSocket = false;
		}
		else if (!attached)
		{
			hasAttachedSocket = false;
		}
		else if (OverrideSKMTagName == FName.None && !MeshComp.DoesSocketExist(socketName) && MeshComp.GetBoneIndex(socketName) == -1)
		{
			result = false;
			hasAttachedSocket = false;
		}
		else
		{
			hasAttachedSocket = true;
		}
		return result;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.CanBePlacedInASCS = true;
		base.CanUseQueuedType = true;
		scale = FVector.OneVector;
		ignoreRootBoneScale = true;
		socketName = FName.None;
		hasAttachedSocket = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		if (!template.IsNull)
		{
			return new List<FSoftObjectPath> { template.ObjectPath };
		}
		return new List<FSoftObjectPath>();
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		if (!template.IsNull)
		{
			SoftPathSet.Add(template.ObjectPath);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		base.Received_NotifyBegin_Implementation(meshComp, animation, TotalDuration, default(FAnimNotifyEventReference));
		if (ValidateParameters(meshComp))
		{
			GetValidResource(template);
			SpawnNiagaraCompByDBC(meshComp, animation, TotalDuration);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		base.Received_NotifyEnd_Implementation(meshComp, animation, default(FAnimNotifyEventReference));
		Runtime_EndNiagaraByANID(meshComp, animation);
	}

	protected UNiagaraComponent SpawnNiagaraCompByDBC(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float Duration)
	{
		return Runtime_DoSpawnNiagaraByDBC(MeshComp, Animation, Duration);
	}

	protected UNiagaraComponent Runtime_DoSpawnNiagaraByDBC(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation, float Duration)
	{
		if (template.IsNull)
		{
			return null;
		}
		USkeletalMeshComponent uSkeletalMeshComponent = null;
		if (SetSelfMeshParam)
		{
			uSkeletalMeshComponent = BGU_DispLibDataUtil.FindRealTargetSkeletalMeshComp(MeshComp, OverrideSKMTagName);
			if (uSkeletalMeshComponent == null)
			{
				return null;
			}
			if (!UGSE_SkeletalMeshFuncLib.IsCPUAccess(uSkeletalMeshComponent.SkeletalMesh))
			{
				return null;
			}
		}
		bool flag = false;
		if (GSGameplayCVar.CVar_SyncLoadSoftResource.GetValueInGameThread() != 0)
		{
			flag = true;
		}
		if (template.Value == null)
		{
			if (!flag && base.isPreload)
			{
				return null;
			}
			SyncLoadSoftPathObjAndAddPreloadedAsset<UNiagaraSystem>(template.ObjectPath.Path);
		}
		BUC_DispLibDBC_PlayNiagara d = new BUC_DispLibDBC_PlayNiagara(0f, DispLibDBCEndMode.ProcedureNotity, Duration, DelayTimeAfterStop, DestroyTiming, template.Value, OverrideSKMTagName, attached, socketName, offsetInLocaSpace, locationOffset, rotationOffset, scale, SnapGround, SnapGroundRotationMode, DetachOnEndDispStageBegin, EnableShadow, translucentSortPriority, _ForcePoolModeNone: false, PausePriority, PauseMode, EndStagePriority, ForceChangeVisibleStateDEFPriority, ForceVisibleStateDefaultMode, CompTag, ScalabilitySettings);
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(MeshComp.GetOwner());
		uint uniqueID = GetUniqueID();
		if (bUS_DispLibEventCollection == null)
		{
			BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(MeshComp))?.Evt_RequestSpawn_One_Common_Niagara(MeshComp, d, DispLibRefParam.Instance, DBCTransformParam.Default, DBCSetCallbackParams.Default, uniqueID);
		}
		else
		{
			bUS_DispLibEventCollection.Evt_RequestSpawn_One_Common_Niagara(d, DispLibRefParam.Instance, DBCTransformParam.Default, DBCSetCallbackParams.Default, uniqueID);
		}
		UNiagaraComponent dBCReturn_FirstNC = DispLibRefParam.Instance.DBCReturn_FirstNC;
		if (dBCReturn_FirstNC.IsNullOrDestroyed())
		{
			return null;
		}
		if (hasAttachedSocket && ignoreRootBoneScale)
		{
			FVector scale3D = UGSE_CharacterFuncLib.GetBoneTransformByMesh(MeshComp, 0).GetScale3D();
			dBCReturn_FirstNC.SetRelativeScale3D(scale * new FVector(1f / scale3D.X, 1f / scale3D.Y, 1f / scale3D.Z));
		}
		else
		{
			dBCReturn_FirstNC.SetRelativeScale3D(scale);
		}
		if (SetSelfMeshParam)
		{
			UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(dBCReturn_FirstNC, "User.GS_EfxSelfSkeletalMesh", uSkeletalMeshComponent);
			if (OverrideSKMSockets.Count != 0)
			{
				UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredSockets(dBCReturn_FirstNC, "User.GS_EfxSelfSkeletalMesh", OverrideSKMSockets.ToList());
			}
			if (OverrideSKMBones.Count != 0)
			{
				UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredBones(dBCReturn_FirstNC, "User.GS_EfxSelfSkeletalMesh", OverrideSKMBones.ToList());
			}
		}
		for (int i = 0; i < customParams.Count; i++)
		{
			FName name = customParams[i].Name;
			switch (customParams[i].ParamType)
			{
			case EGSNiagaraSysParamType.GSNPT_Float:
				dBCReturn_FirstNC.SetVariableFloat(name, customParams[i].FloatValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Int:
				dBCReturn_FirstNC.SetVariableInt(name, customParams[i].IntValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Vector:
				dBCReturn_FirstNC.SetVariableVec3(name, customParams[i].VectorValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Bool:
				dBCReturn_FirstNC.SetVariableBool(name, customParams[i].BoolValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_LinearColor:
				dBCReturn_FirstNC.SetVariableLinearColor(name, customParams[i].LinearColorValue);
				break;
			}
		}
		dBCReturn_FirstNC.ComponentTags.Add(B1GlobalFNames.DBCNG);
		return dBCReturn_FirstNC;
	}

	protected bool Runtime_EndNiagaraByANID(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		AActor owner = MeshComp.GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return false;
		}
		uint uniqueID = GetUniqueID();
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(owner);
		if (bUS_DispLibEventCollection != null)
		{
			bUS_DispLibEventCollection.Evt_RequestEndDBCEffectsByAnimNotifyUniqueID(uniqueID, 0u, OnlyEndFX: true, OnlyEndProcedureEndMode: false);
		}
		else
		{
			BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(owner))?.Evt_RequestEndDBCEffectsByAnimNotifyUniqueID(MeshComp, uniqueID, 0u, OnlyEndFX: true, OnlyEndProcedureEndMode: false);
		}
		return true;
	}

	protected bool Runtime_EndNiagaraByDBCID(USkeletalMeshComponent MeshComp, UAnimSequenceBase Animation)
	{
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_GSTimedPlayNiagaraFX bANS_GSTimedPlayNiagaraFX = GCHelper.Find<GSDispLib.BANS_GSTimedPlayNiagaraFX>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSTimedPlayNiagaraFX.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_GSTimedPlayNiagaraFX bANS_GSTimedPlayNiagaraFX = GCHelper.Find<GSDispLib.BANS_GSTimedPlayNiagaraFX>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSTimedPlayNiagaraFX.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSDispLib.BANS_GSTimedPlayNiagaraFX bANS_GSTimedPlayNiagaraFX = GCHelper.Find<GSDispLib.BANS_GSTimedPlayNiagaraFX>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bANS_GSTimedPlayNiagaraFX.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		template_Offset = NativeReflection.GetPropertyOffset(intPtr, "template");
		template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "template", Classes.FSoftObjectProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DestroyTiming_PropertyAddress, intPtr, "DestroyTiming");
		DestroyTiming_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyTiming");
		DestroyTiming_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyTiming", Classes.FEnumProperty);
		OverrideSKMTagName_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideSKMTagName");
		OverrideSKMTagName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideSKMTagName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref attached_PropertyAddress, intPtr, "attached");
		attached_Offset = NativeReflection.GetPropertyOffset(intPtr, "attached");
		attached_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "attached", Classes.FBoolProperty);
		socketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "socketName");
		socketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "socketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref offsetInLocaSpace_PropertyAddress, intPtr, "offsetInLocaSpace");
		offsetInLocaSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "offsetInLocaSpace");
		offsetInLocaSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "offsetInLocaSpace", Classes.FBoolProperty);
		locationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "locationOffset");
		locationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "locationOffset", Classes.FStructProperty);
		rotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "rotationOffset");
		rotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "rotationOffset", Classes.FStructProperty);
		scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "scale");
		scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "scale", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SnapGround_PropertyAddress, intPtr, "SnapGround");
		SnapGround_Offset = NativeReflection.GetPropertyOffset(intPtr, "SnapGround");
		SnapGround_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SnapGround", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SnapGroundRotationMode_PropertyAddress, intPtr, "SnapGroundRotationMode");
		SnapGroundRotationMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "SnapGroundRotationMode");
		SnapGroundRotationMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SnapGroundRotationMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ignoreRootBoneScale_PropertyAddress, intPtr, "ignoreRootBoneScale");
		ignoreRootBoneScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "ignoreRootBoneScale");
		ignoreRootBoneScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ignoreRootBoneScale", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SetSelfMeshParam_PropertyAddress, intPtr, "SetSelfMeshParam");
		SetSelfMeshParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetSelfMeshParam");
		SetSelfMeshParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetSelfMeshParam", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OverrideSKMBones_PropertyAddress, intPtr, "OverrideSKMBones");
		OverrideSKMBones_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideSKMBones");
		OverrideSKMBones_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideSKMBones", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideSKMSockets_PropertyAddress, intPtr, "OverrideSKMSockets");
		OverrideSKMSockets_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideSKMSockets");
		OverrideSKMSockets_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideSKMSockets", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref customParams_PropertyAddress, intPtr, "customParams");
		customParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "customParams");
		customParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "customParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DetachOnEndDispStageBegin_PropertyAddress, intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetachOnEndDispStageBegin", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableShadow_PropertyAddress, intPtr, "EnableShadow");
		EnableShadow_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableShadow");
		EnableShadow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableShadow", Classes.FBoolProperty);
		translucentSortPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "translucentSortPriority");
		translucentSortPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "translucentSortPriority", Classes.FIntProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref PauseMode_PropertyAddress, intPtr, "PauseMode");
		PauseMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "PauseMode");
		PauseMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PauseMode", Classes.FEnumProperty);
		EndStagePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndStagePriority");
		EndStagePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndStagePriority", Classes.FIntProperty);
		ForceChangeVisibleStateDEFPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceChangeVisibleStateDEFPriority");
		ForceChangeVisibleStateDEFPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceChangeVisibleStateDEFPriority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ForceVisibleStateDefaultMode_PropertyAddress, intPtr, "ForceVisibleStateDefaultMode");
		ForceVisibleStateDefaultMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "ForceVisibleStateDefaultMode");
		ForceVisibleStateDefaultMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ForceVisibleStateDefaultMode", Classes.FEnumProperty);
		CompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTag");
		CompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTag", Classes.FNameProperty);
		ScalabilitySettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "ScalabilitySettings");
		ScalabilitySettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ScalabilitySettings", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref hasAttachedSocket_PropertyAddress, intPtr, "hasAttachedSocket");
		hasAttachedSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "hasAttachedSocket");
		hasAttachedSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "hasAttachedSocket", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTimedPlayNiagaraFX:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BANS_GSTimedPlayNiagaraFX()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.BANS_GSTimedPlayNiagaraFX)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.BANS_GSTimedPlayNiagaraFX));
	}
}
