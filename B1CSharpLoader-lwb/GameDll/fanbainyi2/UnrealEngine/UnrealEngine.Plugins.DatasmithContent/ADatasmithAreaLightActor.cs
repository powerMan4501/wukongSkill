using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public class ADatasmithAreaLightActor : AActor
{
	private static bool Mobility_IsValid;

	private static FFieldAddress Mobility_PropertyAddress;

	private static int Mobility_Offset;

	private static bool LightType_IsValid;

	private static FFieldAddress LightType_PropertyAddress;

	private static int LightType_Offset;

	private static bool LightShape_IsValid;

	private static FFieldAddress LightShape_PropertyAddress;

	private static int LightShape_Offset;

	private static bool Dimensions_IsValid;

	private static int Dimensions_Offset;

	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	private static bool IntensityUnits_IsValid;

	private static FFieldAddress IntensityUnits_PropertyAddress;

	private static int IntensityUnits_Offset;

	private static bool Color_IsValid;

	private static int Color_Offset;

	private static bool Temperature_IsValid;

	private static int Temperature_Offset;

	private static bool IESTexture_IsValid;

	private static int IESTexture_Offset;

	private static bool UseIESBrightness_IsValid;

	private static FFieldAddress UseIESBrightness_PropertyAddress;

	private static int UseIESBrightness_Offset;

	private static bool IESBrightnessScale_IsValid;

	private static int IESBrightnessScale_Offset;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	private static bool SourceRadius_IsValid;

	private static int SourceRadius_Offset;

	private static bool SourceLength_IsValid;

	private static int SourceLength_Offset;

	private static bool AttenuationRadius_IsValid;

	private static int AttenuationRadius_Offset;

	private static bool SpotlightInnerAngle_IsValid;

	private static int SpotlightInnerAngle_Offset;

	private static bool SpotlightOuterAngle_IsValid;

	private static int SpotlightOuterAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:Mobility")]
	public EComponentMobility Mobility
	{
		get
		{
			CheckDestroyed();
			if (!Mobility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Mobility");
				return EComponentMobility.Static;
			}
			return EnumMarshaler<EComponentMobility>.FromNative(IntPtr.Add(base.Address, Mobility_Offset), 0, Mobility_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Mobility_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Mobility");
			}
			else
			{
				EnumMarshaler<EComponentMobility>.ToNative(IntPtr.Add(base.Address, Mobility_Offset), 0, Mobility_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:LightType")]
	public EDatasmithAreaLightActorType LightType
	{
		get
		{
			CheckDestroyed();
			if (!LightType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:LightType");
				return EDatasmithAreaLightActorType.Point;
			}
			return EnumMarshaler<EDatasmithAreaLightActorType>.FromNative(IntPtr.Add(base.Address, LightType_Offset), 0, LightType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LightType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:LightType");
			}
			else
			{
				EnumMarshaler<EDatasmithAreaLightActorType>.ToNative(IntPtr.Add(base.Address, LightType_Offset), 0, LightType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:LightShape")]
	public EDatasmithAreaLightActorShape LightShape
	{
		get
		{
			CheckDestroyed();
			if (!LightShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:LightShape");
				return EDatasmithAreaLightActorShape.Rectangle;
			}
			return EnumMarshaler<EDatasmithAreaLightActorShape>.FromNative(IntPtr.Add(base.Address, LightShape_Offset), 0, LightShape_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LightShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:LightShape");
			}
			else
			{
				EnumMarshaler<EDatasmithAreaLightActorShape>.ToNative(IntPtr.Add(base.Address, LightShape_Offset), 0, LightShape_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:Dimensions")]
	public FVector2D Dimensions
	{
		get
		{
			CheckDestroyed();
			if (!Dimensions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Dimensions");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Dimensions_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Dimensions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Dimensions");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Dimensions_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:Intensity")]
	public float Intensity
	{
		get
		{
			CheckDestroyed();
			if (!Intensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Intensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Intensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Intensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Intensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Intensity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:IntensityUnits")]
	public ELightUnits IntensityUnits
	{
		get
		{
			CheckDestroyed();
			if (!IntensityUnits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:IntensityUnits");
				return ELightUnits.Unitless;
			}
			return EnumMarshaler<ELightUnits>.FromNative(IntPtr.Add(base.Address, IntensityUnits_Offset), 0, IntensityUnits_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IntensityUnits_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:IntensityUnits");
			}
			else
			{
				EnumMarshaler<ELightUnits>.ToNative(IntPtr.Add(base.Address, IntensityUnits_Offset), 0, IntensityUnits_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:Color")]
	public FLinearColor Color
	{
		get
		{
			CheckDestroyed();
			if (!Color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Color");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, Color_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Color");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, Color_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:Temperature")]
	public float Temperature
	{
		get
		{
			CheckDestroyed();
			if (!Temperature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Temperature");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Temperature_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Temperature_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Temperature");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Temperature_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:IESTexture")]
	public UTextureLightProfile IESTexture
	{
		get
		{
			CheckDestroyed();
			if (!IESTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:IESTexture");
				return null;
			}
			return UObjectMarshaler<UTextureLightProfile>.FromNative(IntPtr.Add(base.Address, IESTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IESTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:IESTexture");
			}
			else
			{
				UObjectMarshaler<UTextureLightProfile>.ToNative(IntPtr.Add(base.Address, IESTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:bUseIESBrightness")]
	public bool UseIESBrightness
	{
		get
		{
			CheckDestroyed();
			if (!UseIESBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:bUseIESBrightness");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseIESBrightness_Offset), 0, UseIESBrightness_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseIESBrightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:bUseIESBrightness");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseIESBrightness_Offset), 0, UseIESBrightness_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:IESBrightnessScale")]
	public float IESBrightnessScale
	{
		get
		{
			CheckDestroyed();
			if (!IESBrightnessScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:IESBrightnessScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IESBrightnessScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IESBrightnessScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:IESBrightnessScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IESBrightnessScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589573uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:Rotation")]
	public FRotator Rotation
	{
		get
		{
			CheckDestroyed();
			if (!Rotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Rotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, Rotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Rotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:Rotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, Rotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:SourceRadius")]
	public float SourceRadius
	{
		get
		{
			CheckDestroyed();
			if (!SourceRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:SourceRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SourceRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:SourceRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SourceRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:SourceLength")]
	public float SourceLength
	{
		get
		{
			CheckDestroyed();
			if (!SourceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:SourceLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SourceLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:SourceLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SourceLength_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:AttenuationRadius")]
	public float AttenuationRadius
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:AttenuationRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AttenuationRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:AttenuationRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AttenuationRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:SpotlightInnerAngle")]
	public float SpotlightInnerAngle
	{
		get
		{
			CheckDestroyed();
			if (!SpotlightInnerAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:SpotlightInnerAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpotlightInnerAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpotlightInnerAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:SpotlightInnerAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpotlightInnerAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithAreaLightActor:SpotlightOuterAngle")]
	public float SpotlightOuterAngle
	{
		get
		{
			CheckDestroyed();
			if (!SpotlightOuterAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:SpotlightOuterAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpotlightOuterAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpotlightOuterAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DatasmithContent.DatasmithAreaLightActor:SpotlightOuterAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpotlightOuterAngle_Offset), value);
			}
		}
	}

	static ADatasmithAreaLightActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADatasmithAreaLightActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADatasmithAreaLightActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/DatasmithContent.DatasmithAreaLightActor");
		NativeReflectionCached.GetPropertyRef(ref Mobility_PropertyAddress, unrealStruct, "Mobility");
		Mobility_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Mobility");
		Mobility_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Mobility", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref LightType_PropertyAddress, unrealStruct, "LightType");
		LightType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightType");
		LightType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref LightShape_PropertyAddress, unrealStruct, "LightShape");
		LightShape_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LightShape");
		LightShape_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LightShape", Classes.FEnumProperty);
		Dimensions_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Dimensions");
		Dimensions_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Dimensions", Classes.FStructProperty);
		Intensity_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Intensity");
		Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Intensity", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IntensityUnits_PropertyAddress, unrealStruct, "IntensityUnits");
		IntensityUnits_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IntensityUnits");
		IntensityUnits_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IntensityUnits", Classes.FEnumProperty);
		Color_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Color");
		Color_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Color", Classes.FStructProperty);
		Temperature_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Temperature");
		Temperature_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Temperature", Classes.FFloatProperty);
		IESTexture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IESTexture");
		IESTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IESTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref UseIESBrightness_PropertyAddress, unrealStruct, "bUseIESBrightness");
		UseIESBrightness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseIESBrightness");
		UseIESBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseIESBrightness", Classes.FBoolProperty);
		IESBrightnessScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IESBrightnessScale");
		IESBrightnessScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IESBrightnessScale", Classes.FFloatProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Rotation", Classes.FStructProperty);
		SourceRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceRadius");
		SourceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceRadius", Classes.FFloatProperty);
		SourceLength_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceLength");
		SourceLength_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceLength", Classes.FFloatProperty);
		AttenuationRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AttenuationRadius");
		AttenuationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AttenuationRadius", Classes.FFloatProperty);
		SpotlightInnerAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpotlightInnerAngle");
		SpotlightInnerAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpotlightInnerAngle", Classes.FFloatProperty);
		SpotlightOuterAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpotlightOuterAngle");
		SpotlightOuterAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpotlightOuterAngle", Classes.FFloatProperty);
	}
}
