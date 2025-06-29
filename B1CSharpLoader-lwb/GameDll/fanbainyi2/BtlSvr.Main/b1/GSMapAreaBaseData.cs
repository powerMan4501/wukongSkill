using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSMapAreaBaseData")]
public class GSMapAreaBaseData : UDataAsset
{
	private static bool AreaColorData_IsValid;

	private static int AreaColorData_Offset;

	private static FFieldAddress AreaColorData_PropertyAddress;

	private TMapReadWriteMarshaler<FColor, int> AreaColorData_Marshaler;

	private static bool OriginPos_IsValid;

	private static int OriginPos_Offset;

	private static bool MapSize_IsValid;

	private static int MapSize_Offset;

	private static bool MapScale_IsValid;

	private static int MapScale_Offset;

	[Tooltip("缩略图颜色与区域ID索引")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMapAreaBaseData:AreaColorData")]
	public TMapReadWrite<FColor, int> AreaColorData
	{
		get
		{
			CheckDestroyed();
			if (!AreaColorData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaBaseData:AreaColorData");
				return null;
			}
			if (AreaColorData_Marshaler == null)
			{
				AreaColorData_Marshaler = new TMapReadWriteMarshaler<FColor, int>(1, AreaColorData_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return AreaColorData_Marshaler.FromNative(IntPtr.Add(base.Address, AreaColorData_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("原点对应的缩略图格子Pos")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMapAreaBaseData:OriginPos")]
	public FVector2D OriginPos
	{
		get
		{
			CheckDestroyed();
			if (!OriginPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaBaseData:OriginPos");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, OriginPos_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OriginPos_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaBaseData:OriginPos");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, OriginPos_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("缩略图格子大小")]
	[USharpPath("/Script/b1-Managed.GSMapAreaBaseData:MapSize")]
	public FVector2D MapSize
	{
		get
		{
			CheckDestroyed();
			if (!MapSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaBaseData:MapSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, MapSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaBaseData:MapSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, MapSize_Offset), value);
			}
		}
	}

	[Tooltip("缩略图与真实地图的缩放比例")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSMapAreaBaseData:MapScale")]
	public float MapScale
	{
		get
		{
			CheckDestroyed();
			if (!MapScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaBaseData:MapScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MapScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaBaseData:MapScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MapScale_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSMapAreaBaseData");
		NativeReflection.GetPropertyRef(ref AreaColorData_PropertyAddress, unrealStruct, "AreaColorData");
		AreaColorData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AreaColorData");
		AreaColorData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AreaColorData", Classes.FMapProperty);
		OriginPos_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OriginPos");
		OriginPos_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OriginPos", Classes.FStructProperty);
		MapSize_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapSize");
		MapSize_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapSize", Classes.FStructProperty);
		MapScale_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapScale");
		MapScale_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapScale", Classes.FFloatProperty);
	}

	static GSMapAreaBaseData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSMapAreaBaseData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSMapAreaBaseData));
	}
}
