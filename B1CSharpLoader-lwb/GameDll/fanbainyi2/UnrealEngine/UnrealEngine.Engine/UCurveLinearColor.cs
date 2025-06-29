using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818946208uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CurveLinearColor", "Engine", UnrealModuleType.Engine)]
public class UCurveLinearColor : UCurveBase
{
	private static bool GetUnadjustedLinearColorValue_IsValid;

	private static IntPtr GetUnadjustedLinearColorValue_FunctionAddress;

	private static int GetUnadjustedLinearColorValue_ParamsSize;

	private static bool GetUnadjustedLinearColorValue_InTime_IsValid;

	private static FFieldAddress GetUnadjustedLinearColorValue_InTime_PropertyAddress;

	private static int GetUnadjustedLinearColorValue_InTime_Offset;

	private static bool GetUnadjustedLinearColorValue_ReturnValue_IsValid;

	private static FFieldAddress GetUnadjustedLinearColorValue_ReturnValue_PropertyAddress;

	private static int GetUnadjustedLinearColorValue_ReturnValue_Offset;

	private static bool GetLinearColorValue_IsValid;

	private static IntPtr GetLinearColorValue_FunctionAddress;

	private static int GetLinearColorValue_ParamsSize;

	private static bool GetLinearColorValue_InTime_IsValid;

	private static FFieldAddress GetLinearColorValue_InTime_PropertyAddress;

	private static int GetLinearColorValue_InTime_Offset;

	private static bool GetLinearColorValue_ReturnValue_IsValid;

	private static FFieldAddress GetLinearColorValue_ReturnValue_PropertyAddress;

	private static int GetLinearColorValue_ReturnValue_Offset;

	private static bool GetClampedLinearColorValue_IsValid;

	private static IntPtr GetClampedLinearColorValue_FunctionAddress;

	private static int GetClampedLinearColorValue_ParamsSize;

	private static bool GetClampedLinearColorValue_InTime_IsValid;

	private static FFieldAddress GetClampedLinearColorValue_InTime_PropertyAddress;

	private static int GetClampedLinearColorValue_InTime_Offset;

	private static bool GetClampedLinearColorValue_ReturnValue_IsValid;

	private static FFieldAddress GetClampedLinearColorValue_ReturnValue_PropertyAddress;

	private static int GetClampedLinearColorValue_ReturnValue_Offset;

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.CurveLinearColor:GetUnadjustedLinearColorValue")]
	public unsafe FLinearColor GetUnadjustedLinearColorValue(float InTime)
	{
		CheckDestroyed();
		if (!GetUnadjustedLinearColorValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveLinearColor:GetUnadjustedLinearColorValue");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUnadjustedLinearColorValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUnadjustedLinearColorValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetUnadjustedLinearColorValue_InTime_Offset), 0, GetUnadjustedLinearColorValue_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUnadjustedLinearColorValue_FunctionAddress, intPtr, GetUnadjustedLinearColorValue_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetUnadjustedLinearColorValue_ReturnValue_Offset), 0, GetUnadjustedLinearColorValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.CurveLinearColor:GetLinearColorValue")]
	public unsafe FLinearColor GetLinearColorValue(float InTime)
	{
		CheckDestroyed();
		if (!GetLinearColorValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveLinearColor:GetLinearColorValue");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearColorValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearColorValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetLinearColorValue_InTime_Offset), 0, GetLinearColorValue_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLinearColorValue_FunctionAddress, intPtr, GetLinearColorValue_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetLinearColorValue_ReturnValue_Offset), 0, GetLinearColorValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.CurveLinearColor:GetClampedLinearColorValue")]
	public unsafe FLinearColor GetClampedLinearColorValue(float InTime)
	{
		CheckDestroyed();
		if (!GetClampedLinearColorValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveLinearColor:GetClampedLinearColorValue");
			return default(FLinearColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetClampedLinearColorValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetClampedLinearColorValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetClampedLinearColorValue_InTime_Offset), 0, GetClampedLinearColorValue_InTime_PropertyAddress.Address, InTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetClampedLinearColorValue_FunctionAddress, intPtr, GetClampedLinearColorValue_ParamsSize);
		return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetClampedLinearColorValue_ReturnValue_Offset), 0, GetClampedLinearColorValue_ReturnValue_PropertyAddress.Address);
	}

	static UCurveLinearColor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCurveLinearColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCurveLinearColor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.CurveLinearColor");
		GetUnadjustedLinearColorValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUnadjustedLinearColorValue");
		GetUnadjustedLinearColorValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUnadjustedLinearColorValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUnadjustedLinearColorValue_InTime_PropertyAddress, GetUnadjustedLinearColorValue_FunctionAddress, "InTime");
		GetUnadjustedLinearColorValue_InTime_Offset = NativeReflectionCached.GetPropertyOffset(GetUnadjustedLinearColorValue_FunctionAddress, "InTime");
		GetUnadjustedLinearColorValue_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnadjustedLinearColorValue_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUnadjustedLinearColorValue_ReturnValue_PropertyAddress, GetUnadjustedLinearColorValue_FunctionAddress, "ReturnValue");
		GetUnadjustedLinearColorValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUnadjustedLinearColorValue_FunctionAddress, "ReturnValue");
		GetUnadjustedLinearColorValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUnadjustedLinearColorValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUnadjustedLinearColorValue_IsValid = GetUnadjustedLinearColorValue_FunctionAddress != IntPtr.Zero && GetUnadjustedLinearColorValue_InTime_IsValid && GetUnadjustedLinearColorValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveLinearColor:GetUnadjustedLinearColorValue", GetUnadjustedLinearColorValue_IsValid);
		GetLinearColorValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLinearColorValue");
		GetLinearColorValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearColorValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearColorValue_InTime_PropertyAddress, GetLinearColorValue_FunctionAddress, "InTime");
		GetLinearColorValue_InTime_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearColorValue_FunctionAddress, "InTime");
		GetLinearColorValue_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearColorValue_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearColorValue_ReturnValue_PropertyAddress, GetLinearColorValue_FunctionAddress, "ReturnValue");
		GetLinearColorValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearColorValue_FunctionAddress, "ReturnValue");
		GetLinearColorValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearColorValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLinearColorValue_IsValid = GetLinearColorValue_FunctionAddress != IntPtr.Zero && GetLinearColorValue_InTime_IsValid && GetLinearColorValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveLinearColor:GetLinearColorValue", GetLinearColorValue_IsValid);
		GetClampedLinearColorValue_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetClampedLinearColorValue");
		GetClampedLinearColorValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetClampedLinearColorValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetClampedLinearColorValue_InTime_PropertyAddress, GetClampedLinearColorValue_FunctionAddress, "InTime");
		GetClampedLinearColorValue_InTime_Offset = NativeReflectionCached.GetPropertyOffset(GetClampedLinearColorValue_FunctionAddress, "InTime");
		GetClampedLinearColorValue_InTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClampedLinearColorValue_FunctionAddress, "InTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetClampedLinearColorValue_ReturnValue_PropertyAddress, GetClampedLinearColorValue_FunctionAddress, "ReturnValue");
		GetClampedLinearColorValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetClampedLinearColorValue_FunctionAddress, "ReturnValue");
		GetClampedLinearColorValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClampedLinearColorValue_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetClampedLinearColorValue_IsValid = GetClampedLinearColorValue_FunctionAddress != IntPtr.Zero && GetClampedLinearColorValue_InTime_IsValid && GetClampedLinearColorValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveLinearColor:GetClampedLinearColorValue", GetClampedLinearColorValue_IsValid);
	}
}
