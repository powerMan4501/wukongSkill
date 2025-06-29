using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.AkItemBoolPropertiesConv", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkItemBoolPropertiesConv : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Conv_FAkBoolPropertyToControlToText_IsValid;

	private static IntPtr Conv_FAkBoolPropertyToControlToText_FunctionAddress;

	private static int Conv_FAkBoolPropertyToControlToText_ParamsSize;

	private static bool Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_IsValid;

	private static FFieldAddress Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_PropertyAddress;

	private static int Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_Offset;

	private static bool Conv_FAkBoolPropertyToControlToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkBoolPropertyToControlToText_ReturnValue_PropertyAddress;

	private static int Conv_FAkBoolPropertyToControlToText_ReturnValue_Offset;

	private static bool Conv_FAkBoolPropertyToControlToString_IsValid;

	private static IntPtr Conv_FAkBoolPropertyToControlToString_FunctionAddress;

	private static int Conv_FAkBoolPropertyToControlToString_ParamsSize;

	private static bool Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_IsValid;

	private static FFieldAddress Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_PropertyAddress;

	private static int Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_Offset;

	private static bool Conv_FAkBoolPropertyToControlToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkBoolPropertyToControlToString_ReturnValue_PropertyAddress;

	private static int Conv_FAkBoolPropertyToControlToString_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.AkItemBoolPropertiesConv:Conv_FAkBoolPropertyToControlToText")]
	public unsafe static string Conv_FAkBoolPropertyToControlToText(FAkBoolPropertyToControl INAkBoolPropertyToControl)
	{
		if (!Conv_FAkBoolPropertyToControlToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkItemBoolPropertiesConv:Conv_FAkBoolPropertyToControlToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkBoolPropertyToControlToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkBoolPropertyToControlToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_PropertyAddress.Address, intPtr);
		FAkBoolPropertyToControl.ToNative(IntPtr.Add(intPtr, Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_Offset), 0, Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_PropertyAddress.Address, INAkBoolPropertyToControl);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkBoolPropertyToControlToText_FunctionAddress, intPtr, Conv_FAkBoolPropertyToControlToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkBoolPropertyToControlToText_ReturnValue_Offset), 0, Conv_FAkBoolPropertyToControlToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_FAkBoolPropertyToControlToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.AkItemBoolPropertiesConv:Conv_FAkBoolPropertyToControlToString")]
	public unsafe static string Conv_FAkBoolPropertyToControlToString(FAkBoolPropertyToControl INAkBoolPropertyToControl)
	{
		if (!Conv_FAkBoolPropertyToControlToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkItemBoolPropertiesConv:Conv_FAkBoolPropertyToControlToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkBoolPropertyToControlToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkBoolPropertyToControlToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_PropertyAddress.Address, intPtr);
		FAkBoolPropertyToControl.ToNative(IntPtr.Add(intPtr, Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_Offset), 0, Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_PropertyAddress.Address, INAkBoolPropertyToControl);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkBoolPropertyToControlToString_FunctionAddress, intPtr, Conv_FAkBoolPropertyToControlToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkBoolPropertyToControlToString_ReturnValue_Offset), 0, Conv_FAkBoolPropertyToControlToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_FAkBoolPropertyToControlToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAkItemBoolPropertiesConv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkItemBoolPropertiesConv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkItemBoolPropertiesConv));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AkAudio.AkItemBoolPropertiesConv");
		Conv_FAkBoolPropertyToControlToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkBoolPropertyToControlToText");
		Conv_FAkBoolPropertyToControlToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkBoolPropertyToControlToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_PropertyAddress, Conv_FAkBoolPropertyToControlToText_FunctionAddress, "INAkBoolPropertyToControl");
		Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkBoolPropertyToControlToText_FunctionAddress, "INAkBoolPropertyToControl");
		Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkBoolPropertyToControlToText_FunctionAddress, "INAkBoolPropertyToControl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkBoolPropertyToControlToText_ReturnValue_PropertyAddress, Conv_FAkBoolPropertyToControlToText_FunctionAddress, "ReturnValue");
		Conv_FAkBoolPropertyToControlToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkBoolPropertyToControlToText_FunctionAddress, "ReturnValue");
		Conv_FAkBoolPropertyToControlToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkBoolPropertyToControlToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_FAkBoolPropertyToControlToText_IsValid = Conv_FAkBoolPropertyToControlToText_FunctionAddress != IntPtr.Zero && Conv_FAkBoolPropertyToControlToText_INAkBoolPropertyToControl_IsValid && Conv_FAkBoolPropertyToControlToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkItemBoolPropertiesConv:Conv_FAkBoolPropertyToControlToText", Conv_FAkBoolPropertyToControlToText_IsValid);
		Conv_FAkBoolPropertyToControlToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkBoolPropertyToControlToString");
		Conv_FAkBoolPropertyToControlToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkBoolPropertyToControlToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_PropertyAddress, Conv_FAkBoolPropertyToControlToString_FunctionAddress, "INAkBoolPropertyToControl");
		Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkBoolPropertyToControlToString_FunctionAddress, "INAkBoolPropertyToControl");
		Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkBoolPropertyToControlToString_FunctionAddress, "INAkBoolPropertyToControl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkBoolPropertyToControlToString_ReturnValue_PropertyAddress, Conv_FAkBoolPropertyToControlToString_FunctionAddress, "ReturnValue");
		Conv_FAkBoolPropertyToControlToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkBoolPropertyToControlToString_FunctionAddress, "ReturnValue");
		Conv_FAkBoolPropertyToControlToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkBoolPropertyToControlToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_FAkBoolPropertyToControlToString_IsValid = Conv_FAkBoolPropertyToControlToString_FunctionAddress != IntPtr.Zero && Conv_FAkBoolPropertyToControlToString_INAkBoolPropertyToControl_IsValid && Conv_FAkBoolPropertyToControlToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkItemBoolPropertiesConv:Conv_FAkBoolPropertyToControlToString", Conv_FAkBoolPropertyToControlToString_IsValid);
	}
}
