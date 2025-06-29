using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping")]
public class BGWDataAsset_WaterSplashMapping : UBGWDataAsset
{
	private static bool bDrawDebug_IsValid;

	private static int bDrawDebug_Offset;

	private static FFieldAddress bDrawDebug_PropertyAddress;

	private static bool SocketName_PostAudio_IsValid;

	private static int SocketName_PostAudio_Offset;

	private static bool AudioFadeOutTime_Ms_IsValid;

	private static int AudioFadeOutTime_Ms_Offset;

	private static bool ResourceMap_IsValid;

	private static int ResourceMap_Offset;

	private static FFieldAddress ResourceMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, FWaterSplashResourceMap_WithSurfaceType> ResourceMap_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:bDrawDebug")]
	public bool bDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:bDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:bDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:SocketName_PostAudio")]
	public FName SocketName_PostAudio
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_PostAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:SocketName_PostAudio");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_PostAudio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_PostAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:SocketName_PostAudio");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_PostAudio_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("音效淡出时长(毫秒)")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:AudioFadeOutTime_Ms")]
	public int AudioFadeOutTime_Ms
	{
		get
		{
			CheckDestroyed();
			if (!AudioFadeOutTime_Ms_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:AudioFadeOutTime_Ms");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AudioFadeOutTime_Ms_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioFadeOutTime_Ms_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:AudioFadeOutTime_Ms");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AudioFadeOutTime_Ms_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:ResourceMap")]
	public TMapReadWrite<int, FWaterSplashResourceMap_WithSurfaceType> ResourceMap
	{
		get
		{
			CheckDestroyed();
			if (!ResourceMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping:ResourceMap");
				return null;
			}
			if (ResourceMap_Marshaler == null)
			{
				ResourceMap_Marshaler = new TMapReadWriteMarshaler<int, FWaterSplashResourceMap_WithSurfaceType>(1, ResourceMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FWaterSplashResourceMap_WithSurfaceType, FWaterSplashResourceMap_WithSurfaceType>.FromNative, CachedMarshalingDelegates<FWaterSplashResourceMap_WithSurfaceType, FWaterSplashResourceMap_WithSurfaceType>.ToNative);
			}
			return ResourceMap_Marshaler.FromNative(IntPtr.Add(base.Address, ResourceMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_WaterSplashMapping");
		NativeReflection.GetPropertyRef(ref bDrawDebug_PropertyAddress, unrealStruct, "bDrawDebug");
		bDrawDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDrawDebug");
		bDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDrawDebug", Classes.FBoolProperty);
		SocketName_PostAudio_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SocketName_PostAudio");
		SocketName_PostAudio_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SocketName_PostAudio", Classes.FNameProperty);
		AudioFadeOutTime_Ms_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AudioFadeOutTime_Ms");
		AudioFadeOutTime_Ms_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AudioFadeOutTime_Ms", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ResourceMap_PropertyAddress, unrealStruct, "ResourceMap");
		ResourceMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ResourceMap");
		ResourceMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ResourceMap", Classes.FMapProperty);
	}

	static BGWDataAsset_WaterSplashMapping()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_WaterSplashMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_WaterSplashMapping));
	}
}
