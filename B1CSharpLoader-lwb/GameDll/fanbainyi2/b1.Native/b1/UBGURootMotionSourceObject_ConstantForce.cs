using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BGURootMotionSourceObject_ConstantForce", "b1", UnrealModuleType.Game)]
public class UBGURootMotionSourceObject_ConstantForce : UBGURootMotionSourceObject_Base
{
	private static bool ApplyRootMotionSource_IsValid;

	private static IntPtr ApplyRootMotionSource_FunctionAddress;

	private static int ApplyRootMotionSource_ParamsSize;

	private static bool ApplyRootMotionSource_WorldDirection_IsValid;

	private static FFieldAddress ApplyRootMotionSource_WorldDirection_PropertyAddress;

	private static int ApplyRootMotionSource_WorldDirection_Offset;

	private static bool ApplyRootMotionSource_Strength_IsValid;

	private static FFieldAddress ApplyRootMotionSource_Strength_PropertyAddress;

	private static int ApplyRootMotionSource_Strength_Offset;

	private static bool ApplyRootMotionSource_Duration_IsValid;

	private static FFieldAddress ApplyRootMotionSource_Duration_PropertyAddress;

	private static int ApplyRootMotionSource_Duration_Offset;

	private static bool ApplyRootMotionSource_bIsAdditive_IsValid;

	private static FFieldAddress ApplyRootMotionSource_bIsAdditive_PropertyAddress;

	private static int ApplyRootMotionSource_bIsAdditive_Offset;

	private static bool ApplyRootMotionSource_StrengthOverTime_IsValid;

	private static FFieldAddress ApplyRootMotionSource_StrengthOverTime_PropertyAddress;

	private static int ApplyRootMotionSource_StrengthOverTime_Offset;

	private static bool ApplyRootMotionSource_FinishVelocityMode_IsValid;

	private static FFieldAddress ApplyRootMotionSource_FinishVelocityMode_PropertyAddress;

	private static int ApplyRootMotionSource_FinishVelocityMode_Offset;

	private static bool ApplyRootMotionSource_FinishSetVelocity_IsValid;

	private static FFieldAddress ApplyRootMotionSource_FinishSetVelocity_PropertyAddress;

	private static int ApplyRootMotionSource_FinishSetVelocity_Offset;

	private static bool ApplyRootMotionSource_FinishClampVelocity_IsValid;

	private static FFieldAddress ApplyRootMotionSource_FinishClampVelocity_PropertyAddress;

	private static int ApplyRootMotionSource_FinishClampVelocity_Offset;

	private static bool ApplyRootMotionSource_bEnableGravity_IsValid;

	private static FFieldAddress ApplyRootMotionSource_bEnableGravity_PropertyAddress;

	private static int ApplyRootMotionSource_bEnableGravity_Offset;

	private static bool ApplyRootMotionSource_ReturnValue_IsValid;

	private static FFieldAddress ApplyRootMotionSource_ReturnValue_PropertyAddress;

