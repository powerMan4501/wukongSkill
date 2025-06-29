using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.GameplayCameras;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl")]
public class BGWDataAsset_CameraShakeWithControl : UBGWDataAsset
{
	private static bool CameraShake_IsValid;

	private static int CameraShake_Offset;

	private static bool WithControl_IsValid;

	private static int WithControl_Offset;

	private static FFieldAddress WithControl_PropertyAddress;

	private static bool CamShakeScaleByDistCurve_IsValid;

	private static int CamShakeScaleByDistCurve_Offset;

	private static bool EpicenterIsAttach_IsValid;

	private static int EpicenterIsAttach_Offset;

	private static FFieldAddress EpicenterIsAttach_PropertyAddress;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:CameraShake")]
	public TSubclassOf<UMatineeCameraShake> CameraShake
	{
		get
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:CameraShake");
				return default(TSubclassOf<UMatineeCameraShake>);
			}
			return TSubclassOfMarshaler<UMatineeCameraShake>.FromNative(IntPtr.Add(base.Address, CameraShake_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraShake_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:CameraShake");
			}
			else
			{
				TSubclassOfMarshaler<UMatineeCameraShake>.ToNative(IntPtr.Add(base.Address, CameraShake_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:WithControl")]
	public bool WithControl
	{
		get
		{
			CheckDestroyed();
			if (!WithControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:WithControl");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WithControl_Offset), 0, WithControl_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WithControl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:WithControl");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WithControl_Offset), 0, WithControl_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "WithControl")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:CamShakeScaleByDistCurve")]
	public UCurveFloat CamShakeScaleByDistCurve
	{
		get
		{
			CheckDestroyed();
			if (!CamShakeScaleByDistCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:CamShakeScaleByDistCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, CamShakeScaleByDistCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CamShakeScaleByDistCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:CamShakeScaleByDistCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, CamShakeScaleByDistCurve_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "WithControl")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:EpicenterIsAttach")]
	public bool EpicenterIsAttach
	{
		get
		{
			CheckDestroyed();
			if (!EpicenterIsAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:EpicenterIsAttach");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EpicenterIsAttach_Offset), 0, EpicenterIsAttach_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EpicenterIsAttach_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:EpicenterIsAttach");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EpicenterIsAttach_Offset), 0, EpicenterIsAttach_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "WithControl")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_CameraShakeWithControl");
		CameraShake_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraShake");
		CameraShake_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraShake", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref WithControl_PropertyAddress, unrealStruct, "WithControl");
		WithControl_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WithControl");
		WithControl_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WithControl", Classes.FBoolProperty);
		CamShakeScaleByDistCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CamShakeScaleByDistCurve");
		CamShakeScaleByDistCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CamShakeScaleByDistCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EpicenterIsAttach_PropertyAddress, unrealStruct, "EpicenterIsAttach");
		EpicenterIsAttach_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EpicenterIsAttach");
		EpicenterIsAttach_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EpicenterIsAttach", Classes.FBoolProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SocketName", Classes.FNameProperty);
	}

	static BGWDataAsset_CameraShakeWithControl()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_CameraShakeWithControl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_CameraShakeWithControl));
	}
}
