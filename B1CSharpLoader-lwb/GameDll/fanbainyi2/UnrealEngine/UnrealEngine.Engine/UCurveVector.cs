using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413728uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CurveVector", "Engine", UnrealModuleType.Engine)]
public class UCurveVector : UCurveBase
{
	private static bool GetVectorValue_IsValid;

	private static IntPtr GetVectorValue_FunctionAddress;

	private static int GetVectorValue_ParamsSize;

	private static bool GetVectorValue_InTime_IsValid;

	private static FFieldAddress GetVectorValue_InTime_PropertyAddress;

	private static int GetVectorValue_InTime_Offset;

	private static bool GetVectorValue_ReturnValue_IsValid;

	private static FFieldAddress GetVectorValue_ReturnValue_PropertyAddress;

	private static int GetVectorValue_ReturnValue_Offset;

	[UFunction(Flags = 1417806851u)]
	[UMetaPath("/Script/Engine.CurveVector:GetVectorValue")]
	public unsafe FVector GetVectorValue(float InTime)
	{
		CheckDestroyed();
		if (!GetVectorValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveVector:GetVectorValue");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVectorValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVectorValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetVectorValue_InTime_Offset), 0, GetVectorValue_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVectorValue_FunctionAddress, intPtr, GetVectorValue_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetVectorValue_ReturnValue_Offset), 0, GetVectorValue_ReturnValue_PropertyAddress.Address);
	}

	static UCurveVector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCurveVector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCurveVector));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.CurveVector");
		GetVectorValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVectorValue");
		GetVectorValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVectorValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVectorValue_InTime_PropertyAddress, GetVectorValue_FunctionAddress, "InTime");
		GetVectorValue_InTime_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorValue_FunctionAddress, "InTime");
		GetVectorValue_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorValue_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetVectorValue_ReturnValue_PropertyAddress, GetVectorValue_FunctionAddress, "ReturnValue");
		GetVectorValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVectorValue_FunctionAddress, "ReturnValue");
		GetVectorValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVectorValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetVectorValue_IsValid = GetVectorValue_FunctionAddress != IntPtr.Zero && GetVectorValue_InTime_IsValid && GetVectorValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveVector:GetVectorValue", GetVectorValue_IsValid);
	}
}
