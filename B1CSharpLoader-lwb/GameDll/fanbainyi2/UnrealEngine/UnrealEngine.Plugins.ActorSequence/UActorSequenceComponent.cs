using System;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ActorSequence;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/ActorSequence.ActorSequenceComponent", "ActorSequence", UnrealModuleType.EnginePlugin)]
public class UActorSequenceComponent : UActorComponent, IMovieSceneSequenceActor, IInterface
{
	private static bool SequencePlayer_IsValid;

	private static int SequencePlayer_Offset;

	[UProperty(Flags = (PropFlags)12393764861518356uL)]
	[UMetaPath("/Script/ActorSequence.ActorSequenceComponent:SequencePlayer")]
	protected UActorSequencePlayer SequencePlayer
	{
		get
		{
			CheckDestroyed();
			if (!SequencePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ActorSequence.ActorSequenceComponent:SequencePlayer");
				return null;
			}
			return UObjectMarshaler<UActorSequencePlayer>.FromNative(IntPtr.Add(base.Address, SequencePlayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequencePlayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ActorSequence.ActorSequenceComponent:SequencePlayer");
			}
			else
			{
				UObjectMarshaler<UActorSequencePlayer>.ToNative(IntPtr.Add(base.Address, SequencePlayer_Offset), value);
			}
		}
	}

	static UActorSequenceComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UActorSequenceComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UActorSequenceComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/ActorSequence.ActorSequenceComponent");
		SequencePlayer_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SequencePlayer");
		SequencePlayer_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SequencePlayer", Classes.FObjectProperty);
	}
}
