using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BANSM_AttackRotation")]
internal class BANSM_AttackRotation : b1.BANSM_MarkFoot
{
	private static bool MinFootOnGroundCanRotate_IsValid;

	private static int MinFootOnGroundCanRotate_Offset;

	private static bool MaxFootOnGroundCanRotate_IsValid;

	private static int MaxFootOnGroundCanRotate_Offset;

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

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANSM_AttackRotation:MinFootOnGroundCanRotate")]
	public int MinFootOnGroundCanRotate
	{
		get
		{
			CheckDestroyed();
			if (!MinFootOnGroundCanRotate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_AttackRotation:MinFootOnGroundCanRotate");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinFootOnGroundCanRotate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinFootOnGroundCanRotate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_AttackRotation:MinFootOnGroundCanRotate");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinFootOnGroundCanRotate_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANSM_AttackRotation:MaxFootOnGroundCanRotate")]
	public int MaxFootOnGroundCanRotate
	{
		get
		{
			CheckDestroyed();
			if (!MaxFootOnGroundCanRotate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_AttackRotation:MaxFootOnGroundCanRotate");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxFootOnGroundCanRotate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxFootOnGroundCanRotate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANSM_AttackRotation:MaxFootOnGroundCanRotate");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxFootOnGroundCanRotate_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANSM_AttackRotation:CheckState")]
	protected override bool CheckState_Implementation(UAnimSequenceBase AnimBase, float CurTime)
	{
		int num = 0;
		foreach (FName footName in base.FootNames)
		{
			FTransform fTransform = FTransform.Identity;
			UAnimMontage uAnimMontage = AnimBase.Cast<UAnimMontage>();
			if (uAnimMontage != null)
			{
				fTransform = UGSE_AnimFuncLib.Montage_GetBoneTransformCS(uAnimMontage, CurTime, footName, base.SlotName, bExtractRootMotion: false);
			}
			else
			{
				UAnimSequence uAnimSequence = AnimBase.Cast<UAnimSequence>();
				if (uAnimSequence != null)
				{
					fTransform = UGSE_AnimFuncLib.Sequence_GetBoneTransformCS(uAnimSequence, CurTime, footName);
				}
			}
			if (fTransform.Translation.Z > base.DistTolerance)
			{
				num++;
			}
		}
		if (num >= MinFootOnGroundCanRotate && num <= MaxFootOnGroundCanRotate)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_AttackRotation:CheckState")]
	private static void CheckState__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_AttackRotation bANSM_AttackRotation = GCHelper.Find<b1.BANSM_AttackRotation>(obj);
		UAnimSequenceBase animBase = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(buffer, CheckState_AnimBase_Offset));
		float curTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CheckState_CurTime_Offset));
		bool value = bANSM_AttackRotation.CheckState_Implementation(animBase, curTime);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckState_ReturnValue_Offset), 0, CheckState_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANSM_AttackRotation");
		MinFootOnGroundCanRotate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinFootOnGroundCanRotate");
		MinFootOnGroundCanRotate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinFootOnGroundCanRotate", Classes.FIntProperty);
		MaxFootOnGroundCanRotate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxFootOnGroundCanRotate");
		MaxFootOnGroundCanRotate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxFootOnGroundCanRotate", Classes.FIntProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_AttackRotation:CheckState", CheckState_IsValid);
	}

	static BANSM_AttackRotation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANSM_AttackRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANSM_AttackRotation));
	}
}
