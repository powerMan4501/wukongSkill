using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BANSM_MarkFoot")]
internal class BANSM_MarkFoot : b1.BANSM_Base
{
	private static bool FootNames_IsValid;

	private static int FootNames_Offset;

	private static FFieldAddress FootNames_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> FootNames_Marshaler;

	private static bool SlotName_IsValid;

	private static int SlotName_Offset;

	private static bool DistTolerance_IsValid;

	private static int DistTolerance_Offset;

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

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANSM_MarkFoot:FootNames")]
	public TArrayReadWrite<FName> FootNames
	{
		get
		{
			CheckDestroyed();
			if (!FootNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_MarkFoot:FootNames");
				return null;
			}
			if (FootNames_Marshaler == null)
			{
				FootNames_Marshaler = new TArrayReadWriteMarshaler<FName>(1, FootNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return FootNames_Marshaler.FromNative(IntPtr.Add(base.Address, FootNames_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANSM_MarkFoot:SlotName")]
	public FName SlotName
	{
		get
		{
			CheckDestroyed();
			if (!SlotName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_MarkFoot:SlotName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SlotName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SlotName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_MarkFoot:SlotName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SlotName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANSM_MarkFoot:DistTolerance")]
	public float DistTolerance
	{
		get
		{
			CheckDestroyed();
			if (!DistTolerance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_MarkFoot:DistTolerance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistTolerance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistTolerance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_MarkFoot:DistTolerance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistTolerance_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SlotName = B1GlobalFNames.DefaultSlot;
	}

	[USharpPath("/Script/b1-Managed.BANSM_MarkFoot:CheckState")]
	protected override bool CheckState_Implementation(UAnimSequenceBase AnimBase, float CurTime)
	{
		float num = 0f;
		foreach (FName footName in FootNames)
		{
			FTransform fTransform = FTransform.Identity;
			UAnimMontage uAnimMontage = AnimBase.Cast<UAnimMontage>();
			if (uAnimMontage != null)
			{
				fTransform = UGSE_AnimFuncLib.Montage_GetBoneTransformCS(uAnimMontage, CurTime, footName, SlotName, bExtractRootMotion: false);
			}
			else
			{
				UAnimSequence uAnimSequence = AnimBase.Cast<UAnimSequence>();
				if (uAnimSequence != null)
				{
					fTransform = UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(uAnimSequence, CurTime, footName);
				}
			}
			num += fTransform.Translation.Z;
		}
		return num < DistTolerance;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_MarkFoot:CheckState")]
	private static void CheckState__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_MarkFoot bANSM_MarkFoot = GCHelper.Find<b1.BANSM_MarkFoot>(obj);
		UAnimSequenceBase animBase = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(buffer, CheckState_AnimBase_Offset));
		float curTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CheckState_CurTime_Offset));
		bool value = bANSM_MarkFoot.CheckState_Implementation(animBase, curTime);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckState_ReturnValue_Offset), 0, CheckState_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANSM_MarkFoot");
		NativeReflection.GetPropertyRef(ref FootNames_PropertyAddress, intPtr, "FootNames");
		FootNames_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootNames");
		FootNames_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootNames", Classes.FArrayProperty);
		SlotName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SlotName");
		SlotName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SlotName", Classes.FNameProperty);
		DistTolerance_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistTolerance");
		DistTolerance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistTolerance", Classes.FFloatProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_MarkFoot:CheckState", CheckState_IsValid);
	}

	static BANSM_MarkFoot()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANSM_MarkFoot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANSM_MarkFoot));
	}
}
