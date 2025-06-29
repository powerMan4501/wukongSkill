using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)817889444uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BWC_DispLibEnvVolume", "b1", UnrealModuleType.Game)]
public class ABWC_DispLibEnvVolume : AVolume, IInterface_DispLibEnvVolume, IInterface
{
	private static bool Settings_IsValid;

	private static FFieldAddress Settings_PropertyAddress;

	private static int Settings_Offset;

	private TArrayReadWriteMarshaler<UBWS_DispLibEnvWeatherSetting> Settings_MarshalerCached;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool BlendRadius_IsValid;

	private static int BlendRadius_Offset;

	private static bool BlendWeight_IsValid;

	private static int BlendWeight_Offset;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	private static bool Unbound_IsValid;

	private static FFieldAddress Unbound_PropertyAddress;

	private static int Unbound_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvVolume:Settings")]
	public TArrayReadWrite<UBWS_DispLibEnvWeatherSetting> Settings
	{
		get
		{
			CheckDestroyed();
			if (!Settings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:Settings");
				return null;
			}
			if (Settings_MarshalerCached == null)
			{
				Settings_MarshalerCached = new TArrayReadWriteMarshaler<UBWS_DispLibEnvWeatherSetting>(1, Settings_PropertyAddress, CachedMarshalingDelegates<UBWS_DispLibEnvWeatherSetting, UObjectMarshaler<UBWS_DispLibEnvWeatherSetting>>.FromNative, CachedMarshalingDelegates<UBWS_DispLibEnvWeatherSetting, UObjectMarshaler<UBWS_DispLibEnvWeatherSetting>>.ToNative);
			}
			return Settings_MarshalerCached.FromNative(IntPtr.Add(base.Address, Settings_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvVolume:Priority")]
	public float Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:Priority");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:Priority");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvVolume:BlendRadius")]
	public float BlendRadius
	{
		get
		{
			CheckDestroyed();
			if (!BlendRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:BlendRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:BlendRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvVolume:BlendWeight")]
	public float BlendWeight
	{
		get
		{
			CheckDestroyed();
			if (!BlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:BlendWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:BlendWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendWeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvVolume:bEnabled")]
	public bool Enabled
	{
		get
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:bEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Enabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:bEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Enabled_Offset), 0, Enabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.BWC_DispLibEnvVolume:bUnbound")]
	public bool Unbound
	{
		get
		{
			CheckDestroyed();
			if (!Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:bUnbound");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Unbound_Offset), 0, Unbound_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BWC_DispLibEnvVolume:bUnbound");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Unbound_Offset), 0, Unbound_PropertyAddress.Address, value);
			}
		}
	}

	static ABWC_DispLibEnvVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABWC_DispLibEnvVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABWC_DispLibEnvVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BWC_DispLibEnvVolume");
		NativeReflectionCached.GetPropertyRef(ref Settings_PropertyAddress, unrealStruct, "Settings");
		Settings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Settings");
		Settings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Settings", Classes.FArrayProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Priority", Classes.FFloatProperty);
		BlendRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendRadius");
		BlendRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendRadius", Classes.FFloatProperty);
		BlendWeight_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendWeight");
		BlendWeight_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendWeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, unrealStruct, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Unbound_PropertyAddress, unrealStruct, "bUnbound");
		Unbound_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUnbound");
		Unbound_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUnbound", Classes.FBoolProperty);
	}
}
