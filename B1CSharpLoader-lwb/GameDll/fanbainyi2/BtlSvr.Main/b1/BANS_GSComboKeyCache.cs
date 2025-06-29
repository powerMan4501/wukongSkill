using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Atk Combo Key Cache")]
[USharpPath("/Script/b1-Managed.BANS_GSComboKeyCache")]
internal class BANS_GSComboKeyCache : BANS_GSBase
{
	private static bool GroupID_IsValid;

	private static int GroupID_Offset;

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
	[Category("PlayerCastSkill")]
	[DisplayName("编组ID")]
	[UMeta(MDProp.ClampMin, 0)]
	[Tooltip("默认是0，可以和ComboWindow进行编组绑定触发（只能在一个AM内生效）")]
	[USharpPath("/Script/b1-Managed.BANS_GSComboKeyCache:GroupID")]
	public int GroupID
	{
		get
		{
			CheckDestroyed();
			if (!GroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboKeyCache:GroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, GroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSComboKeyCache:GroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, GroupID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		GroupID = 0;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSComboKeyCache:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ABGUCharacter aBGUCharacter = NotifyParam.owner as ABGUCharacter;
		if (aBGUCharacter != null)
		{
			BUS_EventCollectionCS.Get(aBGUCharacter)?.Evt_InputKeyCacheStart.Invoke(EInputKeyCacheType.Combo, NotifyParam.FromInstanceID, GetUniqueID(), GroupID, TotalDuration);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSComboKeyCache:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSComboKeyCache bANS_GSComboKeyCache = GCHelper.Find<b1.BANS_GSComboKeyCache>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSComboKeyCache.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSComboKeyCache");
		GroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupID");
		GroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupID", Classes.FIntProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSComboKeyCache:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSComboKeyCache()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSComboKeyCache)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSComboKeyCache));
	}
}
