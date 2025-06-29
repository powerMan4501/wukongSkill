using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CurveFloat", "Engine", UnrealModuleType.Engine)]
public class UCurveFloat : UCurveBase
{
	private static bool GetFloatValue_IsValid;

	private static IntPtr GetFloatValue_FunctionAddress;

	private static int GetFloatValue_ParamsSize;

	private static bool GetFloatValue_InTime_IsValid;

	private static FFieldAddress GetFloatValue_InTime_PropertyAddress;

	private static int GetFloatValue_InTime_Offset;

	private static bool GetFloatValue_ReturnValue_IsValid;

	private static FFieldAddress GetFloatValue_ReturnValue_PropertyAddress;

	private static int GetFloatValue_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.CurveFloat:GetFloatValue")]
	public unsafe float GetFloatValue(float InTime)
	{
		CheckDestroyed();
		if (!GetFloatValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveFloat:GetFloatValue");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloatValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloatValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetFloatValue_InTime_Offset), 0, GetFloatValue_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFloatValue_FunctionAddress, intPtr, GetFloatValue_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloatValue_ReturnValue_Offset), 0, GetFloatValue_ReturnValue_PropertyAddress.Address);
	}

	static UCurveFloat()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCurveFloat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCurveFloat));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.CurveFloat");
		GetFloatValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFloatValue");
		GetFloatValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloatValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloatValue_InTime_PropertyAddress, GetFloatValue_FunctionAddress, "InTime");
		GetFloatValue_InTime_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatValue_FunctionAddress, "InTime");
		GetFloatValue_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatValue_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloatValue_ReturnValue_PropertyAddress, GetFloatValue_FunctionAddress, "ReturnValue");
		GetFloatValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloatValue_FunctionAddress, "ReturnValue");
		GetFloatValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloatValue_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetFloatValue_IsValid = GetFloatValue_FunctionAddress != IntPtr.Zero && GetFloatValue_InTime_IsValid && GetFloatValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveFloat:GetFloatValue", GetFloatValue_IsValid);
	}
}
