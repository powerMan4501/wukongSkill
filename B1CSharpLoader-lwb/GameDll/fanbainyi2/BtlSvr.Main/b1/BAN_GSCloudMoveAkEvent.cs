using System;
using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Cloud Move AkEvent")]
[USharpPath("/Script/b1-Managed.BAN_GSCloudMoveAkEvent")]
internal class BAN_GSCloudMoveAkEvent : BAN_GSBase
{
	private static bool bIsStop_IsValid;

	private static int bIsStop_Offset;

	private static FFieldAddress bIsStop_PropertyAddress;

	private static bool AkEvent_IsValid;

	private static int AkEvent_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:bIsStop")]
	public bool bIsStop
	{
		get
		{
			CheckDestroyed();
			if (!bIsStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:bIsStop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsStop_Offset), 0, bIsStop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:bIsStop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsStop_Offset), 0, bIsStop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:AkEvent")]
	public TSoftObject<UAkAudioEvent> AkEvent
	{
		get
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:AkEvent");
				return default(TSoftObject<UAkAudioEvent>);
			}
			return TSoftObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, AkEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:AkEvent");
			}
			else
			{
				TSoftObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, AkEvent_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		UAkAudioEvent validResource = GetValidResource(AkEvent);
		if (validResource != null)
		{
			BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_PostCloudMoveAkEvent.Invoke(bIsStop, validResource);
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		List<FSoftObjectPath> list = new List<FSoftObjectPath>();
		if (!AkEvent.IsNull)
		{
			list.Add(AkEvent.ObjectPath);
		}
		return list;
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		if (!AkEvent.IsNull)
		{
			SoftPathSet.Add(AkEvent.ObjectPath);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSCloudMoveAkEvent bAN_GSCloudMoveAkEvent = GCHelper.Find<b1.BAN_GSCloudMoveAkEvent>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSCloudMoveAkEvent.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSCloudMoveAkEvent bAN_GSCloudMoveAkEvent = GCHelper.Find<b1.BAN_GSCloudMoveAkEvent>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bAN_GSCloudMoveAkEvent.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSCloudMoveAkEvent");
		NativeReflection.GetPropertyRef(ref bIsStop_PropertyAddress, intPtr, "bIsStop");
		bIsStop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsStop");
		bIsStop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsStop", Classes.FBoolProperty);
		AkEvent_Offset = NativeReflection.GetPropertyOffset(intPtr, "AkEvent");
		AkEvent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AkEvent", Classes.FSoftObjectProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:GSNotifyCS", GSNotifyCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSCloudMoveAkEvent:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BAN_GSCloudMoveAkEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSCloudMoveAkEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSCloudMoveAkEvent));
	}
}
