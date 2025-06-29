using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)820510885uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ReflectionCaptureComponent", "Engine", UnrealModuleType.Engine)]
public class UReflectionCaptureComponent : USceneComponent
{
	private static bool ReflectionSourceType_IsValid;

	private static FFieldAddress ReflectionSourceType_PropertyAddress;

	private static int ReflectionSourceType_Offset;

	private static bool MobileReflectionCompression_IsValid;

	private static FFieldAddress MobileReflectionCompression_PropertyAddress;

	private static int MobileReflectionCompression_Offset;

	private static bool Cubemap_IsValid;

	private static int Cubemap_Offset;

	private static bool SourceCubemapAngle_IsValid;

	private static int SourceCubemapAngle_Offset;

	private static bool Brightness_IsValid;

	private static int Brightness_Offset;

	private static bool ModifyMaxValueRGBM_IsValid;

	private static FFieldAddress ModifyMaxValueRGBM_PropertyAddress;

	private static int ModifyMaxValueRGBM_Offset;

	private static bool MaxValueRGBM_IsValid;

	private static int MaxValueRGBM_Offset;

	private static bool CaptureOffset_IsValid;

	private static int CaptureOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ReflectionCaptureComponent:ReflectionSourceType")]
	public EReflectionSourceType ReflectionSourceType
	{
		get
		{
			CheckDestroyed();
			if (!ReflectionSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:ReflectionSourceType");
				return EReflectionSourceType.CapturedScene;
			}
			return EnumMarshaler<EReflectionSourceType>.FromNative(IntPtr.Add(base.Address, ReflectionSourceType_Offset), 0, ReflectionSourceType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ReflectionSourceType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:ReflectionSourceType");
			}
			else
			{
				EnumMarshaler<EReflectionSourceType>.ToNative(IntPtr.Add(base.Address, ReflectionSourceType_Offset), 0, ReflectionSourceType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ReflectionCaptureComponent:MobileReflectionCompression")]
	public EMobileReflectionCompression MobileReflectionCompression
	{
		get
		{
			CheckDestroyed();
			if (!MobileReflectionCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:MobileReflectionCompression");
				return EMobileReflectionCompression.Default;
			}
			return EnumMarshaler<EMobileReflectionCompression>.FromNative(IntPtr.Add(base.Address, MobileReflectionCompression_Offset), 0, MobileReflectionCompression_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MobileReflectionCompression_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:MobileReflectionCompression");
			}
			else
			{
				EnumMarshaler<EMobileReflectionCompression>.ToNative(IntPtr.Add(base.Address, MobileReflectionCompression_Offset), 0, MobileReflectionCompression_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.ReflectionCaptureComponent:Cubemap")]
	public UTextureCube Cubemap
	{
		get
		{
			CheckDestroyed();
			if (!Cubemap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:Cubemap");
				return null;
			}
			return UObjectMarshaler<UTextureCube>.FromNative(IntPtr.Add(base.Address, Cubemap_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Cubemap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:Cubemap");
			}
			else
			{
				UObjectMarshaler<UTextureCube>.ToNative(IntPtr.Add(base.Address, Cubemap_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ReflectionCaptureComponent:SourceCubemapAngle")]
	public float SourceCubemapAngle
	{
		get
		{
			CheckDestroyed();
			if (!SourceCubemapAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:SourceCubemapAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SourceCubemapAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceCubemapAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:SourceCubemapAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SourceCubemapAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ReflectionCaptureComponent:Brightness")]
	public float Brightness
	{
		get
		{
			CheckDestroyed();
			if (!Brightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:Brightness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Brightness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Brightness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:Brightness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Brightness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ReflectionCaptureComponent:bModifyMaxValueRGBM")]
	public bool ModifyMaxValueRGBM
	{
		get
		{
			CheckDestroyed();
			if (!ModifyMaxValueRGBM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:bModifyMaxValueRGBM");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ModifyMaxValueRGBM_Offset), 0, ModifyMaxValueRGBM_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ModifyMaxValueRGBM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:bModifyMaxValueRGBM");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ModifyMaxValueRGBM_Offset), 0, ModifyMaxValueRGBM_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.ReflectionCaptureComponent:MaxValueRGBM")]
	public float MaxValueRGBM
	{
		get
		{
			CheckDestroyed();
			if (!MaxValueRGBM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:MaxValueRGBM");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxValueRGBM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxValueRGBM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:MaxValueRGBM");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxValueRGBM_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.ReflectionCaptureComponent:CaptureOffset")]
	public FVector CaptureOffset
	{
		get
		{
			CheckDestroyed();
			if (!CaptureOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:CaptureOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CaptureOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CaptureOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ReflectionCaptureComponent:CaptureOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CaptureOffset_Offset), value);
			}
		}
	}

	static UReflectionCaptureComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UReflectionCaptureComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UReflectionCaptureComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.ReflectionCaptureComponent");
		NativeReflectionCached.GetPropertyRef(ref ReflectionSourceType_PropertyAddress, unrealStruct, "ReflectionSourceType");
		ReflectionSourceType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ReflectionSourceType");
		ReflectionSourceType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ReflectionSourceType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MobileReflectionCompression_PropertyAddress, unrealStruct, "MobileReflectionCompression");
		MobileReflectionCompression_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MobileReflectionCompression");
		MobileReflectionCompression_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MobileReflectionCompression", Classes.FEnumProperty);
		Cubemap_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Cubemap");
		Cubemap_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Cubemap", Classes.FObjectProperty);
		SourceCubemapAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SourceCubemapAngle");
		SourceCubemapAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SourceCubemapAngle", Classes.FFloatProperty);
		Brightness_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Brightness");
		Brightness_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Brightness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ModifyMaxValueRGBM_PropertyAddress, unrealStruct, "bModifyMaxValueRGBM");
		ModifyMaxValueRGBM_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bModifyMaxValueRGBM");
		ModifyMaxValueRGBM_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bModifyMaxValueRGBM", Classes.FBoolProperty);
		MaxValueRGBM_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxValueRGBM");
		MaxValueRGBM_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxValueRGBM", Classes.FFloatProperty);
		CaptureOffset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CaptureOffset");
		CaptureOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CaptureOffset", Classes.FStructProperty);
	}
}
