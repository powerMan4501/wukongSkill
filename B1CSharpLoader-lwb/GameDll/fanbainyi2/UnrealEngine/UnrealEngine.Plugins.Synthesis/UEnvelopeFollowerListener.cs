using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Synthesis.EnvelopeFollowerListener", "Synthesis", UnrealModuleType.EnginePlugin)]
public class UEnvelopeFollowerListener : UActorComponent
{
	private static bool OnEnvelopeFollowerUpdate_IsValid;

	private static int OnEnvelopeFollowerUpdate_Offset;

	private FOnEnvelopeFollowerUpdate OnEnvelopeFollowerUpdate_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Synthesis.EnvelopeFollowerListener:OnEnvelopeFollowerUpdate")]
	public FOnEnvelopeFollowerUpdate OnEnvelopeFollowerUpdate
	{
		get
		{
			CheckDestroyed();
			if (!OnEnvelopeFollowerUpdate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Synthesis.EnvelopeFollowerListener:OnEnvelopeFollowerUpdate");
				return new FOnEnvelopeFollowerUpdate();
			}
			if (OnEnvelopeFollowerUpdate_DelegateCached == null)
			{
				OnEnvelopeFollowerUpdate_DelegateCached = new FOnEnvelopeFollowerUpdate();
				OnEnvelopeFollowerUpdate_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnEnvelopeFollowerUpdate_Offset));
			}
			return OnEnvelopeFollowerUpdate_DelegateCached;
		}
	}

	static UEnvelopeFollowerListener()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEnvelopeFollowerListener)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEnvelopeFollowerListener));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Synthesis.EnvelopeFollowerListener");
		OnEnvelopeFollowerUpdate_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnEnvelopeFollowerUpdate");
		OnEnvelopeFollowerUpdate_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnEnvelopeFollowerUpdate", Classes.FMulticastDelegateProperty);
	}
}
