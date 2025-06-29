using System;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.GSEQG_Donut", "b1", UnrealModuleType.Game)]
public class UGSEQG_Donut : UGSEQG_SimpleTeleport
{
	private static bool InnerRadius_IsValid;

	private static int InnerRadius_Offset;

	private static bool OuterRadius_IsValid;

	private static int OuterRadius_Offset;

	private static bool NumberOfRings_IsValid;

	private static int NumberOfRings_Offset;

	private static bool PointsPerRing_IsValid;

	private static int PointsPerRing_Offset;

	private static bool AngleCenterDirection_IsValid;

	private static FFieldAddress AngleCenterDirection_PropertyAddress;

	private static int AngleCenterDirection_Offset;

	private static bool LeftAngle_IsValid;

	private static int LeftAngle_Offset;

	private static bool RightAngle_IsValid;

	private static int RightAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Donut:InnerRadius")]
	public float InnerRadius
	{
		get
		{
			CheckDestroyed();
			if (!InnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:InnerRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InnerRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InnerRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:InnerRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InnerRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Donut:OuterRadius")]
	public float OuterRadius
	{
		get
		{
			CheckDestroyed();
			if (!OuterRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:OuterRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OuterRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OuterRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:OuterRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OuterRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Donut:NumberOfRings")]
	public int NumberOfRings
	{
		get
		{
			CheckDestroyed();
			if (!NumberOfRings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:NumberOfRings");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumberOfRings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumberOfRings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:NumberOfRings");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumberOfRings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Donut:PointsPerRing")]
	public int PointsPerRing
	{
		get
		{
			CheckDestroyed();
			if (!PointsPerRing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:PointsPerRing");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PointsPerRing_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointsPerRing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:PointsPerRing");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PointsPerRing_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Donut:AngleCenterDirection")]
	public EGSAngleCenterDirection AngleCenterDirection
	{
		get
		{
			CheckDestroyed();
			if (!AngleCenterDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:AngleCenterDirection");
				return EGSAngleCenterDirection.Forward;
			}
			return EnumMarshaler<EGSAngleCenterDirection>.FromNative(IntPtr.Add(base.Address, AngleCenterDirection_Offset), 0, AngleCenterDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AngleCenterDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:AngleCenterDirection");
			}
			else
			{
				EnumMarshaler<EGSAngleCenterDirection>.ToNative(IntPtr.Add(base.Address, AngleCenterDirection_Offset), 0, AngleCenterDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Donut:LeftAngle")]
	public float LeftAngle
	{
		get
		{
			CheckDestroyed();
			if (!LeftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:LeftAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeftAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:LeftAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeftAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Donut:RightAngle")]
	public float RightAngle
	{
		get
		{
			CheckDestroyed();
			if (!RightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:RightAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RightAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Donut:RightAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RightAngle_Offset), value);
			}
		}
	}

	static UGSEQG_Donut()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEQG_Donut)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEQG_Donut));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.GSEQG_Donut");
		InnerRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InnerRadius");
		InnerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InnerRadius", Classes.FFloatProperty);
		OuterRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OuterRadius");
		OuterRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OuterRadius", Classes.FFloatProperty);
		NumberOfRings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumberOfRings");
		NumberOfRings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumberOfRings", Classes.FIntProperty);
		PointsPerRing_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PointsPerRing");
		PointsPerRing_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PointsPerRing", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AngleCenterDirection_PropertyAddress, unrealStruct, "AngleCenterDirection");
		AngleCenterDirection_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AngleCenterDirection");
		AngleCenterDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AngleCenterDirection", Classes.FEnumProperty);
		LeftAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LeftAngle");
		LeftAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LeftAngle", Classes.FFloatProperty);
		RightAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RightAngle");
		RightAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RightAngle", Classes.FFloatProperty);
	}
}
