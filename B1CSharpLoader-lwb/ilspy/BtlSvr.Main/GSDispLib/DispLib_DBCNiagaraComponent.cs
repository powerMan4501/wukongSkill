using System;
using b1;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent")]
public class DispLib_DBCNiagaraComponent : UBaseEditorTickableActorComp
{
	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	private static bool DelayTimeAfterStop_IsValid;

	private static int DelayTimeAfterStop_Offset;

	private static bool DestroyTiming_IsValid;

	private static int DestroyTiming_Offset;

	private static FFieldAddress DestroyTiming_PropertyAddress;

	private static bool Template_IsValid;

	private static int Template_Offset;

	private static bool OverrideTargetMeshCompTag_IsValid;

	private static int OverrideTargetMeshCompTag_Offset;

	private static bool Attached_IsValid;

	private static int Attached_Offset;

	private static FFieldAddress Attached_PropertyAddress;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool OffsetInLocaSpace_IsValid;

	private static int OffsetInLocaSpace_Offset;

	private static FFieldAddress OffsetInLocaSpace_PropertyAddress;

	private static bool LocationOffset_IsValid;

	private static int LocationOffset_Offset;

	private static bool RotationOffset_IsValid;

	private static int RotationOffset_Offset;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	private static bool SnapGround_IsValid;

	private static int SnapGround_Offset;

	private static FFieldAddress SnapGround_PropertyAddress;

	private static bool SnapGroundRotationMode_IsValid;

	private static int SnapGroundRotationMode_Offset;

	private static FFieldAddress SnapGroundRotationMode_PropertyAddress;

	private static bool IgnoreRootBoneScale_IsValid;

	private static int IgnoreRootBoneScale_Offset;

	private static FFieldAddress IgnoreRootBoneScale_PropertyAddress;

	private static bool SetSelfMeshParam_IsValid;

	private static int SetSelfMeshParam_Offset;

	private static FFieldAddress SetSelfMeshParam_PropertyAddress;

	private static bool OverrideMeshBones_IsValid;

	private static int OverrideMeshBones_Offset;

	private static FFieldAddress OverrideMeshBones_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> OverrideMeshBones_Marshaler;

	private static bool OverrideMeshSockets_IsValid;

	private static int OverrideMeshSockets_Offset;

	private static FFieldAddress OverrideMeshSockets_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> OverrideMeshSockets_Marshaler;

	private static bool CustomParams_IsValid;

	private static int CustomParams_Offset;

	private static FFieldAddress CustomParams_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSNiagaraSysParam> CustomParams_Marshaler;

	private static bool DetachOnEndDispStageBegin_IsValid;

	private static int DetachOnEndDispStageBegin_Offset;

	private static FFieldAddress DetachOnEndDispStageBegin_PropertyAddress;

	private static bool EnableShadow_IsValid;

	private static int EnableShadow_Offset;

	private static FFieldAddress EnableShadow_PropertyAddress;

	private static bool EnableVolumetricTranslucentShadow_IsValid;

	private static int EnableVolumetricTranslucentShadow_Offset;

	private static FFieldAddress EnableVolumetricTranslucentShadow_PropertyAddress;

	private static bool TranslucentSortPriority_IsValid;

	private static int TranslucentSortPriority_Offset;

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

	private static bool MergedSettings_IsValid;

	private static int MergedSettings_Offset;

	private static bool GamePlayDispReqID_IsValid;

	private static int GamePlayDispReqID_Offset;

	private static bool HasAttachedSocket_IsValid;

	private static int HasAttachedSocket_Offset;

	private static FFieldAddress HasAttachedSocket_PropertyAddress;

	private static bool EditorPreview_NGComp_IsValid;

	private static int EditorPreview_NGComp_Offset;

	private static bool DBCRequestHasSend_IsValid;

	private static int DBCRequestHasSend_Offset;

	private static FFieldAddress DBCRequestHasSend_PropertyAddress;

	private static bool InitOver_IsValid;

	private static int InitOver_Offset;

	private static FFieldAddress InitOver_PropertyAddress;

