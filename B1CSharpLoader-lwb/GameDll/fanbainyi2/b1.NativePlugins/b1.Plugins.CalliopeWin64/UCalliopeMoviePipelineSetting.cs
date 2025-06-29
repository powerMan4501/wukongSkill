using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.MovieRenderPipelineCore;
using UnrealEngine.Runtime;

namespace b1.Plugins.CalliopeWin64;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting", "CalliopeWin64", UnrealModuleType.GamePlugin)]
public class UCalliopeMoviePipelineSetting : UMoviePipelineSetting
{
	private static bool TeardownForPipelineCS_IsValid;

	private IntPtr TeardownForPipelineCS_InstanceFunctionAddress;

	private static IntPtr TeardownForPipelineCS_FunctionAddress;

	private static int TeardownForPipelineCS_ParamsSize;

	private static bool TeardownForPipelineCS_InPipeline_IsValid;

	private static FFieldAddress TeardownForPipelineCS_InPipeline_PropertyAddress;

	private static int TeardownForPipelineCS_InPipeline_Offset;

	private static bool SetupForPipelineCS_IsValid;

	private IntPtr SetupForPipelineCS_InstanceFunctionAddress;

	private static IntPtr SetupForPipelineCS_FunctionAddress;

	private static int SetupForPipelineCS_ParamsSize;

	private static bool SetupForPipelineCS_InPipeline_IsValid;

	private static FFieldAddress SetupForPipelineCS_InPipeline_PropertyAddress;

	private static int SetupForPipelineCS_InPipeline_Offset;

	private static bool SequenceBindActorsByTag_IsValid;

	private static IntPtr SequenceBindActorsByTag_FunctionAddress;

	private static int SequenceBindActorsByTag_ParamsSize;

	private static bool SequenceBindActorsByTag_InPipeline_IsValid;

	private static FFieldAddress SequenceBindActorsByTag_InPipeline_PropertyAddress;

	private static int SequenceBindActorsByTag_InPipeline_Offset;

	private static bool SequenceBindActorsByTag_TagActors_IsValid;

	private static FFieldAddress SequenceBindActorsByTag_TagActors_PropertyAddress;

	private static int SequenceBindActorsByTag_TagActors_Offset;

	private static bool IgnoreTransientFiltersCS_IsValid;

	private IntPtr IgnoreTransientFiltersCS_InstanceFunctionAddress;

	private static IntPtr IgnoreTransientFiltersCS_FunctionAddress;

	private static int IgnoreTransientFiltersCS_ParamsSize;

	private static bool IgnoreTransientFiltersCS_ReturnValue_IsValid;

	private static FFieldAddress IgnoreTransientFiltersCS_ReturnValue_PropertyAddress;

	private static int IgnoreTransientFiltersCS_ReturnValue_Offset;

	private static bool GetSequenceBindingTags_IsValid;

	private static IntPtr GetSequenceBindingTags_FunctionAddress;

	private static int GetSequenceBindingTags_ParamsSize;

	private static bool GetSequenceBindingTags_InPipeline_IsValid;

	private static FFieldAddress GetSequenceBindingTags_InPipeline_PropertyAddress;

	private static int GetSequenceBindingTags_InPipeline_Offset;

	private static bool GetSequenceBindingTags_OutBindingTags_IsValid;

	private static FFieldAddress GetSequenceBindingTags_OutBindingTags_PropertyAddress;

	private static int GetSequenceBindingTags_OutBindingTags_Offset;

	private static bool GetSequenceBindingTags_ReturnValue_IsValid;

	private static FFieldAddress GetSequenceBindingTags_ReturnValue_PropertyAddress;

	private static int GetSequenceBindingTags_ReturnValue_Offset;

	private static bool GetFooterTextCS_IsValid;

	private IntPtr GetFooterTextCS_InstanceFunctionAddress;

	private static IntPtr GetFooterTextCS_FunctionAddress;

	private static int GetFooterTextCS_ParamsSize;

	private static bool GetFooterTextCS_ReturnValue_IsValid;

	private static FFieldAddress GetFooterTextCS_ReturnValue_PropertyAddress;

	private static int GetFooterTextCS_ReturnValue_Offset;

	private static bool GetDisplayTextCS_IsValid;

	private IntPtr GetDisplayTextCS_InstanceFunctionAddress;

	private static IntPtr GetDisplayTextCS_FunctionAddress;

	private static int GetDisplayTextCS_ParamsSize;

