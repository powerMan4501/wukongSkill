using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryCache;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/GeometryCache.GeometryCache", "GeometryCache", UnrealModuleType.EnginePlugin)]
public class UGeometryCache : UObject, IInterface_AssetUserData, IInterface
{
	private static bool StartFrame_IsValid;

	private static int StartFrame_Offset;

	private static bool EndFrame_IsValid;

	private static int EndFrame_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCache:StartFrame")]
	protected int StartFrame
	{
		get
		{
			CheckDestroyed();
			if (!StartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCache:StartFrame");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, StartFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCache:StartFrame");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, StartFrame_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/GeometryCache.GeometryCache:EndFrame")]
	protected int EndFrame
	{
		get
		{
			CheckDestroyed();
			if (!EndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCache:EndFrame");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EndFrame_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndFrame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GeometryCache.GeometryCache:EndFrame");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EndFrame_Offset), value);
			}
		}
	}

	static UGeometryCache()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGeometryCache)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGeometryCache));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GeometryCache.GeometryCache");
		StartFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StartFrame");
		StartFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StartFrame", Classes.FIntProperty);
		EndFrame_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "EndFrame");
		EndFrame_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "EndFrame", Classes.FIntProperty);
	}
}
