using System;
using System.Collections.Generic;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[DisplayName("BAN DispLib Play Niagara FX")]
[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX")]
public class BAN_GSPlayNiagaraFX : BAN_GSBase
{
	private static bool EditorActive_IsValid;

	private static int EditorActive_Offset;

	private static FFieldAddress EditorActive_PropertyAddress;

	private static bool template_IsValid;

	private static int template_Offset;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

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

	private static bool attachLocationMode_IsValid;

	private static int attachLocationMode_Offset;

	private static FFieldAddress attachLocationMode_PropertyAddress;

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

	private static bool DBC_IdentityID_IsValid;

	private static int DBC_IdentityID_Offset;

	private static bool hasAttachedSocket_IsValid;

	private static int hasAttachedSocket_Offset;

	private static FFieldAddress hasAttachedSocket_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GetAnimNType_IsValid;

	private static IntPtr GetAnimNType_FunctionAddress;

	private static int GetAnimNType_ParamsSize;

	private static bool GetAnimNType_ReturnValue_IsValid;

	private static int GetAnimNType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNType_ReturnValue_PropertyAddress;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("Editor Active")]
	[UMeta(MD.ToolTip, "关闭后编辑器下不会播放当前效果，不影响运行时")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EditorActive")]
	public bool EditorActive
	{
		get
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EditorActive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorActive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EditorActive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorActive_Offset), 0, EditorActive_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:template")]
	public TSoftObject<UNiagaraSystem> template
	{
		get
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:template");
				return default(TSoftObject<UNiagaraSystem>);
			}
			return TSoftObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:template");
			}
			else
			{
				TSoftObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, template_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("持续时间")]
	[UMeta(MD.ToolTip, "不大于0的值表示会以 AutoRelease 模式创建并在8s后强制销毁，大于0的值表示会以 ManualRelease 模式创建并由DBC负责按时销毁")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("结束表现时间")]
	[UMeta(MD.ToolTip, "若不为0设置特效参数 GS_EfxEndDispStageTime; 逻辑通知特效可以结束或固定持续时间过后，设置特效参数 GS_EfxStop = true; EndMode 是 AutoRelease 时视为0")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DelayTimeAfterStop")]
	public float DelayTimeAfterStop
	{
		get
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DelayTimeAfterStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DelayTimeAfterStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "逻辑在何时通知特效销毁")]
	[DisplayName("销毁时机")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DestroyTiming")]
	public DispLibDBCEffectDestroyTiming DestroyTiming
	{
		get
		{
			CheckDestroyed();
			if (!DestroyTiming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DestroyTiming");
				return DispLibDBCEffectDestroyTiming.OnEndDispStageEnd;
			}
			return EnumMarshaler<DispLibDBCEffectDestroyTiming>.FromNative(IntPtr.Add(base.Address, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DestroyTiming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DestroyTiming");
			}
			else
			{
				EnumMarshaler<DispLibDBCEffectDestroyTiming>.ToNative(IntPtr.Add(base.Address, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MD.ToolTip, "填写目标Comp的tag，为None表示以master作为目标骨骼，否则查找tag对应的骨骼，多个结果只取第一个; 编辑器预览时忽略此参数因为MeshTag仅在运行时由逻辑注入")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标MeshComp")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:OverrideSKMTagName")]
	public FName OverrideSKMTagName
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSKMTagName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:OverrideSKMTagName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OverrideSKMTagName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideSKMTagName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:OverrideSKMTagName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OverrideSKMTagName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:attached")]
	public bool attached
	{
		get
		{
			CheckDestroyed();
			if (!attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:attached");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, attached_Offset), 0, attached_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:attached");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, attached_Offset), 0, attached_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Attach Location Mode")]
	[UMeta(MDProp.EditCondition, "attached")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:attachLocationMode")]
	public EAttachLocation attachLocationMode
	{
		get
		{
			CheckDestroyed();
			if (!attachLocationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:attachLocationMode");
				return EAttachLocation.KeepRelativeOffset;
			}
			return EnumMarshaler<EAttachLocation>.FromNative(IntPtr.Add(base.Address, attachLocationMode_Offset), 0, attachLocationMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!attachLocationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:attachLocationMode");
			}
			else
			{
				EnumMarshaler<EAttachLocation>.ToNative(IntPtr.Add(base.Address, attachLocationMode_Offset), 0, attachLocationMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta("AnimNotifyBoneName", "true")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:socketName")]
	public FName socketName
	{
		get
		{
			CheckDestroyed();
			if (!socketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:socketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, socketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!socketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:socketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, socketName_Offset), value);
			}
		}
	}

	[DisplayName("偏移是否基于本地空间")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:offsetInLocaSpace")]
	public bool offsetInLocaSpace
	{
		get
		{
			CheckDestroyed();
			if (!offsetInLocaSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:offsetInLocaSpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, offsetInLocaSpace_Offset), 0, offsetInLocaSpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!offsetInLocaSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:offsetInLocaSpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, offsetInLocaSpace_Offset), 0, offsetInLocaSpace_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:locationOffset")]
	public FVector locationOffset
	{
		get
		{
			CheckDestroyed();
			if (!locationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:locationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, locationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!locationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:locationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, locationOffset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:rotationOffset")]
	public FRotator rotationOffset
	{
		get
		{
			CheckDestroyed();
			if (!rotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:rotationOffset");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, rotationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!rotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:rotationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, rotationOffset_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:scale")]
	public FVector scale
	{
		get
		{
			CheckDestroyed();
			if (!scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:scale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, scale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:scale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, scale_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("吸附地面")]
	[UMeta(MD.ToolTip, "勾选此参数，特效强制不跟随挂点且忽略 DBCOverrideTransform\r\n勾选此参数后，\r\nLocation如何计算：从配置的挂点位置（不计算配置的offset）向世界空间负Z轴打射线，命中地面后在命中点的 Location 基础上计算配置的 LocationOffset，如果勾选了【偏移是否基于本地空间】，LocationOffset 是在配置的挂点空间计算的\r\n   Rotation如何计算：命中地面后根据【吸附地面时特效朝向】决定特效朝向，但无论哪种方式都会完全忽略配置的 RotationOffset")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SnapGround")]
	public bool SnapGround
	{
		get
		{
			CheckDestroyed();
			if (!SnapGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SnapGround");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SnapGround");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "SnapGround == true")]
	[DisplayName("吸附地面时特效朝向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SnapGroundRotationMode")]
	public DispLibDBCSnapGroundRotationMode SnapGroundRotationMode
	{
		get
		{
			CheckDestroyed();
			if (!SnapGroundRotationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SnapGroundRotationMode");
				return DispLibDBCSnapGroundRotationMode.HitPointNormalProjected;
			}
			return EnumMarshaler<DispLibDBCSnapGroundRotationMode>.FromNative(IntPtr.Add(base.Address, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapGroundRotationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SnapGroundRotationMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCSnapGroundRotationMode>.ToNative(IntPtr.Add(base.Address, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MD.DisplayName, "Ignore Root Bone Scale")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ignoreRootBoneScale")]
	public bool ignoreRootBoneScale
	{
		get
		{
			CheckDestroyed();
			if (!ignoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ignoreRootBoneScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ignoreRootBoneScale_Offset), 0, ignoreRootBoneScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ignoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ignoreRootBoneScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ignoreRootBoneScale_Offset), 0, ignoreRootBoneScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "设置自身Mesh参数")]
	[UMeta(MD.ToolTip, "当【目标MeshComp】有效时，设置重定向后的Mesh到特效")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SetSelfMeshParam")]
	public bool SetSelfMeshParam
	{
		get
		{
			CheckDestroyed();
			if (!SetSelfMeshParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SetSelfMeshParam");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SetSelfMeshParam_Offset), 0, SetSelfMeshParam_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SetSelfMeshParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:SetSelfMeshParam");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SetSelfMeshParam_Offset), 0, SetSelfMeshParam_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Override SKM Bones")]
	[UMeta(MDProp.EditCondition, "SetSelfMeshParam")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:OverrideSKMBones")]
	public TArrayReadWrite<FName> OverrideSKMBones
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSKMBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:OverrideSKMBones");
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
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:OverrideSKMSockets")]
	public TArrayReadWrite<FName> OverrideSKMSockets
	{
		get
		{
			CheckDestroyed();
			if (!OverrideSKMSockets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:OverrideSKMSockets");
				return null;
			}
			if (OverrideSKMSockets_Marshaler == null)
			{
				OverrideSKMSockets_Marshaler = new TArrayReadWriteMarshaler<FName>(1, OverrideSKMSockets_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return OverrideSKMSockets_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideSKMSockets_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MD.DisplayName, "Set Custom Params ")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:customParams")]
	public TArrayReadWrite<FGSNiagaraSysParam> customParams
	{
		get
		{
			CheckDestroyed();
			if (!customParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:customParams");
				return null;
			}
			if (customParams_Marshaler == null)
			{
				customParams_Marshaler = new TArrayReadWriteMarshaler<FGSNiagaraSysParam>(1, customParams_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.FromNative, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.ToNative);
			}
			return customParams_Marshaler.FromNative(IntPtr.Add(base.Address, customParams_Offset));
		}
	}

	[UMeta(MDProp.EditCondition, "attached")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("结束表现阶段与挂点分离")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DetachOnEndDispStageBegin")]
	public bool DetachOnEndDispStageBegin
	{
		get
		{
			CheckDestroyed();
			if (!DetachOnEndDispStageBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DetachOnEndDispStageBegin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachOnEndDispStageBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DetachOnEndDispStageBegin");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("阴影")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EnableShadow")]
	public bool EnableShadow
	{
		get
		{
			CheckDestroyed();
			if (!EnableShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EnableShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EnableShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:translucentSortPriority")]
	public int translucentSortPriority
	{
		get
		{
			CheckDestroyed();
			if (!translucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:translucentSortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, translucentSortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!translucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:translucentSortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, translucentSortPriority_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("暂停优先级")]
	[UMeta(MD.ToolTip, "当触发暂停时请求方会给定一个优先级，如果此参数大于优先级则不会进入暂停逻辑")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:PausePriority")]
	public int PausePriority
	{
		get
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:PausePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PausePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:PausePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PausePriority_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("暂停模式")]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "进入暂停逻辑后，此配置项决定了特效的行为")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:PauseMode")]
	public DispLibDBCPauseMode PauseMode
	{
		get
		{
			CheckDestroyed();
			if (!PauseMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:PauseMode");
				return DispLibDBCPauseMode.Pause;
			}
			return EnumMarshaler<DispLibDBCPauseMode>.FromNative(IntPtr.Add(base.Address, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PauseMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:PauseMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCPauseMode>.ToNative(IntPtr.Add(base.Address, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("结束表现阶段优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "角色死亡时各种效果默认不进入结束表现阶段，如果此效果需要进入则填写1")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EndStagePriority")]
	public int EndStagePriority
	{
		get
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EndStagePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EndStagePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:EndStagePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EndStagePriority_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("强制可见性优先级")]
	[UMeta(MD.ToolTip, "当外部请求强制设置可见性时会给定一个优先级，如果此参数大于优先级则不会受此请求的影响；\n主角因为释放人种袋变身而强制隐藏所有特效时逻辑给出的优先级是 100\n主角因为进入Seq而监听宿主Actor的Hidden状态而隐藏所有特效时逻辑给出的优先级是 50\n主角因为进入Seq而强制隐藏所有特效时逻辑给出的优先级是 10")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ForceChangeVisibleStateDEFPriority")]
	public int ForceChangeVisibleStateDEFPriority
	{
		get
		{
			CheckDestroyed();
			if (!ForceChangeVisibleStateDEFPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ForceChangeVisibleStateDEFPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForceChangeVisibleStateDEFPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceChangeVisibleStateDEFPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ForceChangeVisibleStateDEFPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForceChangeVisibleStateDEFPriority_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "如果强制设置可见性的请求允许执行，此配置决定特效的默认行为。如果需要对指定优先级的请求有不同的行为，可改为 DataAseet 形式的 AdvanceNiagara，设置【强制可见性自定义模式】")]
	[DisplayName("强制可见性默认行为")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ForceVisibleStateDefaultMode")]
	public DispLibDBCNiagaraForceVisibleStateMode ForceVisibleStateDefaultMode
	{
		get
		{
			CheckDestroyed();
			if (!ForceVisibleStateDefaultMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ForceVisibleStateDefaultMode");
				return DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState;
			}
			return EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.FromNative(IntPtr.Add(base.Address, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceVisibleStateDefaultMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ForceVisibleStateDefaultMode");
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
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:CompTag")]
	public FName CompTag
	{
		get
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:CompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:CompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CompTag_Offset), value);
			}
		}
	}

	[DisplayName("DBC Scalability")]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "DBC性能控制")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ScalabilitySettings")]
	public BUC_DispLibDBC_NiagaraEventScalabilitySettings ScalabilitySettings
	{
		get
		{
			CheckDestroyed();
			if (!ScalabilitySettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ScalabilitySettings");
				return default(BUC_DispLibDBC_NiagaraEventScalabilitySettings);
			}
			return BUC_DispLibDBC_NiagaraEventScalabilitySettings.FromNative(IntPtr.Add(base.Address, ScalabilitySettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScalabilitySettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:ScalabilitySettings");
			}
			else
			{
				BUC_DispLibDBC_NiagaraEventScalabilitySettings.ToNative(IntPtr.Add(base.Address, ScalabilitySettings_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DBC_IdentityID")]
	public int DBC_IdentityID
	{
		get
		{
			CheckDestroyed();
			if (!DBC_IdentityID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DBC_IdentityID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DBC_IdentityID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DBC_IdentityID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:DBC_IdentityID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DBC_IdentityID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:hasAttachedSocket")]
	public bool hasAttachedSocket
	{
		get
		{
			CheckDestroyed();
			if (!hasAttachedSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:hasAttachedSocket");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, hasAttachedSocket_Offset), 0, hasAttachedSocket_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!hasAttachedSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayNiagaraFX:hasAttachedSocket");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, hasAttachedSocket_Offset), 0, hasAttachedSocket_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GetAnimNType")]
	protected override EGsEnAnimN GetAnimNType_Implementation()
	{
		return EGsEnAnimN.PlayerNiagaraFX;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		scale = FVector.OneVector;
		attached = true;
		attachLocationMode = EAttachLocation.KeepRelativeOffset;
		ignoreRootBoneScale = true;
		socketName = FName.None;
		hasAttachedSocket = false;
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

	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		UAnimSequenceBase animation = NotifyParam.Animation;
		if (ValidateParameters(meshComp))
		{
			GetValidResource(template);
			SpawnNiagaraCompByDBC(meshComp, animation);
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GetSoftReferences")]
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

	protected UNiagaraComponent SpawnNiagaraCompByDBC(USkeletalMeshComponent SourceDispOwnerComp, UAnimSequenceBase Animation)
	{
		return Runtime_DoSpawnNiagaraByDBC(SourceDispOwnerComp, Animation);
	}

	protected UNiagaraComponent Runtime_DoSpawnNiagaraByDBC(USkeletalMeshComponent SourceDispOwnerComp, UAnimSequenceBase Animation)
	{
		if (template.IsNull)
		{
			return null;
		}
		AActor owner = SourceDispOwnerComp.GetOwner();
		if (owner.IsNullOrDestroyed())
		{
			return null;
		}
		USkeletalMeshComponent uSkeletalMeshComponent = null;
		if (SetSelfMeshParam)
		{
			uSkeletalMeshComponent = BGU_DispLibDataUtil.FindRealTargetSkeletalMeshComp(SourceDispOwnerComp, OverrideSKMTagName);
			if (uSkeletalMeshComponent == null)
			{
				return null;
			}
			if (!UGSE_SkeletalMeshFuncLib.IsCPUAccess(uSkeletalMeshComponent.SkeletalMesh))
			{
				return null;
			}
		}
		if (template.Value == null)
		{
			if (base.isPreload)
			{
				return null;
			}
			SyncLoadSoftPathObjAndAddPreloadedAsset<UNiagaraSystem>(template.ObjectPath.Path);
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(owner);
		uint uniqueID = GetUniqueID();
		BUC_DispLibDBC_PlayNiagara d = new BUC_DispLibDBC_PlayNiagara(0f, (Duration > 0f) ? DispLibDBCEndMode.FixDuration : DispLibDBCEndMode.AutoRelease, Duration, DelayTimeAfterStop, DestroyTiming, template.Value, OverrideSKMTagName, attached, socketName, offsetInLocaSpace, locationOffset, rotationOffset, scale, SnapGround, SnapGroundRotationMode, DetachOnEndDispStageBegin, EnableShadow, translucentSortPriority, _ForcePoolModeNone: false, PausePriority, PauseMode, EndStagePriority, ForceChangeVisibleStateDEFPriority, ForceVisibleStateDefaultMode, CompTag, ScalabilitySettings);
		if (bUS_DispLibEventCollection == null)
		{
			BWS_DispLibEventCollection.Get(DispLibDispWorld.GetInstance(owner)).Evt_RequestSpawn_One_Common_Niagara(SourceDispOwnerComp, d, DispLibRefParam.Instance, DBCTransformParam.Default, DBCSetCallbackParams.Default, uniqueID);
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
			FVector scale3D = UGSE_CharacterFuncLib.GetBoneTransformByMesh(SourceDispOwnerComp, 0).GetScale3D();
			new FVector(1f / scale3D.X, 1f / scale3D.Y, 1f / scale3D.Z);
			dBCReturn_FirstNC.SetRelativeScale3D(scale * new FVector(1f / scale3D.X, 1f / scale3D.Y, 1f / scale3D.Z));
		}
		else
		{
			dBCReturn_FirstNC.SetRelativeScale3D(scale);
		}
		if (SetSelfMeshParam)
		{
			UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(dBCReturn_FirstNC, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxSelfSkeletalMesh.PlainName, uSkeletalMeshComponent);
			if (OverrideSKMSockets.Count != 0)
			{
				UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredSockets(dBCReturn_FirstNC, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxSelfSkeletalMesh.PlainName, OverrideSKMSockets.ToList());
			}
			if (OverrideSKMBones.Count != 0)
			{
				UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredBones(dBCReturn_FirstNC, BGW_DispLibGameDB.GameDBDataAsset.FNameCacheDA.EfxSelfSkeletalMesh.PlainName, OverrideSKMBones.ToList());
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

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSPlayNiagaraFX bAN_GSPlayNiagaraFX = GCHelper.Find<BAN_GSPlayNiagaraFX>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSPlayNiagaraFX.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GetAnimNType")]
	private static void GetAnimNType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSPlayNiagaraFX bAN_GSPlayNiagaraFX = GCHelper.Find<BAN_GSPlayNiagaraFX>(obj);
		EGsEnAnimN animNType_Implementation = bAN_GSPlayNiagaraFX.GetAnimNType_Implementation();
		EnumMarshaler<EGsEnAnimN>.ToNative(IntPtr.Add(buffer, GetAnimNType_ReturnValue_Offset), 0, GetAnimNType_ReturnValue_PropertyAddress.Address, animNType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSPlayNiagaraFX bAN_GSPlayNiagaraFX = GCHelper.Find<BAN_GSPlayNiagaraFX>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bAN_GSPlayNiagaraFX.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayNiagaraFX");
		NativeReflection.GetPropertyRef(ref EditorActive_PropertyAddress, intPtr, "EditorActive");
		EditorActive_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorActive");
		EditorActive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorActive", Classes.FBoolProperty);
		template_Offset = NativeReflection.GetPropertyOffset(intPtr, "template");
		template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "template", Classes.FSoftObjectProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
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
		NativeReflection.GetPropertyRef(ref attachLocationMode_PropertyAddress, intPtr, "attachLocationMode");
		attachLocationMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "attachLocationMode");
		attachLocationMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "attachLocationMode", Classes.FEnumProperty);
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
		DBC_IdentityID_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBC_IdentityID");
		DBC_IdentityID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBC_IdentityID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref hasAttachedSocket_PropertyAddress, intPtr, "hasAttachedSocket");
		hasAttachedSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "hasAttachedSocket");
		hasAttachedSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "hasAttachedSocket", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GSNotifyCS", GSNotifyCS_IsValid);
		GetAnimNType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNType");
		GetAnimNType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNType_ReturnValue_PropertyAddress, GetAnimNType_FunctionAddress, "ReturnValue");
		GetAnimNType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNType_FunctionAddress, "ReturnValue");
		GetAnimNType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNType_IsValid = GetAnimNType_FunctionAddress != IntPtr.Zero && GetAnimNType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GetAnimNType", GetAnimNType_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayNiagaraFX:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BAN_GSPlayNiagaraFX()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSPlayNiagaraFX)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSPlayNiagaraFX));
	}
}
