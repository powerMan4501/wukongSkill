using System;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Enable Montage Footstep")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSEnableMontageFootstep")]
internal class BANS_GSEnableMontageFootstep : BANS_GSBase
{
	private static bool bEnableFootDecal_IsValid;

	private static int bEnableFootDecal_Offset;

	private static FFieldAddress bEnableFootDecal_PropertyAddress;

	private static bool bEnableFootstepAudio_IsValid;

	private static int bEnableFootstepAudio_Offset;

	private static FFieldAddress bEnableFootstepAudio_PropertyAddress;

	private static bool bEnableFootstepFX_IsValid;

	private static int bEnableFootstepFX_Offset;

	private static FFieldAddress bEnableFootstepFX_PropertyAddress;

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

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootDecal")]
	public bool bEnableFootDecal
	{
		get
		{
			CheckDestroyed();
			if (!bEnableFootDecal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootDecal");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableFootDecal_Offset), 0, bEnableFootDecal_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableFootDecal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootDecal");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableFootDecal_Offset), 0, bEnableFootDecal_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Category("Anim Notify")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootstepAudio")]
	public bool bEnableFootstepAudio
	{
		get
		{
			CheckDestroyed();
			if (!bEnableFootstepAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootstepAudio");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableFootstepAudio_Offset), 0, bEnableFootstepAudio_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableFootstepAudio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootstepAudio");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableFootstepAudio_Offset), 0, bEnableFootstepAudio_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootstepFX")]
	public bool bEnableFootstepFX
	{
		get
		{
			CheckDestroyed();
			if (!bEnableFootstepFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootstepFX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableFootstepFX_Offset), 0, bEnableFootstepFX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableFootstepFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSEnableMontageFootstep:bEnableFootstepFX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableFootstepFX_Offset), 0, bEnableFootstepFX_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		bEnableFootDecal = true;
		bEnableFootstepAudio = true;
		bEnableFootstepFX = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSEnableMontageFootstep:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_EnableMontageFootstepEnd.Invoke((int)GetUniqueID());
	}

	[USharpPath("/Script/b1-Managed.BANS_GSEnableMontageFootstep:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BUS_EventCollectionCS.Get(NotifyParam.owner)?.Evt_EnableMontageFootstepBegin.Invoke(bEnableFootDecal, bEnableFootstepAudio, bEnableFootstepFX, (int)GetUniqueID());
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSEnableMontageFootstep:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSEnableMontageFootstep bANS_GSEnableMontageFootstep = GCHelper.Find<b1.BANS_GSEnableMontageFootstep>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSEnableMontageFootstep.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSEnableMontageFootstep:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSEnableMontageFootstep bANS_GSEnableMontageFootstep = GCHelper.Find<b1.BANS_GSEnableMontageFootstep>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSEnableMontageFootstep.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSEnableMontageFootstep");
		NativeReflection.GetPropertyRef(ref bEnableFootDecal_PropertyAddress, intPtr, "bEnableFootDecal");
		bEnableFootDecal_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableFootDecal");
		bEnableFootDecal_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableFootDecal", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableFootstepAudio_PropertyAddress, intPtr, "bEnableFootstepAudio");
		bEnableFootstepAudio_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableFootstepAudio");
		bEnableFootstepAudio_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableFootstepAudio", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bEnableFootstepFX_PropertyAddress, intPtr, "bEnableFootstepFX");
		bEnableFootstepFX_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableFootstepFX");
		bEnableFootstepFX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableFootstepFX", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSEnableMontageFootstep:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSEnableMontageFootstep:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSEnableMontageFootstep()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSEnableMontageFootstep)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSEnableMontageFootstep));
	}
}
