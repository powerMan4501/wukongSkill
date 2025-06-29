using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSMapAreaDetailData")]
public class GSMapAreaDetailData : UDataAsset
{
	private static bool MapAreaData_IsValid;

	private static int MapAreaData_Offset;

	private static FFieldAddress MapAreaData_PropertyAddress;

	private TMapReadWriteMarshaler<int, byte> MapAreaData_Marshaler;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("详细区域数据")]
	[USharpPath("/Script/b1-Managed.GSMapAreaDetailData:MapAreaData")]
	public TMapReadWrite<int, byte> MapAreaData
	{
		get
		{
			CheckDestroyed();
			if (!MapAreaData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSMapAreaDetailData:MapAreaData");
				return null;
			}
			if (MapAreaData_Marshaler == null)
			{
				MapAreaData_Marshaler = new TMapReadWriteMarshaler<int, byte>(1, MapAreaData_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative);
			}
			return MapAreaData_Marshaler.FromNative(IntPtr.Add(base.Address, MapAreaData_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.GSMapAreaDetailData");
		NativeReflection.GetPropertyRef(ref MapAreaData_PropertyAddress, unrealStruct, "MapAreaData");
		MapAreaData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapAreaData");
		MapAreaData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapAreaData", Classes.FMapProperty);
	}

	static GSMapAreaDetailData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSMapAreaDetailData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSMapAreaDetailData));
	}
}
