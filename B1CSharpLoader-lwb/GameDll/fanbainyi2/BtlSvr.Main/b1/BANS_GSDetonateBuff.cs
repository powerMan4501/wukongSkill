using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Detonate Spider egg")]
[USharpPath("/Script/b1-Managed.BANS_GSDetonateBuff")]
public class BANS_GSDetonateBuff : BANS_GSBase
{
	private static bool ChargeLevel_IsValid;

	private static int ChargeLevel_Offset;

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
	[USharpPath("/Script/b1-Managed.BANS_GSDetonateBuff:ChargeLevel")]
	public int ChargeLevel
	{
		get
		{
			CheckDestroyed();
			if (!ChargeLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDetonateBuff:ChargeLevel");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChargeLevel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChargeLevel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSDetonateBuff:ChargeLevel");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChargeLevel_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSDetonateBuff:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ABGUCharacter aBGUCharacter = NotifyParam.owner as ABGUCharacter;
		if (aBGUCharacter != null)
		{
			BUS_EventCollectionCS.Get(aBGUCharacter)?.Evt_Detonate.Invoke(ChargeLevel);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSDetonateBuff:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSDetonateBuff bANS_GSDetonateBuff = GCHelper.Find<BANS_GSDetonateBuff>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSDetonateBuff.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSDetonateBuff");
		ChargeLevel_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChargeLevel");
		ChargeLevel_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChargeLevel", Classes.FIntProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSDetonateBuff:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSDetonateBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSDetonateBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSDetonateBuff));
	}
}
