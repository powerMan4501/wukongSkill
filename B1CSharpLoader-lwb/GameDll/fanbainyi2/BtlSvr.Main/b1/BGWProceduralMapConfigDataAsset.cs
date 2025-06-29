using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset")]
public class BGWProceduralMapConfigDataAsset : UBGWDataAsset
{
	private static bool MapType_IsValid;

	private static int MapType_Offset;

	private static FFieldAddress MapType_PropertyAddress;

	private static bool MapWidth_IsValid;

	private static int MapWidth_Offset;

	private static bool MapHeight_IsValid;

	private static int MapHeight_Offset;

	private static bool BlockWidth_IsValid;

	private static int BlockWidth_Offset;

	private static bool BlockHeight_IsValid;

	private static int BlockHeight_Offset;

	private static bool IsUsingRanEE_IsValid;

	private static int IsUsingRanEE_Offset;

	private static FFieldAddress IsUsingRanEE_PropertyAddress;

	private static bool EntranceX_IsValid;

	private static int EntranceX_Offset;

	private static bool EntranceY_IsValid;

	private static int EntranceY_Offset;

	private static bool ExitX_IsValid;

	private static int ExitX_Offset;

	private static bool ExitY_IsValid;

	private static int ExitY_Offset;

	private static bool ExpectedPointNumber_IsValid;

	private static int ExpectedPointNumber_Offset;

	private static bool MinPointWidth_IsValid;

	private static int MinPointWidth_Offset;

	private static bool MinPointHeight_IsValid;

	private static int MinPointHeight_Offset;

	private static bool MaxPointWidth_IsValid;

	private static int MaxPointWidth_Offset;

	private static bool MaxPointHeight_IsValid;

