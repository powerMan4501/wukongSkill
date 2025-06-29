using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.CullDistanceVolume", "Engine", UnrealModuleType.Engine)]
public class ACullDistanceVolume : AVolume
{
	private static bool CullDistances_IsValid;

	private static FFieldAddress CullDistances_PropertyAddress;

	private static int CullDistances_Offset;

	private TArrayReadOnlyMarshaler<FCullDistanceSizePair> CullDistances_MarshalerCached;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/Engine.CullDistanceVolume:CullDistances")]
	public TArrayReadOnly<FCullDistanceSizePair> CullDistances
	{
		get
		{
			CheckDestroyed();
			if (!CullDistances_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CullDistanceVolume:CullDistances");
				return null;
			}
			if (CullDistances_MarshalerCached == null)
			{
				CullDistances_MarshalerCached = new TArrayReadOnlyMarshaler<FCullDistanceSizePair>(1, CullDistances_PropertyAddress, CachedMarshalingDelegates<FCullDistanceSizePair, FCullDistanceSizePair>.FromNative, CachedMarshalingDelegates<FCullDistanceSizePair, FCullDistanceSizePair>.ToNative);
			}
			return CullDistances_MarshalerCached.FromNative(IntPtr.Add(base.Address, CullDistances_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.CullDistanceVolume:bEnabled")]
	public bool Enabled
	{
		get
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CullDistanceVolume:bEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.CullDistanceVolume:bEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address, value);
			}
		}
	}

	static ACullDistanceVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ACullDistanceVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ACullDistanceVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.CullDistanceVolume");
		NativeReflectionCached.GetPropertyRef(ref CullDistances_PropertyAddress, unrealStruct, "CullDistances");
		CullDistances_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CullDistances");
		CullDistances_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CullDistances", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, unrealStruct, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnabled", Classes.FBoolProperty);
	}
}
