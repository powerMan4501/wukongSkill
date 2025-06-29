using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)820523172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.DrawFrustumComponent", "Engine", UnrealModuleType.Engine)]
public class UDrawFrustumComponent : UPrimitiveComponent
{
	private static bool FrustumEnabled_IsValid;

	private static FFieldAddress FrustumEnabled_PropertyAddress;

	private static int FrustumEnabled_Offset;

	private static bool FrustumColor_IsValid;

	private static int FrustumColor_Offset;

	private static bool FrustumAngle_IsValid;

	private static int FrustumAngle_Offset;

	private static bool FrustumAspectRatio_IsValid;

	private static int FrustumAspectRatio_Offset;

	private static bool FrustumStartDist_IsValid;

	private static int FrustumStartDist_Offset;

	private static bool FrustumEndDist_IsValid;

	private static int FrustumEndDist_Offset;

	private static bool Texture_IsValid;

	private static int Texture_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DrawFrustumComponent:bFrustumEnabled")]
	public bool FrustumEnabled
	{
		get
		{
			CheckDestroyed();
			if (!FrustumEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:bFrustumEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, FrustumEnabled_Offset), 0, FrustumEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FrustumEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:bFrustumEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, FrustumEnabled_Offset), 0, FrustumEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DrawFrustumComponent:FrustumColor")]
	public FColor FrustumColor
	{
		get
		{
			CheckDestroyed();
			if (!FrustumColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, FrustumColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrustumColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, FrustumColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DrawFrustumComponent:FrustumAngle")]
	public float FrustumAngle
	{
		get
		{
			CheckDestroyed();
			if (!FrustumAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FrustumAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrustumAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FrustumAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DrawFrustumComponent:FrustumAspectRatio")]
	public float FrustumAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!FrustumAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumAspectRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FrustumAspectRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrustumAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumAspectRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FrustumAspectRatio_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DrawFrustumComponent:FrustumStartDist")]
	public float FrustumStartDist
	{
		get
		{
			CheckDestroyed();
			if (!FrustumStartDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumStartDist");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FrustumStartDist_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrustumStartDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumStartDist");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FrustumStartDist_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.DrawFrustumComponent:FrustumEndDist")]
	public float FrustumEndDist
	{
		get
		{
			CheckDestroyed();
			if (!FrustumEndDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumEndDist");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FrustumEndDist_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FrustumEndDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:FrustumEndDist");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FrustumEndDist_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.DrawFrustumComponent:Texture")]
	public UTexture Texture
	{
		get
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:Texture");
				return null;
			}
			return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(base.Address, Texture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.DrawFrustumComponent:Texture");
			}
			else
			{
				UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(base.Address, Texture_Offset), value);
			}
		}
	}

	static UDrawFrustumComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDrawFrustumComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDrawFrustumComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.DrawFrustumComponent");
		NativeReflectionCached.GetPropertyRef(ref FrustumEnabled_PropertyAddress, unrealStruct, "bFrustumEnabled");
		FrustumEnabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bFrustumEnabled");
		FrustumEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bFrustumEnabled", Classes.FBoolProperty);
		FrustumColor_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrustumColor");
		FrustumColor_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrustumColor", Classes.FStructProperty);
		FrustumAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrustumAngle");
		FrustumAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrustumAngle", Classes.FFloatProperty);
		FrustumAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrustumAspectRatio");
		FrustumAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrustumAspectRatio", Classes.FFloatProperty);
		FrustumStartDist_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrustumStartDist");
		FrustumStartDist_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrustumStartDist", Classes.FFloatProperty);
		FrustumEndDist_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FrustumEndDist");
		FrustumEndDist_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FrustumEndDist", Classes.FFloatProperty);
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Texture", Classes.FObjectProperty);
	}
}
