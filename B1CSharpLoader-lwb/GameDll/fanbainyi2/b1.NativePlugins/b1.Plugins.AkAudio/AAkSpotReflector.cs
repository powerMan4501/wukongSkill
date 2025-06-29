using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AkAudio.AkSpotReflector", "AkAudio", UnrealModuleType.GamePlugin)]
public class AAkSpotReflector : AActor
{
	private static bool EarlyReflectionAuxBus_IsValid;

	private static int EarlyReflectionAuxBus_Offset;

	private static bool EarlyReflectionAuxBusName_IsValid;

	private static int EarlyReflectionAuxBusName_Offset;

	private static bool AcousticTexture_IsValid;

	private static int AcousticTexture_Offset;

	private static bool DistanceScalingFactor_IsValid;

	private static int DistanceScalingFactor_Offset;

	private static bool Level_IsValid;

	private static int Level_Offset;

	private static bool SameRoomOnly_IsValid;

	private static FFieldAddress SameRoomOnly_PropertyAddress;

	private static int SameRoomOnly_Offset;

	private static bool EnableRoomOverride_IsValid;

	private static FFieldAddress EnableRoomOverride_PropertyAddress;

	private static int EnableRoomOverride_Offset;

	private static bool RoomOverride_IsValid;

	private static int RoomOverride_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSpotReflector:EarlyReflectionAuxBus")]
	public UAkAuxBus EarlyReflectionAuxBus
	{
		get
		{
			CheckDestroyed();
			if (!EarlyReflectionAuxBus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:EarlyReflectionAuxBus");
				return null;
			}
			return UObjectMarshaler<UAkAuxBus>.FromNative(IntPtr.Add(base.Address, EarlyReflectionAuxBus_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EarlyReflectionAuxBus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:EarlyReflectionAuxBus");
			}
			else
			{
				UObjectMarshaler<UAkAuxBus>.ToNative(IntPtr.Add(base.Address, EarlyReflectionAuxBus_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759797487567365uL)]
	[UMetaPath("/Script/AkAudio.AkSpotReflector:EarlyReflectionAuxBusName")]
	public string EarlyReflectionAuxBusName
	{
		get
		{
			CheckDestroyed();
			if (!EarlyReflectionAuxBusName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:EarlyReflectionAuxBusName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, EarlyReflectionAuxBusName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EarlyReflectionAuxBusName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:EarlyReflectionAuxBusName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, EarlyReflectionAuxBusName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSpotReflector:AcousticTexture")]
	public UAkAcousticTexture AcousticTexture
	{
		get
		{
			CheckDestroyed();
			if (!AcousticTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:AcousticTexture");
				return null;
			}
			return UObjectMarshaler<UAkAcousticTexture>.FromNative(IntPtr.Add(base.Address, AcousticTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcousticTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:AcousticTexture");
			}
			else
			{
				UObjectMarshaler<UAkAcousticTexture>.ToNative(IntPtr.Add(base.Address, AcousticTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSpotReflector:DistanceScalingFactor")]
	public float DistanceScalingFactor
	{
		get
		{
			CheckDestroyed();
			if (!DistanceScalingFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:DistanceScalingFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceScalingFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceScalingFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:DistanceScalingFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceScalingFactor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSpotReflector:Level")]
	public float Level
	{
		get
		{
			CheckDestroyed();
			if (!Level_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:Level");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Level_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Level_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:Level");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Level_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSpotReflector:SameRoomOnly")]
	public bool SameRoomOnly
	{
		get
		{
			CheckDestroyed();
			if (!SameRoomOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:SameRoomOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SameRoomOnly_Offset), 0, SameRoomOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SameRoomOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:SameRoomOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SameRoomOnly_Offset), 0, SameRoomOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSpotReflector:EnableRoomOverride")]
	public bool EnableRoomOverride
	{
		get
		{
			CheckDestroyed();
			if (!EnableRoomOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:EnableRoomOverride");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRoomOverride_Offset), 0, EnableRoomOverride_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRoomOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:EnableRoomOverride");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRoomOverride_Offset), 0, EnableRoomOverride_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkSpotReflector:RoomOverride")]
	public AActor RoomOverride
	{
		get
		{
			CheckDestroyed();
			if (!RoomOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:RoomOverride");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, RoomOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RoomOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AkAudio.AkSpotReflector:RoomOverride");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, RoomOverride_Offset), value);
			}
		}
	}

	static AAkSpotReflector()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AAkSpotReflector)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AAkSpotReflector));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AkAudio.AkSpotReflector");
		EarlyReflectionAuxBus_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EarlyReflectionAuxBus");
		EarlyReflectionAuxBus_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EarlyReflectionAuxBus", Classes.FObjectProperty);
		EarlyReflectionAuxBusName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EarlyReflectionAuxBusName");
		EarlyReflectionAuxBusName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EarlyReflectionAuxBusName", Classes.FStrProperty);
		AcousticTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AcousticTexture");
		AcousticTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AcousticTexture", Classes.FObjectProperty);
		DistanceScalingFactor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DistanceScalingFactor");
		DistanceScalingFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DistanceScalingFactor", Classes.FFloatProperty);
		Level_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Level");
		Level_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Level", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SameRoomOnly_PropertyAddress, unrealStruct, "SameRoomOnly");
		SameRoomOnly_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SameRoomOnly");
		SameRoomOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SameRoomOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRoomOverride_PropertyAddress, unrealStruct, "EnableRoomOverride");
		EnableRoomOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EnableRoomOverride");
		EnableRoomOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EnableRoomOverride", Classes.FBoolProperty);
		RoomOverride_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RoomOverride");
		RoomOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RoomOverride", Classes.FObjectProperty);
	}
}
