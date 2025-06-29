using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS GSCameraFixedParam")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSCameraFixedParam")]
internal class BANS_GSCameraFixedParam : BANS_GSBase
{
	private static bool FixedCameraParam_IsValid;

	private static int FixedCameraParam_Offset;

	private static FFieldAddress FixedCameraParam_PropertyAddress;

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

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSCameraFixedParam:FixedCameraParam")]
	public ECameraParamType FixedCameraParam
	{
		get
		{
			CheckDestroyed();
			if (!FixedCameraParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCameraFixedParam:FixedCameraParam");
				return ECameraParamType.ArmLocationX;
			}
			return EnumMarshaler<ECameraParamType>.FromNative(IntPtr.Add(base.Address, FixedCameraParam_Offset), 0, FixedCameraParam_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FixedCameraParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCameraFixedParam:FixedCameraParam");
			}
			else
			{
				EnumMarshaler<ECameraParamType>.ToNative(IntPtr.Add(base.Address, FixedCameraParam_Offset), 0, FixedCameraParam_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCameraFixedParam:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(owner);
		if (aActor != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_AddFixedCameraParam.Invoke(FixedCameraParam);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCameraFixedParam:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(owner);
		if (aActor != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RemoveFixedCameraParam.Invoke(FixedCameraParam);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCameraFixedParam:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCameraFixedParam bANS_GSCameraFixedParam = GCHelper.Find<b1.BANS_GSCameraFixedParam>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSCameraFixedParam.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCameraFixedParam:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCameraFixedParam bANS_GSCameraFixedParam = GCHelper.Find<b1.BANS_GSCameraFixedParam>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCameraFixedParam.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCameraFixedParam");
		NativeReflection.GetPropertyRef(ref FixedCameraParam_PropertyAddress, intPtr, "FixedCameraParam");
		FixedCameraParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "FixedCameraParam");
		FixedCameraParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FixedCameraParam", Classes.FEnumProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCameraFixedParam:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCameraFixedParam:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSCameraFixedParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCameraFixedParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCameraFixedParam));
	}
}
