using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGSpatialData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGSpatialData : UPCGData
{
	private static bool TargetActor_IsValid;

	private static int TargetActor_Offset;

	private static bool KeepZeroDensityPoints_IsValid;

	private static FFieldAddress KeepZeroDensityPoints_PropertyAddress;

	private static int KeepZeroDensityPoints_Offset;

	private static bool UnionWith_IsValid;

	private static IntPtr UnionWith_FunctionAddress;

	private static int UnionWith_ParamsSize;

	private static bool UnionWith_InOther_IsValid;

	private static FFieldAddress UnionWith_InOther_PropertyAddress;

	private static int UnionWith_InOther_Offset;

	private static bool UnionWith_ReturnValue_IsValid;

	private static FFieldAddress UnionWith_ReturnValue_PropertyAddress;

	private static int UnionWith_ReturnValue_Offset;

	private static bool ToPointDataWithContext_IsValid;

	private static IntPtr ToPointDataWithContext_FunctionAddress;

	private static int ToPointDataWithContext_ParamsSize;

	private static bool ToPointDataWithContext_Context_IsValid;

	private static FFieldAddress ToPointDataWithContext_Context_PropertyAddress;

	private static int ToPointDataWithContext_Context_Offset;

	private static bool ToPointDataWithContext_ReturnValue_IsValid;

	private static FFieldAddress ToPointDataWithContext_ReturnValue_PropertyAddress;

	private static int ToPointDataWithContext_ReturnValue_Offset;

	private static bool Subtract_IsValid;

	private static IntPtr Subtract_FunctionAddress;

	private static int Subtract_ParamsSize;

	private static bool Subtract_InOther_IsValid;

	private static FFieldAddress Subtract_InOther_PropertyAddress;

	private static int Subtract_InOther_Offset;

	private static bool Subtract_ReturnValue_IsValid;

	private static FFieldAddress Subtract_ReturnValue_PropertyAddress;

	private static int Subtract_ReturnValue_Offset;

	private static bool SamplePoint_IsValid;

	private static IntPtr SamplePoint_FunctionAddress;

	private static int SamplePoint_ParamsSize;

	private static bool SamplePoint_Transform_IsValid;

	private static FFieldAddress SamplePoint_Transform_PropertyAddress;

	private static int SamplePoint_Transform_Offset;

	private static bool SamplePoint_Bounds_IsValid;

	private static FFieldAddress SamplePoint_Bounds_PropertyAddress;

	private static int SamplePoint_Bounds_Offset;

	private static bool SamplePoint_OutPoint_IsValid;

	private static FFieldAddress SamplePoint_OutPoint_PropertyAddress;

	private static int SamplePoint_OutPoint_Offset;

	private static bool SamplePoint_OutMetadata_IsValid;

	private static FFieldAddress SamplePoint_OutMetadata_PropertyAddress;

	private static int SamplePoint_OutMetadata_Offset;

	private static bool SamplePoint_ReturnValue_IsValid;

	private static FFieldAddress SamplePoint_ReturnValue_PropertyAddress;

	private static int SamplePoint_ReturnValue_Offset;

	private static bool ProjectPoint_IsValid;

	private static IntPtr ProjectPoint_FunctionAddress;

	private static int ProjectPoint_ParamsSize;

	private static bool ProjectPoint_InTransform_IsValid;

	private static FFieldAddress ProjectPoint_InTransform_PropertyAddress;

	private static int ProjectPoint_InTransform_Offset;

	private static bool ProjectPoint_InBounds_IsValid;

	private static FFieldAddress ProjectPoint_InBounds_PropertyAddress;

	private static int ProjectPoint_InBounds_Offset;

	private static bool ProjectPoint_InParams_IsValid;

	private static FFieldAddress ProjectPoint_InParams_PropertyAddress;

	private static int ProjectPoint_InParams_Offset;

	private static bool ProjectPoint_OutPoint_IsValid;

	private static FFieldAddress ProjectPoint_OutPoint_PropertyAddress;

	private static int ProjectPoint_OutPoint_Offset;

	private static bool ProjectPoint_OutMetadata_IsValid;

	private static FFieldAddress ProjectPoint_OutMetadata_PropertyAddress;

	private static int ProjectPoint_OutMetadata_Offset;

	private static bool ProjectPoint_ReturnValue_IsValid;

	private static FFieldAddress ProjectPoint_ReturnValue_PropertyAddress;

	private static int ProjectPoint_ReturnValue_Offset;

	private static bool ProjectOn_IsValid;

	private static IntPtr ProjectOn_FunctionAddress;

	private static int ProjectOn_ParamsSize;

	private static bool ProjectOn_InOther_IsValid;

	private static FFieldAddress ProjectOn_InOther_PropertyAddress;

	private static int ProjectOn_InOther_Offset;

	private static bool ProjectOn_InParams_IsValid;

	private static FFieldAddress ProjectOn_InParams_PropertyAddress;

	private static int ProjectOn_InParams_Offset;

	private static bool ProjectOn_ReturnValue_IsValid;

	private static FFieldAddress ProjectOn_ReturnValue_PropertyAddress;

	private static int ProjectOn_ReturnValue_Offset;

	private static bool MutableMetadata_IsValid;

	private static IntPtr MutableMetadata_FunctionAddress;

	private static int MutableMetadata_ParamsSize;

	private static bool MutableMetadata_ReturnValue_IsValid;

	private static FFieldAddress MutableMetadata_ReturnValue_PropertyAddress;

	private static int MutableMetadata_ReturnValue_Offset;

	private static bool IntersectWith_IsValid;

	private static IntPtr IntersectWith_FunctionAddress;

	private static int IntersectWith_ParamsSize;

	private static bool IntersectWith_InOther_IsValid;

	private static FFieldAddress IntersectWith_InOther_PropertyAddress;

	private static int IntersectWith_InOther_Offset;

	private static bool IntersectWith_ReturnValue_IsValid;

	private static FFieldAddress IntersectWith_ReturnValue_PropertyAddress;

	private static int IntersectWith_ReturnValue_Offset;

	private static bool InitializeFromData_IsValid;

	private static IntPtr InitializeFromData_FunctionAddress;

	private static int InitializeFromData_ParamsSize;

	private static bool InitializeFromData_InSource_IsValid;

	private static FFieldAddress InitializeFromData_InSource_PropertyAddress;

	private static int InitializeFromData_InSource_Offset;

	private static bool InitializeFromData_InMetadataParentOverride_IsValid;

	private static FFieldAddress InitializeFromData_InMetadataParentOverride_PropertyAddress;

	private static int InitializeFromData_InMetadataParentOverride_Offset;

	private static bool InitializeFromData_bInheritMetadata_IsValid;

	private static FFieldAddress InitializeFromData_bInheritMetadata_PropertyAddress;

	private static int InitializeFromData_bInheritMetadata_Offset;

	private static bool InitializeFromData_bInheritAttributes_IsValid;

	private static FFieldAddress InitializeFromData_bInheritAttributes_PropertyAddress;

	private static int InitializeFromData_bInheritAttributes_Offset;

	private static bool HasNonTrivialTransform_IsValid;

	private static IntPtr HasNonTrivialTransform_FunctionAddress;

	private static int HasNonTrivialTransform_ParamsSize;

	private static bool HasNonTrivialTransform_ReturnValue_IsValid;

	private static FFieldAddress HasNonTrivialTransform_ReturnValue_PropertyAddress;

	private static int HasNonTrivialTransform_ReturnValue_Offset;

	private static bool GetStrictBounds_IsValid;

	private static IntPtr GetStrictBounds_FunctionAddress;

	private static int GetStrictBounds_ParamsSize;

	private static bool GetStrictBounds_ReturnValue_IsValid;

	private static FFieldAddress GetStrictBounds_ReturnValue_PropertyAddress;

	private static int GetStrictBounds_ReturnValue_Offset;

	private static bool GetNormal_IsValid;

	private static IntPtr GetNormal_FunctionAddress;

	private static int GetNormal_ParamsSize;

	private static bool GetNormal_ReturnValue_IsValid;

	private static FFieldAddress GetNormal_ReturnValue_PropertyAddress;

	private static int GetNormal_ReturnValue_Offset;

	private static bool GetDimension_IsValid;

	private static IntPtr GetDimension_FunctionAddress;

	private static int GetDimension_ParamsSize;

	private static bool GetDimension_ReturnValue_IsValid;

	private static FFieldAddress GetDimension_ReturnValue_PropertyAddress;

	private static int GetDimension_ReturnValue_Offset;

	private static bool GetDensityAtPosition_IsValid;

	private static IntPtr GetDensityAtPosition_FunctionAddress;

	private static int GetDensityAtPosition_ParamsSize;

	private static bool GetDensityAtPosition_InPosition_IsValid;

	private static FFieldAddress GetDensityAtPosition_InPosition_PropertyAddress;

	private static int GetDensityAtPosition_InPosition_Offset;

	private static bool GetDensityAtPosition_ReturnValue_IsValid;

	private static FFieldAddress GetDensityAtPosition_ReturnValue_PropertyAddress;

	private static int GetDensityAtPosition_ReturnValue_Offset;

	private static bool GetBounds_IsValid;

	private static IntPtr GetBounds_FunctionAddress;

	private static int GetBounds_ParamsSize;

	private static bool GetBounds_ReturnValue_IsValid;

	private static FFieldAddress GetBounds_ReturnValue_PropertyAddress;

	private static int GetBounds_ReturnValue_Offset;

	private static bool ConstMetadata_IsValid;

	private static IntPtr ConstMetadata_FunctionAddress;

	private static int ConstMetadata_ParamsSize;

	private static bool ConstMetadata_ReturnValue_IsValid;

	private static FFieldAddress ConstMetadata_ReturnValue_PropertyAddress;

	private static int ConstMetadata_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141125637uL)]
	[UMetaPath("/Script/PCG.PCGSpatialData:TargetActor")]
	public TWeakObject<AActor> TargetActor
	{
		get
		{
			CheckDestroyed();
			if (!TargetActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialData:TargetActor");
				return default(TWeakObject<AActor>);
			}
			return TWeakObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TargetActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialData:TargetActor");
			}
			else
			{
				TWeakObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TargetActor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755503594021381uL)]
	[UMetaPath("/Script/PCG.PCGSpatialData:bKeepZeroDensityPoints")]
	public bool KeepZeroDensityPoints
	{
		get
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialData:bKeepZeroDensityPoints");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!KeepZeroDensityPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGSpatialData:bKeepZeroDensityPoints");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, KeepZeroDensityPoints_Offset), 0, KeepZeroDensityPoints_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:UnionWith")]
	public unsafe UPCGUnionData UnionWith(UPCGSpatialData InOther)
	{
		CheckDestroyed();
		if (!UnionWith_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:UnionWith");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnionWith_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnionWith_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, UnionWith_InOther_Offset), 0, UnionWith_InOther_PropertyAddress.Address, InOther);
		NativeReflection.InvokeFunctionOptimized(base.Address, UnionWith_FunctionAddress, intPtr, UnionWith_ParamsSize);
		return UObjectMarshaler<UPCGUnionData>.FromNative(IntPtr.Add(intPtr, UnionWith_ReturnValue_Offset), 0, UnionWith_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:ToPointDataWithContext")]
	public unsafe UPCGPointData ToPointDataWithContext(ref FPCGContext Context)
	{
		CheckDestroyed();
		if (!ToPointDataWithContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:ToPointDataWithContext");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ToPointDataWithContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ToPointDataWithContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ToPointDataWithContext_Context_PropertyAddress.Address, intPtr);
		FPCGContext.ToNative(IntPtr.Add(intPtr, ToPointDataWithContext_Context_Offset), 0, ToPointDataWithContext_Context_PropertyAddress.Address, Context);
		NativeReflection.InvokeFunctionOptimized(base.Address, ToPointDataWithContext_FunctionAddress, intPtr, ToPointDataWithContext_ParamsSize);
		Context = FPCGContext.FromNative(IntPtr.Add(intPtr, ToPointDataWithContext_Context_Offset), 0, ToPointDataWithContext_Context_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ToPointDataWithContext_Context_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UPCGPointData>.FromNative(IntPtr.Add(intPtr, ToPointDataWithContext_ReturnValue_Offset), 0, ToPointDataWithContext_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:Subtract")]
	public unsafe UPCGDifferenceData Subtract(UPCGSpatialData InOther)
	{
		CheckDestroyed();
		if (!Subtract_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:Subtract");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Subtract_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Subtract_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, Subtract_InOther_Offset), 0, Subtract_InOther_PropertyAddress.Address, InOther);
		NativeReflection.InvokeFunctionOptimized(base.Address, Subtract_FunctionAddress, intPtr, Subtract_ParamsSize);
		return UObjectMarshaler<UPCGDifferenceData>.FromNative(IntPtr.Add(intPtr, Subtract_ReturnValue_Offset), 0, Subtract_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:SamplePoint")]
	public unsafe bool SamplePoint(FTransform Transform, FBox Bounds, out FPCGPoint OutPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!SamplePoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:SamplePoint");
			OutPoint = default(FPCGPoint);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SamplePoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SamplePoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SamplePoint_Transform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, SamplePoint_Transform_Offset), 0, SamplePoint_Transform_PropertyAddress.Address, Transform);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, SamplePoint_Bounds_Offset), 0, SamplePoint_Bounds_PropertyAddress.Address, Bounds);
		NativeReflection.InitializeValue_InContainer(SamplePoint_OutPoint_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, SamplePoint_OutMetadata_Offset), 0, SamplePoint_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, SamplePoint_FunctionAddress, intPtr, SamplePoint_ParamsSize);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, SamplePoint_OutPoint_Offset), 0, SamplePoint_OutPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SamplePoint_ReturnValue_Offset), 0, SamplePoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:ProjectPoint")]
	public unsafe bool ProjectPoint(FTransform InTransform, FBox InBounds, FPCGProjectionParams InParams, out FPCGPoint OutPoint, UPCGMetadata OutMetadata)
	{
		CheckDestroyed();
		if (!ProjectPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:ProjectPoint");
			OutPoint = default(FPCGPoint);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ProjectPoint_InTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ProjectPoint_InTransform_Offset), 0, ProjectPoint_InTransform_PropertyAddress.Address, InTransform);
		BlittableTypeMarshaler<FBox>.ToNative(IntPtr.Add(intPtr, ProjectPoint_InBounds_Offset), 0, ProjectPoint_InBounds_PropertyAddress.Address, InBounds);
		NativeReflection.InitializeValue_InContainer(ProjectPoint_InParams_PropertyAddress.Address, intPtr);
		FPCGProjectionParams.ToNative(IntPtr.Add(intPtr, ProjectPoint_InParams_Offset), 0, ProjectPoint_InParams_PropertyAddress.Address, InParams);
		NativeReflection.InitializeValue_InContainer(ProjectPoint_OutPoint_PropertyAddress.Address, intPtr);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, ProjectPoint_OutMetadata_Offset), 0, ProjectPoint_OutMetadata_PropertyAddress.Address, OutMetadata);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProjectPoint_FunctionAddress, intPtr, ProjectPoint_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProjectPoint_InParams_PropertyAddress.Address, intPtr);
		OutPoint = FPCGPoint.FromNative(IntPtr.Add(intPtr, ProjectPoint_OutPoint_Offset), 0, ProjectPoint_OutPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ProjectPoint_ReturnValue_Offset), 0, ProjectPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612544u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:ProjectOn")]
	public unsafe UPCGSpatialData ProjectOn(UPCGSpatialData InOther, FPCGProjectionParams InParams)
	{
		CheckDestroyed();
		if (!ProjectOn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:ProjectOn");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectOn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectOn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, ProjectOn_InOther_Offset), 0, ProjectOn_InOther_PropertyAddress.Address, InOther);
		NativeReflection.InitializeValue_InContainer(ProjectOn_InParams_PropertyAddress.Address, intPtr);
		FPCGProjectionParams.ToNative(IntPtr.Add(intPtr, ProjectOn_InParams_Offset), 0, ProjectOn_InParams_PropertyAddress.Address, InParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProjectOn_FunctionAddress, intPtr, ProjectOn_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ProjectOn_InParams_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UPCGSpatialData>.FromNative(IntPtr.Add(intPtr, ProjectOn_ReturnValue_Offset), 0, ProjectOn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:MutableMetadata")]
	public unsafe UPCGMetadata MutableMetadata()
	{
		CheckDestroyed();
		if (!MutableMetadata_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:MutableMetadata");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MutableMetadata_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MutableMetadata_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, MutableMetadata_FunctionAddress, intPtr, MutableMetadata_ParamsSize);
		return UObjectMarshaler<UPCGMetadata>.FromNative(IntPtr.Add(intPtr, MutableMetadata_ReturnValue_Offset), 0, MutableMetadata_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:IntersectWith")]
	public unsafe UPCGIntersectionData IntersectWith(UPCGSpatialData InOther)
	{
		CheckDestroyed();
		if (!IntersectWith_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:IntersectWith");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IntersectWith_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IntersectWith_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, IntersectWith_InOther_Offset), 0, IntersectWith_InOther_PropertyAddress.Address, InOther);
		NativeReflection.InvokeFunctionOptimized(base.Address, IntersectWith_FunctionAddress, intPtr, IntersectWith_ParamsSize);
		return UObjectMarshaler<UPCGIntersectionData>.FromNative(IntPtr.Add(intPtr, IntersectWith_ReturnValue_Offset), 0, IntersectWith_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:InitializeFromData")]
	public unsafe void InitializeFromData(UPCGSpatialData InSource, UPCGMetadata InMetadataParentOverride, bool bInheritMetadata, bool bInheritAttributes)
	{
		CheckDestroyed();
		if (!InitializeFromData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:InitializeFromData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeFromData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeFromData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, InitializeFromData_InSource_Offset), 0, InitializeFromData_InSource_PropertyAddress.Address, InSource);
		UObjectMarshaler<UPCGMetadata>.ToNative(IntPtr.Add(intPtr, InitializeFromData_InMetadataParentOverride_Offset), 0, InitializeFromData_InMetadataParentOverride_PropertyAddress.Address, InMetadataParentOverride);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InitializeFromData_bInheritMetadata_Offset), 0, InitializeFromData_bInheritMetadata_PropertyAddress.Address, bInheritMetadata);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, InitializeFromData_bInheritAttributes_Offset), 0, InitializeFromData_bInheritAttributes_PropertyAddress.Address, bInheritAttributes);
		NativeReflection.InvokeFunctionOptimized(base.Address, InitializeFromData_FunctionAddress, intPtr, InitializeFromData_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:HasNonTrivialTransform")]
	public unsafe bool HasNonTrivialTransform()
	{
		CheckDestroyed();
		if (!HasNonTrivialTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:HasNonTrivialTransform");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasNonTrivialTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasNonTrivialTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasNonTrivialTransform_FunctionAddress, intPtr, HasNonTrivialTransform_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasNonTrivialTransform_ReturnValue_Offset), 0, HasNonTrivialTransform_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:GetStrictBounds")]
	public unsafe FBox GetStrictBounds()
	{
		CheckDestroyed();
		if (!GetStrictBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:GetStrictBounds");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStrictBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStrictBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStrictBounds_FunctionAddress, intPtr, GetStrictBounds_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetStrictBounds_ReturnValue_Offset), 0, GetStrictBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:GetNormal")]
	public unsafe FVector GetNormal()
	{
		CheckDestroyed();
		if (!GetNormal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:GetNormal");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNormal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNormal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetNormal_FunctionAddress, intPtr, GetNormal_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetNormal_ReturnValue_Offset), 0, GetNormal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:GetDimension")]
	public unsafe int GetDimension()
	{
		CheckDestroyed();
		if (!GetDimension_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:GetDimension");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDimension_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDimension_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDimension_FunctionAddress, intPtr, GetDimension_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDimension_ReturnValue_Offset), 0, GetDimension_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001152u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:GetDensityAtPosition")]
	public unsafe float GetDensityAtPosition(FVector InPosition)
	{
		CheckDestroyed();
		if (!GetDensityAtPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:GetDensityAtPosition");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDensityAtPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDensityAtPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetDensityAtPosition_InPosition_Offset), 0, GetDensityAtPosition_InPosition_PropertyAddress.Address, InPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDensityAtPosition_FunctionAddress, intPtr, GetDensityAtPosition_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDensityAtPosition_ReturnValue_Offset), 0, GetDensityAtPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:GetBounds")]
	public unsafe FBox GetBounds()
	{
		CheckDestroyed();
		if (!GetBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:GetBounds");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBounds_FunctionAddress, intPtr, GetBounds_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetBounds_ReturnValue_Offset), 0, GetBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGSpatialData:ConstMetadata")]
	public unsafe UPCGMetadata ConstMetadata()
	{
		CheckDestroyed();
		if (!ConstMetadata_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGSpatialData:ConstMetadata");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstMetadata_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstMetadata_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstMetadata_FunctionAddress, intPtr, ConstMetadata_ParamsSize);
		return UObjectMarshaler<UPCGMetadata>.FromNative(IntPtr.Add(intPtr, ConstMetadata_ReturnValue_Offset), 0, ConstMetadata_ReturnValue_PropertyAddress.Address);
	}

	static UPCGSpatialData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGSpatialData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGSpatialData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGSpatialData");
		TargetActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetActor");
		TargetActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetActor", Classes.FWeakObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref KeepZeroDensityPoints_PropertyAddress, intPtr, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bKeepZeroDensityPoints");
		KeepZeroDensityPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bKeepZeroDensityPoints", Classes.FBoolProperty);
		UnionWith_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UnionWith");
		UnionWith_ParamsSize = NativeReflection.GetFunctionParamsSize(UnionWith_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnionWith_InOther_PropertyAddress, UnionWith_FunctionAddress, "InOther");
		UnionWith_InOther_Offset = NativeReflectionCached.GetPropertyOffset(UnionWith_FunctionAddress, "InOther");
		UnionWith_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(UnionWith_FunctionAddress, "InOther", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UnionWith_ReturnValue_PropertyAddress, UnionWith_FunctionAddress, "ReturnValue");
		UnionWith_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UnionWith_FunctionAddress, "ReturnValue");
		UnionWith_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UnionWith_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		UnionWith_IsValid = UnionWith_FunctionAddress != IntPtr.Zero && UnionWith_InOther_IsValid && UnionWith_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:UnionWith", UnionWith_IsValid);
		ToPointDataWithContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ToPointDataWithContext");
		ToPointDataWithContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ToPointDataWithContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ToPointDataWithContext_Context_PropertyAddress, ToPointDataWithContext_FunctionAddress, "Context");
		ToPointDataWithContext_Context_Offset = NativeReflectionCached.GetPropertyOffset(ToPointDataWithContext_FunctionAddress, "Context");
		ToPointDataWithContext_Context_IsValid = NativeReflectionCached.ValidatePropertyClass(ToPointDataWithContext_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ToPointDataWithContext_ReturnValue_PropertyAddress, ToPointDataWithContext_FunctionAddress, "ReturnValue");
		ToPointDataWithContext_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ToPointDataWithContext_FunctionAddress, "ReturnValue");
		ToPointDataWithContext_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ToPointDataWithContext_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ToPointDataWithContext_IsValid = ToPointDataWithContext_FunctionAddress != IntPtr.Zero && ToPointDataWithContext_Context_IsValid && ToPointDataWithContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:ToPointDataWithContext", ToPointDataWithContext_IsValid);
		Subtract_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Subtract");
		Subtract_ParamsSize = NativeReflection.GetFunctionParamsSize(Subtract_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Subtract_InOther_PropertyAddress, Subtract_FunctionAddress, "InOther");
		Subtract_InOther_Offset = NativeReflectionCached.GetPropertyOffset(Subtract_FunctionAddress, "InOther");
		Subtract_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(Subtract_FunctionAddress, "InOther", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Subtract_ReturnValue_PropertyAddress, Subtract_FunctionAddress, "ReturnValue");
		Subtract_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Subtract_FunctionAddress, "ReturnValue");
		Subtract_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Subtract_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		Subtract_IsValid = Subtract_FunctionAddress != IntPtr.Zero && Subtract_InOther_IsValid && Subtract_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:Subtract", Subtract_IsValid);
		SamplePoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SamplePoint");
		SamplePoint_ParamsSize = NativeReflection.GetFunctionParamsSize(SamplePoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SamplePoint_Transform_PropertyAddress, SamplePoint_FunctionAddress, "Transform");
		SamplePoint_Transform_Offset = NativeReflectionCached.GetPropertyOffset(SamplePoint_FunctionAddress, "Transform");
		SamplePoint_Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(SamplePoint_FunctionAddress, "Transform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SamplePoint_Bounds_PropertyAddress, SamplePoint_FunctionAddress, "Bounds");
		SamplePoint_Bounds_Offset = NativeReflectionCached.GetPropertyOffset(SamplePoint_FunctionAddress, "Bounds");
		SamplePoint_Bounds_IsValid = NativeReflectionCached.ValidatePropertyClass(SamplePoint_FunctionAddress, "Bounds", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SamplePoint_OutPoint_PropertyAddress, SamplePoint_FunctionAddress, "OutPoint");
		SamplePoint_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(SamplePoint_FunctionAddress, "OutPoint");
		SamplePoint_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(SamplePoint_FunctionAddress, "OutPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SamplePoint_OutMetadata_PropertyAddress, SamplePoint_FunctionAddress, "OutMetadata");
		SamplePoint_OutMetadata_Offset = NativeReflectionCached.GetPropertyOffset(SamplePoint_FunctionAddress, "OutMetadata");
		SamplePoint_OutMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(SamplePoint_FunctionAddress, "OutMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SamplePoint_ReturnValue_PropertyAddress, SamplePoint_FunctionAddress, "ReturnValue");
		SamplePoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SamplePoint_FunctionAddress, "ReturnValue");
		SamplePoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SamplePoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SamplePoint_IsValid = SamplePoint_FunctionAddress != IntPtr.Zero && SamplePoint_Transform_IsValid && SamplePoint_Bounds_IsValid && SamplePoint_OutPoint_IsValid && SamplePoint_OutMetadata_IsValid && SamplePoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:SamplePoint", SamplePoint_IsValid);
		ProjectPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProjectPoint");
		ProjectPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectPoint_InTransform_PropertyAddress, ProjectPoint_FunctionAddress, "InTransform");
		ProjectPoint_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPoint_FunctionAddress, "InTransform");
		ProjectPoint_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPoint_FunctionAddress, "InTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPoint_InBounds_PropertyAddress, ProjectPoint_FunctionAddress, "InBounds");
		ProjectPoint_InBounds_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPoint_FunctionAddress, "InBounds");
		ProjectPoint_InBounds_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPoint_FunctionAddress, "InBounds", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPoint_InParams_PropertyAddress, ProjectPoint_FunctionAddress, "InParams");
		ProjectPoint_InParams_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPoint_FunctionAddress, "InParams");
		ProjectPoint_InParams_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPoint_FunctionAddress, "InParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPoint_OutPoint_PropertyAddress, ProjectPoint_FunctionAddress, "OutPoint");
		ProjectPoint_OutPoint_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPoint_FunctionAddress, "OutPoint");
		ProjectPoint_OutPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPoint_FunctionAddress, "OutPoint", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPoint_OutMetadata_PropertyAddress, ProjectPoint_FunctionAddress, "OutMetadata");
		ProjectPoint_OutMetadata_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPoint_FunctionAddress, "OutMetadata");
		ProjectPoint_OutMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPoint_FunctionAddress, "OutMetadata", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectPoint_ReturnValue_PropertyAddress, ProjectPoint_FunctionAddress, "ReturnValue");
		ProjectPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectPoint_FunctionAddress, "ReturnValue");
		ProjectPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectPoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProjectPoint_IsValid = ProjectPoint_FunctionAddress != IntPtr.Zero && ProjectPoint_InTransform_IsValid && ProjectPoint_InBounds_IsValid && ProjectPoint_InParams_IsValid && ProjectPoint_OutPoint_IsValid && ProjectPoint_OutMetadata_IsValid && ProjectPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:ProjectPoint", ProjectPoint_IsValid);
		ProjectOn_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProjectOn");
		ProjectOn_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectOn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectOn_InOther_PropertyAddress, ProjectOn_FunctionAddress, "InOther");
		ProjectOn_InOther_Offset = NativeReflectionCached.GetPropertyOffset(ProjectOn_FunctionAddress, "InOther");
		ProjectOn_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectOn_FunctionAddress, "InOther", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectOn_InParams_PropertyAddress, ProjectOn_FunctionAddress, "InParams");
		ProjectOn_InParams_Offset = NativeReflectionCached.GetPropertyOffset(ProjectOn_FunctionAddress, "InParams");
		ProjectOn_InParams_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectOn_FunctionAddress, "InParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectOn_ReturnValue_PropertyAddress, ProjectOn_FunctionAddress, "ReturnValue");
		ProjectOn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ProjectOn_FunctionAddress, "ReturnValue");
		ProjectOn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectOn_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ProjectOn_IsValid = ProjectOn_FunctionAddress != IntPtr.Zero && ProjectOn_InOther_IsValid && ProjectOn_InParams_IsValid && ProjectOn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:ProjectOn", ProjectOn_IsValid);
		MutableMetadata_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MutableMetadata");
		MutableMetadata_ParamsSize = NativeReflection.GetFunctionParamsSize(MutableMetadata_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MutableMetadata_ReturnValue_PropertyAddress, MutableMetadata_FunctionAddress, "ReturnValue");
		MutableMetadata_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MutableMetadata_FunctionAddress, "ReturnValue");
		MutableMetadata_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MutableMetadata_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MutableMetadata_IsValid = MutableMetadata_FunctionAddress != IntPtr.Zero && MutableMetadata_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:MutableMetadata", MutableMetadata_IsValid);
		IntersectWith_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IntersectWith");
		IntersectWith_ParamsSize = NativeReflection.GetFunctionParamsSize(IntersectWith_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IntersectWith_InOther_PropertyAddress, IntersectWith_FunctionAddress, "InOther");
		IntersectWith_InOther_Offset = NativeReflectionCached.GetPropertyOffset(IntersectWith_FunctionAddress, "InOther");
		IntersectWith_InOther_IsValid = NativeReflectionCached.ValidatePropertyClass(IntersectWith_FunctionAddress, "InOther", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IntersectWith_ReturnValue_PropertyAddress, IntersectWith_FunctionAddress, "ReturnValue");
		IntersectWith_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IntersectWith_FunctionAddress, "ReturnValue");
		IntersectWith_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IntersectWith_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		IntersectWith_IsValid = IntersectWith_FunctionAddress != IntPtr.Zero && IntersectWith_InOther_IsValid && IntersectWith_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:IntersectWith", IntersectWith_IsValid);
		InitializeFromData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitializeFromData");
		InitializeFromData_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeFromData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InitializeFromData_InSource_PropertyAddress, InitializeFromData_FunctionAddress, "InSource");
		InitializeFromData_InSource_Offset = NativeReflectionCached.GetPropertyOffset(InitializeFromData_FunctionAddress, "InSource");
		InitializeFromData_InSource_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeFromData_FunctionAddress, "InSource", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeFromData_InMetadataParentOverride_PropertyAddress, InitializeFromData_FunctionAddress, "InMetadataParentOverride");
		InitializeFromData_InMetadataParentOverride_Offset = NativeReflectionCached.GetPropertyOffset(InitializeFromData_FunctionAddress, "InMetadataParentOverride");
		InitializeFromData_InMetadataParentOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeFromData_FunctionAddress, "InMetadataParentOverride", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeFromData_bInheritMetadata_PropertyAddress, InitializeFromData_FunctionAddress, "bInheritMetadata");
		InitializeFromData_bInheritMetadata_Offset = NativeReflectionCached.GetPropertyOffset(InitializeFromData_FunctionAddress, "bInheritMetadata");
		InitializeFromData_bInheritMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeFromData_FunctionAddress, "bInheritMetadata", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InitializeFromData_bInheritAttributes_PropertyAddress, InitializeFromData_FunctionAddress, "bInheritAttributes");
		InitializeFromData_bInheritAttributes_Offset = NativeReflectionCached.GetPropertyOffset(InitializeFromData_FunctionAddress, "bInheritAttributes");
		InitializeFromData_bInheritAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(InitializeFromData_FunctionAddress, "bInheritAttributes", Classes.FBoolProperty);
		InitializeFromData_IsValid = InitializeFromData_FunctionAddress != IntPtr.Zero && InitializeFromData_InSource_IsValid && InitializeFromData_InMetadataParentOverride_IsValid && InitializeFromData_bInheritMetadata_IsValid && InitializeFromData_bInheritAttributes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:InitializeFromData", InitializeFromData_IsValid);
		HasNonTrivialTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasNonTrivialTransform");
		HasNonTrivialTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(HasNonTrivialTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasNonTrivialTransform_ReturnValue_PropertyAddress, HasNonTrivialTransform_FunctionAddress, "ReturnValue");
		HasNonTrivialTransform_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasNonTrivialTransform_FunctionAddress, "ReturnValue");
		HasNonTrivialTransform_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasNonTrivialTransform_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasNonTrivialTransform_IsValid = HasNonTrivialTransform_FunctionAddress != IntPtr.Zero && HasNonTrivialTransform_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:HasNonTrivialTransform", HasNonTrivialTransform_IsValid);
		GetStrictBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetStrictBounds");
		GetStrictBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStrictBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStrictBounds_ReturnValue_PropertyAddress, GetStrictBounds_FunctionAddress, "ReturnValue");
		GetStrictBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStrictBounds_FunctionAddress, "ReturnValue");
		GetStrictBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStrictBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStrictBounds_IsValid = GetStrictBounds_FunctionAddress != IntPtr.Zero && GetStrictBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:GetStrictBounds", GetStrictBounds_IsValid);
		GetNormal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNormal");
		GetNormal_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNormal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNormal_ReturnValue_PropertyAddress, GetNormal_FunctionAddress, "ReturnValue");
		GetNormal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNormal_FunctionAddress, "ReturnValue");
		GetNormal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNormal_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetNormal_IsValid = GetNormal_FunctionAddress != IntPtr.Zero && GetNormal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:GetNormal", GetNormal_IsValid);
		GetDimension_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDimension");
		GetDimension_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDimension_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDimension_ReturnValue_PropertyAddress, GetDimension_FunctionAddress, "ReturnValue");
		GetDimension_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDimension_FunctionAddress, "ReturnValue");
		GetDimension_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDimension_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetDimension_IsValid = GetDimension_FunctionAddress != IntPtr.Zero && GetDimension_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:GetDimension", GetDimension_IsValid);
		GetDensityAtPosition_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDensityAtPosition");
		GetDensityAtPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDensityAtPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDensityAtPosition_InPosition_PropertyAddress, GetDensityAtPosition_FunctionAddress, "InPosition");
		GetDensityAtPosition_InPosition_Offset = NativeReflectionCached.GetPropertyOffset(GetDensityAtPosition_FunctionAddress, "InPosition");
		GetDensityAtPosition_InPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDensityAtPosition_FunctionAddress, "InPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDensityAtPosition_ReturnValue_PropertyAddress, GetDensityAtPosition_FunctionAddress, "ReturnValue");
		GetDensityAtPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDensityAtPosition_FunctionAddress, "ReturnValue");
		GetDensityAtPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDensityAtPosition_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDensityAtPosition_IsValid = GetDensityAtPosition_FunctionAddress != IntPtr.Zero && GetDensityAtPosition_InPosition_IsValid && GetDensityAtPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:GetDensityAtPosition", GetDensityAtPosition_IsValid);
		GetBounds_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetBounds");
		GetBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBounds_ReturnValue_PropertyAddress, GetBounds_FunctionAddress, "ReturnValue");
		GetBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBounds_FunctionAddress, "ReturnValue");
		GetBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetBounds_IsValid = GetBounds_FunctionAddress != IntPtr.Zero && GetBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:GetBounds", GetBounds_IsValid);
		ConstMetadata_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstMetadata");
		ConstMetadata_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstMetadata_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstMetadata_ReturnValue_PropertyAddress, ConstMetadata_FunctionAddress, "ReturnValue");
		ConstMetadata_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConstMetadata_FunctionAddress, "ReturnValue");
		ConstMetadata_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstMetadata_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ConstMetadata_IsValid = ConstMetadata_FunctionAddress != IntPtr.Zero && ConstMetadata_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGSpatialData:ConstMetadata", ConstMetadata_IsValid);
	}
}
