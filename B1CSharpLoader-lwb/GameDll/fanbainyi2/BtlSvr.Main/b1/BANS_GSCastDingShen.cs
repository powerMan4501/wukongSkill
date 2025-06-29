using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Cast DingShen")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSCastDingShen")]
internal class BANS_GSCastDingShen : BANS_GSBase
{
	private static bool ImmobilizeConfigID_IsValid;

	private static int ImmobilizeConfigID_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[Category("Anim Notify")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSCastDingShen:ImmobilizeConfigID")]
	public int ImmobilizeConfigID
	{
		get
		{
			CheckDestroyed();
			if (!ImmobilizeConfigID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCastDingShen:ImmobilizeConfigID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ImmobilizeConfigID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImmobilizeConfigID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCastDingShen:ImmobilizeConfigID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ImmobilizeConfigID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.AnimNSType = EGsEnAnimNS.CastDingShen;
		ImmobilizeConfigID = 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCastDingShen:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_CastImmobilize.Invoke(ImmobilizeConfigID);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCastDingShen:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCastDingShen bANS_GSCastDingShen = GCHelper.Find<b1.BANS_GSCastDingShen>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCastDingShen.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCastDingShen");
		ImmobilizeConfigID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ImmobilizeConfigID");
		ImmobilizeConfigID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ImmobilizeConfigID", Classes.FIntProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCastDingShen:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSCastDingShen()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCastDingShen)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCastDingShen));
	}
}
