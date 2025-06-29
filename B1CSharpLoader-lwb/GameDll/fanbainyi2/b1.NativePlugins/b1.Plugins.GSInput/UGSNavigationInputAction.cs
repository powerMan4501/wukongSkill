using System;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GSInput.GSNavigationInputAction", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSNavigationInputAction : UInputAction
{
	private static bool FirstTriggerNavigations_IsValid;

	private static FFieldAddress FirstTriggerNavigations_PropertyAddress;

	private static int FirstTriggerNavigations_Offset;

	private TArrayReadOnlyMarshaler<EUINavigation> FirstTriggerNavigations_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503599627371029uL)]
	[UMetaPath("/Script/GSInput.GSNavigationInputAction:FirstTriggerNavigations")]
	public TArrayReadOnly<EUINavigation> FirstTriggerNavigations
	{
		get
		{
			CheckDestroyed();
			if (!FirstTriggerNavigations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSNavigationInputAction:FirstTriggerNavigations");
				return null;
			}
			if (FirstTriggerNavigations_MarshalerCached == null)
			{
				FirstTriggerNavigations_MarshalerCached = new TArrayReadOnlyMarshaler<EUINavigation>(1, FirstTriggerNavigations_PropertyAddress, CachedMarshalingDelegates<EUINavigation, EnumMarshaler<EUINavigation>>.FromNative, CachedMarshalingDelegates<EUINavigation, EnumMarshaler<EUINavigation>>.ToNative);
			}
			return FirstTriggerNavigations_MarshalerCached.FromNative(IntPtr.Add(base.Address, FirstTriggerNavigations_Offset));
		}
	}

	static UGSNavigationInputAction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSNavigationInputAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSNavigationInputAction));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSInput.GSNavigationInputAction");
		NativeReflectionCached.GetPropertyRef(ref FirstTriggerNavigations_PropertyAddress, unrealStruct, "FirstTriggerNavigations");
		FirstTriggerNavigations_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FirstTriggerNavigations");
		FirstTriggerNavigations_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FirstTriggerNavigations", Classes.FArrayProperty);
	}
}
