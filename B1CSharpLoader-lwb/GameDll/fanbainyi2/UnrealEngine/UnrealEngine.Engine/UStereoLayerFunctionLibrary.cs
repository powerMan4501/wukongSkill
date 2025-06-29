using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/Engine.StereoLayerFunctionLibrary", "Engine", UnrealModuleType.Engine)]
public class UStereoLayerFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool EnableAutoLoadingSplashScreen_IsValid;

	private static IntPtr EnableAutoLoadingSplashScreen_FunctionAddress;

	private static int EnableAutoLoadingSplashScreen_ParamsSize;

	private static bool EnableAutoLoadingSplashScreen_InAutoShowEnabled_IsValid;

	private static FFieldAddress EnableAutoLoadingSplashScreen_InAutoShowEnabled_PropertyAddress;

	private static int EnableAutoLoadingSplashScreen_InAutoShowEnabled_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Engine.StereoLayerFunctionLibrary:EnableAutoLoadingSplashScreen")]
	public unsafe static void EnableAutoLoadingSplashScreen(bool InAutoShowEnabled)
	{
		if (!EnableAutoLoadingSplashScreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerFunctionLibrary:EnableAutoLoadingSplashScreen");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EnableAutoLoadingSplashScreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EnableAutoLoadingSplashScreen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, EnableAutoLoadingSplashScreen_InAutoShowEnabled_Offset), 0, EnableAutoLoadingSplashScreen_InAutoShowEnabled_PropertyAddress.Address, InAutoShowEnabled);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EnableAutoLoadingSplashScreen_FunctionAddress, intPtr, EnableAutoLoadingSplashScreen_ParamsSize);
	}

	static UStereoLayerFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStereoLayerFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStereoLayerFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Engine.StereoLayerFunctionLibrary");
		EnableAutoLoadingSplashScreen_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EnableAutoLoadingSplashScreen");
		EnableAutoLoadingSplashScreen_ParamsSize = NativeReflection.GetFunctionParamsSize(EnableAutoLoadingSplashScreen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EnableAutoLoadingSplashScreen_InAutoShowEnabled_PropertyAddress, EnableAutoLoadingSplashScreen_FunctionAddress, "InAutoShowEnabled");
		EnableAutoLoadingSplashScreen_InAutoShowEnabled_Offset = NativeReflectionCached.GetPropertyOffset(EnableAutoLoadingSplashScreen_FunctionAddress, "InAutoShowEnabled");
		EnableAutoLoadingSplashScreen_InAutoShowEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(EnableAutoLoadingSplashScreen_FunctionAddress, "InAutoShowEnabled", Classes.FBoolProperty);
		EnableAutoLoadingSplashScreen_IsValid = EnableAutoLoadingSplashScreen_FunctionAddress != IntPtr.Zero && EnableAutoLoadingSplashScreen_InAutoShowEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerFunctionLibrary:EnableAutoLoadingSplashScreen", EnableAutoLoadingSplashScreen_IsValid);
	}
}
