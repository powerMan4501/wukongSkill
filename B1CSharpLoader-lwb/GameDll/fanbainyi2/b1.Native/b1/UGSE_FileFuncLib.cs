using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_FileFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WriteFile_IsValid;

	private static IntPtr WriteFile_FunctionAddress;

	private static int WriteFile_ParamsSize;

	private static bool WriteFile_Path_IsValid;

	private static FFieldAddress WriteFile_Path_PropertyAddress;

	private static int WriteFile_Path_Offset;

	private static bool WriteFile_BytesToWrite_IsValid;

	private static FFieldAddress WriteFile_BytesToWrite_PropertyAddress;

	private static int WriteFile_BytesToWrite_Offset;

	private static bool WriteFile_bAppend_IsValid;

	private static FFieldAddress WriteFile_bAppend_PropertyAddress;

	private static int WriteFile_bAppend_Offset;

	private static bool WriteFile_ReturnValue_IsValid;

	private static FFieldAddress WriteFile_ReturnValue_PropertyAddress;

	private static int WriteFile_ReturnValue_Offset;

	private static bool ReadFile_IsValid;

	private static IntPtr ReadFile_FunctionAddress;

	private static int ReadFile_ParamsSize;

	private static bool ReadFile_Path_IsValid;

	private static FFieldAddress ReadFile_Path_PropertyAddress;

	private static int ReadFile_Path_Offset;

	private static bool ReadFile_BytesToRead_IsValid;

	private static FFieldAddress ReadFile_BytesToRead_PropertyAddress;

	private static int ReadFile_BytesToRead_Offset;

	private static bool ReadFile_ReturnValue_IsValid;

	private static FFieldAddress ReadFile_ReturnValue_PropertyAddress;

	private static int ReadFile_ReturnValue_Offset;

	private static bool PromptForCheckoutAndSave_IsValid;

	private static IntPtr PromptForCheckoutAndSave_FunctionAddress;

	private static int PromptForCheckoutAndSave_ParamsSize;

	private static bool PromptForCheckoutAndSave_Obj_IsValid;

	private static FFieldAddress PromptForCheckoutAndSave_Obj_PropertyAddress;

	private static int PromptForCheckoutAndSave_Obj_Offset;

	private static bool PromptForCheckoutAndSave_ReturnValue_IsValid;

	private static FFieldAddress PromptForCheckoutAndSave_ReturnValue_PropertyAddress;

	private static int PromptForCheckoutAndSave_ReturnValue_Offset;

	private static bool MountPakWithInPath_IsValid;

	private static IntPtr MountPakWithInPath_FunctionAddress;

	private static int MountPakWithInPath_ParamsSize;

	private static bool MountPakWithInPath_InPakFilename_IsValid;

	private static FFieldAddress MountPakWithInPath_InPakFilename_PropertyAddress;

	private static int MountPakWithInPath_InPakFilename_Offset;

	private static bool MountPakWithInPath_PakOrder_IsValid;

	private static FFieldAddress MountPakWithInPath_PakOrder_PropertyAddress;

	private static int MountPakWithInPath_PakOrder_Offset;

	private static bool MountPakWithInPath_InPath_IsValid;

	private static FFieldAddress MountPakWithInPath_InPath_PropertyAddress;

	private static int MountPakWithInPath_InPath_Offset;

	private static bool MountPakWithInPath_ReturnValue_IsValid;

	private static FFieldAddress MountPakWithInPath_ReturnValue_PropertyAddress;

	private static int MountPakWithInPath_ReturnValue_Offset;

	private static bool MountPak_IsValid;

	private static IntPtr MountPak_FunctionAddress;

	private static int MountPak_ParamsSize;

	private static bool MountPak_InPakFilename_IsValid;

	private static FFieldAddress MountPak_InPakFilename_PropertyAddress;

	private static int MountPak_InPakFilename_Offset;

	private static bool MountPak_PakOrder_IsValid;

	private static FFieldAddress MountPak_PakOrder_PropertyAddress;

	private static int MountPak_PakOrder_Offset;

	private static bool MountPak_ReturnValue_IsValid;

	private static FFieldAddress MountPak_ReturnValue_PropertyAddress;

	private static int MountPak_ReturnValue_Offset;

	private static bool MountAllPakFiles_IsValid;

	private static IntPtr MountAllPakFiles_FunctionAddress;

	private static int MountAllPakFiles_ParamsSize;

	private static bool MountAllPakFiles_PakFolders_IsValid;

	private static FFieldAddress MountAllPakFiles_PakFolders_PropertyAddress;

	private static int MountAllPakFiles_PakFolders_Offset;

	private static bool MountAllPakFiles_ReturnValue_IsValid;

	private static FFieldAddress MountAllPakFiles_ReturnValue_PropertyAddress;

	private static int MountAllPakFiles_ReturnValue_Offset;

	private static bool LoadFileToArray_IsValid;

	private static IntPtr LoadFileToArray_FunctionAddress;

	private static int LoadFileToArray_ParamsSize;

	private static bool LoadFileToArray_Path_IsValid;

	private static FFieldAddress LoadFileToArray_Path_PropertyAddress;

	private static int LoadFileToArray_Path_Offset;

	private static bool LoadFileToArray_FileData_IsValid;

	private static FFieldAddress LoadFileToArray_FileData_PropertyAddress;

	private static int LoadFileToArray_FileData_Offset;

	private static bool LoadFileToArray_ReturnValue_IsValid;

	private static FFieldAddress LoadFileToArray_ReturnValue_PropertyAddress;

	private static int LoadFileToArray_ReturnValue_Offset;

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

	private static bool FindFilesRecursively_ReturnValue_IsValid;

	private static FFieldAddress FindFilesRecursively_ReturnValue_PropertyAddress;

	private static int FindFilesRecursively_ReturnValue_Offset;

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

	private static bool FindFiles_ReturnValue_IsValid;

	private static FFieldAddress FindFiles_ReturnValue_PropertyAddress;

	private static int FindFiles_ReturnValue_Offset;

	private static bool ExtractFileToPath_IsValid;

	private static IntPtr ExtractFileToPath_FunctionAddress;

	private static int ExtractFileToPath_ParamsSize;

	private static bool ExtractFileToPath_src_IsValid;

	private static FFieldAddress ExtractFileToPath_src_PropertyAddress;

	private static int ExtractFileToPath_src_Offset;

	private static bool ExtractFileToPath_dest_IsValid;

	private static FFieldAddress ExtractFileToPath_dest_PropertyAddress;

	private static int ExtractFileToPath_dest_Offset;

	private static bool ExtractFileToPath_ReturnValue_IsValid;

	private static FFieldAddress ExtractFileToPath_ReturnValue_PropertyAddress;

	private static int ExtractFileToPath_ReturnValue_Offset;

	private static bool ExtractDirToPath_IsValid;

	private static IntPtr ExtractDirToPath_FunctionAddress;

	private static int ExtractDirToPath_ParamsSize;

	private static bool ExtractDirToPath_src_IsValid;

	private static FFieldAddress ExtractDirToPath_src_PropertyAddress;

	private static int ExtractDirToPath_src_Offset;

	private static bool ExtractDirToPath_dest_IsValid;

	private static FFieldAddress ExtractDirToPath_dest_PropertyAddress;

	private static int ExtractDirToPath_dest_Offset;

	private static bool ExtractDirToPath_ReturnValue_IsValid;

	private static FFieldAddress ExtractDirToPath_ReturnValue_PropertyAddress;

	private static int ExtractDirToPath_ReturnValue_Offset;

	private static bool AndroidHasFileInApk_IsValid;

	private static IntPtr AndroidHasFileInApk_FunctionAddress;

	private static int AndroidHasFileInApk_ParamsSize;

	private static bool AndroidHasFileInApk_SrcPath_IsValid;

	private static FFieldAddress AndroidHasFileInApk_SrcPath_PropertyAddress;

	private static int AndroidHasFileInApk_SrcPath_Offset;

	private static bool AndroidHasFileInApk_ReturnValue_IsValid;

	private static FFieldAddress AndroidHasFileInApk_ReturnValue_PropertyAddress;

	private static int AndroidHasFileInApk_ReturnValue_Offset;

	private static bool AndroidExtractFolderFromApk_IsValid;

	private static IntPtr AndroidExtractFolderFromApk_FunctionAddress;

	private static int AndroidExtractFolderFromApk_ParamsSize;

	private static bool AndroidExtractFolderFromApk_SrcPath_IsValid;

	private static FFieldAddress AndroidExtractFolderFromApk_SrcPath_PropertyAddress;

	private static int AndroidExtractFolderFromApk_SrcPath_Offset;

	private static bool AndroidExtractFolderFromApk_DestPath_IsValid;

	private static FFieldAddress AndroidExtractFolderFromApk_DestPath_PropertyAddress;

	private static int AndroidExtractFolderFromApk_DestPath_Offset;

	private static bool AndroidExtractFolderFromApk_ReturnValue_IsValid;

	private static FFieldAddress AndroidExtractFolderFromApk_ReturnValue_PropertyAddress;

	private static int AndroidExtractFolderFromApk_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:WriteFile")]
	public unsafe static bool WriteFile(string Path, List<byte> BytesToWrite, bool bAppend = false)
	{
		if (!WriteFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:WriteFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WriteFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WriteFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WriteFile_Path_Offset), 0, WriteFile_Path_PropertyAddress.Address, Path);
		new TArrayCopyMarshaler<byte>(1, WriteFile_BytesToWrite_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, WriteFile_BytesToWrite_Offset), BytesToWrite);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, WriteFile_bAppend_Offset), 0, WriteFile_bAppend_PropertyAddress.Address, bAppend);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WriteFile_FunctionAddress, intPtr, WriteFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WriteFile_Path_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(WriteFile_BytesToWrite_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WriteFile_ReturnValue_Offset), 0, WriteFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:ReadFile")]
	public unsafe static bool ReadFile(string Path, out List<byte> BytesToRead)
	{
		if (!ReadFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:ReadFile");
			BytesToRead = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReadFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReadFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReadFile_Path_Offset), 0, ReadFile_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReadFile_FunctionAddress, intPtr, ReadFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReadFile_Path_PropertyAddress.Address, intPtr);
		BytesToRead = new TArrayCopyMarshaler<byte>(1, ReadFile_BytesToRead_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, ReadFile_BytesToRead_Offset));
		NativeReflection.DestroyValue_InContainer(ReadFile_BytesToRead_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReadFile_ReturnValue_Offset), 0, ReadFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:PromptForCheckoutAndSave")]
	public unsafe static bool PromptForCheckoutAndSave(UObject Obj)
	{
		if (!PromptForCheckoutAndSave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:PromptForCheckoutAndSave");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PromptForCheckoutAndSave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PromptForCheckoutAndSave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, PromptForCheckoutAndSave_Obj_Offset), 0, PromptForCheckoutAndSave_Obj_PropertyAddress.Address, Obj);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PromptForCheckoutAndSave_FunctionAddress, intPtr, PromptForCheckoutAndSave_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PromptForCheckoutAndSave_ReturnValue_Offset), 0, PromptForCheckoutAndSave_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:MountPakWithInPath")]
	public unsafe static bool MountPakWithInPath(string InPakFilename, int PakOrder, string InPath)
	{
		if (!MountPakWithInPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:MountPakWithInPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MountPakWithInPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MountPakWithInPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MountPakWithInPath_InPakFilename_Offset), 0, MountPakWithInPath_InPakFilename_PropertyAddress.Address, InPakFilename);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MountPakWithInPath_PakOrder_Offset), 0, MountPakWithInPath_PakOrder_PropertyAddress.Address, PakOrder);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MountPakWithInPath_InPath_Offset), 0, MountPakWithInPath_InPath_PropertyAddress.Address, InPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MountPakWithInPath_FunctionAddress, intPtr, MountPakWithInPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MountPakWithInPath_InPakFilename_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MountPakWithInPath_InPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MountPakWithInPath_ReturnValue_Offset), 0, MountPakWithInPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:MountPak")]
	public unsafe static bool MountPak(string InPakFilename, int PakOrder)
	{
		if (!MountPak_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:MountPak");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MountPak_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MountPak_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MountPak_InPakFilename_Offset), 0, MountPak_InPakFilename_PropertyAddress.Address, InPakFilename);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MountPak_PakOrder_Offset), 0, MountPak_PakOrder_PropertyAddress.Address, PakOrder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MountPak_FunctionAddress, intPtr, MountPak_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MountPak_InPakFilename_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MountPak_ReturnValue_Offset), 0, MountPak_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:MountAllPakFiles")]
	public unsafe static bool MountAllPakFiles(List<string> PakFolders)
	{
		if (!MountAllPakFiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:MountAllPakFiles");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MountAllPakFiles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MountAllPakFiles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, MountAllPakFiles_PakFolders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, MountAllPakFiles_PakFolders_Offset), PakFolders);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MountAllPakFiles_FunctionAddress, intPtr, MountAllPakFiles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MountAllPakFiles_PakFolders_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MountAllPakFiles_ReturnValue_Offset), 0, MountAllPakFiles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:LoadFileToArray")]
	public unsafe static bool LoadFileToArray(string Path, out List<byte> FileData)
	{
		if (!LoadFileToArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:LoadFileToArray");
			FileData = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadFileToArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadFileToArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadFileToArray_Path_Offset), 0, LoadFileToArray_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadFileToArray_FunctionAddress, intPtr, LoadFileToArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadFileToArray_Path_PropertyAddress.Address, intPtr);
		FileData = new TArrayCopyMarshaler<byte>(1, LoadFileToArray_FileData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, LoadFileToArray_FileData_Offset));
		NativeReflection.DestroyValue_InContainer(LoadFileToArray_FileData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, LoadFileToArray_ReturnValue_Offset), 0, LoadFileToArray_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:FindFilesRecursively")]
	public unsafe static bool FindFilesRecursively(string Directory, out List<string> FoundFiles, string FileExtension)
	{
		if (!FindFilesRecursively_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:FindFilesRecursively");
			FoundFiles = null;
			return false;
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
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FindFilesRecursively_ReturnValue_Offset), 0, FindFilesRecursively_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:FindFiles")]
	public unsafe static bool FindFiles(string Directory, out List<string> FoundFiles, string FileExtension)
	{
		if (!FindFiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:FindFiles");
			FoundFiles = null;
			return false;
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
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FindFiles_ReturnValue_Offset), 0, FindFiles_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:ExtractFileToPath")]
	public unsafe static bool ExtractFileToPath(string src, string dest)
	{
		if (!ExtractFileToPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:ExtractFileToPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractFileToPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractFileToPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExtractFileToPath_src_Offset), 0, ExtractFileToPath_src_PropertyAddress.Address, src);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExtractFileToPath_dest_Offset), 0, ExtractFileToPath_dest_PropertyAddress.Address, dest);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExtractFileToPath_FunctionAddress, intPtr, ExtractFileToPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExtractFileToPath_src_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExtractFileToPath_dest_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExtractFileToPath_ReturnValue_Offset), 0, ExtractFileToPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:ExtractDirToPath")]
	public unsafe static bool ExtractDirToPath(string src, string dest)
	{
		if (!ExtractDirToPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:ExtractDirToPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractDirToPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractDirToPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExtractDirToPath_src_Offset), 0, ExtractDirToPath_src_PropertyAddress.Address, src);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExtractDirToPath_dest_Offset), 0, ExtractDirToPath_dest_PropertyAddress.Address, dest);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExtractDirToPath_FunctionAddress, intPtr, ExtractDirToPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExtractDirToPath_src_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExtractDirToPath_dest_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ExtractDirToPath_ReturnValue_Offset), 0, ExtractDirToPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:AndroidHasFileInApk")]
	public unsafe static bool AndroidHasFileInApk(string SrcPath)
	{
		if (!AndroidHasFileInApk_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:AndroidHasFileInApk");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AndroidHasFileInApk_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AndroidHasFileInApk_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AndroidHasFileInApk_SrcPath_Offset), 0, AndroidHasFileInApk_SrcPath_PropertyAddress.Address, SrcPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AndroidHasFileInApk_FunctionAddress, intPtr, AndroidHasFileInApk_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AndroidHasFileInApk_SrcPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AndroidHasFileInApk_ReturnValue_Offset), 0, AndroidHasFileInApk_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_FileFuncLib:AndroidExtractFolderFromApk")]
	public unsafe static bool AndroidExtractFolderFromApk(string SrcPath, string DestPath)
	{
		if (!AndroidExtractFolderFromApk_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_FileFuncLib:AndroidExtractFolderFromApk");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AndroidExtractFolderFromApk_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AndroidExtractFolderFromApk_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AndroidExtractFolderFromApk_SrcPath_Offset), 0, AndroidExtractFolderFromApk_SrcPath_PropertyAddress.Address, SrcPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AndroidExtractFolderFromApk_DestPath_Offset), 0, AndroidExtractFolderFromApk_DestPath_PropertyAddress.Address, DestPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AndroidExtractFolderFromApk_FunctionAddress, intPtr, AndroidExtractFolderFromApk_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AndroidExtractFolderFromApk_SrcPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AndroidExtractFolderFromApk_DestPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AndroidExtractFolderFromApk_ReturnValue_Offset), 0, AndroidExtractFolderFromApk_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_FileFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_FileFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_FileFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_FileFuncLib");
		WriteFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WriteFile");
		WriteFile_ParamsSize = NativeReflection.GetFunctionParamsSize(WriteFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_Path_PropertyAddress, WriteFile_FunctionAddress, "Path");
		WriteFile_Path_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "Path");
		WriteFile_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_BytesToWrite_PropertyAddress, WriteFile_FunctionAddress, "BytesToWrite");
		WriteFile_BytesToWrite_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "BytesToWrite");
		WriteFile_BytesToWrite_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "BytesToWrite", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_bAppend_PropertyAddress, WriteFile_FunctionAddress, "bAppend");
		WriteFile_bAppend_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "bAppend");
		WriteFile_bAppend_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "bAppend", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WriteFile_ReturnValue_PropertyAddress, WriteFile_FunctionAddress, "ReturnValue");
		WriteFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WriteFile_FunctionAddress, "ReturnValue");
		WriteFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WriteFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WriteFile_IsValid = WriteFile_FunctionAddress != IntPtr.Zero && WriteFile_Path_IsValid && WriteFile_BytesToWrite_IsValid && WriteFile_bAppend_IsValid && WriteFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:WriteFile", WriteFile_IsValid);
		ReadFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReadFile");
		ReadFile_ParamsSize = NativeReflection.GetFunctionParamsSize(ReadFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReadFile_Path_PropertyAddress, ReadFile_FunctionAddress, "Path");
		ReadFile_Path_Offset = NativeReflectionCached.GetPropertyOffset(ReadFile_FunctionAddress, "Path");
		ReadFile_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFile_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadFile_BytesToRead_PropertyAddress, ReadFile_FunctionAddress, "BytesToRead");
		ReadFile_BytesToRead_Offset = NativeReflectionCached.GetPropertyOffset(ReadFile_FunctionAddress, "BytesToRead");
		ReadFile_BytesToRead_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFile_FunctionAddress, "BytesToRead", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ReadFile_ReturnValue_PropertyAddress, ReadFile_FunctionAddress, "ReturnValue");
		ReadFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReadFile_FunctionAddress, "ReturnValue");
		ReadFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReadFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReadFile_IsValid = ReadFile_FunctionAddress != IntPtr.Zero && ReadFile_Path_IsValid && ReadFile_BytesToRead_IsValid && ReadFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:ReadFile", ReadFile_IsValid);
		PromptForCheckoutAndSave_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PromptForCheckoutAndSave");
		PromptForCheckoutAndSave_ParamsSize = NativeReflection.GetFunctionParamsSize(PromptForCheckoutAndSave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PromptForCheckoutAndSave_Obj_PropertyAddress, PromptForCheckoutAndSave_FunctionAddress, "Obj");
		PromptForCheckoutAndSave_Obj_Offset = NativeReflectionCached.GetPropertyOffset(PromptForCheckoutAndSave_FunctionAddress, "Obj");
		PromptForCheckoutAndSave_Obj_IsValid = NativeReflectionCached.ValidatePropertyClass(PromptForCheckoutAndSave_FunctionAddress, "Obj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PromptForCheckoutAndSave_ReturnValue_PropertyAddress, PromptForCheckoutAndSave_FunctionAddress, "ReturnValue");
		PromptForCheckoutAndSave_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PromptForCheckoutAndSave_FunctionAddress, "ReturnValue");
		PromptForCheckoutAndSave_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PromptForCheckoutAndSave_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PromptForCheckoutAndSave_IsValid = PromptForCheckoutAndSave_FunctionAddress != IntPtr.Zero && PromptForCheckoutAndSave_Obj_IsValid && PromptForCheckoutAndSave_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:PromptForCheckoutAndSave", PromptForCheckoutAndSave_IsValid);
		MountPakWithInPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MountPakWithInPath");
		MountPakWithInPath_ParamsSize = NativeReflection.GetFunctionParamsSize(MountPakWithInPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MountPakWithInPath_InPakFilename_PropertyAddress, MountPakWithInPath_FunctionAddress, "InPakFilename");
		MountPakWithInPath_InPakFilename_Offset = NativeReflectionCached.GetPropertyOffset(MountPakWithInPath_FunctionAddress, "InPakFilename");
		MountPakWithInPath_InPakFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(MountPakWithInPath_FunctionAddress, "InPakFilename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MountPakWithInPath_PakOrder_PropertyAddress, MountPakWithInPath_FunctionAddress, "PakOrder");
		MountPakWithInPath_PakOrder_Offset = NativeReflectionCached.GetPropertyOffset(MountPakWithInPath_FunctionAddress, "PakOrder");
		MountPakWithInPath_PakOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(MountPakWithInPath_FunctionAddress, "PakOrder", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MountPakWithInPath_InPath_PropertyAddress, MountPakWithInPath_FunctionAddress, "InPath");
		MountPakWithInPath_InPath_Offset = NativeReflectionCached.GetPropertyOffset(MountPakWithInPath_FunctionAddress, "InPath");
		MountPakWithInPath_InPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MountPakWithInPath_FunctionAddress, "InPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MountPakWithInPath_ReturnValue_PropertyAddress, MountPakWithInPath_FunctionAddress, "ReturnValue");
		MountPakWithInPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MountPakWithInPath_FunctionAddress, "ReturnValue");
		MountPakWithInPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MountPakWithInPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MountPakWithInPath_IsValid = MountPakWithInPath_FunctionAddress != IntPtr.Zero && MountPakWithInPath_InPakFilename_IsValid && MountPakWithInPath_PakOrder_IsValid && MountPakWithInPath_InPath_IsValid && MountPakWithInPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:MountPakWithInPath", MountPakWithInPath_IsValid);
		MountPak_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MountPak");
		MountPak_ParamsSize = NativeReflection.GetFunctionParamsSize(MountPak_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MountPak_InPakFilename_PropertyAddress, MountPak_FunctionAddress, "InPakFilename");
		MountPak_InPakFilename_Offset = NativeReflectionCached.GetPropertyOffset(MountPak_FunctionAddress, "InPakFilename");
		MountPak_InPakFilename_IsValid = NativeReflectionCached.ValidatePropertyClass(MountPak_FunctionAddress, "InPakFilename", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MountPak_PakOrder_PropertyAddress, MountPak_FunctionAddress, "PakOrder");
		MountPak_PakOrder_Offset = NativeReflectionCached.GetPropertyOffset(MountPak_FunctionAddress, "PakOrder");
		MountPak_PakOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(MountPak_FunctionAddress, "PakOrder", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MountPak_ReturnValue_PropertyAddress, MountPak_FunctionAddress, "ReturnValue");
		MountPak_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MountPak_FunctionAddress, "ReturnValue");
		MountPak_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MountPak_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MountPak_IsValid = MountPak_FunctionAddress != IntPtr.Zero && MountPak_InPakFilename_IsValid && MountPak_PakOrder_IsValid && MountPak_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:MountPak", MountPak_IsValid);
		MountAllPakFiles_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MountAllPakFiles");
		MountAllPakFiles_ParamsSize = NativeReflection.GetFunctionParamsSize(MountAllPakFiles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MountAllPakFiles_PakFolders_PropertyAddress, MountAllPakFiles_FunctionAddress, "PakFolders");
		MountAllPakFiles_PakFolders_Offset = NativeReflectionCached.GetPropertyOffset(MountAllPakFiles_FunctionAddress, "PakFolders");
		MountAllPakFiles_PakFolders_IsValid = NativeReflectionCached.ValidatePropertyClass(MountAllPakFiles_FunctionAddress, "PakFolders", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MountAllPakFiles_ReturnValue_PropertyAddress, MountAllPakFiles_FunctionAddress, "ReturnValue");
		MountAllPakFiles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MountAllPakFiles_FunctionAddress, "ReturnValue");
		MountAllPakFiles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MountAllPakFiles_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MountAllPakFiles_IsValid = MountAllPakFiles_FunctionAddress != IntPtr.Zero && MountAllPakFiles_PakFolders_IsValid && MountAllPakFiles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:MountAllPakFiles", MountAllPakFiles_IsValid);
		LoadFileToArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadFileToArray");
		LoadFileToArray_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadFileToArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToArray_Path_PropertyAddress, LoadFileToArray_FunctionAddress, "Path");
		LoadFileToArray_Path_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToArray_FunctionAddress, "Path");
		LoadFileToArray_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToArray_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToArray_FileData_PropertyAddress, LoadFileToArray_FunctionAddress, "FileData");
		LoadFileToArray_FileData_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToArray_FunctionAddress, "FileData");
		LoadFileToArray_FileData_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToArray_FunctionAddress, "FileData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadFileToArray_ReturnValue_PropertyAddress, LoadFileToArray_FunctionAddress, "ReturnValue");
		LoadFileToArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadFileToArray_FunctionAddress, "ReturnValue");
		LoadFileToArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadFileToArray_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		LoadFileToArray_IsValid = LoadFileToArray_FunctionAddress != IntPtr.Zero && LoadFileToArray_Path_IsValid && LoadFileToArray_FileData_IsValid && LoadFileToArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:LoadFileToArray", LoadFileToArray_IsValid);
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
		NativeReflectionCached.GetPropertyRef(ref FindFilesRecursively_ReturnValue_PropertyAddress, FindFilesRecursively_FunctionAddress, "ReturnValue");
		FindFilesRecursively_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindFilesRecursively_FunctionAddress, "ReturnValue");
		FindFilesRecursively_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFilesRecursively_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FindFilesRecursively_IsValid = FindFilesRecursively_FunctionAddress != IntPtr.Zero && FindFilesRecursively_Directory_IsValid && FindFilesRecursively_FoundFiles_IsValid && FindFilesRecursively_FileExtension_IsValid && FindFilesRecursively_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:FindFilesRecursively", FindFilesRecursively_IsValid);
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
		NativeReflectionCached.GetPropertyRef(ref FindFiles_ReturnValue_PropertyAddress, FindFiles_FunctionAddress, "ReturnValue");
		FindFiles_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindFiles_FunctionAddress, "ReturnValue");
		FindFiles_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindFiles_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FindFiles_IsValid = FindFiles_FunctionAddress != IntPtr.Zero && FindFiles_Directory_IsValid && FindFiles_FoundFiles_IsValid && FindFiles_FileExtension_IsValid && FindFiles_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:FindFiles", FindFiles_IsValid);
		ExtractFileToPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExtractFileToPath");
		ExtractFileToPath_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractFileToPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractFileToPath_src_PropertyAddress, ExtractFileToPath_FunctionAddress, "src");
		ExtractFileToPath_src_Offset = NativeReflectionCached.GetPropertyOffset(ExtractFileToPath_FunctionAddress, "src");
		ExtractFileToPath_src_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractFileToPath_FunctionAddress, "src", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractFileToPath_dest_PropertyAddress, ExtractFileToPath_FunctionAddress, "dest");
		ExtractFileToPath_dest_Offset = NativeReflectionCached.GetPropertyOffset(ExtractFileToPath_FunctionAddress, "dest");
		ExtractFileToPath_dest_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractFileToPath_FunctionAddress, "dest", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractFileToPath_ReturnValue_PropertyAddress, ExtractFileToPath_FunctionAddress, "ReturnValue");
		ExtractFileToPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExtractFileToPath_FunctionAddress, "ReturnValue");
		ExtractFileToPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractFileToPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExtractFileToPath_IsValid = ExtractFileToPath_FunctionAddress != IntPtr.Zero && ExtractFileToPath_src_IsValid && ExtractFileToPath_dest_IsValid && ExtractFileToPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:ExtractFileToPath", ExtractFileToPath_IsValid);
		ExtractDirToPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExtractDirToPath");
		ExtractDirToPath_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractDirToPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractDirToPath_src_PropertyAddress, ExtractDirToPath_FunctionAddress, "src");
		ExtractDirToPath_src_Offset = NativeReflectionCached.GetPropertyOffset(ExtractDirToPath_FunctionAddress, "src");
		ExtractDirToPath_src_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractDirToPath_FunctionAddress, "src", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractDirToPath_dest_PropertyAddress, ExtractDirToPath_FunctionAddress, "dest");
		ExtractDirToPath_dest_Offset = NativeReflectionCached.GetPropertyOffset(ExtractDirToPath_FunctionAddress, "dest");
		ExtractDirToPath_dest_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractDirToPath_FunctionAddress, "dest", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractDirToPath_ReturnValue_PropertyAddress, ExtractDirToPath_FunctionAddress, "ReturnValue");
		ExtractDirToPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ExtractDirToPath_FunctionAddress, "ReturnValue");
		ExtractDirToPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractDirToPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ExtractDirToPath_IsValid = ExtractDirToPath_FunctionAddress != IntPtr.Zero && ExtractDirToPath_src_IsValid && ExtractDirToPath_dest_IsValid && ExtractDirToPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:ExtractDirToPath", ExtractDirToPath_IsValid);
		AndroidHasFileInApk_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AndroidHasFileInApk");
		AndroidHasFileInApk_ParamsSize = NativeReflection.GetFunctionParamsSize(AndroidHasFileInApk_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AndroidHasFileInApk_SrcPath_PropertyAddress, AndroidHasFileInApk_FunctionAddress, "SrcPath");
		AndroidHasFileInApk_SrcPath_Offset = NativeReflectionCached.GetPropertyOffset(AndroidHasFileInApk_FunctionAddress, "SrcPath");
		AndroidHasFileInApk_SrcPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AndroidHasFileInApk_FunctionAddress, "SrcPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AndroidHasFileInApk_ReturnValue_PropertyAddress, AndroidHasFileInApk_FunctionAddress, "ReturnValue");
		AndroidHasFileInApk_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AndroidHasFileInApk_FunctionAddress, "ReturnValue");
		AndroidHasFileInApk_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AndroidHasFileInApk_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AndroidHasFileInApk_IsValid = AndroidHasFileInApk_FunctionAddress != IntPtr.Zero && AndroidHasFileInApk_SrcPath_IsValid && AndroidHasFileInApk_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:AndroidHasFileInApk", AndroidHasFileInApk_IsValid);
		AndroidExtractFolderFromApk_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AndroidExtractFolderFromApk");
		AndroidExtractFolderFromApk_ParamsSize = NativeReflection.GetFunctionParamsSize(AndroidExtractFolderFromApk_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AndroidExtractFolderFromApk_SrcPath_PropertyAddress, AndroidExtractFolderFromApk_FunctionAddress, "SrcPath");
		AndroidExtractFolderFromApk_SrcPath_Offset = NativeReflectionCached.GetPropertyOffset(AndroidExtractFolderFromApk_FunctionAddress, "SrcPath");
		AndroidExtractFolderFromApk_SrcPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AndroidExtractFolderFromApk_FunctionAddress, "SrcPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AndroidExtractFolderFromApk_DestPath_PropertyAddress, AndroidExtractFolderFromApk_FunctionAddress, "DestPath");
		AndroidExtractFolderFromApk_DestPath_Offset = NativeReflectionCached.GetPropertyOffset(AndroidExtractFolderFromApk_FunctionAddress, "DestPath");
		AndroidExtractFolderFromApk_DestPath_IsValid = NativeReflectionCached.ValidatePropertyClass(AndroidExtractFolderFromApk_FunctionAddress, "DestPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AndroidExtractFolderFromApk_ReturnValue_PropertyAddress, AndroidExtractFolderFromApk_FunctionAddress, "ReturnValue");
		AndroidExtractFolderFromApk_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AndroidExtractFolderFromApk_FunctionAddress, "ReturnValue");
		AndroidExtractFolderFromApk_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AndroidExtractFolderFromApk_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AndroidExtractFolderFromApk_IsValid = AndroidExtractFolderFromApk_FunctionAddress != IntPtr.Zero && AndroidExtractFolderFromApk_SrcPath_IsValid && AndroidExtractFolderFromApk_DestPath_IsValid && AndroidExtractFolderFromApk_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_FileFuncLib:AndroidExtractFolderFromApk", AndroidExtractFolderFromApk_IsValid);
	}
}
