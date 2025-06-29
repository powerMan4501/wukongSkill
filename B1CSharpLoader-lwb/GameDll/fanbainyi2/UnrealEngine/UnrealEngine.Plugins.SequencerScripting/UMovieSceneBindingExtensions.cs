using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneBindingExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetParent_IsValid;

	private static IntPtr SetParent_FunctionAddress;

	private static int SetParent_ParamsSize;

	private static bool SetParent_InBinding_IsValid;

	private static FFieldAddress SetParent_InBinding_PropertyAddress;

	private static int SetParent_InBinding_Offset;

	private static bool SetParent_InParentBinding_IsValid;

	private static FFieldAddress SetParent_InParentBinding_PropertyAddress;

	private static int SetParent_InParentBinding_Offset;

	private static bool SetName_IsValid;

	private static IntPtr SetName_FunctionAddress;

	private static int SetName_ParamsSize;

	private static bool SetName_InBinding_IsValid;

	private static FFieldAddress SetName_InBinding_PropertyAddress;

	private static int SetName_InBinding_Offset;

	private static bool SetName_InName_IsValid;

	private static FFieldAddress SetName_InName_PropertyAddress;

	private static int SetName_InName_Offset;

	private static bool SetDisplayName_IsValid;

	private static IntPtr SetDisplayName_FunctionAddress;

	private static int SetDisplayName_ParamsSize;

	private static bool SetDisplayName_InBinding_IsValid;

	private static FFieldAddress SetDisplayName_InBinding_PropertyAddress;

	private static int SetDisplayName_InBinding_Offset;

	private static bool SetDisplayName_InDisplayName_IsValid;

	private static FFieldAddress SetDisplayName_InDisplayName_PropertyAddress;

	private static int SetDisplayName_InDisplayName_Offset;

	private static bool RemoveTrack_IsValid;

	private static IntPtr RemoveTrack_FunctionAddress;

	private static int RemoveTrack_ParamsSize;

	private static bool RemoveTrack_InBinding_IsValid;

	private static FFieldAddress RemoveTrack_InBinding_PropertyAddress;

	private static int RemoveTrack_InBinding_Offset;

	private static bool RemoveTrack_TrackToRemove_IsValid;

	private static FFieldAddress RemoveTrack_TrackToRemove_PropertyAddress;

	private static int RemoveTrack_TrackToRemove_Offset;

	private static bool Remove_IsValid;

	private static IntPtr Remove_FunctionAddress;

	private static int Remove_ParamsSize;

	private static bool Remove_InBinding_IsValid;

	private static FFieldAddress Remove_InBinding_PropertyAddress;

	private static int Remove_InBinding_Offset;

	private static bool MoveBindingContents_IsValid;

	private static IntPtr MoveBindingContents_FunctionAddress;

	private static int MoveBindingContents_ParamsSize;

	private static bool MoveBindingContents_SourceBindingId_IsValid;

	private static FFieldAddress MoveBindingContents_SourceBindingId_PropertyAddress;

	private static int MoveBindingContents_SourceBindingId_Offset;

	private static bool MoveBindingContents_DestinationBindingId_IsValid;

	private static FFieldAddress MoveBindingContents_DestinationBindingId_PropertyAddress;

	private static int MoveBindingContents_DestinationBindingId_Offset;

	private static bool IsValid_IsValid;

	private static IntPtr IsValid_FunctionAddress;

	private static int IsValid_ParamsSize;

	private static bool IsValid_InBinding_IsValid;

	private static FFieldAddress IsValid_InBinding_PropertyAddress;

	private static int IsValid_InBinding_Offset;

	private static bool IsValid_ReturnValue_IsValid;

	private static FFieldAddress IsValid_ReturnValue_PropertyAddress;

	private static int IsValid_ReturnValue_Offset;

	private static bool GetTracks_IsValid;

	private static IntPtr GetTracks_FunctionAddress;

	private static int GetTracks_ParamsSize;

	private static bool GetTracks_InBinding_IsValid;

	private static FFieldAddress GetTracks_InBinding_PropertyAddress;

	private static int GetTracks_InBinding_Offset;

	private static bool GetTracks_ReturnValue_IsValid;

	private static FFieldAddress GetTracks_ReturnValue_PropertyAddress;

	private static int GetTracks_ReturnValue_Offset;

	private static bool GetPossessedObjectClass_IsValid;

	private static IntPtr GetPossessedObjectClass_FunctionAddress;

	private static int GetPossessedObjectClass_ParamsSize;

	private static bool GetPossessedObjectClass_InBinding_IsValid;

	private static FFieldAddress GetPossessedObjectClass_InBinding_PropertyAddress;

	private static int GetPossessedObjectClass_InBinding_Offset;

	private static bool GetPossessedObjectClass_ReturnValue_IsValid;

	private static FFieldAddress GetPossessedObjectClass_ReturnValue_PropertyAddress;

	private static int GetPossessedObjectClass_ReturnValue_Offset;

	private static bool GetParent_IsValid;

	private static IntPtr GetParent_FunctionAddress;

	private static int GetParent_ParamsSize;

	private static bool GetParent_InBinding_IsValid;

	private static FFieldAddress GetParent_InBinding_PropertyAddress;

	private static int GetParent_InBinding_Offset;

	private static bool GetParent_ReturnValue_IsValid;

	private static FFieldAddress GetParent_ReturnValue_PropertyAddress;

	private static int GetParent_ReturnValue_Offset;

	private static bool GetObjectTemplate_IsValid;

	private static IntPtr GetObjectTemplate_FunctionAddress;

	private static int GetObjectTemplate_ParamsSize;

	private static bool GetObjectTemplate_InBinding_IsValid;

	private static FFieldAddress GetObjectTemplate_InBinding_PropertyAddress;

	private static int GetObjectTemplate_InBinding_Offset;

	private static bool GetObjectTemplate_ReturnValue_IsValid;

	private static FFieldAddress GetObjectTemplate_ReturnValue_PropertyAddress;

	private static int GetObjectTemplate_ReturnValue_Offset;

	private static bool GetName_IsValid;

	private static IntPtr GetName_FunctionAddress;

	private static int GetName_ParamsSize;

	private static bool GetName_InBinding_IsValid;

	private static FFieldAddress GetName_InBinding_PropertyAddress;

	private static int GetName_InBinding_Offset;

	private static bool GetName_ReturnValue_IsValid;

	private static FFieldAddress GetName_ReturnValue_PropertyAddress;

	private static int GetName_ReturnValue_Offset;

	private static bool GetId_IsValid;

	private static IntPtr GetId_FunctionAddress;

	private static int GetId_ParamsSize;

	private static bool GetId_InBinding_IsValid;

	private static FFieldAddress GetId_InBinding_PropertyAddress;

	private static int GetId_InBinding_Offset;

	private static bool GetId_ReturnValue_IsValid;

	private static FFieldAddress GetId_ReturnValue_PropertyAddress;

	private static int GetId_ReturnValue_Offset;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_InBinding_IsValid;

	private static FFieldAddress GetDisplayName_InBinding_PropertyAddress;

	private static int GetDisplayName_InBinding_Offset;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static int GetDisplayName_ReturnValue_Offset;

	private static bool GetChildPossessables_IsValid;

	private static IntPtr GetChildPossessables_FunctionAddress;

	private static int GetChildPossessables_ParamsSize;

	private static bool GetChildPossessables_InBinding_IsValid;

	private static FFieldAddress GetChildPossessables_InBinding_PropertyAddress;

	private static int GetChildPossessables_InBinding_Offset;

	private static bool GetChildPossessables_ReturnValue_IsValid;

	private static FFieldAddress GetChildPossessables_ReturnValue_PropertyAddress;

	private static int GetChildPossessables_ReturnValue_Offset;

	private static bool FindTracksByType_IsValid;

	private static IntPtr FindTracksByType_FunctionAddress;

	private static int FindTracksByType_ParamsSize;

	private static bool FindTracksByType_InBinding_IsValid;

	private static FFieldAddress FindTracksByType_InBinding_PropertyAddress;

	private static int FindTracksByType_InBinding_Offset;

	private static bool FindTracksByType_TrackType_IsValid;

	private static FFieldAddress FindTracksByType_TrackType_PropertyAddress;

	private static int FindTracksByType_TrackType_Offset;

	private static bool FindTracksByType_ReturnValue_IsValid;

	private static FFieldAddress FindTracksByType_ReturnValue_PropertyAddress;

	private static int FindTracksByType_ReturnValue_Offset;

	private static bool FindTracksByExactType_IsValid;

	private static IntPtr FindTracksByExactType_FunctionAddress;

	private static int FindTracksByExactType_ParamsSize;

	private static bool FindTracksByExactType_InBinding_IsValid;

	private static FFieldAddress FindTracksByExactType_InBinding_PropertyAddress;

	private static int FindTracksByExactType_InBinding_Offset;

	private static bool FindTracksByExactType_TrackType_IsValid;

	private static FFieldAddress FindTracksByExactType_TrackType_PropertyAddress;

	private static int FindTracksByExactType_TrackType_Offset;

	private static bool FindTracksByExactType_ReturnValue_IsValid;

	private static FFieldAddress FindTracksByExactType_ReturnValue_PropertyAddress;

	private static int FindTracksByExactType_ReturnValue_Offset;

	private static bool AddTrack_IsValid;

	private static IntPtr AddTrack_FunctionAddress;

	private static int AddTrack_ParamsSize;

	private static bool AddTrack_InBinding_IsValid;

	private static FFieldAddress AddTrack_InBinding_PropertyAddress;

	private static int AddTrack_InBinding_Offset;

	private static bool AddTrack_TrackType_IsValid;

	private static FFieldAddress AddTrack_TrackType_PropertyAddress;

	private static int AddTrack_TrackType_Offset;

	private static bool AddTrack_ReturnValue_IsValid;

	private static FFieldAddress AddTrack_ReturnValue_PropertyAddress;

	private static int AddTrack_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:SetParent")]
	public unsafe static void SetParent(FSequencerBindingProxy InBinding, FSequencerBindingProxy InParentBinding)
	{
		if (!SetParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:SetParent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetParent_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, SetParent_InBinding_Offset), 0, SetParent_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InitializeValue_InContainer(SetParent_InParentBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, SetParent_InParentBinding_Offset), 0, SetParent_InParentBinding_PropertyAddress.Address, InParentBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetParent_FunctionAddress, intPtr, SetParent_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:SetName")]
	public unsafe static void SetName(FSequencerBindingProxy InBinding, string InName)
	{
		if (!SetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:SetName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetName_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, SetName_InBinding_Offset), 0, SetName_InBinding_PropertyAddress.Address, InBinding);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetName_InName_Offset), 0, SetName_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetName_FunctionAddress, intPtr, SetName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetName_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:SetDisplayName")]
	public unsafe static void SetDisplayName(FSequencerBindingProxy InBinding, FText InDisplayName)
	{
		if (!SetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:SetDisplayName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetDisplayName_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, SetDisplayName_InBinding_Offset), 0, SetDisplayName_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InitializeValue_InContainer(SetDisplayName_InDisplayName_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetDisplayName_InDisplayName_Offset), 0, SetDisplayName_InDisplayName_PropertyAddress.Address, InDisplayName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDisplayName_FunctionAddress, intPtr, SetDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDisplayName_InDisplayName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:RemoveTrack")]
	public unsafe static void RemoveTrack(FSequencerBindingProxy InBinding, UMovieSceneTrack TrackToRemove)
	{
		if (!RemoveTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:RemoveTrack");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveTrack_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, RemoveTrack_InBinding_Offset), 0, RemoveTrack_InBinding_PropertyAddress.Address, InBinding);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, RemoveTrack_TrackToRemove_Offset), 0, RemoveTrack_TrackToRemove_PropertyAddress.Address, TrackToRemove);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveTrack_FunctionAddress, intPtr, RemoveTrack_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:Remove")]
	public unsafe static void Remove(FSequencerBindingProxy InBinding)
	{
		if (!Remove_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:Remove");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Remove_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Remove_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(Remove_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, Remove_InBinding_Offset), 0, Remove_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, Remove_FunctionAddress, intPtr, Remove_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:MoveBindingContents")]
	public unsafe static void MoveBindingContents(FSequencerBindingProxy SourceBindingId, FSequencerBindingProxy DestinationBindingId)
	{
		if (!MoveBindingContents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:MoveBindingContents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveBindingContents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveBindingContents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MoveBindingContents_SourceBindingId_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, MoveBindingContents_SourceBindingId_Offset), 0, MoveBindingContents_SourceBindingId_PropertyAddress.Address, SourceBindingId);
		NativeReflection.InitializeValue_InContainer(MoveBindingContents_DestinationBindingId_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, MoveBindingContents_DestinationBindingId_Offset), 0, MoveBindingContents_DestinationBindingId_PropertyAddress.Address, DestinationBindingId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MoveBindingContents_FunctionAddress, intPtr, MoveBindingContents_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:IsValid")]
	public unsafe static bool IsValid(FSequencerBindingProxy InBinding)
	{
		if (!IsValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:IsValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsValid_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, IsValid_InBinding_Offset), 0, IsValid_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsValid_FunctionAddress, intPtr, IsValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsValid_ReturnValue_Offset), 0, IsValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:GetTracks")]
	public unsafe static List<UMovieSceneTrack> GetTracks(FSequencerBindingProxy InBinding)
	{
		if (!GetTracks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:GetTracks");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTracks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTracks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTracks_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetTracks_InBinding_Offset), 0, GetTracks_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTracks_FunctionAddress, intPtr, GetTracks_ParamsSize);
		List<UMovieSceneTrack> result = new TArrayCopyMarshaler<UMovieSceneTrack>(1, GetTracks_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTracks_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTracks_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:GetPossessedObjectClass")]
	public unsafe static TSubclassOf<UObject> GetPossessedObjectClass(FSequencerBindingProxy InBinding)
	{
		if (!GetPossessedObjectClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:GetPossessedObjectClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPossessedObjectClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPossessedObjectClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetPossessedObjectClass_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetPossessedObjectClass_InBinding_Offset), 0, GetPossessedObjectClass_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPossessedObjectClass_FunctionAddress, intPtr, GetPossessedObjectClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetPossessedObjectClass_ReturnValue_Offset), 0, GetPossessedObjectClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:GetParent")]
	public unsafe static FSequencerBindingProxy GetParent(FSequencerBindingProxy InBinding)
	{
		if (!GetParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:GetParent");
			return default(FSequencerBindingProxy);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetParent_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetParent_InBinding_Offset), 0, GetParent_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetParent_FunctionAddress, intPtr, GetParent_ParamsSize);
		return FSequencerBindingProxy.FromNative(IntPtr.Add(intPtr, GetParent_ReturnValue_Offset), 0, GetParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:GetObjectTemplate")]
	public unsafe static UObject GetObjectTemplate(FSequencerBindingProxy InBinding)
	{
		if (!GetObjectTemplate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:GetObjectTemplate");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectTemplate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectTemplate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetObjectTemplate_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetObjectTemplate_InBinding_Offset), 0, GetObjectTemplate_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObjectTemplate_FunctionAddress, intPtr, GetObjectTemplate_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObjectTemplate_ReturnValue_Offset), 0, GetObjectTemplate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:GetName")]
	public unsafe static string GetName(FSequencerBindingProxy InBinding)
	{
		if (!GetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:GetName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetName_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetName_InBinding_Offset), 0, GetName_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetName_FunctionAddress, intPtr, GetName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetName_ReturnValue_Offset), 0, GetName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:GetId")]
	public unsafe static Guid GetId(FSequencerBindingProxy InBinding)
	{
		if (!GetId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:GetId");
			return default(Guid);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetId_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetId_InBinding_Offset), 0, GetId_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetId_FunctionAddress, intPtr, GetId_ParamsSize);
		return BlittableTypeMarshaler<Guid>.FromNative(IntPtr.Add(intPtr, GetId_ReturnValue_Offset), 0, GetId_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:GetDisplayName")]
	public unsafe static string GetDisplayName(FSequencerBindingProxy InBinding)
	{
		if (!GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDisplayName_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetDisplayName_InBinding_Offset), 0, GetDisplayName_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDisplayName_FunctionAddress, intPtr, GetDisplayName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayName_ReturnValue_Offset), 0, GetDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:GetChildPossessables")]
	public unsafe static List<FSequencerBindingProxy> GetChildPossessables(FSequencerBindingProxy InBinding)
	{
		if (!GetChildPossessables_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:GetChildPossessables");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetChildPossessables_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetChildPossessables_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetChildPossessables_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, GetChildPossessables_InBinding_Offset), 0, GetChildPossessables_InBinding_PropertyAddress.Address, InBinding);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetChildPossessables_FunctionAddress, intPtr, GetChildPossessables_ParamsSize);
		List<FSequencerBindingProxy> result = new TArrayCopyMarshaler<FSequencerBindingProxy>(1, GetChildPossessables_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.FromNative, CachedMarshalingDelegates<FSequencerBindingProxy, FSequencerBindingProxy>.ToNative).FromNative(IntPtr.Add(intPtr, GetChildPossessables_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetChildPossessables_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:FindTracksByType")]
	public unsafe static List<UMovieSceneTrack> FindTracksByType(FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		if (!FindTracksByType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:FindTracksByType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindTracksByType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindTracksByType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindTracksByType_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, FindTracksByType_InBinding_Offset), 0, FindTracksByType_InBinding_PropertyAddress.Address, InBinding);
		TSubclassOfMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, FindTracksByType_TrackType_Offset), 0, FindTracksByType_TrackType_PropertyAddress.Address, TrackType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindTracksByType_FunctionAddress, intPtr, FindTracksByType_ParamsSize);
		List<UMovieSceneTrack> result = new TArrayCopyMarshaler<UMovieSceneTrack>(1, FindTracksByType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).FromNative(IntPtr.Add(intPtr, FindTracksByType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindTracksByType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:FindTracksByExactType")]
	public unsafe static List<UMovieSceneTrack> FindTracksByExactType(FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		if (!FindTracksByExactType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:FindTracksByExactType");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindTracksByExactType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindTracksByExactType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindTracksByExactType_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, FindTracksByExactType_InBinding_Offset), 0, FindTracksByExactType_InBinding_PropertyAddress.Address, InBinding);
		TSubclassOfMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, FindTracksByExactType_TrackType_Offset), 0, FindTracksByExactType_TrackType_PropertyAddress.Address, TrackType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindTracksByExactType_FunctionAddress, intPtr, FindTracksByExactType_ParamsSize);
		List<UMovieSceneTrack> result = new TArrayCopyMarshaler<UMovieSceneTrack>(1, FindTracksByExactType_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.FromNative, CachedMarshalingDelegates<UMovieSceneTrack, UObjectMarshaler<UMovieSceneTrack>>.ToNative).FromNative(IntPtr.Add(intPtr, FindTracksByExactType_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindTracksByExactType_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneBindingExtensions:AddTrack")]
	public unsafe static UMovieSceneTrack AddTrack(FSequencerBindingProxy InBinding, TSubclassOf<UMovieSceneTrack> TrackType)
	{
		if (!AddTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneBindingExtensions:AddTrack");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddTrack_InBinding_PropertyAddress.Address, intPtr);
		FSequencerBindingProxy.ToNative(IntPtr.Add(intPtr, AddTrack_InBinding_Offset), 0, AddTrack_InBinding_PropertyAddress.Address, InBinding);
		TSubclassOfMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, AddTrack_TrackType_Offset), 0, AddTrack_TrackType_PropertyAddress.Address, TrackType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddTrack_FunctionAddress, intPtr, AddTrack_ParamsSize);
		return UObjectMarshaler<UMovieSceneTrack>.FromNative(IntPtr.Add(intPtr, AddTrack_ReturnValue_Offset), 0, AddTrack_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneBindingExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneBindingExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneBindingExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneBindingExtensions");
		SetParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetParent");
		SetParent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetParent_InBinding_PropertyAddress, SetParent_FunctionAddress, "InBinding");
		SetParent_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(SetParent_FunctionAddress, "InBinding");
		SetParent_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParent_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetParent_InParentBinding_PropertyAddress, SetParent_FunctionAddress, "InParentBinding");
		SetParent_InParentBinding_Offset = NativeReflectionCached.GetPropertyOffset(SetParent_FunctionAddress, "InParentBinding");
		SetParent_InParentBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetParent_FunctionAddress, "InParentBinding", Classes.FStructProperty);
		SetParent_IsValid = SetParent_FunctionAddress != IntPtr.Zero && SetParent_InBinding_IsValid && SetParent_InParentBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:SetParent", SetParent_IsValid);
		SetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetName");
		SetName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetName_InBinding_PropertyAddress, SetName_FunctionAddress, "InBinding");
		SetName_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(SetName_FunctionAddress, "InBinding");
		SetName_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetName_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetName_InName_PropertyAddress, SetName_FunctionAddress, "InName");
		SetName_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetName_FunctionAddress, "InName");
		SetName_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetName_FunctionAddress, "InName", Classes.FStrProperty);
		SetName_IsValid = SetName_FunctionAddress != IntPtr.Zero && SetName_InBinding_IsValid && SetName_InName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:SetName", SetName_IsValid);
		SetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDisplayName");
		SetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayName_InBinding_PropertyAddress, SetDisplayName_FunctionAddress, "InBinding");
		SetDisplayName_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayName_FunctionAddress, "InBinding");
		SetDisplayName_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayName_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayName_InDisplayName_PropertyAddress, SetDisplayName_FunctionAddress, "InDisplayName");
		SetDisplayName_InDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayName_FunctionAddress, "InDisplayName");
		SetDisplayName_InDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayName_FunctionAddress, "InDisplayName", Classes.FTextProperty);
		SetDisplayName_IsValid = SetDisplayName_FunctionAddress != IntPtr.Zero && SetDisplayName_InBinding_IsValid && SetDisplayName_InDisplayName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:SetDisplayName", SetDisplayName_IsValid);
		RemoveTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveTrack");
		RemoveTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveTrack_InBinding_PropertyAddress, RemoveTrack_FunctionAddress, "InBinding");
		RemoveTrack_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTrack_FunctionAddress, "InBinding");
		RemoveTrack_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTrack_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveTrack_TrackToRemove_PropertyAddress, RemoveTrack_FunctionAddress, "TrackToRemove");
		RemoveTrack_TrackToRemove_Offset = NativeReflectionCached.GetPropertyOffset(RemoveTrack_FunctionAddress, "TrackToRemove");
		RemoveTrack_TrackToRemove_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveTrack_FunctionAddress, "TrackToRemove", Classes.FObjectProperty);
		RemoveTrack_IsValid = RemoveTrack_FunctionAddress != IntPtr.Zero && RemoveTrack_InBinding_IsValid && RemoveTrack_TrackToRemove_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:RemoveTrack", RemoveTrack_IsValid);
		Remove_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "Remove");
		Remove_ParamsSize = NativeReflection.GetFunctionParamsSize(Remove_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Remove_InBinding_PropertyAddress, Remove_FunctionAddress, "InBinding");
		Remove_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(Remove_FunctionAddress, "InBinding");
		Remove_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(Remove_FunctionAddress, "InBinding", Classes.FStructProperty);
		Remove_IsValid = Remove_FunctionAddress != IntPtr.Zero && Remove_InBinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:Remove", Remove_IsValid);
		MoveBindingContents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MoveBindingContents");
		MoveBindingContents_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveBindingContents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveBindingContents_SourceBindingId_PropertyAddress, MoveBindingContents_FunctionAddress, "SourceBindingId");
		MoveBindingContents_SourceBindingId_Offset = NativeReflectionCached.GetPropertyOffset(MoveBindingContents_FunctionAddress, "SourceBindingId");
		MoveBindingContents_SourceBindingId_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveBindingContents_FunctionAddress, "SourceBindingId", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveBindingContents_DestinationBindingId_PropertyAddress, MoveBindingContents_FunctionAddress, "DestinationBindingId");
		MoveBindingContents_DestinationBindingId_Offset = NativeReflectionCached.GetPropertyOffset(MoveBindingContents_FunctionAddress, "DestinationBindingId");
		MoveBindingContents_DestinationBindingId_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveBindingContents_FunctionAddress, "DestinationBindingId", Classes.FStructProperty);
		MoveBindingContents_IsValid = MoveBindingContents_FunctionAddress != IntPtr.Zero && MoveBindingContents_SourceBindingId_IsValid && MoveBindingContents_DestinationBindingId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:MoveBindingContents", MoveBindingContents_IsValid);
		IsValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsValid");
		IsValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsValid_InBinding_PropertyAddress, IsValid_FunctionAddress, "InBinding");
		IsValid_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "InBinding");
		IsValid_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsValid_ReturnValue_PropertyAddress, IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsValid_FunctionAddress, "ReturnValue");
		IsValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsValid_IsValid = IsValid_FunctionAddress != IntPtr.Zero && IsValid_InBinding_IsValid && IsValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:IsValid", IsValid_IsValid);
		GetTracks_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTracks");
		GetTracks_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTracks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTracks_InBinding_PropertyAddress, GetTracks_FunctionAddress, "InBinding");
		GetTracks_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetTracks_FunctionAddress, "InBinding");
		GetTracks_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTracks_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTracks_ReturnValue_PropertyAddress, GetTracks_FunctionAddress, "ReturnValue");
		GetTracks_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTracks_FunctionAddress, "ReturnValue");
		GetTracks_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTracks_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetTracks_IsValid = GetTracks_FunctionAddress != IntPtr.Zero && GetTracks_InBinding_IsValid && GetTracks_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:GetTracks", GetTracks_IsValid);
		GetPossessedObjectClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPossessedObjectClass");
		GetPossessedObjectClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPossessedObjectClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPossessedObjectClass_InBinding_PropertyAddress, GetPossessedObjectClass_FunctionAddress, "InBinding");
		GetPossessedObjectClass_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetPossessedObjectClass_FunctionAddress, "InBinding");
		GetPossessedObjectClass_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossessedObjectClass_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPossessedObjectClass_ReturnValue_PropertyAddress, GetPossessedObjectClass_FunctionAddress, "ReturnValue");
		GetPossessedObjectClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPossessedObjectClass_FunctionAddress, "ReturnValue");
		GetPossessedObjectClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPossessedObjectClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetPossessedObjectClass_IsValid = GetPossessedObjectClass_FunctionAddress != IntPtr.Zero && GetPossessedObjectClass_InBinding_IsValid && GetPossessedObjectClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:GetPossessedObjectClass", GetPossessedObjectClass_IsValid);
		GetParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetParent");
		GetParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParent_InBinding_PropertyAddress, GetParent_FunctionAddress, "InBinding");
		GetParent_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetParent_FunctionAddress, "InBinding");
		GetParent_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParent_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetParent_ReturnValue_PropertyAddress, GetParent_FunctionAddress, "ReturnValue");
		GetParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParent_FunctionAddress, "ReturnValue");
		GetParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetParent_IsValid = GetParent_FunctionAddress != IntPtr.Zero && GetParent_InBinding_IsValid && GetParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:GetParent", GetParent_IsValid);
		GetObjectTemplate_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObjectTemplate");
		GetObjectTemplate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectTemplate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectTemplate_InBinding_PropertyAddress, GetObjectTemplate_FunctionAddress, "InBinding");
		GetObjectTemplate_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectTemplate_FunctionAddress, "InBinding");
		GetObjectTemplate_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectTemplate_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectTemplate_ReturnValue_PropertyAddress, GetObjectTemplate_FunctionAddress, "ReturnValue");
		GetObjectTemplate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectTemplate_FunctionAddress, "ReturnValue");
		GetObjectTemplate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectTemplate_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetObjectTemplate_IsValid = GetObjectTemplate_FunctionAddress != IntPtr.Zero && GetObjectTemplate_InBinding_IsValid && GetObjectTemplate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:GetObjectTemplate", GetObjectTemplate_IsValid);
		GetName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetName");
		GetName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetName_InBinding_PropertyAddress, GetName_FunctionAddress, "InBinding");
		GetName_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetName_FunctionAddress, "InBinding");
		GetName_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetName_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetName_ReturnValue_PropertyAddress, GetName_FunctionAddress, "ReturnValue");
		GetName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetName_FunctionAddress, "ReturnValue");
		GetName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetName_IsValid = GetName_FunctionAddress != IntPtr.Zero && GetName_InBinding_IsValid && GetName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:GetName", GetName_IsValid);
		GetId_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetId");
		GetId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetId_InBinding_PropertyAddress, GetId_FunctionAddress, "InBinding");
		GetId_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetId_FunctionAddress, "InBinding");
		GetId_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetId_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetId_ReturnValue_PropertyAddress, GetId_FunctionAddress, "ReturnValue");
		GetId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetId_FunctionAddress, "ReturnValue");
		GetId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetId_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetId_IsValid = GetId_FunctionAddress != IntPtr.Zero && GetId_InBinding_IsValid && GetId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:GetId", GetId_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_InBinding_PropertyAddress, GetDisplayName_FunctionAddress, "InBinding");
		GetDisplayName_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "InBinding");
		GetDisplayName_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_InBinding_IsValid && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:GetDisplayName", GetDisplayName_IsValid);
		GetChildPossessables_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetChildPossessables");
		GetChildPossessables_ParamsSize = NativeReflection.GetFunctionParamsSize(GetChildPossessables_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetChildPossessables_InBinding_PropertyAddress, GetChildPossessables_FunctionAddress, "InBinding");
		GetChildPossessables_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(GetChildPossessables_FunctionAddress, "InBinding");
		GetChildPossessables_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildPossessables_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetChildPossessables_ReturnValue_PropertyAddress, GetChildPossessables_FunctionAddress, "ReturnValue");
		GetChildPossessables_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetChildPossessables_FunctionAddress, "ReturnValue");
		GetChildPossessables_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetChildPossessables_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetChildPossessables_IsValid = GetChildPossessables_FunctionAddress != IntPtr.Zero && GetChildPossessables_InBinding_IsValid && GetChildPossessables_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:GetChildPossessables", GetChildPossessables_IsValid);
		FindTracksByType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindTracksByType");
		FindTracksByType_ParamsSize = NativeReflection.GetFunctionParamsSize(FindTracksByType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindTracksByType_InBinding_PropertyAddress, FindTracksByType_FunctionAddress, "InBinding");
		FindTracksByType_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(FindTracksByType_FunctionAddress, "InBinding");
		FindTracksByType_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTracksByType_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTracksByType_TrackType_PropertyAddress, FindTracksByType_FunctionAddress, "TrackType");
		FindTracksByType_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(FindTracksByType_FunctionAddress, "TrackType");
		FindTracksByType_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTracksByType_FunctionAddress, "TrackType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTracksByType_ReturnValue_PropertyAddress, FindTracksByType_FunctionAddress, "ReturnValue");
		FindTracksByType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindTracksByType_FunctionAddress, "ReturnValue");
		FindTracksByType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTracksByType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindTracksByType_IsValid = FindTracksByType_FunctionAddress != IntPtr.Zero && FindTracksByType_InBinding_IsValid && FindTracksByType_TrackType_IsValid && FindTracksByType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:FindTracksByType", FindTracksByType_IsValid);
		FindTracksByExactType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindTracksByExactType");
		FindTracksByExactType_ParamsSize = NativeReflection.GetFunctionParamsSize(FindTracksByExactType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindTracksByExactType_InBinding_PropertyAddress, FindTracksByExactType_FunctionAddress, "InBinding");
		FindTracksByExactType_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(FindTracksByExactType_FunctionAddress, "InBinding");
		FindTracksByExactType_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTracksByExactType_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTracksByExactType_TrackType_PropertyAddress, FindTracksByExactType_FunctionAddress, "TrackType");
		FindTracksByExactType_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(FindTracksByExactType_FunctionAddress, "TrackType");
		FindTracksByExactType_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTracksByExactType_FunctionAddress, "TrackType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindTracksByExactType_ReturnValue_PropertyAddress, FindTracksByExactType_FunctionAddress, "ReturnValue");
		FindTracksByExactType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindTracksByExactType_FunctionAddress, "ReturnValue");
		FindTracksByExactType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindTracksByExactType_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindTracksByExactType_IsValid = FindTracksByExactType_FunctionAddress != IntPtr.Zero && FindTracksByExactType_InBinding_IsValid && FindTracksByExactType_TrackType_IsValid && FindTracksByExactType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:FindTracksByExactType", FindTracksByExactType_IsValid);
		AddTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddTrack");
		AddTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(AddTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddTrack_InBinding_PropertyAddress, AddTrack_FunctionAddress, "InBinding");
		AddTrack_InBinding_Offset = NativeReflectionCached.GetPropertyOffset(AddTrack_FunctionAddress, "InBinding");
		AddTrack_InBinding_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrack_FunctionAddress, "InBinding", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTrack_TrackType_PropertyAddress, AddTrack_FunctionAddress, "TrackType");
		AddTrack_TrackType_Offset = NativeReflectionCached.GetPropertyOffset(AddTrack_FunctionAddress, "TrackType");
		AddTrack_TrackType_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrack_FunctionAddress, "TrackType", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddTrack_ReturnValue_PropertyAddress, AddTrack_FunctionAddress, "ReturnValue");
		AddTrack_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddTrack_FunctionAddress, "ReturnValue");
		AddTrack_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddTrack_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddTrack_IsValid = AddTrack_FunctionAddress != IntPtr.Zero && AddTrack_InBinding_IsValid && AddTrack_TrackType_IsValid && AddTrack_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneBindingExtensions:AddTrack", AddTrack_IsValid);
	}
}
