using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Trigger Trans Effect")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSTriggerTransEffect")]
internal class BANS_GSTriggerTransEffect : BANS_GSBase
{
	private static bool TransEffectSettings_IsValid;

	private static int TransEffectSettings_Offset;

	private static bool EffectOffset_IsValid;

	private static int EffectOffset_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GetSoftReferences_IsValid;

	private static IntPtr GetSoftReferences_FunctionAddress;

	private static int GetSoftReferences_ParamsSize;

	private static bool GetSoftReferences_ReturnValue_IsValid;

	private static int GetSoftReferences_ReturnValue_Offset;

	private static FFieldAddress GetSoftReferences_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("TransEffect Settings")]
	[USharpPath("/Script/b1-Managed.BANS_GSTriggerTransEffect:TransEffectSettings")]
	public TSoftObject<BGWDataAsset_TransEffectSetting> TransEffectSettings
	{
		get
		{
			CheckDestroyed();
			if (!TransEffectSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTriggerTransEffect:TransEffectSettings");
				return default(TSoftObject<BGWDataAsset_TransEffectSetting>);
			}
			return TSoftObjectMarshaler<BGWDataAsset_TransEffectSetting>.FromNative(IntPtr.Add(base.Address, TransEffectSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransEffectSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTriggerTransEffect:TransEffectSettings");
			}
			else
			{
				TSoftObjectMarshaler<BGWDataAsset_TransEffectSetting>.ToNative(IntPtr.Add(base.Address, TransEffectSettings_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("TransEffect Settings")]
	[USharpPath("/Script/b1-Managed.BANS_GSTriggerTransEffect:EffectOffset")]
	public FVector EffectOffset
	{
		get
		{
			CheckDestroyed();
			if (!EffectOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTriggerTransEffect:EffectOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, EffectOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSTriggerTransEffect:EffectOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, EffectOffset_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTriggerTransEffect:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ACharacter aCharacter = NotifyParam.MeshComp?.GetOwner() as ACharacter;
		if (aCharacter != null)
		{
			BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(aCharacter);
			if (bGS_GSEventCollection != null && GetValidResource(TransEffectSettings) != null)
			{
				bGS_GSEventCollection.Evt_TriggerTransEffect.Invoke(aCharacter, TransEffectSettings.Path, EffectOffset);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTriggerTransEffect:GetSoftReferences")]
	protected override List<FSoftObjectPath> GetSoftReferences_Implementation()
	{
		List<FSoftObjectPath> list = new List<FSoftObjectPath>();
		if (!TransEffectSettings.IsNull)
		{
			list.Add(TransEffectSettings.ObjectPath);
		}
		return list;
	}

	public override void GetSoftReferencesCS(ref HashSet<FSoftObjectPath> SoftPathSet)
	{
		if (SoftPathSet == null)
		{
			SoftPathSet = new HashSet<FSoftObjectPath>();
		}
		if (!TransEffectSettings.IsNull)
		{
			SoftPathSet.Add(TransEffectSettings.ObjectPath);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTriggerTransEffect:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSTriggerTransEffect bANS_GSTriggerTransEffect = GCHelper.Find<b1.BANS_GSTriggerTransEffect>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSTriggerTransEffect.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTriggerTransEffect:GetSoftReferences")]
	private static void GetSoftReferences__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSTriggerTransEffect bANS_GSTriggerTransEffect = GCHelper.Find<b1.BANS_GSTriggerTransEffect>(obj);
		TArrayCopyMarshaler<FSoftObjectPath> tArrayCopyMarshaler = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetSoftReferences_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
		List<FSoftObjectPath> softReferences_Implementation = bANS_GSTriggerTransEffect.GetSoftReferences_Implementation();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSoftReferences_ReturnValue_Offset), softReferences_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTriggerTransEffect");
		TransEffectSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "TransEffectSettings");
		TransEffectSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TransEffectSettings", Classes.FSoftObjectProperty);
		EffectOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectOffset");
		EffectOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectOffset", Classes.FStructProperty);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTriggerTransEffect:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GetSoftReferences_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSoftReferences");
		GetSoftReferences_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSoftReferences_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSoftReferences_ReturnValue_PropertyAddress, GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSoftReferences_FunctionAddress, "ReturnValue");
		GetSoftReferences_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSoftReferences_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSoftReferences_IsValid = GetSoftReferences_FunctionAddress != IntPtr.Zero && GetSoftReferences_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTriggerTransEffect:GetSoftReferences", GetSoftReferences_IsValid);
	}

	static BANS_GSTriggerTransEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSTriggerTransEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSTriggerTransEffect));
	}
}
