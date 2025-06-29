using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)821035170uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkWwiseTreeSelector", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkWwiseTreeSelector : UWidget
{
	private static bool OnSelectionChanged_IsValid;

	private static int OnSelectionChanged_Offset;

	private FOnItemSelectionChanged OnSelectionChanged_DelegateCached;

	private static bool OnItemDragged_IsValid;

	private static int OnItemDragged_Offset;

	private FOnItemDragDetected OnItemDragged_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkWwiseTreeSelector:OnSelectionChanged")]
	public FOnItemSelectionChanged OnSelectionChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnSelectionChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkWwiseTreeSelector:OnSelectionChanged");
				return new FOnItemSelectionChanged();
			}
			if (OnSelectionChanged_DelegateCached == null)
			{
				OnSelectionChanged_DelegateCached = new FOnItemSelectionChanged();
				OnSelectionChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSelectionChanged_Offset));
			}
			return OnSelectionChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/AkAudio.AkWwiseTreeSelector:OnItemDragged")]
	public FOnItemDragDetected OnItemDragged
	{
		get
		{
			CheckDestroyed();
			if (!OnItemDragged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkWwiseTreeSelector:OnItemDragged");
				return new FOnItemDragDetected();
			}
			if (OnItemDragged_DelegateCached == null)
			{
				OnItemDragged_DelegateCached = new FOnItemDragDetected();
				OnItemDragged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnItemDragged_Offset));
			}
			return OnItemDragged_DelegateCached;
		}
	}

	static UAkWwiseTreeSelector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkWwiseTreeSelector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkWwiseTreeSelector));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkWwiseTreeSelector");
		OnSelectionChanged_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnSelectionChanged");
		OnSelectionChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnSelectionChanged", Classes.FMulticastDelegateProperty);
		OnItemDragged_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnItemDragged");
		OnItemDragged_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnItemDragged", Classes.FMulticastDelegateProperty);
	}
}
