using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AkAudio.SAkWaapiFieldNamesConv", "AkAudio", UnrealModuleType.GamePlugin)]
public class USAkWaapiFieldNamesConv : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool Conv_FAkWaapiFieldNamesToText_IsValid;

	private static IntPtr Conv_FAkWaapiFieldNamesToText_FunctionAddress;

	private static int Conv_FAkWaapiFieldNamesToText_ParamsSize;

	private static bool Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_IsValid;

	private static FFieldAddress Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_PropertyAddress;

	private static int Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_Offset;

	private static bool Conv_FAkWaapiFieldNamesToText_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkWaapiFieldNamesToText_ReturnValue_PropertyAddress;

	private static int Conv_FAkWaapiFieldNamesToText_ReturnValue_Offset;

	private static bool Conv_FAkWaapiFieldNamesToString_IsValid;

	private static IntPtr Conv_FAkWaapiFieldNamesToString_FunctionAddress;

	private static int Conv_FAkWaapiFieldNamesToString_ParamsSize;

	private static bool Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_IsValid;

	private static FFieldAddress Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_PropertyAddress;

	private static int Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_Offset;

	private static bool Conv_FAkWaapiFieldNamesToString_ReturnValue_IsValid;

	private static FFieldAddress Conv_FAkWaapiFieldNamesToString_ReturnValue_PropertyAddress;

	private static int Conv_FAkWaapiFieldNamesToString_ReturnValue_Offset;

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.SAkWaapiFieldNamesConv:Conv_FAkWaapiFieldNamesToText")]
	public unsafe static string Conv_FAkWaapiFieldNamesToText(FAkWaapiFieldNames INAkWaapiFieldNames)
	{
		if (!Conv_FAkWaapiFieldNamesToText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.SAkWaapiFieldNamesConv:Conv_FAkWaapiFieldNamesToText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkWaapiFieldNamesToText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkWaapiFieldNamesToText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_Offset), 0, Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_PropertyAddress.Address, INAkWaapiFieldNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkWaapiFieldNamesToText_FunctionAddress, intPtr, Conv_FAkWaapiFieldNamesToText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_PropertyAddress.Address, intPtr);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkWaapiFieldNamesToText_ReturnValue_Offset), 0, Conv_FAkWaapiFieldNamesToText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiFieldNamesToText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/AkAudio.SAkWaapiFieldNamesConv:Conv_FAkWaapiFieldNamesToString")]
	public unsafe static string Conv_FAkWaapiFieldNamesToString(FAkWaapiFieldNames INAkWaapiFieldNames)
	{
		if (!Conv_FAkWaapiFieldNamesToString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.SAkWaapiFieldNamesConv:Conv_FAkWaapiFieldNamesToString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Conv_FAkWaapiFieldNamesToString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Conv_FAkWaapiFieldNamesToString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_PropertyAddress.Address, intPtr);
		FAkWaapiFieldNames.ToNative(IntPtr.Add(intPtr, Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_Offset), 0, Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_PropertyAddress.Address, INAkWaapiFieldNames);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Conv_FAkWaapiFieldNamesToString_FunctionAddress, intPtr, Conv_FAkWaapiFieldNamesToString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, Conv_FAkWaapiFieldNamesToString_ReturnValue_Offset), 0, Conv_FAkWaapiFieldNamesToString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(Conv_FAkWaapiFieldNamesToString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static USAkWaapiFieldNamesConv()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USAkWaapiFieldNamesConv)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USAkWaapiFieldNamesConv));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/AkAudio.SAkWaapiFieldNamesConv");
		Conv_FAkWaapiFieldNamesToText_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkWaapiFieldNamesToText");
		Conv_FAkWaapiFieldNamesToText_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkWaapiFieldNamesToText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_PropertyAddress, Conv_FAkWaapiFieldNamesToText_FunctionAddress, "INAkWaapiFieldNames");
		Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiFieldNamesToText_FunctionAddress, "INAkWaapiFieldNames");
		Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiFieldNamesToText_FunctionAddress, "INAkWaapiFieldNames", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiFieldNamesToText_ReturnValue_PropertyAddress, Conv_FAkWaapiFieldNamesToText_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiFieldNamesToText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiFieldNamesToText_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiFieldNamesToText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiFieldNamesToText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		Conv_FAkWaapiFieldNamesToText_IsValid = Conv_FAkWaapiFieldNamesToText_FunctionAddress != IntPtr.Zero && Conv_FAkWaapiFieldNamesToText_INAkWaapiFieldNames_IsValid && Conv_FAkWaapiFieldNamesToText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.SAkWaapiFieldNamesConv:Conv_FAkWaapiFieldNamesToText", Conv_FAkWaapiFieldNamesToText_IsValid);
		Conv_FAkWaapiFieldNamesToString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Conv_FAkWaapiFieldNamesToString");
		Conv_FAkWaapiFieldNamesToString_ParamsSize = NativeReflection.GetFunctionParamsSize(Conv_FAkWaapiFieldNamesToString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_PropertyAddress, Conv_FAkWaapiFieldNamesToString_FunctionAddress, "INAkWaapiFieldNames");
		Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiFieldNamesToString_FunctionAddress, "INAkWaapiFieldNames");
		Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiFieldNamesToString_FunctionAddress, "INAkWaapiFieldNames", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Conv_FAkWaapiFieldNamesToString_ReturnValue_PropertyAddress, Conv_FAkWaapiFieldNamesToString_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiFieldNamesToString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Conv_FAkWaapiFieldNamesToString_FunctionAddress, "ReturnValue");
		Conv_FAkWaapiFieldNamesToString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Conv_FAkWaapiFieldNamesToString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		Conv_FAkWaapiFieldNamesToString_IsValid = Conv_FAkWaapiFieldNamesToString_FunctionAddress != IntPtr.Zero && Conv_FAkWaapiFieldNamesToString_INAkWaapiFieldNames_IsValid && Conv_FAkWaapiFieldNamesToString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.SAkWaapiFieldNamesConv:Conv_FAkWaapiFieldNamesToString", Conv_FAkWaapiFieldNamesToString_IsValid);
	}
}
