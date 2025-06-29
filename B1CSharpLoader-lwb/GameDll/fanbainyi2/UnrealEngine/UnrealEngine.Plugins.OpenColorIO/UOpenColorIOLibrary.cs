using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OpenColorIO;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[UMetaPath("/Script/OpenColorIO.OpenColorIOBlueprintLibrary", "OpenColorIO", UnrealModuleType.EnginePlugin)]
public class UOpenColorIOLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ApplyColorSpaceTransform_IsValid;

	private static IntPtr ApplyColorSpaceTransform_FunctionAddress;

	private static int ApplyColorSpaceTransform_ParamsSize;

	private static bool ApplyColorSpaceTransform_WorldContextObject_IsValid;

	private static FFieldAddress ApplyColorSpaceTransform_WorldContextObject_PropertyAddress;

	private static int ApplyColorSpaceTransform_WorldContextObject_Offset;

	private static bool ApplyColorSpaceTransform_ConversionSettings_IsValid;

	private static FFieldAddress ApplyColorSpaceTransform_ConversionSettings_PropertyAddress;

	private static int ApplyColorSpaceTransform_ConversionSettings_Offset;

	private static bool ApplyColorSpaceTransform_InputTexture_IsValid;

	private static FFieldAddress ApplyColorSpaceTransform_InputTexture_PropertyAddress;

	private static int ApplyColorSpaceTransform_InputTexture_Offset;

	private static bool ApplyColorSpaceTransform_OutputRenderTarget_IsValid;

	private static FFieldAddress ApplyColorSpaceTransform_OutputRenderTarget_PropertyAddress;

	private static int ApplyColorSpaceTransform_OutputRenderTarget_Offset;

	private static bool ApplyColorSpaceTransform_ReturnValue_IsValid;

	private static FFieldAddress ApplyColorSpaceTransform_ReturnValue_PropertyAddress;

	private static int ApplyColorSpaceTransform_ReturnValue_Offset;

	[UFunction(Flags = 71443459u)]
	[UMetaPath("/Script/OpenColorIO.OpenColorIOBlueprintLibrary:ApplyColorSpaceTransform")]
	public unsafe static bool ApplyColorSpaceTransform(UObject WorldContextObject, FOpenColorIOColorConversionSettings ConversionSettings, UTexture InputTexture, UTextureRenderTarget2D OutputRenderTarget)
	{
		if (!ApplyColorSpaceTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OpenColorIO.OpenColorIOBlueprintLibrary:ApplyColorSpaceTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyColorSpaceTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyColorSpaceTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ApplyColorSpaceTransform_WorldContextObject_Offset), 0, ApplyColorSpaceTransform_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InitializeValue_InContainer(ApplyColorSpaceTransform_ConversionSettings_PropertyAddress.Address, intPtr);
		FOpenColorIOColorConversionSettings.ToNative(IntPtr.Add(intPtr, ApplyColorSpaceTransform_ConversionSettings_Offset), 0, ApplyColorSpaceTransform_ConversionSettings_PropertyAddress.Address, ConversionSettings);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, ApplyColorSpaceTransform_InputTexture_Offset), 0, ApplyColorSpaceTransform_InputTexture_PropertyAddress.Address, InputTexture);
		UObjectMarshaler<UTextureRenderTarget2D>.ToNative(IntPtr.Add(intPtr, ApplyColorSpaceTransform_OutputRenderTarget_Offset), 0, ApplyColorSpaceTransform_OutputRenderTarget_PropertyAddress.Address, OutputRenderTarget);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyColorSpaceTransform_FunctionAddress, intPtr, ApplyColorSpaceTransform_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ApplyColorSpaceTransform_ConversionSettings_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ApplyColorSpaceTransform_ReturnValue_Offset), 0, ApplyColorSpaceTransform_ReturnValue_PropertyAddress.Address);
	}

	static UOpenColorIOLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOpenColorIOLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOpenColorIOLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/OpenColorIO.OpenColorIOBlueprintLibrary");
		ApplyColorSpaceTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyColorSpaceTransform");
		ApplyColorSpaceTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyColorSpaceTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyColorSpaceTransform_WorldContextObject_PropertyAddress, ApplyColorSpaceTransform_FunctionAddress, "WorldContextObject");
		ApplyColorSpaceTransform_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ApplyColorSpaceTransform_FunctionAddress, "WorldContextObject");
		ApplyColorSpaceTransform_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyColorSpaceTransform_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyColorSpaceTransform_ConversionSettings_PropertyAddress, ApplyColorSpaceTransform_FunctionAddress, "ConversionSettings");
		ApplyColorSpaceTransform_ConversionSettings_Offset = NativeReflectionCached.GetPropertyOffset(ApplyColorSpaceTransform_FunctionAddress, "ConversionSettings");
		ApplyColorSpaceTransform_ConversionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyColorSpaceTransform_FunctionAddress, "ConversionSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyColorSpaceTransform_InputTexture_PropertyAddress, ApplyColorSpaceTransform_FunctionAddress, "InputTexture");
		ApplyColorSpaceTransform_InputTexture_Offset = NativeReflectionCached.GetPropertyOffset(ApplyColorSpaceTransform_FunctionAddress, "InputTexture");
		ApplyColorSpaceTransform_InputTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyColorSpaceTransform_FunctionAddress, "InputTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyColorSpaceTransform_OutputRenderTarget_PropertyAddress, ApplyColorSpaceTransform_FunctionAddress, "OutputRenderTarget");
		ApplyColorSpaceTransform_OutputRenderTarget_Offset = NativeReflectionCached.GetPropertyOffset(ApplyColorSpaceTransform_FunctionAddress, "OutputRenderTarget");
		ApplyColorSpaceTransform_OutputRenderTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyColorSpaceTransform_FunctionAddress, "OutputRenderTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyColorSpaceTransform_ReturnValue_PropertyAddress, ApplyColorSpaceTransform_FunctionAddress, "ReturnValue");
		ApplyColorSpaceTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ApplyColorSpaceTransform_FunctionAddress, "ReturnValue");
		ApplyColorSpaceTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyColorSpaceTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ApplyColorSpaceTransform_IsValid = ApplyColorSpaceTransform_FunctionAddress != IntPtr.Zero && ApplyColorSpaceTransform_WorldContextObject_IsValid && ApplyColorSpaceTransform_ConversionSettings_IsValid && ApplyColorSpaceTransform_InputTexture_IsValid && ApplyColorSpaceTransform_OutputRenderTarget_IsValid && ApplyColorSpaceTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OpenColorIO.OpenColorIOBlueprintLibrary:ApplyColorSpaceTransform", ApplyColorSpaceTransform_IsValid);
	}
}
