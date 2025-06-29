using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)810549413uL, Config = "Engine")]
[UMetaPath("/Script/AIModule.AISense", "AIModule", UnrealModuleType.Engine)]
public class UAISense : UObject
{
	private static bool DefaultExpirationAge_IsValid;

	private static int DefaultExpirationAge_Offset;

	private static bool NotifyType_IsValid;

	private static FFieldAddress NotifyType_PropertyAddress;

	private static int NotifyType_Offset;

	private static bool WantsNewPawnNotification_IsValid;

	private static FFieldAddress WantsNewPawnNotification_PropertyAddress;

	private static int WantsNewPawnNotification_Offset;

	private static bool AutoRegisterAllPawnsAsSources_IsValid;

	private static FFieldAddress AutoRegisterAllPawnsAsSources_PropertyAddress;

	private static int AutoRegisterAllPawnsAsSources_Offset;

	[UProperty(Flags = (PropFlags)11267864954814997uL)]
	[UMetaPath("/Script/AIModule.AISense:DefaultExpirationAge")]
	protected float DefaultExpirationAge
	{
		get
		{
			CheckDestroyed();
			if (!DefaultExpirationAge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense:DefaultExpirationAge");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultExpirationAge_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultExpirationAge_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense:DefaultExpirationAge");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultExpirationAge_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954749461uL)]
	[UMetaPath("/Script/AIModule.AISense:NotifyType")]
	protected EAISenseNotifyType NotifyType
	{
		get
		{
			CheckDestroyed();
			if (!NotifyType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense:NotifyType");
				return EAISenseNotifyType.OnEveryPerception;
			}
			return EnumMarshaler<EAISenseNotifyType>.FromNative(IntPtr.Add(base.Address, NotifyType_Offset), 0, NotifyType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NotifyType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense:NotifyType");
			}
			else
			{
				EnumMarshaler<EAISenseNotifyType>.ToNative(IntPtr.Add(base.Address, NotifyType_Offset), 0, NotifyType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863881007125uL)]
	[UMetaPath("/Script/AIModule.AISense:bWantsNewPawnNotification")]
	protected bool WantsNewPawnNotification
	{
		get
		{
			CheckDestroyed();
			if (!WantsNewPawnNotification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense:bWantsNewPawnNotification");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, WantsNewPawnNotification_Offset), 0, WantsNewPawnNotification_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WantsNewPawnNotification_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense:bWantsNewPawnNotification");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, WantsNewPawnNotification_Offset), 0, WantsNewPawnNotification_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863881007125uL)]
	[UMetaPath("/Script/AIModule.AISense:bAutoRegisterAllPawnsAsSources")]
	protected bool AutoRegisterAllPawnsAsSources
	{
		get
		{
			CheckDestroyed();
			if (!AutoRegisterAllPawnsAsSources_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense:bAutoRegisterAllPawnsAsSources");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoRegisterAllPawnsAsSources_Offset), 0, AutoRegisterAllPawnsAsSources_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoRegisterAllPawnsAsSources_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISense:bAutoRegisterAllPawnsAsSources");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoRegisterAllPawnsAsSources_Offset), 0, AutoRegisterAllPawnsAsSources_PropertyAddress.Address, value);
			}
		}
	}

	static UAISense()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAISense)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAISense));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AIModule.AISense");
		DefaultExpirationAge_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DefaultExpirationAge");
		DefaultExpirationAge_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DefaultExpirationAge", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref NotifyType_PropertyAddress, unrealStruct, "NotifyType");
		NotifyType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NotifyType");
		NotifyType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NotifyType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref WantsNewPawnNotification_PropertyAddress, unrealStruct, "bWantsNewPawnNotification");
		WantsNewPawnNotification_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bWantsNewPawnNotification");
		WantsNewPawnNotification_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bWantsNewPawnNotification", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoRegisterAllPawnsAsSources_PropertyAddress, unrealStruct, "bAutoRegisterAllPawnsAsSources");
		AutoRegisterAllPawnsAsSources_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bAutoRegisterAllPawnsAsSources");
		AutoRegisterAllPawnsAsSources_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bAutoRegisterAllPawnsAsSources", Classes.FBoolProperty);
	}
}
