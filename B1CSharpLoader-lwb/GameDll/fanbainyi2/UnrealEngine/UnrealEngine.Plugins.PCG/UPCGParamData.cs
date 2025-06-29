using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGParamData", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGParamData : UPCGData
{
	private static bool MutableMetadata_IsValid;

	private static IntPtr MutableMetadata_FunctionAddress;

	private static int MutableMetadata_ParamsSize;

	private static bool MutableMetadata_ReturnValue_IsValid;

	private static FFieldAddress MutableMetadata_ReturnValue_PropertyAddress;

	private static int MutableMetadata_ReturnValue_Offset;

	private static bool FindOrAddMetadataKey_IsValid;

	private static IntPtr FindOrAddMetadataKey_FunctionAddress;

	private static int FindOrAddMetadataKey_ParamsSize;

	private static bool FindOrAddMetadataKey_InName_IsValid;

	private static FFieldAddress FindOrAddMetadataKey_InName_PropertyAddress;

	private static int FindOrAddMetadataKey_InName_Offset;

	private static bool FindOrAddMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress FindOrAddMetadataKey_ReturnValue_PropertyAddress;

	private static int FindOrAddMetadataKey_ReturnValue_Offset;

	private static bool FindMetadataKey_IsValid;

	private static IntPtr FindMetadataKey_FunctionAddress;

	private static int FindMetadataKey_ParamsSize;

	private static bool FindMetadataKey_InName_IsValid;

	private static FFieldAddress FindMetadataKey_InName_PropertyAddress;

	private static int FindMetadataKey_InName_Offset;

	private static bool FindMetadataKey_ReturnValue_IsValid;

	private static FFieldAddress FindMetadataKey_ReturnValue_PropertyAddress;

	private static int FindMetadataKey_ReturnValue_Offset;

	private static bool FilterParamsByName_IsValid;

	private static IntPtr FilterParamsByName_FunctionAddress;

	private static int FilterParamsByName_ParamsSize;

	private static bool FilterParamsByName_InName_IsValid;

	private static FFieldAddress FilterParamsByName_InName_PropertyAddress;

	private static int FilterParamsByName_InName_Offset;

	private static bool FilterParamsByName_ReturnValue_IsValid;

	private static FFieldAddress FilterParamsByName_ReturnValue_PropertyAddress;

	private static int FilterParamsByName_ReturnValue_Offset;

	private static bool FilterParamsByKey_IsValid;

	private static IntPtr FilterParamsByKey_FunctionAddress;

	private static int FilterParamsByKey_ParamsSize;

	private static bool FilterParamsByKey_InKey_IsValid;

	private static FFieldAddress FilterParamsByKey_InKey_PropertyAddress;

	private static int FilterParamsByKey_InKey_Offset;

	private static bool FilterParamsByKey_ReturnValue_IsValid;

	private static FFieldAddress FilterParamsByKey_ReturnValue_PropertyAddress;

	private static int FilterParamsByKey_ReturnValue_Offset;

	private static bool ConstMetadata_IsValid;

	private static IntPtr ConstMetadata_FunctionAddress;

	private static int ConstMetadata_ParamsSize;

	private static bool ConstMetadata_ReturnValue_IsValid;

	private static FFieldAddress ConstMetadata_ReturnValue_PropertyAddress;

	private static int ConstMetadata_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/PCG.PCGParamData:MutableMetadata")]
	public unsafe UPCGMetadata MutableMetadata()
	{
		CheckDestroyed();
		if (!MutableMetadata_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGParamData:MutableMetadata");
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

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/PCG.PCGParamData:FindOrAddMetadataKey")]
	public unsafe long FindOrAddMetadataKey(FName InName)
	{
		CheckDestroyed();
		if (!FindOrAddMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGParamData:FindOrAddMetadataKey");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindOrAddMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindOrAddMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindOrAddMetadataKey_InName_Offset), 0, FindOrAddMetadataKey_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindOrAddMetadataKey_FunctionAddress, intPtr, FindOrAddMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, FindOrAddMetadataKey_ReturnValue_Offset), 0, FindOrAddMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGParamData:FindMetadataKey")]
	public unsafe long FindMetadataKey(FName InName)
	{
		CheckDestroyed();
		if (!FindMetadataKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGParamData:FindMetadataKey");
			return 0L;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindMetadataKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindMetadataKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FindMetadataKey_InName_Offset), 0, FindMetadataKey_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindMetadataKey_FunctionAddress, intPtr, FindMetadataKey_ParamsSize);
		return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, FindMetadataKey_ReturnValue_Offset), 0, FindMetadataKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/PCG.PCGParamData:FilterParamsByName")]
	public unsafe UPCGParamData FilterParamsByName(FName InName)
	{
		CheckDestroyed();
		if (!FilterParamsByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGParamData:FilterParamsByName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterParamsByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterParamsByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, FilterParamsByName_InName_Offset), 0, FilterParamsByName_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeFunctionOptimized(base.Address, FilterParamsByName_FunctionAddress, intPtr, FilterParamsByName_ParamsSize);
		return UObjectMarshaler<UPCGParamData>.FromNative(IntPtr.Add(intPtr, FilterParamsByName_ReturnValue_Offset), 0, FilterParamsByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGParamData:FilterParamsByKey")]
	public unsafe UPCGParamData FilterParamsByKey(long InKey)
	{
		CheckDestroyed();
		if (!FilterParamsByKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGParamData:FilterParamsByKey");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterParamsByKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterParamsByKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, FilterParamsByKey_InKey_Offset), 0, FilterParamsByKey_InKey_PropertyAddress.Address, InKey);
		NativeReflection.InvokeFunctionOptimized(base.Address, FilterParamsByKey_FunctionAddress, intPtr, FilterParamsByKey_ParamsSize);
		return UObjectMarshaler<UPCGParamData>.FromNative(IntPtr.Add(intPtr, FilterParamsByKey_ReturnValue_Offset), 0, FilterParamsByKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/PCG.PCGParamData:ConstMetadata")]
	public unsafe UPCGMetadata ConstMetadata()
	{
		CheckDestroyed();
		if (!ConstMetadata_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/PCG.PCGParamData:ConstMetadata");
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

	static UPCGParamData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGParamData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGParamData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/PCG.PCGParamData");
		MutableMetadata_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "MutableMetadata");
		MutableMetadata_ParamsSize = NativeReflection.GetFunctionParamsSize(MutableMetadata_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MutableMetadata_ReturnValue_PropertyAddress, MutableMetadata_FunctionAddress, "ReturnValue");
		MutableMetadata_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MutableMetadata_FunctionAddress, "ReturnValue");
		MutableMetadata_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MutableMetadata_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		MutableMetadata_IsValid = MutableMetadata_FunctionAddress != IntPtr.Zero && MutableMetadata_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGParamData:MutableMetadata", MutableMetadata_IsValid);
		FindOrAddMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindOrAddMetadataKey");
		FindOrAddMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(FindOrAddMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddMetadataKey_InName_PropertyAddress, FindOrAddMetadataKey_FunctionAddress, "InName");
		FindOrAddMetadataKey_InName_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddMetadataKey_FunctionAddress, "InName");
		FindOrAddMetadataKey_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddMetadataKey_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddMetadataKey_ReturnValue_PropertyAddress, FindOrAddMetadataKey_FunctionAddress, "ReturnValue");
		FindOrAddMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddMetadataKey_FunctionAddress, "ReturnValue");
		FindOrAddMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddMetadataKey_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		FindOrAddMetadataKey_IsValid = FindOrAddMetadataKey_FunctionAddress != IntPtr.Zero && FindOrAddMetadataKey_InName_IsValid && FindOrAddMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGParamData:FindOrAddMetadataKey", FindOrAddMetadataKey_IsValid);
		FindMetadataKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindMetadataKey");
		FindMetadataKey_ParamsSize = NativeReflection.GetFunctionParamsSize(FindMetadataKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindMetadataKey_InName_PropertyAddress, FindMetadataKey_FunctionAddress, "InName");
		FindMetadataKey_InName_Offset = NativeReflectionCached.GetPropertyOffset(FindMetadataKey_FunctionAddress, "InName");
		FindMetadataKey_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMetadataKey_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FindMetadataKey_ReturnValue_PropertyAddress, FindMetadataKey_FunctionAddress, "ReturnValue");
		FindMetadataKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindMetadataKey_FunctionAddress, "ReturnValue");
		FindMetadataKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindMetadataKey_FunctionAddress, "ReturnValue", Classes.FInt64Property);
		FindMetadataKey_IsValid = FindMetadataKey_FunctionAddress != IntPtr.Zero && FindMetadataKey_InName_IsValid && FindMetadataKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGParamData:FindMetadataKey", FindMetadataKey_IsValid);
		FilterParamsByName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FilterParamsByName");
		FilterParamsByName_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterParamsByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterParamsByName_InName_PropertyAddress, FilterParamsByName_FunctionAddress, "InName");
		FilterParamsByName_InName_Offset = NativeReflectionCached.GetPropertyOffset(FilterParamsByName_FunctionAddress, "InName");
		FilterParamsByName_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterParamsByName_FunctionAddress, "InName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterParamsByName_ReturnValue_PropertyAddress, FilterParamsByName_FunctionAddress, "ReturnValue");
		FilterParamsByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterParamsByName_FunctionAddress, "ReturnValue");
		FilterParamsByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterParamsByName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FilterParamsByName_IsValid = FilterParamsByName_FunctionAddress != IntPtr.Zero && FilterParamsByName_InName_IsValid && FilterParamsByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGParamData:FilterParamsByName", FilterParamsByName_IsValid);
		FilterParamsByKey_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FilterParamsByKey");
		FilterParamsByKey_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterParamsByKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterParamsByKey_InKey_PropertyAddress, FilterParamsByKey_FunctionAddress, "InKey");
		FilterParamsByKey_InKey_Offset = NativeReflectionCached.GetPropertyOffset(FilterParamsByKey_FunctionAddress, "InKey");
		FilterParamsByKey_InKey_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterParamsByKey_FunctionAddress, "InKey", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref FilterParamsByKey_ReturnValue_PropertyAddress, FilterParamsByKey_FunctionAddress, "ReturnValue");
		FilterParamsByKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterParamsByKey_FunctionAddress, "ReturnValue");
		FilterParamsByKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterParamsByKey_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FilterParamsByKey_IsValid = FilterParamsByKey_FunctionAddress != IntPtr.Zero && FilterParamsByKey_InKey_IsValid && FilterParamsByKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGParamData:FilterParamsByKey", FilterParamsByKey_IsValid);
		ConstMetadata_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ConstMetadata");
		ConstMetadata_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstMetadata_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstMetadata_ReturnValue_PropertyAddress, ConstMetadata_FunctionAddress, "ReturnValue");
		ConstMetadata_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConstMetadata_FunctionAddress, "ReturnValue");
		ConstMetadata_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstMetadata_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ConstMetadata_IsValid = ConstMetadata_FunctionAddress != IntPtr.Zero && ConstMetadata_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/PCG.PCGParamData:ConstMetadata", ConstMetadata_IsValid);
	}
}
