using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS CallPointsRegister")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSCallPointsRegister")]
internal class BANS_GSCallPointsRegister : BANS_GSBase
{
	private static bool RegistID_IsValid;

	private static int RegistID_Offset;

	private static bool GenType_IsValid;

	private static int GenType_Offset;

	private static FFieldAddress GenType_PropertyAddress;

	private static bool ExtParam_IsValid;

	private static int ExtParam_Offset;

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
	[USharpPath("/Script/b1-Managed.BANS_GSCallPointsRegister:RegistID")]
	public int RegistID
	{
		get
		{
			CheckDestroyed();
			if (!RegistID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCallPointsRegister:RegistID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RegistID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RegistID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCallPointsRegister:RegistID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RegistID_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSCallPointsRegister:GenType")]
	public PointsGenType GenType
	{
		get
		{
			CheckDestroyed();
			if (!GenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCallPointsRegister:GenType");
				return PointsGenType.ByEQS_Async;
			}
			return EnumMarshaler<PointsGenType>.FromNative(IntPtr.Add(base.Address, GenType_Offset), 0, GenType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCallPointsRegister:GenType");
			}
			else
			{
				EnumMarshaler<PointsGenType>.ToNative(IntPtr.Add(base.Address, GenType_Offset), 0, GenType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSCallPointsRegister:ExtParam")]
	public PointsGenExtParam ExtParam
	{
		get
		{
			CheckDestroyed();
			if (!ExtParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCallPointsRegister:ExtParam");
				return default(PointsGenExtParam);
			}
			return PointsGenExtParam.FromNative(IntPtr.Add(base.Address, ExtParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCallPointsRegister:ExtParam");
			}
			else
			{
				PointsGenExtParam.ToNative(IntPtr.Add(base.Address, ExtParam_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCallPointsRegister:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_CallPointsRegister.Invoke(RegistID, GenType, ExtParam);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCallPointsRegister:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCallPointsRegister bANS_GSCallPointsRegister = GCHelper.Find<b1.BANS_GSCallPointsRegister>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCallPointsRegister.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCallPointsRegister");
		RegistID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RegistID");
		RegistID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RegistID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref GenType_PropertyAddress, intPtr, "GenType");
		GenType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GenType");
		GenType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GenType", Classes.FEnumProperty);
		ExtParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtParam");
		ExtParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtParam", Classes.FStructProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCallPointsRegister:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSCallPointsRegister()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCallPointsRegister)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCallPointsRegister));
	}
}
