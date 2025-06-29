using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGUnionData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGUnionData : UPCGSpatialDataWithPointCache
{
	private static bool Data_IsValid;

	private static FFieldAddress Data_PropertyAddress;

	private static int Data_Offset;

	private TArrayReadOnlyMarshaler<UPCGSpatialData> Data_MarshalerCached;

	private static bool UnionType_IsValid;

	private static FFieldAddress UnionType_PropertyAddress;

	private static int UnionType_Offset;

	private static bool DensityFunction_IsValid;

	private static FFieldAddress DensityFunction_PropertyAddress;

	private static int DensityFunction_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InA_IsValid;

	private static FFieldAddress Initialize_InA_PropertyAddress;

	private static int Initialize_InA_Offset;

	private static bool Initialize_InB_IsValid;

	private static FFieldAddress Initialize_InB_PropertyAddress;

	private static int Initialize_InB_Offset;

	private static bool AddData_IsValid;

	private static IntPtr AddData_FunctionAddress;

	private static int AddData_ParamsSize;

	private static bool AddData_InData_IsValid;

	private static FFieldAddress AddData_InData_PropertyAddress;

	private static int AddData_InData_Offset;

	[UProperty(Flags = (PropFlags)10141895254737429uL)]
	[UMetaPath("/Script/PCG.PCGUnionData:Data")]
	protected TArrayReadOnly<UPCGSpatialData> Data
	{
		get
		{
			CheckDestroyed();
			if (!Data_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionData:Data");
				return null;
			}
			if (Data_MarshalerCached == null)
			{
				Data_MarshalerCached = new TArrayReadOnlyMarshaler<UPCGSpatialData>(1, Data_PropertyAddress, CachedMarshalingDelegates<UPCGSpatialData, UObjectMarshaler<UPCGSpatialData>>.FromNative, CachedMarshalingDelegates<UPCGSpatialData, UObjectMarshaler<UPCGSpatialData>>.ToNative);
			}
			return Data_MarshalerCached.FromNative(IntPtr.Add(base.Address, Data_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/PCG.PCGUnionData:UnionType")]
	protected EPCGUnionType UnionType
	{
		get
		{
			CheckDestroyed();
			if (!UnionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionData:UnionType");
				return EPCGUnionType.LeftToRightPriority;
			}
			return EnumMarshaler<EPCGUnionType>.FromNative(IntPtr.Add(base.Address, UnionType_Offset), 0, UnionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UnionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionData:UnionType");
			}
			else
			{
				EnumMarshaler<EPCGUnionType>.ToNative(IntPtr.Add(base.Address, UnionType_Offset), 0, UnionType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667525uL)]
	[UMetaPath("/Script/PCG.PCGUnionData:DensityFunction")]
	protected EPCGUnionDensityFunction DensityFunction
	{
		get
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionData:DensityFunction");
				return EPCGUnionDensityFunction.Maximum;
			}
			return EnumMarshaler<EPCGUnionDensityFunction>.FromNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGUnionData:DensityFunction");
			}
			else
			{
				EnumMarshaler<EPCGUnionDensityFunction>.ToNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGUnionData:Initialize")]
	public unsafe void Initialize(UPCGSpatialData InA, UPCGSpatialData InB)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGUnionData:Initialize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Initialize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Initialize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, Initialize_InA_Offset), 0, Initialize_InA_PropertyAddress.Address, InA);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, Initialize_InB_Offset), 0, Initialize_InB_PropertyAddress.Address, InB);
		NativeReflection.InvokeFunctionOptimized(base.Address, Initialize_FunctionAddress, intPtr, Initialize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGUnionData:AddData")]
	public unsafe void AddData(UPCGSpatialData InData)
	{
		CheckDestroyed();
		if (!AddData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGUnionData:AddData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(intPtr, AddData_InData_Offset), 0, AddData_InData_PropertyAddress.Address, InData);
		NativeReflection.InvokeFunctionOptimized(base.Address, AddData_FunctionAddress, intPtr, AddData_ParamsSize);
	}

	static UPCGUnionData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGUnionData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGUnionData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGUnionData");
		NativeReflectionCached.GetPropertyRef(ref Data_PropertyAddress, intPtr, "Data");
		Data_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Data");
		Data_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Data", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UnionType_PropertyAddress, intPtr, "UnionType");
		UnionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnionType");
		UnionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnionType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref DensityFunction_PropertyAddress, intPtr, "DensityFunction");
		DensityFunction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityFunction");
		DensityFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityFunction", Classes.FEnumProperty);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InA_PropertyAddress, Initialize_FunctionAddress, "InA");
		Initialize_InA_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InA");
		Initialize_InA_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InB_PropertyAddress, Initialize_FunctionAddress, "InB");
		Initialize_InB_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InB");
		Initialize_InB_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InB", Classes.FObjectProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InA_IsValid && Initialize_InB_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGUnionData:Initialize", Initialize_IsValid);
		AddData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddData");
		AddData_ParamsSize = NativeReflection.GetFunctionParamsSize(AddData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddData_InData_PropertyAddress, AddData_FunctionAddress, "InData");
		AddData_InData_Offset = NativeReflectionCached.GetPropertyOffset(AddData_FunctionAddress, "InData");
		AddData_InData_IsValid = NativeReflectionCached.ValidatePropertyClass(AddData_FunctionAddress, "InData", Classes.FObjectProperty);
		AddData_IsValid = AddData_FunctionAddress != IntPtr.Zero && AddData_InData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGUnionData:AddData", AddData_IsValid);
	}
}
