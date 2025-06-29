using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.LocationServicesBPLibrary;

[Abstract]
[UClass(Flags = (ClassFlags)817889441uL, Config = "Engine")]
[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesImpl", "LocationServicesBPLibrary", UnrealModuleType.EnginePlugin)]
public class ULocationServicesImpl : UObject
{
	private static bool OnLocationChanged_IsValid;

	private static int OnLocationChanged_Offset;

	private FLocationServicesData_OnLocationChanged OnLocationChanged_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/LocationServicesBPLibrary.LocationServicesImpl:OnLocationChanged")]
	public FLocationServicesData_OnLocationChanged OnLocationChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnLocationChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LocationServicesBPLibrary.LocationServicesImpl:OnLocationChanged");
				return new FLocationServicesData_OnLocationChanged();
			}
			if (OnLocationChanged_DelegateCached == null)
			{
				OnLocationChanged_DelegateCached = new FLocationServicesData_OnLocationChanged();
				OnLocationChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnLocationChanged_Offset));
			}
			return OnLocationChanged_DelegateCached;
		}
	}

	static ULocationServicesImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ULocationServicesImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ULocationServicesImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/LocationServicesBPLibrary.LocationServicesImpl");
		OnLocationChanged_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnLocationChanged");
		OnLocationChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnLocationChanged", Classes.FMulticastDelegateProperty);
	}
}
