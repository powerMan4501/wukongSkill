using System;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.B2D_DispLibFXActorCameraShakeData")]
internal class B2D_DispLibFXActorCameraShakeData : BGU_DispLibUComponentBase
{
	public float TimeACC;

	public bool HasTrigger;

	private static bool CameraShake_IsValid;

	private static int CameraShake_Offset;

	private static bool FirstDelayTime_IsValid;

	private static int FirstDelayTime_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.B2D_DispLibFXActorCameraShakeData:CameraShake")]
	public TSubclassOf<UMatineeCameraShake> CameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.B2D_DispLibFXActorCameraShakeData:CameraShake");
				return default(TSubclassOf<UMatineeCameraShake>);
			}
			return TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(base.Address, CameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.B2D_DispLibFXActorCameraShakeData:CameraShake");
			}
			else
			{
				TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(base.Address, CameraShake_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("时间")]
	[DisplayName("首次触发延迟")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.B2D_DispLibFXActorCameraShakeData:FirstDelayTime")]
	public float FirstDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!FirstDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.B2D_DispLibFXActorCameraShakeData:FirstDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FirstDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.B2D_DispLibFXActorCameraShakeData:FirstDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FirstDelayTime_Offset), value);
			}
		}
	}

	protected override void Reset()
	{
		TimeACC = 0f;
		HasTrigger = false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.B2D_DispLibFXActorCameraShakeData");
		CameraShake_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraShake");
		CameraShake_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraShake", Classes.FClassProperty);
		FirstDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FirstDelayTime");
		FirstDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FirstDelayTime", Classes.FFloatProperty);
	}

	static B2D_DispLibFXActorCameraShakeData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSDispLib.B2D_DispLibFXActorCameraShakeData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSDispLib.B2D_DispLibFXActorCameraShakeData));
	}
}
