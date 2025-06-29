using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SeqPerformerConfigInfoComp")]
public class BUS_SeqPerformerConfigInfoComp : UActorEditCompBase
{
	private static bool DispInteractBoneMap_IsValid;

	private static int DispInteractBoneMap_Offset;

	private static FFieldAddress DispInteractBoneMap_PropertyAddress;

	private TMapReadWriteMarshaler<FName, FBoneUseForDispMap> DispInteractBoneMap_Marshaler;

	private static bool bUseCustomBodyPartCollision_IsValid;

	private static int bUseCustomBodyPartCollision_Offset;

	private static FFieldAddress bUseCustomBodyPartCollision_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[Category("DispInteractConfig")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SeqPerformerConfigInfoComp:DispInteractBoneMap")]
	public TMapReadWrite<FName, FBoneUseForDispMap> DispInteractBoneMap
	{
		get
		{
			CheckDestroyed();
			if (!DispInteractBoneMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqPerformerConfigInfoComp:DispInteractBoneMap");
				return null;
			}
			if (DispInteractBoneMap_Marshaler == null)
			{
				DispInteractBoneMap_Marshaler = new TMapReadWriteMarshaler<FName, FBoneUseForDispMap>(1, DispInteractBoneMap_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.FromNative, CachedMarshalingDelegates<FBoneUseForDispMap, BlittableTypeMarshaler<FBoneUseForDispMap>>.ToNative);
			}
			return DispInteractBoneMap_Marshaler.FromNative(IntPtr.Add(base.Address, DispInteractBoneMap_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Body Part")]
	[USharpPath("/Script/b1-Managed.BUS_SeqPerformerConfigInfoComp:bUseCustomBodyPartCollision")]
	public bool bUseCustomBodyPartCollision
	{
		get
		{
			CheckDestroyed();
			if (!bUseCustomBodyPartCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqPerformerConfigInfoComp:bUseCustomBodyPartCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bUseCustomBodyPartCollision_Offset), 0, bUseCustomBodyPartCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bUseCustomBodyPartCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqPerformerConfigInfoComp:bUseCustomBodyPartCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bUseCustomBodyPartCollision_Offset), 0, bUseCustomBodyPartCollision_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<BUC_SeqPerformerConfigInfoData>()?.CopyBPDataToData(DispInteractBoneMap, bUseCustomBodyPartCollision);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SeqPerformerConfigInfoComp");
		NativeReflection.GetPropertyRef(ref DispInteractBoneMap_PropertyAddress, unrealStruct, "DispInteractBoneMap");
		DispInteractBoneMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DispInteractBoneMap");
		DispInteractBoneMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DispInteractBoneMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref bUseCustomBodyPartCollision_PropertyAddress, unrealStruct, "bUseCustomBodyPartCollision");
		bUseCustomBodyPartCollision_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bUseCustomBodyPartCollision");
		bUseCustomBodyPartCollision_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bUseCustomBodyPartCollision", Classes.FBoolProperty);
	}

	static BUS_SeqPerformerConfigInfoComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SeqPerformerConfigInfoComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SeqPerformerConfigInfoComp));
	}
}
