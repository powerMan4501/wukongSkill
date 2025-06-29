using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.GSEQGBase_ProjectedPoint", "b1", UnrealModuleType.Game)]
public class UGSEQGBase_ProjectedPoint : UEnvQueryGenerator
{
	private static bool GenerateItemList_IsValid;

	private static FFieldAddress GenerateItemList_PropertyAddress;

	private static int GenerateItemList_Offset;

	private TArrayReadWriteMarshaler<FVector> GenerateItemList_MarshalerCached;

	private static bool RunNavRaycastsInCS_IsValid;

	private static IntPtr RunNavRaycastsInCS_FunctionAddress;

	private static int RunNavRaycastsInCS_ParamsSize;

	private static bool RunNavRaycastsInCS_Points_IsValid;

	private static FFieldAddress RunNavRaycastsInCS_Points_PropertyAddress;

	private static int RunNavRaycastsInCS_Points_Offset;

	private static bool RunNavRaycastsInCS_SourcePt_IsValid;

	private static FFieldAddress RunNavRaycastsInCS_SourcePt_PropertyAddress;

	private static int RunNavRaycastsInCS_SourcePt_Offset;

	private static bool RunNavRaycastsInCS_ReturnValue_IsValid;

	private static FFieldAddress RunNavRaycastsInCS_ReturnValue_PropertyAddress;

	private static int RunNavRaycastsInCS_ReturnValue_Offset;

	private static bool ProjectAndFilterNavPointsInCS_IsValid;

	private static IntPtr ProjectAndFilterNavPointsInCS_FunctionAddress;

	private static int ProjectAndFilterNavPointsInCS_ParamsSize;

	private static bool ProjectAndFilterNavPointsInCS_Points_IsValid;

	private static FFieldAddress ProjectAndFilterNavPointsInCS_Points_PropertyAddress;

	private static int ProjectAndFilterNavPointsInCS_Points_Offset;

	private static bool ProjectAndFilterNavPointsInCS_ReturnValue_IsValid;

	private static FFieldAddress ProjectAndFilterNavPointsInCS_ReturnValue_PropertyAddress;

	private static int ProjectAndFilterNavPointsInCS_ReturnValue_Offset;

	private static bool GetQuerier_IsValid;

	private static IntPtr GetQuerier_FunctionAddress;

	private static int GetQuerier_ParamsSize;

	private static bool GetQuerier_ReturnValue_IsValid;

	private static FFieldAddress GetQuerier_ReturnValue_PropertyAddress;

	private static int GetQuerier_ReturnValue_Offset;

	private static bool DoItemGenerationCS_IsValid;

	private IntPtr DoItemGenerationCS_InstanceFunctionAddress;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static bool AddGeneratedVector_IsValid;

	private static IntPtr AddGeneratedVector_FunctionAddress;

	private static int AddGeneratedVector_ParamsSize;

	private static bool AddGeneratedVector_GeneratedVector_IsValid;

	private static FFieldAddress AddGeneratedVector_GeneratedVector_PropertyAddress;

	private static int AddGeneratedVector_GeneratedVector_Offset;

	private static bool AddGeneratedActor_IsValid;

	private static IntPtr AddGeneratedActor_FunctionAddress;

	private static int AddGeneratedActor_ParamsSize;

	private static bool AddGeneratedActor_GeneratedActor_IsValid;

	private static FFieldAddress AddGeneratedActor_GeneratedActor_PropertyAddress;

