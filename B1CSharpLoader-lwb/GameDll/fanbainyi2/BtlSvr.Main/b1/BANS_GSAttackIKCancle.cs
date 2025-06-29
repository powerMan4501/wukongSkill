using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Attack IK Cancle")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSAttackIKCancle")]
internal class BANS_GSAttackIKCancle : BANS_GSBase
{
	private static bool DisableIK_IsValid;

	private static int DisableIK_Offset;

	private static FFieldAddress DisableIK_PropertyAddress;

	private static bool ShowDebug_IsValid;

	private static int ShowDebug_Offset;

	private static FFieldAddress ShowDebug_PropertyAddress;

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
	[UProperty]
	[EditAnywhere]
	[DisplayName("关闭所有对俺的攻击IK")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIKCancle:DisableIK")]
	public bool DisableIK
	{
		get
		{
			CheckDestroyed();
			if (!DisableIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIKCancle:DisableIK");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisableIK_Offset), 0, DisableIK_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisableIK_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIKCancle:DisableIK");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisableIK_Offset), 0, DisableIK_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("开启debug")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackIKCancle:ShowDebug")]
	public bool ShowDebug
	{
		get
		{
			CheckDestroyed();
			if (!ShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIKCancle:ShowDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShowDebug_Offset), 0, ShowDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackIKCancle:ShowDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShowDebug_Offset), 0, ShowDebug_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null))
		{
			BUS_EventCollectionCS.Get(aCharacter).Evt_DisableTargetAttackIK.Invoke(enable: false);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null))
		{
			BUS_EventCollectionCS.Get(aCharacter).Evt_DisableTargetAttackIK.Invoke(DisableIK);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null) && BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_ABPAttackIKData>(aCharacter) != null && ShowDebug)
		{
			FTransform worldTransform = aCharacter.Mesh.GetWorldTransform();
			aCharacter.GetActorBounds(bOnlyCollidingComponents: true, out var _, out var BoxExtent, bIncludeFromChildActors: true);
			USystemLibrary.DrawDebugBox(aCharacter, worldTransform.GetLocation(), BoxExtent / 2.0, FLinearColor.Red, aCharacter.Mesh.GetWorldRotation(), 2f, 10f);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackIKCancle bANS_GSAttackIKCancle = GCHelper.Find<b1.BANS_GSAttackIKCancle>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAttackIKCancle.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackIKCancle bANS_GSAttackIKCancle = GCHelper.Find<b1.BANS_GSAttackIKCancle>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSAttackIKCancle.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAttackIKCancle bANS_GSAttackIKCancle = GCHelper.Find<b1.BANS_GSAttackIKCancle>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAttackIKCancle.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAttackIKCancle");
		NativeReflection.GetPropertyRef(ref DisableIK_PropertyAddress, intPtr, "DisableIK");
		DisableIK_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisableIK");
		DisableIK_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisableIK", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ShowDebug_PropertyAddress, intPtr, "ShowDebug");
		ShowDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShowDebug");
		ShowDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShowDebug", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackIKCancle:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAttackIKCancle()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAttackIKCancle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAttackIKCancle));
	}
}
