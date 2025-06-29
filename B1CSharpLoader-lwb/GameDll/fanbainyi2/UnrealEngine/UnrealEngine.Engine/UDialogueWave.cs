using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810029216uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.DialogueWave", "Engine", UnrealModuleType.Engine)]
public class UDialogueWave : UObject
{
	private static bool Mature_IsValid;

	private static FFieldAddress Mature_PropertyAddress;

	private static int Mature_Offset;

	private static bool Override_SubtitleOverride_IsValid;

	private static FFieldAddress Override_SubtitleOverride_PropertyAddress;

	private static int Override_SubtitleOverride_Offset;

	private static bool SpokenText_IsValid;

	private static int SpokenText_Offset;

	private static bool SubtitleOverride_IsValid;

	private static int SubtitleOverride_Offset;

	[UProperty(Flags = (PropFlags)6756567672160277uL)]
	[UMetaPath("/Script/Engine.DialogueWave:bMature")]
	public bool Mature
	{
		get
		{
			CheckDestroyed();
			if (!Mature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DialogueWave:bMature");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Mature_Offset), 0, Mature_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DialogueWave:bMature");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Mature_Offset), 0, Mature_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.DialogueWave:bOverride_SubtitleOverride")]
	public bool Override_SubtitleOverride
	{
		get
		{
			CheckDestroyed();
			if (!Override_SubtitleOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DialogueWave:bOverride_SubtitleOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Override_SubtitleOverride_Offset), 0, Override_SubtitleOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Override_SubtitleOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DialogueWave:bOverride_SubtitleOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Override_SubtitleOverride_Offset), 0, Override_SubtitleOverride_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/Engine.DialogueWave:SpokenText")]
	public string SpokenText
	{
		get
		{
			CheckDestroyed();
			if (!SpokenText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DialogueWave:SpokenText");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SpokenText_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpokenText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DialogueWave:SpokenText");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SpokenText_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/Engine.DialogueWave:SubtitleOverride")]
	public string SubtitleOverride
	{
		get
		{
			CheckDestroyed();
			if (!SubtitleOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DialogueWave:SubtitleOverride");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, SubtitleOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SubtitleOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DialogueWave:SubtitleOverride");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, SubtitleOverride_Offset), value);
			}
		}
	}

	static UDialogueWave()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDialogueWave)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDialogueWave));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.DialogueWave");
		NativeReflectionCached.GetPropertyRef(ref Mature_PropertyAddress, unrealStruct, "bMature");
		Mature_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bMature");
		Mature_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bMature", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_SubtitleOverride_PropertyAddress, unrealStruct, "bOverride_SubtitleOverride");
		Override_SubtitleOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bOverride_SubtitleOverride");
		Override_SubtitleOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bOverride_SubtitleOverride", Classes.FBoolProperty);
		SpokenText_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpokenText");
		SpokenText_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpokenText", Classes.FStrProperty);
		SubtitleOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SubtitleOverride");
		SubtitleOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SubtitleOverride", Classes.FStrProperty);
	}
}
