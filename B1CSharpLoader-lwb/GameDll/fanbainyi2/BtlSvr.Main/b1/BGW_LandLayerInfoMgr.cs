using System;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_LandLayerInfoMgr")]
public class BGW_LandLayerInfoMgr : GameInstanceSystemBaseUObj
{
	private static bool LayerSceneInfoActor_IsValid;

	private static int LayerSceneInfoActor_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_LandLayerInfoMgr:LayerSceneInfoActor")]
	private ALayerSceneInfo LayerSceneInfoActor
	{
		get
		{
			CheckDestroyed();
			if (!LayerSceneInfoActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_LandLayerInfoMgr:LayerSceneInfoActor");
				return null;
			}
			return UObjectMarshaler<ALayerSceneInfo>.FromNative(IntPtr.Add(base.Address, LayerSceneInfoActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LayerSceneInfoActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_LandLayerInfoMgr:LayerSceneInfoActor");
			}
			else
			{
				UObjectMarshaler<ALayerSceneInfo>.ToNative(IntPtr.Add(base.Address, LayerSceneInfoActor_Offset), value);
			}
		}
	}

	public static BGW_LandLayerInfoMgr Get(UObject Context)
	{
		return BGWGameInstanceCS.GetObject<BGW_LandLayerInfoMgr>(Context);
	}

	public void RegisterLayerSceneActor(ALayerSceneInfo _LayerSceneInfoActor)
	{
		LayerSceneInfoActor = _LayerSceneInfoActor;
	}

	public bool GetCurLayerSceneInfoUnderfoot(FVector WorldPos, string blockName, int WantSurfaceType, out float value, out EPhysicalSurface SurfaceType)
	{
		value = 0f;
		SurfaceType = EPhysicalSurface.SurfaceType_Default;
		return false;
	}

	public bool GetCurWaterDepthUnderfoot(FVector WorldPos, out float value)
	{
		if (LayerSceneInfoActor.IsNullOrDestroyed())
		{
			value = 0f;
			return false;
		}
		value = 0f;
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_LandLayerInfoMgr");
		LayerSceneInfoActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LayerSceneInfoActor");
		LayerSceneInfoActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LayerSceneInfoActor", Classes.FObjectProperty);
	}

	static BGW_LandLayerInfoMgr()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_LandLayerInfoMgr)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_LandLayerInfoMgr));
	}
}
