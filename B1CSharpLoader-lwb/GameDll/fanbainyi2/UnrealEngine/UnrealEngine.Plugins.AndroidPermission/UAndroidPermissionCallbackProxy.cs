using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AndroidPermission;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/AndroidPermission.AndroidPermissionCallbackProxy", "AndroidPermission", UnrealModuleType.EnginePlugin)]
public class UAndroidPermissionCallbackProxy : UObject
{
	private static bool OnPermissionsGrantedDynamicDelegate_IsValid;

	private static int OnPermissionsGrantedDynamicDelegate_Offset;

	private FAndroidPermissionDynamicDelegate OnPermissionsGrantedDynamicDelegate_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AndroidPermission.AndroidPermissionCallbackProxy:OnPermissionsGrantedDynamicDelegate")]
	public FAndroidPermissionDynamicDelegate OnPermissionsGrantedDynamicDelegate
	{
		get
		{
			CheckDestroyed();
			if (!OnPermissionsGrantedDynamicDelegate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AndroidPermission.AndroidPermissionCallbackProxy:OnPermissionsGrantedDynamicDelegate");
				return new FAndroidPermissionDynamicDelegate();
			}
			if (OnPermissionsGrantedDynamicDelegate_DelegateCached == null)
			{
				OnPermissionsGrantedDynamicDelegate_DelegateCached = new FAndroidPermissionDynamicDelegate();
				OnPermissionsGrantedDynamicDelegate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPermissionsGrantedDynamicDelegate_Offset));
			}
			return OnPermissionsGrantedDynamicDelegate_DelegateCached;
		}
	}

	static UAndroidPermissionCallbackProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAndroidPermissionCallbackProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAndroidPermissionCallbackProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AndroidPermission.AndroidPermissionCallbackProxy");
		OnPermissionsGrantedDynamicDelegate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnPermissionsGrantedDynamicDelegate");
		OnPermissionsGrantedDynamicDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnPermissionsGrantedDynamicDelegate", Classes.FMulticastDelegateProperty);
	}
}
