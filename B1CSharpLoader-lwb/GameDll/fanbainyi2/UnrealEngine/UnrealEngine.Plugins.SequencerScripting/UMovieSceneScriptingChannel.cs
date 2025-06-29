using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[Abstract]
[UClass(Flags = (ClassFlags)809500833uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingChannel", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneScriptingChannel : UObject
{
	private static bool ChannelName_IsValid;

	private static int ChannelName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneScriptingChannel:ChannelName")]
	public FName ChannelName
	{
		get
		{
			CheckDestroyed();
			if (!ChannelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SequencerScripting.MovieSceneScriptingChannel:ChannelName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, ChannelName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChannelName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SequencerScripting.MovieSceneScriptingChannel:ChannelName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, ChannelName_Offset), value);
			}
		}
	}

	static UMovieSceneScriptingChannel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneScriptingChannel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneScriptingChannel));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneScriptingChannel");
		ChannelName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ChannelName");
		ChannelName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ChannelName", Classes.FNameProperty);
	}
}