	private static bool GetDisplayTextCS_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayTextCS_ReturnValue_PropertyAddress;

	private static int GetDisplayTextCS_ReturnValue_Offset;

	private static bool GetCategoryTextCS_IsValid;

	private IntPtr GetCategoryTextCS_InstanceFunctionAddress;

	private static IntPtr GetCategoryTextCS_FunctionAddress;

	private static int GetCategoryTextCS_ParamsSize;

	private static bool GetCategoryTextCS_ReturnValue_IsValid;

	private static FFieldAddress GetCategoryTextCS_ReturnValue_PropertyAddress;

	private static int GetCategoryTextCS_ReturnValue_Offset;

	private static bool AfterLevelSequenceActorInitializedCS_IsValid;

	private IntPtr AfterLevelSequenceActorInitializedCS_InstanceFunctionAddress;

	private static IntPtr AfterLevelSequenceActorInitializedCS_FunctionAddress;

	private static int AfterLevelSequenceActorInitializedCS_ParamsSize;

	private static bool AfterLevelSequenceActorInitializedCS_InPipeline_IsValid;

	private static FFieldAddress AfterLevelSequenceActorInitializedCS_InPipeline_PropertyAddress;

	private static int AfterLevelSequenceActorInitializedCS_InPipeline_Offset;

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:TeardownForPipelineCS")]
	protected unsafe void TeardownForPipelineCS(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!TeardownForPipelineCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:TeardownForPipelineCS");
			return;
		}
		if (TeardownForPipelineCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			TeardownForPipelineCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "TeardownForPipelineCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(TeardownForPipelineCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TeardownForPipelineCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, TeardownForPipelineCS_InPipeline_Offset), 0, TeardownForPipelineCS_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, TeardownForPipelineCS_InstanceFunctionAddress, intPtr, TeardownForPipelineCS_ParamsSize);
	}

