using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDifferenceData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGDifferenceData : UPCGSpatialDataWithPointCache
{
	private static bool DiffMetadata_IsValid;

	private static FFieldAddress DiffMetadata_PropertyAddress;

	private static int DiffMetadata_Offset;

	private static bool Source_IsValid;

	private static int Source_Offset;

	private static bool Difference_IsValid;

	private static int Difference_Offset;

	private static bool DensityFunction_IsValid;

	private static FFieldAddress DensityFunction_PropertyAddress;

	private static int DensityFunction_Offset;

	private static bool SetDensityFunction_IsValid;

	private static IntPtr SetDensityFunction_FunctionAddress;

	private static int SetDensityFunction_ParamsSize;

	private static bool SetDensityFunction_InDensityFunction_IsValid;

	private static FFieldAddress SetDensityFunction_InDensityFunction_PropertyAddress;

	private static int SetDensityFunction_InDensityFunction_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InData_IsValid;

	private static FFieldAddress Initialize_InData_PropertyAddress;

	private static int Initialize_InData_Offset;

	private static bool AddDifference_IsValid;

	private static IntPtr AddDifference_FunctionAddress;

	private static int AddDifference_ParamsSize;

	private static bool AddDifference_InDifference_IsValid;

	private static FFieldAddress AddDifference_InDifference_PropertyAddress;

	private static int AddDifference_InDifference_Offset;

	[UProperty(Flags = (PropFlags)6755469234405909uL)]
	[UMetaPath("/Script/PCG.PCGDifferenceData:bDiffMetadata")]
	public bool DiffMetadata
	{
		get
		{
			CheckDestroyed();
			if (!DiffMetadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceData:bDiffMetadata");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DiffMetadata_Offset), 0, DiffMetadata_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DiffMetadata_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceData:bDiffMetadata");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DiffMetadata_Offset), 0, DiffMetadata_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861641237uL)]
	[UMetaPath("/Script/PCG.PCGDifferenceData:Source")]
	protected UPCGSpatialData Source
	{
		get
		{
			CheckDestroyed();
			if (!Source_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceData:Source");
				return null;
			}
			return UObjectMarshaler<UPCGSpatialData>.FromNative(IntPtr.Add(base.Address, Source_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Source_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceData:Source");
			}
			else
			{
				UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(base.Address, Source_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861641237uL)]
	[UMetaPath("/Script/PCG.PCGDifferenceData:Difference")]
	protected UPCGSpatialData Difference
	{
		get
		{
			CheckDestroyed();
			if (!Difference_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceData:Difference");
				return null;
			}
			return UObjectMarshaler<UPCGSpatialData>.FromNative(IntPtr.Add(base.Address, Difference_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Difference_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceData:Difference");
			}
			else
			{
				UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(base.Address, Difference_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/PCG.PCGDifferenceData:DensityFunction")]
	protected EPCGDifferenceDensityFunction DensityFunction
	{
		get
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceData:DensityFunction");
				return EPCGDifferenceDensityFunction.Minimum;
			}
			return EnumMarshaler<EPCGDifferenceDensityFunction>.FromNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGDifferenceData:DensityFunction");
			}
			else
			{
				EnumMarshaler<EPCGDifferenceDensityFunction>.ToNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGDifferenceData:SetDensityFunction")]
	public unsafe void SetDensityFunction(EPCGDifferenceDensityFunction InDensityFunction)
	{
		CheckDestroyed();
		if (!SetDensityFunction_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDifferenceData:SetDensityFunction");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDensityFunction_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDensityFunction_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EPCGDifferenceDensityFunction>.ToNative(IntPtr.Add(intPtr, SetDensityFunction_InDensityFunction_Offset), 0, SetDensityFunction_InDensityFunction_PropertyAddress.Address, InDensityFunction);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDensityFunction_FunctionAddress, intPtr, SetDensityFunction_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGDifferenceData:Initialize")]
	public unsafe void Initialize(UPCGSpatialData InData)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDifferenceData:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, Initialize_InData_Offset), 0, Initialize_InData_PropertyAddress.Address, InData);
		NativeReflection.InvokeFunctionOptimized(base.Address, Initialize_FunctionAddress, intPtr, Initialize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGDifferenceData:AddDifference")]
	public unsafe void AddDifference(UPCGSpatialData InDifference)
	{
		CheckDestroyed();
		if (!AddDifference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGDifferenceData:AddDifference");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddDifference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddDifference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, AddDifference_InDifference_Offset), 0, AddDifference_InDifference_PropertyAddress.Address, InDifference);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddDifference_FunctionAddress, intPtr, AddDifference_ParamsSize);
	}

	static UPCGDifferenceData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGDifferenceData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGDifferenceData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGDifferenceData");
		NativeReflectionCached.GetPropertyRef(ref DiffMetadata_PropertyAddress, intPtr, "bDiffMetadata");
		DiffMetadata_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDiffMetadata");
		DiffMetadata_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDiffMetadata", Classes.FBoolProperty);
		Source_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Source");
		Source_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Source", Classes.FObjectProperty);
		Difference_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Difference");
		Difference_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Difference", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DensityFunction_PropertyAddress, intPtr, "DensityFunction");
		DensityFunction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityFunction");
		DensityFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityFunction", Classes.FEnumProperty);
		SetDensityFunction_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDensityFunction");
		SetDensityFunction_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDensityFunction_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDensityFunction_InDensityFunction_PropertyAddress, SetDensityFunction_FunctionAddress, "InDensityFunction");
		SetDensityFunction_InDensityFunction_Offset = NativeReflectionCached.GetPropertyOffset(SetDensityFunction_FunctionAddress, "InDensityFunction");
		SetDensityFunction_InDensityFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDensityFunction_FunctionAddress, "InDensityFunction", Classes.FEnumProperty);
		SetDensityFunction_IsValid = SetDensityFunction_FunctionAddress != IntPtr.Zero && SetDensityFunction_InDensityFunction_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDifferenceData:SetDensityFunction", SetDensityFunction_IsValid);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InData_PropertyAddress, Initialize_FunctionAddress, "InData");
		Initialize_InData_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InData");
		Initialize_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InData", Classes.FObjectProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDifferenceData:Initialize", Initialize_IsValid);
		AddDifference_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddDifference");
		AddDifference_ParamsSize = NativeReflection.GetFunctionParamsSize(AddDifference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddDifference_InDifference_PropertyAddress, AddDifference_FunctionAddress, "InDifference");
		AddDifference_InDifference_Offset = NativeReflectionCached.GetPropertyOffset(AddDifference_FunctionAddress, "InDifference");
		AddDifference_InDifference_IsValid = NativeReflectionCached.ValidatePropertyClass(AddDifference_FunctionAddress, "InDifference", Classes.FObjectProperty);
		AddDifference_IsValid = AddDifference_FunctionAddress != IntPtr.Zero && AddDifference_InDifference_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGDifferenceData:AddDifference", AddDifference_IsValid);
	}
}
