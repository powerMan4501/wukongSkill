using System;
using System.Text;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Play Level Sequence")]
[Placeable(false)]
[UClass]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence")]
internal class BED_ProcessStateNode_PlayLevelSequence : BED_ProcessStateNode
{
	private static bool SequenceId_IsValid;

	private static int SequenceId_Offset;

	private static bool bUsePlayerCamera_IsValid;

	private static int bUsePlayerCamera_Offset;

	private static FFieldAddress bUsePlayerCamera_PropertyAddress;

	private static bool StartTime_IsValid;

	private static int StartTime_Offset;

	private static bool bTriggerTransBack_IsValid;

	private static int bTriggerTransBack_Offset;

	private static FFieldAddress bTriggerTransBack_PropertyAddress;

	private static bool bTriggerMonsterGoHome_IsValid;

	private static int bTriggerMonsterGoHome_Offset;

	private static FFieldAddress bTriggerMonsterGoHome_PropertyAddress;

	private static bool bDisableMovementInput_IsValid;

	private static int bDisableMovementInput_Offset;

	private static FFieldAddress bDisableMovementInput_PropertyAddress;

	private static bool bDisableLookAtInput_IsValid;

	private static int bDisableLookAtInput_Offset;

	private static FFieldAddress bDisableLookAtInput_PropertyAddress;

	private static bool bUseCrane_IsValid;

	private static int bUseCrane_Offset;

	private static FFieldAddress bUseCrane_PropertyAddress;

	private static bool bUseRail_IsValid;

	private static int bUseRail_Offset;

	private static FFieldAddress bUseRail_PropertyAddress;

	private static bool bHidePlayer_IsValid;

	private static int bHidePlayer_Offset;

	private static FFieldAddress bHidePlayer_PropertyAddress;

	private static bool bHideHud_IsValid;

	private static int bHideHud_Offset;

	private static FFieldAddress bHideHud_PropertyAddress;

	private static bool bDisableCameraCuts_IsValid;

	private static int bDisableCameraCuts_Offset;

