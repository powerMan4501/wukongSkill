using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSFocusWidget", "UnrealExtent", UnrealModuleType.Game)]
public class UGSFocusWidget : UWidget
{
	private static bool IsFocusable_IsValid;

	private static FFieldAddress IsFocusable_PropertyAddress;

	private static int IsFocusable_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSFocusWidget:IsFocusable")]
	public bool IsFocusable
	{
		get
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSFocusWidget:IsFocusable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsFocusable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSFocusWidget:IsFocusable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsFocusable_Offset), 0, IsFocusable_PropertyAddress.Address, value);
			}
		}
	}

	static UGSFocusWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSFocusWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSFocusWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSFocusWidget");
		NativeReflectionCached.GetPropertyRef(ref IsFocusable_PropertyAddress, unrealStruct, "IsFocusable");
		IsFocusable_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IsFocusable");
		IsFocusable_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IsFocusable", Classes.FBoolProperty);
	}
}