	protected unsafe virtual void TeardownForPipelineCS_Implementation(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!TeardownForPipelineCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:TeardownForPipelineCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TeardownForPipelineCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TeardownForPipelineCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, TeardownForPipelineCS_InPipeline_Offset), 0, TeardownForPipelineCS_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, TeardownForPipelineCS_FunctionAddress, intPtr, TeardownForPipelineCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:SetupForPipelineCS")]
	protected unsafe void SetupForPipelineCS(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!SetupForPipelineCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:SetupForPipelineCS");
			return;
		}
		if (SetupForPipelineCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetupForPipelineCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetupForPipelineCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetupForPipelineCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetupForPipelineCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, SetupForPipelineCS_InPipeline_Offset), 0, SetupForPipelineCS_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetupForPipelineCS_InstanceFunctionAddress, intPtr, SetupForPipelineCS_ParamsSize);
	}

	protected unsafe virtual void SetupForPipelineCS_Implementation(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!SetupForPipelineCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:SetupForPipelineCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetupForPipelineCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetupForPipelineCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, SetupForPipelineCS_InPipeline_Offset), 0, SetupForPipelineCS_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetupForPipelineCS_FunctionAddress, intPtr, SetupForPipelineCS_ParamsSize);
	}

	[UFunction(Flags = 71828481u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:SequenceBindActorsByTag")]
	protected unsafe void SequenceBindActorsByTag(UMoviePipeline InPipeline, Dictionary<FName, AActor> TagActors)
	{
		CheckDestroyed();
		if (!SequenceBindActorsByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:SequenceBindActorsByTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SequenceBindActorsByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SequenceBindActorsByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, SequenceBindActorsByTag_InPipeline_Offset), 0, SequenceBindActorsByTag_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InitializeValue_InContainer(SequenceBindActorsByTag_TagActors_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FName, AActor>(1, SequenceBindActorsByTag_TagActors_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, SequenceBindActorsByTag_TagActors_Offset), TagActors);
		NativeReflection.InvokeFunctionOptimized(base.Address, SequenceBindActorsByTag_FunctionAddress, intPtr, SequenceBindActorsByTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SequenceBindActorsByTag_TagActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1208486912u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:IgnoreTransientFiltersCS")]
	protected unsafe bool IgnoreTransientFiltersCS()
	{
		CheckDestroyed();
		if (!IgnoreTransientFiltersCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:IgnoreTransientFiltersCS");
			return false;
		}
		if (IgnoreTransientFiltersCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			IgnoreTransientFiltersCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IgnoreTransientFiltersCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IgnoreTransientFiltersCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IgnoreTransientFiltersCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IgnoreTransientFiltersCS_InstanceFunctionAddress, intPtr, IgnoreTransientFiltersCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IgnoreTransientFiltersCS_ReturnValue_Offset), 0, IgnoreTransientFiltersCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IgnoreTransientFiltersCS_Implementation()
	{
		CheckDestroyed();
		if (!IgnoreTransientFiltersCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:IgnoreTransientFiltersCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IgnoreTransientFiltersCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IgnoreTransientFiltersCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IgnoreTransientFiltersCS_FunctionAddress, intPtr, IgnoreTransientFiltersCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IgnoreTransientFiltersCS_ReturnValue_Offset), 0, IgnoreTransientFiltersCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1414005761u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetSequenceBindingTags")]
	protected unsafe int GetSequenceBindingTags(UMoviePipeline InPipeline, out HashSet<FName> OutBindingTags)
	{
		CheckDestroyed();
		if (!GetSequenceBindingTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetSequenceBindingTags");
			OutBindingTags = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSequenceBindingTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSequenceBindingTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, GetSequenceBindingTags_InPipeline_Offset), 0, GetSequenceBindingTags_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InitializeValue_InContainer(GetSequenceBindingTags_OutBindingTags_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSequenceBindingTags_FunctionAddress, intPtr, GetSequenceBindingTags_ParamsSize);
		OutBindingTags = new TSetCopyMarshaler<FName>(1, GetSequenceBindingTags_OutBindingTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSequenceBindingTags_OutBindingTags_Offset));
		NativeReflection.DestroyValue_InContainer(GetSequenceBindingTags_OutBindingTags_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSequenceBindingTags_ReturnValue_Offset), 0, GetSequenceBindingTags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1745357824u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetFooterTextCS")]
	protected unsafe string GetFooterTextCS()
	{
		CheckDestroyed();
		if (!GetFooterTextCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetFooterTextCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetFooterTextCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetFooterTextCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetFooterTextCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFooterTextCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFooterTextCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFooterTextCS_InstanceFunctionAddress, intPtr, GetFooterTextCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFooterTextCS_ReturnValue_Offset), 0, GetFooterTextCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFooterTextCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetFooterTextCS_Implementation()
	{
		CheckDestroyed();
		if (!GetFooterTextCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetFooterTextCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFooterTextCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFooterTextCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFooterTextCS_FunctionAddress, intPtr, GetFooterTextCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetFooterTextCS_ReturnValue_Offset), 0, GetFooterTextCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetFooterTextCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1745357824u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetDisplayTextCS")]
	protected unsafe string GetDisplayTextCS()
	{
		CheckDestroyed();
		if (!GetDisplayTextCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetDisplayTextCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetDisplayTextCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDisplayTextCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDisplayTextCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayTextCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayTextCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayTextCS_InstanceFunctionAddress, intPtr, GetDisplayTextCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayTextCS_ReturnValue_Offset), 0, GetDisplayTextCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDisplayTextCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetDisplayTextCS_Implementation()
	{
		CheckDestroyed();
		if (!GetDisplayTextCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetDisplayTextCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayTextCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayTextCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDisplayTextCS_FunctionAddress, intPtr, GetDisplayTextCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayTextCS_ReturnValue_Offset), 0, GetDisplayTextCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDisplayTextCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1745357824u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetCategoryTextCS")]
	protected unsafe string GetCategoryTextCS()
	{
		CheckDestroyed();
		if (!GetCategoryTextCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetCategoryTextCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetCategoryTextCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetCategoryTextCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetCategoryTextCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCategoryTextCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCategoryTextCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCategoryTextCS_InstanceFunctionAddress, intPtr, GetCategoryTextCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCategoryTextCS_ReturnValue_Offset), 0, GetCategoryTextCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCategoryTextCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetCategoryTextCS_Implementation()
	{
		CheckDestroyed();
		if (!GetCategoryTextCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetCategoryTextCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCategoryTextCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCategoryTextCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCategoryTextCS_FunctionAddress, intPtr, GetCategoryTextCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetCategoryTextCS_ReturnValue_Offset), 0, GetCategoryTextCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCategoryTextCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:AfterLevelSequenceActorInitializedCS")]
	protected unsafe void AfterLevelSequenceActorInitializedCS(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!AfterLevelSequenceActorInitializedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:AfterLevelSequenceActorInitializedCS");
			return;
		}
		if (AfterLevelSequenceActorInitializedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			AfterLevelSequenceActorInitializedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "AfterLevelSequenceActorInitializedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(AfterLevelSequenceActorInitializedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AfterLevelSequenceActorInitializedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, AfterLevelSequenceActorInitializedCS_InPipeline_Offset), 0, AfterLevelSequenceActorInitializedCS_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, AfterLevelSequenceActorInitializedCS_InstanceFunctionAddress, intPtr, AfterLevelSequenceActorInitializedCS_ParamsSize);
	}

	protected unsafe virtual void AfterLevelSequenceActorInitializedCS_Implementation(UMoviePipeline InPipeline)
	{
		CheckDestroyed();
		if (!AfterLevelSequenceActorInitializedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:AfterLevelSequenceActorInitializedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AfterLevelSequenceActorInitializedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AfterLevelSequenceActorInitializedCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipeline>.ToNative(IntPtr.Add(intPtr, AfterLevelSequenceActorInitializedCS_InPipeline_Offset), 0, AfterLevelSequenceActorInitializedCS_InPipeline_PropertyAddress.Address, InPipeline);
		NativeReflection.InvokeFunctionOptimized(base.Address, AfterLevelSequenceActorInitializedCS_FunctionAddress, intPtr, AfterLevelSequenceActorInitializedCS_ParamsSize);
	}

	static UCalliopeMoviePipelineSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeMoviePipelineSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeMoviePipelineSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/CalliopeWin64.CalliopeMoviePipelineSetting");
		TeardownForPipelineCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "TeardownForPipelineCS");
		TeardownForPipelineCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TeardownForPipelineCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TeardownForPipelineCS_InPipeline_PropertyAddress, TeardownForPipelineCS_FunctionAddress, "InPipeline");
		TeardownForPipelineCS_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(TeardownForPipelineCS_FunctionAddress, "InPipeline");
		TeardownForPipelineCS_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(TeardownForPipelineCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		TeardownForPipelineCS_IsValid = TeardownForPipelineCS_FunctionAddress != IntPtr.Zero && TeardownForPipelineCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:TeardownForPipelineCS", TeardownForPipelineCS_IsValid);
		SetupForPipelineCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetupForPipelineCS");
		SetupForPipelineCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupForPipelineCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetupForPipelineCS_InPipeline_PropertyAddress, SetupForPipelineCS_FunctionAddress, "InPipeline");
		SetupForPipelineCS_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(SetupForPipelineCS_FunctionAddress, "InPipeline");
		SetupForPipelineCS_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(SetupForPipelineCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		SetupForPipelineCS_IsValid = SetupForPipelineCS_FunctionAddress != IntPtr.Zero && SetupForPipelineCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:SetupForPipelineCS", SetupForPipelineCS_IsValid);
		SequenceBindActorsByTag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SequenceBindActorsByTag");
		SequenceBindActorsByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(SequenceBindActorsByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SequenceBindActorsByTag_InPipeline_PropertyAddress, SequenceBindActorsByTag_FunctionAddress, "InPipeline");
		SequenceBindActorsByTag_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(SequenceBindActorsByTag_FunctionAddress, "InPipeline");
		SequenceBindActorsByTag_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceBindActorsByTag_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SequenceBindActorsByTag_TagActors_PropertyAddress, SequenceBindActorsByTag_FunctionAddress, "TagActors");
		SequenceBindActorsByTag_TagActors_Offset = NativeReflectionCached.GetPropertyOffset(SequenceBindActorsByTag_FunctionAddress, "TagActors");
		SequenceBindActorsByTag_TagActors_IsValid = NativeReflectionCached.ValidatePropertyClass(SequenceBindActorsByTag_FunctionAddress, "TagActors", Classes.FMapProperty);
		SequenceBindActorsByTag_IsValid = SequenceBindActorsByTag_FunctionAddress != IntPtr.Zero && SequenceBindActorsByTag_InPipeline_IsValid && SequenceBindActorsByTag_TagActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:SequenceBindActorsByTag", SequenceBindActorsByTag_IsValid);
		IgnoreTransientFiltersCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IgnoreTransientFiltersCS");
		IgnoreTransientFiltersCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IgnoreTransientFiltersCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IgnoreTransientFiltersCS_ReturnValue_PropertyAddress, IgnoreTransientFiltersCS_FunctionAddress, "ReturnValue");
		IgnoreTransientFiltersCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IgnoreTransientFiltersCS_FunctionAddress, "ReturnValue");
		IgnoreTransientFiltersCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IgnoreTransientFiltersCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IgnoreTransientFiltersCS_IsValid = IgnoreTransientFiltersCS_FunctionAddress != IntPtr.Zero && IgnoreTransientFiltersCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:IgnoreTransientFiltersCS", IgnoreTransientFiltersCS_IsValid);
		GetSequenceBindingTags_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSequenceBindingTags");
		GetSequenceBindingTags_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSequenceBindingTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceBindingTags_InPipeline_PropertyAddress, GetSequenceBindingTags_FunctionAddress, "InPipeline");
		GetSequenceBindingTags_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceBindingTags_FunctionAddress, "InPipeline");
		GetSequenceBindingTags_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceBindingTags_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceBindingTags_OutBindingTags_PropertyAddress, GetSequenceBindingTags_FunctionAddress, "OutBindingTags");
		GetSequenceBindingTags_OutBindingTags_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceBindingTags_FunctionAddress, "OutBindingTags");
		GetSequenceBindingTags_OutBindingTags_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceBindingTags_FunctionAddress, "OutBindingTags", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSequenceBindingTags_ReturnValue_PropertyAddress, GetSequenceBindingTags_FunctionAddress, "ReturnValue");
		GetSequenceBindingTags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSequenceBindingTags_FunctionAddress, "ReturnValue");
		GetSequenceBindingTags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSequenceBindingTags_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSequenceBindingTags_IsValid = GetSequenceBindingTags_FunctionAddress != IntPtr.Zero && GetSequenceBindingTags_InPipeline_IsValid && GetSequenceBindingTags_OutBindingTags_IsValid && GetSequenceBindingTags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetSequenceBindingTags", GetSequenceBindingTags_IsValid);
		GetFooterTextCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFooterTextCS");
		GetFooterTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFooterTextCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFooterTextCS_ReturnValue_PropertyAddress, GetFooterTextCS_FunctionAddress, "ReturnValue");
		GetFooterTextCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFooterTextCS_FunctionAddress, "ReturnValue");
		GetFooterTextCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFooterTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFooterTextCS_IsValid = GetFooterTextCS_FunctionAddress != IntPtr.Zero && GetFooterTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetFooterTextCS", GetFooterTextCS_IsValid);
		GetDisplayTextCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDisplayTextCS");
		GetDisplayTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayTextCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayTextCS_ReturnValue_PropertyAddress, GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayTextCS_FunctionAddress, "ReturnValue");
		GetDisplayTextCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDisplayTextCS_IsValid = GetDisplayTextCS_FunctionAddress != IntPtr.Zero && GetDisplayTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetDisplayTextCS", GetDisplayTextCS_IsValid);
		GetCategoryTextCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCategoryTextCS");
		GetCategoryTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCategoryTextCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCategoryTextCS_ReturnValue_PropertyAddress, GetCategoryTextCS_FunctionAddress, "ReturnValue");
		GetCategoryTextCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCategoryTextCS_FunctionAddress, "ReturnValue");
		GetCategoryTextCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCategoryTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCategoryTextCS_IsValid = GetCategoryTextCS_FunctionAddress != IntPtr.Zero && GetCategoryTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:GetCategoryTextCS", GetCategoryTextCS_IsValid);
		AfterLevelSequenceActorInitializedCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "AfterLevelSequenceActorInitializedCS");
		AfterLevelSequenceActorInitializedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(AfterLevelSequenceActorInitializedCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AfterLevelSequenceActorInitializedCS_InPipeline_PropertyAddress, AfterLevelSequenceActorInitializedCS_FunctionAddress, "InPipeline");
		AfterLevelSequenceActorInitializedCS_InPipeline_Offset = NativeReflectionCached.GetPropertyOffset(AfterLevelSequenceActorInitializedCS_FunctionAddress, "InPipeline");
		AfterLevelSequenceActorInitializedCS_InPipeline_IsValid = NativeReflectionCached.ValidatePropertyClass(AfterLevelSequenceActorInitializedCS_FunctionAddress, "InPipeline", Classes.FObjectProperty);
		AfterLevelSequenceActorInitializedCS_IsValid = AfterLevelSequenceActorInitializedCS_FunctionAddress != IntPtr.Zero && AfterLevelSequenceActorInitializedCS_InPipeline_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/CalliopeWin64.CalliopeMoviePipelineSetting:AfterLevelSequenceActorInitializedCS", AfterLevelSequenceActorInitializedCS_IsValid);
	}
}
