using System;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/UMG.WidgetAnimation", "UMG", UnrealModuleType.Engine)]
public class UWidgetAnimation : UMovieSceneSequence
{
	private static bool GetStartTime_IsValid;

	private static IntPtr GetStartTime_FunctionAddress;

	private static int GetStartTime_ParamsSize;

	private static bool GetStartTime_ReturnValue_IsValid;

	private static FFieldAddress GetStartTime_ReturnValue_PropertyAddress;

	private static int GetStartTime_ReturnValue_Offset;

	private static bool GetEndTime_IsValid;

	private static IntPtr GetEndTime_FunctionAddress;

	private static int GetEndTime_ParamsSize;

	private static bool GetEndTime_ReturnValue_IsValid;

	private static FFieldAddress GetEndTime_ReturnValue_PropertyAddress;

	private static int GetEndTime_ReturnValue_Offset;

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/UMG.WidgetAnimation:GetStartTime")]
	public unsafe float GetStartTime()
	{
		CheckDestroyed();
		if (!GetStartTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetAnimation:GetStartTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartTime_FunctionAddress, intPtr, GetStartTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStartTime_ReturnValue_Offset), 0, GetStartTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418243u)]
	[UMetaPath("/Script/UMG.WidgetAnimation:GetEndTime")]
	public unsafe float GetEndTime()
	{
		CheckDestroyed();
		if (!GetEndTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.WidgetAnimation:GetEndTime");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndTime_FunctionAddress, intPtr, GetEndTime_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEndTime_ReturnValue_Offset), 0, GetEndTime_ReturnValue_PropertyAddress.Address);
	}

	static UWidgetAnimation()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWidgetAnimation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWidgetAnimation));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UMG.WidgetAnimation");
		GetStartTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartTime");
		GetStartTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartTime_ReturnValue_PropertyAddress, GetStartTime_FunctionAddress, "ReturnValue");
		GetStartTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartTime_FunctionAddress, "ReturnValue");
		GetStartTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStartTime_IsValid = GetStartTime_FunctionAddress != IntPtr.Zero && GetStartTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetAnimation:GetStartTime", GetStartTime_IsValid);
		GetEndTime_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEndTime");
		GetEndTime_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndTime_ReturnValue_PropertyAddress, GetEndTime_FunctionAddress, "ReturnValue");
		GetEndTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndTime_FunctionAddress, "ReturnValue");
		GetEndTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndTime_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEndTime_IsValid = GetEndTime_FunctionAddress != IntPtr.Zero && GetEndTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.WidgetAnimation:GetEndTime", GetEndTime_IsValid);
	}
}
