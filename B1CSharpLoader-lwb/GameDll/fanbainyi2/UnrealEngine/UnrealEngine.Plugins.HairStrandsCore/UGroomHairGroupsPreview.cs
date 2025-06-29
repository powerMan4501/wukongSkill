using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UClass(Flags = (ClassFlags)810549412uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomHairGroupsPreview", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public class UGroomHairGroupsPreview : UObject
{
	private static bool Groups_IsValid;

	private static FFieldAddress Groups_PropertyAddress;

	private static int Groups_Offset;

	private TArrayReadWriteMarshaler<FGroomHairGroupPreview> Groups_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627387397uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomHairGroupsPreview:Groups")]
	public TArrayReadWrite<FGroomHairGroupPreview> Groups
	{
		get
		{
			CheckDestroyed();
			if (!Groups_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HairStrandsCore.GroomHairGroupsPreview:Groups");
				return null;
			}
			if (Groups_MarshalerCached == null)
			{
				Groups_MarshalerCached = new TArrayReadWriteMarshaler<FGroomHairGroupPreview>(1, Groups_PropertyAddress, CachedMarshalingDelegates<FGroomHairGroupPreview, FGroomHairGroupPreview>.FromNative, CachedMarshalingDelegates<FGroomHairGroupPreview, FGroomHairGroupPreview>.ToNative);
			}
			return Groups_MarshalerCached.FromNative(IntPtr.Add(base.Address, Groups_Offset));
		}
	}

	static UGroomHairGroupsPreview()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGroomHairGroupsPreview)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGroomHairGroupsPreview));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HairStrandsCore.GroomHairGroupsPreview");
		NativeReflectionCached.GetPropertyRef(ref Groups_PropertyAddress, unrealStruct, "Groups");
		Groups_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Groups");
		Groups_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Groups", Classes.FArrayProperty);
	}
}
