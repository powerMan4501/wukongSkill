using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;

namespace UnrealEngine.Runtime;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary", "GameplayTags", UnrealModuleType.Engine)]
public class UGameplayTagLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RemoveGameplayTag_IsValid;

	private static IntPtr RemoveGameplayTag_FunctionAddress;

	private static int RemoveGameplayTag_ParamsSize;

	private static bool RemoveGameplayTag_TagContainer_IsValid;

	private static FFieldAddress RemoveGameplayTag_TagContainer_PropertyAddress;

	private static int RemoveGameplayTag_TagContainer_Offset;

	private static bool RemoveGameplayTag_Tag_IsValid;

	private static FFieldAddress RemoveGameplayTag_Tag_PropertyAddress;

	private static int RemoveGameplayTag_Tag_Offset;

	private static bool RemoveGameplayTag_ReturnValue_IsValid;

	private static FFieldAddress RemoveGameplayTag_ReturnValue_PropertyAddress;

	private static int RemoveGameplayTag_ReturnValue_Offset;

	private static bool NotEqual_GameplayTagContainer_IsValid;

	private static IntPtr NotEqual_GameplayTagContainer_FunctionAddress;

	private static int NotEqual_GameplayTagContainer_ParamsSize;

	private static bool NotEqual_GameplayTagContainer_A_IsValid;

	private static FFieldAddress NotEqual_GameplayTagContainer_A_PropertyAddress;

	private static int NotEqual_GameplayTagContainer_A_Offset;

	private static bool NotEqual_GameplayTagContainer_B_IsValid;

	private static FFieldAddress NotEqual_GameplayTagContainer_B_PropertyAddress;

	private static int NotEqual_GameplayTagContainer_B_Offset;

	private static bool NotEqual_GameplayTagContainer_ReturnValue_IsValid;

	private static FFieldAddress NotEqual_GameplayTagContainer_ReturnValue_PropertyAddress;

	private static int NotEqual_GameplayTagContainer_ReturnValue_Offset;

	private static bool NotEqual_GameplayTag_IsValid;

	private static IntPtr NotEqual_GameplayTag_FunctionAddress;

	private static int NotEqual_GameplayTag_ParamsSize;

	private static bool NotEqual_GameplayTag_A_IsValid;

	private static FFieldAddress NotEqual_GameplayTag_A_PropertyAddress;

	private static int NotEqual_GameplayTag_A_Offset;

	private static bool NotEqual_GameplayTag_B_IsValid;

	private static FFieldAddress NotEqual_GameplayTag_B_PropertyAddress;

	private static int NotEqual_GameplayTag_B_Offset;

	private static bool NotEqual_GameplayTag_ReturnValue_IsValid;

	private static FFieldAddress NotEqual_GameplayTag_ReturnValue_PropertyAddress;

	private static int NotEqual_GameplayTag_ReturnValue_Offset;

	private static bool MatchesTag_IsValid;

	private static IntPtr MatchesTag_FunctionAddress;

	private static int MatchesTag_ParamsSize;

	private static bool MatchesTag_TagOne_IsValid;

	private static FFieldAddress MatchesTag_TagOne_PropertyAddress;

	private static int MatchesTag_TagOne_Offset;

	private static bool MatchesTag_TagTwo_IsValid;

	private static FFieldAddress MatchesTag_TagTwo_PropertyAddress;

	private static int MatchesTag_TagTwo_Offset;

	private static bool MatchesTag_bExactMatch_IsValid;

	private static FFieldAddress MatchesTag_bExactMatch_PropertyAddress;

	private static int MatchesTag_bExactMatch_Offset;

	private static bool MatchesTag_ReturnValue_IsValid;

	private static FFieldAddress MatchesTag_ReturnValue_PropertyAddress;

	private static int MatchesTag_ReturnValue_Offset;

	private static bool MatchesAnyTags_IsValid;

	private static IntPtr MatchesAnyTags_FunctionAddress;

	private static int MatchesAnyTags_ParamsSize;

	private static bool MatchesAnyTags_TagOne_IsValid;

	private static FFieldAddress MatchesAnyTags_TagOne_PropertyAddress;

	private static int MatchesAnyTags_TagOne_Offset;

	private static bool MatchesAnyTags_OtherContainer_IsValid;

	private static FFieldAddress MatchesAnyTags_OtherContainer_PropertyAddress;

	private static int MatchesAnyTags_OtherContainer_Offset;

	private static bool MatchesAnyTags_bExactMatch_IsValid;

	private static FFieldAddress MatchesAnyTags_bExactMatch_PropertyAddress;

	private static int MatchesAnyTags_bExactMatch_Offset;

	private static bool MatchesAnyTags_ReturnValue_IsValid;

	private static FFieldAddress MatchesAnyTags_ReturnValue_PropertyAddress;

	private static int MatchesAnyTags_ReturnValue_Offset;

	private static bool MakeLiteralGameplayTagContainer_IsValid;

	private static IntPtr MakeLiteralGameplayTagContainer_FunctionAddress;

	private static int MakeLiteralGameplayTagContainer_ParamsSize;

	private static bool MakeLiteralGameplayTagContainer_Value_IsValid;

	private static FFieldAddress MakeLiteralGameplayTagContainer_Value_PropertyAddress;

	private static int MakeLiteralGameplayTagContainer_Value_Offset;

	private static bool MakeLiteralGameplayTagContainer_ReturnValue_IsValid;

	private static FFieldAddress MakeLiteralGameplayTagContainer_ReturnValue_PropertyAddress;

	private static int MakeLiteralGameplayTagContainer_ReturnValue_Offset;

	private static bool MakeLiteralGameplayTag_IsValid;

	private static IntPtr MakeLiteralGameplayTag_FunctionAddress;

	private static int MakeLiteralGameplayTag_ParamsSize;

	private static bool MakeLiteralGameplayTag_Value_IsValid;

	private static FFieldAddress MakeLiteralGameplayTag_Value_PropertyAddress;

	private static int MakeLiteralGameplayTag_Value_Offset;

	private static bool MakeLiteralGameplayTag_ReturnValue_IsValid;

	private static FFieldAddress MakeLiteralGameplayTag_ReturnValue_PropertyAddress;

	private static int MakeLiteralGameplayTag_ReturnValue_Offset;

	private static bool MakeGameplayTagQuery_IsValid;

	private static IntPtr MakeGameplayTagQuery_FunctionAddress;

	private static int MakeGameplayTagQuery_ParamsSize;

	private static bool MakeGameplayTagQuery_TagQuery_IsValid;

	private static FFieldAddress MakeGameplayTagQuery_TagQuery_PropertyAddress;

	private static int MakeGameplayTagQuery_TagQuery_Offset;

	private static bool MakeGameplayTagQuery_ReturnValue_IsValid;

	private static FFieldAddress MakeGameplayTagQuery_ReturnValue_PropertyAddress;

	private static int MakeGameplayTagQuery_ReturnValue_Offset;

	private static bool MakeGameplayTagContainerFromTag_IsValid;

	private static IntPtr MakeGameplayTagContainerFromTag_FunctionAddress;

	private static int MakeGameplayTagContainerFromTag_ParamsSize;

	private static bool MakeGameplayTagContainerFromTag_SingleTag_IsValid;

	private static FFieldAddress MakeGameplayTagContainerFromTag_SingleTag_PropertyAddress;

	private static int MakeGameplayTagContainerFromTag_SingleTag_Offset;

	private static bool MakeGameplayTagContainerFromTag_ReturnValue_IsValid;

	private static FFieldAddress MakeGameplayTagContainerFromTag_ReturnValue_PropertyAddress;

	private static int MakeGameplayTagContainerFromTag_ReturnValue_Offset;

	private static bool MakeGameplayTagContainerFromArray_IsValid;

	private static IntPtr MakeGameplayTagContainerFromArray_FunctionAddress;

	private static int MakeGameplayTagContainerFromArray_ParamsSize;

	private static bool MakeGameplayTagContainerFromArray_GameplayTags_IsValid;

	private static FFieldAddress MakeGameplayTagContainerFromArray_GameplayTags_PropertyAddress;

	private static int MakeGameplayTagContainerFromArray_GameplayTags_Offset;

	private static bool MakeGameplayTagContainerFromArray_ReturnValue_IsValid;

	private static FFieldAddress MakeGameplayTagContainerFromArray_ReturnValue_PropertyAddress;

	private static int MakeGameplayTagContainerFromArray_ReturnValue_Offset;

	private static bool IsTagQueryEmpty_IsValid;

	private static IntPtr IsTagQueryEmpty_FunctionAddress;

	private static int IsTagQueryEmpty_ParamsSize;

	private static bool IsTagQueryEmpty_TagQuery_IsValid;

	private static FFieldAddress IsTagQueryEmpty_TagQuery_PropertyAddress;

	private static int IsTagQueryEmpty_TagQuery_Offset;

	private static bool IsTagQueryEmpty_ReturnValue_IsValid;

	private static FFieldAddress IsTagQueryEmpty_ReturnValue_PropertyAddress;

	private static int IsTagQueryEmpty_ReturnValue_Offset;

	private static bool IsGameplayTagValid_IsValid;

	private static IntPtr IsGameplayTagValid_FunctionAddress;

	private static int IsGameplayTagValid_ParamsSize;

	private static bool IsGameplayTagValid_GameplayTag_IsValid;

	private static FFieldAddress IsGameplayTagValid_GameplayTag_PropertyAddress;

	private static int IsGameplayTagValid_GameplayTag_Offset;

	private static bool IsGameplayTagValid_ReturnValue_IsValid;

	private static FFieldAddress IsGameplayTagValid_ReturnValue_PropertyAddress;

	private static int IsGameplayTagValid_ReturnValue_Offset;

	private static bool HasTag_IsValid;

	private static IntPtr HasTag_FunctionAddress;

	private static int HasTag_ParamsSize;

	private static bool HasTag_TagContainer_IsValid;

	private static FFieldAddress HasTag_TagContainer_PropertyAddress;

	private static int HasTag_TagContainer_Offset;

	private static bool HasTag_Tag_IsValid;

	private static FFieldAddress HasTag_Tag_PropertyAddress;

	private static int HasTag_Tag_Offset;

	private static bool HasTag_bExactMatch_IsValid;

	private static FFieldAddress HasTag_bExactMatch_PropertyAddress;

	private static int HasTag_bExactMatch_Offset;

	private static bool HasTag_ReturnValue_IsValid;

	private static FFieldAddress HasTag_ReturnValue_PropertyAddress;

	private static int HasTag_ReturnValue_Offset;

	private static bool HasAnyTags_IsValid;

	private static IntPtr HasAnyTags_FunctionAddress;

	private static int HasAnyTags_ParamsSize;

	private static bool HasAnyTags_TagContainer_IsValid;

	private static FFieldAddress HasAnyTags_TagContainer_PropertyAddress;

	private static int HasAnyTags_TagContainer_Offset;

	private static bool HasAnyTags_OtherContainer_IsValid;

	private static FFieldAddress HasAnyTags_OtherContainer_PropertyAddress;

	private static int HasAnyTags_OtherContainer_Offset;

	private static bool HasAnyTags_bExactMatch_IsValid;

	private static FFieldAddress HasAnyTags_bExactMatch_PropertyAddress;

	private static int HasAnyTags_bExactMatch_Offset;

	private static bool HasAnyTags_ReturnValue_IsValid;

	private static FFieldAddress HasAnyTags_ReturnValue_PropertyAddress;

	private static int HasAnyTags_ReturnValue_Offset;

	private static bool HasAllTags_IsValid;

	private static IntPtr HasAllTags_FunctionAddress;

	private static int HasAllTags_ParamsSize;

	private static bool HasAllTags_TagContainer_IsValid;

	private static FFieldAddress HasAllTags_TagContainer_PropertyAddress;

	private static int HasAllTags_TagContainer_Offset;

	private static bool HasAllTags_OtherContainer_IsValid;

	private static FFieldAddress HasAllTags_OtherContainer_PropertyAddress;

	private static int HasAllTags_OtherContainer_Offset;

	private static bool HasAllTags_bExactMatch_IsValid;

	private static FFieldAddress HasAllTags_bExactMatch_PropertyAddress;

	private static int HasAllTags_bExactMatch_Offset;

	private static bool HasAllTags_ReturnValue_IsValid;

	private static FFieldAddress HasAllTags_ReturnValue_PropertyAddress;

	private static int HasAllTags_ReturnValue_Offset;

	private static bool GetTagName_IsValid;

	private static IntPtr GetTagName_FunctionAddress;

	private static int GetTagName_ParamsSize;

	private static bool GetTagName_GameplayTag_IsValid;

	private static FFieldAddress GetTagName_GameplayTag_PropertyAddress;

	private static int GetTagName_GameplayTag_Offset;

	private static bool GetTagName_ReturnValue_IsValid;

	private static FFieldAddress GetTagName_ReturnValue_PropertyAddress;

	private static int GetTagName_ReturnValue_Offset;

	private static bool GetNumGameplayTagsInContainer_IsValid;

	private static IntPtr GetNumGameplayTagsInContainer_FunctionAddress;

	private static int GetNumGameplayTagsInContainer_ParamsSize;

	private static bool GetNumGameplayTagsInContainer_TagContainer_IsValid;

	private static FFieldAddress GetNumGameplayTagsInContainer_TagContainer_PropertyAddress;

	private static int GetNumGameplayTagsInContainer_TagContainer_Offset;

	private static bool GetNumGameplayTagsInContainer_ReturnValue_IsValid;

	private static FFieldAddress GetNumGameplayTagsInContainer_ReturnValue_PropertyAddress;

	private static int GetNumGameplayTagsInContainer_ReturnValue_Offset;

	private static bool GetDebugStringFromGameplayTagContainer_IsValid;

	private static IntPtr GetDebugStringFromGameplayTagContainer_FunctionAddress;

	private static int GetDebugStringFromGameplayTagContainer_ParamsSize;

	private static bool GetDebugStringFromGameplayTagContainer_TagContainer_IsValid;

	private static FFieldAddress GetDebugStringFromGameplayTagContainer_TagContainer_PropertyAddress;

	private static int GetDebugStringFromGameplayTagContainer_TagContainer_Offset;

	private static bool GetDebugStringFromGameplayTagContainer_ReturnValue_IsValid;

	private static FFieldAddress GetDebugStringFromGameplayTagContainer_ReturnValue_PropertyAddress;

	private static int GetDebugStringFromGameplayTagContainer_ReturnValue_Offset;

	private static bool GetDebugStringFromGameplayTag_IsValid;

	private static IntPtr GetDebugStringFromGameplayTag_FunctionAddress;

	private static int GetDebugStringFromGameplayTag_ParamsSize;

	private static bool GetDebugStringFromGameplayTag_GameplayTag_IsValid;

	private static FFieldAddress GetDebugStringFromGameplayTag_GameplayTag_PropertyAddress;

	private static int GetDebugStringFromGameplayTag_GameplayTag_Offset;

	private static bool GetDebugStringFromGameplayTag_ReturnValue_IsValid;

	private static FFieldAddress GetDebugStringFromGameplayTag_ReturnValue_PropertyAddress;

	private static int GetDebugStringFromGameplayTag_ReturnValue_Offset;

	private static bool GetAllActorsOfClassMatchingTagQuery_IsValid;

	private static IntPtr GetAllActorsOfClassMatchingTagQuery_FunctionAddress;

	private static int GetAllActorsOfClassMatchingTagQuery_ParamsSize;

	private static bool GetAllActorsOfClassMatchingTagQuery_WorldContextObject_IsValid;

	private static FFieldAddress GetAllActorsOfClassMatchingTagQuery_WorldContextObject_PropertyAddress;

	private static int GetAllActorsOfClassMatchingTagQuery_WorldContextObject_Offset;

	private static bool GetAllActorsOfClassMatchingTagQuery_ActorClass_IsValid;

	private static FFieldAddress GetAllActorsOfClassMatchingTagQuery_ActorClass_PropertyAddress;

	private static int GetAllActorsOfClassMatchingTagQuery_ActorClass_Offset;

	private static bool GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_IsValid;

	private static FFieldAddress GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_PropertyAddress;

	private static int GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_Offset;

	private static bool GetAllActorsOfClassMatchingTagQuery_OutActors_IsValid;

	private static FFieldAddress GetAllActorsOfClassMatchingTagQuery_OutActors_PropertyAddress;

	private static int GetAllActorsOfClassMatchingTagQuery_OutActors_Offset;

	private static bool EqualEqual_GameplayTagContainer_IsValid;

	private static IntPtr EqualEqual_GameplayTagContainer_FunctionAddress;

	private static int EqualEqual_GameplayTagContainer_ParamsSize;

	private static bool EqualEqual_GameplayTagContainer_A_IsValid;

	private static FFieldAddress EqualEqual_GameplayTagContainer_A_PropertyAddress;

	private static int EqualEqual_GameplayTagContainer_A_Offset;

	private static bool EqualEqual_GameplayTagContainer_B_IsValid;

	private static FFieldAddress EqualEqual_GameplayTagContainer_B_PropertyAddress;

	private static int EqualEqual_GameplayTagContainer_B_Offset;

	private static bool EqualEqual_GameplayTagContainer_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_GameplayTagContainer_ReturnValue_PropertyAddress;

	private static int EqualEqual_GameplayTagContainer_ReturnValue_Offset;

	private static bool EqualEqual_GameplayTag_IsValid;

	private static IntPtr EqualEqual_GameplayTag_FunctionAddress;

	private static int EqualEqual_GameplayTag_ParamsSize;

	private static bool EqualEqual_GameplayTag_A_IsValid;

	private static FFieldAddress EqualEqual_GameplayTag_A_PropertyAddress;

	private static int EqualEqual_GameplayTag_A_Offset;

	private static bool EqualEqual_GameplayTag_B_IsValid;

	private static FFieldAddress EqualEqual_GameplayTag_B_PropertyAddress;

	private static int EqualEqual_GameplayTag_B_Offset;

	private static bool EqualEqual_GameplayTag_ReturnValue_IsValid;

	private static FFieldAddress EqualEqual_GameplayTag_ReturnValue_PropertyAddress;

	private static int EqualEqual_GameplayTag_ReturnValue_Offset;

	private static bool DoesContainerMatchTagQuery_IsValid;

	private static IntPtr DoesContainerMatchTagQuery_FunctionAddress;

	private static int DoesContainerMatchTagQuery_ParamsSize;

	private static bool DoesContainerMatchTagQuery_TagContainer_IsValid;

	private static FFieldAddress DoesContainerMatchTagQuery_TagContainer_PropertyAddress;

	private static int DoesContainerMatchTagQuery_TagContainer_Offset;

	private static bool DoesContainerMatchTagQuery_TagQuery_IsValid;

	private static FFieldAddress DoesContainerMatchTagQuery_TagQuery_PropertyAddress;

	private static int DoesContainerMatchTagQuery_TagQuery_Offset;

	private static bool DoesContainerMatchTagQuery_ReturnValue_IsValid;

	private static FFieldAddress DoesContainerMatchTagQuery_ReturnValue_PropertyAddress;

	private static int DoesContainerMatchTagQuery_ReturnValue_Offset;

	private static bool BreakGameplayTagContainer_IsValid;

	private static IntPtr BreakGameplayTagContainer_FunctionAddress;

	private static int BreakGameplayTagContainer_ParamsSize;

	private static bool BreakGameplayTagContainer_GameplayTagContainer_IsValid;

	private static FFieldAddress BreakGameplayTagContainer_GameplayTagContainer_PropertyAddress;

	private static int BreakGameplayTagContainer_GameplayTagContainer_Offset;

	private static bool BreakGameplayTagContainer_GameplayTags_IsValid;

	private static FFieldAddress BreakGameplayTagContainer_GameplayTags_PropertyAddress;

	private static int BreakGameplayTagContainer_GameplayTags_Offset;

	private static bool AppendGameplayTagContainers_IsValid;

	private static IntPtr AppendGameplayTagContainers_FunctionAddress;

	private static int AppendGameplayTagContainers_ParamsSize;

	private static bool AppendGameplayTagContainers_InOutTagContainer_IsValid;

	private static FFieldAddress AppendGameplayTagContainers_InOutTagContainer_PropertyAddress;

	private static int AppendGameplayTagContainers_InOutTagContainer_Offset;

	private static bool AppendGameplayTagContainers_InTagContainer_IsValid;

	private static FFieldAddress AppendGameplayTagContainers_InTagContainer_PropertyAddress;

	private static int AppendGameplayTagContainers_InTagContainer_Offset;

	private static bool AddGameplayTag_IsValid;

	private static IntPtr AddGameplayTag_FunctionAddress;

	private static int AddGameplayTag_ParamsSize;

	private static bool AddGameplayTag_TagContainer_IsValid;

	private static FFieldAddress AddGameplayTag_TagContainer_PropertyAddress;

	private static int AddGameplayTag_TagContainer_Offset;

	private static bool AddGameplayTag_Tag_IsValid;

	private static FFieldAddress AddGameplayTag_Tag_PropertyAddress;

	private static int AddGameplayTag_Tag_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:RemoveGameplayTag")]
	public unsafe static bool RemoveGameplayTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag)
	{
		if (!RemoveGameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:RemoveGameplayTag");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveGameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveGameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(RemoveGameplayTag_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, RemoveGameplayTag_TagContainer_Offset), 0, RemoveGameplayTag_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InitializeValue_InContainer(RemoveGameplayTag_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, RemoveGameplayTag_Tag_Offset), 0, RemoveGameplayTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveGameplayTag_FunctionAddress, intPtr, RemoveGameplayTag_ParamsSize);
		TagContainer = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, RemoveGameplayTag_TagContainer_Offset), 0, RemoveGameplayTag_TagContainer_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(RemoveGameplayTag_TagContainer_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveGameplayTag_ReturnValue_Offset), 0, RemoveGameplayTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:NotEqual_GameplayTagContainer")]
	public unsafe static bool NotEqual_GameplayTagContainer(FGameplayTagContainer A, FGameplayTagContainer B)
	{
		if (!NotEqual_GameplayTagContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:NotEqual_GameplayTagContainer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotEqual_GameplayTagContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotEqual_GameplayTagContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NotEqual_GameplayTagContainer_A_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, NotEqual_GameplayTagContainer_A_Offset), 0, NotEqual_GameplayTagContainer_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(NotEqual_GameplayTagContainer_B_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, NotEqual_GameplayTagContainer_B_Offset), 0, NotEqual_GameplayTagContainer_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotEqual_GameplayTagContainer_FunctionAddress, intPtr, NotEqual_GameplayTagContainer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NotEqual_GameplayTagContainer_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NotEqual_GameplayTagContainer_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotEqual_GameplayTagContainer_ReturnValue_Offset), 0, NotEqual_GameplayTagContainer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:NotEqual_GameplayTag")]
	public unsafe static bool NotEqual_GameplayTag(FGameplayTag A, FGameplayTag B)
	{
		if (!NotEqual_GameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:NotEqual_GameplayTag");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NotEqual_GameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NotEqual_GameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(NotEqual_GameplayTag_A_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, NotEqual_GameplayTag_A_Offset), 0, NotEqual_GameplayTag_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(NotEqual_GameplayTag_B_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, NotEqual_GameplayTag_B_Offset), 0, NotEqual_GameplayTag_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NotEqual_GameplayTag_FunctionAddress, intPtr, NotEqual_GameplayTag_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NotEqual_GameplayTag_ReturnValue_Offset), 0, NotEqual_GameplayTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:MatchesTag")]
	public unsafe static bool MatchesTag(FGameplayTag TagOne, FGameplayTag TagTwo, bool bExactMatch)
	{
		if (!MatchesTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:MatchesTag");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MatchesTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MatchesTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MatchesTag_TagOne_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, MatchesTag_TagOne_Offset), 0, MatchesTag_TagOne_PropertyAddress.Address, TagOne);
		NativeReflection.InitializeValue_InContainer(MatchesTag_TagTwo_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, MatchesTag_TagTwo_Offset), 0, MatchesTag_TagTwo_PropertyAddress.Address, TagTwo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MatchesTag_bExactMatch_Offset), 0, MatchesTag_bExactMatch_PropertyAddress.Address, bExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MatchesTag_FunctionAddress, intPtr, MatchesTag_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MatchesTag_ReturnValue_Offset), 0, MatchesTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:MatchesAnyTags")]
	public unsafe static bool MatchesAnyTags(FGameplayTag TagOne, FGameplayTagContainer OtherContainer, bool bExactMatch)
	{
		if (!MatchesAnyTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:MatchesAnyTags");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MatchesAnyTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MatchesAnyTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MatchesAnyTags_TagOne_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, MatchesAnyTags_TagOne_Offset), 0, MatchesAnyTags_TagOne_PropertyAddress.Address, TagOne);
		NativeReflection.InitializeValue_InContainer(MatchesAnyTags_OtherContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, MatchesAnyTags_OtherContainer_Offset), 0, MatchesAnyTags_OtherContainer_PropertyAddress.Address, OtherContainer);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MatchesAnyTags_bExactMatch_Offset), 0, MatchesAnyTags_bExactMatch_PropertyAddress.Address, bExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MatchesAnyTags_FunctionAddress, intPtr, MatchesAnyTags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MatchesAnyTags_OtherContainer_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MatchesAnyTags_ReturnValue_Offset), 0, MatchesAnyTags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeLiteralGameplayTagContainer")]
	public unsafe static FGameplayTagContainer MakeLiteralGameplayTagContainer(FGameplayTagContainer Value)
	{
		if (!MakeLiteralGameplayTagContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeLiteralGameplayTagContainer");
			return default(FGameplayTagContainer);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeLiteralGameplayTagContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeLiteralGameplayTagContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeLiteralGameplayTagContainer_Value_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, MakeLiteralGameplayTagContainer_Value_Offset), 0, MakeLiteralGameplayTagContainer_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeLiteralGameplayTagContainer_FunctionAddress, intPtr, MakeLiteralGameplayTagContainer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeLiteralGameplayTagContainer_Value_PropertyAddress.Address, intPtr);
		FGameplayTagContainer result = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, MakeLiteralGameplayTagContainer_ReturnValue_Offset), 0, MakeLiteralGameplayTagContainer_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeLiteralGameplayTagContainer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeLiteralGameplayTag")]
	public unsafe static FGameplayTag MakeLiteralGameplayTag(FGameplayTag Value)
	{
		if (!MakeLiteralGameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeLiteralGameplayTag");
			return default(FGameplayTag);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeLiteralGameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeLiteralGameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeLiteralGameplayTag_Value_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, MakeLiteralGameplayTag_Value_Offset), 0, MakeLiteralGameplayTag_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeLiteralGameplayTag_FunctionAddress, intPtr, MakeLiteralGameplayTag_ParamsSize);
		return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(intPtr, MakeLiteralGameplayTag_ReturnValue_Offset), 0, MakeLiteralGameplayTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagQuery")]
	public unsafe static FGameplayTagQuery MakeGameplayTagQuery(FGameplayTagQuery TagQuery)
	{
		if (!MakeGameplayTagQuery_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagQuery");
			return default(FGameplayTagQuery);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeGameplayTagQuery_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeGameplayTagQuery_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeGameplayTagQuery_TagQuery_PropertyAddress.Address, intPtr);
		FGameplayTagQuery.ToNative(IntPtr.Add(intPtr, MakeGameplayTagQuery_TagQuery_Offset), 0, MakeGameplayTagQuery_TagQuery_PropertyAddress.Address, TagQuery);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeGameplayTagQuery_FunctionAddress, intPtr, MakeGameplayTagQuery_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeGameplayTagQuery_TagQuery_PropertyAddress.Address, intPtr);
		FGameplayTagQuery result = FGameplayTagQuery.FromNative(IntPtr.Add(intPtr, MakeGameplayTagQuery_ReturnValue_Offset), 0, MakeGameplayTagQuery_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeGameplayTagQuery_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagContainerFromTag")]
	public unsafe static FGameplayTagContainer MakeGameplayTagContainerFromTag(FGameplayTag SingleTag)
	{
		if (!MakeGameplayTagContainerFromTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagContainerFromTag");
			return default(FGameplayTagContainer);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeGameplayTagContainerFromTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeGameplayTagContainerFromTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(MakeGameplayTagContainerFromTag_SingleTag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, MakeGameplayTagContainerFromTag_SingleTag_Offset), 0, MakeGameplayTagContainerFromTag_SingleTag_PropertyAddress.Address, SingleTag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeGameplayTagContainerFromTag_FunctionAddress, intPtr, MakeGameplayTagContainerFromTag_ParamsSize);
		FGameplayTagContainer result = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, MakeGameplayTagContainerFromTag_ReturnValue_Offset), 0, MakeGameplayTagContainerFromTag_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeGameplayTagContainerFromTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagContainerFromArray")]
	public unsafe static FGameplayTagContainer MakeGameplayTagContainerFromArray(List<FGameplayTag> GameplayTags)
	{
		if (!MakeGameplayTagContainerFromArray_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagContainerFromArray");
			return default(FGameplayTagContainer);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeGameplayTagContainerFromArray_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeGameplayTagContainerFromArray_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FGameplayTag>(1, MakeGameplayTagContainerFromArray_GameplayTags_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).ToNative(IntPtr.Add(intPtr, MakeGameplayTagContainerFromArray_GameplayTags_Offset), GameplayTags);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeGameplayTagContainerFromArray_FunctionAddress, intPtr, MakeGameplayTagContainerFromArray_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeGameplayTagContainerFromArray_GameplayTags_PropertyAddress.Address, intPtr);
		FGameplayTagContainer result = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, MakeGameplayTagContainerFromArray_ReturnValue_Offset), 0, MakeGameplayTagContainerFromArray_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeGameplayTagContainerFromArray_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:IsTagQueryEmpty")]
	public unsafe static bool IsTagQueryEmpty(FGameplayTagQuery TagQuery)
	{
		if (!IsTagQueryEmpty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:IsTagQueryEmpty");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsTagQueryEmpty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsTagQueryEmpty_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsTagQueryEmpty_TagQuery_PropertyAddress.Address, intPtr);
		FGameplayTagQuery.ToNative(IntPtr.Add(intPtr, IsTagQueryEmpty_TagQuery_Offset), 0, IsTagQueryEmpty_TagQuery_PropertyAddress.Address, TagQuery);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsTagQueryEmpty_FunctionAddress, intPtr, IsTagQueryEmpty_ParamsSize);
		NativeReflection.DestroyValue_InContainer(IsTagQueryEmpty_TagQuery_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsTagQueryEmpty_ReturnValue_Offset), 0, IsTagQueryEmpty_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:IsGameplayTagValid")]
	public unsafe static bool IsGameplayTagValid(FGameplayTag GameplayTag)
	{
		if (!IsGameplayTagValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:IsGameplayTagValid");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsGameplayTagValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsGameplayTagValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(IsGameplayTagValid_GameplayTag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, IsGameplayTagValid_GameplayTag_Offset), 0, IsGameplayTagValid_GameplayTag_PropertyAddress.Address, GameplayTag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsGameplayTagValid_FunctionAddress, intPtr, IsGameplayTagValid_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsGameplayTagValid_ReturnValue_Offset), 0, IsGameplayTagValid_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasTag")]
	public unsafe static bool HasTag(FGameplayTagContainer TagContainer, FGameplayTag Tag, bool bExactMatch)
	{
		if (!HasTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasTag");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasTag_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, HasTag_TagContainer_Offset), 0, HasTag_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InitializeValue_InContainer(HasTag_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, HasTag_Tag_Offset), 0, HasTag_Tag_PropertyAddress.Address, Tag);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HasTag_bExactMatch_Offset), 0, HasTag_bExactMatch_PropertyAddress.Address, bExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasTag_FunctionAddress, intPtr, HasTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasTag_TagContainer_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasTag_ReturnValue_Offset), 0, HasTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasAnyTags")]
	public unsafe static bool HasAnyTags(FGameplayTagContainer TagContainer, FGameplayTagContainer OtherContainer, bool bExactMatch)
	{
		if (!HasAnyTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasAnyTags");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAnyTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAnyTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasAnyTags_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, HasAnyTags_TagContainer_Offset), 0, HasAnyTags_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InitializeValue_InContainer(HasAnyTags_OtherContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, HasAnyTags_OtherContainer_Offset), 0, HasAnyTags_OtherContainer_PropertyAddress.Address, OtherContainer);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HasAnyTags_bExactMatch_Offset), 0, HasAnyTags_bExactMatch_PropertyAddress.Address, bExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasAnyTags_FunctionAddress, intPtr, HasAnyTags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasAnyTags_TagContainer_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HasAnyTags_OtherContainer_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAnyTags_ReturnValue_Offset), 0, HasAnyTags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasAllTags")]
	public unsafe static bool HasAllTags(FGameplayTagContainer TagContainer, FGameplayTagContainer OtherContainer, bool bExactMatch)
	{
		if (!HasAllTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasAllTags");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAllTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAllTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(HasAllTags_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, HasAllTags_TagContainer_Offset), 0, HasAllTags_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InitializeValue_InContainer(HasAllTags_OtherContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, HasAllTags_OtherContainer_Offset), 0, HasAllTags_OtherContainer_PropertyAddress.Address, OtherContainer);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HasAllTags_bExactMatch_Offset), 0, HasAllTags_bExactMatch_PropertyAddress.Address, bExactMatch);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasAllTags_FunctionAddress, intPtr, HasAllTags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HasAllTags_TagContainer_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HasAllTags_OtherContainer_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAllTags_ReturnValue_Offset), 0, HasAllTags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetTagName")]
	public unsafe static FName GetTagName(FGameplayTag GameplayTag)
	{
		if (!GetTagName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetTagName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTagName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTagName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTagName_GameplayTag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, GetTagName_GameplayTag_Offset), 0, GetTagName_GameplayTag_PropertyAddress.Address, GameplayTag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTagName_FunctionAddress, intPtr, GetTagName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetTagName_ReturnValue_Offset), 0, GetTagName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetNumGameplayTagsInContainer")]
	public unsafe static int GetNumGameplayTagsInContainer(FGameplayTagContainer TagContainer)
	{
		if (!GetNumGameplayTagsInContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetNumGameplayTagsInContainer");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumGameplayTagsInContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumGameplayTagsInContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetNumGameplayTagsInContainer_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, GetNumGameplayTagsInContainer_TagContainer_Offset), 0, GetNumGameplayTagsInContainer_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumGameplayTagsInContainer_FunctionAddress, intPtr, GetNumGameplayTagsInContainer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNumGameplayTagsInContainer_TagContainer_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumGameplayTagsInContainer_ReturnValue_Offset), 0, GetNumGameplayTagsInContainer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetDebugStringFromGameplayTagContainer")]
	public unsafe static string GetDebugStringFromGameplayTagContainer(FGameplayTagContainer TagContainer)
	{
		if (!GetDebugStringFromGameplayTagContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetDebugStringFromGameplayTagContainer");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDebugStringFromGameplayTagContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDebugStringFromGameplayTagContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDebugStringFromGameplayTagContainer_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, GetDebugStringFromGameplayTagContainer_TagContainer_Offset), 0, GetDebugStringFromGameplayTagContainer_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDebugStringFromGameplayTagContainer_FunctionAddress, intPtr, GetDebugStringFromGameplayTagContainer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDebugStringFromGameplayTagContainer_TagContainer_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDebugStringFromGameplayTagContainer_ReturnValue_Offset), 0, GetDebugStringFromGameplayTagContainer_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDebugStringFromGameplayTagContainer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetDebugStringFromGameplayTag")]
	public unsafe static string GetDebugStringFromGameplayTag(FGameplayTag GameplayTag)
	{
		if (!GetDebugStringFromGameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetDebugStringFromGameplayTag");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDebugStringFromGameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDebugStringFromGameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetDebugStringFromGameplayTag_GameplayTag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, GetDebugStringFromGameplayTag_GameplayTag_Offset), 0, GetDebugStringFromGameplayTag_GameplayTag_PropertyAddress.Address, GameplayTag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDebugStringFromGameplayTag_FunctionAddress, intPtr, GetDebugStringFromGameplayTag_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDebugStringFromGameplayTag_ReturnValue_Offset), 0, GetDebugStringFromGameplayTag_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDebugStringFromGameplayTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetAllActorsOfClassMatchingTagQuery")]
	public unsafe static void GetAllActorsOfClassMatchingTagQuery(UObject WorldContextObject, TSubclassOf<AActor> ActorClass, FGameplayTagQuery GameplayTagQuery, out List<AActor> OutActors)
	{
		if (!GetAllActorsOfClassMatchingTagQuery_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetAllActorsOfClassMatchingTagQuery");
			OutActors = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllActorsOfClassMatchingTagQuery_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllActorsOfClassMatchingTagQuery_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetAllActorsOfClassMatchingTagQuery_WorldContextObject_Offset), 0, GetAllActorsOfClassMatchingTagQuery_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetAllActorsOfClassMatchingTagQuery_ActorClass_Offset), 0, GetAllActorsOfClassMatchingTagQuery_ActorClass_PropertyAddress.Address, ActorClass);
		NativeReflection.InitializeValue_InContainer(GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_PropertyAddress.Address, intPtr);
		FGameplayTagQuery.ToNative(IntPtr.Add(intPtr, GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_Offset), 0, GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_PropertyAddress.Address, GameplayTagQuery);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllActorsOfClassMatchingTagQuery_FunctionAddress, intPtr, GetAllActorsOfClassMatchingTagQuery_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_PropertyAddress.Address, intPtr);
		OutActors = new TArrayCopyMarshaler<AActor>(1, GetAllActorsOfClassMatchingTagQuery_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllActorsOfClassMatchingTagQuery_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllActorsOfClassMatchingTagQuery_OutActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:EqualEqual_GameplayTagContainer")]
	public unsafe static bool EqualEqual_GameplayTagContainer(FGameplayTagContainer A, FGameplayTagContainer B)
	{
		if (!EqualEqual_GameplayTagContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:EqualEqual_GameplayTagContainer");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_GameplayTagContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_GameplayTagContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EqualEqual_GameplayTagContainer_A_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, EqualEqual_GameplayTagContainer_A_Offset), 0, EqualEqual_GameplayTagContainer_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(EqualEqual_GameplayTagContainer_B_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, EqualEqual_GameplayTagContainer_B_Offset), 0, EqualEqual_GameplayTagContainer_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_GameplayTagContainer_FunctionAddress, intPtr, EqualEqual_GameplayTagContainer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(EqualEqual_GameplayTagContainer_A_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(EqualEqual_GameplayTagContainer_B_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_GameplayTagContainer_ReturnValue_Offset), 0, EqualEqual_GameplayTagContainer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:EqualEqual_GameplayTag")]
	public unsafe static bool EqualEqual_GameplayTag(FGameplayTag A, FGameplayTag B)
	{
		if (!EqualEqual_GameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:EqualEqual_GameplayTag");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EqualEqual_GameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EqualEqual_GameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(EqualEqual_GameplayTag_A_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, EqualEqual_GameplayTag_A_Offset), 0, EqualEqual_GameplayTag_A_PropertyAddress.Address, A);
		NativeReflection.InitializeValue_InContainer(EqualEqual_GameplayTag_B_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, EqualEqual_GameplayTag_B_Offset), 0, EqualEqual_GameplayTag_B_PropertyAddress.Address, B);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, EqualEqual_GameplayTag_FunctionAddress, intPtr, EqualEqual_GameplayTag_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, EqualEqual_GameplayTag_ReturnValue_Offset), 0, EqualEqual_GameplayTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:DoesContainerMatchTagQuery")]
	public unsafe static bool DoesContainerMatchTagQuery(FGameplayTagContainer TagContainer, FGameplayTagQuery TagQuery)
	{
		if (!DoesContainerMatchTagQuery_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:DoesContainerMatchTagQuery");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesContainerMatchTagQuery_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesContainerMatchTagQuery_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(DoesContainerMatchTagQuery_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, DoesContainerMatchTagQuery_TagContainer_Offset), 0, DoesContainerMatchTagQuery_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InitializeValue_InContainer(DoesContainerMatchTagQuery_TagQuery_PropertyAddress.Address, intPtr);
		FGameplayTagQuery.ToNative(IntPtr.Add(intPtr, DoesContainerMatchTagQuery_TagQuery_Offset), 0, DoesContainerMatchTagQuery_TagQuery_PropertyAddress.Address, TagQuery);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoesContainerMatchTagQuery_FunctionAddress, intPtr, DoesContainerMatchTagQuery_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoesContainerMatchTagQuery_TagContainer_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DoesContainerMatchTagQuery_TagQuery_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesContainerMatchTagQuery_ReturnValue_Offset), 0, DoesContainerMatchTagQuery_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:BreakGameplayTagContainer")]
	public unsafe static void BreakGameplayTagContainer(FGameplayTagContainer GameplayTagContainer, out List<FGameplayTag> GameplayTags)
	{
		if (!BreakGameplayTagContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:BreakGameplayTagContainer");
			GameplayTags = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BreakGameplayTagContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BreakGameplayTagContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BreakGameplayTagContainer_GameplayTagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, BreakGameplayTagContainer_GameplayTagContainer_Offset), 0, BreakGameplayTagContainer_GameplayTagContainer_PropertyAddress.Address, GameplayTagContainer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BreakGameplayTagContainer_FunctionAddress, intPtr, BreakGameplayTagContainer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BreakGameplayTagContainer_GameplayTagContainer_PropertyAddress.Address, intPtr);
		GameplayTags = new TArrayCopyMarshaler<FGameplayTag>(1, BreakGameplayTagContainer_GameplayTags_PropertyAddress, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.FromNative, CachedMarshalingDelegates<FGameplayTag, BlittableTypeMarshaler<FGameplayTag>>.ToNative).FromNative(IntPtr.Add(intPtr, BreakGameplayTagContainer_GameplayTags_Offset));
		NativeReflection.DestroyValue_InContainer(BreakGameplayTagContainer_GameplayTags_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:AppendGameplayTagContainers")]
	public unsafe static void AppendGameplayTagContainers(ref FGameplayTagContainer InOutTagContainer, FGameplayTagContainer InTagContainer)
	{
		if (!AppendGameplayTagContainers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:AppendGameplayTagContainers");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AppendGameplayTagContainers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AppendGameplayTagContainers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AppendGameplayTagContainers_InOutTagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, AppendGameplayTagContainers_InOutTagContainer_Offset), 0, AppendGameplayTagContainers_InOutTagContainer_PropertyAddress.Address, InOutTagContainer);
		NativeReflection.InitializeValue_InContainer(AppendGameplayTagContainers_InTagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, AppendGameplayTagContainers_InTagContainer_Offset), 0, AppendGameplayTagContainers_InTagContainer_PropertyAddress.Address, InTagContainer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AppendGameplayTagContainers_FunctionAddress, intPtr, AppendGameplayTagContainers_ParamsSize);
		InOutTagContainer = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, AppendGameplayTagContainers_InOutTagContainer_Offset), 0, AppendGameplayTagContainers_InOutTagContainer_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AppendGameplayTagContainers_InOutTagContainer_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AppendGameplayTagContainers_InTagContainer_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GameplayTags.BlueprintGameplayTagLibrary:AddGameplayTag")]
	public unsafe static void AddGameplayTag(ref FGameplayTagContainer TagContainer, FGameplayTag Tag)
	{
		if (!AddGameplayTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GameplayTags.BlueprintGameplayTagLibrary:AddGameplayTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGameplayTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGameplayTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddGameplayTag_TagContainer_PropertyAddress.Address, intPtr);
		FGameplayTagContainer.ToNative(IntPtr.Add(intPtr, AddGameplayTag_TagContainer_Offset), 0, AddGameplayTag_TagContainer_PropertyAddress.Address, TagContainer);
		NativeReflection.InitializeValue_InContainer(AddGameplayTag_Tag_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(intPtr, AddGameplayTag_Tag_Offset), 0, AddGameplayTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddGameplayTag_FunctionAddress, intPtr, AddGameplayTag_ParamsSize);
		TagContainer = FGameplayTagContainer.FromNative(IntPtr.Add(intPtr, AddGameplayTag_TagContainer_Offset), 0, AddGameplayTag_TagContainer_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddGameplayTag_TagContainer_PropertyAddress.Address, intPtr);
	}

	static UGameplayTagLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameplayTagLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameplayTagLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GameplayTags.BlueprintGameplayTagLibrary");
		RemoveGameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveGameplayTag");
		RemoveGameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveGameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveGameplayTag_TagContainer_PropertyAddress, RemoveGameplayTag_FunctionAddress, "TagContainer");
		RemoveGameplayTag_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(RemoveGameplayTag_FunctionAddress, "TagContainer");
		RemoveGameplayTag_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveGameplayTag_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveGameplayTag_Tag_PropertyAddress, RemoveGameplayTag_FunctionAddress, "Tag");
		RemoveGameplayTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(RemoveGameplayTag_FunctionAddress, "Tag");
		RemoveGameplayTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveGameplayTag_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveGameplayTag_ReturnValue_PropertyAddress, RemoveGameplayTag_FunctionAddress, "ReturnValue");
		RemoveGameplayTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveGameplayTag_FunctionAddress, "ReturnValue");
		RemoveGameplayTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveGameplayTag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveGameplayTag_IsValid = RemoveGameplayTag_FunctionAddress != IntPtr.Zero && RemoveGameplayTag_TagContainer_IsValid && RemoveGameplayTag_Tag_IsValid && RemoveGameplayTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:RemoveGameplayTag", RemoveGameplayTag_IsValid);
		NotEqual_GameplayTagContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotEqual_GameplayTagContainer");
		NotEqual_GameplayTagContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(NotEqual_GameplayTagContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GameplayTagContainer_A_PropertyAddress, NotEqual_GameplayTagContainer_FunctionAddress, "A");
		NotEqual_GameplayTagContainer_A_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GameplayTagContainer_FunctionAddress, "A");
		NotEqual_GameplayTagContainer_A_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GameplayTagContainer_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GameplayTagContainer_B_PropertyAddress, NotEqual_GameplayTagContainer_FunctionAddress, "B");
		NotEqual_GameplayTagContainer_B_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GameplayTagContainer_FunctionAddress, "B");
		NotEqual_GameplayTagContainer_B_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GameplayTagContainer_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GameplayTagContainer_ReturnValue_PropertyAddress, NotEqual_GameplayTagContainer_FunctionAddress, "ReturnValue");
		NotEqual_GameplayTagContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GameplayTagContainer_FunctionAddress, "ReturnValue");
		NotEqual_GameplayTagContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GameplayTagContainer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotEqual_GameplayTagContainer_IsValid = NotEqual_GameplayTagContainer_FunctionAddress != IntPtr.Zero && NotEqual_GameplayTagContainer_A_IsValid && NotEqual_GameplayTagContainer_B_IsValid && NotEqual_GameplayTagContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:NotEqual_GameplayTagContainer", NotEqual_GameplayTagContainer_IsValid);
		NotEqual_GameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NotEqual_GameplayTag");
		NotEqual_GameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(NotEqual_GameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GameplayTag_A_PropertyAddress, NotEqual_GameplayTag_FunctionAddress, "A");
		NotEqual_GameplayTag_A_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GameplayTag_FunctionAddress, "A");
		NotEqual_GameplayTag_A_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GameplayTag_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GameplayTag_B_PropertyAddress, NotEqual_GameplayTag_FunctionAddress, "B");
		NotEqual_GameplayTag_B_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GameplayTag_FunctionAddress, "B");
		NotEqual_GameplayTag_B_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GameplayTag_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NotEqual_GameplayTag_ReturnValue_PropertyAddress, NotEqual_GameplayTag_FunctionAddress, "ReturnValue");
		NotEqual_GameplayTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NotEqual_GameplayTag_FunctionAddress, "ReturnValue");
		NotEqual_GameplayTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NotEqual_GameplayTag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NotEqual_GameplayTag_IsValid = NotEqual_GameplayTag_FunctionAddress != IntPtr.Zero && NotEqual_GameplayTag_A_IsValid && NotEqual_GameplayTag_B_IsValid && NotEqual_GameplayTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:NotEqual_GameplayTag", NotEqual_GameplayTag_IsValid);
		MatchesTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MatchesTag");
		MatchesTag_ParamsSize = NativeReflection.GetFunctionParamsSize(MatchesTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MatchesTag_TagOne_PropertyAddress, MatchesTag_FunctionAddress, "TagOne");
		MatchesTag_TagOne_Offset = NativeReflectionCached.GetPropertyOffset(MatchesTag_FunctionAddress, "TagOne");
		MatchesTag_TagOne_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesTag_FunctionAddress, "TagOne", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesTag_TagTwo_PropertyAddress, MatchesTag_FunctionAddress, "TagTwo");
		MatchesTag_TagTwo_Offset = NativeReflectionCached.GetPropertyOffset(MatchesTag_FunctionAddress, "TagTwo");
		MatchesTag_TagTwo_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesTag_FunctionAddress, "TagTwo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesTag_bExactMatch_PropertyAddress, MatchesTag_FunctionAddress, "bExactMatch");
		MatchesTag_bExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(MatchesTag_FunctionAddress, "bExactMatch");
		MatchesTag_bExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesTag_FunctionAddress, "bExactMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesTag_ReturnValue_PropertyAddress, MatchesTag_FunctionAddress, "ReturnValue");
		MatchesTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MatchesTag_FunctionAddress, "ReturnValue");
		MatchesTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesTag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MatchesTag_IsValid = MatchesTag_FunctionAddress != IntPtr.Zero && MatchesTag_TagOne_IsValid && MatchesTag_TagTwo_IsValid && MatchesTag_bExactMatch_IsValid && MatchesTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:MatchesTag", MatchesTag_IsValid);
		MatchesAnyTags_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MatchesAnyTags");
		MatchesAnyTags_ParamsSize = NativeReflection.GetFunctionParamsSize(MatchesAnyTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MatchesAnyTags_TagOne_PropertyAddress, MatchesAnyTags_FunctionAddress, "TagOne");
		MatchesAnyTags_TagOne_Offset = NativeReflectionCached.GetPropertyOffset(MatchesAnyTags_FunctionAddress, "TagOne");
		MatchesAnyTags_TagOne_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesAnyTags_FunctionAddress, "TagOne", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesAnyTags_OtherContainer_PropertyAddress, MatchesAnyTags_FunctionAddress, "OtherContainer");
		MatchesAnyTags_OtherContainer_Offset = NativeReflectionCached.GetPropertyOffset(MatchesAnyTags_FunctionAddress, "OtherContainer");
		MatchesAnyTags_OtherContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesAnyTags_FunctionAddress, "OtherContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesAnyTags_bExactMatch_PropertyAddress, MatchesAnyTags_FunctionAddress, "bExactMatch");
		MatchesAnyTags_bExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(MatchesAnyTags_FunctionAddress, "bExactMatch");
		MatchesAnyTags_bExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesAnyTags_FunctionAddress, "bExactMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MatchesAnyTags_ReturnValue_PropertyAddress, MatchesAnyTags_FunctionAddress, "ReturnValue");
		MatchesAnyTags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MatchesAnyTags_FunctionAddress, "ReturnValue");
		MatchesAnyTags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MatchesAnyTags_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MatchesAnyTags_IsValid = MatchesAnyTags_FunctionAddress != IntPtr.Zero && MatchesAnyTags_TagOne_IsValid && MatchesAnyTags_OtherContainer_IsValid && MatchesAnyTags_bExactMatch_IsValid && MatchesAnyTags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:MatchesAnyTags", MatchesAnyTags_IsValid);
		MakeLiteralGameplayTagContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeLiteralGameplayTagContainer");
		MakeLiteralGameplayTagContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeLiteralGameplayTagContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeLiteralGameplayTagContainer_Value_PropertyAddress, MakeLiteralGameplayTagContainer_FunctionAddress, "Value");
		MakeLiteralGameplayTagContainer_Value_Offset = NativeReflectionCached.GetPropertyOffset(MakeLiteralGameplayTagContainer_FunctionAddress, "Value");
		MakeLiteralGameplayTagContainer_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeLiteralGameplayTagContainer_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeLiteralGameplayTagContainer_ReturnValue_PropertyAddress, MakeLiteralGameplayTagContainer_FunctionAddress, "ReturnValue");
		MakeLiteralGameplayTagContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeLiteralGameplayTagContainer_FunctionAddress, "ReturnValue");
		MakeLiteralGameplayTagContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeLiteralGameplayTagContainer_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeLiteralGameplayTagContainer_IsValid = MakeLiteralGameplayTagContainer_FunctionAddress != IntPtr.Zero && MakeLiteralGameplayTagContainer_Value_IsValid && MakeLiteralGameplayTagContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeLiteralGameplayTagContainer", MakeLiteralGameplayTagContainer_IsValid);
		MakeLiteralGameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeLiteralGameplayTag");
		MakeLiteralGameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeLiteralGameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeLiteralGameplayTag_Value_PropertyAddress, MakeLiteralGameplayTag_FunctionAddress, "Value");
		MakeLiteralGameplayTag_Value_Offset = NativeReflectionCached.GetPropertyOffset(MakeLiteralGameplayTag_FunctionAddress, "Value");
		MakeLiteralGameplayTag_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeLiteralGameplayTag_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeLiteralGameplayTag_ReturnValue_PropertyAddress, MakeLiteralGameplayTag_FunctionAddress, "ReturnValue");
		MakeLiteralGameplayTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeLiteralGameplayTag_FunctionAddress, "ReturnValue");
		MakeLiteralGameplayTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeLiteralGameplayTag_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeLiteralGameplayTag_IsValid = MakeLiteralGameplayTag_FunctionAddress != IntPtr.Zero && MakeLiteralGameplayTag_Value_IsValid && MakeLiteralGameplayTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeLiteralGameplayTag", MakeLiteralGameplayTag_IsValid);
		MakeGameplayTagQuery_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeGameplayTagQuery");
		MakeGameplayTagQuery_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeGameplayTagQuery_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagQuery_TagQuery_PropertyAddress, MakeGameplayTagQuery_FunctionAddress, "TagQuery");
		MakeGameplayTagQuery_TagQuery_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagQuery_FunctionAddress, "TagQuery");
		MakeGameplayTagQuery_TagQuery_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagQuery_FunctionAddress, "TagQuery", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagQuery_ReturnValue_PropertyAddress, MakeGameplayTagQuery_FunctionAddress, "ReturnValue");
		MakeGameplayTagQuery_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagQuery_FunctionAddress, "ReturnValue");
		MakeGameplayTagQuery_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagQuery_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeGameplayTagQuery_IsValid = MakeGameplayTagQuery_FunctionAddress != IntPtr.Zero && MakeGameplayTagQuery_TagQuery_IsValid && MakeGameplayTagQuery_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagQuery", MakeGameplayTagQuery_IsValid);
		MakeGameplayTagContainerFromTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeGameplayTagContainerFromTag");
		MakeGameplayTagContainerFromTag_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeGameplayTagContainerFromTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagContainerFromTag_SingleTag_PropertyAddress, MakeGameplayTagContainerFromTag_FunctionAddress, "SingleTag");
		MakeGameplayTagContainerFromTag_SingleTag_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagContainerFromTag_FunctionAddress, "SingleTag");
		MakeGameplayTagContainerFromTag_SingleTag_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagContainerFromTag_FunctionAddress, "SingleTag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagContainerFromTag_ReturnValue_PropertyAddress, MakeGameplayTagContainerFromTag_FunctionAddress, "ReturnValue");
		MakeGameplayTagContainerFromTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagContainerFromTag_FunctionAddress, "ReturnValue");
		MakeGameplayTagContainerFromTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagContainerFromTag_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeGameplayTagContainerFromTag_IsValid = MakeGameplayTagContainerFromTag_FunctionAddress != IntPtr.Zero && MakeGameplayTagContainerFromTag_SingleTag_IsValid && MakeGameplayTagContainerFromTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagContainerFromTag", MakeGameplayTagContainerFromTag_IsValid);
		MakeGameplayTagContainerFromArray_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeGameplayTagContainerFromArray");
		MakeGameplayTagContainerFromArray_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeGameplayTagContainerFromArray_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagContainerFromArray_GameplayTags_PropertyAddress, MakeGameplayTagContainerFromArray_FunctionAddress, "GameplayTags");
		MakeGameplayTagContainerFromArray_GameplayTags_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagContainerFromArray_FunctionAddress, "GameplayTags");
		MakeGameplayTagContainerFromArray_GameplayTags_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagContainerFromArray_FunctionAddress, "GameplayTags", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeGameplayTagContainerFromArray_ReturnValue_PropertyAddress, MakeGameplayTagContainerFromArray_FunctionAddress, "ReturnValue");
		MakeGameplayTagContainerFromArray_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeGameplayTagContainerFromArray_FunctionAddress, "ReturnValue");
		MakeGameplayTagContainerFromArray_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeGameplayTagContainerFromArray_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeGameplayTagContainerFromArray_IsValid = MakeGameplayTagContainerFromArray_FunctionAddress != IntPtr.Zero && MakeGameplayTagContainerFromArray_GameplayTags_IsValid && MakeGameplayTagContainerFromArray_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:MakeGameplayTagContainerFromArray", MakeGameplayTagContainerFromArray_IsValid);
		IsTagQueryEmpty_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsTagQueryEmpty");
		IsTagQueryEmpty_ParamsSize = NativeReflection.GetFunctionParamsSize(IsTagQueryEmpty_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsTagQueryEmpty_TagQuery_PropertyAddress, IsTagQueryEmpty_FunctionAddress, "TagQuery");
		IsTagQueryEmpty_TagQuery_Offset = NativeReflectionCached.GetPropertyOffset(IsTagQueryEmpty_FunctionAddress, "TagQuery");
		IsTagQueryEmpty_TagQuery_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTagQueryEmpty_FunctionAddress, "TagQuery", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsTagQueryEmpty_ReturnValue_PropertyAddress, IsTagQueryEmpty_FunctionAddress, "ReturnValue");
		IsTagQueryEmpty_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsTagQueryEmpty_FunctionAddress, "ReturnValue");
		IsTagQueryEmpty_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsTagQueryEmpty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsTagQueryEmpty_IsValid = IsTagQueryEmpty_FunctionAddress != IntPtr.Zero && IsTagQueryEmpty_TagQuery_IsValid && IsTagQueryEmpty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:IsTagQueryEmpty", IsTagQueryEmpty_IsValid);
		IsGameplayTagValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsGameplayTagValid");
		IsGameplayTagValid_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGameplayTagValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsGameplayTagValid_GameplayTag_PropertyAddress, IsGameplayTagValid_FunctionAddress, "GameplayTag");
		IsGameplayTagValid_GameplayTag_Offset = NativeReflectionCached.GetPropertyOffset(IsGameplayTagValid_FunctionAddress, "GameplayTag");
		IsGameplayTagValid_GameplayTag_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGameplayTagValid_FunctionAddress, "GameplayTag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsGameplayTagValid_ReturnValue_PropertyAddress, IsGameplayTagValid_FunctionAddress, "ReturnValue");
		IsGameplayTagValid_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsGameplayTagValid_FunctionAddress, "ReturnValue");
		IsGameplayTagValid_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGameplayTagValid_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGameplayTagValid_IsValid = IsGameplayTagValid_FunctionAddress != IntPtr.Zero && IsGameplayTagValid_GameplayTag_IsValid && IsGameplayTagValid_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:IsGameplayTagValid", IsGameplayTagValid_IsValid);
		HasTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasTag");
		HasTag_ParamsSize = NativeReflection.GetFunctionParamsSize(HasTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasTag_TagContainer_PropertyAddress, HasTag_FunctionAddress, "TagContainer");
		HasTag_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(HasTag_FunctionAddress, "TagContainer");
		HasTag_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTag_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasTag_Tag_PropertyAddress, HasTag_FunctionAddress, "Tag");
		HasTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(HasTag_FunctionAddress, "Tag");
		HasTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTag_FunctionAddress, "Tag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasTag_bExactMatch_PropertyAddress, HasTag_FunctionAddress, "bExactMatch");
		HasTag_bExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(HasTag_FunctionAddress, "bExactMatch");
		HasTag_bExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTag_FunctionAddress, "bExactMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasTag_ReturnValue_PropertyAddress, HasTag_FunctionAddress, "ReturnValue");
		HasTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasTag_FunctionAddress, "ReturnValue");
		HasTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasTag_IsValid = HasTag_FunctionAddress != IntPtr.Zero && HasTag_TagContainer_IsValid && HasTag_Tag_IsValid && HasTag_bExactMatch_IsValid && HasTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasTag", HasTag_IsValid);
		HasAnyTags_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasAnyTags");
		HasAnyTags_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAnyTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAnyTags_TagContainer_PropertyAddress, HasAnyTags_FunctionAddress, "TagContainer");
		HasAnyTags_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyTags_FunctionAddress, "TagContainer");
		HasAnyTags_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyTags_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAnyTags_OtherContainer_PropertyAddress, HasAnyTags_FunctionAddress, "OtherContainer");
		HasAnyTags_OtherContainer_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyTags_FunctionAddress, "OtherContainer");
		HasAnyTags_OtherContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyTags_FunctionAddress, "OtherContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAnyTags_bExactMatch_PropertyAddress, HasAnyTags_FunctionAddress, "bExactMatch");
		HasAnyTags_bExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyTags_FunctionAddress, "bExactMatch");
		HasAnyTags_bExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyTags_FunctionAddress, "bExactMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAnyTags_ReturnValue_PropertyAddress, HasAnyTags_FunctionAddress, "ReturnValue");
		HasAnyTags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyTags_FunctionAddress, "ReturnValue");
		HasAnyTags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyTags_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAnyTags_IsValid = HasAnyTags_FunctionAddress != IntPtr.Zero && HasAnyTags_TagContainer_IsValid && HasAnyTags_OtherContainer_IsValid && HasAnyTags_bExactMatch_IsValid && HasAnyTags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasAnyTags", HasAnyTags_IsValid);
		HasAllTags_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasAllTags");
		HasAllTags_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAllTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAllTags_TagContainer_PropertyAddress, HasAllTags_FunctionAddress, "TagContainer");
		HasAllTags_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(HasAllTags_FunctionAddress, "TagContainer");
		HasAllTags_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAllTags_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAllTags_OtherContainer_PropertyAddress, HasAllTags_FunctionAddress, "OtherContainer");
		HasAllTags_OtherContainer_Offset = NativeReflectionCached.GetPropertyOffset(HasAllTags_FunctionAddress, "OtherContainer");
		HasAllTags_OtherContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAllTags_FunctionAddress, "OtherContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAllTags_bExactMatch_PropertyAddress, HasAllTags_FunctionAddress, "bExactMatch");
		HasAllTags_bExactMatch_Offset = NativeReflectionCached.GetPropertyOffset(HasAllTags_FunctionAddress, "bExactMatch");
		HasAllTags_bExactMatch_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAllTags_FunctionAddress, "bExactMatch", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAllTags_ReturnValue_PropertyAddress, HasAllTags_FunctionAddress, "ReturnValue");
		HasAllTags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAllTags_FunctionAddress, "ReturnValue");
		HasAllTags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAllTags_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAllTags_IsValid = HasAllTags_FunctionAddress != IntPtr.Zero && HasAllTags_TagContainer_IsValid && HasAllTags_OtherContainer_IsValid && HasAllTags_bExactMatch_IsValid && HasAllTags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:HasAllTags", HasAllTags_IsValid);
		GetTagName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTagName");
		GetTagName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTagName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTagName_GameplayTag_PropertyAddress, GetTagName_FunctionAddress, "GameplayTag");
		GetTagName_GameplayTag_Offset = NativeReflectionCached.GetPropertyOffset(GetTagName_FunctionAddress, "GameplayTag");
		GetTagName_GameplayTag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagName_FunctionAddress, "GameplayTag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagName_ReturnValue_PropertyAddress, GetTagName_FunctionAddress, "ReturnValue");
		GetTagName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTagName_FunctionAddress, "ReturnValue");
		GetTagName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetTagName_IsValid = GetTagName_FunctionAddress != IntPtr.Zero && GetTagName_GameplayTag_IsValid && GetTagName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetTagName", GetTagName_IsValid);
		GetNumGameplayTagsInContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumGameplayTagsInContainer");
		GetNumGameplayTagsInContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumGameplayTagsInContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumGameplayTagsInContainer_TagContainer_PropertyAddress, GetNumGameplayTagsInContainer_FunctionAddress, "TagContainer");
		GetNumGameplayTagsInContainer_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(GetNumGameplayTagsInContainer_FunctionAddress, "TagContainer");
		GetNumGameplayTagsInContainer_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumGameplayTagsInContainer_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumGameplayTagsInContainer_ReturnValue_PropertyAddress, GetNumGameplayTagsInContainer_FunctionAddress, "ReturnValue");
		GetNumGameplayTagsInContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumGameplayTagsInContainer_FunctionAddress, "ReturnValue");
		GetNumGameplayTagsInContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumGameplayTagsInContainer_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumGameplayTagsInContainer_IsValid = GetNumGameplayTagsInContainer_FunctionAddress != IntPtr.Zero && GetNumGameplayTagsInContainer_TagContainer_IsValid && GetNumGameplayTagsInContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetNumGameplayTagsInContainer", GetNumGameplayTagsInContainer_IsValid);
		GetDebugStringFromGameplayTagContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDebugStringFromGameplayTagContainer");
		GetDebugStringFromGameplayTagContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugStringFromGameplayTagContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDebugStringFromGameplayTagContainer_TagContainer_PropertyAddress, GetDebugStringFromGameplayTagContainer_FunctionAddress, "TagContainer");
		GetDebugStringFromGameplayTagContainer_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugStringFromGameplayTagContainer_FunctionAddress, "TagContainer");
		GetDebugStringFromGameplayTagContainer_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugStringFromGameplayTagContainer_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDebugStringFromGameplayTagContainer_ReturnValue_PropertyAddress, GetDebugStringFromGameplayTagContainer_FunctionAddress, "ReturnValue");
		GetDebugStringFromGameplayTagContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugStringFromGameplayTagContainer_FunctionAddress, "ReturnValue");
		GetDebugStringFromGameplayTagContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugStringFromGameplayTagContainer_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDebugStringFromGameplayTagContainer_IsValid = GetDebugStringFromGameplayTagContainer_FunctionAddress != IntPtr.Zero && GetDebugStringFromGameplayTagContainer_TagContainer_IsValid && GetDebugStringFromGameplayTagContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetDebugStringFromGameplayTagContainer", GetDebugStringFromGameplayTagContainer_IsValid);
		GetDebugStringFromGameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDebugStringFromGameplayTag");
		GetDebugStringFromGameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugStringFromGameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDebugStringFromGameplayTag_GameplayTag_PropertyAddress, GetDebugStringFromGameplayTag_FunctionAddress, "GameplayTag");
		GetDebugStringFromGameplayTag_GameplayTag_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugStringFromGameplayTag_FunctionAddress, "GameplayTag");
		GetDebugStringFromGameplayTag_GameplayTag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugStringFromGameplayTag_FunctionAddress, "GameplayTag", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDebugStringFromGameplayTag_ReturnValue_PropertyAddress, GetDebugStringFromGameplayTag_FunctionAddress, "ReturnValue");
		GetDebugStringFromGameplayTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugStringFromGameplayTag_FunctionAddress, "ReturnValue");
		GetDebugStringFromGameplayTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugStringFromGameplayTag_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDebugStringFromGameplayTag_IsValid = GetDebugStringFromGameplayTag_FunctionAddress != IntPtr.Zero && GetDebugStringFromGameplayTag_GameplayTag_IsValid && GetDebugStringFromGameplayTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetDebugStringFromGameplayTag", GetDebugStringFromGameplayTag_IsValid);
		GetAllActorsOfClassMatchingTagQuery_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllActorsOfClassMatchingTagQuery");
		GetAllActorsOfClassMatchingTagQuery_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllActorsOfClassMatchingTagQuery_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsOfClassMatchingTagQuery_WorldContextObject_PropertyAddress, GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "WorldContextObject");
		GetAllActorsOfClassMatchingTagQuery_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "WorldContextObject");
		GetAllActorsOfClassMatchingTagQuery_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsOfClassMatchingTagQuery_ActorClass_PropertyAddress, GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "ActorClass");
		GetAllActorsOfClassMatchingTagQuery_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "ActorClass");
		GetAllActorsOfClassMatchingTagQuery_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_PropertyAddress, GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "GameplayTagQuery");
		GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "GameplayTagQuery");
		GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "GameplayTagQuery", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsOfClassMatchingTagQuery_OutActors_PropertyAddress, GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "OutActors");
		GetAllActorsOfClassMatchingTagQuery_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "OutActors");
		GetAllActorsOfClassMatchingTagQuery_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsOfClassMatchingTagQuery_FunctionAddress, "OutActors", Classes.FArrayProperty);
		GetAllActorsOfClassMatchingTagQuery_IsValid = GetAllActorsOfClassMatchingTagQuery_FunctionAddress != IntPtr.Zero && GetAllActorsOfClassMatchingTagQuery_WorldContextObject_IsValid && GetAllActorsOfClassMatchingTagQuery_ActorClass_IsValid && GetAllActorsOfClassMatchingTagQuery_GameplayTagQuery_IsValid && GetAllActorsOfClassMatchingTagQuery_OutActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:GetAllActorsOfClassMatchingTagQuery", GetAllActorsOfClassMatchingTagQuery_IsValid);
		EqualEqual_GameplayTagContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_GameplayTagContainer");
		EqualEqual_GameplayTagContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_GameplayTagContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GameplayTagContainer_A_PropertyAddress, EqualEqual_GameplayTagContainer_FunctionAddress, "A");
		EqualEqual_GameplayTagContainer_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GameplayTagContainer_FunctionAddress, "A");
		EqualEqual_GameplayTagContainer_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GameplayTagContainer_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GameplayTagContainer_B_PropertyAddress, EqualEqual_GameplayTagContainer_FunctionAddress, "B");
		EqualEqual_GameplayTagContainer_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GameplayTagContainer_FunctionAddress, "B");
		EqualEqual_GameplayTagContainer_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GameplayTagContainer_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GameplayTagContainer_ReturnValue_PropertyAddress, EqualEqual_GameplayTagContainer_FunctionAddress, "ReturnValue");
		EqualEqual_GameplayTagContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GameplayTagContainer_FunctionAddress, "ReturnValue");
		EqualEqual_GameplayTagContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GameplayTagContainer_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_GameplayTagContainer_IsValid = EqualEqual_GameplayTagContainer_FunctionAddress != IntPtr.Zero && EqualEqual_GameplayTagContainer_A_IsValid && EqualEqual_GameplayTagContainer_B_IsValid && EqualEqual_GameplayTagContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:EqualEqual_GameplayTagContainer", EqualEqual_GameplayTagContainer_IsValid);
		EqualEqual_GameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "EqualEqual_GameplayTag");
		EqualEqual_GameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(EqualEqual_GameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GameplayTag_A_PropertyAddress, EqualEqual_GameplayTag_FunctionAddress, "A");
		EqualEqual_GameplayTag_A_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GameplayTag_FunctionAddress, "A");
		EqualEqual_GameplayTag_A_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GameplayTag_FunctionAddress, "A", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GameplayTag_B_PropertyAddress, EqualEqual_GameplayTag_FunctionAddress, "B");
		EqualEqual_GameplayTag_B_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GameplayTag_FunctionAddress, "B");
		EqualEqual_GameplayTag_B_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GameplayTag_FunctionAddress, "B", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref EqualEqual_GameplayTag_ReturnValue_PropertyAddress, EqualEqual_GameplayTag_FunctionAddress, "ReturnValue");
		EqualEqual_GameplayTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(EqualEqual_GameplayTag_FunctionAddress, "ReturnValue");
		EqualEqual_GameplayTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(EqualEqual_GameplayTag_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		EqualEqual_GameplayTag_IsValid = EqualEqual_GameplayTag_FunctionAddress != IntPtr.Zero && EqualEqual_GameplayTag_A_IsValid && EqualEqual_GameplayTag_B_IsValid && EqualEqual_GameplayTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:EqualEqual_GameplayTag", EqualEqual_GameplayTag_IsValid);
		DoesContainerMatchTagQuery_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoesContainerMatchTagQuery");
		DoesContainerMatchTagQuery_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesContainerMatchTagQuery_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesContainerMatchTagQuery_TagContainer_PropertyAddress, DoesContainerMatchTagQuery_FunctionAddress, "TagContainer");
		DoesContainerMatchTagQuery_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(DoesContainerMatchTagQuery_FunctionAddress, "TagContainer");
		DoesContainerMatchTagQuery_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesContainerMatchTagQuery_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesContainerMatchTagQuery_TagQuery_PropertyAddress, DoesContainerMatchTagQuery_FunctionAddress, "TagQuery");
		DoesContainerMatchTagQuery_TagQuery_Offset = NativeReflectionCached.GetPropertyOffset(DoesContainerMatchTagQuery_FunctionAddress, "TagQuery");
		DoesContainerMatchTagQuery_TagQuery_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesContainerMatchTagQuery_FunctionAddress, "TagQuery", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesContainerMatchTagQuery_ReturnValue_PropertyAddress, DoesContainerMatchTagQuery_FunctionAddress, "ReturnValue");
		DoesContainerMatchTagQuery_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesContainerMatchTagQuery_FunctionAddress, "ReturnValue");
		DoesContainerMatchTagQuery_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesContainerMatchTagQuery_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesContainerMatchTagQuery_IsValid = DoesContainerMatchTagQuery_FunctionAddress != IntPtr.Zero && DoesContainerMatchTagQuery_TagContainer_IsValid && DoesContainerMatchTagQuery_TagQuery_IsValid && DoesContainerMatchTagQuery_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:DoesContainerMatchTagQuery", DoesContainerMatchTagQuery_IsValid);
		BreakGameplayTagContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BreakGameplayTagContainer");
		BreakGameplayTagContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(BreakGameplayTagContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BreakGameplayTagContainer_GameplayTagContainer_PropertyAddress, BreakGameplayTagContainer_FunctionAddress, "GameplayTagContainer");
		BreakGameplayTagContainer_GameplayTagContainer_Offset = NativeReflectionCached.GetPropertyOffset(BreakGameplayTagContainer_FunctionAddress, "GameplayTagContainer");
		BreakGameplayTagContainer_GameplayTagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakGameplayTagContainer_FunctionAddress, "GameplayTagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BreakGameplayTagContainer_GameplayTags_PropertyAddress, BreakGameplayTagContainer_FunctionAddress, "GameplayTags");
		BreakGameplayTagContainer_GameplayTags_Offset = NativeReflectionCached.GetPropertyOffset(BreakGameplayTagContainer_FunctionAddress, "GameplayTags");
		BreakGameplayTagContainer_GameplayTags_IsValid = NativeReflectionCached.ValidatePropertyClass(BreakGameplayTagContainer_FunctionAddress, "GameplayTags", Classes.FArrayProperty);
		BreakGameplayTagContainer_IsValid = BreakGameplayTagContainer_FunctionAddress != IntPtr.Zero && BreakGameplayTagContainer_GameplayTagContainer_IsValid && BreakGameplayTagContainer_GameplayTags_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:BreakGameplayTagContainer", BreakGameplayTagContainer_IsValid);
		AppendGameplayTagContainers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AppendGameplayTagContainers");
		AppendGameplayTagContainers_ParamsSize = NativeReflection.GetFunctionParamsSize(AppendGameplayTagContainers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AppendGameplayTagContainers_InOutTagContainer_PropertyAddress, AppendGameplayTagContainers_FunctionAddress, "InOutTagContainer");
		AppendGameplayTagContainers_InOutTagContainer_Offset = NativeReflectionCached.GetPropertyOffset(AppendGameplayTagContainers_FunctionAddress, "InOutTagContainer");
		AppendGameplayTagContainers_InOutTagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendGameplayTagContainers_FunctionAddress, "InOutTagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AppendGameplayTagContainers_InTagContainer_PropertyAddress, AppendGameplayTagContainers_FunctionAddress, "InTagContainer");
		AppendGameplayTagContainers_InTagContainer_Offset = NativeReflectionCached.GetPropertyOffset(AppendGameplayTagContainers_FunctionAddress, "InTagContainer");
		AppendGameplayTagContainers_InTagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(AppendGameplayTagContainers_FunctionAddress, "InTagContainer", Classes.FStructProperty);
		AppendGameplayTagContainers_IsValid = AppendGameplayTagContainers_FunctionAddress != IntPtr.Zero && AppendGameplayTagContainers_InOutTagContainer_IsValid && AppendGameplayTagContainers_InTagContainer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:AppendGameplayTagContainers", AppendGameplayTagContainers_IsValid);
		AddGameplayTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddGameplayTag");
		AddGameplayTag_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGameplayTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGameplayTag_TagContainer_PropertyAddress, AddGameplayTag_FunctionAddress, "TagContainer");
		AddGameplayTag_TagContainer_Offset = NativeReflectionCached.GetPropertyOffset(AddGameplayTag_FunctionAddress, "TagContainer");
		AddGameplayTag_TagContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGameplayTag_FunctionAddress, "TagContainer", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddGameplayTag_Tag_PropertyAddress, AddGameplayTag_FunctionAddress, "Tag");
		AddGameplayTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(AddGameplayTag_FunctionAddress, "Tag");
		AddGameplayTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGameplayTag_FunctionAddress, "Tag", Classes.FStructProperty);
		AddGameplayTag_IsValid = AddGameplayTag_FunctionAddress != IntPtr.Zero && AddGameplayTag_TagContainer_IsValid && AddGameplayTag_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GameplayTags.BlueprintGameplayTagLibrary:AddGameplayTag", AddGameplayTag_IsValid);
	}
}
