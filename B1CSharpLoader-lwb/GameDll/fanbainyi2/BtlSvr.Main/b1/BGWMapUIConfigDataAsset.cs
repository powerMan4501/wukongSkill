using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWMapUIConfigDataAsset")]
public class BGWMapUIConfigDataAsset : UBGWDataAsset
{
	private static bool SpriteConfigMap_IsValid;

	private static int SpriteConfigMap_Offset;

	private static FFieldAddress SpriteConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, FMapSpriteConfig> SpriteConfigMap_Marshaler;

	private static bool GamepadScaleRate_IsValid;

	private static int GamepadScaleRate_Offset;

	private static bool MouseScaleRate_IsValid;

	private static int MouseScaleRate_Offset;

	private static bool MapUpdateDelayTime_IsValid;

	private static int MapUpdateDelayTime_Offset;

	private static bool MapAnimParams_IsValid;

	private static int MapAnimParams_Offset;

	[UProperty]
	[EditAnywhere]
	[DisplayName("地图配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWMapUIConfigDataAsset:SpriteConfigMap")]
	public TMapReadWrite<int, FMapSpriteConfig> SpriteConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!SpriteConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:SpriteConfigMap");
				return null;
			}
			if (SpriteConfigMap_Marshaler == null)
			{
				SpriteConfigMap_Marshaler = new TMapReadWriteMarshaler<int, FMapSpriteConfig>(1, SpriteConfigMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FMapSpriteConfig, BlittableTypeMarshaler<FMapSpriteConfig>>.FromNative, CachedMarshalingDelegates<FMapSpriteConfig, BlittableTypeMarshaler<FMapSpriteConfig>>.ToNative);
			}
			return SpriteConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, SpriteConfigMap_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("手柄缩放输入倍率")]
	[USharpPath("/Script/b1-Managed.BGWMapUIConfigDataAsset:GamepadScaleRate")]
	public float GamepadScaleRate
	{
		get
		{
			CheckDestroyed();
			if (!GamepadScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:GamepadScaleRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GamepadScaleRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GamepadScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:GamepadScaleRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GamepadScaleRate_Offset), value);
			}
		}
	}

	[DisplayName("鼠标缩放输入倍率")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWMapUIConfigDataAsset:MouseScaleRate")]
	public float MouseScaleRate
	{
		get
		{
			CheckDestroyed();
			if (!MouseScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:MouseScaleRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MouseScaleRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MouseScaleRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:MouseScaleRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MouseScaleRate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("地图更新延迟")]
	[USharpPath("/Script/b1-Managed.BGWMapUIConfigDataAsset:MapUpdateDelayTime")]
	public float MapUpdateDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!MapUpdateDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:MapUpdateDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MapUpdateDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapUpdateDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:MapUpdateDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MapUpdateDelayTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("地图表演参数")]
	[USharpPath("/Script/b1-Managed.BGWMapUIConfigDataAsset:MapAnimParams")]
	public FMapAnimParams MapAnimParams
	{
		get
		{
			CheckDestroyed();
			if (!MapAnimParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:MapAnimParams");
				return default(FMapAnimParams);
			}
			return FMapAnimParams.FromNative(IntPtr.Add(base.Address, MapAnimParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MapAnimParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMapUIConfigDataAsset:MapAnimParams");
			}
			else
			{
				FMapAnimParams.ToNative(IntPtr.Add(base.Address, MapAnimParams_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		MapAnimParams = default(FMapAnimParams);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWMapUIConfigDataAsset");
		NativeReflection.GetPropertyRef(ref SpriteConfigMap_PropertyAddress, unrealStruct, "SpriteConfigMap");
		SpriteConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpriteConfigMap");
		SpriteConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpriteConfigMap", Classes.FMapProperty);
		GamepadScaleRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GamepadScaleRate");
		GamepadScaleRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GamepadScaleRate", Classes.FFloatProperty);
		MouseScaleRate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MouseScaleRate");
		MouseScaleRate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MouseScaleRate", Classes.FFloatProperty);
		MapUpdateDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapUpdateDelayTime");
		MapUpdateDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapUpdateDelayTime", Classes.FFloatProperty);
		MapAnimParams_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapAnimParams");
		MapAnimParams_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapAnimParams", Classes.FStructProperty);
	}

	static BGWMapUIConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWMapUIConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWMapUIConfigDataAsset));
	}
}
