using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Arm LocationZ Curve")]
[USharpPath("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve")]
internal class BANS_GSCameraArmLocationZCurve : BANS_GSBase
{
	private static bool Curve_IsValid;

	private static int Curve_Offset;

	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:Curve")]
	public FGSFloatCurveToParam Curve
	{
		get
		{
			CheckDestroyed();
			if (!Curve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:Curve");
				return default(FGSFloatCurveToParam);
			}
			return FGSFloatCurveToParam.FromNative(IntPtr.Add(base.Address, Curve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Curve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:Curve");
			}
			else
			{
				FGSFloatCurveToParam.ToNative(IntPtr.Add(base.Address, Curve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:BlendInTime")]
	public float BlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:BlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:BlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:BlendOutTime")]
	public float BlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:BlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:BlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutTime_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		BlendInTime = 0.1f;
		BlendOutTime = 0f;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(owner.World))
		{
			BUS_EventCollectionCS.Get(owner).Evt_EnableCameraArmLocationZCurve.Invoke(Curve, BlendInTime);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(owner.World))
		{
			BUS_EventCollectionCS.Get(owner).Evt_DisableCameraArmLocationZCurve.Invoke(BlendOutTime);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCameraArmLocationZCurve bANS_GSCameraArmLocationZCurve = GCHelper.Find<b1.BANS_GSCameraArmLocationZCurve>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSCameraArmLocationZCurve.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCameraArmLocationZCurve bANS_GSCameraArmLocationZCurve = GCHelper.Find<b1.BANS_GSCameraArmLocationZCurve>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCameraArmLocationZCurve.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve");
		Curve_Offset = NativeReflection.GetPropertyOffset(intPtr, "Curve");
		Curve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Curve", Classes.FStructProperty);
		BlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		BlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCameraArmLocationZCurve:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSCameraArmLocationZCurve()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCameraArmLocationZCurve)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCameraArmLocationZCurve));
	}
}
