using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneFolderExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetFolderName_IsValid;

	private static IntPtr SetFolderName_FunctionAddress;

	private static int SetFolderName_ParamsSize;

	private static bool SetFolderName_Folder_IsValid;

	private static FFieldAddress SetFolderName_Folder_PropertyAddress;

	private static int SetFolderName_Folder_Offset;

	private static bool SetFolderName_InFolderName_IsValid;

	private static FFieldAddress SetFolderName_InFolderName_PropertyAddress;

	private static int SetFolderName_InFolderName_Offset;

	private static bool SetFolderName_ReturnValue_IsValid;

	private static FFieldAddress SetFolderName_ReturnValue_PropertyAddress;

	private static int SetFolderName_ReturnValue_Offset;

	private static bool SetFolderColor_IsValid;

	private static IntPtr SetFolderColor_FunctionAddress;

	private static int SetFolderColor_ParamsSize;

	private static bool SetFolderColor_Folder_IsValid;

	private static FFieldAddress SetFolderColor_Folder_PropertyAddress;

	private static int SetFolderColor_Folder_Offset;

	private static bool SetFolderColor_InFolderColor_IsValid;

	private static FFieldAddress SetFolderColor_InFolderColor_PropertyAddress;

	private static int SetFolderColor_InFolderColor_Offset;

	private static bool SetFolderColor_ReturnValue_IsValid;

	private static FFieldAddress SetFolderColor_ReturnValue_PropertyAddress;

	private static int SetFolderColor_ReturnValue_Offset;

	private static bool RemoveChildObjectBinding_IsValid;

	private static IntPtr RemoveChildObjectBinding_FunctionAddress;

	private static int RemoveChildObjectBinding_ParamsSize;

	private static bool RemoveChildObjectBinding_Folder_IsValid;

	private static FFieldAddress RemoveChildObjectBinding_Folder_PropertyAddress;

	private static int RemoveChildObjectBinding_Folder_Offset;

	private static bool RemoveChildObjectBinding_InObjectBinding_IsValid;

	private static FFieldAddress RemoveChildObjectBinding_InObjectBinding_PropertyAddress;

	private static int RemoveChildObjectBinding_InObjectBinding_Offset;

	private static bool RemoveChildObjectBinding_ReturnValue_IsValid;

	private static FFieldAddress RemoveChildObjectBinding_ReturnValue_PropertyAddress;

	private static int RemoveChildObjectBinding_ReturnValue_Offset;

	private static bool RemoveChildMasterTrack_IsValid;

	private static IntPtr RemoveChildMasterTrack_FunctionAddress;

	private static int RemoveChildMasterTrack_ParamsSize;

	private static bool RemoveChildMasterTrack_Folder_IsValid;

	private static FFieldAddress RemoveChildMasterTrack_Folder_PropertyAddress;

	private static int RemoveChildMasterTrack_Folder_Offset;

	private static bool RemoveChildMasterTrack_InMasterTrack_IsValid;

	private static FFieldAddress RemoveChildMasterTrack_InMasterTrack_PropertyAddress;

	private static int RemoveChildMasterTrack_InMasterTrack_Offset;

	private static bool RemoveChildMasterTrack_ReturnValue_IsValid;

	private static FFieldAddress RemoveChildMasterTrack_ReturnValue_PropertyAddress;

	private static int RemoveChildMasterTrack_ReturnValue_Offset;

	private static bool RemoveChildFolder_IsValid;

	private static IntPtr RemoveChildFolder_FunctionAddress;

	private static int RemoveChildFolder_ParamsSize;

	private static bool RemoveChildFolder_TargetFolder_IsValid;

	private static FFieldAddress RemoveChildFolder_TargetFolder_PropertyAddress;

	private static int RemoveChildFolder_TargetFolder_Offset;

	private static bool RemoveChildFolder_FolderToRemove_IsValid;

	private static FFieldAddress RemoveChildFolder_FolderToRemove_PropertyAddress;

	private static int RemoveChildFolder_FolderToRemove_Offset;

	private static bool RemoveChildFolder_ReturnValue_IsValid;

	private static FFieldAddress RemoveChildFolder_ReturnValue_PropertyAddress;

	private static int RemoveChildFolder_ReturnValue_Offset;

	private static bool GetFolderName_IsValid;

	private static IntPtr GetFolderName_FunctionAddress;

	private static int GetFolderName_ParamsSize;

	private static bool GetFolderName_Folder_IsValid;

	private static FFieldAddress GetFolderName_Folder_PropertyAddress;

	private static int GetFolderName_Folder_Offset;

	private static bool GetFolderName_ReturnValue_IsValid;

	private static FFieldAddress GetFolderName_ReturnValue_PropertyAddress;

	private static int GetFolderName_ReturnValue_Offset;

	private static bool GetFolderColor_IsValid;

	private static IntPtr GetFolderColor_FunctionAddress;

	private static int GetFolderColor_ParamsSize;

	private static bool GetFolderColor_Folder_IsValid;

	private static FFieldAddress GetFolderColor_Folder_PropertyAddress;

	private static int GetFolderColor_Folder_Offset;

	private static bool GetFolderColor_ReturnValue_IsValid;

	private static FFieldAddress GetFolderColor_ReturnValue_PropertyAddress;

	private static int GetFolderColor_ReturnValue_Offset;

	private static bool GetChildObjectBindings_IsValid;

	private static IntPtr GetChildObjectBindings_FunctionAddress;

	private static int GetChildObjectBindings_ParamsSize;

	private static bool GetChildObjectBindings_Folder_IsValid;

	private static FFieldAddress GetChildObjectBindings_Folder_PropertyAddress;

	private static int GetChildObjectBindings_Folder_Offset;

	private static bool GetChildObjectBindings_ReturnValue_IsValid;

	private static FFieldAddress GetChildObjectBindings_ReturnValue_PropertyAddress;

	private static int GetChildObjectBindings_ReturnValue_Offset;

	private static bool GetChildMasterTracks_IsValid;

	private static IntPtr GetChildMasterTracks_FunctionAddress;

	private static int GetChildMasterTracks_ParamsSize;

	private static bool GetChildMasterTracks_Folder_IsValid;

	private static FFieldAddress GetChildMasterTracks_Folder_PropertyAddress;

	private static int GetChildMasterTracks_Folder_Offset;

	private static bool GetChildMasterTracks_ReturnValue_IsValid;

	private static FFieldAddress GetChildMasterTracks_ReturnValue_PropertyAddress;

	private static int GetChildMasterTracks_ReturnValue_Offset;

	private static bool GetChildFolders_IsValid;

	private static IntPtr GetChildFolders_FunctionAddress;

	private static int GetChildFolders_ParamsSize;

	private static bool GetChildFolders_Folder_IsValid;

	private static FFieldAddress GetChildFolders_Folder_PropertyAddress;

	private static int GetChildFolders_Folder_Offset;

	private static bool GetChildFolders_ReturnValue_IsValid;

	private static FFieldAddress GetChildFolders_ReturnValue_PropertyAddress;

	private static int GetChildFolders_ReturnValue_Offset;

	private static bool AddChildObjectBinding_IsValid;

	private static IntPtr AddChildObjectBinding_FunctionAddress;

	private static int AddChildObjectBinding_ParamsSize;

	private static bool AddChildObjectBinding_Folder_IsValid;

	private static FFieldAddress AddChildObjectBinding_Folder_PropertyAddress;

	private static int AddChildObjectBinding_Folder_Offset;

	private static bool AddChildObjectBinding_InObjectBinding_IsValid;

	private static FFieldAddress AddChildObjectBinding_InObjectBinding_PropertyAddress;

	private static int AddChildObjectBinding_InObjectBinding_Offset;

	private static bool AddChildObjectBinding_ReturnValue_IsValid;

	private static FFieldAddress AddChildObjectBinding_ReturnValue_PropertyAddress;

	private static int AddChildObjectBinding_ReturnValue_Offset;

	private static bool AddChildMasterTrack_IsValid;

	private static IntPtr AddChildMasterTrack_FunctionAddress;

	private static int AddChildMasterTrack_ParamsSize;

	private static bool AddChildMasterTrack_Folder_IsValid;

	private static FFieldAddress AddChildMasterTrack_Folder_PropertyAddress;

	private static int AddChildMasterTrack_Folder_Offset;

	private static bool AddChildMasterTrack_InMasterTrack_IsValid;

	private static FFieldAddress AddChildMasterTrack_InMasterTrack_PropertyAddress;

	private static int AddChildMasterTrack_InMasterTrack_Offset;

	private static bool AddChildMasterTrack_ReturnValue_IsValid;

	private static FFieldAddress AddChildMasterTrack_ReturnValue_PropertyAddress;

	private static int AddChildMasterTrack_ReturnValue_Offset;

	private static bool AddChildFolder_IsValid;

	private static IntPtr AddChildFolder_FunctionAddress;

	private static int AddChildFolder_ParamsSize;

	private static bool AddChildFolder_TargetFolder_IsValid;

	private static FFieldAddress AddChildFolder_TargetFolder_PropertyAddress;

	private static int AddChildFolder_TargetFolder_Offset;

	private static bool AddChildFolder_FolderToAdd_IsValid;

	private static FFieldAddress AddChildFolder_FolderToAdd_PropertyAddress;

	private static int AddChildFolder_FolderToAdd_Offset;

	private static bool AddChildFolder_ReturnValue_IsValid;

	private static FFieldAddress AddChildFolder_ReturnValue_PropertyAddress;

	private static int AddChildFolder_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:SetFolderName")]
	public unsafe static bool SetFolderName(UMovieSceneFolder Folder, FName InFolderName)
	{
		if (!SetFolderName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:SetFolderName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFolderName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFolderName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, SetFolderName_Folder_Offset), 0, SetFolderName_Folder_PropertyAddress.Address, Folder);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetFolderName_InFolderName_Offset), 0, SetFolderName_InFolderName_PropertyAddress.Address, InFolderName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFolderName_FunctionAddress, intPtr, SetFolderName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetFolderName_ReturnValue_Offset), 0, SetFolderName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:SetFolderColor")]
	public unsafe static bool SetFolderColor(UMovieSceneFolder Folder, FColor InFolderColor)
	{
		if (!SetFolderColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:SetFolderColor");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFolderColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFolderColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, SetFolderColor_Folder_Offset), 0, SetFolderColor_Folder_PropertyAddress.Address, Folder);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetFolderColor_InFolderColor_Offset), 0, SetFolderColor_InFolderColor_PropertyAddress.Address, InFolderColor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFolderColor_FunctionAddress, intPtr, SetFolderColor_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetFolderColor_ReturnValue_Offset), 0, SetFolderColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildObjectBinding")]
	public unsafe static bool RemoveChildObjectBinding(UMovieSceneFolder Folder, FSequencerBindingProxy InObjectBinding)
	{
		if (!RemoveChildObjectBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildObjectBinding");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveChildObjectBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveChildObjectBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, RemoveChildObjectBinding_Folder_Offset), 0, RemoveChildObjectBinding_Folder_PropertyAddress.Address, Folder);
		NativeReflection.InitializeValue_InContainer(RemoveChildObjectBinding_InObjectBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, RemoveChildObjectBinding_InObjectBinding_Offset), 0, RemoveChildObjectBinding_InObjectBinding_PropertyAddress.Address, InObjectBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveChildObjectBinding_FunctionAddress, intPtr, RemoveChildObjectBinding_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveChildObjectBinding_ReturnValue_Offset), 0, RemoveChildObjectBinding_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildMasterTrack")]
	public unsafe static bool RemoveChildMasterTrack(UMovieSceneFolder Folder, UMovieSceneTrack InMasterTrack)
	{
		if (!RemoveChildMasterTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildMasterTrack");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveChildMasterTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveChildMasterTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, RemoveChildMasterTrack_Folder_Offset), 0, RemoveChildMasterTrack_Folder_PropertyAddress.Address, Folder);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, RemoveChildMasterTrack_InMasterTrack_Offset), 0, RemoveChildMasterTrack_InMasterTrack_PropertyAddress.Address, InMasterTrack);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveChildMasterTrack_FunctionAddress, intPtr, RemoveChildMasterTrack_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveChildMasterTrack_ReturnValue_Offset), 0, RemoveChildMasterTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildFolder")]
	public unsafe static bool RemoveChildFolder(UMovieSceneFolder TargetFolder, UMovieSceneFolder FolderToRemove)
	{
		if (!RemoveChildFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildFolder");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveChildFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveChildFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, RemoveChildFolder_TargetFolder_Offset), 0, RemoveChildFolder_TargetFolder_PropertyAddress.Address, TargetFolder);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, RemoveChildFolder_FolderToRemove_Offset), 0, RemoveChildFolder_FolderToRemove_PropertyAddress.Address, FolderToRemove);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveChildFolder_FunctionAddress, intPtr, RemoveChildFolder_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveChildFolder_ReturnValue_Offset), 0, RemoveChildFolder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:GetFolderName")]
	public unsafe static FName GetFolderName(UMovieSceneFolder Folder)
	{
		if (!GetFolderName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:GetFolderName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFolderName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFolderName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, GetFolderName_Folder_Offset), 0, GetFolderName_Folder_PropertyAddress.Address, Folder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFolderName_FunctionAddress, intPtr, GetFolderName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetFolderName_ReturnValue_Offset), 0, GetFolderName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344073217u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:GetFolderColor")]
	public unsafe static FColor GetFolderColor(UMovieSceneFolder Folder)
	{
		if (!GetFolderColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:GetFolderColor");
			return default(FColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFolderColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFolderColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, GetFolderColor_Folder_Offset), 0, GetFolderColor_Folder_PropertyAddress.Address, Folder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFolderColor_FunctionAddress, intPtr, GetFolderColor_ParamsSize);
		return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(intPtr, GetFolderColor_ReturnValue_Offset), 0, GetFolderColor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildObjectBindings")]
	public unsafe static List<FSequencerBindingProxy> GetChildObjectBindings(UMovieSceneFolder Folder)
	{
		if (!GetChildObjectBindings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildObjectBindings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildObjectBindings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildObjectBindings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, GetChildObjectBindings_Folder_Offset), 0, GetChildObjectBindings_Folder_PropertyAddress.Address, Folder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChildObjectBindings_FunctionAddress, intPtr, GetChildObjectBindings_ParamsSize);
		List<FSequencerBindingProxy> result = new TArrayCopyMarshaler<FSequencerBindingProxy>(1, GetChildObjectBindings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildObjectBindings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildObjectBindings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildMasterTracks")]
	public unsafe static List<UMovieSceneTrack> GetChildMasterTracks(UMovieSceneFolder Folder)
	{
		if (!GetChildMasterTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildMasterTracks");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildMasterTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildMasterTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, GetChildMasterTracks_Folder_Offset), 0, GetChildMasterTracks_Folder_PropertyAddress.Address, Folder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChildMasterTracks_FunctionAddress, intPtr, GetChildMasterTracks_ParamsSize);
		List<UMovieSceneTrack> result = new TArrayCopyMarshaler<UMovieSceneTrack>(1, GetChildMasterTracks_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildMasterTracks_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildMasterTracks_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildFolders")]
	public unsafe static List<UMovieSceneFolder> GetChildFolders(UMovieSceneFolder Folder)
	{
		if (!GetChildFolders_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildFolders");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildFolders_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildFolders_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, GetChildFolders_Folder_Offset), 0, GetChildFolders_Folder_PropertyAddress.Address, Folder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChildFolders_FunctionAddress, intPtr, GetChildFolders_ParamsSize);
		List<UMovieSceneFolder> result = new TArrayCopyMarshaler<UMovieSceneFolder>(1, GetChildFolders_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneFolder, UObjectMarshaler<UMovieSceneFolder>>.FromNative, CachedMarshalingDelegates<UMovieSceneFolder, UObjectMarshaler<UMovieSceneFolder>>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildFolders_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildFolders_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildObjectBinding")]
	public unsafe static bool AddChildObjectBinding(UMovieSceneFolder Folder, FSequencerBindingProxy InObjectBinding)
	{
		if (!AddChildObjectBinding_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildObjectBinding");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildObjectBinding_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildObjectBinding_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, AddChildObjectBinding_Folder_Offset), 0, AddChildObjectBinding_Folder_PropertyAddress.Address, Folder);
		NativeReflection.InitializeValue_InContainer(AddChildObjectBinding_InObjectBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, AddChildObjectBinding_InObjectBinding_Offset), 0, AddChildObjectBinding_InObjectBinding_PropertyAddress.Address, InObjectBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddChildObjectBinding_FunctionAddress, intPtr, AddChildObjectBinding_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddChildObjectBinding_ReturnValue_Offset), 0, AddChildObjectBinding_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildMasterTrack")]
	public unsafe static bool AddChildMasterTrack(UMovieSceneFolder Folder, UMovieSceneTrack InMasterTrack)
	{
		if (!AddChildMasterTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildMasterTrack");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildMasterTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildMasterTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, AddChildMasterTrack_Folder_Offset), 0, AddChildMasterTrack_Folder_PropertyAddress.Address, Folder);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, AddChildMasterTrack_InMasterTrack_Offset), 0, AddChildMasterTrack_InMasterTrack_PropertyAddress.Address, InMasterTrack);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddChildMasterTrack_FunctionAddress, intPtr, AddChildMasterTrack_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddChildMasterTrack_ReturnValue_Offset), 0, AddChildMasterTrack_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildFolder")]
	public unsafe static bool AddChildFolder(UMovieSceneFolder TargetFolder, UMovieSceneFolder FolderToAdd)
	{
		if (!AddChildFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildFolder");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddChildFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddChildFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, AddChildFolder_TargetFolder_Offset), 0, AddChildFolder_TargetFolder_PropertyAddress.Address, TargetFolder);
		UObjectMarshaler<UMovieSceneFolder>.ToNative(IntPtr.Add(intPtr, AddChildFolder_FolderToAdd_Offset), 0, AddChildFolder_FolderToAdd_PropertyAddress.Address, FolderToAdd);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddChildFolder_FunctionAddress, intPtr, AddChildFolder_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddChildFolder_ReturnValue_Offset), 0, AddChildFolder_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneFolderExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneFolderExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneFolderExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneFolderExtensions");
		SetFolderName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFolderName");
		SetFolderName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFolderName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFolderName_Folder_PropertyAddress, SetFolderName_FunctionAddress, "Folder");
		SetFolderName_Folder_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderName_FunctionAddress, "Folder");
		SetFolderName_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderName_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFolderName_InFolderName_PropertyAddress, SetFolderName_FunctionAddress, "InFolderName");
		SetFolderName_InFolderName_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderName_FunctionAddress, "InFolderName");
		SetFolderName_InFolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderName_FunctionAddress, "InFolderName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFolderName_ReturnValue_PropertyAddress, SetFolderName_FunctionAddress, "ReturnValue");
		SetFolderName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderName_FunctionAddress, "ReturnValue");
		SetFolderName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetFolderName_IsValid = SetFolderName_FunctionAddress != IntPtr.Zero && SetFolderName_Folder_IsValid && SetFolderName_InFolderName_IsValid && SetFolderName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:SetFolderName", SetFolderName_IsValid);
		SetFolderColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFolderColor");
		SetFolderColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFolderColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFolderColor_Folder_PropertyAddress, SetFolderColor_FunctionAddress, "Folder");
		SetFolderColor_Folder_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderColor_FunctionAddress, "Folder");
		SetFolderColor_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderColor_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFolderColor_InFolderColor_PropertyAddress, SetFolderColor_FunctionAddress, "InFolderColor");
		SetFolderColor_InFolderColor_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderColor_FunctionAddress, "InFolderColor");
		SetFolderColor_InFolderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderColor_FunctionAddress, "InFolderColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetFolderColor_ReturnValue_PropertyAddress, SetFolderColor_FunctionAddress, "ReturnValue");
		SetFolderColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFolderColor_FunctionAddress, "ReturnValue");
		SetFolderColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFolderColor_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetFolderColor_IsValid = SetFolderColor_FunctionAddress != IntPtr.Zero && SetFolderColor_Folder_IsValid && SetFolderColor_InFolderColor_IsValid && SetFolderColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:SetFolderColor", SetFolderColor_IsValid);
		RemoveChildObjectBinding_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveChildObjectBinding");
		RemoveChildObjectBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveChildObjectBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildObjectBinding_Folder_PropertyAddress, RemoveChildObjectBinding_FunctionAddress, "Folder");
		RemoveChildObjectBinding_Folder_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildObjectBinding_FunctionAddress, "Folder");
		RemoveChildObjectBinding_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildObjectBinding_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildObjectBinding_InObjectBinding_PropertyAddress, RemoveChildObjectBinding_FunctionAddress, "InObjectBinding");
		RemoveChildObjectBinding_InObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildObjectBinding_FunctionAddress, "InObjectBinding");
		RemoveChildObjectBinding_InObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildObjectBinding_FunctionAddress, "InObjectBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildObjectBinding_ReturnValue_PropertyAddress, RemoveChildObjectBinding_FunctionAddress, "ReturnValue");
		RemoveChildObjectBinding_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildObjectBinding_FunctionAddress, "ReturnValue");
		RemoveChildObjectBinding_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildObjectBinding_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveChildObjectBinding_IsValid = RemoveChildObjectBinding_FunctionAddress != IntPtr.Zero && RemoveChildObjectBinding_Folder_IsValid && RemoveChildObjectBinding_InObjectBinding_IsValid && RemoveChildObjectBinding_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildObjectBinding", RemoveChildObjectBinding_IsValid);
		RemoveChildMasterTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveChildMasterTrack");
		RemoveChildMasterTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveChildMasterTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildMasterTrack_Folder_PropertyAddress, RemoveChildMasterTrack_FunctionAddress, "Folder");
		RemoveChildMasterTrack_Folder_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildMasterTrack_FunctionAddress, "Folder");
		RemoveChildMasterTrack_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildMasterTrack_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildMasterTrack_InMasterTrack_PropertyAddress, RemoveChildMasterTrack_FunctionAddress, "InMasterTrack");
		RemoveChildMasterTrack_InMasterTrack_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildMasterTrack_FunctionAddress, "InMasterTrack");
		RemoveChildMasterTrack_InMasterTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildMasterTrack_FunctionAddress, "InMasterTrack", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildMasterTrack_ReturnValue_PropertyAddress, RemoveChildMasterTrack_FunctionAddress, "ReturnValue");
		RemoveChildMasterTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildMasterTrack_FunctionAddress, "ReturnValue");
		RemoveChildMasterTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildMasterTrack_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveChildMasterTrack_IsValid = RemoveChildMasterTrack_FunctionAddress != IntPtr.Zero && RemoveChildMasterTrack_Folder_IsValid && RemoveChildMasterTrack_InMasterTrack_IsValid && RemoveChildMasterTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildMasterTrack", RemoveChildMasterTrack_IsValid);
		RemoveChildFolder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveChildFolder");
		RemoveChildFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveChildFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildFolder_TargetFolder_PropertyAddress, RemoveChildFolder_FunctionAddress, "TargetFolder");
		RemoveChildFolder_TargetFolder_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildFolder_FunctionAddress, "TargetFolder");
		RemoveChildFolder_TargetFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildFolder_FunctionAddress, "TargetFolder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildFolder_FolderToRemove_PropertyAddress, RemoveChildFolder_FunctionAddress, "FolderToRemove");
		RemoveChildFolder_FolderToRemove_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildFolder_FunctionAddress, "FolderToRemove");
		RemoveChildFolder_FolderToRemove_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildFolder_FunctionAddress, "FolderToRemove", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveChildFolder_ReturnValue_PropertyAddress, RemoveChildFolder_FunctionAddress, "ReturnValue");
		RemoveChildFolder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveChildFolder_FunctionAddress, "ReturnValue");
		RemoveChildFolder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveChildFolder_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveChildFolder_IsValid = RemoveChildFolder_FunctionAddress != IntPtr.Zero && RemoveChildFolder_TargetFolder_IsValid && RemoveChildFolder_FolderToRemove_IsValid && RemoveChildFolder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:RemoveChildFolder", RemoveChildFolder_IsValid);
		GetFolderName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFolderName");
		GetFolderName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFolderName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFolderName_Folder_PropertyAddress, GetFolderName_FunctionAddress, "Folder");
		GetFolderName_Folder_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderName_FunctionAddress, "Folder");
		GetFolderName_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderName_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFolderName_ReturnValue_PropertyAddress, GetFolderName_FunctionAddress, "ReturnValue");
		GetFolderName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderName_FunctionAddress, "ReturnValue");
		GetFolderName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetFolderName_IsValid = GetFolderName_FunctionAddress != IntPtr.Zero && GetFolderName_Folder_IsValid && GetFolderName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:GetFolderName", GetFolderName_IsValid);
		GetFolderColor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFolderColor");
		GetFolderColor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFolderColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFolderColor_Folder_PropertyAddress, GetFolderColor_FunctionAddress, "Folder");
		GetFolderColor_Folder_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderColor_FunctionAddress, "Folder");
		GetFolderColor_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderColor_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFolderColor_ReturnValue_PropertyAddress, GetFolderColor_FunctionAddress, "ReturnValue");
		GetFolderColor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFolderColor_FunctionAddress, "ReturnValue");
		GetFolderColor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFolderColor_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetFolderColor_IsValid = GetFolderColor_FunctionAddress != IntPtr.Zero && GetFolderColor_Folder_IsValid && GetFolderColor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:GetFolderColor", GetFolderColor_IsValid);
		GetChildObjectBindings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildObjectBindings");
		GetChildObjectBindings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildObjectBindings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildObjectBindings_Folder_PropertyAddress, GetChildObjectBindings_FunctionAddress, "Folder");
		GetChildObjectBindings_Folder_Offset = NativeReflectionCached.GetPropertyOffset(GetChildObjectBindings_FunctionAddress, "Folder");
		GetChildObjectBindings_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildObjectBindings_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildObjectBindings_ReturnValue_PropertyAddress, GetChildObjectBindings_FunctionAddress, "ReturnValue");
		GetChildObjectBindings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildObjectBindings_FunctionAddress, "ReturnValue");
		GetChildObjectBindings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildObjectBindings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChildObjectBindings_IsValid = GetChildObjectBindings_FunctionAddress != IntPtr.Zero && GetChildObjectBindings_Folder_IsValid && GetChildObjectBindings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildObjectBindings", GetChildObjectBindings_IsValid);
		GetChildMasterTracks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildMasterTracks");
		GetChildMasterTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildMasterTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildMasterTracks_Folder_PropertyAddress, GetChildMasterTracks_FunctionAddress, "Folder");
		GetChildMasterTracks_Folder_Offset = NativeReflectionCached.GetPropertyOffset(GetChildMasterTracks_FunctionAddress, "Folder");
		GetChildMasterTracks_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildMasterTracks_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildMasterTracks_ReturnValue_PropertyAddress, GetChildMasterTracks_FunctionAddress, "ReturnValue");
		GetChildMasterTracks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildMasterTracks_FunctionAddress, "ReturnValue");
		GetChildMasterTracks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildMasterTracks_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChildMasterTracks_IsValid = GetChildMasterTracks_FunctionAddress != IntPtr.Zero && GetChildMasterTracks_Folder_IsValid && GetChildMasterTracks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildMasterTracks", GetChildMasterTracks_IsValid);
		GetChildFolders_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildFolders");
		GetChildFolders_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildFolders_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildFolders_Folder_PropertyAddress, GetChildFolders_FunctionAddress, "Folder");
		GetChildFolders_Folder_Offset = NativeReflectionCached.GetPropertyOffset(GetChildFolders_FunctionAddress, "Folder");
		GetChildFolders_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildFolders_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildFolders_ReturnValue_PropertyAddress, GetChildFolders_FunctionAddress, "ReturnValue");
		GetChildFolders_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildFolders_FunctionAddress, "ReturnValue");
		GetChildFolders_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildFolders_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChildFolders_IsValid = GetChildFolders_FunctionAddress != IntPtr.Zero && GetChildFolders_Folder_IsValid && GetChildFolders_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:GetChildFolders", GetChildFolders_IsValid);
		AddChildObjectBinding_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddChildObjectBinding");
		AddChildObjectBinding_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildObjectBinding_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildObjectBinding_Folder_PropertyAddress, AddChildObjectBinding_FunctionAddress, "Folder");
		AddChildObjectBinding_Folder_Offset = NativeReflectionCached.GetPropertyOffset(AddChildObjectBinding_FunctionAddress, "Folder");
		AddChildObjectBinding_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildObjectBinding_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildObjectBinding_InObjectBinding_PropertyAddress, AddChildObjectBinding_FunctionAddress, "InObjectBinding");
		AddChildObjectBinding_InObjectBinding_Offset = NativeReflectionCached.GetPropertyOffset(AddChildObjectBinding_FunctionAddress, "InObjectBinding");
		AddChildObjectBinding_InObjectBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildObjectBinding_FunctionAddress, "InObjectBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildObjectBinding_ReturnValue_PropertyAddress, AddChildObjectBinding_FunctionAddress, "ReturnValue");
		AddChildObjectBinding_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildObjectBinding_FunctionAddress, "ReturnValue");
		AddChildObjectBinding_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildObjectBinding_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddChildObjectBinding_IsValid = AddChildObjectBinding_FunctionAddress != IntPtr.Zero && AddChildObjectBinding_Folder_IsValid && AddChildObjectBinding_InObjectBinding_IsValid && AddChildObjectBinding_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildObjectBinding", AddChildObjectBinding_IsValid);
		AddChildMasterTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddChildMasterTrack");
		AddChildMasterTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildMasterTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildMasterTrack_Folder_PropertyAddress, AddChildMasterTrack_FunctionAddress, "Folder");
		AddChildMasterTrack_Folder_Offset = NativeReflectionCached.GetPropertyOffset(AddChildMasterTrack_FunctionAddress, "Folder");
		AddChildMasterTrack_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildMasterTrack_FunctionAddress, "Folder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildMasterTrack_InMasterTrack_PropertyAddress, AddChildMasterTrack_FunctionAddress, "InMasterTrack");
		AddChildMasterTrack_InMasterTrack_Offset = NativeReflectionCached.GetPropertyOffset(AddChildMasterTrack_FunctionAddress, "InMasterTrack");
		AddChildMasterTrack_InMasterTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildMasterTrack_FunctionAddress, "InMasterTrack", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildMasterTrack_ReturnValue_PropertyAddress, AddChildMasterTrack_FunctionAddress, "ReturnValue");
		AddChildMasterTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildMasterTrack_FunctionAddress, "ReturnValue");
		AddChildMasterTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildMasterTrack_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddChildMasterTrack_IsValid = AddChildMasterTrack_FunctionAddress != IntPtr.Zero && AddChildMasterTrack_Folder_IsValid && AddChildMasterTrack_InMasterTrack_IsValid && AddChildMasterTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildMasterTrack", AddChildMasterTrack_IsValid);
		AddChildFolder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddChildFolder");
		AddChildFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(AddChildFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddChildFolder_TargetFolder_PropertyAddress, AddChildFolder_FunctionAddress, "TargetFolder");
		AddChildFolder_TargetFolder_Offset = NativeReflectionCached.GetPropertyOffset(AddChildFolder_FunctionAddress, "TargetFolder");
		AddChildFolder_TargetFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildFolder_FunctionAddress, "TargetFolder", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildFolder_FolderToAdd_PropertyAddress, AddChildFolder_FunctionAddress, "FolderToAdd");
		AddChildFolder_FolderToAdd_Offset = NativeReflectionCached.GetPropertyOffset(AddChildFolder_FunctionAddress, "FolderToAdd");
		AddChildFolder_FolderToAdd_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildFolder_FunctionAddress, "FolderToAdd", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddChildFolder_ReturnValue_PropertyAddress, AddChildFolder_FunctionAddress, "ReturnValue");
		AddChildFolder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddChildFolder_FunctionAddress, "ReturnValue");
		AddChildFolder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddChildFolder_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddChildFolder_IsValid = AddChildFolder_FunctionAddress != IntPtr.Zero && AddChildFolder_TargetFolder_IsValid && AddChildFolder_FolderToAdd_IsValid && AddChildFolder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFolderExtensions:AddChildFolder", AddChildFolder_IsValid);
	}
}
