using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_NetMapConfig")]
public class BGWDataAsset_NetMapConfig : UBGWDataAsset
{
	private static bool NetMapObjects_IsValid;

	private static int NetMapObjects_Offset;

	private static FFieldAddress NetMapObjects_PropertyAddress;

	private TArrayReadWriteMarshaler<FSoftObjectPath> NetMapObjects_Marshaler;

	[DisplayName("网络地图对象")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_NetMapConfig:NetMapObjects")]
	public TArrayReadWrite<FSoftObjectPath> NetMapObjects
	{
		get
		{
			CheckDestroyed();
			if (!NetMapObjects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_NetMapConfig:NetMapObjects");
				return null;
			}
			if (NetMapObjects_Marshaler == null)
			{
				NetMapObjects_Marshaler = new TArrayReadWriteMarshaler<FSoftObjectPath>(1, NetMapObjects_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
			}
			return NetMapObjects_Marshaler.FromNative(IntPtr.Add(base.Address, NetMapObjects_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_NetMapConfig");
		NativeReflection.GetPropertyRef(ref NetMapObjects_PropertyAddress, unrealStruct, "NetMapObjects");
		NetMapObjects_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NetMapObjects");
		NetMapObjects_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NetMapObjects", Classes.FArrayProperty);
	}

	static BGWDataAsset_NetMapConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_NetMapConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_NetMapConfig));
	}
}
