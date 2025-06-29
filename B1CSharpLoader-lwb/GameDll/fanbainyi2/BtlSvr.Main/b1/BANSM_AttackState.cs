using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BANSM_AttackState")]
internal class BANSM_AttackState : b1.BANSM_Base
{
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

	[USharpPath("/Script/b1-Managed.BANSM_AttackState:CheckState")]
	protected override bool CheckState_Implementation(UAnimSequenceBase AnimBase, float CurTime)
	{
		AnimBase.Cast<UAnimMontage>();
		float playLength = AnimBase.GetPlayLength();
		if ((double)CurTime < (double)playLength * 0.8)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANSM_AttackState:CheckState")]
	private static void CheckState__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANSM_AttackState bANSM_AttackState = GCHelper.Find<b1.BANSM_AttackState>(obj);
		UAnimSequenceBase animBase = UObjectMarshaler<UAnimSequenceBase>.FromNative(IntPtr.Add(buffer, CheckState_AnimBase_Offset));
		float curTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, CheckState_CurTime_Offset));
		bool value = bANSM_AttackState.CheckState_Implementation(animBase, curTime);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckState_ReturnValue_Offset), 0, CheckState_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BANSM_AttackState");
		CheckState_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckState");
		CheckState_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckState_FunctionAddress);
		CheckState_AnimBase_Offset = NativeReflection.GetPropertyOffset(CheckState_FunctionAddress, "AnimBase");
		CheckState_AnimBase_IsValid = NativeReflection.ValidatePropertyClass(CheckState_FunctionAddress, "AnimBase", Classes.FObjectProperty);
		CheckState_CurTime_Offset = NativeReflection.GetPropertyOffset(CheckState_FunctionAddress, "CurTime");
		CheckState_CurTime_IsValid = NativeReflection.ValidatePropertyClass(CheckState_FunctionAddress, "CurTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref CheckState_ReturnValue_PropertyAddress, CheckState_FunctionAddress, "ReturnValue");
		CheckState_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckState_FunctionAddress, "ReturnValue");
		CheckState_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckState_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckState_IsValid = CheckState_FunctionAddress != IntPtr.Zero && CheckState_AnimBase_IsValid && CheckState_CurTime_IsValid && CheckState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANSM_AttackState:CheckState", CheckState_IsValid);
	}

	static BANSM_AttackState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANSM_AttackState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANSM_AttackState));
	}
}
