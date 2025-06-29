using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 57352)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.FloatRangeBound", "CoreUObject", UnrealModuleType.Engine)]
public struct FFloatRangeBound : IEquatable<FFloatRangeBound>
{
	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.FloatRangeBound:Type")]
	public ERangeBoundTypes Type;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CoreUObject.FloatRangeBound:Value")]
	public float Value;

	private static int FFloatRangeBound_StructSize;

	public FFloatRangeBound Copy()
	{
		return this;
	}

	static FFloatRangeBound()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFloatRangeBound)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFloatRangeBound));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreUObject.FloatRangeBound");
		FFloatRangeBound_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, unrealStruct, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Type", Classes.FByteProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Value", Classes.FFloatProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FFloatRangeBound));
	}

	public FFloatRangeBound(float value)
	{
		Type = ERangeBoundTypes.Inclusive;
		Value = value;
	}

	public static bool operator ==(FFloatRangeBound a, FFloatRangeBound b)
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

	public static bool operator !=(FFloatRangeBound a, FFloatRangeBound b)
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
		if (!(obj is FFloatRangeBound))
		{
			return false;
		}
		return Equals((FFloatRangeBound)obj);
	}

	public bool Equals(FFloatRangeBound other)
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

	public float GetValue()
	{
		return Value;
	}

	public void SetValue(float value)
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

	public static FFloatRangeBound Exclusive(float value)
	{
		FFloatRangeBound result = default(FFloatRangeBound);
		result.Type = ERangeBoundTypes.Exclusive;
		result.Value = value;
		return result;
	}

	public static FFloatRangeBound Inclusive(float value)
	{
		FFloatRangeBound result = default(FFloatRangeBound);
		result.Type = ERangeBoundTypes.Inclusive;
		result.Value = value;
		return result;
	}

	public static FFloatRangeBound Open()
	{
		FFloatRangeBound result = default(FFloatRangeBound);
		result.Type = ERangeBoundTypes.Open;
		result.Value = 0f;
		return result;
	}

	public static FFloatRangeBound FlipInclusion(FFloatRangeBound bound)
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

	public static FFloatRangeBound MaxLower(FFloatRangeBound a, FFloatRangeBound b)
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

	public static FFloatRangeBound MaxUpper(FFloatRangeBound a, FFloatRangeBound b)
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

	public static FFloatRangeBound MinLower(FFloatRangeBound a, FFloatRangeBound b)
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

	public static FFloatRangeBound MinUpper(FFloatRangeBound a, FFloatRangeBound b)
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
