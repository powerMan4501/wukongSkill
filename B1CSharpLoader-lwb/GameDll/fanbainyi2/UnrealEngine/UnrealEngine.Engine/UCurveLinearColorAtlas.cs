using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CurveLinearColorAtlas", "Engine", UnrealModuleType.Engine)]
public class UCurveLinearColorAtlas : UTexture2D
{
	private static bool GetCurvePosition_IsValid;

	private static IntPtr GetCurvePosition_FunctionAddress;

	private static int GetCurvePosition_ParamsSize;

	private static bool GetCurvePosition_InCurve_IsValid;

	private static FFieldAddress GetCurvePosition_InCurve_PropertyAddress;

	private static int GetCurvePosition_InCurve_Offset;

	private static bool GetCurvePosition_Position_IsValid;

	private static FFieldAddress GetCurvePosition_Position_PropertyAddress;

	private static int GetCurvePosition_Position_Offset;

	private static bool GetCurvePosition_ReturnValue_IsValid;

	private static FFieldAddress GetCurvePosition_ReturnValue_PropertyAddress;

	private static int GetCurvePosition_ReturnValue_Offset;

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Engine.CurveLinearColorAtlas:GetCurvePosition")]
	public unsafe bool GetCurvePosition(UCurveLinearColor InCurve, out float Position)
	{
		CheckDestroyed();
		if (!GetCurvePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.CurveLinearColorAtlas:GetCurvePosition");
			Position = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurvePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurvePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(intPtr, GetCurvePosition_InCurve_Offset), 0, GetCurvePosition_InCurve_PropertyAddress.Address, InCurve);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurvePosition_FunctionAddress, intPtr, GetCurvePosition_ParamsSize);
		Position = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetCurvePosition_Position_Offset), 0, GetCurvePosition_Position_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetCurvePosition_ReturnValue_Offset), 0, GetCurvePosition_ReturnValue_PropertyAddress.Address);
	}

	static UCurveLinearColorAtlas()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCurveLinearColorAtlas)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCurveLinearColorAtlas));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.CurveLinearColorAtlas");
		GetCurvePosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCurvePosition");
		GetCurvePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurvePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurvePosition_InCurve_PropertyAddress, GetCurvePosition_FunctionAddress, "InCurve");
		GetCurvePosition_InCurve_Offset = NativeReflectionCached.GetPropertyOffset(GetCurvePosition_FunctionAddress, "InCurve");
		GetCurvePosition_InCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurvePosition_FunctionAddress, "InCurve", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurvePosition_Position_PropertyAddress, GetCurvePosition_FunctionAddress, "Position");
		GetCurvePosition_Position_Offset = NativeReflectionCached.GetPropertyOffset(GetCurvePosition_FunctionAddress, "Position");
		GetCurvePosition_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurvePosition_FunctionAddress, "Position", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurvePosition_ReturnValue_PropertyAddress, GetCurvePosition_FunctionAddress, "ReturnValue");
		GetCurvePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurvePosition_FunctionAddress, "ReturnValue");
		GetCurvePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurvePosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetCurvePosition_IsValid = GetCurvePosition_FunctionAddress != IntPtr.Zero && GetCurvePosition_InCurve_IsValid && GetCurvePosition_Position_IsValid && GetCurvePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.CurveLinearColorAtlas:GetCurvePosition", GetCurvePosition_IsValid);
	}
}
