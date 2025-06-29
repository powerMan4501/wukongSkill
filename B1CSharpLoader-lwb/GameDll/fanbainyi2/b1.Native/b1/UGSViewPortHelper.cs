using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSViewPortHelper", "UnrealExtent", UnrealModuleType.Game)]
public class UGSViewPortHelper : UObject
{
	private static bool OnViewPortResized_IsValid;

	private static int OnViewPortResized_Offset;

	private FGSOnViewPortResized OnViewPortResized_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealExtent.GSViewPortHelper:OnViewPortResized")]
	public FGSOnViewPortResized OnViewPortResized
	{
		get
		{
			CheckDestroyed();
			if (!OnViewPortResized_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSViewPortHelper:OnViewPortResized");
				return new FGSOnViewPortResized();
			}
			if (OnViewPortResized_DelegateCached == null)
			{
				OnViewPortResized_DelegateCached = new FGSOnViewPortResized();
				OnViewPortResized_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnViewPortResized_Offset));
			}
			return OnViewPortResized_DelegateCached;
		}
	}

	static UGSViewPortHelper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSViewPortHelper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSViewPortHelper));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSViewPortHelper");
		OnViewPortResized_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnViewPortResized");
		OnViewPortResized_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnViewPortResized", Classes.FMulticastDelegateProperty);
	}
}
