using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass(Flags = (ClassFlags)818938017uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.GSEQTBase", "b1", UnrealModuleType.Game)]
public class UGSEQTBase : UEnvQueryTest
{
	private static bool ShouldUseCustomItemScore_IsValid;

	private IntPtr ShouldUseCustomItemScore_InstanceFunctionAddress;

	private static IntPtr ShouldUseCustomItemScore_FunctionAddress;

	private static int ShouldUseCustomItemScore_ParamsSize;

	private static bool ShouldUseCustomItemScore_ReturnValue_IsValid;

	private static FFieldAddress ShouldUseCustomItemScore_ReturnValue_PropertyAddress;

	private static int ShouldUseCustomItemScore_ReturnValue_Offset;

	private static bool ShouldPrepareContext_IsValid;

	private IntPtr ShouldPrepareContext_InstanceFunctionAddress;

	private static IntPtr ShouldPrepareContext_FunctionAddress;

	private static int ShouldPrepareContext_ParamsSize;

	private static bool ShouldPrepareContext_ReturnValue_IsValid;

	private static FFieldAddress ShouldPrepareContext_ReturnValue_PropertyAddress;

	private static int ShouldPrepareContext_ReturnValue_Offset;

	private static bool SetWorkOnFloatValuesCS_IsValid;

	private static IntPtr SetWorkOnFloatValuesCS_FunctionAddress;

	private static int SetWorkOnFloatValuesCS_ParamsSize;

	private static bool SetWorkOnFloatValuesCS_bWorkOnFloats_IsValid;

	private static FFieldAddress SetWorkOnFloatValuesCS_bWorkOnFloats_PropertyAddress;

	private static int SetWorkOnFloatValuesCS_bWorkOnFloats_Offset;

	private static bool SetItemScoreFloat_IsValid;

	private static IntPtr SetItemScoreFloat_FunctionAddress;

	private static int SetItemScoreFloat_ParamsSize;

	private static bool SetItemScoreFloat_Score_IsValid;

	private static FFieldAddress SetItemScoreFloat_Score_PropertyAddress;

	private static int SetItemScoreFloat_Score_Offset;

	private static bool SetItemScoreBool_IsValid;

	private static IntPtr SetItemScoreBool_FunctionAddress;

	private static int SetItemScoreBool_ParamsSize;

	private static bool SetItemScoreBool_bScore_IsValid;

	private static FFieldAddress SetItemScoreBool_bScore_PropertyAddress;

	private static int SetItemScoreBool_bScore_Offset;

	private static bool ProcessItemCS_IsValid;

	private IntPtr ProcessItemCS_InstanceFunctionAddress;

	private static IntPtr ProcessItemCS_FunctionAddress;

	private static int ProcessItemCS_ParamsSize;

	private static bool ProcessItemCS_World_IsValid;

	private static FFieldAddress ProcessItemCS_World_PropertyAddress;

	private static int ProcessItemCS_World_Offset;

	private static bool ProcessItemCS_ItemLocation_IsValid;

	private static FFieldAddress ProcessItemCS_ItemLocation_PropertyAddress;

	private static int ProcessItemCS_ItemLocation_Offset;

	private static bool ProcessItemCS_ItemActor_IsValid;

	private static FFieldAddress ProcessItemCS_ItemActor_PropertyAddress;

	private static int ProcessItemCS_ItemActor_Offset;

	private static bool ProcessItemCS_Querier_IsValid;

	private static FFieldAddress ProcessItemCS_Querier_PropertyAddress;

	private static int ProcessItemCS_Querier_Offset;

	private static bool ProcessItemCS_ReturnValue_IsValid;

	private static FFieldAddress ProcessItemCS_ReturnValue_PropertyAddress;

	private static int ProcessItemCS_ReturnValue_Offset;

	private static bool ProcessCustomItemScoreCS_IsValid;

	private IntPtr ProcessCustomItemScoreCS_InstanceFunctionAddress;

	private static IntPtr ProcessCustomItemScoreCS_FunctionAddress;

	private static int ProcessCustomItemScoreCS_ParamsSize;

	private static bool ProcessCustomItemScoreCS_Item_IsValid;

	private static FFieldAddress ProcessCustomItemScoreCS_Item_PropertyAddress;

	private static int ProcessCustomItemScoreCS_Item_Offset;

	private static bool PreProcessItems_IsValid;

	private IntPtr PreProcessItems_InstanceFunctionAddress;

	private static IntPtr PreProcessItems_FunctionAddress;

	private static int PreProcessItems_ParamsSize;

	private static bool PreProcessItems_ContextActors_IsValid;

	private static FFieldAddress PreProcessItems_ContextActors_PropertyAddress;

	private static int PreProcessItems_ContextActors_Offset;

	private static bool PreProcessItems_ContextLocations_IsValid;

	private static FFieldAddress PreProcessItems_ContextLocations_PropertyAddress;

	private static int PreProcessItems_ContextLocations_Offset;

	private static bool PostProcessItems_IsValid;

	private IntPtr PostProcessItems_InstanceFunctionAddress;

	private static IntPtr PostProcessItems_FunctionAddress;

	private static int PostProcessItems_ParamsSize;

	private static bool OnPropertyChanged_IsValid;

	private IntPtr OnPropertyChanged_InstanceFunctionAddress;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static int OnPropertyChanged_MemberName_Offset;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static bool GetWorkOnFloatValuesCS_IsValid;

	private static IntPtr GetWorkOnFloatValuesCS_FunctionAddress;

	private static int GetWorkOnFloatValuesCS_ParamsSize;

	private static bool GetWorkOnFloatValuesCS_ReturnValue_IsValid;

	private static FFieldAddress GetWorkOnFloatValuesCS_ReturnValue_PropertyAddress;

	private static int GetWorkOnFloatValuesCS_ReturnValue_Offset;

	private static bool GetDescriptionTitleCS_IsValid;

	private IntPtr GetDescriptionTitleCS_InstanceFunctionAddress;

	private static IntPtr GetDescriptionTitleCS_FunctionAddress;

	private static int GetDescriptionTitleCS_ParamsSize;

	private static bool GetDescriptionTitleCS_ReturnValue_IsValid;

	private static FFieldAddress GetDescriptionTitleCS_ReturnValue_PropertyAddress;

	private static int GetDescriptionTitleCS_ReturnValue_Offset;

	private static bool GetDescriptionDetailsCS_IsValid;

	private IntPtr GetDescriptionDetailsCS_InstanceFunctionAddress;

	private static IntPtr GetDescriptionDetailsCS_FunctionAddress;

	private static int GetDescriptionDetailsCS_ParamsSize;

	private static bool GetDescriptionDetailsCS_ReturnValue_IsValid;

	private static FFieldAddress GetDescriptionDetailsCS_ReturnValue_PropertyAddress;

	private static int GetDescriptionDetailsCS_ReturnValue_Offset;

	private static bool ForceItemStatePassed_IsValid;

	private static IntPtr ForceItemStatePassed_FunctionAddress;

	private static int ForceItemStatePassed_ParamsSize;

	private static bool ForceItemStateFailed_IsValid;

	private static IntPtr ForceItemStateFailed_FunctionAddress;

	private static int ForceItemStateFailed_ParamsSize;

	[UFunction(Flags = 1208093696u)]
	[UMetaPath("/Script/b1.GSEQTBase:ShouldUseCustomItemScore")]
	public unsafe bool ShouldUseCustomItemScore()
	{
		CheckDestroyed();
		if (!ShouldUseCustomItemScore_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ShouldUseCustomItemScore");
			return false;
		}
		if (ShouldUseCustomItemScore_InstanceFunctionAddress == IntPtr.Zero)
		{
			ShouldUseCustomItemScore_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ShouldUseCustomItemScore");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldUseCustomItemScore_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldUseCustomItemScore_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldUseCustomItemScore_InstanceFunctionAddress, intPtr, ShouldUseCustomItemScore_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldUseCustomItemScore_ReturnValue_Offset), 0, ShouldUseCustomItemScore_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ShouldUseCustomItemScore_Implementation()
	{
		CheckDestroyed();
		if (!ShouldUseCustomItemScore_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ShouldUseCustomItemScore");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldUseCustomItemScore_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldUseCustomItemScore_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldUseCustomItemScore_FunctionAddress, intPtr, ShouldUseCustomItemScore_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldUseCustomItemScore_ReturnValue_Offset), 0, ShouldUseCustomItemScore_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSEQTBase:ShouldPrepareContext")]
	public unsafe bool ShouldPrepareContext()
	{
		CheckDestroyed();
		if (!ShouldPrepareContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ShouldPrepareContext");
			return false;
		}
		if (ShouldPrepareContext_InstanceFunctionAddress == IntPtr.Zero)
		{
			ShouldPrepareContext_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ShouldPrepareContext");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldPrepareContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldPrepareContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldPrepareContext_InstanceFunctionAddress, intPtr, ShouldPrepareContext_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldPrepareContext_ReturnValue_Offset), 0, ShouldPrepareContext_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ShouldPrepareContext_Implementation()
	{
		CheckDestroyed();
		if (!ShouldPrepareContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ShouldPrepareContext");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShouldPrepareContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShouldPrepareContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ShouldPrepareContext_FunctionAddress, intPtr, ShouldPrepareContext_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShouldPrepareContext_ReturnValue_Offset), 0, ShouldPrepareContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.GSEQTBase:SetWorkOnFloatValuesCS")]
	public unsafe void SetWorkOnFloatValuesCS(bool bWorkOnFloats)
	{
		CheckDestroyed();
		if (!SetWorkOnFloatValuesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:SetWorkOnFloatValuesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorkOnFloatValuesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorkOnFloatValuesCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetWorkOnFloatValuesCS_bWorkOnFloats_Offset), 0, SetWorkOnFloatValuesCS_bWorkOnFloats_PropertyAddress.Address, bWorkOnFloats);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorkOnFloatValuesCS_FunctionAddress, intPtr, SetWorkOnFloatValuesCS_ParamsSize);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.GSEQTBase:SetItemScoreFloat")]
	public unsafe void SetItemScoreFloat(float Score)
	{
		CheckDestroyed();
		if (!SetItemScoreFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:SetItemScoreFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetItemScoreFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetItemScoreFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetItemScoreFloat_Score_Offset), 0, SetItemScoreFloat_Score_PropertyAddress.Address, Score);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetItemScoreFloat_FunctionAddress, intPtr, SetItemScoreFloat_ParamsSize);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.GSEQTBase:SetItemScoreBool")]
	public unsafe void SetItemScoreBool(bool bScore)
	{
		CheckDestroyed();
		if (!SetItemScoreBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:SetItemScoreBool");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetItemScoreBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetItemScoreBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetItemScoreBool_bScore_Offset), 0, SetItemScoreBool_bScore_PropertyAddress.Address, bScore);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetItemScoreBool_FunctionAddress, intPtr, SetItemScoreBool_ParamsSize);
	}

	[UFunction(Flags = 1220675584u)]
	[UMetaPath("/Script/b1.GSEQTBase:ProcessItemCS")]
	public unsafe bool ProcessItemCS(UWorld World, FVector ItemLocation, AActor ItemActor, AActor Querier)
	{
		CheckDestroyed();
		if (!ProcessItemCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ProcessItemCS");
			return false;
		}
		if (ProcessItemCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProcessItemCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProcessItemCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessItemCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessItemCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ProcessItemCS_World_Offset), 0, ProcessItemCS_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ProcessItemCS_ItemLocation_Offset), 0, ProcessItemCS_ItemLocation_PropertyAddress.Address, ItemLocation);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProcessItemCS_ItemActor_Offset), 0, ProcessItemCS_ItemActor_PropertyAddress.Address, ItemActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProcessItemCS_Querier_Offset), 0, ProcessItemCS_Querier_PropertyAddress.Address, Querier);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessItemCS_InstanceFunctionAddress, intPtr, ProcessItemCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ProcessItemCS_ReturnValue_Offset), 0, ProcessItemCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool ProcessItemCS_Implementation(UWorld World, FVector ItemLocation, AActor ItemActor, AActor Querier)
	{
		CheckDestroyed();
		if (!ProcessItemCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ProcessItemCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessItemCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessItemCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, ProcessItemCS_World_Offset), 0, ProcessItemCS_World_PropertyAddress.Address, World);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ProcessItemCS_ItemLocation_Offset), 0, ProcessItemCS_ItemLocation_PropertyAddress.Address, ItemLocation);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProcessItemCS_ItemActor_Offset), 0, ProcessItemCS_ItemActor_PropertyAddress.Address, ItemActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, ProcessItemCS_Querier_Offset), 0, ProcessItemCS_Querier_PropertyAddress.Address, Querier);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessItemCS_FunctionAddress, intPtr, ProcessItemCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ProcessItemCS_ReturnValue_Offset), 0, ProcessItemCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/b1.GSEQTBase:ProcessCustomItemScoreCS")]
	public unsafe void ProcessCustomItemScoreCS(FGSEnvQueryTestItem Item)
	{
		CheckDestroyed();
		if (!ProcessCustomItemScoreCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ProcessCustomItemScoreCS");
			return;
		}
		if (ProcessCustomItemScoreCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProcessCustomItemScoreCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProcessCustomItemScoreCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessCustomItemScoreCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessCustomItemScoreCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ProcessCustomItemScoreCS_Item_PropertyAddress.Address, intPtr);
		FGSEnvQueryTestItem.ToNative(IntPtr.Add(intPtr, ProcessCustomItemScoreCS_Item_Offset), 0, ProcessCustomItemScoreCS_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessCustomItemScoreCS_InstanceFunctionAddress, intPtr, ProcessCustomItemScoreCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProcessCustomItemScoreCS_Item_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ProcessCustomItemScoreCS_Implementation(FGSEnvQueryTestItem Item)
	{
		CheckDestroyed();
		if (!ProcessCustomItemScoreCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ProcessCustomItemScoreCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessCustomItemScoreCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessCustomItemScoreCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ProcessCustomItemScoreCS_Item_PropertyAddress.Address, intPtr);
		FGSEnvQueryTestItem.ToNative(IntPtr.Add(intPtr, ProcessCustomItemScoreCS_Item_Offset), 0, ProcessCustomItemScoreCS_Item_PropertyAddress.Address, Item);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessCustomItemScoreCS_FunctionAddress, intPtr, ProcessCustomItemScoreCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProcessCustomItemScoreCS_Item_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/b1.GSEQTBase:PreProcessItems")]
	public unsafe void PreProcessItems(List<AActor> ContextActors, List<FVector> ContextLocations)
	{
		CheckDestroyed();
		if (!PreProcessItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:PreProcessItems");
			return;
		}
		if (PreProcessItems_InstanceFunctionAddress == IntPtr.Zero)
		{
			PreProcessItems_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PreProcessItems");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreProcessItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreProcessItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, PreProcessItems_ContextActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, PreProcessItems_ContextActors_Offset), ContextActors);
		new TArrayCopyMarshaler<FVector>(1, PreProcessItems_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, PreProcessItems_ContextLocations_Offset), ContextLocations);
		NativeReflection.InvokeFunctionOptimized(base.Address, PreProcessItems_InstanceFunctionAddress, intPtr, PreProcessItems_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PreProcessItems_ContextActors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PreProcessItems_ContextLocations_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void PreProcessItems_Implementation(List<AActor> ContextActors, List<FVector> ContextLocations)
	{
		CheckDestroyed();
		if (!PreProcessItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:PreProcessItems");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PreProcessItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PreProcessItems_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<AActor>(1, PreProcessItems_ContextActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, PreProcessItems_ContextActors_Offset), ContextActors);
		new TArrayCopyMarshaler<FVector>(1, PreProcessItems_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, PreProcessItems_ContextLocations_Offset), ContextLocations);
		NativeReflection.InvokeFunctionOptimized(base.Address, PreProcessItems_FunctionAddress, intPtr, PreProcessItems_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PreProcessItems_ContextActors_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PreProcessItems_ContextLocations_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSEQTBase:PostProcessItems")]
	public unsafe void PostProcessItems()
	{
		CheckDestroyed();
		if (!PostProcessItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:PostProcessItems");
			return;
		}
		if (PostProcessItems_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostProcessItems_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostProcessItems");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostProcessItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostProcessItems_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostProcessItems_InstanceFunctionAddress, argsSize: PostProcessItems_ParamsSize);
	}

	protected unsafe virtual void PostProcessItems_Implementation()
	{
		CheckDestroyed();
		if (!PostProcessItems_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:PostProcessItems");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostProcessItems_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostProcessItems_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostProcessItems_FunctionAddress, argsSize: PostProcessItems_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.GSEQTBase:OnPropertyChanged")]
	public unsafe void OnPropertyChanged(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:OnPropertyChanged");
			return;
		}
		if (OnPropertyChanged_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPropertyChanged_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPropertyChanged");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_MemberName_Offset), 0, OnPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_PropertyName_Offset), 0, OnPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPropertyChanged_InstanceFunctionAddress, intPtr, OnPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		CheckDestroyed();
		if (!OnPropertyChanged_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:OnPropertyChanged");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPropertyChanged_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPropertyChanged_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_MemberName_Offset), 0, OnPropertyChanged_MemberName_PropertyAddress.Address, MemberName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnPropertyChanged_PropertyName_Offset), 0, OnPropertyChanged_PropertyName_PropertyAddress.Address, PropertyName);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnPropertyChanged_FunctionAddress, intPtr, OnPropertyChanged_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_MemberName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OnPropertyChanged_PropertyName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.GSEQTBase:GetWorkOnFloatValuesCS")]
	public unsafe bool GetWorkOnFloatValuesCS()
	{
		CheckDestroyed();
		if (!GetWorkOnFloatValuesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:GetWorkOnFloatValuesCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorkOnFloatValuesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorkOnFloatValuesCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorkOnFloatValuesCS_FunctionAddress, intPtr, GetWorkOnFloatValuesCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetWorkOnFloatValuesCS_ReturnValue_Offset), 0, GetWorkOnFloatValuesCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSEQTBase:GetDescriptionTitleCS")]
	public unsafe string GetDescriptionTitleCS()
	{
		CheckDestroyed();
		if (!GetDescriptionTitleCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:GetDescriptionTitleCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetDescriptionTitleCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDescriptionTitleCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDescriptionTitleCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDescriptionTitleCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDescriptionTitleCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDescriptionTitleCS_InstanceFunctionAddress, intPtr, GetDescriptionTitleCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDescriptionTitleCS_ReturnValue_Offset), 0, GetDescriptionTitleCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDescriptionTitleCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetDescriptionTitleCS_Implementation()
	{
		CheckDestroyed();
		if (!GetDescriptionTitleCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:GetDescriptionTitleCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDescriptionTitleCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDescriptionTitleCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDescriptionTitleCS_FunctionAddress, intPtr, GetDescriptionTitleCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDescriptionTitleCS_ReturnValue_Offset), 0, GetDescriptionTitleCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDescriptionTitleCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208092672u)]
	[UMetaPath("/Script/b1.GSEQTBase:GetDescriptionDetailsCS")]
	public unsafe string GetDescriptionDetailsCS()
	{
		CheckDestroyed();
		if (!GetDescriptionDetailsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:GetDescriptionDetailsCS");
			return FStringMarshaler.DefaultString;
		}
		if (GetDescriptionDetailsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDescriptionDetailsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetDescriptionDetailsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDescriptionDetailsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDescriptionDetailsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDescriptionDetailsCS_InstanceFunctionAddress, intPtr, GetDescriptionDetailsCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDescriptionDetailsCS_ReturnValue_Offset), 0, GetDescriptionDetailsCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDescriptionDetailsCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	protected unsafe virtual string GetDescriptionDetailsCS_Implementation()
	{
		CheckDestroyed();
		if (!GetDescriptionDetailsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:GetDescriptionDetailsCS");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDescriptionDetailsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDescriptionDetailsCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDescriptionDetailsCS_FunctionAddress, intPtr, GetDescriptionDetailsCS_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDescriptionDetailsCS_ReturnValue_Offset), 0, GetDescriptionDetailsCS_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDescriptionDetailsCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.GSEQTBase:ForceItemStatePassed")]
	public unsafe void ForceItemStatePassed()
	{
		CheckDestroyed();
		if (!ForceItemStatePassed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ForceItemStatePassed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceItemStatePassed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceItemStatePassed_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceItemStatePassed_FunctionAddress, argsSize: ForceItemStatePassed_ParamsSize);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.GSEQTBase:ForceItemStateFailed")]
	public unsafe void ForceItemStateFailed()
	{
		CheckDestroyed();
		if (!ForceItemStateFailed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQTBase:ForceItemStateFailed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceItemStateFailed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceItemStateFailed_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceItemStateFailed_FunctionAddress, argsSize: ForceItemStateFailed_ParamsSize);
	}

	static UGSEQTBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEQTBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEQTBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.GSEQTBase");
		ShouldUseCustomItemScore_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ShouldUseCustomItemScore");
		ShouldUseCustomItemScore_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldUseCustomItemScore_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShouldUseCustomItemScore_ReturnValue_PropertyAddress, ShouldUseCustomItemScore_FunctionAddress, "ReturnValue");
		ShouldUseCustomItemScore_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShouldUseCustomItemScore_FunctionAddress, "ReturnValue");
		ShouldUseCustomItemScore_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldUseCustomItemScore_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldUseCustomItemScore_IsValid = ShouldUseCustomItemScore_FunctionAddress != IntPtr.Zero && ShouldUseCustomItemScore_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:ShouldUseCustomItemScore", ShouldUseCustomItemScore_IsValid);
		ShouldPrepareContext_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ShouldPrepareContext");
		ShouldPrepareContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldPrepareContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShouldPrepareContext_ReturnValue_PropertyAddress, ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShouldPrepareContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldPrepareContext_IsValid = ShouldPrepareContext_FunctionAddress != IntPtr.Zero && ShouldPrepareContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:ShouldPrepareContext", ShouldPrepareContext_IsValid);
		SetWorkOnFloatValuesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetWorkOnFloatValuesCS");
		SetWorkOnFloatValuesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorkOnFloatValuesCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorkOnFloatValuesCS_bWorkOnFloats_PropertyAddress, SetWorkOnFloatValuesCS_FunctionAddress, "bWorkOnFloats");
		SetWorkOnFloatValuesCS_bWorkOnFloats_Offset = NativeReflectionCached.GetPropertyOffset(SetWorkOnFloatValuesCS_FunctionAddress, "bWorkOnFloats");
		SetWorkOnFloatValuesCS_bWorkOnFloats_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorkOnFloatValuesCS_FunctionAddress, "bWorkOnFloats", Classes.FBoolProperty);
		SetWorkOnFloatValuesCS_IsValid = SetWorkOnFloatValuesCS_FunctionAddress != IntPtr.Zero && SetWorkOnFloatValuesCS_bWorkOnFloats_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:SetWorkOnFloatValuesCS", SetWorkOnFloatValuesCS_IsValid);
		SetItemScoreFloat_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetItemScoreFloat");
		SetItemScoreFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(SetItemScoreFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetItemScoreFloat_Score_PropertyAddress, SetItemScoreFloat_FunctionAddress, "Score");
		SetItemScoreFloat_Score_Offset = NativeReflectionCached.GetPropertyOffset(SetItemScoreFloat_FunctionAddress, "Score");
		SetItemScoreFloat_Score_IsValid = NativeReflectionCached.ValidatePropertyClass(SetItemScoreFloat_FunctionAddress, "Score", Classes.FFloatProperty);
		SetItemScoreFloat_IsValid = SetItemScoreFloat_FunctionAddress != IntPtr.Zero && SetItemScoreFloat_Score_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:SetItemScoreFloat", SetItemScoreFloat_IsValid);
		SetItemScoreBool_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetItemScoreBool");
		SetItemScoreBool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetItemScoreBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetItemScoreBool_bScore_PropertyAddress, SetItemScoreBool_FunctionAddress, "bScore");
		SetItemScoreBool_bScore_Offset = NativeReflectionCached.GetPropertyOffset(SetItemScoreBool_FunctionAddress, "bScore");
		SetItemScoreBool_bScore_IsValid = NativeReflectionCached.ValidatePropertyClass(SetItemScoreBool_FunctionAddress, "bScore", Classes.FBoolProperty);
		SetItemScoreBool_IsValid = SetItemScoreBool_FunctionAddress != IntPtr.Zero && SetItemScoreBool_bScore_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:SetItemScoreBool", SetItemScoreBool_IsValid);
		ProcessItemCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProcessItemCS");
		ProcessItemCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessItemCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProcessItemCS_World_PropertyAddress, ProcessItemCS_FunctionAddress, "World");
		ProcessItemCS_World_Offset = NativeReflectionCached.GetPropertyOffset(ProcessItemCS_FunctionAddress, "World");
		ProcessItemCS_World_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessItemCS_ItemLocation_PropertyAddress, ProcessItemCS_FunctionAddress, "ItemLocation");
		ProcessItemCS_ItemLocation_Offset = NativeReflectionCached.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ItemLocation");
		ProcessItemCS_ItemLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ItemLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessItemCS_ItemActor_PropertyAddress, ProcessItemCS_FunctionAddress, "ItemActor");
		ProcessItemCS_ItemActor_Offset = NativeReflectionCached.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ItemActor");
		ProcessItemCS_ItemActor_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ItemActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessItemCS_Querier_PropertyAddress, ProcessItemCS_FunctionAddress, "Querier");
		ProcessItemCS_Querier_Offset = NativeReflectionCached.GetPropertyOffset(ProcessItemCS_FunctionAddress, "Querier");
		ProcessItemCS_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessItemCS_ReturnValue_PropertyAddress, ProcessItemCS_FunctionAddress, "ReturnValue");
		ProcessItemCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ReturnValue");
		ProcessItemCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProcessItemCS_IsValid = ProcessItemCS_FunctionAddress != IntPtr.Zero && ProcessItemCS_World_IsValid && ProcessItemCS_ItemLocation_IsValid && ProcessItemCS_ItemActor_IsValid && ProcessItemCS_Querier_IsValid && ProcessItemCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:ProcessItemCS", ProcessItemCS_IsValid);
		ProcessCustomItemScoreCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProcessCustomItemScoreCS");
		ProcessCustomItemScoreCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessCustomItemScoreCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProcessCustomItemScoreCS_Item_PropertyAddress, ProcessCustomItemScoreCS_FunctionAddress, "Item");
		ProcessCustomItemScoreCS_Item_Offset = NativeReflectionCached.GetPropertyOffset(ProcessCustomItemScoreCS_FunctionAddress, "Item");
		ProcessCustomItemScoreCS_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessCustomItemScoreCS_FunctionAddress, "Item", Classes.FStructProperty);
		ProcessCustomItemScoreCS_IsValid = ProcessCustomItemScoreCS_FunctionAddress != IntPtr.Zero && ProcessCustomItemScoreCS_Item_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:ProcessCustomItemScoreCS", ProcessCustomItemScoreCS_IsValid);
		PreProcessItems_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreProcessItems");
		PreProcessItems_ParamsSize = NativeReflection.GetFunctionParamsSize(PreProcessItems_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PreProcessItems_ContextActors_PropertyAddress, PreProcessItems_FunctionAddress, "ContextActors");
		PreProcessItems_ContextActors_Offset = NativeReflectionCached.GetPropertyOffset(PreProcessItems_FunctionAddress, "ContextActors");
		PreProcessItems_ContextActors_IsValid = NativeReflectionCached.ValidatePropertyClass(PreProcessItems_FunctionAddress, "ContextActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PreProcessItems_ContextLocations_PropertyAddress, PreProcessItems_FunctionAddress, "ContextLocations");
		PreProcessItems_ContextLocations_Offset = NativeReflectionCached.GetPropertyOffset(PreProcessItems_FunctionAddress, "ContextLocations");
		PreProcessItems_ContextLocations_IsValid = NativeReflectionCached.ValidatePropertyClass(PreProcessItems_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		PreProcessItems_IsValid = PreProcessItems_FunctionAddress != IntPtr.Zero && PreProcessItems_ContextActors_IsValid && PreProcessItems_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:PreProcessItems", PreProcessItems_IsValid);
		PostProcessItems_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostProcessItems");
		PostProcessItems_ParamsSize = NativeReflection.GetFunctionParamsSize(PostProcessItems_FunctionAddress);
		PostProcessItems_IsValid = PostProcessItems_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:PostProcessItems", PostProcessItems_IsValid);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflectionCached.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:OnPropertyChanged", OnPropertyChanged_IsValid);
		GetWorkOnFloatValuesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetWorkOnFloatValuesCS");
		GetWorkOnFloatValuesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorkOnFloatValuesCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorkOnFloatValuesCS_ReturnValue_PropertyAddress, GetWorkOnFloatValuesCS_FunctionAddress, "ReturnValue");
		GetWorkOnFloatValuesCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorkOnFloatValuesCS_FunctionAddress, "ReturnValue");
		GetWorkOnFloatValuesCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorkOnFloatValuesCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetWorkOnFloatValuesCS_IsValid = GetWorkOnFloatValuesCS_FunctionAddress != IntPtr.Zero && GetWorkOnFloatValuesCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:GetWorkOnFloatValuesCS", GetWorkOnFloatValuesCS_IsValid);
		GetDescriptionTitleCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDescriptionTitleCS");
		GetDescriptionTitleCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDescriptionTitleCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDescriptionTitleCS_ReturnValue_PropertyAddress, GetDescriptionTitleCS_FunctionAddress, "ReturnValue");
		GetDescriptionTitleCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDescriptionTitleCS_FunctionAddress, "ReturnValue");
		GetDescriptionTitleCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDescriptionTitleCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDescriptionTitleCS_IsValid = GetDescriptionTitleCS_FunctionAddress != IntPtr.Zero && GetDescriptionTitleCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:GetDescriptionTitleCS", GetDescriptionTitleCS_IsValid);
		GetDescriptionDetailsCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDescriptionDetailsCS");
		GetDescriptionDetailsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDescriptionDetailsCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDescriptionDetailsCS_ReturnValue_PropertyAddress, GetDescriptionDetailsCS_FunctionAddress, "ReturnValue");
		GetDescriptionDetailsCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDescriptionDetailsCS_FunctionAddress, "ReturnValue");
		GetDescriptionDetailsCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDescriptionDetailsCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDescriptionDetailsCS_IsValid = GetDescriptionDetailsCS_FunctionAddress != IntPtr.Zero && GetDescriptionDetailsCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:GetDescriptionDetailsCS", GetDescriptionDetailsCS_IsValid);
		ForceItemStatePassed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ForceItemStatePassed");
		ForceItemStatePassed_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceItemStatePassed_FunctionAddress);
		ForceItemStatePassed_IsValid = ForceItemStatePassed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:ForceItemStatePassed", ForceItemStatePassed_IsValid);
		ForceItemStateFailed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ForceItemStateFailed");
		ForceItemStateFailed_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceItemStateFailed_FunctionAddress);
		ForceItemStateFailed_IsValid = ForceItemStateFailed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQTBase:ForceItemStateFailed", ForceItemStateFailed_IsValid);
	}
}
