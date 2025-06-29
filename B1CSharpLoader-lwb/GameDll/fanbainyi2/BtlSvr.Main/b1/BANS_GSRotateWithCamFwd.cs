using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Rotate With CamFwd")]
[USharpPath("/Script/b1-Managed.BANS_GSRotateWithCamFwd")]
internal class BANS_GSRotateWithCamFwd : BANS_GSBase
{
	private static bool RotSpeed_IsValid;

	private static int RotSpeed_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

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
	[USharpPath("/Script/b1-Managed.BANS_GSRotateWithCamFwd:RotSpeed")]
	public float RotSpeed
	{
		get
		{
			CheckDestroyed();
			if (!RotSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRotateWithCamFwd:RotSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSRotateWithCamFwd:RotSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotSpeed_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		RotateWithCam(NotifyParam.owner);
	}

	[USharpPath("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		RotateWithCam(NotifyParam.owner);
	}

	[USharpPath("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_OnRotateWithCamEnded.Invoke();
		}
	}

	private void RotateWithCam(AActor Owner)
	{
		BGUPlayerCharacterCS bGUPlayerCharacterCS = Owner as BGUPlayerCharacterCS;
		if (bGUPlayerCharacterCS != null)
		{
			FVector safeNormal2D = bGUPlayerCharacterCS.GetFollowCamera().GetWorldRotation().Conv_RotatorToVector()
				.GetSafeNormal2D();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUPlayerCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnRotateWithCam.Invoke(safeNormal2D, RotSpeed);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSRotateWithCamFwd bANS_GSRotateWithCamFwd = GCHelper.Find<b1.BANS_GSRotateWithCamFwd>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSRotateWithCamFwd.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSRotateWithCamFwd bANS_GSRotateWithCamFwd = GCHelper.Find<b1.BANS_GSRotateWithCamFwd>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSRotateWithCamFwd.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSRotateWithCamFwd bANS_GSRotateWithCamFwd = GCHelper.Find<b1.BANS_GSRotateWithCamFwd>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSRotateWithCamFwd.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSRotateWithCamFwd");
		RotSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotSpeed");
		RotSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotSpeed", Classes.FFloatProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSRotateWithCamFwd:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSRotateWithCamFwd()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSRotateWithCamFwd)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSRotateWithCamFwd));
	}
}