	private static int AddGeneratedActor_GeneratedActor_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/b1.GSEQGBase_ProjectedPoint:GenerateItemList")]
	public TArrayReadWrite<FVector> GenerateItemList
	{
		get
		{
			CheckDestroyed();
			if (!GenerateItemList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQGBase_ProjectedPoint:GenerateItemList");
				return null;
			}
			if (GenerateItemList_MarshalerCached == null)
			{
				GenerateItemList_MarshalerCached = new TArrayReadWriteMarshaler<FVector>(1, GenerateItemList_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return GenerateItemList_MarshalerCached.FromNative(IntPtr.Add(base.Address, GenerateItemList_Offset));
		}
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/b1.GSEQGBase_ProjectedPoint:RunNavRaycastsInCS")]
	public unsafe List<FVector> RunNavRaycastsInCS(List<FVector> Points, FVector SourcePt)
	{
		CheckDestroyed();
		if (!RunNavRaycastsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQGBase_ProjectedPoint:RunNavRaycastsInCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunNavRaycastsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunNavRaycastsInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, RunNavRaycastsInCS_Points_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, RunNavRaycastsInCS_Points_Offset), Points);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, RunNavRaycastsInCS_SourcePt_Offset), 0, RunNavRaycastsInCS_SourcePt_PropertyAddress.Address, SourcePt);
		NativeReflection.InvokeFunctionOptimized(base.Address, RunNavRaycastsInCS_FunctionAddress, intPtr, RunNavRaycastsInCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RunNavRaycastsInCS_Points_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, RunNavRaycastsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, RunNavRaycastsInCS_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(RunNavRaycastsInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/b1.GSEQGBase_ProjectedPoint:ProjectAndFilterNavPointsInCS")]
	public unsafe List<FVector> ProjectAndFilterNavPointsInCS(List<FVector> Points)
	{
		CheckDestroyed();
		if (!ProjectAndFilterNavPointsInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQGBase_ProjectedPoint:ProjectAndFilterNavPointsInCS");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectAndFilterNavPointsInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectAndFilterNavPointsInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, ProjectAndFilterNavPointsInCS_Points_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, ProjectAndFilterNavPointsInCS_Points_Offset), Points);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProjectAndFilterNavPointsInCS_FunctionAddress, intPtr, ProjectAndFilterNavPointsInCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProjectAndFilterNavPointsInCS_Points_PropertyAddress.Address, intPtr);
		List<FVector> result = new TArrayCopyMarshaler<FVector>(1, ProjectAndFilterNavPointsInCS_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, ProjectAndFilterNavPointsInCS_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ProjectAndFilterNavPointsInCS_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.GSEQGBase_ProjectedPoint:GetQuerier")]
	public unsafe UObject GetQuerier()
	{
		CheckDestroyed();
		if (!GetQuerier_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQGBase_ProjectedPoint:GetQuerier");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQuerier_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQuerier_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQuerier_FunctionAddress, intPtr, GetQuerier_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetQuerier_ReturnValue_Offset), 0, GetQuerier_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1212286976u)]
	[UMetaPath("/Script/b1.GSEQGBase_ProjectedPoint:DoItemGenerationCS")]
	public unsafe void DoItemGenerationCS(List<FVector> ContextLocations)
	{
		CheckDestroyed();
		if (!DoItemGenerationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQGBase_ProjectedPoint:DoItemGenerationCS");
			return;
		}
		if (DoItemGenerationCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			DoItemGenerationCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DoItemGenerationCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoItemGenerationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoItemGenerationCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, DoItemGenerationCS_ContextLocations_Offset), ContextLocations);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoItemGenerationCS_InstanceFunctionAddress, intPtr, DoItemGenerationCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoItemGenerationCS_ContextLocations_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		CheckDestroyed();
		if (!DoItemGenerationCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQGBase_ProjectedPoint:DoItemGenerationCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoItemGenerationCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoItemGenerationCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, DoItemGenerationCS_ContextLocations_Offset), ContextLocations);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoItemGenerationCS_FunctionAddress, intPtr, DoItemGenerationCS_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoItemGenerationCS_ContextLocations_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1149371393u)]
	[UMetaPath("/Script/b1.GSEQGBase_ProjectedPoint:AddGeneratedVector")]
	public unsafe void AddGeneratedVector(FVector GeneratedVector)
	{
		CheckDestroyed();
		if (!AddGeneratedVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQGBase_ProjectedPoint:AddGeneratedVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGeneratedVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGeneratedVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddGeneratedVector_GeneratedVector_Offset), 0, AddGeneratedVector_GeneratedVector_PropertyAddress.Address, GeneratedVector);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddGeneratedVector_FunctionAddress, intPtr, AddGeneratedVector_ParamsSize);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/b1.GSEQGBase_ProjectedPoint:AddGeneratedActor")]
	public unsafe void AddGeneratedActor(AActor GeneratedActor)
	{
		CheckDestroyed();
		if (!AddGeneratedActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.GSEQGBase_ProjectedPoint:AddGeneratedActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddGeneratedActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddGeneratedActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AddGeneratedActor_GeneratedActor_Offset), 0, AddGeneratedActor_GeneratedActor_PropertyAddress.Address, GeneratedActor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddGeneratedActor_FunctionAddress, intPtr, AddGeneratedActor_ParamsSize);
	}

	static UGSEQGBase_ProjectedPoint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEQGBase_ProjectedPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEQGBase_ProjectedPoint));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.GSEQGBase_ProjectedPoint");
		NativeReflectionCached.GetPropertyRef(ref GenerateItemList_PropertyAddress, intPtr, "GenerateItemList");
		GenerateItemList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GenerateItemList");
		GenerateItemList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GenerateItemList", Classes.FArrayProperty);
		RunNavRaycastsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RunNavRaycastsInCS");
		RunNavRaycastsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(RunNavRaycastsInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunNavRaycastsInCS_Points_PropertyAddress, RunNavRaycastsInCS_FunctionAddress, "Points");
		RunNavRaycastsInCS_Points_Offset = NativeReflectionCached.GetPropertyOffset(RunNavRaycastsInCS_FunctionAddress, "Points");
		RunNavRaycastsInCS_Points_IsValid = NativeReflectionCached.ValidatePropertyClass(RunNavRaycastsInCS_FunctionAddress, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RunNavRaycastsInCS_SourcePt_PropertyAddress, RunNavRaycastsInCS_FunctionAddress, "SourcePt");
		RunNavRaycastsInCS_SourcePt_Offset = NativeReflectionCached.GetPropertyOffset(RunNavRaycastsInCS_FunctionAddress, "SourcePt");
		RunNavRaycastsInCS_SourcePt_IsValid = NativeReflectionCached.ValidatePropertyClass(RunNavRaycastsInCS_FunctionAddress, "SourcePt", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref RunNavRaycastsInCS_ReturnValue_PropertyAddress, RunNavRaycastsInCS_FunctionAddress, "ReturnValue");
		RunNavRaycastsInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RunNavRaycastsInCS_FunctionAddress, "ReturnValue");
		RunNavRaycastsInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RunNavRaycastsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		RunNavRaycastsInCS_IsValid = RunNavRaycastsInCS_FunctionAddress != IntPtr.Zero && RunNavRaycastsInCS_Points_IsValid && RunNavRaycastsInCS_SourcePt_IsValid && RunNavRaycastsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQGBase_ProjectedPoint:RunNavRaycastsInCS", RunNavRaycastsInCS_IsValid);
		ProjectAndFilterNavPointsInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProjectAndFilterNavPointsInCS");
		ProjectAndFilterNavPointsInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectAndFilterNavPointsInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectAndFilterNavPointsInCS_Points_PropertyAddress, ProjectAndFilterNavPointsInCS_FunctionAddress, "Points");
		ProjectAndFilterNavPointsInCS_Points_Offset = NativeReflectionCached.GetPropertyOffset(ProjectAndFilterNavPointsInCS_FunctionAddress, "Points");
		ProjectAndFilterNavPointsInCS_Points_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectAndFilterNavPointsInCS_FunctionAddress, "Points", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectAndFilterNavPointsInCS_ReturnValue_PropertyAddress, ProjectAndFilterNavPointsInCS_FunctionAddress, "ReturnValue");
		ProjectAndFilterNavPointsInCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectAndFilterNavPointsInCS_FunctionAddress, "ReturnValue");
		ProjectAndFilterNavPointsInCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectAndFilterNavPointsInCS_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ProjectAndFilterNavPointsInCS_IsValid = ProjectAndFilterNavPointsInCS_FunctionAddress != IntPtr.Zero && ProjectAndFilterNavPointsInCS_Points_IsValid && ProjectAndFilterNavPointsInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQGBase_ProjectedPoint:ProjectAndFilterNavPointsInCS", ProjectAndFilterNavPointsInCS_IsValid);
		GetQuerier_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetQuerier");
		GetQuerier_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQuerier_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQuerier_ReturnValue_PropertyAddress, GetQuerier_FunctionAddress, "ReturnValue");
		GetQuerier_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQuerier_FunctionAddress, "ReturnValue");
		GetQuerier_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuerier_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetQuerier_IsValid = GetQuerier_FunctionAddress != IntPtr.Zero && GetQuerier_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQGBase_ProjectedPoint:GetQuerier", GetQuerier_IsValid);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflectionCached.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflectionCached.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQGBase_ProjectedPoint:DoItemGenerationCS", DoItemGenerationCS_IsValid);
		AddGeneratedVector_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddGeneratedVector");
		AddGeneratedVector_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGeneratedVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGeneratedVector_GeneratedVector_PropertyAddress, AddGeneratedVector_FunctionAddress, "GeneratedVector");
		AddGeneratedVector_GeneratedVector_Offset = NativeReflectionCached.GetPropertyOffset(AddGeneratedVector_FunctionAddress, "GeneratedVector");
		AddGeneratedVector_GeneratedVector_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGeneratedVector_FunctionAddress, "GeneratedVector", Classes.FStructProperty);
		AddGeneratedVector_IsValid = AddGeneratedVector_FunctionAddress != IntPtr.Zero && AddGeneratedVector_GeneratedVector_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQGBase_ProjectedPoint:AddGeneratedVector", AddGeneratedVector_IsValid);
		AddGeneratedActor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddGeneratedActor");
		AddGeneratedActor_ParamsSize = NativeReflection.GetFunctionParamsSize(AddGeneratedActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddGeneratedActor_GeneratedActor_PropertyAddress, AddGeneratedActor_FunctionAddress, "GeneratedActor");
		AddGeneratedActor_GeneratedActor_Offset = NativeReflectionCached.GetPropertyOffset(AddGeneratedActor_FunctionAddress, "GeneratedActor");
		AddGeneratedActor_GeneratedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(AddGeneratedActor_FunctionAddress, "GeneratedActor", Classes.FObjectProperty);
		AddGeneratedActor_IsValid = AddGeneratedActor_FunctionAddress != IntPtr.Zero && AddGeneratedActor_GeneratedActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.GSEQGBase_ProjectedPoint:AddGeneratedActor", AddGeneratedActor_IsValid);
	}
}
