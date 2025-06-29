using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Set Simple State")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSSetSimpleState")]
internal class BAN_GSSetSimpleState : BAN_GSBase
{
	private static bool SimpleState_IsValid;

	private static int SimpleState_Offset;

	private static FFieldAddress SimpleState_PropertyAddress;

	private static bool IsRemove_IsValid;

	private static int IsRemove_Offset;

	private static FFieldAddress IsRemove_PropertyAddress;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BAN_GSSetSimpleState:SimpleState")]
	public EBGUSimpleState SimpleState
	{
		get
		{
			CheckDestroyed();
			if (!SimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetSimpleState:SimpleState");
				return EBGUSimpleState.Normal;
			}
			return EnumMarshaler<EBGUSimpleState>.FromNative(IntPtr.Add(base.Address, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimpleState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetSimpleState:SimpleState");
			}
			else
			{
				EnumMarshaler<EBGUSimpleState>.ToNative(IntPtr.Add(base.Address, SimpleState_Offset), 0, SimpleState_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSSetSimpleState:IsRemove")]
	public bool IsRemove
	{
		get
		{
			CheckDestroyed();
			if (!IsRemove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetSimpleState:IsRemove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRemove_Offset), 0, IsRemove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRemove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSetSimpleState:IsRemove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRemove_Offset), 0, IsRemove_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSetSimpleState:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_UnitSetSimpleState.Invoke(SimpleState, IsRemove);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSetSimpleState:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSSetSimpleState bAN_GSSetSimpleState = GCHelper.Find<b1.BAN_GSSetSimpleState>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSetSimpleState.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSetSimpleState");
		NativeReflection.GetPropertyRef(ref SimpleState_PropertyAddress, intPtr, "SimpleState");
		SimpleState_Offset = NativeReflection.GetPropertyOffset(intPtr, "SimpleState");
		SimpleState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SimpleState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsRemove_PropertyAddress, intPtr, "IsRemove");
		IsRemove_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRemove");
		IsRemove_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRemove", Classes.FBoolProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSetSimpleState:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSSetSimpleState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSSetSimpleState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSSetSimpleState));
	}
}
