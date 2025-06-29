using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Calliope.CalliopeParameterMappingDataAsset", "Calliope", UnrealModuleType.GamePlugin)]
public class UCalliopeParameterMappingDataAsset : UPrimaryDataAsset
{
	private static bool MappedAsset_IsValid;

	private static int MappedAsset_Offset;

	private static bool RunTemplateInstance_IsValid;

	private static FFieldAddress RunTemplateInstance_PropertyAddress;

	private static int RunTemplateInstance_Offset;

	private static bool Groups_IsValid;

	private static FFieldAddress Groups_PropertyAddress;

	private static int Groups_Offset;

	private TArrayReadWriteMarshaler<FCalliopeParameterMappingGroup> Groups_MarshalerCached;

	private static bool RefreshGroupsParameterValue_IsValid;

	private static IntPtr RefreshGroupsParameterValue_FunctionAddress;

	private static int RefreshGroupsParameterValue_ParamsSize;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMappingDataAsset:MappedAsset")]
	public TSoftObject<UCalliopeAsset> MappedAsset
	{
		get
		{
			CheckDestroyed();
			if (!MappedAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeParameterMappingDataAsset:MappedAsset");
				return default(TSoftObject<UCalliopeAsset>);
			}
			return TSoftObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(base.Address, MappedAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MappedAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeParameterMappingDataAsset:MappedAsset");
			}
			else
			{
				TSoftObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(base.Address, MappedAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMappingDataAsset:bRunTemplateInstance")]
	public bool RunTemplateInstance
	{
		get
		{
			CheckDestroyed();
			if (!RunTemplateInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeParameterMappingDataAsset:bRunTemplateInstance");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RunTemplateInstance_Offset), 0, RunTemplateInstance_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RunTemplateInstance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeParameterMappingDataAsset:bRunTemplateInstance");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RunTemplateInstance_Offset), 0, RunTemplateInstance_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMappingDataAsset:Groups")]
	public TArrayReadWrite<FCalliopeParameterMappingGroup> Groups
	{
		get
		{
			CheckDestroyed();
			if (!Groups_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Calliope.CalliopeParameterMappingDataAsset:Groups");
				return null;
			}
			if (Groups_MarshalerCached == null)
			{
				Groups_MarshalerCached = new TArrayReadWriteMarshaler<FCalliopeParameterMappingGroup>(1, Groups_PropertyAddress, CachedMarshalingDelegates<FCalliopeParameterMappingGroup, FCalliopeParameterMappingGroup>.FromNative, CachedMarshalingDelegates<FCalliopeParameterMappingGroup, FCalliopeParameterMappingGroup>.ToNative);
			}
			return Groups_MarshalerCached.FromNative(IntPtr.Add(base.Address, Groups_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Calliope.CalliopeParameterMappingDataAsset:RefreshGroupsParameterValue")]
	public unsafe void RefreshGroupsParameterValue()
	{
		CheckDestroyed();
		if (!RefreshGroupsParameterValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeParameterMappingDataAsset:RefreshGroupsParameterValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RefreshGroupsParameterValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RefreshGroupsParameterValue_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RefreshGroupsParameterValue_FunctionAddress, argsSize: RefreshGroupsParameterValue_ParamsSize);
	}

	static UCalliopeParameterMappingDataAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeParameterMappingDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeParameterMappingDataAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Calliope.CalliopeParameterMappingDataAsset");
		MappedAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MappedAsset");
		MappedAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MappedAsset", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RunTemplateInstance_PropertyAddress, intPtr, "bRunTemplateInstance");
		RunTemplateInstance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRunTemplateInstance");
		RunTemplateInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRunTemplateInstance", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Groups_PropertyAddress, intPtr, "Groups");
		Groups_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Groups");
		Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Groups", Classes.FArrayProperty);
		RefreshGroupsParameterValue_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RefreshGroupsParameterValue");
		RefreshGroupsParameterValue_ParamsSize = NativeReflection.GetFunctionParamsSize(RefreshGroupsParameterValue_FunctionAddress);
		RefreshGroupsParameterValue_IsValid = RefreshGroupsParameterValue_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeParameterMappingDataAsset:RefreshGroupsParameterValue", RefreshGroupsParameterValue_IsValid);
	}
}
