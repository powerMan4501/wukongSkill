using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.VOIPStatics", "Engine", UnrealModuleType.Engine)]
public class UVOIPStatics : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetMicThreshold_IsValid;

	private static IntPtr SetMicThreshold_FunctionAddress;

	private static int SetMicThreshold_ParamsSize;

	private static bool SetMicThreshold_InThreshold_IsValid;

	private static FFieldAddress SetMicThreshold_InThreshold_PropertyAddress;

	private static int SetMicThreshold_InThreshold_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.VOIPStatics:SetMicThreshold")]
	public unsafe static void SetMicThreshold(float InThreshold)
	{
		if (!SetMicThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.VOIPStatics:SetMicThreshold");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMicThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMicThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMicThreshold_InThreshold_Offset), 0, SetMicThreshold_InThreshold_PropertyAddress.Address, InThreshold);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMicThreshold_FunctionAddress, intPtr, SetMicThreshold_ParamsSize);
	}

	static UVOIPStatics()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVOIPStatics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVOIPStatics));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.VOIPStatics");
		SetMicThreshold_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMicThreshold");
		SetMicThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMicThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMicThreshold_InThreshold_PropertyAddress, SetMicThreshold_FunctionAddress, "InThreshold");
		SetMicThreshold_InThreshold_Offset = NativeReflectionCached.GetPropertyOffset(SetMicThreshold_FunctionAddress, "InThreshold");
		SetMicThreshold_InThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMicThreshold_FunctionAddress, "InThreshold", Classes.FFloatProperty);
		SetMicThreshold_IsValid = SetMicThreshold_FunctionAddress != IntPtr.Zero && SetMicThreshold_InThreshold_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.VOIPStatics:SetMicThreshold", SetMicThreshold_IsValid);
	}
}
