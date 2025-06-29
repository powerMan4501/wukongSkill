using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_SequencerFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SequenceSetClockSource_IsValid;

	private static IntPtr SequenceSetClockSource_FunctionAddress;

	private static int SequenceSetClockSource_ParamsSize;

	private static bool SequenceSetClockSource_SequencePlayer_IsValid;

	private static FFieldAddress SequenceSetClockSource_SequencePlayer_PropertyAddress;

	private static int SequenceSetClockSource_SequencePlayer_Offset;

	private static bool SequenceSetClockSource_ClockSource_IsValid;

	private static FFieldAddress SequenceSetClockSource_ClockSource_PropertyAddress;

	private static int SequenceSetClockSource_ClockSource_Offset;

	private static bool SequenceSetClockSource_ReturnValue_IsValid;

	private static FFieldAddress SequenceSetClockSource_ReturnValue_PropertyAddress;

	private static int SequenceSetClockSource_ReturnValue_Offset;

	private static bool SequenceMasterAutoBind_IsValid;

	private static IntPtr SequenceMasterAutoBind_FunctionAddress;

	private static int SequenceMasterAutoBind_ParamsSize;

	private static bool SequenceMasterAutoBind_SequenceActor_IsValid;

	private static FFieldAddress SequenceMasterAutoBind_SequenceActor_PropertyAddress;

	private static int SequenceMasterAutoBind_SequenceActor_Offset;

	private static bool SequenceMasterAutoBind_MasterActor_IsValid;

	private static FFieldAddress SequenceMasterAutoBind_MasterActor_PropertyAddress;

	private static int SequenceMasterAutoBind_MasterActor_Offset;

	private static bool SequenceMasterAutoBind_ReturnValue_IsValid;

	private static FFieldAddress SequenceMasterAutoBind_ReturnValue_PropertyAddress;

	private static int SequenceMasterAutoBind_ReturnValue_Offset;

	private static bool SequenceActorSetBindingByName_IsValid;

	private static IntPtr SequenceActorSetBindingByName_FunctionAddress;

	private static int SequenceActorSetBindingByName_ParamsSize;

	private static bool SequenceActorSetBindingByName_SequenceActor_IsValid;

	private static FFieldAddress SequenceActorSetBindingByName_SequenceActor_PropertyAddress;

	private static int SequenceActorSetBindingByName_SequenceActor_Offset;

	private static bool SequenceActorSetBindingByName_TargetName_IsValid;

	private static FFieldAddress SequenceActorSetBindingByName_TargetName_PropertyAddress;

	private static int SequenceActorSetBindingByName_TargetName_Offset;

	private static bool SequenceActorSetBindingByName_Actors_IsValid;

	private static FFieldAddress SequenceActorSetBindingByName_Actors_PropertyAddress;

	private static int SequenceActorSetBindingByName_Actors_Offset;

	private static bool SequenceActorSetBindingByName_bUseDisplayName_IsValid;

	private static FFieldAddress SequenceActorSetBindingByName_bUseDisplayName_PropertyAddress;

	private static int SequenceActorSetBindingByName_bUseDisplayName_Offset;

	private static bool SequenceActorSetBindingByName_ReturnValue_IsValid;

	private static FFieldAddress SequenceActorSetBindingByName_ReturnValue_PropertyAddress;

	private static int SequenceActorSetBindingByName_ReturnValue_Offset;

	private static bool SequenceActorInitPlayerCS_IsValid;

	private static IntPtr SequenceActorInitPlayerCS_FunctionAddress;

	private static int SequenceActorInitPlayerCS_ParamsSize;

	private static bool SequenceActorInitPlayerCS_SeqActor_IsValid;

	private static FFieldAddress SequenceActorInitPlayerCS_SeqActor_PropertyAddress;

	private static int SequenceActorInitPlayerCS_SeqActor_Offset;

	private static bool SequenceActorInitPlayerCS_Lvl_IsValid;

	private static FFieldAddress SequenceActorInitPlayerCS_Lvl_PropertyAddress;

	private static int SequenceActorInitPlayerCS_Lvl_Offset;

	private static bool SequenceActorInitPlayerCS_LevelSeq_IsValid;

	private static FFieldAddress SequenceActorInitPlayerCS_LevelSeq_PropertyAddress;

	private static int SequenceActorInitPlayerCS_LevelSeq_Offset;

	private static bool SequenceActorAddBindingCS_IsValid;

	private static IntPtr SequenceActorAddBindingCS_FunctionAddress;

	private static int SequenceActorAddBindingCS_ParamsSize;

	private static bool SequenceActorAddBindingCS_SeqActor_IsValid;

	private static FFieldAddress SequenceActorAddBindingCS_SeqActor_PropertyAddress;

	private static int SequenceActorAddBindingCS_SeqActor_Offset;

	private static bool SequenceActorAddBindingCS_BindingID_IsValid;

	private static FFieldAddress SequenceActorAddBindingCS_BindingID_PropertyAddress;

	private static int SequenceActorAddBindingCS_BindingID_Offset;

	private static bool SequenceActorAddBindingCS_Actor_IsValid;

	private static FFieldAddress SequenceActorAddBindingCS_Actor_PropertyAddress;

	private static int SequenceActorAddBindingCS_Actor_Offset;

	private static bool LevelSequenceUnbindPossessableObjectCS_IsValid;

	private static IntPtr LevelSequenceUnbindPossessableObjectCS_FunctionAddress;

	private static int LevelSequenceUnbindPossessableObjectCS_ParamsSize;

	private static bool LevelSequenceUnbindPossessableObjectCS_LevelSequence_IsValid;

	private static FFieldAddress LevelSequenceUnbindPossessableObjectCS_LevelSequence_PropertyAddress;

	private static int LevelSequenceUnbindPossessableObjectCS_LevelSequence_Offset;

	private static bool LevelSequenceUnbindPossessableObjectCS_BindingID_IsValid;

	private static FFieldAddress LevelSequenceUnbindPossessableObjectCS_BindingID_PropertyAddress;

	private static int LevelSequenceUnbindPossessableObjectCS_BindingID_Offset;

	private static bool LevelSequenceBindPossessableObjectCS_IsValid;

	private static IntPtr LevelSequenceBindPossessableObjectCS_FunctionAddress;

	private static int LevelSequenceBindPossessableObjectCS_ParamsSize;

	private static bool LevelSequenceBindPossessableObjectCS_LevelSequence_IsValid;

	private static FFieldAddress LevelSequenceBindPossessableObjectCS_LevelSequence_PropertyAddress;

	private static int LevelSequenceBindPossessableObjectCS_LevelSequence_Offset;

	private static bool LevelSequenceBindPossessableObjectCS_BindingID_IsValid;

	private static FFieldAddress LevelSequenceBindPossessableObjectCS_BindingID_PropertyAddress;

	private static int LevelSequenceBindPossessableObjectCS_BindingID_Offset;

	private static bool LevelSequenceBindPossessableObjectCS_BindObj_IsValid;

	private static FFieldAddress LevelSequenceBindPossessableObjectCS_BindObj_PropertyAddress;

	private static int LevelSequenceBindPossessableObjectCS_BindObj_Offset;

	private static bool LevelSequenceBindPossessableObjectCS_Ctx_IsValid;

	private static FFieldAddress LevelSequenceBindPossessableObjectCS_Ctx_PropertyAddress;

	private static int LevelSequenceBindPossessableObjectCS_Ctx_Offset;

	private static bool IsMovieSceneObjectBindingIDValidCS_IsValid;

	private static IntPtr IsMovieSceneObjectBindingIDValidCS_FunctionAddress;

	private static int IsMovieSceneObjectBindingIDValidCS_ParamsSize;

	private static bool IsMovieSceneObjectBindingIDValidCS_BindID_IsValid;

	private static FFieldAddress IsMovieSceneObjectBindingIDValidCS_BindID_PropertyAddress;

	private static int IsMovieSceneObjectBindingIDValidCS_BindID_Offset;

	private static bool IsMovieSceneObjectBindingIDValidCS_ReturnValue_IsValid;

	private static FFieldAddress IsMovieSceneObjectBindingIDValidCS_ReturnValue_PropertyAddress;

	private static int IsMovieSceneObjectBindingIDValidCS_ReturnValue_Offset;

	private static bool GetLevelSequenceBindingIDByNameCS_IsValid;

	private static IntPtr GetLevelSequenceBindingIDByNameCS_FunctionAddress;

	private static int GetLevelSequenceBindingIDByNameCS_ParamsSize;

	private static bool GetLevelSequenceBindingIDByNameCS_LevelSequence_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByNameCS_LevelSequence_PropertyAddress;

	private static int GetLevelSequenceBindingIDByNameCS_LevelSequence_Offset;

	private static bool GetLevelSequenceBindingIDByNameCS_TargetName_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByNameCS_TargetName_PropertyAddress;

	private static int GetLevelSequenceBindingIDByNameCS_TargetName_Offset;

	private static bool GetLevelSequenceBindingIDByNameCS_ReturnValue_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByNameCS_ReturnValue_PropertyAddress;

	private static int GetLevelSequenceBindingIDByNameCS_ReturnValue_Offset;

	private static bool GetLevelSequenceBindingIDByName_IsValid;

	private static IntPtr GetLevelSequenceBindingIDByName_FunctionAddress;

	private static int GetLevelSequenceBindingIDByName_ParamsSize;

	private static bool GetLevelSequenceBindingIDByName_LevelSequence_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByName_LevelSequence_PropertyAddress;

	private static int GetLevelSequenceBindingIDByName_LevelSequence_Offset;

	private static bool GetLevelSequenceBindingIDByName_TargetName_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByName_TargetName_PropertyAddress;

	private static int GetLevelSequenceBindingIDByName_TargetName_Offset;

	private static bool GetLevelSequenceBindingIDByName_ReturnValue_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByName_ReturnValue_PropertyAddress;

	private static int GetLevelSequenceBindingIDByName_ReturnValue_Offset;

	private static bool GetLevelSequenceBindingIDByDisplayName_IsValid;

	private static IntPtr GetLevelSequenceBindingIDByDisplayName_FunctionAddress;

	private static int GetLevelSequenceBindingIDByDisplayName_ParamsSize;

	private static bool GetLevelSequenceBindingIDByDisplayName_LevelSequence_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByDisplayName_LevelSequence_PropertyAddress;

	private static int GetLevelSequenceBindingIDByDisplayName_LevelSequence_Offset;

	private static bool GetLevelSequenceBindingIDByDisplayName_TargetName_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByDisplayName_TargetName_PropertyAddress;

	private static int GetLevelSequenceBindingIDByDisplayName_TargetName_Offset;

	private static bool GetLevelSequenceBindingIDByDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetLevelSequenceBindingIDByDisplayName_ReturnValue_PropertyAddress;

	private static int GetLevelSequenceBindingIDByDisplayName_ReturnValue_Offset;

	private static bool FQualifiedTimeAsSeconds_IsValid;

	private static IntPtr FQualifiedTimeAsSeconds_FunctionAddress;

	private static int FQualifiedTimeAsSeconds_ParamsSize;

	private static bool FQualifiedTimeAsSeconds_FrameTime_IsValid;

	private static FFieldAddress FQualifiedTimeAsSeconds_FrameTime_PropertyAddress;

	private static int FQualifiedTimeAsSeconds_FrameTime_Offset;

	private static bool FQualifiedTimeAsSeconds_ReturnValue_IsValid;

	private static FFieldAddress FQualifiedTimeAsSeconds_ReturnValue_PropertyAddress;

	private static int FQualifiedTimeAsSeconds_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceSetClockSource")]
	public unsafe static bool SequenceSetClockSource(UMovieSceneSequencePlayer SequencePlayer, EUpdateClockSource ClockSource)
	{
		if (!SequenceSetClockSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceSetClockSource");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SequenceSetClockSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SequenceSetClockSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneSequencePlayer>.ToNative(IntPtr.Add(intPtr, SequenceSetClockSource_SequencePlayer_Offset), 0, SequenceSetClockSource_SequencePlayer_PropertyAddress.Address, SequencePlayer);
		EnumMarshaler<EUpdateClockSource>.ToNative(IntPtr.Add(intPtr, SequenceSetClockSource_ClockSource_Offset), 0, SequenceSetClockSource_ClockSource_PropertyAddress.Address, ClockSource);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SequenceSetClockSource_FunctionAddress, intPtr, SequenceSetClockSource_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SequenceSetClockSource_ReturnValue_Offset), 0, SequenceSetClockSource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceMasterAutoBind")]
	public unsafe static int SequenceMasterAutoBind(ALevelSequenceActor SequenceActor, AActor MasterActor)
	{
		if (!SequenceMasterAutoBind_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceMasterAutoBind");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SequenceMasterAutoBind_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SequenceMasterAutoBind_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALevelSequenceActor>.ToNative(IntPtr.Add(intPtr, SequenceMasterAutoBind_SequenceActor_Offset), 0, SequenceMasterAutoBind_SequenceActor_PropertyAddress.Address, SequenceActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SequenceMasterAutoBind_MasterActor_Offset), 0, SequenceMasterAutoBind_MasterActor_PropertyAddress.Address, MasterActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SequenceMasterAutoBind_FunctionAddress, intPtr, SequenceMasterAutoBind_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, SequenceMasterAutoBind_ReturnValue_Offset), 0, SequenceMasterAutoBind_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorSetBindingByName")]
	public unsafe static bool SequenceActorSetBindingByName(ALevelSequenceActor SequenceActor, FName TargetName, List<AActor> Actors, bool bUseDisplayName)
	{
		if (!SequenceActorSetBindingByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorSetBindingByName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SequenceActorSetBindingByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SequenceActorSetBindingByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALevelSequenceActor>.ToNative(IntPtr.Add(intPtr, SequenceActorSetBindingByName_SequenceActor_Offset), 0, SequenceActorSetBindingByName_SequenceActor_PropertyAddress.Address, SequenceActor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SequenceActorSetBindingByName_TargetName_Offset), 0, SequenceActorSetBindingByName_TargetName_PropertyAddress.Address, TargetName);
		new TArrayCopyMarshaler<AActor>(1, SequenceActorSetBindingByName_Actors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, SequenceActorSetBindingByName_Actors_Offset), Actors);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SequenceActorSetBindingByName_bUseDisplayName_Offset), 0, SequenceActorSetBindingByName_bUseDisplayName_PropertyAddress.Address, bUseDisplayName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SequenceActorSetBindingByName_FunctionAddress, intPtr, SequenceActorSetBindingByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SequenceActorSetBindingByName_Actors_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SequenceActorSetBindingByName_ReturnValue_Offset), 0, SequenceActorSetBindingByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorInitPlayerCS")]
	public unsafe static void SequenceActorInitPlayerCS(ALevelSequenceActor SeqActor, ULevel Lvl, ULevelSequence LevelSeq)
	{
		if (!SequenceActorInitPlayerCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorInitPlayerCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SequenceActorInitPlayerCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SequenceActorInitPlayerCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALevelSequenceActor>.ToNative(IntPtr.Add(intPtr, SequenceActorInitPlayerCS_SeqActor_Offset), 0, SequenceActorInitPlayerCS_SeqActor_PropertyAddress.Address, SeqActor);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, SequenceActorInitPlayerCS_Lvl_Offset), 0, SequenceActorInitPlayerCS_Lvl_PropertyAddress.Address, Lvl);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, SequenceActorInitPlayerCS_LevelSeq_Offset), 0, SequenceActorInitPlayerCS_LevelSeq_PropertyAddress.Address, LevelSeq);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SequenceActorInitPlayerCS_FunctionAddress, intPtr, SequenceActorInitPlayerCS_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorAddBindingCS")]
	public unsafe static void SequenceActorAddBindingCS(ALevelSequenceActor SeqActor, FSequenceBindingIDInCS BindingID, AActor Actor)
	{
		if (!SequenceActorAddBindingCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorAddBindingCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SequenceActorAddBindingCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SequenceActorAddBindingCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ALevelSequenceActor>.ToNative(IntPtr.Add(intPtr, SequenceActorAddBindingCS_SeqActor_Offset), 0, SequenceActorAddBindingCS_SeqActor_PropertyAddress.Address, SeqActor);
		NativeReflection.InitializeValue_InContainer(SequenceActorAddBindingCS_BindingID_PropertyAddress.Address, intPtr);
		FSequenceBindingIDInCS.ToNative(IntPtr.Add(intPtr, SequenceActorAddBindingCS_BindingID_Offset), 0, SequenceActorAddBindingCS_BindingID_PropertyAddress.Address, BindingID);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SequenceActorAddBindingCS_Actor_Offset), 0, SequenceActorAddBindingCS_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SequenceActorAddBindingCS_FunctionAddress, intPtr, SequenceActorAddBindingCS_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:LevelSequenceUnbindPossessableObjectCS")]
	public unsafe static void LevelSequenceUnbindPossessableObjectCS(ULevelSequence LevelSequence, FSequenceBindingIDInCS BindingID)
	{
		if (!LevelSequenceUnbindPossessableObjectCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:LevelSequenceUnbindPossessableObjectCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LevelSequenceUnbindPossessableObjectCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LevelSequenceUnbindPossessableObjectCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, LevelSequenceUnbindPossessableObjectCS_LevelSequence_Offset), 0, LevelSequenceUnbindPossessableObjectCS_LevelSequence_PropertyAddress.Address, LevelSequence);
		NativeReflection.InitializeValue_InContainer(LevelSequenceUnbindPossessableObjectCS_BindingID_PropertyAddress.Address, intPtr);
		FSequenceBindingIDInCS.ToNative(IntPtr.Add(intPtr, LevelSequenceUnbindPossessableObjectCS_BindingID_Offset), 0, LevelSequenceUnbindPossessableObjectCS_BindingID_PropertyAddress.Address, BindingID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LevelSequenceUnbindPossessableObjectCS_FunctionAddress, intPtr, LevelSequenceUnbindPossessableObjectCS_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:LevelSequenceBindPossessableObjectCS")]
	public unsafe static void LevelSequenceBindPossessableObjectCS(ULevelSequence LevelSequence, FSequenceBindingIDInCS BindingID, UObject BindObj, UObject Ctx)
	{
		if (!LevelSequenceBindPossessableObjectCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:LevelSequenceBindPossessableObjectCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LevelSequenceBindPossessableObjectCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LevelSequenceBindPossessableObjectCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, LevelSequenceBindPossessableObjectCS_LevelSequence_Offset), 0, LevelSequenceBindPossessableObjectCS_LevelSequence_PropertyAddress.Address, LevelSequence);
		NativeReflection.InitializeValue_InContainer(LevelSequenceBindPossessableObjectCS_BindingID_PropertyAddress.Address, intPtr);
		FSequenceBindingIDInCS.ToNative(IntPtr.Add(intPtr, LevelSequenceBindPossessableObjectCS_BindingID_Offset), 0, LevelSequenceBindPossessableObjectCS_BindingID_PropertyAddress.Address, BindingID);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LevelSequenceBindPossessableObjectCS_BindObj_Offset), 0, LevelSequenceBindPossessableObjectCS_BindObj_PropertyAddress.Address, BindObj);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, LevelSequenceBindPossessableObjectCS_Ctx_Offset), 0, LevelSequenceBindPossessableObjectCS_Ctx_PropertyAddress.Address, Ctx);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LevelSequenceBindPossessableObjectCS_FunctionAddress, intPtr, LevelSequenceBindPossessableObjectCS_ParamsSize);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:IsMovieSceneObjectBindingIDValidCS")]
	public unsafe static bool IsMovieSceneObjectBindingIDValidCS(FSequenceBindingIDInCS BindID)
	{
		if (!IsMovieSceneObjectBindingIDValidCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:IsMovieSceneObjectBindingIDValidCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMovieSceneObjectBindingIDValidCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMovieSceneObjectBindingIDValidCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsMovieSceneObjectBindingIDValidCS_BindID_PropertyAddress.Address, intPtr);
		FSequenceBindingIDInCS.ToNative(IntPtr.Add(intPtr, IsMovieSceneObjectBindingIDValidCS_BindID_Offset), 0, IsMovieSceneObjectBindingIDValidCS_BindID_PropertyAddress.Address, BindID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsMovieSceneObjectBindingIDValidCS_FunctionAddress, intPtr, IsMovieSceneObjectBindingIDValidCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMovieSceneObjectBindingIDValidCS_ReturnValue_Offset), 0, IsMovieSceneObjectBindingIDValidCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByNameCS")]
	public unsafe static FSequenceBindingIDInCS GetLevelSequenceBindingIDByNameCS(ULevelSequence LevelSequence, FName TargetName)
	{
		if (!GetLevelSequenceBindingIDByNameCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByNameCS");
			return default(FSequenceBindingIDInCS);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelSequenceBindingIDByNameCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelSequenceBindingIDByNameCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByNameCS_LevelSequence_Offset), 0, GetLevelSequenceBindingIDByNameCS_LevelSequence_PropertyAddress.Address, LevelSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByNameCS_TargetName_Offset), 0, GetLevelSequenceBindingIDByNameCS_TargetName_PropertyAddress.Address, TargetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelSequenceBindingIDByNameCS_FunctionAddress, intPtr, GetLevelSequenceBindingIDByNameCS_ParamsSize);
		return FSequenceBindingIDInCS.FromNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByNameCS_ReturnValue_Offset), 0, GetLevelSequenceBindingIDByNameCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByName")]
	public unsafe static FMovieSceneObjectBindingID GetLevelSequenceBindingIDByName(ULevelSequence LevelSequence, FName TargetName)
	{
		if (!GetLevelSequenceBindingIDByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByName");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelSequenceBindingIDByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelSequenceBindingIDByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByName_LevelSequence_Offset), 0, GetLevelSequenceBindingIDByName_LevelSequence_PropertyAddress.Address, LevelSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByName_TargetName_Offset), 0, GetLevelSequenceBindingIDByName_TargetName_PropertyAddress.Address, TargetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelSequenceBindingIDByName_FunctionAddress, intPtr, GetLevelSequenceBindingIDByName_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByName_ReturnValue_Offset), 0, GetLevelSequenceBindingIDByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByDisplayName")]
	public unsafe static FMovieSceneObjectBindingID GetLevelSequenceBindingIDByDisplayName(ULevelSequence LevelSequence, FName TargetName)
	{
		if (!GetLevelSequenceBindingIDByDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByDisplayName");
			return default(FMovieSceneObjectBindingID);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelSequenceBindingIDByDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelSequenceBindingIDByDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByDisplayName_LevelSequence_Offset), 0, GetLevelSequenceBindingIDByDisplayName_LevelSequence_PropertyAddress.Address, LevelSequence);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByDisplayName_TargetName_Offset), 0, GetLevelSequenceBindingIDByDisplayName_TargetName_PropertyAddress.Address, TargetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelSequenceBindingIDByDisplayName_FunctionAddress, intPtr, GetLevelSequenceBindingIDByDisplayName_ParamsSize);
		return FMovieSceneObjectBindingID.FromNative(IntPtr.Add(intPtr, GetLevelSequenceBindingIDByDisplayName_ReturnValue_Offset), 0, GetLevelSequenceBindingIDByDisplayName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SequencerFuncLib:FQualifiedTimeAsSeconds")]
	public unsafe static float FQualifiedTimeAsSeconds(FQualifiedTime FrameTime)
	{
		if (!FQualifiedTimeAsSeconds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SequencerFuncLib:FQualifiedTimeAsSeconds");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FQualifiedTimeAsSeconds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FQualifiedTimeAsSeconds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FQualifiedTimeAsSeconds_FrameTime_PropertyAddress.Address, intPtr);
		FQualifiedTime.ToNative(IntPtr.Add(intPtr, FQualifiedTimeAsSeconds_FrameTime_Offset), 0, FQualifiedTimeAsSeconds_FrameTime_PropertyAddress.Address, FrameTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FQualifiedTimeAsSeconds_FunctionAddress, intPtr, FQualifiedTimeAsSeconds_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, FQualifiedTimeAsSeconds_ReturnValue_Offset), 0, FQualifiedTimeAsSeconds_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_SequencerFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_SequencerFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_SequencerFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_SequencerFuncLib");
		SequenceSetClockSource_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SequenceSetClockSource");
		SequenceSetClockSource_ParamsSize = NativeReflection.GetFunctionParamsSize(SequenceSetClockSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SequenceSetClockSource_SequencePlayer_PropertyAddress, SequenceSetClockSource_FunctionAddress, "SequencePlayer");
		SequenceSetClockSource_SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(SequenceSetClockSource_FunctionAddress, "SequencePlayer");
		SequenceSetClockSource_SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceSetClockSource_FunctionAddress, "SequencePlayer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceSetClockSource_ClockSource_PropertyAddress, SequenceSetClockSource_FunctionAddress, "ClockSource");
		SequenceSetClockSource_ClockSource_Offset = NativeReflectionCached.GetPropertyOffset(SequenceSetClockSource_FunctionAddress, "ClockSource");
		SequenceSetClockSource_ClockSource_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceSetClockSource_FunctionAddress, "ClockSource", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceSetClockSource_ReturnValue_PropertyAddress, SequenceSetClockSource_FunctionAddress, "ReturnValue");
		SequenceSetClockSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SequenceSetClockSource_FunctionAddress, "ReturnValue");
		SequenceSetClockSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceSetClockSource_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SequenceSetClockSource_IsValid = SequenceSetClockSource_FunctionAddress != IntPtr.Zero && SequenceSetClockSource_SequencePlayer_IsValid && SequenceSetClockSource_ClockSource_IsValid && SequenceSetClockSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceSetClockSource", SequenceSetClockSource_IsValid);
		SequenceMasterAutoBind_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SequenceMasterAutoBind");
		SequenceMasterAutoBind_ParamsSize = NativeReflection.GetFunctionParamsSize(SequenceMasterAutoBind_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SequenceMasterAutoBind_SequenceActor_PropertyAddress, SequenceMasterAutoBind_FunctionAddress, "SequenceActor");
		SequenceMasterAutoBind_SequenceActor_Offset = NativeReflectionCached.GetPropertyOffset(SequenceMasterAutoBind_FunctionAddress, "SequenceActor");
		SequenceMasterAutoBind_SequenceActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceMasterAutoBind_FunctionAddress, "SequenceActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceMasterAutoBind_MasterActor_PropertyAddress, SequenceMasterAutoBind_FunctionAddress, "MasterActor");
		SequenceMasterAutoBind_MasterActor_Offset = NativeReflectionCached.GetPropertyOffset(SequenceMasterAutoBind_FunctionAddress, "MasterActor");
		SequenceMasterAutoBind_MasterActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceMasterAutoBind_FunctionAddress, "MasterActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceMasterAutoBind_ReturnValue_PropertyAddress, SequenceMasterAutoBind_FunctionAddress, "ReturnValue");
		SequenceMasterAutoBind_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SequenceMasterAutoBind_FunctionAddress, "ReturnValue");
		SequenceMasterAutoBind_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceMasterAutoBind_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		SequenceMasterAutoBind_IsValid = SequenceMasterAutoBind_FunctionAddress != IntPtr.Zero && SequenceMasterAutoBind_SequenceActor_IsValid && SequenceMasterAutoBind_MasterActor_IsValid && SequenceMasterAutoBind_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceMasterAutoBind", SequenceMasterAutoBind_IsValid);
		SequenceActorSetBindingByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SequenceActorSetBindingByName");
		SequenceActorSetBindingByName_ParamsSize = NativeReflection.GetFunctionParamsSize(SequenceActorSetBindingByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorSetBindingByName_SequenceActor_PropertyAddress, SequenceActorSetBindingByName_FunctionAddress, "SequenceActor");
		SequenceActorSetBindingByName_SequenceActor_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorSetBindingByName_FunctionAddress, "SequenceActor");
		SequenceActorSetBindingByName_SequenceActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorSetBindingByName_FunctionAddress, "SequenceActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorSetBindingByName_TargetName_PropertyAddress, SequenceActorSetBindingByName_FunctionAddress, "TargetName");
		SequenceActorSetBindingByName_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorSetBindingByName_FunctionAddress, "TargetName");
		SequenceActorSetBindingByName_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorSetBindingByName_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorSetBindingByName_Actors_PropertyAddress, SequenceActorSetBindingByName_FunctionAddress, "Actors");
		SequenceActorSetBindingByName_Actors_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorSetBindingByName_FunctionAddress, "Actors");
		SequenceActorSetBindingByName_Actors_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorSetBindingByName_FunctionAddress, "Actors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorSetBindingByName_bUseDisplayName_PropertyAddress, SequenceActorSetBindingByName_FunctionAddress, "bUseDisplayName");
		SequenceActorSetBindingByName_bUseDisplayName_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorSetBindingByName_FunctionAddress, "bUseDisplayName");
		SequenceActorSetBindingByName_bUseDisplayName_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorSetBindingByName_FunctionAddress, "bUseDisplayName", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorSetBindingByName_ReturnValue_PropertyAddress, SequenceActorSetBindingByName_FunctionAddress, "ReturnValue");
		SequenceActorSetBindingByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorSetBindingByName_FunctionAddress, "ReturnValue");
		SequenceActorSetBindingByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorSetBindingByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SequenceActorSetBindingByName_IsValid = SequenceActorSetBindingByName_FunctionAddress != IntPtr.Zero && SequenceActorSetBindingByName_SequenceActor_IsValid && SequenceActorSetBindingByName_TargetName_IsValid && SequenceActorSetBindingByName_Actors_IsValid && SequenceActorSetBindingByName_bUseDisplayName_IsValid && SequenceActorSetBindingByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorSetBindingByName", SequenceActorSetBindingByName_IsValid);
		SequenceActorInitPlayerCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SequenceActorInitPlayerCS");
		SequenceActorInitPlayerCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SequenceActorInitPlayerCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorInitPlayerCS_SeqActor_PropertyAddress, SequenceActorInitPlayerCS_FunctionAddress, "SeqActor");
		SequenceActorInitPlayerCS_SeqActor_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorInitPlayerCS_FunctionAddress, "SeqActor");
		SequenceActorInitPlayerCS_SeqActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorInitPlayerCS_FunctionAddress, "SeqActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorInitPlayerCS_Lvl_PropertyAddress, SequenceActorInitPlayerCS_FunctionAddress, "Lvl");
		SequenceActorInitPlayerCS_Lvl_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorInitPlayerCS_FunctionAddress, "Lvl");
		SequenceActorInitPlayerCS_Lvl_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorInitPlayerCS_FunctionAddress, "Lvl", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorInitPlayerCS_LevelSeq_PropertyAddress, SequenceActorInitPlayerCS_FunctionAddress, "LevelSeq");
		SequenceActorInitPlayerCS_LevelSeq_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorInitPlayerCS_FunctionAddress, "LevelSeq");
		SequenceActorInitPlayerCS_LevelSeq_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorInitPlayerCS_FunctionAddress, "LevelSeq", Classes.FObjectProperty);
		SequenceActorInitPlayerCS_IsValid = SequenceActorInitPlayerCS_FunctionAddress != IntPtr.Zero && SequenceActorInitPlayerCS_SeqActor_IsValid && SequenceActorInitPlayerCS_Lvl_IsValid && SequenceActorInitPlayerCS_LevelSeq_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorInitPlayerCS", SequenceActorInitPlayerCS_IsValid);
		SequenceActorAddBindingCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SequenceActorAddBindingCS");
		SequenceActorAddBindingCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SequenceActorAddBindingCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorAddBindingCS_SeqActor_PropertyAddress, SequenceActorAddBindingCS_FunctionAddress, "SeqActor");
		SequenceActorAddBindingCS_SeqActor_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorAddBindingCS_FunctionAddress, "SeqActor");
		SequenceActorAddBindingCS_SeqActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorAddBindingCS_FunctionAddress, "SeqActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorAddBindingCS_BindingID_PropertyAddress, SequenceActorAddBindingCS_FunctionAddress, "BindingID");
		SequenceActorAddBindingCS_BindingID_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorAddBindingCS_FunctionAddress, "BindingID");
		SequenceActorAddBindingCS_BindingID_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorAddBindingCS_FunctionAddress, "BindingID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceActorAddBindingCS_Actor_PropertyAddress, SequenceActorAddBindingCS_FunctionAddress, "Actor");
		SequenceActorAddBindingCS_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SequenceActorAddBindingCS_FunctionAddress, "Actor");
		SequenceActorAddBindingCS_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceActorAddBindingCS_FunctionAddress, "Actor", Classes.FObjectProperty);
		SequenceActorAddBindingCS_IsValid = SequenceActorAddBindingCS_FunctionAddress != IntPtr.Zero && SequenceActorAddBindingCS_SeqActor_IsValid && SequenceActorAddBindingCS_BindingID_IsValid && SequenceActorAddBindingCS_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:SequenceActorAddBindingCS", SequenceActorAddBindingCS_IsValid);
		LevelSequenceUnbindPossessableObjectCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LevelSequenceUnbindPossessableObjectCS");
		LevelSequenceUnbindPossessableObjectCS_ParamsSize = NativeReflection.GetFunctionParamsSize(LevelSequenceUnbindPossessableObjectCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LevelSequenceUnbindPossessableObjectCS_LevelSequence_PropertyAddress, LevelSequenceUnbindPossessableObjectCS_FunctionAddress, "LevelSequence");
		LevelSequenceUnbindPossessableObjectCS_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(LevelSequenceUnbindPossessableObjectCS_FunctionAddress, "LevelSequence");
		LevelSequenceUnbindPossessableObjectCS_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(LevelSequenceUnbindPossessableObjectCS_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LevelSequenceUnbindPossessableObjectCS_BindingID_PropertyAddress, LevelSequenceUnbindPossessableObjectCS_FunctionAddress, "BindingID");
		LevelSequenceUnbindPossessableObjectCS_BindingID_Offset = NativeReflectionCached.GetPropertyOffset(LevelSequenceUnbindPossessableObjectCS_FunctionAddress, "BindingID");
		LevelSequenceUnbindPossessableObjectCS_BindingID_IsValid = NativeReflectionCached.ValidatePropertyClass(LevelSequenceUnbindPossessableObjectCS_FunctionAddress, "BindingID", Classes.FStructProperty);
		LevelSequenceUnbindPossessableObjectCS_IsValid = LevelSequenceUnbindPossessableObjectCS_FunctionAddress != IntPtr.Zero && LevelSequenceUnbindPossessableObjectCS_LevelSequence_IsValid && LevelSequenceUnbindPossessableObjectCS_BindingID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:LevelSequenceUnbindPossessableObjectCS", LevelSequenceUnbindPossessableObjectCS_IsValid);
		LevelSequenceBindPossessableObjectCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LevelSequenceBindPossessableObjectCS");
		LevelSequenceBindPossessableObjectCS_ParamsSize = NativeReflection.GetFunctionParamsSize(LevelSequenceBindPossessableObjectCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LevelSequenceBindPossessableObjectCS_LevelSequence_PropertyAddress, LevelSequenceBindPossessableObjectCS_FunctionAddress, "LevelSequence");
		LevelSequenceBindPossessableObjectCS_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(LevelSequenceBindPossessableObjectCS_FunctionAddress, "LevelSequence");
		LevelSequenceBindPossessableObjectCS_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(LevelSequenceBindPossessableObjectCS_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LevelSequenceBindPossessableObjectCS_BindingID_PropertyAddress, LevelSequenceBindPossessableObjectCS_FunctionAddress, "BindingID");
		LevelSequenceBindPossessableObjectCS_BindingID_Offset = NativeReflectionCached.GetPropertyOffset(LevelSequenceBindPossessableObjectCS_FunctionAddress, "BindingID");
		LevelSequenceBindPossessableObjectCS_BindingID_IsValid = NativeReflectionCached.ValidatePropertyClass(LevelSequenceBindPossessableObjectCS_FunctionAddress, "BindingID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LevelSequenceBindPossessableObjectCS_BindObj_PropertyAddress, LevelSequenceBindPossessableObjectCS_FunctionAddress, "BindObj");
		LevelSequenceBindPossessableObjectCS_BindObj_Offset = NativeReflectionCached.GetPropertyOffset(LevelSequenceBindPossessableObjectCS_FunctionAddress, "BindObj");
		LevelSequenceBindPossessableObjectCS_BindObj_IsValid = NativeReflectionCached.ValidatePropertyClass(LevelSequenceBindPossessableObjectCS_FunctionAddress, "BindObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LevelSequenceBindPossessableObjectCS_Ctx_PropertyAddress, LevelSequenceBindPossessableObjectCS_FunctionAddress, "Ctx");
		LevelSequenceBindPossessableObjectCS_Ctx_Offset = NativeReflectionCached.GetPropertyOffset(LevelSequenceBindPossessableObjectCS_FunctionAddress, "Ctx");
		LevelSequenceBindPossessableObjectCS_Ctx_IsValid = NativeReflectionCached.ValidatePropertyClass(LevelSequenceBindPossessableObjectCS_FunctionAddress, "Ctx", Classes.FObjectProperty);
		LevelSequenceBindPossessableObjectCS_IsValid = LevelSequenceBindPossessableObjectCS_FunctionAddress != IntPtr.Zero && LevelSequenceBindPossessableObjectCS_LevelSequence_IsValid && LevelSequenceBindPossessableObjectCS_BindingID_IsValid && LevelSequenceBindPossessableObjectCS_BindObj_IsValid && LevelSequenceBindPossessableObjectCS_Ctx_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:LevelSequenceBindPossessableObjectCS", LevelSequenceBindPossessableObjectCS_IsValid);
		IsMovieSceneObjectBindingIDValidCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsMovieSceneObjectBindingIDValidCS");
		IsMovieSceneObjectBindingIDValidCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMovieSceneObjectBindingIDValidCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMovieSceneObjectBindingIDValidCS_BindID_PropertyAddress, IsMovieSceneObjectBindingIDValidCS_FunctionAddress, "BindID");
		IsMovieSceneObjectBindingIDValidCS_BindID_Offset = NativeReflectionCached.GetPropertyOffset(IsMovieSceneObjectBindingIDValidCS_FunctionAddress, "BindID");
		IsMovieSceneObjectBindingIDValidCS_BindID_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMovieSceneObjectBindingIDValidCS_FunctionAddress, "BindID", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMovieSceneObjectBindingIDValidCS_ReturnValue_PropertyAddress, IsMovieSceneObjectBindingIDValidCS_FunctionAddress, "ReturnValue");
		IsMovieSceneObjectBindingIDValidCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMovieSceneObjectBindingIDValidCS_FunctionAddress, "ReturnValue");
		IsMovieSceneObjectBindingIDValidCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMovieSceneObjectBindingIDValidCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMovieSceneObjectBindingIDValidCS_IsValid = IsMovieSceneObjectBindingIDValidCS_FunctionAddress != IntPtr.Zero && IsMovieSceneObjectBindingIDValidCS_BindID_IsValid && IsMovieSceneObjectBindingIDValidCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:IsMovieSceneObjectBindingIDValidCS", IsMovieSceneObjectBindingIDValidCS_IsValid);
		GetLevelSequenceBindingIDByNameCS_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelSequenceBindingIDByNameCS");
		GetLevelSequenceBindingIDByNameCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelSequenceBindingIDByNameCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByNameCS_LevelSequence_PropertyAddress, GetLevelSequenceBindingIDByNameCS_FunctionAddress, "LevelSequence");
		GetLevelSequenceBindingIDByNameCS_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByNameCS_FunctionAddress, "LevelSequence");
		GetLevelSequenceBindingIDByNameCS_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByNameCS_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByNameCS_TargetName_PropertyAddress, GetLevelSequenceBindingIDByNameCS_FunctionAddress, "TargetName");
		GetLevelSequenceBindingIDByNameCS_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByNameCS_FunctionAddress, "TargetName");
		GetLevelSequenceBindingIDByNameCS_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByNameCS_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByNameCS_ReturnValue_PropertyAddress, GetLevelSequenceBindingIDByNameCS_FunctionAddress, "ReturnValue");
		GetLevelSequenceBindingIDByNameCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByNameCS_FunctionAddress, "ReturnValue");
		GetLevelSequenceBindingIDByNameCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByNameCS_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLevelSequenceBindingIDByNameCS_IsValid = GetLevelSequenceBindingIDByNameCS_FunctionAddress != IntPtr.Zero && GetLevelSequenceBindingIDByNameCS_LevelSequence_IsValid && GetLevelSequenceBindingIDByNameCS_TargetName_IsValid && GetLevelSequenceBindingIDByNameCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByNameCS", GetLevelSequenceBindingIDByNameCS_IsValid);
		GetLevelSequenceBindingIDByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelSequenceBindingIDByName");
		GetLevelSequenceBindingIDByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelSequenceBindingIDByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByName_LevelSequence_PropertyAddress, GetLevelSequenceBindingIDByName_FunctionAddress, "LevelSequence");
		GetLevelSequenceBindingIDByName_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByName_FunctionAddress, "LevelSequence");
		GetLevelSequenceBindingIDByName_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByName_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByName_TargetName_PropertyAddress, GetLevelSequenceBindingIDByName_FunctionAddress, "TargetName");
		GetLevelSequenceBindingIDByName_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByName_FunctionAddress, "TargetName");
		GetLevelSequenceBindingIDByName_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByName_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByName_ReturnValue_PropertyAddress, GetLevelSequenceBindingIDByName_FunctionAddress, "ReturnValue");
		GetLevelSequenceBindingIDByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByName_FunctionAddress, "ReturnValue");
		GetLevelSequenceBindingIDByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLevelSequenceBindingIDByName_IsValid = GetLevelSequenceBindingIDByName_FunctionAddress != IntPtr.Zero && GetLevelSequenceBindingIDByName_LevelSequence_IsValid && GetLevelSequenceBindingIDByName_TargetName_IsValid && GetLevelSequenceBindingIDByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByName", GetLevelSequenceBindingIDByName_IsValid);
		GetLevelSequenceBindingIDByDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelSequenceBindingIDByDisplayName");
		GetLevelSequenceBindingIDByDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelSequenceBindingIDByDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByDisplayName_LevelSequence_PropertyAddress, GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "LevelSequence");
		GetLevelSequenceBindingIDByDisplayName_LevelSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "LevelSequence");
		GetLevelSequenceBindingIDByDisplayName_LevelSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "LevelSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByDisplayName_TargetName_PropertyAddress, GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "TargetName");
		GetLevelSequenceBindingIDByDisplayName_TargetName_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "TargetName");
		GetLevelSequenceBindingIDByDisplayName_TargetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "TargetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelSequenceBindingIDByDisplayName_ReturnValue_PropertyAddress, GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "ReturnValue");
		GetLevelSequenceBindingIDByDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "ReturnValue");
		GetLevelSequenceBindingIDByDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelSequenceBindingIDByDisplayName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLevelSequenceBindingIDByDisplayName_IsValid = GetLevelSequenceBindingIDByDisplayName_FunctionAddress != IntPtr.Zero && GetLevelSequenceBindingIDByDisplayName_LevelSequence_IsValid && GetLevelSequenceBindingIDByDisplayName_TargetName_IsValid && GetLevelSequenceBindingIDByDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:GetLevelSequenceBindingIDByDisplayName", GetLevelSequenceBindingIDByDisplayName_IsValid);
		FQualifiedTimeAsSeconds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FQualifiedTimeAsSeconds");
		FQualifiedTimeAsSeconds_ParamsSize = NativeReflection.GetFunctionParamsSize(FQualifiedTimeAsSeconds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FQualifiedTimeAsSeconds_FrameTime_PropertyAddress, FQualifiedTimeAsSeconds_FunctionAddress, "FrameTime");
		FQualifiedTimeAsSeconds_FrameTime_Offset = NativeReflectionCached.GetPropertyOffset(FQualifiedTimeAsSeconds_FunctionAddress, "FrameTime");
		FQualifiedTimeAsSeconds_FrameTime_IsValid = NativeReflectionCached.ValidatePropertyClass(FQualifiedTimeAsSeconds_FunctionAddress, "FrameTime", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FQualifiedTimeAsSeconds_ReturnValue_PropertyAddress, FQualifiedTimeAsSeconds_FunctionAddress, "ReturnValue");
		FQualifiedTimeAsSeconds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FQualifiedTimeAsSeconds_FunctionAddress, "ReturnValue");
		FQualifiedTimeAsSeconds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FQualifiedTimeAsSeconds_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		FQualifiedTimeAsSeconds_IsValid = FQualifiedTimeAsSeconds_FunctionAddress != IntPtr.Zero && FQualifiedTimeAsSeconds_FrameTime_IsValid && FQualifiedTimeAsSeconds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SequencerFuncLib:FQualifiedTimeAsSeconds", FQualifiedTimeAsSeconds_IsValid);
	}
}