	private static int ApplyRootMotionSource_ReturnValue_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BGURootMotionSourceObject_ConstantForce:ApplyRootMotionSource")]
	public unsafe bool ApplyRootMotionSource(FVector WorldDirection, float Strength, float Duration, bool bIsAdditive, UCurveFloat StrengthOverTime, ERootMotionFinishVelocityMode FinishVelocityMode, FVector FinishSetVelocity, float FinishClampVelocity, bool bEnableGravity)
	{
		CheckDestroyed();
		if (!ApplyRootMotionSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGURootMotionSourceObject_ConstantForce:ApplyRootMotionSource");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyRootMotionSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyRootMotionSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_WorldDirection_Offset), 0, ApplyRootMotionSource_WorldDirection_PropertyAddress.Address, WorldDirection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_Strength_Offset), 0, ApplyRootMotionSource_Strength_PropertyAddress.Address, Strength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_Duration_Offset), 0, ApplyRootMotionSource_Duration_PropertyAddress.Address, Duration);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_bIsAdditive_Offset), 0, ApplyRootMotionSource_bIsAdditive_PropertyAddress.Address, bIsAdditive);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_StrengthOverTime_Offset), 0, ApplyRootMotionSource_StrengthOverTime_PropertyAddress.Address, StrengthOverTime);
		EnumMarshaler<ERootMotionFinishVelocityMode>.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_FinishVelocityMode_Offset), 0, ApplyRootMotionSource_FinishVelocityMode_PropertyAddress.Address, FinishVelocityMode);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_FinishSetVelocity_Offset), 0, ApplyRootMotionSource_FinishSetVelocity_PropertyAddress.Address, FinishSetVelocity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_FinishClampVelocity_Offset), 0, ApplyRootMotionSource_FinishClampVelocity_PropertyAddress.Address, FinishClampVelocity);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyRootMotionSource_bEnableGravity_Offset), 0, ApplyRootMotionSource_bEnableGravity_PropertyAddress.Address, bEnableGravity);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyRootMotionSource_FunctionAddress, intPtr, ApplyRootMotionSource_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ApplyRootMotionSource_ReturnValue_Offset), 0, ApplyRootMotionSource_ReturnValue_PropertyAddress.Address);
	}

	static UBGURootMotionSourceObject_ConstantForce()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGURootMotionSourceObject_ConstantForce)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGURootMotionSourceObject_ConstantForce));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGURootMotionSourceObject_ConstantForce");
		ApplyRootMotionSource_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ApplyRootMotionSource");
		ApplyRootMotionSource_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyRootMotionSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_WorldDirection_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "WorldDirection");
		ApplyRootMotionSource_WorldDirection_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "WorldDirection");
		ApplyRootMotionSource_WorldDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "WorldDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_Strength_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "Strength");
		ApplyRootMotionSource_Strength_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "Strength");
		ApplyRootMotionSource_Strength_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "Strength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_Duration_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "Duration");
		ApplyRootMotionSource_Duration_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "Duration");
		ApplyRootMotionSource_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_bIsAdditive_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "bIsAdditive");
		ApplyRootMotionSource_bIsAdditive_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "bIsAdditive");
		ApplyRootMotionSource_bIsAdditive_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "bIsAdditive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_StrengthOverTime_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "StrengthOverTime");
		ApplyRootMotionSource_StrengthOverTime_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "StrengthOverTime");
		ApplyRootMotionSource_StrengthOverTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "StrengthOverTime", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_FinishVelocityMode_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "FinishVelocityMode");
		ApplyRootMotionSource_FinishVelocityMode_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "FinishVelocityMode");
		ApplyRootMotionSource_FinishVelocityMode_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "FinishVelocityMode", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_FinishSetVelocity_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "FinishSetVelocity");
		ApplyRootMotionSource_FinishSetVelocity_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "FinishSetVelocity");
		ApplyRootMotionSource_FinishSetVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "FinishSetVelocity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_FinishClampVelocity_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "FinishClampVelocity");
		ApplyRootMotionSource_FinishClampVelocity_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "FinishClampVelocity");
		ApplyRootMotionSource_FinishClampVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "FinishClampVelocity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_bEnableGravity_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "bEnableGravity");
		ApplyRootMotionSource_bEnableGravity_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "bEnableGravity");
		ApplyRootMotionSource_bEnableGravity_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "bEnableGravity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyRootMotionSource_ReturnValue_PropertyAddress, ApplyRootMotionSource_FunctionAddress, "ReturnValue");
		ApplyRootMotionSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyRootMotionSource_FunctionAddress, "ReturnValue");
		ApplyRootMotionSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyRootMotionSource_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ApplyRootMotionSource_IsValid = ApplyRootMotionSource_FunctionAddress != IntPtr.Zero && ApplyRootMotionSource_WorldDirection_IsValid && ApplyRootMotionSource_Strength_IsValid && ApplyRootMotionSource_Duration_IsValid && ApplyRootMotionSource_bIsAdditive_IsValid && ApplyRootMotionSource_StrengthOverTime_IsValid && ApplyRootMotionSource_FinishVelocityMode_IsValid && ApplyRootMotionSource_FinishSetVelocity_IsValid && ApplyRootMotionSource_FinishClampVelocity_IsValid && ApplyRootMotionSource_bEnableGravity_IsValid && ApplyRootMotionSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGURootMotionSourceObject_ConstantForce:ApplyRootMotionSource", ApplyRootMotionSource_IsValid);
	}
}
