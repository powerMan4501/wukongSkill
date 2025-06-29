using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)818938017uL, Config = "Engine")]
[UMetaPath("/Script/Engine.CurveBase", "Engine", UnrealModuleType.Engine)]
public class UCurveBase : UObject
{
	private static bool GetValueRange_IsValid;

	private static IntPtr GetValueRange_FunctionAddress;

	private static int GetValueRange_ParamsSize;

	private static bool GetValueRange_MinValue_IsValid;

	private static FFieldAddress GetValueRange_MinValue_PropertyAddress;

	private static int GetValueRange_MinValue_Offset;

	private static bool GetValueRange_MaxValue_IsValid;

	private static FFieldAddress GetValueRange_MaxValue_PropertyAddress;

	private static int GetValueRange_MaxValue_Offset;

	private static bool GetTimeRange_IsValid;

	private static IntPtr GetTimeRange_FunctionAddress;

	private static int GetTimeRange_ParamsSize;

	private static bool GetTimeRange_MinTime_IsValid;

	private static FFieldAddress GetTimeRange_MinTime_PropertyAddress;

	private static int GetTimeRange_MinTime_Offset;

	private static bool GetTimeRange_MaxTime_IsValid;

	private static FFieldAddress GetTimeRange_MaxTime_PropertyAddress;

	private static int GetTimeRange_MaxTime_Offset;

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.CurveBase:GetValueRange")]
	public unsafe void GetValueRange(out float MinValue, out float MaxValue)
	{
		CheckDestroyed();
		if (!GetValueRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveBase:GetValueRange");
			MinValue = 0f;
			MaxValue = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetValueRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetValueRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetValueRange_FunctionAddress, intPtr, GetValueRange_ParamsSize);
		MinValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetValueRange_MinValue_Offset), 0, GetValueRange_MinValue_PropertyAddress.Address);
		MaxValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetValueRange_MaxValue_Offset), 0, GetValueRange_MaxValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Engine.CurveBase:GetTimeRange")]
	public unsafe void GetTimeRange(out float MinTime, out float MaxTime)
	{
		CheckDestroyed();
		if (!GetTimeRange_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveBase:GetTimeRange");
			MinTime = 0f;
			MaxTime = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimeRange_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimeRange_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTimeRange_FunctionAddress, intPtr, GetTimeRange_ParamsSize);
		MinTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTimeRange_MinTime_Offset), 0, GetTimeRange_MinTime_PropertyAddress.Address);
		MaxTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTimeRange_MaxTime_Offset), 0, GetTimeRange_MaxTime_PropertyAddress.Address);
	}

	static UCurveBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCurveBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCurveBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.CurveBase");
		GetValueRange_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetValueRange");
		GetValueRange_ParamsSize = NativeReflection.GetFunctionParamsSize(GetValueRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetValueRange_MinValue_PropertyAddress, GetValueRange_FunctionAddress, "MinValue");
		GetValueRange_MinValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueRange_FunctionAddress, "MinValue");
		GetValueRange_MinValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueRange_FunctionAddress, "MinValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetValueRange_MaxValue_PropertyAddress, GetValueRange_FunctionAddress, "MaxValue");
		GetValueRange_MaxValue_Offset = NativeReflectionCached.GetPropertyOffset(GetValueRange_FunctionAddress, "MaxValue");
		GetValueRange_MaxValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetValueRange_FunctionAddress, "MaxValue", Classes.FFloatProperty);
		GetValueRange_IsValid = GetValueRange_FunctionAddress != IntPtr.Zero && GetValueRange_MinValue_IsValid && GetValueRange_MaxValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveBase:GetValueRange", GetValueRange_IsValid);
		GetTimeRange_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTimeRange");
		GetTimeRange_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimeRange_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimeRange_MinTime_PropertyAddress, GetTimeRange_FunctionAddress, "MinTime");
		GetTimeRange_MinTime_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeRange_FunctionAddress, "MinTime");
		GetTimeRange_MinTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeRange_FunctionAddress, "MinTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTimeRange_MaxTime_PropertyAddress, GetTimeRange_FunctionAddress, "MaxTime");
		GetTimeRange_MaxTime_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeRange_FunctionAddress, "MaxTime");
		GetTimeRange_MaxTime_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeRange_FunctionAddress, "MaxTime", Classes.FFloatProperty);
		GetTimeRange_IsValid = GetTimeRange_FunctionAddress != IntPtr.Zero && GetTimeRange_MinTime_IsValid && GetTimeRange_MaxTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveBase:GetTimeRange", GetTimeRange_IsValid);
	}
}
