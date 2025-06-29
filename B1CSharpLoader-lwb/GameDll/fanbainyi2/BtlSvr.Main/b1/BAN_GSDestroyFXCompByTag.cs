using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Destroy FXComp By Tag")]
[USharpPath("/Script/b1-Managed.BAN_GSDestroyFXCompByTag")]
internal class BAN_GSDestroyFXCompByTag : BAN_GSBase
{
	private static bool DestroyImmediately_IsValid;

	private static int DestroyImmediately_Offset;

	private static FFieldAddress DestroyImmediately_PropertyAddress;

	private static bool CompTag_IsValid;

	private static int CompTag_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:DestroyImmediately")]
	public bool DestroyImmediately
	{
		get
		{
			CheckDestroyed();
			if (!DestroyImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:DestroyImmediately");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DestroyImmediately_Offset), 0, DestroyImmediately_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DestroyImmediately_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:DestroyImmediately");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DestroyImmediately_Offset), 0, DestroyImmediately_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:CompTag")]
	public FName CompTag
	{
		get
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:CompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:CompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CompTag_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (!(actorStreamingLevelWorld == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnDestroyFXCompByTag.Invoke(CompTag, DestroyImmediately);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSDestroyFXCompByTag bAN_GSDestroyFXCompByTag = GCHelper.Find<b1.BAN_GSDestroyFXCompByTag>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSDestroyFXCompByTag.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSDestroyFXCompByTag");
		NativeReflection.GetPropertyRef(ref DestroyImmediately_PropertyAddress, intPtr, "DestroyImmediately");
		DestroyImmediately_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyImmediately");
		DestroyImmediately_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyImmediately", Classes.FBoolProperty);
		CompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "CompTag");
		CompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CompTag", Classes.FNameProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSDestroyFXCompByTag:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSDestroyFXCompByTag()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSDestroyFXCompByTag)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSDestroyFXCompByTag));
	}
}
