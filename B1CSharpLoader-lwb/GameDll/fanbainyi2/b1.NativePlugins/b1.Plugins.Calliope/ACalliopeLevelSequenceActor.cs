using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor", "Calliope", UnrealModuleType.GamePlugin)]
public class ACalliopeLevelSequenceActor : ALevelSequenceActor
{
	private static bool SetPaused_IsValid;

	private static IntPtr SetPaused_FunctionAddress;

	private static int SetPaused_ParamsSize;

	private static bool SetPaused_bInPaused_IsValid;

	private static FFieldAddress SetPaused_bInPaused_PropertyAddress;

	private static int SetPaused_bInPaused_Offset;

	private static bool SetAllPerformerTickEnabled_IsValid;

	private static IntPtr SetAllPerformerTickEnabled_FunctionAddress;

	private static int SetAllPerformerTickEnabled_ParamsSize;

	private static bool SetAllPerformerTickEnabled_bEnable_IsValid;

	private static FFieldAddress SetAllPerformerTickEnabled_bEnable_PropertyAddress;

	private static int SetAllPerformerTickEnabled_bEnable_Offset;

	private static bool SetAllPerformerTickEnabled_OutPerformers_IsValid;

	private static FFieldAddress SetAllPerformerTickEnabled_OutPerformers_PropertyAddress;

	private static int SetAllPerformerTickEnabled_OutPerformers_Offset;

	private static bool SetAllMeshPropertyInSequence_IsValid;

	private static IntPtr SetAllMeshPropertyInSequence_FunctionAddress;

	private static int SetAllMeshPropertyInSequence_ParamsSize;

	private static bool SetAllMeshPropertyInSequence_bEnable_IsValid;

	private static FFieldAddress SetAllMeshPropertyInSequence_bEnable_PropertyAddress;

	private static int SetAllMeshPropertyInSequence_bEnable_Offset;

	private static bool ReSetSequence_IsValid;

	private static IntPtr ReSetSequence_FunctionAddress;

	private static int ReSetSequence_ParamsSize;

	private static bool ReSetSequence_InSequence_IsValid;

	private static FFieldAddress ReSetSequence_InSequence_PropertyAddress;

	private static int ReSetSequence_InSequence_Offset;

	private static bool MeshSetClothLocalSpaceSimulation_IsValid;

	private static IntPtr MeshSetClothLocalSpaceSimulation_FunctionAddress;

	private static int MeshSetClothLocalSpaceSimulation_ParamsSize;

	private static bool MeshSetClothLocalSpaceSimulation_Mesh_IsValid;

	private static FFieldAddress MeshSetClothLocalSpaceSimulation_Mesh_PropertyAddress;

	private static int MeshSetClothLocalSpaceSimulation_Mesh_Offset;

	private static bool MeshSetClothLocalSpaceSimulation_bEnable_IsValid;

	private static FFieldAddress MeshSetClothLocalSpaceSimulation_bEnable_PropertyAddress;

	private static int MeshSetClothLocalSpaceSimulation_bEnable_Offset;

	private static bool MeshPrestreamTextures_IsValid;

	private static IntPtr MeshPrestreamTextures_FunctionAddress;

	private static int MeshPrestreamTextures_ParamsSize;

	private static bool MeshPrestreamTextures_Mesh_IsValid;

	private static FFieldAddress MeshPrestreamTextures_Mesh_PropertyAddress;

	private static int MeshPrestreamTextures_Mesh_Offset;

	private static bool MeshPrestreamTextures_DurationTimeSeconds_IsValid;

	private static FFieldAddress MeshPrestreamTextures_DurationTimeSeconds_PropertyAddress;

	private static int MeshPrestreamTextures_DurationTimeSeconds_Offset;

	private static bool MeshPrestreamTextures_bEnable_IsValid;

	private static FFieldAddress MeshPrestreamTextures_bEnable_PropertyAddress;

	private static int MeshPrestreamTextures_bEnable_Offset;

	private static bool LocateBoundActors_IsValid;

	private static IntPtr LocateBoundActors_FunctionAddress;

	private static int LocateBoundActors_ParamsSize;

	private static bool GetBindingTags_IsValid;

	private static IntPtr GetBindingTags_FunctionAddress;

	private static int GetBindingTags_ParamsSize;

	private static bool GetBindingTags_OutBindingTags_IsValid;

	private static FFieldAddress GetBindingTags_OutBindingTags_PropertyAddress;

