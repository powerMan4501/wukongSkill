using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSWCStreamingSourceActor", "UnrealExtent", UnrealModuleType.Game)]
public class AGSWCStreamingSourceActor : AActor
{
	private static bool StreamingSorceComponent_IsValid;

	private static int StreamingSorceComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/UnrealExtent.GSWCStreamingSourceActor:StreamingSorceComponent")]
	public UGSWorldCompositionStreamingSourceComponent StreamingSorceComponent
	{
		get
		{
			CheckDestroyed();
			if (!StreamingSorceComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSWCStreamingSourceActor:StreamingSorceComponent");
				return null;
			}
			return UObjectMarshaler<UGSWorldCompositionStreamingSourceComponent>.FromNative(IntPtr.Add(base.Address, StreamingSorceComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StreamingSorceComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSWCStreamingSourceActor:StreamingSorceComponent");
			}
			else
			{
				UObjectMarshaler<UGSWorldCompositionStreamingSourceComponent>.ToNative(IntPtr.Add(base.Address, StreamingSorceComponent_Offset), value);
			}
		}
	}

	static AGSWCStreamingSourceActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSWCStreamingSourceActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSWCStreamingSourceActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.GSWCStreamingSourceActor");
		StreamingSorceComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StreamingSorceComponent");
		StreamingSorceComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StreamingSorceComponent", Classes.FObjectProperty);
	}
}
