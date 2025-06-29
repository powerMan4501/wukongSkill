using System;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSDropCanvasPanel", "UnrealExtent", UnrealModuleType.Game)]
public class UGSDropCanvasPanel : UCanvasPanel
{
	private static bool OnDropEvent_IsValid;

	private static int OnDropEvent_Offset;

	private FOnGSDropEvent OnDropEvent_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UnrealExtent.GSDropCanvasPanel:OnDropEvent")]
	public FOnGSDropEvent OnDropEvent
	{
		get
		{
			CheckDestroyed();
			if (!OnDropEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSDropCanvasPanel:OnDropEvent");
				return new FOnGSDropEvent();
			}
			if (OnDropEvent_DelegateCached == null)
			{
				OnDropEvent_DelegateCached = new FOnGSDropEvent();
				OnDropEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDropEvent_Offset));
			}
			return OnDropEvent_DelegateCached;
		}
	}

	static UGSDropCanvasPanel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSDropCanvasPanel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSDropCanvasPanel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSDropCanvasPanel");
		OnDropEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnDropEvent");
		OnDropEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnDropEvent", Classes.FMulticastDelegateProperty);
	}
}