	private static bool EndPlayInCS_IsValid;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

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
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("延迟时间")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Delay")]
	public float Delay
	{
		get
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Delay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Delay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Delay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Delay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Delay_Offset), value);
			}
		}
	}

	[DisplayName("结束模式")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndMode")]
	public DispLibDBCEndMode EndMode
	{
		get
		{
			CheckDestroyed();
			if (!EndMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndMode");
				return DispLibDBCEndMode.AutoRelease;
			}
			return EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(base.Address, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EndMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(base.Address, EndMode_Offset), 0, EndMode_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MD.ToolTip, "不大于0的值表示会以 AutoRelease 模式创建并在8s后强制销毁，大于0的值表示会以 ManualRelease 模式创建并由DBC负责按时销毁")]
	[DisplayName("持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EndMode == DispLibDBCEndMode::FixDuration")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Duration")]
	public float Duration
	{
		get
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Duration");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Duration_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Duration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Duration");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Duration_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MD.ToolTip, "逻辑通知特效可以结束或固定持续时间过后，设置特效参数 GS_EfxStop = true，此时若此参数不为0则将此值设置到特效参数 GS_EfxEndDispStageTime; EndMode 是 AutoRelease 时此参数视为0")]
	[DisplayName("结束表现时间")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DelayTimeAfterStop")]
	public float DelayTimeAfterStop
	{
		get
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DelayTimeAfterStop");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DelayTimeAfterStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DelayTimeAfterStop");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DelayTimeAfterStop_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "逻辑在何时通知特效销毁")]
	[DisplayName("销毁时机")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DestroyTiming")]
	public DispLibDBCEffectDestroyTiming DestroyTiming
	{
		get
		{
			CheckDestroyed();
			if (!DestroyTiming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DestroyTiming");
				return DispLibDBCEffectDestroyTiming.OnEndDispStageEnd;
			}
			return EnumMarshaler<DispLibDBCEffectDestroyTiming>.FromNative(IntPtr.Add(base.Address, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DestroyTiming_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DestroyTiming");
			}
			else
			{
				EnumMarshaler<DispLibDBCEffectDestroyTiming>.ToNative(IntPtr.Add(base.Address, DestroyTiming_Offset), 0, DestroyTiming_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Template")]
	public UNiagaraSystem Template
	{
		get
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Template");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, Template_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Template_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Template");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, Template_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标MeshComp")]
	[UMeta(MD.ToolTip, "目标MeshComp的tag，填 None 表示以 master 作为目标MeshComp，否则查找是否有tag对应的comp，多个结果只取第一个，没有的话使用master; 编辑器预览时忽略此参数因为 MeshCompTag 仅在运行时由逻辑注入")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OverrideTargetMeshCompTag")]
	public FName OverrideTargetMeshCompTag
	{
		get
		{
			CheckDestroyed();
			if (!OverrideTargetMeshCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OverrideTargetMeshCompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, OverrideTargetMeshCompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverrideTargetMeshCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OverrideTargetMeshCompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, OverrideTargetMeshCompTag_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "如果不勾选Attached，在编辑器非运行时的蓝图编辑界面无法看到预览特效，但把蓝图拖到场景里能看到，看不到预览不影响运行时效果")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Attached")]
	public bool Attached
	{
		get
		{
			CheckDestroyed();
			if (!Attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Attached");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Attached_Offset), 0, Attached_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Attached_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Attached");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Attached_Offset), 0, Attached_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("偏移是否基于本地空间")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OffsetInLocaSpace")]
	public bool OffsetInLocaSpace
	{
		get
		{
			CheckDestroyed();
			if (!OffsetInLocaSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OffsetInLocaSpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, OffsetInLocaSpace_Offset), 0, OffsetInLocaSpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OffsetInLocaSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OffsetInLocaSpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, OffsetInLocaSpace_Offset), 0, OffsetInLocaSpace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:LocationOffset")]
	public FVector LocationOffset
	{
		get
		{
			CheckDestroyed();
			if (!LocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:LocationOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LocationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:LocationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LocationOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:RotationOffset")]
	public FRotator RotationOffset
	{
		get
		{
			CheckDestroyed();
			if (!RotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:RotationOffset");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, RotationOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:RotationOffset");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, RotationOffset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Scale")]
	public FVector Scale
	{
		get
		{
			CheckDestroyed();
			if (!Scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Scale");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Scale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Scale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:Scale");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Scale_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("吸附地面")]
	[UMeta(MD.ToolTip, "勾选此参数，特效强制不跟随挂点且忽略 DBCOverrideTransform\r\n勾选此参数后，\r\nLocation如何计算：从配置的挂点位置（不计算配置的offset）向世界空间负Z轴打射线，命中地面后在命中点的 Location 基础上计算配置的 LocationOffset，如果勾选了【偏移是否基于本地空间】，LocationOffset 是在配置的挂点空间计算的\r\n   Rotation如何计算：命中地面后根据【吸附地面时特效朝向】决定特效朝向，但无论哪种方式都会完全忽略配置的 RotationOffset")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SnapGround")]
	public bool SnapGround
	{
		get
		{
			CheckDestroyed();
			if (!SnapGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SnapGround");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapGround_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SnapGround");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SnapGround_Offset), 0, SnapGround_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("吸附地面时特效朝向")]
	[UMeta(MDProp.EditCondition, "SnapGround == true")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SnapGroundRotationMode")]
	public DispLibDBCSnapGroundRotationMode SnapGroundRotationMode
	{
		get
		{
			CheckDestroyed();
			if (!SnapGroundRotationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SnapGroundRotationMode");
				return DispLibDBCSnapGroundRotationMode.HitPointNormalProjected;
			}
			return EnumMarshaler<DispLibDBCSnapGroundRotationMode>.FromNative(IntPtr.Add(base.Address, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapGroundRotationMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SnapGroundRotationMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCSnapGroundRotationMode>.ToNative(IntPtr.Add(base.Address, SnapGroundRotationMode_Offset), 0, SnapGroundRotationMode_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "忽略根骨骼缩放")]
	[UMeta(MD.ToolTip, "如果Attach对象是蒙皮模型，是否忽略其根骨骼的缩放，不Attach到蒙皮时此参数无效")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:IgnoreRootBoneScale")]
	public bool IgnoreRootBoneScale
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:IgnoreRootBoneScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreRootBoneScale_Offset), 0, IgnoreRootBoneScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreRootBoneScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:IgnoreRootBoneScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreRootBoneScale_Offset), 0, IgnoreRootBoneScale_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("传递自身MeshComp")]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "设置自身 SkeletalMeshComp 到特效的 User.GS_EfxSelfSkeletalMesh 或者 设置自身 StaticMeshComp 到 User.GS_EfxSelfStaticMesh")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SetSelfMeshParam")]
	public bool SetSelfMeshParam
	{
		get
		{
			CheckDestroyed();
			if (!SetSelfMeshParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SetSelfMeshParam");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SetSelfMeshParam_Offset), 0, SetSelfMeshParam_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SetSelfMeshParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:SetSelfMeshParam");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SetSelfMeshParam_Offset), 0, SetSelfMeshParam_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Override Mesh Bones")]
	[UMeta(MDProp.EditCondition, "SetSelfMeshParam")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OverrideMeshBones")]
	public TArrayReadWrite<FName> OverrideMeshBones
	{
		get
		{
			CheckDestroyed();
			if (!OverrideMeshBones_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OverrideMeshBones");
				return null;
			}
			if (OverrideMeshBones_Marshaler == null)
			{
				OverrideMeshBones_Marshaler = new TArrayReadWriteMarshaler<FName>(1, OverrideMeshBones_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return OverrideMeshBones_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideMeshBones_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Override Mesh Sockets")]
	[UMeta(MDProp.EditCondition, "SetSelfMeshParam")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OverrideMeshSockets")]
	public TArrayReadWrite<FName> OverrideMeshSockets
	{
		get
		{
			CheckDestroyed();
			if (!OverrideMeshSockets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OverrideMeshSockets");
				return null;
			}
			if (OverrideMeshSockets_Marshaler == null)
			{
				OverrideMeshSockets_Marshaler = new TArrayReadWriteMarshaler<FName>(1, OverrideMeshSockets_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return OverrideMeshSockets_Marshaler.FromNative(IntPtr.Add(base.Address, OverrideMeshSockets_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.DisplayName, "Set Custom Params ")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:CustomParams")]
	public TArrayReadWrite<FGSNiagaraSysParam> CustomParams
	{
		get
		{
			CheckDestroyed();
			if (!CustomParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:CustomParams");
				return null;
			}
			if (CustomParams_Marshaler == null)
			{
				CustomParams_Marshaler = new TArrayReadWriteMarshaler<FGSNiagaraSysParam>(1, CustomParams_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.FromNative, CachedMarshalingDelegates<FGSNiagaraSysParam, FGSNiagaraSysParam>.ToNative);
			}
			return CustomParams_Marshaler.FromNative(IntPtr.Add(base.Address, CustomParams_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "Attached")]
	[DisplayName("进入结束表现阶段时与挂点分离")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DetachOnEndDispStageBegin")]
	public bool DetachOnEndDispStageBegin
	{
		get
		{
			CheckDestroyed();
			if (!DetachOnEndDispStageBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DetachOnEndDispStageBegin");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DetachOnEndDispStageBegin_Offset), 0, DetachOnEndDispStageBegin_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DetachOnEndDispStageBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DetachOnEndDispStageBegin");
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
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EnableShadow")]
	public bool EnableShadow
	{
		get
		{
			CheckDestroyed();
			if (!EnableShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EnableShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EnableShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("透明体积阴影")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EnableVolumetricTranslucentShadow")]
	public bool EnableVolumetricTranslucentShadow
	{
		get
		{
			CheckDestroyed();
			if (!EnableVolumetricTranslucentShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EnableVolumetricTranslucentShadow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableVolumetricTranslucentShadow_Offset), 0, EnableVolumetricTranslucentShadow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableVolumetricTranslucentShadow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EnableVolumetricTranslucentShadow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableVolumetricTranslucentShadow_Offset), 0, EnableVolumetricTranslucentShadow_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:TranslucentSortPriority")]
	public int TranslucentSortPriority
	{
		get
		{
			CheckDestroyed();
			if (!TranslucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:TranslucentSortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TranslucentSortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TranslucentSortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:TranslucentSortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TranslucentSortPriority_Offset), value);
			}
		}
	}

	[UMeta(MD.ToolTip, "当触发暂停时请求方会给定一个优先级，如果此参数大于优先级则不会进入暂停逻辑")]
	[DisplayName("暂停优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:PausePriority")]
	public int PausePriority
	{
		get
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:PausePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PausePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PausePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:PausePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PausePriority_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("暂停模式")]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "进入暂停逻辑后，此配置项决定了特效的行为")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:PauseMode")]
	public DispLibDBCPauseMode PauseMode
	{
		get
		{
			CheckDestroyed();
			if (!PauseMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:PauseMode");
				return DispLibDBCPauseMode.Pause;
			}
			return EnumMarshaler<DispLibDBCPauseMode>.FromNative(IntPtr.Add(base.Address, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PauseMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:PauseMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCPauseMode>.ToNative(IntPtr.Add(base.Address, PauseMode_Offset), 0, PauseMode_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MD.ToolTip, "每次进入结束表现阶段时逻辑会给出此次结束表现阶段的优先级，不同原因触发的结束表现阶段其优先级可能不同;\n如果 此参数 < 优先级 则不会进入结束表现阶段而是直接进入销毁流程;\n正常流程下因事件到达持续时间或程序通知停止而进入结束表现阶段时逻辑给出的优先级是 -1\n因角色死亡触发结束表现阶段时逻辑给出的优先级是 0\n因角色回家或土地庙重置触发结束表现阶段时逻辑给出的优先级是 0")]
	[UProperty]
	[DisplayName("结束表现阶段优先级")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndStagePriority")]
	public int EndStagePriority
	{
		get
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndStagePriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EndStagePriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndStagePriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndStagePriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EndStagePriority_Offset), value);
			}
		}
	}

	[DisplayName("强制可见性优先级")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "当外部请求强制设置可见性时会给定一个优先级，如果此参数大于优先级则不会受此请求的影响；\n主角因为释放人种袋变身而强制隐藏所有特效时逻辑给出的优先级是 100\n主角因为进入Seq而监听宿主Actor的Hidden状态而隐藏所有特效时逻辑给出的优先级是 50\n主角因为进入Seq而强制隐藏所有特效时逻辑给出的优先级是 10")]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ForceChangeVisibleStateDEFPriority")]
	public int ForceChangeVisibleStateDEFPriority
	{
		get
		{
			CheckDestroyed();
			if (!ForceChangeVisibleStateDEFPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ForceChangeVisibleStateDEFPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForceChangeVisibleStateDEFPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceChangeVisibleStateDEFPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ForceChangeVisibleStateDEFPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForceChangeVisibleStateDEFPriority_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("强制可见性默认行为")]
	[UMeta(MD.ToolTip, "如果强制设置可见性的请求允许执行，此配置决定特效的默认行为。如果需要对指定优先级的请求有不同的行为，可改为 DataAseet 形式的 AdvanceNiagara，设置【强制可见性自定义模式】")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ForceVisibleStateDefaultMode")]
	public DispLibDBCNiagaraForceVisibleStateMode ForceVisibleStateDefaultMode
	{
		get
		{
			CheckDestroyed();
			if (!ForceVisibleStateDefaultMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ForceVisibleStateDefaultMode");
				return DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState;
			}
			return EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.FromNative(IntPtr.Add(base.Address, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceVisibleStateDefaultMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ForceVisibleStateDefaultMode");
			}
			else
			{
				EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.ToNative(IntPtr.Add(base.Address, ForceVisibleStateDefaultMode_Offset), 0, ForceVisibleStateDefaultMode_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MD.ToolTip, "创建出的特效将赋予此tag，另外由此组件创建的DBC特效会固定添加一个名为 DBCNG 的tag用以区分引擎原生Niagara组件创建的特效")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:CompTag")]
	public FName CompTag
	{
		get
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:CompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:CompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CompTag_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("DBC Scalability")]
	[UMeta(MD.ToolTip, "DBC性能控制")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ScalabilitySettings")]
	public BUC_DispLibDBC_NiagaraEventScalabilitySettings ScalabilitySettings
	{
		get
		{
			CheckDestroyed();
			if (!ScalabilitySettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ScalabilitySettings");
				return default(BUC_DispLibDBC_NiagaraEventScalabilitySettings);
			}
			return BUC_DispLibDBC_NiagaraEventScalabilitySettings.FromNative(IntPtr.Add(base.Address, ScalabilitySettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScalabilitySettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:ScalabilitySettings");
			}
			else
			{
				BUC_DispLibDBC_NiagaraEventScalabilitySettings.ToNative(IntPtr.Add(base.Address, ScalabilitySettings_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "DBC特效合并")]
	[UMeta(MDProp.EditCondition, "Template")]
	[DisplayName("DBC 特效合并")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:MergedSettings")]
	public BUC_DispLibDBC_NiagaraEventMergedSettings MergedSettings
	{
		get
		{
			CheckDestroyed();
			if (!MergedSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:MergedSettings");
				return default(BUC_DispLibDBC_NiagaraEventMergedSettings);
			}
			return BUC_DispLibDBC_NiagaraEventMergedSettings.FromNative(IntPtr.Add(base.Address, MergedSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MergedSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:MergedSettings");
			}
			else
			{
				BUC_DispLibDBC_NiagaraEventMergedSettings.ToNative(IntPtr.Add(base.Address, MergedSettings_Offset), value);
			}
		}
	}

	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:GamePlayDispReqID")]
	public int GamePlayDispReqID
	{
		get
		{
			CheckDestroyed();
			if (!GamePlayDispReqID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:GamePlayDispReqID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GamePlayDispReqID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GamePlayDispReqID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:GamePlayDispReqID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GamePlayDispReqID_Offset), value);
			}
		}
	}

	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:HasAttachedSocket")]
	public bool HasAttachedSocket
	{
		get
		{
			CheckDestroyed();
			if (!HasAttachedSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:HasAttachedSocket");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, HasAttachedSocket_Offset), 0, HasAttachedSocket_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HasAttachedSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:HasAttachedSocket");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, HasAttachedSocket_Offset), 0, HasAttachedSocket_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EditorPreview_NGComp")]
	public UNiagaraComponent EditorPreview_NGComp
	{
		get
		{
			CheckDestroyed();
			if (!EditorPreview_NGComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EditorPreview_NGComp");
				return null;
			}
			return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(base.Address, EditorPreview_NGComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EditorPreview_NGComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EditorPreview_NGComp");
			}
			else
			{
				UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(base.Address, EditorPreview_NGComp_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DBCRequestHasSend")]
	public bool DBCRequestHasSend
	{
		get
		{
			CheckDestroyed();
			if (!DBCRequestHasSend_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DBCRequestHasSend");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DBCRequestHasSend_Offset), 0, DBCRequestHasSend_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DBCRequestHasSend_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:DBCRequestHasSend");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DBCRequestHasSend_Offset), 0, DBCRequestHasSend_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:InitOver")]
	public bool InitOver
	{
		get
		{
			CheckDestroyed();
			if (!InitOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:InitOver");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InitOver_Offset), 0, InitOver_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InitOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCNiagaraComponent:InitOver");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InitOver_Offset), 0, InitOver_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Scale = FVector.OneVector;
		Attached = true;
		EndMode = DispLibDBCEndMode.ProcedureNotity;
		InitOver = false;
		if (!EditorPreview_NGComp.IsNullOrDestroyed())
		{
			EditorPreview_NGComp.DestroyComponent(GetOwner());
		}
	}

	private bool ValidateParameters()
	{
		if (Template.IsNullOrDestroyed())
		{
			return false;
		}
		return true;
	}

	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
		InitOver = false;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(this);
		if (!(bUS_GSEventCollection == null))
		{
			InitOver = true;
			bUS_GSEventCollection.Evt_OnProjectileDead += new Del_OnBulletDead(OnProjectileDead);
			Runtime_DoSpawnNiagaraByDBC();
		}
	}

	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		base.TickComponentInCS_Implementation(DeltaTime);
		if (!DBCRequestHasSend && ValidateParameters())
		{
			Runtime_DoSpawnNiagaraByDBC();
		}
	}

	private bool NeedDoDBCNiagaraMerge()
	{
		bool result = false;
		if (MergedSettings.Enable && !MergedSettings.MergeMangerSystem.IsNullOrDestroyed())
		{
			result = true;
		}
		return result;
	}

	protected void Runtime_DoSpawnNiagaraByDBC()
	{
		GamePlayDispReqID = 0;
		DBCRequestHasSend = false;
		if (!InitOver || Template.IsNullOrDestroyed())
		{
			return;
		}
		USceneComponent rootComponent = GetOwner().GetRootComponent();
		USceneComponent uSceneComponent = rootComponent;
		if (SetSelfMeshParam)
		{
			uSceneComponent = BGU_DispLibDataUtil.FindRealTargetPrimitiveComponent(rootComponent, OverrideTargetMeshCompTag);
			if (uSceneComponent.IsNullOrDestroyed())
			{
				return;
			}
			if (uSceneComponent is UStaticMeshComponent)
			{
				UStaticMesh staticMesh = (uSceneComponent as UStaticMeshComponent).StaticMesh;
				if (staticMesh.IsNullOrDestroyed() || !UGSE_StaticMeshFunLib.IsCPUAccess(staticMesh))
				{
					return;
				}
			}
			else
			{
				if (!(uSceneComponent is USkeletalMeshComponent))
				{
					return;
				}
				USkeletalMesh skeletalMesh = (uSceneComponent as USkeletalMeshComponent).SkeletalMesh;
				if (skeletalMesh.IsNullOrDestroyed() || !UGSE_SkeletalMeshFuncLib.IsCPUAccess(skeletalMesh))
				{
					return;
				}
			}
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		if (NeedDoDBCNiagaraMerge())
		{
			BUC_DispLibDBC_PlayAdvanceNiagara d = new BUC_DispLibDBC_PlayAdvanceNiagara(Delay, EndMode, Duration, DelayTimeAfterStop, DispLibAdvanceNiagaraDispLogicMode.DBCMergedSystem, DestroyTiming, Template, OverrideTargetMeshCompTag, Attached, DispLibSocketSearchMode.OnlyOriginSocket, SocketName, OffsetInLocaSpace, LocationOffset, RotationOffset, _AttachedEmitter: false, DispLibSocketSearchMode.OnlyOriginSocket, FName.None, FVector.ZeroVector, FRotator.ZeroRotator, FVector.OneVector, SnapGround, SnapGroundRotationMode, FVector4.ZeroVector, _SetDBCTransformAsParam: false, _SetSelfSKMeshParam: false, _SetMinorSKMeshParam: false, _UseExtraCustomParams: false, null, null, null, null, null, DetachOnEndDispStageBegin, DispLibAttachConstraintMode.Fixed, FVector2D.ZeroVector, EnableShadow, _EnableVolumetricTranslucentShadow: false, TranslucentSortPriority, _DeactiveAtSpawn: false, _ForcePoolModeNone: true, PausePriority, PauseMode, EndStagePriority, ForceChangeVisibleStateDEFPriority, ForceVisibleStateDefaultMode, null, CompTag, ScalabilitySettings, MergedSettings);
			GamePlayDispReqID = bUS_DispLibEventCollection.Evt_RequestSpawn_One_Advance_Niagara(d, DispLibRefParam.Instance, null, FVector.ZeroVector);
		}
		else
		{
			BUC_DispLibDBC_PlayNiagara d2 = new BUC_DispLibDBC_PlayNiagara(Delay, EndMode, Duration, DelayTimeAfterStop, DestroyTiming, Template, OverrideTargetMeshCompTag, Attached, SocketName, OffsetInLocaSpace, LocationOffset, RotationOffset, Scale, SnapGround, SnapGroundRotationMode, DetachOnEndDispStageBegin, EnableShadow, TranslucentSortPriority, _ForcePoolModeNone: true, PausePriority, PauseMode, EndStagePriority, ForceChangeVisibleStateDEFPriority, ForceVisibleStateDefaultMode, CompTag, ScalabilitySettings);
			GamePlayDispReqID = bUS_DispLibEventCollection.Evt_RequestSpawn_One_Common_Niagara(d2, DispLibRefParam.Instance);
		}
		if (GamePlayDispReqID == 0)
		{
			return;
		}
		DBCRequestHasSend = true;
		UNiagaraComponent dBCReturn_FirstNC = DispLibRefParam.Instance.DBCReturn_FirstNC;
		if (dBCReturn_FirstNC.IsNullOrDestroyed())
		{
			return;
		}
		if (IgnoreRootBoneScale)
		{
			if (uSceneComponent is USkeletalMeshComponent)
			{
				FVector scale3D = UGSE_CharacterFuncLib.GetBoneTransformByMesh(uSceneComponent as USkeletalMeshComponent, 0).GetScale3D();
				dBCReturn_FirstNC.SetRelativeScale3D(Scale * new FVector(1f / scale3D.X, 1f / scale3D.Y, 1f / scale3D.Z));
			}
			else
			{
				FVector worldScale = uSceneComponent.GetWorldScale();
				dBCReturn_FirstNC.SetRelativeScale3D(Scale * new FVector(1f / worldScale.X, 1f / worldScale.Y, 1f / worldScale.Z));
			}
		}
		else
		{
			dBCReturn_FirstNC.SetRelativeScale3D(Scale);
		}
		if (SetSelfMeshParam)
		{
			if (uSceneComponent is UStaticMeshComponent)
			{
				UNiagaraFunctionLibrary.OverrideSystemUserVariableStaticMeshComponent(dBCReturn_FirstNC, "User.GS_EfxSelfStaticMesh", uSceneComponent as UStaticMeshComponent);
			}
			else
			{
				UNiagaraFunctionLibrary.OverrideSystemUserVariableSkeletalMeshComponent(dBCReturn_FirstNC, "User.GS_EfxSelfSkeletalMesh", uSceneComponent as USkeletalMeshComponent);
				if (OverrideMeshSockets.Count != 0)
				{
					UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredSockets(dBCReturn_FirstNC, "User.GS_EfxSelfSkeletalMesh", OverrideMeshSockets.ToList());
				}
				if (OverrideMeshBones.Count != 0)
				{
					UGSE_RenderUtilFuncLib.OverrideSystemUserVariableSKMFilteredBones(dBCReturn_FirstNC, "User.GS_EfxSelfSkeletalMesh", OverrideMeshBones.ToList());
				}
			}
		}
		for (int i = 0; i < CustomParams.Count; i++)
		{
			FName name = CustomParams[i].Name;
			switch (CustomParams[i].ParamType)
			{
			case EGSNiagaraSysParamType.GSNPT_Float:
				dBCReturn_FirstNC.SetVariableFloat(name, CustomParams[i].FloatValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Int:
				dBCReturn_FirstNC.SetVariableInt(name, CustomParams[i].IntValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Vector:
				dBCReturn_FirstNC.SetVariableVec3(name, CustomParams[i].VectorValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_Bool:
				dBCReturn_FirstNC.SetVariableBool(name, CustomParams[i].BoolValue);
				break;
			case EGSNiagaraSysParamType.GSNPT_LinearColor:
				dBCReturn_FirstNC.SetVariableLinearColor(name, CustomParams[i].LinearColorValue);
				break;
			}
		}
		dBCReturn_FirstNC.ComponentTags.Add(B1GlobalFNames.DBCNG);
	}

	protected void Runtime_EndNiagaraByDBCID()
	{
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(GetOwner());
		if (bUS_DispLibEventCollection == null)
		{
			if (DBCRequestHasSend)
			{
				BGW_LogUtil.LogError("[DBC] [Error] DispLib_DBCNiagaraComponent request end niagara but BUS_DispLibEventCollection is null. TPath = " + Template.GetPathName());
			}
		}
		else
		{
			bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(GamePlayDispReqID, OnlyEndFX: true, OnlyEndProcedureEndMode: false);
			GamePlayDispReqID = 0;
		}
	}

	private void OnProjectileDead(EBGUBulletDestroyReason Reason)
	{
		Runtime_EndNiagaraByDBCID();
	}

	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndPlayInCS")]
	protected override void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		base.EndPlayInCS_Implementation(EndPlayReason);
		if (GamePlayDispReqID != 0)
		{
			Runtime_EndNiagaraByDBCID();
		}
	}

	[USharpPath("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		base.OnPropertyChanged_Implementation(MemberName, PropertyName);
		if (!EditorPreview_NGComp.IsNullOrDestroyed())
		{
			EditorPreview_NGComp.DestroyComponent(GetOwner());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndPlayInCS")]
	private static void EndPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCNiagaraComponent dispLib_DBCNiagaraComponent = GCHelper.Find<DispLib_DBCNiagaraComponent>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address);
		dispLib_DBCNiagaraComponent.EndPlayInCS_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCNiagaraComponent:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCNiagaraComponent dispLib_DBCNiagaraComponent = GCHelper.Find<DispLib_DBCNiagaraComponent>(obj);
		dispLib_DBCNiagaraComponent.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCNiagaraComponent:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCNiagaraComponent dispLib_DBCNiagaraComponent = GCHelper.Find<DispLib_DBCNiagaraComponent>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		dispLib_DBCNiagaraComponent.TickComponentInCS_Implementation(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCNiagaraComponent dispLib_DBCNiagaraComponent = GCHelper.Find<DispLib_DBCNiagaraComponent>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		dispLib_DBCNiagaraComponent.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_DBCNiagaraComponent");
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		Duration_Offset = NativeReflection.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		DelayTimeAfterStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTimeAfterStop");
		DelayTimeAfterStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTimeAfterStop", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DestroyTiming_PropertyAddress, intPtr, "DestroyTiming");
		DestroyTiming_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyTiming");
		DestroyTiming_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyTiming", Classes.FEnumProperty);
		Template_Offset = NativeReflection.GetPropertyOffset(intPtr, "Template");
		Template_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Template", Classes.FObjectProperty);
		OverrideTargetMeshCompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideTargetMeshCompTag");
		OverrideTargetMeshCompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideTargetMeshCompTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref Attached_PropertyAddress, intPtr, "Attached");
		Attached_Offset = NativeReflection.GetPropertyOffset(intPtr, "Attached");
		Attached_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Attached", Classes.FBoolProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref OffsetInLocaSpace_PropertyAddress, intPtr, "OffsetInLocaSpace");
		OffsetInLocaSpace_Offset = NativeReflection.GetPropertyOffset(intPtr, "OffsetInLocaSpace");
		OffsetInLocaSpace_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OffsetInLocaSpace", Classes.FBoolProperty);
		LocationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocationOffset");
		LocationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocationOffset", Classes.FStructProperty);
		RotationOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotationOffset");
		RotationOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotationOffset", Classes.FStructProperty);
		Scale_Offset = NativeReflection.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SnapGround_PropertyAddress, intPtr, "SnapGround");
		SnapGround_Offset = NativeReflection.GetPropertyOffset(intPtr, "SnapGround");
		SnapGround_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SnapGround", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SnapGroundRotationMode_PropertyAddress, intPtr, "SnapGroundRotationMode");
		SnapGroundRotationMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "SnapGroundRotationMode");
		SnapGroundRotationMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SnapGroundRotationMode", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IgnoreRootBoneScale_PropertyAddress, intPtr, "IgnoreRootBoneScale");
		IgnoreRootBoneScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "IgnoreRootBoneScale");
		IgnoreRootBoneScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IgnoreRootBoneScale", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SetSelfMeshParam_PropertyAddress, intPtr, "SetSelfMeshParam");
		SetSelfMeshParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "SetSelfMeshParam");
		SetSelfMeshParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SetSelfMeshParam", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OverrideMeshBones_PropertyAddress, intPtr, "OverrideMeshBones");
		OverrideMeshBones_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideMeshBones");
		OverrideMeshBones_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideMeshBones", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverrideMeshSockets_PropertyAddress, intPtr, "OverrideMeshSockets");
		OverrideMeshSockets_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideMeshSockets");
		OverrideMeshSockets_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideMeshSockets", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref CustomParams_PropertyAddress, intPtr, "CustomParams");
		CustomParams_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomParams");
		CustomParams_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomParams", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref DetachOnEndDispStageBegin_PropertyAddress, intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_Offset = NativeReflection.GetPropertyOffset(intPtr, "DetachOnEndDispStageBegin");
		DetachOnEndDispStageBegin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DetachOnEndDispStageBegin", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableShadow_PropertyAddress, intPtr, "EnableShadow");
		EnableShadow_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableShadow");
		EnableShadow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableShadow", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableVolumetricTranslucentShadow_PropertyAddress, intPtr, "EnableVolumetricTranslucentShadow");
		EnableVolumetricTranslucentShadow_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableVolumetricTranslucentShadow");
		EnableVolumetricTranslucentShadow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableVolumetricTranslucentShadow", Classes.FBoolProperty);
		TranslucentSortPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "TranslucentSortPriority");
		TranslucentSortPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TranslucentSortPriority", Classes.FIntProperty);
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
		MergedSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "MergedSettings");
		MergedSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MergedSettings", Classes.FStructProperty);
		GamePlayDispReqID_Offset = NativeReflection.GetPropertyOffset(intPtr, "GamePlayDispReqID");
		GamePlayDispReqID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GamePlayDispReqID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref HasAttachedSocket_PropertyAddress, intPtr, "HasAttachedSocket");
		HasAttachedSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "HasAttachedSocket");
		HasAttachedSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HasAttachedSocket", Classes.FBoolProperty);
		EditorPreview_NGComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "EditorPreview_NGComp");
		EditorPreview_NGComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EditorPreview_NGComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref DBCRequestHasSend_PropertyAddress, intPtr, "DBCRequestHasSend");
		DBCRequestHasSend_Offset = NativeReflection.GetPropertyOffset(intPtr, "DBCRequestHasSend");
		DBCRequestHasSend_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DBCRequestHasSend", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InitOver_PropertyAddress, intPtr, "InitOver");
		InitOver_Offset = NativeReflection.GetPropertyOffset(intPtr, "InitOver");
		InitOver_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InitOver", Classes.FBoolProperty);
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCNiagaraComponent:EndPlayInCS", EndPlayInCS_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCNiagaraComponent:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCNiagaraComponent:TickComponentInCS", TickComponentInCS_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCNiagaraComponent:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static DispLib_DBCNiagaraComponent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_DBCNiagaraComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_DBCNiagaraComponent));
	}
}
