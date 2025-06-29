using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN CallPointsRegister")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSCallPointsRegister")]
internal class BAN_GSCallPointsRegister : BAN_GSBase
{
	private static bool RegistID_IsValid;

	private static int RegistID_Offset;

	private static bool GenType_IsValid;

	private static int GenType_Offset;

	private static FFieldAddress GenType_PropertyAddress;

	private static bool ExtParam_IsValid;

	private static int ExtParam_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSCallPointsRegister:RegistID")]
	public int RegistID
	{
		get
		{
			CheckDestroyed();
			if (!RegistID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallPointsRegister:RegistID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RegistID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RegistID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallPointsRegister:RegistID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RegistID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSCallPointsRegister:GenType")]
	public PointsGenType GenType
	{
		get
		{
			CheckDestroyed();
			if (!GenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallPointsRegister:GenType");
				return PointsGenType.ByEQS_Async;
			}
			return EnumMarshaler<PointsGenType>.FromNative(IntPtr.Add(base.Address, GenType_Offset), 0, GenType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!GenType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallPointsRegister:GenType");
			}
			else
			{
				EnumMarshaler<PointsGenType>.ToNative(IntPtr.Add(base.Address, GenType_Offset), 0, GenType_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSCallPointsRegister:ExtParam")]
	public PointsGenExtParam ExtParam
	{
		get
		{
			CheckDestroyed();
			if (!ExtParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallPointsRegister:ExtParam");
				return default(PointsGenExtParam);
			}
			return PointsGenExtParam.FromNative(IntPtr.Add(base.Address, ExtParam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtParam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCallPointsRegister:ExtParam");
			}
			else
			{
				PointsGenExtParam.ToNative(IntPtr.Add(base.Address, ExtParam_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSCallPointsRegister:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSCallPointsRegister:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
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

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSCallPointsRegister:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSCallPointsRegister bAN_GSCallPointsRegister = GCHelper.Find<b1.BAN_GSCallPointsRegister>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSCallPointsRegister.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSCallPointsRegister:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSCallPointsRegister bAN_GSCallPointsRegister = GCHelper.Find<b1.BAN_GSCallPointsRegister>(obj);
		bool value = bAN_GSCallPointsRegister.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSCallPointsRegister");
		RegistID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RegistID");
		RegistID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RegistID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref GenType_PropertyAddress, intPtr, "GenType");
		GenType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GenType");
		GenType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GenType", Classes.FEnumProperty);
		ExtParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtParam");
		ExtParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtParam", Classes.FStructProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSCallPointsRegister:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSCallPointsRegister:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSCallPointsRegister()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSCallPointsRegister)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSCallPointsRegister));
	}
}
