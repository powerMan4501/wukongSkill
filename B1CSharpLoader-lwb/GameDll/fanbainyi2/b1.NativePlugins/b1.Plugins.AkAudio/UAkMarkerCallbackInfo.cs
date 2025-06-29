using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)817889440uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkMarkerCallbackInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public class UAkMarkerCallbackInfo : UAkEventCallbackInfo
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	private static bool Position_IsValid;

	private static int Position_Offset;

	private static bool Label_IsValid;

	private static int Label_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMarkerCallbackInfo:Identifier")]
	public int Identifier
	{
		get
		{
			CheckDestroyed();
			if (!Identifier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMarkerCallbackInfo:Identifier");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Identifier_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Identifier_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMarkerCallbackInfo:Identifier");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Identifier_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkMarkerCallbackInfo:Position")]
	public int Position
	{
		get
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMarkerCallbackInfo:Position");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Position_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMarkerCallbackInfo:Position");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Position_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/AkAudio.AkMarkerCallbackInfo:Label")]
	public string Label
	{
		get
		{
			CheckDestroyed();
			if (!Label_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMarkerCallbackInfo:Label");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Label_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Label_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkMarkerCallbackInfo:Label");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Label_Offset), value);
			}
		}
	}

	static UAkMarkerCallbackInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAkMarkerCallbackInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAkMarkerCallbackInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkMarkerCallbackInfo");
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Identifier", Classes.FIntProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Position", Classes.FIntProperty);
		Label_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Label");
		Label_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Label", Classes.FStrProperty);
	}
}