	private static int GetBindingTags_OutBindingTags_Offset;

	private static bool GetBindingTags_ReturnValue_IsValid;

	private static FFieldAddress GetBindingTags_ReturnValue_PropertyAddress;

	private static int GetBindingTags_ReturnValue_Offset;

	private static bool BindActorsByTag_IsValid;

	private static IntPtr BindActorsByTag_FunctionAddress;

	private static int BindActorsByTag_ParamsSize;

	private static bool BindActorsByTag_TagActors_IsValid;

	private static FFieldAddress BindActorsByTag_TagActors_PropertyAddress;

	private static int BindActorsByTag_TagActors_Offset;

	private static bool BindActorByName_IsValid;

	private static IntPtr BindActorByName_FunctionAddress;

	private static int BindActorByName_ParamsSize;

	private static bool BindActorByName_BindingName_IsValid;

	private static FFieldAddress BindActorByName_BindingName_PropertyAddress;

	private static int BindActorByName_BindingName_Offset;

	private static bool BindActorByName_BindingActor_IsValid;

	private static FFieldAddress BindActorByName_BindingActor_PropertyAddress;

	private static int BindActorByName_BindingActor_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:SetPaused")]
	public unsafe void SetPaused(bool bInPaused)
	{
		CheckDestroyed();
		if (!SetPaused_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:SetPaused");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPaused_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPaused_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPaused_bInPaused_Offset), 0, SetPaused_bInPaused_PropertyAddress.Address, bInPaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPaused_FunctionAddress, intPtr, SetPaused_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:SetAllPerformerTickEnabled")]
	public unsafe void SetAllPerformerTickEnabled(bool bEnable, out HashSet<AActor> OutPerformers)
	{
		CheckDestroyed();
		if (!SetAllPerformerTickEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:SetAllPerformerTickEnabled");
			OutPerformers = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllPerformerTickEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllPerformerTickEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllPerformerTickEnabled_bEnable_Offset), 0, SetAllPerformerTickEnabled_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InitializeValue_InContainer(SetAllPerformerTickEnabled_OutPerformers_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllPerformerTickEnabled_FunctionAddress, intPtr, SetAllPerformerTickEnabled_ParamsSize);
		OutPerformers = new TSetCopyMarshaler<AActor>(1, SetAllPerformerTickEnabled_OutPerformers_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, SetAllPerformerTickEnabled_OutPerformers_Offset));
		NativeReflection.DestroyValue_InContainer(SetAllPerformerTickEnabled_OutPerformers_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:SetAllMeshPropertyInSequence")]
	public unsafe void SetAllMeshPropertyInSequence(bool bEnable)
	{
		CheckDestroyed();
		if (!SetAllMeshPropertyInSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:SetAllMeshPropertyInSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllMeshPropertyInSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllMeshPropertyInSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllMeshPropertyInSequence_bEnable_Offset), 0, SetAllMeshPropertyInSequence_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllMeshPropertyInSequence_FunctionAddress, intPtr, SetAllMeshPropertyInSequence_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:ReSetSequence")]
	public unsafe void ReSetSequence(ULevelSequence InSequence)
	{
		CheckDestroyed();
		if (!ReSetSequence_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:ReSetSequence");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReSetSequence_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReSetSequence_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, ReSetSequence_InSequence_Offset), 0, ReSetSequence_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReSetSequence_FunctionAddress, intPtr, ReSetSequence_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:MeshSetClothLocalSpaceSimulation")]
	public unsafe void MeshSetClothLocalSpaceSimulation(UMeshComponent Mesh, bool bEnable)
	{
		CheckDestroyed();
		if (!MeshSetClothLocalSpaceSimulation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:MeshSetClothLocalSpaceSimulation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MeshSetClothLocalSpaceSimulation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MeshSetClothLocalSpaceSimulation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMeshComponent>.ToNative(IntPtr.Add(intPtr, MeshSetClothLocalSpaceSimulation_Mesh_Offset), 0, MeshSetClothLocalSpaceSimulation_Mesh_PropertyAddress.Address, Mesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MeshSetClothLocalSpaceSimulation_bEnable_Offset), 0, MeshSetClothLocalSpaceSimulation_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, MeshSetClothLocalSpaceSimulation_FunctionAddress, intPtr, MeshSetClothLocalSpaceSimulation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:MeshPrestreamTextures")]
	public unsafe void MeshPrestreamTextures(UMeshComponent Mesh, float DurationTimeSeconds, bool bEnable)
	{
		CheckDestroyed();
		if (!MeshPrestreamTextures_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:MeshPrestreamTextures");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MeshPrestreamTextures_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MeshPrestreamTextures_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMeshComponent>.ToNative(IntPtr.Add(intPtr, MeshPrestreamTextures_Mesh_Offset), 0, MeshPrestreamTextures_Mesh_PropertyAddress.Address, Mesh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, MeshPrestreamTextures_DurationTimeSeconds_Offset), 0, MeshPrestreamTextures_DurationTimeSeconds_PropertyAddress.Address, DurationTimeSeconds);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MeshPrestreamTextures_bEnable_Offset), 0, MeshPrestreamTextures_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeFunctionOptimized(base.Address, MeshPrestreamTextures_FunctionAddress, intPtr, MeshPrestreamTextures_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:LocateBoundActors")]
	public unsafe void LocateBoundActors()
	{
		CheckDestroyed();
		if (!LocateBoundActors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:LocateBoundActors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LocateBoundActors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LocateBoundActors_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: LocateBoundActors_FunctionAddress, argsSize: LocateBoundActors_ParamsSize);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:GetBindingTags")]
	public unsafe int GetBindingTags(out HashSet<FName> OutBindingTags)
	{
		CheckDestroyed();
		if (!GetBindingTags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:GetBindingTags");
			OutBindingTags = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBindingTags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBindingTags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBindingTags_OutBindingTags_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBindingTags_FunctionAddress, intPtr, GetBindingTags_ParamsSize);
		OutBindingTags = new TSetCopyMarshaler<FName>(1, GetBindingTags_OutBindingTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBindingTags_OutBindingTags_Offset));
		NativeReflection.DestroyValue_InContainer(GetBindingTags_OutBindingTags_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetBindingTags_ReturnValue_Offset), 0, GetBindingTags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:BindActorsByTag")]
	public unsafe void BindActorsByTag(Dictionary<FName, AActor> TagActors)
	{
		CheckDestroyed();
		if (!BindActorsByTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:BindActorsByTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindActorsByTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindActorsByTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BindActorsByTag_TagActors_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FName, AActor>(1, BindActorsByTag_TagActors_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, BindActorsByTag_TagActors_Offset), TagActors);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindActorsByTag_FunctionAddress, intPtr, BindActorsByTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BindActorsByTag_TagActors_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/Calliope.CalliopeLevelSequenceActor:BindActorByName")]
	public unsafe void BindActorByName(FName BindingName, AActor BindingActor)
	{
		CheckDestroyed();
		if (!BindActorByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeLevelSequenceActor:BindActorByName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BindActorByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BindActorByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BindActorByName_BindingName_Offset), 0, BindActorByName_BindingName_PropertyAddress.Address, BindingName);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BindActorByName_BindingActor_Offset), 0, BindActorByName_BindingActor_PropertyAddress.Address, BindingActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, BindActorByName_FunctionAddress, intPtr, BindActorByName_ParamsSize);
	}

	static ACalliopeLevelSequenceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACalliopeLevelSequenceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACalliopeLevelSequenceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Calliope.CalliopeLevelSequenceActor");
		SetPaused_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetPaused");
		SetPaused_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPaused_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPaused_bInPaused_PropertyAddress, SetPaused_FunctionAddress, "bInPaused");
		SetPaused_bInPaused_Offset = NativeReflectionCached.GetPropertyOffset(SetPaused_FunctionAddress, "bInPaused");
		SetPaused_bInPaused_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPaused_FunctionAddress, "bInPaused", Classes.FBoolProperty);
		SetPaused_IsValid = SetPaused_FunctionAddress != IntPtr.Zero && SetPaused_bInPaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:SetPaused", SetPaused_IsValid);
		SetAllPerformerTickEnabled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAllPerformerTickEnabled");
		SetAllPerformerTickEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllPerformerTickEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllPerformerTickEnabled_bEnable_PropertyAddress, SetAllPerformerTickEnabled_FunctionAddress, "bEnable");
		SetAllPerformerTickEnabled_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPerformerTickEnabled_FunctionAddress, "bEnable");
		SetAllPerformerTickEnabled_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPerformerTickEnabled_FunctionAddress, "bEnable", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllPerformerTickEnabled_OutPerformers_PropertyAddress, SetAllPerformerTickEnabled_FunctionAddress, "OutPerformers");
		SetAllPerformerTickEnabled_OutPerformers_Offset = NativeReflectionCached.GetPropertyOffset(SetAllPerformerTickEnabled_FunctionAddress, "OutPerformers");
		SetAllPerformerTickEnabled_OutPerformers_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllPerformerTickEnabled_FunctionAddress, "OutPerformers", Classes.FSetProperty);
		SetAllPerformerTickEnabled_IsValid = SetAllPerformerTickEnabled_FunctionAddress != IntPtr.Zero && SetAllPerformerTickEnabled_bEnable_IsValid && SetAllPerformerTickEnabled_OutPerformers_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:SetAllPerformerTickEnabled", SetAllPerformerTickEnabled_IsValid);
		SetAllMeshPropertyInSequence_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetAllMeshPropertyInSequence");
		SetAllMeshPropertyInSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllMeshPropertyInSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllMeshPropertyInSequence_bEnable_PropertyAddress, SetAllMeshPropertyInSequence_FunctionAddress, "bEnable");
		SetAllMeshPropertyInSequence_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetAllMeshPropertyInSequence_FunctionAddress, "bEnable");
		SetAllMeshPropertyInSequence_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllMeshPropertyInSequence_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetAllMeshPropertyInSequence_IsValid = SetAllMeshPropertyInSequence_FunctionAddress != IntPtr.Zero && SetAllMeshPropertyInSequence_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:SetAllMeshPropertyInSequence", SetAllMeshPropertyInSequence_IsValid);
		ReSetSequence_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ReSetSequence");
		ReSetSequence_ParamsSize = NativeReflection.GetFunctionParamsSize(ReSetSequence_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReSetSequence_InSequence_PropertyAddress, ReSetSequence_FunctionAddress, "InSequence");
		ReSetSequence_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(ReSetSequence_FunctionAddress, "InSequence");
		ReSetSequence_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(ReSetSequence_FunctionAddress, "InSequence", Classes.FObjectProperty);
		ReSetSequence_IsValid = ReSetSequence_FunctionAddress != IntPtr.Zero && ReSetSequence_InSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:ReSetSequence", ReSetSequence_IsValid);
		MeshSetClothLocalSpaceSimulation_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MeshSetClothLocalSpaceSimulation");
		MeshSetClothLocalSpaceSimulation_ParamsSize = NativeReflection.GetFunctionParamsSize(MeshSetClothLocalSpaceSimulation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MeshSetClothLocalSpaceSimulation_Mesh_PropertyAddress, MeshSetClothLocalSpaceSimulation_FunctionAddress, "Mesh");
		MeshSetClothLocalSpaceSimulation_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(MeshSetClothLocalSpaceSimulation_FunctionAddress, "Mesh");
		MeshSetClothLocalSpaceSimulation_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(MeshSetClothLocalSpaceSimulation_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshSetClothLocalSpaceSimulation_bEnable_PropertyAddress, MeshSetClothLocalSpaceSimulation_FunctionAddress, "bEnable");
		MeshSetClothLocalSpaceSimulation_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(MeshSetClothLocalSpaceSimulation_FunctionAddress, "bEnable");
		MeshSetClothLocalSpaceSimulation_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(MeshSetClothLocalSpaceSimulation_FunctionAddress, "bEnable", Classes.FBoolProperty);
		MeshSetClothLocalSpaceSimulation_IsValid = MeshSetClothLocalSpaceSimulation_FunctionAddress != IntPtr.Zero && MeshSetClothLocalSpaceSimulation_Mesh_IsValid && MeshSetClothLocalSpaceSimulation_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:MeshSetClothLocalSpaceSimulation", MeshSetClothLocalSpaceSimulation_IsValid);
		MeshPrestreamTextures_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MeshPrestreamTextures");
		MeshPrestreamTextures_ParamsSize = NativeReflection.GetFunctionParamsSize(MeshPrestreamTextures_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MeshPrestreamTextures_Mesh_PropertyAddress, MeshPrestreamTextures_FunctionAddress, "Mesh");
		MeshPrestreamTextures_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(MeshPrestreamTextures_FunctionAddress, "Mesh");
		MeshPrestreamTextures_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(MeshPrestreamTextures_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshPrestreamTextures_DurationTimeSeconds_PropertyAddress, MeshPrestreamTextures_FunctionAddress, "DurationTimeSeconds");
		MeshPrestreamTextures_DurationTimeSeconds_Offset = NativeReflectionCached.GetPropertyOffset(MeshPrestreamTextures_FunctionAddress, "DurationTimeSeconds");
		MeshPrestreamTextures_DurationTimeSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(MeshPrestreamTextures_FunctionAddress, "DurationTimeSeconds", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref MeshPrestreamTextures_bEnable_PropertyAddress, MeshPrestreamTextures_FunctionAddress, "bEnable");
		MeshPrestreamTextures_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(MeshPrestreamTextures_FunctionAddress, "bEnable");
		MeshPrestreamTextures_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(MeshPrestreamTextures_FunctionAddress, "bEnable", Classes.FBoolProperty);
		MeshPrestreamTextures_IsValid = MeshPrestreamTextures_FunctionAddress != IntPtr.Zero && MeshPrestreamTextures_Mesh_IsValid && MeshPrestreamTextures_DurationTimeSeconds_IsValid && MeshPrestreamTextures_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:MeshPrestreamTextures", MeshPrestreamTextures_IsValid);
		LocateBoundActors_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LocateBoundActors");
		LocateBoundActors_ParamsSize = NativeReflection.GetFunctionParamsSize(LocateBoundActors_FunctionAddress);
		LocateBoundActors_IsValid = LocateBoundActors_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:LocateBoundActors", LocateBoundActors_IsValid);
		GetBindingTags_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBindingTags");
		GetBindingTags_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBindingTags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBindingTags_OutBindingTags_PropertyAddress, GetBindingTags_FunctionAddress, "OutBindingTags");
		GetBindingTags_OutBindingTags_Offset = NativeReflectionCached.GetPropertyOffset(GetBindingTags_FunctionAddress, "OutBindingTags");
		GetBindingTags_OutBindingTags_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBindingTags_FunctionAddress, "OutBindingTags", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBindingTags_ReturnValue_PropertyAddress, GetBindingTags_FunctionAddress, "ReturnValue");
		GetBindingTags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBindingTags_FunctionAddress, "ReturnValue");
		GetBindingTags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBindingTags_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetBindingTags_IsValid = GetBindingTags_FunctionAddress != IntPtr.Zero && GetBindingTags_OutBindingTags_IsValid && GetBindingTags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:GetBindingTags", GetBindingTags_IsValid);
		BindActorsByTag_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BindActorsByTag");
		BindActorsByTag_ParamsSize = NativeReflection.GetFunctionParamsSize(BindActorsByTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindActorsByTag_TagActors_PropertyAddress, BindActorsByTag_FunctionAddress, "TagActors");
		BindActorsByTag_TagActors_Offset = NativeReflectionCached.GetPropertyOffset(BindActorsByTag_FunctionAddress, "TagActors");
		BindActorsByTag_TagActors_IsValid = NativeReflectionCached.ValidatePropertyClass(BindActorsByTag_FunctionAddress, "TagActors", Classes.FMapProperty);
		BindActorsByTag_IsValid = BindActorsByTag_FunctionAddress != IntPtr.Zero && BindActorsByTag_TagActors_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:BindActorsByTag", BindActorsByTag_IsValid);
		BindActorByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BindActorByName");
		BindActorByName_ParamsSize = NativeReflection.GetFunctionParamsSize(BindActorByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BindActorByName_BindingName_PropertyAddress, BindActorByName_FunctionAddress, "BindingName");
		BindActorByName_BindingName_Offset = NativeReflectionCached.GetPropertyOffset(BindActorByName_FunctionAddress, "BindingName");
		BindActorByName_BindingName_IsValid = NativeReflectionCached.ValidatePropertyClass(BindActorByName_FunctionAddress, "BindingName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BindActorByName_BindingActor_PropertyAddress, BindActorByName_FunctionAddress, "BindingActor");
		BindActorByName_BindingActor_Offset = NativeReflectionCached.GetPropertyOffset(BindActorByName_FunctionAddress, "BindingActor");
		BindActorByName_BindingActor_IsValid = NativeReflectionCached.ValidatePropertyClass(BindActorByName_FunctionAddress, "BindingActor", Classes.FObjectProperty);
		BindActorByName_IsValid = BindActorByName_FunctionAddress != IntPtr.Zero && BindActorByName_BindingName_IsValid && BindActorByName_BindingActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeLevelSequenceActor:BindActorByName", BindActorByName_IsValid);
	}
}
