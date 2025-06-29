using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGIntersectionData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGIntersectionData : UPCGSpatialDataWithPointCache
{
	private static bool DensityFunction_IsValid;

	private static FFieldAddress DensityFunction_PropertyAddress;

	private static int DensityFunction_Offset;

	private static bool A_IsValid;

	private static int A_Offset;

	private static bool B_IsValid;

	private static int B_Offset;

	private static bool Initialize_IsValid;

	private static IntPtr Initialize_FunctionAddress;

	private static int Initialize_ParamsSize;

	private static bool Initialize_InA_IsValid;

	private static FFieldAddress Initialize_InA_PropertyAddress;

	private static int Initialize_InA_Offset;

	private static bool Initialize_InB_IsValid;

	private static FFieldAddress Initialize_InB_PropertyAddress;

	private static int Initialize_InB_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGIntersectionData:DensityFunction")]
	public EPCGIntersectionDensityFunction DensityFunction
	{
		get
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGIntersectionData:DensityFunction");
				return EPCGIntersectionDensityFunction.Multiply;
			}
			return EnumMarshaler<EPCGIntersectionDensityFunction>.FromNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DensityFunction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGIntersectionData:DensityFunction");
			}
			else
			{
				EnumMarshaler<EPCGIntersectionDensityFunction>.ToNative(IntPtr.Add(base.Address, DensityFunction_Offset), 0, DensityFunction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/PCG.PCGIntersectionData:A")]
	public UPCGSpatialData A
	{
		get
		{
			CheckDestroyed();
			if (!A_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGIntersectionData:A");
				return null;
			}
			return UObjectMarshaler<UPCGSpatialData>.FromNative(IntPtr.Add(base.Address, A_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!A_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGIntersectionData:A");
			}
			else
			{
				UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(base.Address, A_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/PCG.PCGIntersectionData:B")]
	public UPCGSpatialData B
	{
		get
		{
			CheckDestroyed();
			if (!B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGIntersectionData:B");
				return null;
			}
			return UObjectMarshaler<UPCGSpatialData>.FromNative(IntPtr.Add(base.Address, B_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!B_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGIntersectionData:B");
			}
			else
			{
				UObjectMarshaler<UPCGSpatialData>.ToNative(IntPtr.Add(base.Address, B_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGIntersectionData:Initialize")]
	public unsafe void Initialize(UPCGSpatialData InA, UPCGSpatialData InB)
	{
		CheckDestroyed();
		if (!Initialize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGIntersectionData:Initialize");
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

	static UPCGIntersectionData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGIntersectionData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGIntersectionData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/PCG.PCGIntersectionData");
		NativeReflectionCached.GetPropertyRef(ref DensityFunction_PropertyAddress, intPtr, "DensityFunction");
		DensityFunction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DensityFunction");
		DensityFunction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DensityFunction", Classes.FEnumProperty);
		A_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "A");
		A_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "A", Classes.FObjectProperty);
		B_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "B");
		B_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "B", Classes.FObjectProperty);
		Initialize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Initialize");
		Initialize_ParamsSize = NativeReflection.GetFunctionParamsSize(Initialize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InA_PropertyAddress, Initialize_FunctionAddress, "InA");
		Initialize_InA_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InA");
		Initialize_InA_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InA", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Initialize_InB_PropertyAddress, Initialize_FunctionAddress, "InB");
		Initialize_InB_Offset = NativeReflectionCached.GetPropertyOffset(Initialize_FunctionAddress, "InB");
		Initialize_InB_IsValid = NativeReflectionCached.ValidatePropertyClass(Initialize_FunctionAddress, "InB", Classes.FObjectProperty);
		Initialize_IsValid = Initialize_FunctionAddress != IntPtr.Zero && Initialize_InA_IsValid && Initialize_InB_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGIntersectionData:Initialize", Initialize_IsValid);
	}
}
