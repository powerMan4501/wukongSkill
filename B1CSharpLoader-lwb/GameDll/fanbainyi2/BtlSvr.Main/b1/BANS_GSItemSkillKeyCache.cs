using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS ItemSkill Key Cache")]
[USharpPath("/Script/b1-Managed.BANS_GSItemSkillKeyCache")]
internal class BANS_GSItemSkillKeyCache : BANS_GSBase
{
	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[USharpPath("/Script/b1-Managed.BANS_GSItemSkillKeyCache:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ABGUCharacter aBGUCharacter = NotifyParam.owner as ABGUCharacter;
		if (aBGUCharacter != null)
		{
			BUS_EventCollectionCS.Get(aBGUCharacter)?.Evt_InputKeyCacheStart.Invoke(EInputKeyCacheType.ItemSkill, NotifyParam.FromInstanceID, GetUniqueID(), -1, TotalDuration);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSItemSkillKeyCache:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSItemSkillKeyCache bANS_GSItemSkillKeyCache = GCHelper.Find<b1.BANS_GSItemSkillKeyCache>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSItemSkillKeyCache.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSItemSkillKeyCache");
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSItemSkillKeyCache:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSItemSkillKeyCache()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSItemSkillKeyCache)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSItemSkillKeyCache));
	}
}
