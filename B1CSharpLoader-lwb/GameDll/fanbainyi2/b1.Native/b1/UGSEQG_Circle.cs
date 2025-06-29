using System;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.GSEQG_Circle", "b1", UnrealModuleType.Game)]
public class UGSEQG_Circle : UGSEQG_SimpleTeleport
{
	private static bool CircleRadius_IsValid;

	private static int CircleRadius_Offset;

	private static bool SpaceBetween_IsValid;

	private static int SpaceBetween_Offset;

	private static bool NumberOfPoints_IsValid;

	private static int NumberOfPoints_Offset;

	private static bool PointOnCircleSpacingMethod_IsValid;

	private static FFieldAddress PointOnCircleSpacingMethod_PropertyAddress;

	private static int PointOnCircleSpacingMethod_Offset;

	private static bool AngleCenterDirection_IsValid;

	private static FFieldAddress AngleCenterDirection_PropertyAddress;

	private static int AngleCenterDirection_Offset;

	private static bool LeftAngle_IsValid;

	private static int LeftAngle_Offset;

	private static bool RightAngle_IsValid;

	private static int RightAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Circle:CircleRadius")]
	public float CircleRadius
	{
		get
		{
			CheckDestroyed();
			if (!CircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:CircleRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CircleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:CircleRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CircleRadius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Circle:SpaceBetween")]
	public float SpaceBetween
	{
		get
		{
			CheckDestroyed();
			if (!SpaceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:SpaceBetween");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpaceBetween_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpaceBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:SpaceBetween");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpaceBetween_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Circle:NumberOfPoints")]
	public int NumberOfPoints
	{
		get
		{
			CheckDestroyed();
			if (!NumberOfPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:NumberOfPoints");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumberOfPoints_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumberOfPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:NumberOfPoints");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumberOfPoints_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Circle:PointOnCircleSpacingMethod")]
	public EGSPointOnCircleSpacingMethod PointOnCircleSpacingMethod
	{
		get
		{
			CheckDestroyed();
			if (!PointOnCircleSpacingMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:PointOnCircleSpacingMethod");
				return EGSPointOnCircleSpacingMethod.BySpaceBetween;
			}
			return EnumMarshaler<EGSPointOnCircleSpacingMethod>.FromNative(IntPtr.Add(base.Address, PointOnCircleSpacingMethod_Offset), 0, PointOnCircleSpacingMethod_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PointOnCircleSpacingMethod_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:PointOnCircleSpacingMethod");
			}
			else
			{
				EnumMarshaler<EGSPointOnCircleSpacingMethod>.ToNative(IntPtr.Add(base.Address, PointOnCircleSpacingMethod_Offset), 0, PointOnCircleSpacingMethod_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Circle:AngleCenterDirection")]
	public EGSAngleCenterDirection AngleCenterDirection
	{
		get
		{
			CheckDestroyed();
			if (!AngleCenterDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:AngleCenterDirection");
				return EGSAngleCenterDirection.Forward;
			}
			return EnumMarshaler<EGSAngleCenterDirection>.FromNative(IntPtr.Add(base.Address, AngleCenterDirection_Offset), 0, AngleCenterDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AngleCenterDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:AngleCenterDirection");
			}
			else
			{
				EnumMarshaler<EGSAngleCenterDirection>.ToNative(IntPtr.Add(base.Address, AngleCenterDirection_Offset), 0, AngleCenterDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Circle:LeftAngle")]
	public float LeftAngle
	{
		get
		{
			CheckDestroyed();
			if (!LeftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:LeftAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LeftAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:LeftAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LeftAngle_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQG_Circle:RightAngle")]
	public float RightAngle
	{
		get
		{
			CheckDestroyed();
			if (!RightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:RightAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RightAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.GSEQG_Circle:RightAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RightAngle_Offset), value);
			}
		}
	}

	static UGSEQG_Circle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEQG_Circle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEQG_Circle));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.GSEQG_Circle");
		CircleRadius_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CircleRadius");
		CircleRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CircleRadius", Classes.FFloatProperty);
		SpaceBetween_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SpaceBetween");
		SpaceBetween_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SpaceBetween", Classes.FFloatProperty);
		NumberOfPoints_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NumberOfPoints");
		NumberOfPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NumberOfPoints", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PointOnCircleSpacingMethod_PropertyAddress, unrealStruct, "PointOnCircleSpacingMethod");
		PointOnCircleSpacingMethod_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PointOnCircleSpacingMethod");
		PointOnCircleSpacingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PointOnCircleSpacingMethod", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AngleCenterDirection_PropertyAddress, unrealStruct, "AngleCenterDirection");
		AngleCenterDirection_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AngleCenterDirection");
		AngleCenterDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AngleCenterDirection", Classes.FEnumProperty);
		LeftAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LeftAngle");
		LeftAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LeftAngle", Classes.FFloatProperty);
		RightAngle_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "RightAngle");
		RightAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "RightAngle", Classes.FFloatProperty);
	}
}
