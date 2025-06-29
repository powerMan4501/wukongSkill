using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AutomationUtils;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AutomationUtils.AutomationUtilsBlueprintLibrary", "AutomationUtils", UnrealModuleType.EnginePlugin)]
public class UAutomationUtilsBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool TakeGameplayAutomationScreenshot_IsValid;

	private static IntPtr TakeGameplayAutomationScreenshot_FunctionAddress;

	private static int TakeGameplayAutomationScreenshot_ParamsSize;

	private static bool TakeGameplayAutomationScreenshot_ScreenshotName_IsValid;

	private static FFieldAddress TakeGameplayAutomationScreenshot_ScreenshotName_PropertyAddress;

	private static int TakeGameplayAutomationScreenshot_ScreenshotName_Offset;

	private static bool TakeGameplayAutomationScreenshot_MaxGlobalError_IsValid;

	private static FFieldAddress TakeGameplayAutomationScreenshot_MaxGlobalError_PropertyAddress;

	private static int TakeGameplayAutomationScreenshot_MaxGlobalError_Offset;

	private static bool TakeGameplayAutomationScreenshot_MaxLocalError_IsValid;

	private static FFieldAddress TakeGameplayAutomationScreenshot_MaxLocalError_PropertyAddress;

	private static int TakeGameplayAutomationScreenshot_MaxLocalError_Offset;

	private static bool TakeGameplayAutomationScreenshot_MapNameOverride_IsValid;

	private static FFieldAddress TakeGameplayAutomationScreenshot_MapNameOverride_PropertyAddress;

	private static int TakeGameplayAutomationScreenshot_MapNameOverride_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/AutomationUtils.AutomationUtilsBlueprintLibrary:TakeGameplayAutomationScreenshot")]
	public unsafe static void TakeGameplayAutomationScreenshot(string ScreenshotName, float MaxGlobalError = 0.02f, float MaxLocalError = 0.12f, string MapNameOverride = null)
	{
		if (!TakeGameplayAutomationScreenshot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AutomationUtils.AutomationUtilsBlueprintLibrary:TakeGameplayAutomationScreenshot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TakeGameplayAutomationScreenshot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TakeGameplayAutomationScreenshot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeGameplayAutomationScreenshot_ScreenshotName_Offset), 0, TakeGameplayAutomationScreenshot_ScreenshotName_PropertyAddress.Address, ScreenshotName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TakeGameplayAutomationScreenshot_MaxGlobalError_Offset), 0, TakeGameplayAutomationScreenshot_MaxGlobalError_PropertyAddress.Address, MaxGlobalError);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TakeGameplayAutomationScreenshot_MaxLocalError_Offset), 0, TakeGameplayAutomationScreenshot_MaxLocalError_PropertyAddress.Address, MaxLocalError);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TakeGameplayAutomationScreenshot_MapNameOverride_Offset), 0, TakeGameplayAutomationScreenshot_MapNameOverride_PropertyAddress.Address, MapNameOverride);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TakeGameplayAutomationScreenshot_FunctionAddress, intPtr, TakeGameplayAutomationScreenshot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TakeGameplayAutomationScreenshot_ScreenshotName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TakeGameplayAutomationScreenshot_MapNameOverride_PropertyAddress.Address, intPtr);
	}

	static UAutomationUtilsBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutomationUtilsBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutomationUtilsBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AutomationUtils.AutomationUtilsBlueprintLibrary");
		TakeGameplayAutomationScreenshot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TakeGameplayAutomationScreenshot");
		TakeGameplayAutomationScreenshot_ParamsSize = NativeReflection.GetFunctionParamsSize(TakeGameplayAutomationScreenshot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TakeGameplayAutomationScreenshot_ScreenshotName_PropertyAddress, TakeGameplayAutomationScreenshot_FunctionAddress, "ScreenshotName");
		TakeGameplayAutomationScreenshot_ScreenshotName_Offset = NativeReflectionCached.GetPropertyOffset(TakeGameplayAutomationScreenshot_FunctionAddress, "ScreenshotName");
		TakeGameplayAutomationScreenshot_ScreenshotName_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeGameplayAutomationScreenshot_FunctionAddress, "ScreenshotName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeGameplayAutomationScreenshot_MaxGlobalError_PropertyAddress, TakeGameplayAutomationScreenshot_FunctionAddress, "MaxGlobalError");
		TakeGameplayAutomationScreenshot_MaxGlobalError_Offset = NativeReflectionCached.GetPropertyOffset(TakeGameplayAutomationScreenshot_FunctionAddress, "MaxGlobalError");
		TakeGameplayAutomationScreenshot_MaxGlobalError_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeGameplayAutomationScreenshot_FunctionAddress, "MaxGlobalError", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeGameplayAutomationScreenshot_MaxLocalError_PropertyAddress, TakeGameplayAutomationScreenshot_FunctionAddress, "MaxLocalError");
		TakeGameplayAutomationScreenshot_MaxLocalError_Offset = NativeReflectionCached.GetPropertyOffset(TakeGameplayAutomationScreenshot_FunctionAddress, "MaxLocalError");
		TakeGameplayAutomationScreenshot_MaxLocalError_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeGameplayAutomationScreenshot_FunctionAddress, "MaxLocalError", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TakeGameplayAutomationScreenshot_MapNameOverride_PropertyAddress, TakeGameplayAutomationScreenshot_FunctionAddress, "MapNameOverride");
		TakeGameplayAutomationScreenshot_MapNameOverride_Offset = NativeReflectionCached.GetPropertyOffset(TakeGameplayAutomationScreenshot_FunctionAddress, "MapNameOverride");
		TakeGameplayAutomationScreenshot_MapNameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(TakeGameplayAutomationScreenshot_FunctionAddress, "MapNameOverride", Classes.FStrProperty);
		TakeGameplayAutomationScreenshot_IsValid = TakeGameplayAutomationScreenshot_FunctionAddress != IntPtr.Zero && TakeGameplayAutomationScreenshot_ScreenshotName_IsValid && TakeGameplayAutomationScreenshot_MaxGlobalError_IsValid && TakeGameplayAutomationScreenshot_MaxLocalError_IsValid && TakeGameplayAutomationScreenshot_MapNameOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AutomationUtils.AutomationUtilsBlueprintLibrary:TakeGameplayAutomationScreenshot", TakeGameplayAutomationScreenshot_IsValid);
	}
}
