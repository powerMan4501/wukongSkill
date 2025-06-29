using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.ImageWriteQueue;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/ImageWriteQueue.ImageWriteBlueprintLibrary", "ImageWriteQueue", UnrealModuleType.Engine)]
public class UImageWriteBlueprintLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ExportToDisk_IsValid;

	private static IntPtr ExportToDisk_FunctionAddress;

	private static int ExportToDisk_ParamsSize;

	private static bool ExportToDisk_Texture_IsValid;

	private static FFieldAddress ExportToDisk_Texture_PropertyAddress;

	private static int ExportToDisk_Texture_Offset;

	private static bool ExportToDisk_Filename_IsValid;

	private static FFieldAddress ExportToDisk_Filename_PropertyAddress;

	private static int ExportToDisk_Filename_Offset;

	private static bool ExportToDisk_Options_IsValid;

	private static FFieldAddress ExportToDisk_Options_PropertyAddress;

	private static int ExportToDisk_Options_Offset;

	[UFunction(Flags = 71443459u)]
	[UMetaPath("/Script/ImageWriteQueue.ImageWriteBlueprintLibrary:ExportToDisk")]
	public unsafe static void ExportToDisk(UTexture Texture, string Filename, FImageWriteOptions Options)
	{
		if (!ExportToDisk_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ImageWriteQueue.ImageWriteBlueprintLibrary:ExportToDisk");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportToDisk_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportToDisk_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, ExportToDisk_Texture_Offset), 0, ExportToDisk_Texture_PropertyAddress.Address, Texture);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportToDisk_Filename_Offset), 0, ExportToDisk_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InitializeValue_InContainer(ExportToDisk_Options_PropertyAddress.Address, intPtr);
		FImageWriteOptions.ToNative(IntPtr.Add(intPtr, ExportToDisk_Options_Offset), 0, ExportToDisk_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExportToDisk_FunctionAddress, intPtr, ExportToDisk_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportToDisk_Filename_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportToDisk_Options_PropertyAddress.Address, intPtr);
	}

	static UImageWriteBlueprintLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UImageWriteBlueprintLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UImageWriteBlueprintLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ImageWriteQueue.ImageWriteBlueprintLibrary");
		ExportToDisk_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExportToDisk");
		ExportToDisk_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportToDisk_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportToDisk_Texture_PropertyAddress, ExportToDisk_FunctionAddress, "Texture");
		ExportToDisk_Texture_Offset = NativeReflectionCached.GetPropertyOffset(ExportToDisk_FunctionAddress, "Texture");
		ExportToDisk_Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToDisk_FunctionAddress, "Texture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportToDisk_Filename_PropertyAddress, ExportToDisk_FunctionAddress, "Filename");
		ExportToDisk_Filename_Offset = NativeReflectionCached.GetPropertyOffset(ExportToDisk_FunctionAddress, "Filename");
		ExportToDisk_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToDisk_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportToDisk_Options_PropertyAddress, ExportToDisk_FunctionAddress, "Options");
		ExportToDisk_Options_Offset = NativeReflectionCached.GetPropertyOffset(ExportToDisk_FunctionAddress, "Options");
		ExportToDisk_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportToDisk_FunctionAddress, "Options", Classes.FStructProperty);
		ExportToDisk_IsValid = ExportToDisk_FunctionAddress != IntPtr.Zero && ExportToDisk_Texture_IsValid && ExportToDisk_Filename_IsValid && ExportToDisk_Options_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ImageWriteQueue.ImageWriteBlueprintLibrary:ExportToDisk", ExportToDisk_IsValid);
	}
}
