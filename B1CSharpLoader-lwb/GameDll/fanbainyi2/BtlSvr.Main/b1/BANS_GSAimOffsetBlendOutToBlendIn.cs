using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS AimOffset BlendOut To BlendIn")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn")]
internal class BANS_GSAimOffsetBlendOutToBlendIn : BANS_GSBase
{
	private static bool BlendOutTime_IsValid;

	private static int BlendOutTime_Offset;

	private static bool BlendInTime_IsValid;

	private static int BlendInTime_Offset;

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

	[EditAnywhere]
	[DisplayName("融合退出时间")]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("如果进入和退出时间和大于总时长，会按比例缩放")]
	[USharpPath("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:BlendOutTime")]
	public float BlendOutTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:BlendOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:BlendOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendOutTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("如果进入和退出时间和大于总时长，会按比例缩放")]
	[DisplayName("融合进入时间")]
	[USharpPath("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:BlendInTime")]
	public float BlendInTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:BlendInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:BlendInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendInTime_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner != null) || !(owner as BGUCharacterCS != null))
		{
			return;
		}
		float num = TotalDuration - (BlendInTime + BlendOutTime);
		if (num < 0f)
		{
			num = 0f;
			float num2 = BlendInTime + BlendOutTime;
			if (num2 > 0f)
			{
				BlendInTime = TotalDuration / num2 * BlendInTime;
				BlendOutTime = TotalDuration / num2 * BlendOutTime;
			}
		}
		BUS_EventCollectionCS.Get(owner)?.Evt_SetAimOffsetBlend.Invoke(Enable: true, BlendInTime, BlendOutTime, num);
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null && owner as BGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_SetAimOffsetBlend.Invoke(Enable: false, -1f, -1f, -1f);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAimOffsetBlendOutToBlendIn bANS_GSAimOffsetBlendOutToBlendIn = GCHelper.Find<b1.BANS_GSAimOffsetBlendOutToBlendIn>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAimOffsetBlendOutToBlendIn.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAimOffsetBlendOutToBlendIn bANS_GSAimOffsetBlendOutToBlendIn = GCHelper.Find<b1.BANS_GSAimOffsetBlendOutToBlendIn>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAimOffsetBlendOutToBlendIn.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn");
		BlendOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendOutTime");
		BlendOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendOutTime", Classes.FFloatProperty);
		BlendInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendInTime");
		BlendInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendInTime", Classes.FFloatProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAimOffsetBlendOutToBlendIn:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAimOffsetBlendOutToBlendIn()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAimOffsetBlendOutToBlendIn)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAimOffsetBlendOutToBlendIn));
	}
}
