using System;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[USharpPath("/Script/b1-Managed.TestQueueData")]
public class TestQueueData : UObject
{
	public TestTargetUStruct CSharpT;

	private static bool NCs_IsValid;

	private static int NCs_Offset;

	private static FFieldAddress NCs_PropertyAddress;

	private TArrayReadWriteMarshaler<UNiagaraComponent> NCs_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TestQueueData:NCs")]
	public TArrayReadWrite<UNiagaraComponent> NCs
	{
		get
		{
			CheckDestroyed();
			if (!NCs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.TestQueueData:NCs");
				return null;
			}
			if (NCs_Marshaler == null)
			{
				NCs_Marshaler = new TArrayReadWriteMarshaler<UNiagaraComponent>(1, NCs_PropertyAddress, CachedMarshalingDelegates<UNiagaraComponent, UObjectMarshaler<UNiagaraComponent>>.FromNative, CachedMarshalingDelegates<UNiagaraComponent, UObjectMarshaler<UNiagaraComponent>>.ToNative);
			}
			return NCs_Marshaler.FromNative(IntPtr.Add(base.Address, NCs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.TestQueueData");
		NativeReflection.GetPropertyRef(ref NCs_PropertyAddress, unrealStruct, "NCs");
		NCs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NCs");
		NCs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NCs", Classes.FArrayProperty);
	}

	static TestQueueData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TestQueueData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TestQueueData));
	}
}
