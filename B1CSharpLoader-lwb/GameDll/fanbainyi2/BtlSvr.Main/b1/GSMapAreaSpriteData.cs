using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSMapAreaSpriteData")]
public class GSMapAreaSpriteData : UDataAsset
{
	private static bool Widght_IsValid;

	private static int Widght_Offset;

	private static bool Height_IsValid;

	private static int Height_Offset;

	private static bool MapSpriteData_IsValid;

	private static int MapSpriteData_Offset;

	private static FFieldAddress MapSpriteData_PropertyAddress;

	private TMapReadWriteMarshaler<int, byte> MapSpriteData_Marshaler;

	[Tooltip("宽度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMapAreaSpriteData:Widght")]
	public int Widght
	{
		get
		{
			CheckDestroyed();
			if (!Widght_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaSpriteData:Widght");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Widght_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Widght_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaSpriteData:Widght");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Widght_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("高度")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMapAreaSpriteData:Height")]
	public int Height
	{
		get
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaSpriteData:Height");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Height_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Height_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaSpriteData:Height");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Height_Offset), value);
			}
		}
	}

	[Tooltip("地图图层数据")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMapAreaSpriteData:MapSpriteData")]
	public TMapReadWrite<int, byte> MapSpriteData
	{
		get
		{
			CheckDestroyed();
			if (!MapSpriteData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaSpriteData:MapSpriteData");
				return null;
			}
			if (MapSpriteData_Marshaler == null)
			{
				MapSpriteData_Marshaler = new TMapReadWriteMarshaler<int, byte>(1, MapSpriteData_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative);
			}
			return MapSpriteData_Marshaler.FromNative(IntPtr.Add(base.Address, MapSpriteData_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSMapAreaSpriteData");
		Widght_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Widght");
		Widght_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Widght", Classes.FIntProperty);
		Height_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Height");
		Height_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Height", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref MapSpriteData_PropertyAddress, unrealStruct, "MapSpriteData");
		MapSpriteData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapSpriteData");
		MapSpriteData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapSpriteData", Classes.FMapProperty);
	}

	static GSMapAreaSpriteData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSMapAreaSpriteData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSMapAreaSpriteData));
	}
}
