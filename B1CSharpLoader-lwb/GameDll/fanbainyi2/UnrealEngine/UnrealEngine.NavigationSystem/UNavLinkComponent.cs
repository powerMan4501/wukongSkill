using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/NavigationSystem.NavLinkComponent", "NavigationSystem", UnrealModuleType.Engine)]
public class UNavLinkComponent : UPrimitiveComponent, INavLinkHostInterface, IInterface
{
	private static bool Links_IsValid;

	private static FFieldAddress Links_PropertyAddress;

	private static int Links_Offset;

	private TArrayReadOnlyMarshaler<FNavigationLink> Links_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/NavigationSystem.NavLinkComponent:Links")]
	public TArrayReadOnly<FNavigationLink> Links
	{
		get
		{
			CheckDestroyed();
			if (!Links_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavLinkComponent:Links");
				return null;
			}
			if (Links_MarshalerCached == null)
			{
				Links_MarshalerCached = new TArrayReadOnlyMarshaler<FNavigationLink>(1, Links_PropertyAddress, CachedMarshalingDelegates<FNavigationLink, FNavigationLink>.FromNative, CachedMarshalingDelegates<FNavigationLink, FNavigationLink>.ToNative);
			}
			return Links_MarshalerCached.FromNative(IntPtr.Add(base.Address, Links_Offset));
		}
	}

	static UNavLinkComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNavLinkComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNavLinkComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/NavigationSystem.NavLinkComponent");
		NativeReflectionCached.GetPropertyRef(ref Links_PropertyAddress, unrealStruct, "Links");
		Links_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Links");
		Links_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Links", Classes.FArrayProperty);
	}
}
