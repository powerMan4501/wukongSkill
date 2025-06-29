using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("播放Seq")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq")]
internal class BED_BehaviorNode_PlayLevelSeq : b1.BED_BehaviorNode_Action
{
	private static bool SequenceID_IsValid;

	private static int SequenceID_Offset;

	private static bool UsePlayerCamera_IsValid;

	private static int UsePlayerCamera_Offset;

	private static FFieldAddress UsePlayerCamera_PropertyAddress;

	private static bool StartTime_IsValid;

	private static int StartTime_Offset;

	private static bool IsDisableMovementInput_IsValid;

	private static int IsDisableMovementInput_Offset;

	private static FFieldAddress IsDisableMovementInput_PropertyAddress;

	private static bool IsDisableLookAtInput_IsValid;

	private static int IsDisableLookAtInput_Offset;

	private static FFieldAddress IsDisableLookAtInput_PropertyAddress;

	private static bool IsHideHud_IsValid;

	private static int IsHideHud_Offset;

	private static FFieldAddress IsHideHud_PropertyAddress;

	private static bool IsDisableCameraCuts_IsValid;

	private static int IsDisableCameraCuts_Offset;

	private static FFieldAddress IsDisableCameraCuts_PropertyAddress;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("Sequence")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:SequenceID")]
	public int SequenceID
	{
		get
		{
			CheckDestroyed();
			if (!SequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:SequenceID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SequenceID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequenceID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:SequenceID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SequenceID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("使用主角相机")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:UsePlayerCamera")]
	public bool UsePlayerCamera
	{
		get
		{
			CheckDestroyed();
			if (!UsePlayerCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:UsePlayerCamera");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePlayerCamera_Offset), 0, UsePlayerCamera_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePlayerCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:UsePlayerCamera");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePlayerCamera_Offset), 0, UsePlayerCamera_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("StartTime")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:StartTime")]
	public float StartTime
	{
		get
		{
			CheckDestroyed();
			if (!StartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:StartTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:StartTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("DisableMovement")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableMovementInput")]
	public bool IsDisableMovementInput
	{
		get
		{
			CheckDestroyed();
			if (!IsDisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableMovementInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDisableMovementInput_Offset), 0, IsDisableMovementInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDisableMovementInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableMovementInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDisableMovementInput_Offset), 0, IsDisableMovementInput_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("DisableLookatinput")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableLookAtInput")]
	public bool IsDisableLookAtInput
	{
		get
		{
			CheckDestroyed();
			if (!IsDisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableLookAtInput");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDisableLookAtInput_Offset), 0, IsDisableLookAtInput_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDisableLookAtInput_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableLookAtInput");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDisableLookAtInput_Offset), 0, IsDisableLookAtInput_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("HideHud")]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsHideHud")]
	public bool IsHideHud
	{
		get
		{
			CheckDestroyed();
			if (!IsHideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsHideHud");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsHideHud_Offset), 0, IsHideHud_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsHideHud_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsHideHud");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsHideHud_Offset), 0, IsHideHud_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("DisableCameraCuts")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableCameraCuts")]
	public bool IsDisableCameraCuts
	{
		get
		{
			CheckDestroyed();
			if (!IsDisableCameraCuts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableCameraCuts");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsDisableCameraCuts_Offset), 0, IsDisableCameraCuts_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsDisableCameraCuts_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:IsDisableCameraCuts");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsDisableCameraCuts_Offset), 0, IsDisableCameraCuts_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.BehaviorNode.PlayLevelSeq;
	}

	public override byte[] GetCustomData()
	{
		return new BehaviorCustom_PlayLevelSequence
		{
			SequenceId = SequenceID,
			StartTime = StartTime,
			IsUsePlayerCamera = UsePlayerCamera,
			IsDisableMovementInput = IsDisableMovementInput,
			IsDisableLookAtInput = IsDisableLookAtInput,
			IsHideHud = IsHideHud,
			IsDisableCameraCuts = IsDisableCameraCuts
		}.ToByteArray();
	}

	[USharpPath("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		return $"播放Seq：{SequenceID},";
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_BehaviorNode_PlayLevelSeq bED_BehaviorNode_PlayLevelSeq = GCHelper.Find<b1.BED_BehaviorNode_PlayLevelSeq>(obj);
		string nodeDescriptionInCS_Implementation = bED_BehaviorNode_PlayLevelSeq.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq");
		SequenceID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SequenceID");
		SequenceID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SequenceID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref UsePlayerCamera_PropertyAddress, intPtr, "UsePlayerCamera");
		UsePlayerCamera_Offset = NativeReflection.GetPropertyOffset(intPtr, "UsePlayerCamera");
		UsePlayerCamera_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UsePlayerCamera", Classes.FBoolProperty);
		StartTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartTime");
		StartTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsDisableMovementInput_PropertyAddress, intPtr, "IsDisableMovementInput");
		IsDisableMovementInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsDisableMovementInput");
		IsDisableMovementInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsDisableMovementInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDisableLookAtInput_PropertyAddress, intPtr, "IsDisableLookAtInput");
		IsDisableLookAtInput_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsDisableLookAtInput");
		IsDisableLookAtInput_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsDisableLookAtInput", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsHideHud_PropertyAddress, intPtr, "IsHideHud");
		IsHideHud_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsHideHud");
		IsHideHud_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsHideHud", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsDisableCameraCuts_PropertyAddress, intPtr, "IsDisableCameraCuts");
		IsDisableCameraCuts_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsDisableCameraCuts");
		IsDisableCameraCuts_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsDisableCameraCuts", Classes.FBoolProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_BehaviorNode_PlayLevelSeq:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_BehaviorNode_PlayLevelSeq()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_BehaviorNode_PlayLevelSeq)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_BehaviorNode_PlayLevelSeq));
	}
}
