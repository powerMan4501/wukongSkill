using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ProcessGraphEditComp")]
public class BUS_ProcessGraphEditComp : UActorEditCompBase
{
	private static bool ProcessAssets_IsValid;

	private static int ProcessAssets_Offset;

	private static FFieldAddress ProcessAssets_PropertyAddress;

	private TArrayReadWriteMarshaler<UCalliopeAsset> ProcessAssets_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Process")]
	[DisplayName("物件的CPG图列表")]
	[USharpPath("/Script/b1-Managed.BUS_ProcessGraphEditComp:ProcessAssets")]
	public TArrayReadWrite<UCalliopeAsset> ProcessAssets
	{
		get
		{
			CheckDestroyed();
			if (!ProcessAssets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ProcessGraphEditComp:ProcessAssets");
				return null;
			}
			if (ProcessAssets_Marshaler == null)
			{
				ProcessAssets_Marshaler = new TArrayReadWriteMarshaler<UCalliopeAsset>(1, ProcessAssets_PropertyAddress, CachedMarshalingDelegates<UCalliopeAsset, UObjectMarshaler<UCalliopeAsset>>.FromNative, CachedMarshalingDelegates<UCalliopeAsset, UObjectMarshaler<UCalliopeAsset>>.ToNative);
			}
			return ProcessAssets_Marshaler.FromNative(IntPtr.Add(base.Address, ProcessAssets_Offset));
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ProcessGraphEditComp");
		NativeReflection.GetPropertyRef(ref ProcessAssets_PropertyAddress, unrealStruct, "ProcessAssets");
		ProcessAssets_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProcessAssets");
		ProcessAssets_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProcessAssets", Classes.FArrayProperty);
	}

	static BUS_ProcessGraphEditComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ProcessGraphEditComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ProcessGraphEditComp));
	}
}