	private static int MaxPointHeight_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[DisplayName("地图类型")]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapType")]
	public ProceduralMapType MapType
	{
		get
		{
			CheckDestroyed();
			if (!MapType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapType");
				return ProceduralMapType.PROCEDURAL_DUNGEON;
			}
			return EnumMarshaler<ProceduralMapType>.FromNative(IntPtr.Add(base.Address, MapType_Offset), 0, MapType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MapType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapType");
			}
			else
			{
				EnumMarshaler<ProceduralMapType>.ToNative(IntPtr.Add(base.Address, MapType_Offset), 0, MapType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("地图宽度地块数量（X轴）")]
	[UMeta(MDProp.ClampMin, 2)]
	[BlueprintReadWrite]
	[UProperty]
	[Category("Map Setting")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapWidth")]
	public int MapWidth
	{
		get
		{
			CheckDestroyed();
			if (!MapWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapWidth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MapWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapWidth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MapWidth_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[DisplayName("地图高度地块数量（Y轴）")]
	[UMeta(MDProp.ClampMin, 2)]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapHeight")]
	public int MapHeight
	{
		get
		{
			CheckDestroyed();
			if (!MapHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapHeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MapHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MapHeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MapHeight_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 1400)]
	[EditAnywhere]
	[Category("Map Setting")]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("地块在世界中宽度（X轴）")]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:BlockWidth")]
	public int BlockWidth
	{
		get
		{
			CheckDestroyed();
			if (!BlockWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:BlockWidth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BlockWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlockWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:BlockWidth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BlockWidth_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 1400)]
	[UProperty]
	[Category("Map Setting")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("地块在世界中高度（Y轴）")]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:BlockHeight")]
	public int BlockHeight
	{
		get
		{
			CheckDestroyed();
			if (!BlockHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:BlockHeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BlockHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlockHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:BlockHeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BlockHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[DisplayName("是否采用随机入口和出口坐标")]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:IsUsingRanEE")]
	public bool IsUsingRanEE
	{
		get
		{
			CheckDestroyed();
			if (!IsUsingRanEE_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:IsUsingRanEE");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUsingRanEE_Offset), 0, IsUsingRanEE_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUsingRanEE_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:IsUsingRanEE");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUsingRanEE_Offset), 0, IsUsingRanEE_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.EditCondition, "!IsUsingRanEE")]
	[Category("Map Setting")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("入口在地图地块集合中的X坐标")]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:EntranceX")]
	public int EntranceX
	{
		get
		{
			CheckDestroyed();
			if (!EntranceX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:EntranceX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EntranceX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EntranceX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:EntranceX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EntranceX_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[DisplayName("入口在地图地块集合中的Y坐标")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.EditCondition, "!IsUsingRanEE")]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:EntranceY")]
	public int EntranceY
	{
		get
		{
			CheckDestroyed();
			if (!EntranceY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:EntranceY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EntranceY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EntranceY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:EntranceY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EntranceY_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!IsUsingRanEE")]
	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[UProperty]
	[EditAnywhere]
	[DisplayName("出口在地图地块集合中的X坐标")]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExitX")]
	public int ExitX
	{
		get
		{
			CheckDestroyed();
			if (!ExitX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExitX");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ExitX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExitX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExitX");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ExitX_Offset), value);
			}
		}
	}

	[Category("Map Setting")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("出口在地图地块集合中的Y坐标")]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.EditCondition, "!IsUsingRanEE")]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExitY")]
	public int ExitY
	{
		get
		{
			CheckDestroyed();
			if (!ExitY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExitY");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ExitY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExitY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExitY");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ExitY_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[DisplayName("期望控制点数量")]
	[UMeta(MDProp.ClampMin, 1)]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExpectedPointNumber")]
	public int ExpectedPointNumber
	{
		get
		{
			CheckDestroyed();
			if (!ExpectedPointNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExpectedPointNumber");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ExpectedPointNumber_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExpectedPointNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:ExpectedPointNumber");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ExpectedPointNumber_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[DisplayName("最小控制点宽度地块数")]
	[UMeta(MDProp.ClampMin, 1)]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MinPointWidth")]
	public int MinPointWidth
	{
		get
		{
			CheckDestroyed();
			if (!MinPointWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MinPointWidth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinPointWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinPointWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MinPointWidth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinPointWidth_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 1)]
	[DisplayName("最小控制点高度地块数")]
	[EditAnywhere]
	[UProperty]
	[Category("Map Setting")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MinPointHeight")]
	public int MinPointHeight
	{
		get
		{
			CheckDestroyed();
			if (!MinPointHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MinPointHeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinPointHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinPointHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MinPointHeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinPointHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[DisplayName("最大控制点宽度地块数")]
	[UMeta(MDProp.ClampMin, 1)]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MaxPointWidth")]
	public int MaxPointWidth
	{
		get
		{
			CheckDestroyed();
			if (!MaxPointWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MaxPointWidth");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxPointWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxPointWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MaxPointWidth");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxPointWidth_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Setting")]
	[DisplayName("最大普通房间高度地块数")]
	[UMeta(MDProp.ClampMin, 1)]
	[USharpPath("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MaxPointHeight")]
	public int MaxPointHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxPointHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MaxPointHeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxPointHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxPointHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralMapConfigDataAsset:MaxPointHeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxPointHeight_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWProceduralMapConfigDataAsset");
		NativeReflection.GetPropertyRef(ref MapType_PropertyAddress, unrealStruct, "MapType");
		MapType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapType");
		MapType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapType", Classes.FEnumProperty);
		MapWidth_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapWidth");
		MapWidth_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapWidth", Classes.FIntProperty);
		MapHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapHeight");
		MapHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapHeight", Classes.FIntProperty);
		BlockWidth_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlockWidth");
		BlockWidth_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlockWidth", Classes.FIntProperty);
		BlockHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlockHeight");
		BlockHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlockHeight", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref IsUsingRanEE_PropertyAddress, unrealStruct, "IsUsingRanEE");
		IsUsingRanEE_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsUsingRanEE");
		IsUsingRanEE_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsUsingRanEE", Classes.FBoolProperty);
		EntranceX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EntranceX");
		EntranceX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EntranceX", Classes.FIntProperty);
		EntranceY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EntranceY");
		EntranceY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EntranceY", Classes.FIntProperty);
		ExitX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExitX");
		ExitX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExitX", Classes.FIntProperty);
		ExitY_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExitY");
		ExitY_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExitY", Classes.FIntProperty);
		ExpectedPointNumber_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExpectedPointNumber");
		ExpectedPointNumber_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExpectedPointNumber", Classes.FIntProperty);
		MinPointWidth_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinPointWidth");
		MinPointWidth_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinPointWidth", Classes.FIntProperty);
		MinPointHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinPointHeight");
		MinPointHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinPointHeight", Classes.FIntProperty);
		MaxPointWidth_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxPointWidth");
		MaxPointWidth_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxPointWidth", Classes.FIntProperty);
		MaxPointHeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxPointHeight");
		MaxPointHeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxPointHeight", Classes.FIntProperty);
	}

	static BGWProceduralMapConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWProceduralMapConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWProceduralMapConfigDataAsset));
	}
}