	private static FFieldAddress bDisableCameraCuts_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Play")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:SequenceId")]
	public int SequenceId
	{
		get
		{
			CheckDestroyed();
			if (!SequenceId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:SequenceId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SequenceId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequenceId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:SequenceId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SequenceId_Offset), value);
			}
		}
	}

	[DisplayName("使用主角摄像机")]
	[Category("Play")]
	[Tooltip("不使用Sequence内的摄像机")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUsePlayerCamera")]
	public bool bUsePlayerCamera
	{
		get
		{
			CheckDestroyed();
			if (!bUsePlayerCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUsePlayerCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUsePlayerCamera_Offset), 0, bUsePlayerCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUsePlayerCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUsePlayerCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUsePlayerCamera_Offset), 0, bUsePlayerCamera_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Play")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:StartTime")]
	public float StartTime
	{
		get
		{
			CheckDestroyed();
			if (!StartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:StartTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:StartTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("是否姿态回归")]
	[Category("Play")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bTriggerTransBack")]
	public bool bTriggerTransBack
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerTransBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bTriggerTransBack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerTransBack_Offset), 0, bTriggerTransBack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerTransBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bTriggerTransBack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerTransBack_Offset), 0, bTriggerTransBack_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Play")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("是否触发怪物回家")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bTriggerMonsterGoHome")]
	public bool bTriggerMonsterGoHome
	{
		get
		{
			CheckDestroyed();
			if (!bTriggerMonsterGoHome_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bTriggerMonsterGoHome");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bTriggerMonsterGoHome_Offset), 0, bTriggerMonsterGoHome_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bTriggerMonsterGoHome_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bTriggerMonsterGoHome");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bTriggerMonsterGoHome_Offset), 0, bTriggerMonsterGoHome_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[Category("Camera")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableMovementInput")]
	public bool bDisableMovementInput
	{
		get
		{
			CheckDestroyed();
			if (!bDisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableMovementInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableMovementInput_Offset), 0, bDisableMovementInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableMovementInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableMovementInput_Offset), 0, bDisableMovementInput_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableLookAtInput")]
	public bool bDisableLookAtInput
	{
		get
		{
			CheckDestroyed();
			if (!bDisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableLookAtInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableLookAtInput_Offset), 0, bDisableLookAtInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableLookAtInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableLookAtInput_Offset), 0, bDisableLookAtInput_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[Category("Camera")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUseCrane")]
	public bool bUseCrane
	{
		get
		{
			CheckDestroyed();
			if (!bUseCrane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUseCrane");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCrane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUseCrane");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCrane_Offset), 0, bUseCrane_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Camera")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUseRail")]
	public bool bUseRail
	{
		get
		{
			CheckDestroyed();
			if (!bUseRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUseRail");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseRail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bUseRail");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseRail_Offset), 0, bUseRail_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[Category("Camera")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bHidePlayer")]
	public bool bHidePlayer
	{
		get
		{
			CheckDestroyed();
			if (!bHidePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bHidePlayer");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHidePlayer_Offset), 0, bHidePlayer_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHidePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bHidePlayer");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHidePlayer_Offset), 0, bHidePlayer_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bHideHud")]
	public bool bHideHud
	{
		get
		{
			CheckDestroyed();
			if (!bHideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bHideHud");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHideHud_Offset), 0, bHideHud_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bHideHud");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHideHud_Offset), 0, bHideHud_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Camera")]
	[UMeta(MDProp.EditCondition, "!bUsePlayerCamera")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableCameraCuts")]
	public bool bDisableCameraCuts
	{
		get
		{
			CheckDestroyed();
			if (!bDisableCameraCuts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableCameraCuts");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDisableCameraCuts_Offset), 0, bDisableCameraCuts_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDisableCameraCuts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:bDisableCameraCuts");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDisableCameraCuts_Offset), 0, bDisableCameraCuts_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		StartTime = 0f;
		bDisableMovementInput = true;
		bDisableLookAtInput = true;
		bHidePlayer = false;
		bHideHud = true;
		bUsePlayerCamera = false;
		bTriggerTransBack = true;
		bTriggerMonsterGoHome = true;
		SetNodeCategory("World");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
		base.InputPins.Clear();
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Start
		});
		base.InputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Stop
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.PreStart
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Started
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Completed
		});
		base.OutputPins.Add(new FCalliopePin
		{
			PinName = BGW_FlowUtils.PinName.Stopped
		});
	}

	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"Sequence Id: {SequenceId}");
		stringBuilder.AppendLine($"起始时间:{StartTime}");
		if (bUsePlayerCamera)
		{
			stringBuilder.Append("使用主角摄像机 ");
		}
		else
		{
			stringBuilder.Append(bDisableMovementInput ? "禁用移动输入 " : "启用移动输入 ");
			stringBuilder.Append(bDisableLookAtInput ? "禁用镜头输入 " : "启用镜头输入 ");
			stringBuilder.AppendLine();
			stringBuilder.Append(bHidePlayer ? "隐藏主角 " : "显示主角 ");
			stringBuilder.Append(bHideHud ? "隐藏HUD " : "显示HUD ");
		}
		return stringBuilder.ToString();
	}

	public override string GetNodeName()
	{
		return "Process.State.PlayLevelSequence";
	}

	public override byte[] GetCustomData()
	{
		return new ProcessStateCustom_PlayLevelSequence
		{
			SequenceId = SequenceId,
			StartTime = StartTime,
			IsDisableMovementInput = bDisableMovementInput,
			IsDisableLookAtInput = bDisableLookAtInput,
			IsHidePlayer = bHidePlayer,
			IsHideHud = bHideHud,
			IsDisableCameraCuts = bDisableCameraCuts,
			IsUseCrane = bUseCrane,
			IsUseRail = bUseRail,
			IsUsePlayerCamera = bUsePlayerCamera,
			IsTriggerTransback = bTriggerTransBack,
			IsTriggerMonsterGoHome = bTriggerMonsterGoHome
		}.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_ProcessStateNode_PlayLevelSequence bED_ProcessStateNode_PlayLevelSequence = GCHelper.Find<b1.BED_ProcessStateNode_PlayLevelSequence>(obj);
		string nodeDescriptionInCS_Implementation = bED_ProcessStateNode_PlayLevelSequence.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence");
		SequenceId_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceId");
		SequenceId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bUsePlayerCamera_PropertyAddress, intPtr, "bUsePlayerCamera");
		bUsePlayerCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUsePlayerCamera");
		bUsePlayerCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUsePlayerCamera", Classes.FBoolProperty);
		StartTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartTime");
		StartTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bTriggerTransBack_PropertyAddress, intPtr, "bTriggerTransBack");
		bTriggerTransBack_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTriggerTransBack");
		bTriggerTransBack_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTriggerTransBack", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bTriggerMonsterGoHome_PropertyAddress, intPtr, "bTriggerMonsterGoHome");
		bTriggerMonsterGoHome_Offset = NativeReflection.GetPropertyOffset(intPtr, "bTriggerMonsterGoHome");
		bTriggerMonsterGoHome_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bTriggerMonsterGoHome", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableMovementInput_PropertyAddress, intPtr, "bDisableMovementInput");
		bDisableMovementInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableMovementInput");
		bDisableMovementInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableMovementInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableLookAtInput_PropertyAddress, intPtr, "bDisableLookAtInput");
		bDisableLookAtInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableLookAtInput");
		bDisableLookAtInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableLookAtInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseCrane_PropertyAddress, intPtr, "bUseCrane");
		bUseCrane_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseCrane");
		bUseCrane_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseCrane", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bUseRail_PropertyAddress, intPtr, "bUseRail");
		bUseRail_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseRail");
		bUseRail_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseRail", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHidePlayer_PropertyAddress, intPtr, "bHidePlayer");
		bHidePlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHidePlayer");
		bHidePlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHidePlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bHideHud_PropertyAddress, intPtr, "bHideHud");
		bHideHud_Offset = NativeReflection.GetPropertyOffset(intPtr, "bHideHud");
		bHideHud_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bHideHud", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bDisableCameraCuts_PropertyAddress, intPtr, "bDisableCameraCuts");
		bDisableCameraCuts_Offset = NativeReflection.GetPropertyOffset(intPtr, "bDisableCameraCuts");
		bDisableCameraCuts_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bDisableCameraCuts", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_ProcessStateNode_PlayLevelSequence:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_ProcessStateNode_PlayLevelSequence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_ProcessStateNode_PlayLevelSequence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_ProcessStateNode_PlayLevelSequence));
	}
}
