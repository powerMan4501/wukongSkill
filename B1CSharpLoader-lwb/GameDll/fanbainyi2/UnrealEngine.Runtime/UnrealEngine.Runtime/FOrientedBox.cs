using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 24632)]
[UMetaPath("/Script/CoreUObject.OrientedBox", "CoreUObject", UnrealModuleType.Engine)]
public struct FOrientedBox : IEquatable<FOrientedBox>
{
	private static bool Center_IsValid;

	private static int Center_Offset;

	[UProperty(Flags = (PropFlags)6755469251051521uL)]
	[UMetaPath("/Script/CoreUObject.OrientedBox:Center")]
	public FVector Center;

	private static bool AxisX_IsValid;

	private static int AxisX_Offset;

	[UProperty(Flags = (PropFlags)6755469251051521uL)]
	[UMetaPath("/Script/CoreUObject.OrientedBox:AxisX")]
	public FVector AxisX;

	private static bool AxisY_IsValid;

	private static int AxisY_Offset;

	[UProperty(Flags = (PropFlags)6755469251051521uL)]
	[UMetaPath("/Script/CoreUObject.OrientedBox:AxisY")]
	public FVector AxisY;

	private static bool AxisZ_IsValid;

	private static int AxisZ_Offset;

	[UProperty(Flags = (PropFlags)6755469251051521uL)]
	[UMetaPath("/Script/CoreUObject.OrientedBox:AxisZ")]
	public FVector AxisZ;

	private static bool ExtentX_IsValid;

	private static int ExtentX_Offset;

	[UProperty(Flags = (PropFlags)6755469251052033uL)]
	[UMetaPath("/Script/CoreUObject.OrientedBox:ExtentX")]
	public double ExtentX;

	private static bool ExtentY_IsValid;

	private static int ExtentY_Offset;

	[UProperty(Flags = (PropFlags)6755469251052033uL)]
	[UMetaPath("/Script/CoreUObject.OrientedBox:ExtentY")]
	public double ExtentY;

	private static bool ExtentZ_IsValid;

	private static int ExtentZ_Offset;

	[UProperty(Flags = (PropFlags)6755469251052033uL)]
	[UMetaPath("/Script/CoreUObject.OrientedBox:ExtentZ")]
	public double ExtentZ;

	private static int FOrientedBox_StructSize;

	public static readonly FOrientedBox Default;

	public FOrientedBox Copy()
	{
		return this;
	}

	static FOrientedBox()
	{
		Default = new FOrientedBox
		{
			Center = new FVector(0f),
			AxisX = new FVector(1.0, 0.0, 0.0),
			AxisY = new FVector(0.0, 1.0, 0.0),
			AxisZ = new FVector(0.0, 0.0, 1.0),
			ExtentX = 1.0,
			ExtentY = 1.0,
			ExtentZ = 1.0
		};
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOrientedBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOrientedBox));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.OrientedBox");
		FOrientedBox_StructSize = NativeReflection.GetStructSize(unrealStruct);
		Center_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Center");
		Center_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Center", Classes.FStructProperty);
		AxisX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AxisX");
		AxisX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AxisX", Classes.FStructProperty);
		AxisY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AxisY");
		AxisY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AxisY", Classes.FStructProperty);
		AxisZ_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AxisZ");
		AxisZ_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AxisZ", Classes.FStructProperty);
		ExtentX_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExtentX");
		ExtentX_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExtentX", Classes.FDoubleProperty);
		ExtentY_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExtentY");
		ExtentY_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExtentY", Classes.FDoubleProperty);
		ExtentZ_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ExtentZ");
		ExtentZ_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ExtentZ", Classes.FDoubleProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FOrientedBox));
	}

	public void CalcVertices(FVector[] verts)
	{
		double[] array = new double[2] { -1.0, 1.0 };
		int num = 0;
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					verts[num] = Center + array[i] * AxisX * ExtentX + array[j] * AxisY * ExtentY + array[k] * AxisZ * ExtentZ;
					num++;
				}
			}
		}
	}

	public FFloatInterval Project(FVector axis)
	{
		double[] array = new double[2] { -1.0, 1.0 };
		double num = axis | Center;
		double num2 = axis | (ExtentX * AxisX);
		double num3 = axis | (ExtentY * AxisY);
		double num4 = axis | (ExtentZ * AxisZ);
		FFloatInterval result = FFloatInterval.Default;
		for (int i = 0; i < 2; i++)
		{
			for (int j = 0; j < 2; j++)
			{
				for (int k = 0; k < 2; k++)
				{
					double num5 = num + array[i] * num2 + array[j] * num3 + array[k] * num4;
					result.Include((float)num5);
				}
			}
		}
		return result;
	}

	public static bool operator ==(FOrientedBox a, FOrientedBox b)
	{
		if (a.Center == b.Center && a.AxisX == b.AxisX && a.AxisY == b.AxisY && a.AxisZ == b.AxisZ && a.ExtentX == b.ExtentX && a.ExtentY == b.ExtentY)
		{
			return a.ExtentZ == b.ExtentZ;
		}
		return false;
	}

	public static bool operator !=(FOrientedBox a, FOrientedBox b)
	{
		if (!(a.Center != b.Center) && !(a.AxisX != b.AxisX) && !(a.AxisY != b.AxisY) && !(a.AxisZ != b.AxisZ) && a.ExtentX == b.ExtentX && a.ExtentY == b.ExtentY)
		{
			return a.ExtentZ != b.ExtentZ;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FOrientedBox))
		{
			return false;
		}
		return Equals((FOrientedBox)obj);
	}

	public bool Equals(FOrientedBox other)
	{
		if (Center == other.Center && AxisX == other.AxisX && AxisY == other.AxisY && AxisZ == other.AxisZ && ExtentX == other.ExtentX && ExtentY == other.ExtentY)
		{
			return ExtentZ == other.ExtentZ;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (((((((((((Center.GetHashCode() * 397) ^ AxisX.GetHashCode()) * 397) ^ AxisY.GetHashCode()) * 397) ^ AxisZ.GetHashCode()) * 397) ^ ExtentX.GetHashCode()) * 397) ^ ExtentY.GetHashCode()) * 397) ^ ExtentZ.GetHashCode();
	}
}
