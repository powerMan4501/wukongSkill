using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.WEFMLODSetting")]
public struct WEFMLODSetting
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.WEFMLODSetting:CellLength")]
	public float CellLength;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.WEFMLODSetting:CellNumV3")]
	public FVector CellNumV3;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.WEFMLODSetting:ScaleRT2DSize")]
	public float ScaleRT2DSize;

	private static int WEFMLODSetting_StructSize;

	public bool isValid()
	{
		float num = (int)Math.Sqrt(CellNumV3.Z);
		if (Math.Abs(num * num - CellNumV3.Z) >= 0.01f)
		{
			return false;
		}
		if (CellLength > 0f && !CellNumV3.Vector_IsNAN() && CellNumV3.X >= 0f && CellNumV3.Y >= 0f && CellNumV3.Z >= 0f)
		{
			return ScaleRT2DSize > 0f;
		}
		return false;
	}

	public static WEFMLODSetting GetNewSettingInCSharpByCustomData(float _CellLength, FVector _CellNumV3, float _ScaleRT2DSize)
	{
		WEFMLODSetting result = default(WEFMLODSetting);
		result.CellLength = _CellLength;
		result.CellNumV3 = _CellNumV3;
		result.ScaleRT2DSize = _ScaleRT2DSize;
		return result;
	}

	public WEFMLODSetting Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.WEFMLODSetting");
		WEFMLODSetting_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(WEFMLODSetting));
	}

	static WEFMLODSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(WEFMLODSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(WEFMLODSetting));
	}
}
