using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Process Death In ASS")]
[USharpPath("/Script/b1-Managed.BANS_GSProcessDeathInASS")]
internal class BANS_GSProcessDeathInASS : BANS_GSBase
{
	private static bool DeathMontageList_IsValid;

	private static int DeathMontageList_Offset;

	private static FFieldAddress DeathMontageList_PropertyAddress;

	private TMapReadWriteMarshaler<int, UAnimMontage> DeathMontageList_Marshaler;

	private static bool SectionName_IsValid;

	private static int SectionName_Offset;

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
	[Tooltip("Key为ResID")]
	[DisplayName("抓投专用死亡动画")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSProcessDeathInASS:DeathMontageList")]
	public TMapReadWrite<int, UAnimMontage> DeathMontageList
	{
		get
		{
			CheckDestroyed();
			if (!DeathMontageList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSProcessDeathInASS:DeathMontageList");
				return null;
			}
			if (DeathMontageList_Marshaler == null)
			{
				DeathMontageList_Marshaler = new TMapReadWriteMarshaler<int, UAnimMontage>(1, DeathMontageList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative);
			}
			return DeathMontageList_Marshaler.FromNative(IntPtr.Add(base.Address, DeathMontageList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("【废弃】Guest死亡后跳转Section")]
	[USharpPath("/Script/b1-Managed.BANS_GSProcessDeathInASS:SectionName")]
	public FName SectionName
	{
		get
		{
			CheckDestroyed();
			if (!SectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSProcessDeathInASS:SectionName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SectionName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSProcessDeathInASS:SectionName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SectionName_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSProcessDeathInASS:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		BGS_EventCollectionCS.Get(owner)?.Evt_BGS_ProcessDeathInAnimationSync.Invoke(owner, DeathMontageList.ToDictionary(), TotalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSProcessDeathInASS:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSProcessDeathInASS bANS_GSProcessDeathInASS = GCHelper.Find<b1.BANS_GSProcessDeathInASS>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSProcessDeathInASS.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSProcessDeathInASS");
		NativeReflection.GetPropertyRef(ref DeathMontageList_PropertyAddress, intPtr, "DeathMontageList");
		DeathMontageList_Offset = NativeReflection.GetPropertyOffset(intPtr, "DeathMontageList");
		DeathMontageList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DeathMontageList", Classes.FMapProperty);
		SectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SectionName");
		SectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SectionName", Classes.FNameProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSProcessDeathInASS:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSProcessDeathInASS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSProcessDeathInASS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSProcessDeathInASS));
	}
}
