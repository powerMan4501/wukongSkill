using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/PCG.PCGBlueprintHelpers", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGBlueprintHelpers : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetSeedFromPosition_IsValid;

	private static IntPtr SetSeedFromPosition_FunctionAddress;

	private static int SetSeedFromPosition_ParamsSize;

	private static bool SetSeedFromPosition_InPoint_IsValid;

	private static FFieldAddress SetSeedFromPosition_InPoint_PropertyAddress;

	private static int SetSeedFromPosition_InPoint_Offset;

	private static bool SetLocalCenter_IsValid;

	private static IntPtr SetLocalCenter_FunctionAddress;

	private static int SetLocalCenter_ParamsSize;

	private static bool SetLocalCenter_InPoint_IsValid;

	private static FFieldAddress SetLocalCenter_InPoint_PropertyAddress;

	private static int SetLocalCenter_InPoint_Offset;

	private static bool SetLocalCenter_InLocalCenter_IsValid;

	private static FFieldAddress SetLocalCenter_InLocalCenter_PropertyAddress;

	private static int SetLocalCenter_InLocalCenter_Offset;

	private static bool SetExtents_IsValid;

	private static IntPtr SetExtents_FunctionAddress;

	private static int SetExtents_ParamsSize;

	private static bool SetExtents_InPoint_IsValid;

	private static FFieldAddress SetExtents_InPoint_PropertyAddress;

	private static int SetExtents_InPoint_Offset;

	private static bool SetExtents_InExtents_IsValid;

	private static FFieldAddress SetExtents_InExtents_PropertyAddress;

	private static int SetExtents_InExtents_Offset;

	private static bool GetTransformedBounds_IsValid;

	private static IntPtr GetTransformedBounds_FunctionAddress;

	private static int GetTransformedBounds_ParamsSize;

	private static bool GetTransformedBounds_InPoint_IsValid;

	private static FFieldAddress GetTransformedBounds_InPoint_PropertyAddress;

	private static int GetTransformedBounds_InPoint_Offset;

	private static bool GetTransformedBounds_ReturnValue_IsValid;

	private static FFieldAddress GetTransformedBounds_ReturnValue_PropertyAddress;

	private static int GetTransformedBounds_ReturnValue_Offset;

	private static bool GetTaskId_IsValid;

	private static IntPtr GetTaskId_FunctionAddress;

	private static int GetTaskId_ParamsSize;

	private static bool GetTaskId_Context_IsValid;

	private static FFieldAddress GetTaskId_Context_PropertyAddress;

	private static int GetTaskId_Context_Offset;

	private static bool GetTaskId_ReturnValue_IsValid;

	private static FFieldAddress GetTaskId_ReturnValue_PropertyAddress;

	private static int GetTaskId_ReturnValue_Offset;

	private static bool GetTargetActor_IsValid;

	private static IntPtr GetTargetActor_FunctionAddress;

	private static int GetTargetActor_ParamsSize;

	private static bool GetTargetActor_Context_IsValid;

	private static FFieldAddress GetTargetActor_Context_PropertyAddress;

	private static int GetTargetActor_Context_Offset;

	private static bool GetTargetActor_SpatialData_IsValid;

	private static FFieldAddress GetTargetActor_SpatialData_PropertyAddress;

	private static int GetTargetActor_SpatialData_Offset;

	private static bool GetTargetActor_ReturnValue_IsValid;

	private static FFieldAddress GetTargetActor_ReturnValue_PropertyAddress;

	private static int GetTargetActor_ReturnValue_Offset;

	private static bool GetSettings_IsValid;

	private static IntPtr GetSettings_FunctionAddress;

	private static int GetSettings_ParamsSize;

	private static bool GetSettings_Context_IsValid;

	private static FFieldAddress GetSettings_Context_PropertyAddress;

	private static int GetSettings_Context_Offset;

	private static bool GetSettings_ReturnValue_IsValid;

	private static FFieldAddress GetSettings_ReturnValue_PropertyAddress;

	private static int GetSettings_ReturnValue_Offset;

	private static bool GetRandomStream_IsValid;

	private static IntPtr GetRandomStream_FunctionAddress;

	private static int GetRandomStream_ParamsSize;

	private static bool GetRandomStream_InPoint_IsValid;

	private static FFieldAddress GetRandomStream_InPoint_PropertyAddress;

	private static int GetRandomStream_InPoint_Offset;

	private static bool GetRandomStream_OptionalSettings_IsValid;

	private static FFieldAddress GetRandomStream_OptionalSettings_PropertyAddress;

	private static int GetRandomStream_OptionalSettings_Offset;

	private static bool GetRandomStream_OptionalComponent_IsValid;

	private static FFieldAddress GetRandomStream_OptionalComponent_PropertyAddress;

	private static int GetRandomStream_OptionalComponent_Offset;

	private static bool GetRandomStream_ReturnValue_IsValid;

	private static FFieldAddress GetRandomStream_ReturnValue_PropertyAddress;

	private static int GetRandomStream_ReturnValue_Offset;

	private static bool GetOriginalComponent_IsValid;

	private static IntPtr GetOriginalComponent_FunctionAddress;

	private static int GetOriginalComponent_ParamsSize;

	private static bool GetOriginalComponent_Context_IsValid;

	private static FFieldAddress GetOriginalComponent_Context_PropertyAddress;

	private static int GetOriginalComponent_Context_Offset;

	private static bool GetOriginalComponent_ReturnValue_IsValid;

	private static FFieldAddress GetOriginalComponent_ReturnValue_PropertyAddress;

	private static int GetOriginalComponent_ReturnValue_Offset;

	private static bool GetLocalCenter_IsValid;

	private static IntPtr GetLocalCenter_FunctionAddress;

	private static int GetLocalCenter_ParamsSize;

	private static bool GetLocalCenter_InPoint_IsValid;

	private static FFieldAddress GetLocalCenter_InPoint_PropertyAddress;

	private static int GetLocalCenter_InPoint_Offset;

	private static bool GetLocalCenter_ReturnValue_IsValid;

	private static FFieldAddress GetLocalCenter_ReturnValue_PropertyAddress;

	private static int GetLocalCenter_ReturnValue_Offset;

	private static bool GetInputData_IsValid;

	private static IntPtr GetInputData_FunctionAddress;

	private static int GetInputData_ParamsSize;

	private static bool GetInputData_Context_IsValid;

	private static FFieldAddress GetInputData_Context_PropertyAddress;

	private static int GetInputData_Context_Offset;

	private static bool GetInputData_ReturnValue_IsValid;

	private static FFieldAddress GetInputData_ReturnValue_PropertyAddress;

	private static int GetInputData_ReturnValue_Offset;

	private static bool GetExtents_IsValid;

	private static IntPtr GetExtents_FunctionAddress;

	private static int GetExtents_ParamsSize;

	private static bool GetExtents_InPoint_IsValid;

	private static FFieldAddress GetExtents_InPoint_PropertyAddress;

	private static int GetExtents_InPoint_Offset;

	private static bool GetExtents_ReturnValue_IsValid;

	private static FFieldAddress GetExtents_ReturnValue_PropertyAddress;

	private static int GetExtents_ReturnValue_Offset;

	private static bool GetComponent_IsValid;

	private static IntPtr GetComponent_FunctionAddress;

	private static int GetComponent_ParamsSize;

	private static bool GetComponent_Context_IsValid;

	private static FFieldAddress GetComponent_Context_PropertyAddress;

	private static int GetComponent_Context_Offset;

	private static bool GetComponent_ReturnValue_IsValid;

	private static FFieldAddress GetComponent_ReturnValue_PropertyAddress;

	private static int GetComponent_ReturnValue_Offset;

	private static bool GetActorLocalBoundsPCG_IsValid;

	private static IntPtr GetActorLocalBoundsPCG_FunctionAddress;

	private static int GetActorLocalBoundsPCG_ParamsSize;

	private static bool GetActorLocalBoundsPCG_InActor_IsValid;

	private static FFieldAddress GetActorLocalBoundsPCG_InActor_PropertyAddress;

	private static int GetActorLocalBoundsPCG_InActor_Offset;

	private static bool GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_IsValid;

	private static FFieldAddress GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_PropertyAddress;

	private static int GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_Offset;

	private static bool GetActorLocalBoundsPCG_ReturnValue_IsValid;

	private static FFieldAddress GetActorLocalBoundsPCG_ReturnValue_PropertyAddress;

	private static int GetActorLocalBoundsPCG_ReturnValue_Offset;

	private static bool GetActorData_IsValid;

	private static IntPtr GetActorData_FunctionAddress;

	private static int GetActorData_ParamsSize;

	private static bool GetActorData_Context_IsValid;

	private static FFieldAddress GetActorData_Context_PropertyAddress;

	private static int GetActorData_Context_Offset;

	private static bool GetActorData_ReturnValue_IsValid;

	private static FFieldAddress GetActorData_ReturnValue_PropertyAddress;

	private static int GetActorData_ReturnValue_Offset;

	private static bool GetActorBoundsPCG_IsValid;

	private static IntPtr GetActorBoundsPCG_FunctionAddress;

	private static int GetActorBoundsPCG_ParamsSize;

	private static bool GetActorBoundsPCG_InActor_IsValid;

	private static FFieldAddress GetActorBoundsPCG_InActor_PropertyAddress;

	private static int GetActorBoundsPCG_InActor_Offset;

	private static bool GetActorBoundsPCG_bIgnorePCGCreatedComponents_IsValid;

	private static FFieldAddress GetActorBoundsPCG_bIgnorePCGCreatedComponents_PropertyAddress;

	private static int GetActorBoundsPCG_bIgnorePCGCreatedComponents_Offset;

	private static bool GetActorBoundsPCG_ReturnValue_IsValid;

	private static FFieldAddress GetActorBoundsPCG_ReturnValue_PropertyAddress;

	private static int GetActorBoundsPCG_ReturnValue_Offset;

	private static bool CreatePCGDataFromActor_IsValid;

	private static IntPtr CreatePCGDataFromActor_FunctionAddress;

	private static int CreatePCGDataFromActor_ParamsSize;

	private static bool CreatePCGDataFromActor_InActor_IsValid;

	private static FFieldAddress CreatePCGDataFromActor_InActor_PropertyAddress;

	private static int CreatePCGDataFromActor_InActor_Offset;

	private static bool CreatePCGDataFromActor_bParseActor_IsValid;

	private static FFieldAddress CreatePCGDataFromActor_bParseActor_PropertyAddress;

	private static int CreatePCGDataFromActor_bParseActor_Offset;

	private static bool CreatePCGDataFromActor_ReturnValue_IsValid;

	private static FFieldAddress CreatePCGDataFromActor_ReturnValue_PropertyAddress;

	private static int CreatePCGDataFromActor_ReturnValue_Offset;

	private static bool ComputeSeedFromPosition_IsValid;

	private static IntPtr ComputeSeedFromPosition_FunctionAddress;

	private static int ComputeSeedFromPosition_ParamsSize;

	private static bool ComputeSeedFromPosition_InPosition_IsValid;

	private static FFieldAddress ComputeSeedFromPosition_InPosition_PropertyAddress;

	private static int ComputeSeedFromPosition_InPosition_Offset;

	private static bool ComputeSeedFromPosition_ReturnValue_IsValid;

	private static FFieldAddress ComputeSeedFromPosition_ReturnValue_PropertyAddress;

	private static int ComputeSeedFromPosition_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:SetSeedFromPosition")]
	public unsafe static void SetSeedFromPosition(ref FPCGPoint InPoint)
	{
		if (!SetSeedFromPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:SetSeedFromPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSeedFromPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSeedFromPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetSeedFromPosition_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetSeedFromPosition_InPoint_Offset), 0, SetSeedFromPosition_InPoint_PropertyAddress.Address, InPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSeedFromPosition_FunctionAddress, intPtr, SetSeedFromPosition_ParamsSize);
		InPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetSeedFromPosition_InPoint_Offset), 0, SetSeedFromPosition_InPoint_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:SetLocalCenter")]
	public unsafe static void SetLocalCenter(ref FPCGPoint InPoint, FVector InLocalCenter)
	{
		if (!SetLocalCenter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:SetLocalCenter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalCenter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalCenter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetLocalCenter_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetLocalCenter_InPoint_Offset), 0, SetLocalCenter_InPoint_PropertyAddress.Address, InPoint);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLocalCenter_InLocalCenter_Offset), 0, SetLocalCenter_InLocalCenter_PropertyAddress.Address, InLocalCenter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLocalCenter_FunctionAddress, intPtr, SetLocalCenter_ParamsSize);
		InPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetLocalCenter_InPoint_Offset), 0, SetLocalCenter_InPoint_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:SetExtents")]
	public unsafe static void SetExtents(ref FPCGPoint InPoint, FVector InExtents)
	{
		if (!SetExtents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:SetExtents");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetExtents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetExtents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetExtents_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, SetExtents_InPoint_Offset), 0, SetExtents_InPoint_PropertyAddress.Address, InPoint);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetExtents_InExtents_Offset), 0, SetExtents_InExtents_PropertyAddress.Address, InExtents);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetExtents_FunctionAddress, intPtr, SetExtents_ParamsSize);
		InPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, SetExtents_InPoint_Offset), 0, SetExtents_InPoint_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetTransformedBounds")]
	public unsafe static FBox GetTransformedBounds(FPCGPoint InPoint)
	{
		if (!GetTransformedBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetTransformedBounds");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransformedBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransformedBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTransformedBounds_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetTransformedBounds_InPoint_Offset), 0, GetTransformedBounds_InPoint_PropertyAddress.Address, InPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTransformedBounds_FunctionAddress, intPtr, GetTransformedBounds_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetTransformedBounds_ReturnValue_Offset), 0, GetTransformedBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetTaskId")]
	public unsafe static long GetTaskId(ref FPCGContext Context)
	{
		if (!GetTaskId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetTaskId");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTaskId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTaskId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTaskId_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetTaskId_Context_Offset), 0, GetTaskId_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTaskId_FunctionAddress, intPtr, GetTaskId_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, GetTaskId_Context_Offset), 0, GetTaskId_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTaskId_Context_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetTaskId_ReturnValue_Offset), 0, GetTaskId_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetTargetActor")]
	public unsafe static AActor GetTargetActor(ref FPCGContext Context, UPCGSpatialData SpatialData)
	{
		if (!GetTargetActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetTargetActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTargetActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTargetActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetTargetActor_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetTargetActor_Context_Offset), 0, GetTargetActor_Context_PropertyAddress.Address, Context);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, GetTargetActor_SpatialData_Offset), 0, GetTargetActor_SpatialData_PropertyAddress.Address, SpatialData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTargetActor_FunctionAddress, intPtr, GetTargetActor_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, GetTargetActor_Context_Offset), 0, GetTargetActor_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetTargetActor_Context_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, GetTargetActor_ReturnValue_Offset), 0, GetTargetActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetSettings")]
	public unsafe static UPCGSettings GetSettings(ref FPCGContext Context)
	{
		if (!GetSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetSettings_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetSettings_Context_Offset), 0, GetSettings_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSettings_FunctionAddress, intPtr, GetSettings_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, GetSettings_Context_Offset), 0, GetSettings_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetSettings_Context_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UPCGSettings>.FromNative(IntPtr.Add(intPtr, GetSettings_ReturnValue_Offset), 0, GetSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetRandomStream")]
	public unsafe static FRandomStream GetRandomStream(FPCGPoint InPoint, UPCGSettings OptionalSettings, UPCGComponent OptionalComponent)
	{
		if (!GetRandomStream_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetRandomStream");
			return default(FRandomStream);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandomStream_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandomStream_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetRandomStream_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetRandomStream_InPoint_Offset), 0, GetRandomStream_InPoint_PropertyAddress.Address, InPoint);
		UObjectMarshaler<UPCGSettings>.ToNative(IntPtr.Add(intPtr, GetRandomStream_OptionalSettings_Offset), 0, GetRandomStream_OptionalSettings_PropertyAddress.Address, OptionalSettings);
		UObjectMarshaler<UPCGComponent>.ToNative(IntPtr.Add(intPtr, GetRandomStream_OptionalComponent_Offset), 0, GetRandomStream_OptionalComponent_PropertyAddress.Address, OptionalComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRandomStream_FunctionAddress, intPtr, GetRandomStream_ParamsSize);
		return BlittableTypeMarshaler<FRandomStream>.FromNative(IntPtr.Add(intPtr, GetRandomStream_ReturnValue_Offset), 0, GetRandomStream_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetOriginalComponent")]
	public unsafe static UPCGComponent GetOriginalComponent(ref FPCGContext Context)
	{
		if (!GetOriginalComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetOriginalComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOriginalComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOriginalComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOriginalComponent_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetOriginalComponent_Context_Offset), 0, GetOriginalComponent_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOriginalComponent_FunctionAddress, intPtr, GetOriginalComponent_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, GetOriginalComponent_Context_Offset), 0, GetOriginalComponent_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOriginalComponent_Context_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UPCGComponent>.FromNative(IntPtr.Add(intPtr, GetOriginalComponent_ReturnValue_Offset), 0, GetOriginalComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetLocalCenter")]
	public unsafe static FVector GetLocalCenter(FPCGPoint InPoint)
	{
		if (!GetLocalCenter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetLocalCenter");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLocalCenter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLocalCenter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetLocalCenter_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetLocalCenter_InPoint_Offset), 0, GetLocalCenter_InPoint_PropertyAddress.Address, InPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLocalCenter_FunctionAddress, intPtr, GetLocalCenter_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLocalCenter_ReturnValue_Offset), 0, GetLocalCenter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetInputData")]
	public unsafe static UPCGData GetInputData(ref FPCGContext Context)
	{
		if (!GetInputData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetInputData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInputData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInputData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInputData_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetInputData_Context_Offset), 0, GetInputData_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInputData_FunctionAddress, intPtr, GetInputData_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, GetInputData_Context_Offset), 0, GetInputData_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetInputData_Context_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UPCGData>.FromNative(IntPtr.Add(intPtr, GetInputData_ReturnValue_Offset), 0, GetInputData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetExtents")]
	public unsafe static FVector GetExtents(FPCGPoint InPoint)
	{
		if (!GetExtents_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetExtents");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetExtents_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetExtents_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetExtents_InPoint_PropertyAddress.Address, intPtr);
		FPCGPoint.ToNative(IntPtr.Add(intPtr, GetExtents_InPoint_Offset), 0, GetExtents_InPoint_PropertyAddress.Address, InPoint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetExtents_FunctionAddress, intPtr, GetExtents_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetExtents_ReturnValue_Offset), 0, GetExtents_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetComponent")]
	public unsafe static UPCGComponent GetComponent(ref FPCGContext Context)
	{
		if (!GetComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetComponent_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetComponent_Context_Offset), 0, GetComponent_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetComponent_FunctionAddress, intPtr, GetComponent_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, GetComponent_Context_Offset), 0, GetComponent_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetComponent_Context_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UPCGComponent>.FromNative(IntPtr.Add(intPtr, GetComponent_ReturnValue_Offset), 0, GetComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetActorLocalBoundsPCG")]
	public unsafe static FBox GetActorLocalBoundsPCG(AActor InActor, bool bIgnorePCGCreatedComponents = true)
	{
		if (!GetActorLocalBoundsPCG_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetActorLocalBoundsPCG");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorLocalBoundsPCG_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorLocalBoundsPCG_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorLocalBoundsPCG_InActor_Offset), 0, GetActorLocalBoundsPCG_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_Offset), 0, GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_PropertyAddress.Address, bIgnorePCGCreatedComponents);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorLocalBoundsPCG_FunctionAddress, intPtr, GetActorLocalBoundsPCG_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetActorLocalBoundsPCG_ReturnValue_Offset), 0, GetActorLocalBoundsPCG_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetActorData")]
	public unsafe static UPCGData GetActorData(ref FPCGContext Context)
	{
		if (!GetActorData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetActorData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetActorData_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, GetActorData_Context_Offset), 0, GetActorData_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorData_FunctionAddress, intPtr, GetActorData_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, GetActorData_Context_Offset), 0, GetActorData_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActorData_Context_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UPCGData>.FromNative(IntPtr.Add(intPtr, GetActorData_ReturnValue_Offset), 0, GetActorData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:GetActorBoundsPCG")]
	public unsafe static FBox GetActorBoundsPCG(AActor InActor, bool bIgnorePCGCreatedComponents = true)
	{
		if (!GetActorBoundsPCG_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:GetActorBoundsPCG");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActorBoundsPCG_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActorBoundsPCG_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, GetActorBoundsPCG_InActor_Offset), 0, GetActorBoundsPCG_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetActorBoundsPCG_bIgnorePCGCreatedComponents_Offset), 0, GetActorBoundsPCG_bIgnorePCGCreatedComponents_PropertyAddress.Address, bIgnorePCGCreatedComponents);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActorBoundsPCG_FunctionAddress, intPtr, GetActorBoundsPCG_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetActorBoundsPCG_ReturnValue_Offset), 0, GetActorBoundsPCG_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:CreatePCGDataFromActor")]
	public unsafe static UPCGData CreatePCGDataFromActor(AActor InActor, bool bParseActor = true)
	{
		if (!CreatePCGDataFromActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:CreatePCGDataFromActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreatePCGDataFromActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreatePCGDataFromActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, CreatePCGDataFromActor_InActor_Offset), 0, CreatePCGDataFromActor_InActor_PropertyAddress.Address, InActor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreatePCGDataFromActor_bParseActor_Offset), 0, CreatePCGDataFromActor_bParseActor_PropertyAddress.Address, bParseActor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreatePCGDataFromActor_FunctionAddress, intPtr, CreatePCGDataFromActor_ParamsSize);
		return UObjectMarshaler<UPCGData>.FromNative(IntPtr.Add(intPtr, CreatePCGDataFromActor_ReturnValue_Offset), 0, CreatePCGDataFromActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/PCG.PCGBlueprintHelpers:ComputeSeedFromPosition")]
	public unsafe static int ComputeSeedFromPosition(FVector InPosition)
	{
		if (!ComputeSeedFromPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGBlueprintHelpers:ComputeSeedFromPosition");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ComputeSeedFromPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ComputeSeedFromPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ComputeSeedFromPosition_InPosition_Offset), 0, ComputeSeedFromPosition_InPosition_PropertyAddress.Address, InPosition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ComputeSeedFromPosition_FunctionAddress, intPtr, ComputeSeedFromPosition_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, ComputeSeedFromPosition_ReturnValue_Offset), 0, ComputeSeedFromPosition_ReturnValue_PropertyAddress.Address);
	}

	static UPCGBlueprintHelpers()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGBlueprintHelpers)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGBlueprintHelpers));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/PCG.PCGBlueprintHelpers");
		SetSeedFromPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSeedFromPosition");
		SetSeedFromPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSeedFromPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSeedFromPosition_InPoint_PropertyAddress, SetSeedFromPosition_FunctionAddress, "InPoint");
		SetSeedFromPosition_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(SetSeedFromPosition_FunctionAddress, "InPoint");
		SetSeedFromPosition_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSeedFromPosition_FunctionAddress, "InPoint", Classes.FStructProperty);
		SetSeedFromPosition_IsValid = SetSeedFromPosition_FunctionAddress != IntPtr.Zero && SetSeedFromPosition_InPoint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:SetSeedFromPosition", SetSeedFromPosition_IsValid);
		SetLocalCenter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLocalCenter");
		SetLocalCenter_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalCenter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalCenter_InPoint_PropertyAddress, SetLocalCenter_FunctionAddress, "InPoint");
		SetLocalCenter_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalCenter_FunctionAddress, "InPoint");
		SetLocalCenter_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalCenter_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalCenter_InLocalCenter_PropertyAddress, SetLocalCenter_FunctionAddress, "InLocalCenter");
		SetLocalCenter_InLocalCenter_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalCenter_FunctionAddress, "InLocalCenter");
		SetLocalCenter_InLocalCenter_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalCenter_FunctionAddress, "InLocalCenter", Classes.FStructProperty);
		SetLocalCenter_IsValid = SetLocalCenter_FunctionAddress != IntPtr.Zero && SetLocalCenter_InPoint_IsValid && SetLocalCenter_InLocalCenter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:SetLocalCenter", SetLocalCenter_IsValid);
		SetExtents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetExtents");
		SetExtents_ParamsSize = NativeReflection.GetFunctionParamsSize(SetExtents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetExtents_InPoint_PropertyAddress, SetExtents_FunctionAddress, "InPoint");
		SetExtents_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(SetExtents_FunctionAddress, "InPoint");
		SetExtents_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtents_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetExtents_InExtents_PropertyAddress, SetExtents_FunctionAddress, "InExtents");
		SetExtents_InExtents_Offset = NativeReflectionCached.GetPropertyOffset(SetExtents_FunctionAddress, "InExtents");
		SetExtents_InExtents_IsValid = NativeReflectionCached.ValidatePropertyClass(SetExtents_FunctionAddress, "InExtents", Classes.FStructProperty);
		SetExtents_IsValid = SetExtents_FunctionAddress != IntPtr.Zero && SetExtents_InPoint_IsValid && SetExtents_InExtents_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:SetExtents", SetExtents_IsValid);
		GetTransformedBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTransformedBounds");
		GetTransformedBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransformedBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransformedBounds_InPoint_PropertyAddress, GetTransformedBounds_FunctionAddress, "InPoint");
		GetTransformedBounds_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformedBounds_FunctionAddress, "InPoint");
		GetTransformedBounds_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformedBounds_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTransformedBounds_ReturnValue_PropertyAddress, GetTransformedBounds_FunctionAddress, "ReturnValue");
		GetTransformedBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransformedBounds_FunctionAddress, "ReturnValue");
		GetTransformedBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransformedBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTransformedBounds_IsValid = GetTransformedBounds_FunctionAddress != IntPtr.Zero && GetTransformedBounds_InPoint_IsValid && GetTransformedBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetTransformedBounds", GetTransformedBounds_IsValid);
		GetTaskId_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTaskId");
		GetTaskId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTaskId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTaskId_Context_PropertyAddress, GetTaskId_FunctionAddress, "Context");
		GetTaskId_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetTaskId_FunctionAddress, "Context");
		GetTaskId_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTaskId_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTaskId_ReturnValue_PropertyAddress, GetTaskId_FunctionAddress, "ReturnValue");
		GetTaskId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTaskId_FunctionAddress, "ReturnValue");
		GetTaskId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTaskId_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		GetTaskId_IsValid = GetTaskId_FunctionAddress != IntPtr.Zero && GetTaskId_Context_IsValid && GetTaskId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetTaskId", GetTaskId_IsValid);
		GetTargetActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTargetActor");
		GetTargetActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTargetActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTargetActor_Context_PropertyAddress, GetTargetActor_FunctionAddress, "Context");
		GetTargetActor_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetActor_FunctionAddress, "Context");
		GetTargetActor_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetActor_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTargetActor_SpatialData_PropertyAddress, GetTargetActor_FunctionAddress, "SpatialData");
		GetTargetActor_SpatialData_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetActor_FunctionAddress, "SpatialData");
		GetTargetActor_SpatialData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetActor_FunctionAddress, "SpatialData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTargetActor_ReturnValue_PropertyAddress, GetTargetActor_FunctionAddress, "ReturnValue");
		GetTargetActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTargetActor_FunctionAddress, "ReturnValue");
		GetTargetActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTargetActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTargetActor_IsValid = GetTargetActor_FunctionAddress != IntPtr.Zero && GetTargetActor_Context_IsValid && GetTargetActor_SpatialData_IsValid && GetTargetActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetTargetActor", GetTargetActor_IsValid);
		GetSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSettings");
		GetSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSettings_Context_PropertyAddress, GetSettings_FunctionAddress, "Context");
		GetSettings_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetSettings_FunctionAddress, "Context");
		GetSettings_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSettings_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSettings_ReturnValue_PropertyAddress, GetSettings_FunctionAddress, "ReturnValue");
		GetSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSettings_FunctionAddress, "ReturnValue");
		GetSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSettings_IsValid = GetSettings_FunctionAddress != IntPtr.Zero && GetSettings_Context_IsValid && GetSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetSettings", GetSettings_IsValid);
		GetRandomStream_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRandomStream");
		GetRandomStream_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomStream_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandomStream_InPoint_PropertyAddress, GetRandomStream_FunctionAddress, "InPoint");
		GetRandomStream_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomStream_FunctionAddress, "InPoint");
		GetRandomStream_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomStream_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomStream_OptionalSettings_PropertyAddress, GetRandomStream_FunctionAddress, "OptionalSettings");
		GetRandomStream_OptionalSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomStream_FunctionAddress, "OptionalSettings");
		GetRandomStream_OptionalSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomStream_FunctionAddress, "OptionalSettings", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomStream_OptionalComponent_PropertyAddress, GetRandomStream_FunctionAddress, "OptionalComponent");
		GetRandomStream_OptionalComponent_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomStream_FunctionAddress, "OptionalComponent");
		GetRandomStream_OptionalComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomStream_FunctionAddress, "OptionalComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomStream_ReturnValue_PropertyAddress, GetRandomStream_FunctionAddress, "ReturnValue");
		GetRandomStream_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomStream_FunctionAddress, "ReturnValue");
		GetRandomStream_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomStream_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRandomStream_IsValid = GetRandomStream_FunctionAddress != IntPtr.Zero && GetRandomStream_InPoint_IsValid && GetRandomStream_OptionalSettings_IsValid && GetRandomStream_OptionalComponent_IsValid && GetRandomStream_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetRandomStream", GetRandomStream_IsValid);
		GetOriginalComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOriginalComponent");
		GetOriginalComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOriginalComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOriginalComponent_Context_PropertyAddress, GetOriginalComponent_FunctionAddress, "Context");
		GetOriginalComponent_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetOriginalComponent_FunctionAddress, "Context");
		GetOriginalComponent_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOriginalComponent_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOriginalComponent_ReturnValue_PropertyAddress, GetOriginalComponent_FunctionAddress, "ReturnValue");
		GetOriginalComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOriginalComponent_FunctionAddress, "ReturnValue");
		GetOriginalComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOriginalComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOriginalComponent_IsValid = GetOriginalComponent_FunctionAddress != IntPtr.Zero && GetOriginalComponent_Context_IsValid && GetOriginalComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetOriginalComponent", GetOriginalComponent_IsValid);
		GetLocalCenter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLocalCenter");
		GetLocalCenter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLocalCenter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLocalCenter_InPoint_PropertyAddress, GetLocalCenter_FunctionAddress, "InPoint");
		GetLocalCenter_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalCenter_FunctionAddress, "InPoint");
		GetLocalCenter_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalCenter_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLocalCenter_ReturnValue_PropertyAddress, GetLocalCenter_FunctionAddress, "ReturnValue");
		GetLocalCenter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLocalCenter_FunctionAddress, "ReturnValue");
		GetLocalCenter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLocalCenter_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLocalCenter_IsValid = GetLocalCenter_FunctionAddress != IntPtr.Zero && GetLocalCenter_InPoint_IsValid && GetLocalCenter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetLocalCenter", GetLocalCenter_IsValid);
		GetInputData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInputData");
		GetInputData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInputData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInputData_Context_PropertyAddress, GetInputData_FunctionAddress, "Context");
		GetInputData_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetInputData_FunctionAddress, "Context");
		GetInputData_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputData_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInputData_ReturnValue_PropertyAddress, GetInputData_FunctionAddress, "ReturnValue");
		GetInputData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInputData_FunctionAddress, "ReturnValue");
		GetInputData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInputData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInputData_IsValid = GetInputData_FunctionAddress != IntPtr.Zero && GetInputData_Context_IsValid && GetInputData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetInputData", GetInputData_IsValid);
		GetExtents_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetExtents");
		GetExtents_ParamsSize = NativeReflection.GetFunctionParamsSize(GetExtents_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetExtents_InPoint_PropertyAddress, GetExtents_FunctionAddress, "InPoint");
		GetExtents_InPoint_Offset = NativeReflectionCached.GetPropertyOffset(GetExtents_FunctionAddress, "InPoint");
		GetExtents_InPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtents_FunctionAddress, "InPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetExtents_ReturnValue_PropertyAddress, GetExtents_FunctionAddress, "ReturnValue");
		GetExtents_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetExtents_FunctionAddress, "ReturnValue");
		GetExtents_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetExtents_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetExtents_IsValid = GetExtents_FunctionAddress != IntPtr.Zero && GetExtents_InPoint_IsValid && GetExtents_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetExtents", GetExtents_IsValid);
		GetComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetComponent");
		GetComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetComponent_Context_PropertyAddress, GetComponent_FunctionAddress, "Context");
		GetComponent_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetComponent_FunctionAddress, "Context");
		GetComponent_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponent_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetComponent_ReturnValue_PropertyAddress, GetComponent_FunctionAddress, "ReturnValue");
		GetComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetComponent_FunctionAddress, "ReturnValue");
		GetComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetComponent_IsValid = GetComponent_FunctionAddress != IntPtr.Zero && GetComponent_Context_IsValid && GetComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetComponent", GetComponent_IsValid);
		GetActorLocalBoundsPCG_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorLocalBoundsPCG");
		GetActorLocalBoundsPCG_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorLocalBoundsPCG_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorLocalBoundsPCG_InActor_PropertyAddress, GetActorLocalBoundsPCG_FunctionAddress, "InActor");
		GetActorLocalBoundsPCG_InActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLocalBoundsPCG_FunctionAddress, "InActor");
		GetActorLocalBoundsPCG_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLocalBoundsPCG_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_PropertyAddress, GetActorLocalBoundsPCG_FunctionAddress, "bIgnorePCGCreatedComponents");
		GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLocalBoundsPCG_FunctionAddress, "bIgnorePCGCreatedComponents");
		GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLocalBoundsPCG_FunctionAddress, "bIgnorePCGCreatedComponents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorLocalBoundsPCG_ReturnValue_PropertyAddress, GetActorLocalBoundsPCG_FunctionAddress, "ReturnValue");
		GetActorLocalBoundsPCG_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorLocalBoundsPCG_FunctionAddress, "ReturnValue");
		GetActorLocalBoundsPCG_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorLocalBoundsPCG_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorLocalBoundsPCG_IsValid = GetActorLocalBoundsPCG_FunctionAddress != IntPtr.Zero && GetActorLocalBoundsPCG_InActor_IsValid && GetActorLocalBoundsPCG_bIgnorePCGCreatedComponents_IsValid && GetActorLocalBoundsPCG_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetActorLocalBoundsPCG", GetActorLocalBoundsPCG_IsValid);
		GetActorData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorData");
		GetActorData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorData_Context_PropertyAddress, GetActorData_FunctionAddress, "Context");
		GetActorData_Context_Offset = NativeReflectionCached.GetPropertyOffset(GetActorData_FunctionAddress, "Context");
		GetActorData_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorData_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorData_ReturnValue_PropertyAddress, GetActorData_FunctionAddress, "ReturnValue");
		GetActorData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorData_FunctionAddress, "ReturnValue");
		GetActorData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorData_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetActorData_IsValid = GetActorData_FunctionAddress != IntPtr.Zero && GetActorData_Context_IsValid && GetActorData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetActorData", GetActorData_IsValid);
		GetActorBoundsPCG_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActorBoundsPCG");
		GetActorBoundsPCG_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActorBoundsPCG_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActorBoundsPCG_InActor_PropertyAddress, GetActorBoundsPCG_FunctionAddress, "InActor");
		GetActorBoundsPCG_InActor_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBoundsPCG_FunctionAddress, "InActor");
		GetActorBoundsPCG_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBoundsPCG_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorBoundsPCG_bIgnorePCGCreatedComponents_PropertyAddress, GetActorBoundsPCG_FunctionAddress, "bIgnorePCGCreatedComponents");
		GetActorBoundsPCG_bIgnorePCGCreatedComponents_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBoundsPCG_FunctionAddress, "bIgnorePCGCreatedComponents");
		GetActorBoundsPCG_bIgnorePCGCreatedComponents_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBoundsPCG_FunctionAddress, "bIgnorePCGCreatedComponents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetActorBoundsPCG_ReturnValue_PropertyAddress, GetActorBoundsPCG_FunctionAddress, "ReturnValue");
		GetActorBoundsPCG_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActorBoundsPCG_FunctionAddress, "ReturnValue");
		GetActorBoundsPCG_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActorBoundsPCG_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetActorBoundsPCG_IsValid = GetActorBoundsPCG_FunctionAddress != IntPtr.Zero && GetActorBoundsPCG_InActor_IsValid && GetActorBoundsPCG_bIgnorePCGCreatedComponents_IsValid && GetActorBoundsPCG_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:GetActorBoundsPCG", GetActorBoundsPCG_IsValid);
		CreatePCGDataFromActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreatePCGDataFromActor");
		CreatePCGDataFromActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreatePCGDataFromActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreatePCGDataFromActor_InActor_PropertyAddress, CreatePCGDataFromActor_FunctionAddress, "InActor");
		CreatePCGDataFromActor_InActor_Offset = NativeReflectionCached.GetPropertyOffset(CreatePCGDataFromActor_FunctionAddress, "InActor");
		CreatePCGDataFromActor_InActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePCGDataFromActor_FunctionAddress, "InActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePCGDataFromActor_bParseActor_PropertyAddress, CreatePCGDataFromActor_FunctionAddress, "bParseActor");
		CreatePCGDataFromActor_bParseActor_Offset = NativeReflectionCached.GetPropertyOffset(CreatePCGDataFromActor_FunctionAddress, "bParseActor");
		CreatePCGDataFromActor_bParseActor_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePCGDataFromActor_FunctionAddress, "bParseActor", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreatePCGDataFromActor_ReturnValue_PropertyAddress, CreatePCGDataFromActor_FunctionAddress, "ReturnValue");
		CreatePCGDataFromActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreatePCGDataFromActor_FunctionAddress, "ReturnValue");
		CreatePCGDataFromActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreatePCGDataFromActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreatePCGDataFromActor_IsValid = CreatePCGDataFromActor_FunctionAddress != IntPtr.Zero && CreatePCGDataFromActor_InActor_IsValid && CreatePCGDataFromActor_bParseActor_IsValid && CreatePCGDataFromActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:CreatePCGDataFromActor", CreatePCGDataFromActor_IsValid);
		ComputeSeedFromPosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ComputeSeedFromPosition");
		ComputeSeedFromPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(ComputeSeedFromPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ComputeSeedFromPosition_InPosition_PropertyAddress, ComputeSeedFromPosition_FunctionAddress, "InPosition");
		ComputeSeedFromPosition_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(ComputeSeedFromPosition_FunctionAddress, "InPosition");
		ComputeSeedFromPosition_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeSeedFromPosition_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ComputeSeedFromPosition_ReturnValue_PropertyAddress, ComputeSeedFromPosition_FunctionAddress, "ReturnValue");
		ComputeSeedFromPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ComputeSeedFromPosition_FunctionAddress, "ReturnValue");
		ComputeSeedFromPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ComputeSeedFromPosition_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		ComputeSeedFromPosition_IsValid = ComputeSeedFromPosition_FunctionAddress != IntPtr.Zero && ComputeSeedFromPosition_InPosition_IsValid && ComputeSeedFromPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGBlueprintHelpers:ComputeSeedFromPosition", ComputeSeedFromPosition_IsValid);
	}
}
