using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.FileMediaSource", "MediaAssets", UnrealModuleType.Engine)]
public class UFileMediaSource : UBaseMediaSource
{
	private static bool FilePath_IsValid;

	private static int FilePath_Offset;

	private static bool PrecacheFile_IsValid;

	private static FFieldAddress PrecacheFile_PropertyAddress;

	private static int PrecacheFile_Offset;

	private static bool SetFilePath_IsValid;

	private static IntPtr SetFilePath_FunctionAddress;

	private static int SetFilePath_ParamsSize;

	private static bool SetFilePath_Path_IsValid;

	private static FFieldAddress SetFilePath_Path_PropertyAddress;

	private static int SetFilePath_Path_Offset;

	[UProperty(Flags = (PropFlags)6756498952684037uL)]
	[UMetaPath("/Script/MediaAssets.FileMediaSource:FilePath")]
	public string FilePath
	{
		get
		{
			CheckDestroyed();
			if (!FilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.FileMediaSource:FilePath");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, FilePath_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FilePath_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.FileMediaSource:FilePath");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, FilePath_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/MediaAssets.FileMediaSource:PrecacheFile")]
	public bool PrecacheFile
	{
		get
		{
			CheckDestroyed();
			if (!PrecacheFile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.FileMediaSource:PrecacheFile");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PrecacheFile_Offset), 0, PrecacheFile_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PrecacheFile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.FileMediaSource:PrecacheFile");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PrecacheFile_Offset), 0, PrecacheFile_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MediaAssets.FileMediaSource:SetFilePath")]
	public unsafe void SetFilePath(string Path)
	{
		CheckDestroyed();
		if (!SetFilePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MediaAssets.FileMediaSource:SetFilePath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFilePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFilePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetFilePath_Path_Offset), 0, SetFilePath_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFilePath_FunctionAddress, intPtr, SetFilePath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetFilePath_Path_PropertyAddress.Address, intPtr);
	}

	static UFileMediaSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFileMediaSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFileMediaSource));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/MediaAssets.FileMediaSource");
		FilePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilePath");
		FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PrecacheFile_PropertyAddress, intPtr, "PrecacheFile");
		PrecacheFile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PrecacheFile");
		PrecacheFile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PrecacheFile", Classes.FBoolProperty);
		SetFilePath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFilePath");
		SetFilePath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFilePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFilePath_Path_PropertyAddress, SetFilePath_FunctionAddress, "Path");
		SetFilePath_Path_Offset = NativeReflectionCached.GetPropertyOffset(SetFilePath_FunctionAddress, "Path");
		SetFilePath_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFilePath_FunctionAddress, "Path", Classes.FStrProperty);
		SetFilePath_IsValid = SetFilePath_FunctionAddress != IntPtr.Zero && SetFilePath_Path_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MediaAssets.FileMediaSource:SetFilePath", SetFilePath_IsValid);
	}
}
