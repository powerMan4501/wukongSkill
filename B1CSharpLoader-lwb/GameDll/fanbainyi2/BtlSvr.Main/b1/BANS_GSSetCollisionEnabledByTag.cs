using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Set Collision Enabled By Tag")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag")]
internal class BANS_GSSetCollisionEnabledByTag : BANS_GSBase
{
	private List<UShapeComponent> EnabledCollisionComp;

	public List<ECollisionEnabled> EnableTypes;

	private static bool CollisionCompTag_IsValid;

	private static int CollisionCompTag_Offset;

	private static bool EnableType_IsValid;

	private static int EnableType_Offset;

	private static FFieldAddress EnableType_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:CollisionCompTag")]
	public FName CollisionCompTag
	{
		get
		{
			CheckDestroyed();
			if (!CollisionCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:CollisionCompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CollisionCompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CollisionCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:CollisionCompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CollisionCompTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:EnableType")]
	public ECollisionEnabled EnableType
	{
		get
		{
			CheckDestroyed();
			if (!EnableType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:EnableType");
				return ECollisionEnabled.NoCollision;
			}
			return EnumMarshaler<ECollisionEnabled>.FromNative(IntPtr.Add(base.Address, EnableType_Offset), 0, EnableType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:EnableType");
			}
			else
			{
				EnumMarshaler<ECollisionEnabled>.ToNative(IntPtr.Add(base.Address, EnableType_Offset), 0, EnableType_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		EnabledCollisionComp = new List<UShapeComponent>();
		EnableTypes = new List<ECollisionEnabled>();
		foreach (UActorComponent item in NotifyParam.owner.GetComponentsByTag(UClass.GetClass<UShapeComponent>(), CollisionCompTag))
		{
			UShapeComponent uShapeComponent = item as UShapeComponent;
			if (uShapeComponent != null)
			{
				ECollisionEnabled collisionEnabled = uShapeComponent.GetCollisionEnabled();
				if (collisionEnabled != EnableType)
				{
					EnabledCollisionComp.Add(uShapeComponent);
					EnableTypes.Add(collisionEnabled);
					uShapeComponent.SetCollisionEnabled(EnableType);
				}
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		for (int i = 0; i < EnabledCollisionComp.Count; i++)
		{
			if (EnabledCollisionComp[i] != null)
			{
				EnabledCollisionComp[i].SetCollisionEnabled(EnableTypes[i]);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCollisionEnabledByTag bANS_GSSetCollisionEnabledByTag = GCHelper.Find<b1.BANS_GSSetCollisionEnabledByTag>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSetCollisionEnabledByTag.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetCollisionEnabledByTag bANS_GSSetCollisionEnabledByTag = GCHelper.Find<b1.BANS_GSSetCollisionEnabledByTag>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetCollisionEnabledByTag.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag");
		CollisionCompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CollisionCompTag");
		CollisionCompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CollisionCompTag", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref EnableType_PropertyAddress, intPtr, "EnableType");
		EnableType_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableType");
		EnableType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableType", Classes.FEnumProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetCollisionEnabledByTag:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSetCollisionEnabledByTag()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetCollisionEnabledByTag)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetCollisionEnabledByTag));
	}
}
