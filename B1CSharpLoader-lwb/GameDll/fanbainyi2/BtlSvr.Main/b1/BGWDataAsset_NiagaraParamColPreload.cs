using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_NiagaraParamColPreload")]
public class BGWDataAsset_NiagaraParamColPreload : UBGWDataAsset
{
	private static bool Paths_IsValid;

	private static int Paths_Offset;

	private static FFieldAddress Paths_PropertyAddress;

	private TArrayReadWriteMarshaler<string> Paths_Marshaler;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_NiagaraParamColPreload:Paths")]
	public TArrayReadWrite<string> Paths
	{
		get
		{
			CheckDestroyed();
			if (!Paths_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_NiagaraParamColPreload:Paths");
				return null;
			}
			if (Paths_Marshaler == null)
			{
				Paths_Marshaler = new TArrayReadWriteMarshaler<string>(1, Paths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return Paths_Marshaler.FromNative(IntPtr.Add(base.Address, Paths_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_NiagaraParamColPreload");
		NativeReflection.GetPropertyRef(ref Paths_PropertyAddress, unrealStruct, "Paths");
		Paths_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Paths");
		Paths_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Paths", Classes.FArrayProperty);
	}

	static BGWDataAsset_NiagaraParamColPreload()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_NiagaraParamColPreload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_NiagaraParamColPreload));
	}
}
