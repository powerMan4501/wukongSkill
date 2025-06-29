using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Add Buff")]
[USharpPath("/Script/b1-Managed.BANS_GSAddBuff")]
public class BANS_GSAddBuff : BANS_GSBase
{
	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static FFieldAddress BuffID_PropertyAddress;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool UseBuffDescDuration_IsValid;

	private static int UseBuffDescDuration_Offset;

	private static FFieldAddress UseBuffDescDuration_PropertyAddress;

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

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAddBuff:BuffID")]
	public EBPBuffID BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAddBuff:BuffID");
				return EBPBuffID.NoneBuff;
			}
			return EnumMarshaler<EBPBuffID>.FromNative(IntPtr.Add(base.Address, BuffID_Offset), 0, BuffID_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAddBuff:BuffID");
			}
			else
			{
				EnumMarshaler<EBPBuffID>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), 0, BuffID_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[UMeta(MDProp.ClampMin, "1")]
	[USharpPath("/Script/b1-Managed.BANS_GSAddBuff:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAddBuff:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAddBuff:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSAddBuff:UseBuffDescDuration")]
	public bool UseBuffDescDuration
	{
		get
		{
			CheckDestroyed();
			if (!UseBuffDescDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAddBuff:UseBuffDescDuration");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseBuffDescDuration_Offset), 0, UseBuffDescDuration_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseBuffDescDuration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAddBuff:UseBuffDescDuration");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseBuffDescDuration_Offset), 0, UseBuffDescDuration_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		BuffLayer = 1;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (!UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(NotifyParam.owner.World))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			TotalDuration = ((!UseBuffDescDuration) ? (-1f) : 0f);
			for (int i = 1; i <= BuffLayer; i++)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_BuffAdd.Invoke((int)BuffID, bGUCharacterCS, bGUCharacterCS, TotalDuration, EBuffSourceType.Notify);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (UBGUFunctionLibraryForCS.BGUGetIsInGameWorld(NotifyParam.owner.World) && owner != null && !UseBuffDescDuration)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_BuffRemove.Invoke((int)BuffID, EBuffEffectTriggerType.None, 1);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSAddBuff bANS_GSAddBuff = GCHelper.Find<BANS_GSAddBuff>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAddBuff.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSAddBuff bANS_GSAddBuff = GCHelper.Find<BANS_GSAddBuff>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSAddBuff.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSAddBuff bANS_GSAddBuff = GCHelper.Find<BANS_GSAddBuff>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAddBuff.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAddBuff");
		NativeReflection.GetPropertyRef(ref BuffID_PropertyAddress, intPtr, "BuffID");
		BuffID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffID", Classes.FEnumProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref UseBuffDescDuration_PropertyAddress, intPtr, "UseBuffDescDuration");
		UseBuffDescDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseBuffDescDuration");
		UseBuffDescDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseBuffDescDuration", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAddBuff:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAddBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSAddBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSAddBuff));
	}
}
