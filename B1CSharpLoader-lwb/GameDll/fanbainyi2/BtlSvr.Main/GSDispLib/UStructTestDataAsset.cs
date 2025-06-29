using System;
using b1;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.StructTestDataAsset")]
public class UStructTestDataAsset : UBGWDataAsset
{
	private static bool TestStructs_IsValid;

	private static int TestStructs_Offset;

	private static FFieldAddress TestStructs_PropertyAddress;

	private TArrayReadWriteMarshaler<DBCTestStruct> TestStructs_Marshaler;

	private static bool NiagaraSystems_IsValid;

	private static int NiagaraSystems_Offset;

	private static FFieldAddress NiagaraSystems_PropertyAddress;

	private TArrayReadWriteMarshaler<UNiagaraSystem> NiagaraSystems_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("UStructs")]
	[USharpPath("/Script/b1-Managed.StructTestDataAsset:TestStructs")]
	public TArrayReadWrite<DBCTestStruct> TestStructs
	{
		get
		{
			CheckDestroyed();
			if (!TestStructs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructTestDataAsset:TestStructs");
				return null;
			}
			if (TestStructs_Marshaler == null)
			{
				TestStructs_Marshaler = new TArrayReadWriteMarshaler<DBCTestStruct>(1, TestStructs_PropertyAddress, CachedMarshalingDelegates<DBCTestStruct, DBCTestStruct>.FromNative, CachedMarshalingDelegates<DBCTestStruct, DBCTestStruct>.ToNative);
			}
			return TestStructs_Marshaler.FromNative(IntPtr.Add(base.Address, TestStructs_Offset));
		}
	}

	[DisplayName("NiagaraSystems")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.StructTestDataAsset:NiagaraSystems")]
	public TArrayReadWrite<UNiagaraSystem> NiagaraSystems
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraSystems_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.StructTestDataAsset:NiagaraSystems");
				return null;
			}
			if (NiagaraSystems_Marshaler == null)
			{
				NiagaraSystems_Marshaler = new TArrayReadWriteMarshaler<UNiagaraSystem>(1, NiagaraSystems_PropertyAddress, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.FromNative, CachedMarshalingDelegates<UNiagaraSystem, UObjectMarshaler<UNiagaraSystem>>.ToNative);
			}
			return NiagaraSystems_Marshaler.FromNative(IntPtr.Add(base.Address, NiagaraSystems_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.StructTestDataAsset");
		NativeReflection.GetPropertyRef(ref TestStructs_PropertyAddress, unrealStruct, "TestStructs");
		TestStructs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TestStructs");
		TestStructs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TestStructs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref NiagaraSystems_PropertyAddress, unrealStruct, "NiagaraSystems");
		NiagaraSystems_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NiagaraSystems");
		NiagaraSystems_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NiagaraSystems", Classes.FArrayProperty);
	}

	static UStructTestDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UStructTestDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStructTestDataAsset));
	}
}
