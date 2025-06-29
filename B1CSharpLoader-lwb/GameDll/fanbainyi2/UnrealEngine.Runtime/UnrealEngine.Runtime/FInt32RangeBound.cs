using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 57352)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Int32RangeBound", "CoreUObject", UnrealModuleType.Engine)]
public struct FInt32RangeBound : IEquatable<FInt32RangeBound>
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.Int32RangeBound:Type")]
	public ERangeBoundTypes Type;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.Int32RangeBound:Value")]
	public int Value;

	private static int FInt32RangeBound_StructSize;

	public FInt32RangeBound Copy()
	{
		return this;
	}

	static FInt32RangeBound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInt32RangeBound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInt32RangeBound));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.Int32RangeBound");
		FInt32RangeBound_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, unrealStruct, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Type", Classes.FByteProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Value", Classes.FFloatProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FInt32RangeBound));
	}

	public FInt32RangeBound(int value)
	{
		Type = ERangeBoundTypes.Inclusive;
		Value = value;
	}

	public static bool operator ==(FInt32RangeBound a, FInt32RangeBound b)
	{
		if (a.Type == b.Type)
		{
			if (!a.IsOpen())
			{
				return a.Value == b.Value;
			}
			return true;
		}
		return false;
	}

	public static bool operator !=(FInt32RangeBound a, FInt32RangeBound b)
	{
		if (a.Type == b.Type)
		{
			if (!a.IsOpen())
			{
				return a.Value != b.Value;
			}
			return false;
		}
		return true;
	}

	public override bool Equals(object obj)
	{
		if (!(obj is FInt32RangeBound))
		{
			return false;
		}
		return Equals((FInt32RangeBound)obj);
	}

	public bool Equals(FInt32RangeBound other)
	{
		if (Type == other.Type)
		{
			if (!IsOpen())
			{
				return Value == other.Value;
			}
			return true;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (Type.GetHashCode() * 397) ^ Value.GetHashCode();
	}

	public int GetValue()
	{
		return Value;
	}

	public void SetValue(int value)
	{
		Value = value;
	}

	public bool IsClosed()
	{
		return Type != ERangeBoundTypes.Open;
	}

	public bool IsExclusive()
	{
		return Type == ERangeBoundTypes.Exclusive;
	}

	public bool IsInclusive()
	{
		return Type == ERangeBoundTypes.Inclusive;
	}

	public bool IsOpen()
	{
		return Type == ERangeBoundTypes.Open;
	}

	public static FInt32RangeBound Exclusive(int value)
	{
		FInt32RangeBound result = default(FInt32RangeBound);
		result.Type = ERangeBoundTypes.Exclusive;
		result.Value = value;
		return result;
	}

	public static FInt32RangeBound Inclusive(int value)
	{
		FInt32RangeBound result = default(FInt32RangeBound);
		result.Type = ERangeBoundTypes.Inclusive;
		result.Value = value;
		return result;
	}

	public static FInt32RangeBound Open()
	{
		FInt32RangeBound result = default(FInt32RangeBound);
		result.Type = ERangeBoundTypes.Open;
		result.Value = 0;
		return result;
	}

	public static FInt32RangeBound FlipInclusion(FInt32RangeBound bound)
	{
		if (bound.IsExclusive())
		{
			return Inclusive(bound.Value);
		}
		if (bound.IsInclusive())
		{
			return Exclusive(bound.Value);
		}
		return bound;
	}

	public static FInt32RangeBound MaxLower(FInt32RangeBound a, FInt32RangeBound b)
	{
		if (a.IsOpen())
		{
			return b;
		}
		if (b.IsOpen())
		{
			return a;
		}
		if (a.Value > b.Value)
		{
			return a;
		}
		if (b.Value > a.Value)
		{
			return b;
		}
		if (a.IsExclusive())
		{
			return a;
		}
		return b;
	}

	public static FInt32RangeBound MaxUpper(FInt32RangeBound a, FInt32RangeBound b)
	{
		if (a.IsOpen())
		{
			return a;
		}
		if (b.IsOpen())
		{
			return b;
		}
		if (a.Value > b.Value)
		{
			return a;
		}
		if (b.Value > a.Value)
		{
			return b;
		}
		if (a.IsInclusive())
		{
			return a;
		}
		return b;
	}

	public static FInt32RangeBound MinLower(FInt32RangeBound a, FInt32RangeBound b)
	{
		if (a.IsOpen())
		{
			return a;
		}
		if (b.IsOpen())
		{
			return b;
		}
		if (a.Value < b.Value)
		{
			return a;
		}
		_ = b.Value;
		_ = a.Value;
		return b;
	}

	public static FInt32RangeBound MinUpper(FInt32RangeBound a, FInt32RangeBound b)
	{
		if (a.IsOpen())
		{
			return b;
		}
		if (b.IsOpen())
		{
			return a;
		}
		if (a.Value < b.Value)
		{
			return a;
		}
		if (b.Value < a.Value)
		{
			return b;
		}
		if (a.IsExclusive())
		{
			return a;
		}
		return b;
	}
}
