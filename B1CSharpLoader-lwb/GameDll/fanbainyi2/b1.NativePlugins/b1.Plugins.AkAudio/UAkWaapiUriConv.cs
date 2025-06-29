using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.AkWaapiUriConv", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkWaapiUriConv : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Conv_FAkWaapiUriToText_IsValid;

	private static IntPtr Conv_FAkWaapiUriToText_FunctionAddress;

	private static int Conv_FAkWaapiUriToText_ParamsSize;

	private static bool Conv_FAkWaapiUriToText_INAkWaapiUri_IsValid;

	private static FFieldAddress Conv_FAkWaapiUriToText_INAkWaapiUri_PropertyAddress;

	private static int Conv_FAkWaapiUriToText_INAkWaapiUri_Offset;

	private static bool Conv_FAkWaapiUriToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkWaapiUriToText_ReturnValue_PropertyAddress;

	private static int Conv_FAkWaapiUriToText_ReturnValue_Offset;

	private static bool Conv_FAkWaapiUriToString_IsValid;

	private static IntPtr Conv_FAkWaapiUriToString_FunctionAddress;

	private static int Conv_FAkWaapiUriToString_ParamsSize;

	private static bool Conv_FAkWaapiUriToString_INAkWaapiUri_IsValid;

	private static FFieldAddress Conv_FAkWaapiUriToString_INAkWaapiUri_PropertyAddress;

	private static int Conv_FAkWaapiUriToString_INAkWaapiUri_Offset;

	private static bool Conv_FAkWaapiUriToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkWaapiUriToString_ReturnValue_PropertyAddress;

	private static int Conv_FAkWaapiUriToString_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.AkWaapiUriConv:Conv_FAkWaapiUriToText")]
	public unsafe static string Conv_FAkWaapiUriToText(FAkWaapiUri INAkWaapiUri)
	{
		if (!Conv_FAkWaapiUriToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiUriConv:Conv_FAkWaapiUriToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkWaapiUriToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkWaapiUriToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkWaapiUriToText_INAkWaapiUri_PropertyAddress.Address, intPtr);
		FAkWaapiUri.ToNative(IntPtr.Add(intPtr, Conv_FAkWaapiUriToText_INAkWaapiUri_Offset), 0, Conv_FAkWaapiUriToText_INAkWaapiUri_PropertyAddress.Address, INAkWaapiUri);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkWaapiUriToText_FunctionAddress, intPtr, Conv_FAkWaapiUriToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiUriToText_INAkWaapiUri_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkWaapiUriToText_ReturnValue_Offset), 0, Conv_FAkWaapiUriToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiUriToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.AkWaapiUriConv:Conv_FAkWaapiUriToString")]
	public unsafe static string Conv_FAkWaapiUriToString(FAkWaapiUri INAkWaapiUri)
	{
		if (!Conv_FAkWaapiUriToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.AkWaapiUriConv:Conv_FAkWaapiUriToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkWaapiUriToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkWaapiUriToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkWaapiUriToString_INAkWaapiUri_PropertyAddress.Address, intPtr);
		FAkWaapiUri.ToNative(IntPtr.Add(intPtr, Conv_FAkWaapiUriToString_INAkWaapiUri_Offset), 0, Conv_FAkWaapiUriToString_INAkWaapiUri_PropertyAddress.Address, INAkWaapiUri);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkWaapiUriToString_FunctionAddress, intPtr, Conv_FAkWaapiUriToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiUriToString_INAkWaapiUri_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkWaapiUriToString_ReturnValue_Offset), 0, Conv_FAkWaapiUriToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiUriToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UAkWaapiUriConv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkWaapiUriConv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkWaapiUriConv));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AkAudio.AkWaapiUriConv");
		Conv_FAkWaapiUriToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkWaapiUriToText");
		Conv_FAkWaapiUriToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkWaapiUriToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiUriToText_INAkWaapiUri_PropertyAddress, Conv_FAkWaapiUriToText_FunctionAddress, "INAkWaapiUri");
		Conv_FAkWaapiUriToText_INAkWaapiUri_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiUriToText_FunctionAddress, "INAkWaapiUri");
		Conv_FAkWaapiUriToText_INAkWaapiUri_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiUriToText_FunctionAddress, "INAkWaapiUri", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiUriToText_ReturnValue_PropertyAddress, Conv_FAkWaapiUriToText_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiUriToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiUriToText_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiUriToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiUriToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_FAkWaapiUriToText_IsValid = Conv_FAkWaapiUriToText_FunctionAddress != IntPtr.Zero && Conv_FAkWaapiUriToText_INAkWaapiUri_IsValid && Conv_FAkWaapiUriToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiUriConv:Conv_FAkWaapiUriToText", Conv_FAkWaapiUriToText_IsValid);
		Conv_FAkWaapiUriToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkWaapiUriToString");
		Conv_FAkWaapiUriToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkWaapiUriToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiUriToString_INAkWaapiUri_PropertyAddress, Conv_FAkWaapiUriToString_FunctionAddress, "INAkWaapiUri");
		Conv_FAkWaapiUriToString_INAkWaapiUri_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiUriToString_FunctionAddress, "INAkWaapiUri");
		Conv_FAkWaapiUriToString_INAkWaapiUri_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiUriToString_FunctionAddress, "INAkWaapiUri", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiUriToString_ReturnValue_PropertyAddress, Conv_FAkWaapiUriToString_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiUriToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiUriToString_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiUriToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiUriToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_FAkWaapiUriToString_IsValid = Conv_FAkWaapiUriToString_FunctionAddress != IntPtr.Zero && Conv_FAkWaapiUriToString_INAkWaapiUri_IsValid && Conv_FAkWaapiUriToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.AkWaapiUriConv:Conv_FAkWaapiUriToString", Conv_FAkWaapiUriToString_IsValid);
	}
}
