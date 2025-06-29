using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.AkItemPropertiesConv", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkItemPropertiesConv : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Conv_FAkPropertyToControlToText_IsValid;

	private static IntPtr Conv_FAkPropertyToControlToText_FunctionAddress;

	private static int Conv_FAkPropertyToControlToText_ParamsSize;

	private static bool Conv_FAkPropertyToControlToText_INAkPropertyToControl_IsValid;

	private static FFieldAddress Conv_FAkPropertyToControlToText_INAkPropertyToControl_PropertyAddress;

	private static int Conv_FAkPropertyToControlToText_INAkPropertyToControl_Offset;

	private static bool Conv_FAkPropertyToControlToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkPropertyToControlToText_ReturnValue_PropertyAddress;

	private static int Conv_FAkPropertyToControlToText_ReturnValue_Offset;

	private static bool Conv_FAkPropertyToControlToString_IsValid;

	private static IntPtr Conv_FAkPropertyToControlToString_FunctionAddress;

	private static int Conv_FAkPropertyToControlToString_ParamsSize;

	private static bool Conv_FAkPropertyToControlToString_INAkPropertyToControl_IsValid;

	private static FFieldAddress Conv_FAkPropertyToControlToString_INAkPropertyToControl_PropertyAddress;

	private static int Conv_FAkPropertyToControlToString_INAkPropertyToControl_Offset;

	private static bool Conv_FAkPropertyToControlToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkPropertyToControlToString_ReturnValue_PropertyAddress;

	private static int Conv_FAkPropertyToControlToString_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.AkItemPropertiesConv:Conv_FAkPropertyToControlToText")]
	public unsafe static string Conv_FAkPropertyToControlToText(FAkPropertyToControl INAkPropertyToControl)
	{
		if (!Conv_FAkPropertyToControlToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkItemPropertiesConv:Conv_FAkPropertyToControlToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkPropertyToControlToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkPropertyToControlToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkPropertyToControlToText_INAkPropertyToControl_PropertyAddress.Address, intPtr);
		FAkPropertyToControl.ToNative(IntPtr.Add(intPtr, Conv_FAkPropertyToControlToText_INAkPropertyToControl_Offset), 0, Conv_FAkPropertyToControlToText_INAkPropertyToControl_PropertyAddress.Address, INAkPropertyToControl);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkPropertyToControlToText_FunctionAddress, intPtr, Conv_FAkPropertyToControlToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAkPropertyToControlToText_INAkPropertyToControl_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkPropertyToControlToText_ReturnValue_Offset), 0, Conv_FAkPropertyToControlToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_FAkPropertyToControlToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.AkItemPropertiesConv:Conv_FAkPropertyToControlToString")]
	public unsafe static string Conv_FAkPropertyToControlToString(FAkPropertyToControl INAkPropertyToControl)
	{
		if (!Conv_FAkPropertyToControlToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkItemPropertiesConv:Conv_FAkPropertyToControlToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkPropertyToControlToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkPropertyToControlToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkPropertyToControlToString_INAkPropertyToControl_PropertyAddress.Address, intPtr);
		FAkPropertyToControl.ToNative(IntPtr.Add(intPtr, Conv_FAkPropertyToControlToString_INAkPropertyToControl_Offset), 0, Conv_FAkPropertyToControlToString_INAkPropertyToControl_PropertyAddress.Address, INAkPropertyToControl);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkPropertyToControlToString_FunctionAddress, intPtr, Conv_FAkPropertyToControlToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAkPropertyToControlToString_INAkPropertyToControl_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkPropertyToControlToString_ReturnValue_Offset), 0, Conv_FAkPropertyToControlToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_FAkPropertyToControlToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAkItemPropertiesConv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkItemPropertiesConv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkItemPropertiesConv));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AkAudio.AkItemPropertiesConv");
		Conv_FAkPropertyToControlToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkPropertyToControlToText");
		Conv_FAkPropertyToControlToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkPropertyToControlToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkPropertyToControlToText_INAkPropertyToControl_PropertyAddress, Conv_FAkPropertyToControlToText_FunctionAddress, "INAkPropertyToControl");
		Conv_FAkPropertyToControlToText_INAkPropertyToControl_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkPropertyToControlToText_FunctionAddress, "INAkPropertyToControl");
		Conv_FAkPropertyToControlToText_INAkPropertyToControl_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkPropertyToControlToText_FunctionAddress, "INAkPropertyToControl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkPropertyToControlToText_ReturnValue_PropertyAddress, Conv_FAkPropertyToControlToText_FunctionAddress, "ReturnValue");
		Conv_FAkPropertyToControlToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkPropertyToControlToText_FunctionAddress, "ReturnValue");
		Conv_FAkPropertyToControlToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkPropertyToControlToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_FAkPropertyToControlToText_IsValid = Conv_FAkPropertyToControlToText_FunctionAddress != IntPtr.Zero && Conv_FAkPropertyToControlToText_INAkPropertyToControl_IsValid && Conv_FAkPropertyToControlToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkItemPropertiesConv:Conv_FAkPropertyToControlToText", Conv_FAkPropertyToControlToText_IsValid);
		Conv_FAkPropertyToControlToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkPropertyToControlToString");
		Conv_FAkPropertyToControlToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkPropertyToControlToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkPropertyToControlToString_INAkPropertyToControl_PropertyAddress, Conv_FAkPropertyToControlToString_FunctionAddress, "INAkPropertyToControl");
		Conv_FAkPropertyToControlToString_INAkPropertyToControl_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkPropertyToControlToString_FunctionAddress, "INAkPropertyToControl");
		Conv_FAkPropertyToControlToString_INAkPropertyToControl_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkPropertyToControlToString_FunctionAddress, "INAkPropertyToControl", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkPropertyToControlToString_ReturnValue_PropertyAddress, Conv_FAkPropertyToControlToString_FunctionAddress, "ReturnValue");
		Conv_FAkPropertyToControlToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkPropertyToControlToString_FunctionAddress, "ReturnValue");
		Conv_FAkPropertyToControlToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkPropertyToControlToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_FAkPropertyToControlToString_IsValid = Conv_FAkPropertyToControlToString_FunctionAddress != IntPtr.Zero && Conv_FAkPropertyToControlToString_INAkPropertyToControl_IsValid && Conv_FAkPropertyToControlToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkItemPropertiesConv:Conv_FAkPropertyToControlToString", Conv_FAkPropertyToControlToString_IsValid);
	}
}
