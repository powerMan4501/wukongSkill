using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/GSFileHelper.GSFileHelper", "GSFileHelper", UnrealModuleType.Game)]
public class UGSFileHelper : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WriteFile_IsValid;

	private static IntPtr WriteFile_FunctionAddress;

	private static int WriteFile_ParamsSize;

	private static bool WriteFile_Filename_IsValid;

	private static FFieldAddress WriteFile_Filename_PropertyAddress;

	private static int WriteFile_Filename_Offset;

	private static bool WriteFile_BytesToWrite_IsValid;

	private static FFieldAddress WriteFile_BytesToWrite_PropertyAddress;

	private static int WriteFile_BytesToWrite_Offset;

	private static bool WriteFile_bAppend_IsValid;

	private static FFieldAddress WriteFile_bAppend_PropertyAddress;

	private static int WriteFile_bAppend_Offset;

	private static bool WriteFile_IsStandardPath_IsValid;

	private static FFieldAddress WriteFile_IsStandardPath_PropertyAddress;

	private static int WriteFile_IsStandardPath_Offset;

	private static bool WriteFile_ReturnValue_IsValid;

	private static FFieldAddress WriteFile_ReturnValue_PropertyAddress;

	private static int WriteFile_ReturnValue_Offset;

	private static bool ReadFile_IsValid;

	private static IntPtr ReadFile_FunctionAddress;

	private static int ReadFile_ParamsSize;

	private static bool ReadFile_Filename_IsValid;

	private static FFieldAddress ReadFile_Filename_PropertyAddress;

	private static int ReadFile_Filename_Offset;

	private static bool ReadFile_BytesToRead_IsValid;

	private static FFieldAddress ReadFile_BytesToRead_PropertyAddress;

	private static int ReadFile_BytesToRead_Offset;

	private static bool ReadFile_IsStandardPath_IsValid;

	private static FFieldAddress ReadFile_IsStandardPath_PropertyAddress;

	private static int ReadFile_IsStandardPath_Offset;

	private static bool ReadFile_ReturnValue_IsValid;

	private static FFieldAddress ReadFile_ReturnValue_PropertyAddress;

	private static int ReadFile_ReturnValue_Offset;

	private static bool GetTimeStampTicks_IsValid;

	private static IntPtr GetTimeStampTicks_FunctionAddress;

	private static int GetTimeStampTicks_ParamsSize;

	private static bool GetTimeStampTicks_Filename_IsValid;

	private static FFieldAddress GetTimeStampTicks_Filename_PropertyAddress;

	private static int GetTimeStampTicks_Filename_Offset;

	private static bool GetTimeStampTicks_ReturnValue_IsValid;

	private static FFieldAddress GetTimeStampTicks_ReturnValue_PropertyAddress;

	private static int GetTimeStampTicks_ReturnValue_Offset;

	private static bool FindFilesRecursively_IsValid;

	private static IntPtr FindFilesRecursively_FunctionAddress;

	private static int FindFilesRecursively_ParamsSize;

	private static bool FindFilesRecursively_Directory_IsValid;

	private static FFieldAddress FindFilesRecursively_Directory_PropertyAddress;

	private static int FindFilesRecursively_Directory_Offset;

	private static bool FindFilesRecursively_FoundFiles_IsValid;

	private static FFieldAddress FindFilesRecursively_FoundFiles_PropertyAddress;

	private static int FindFilesRecursively_FoundFiles_Offset;

	private static bool FindFilesRecursively_FileExtension_IsValid;

	private static FFieldAddress FindFilesRecursively_FileExtension_PropertyAddress;

	private static int FindFilesRecursively_FileExtension_Offset;

	private static bool FindFiles_IsValid;

	private static IntPtr FindFiles_FunctionAddress;

	private static int FindFiles_ParamsSize;

	private static bool FindFiles_Directory_IsValid;

	private static FFieldAddress FindFiles_Directory_PropertyAddress;

	private static int FindFiles_Directory_Offset;

	private static bool FindFiles_FoundFiles_IsValid;

	private static FFieldAddress FindFiles_FoundFiles_PropertyAddress;

	private static int FindFiles_FoundFiles_Offset;

	private static bool FindFiles_FileExtension_IsValid;

	private static FFieldAddress FindFiles_FileExtension_PropertyAddress;

	private static int FindFiles_FileExtension_Offset;

	private static bool FileSize_IsValid;

	private static IntPtr FileSize_FunctionAddress;

	private static int FileSize_ParamsSize;

	private static bool FileSize_Filename_IsValid;

	private static FFieldAddress FileSize_Filename_PropertyAddress;

	private static int FileSize_Filename_Offset;

	private static bool FileSize_IsStandardPath_IsValid;

	private static FFieldAddress FileSize_IsStandardPath_PropertyAddress;

	private static int FileSize_IsStandardPath_Offset;

	private static bool FileSize_ReturnValue_IsValid;

	private static FFieldAddress FileSize_ReturnValue_PropertyAddress;

	private static int FileSize_ReturnValue_Offset;

	private static bool FileExists_IsValid;

	private static IntPtr FileExists_FunctionAddress;

	private static int FileExists_ParamsSize;

	private static bool FileExists_Filename_IsValid;

	private static FFieldAddress FileExists_Filename_PropertyAddress;

	private static int FileExists_Filename_Offset;

	private static bool FileExists_ReturnValue_IsValid;

	private static FFieldAddress FileExists_ReturnValue_PropertyAddress;

	private static int FileExists_ReturnValue_Offset;

	private static bool DirectoryExists_IsValid;

	private static IntPtr DirectoryExists_FunctionAddress;

	private static int DirectoryExists_ParamsSize;

	private static bool DirectoryExists_Directory_IsValid;

	private static FFieldAddress DirectoryExists_Directory_PropertyAddress;

	private static int DirectoryExists_Directory_Offset;

	private static bool DirectoryExists_ReturnValue_IsValid;

	private static FFieldAddress DirectoryExists_ReturnValue_PropertyAddress;

	private static int DirectoryExists_ReturnValue_Offset;

	private static bool DeleteFile_IsValid;

	private static IntPtr DeleteFile_FunctionAddress;

	private static int DeleteFile_ParamsSize;

	private static bool DeleteFile_Filename_IsValid;

	private static FFieldAddress DeleteFile_Filename_PropertyAddress;

	private static int DeleteFile_Filename_Offset;

	private static bool DeleteFile_ReturnValue_IsValid;

	private static FFieldAddress DeleteFile_ReturnValue_PropertyAddress;

	private static int DeleteFile_ReturnValue_Offset;

	private static bool DeleteDirectory_IsValid;

	private static IntPtr DeleteDirectory_FunctionAddress;

	private static int DeleteDirectory_ParamsSize;

	private static bool DeleteDirectory_Directory_IsValid;

	private static FFieldAddress DeleteDirectory_Directory_PropertyAddress;

	private static int DeleteDirectory_Directory_Offset;

	private static bool DeleteDirectory_ReturnValue_IsValid;

	private static FFieldAddress DeleteDirectory_ReturnValue_PropertyAddress;

	private static int DeleteDirectory_ReturnValue_Offset;

	private static bool CreateDirectory_IsValid;

	private static IntPtr CreateDirectory_FunctionAddress;

	private static int CreateDirectory_ParamsSize;

	private static bool CreateDirectory_Directory_IsValid;

	private static FFieldAddress CreateDirectory_Directory_PropertyAddress;

	private static int CreateDirectory_Directory_Offset;

	private static bool CreateDirectory_ReturnValue_IsValid;

	private static FFieldAddress CreateDirectory_ReturnValue_PropertyAddress;

	private static int CreateDirectory_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:WriteFile")]
	public unsafe static bool WriteFile(string Filename, List<byte> BytesToWrite, bool bAppend = false, bool IsStandardPath = false)
	{
		if (!WriteFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:WriteFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteFile_Filename_Offset), 0, WriteFile_Filename_PropertyAddress.Address, Filename);
		new TArrayCopyMarshaler<byte>(1, WriteFile_BytesToWrite_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, WriteFile_BytesToWrite_Offset), BytesToWrite);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, WriteFile_bAppend_Offset), 0, WriteFile_bAppend_PropertyAddress.Address, bAppend);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, WriteFile_IsStandardPath_Offset), 0, WriteFile_IsStandardPath_PropertyAddress.Address, IsStandardPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WriteFile_FunctionAddress, intPtr, WriteFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteFile_Filename_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(WriteFile_BytesToWrite_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WriteFile_ReturnValue_Offset), 0, WriteFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:ReadFile")]
	public unsafe static bool ReadFile(string Filename, out List<byte> BytesToRead, bool IsStandardPath = false)
	{
		if (!ReadFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:ReadFile");
			BytesToRead = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReadFile_Filename_Offset), 0, ReadFile_Filename_PropertyAddress.Address, Filename);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ReadFile_IsStandardPath_Offset), 0, ReadFile_IsStandardPath_PropertyAddress.Address, IsStandardPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadFile_FunctionAddress, intPtr, ReadFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReadFile_Filename_PropertyAddress.Address, intPtr);
		BytesToRead = new TArrayCopyMarshaler<byte>(1, ReadFile_BytesToRead_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, ReadFile_BytesToRead_Offset));
		NativeReflection.DestroyValue_InContainer(ReadFile_BytesToRead_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadFile_ReturnValue_Offset), 0, ReadFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:GetTimeStampTicks")]
	public unsafe static long GetTimeStampTicks(string Filename)
	{
		if (!GetTimeStampTicks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:GetTimeStampTicks");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTimeStampTicks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTimeStampTicks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetTimeStampTicks_Filename_Offset), 0, GetTimeStampTicks_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTimeStampTicks_FunctionAddress, intPtr, GetTimeStampTicks_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTimeStampTicks_Filename_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetTimeStampTicks_ReturnValue_Offset), 0, GetTimeStampTicks_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:FindFilesRecursively")]
	public unsafe static void FindFilesRecursively(string Directory, out List<string> FoundFiles, string FileExtension)
	{
		if (!FindFilesRecursively_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:FindFilesRecursively");
			FoundFiles = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindFilesRecursively_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindFilesRecursively_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindFilesRecursively_Directory_Offset), 0, FindFilesRecursively_Directory_PropertyAddress.Address, Directory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindFilesRecursively_FileExtension_Offset), 0, FindFilesRecursively_FileExtension_PropertyAddress.Address, FileExtension);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindFilesRecursively_FunctionAddress, intPtr, FindFilesRecursively_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindFilesRecursively_Directory_PropertyAddress.Address, intPtr);
		FoundFiles = new TArrayCopyMarshaler<string>(1, FindFilesRecursively_FoundFiles_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, FindFilesRecursively_FoundFiles_Offset));
		NativeReflection.DestroyValue_InContainer(FindFilesRecursively_FoundFiles_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(FindFilesRecursively_FileExtension_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:FindFiles")]
	public unsafe static void FindFiles(string Directory, out List<string> FoundFiles, string FileExtension)
	{
		if (!FindFiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:FindFiles");
			FoundFiles = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindFiles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindFiles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindFiles_Directory_Offset), 0, FindFiles_Directory_PropertyAddress.Address, Directory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindFiles_FileExtension_Offset), 0, FindFiles_FileExtension_PropertyAddress.Address, FileExtension);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindFiles_FunctionAddress, intPtr, FindFiles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindFiles_Directory_PropertyAddress.Address, intPtr);
		FoundFiles = new TArrayCopyMarshaler<string>(1, FindFiles_FoundFiles_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, FindFiles_FoundFiles_Offset));
		NativeReflection.DestroyValue_InContainer(FindFiles_FoundFiles_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(FindFiles_FileExtension_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:FileSize")]
	public unsafe static long FileSize(string Filename, bool IsStandardPath = false)
	{
		if (!FileSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:FileSize");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FileSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FileSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FileSize_Filename_Offset), 0, FileSize_Filename_PropertyAddress.Address, Filename);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FileSize_IsStandardPath_Offset), 0, FileSize_IsStandardPath_PropertyAddress.Address, IsStandardPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FileSize_FunctionAddress, intPtr, FileSize_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FileSize_Filename_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, FileSize_ReturnValue_Offset), 0, FileSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:FileExists")]
	public unsafe static bool FileExists(string Filename)
	{
		if (!FileExists_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:FileExists");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FileExists_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FileExists_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FileExists_Filename_Offset), 0, FileExists_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FileExists_FunctionAddress, intPtr, FileExists_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FileExists_Filename_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FileExists_ReturnValue_Offset), 0, FileExists_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:DirectoryExists")]
	public unsafe static bool DirectoryExists(string Directory)
	{
		if (!DirectoryExists_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:DirectoryExists");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DirectoryExists_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DirectoryExists_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DirectoryExists_Directory_Offset), 0, DirectoryExists_Directory_PropertyAddress.Address, Directory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DirectoryExists_FunctionAddress, intPtr, DirectoryExists_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DirectoryExists_Directory_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DirectoryExists_ReturnValue_Offset), 0, DirectoryExists_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:DeleteFile")]
	public unsafe static bool DeleteFile(string Filename)
	{
		if (!DeleteFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:DeleteFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DeleteFile_Filename_Offset), 0, DeleteFile_Filename_PropertyAddress.Address, Filename);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteFile_FunctionAddress, intPtr, DeleteFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteFile_Filename_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteFile_ReturnValue_Offset), 0, DeleteFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:DeleteDirectory")]
	public unsafe static bool DeleteDirectory(string Directory)
	{
		if (!DeleteDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:DeleteDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DeleteDirectory_Directory_Offset), 0, DeleteDirectory_Directory_PropertyAddress.Address, Directory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteDirectory_FunctionAddress, intPtr, DeleteDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteDirectory_Directory_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteDirectory_ReturnValue_Offset), 0, DeleteDirectory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GSFileHelper.GSFileHelper:CreateDirectory")]
	public unsafe static bool CreateDirectory(string Directory)
	{
		if (!CreateDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GSFileHelper.GSFileHelper:CreateDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateDirectory_Directory_Offset), 0, CreateDirectory_Directory_PropertyAddress.Address, Directory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateDirectory_FunctionAddress, intPtr, CreateDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateDirectory_Directory_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CreateDirectory_ReturnValue_Offset), 0, CreateDirectory_ReturnValue_PropertyAddress.Address);
	}

	static UGSFileHelper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSFileHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSFileHelper));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GSFileHelper.GSFileHelper");
		WriteFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WriteFile");
		WriteFile_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_Filename_PropertyAddress, WriteFile_FunctionAddress, "Filename");
		WriteFile_Filename_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "Filename");
		WriteFile_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_BytesToWrite_PropertyAddress, WriteFile_FunctionAddress, "BytesToWrite");
		WriteFile_BytesToWrite_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "BytesToWrite");
		WriteFile_BytesToWrite_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "BytesToWrite", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_bAppend_PropertyAddress, WriteFile_FunctionAddress, "bAppend");
		WriteFile_bAppend_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "bAppend");
		WriteFile_bAppend_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "bAppend", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_IsStandardPath_PropertyAddress, WriteFile_FunctionAddress, "IsStandardPath");
		WriteFile_IsStandardPath_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "IsStandardPath");
		WriteFile_IsStandardPath_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "IsStandardPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_ReturnValue_PropertyAddress, WriteFile_FunctionAddress, "ReturnValue");
		WriteFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "ReturnValue");
		WriteFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WriteFile_IsValid = WriteFile_FunctionAddress != IntPtr.Zero && WriteFile_Filename_IsValid && WriteFile_BytesToWrite_IsValid && WriteFile_bAppend_IsValid && WriteFile_IsStandardPath_IsValid && WriteFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:WriteFile", WriteFile_IsValid);
		ReadFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadFile");
		ReadFile_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadFile_Filename_PropertyAddress, ReadFile_FunctionAddress, "Filename");
		ReadFile_Filename_Offset = NativeReflectionCached.GetPropertyOffset(ReadFile_FunctionAddress, "Filename");
		ReadFile_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFile_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadFile_BytesToRead_PropertyAddress, ReadFile_FunctionAddress, "BytesToRead");
		ReadFile_BytesToRead_Offset = NativeReflectionCached.GetPropertyOffset(ReadFile_FunctionAddress, "BytesToRead");
		ReadFile_BytesToRead_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFile_FunctionAddress, "BytesToRead", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadFile_IsStandardPath_PropertyAddress, ReadFile_FunctionAddress, "IsStandardPath");
		ReadFile_IsStandardPath_Offset = NativeReflectionCached.GetPropertyOffset(ReadFile_FunctionAddress, "IsStandardPath");
		ReadFile_IsStandardPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFile_FunctionAddress, "IsStandardPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadFile_ReturnValue_PropertyAddress, ReadFile_FunctionAddress, "ReturnValue");
		ReadFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadFile_FunctionAddress, "ReturnValue");
		ReadFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadFile_IsValid = ReadFile_FunctionAddress != IntPtr.Zero && ReadFile_Filename_IsValid && ReadFile_BytesToRead_IsValid && ReadFile_IsStandardPath_IsValid && ReadFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:ReadFile", ReadFile_IsValid);
		GetTimeStampTicks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTimeStampTicks");
		GetTimeStampTicks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTimeStampTicks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTimeStampTicks_Filename_PropertyAddress, GetTimeStampTicks_FunctionAddress, "Filename");
		GetTimeStampTicks_Filename_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeStampTicks_FunctionAddress, "Filename");
		GetTimeStampTicks_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeStampTicks_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTimeStampTicks_ReturnValue_PropertyAddress, GetTimeStampTicks_FunctionAddress, "ReturnValue");
		GetTimeStampTicks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTimeStampTicks_FunctionAddress, "ReturnValue");
		GetTimeStampTicks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTimeStampTicks_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetTimeStampTicks_IsValid = GetTimeStampTicks_FunctionAddress != IntPtr.Zero && GetTimeStampTicks_Filename_IsValid && GetTimeStampTicks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:GetTimeStampTicks", GetTimeStampTicks_IsValid);
		FindFilesRecursively_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindFilesRecursively");
		FindFilesRecursively_ParamsSize = NativeReflection.GetFunctionParamsSize(FindFilesRecursively_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindFilesRecursively_Directory_PropertyAddress, FindFilesRecursively_FunctionAddress, "Directory");
		FindFilesRecursively_Directory_Offset = NativeReflectionCached.GetPropertyOffset(FindFilesRecursively_FunctionAddress, "Directory");
		FindFilesRecursively_Directory_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFilesRecursively_FunctionAddress, "Directory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindFilesRecursively_FoundFiles_PropertyAddress, FindFilesRecursively_FunctionAddress, "FoundFiles");
		FindFilesRecursively_FoundFiles_Offset = NativeReflectionCached.GetPropertyOffset(FindFilesRecursively_FunctionAddress, "FoundFiles");
		FindFilesRecursively_FoundFiles_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFilesRecursively_FunctionAddress, "FoundFiles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FindFilesRecursively_FileExtension_PropertyAddress, FindFilesRecursively_FunctionAddress, "FileExtension");
		FindFilesRecursively_FileExtension_Offset = NativeReflectionCached.GetPropertyOffset(FindFilesRecursively_FunctionAddress, "FileExtension");
		FindFilesRecursively_FileExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFilesRecursively_FunctionAddress, "FileExtension", Classes.FStrProperty);
		FindFilesRecursively_IsValid = FindFilesRecursively_FunctionAddress != IntPtr.Zero && FindFilesRecursively_Directory_IsValid && FindFilesRecursively_FoundFiles_IsValid && FindFilesRecursively_FileExtension_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:FindFilesRecursively", FindFilesRecursively_IsValid);
		FindFiles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindFiles");
		FindFiles_ParamsSize = NativeReflection.GetFunctionParamsSize(FindFiles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindFiles_Directory_PropertyAddress, FindFiles_FunctionAddress, "Directory");
		FindFiles_Directory_Offset = NativeReflectionCached.GetPropertyOffset(FindFiles_FunctionAddress, "Directory");
		FindFiles_Directory_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFiles_FunctionAddress, "Directory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindFiles_FoundFiles_PropertyAddress, FindFiles_FunctionAddress, "FoundFiles");
		FindFiles_FoundFiles_Offset = NativeReflectionCached.GetPropertyOffset(FindFiles_FunctionAddress, "FoundFiles");
		FindFiles_FoundFiles_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFiles_FunctionAddress, "FoundFiles", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FindFiles_FileExtension_PropertyAddress, FindFiles_FunctionAddress, "FileExtension");
		FindFiles_FileExtension_Offset = NativeReflectionCached.GetPropertyOffset(FindFiles_FunctionAddress, "FileExtension");
		FindFiles_FileExtension_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFiles_FunctionAddress, "FileExtension", Classes.FStrProperty);
		FindFiles_IsValid = FindFiles_FunctionAddress != IntPtr.Zero && FindFiles_Directory_IsValid && FindFiles_FoundFiles_IsValid && FindFiles_FileExtension_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:FindFiles", FindFiles_IsValid);
		FileSize_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FileSize");
		FileSize_ParamsSize = NativeReflection.GetFunctionParamsSize(FileSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FileSize_Filename_PropertyAddress, FileSize_FunctionAddress, "Filename");
		FileSize_Filename_Offset = NativeReflectionCached.GetPropertyOffset(FileSize_FunctionAddress, "Filename");
		FileSize_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(FileSize_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FileSize_IsStandardPath_PropertyAddress, FileSize_FunctionAddress, "IsStandardPath");
		FileSize_IsStandardPath_Offset = NativeReflectionCached.GetPropertyOffset(FileSize_FunctionAddress, "IsStandardPath");
		FileSize_IsStandardPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FileSize_FunctionAddress, "IsStandardPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FileSize_ReturnValue_PropertyAddress, FileSize_FunctionAddress, "ReturnValue");
		FileSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FileSize_FunctionAddress, "ReturnValue");
		FileSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FileSize_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		FileSize_IsValid = FileSize_FunctionAddress != IntPtr.Zero && FileSize_Filename_IsValid && FileSize_IsStandardPath_IsValid && FileSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:FileSize", FileSize_IsValid);
		FileExists_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FileExists");
		FileExists_ParamsSize = NativeReflection.GetFunctionParamsSize(FileExists_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FileExists_Filename_PropertyAddress, FileExists_FunctionAddress, "Filename");
		FileExists_Filename_Offset = NativeReflectionCached.GetPropertyOffset(FileExists_FunctionAddress, "Filename");
		FileExists_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(FileExists_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FileExists_ReturnValue_PropertyAddress, FileExists_FunctionAddress, "ReturnValue");
		FileExists_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FileExists_FunctionAddress, "ReturnValue");
		FileExists_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FileExists_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FileExists_IsValid = FileExists_FunctionAddress != IntPtr.Zero && FileExists_Filename_IsValid && FileExists_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:FileExists", FileExists_IsValid);
		DirectoryExists_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DirectoryExists");
		DirectoryExists_ParamsSize = NativeReflection.GetFunctionParamsSize(DirectoryExists_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DirectoryExists_Directory_PropertyAddress, DirectoryExists_FunctionAddress, "Directory");
		DirectoryExists_Directory_Offset = NativeReflectionCached.GetPropertyOffset(DirectoryExists_FunctionAddress, "Directory");
		DirectoryExists_Directory_IsValid = NativeReflectionCached.ValidatePropertyClass(DirectoryExists_FunctionAddress, "Directory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DirectoryExists_ReturnValue_PropertyAddress, DirectoryExists_FunctionAddress, "ReturnValue");
		DirectoryExists_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DirectoryExists_FunctionAddress, "ReturnValue");
		DirectoryExists_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DirectoryExists_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DirectoryExists_IsValid = DirectoryExists_FunctionAddress != IntPtr.Zero && DirectoryExists_Directory_IsValid && DirectoryExists_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:DirectoryExists", DirectoryExists_IsValid);
		DeleteFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteFile");
		DeleteFile_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteFile_Filename_PropertyAddress, DeleteFile_FunctionAddress, "Filename");
		DeleteFile_Filename_Offset = NativeReflectionCached.GetPropertyOffset(DeleteFile_FunctionAddress, "Filename");
		DeleteFile_Filename_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteFile_FunctionAddress, "Filename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteFile_ReturnValue_PropertyAddress, DeleteFile_FunctionAddress, "ReturnValue");
		DeleteFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteFile_FunctionAddress, "ReturnValue");
		DeleteFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeleteFile_IsValid = DeleteFile_FunctionAddress != IntPtr.Zero && DeleteFile_Filename_IsValid && DeleteFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:DeleteFile", DeleteFile_IsValid);
		DeleteDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteDirectory");
		DeleteDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteDirectory_Directory_PropertyAddress, DeleteDirectory_FunctionAddress, "Directory");
		DeleteDirectory_Directory_Offset = NativeReflectionCached.GetPropertyOffset(DeleteDirectory_FunctionAddress, "Directory");
		DeleteDirectory_Directory_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteDirectory_FunctionAddress, "Directory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteDirectory_ReturnValue_PropertyAddress, DeleteDirectory_FunctionAddress, "ReturnValue");
		DeleteDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteDirectory_FunctionAddress, "ReturnValue");
		DeleteDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeleteDirectory_IsValid = DeleteDirectory_FunctionAddress != IntPtr.Zero && DeleteDirectory_Directory_IsValid && DeleteDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:DeleteDirectory", DeleteDirectory_IsValid);
		CreateDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateDirectory");
		CreateDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateDirectory_Directory_PropertyAddress, CreateDirectory_FunctionAddress, "Directory");
		CreateDirectory_Directory_Offset = NativeReflectionCached.GetPropertyOffset(CreateDirectory_FunctionAddress, "Directory");
		CreateDirectory_Directory_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDirectory_FunctionAddress, "Directory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateDirectory_ReturnValue_PropertyAddress, CreateDirectory_FunctionAddress, "ReturnValue");
		CreateDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateDirectory_FunctionAddress, "ReturnValue");
		CreateDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CreateDirectory_IsValid = CreateDirectory_FunctionAddress != IntPtr.Zero && CreateDirectory_Directory_IsValid && CreateDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GSFileHelper.GSFileHelper:CreateDirectory", CreateDirectory_IsValid);
	}
}
