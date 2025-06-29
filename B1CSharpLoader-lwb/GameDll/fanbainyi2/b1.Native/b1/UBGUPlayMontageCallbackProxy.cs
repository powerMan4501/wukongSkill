using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUPlayMontageCallbackProxy", "b1", UnrealModuleType.Game)]
public class UBGUPlayMontageCallbackProxy : UObject
{
	private static IntPtr classAddress;

	private static bool OnCompleted_IsValid;

	private static int OnCompleted_Offset;

	private FBGUOnMontagePlayDelegate OnCompleted_DelegateCached;

	private static bool OnBlendOut_IsValid;

	private static int OnBlendOut_Offset;

	private FBGUOnMontagePlayDelegate OnBlendOut_DelegateCached;

	private static bool OnInterrupted_IsValid;

	private static int OnInterrupted_Offset;

	private FBGUOnMontagePlayDelegate OnInterrupted_DelegateCached;

	private static bool OnNotifyBegin_IsValid;

	private static int OnNotifyBegin_Offset;

	private FOnMontagePlayNotifyDelegate OnNotifyBegin_DelegateCached;

	private static bool OnNotifyEnd_IsValid;

	private static int OnNotifyEnd_Offset;

	private FOnMontagePlayNotifyDelegate OnNotifyEnd_DelegateCached;

	private static bool PlayMontage_IsValid;

	private static IntPtr PlayMontage_FunctionAddress;

	private static int PlayMontage_ParamsSize;

	private static bool PlayMontage_InSkeletalMeshComponent_IsValid;

	private static FFieldAddress PlayMontage_InSkeletalMeshComponent_PropertyAddress;

	private static int PlayMontage_InSkeletalMeshComponent_Offset;

	private static bool PlayMontage_MontageToPlay_IsValid;

	private static FFieldAddress PlayMontage_MontageToPlay_PropertyAddress;

	private static int PlayMontage_MontageToPlay_Offset;

	private static bool PlayMontage_PlayRate_IsValid;

	private static FFieldAddress PlayMontage_PlayRate_PropertyAddress;

	private static int PlayMontage_PlayRate_Offset;

	private static bool PlayMontage_StartingPosition_IsValid;

	private static FFieldAddress PlayMontage_StartingPosition_PropertyAddress;

	private static int PlayMontage_StartingPosition_Offset;

	private static bool PlayMontage_bSnapShot_IsValid;

	private static FFieldAddress PlayMontage_bSnapShot_PropertyAddress;

	private static int PlayMontage_bSnapShot_Offset;

	private static bool PlayMontage_StartingSection_IsValid;

	private static FFieldAddress PlayMontage_StartingSection_PropertyAddress;

	private static int PlayMontage_StartingSection_Offset;

	private static bool PlayMontage_ExceptAdditiveSlot_IsValid;

	private static FFieldAddress PlayMontage_ExceptAdditiveSlot_PropertyAddress;

	private static int PlayMontage_ExceptAdditiveSlot_Offset;

	private static bool PlayMontage_ReturnValue_IsValid;

	private static FFieldAddress PlayMontage_ReturnValue_PropertyAddress;

	private static int PlayMontage_ReturnValue_Offset;

	private static bool CreateProxyObjectForPlayMontage_IsValid;

	private static IntPtr CreateProxyObjectForPlayMontage_FunctionAddress;

	private static int CreateProxyObjectForPlayMontage_ParamsSize;

	private static bool CreateProxyObjectForPlayMontage_ReqIdx_IsValid;

	private static FFieldAddress CreateProxyObjectForPlayMontage_ReqIdx_PropertyAddress;

	private static int CreateProxyObjectForPlayMontage_ReqIdx_Offset;

	private static bool CreateProxyObjectForPlayMontage_MontageToPlay_IsValid;

	private static FFieldAddress CreateProxyObjectForPlayMontage_MontageToPlay_PropertyAddress;

	private static int CreateProxyObjectForPlayMontage_MontageToPlay_Offset;

	private static bool CreateProxyObjectForPlayMontage_ReturnValue_IsValid;

	private static FFieldAddress CreateProxyObjectForPlayMontage_ReturnValue_PropertyAddress;

	private static int CreateProxyObjectForPlayMontage_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGUPlayMontageCallbackProxy:OnCompleted")]
	public FBGUOnMontagePlayDelegate OnCompleted
	{
		get
		{
			CheckDestroyed();
			if (!OnCompleted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPlayMontageCallbackProxy:OnCompleted");
				return new FBGUOnMontagePlayDelegate();
			}
			if (OnCompleted_DelegateCached == null)
			{
				OnCompleted_DelegateCached = new FBGUOnMontagePlayDelegate();
				OnCompleted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnCompleted_Offset));
			}
			return OnCompleted_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGUPlayMontageCallbackProxy:OnBlendOut")]
	public FBGUOnMontagePlayDelegate OnBlendOut
	{
		get
		{
			CheckDestroyed();
			if (!OnBlendOut_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPlayMontageCallbackProxy:OnBlendOut");
				return new FBGUOnMontagePlayDelegate();
			}
			if (OnBlendOut_DelegateCached == null)
			{
				OnBlendOut_DelegateCached = new FBGUOnMontagePlayDelegate();
				OnBlendOut_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnBlendOut_Offset));
			}
			return OnBlendOut_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGUPlayMontageCallbackProxy:OnInterrupted")]
	public FBGUOnMontagePlayDelegate OnInterrupted
	{
		get
		{
			CheckDestroyed();
			if (!OnInterrupted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPlayMontageCallbackProxy:OnInterrupted");
				return new FBGUOnMontagePlayDelegate();
			}
			if (OnInterrupted_DelegateCached == null)
			{
				OnInterrupted_DelegateCached = new FBGUOnMontagePlayDelegate();
				OnInterrupted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInterrupted_Offset));
			}
			return OnInterrupted_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGUPlayMontageCallbackProxy:OnNotifyBegin")]
	public FOnMontagePlayNotifyDelegate OnNotifyBegin
	{
		get
		{
			CheckDestroyed();
			if (!OnNotifyBegin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPlayMontageCallbackProxy:OnNotifyBegin");
				return new FOnMontagePlayNotifyDelegate();
			}
			if (OnNotifyBegin_DelegateCached == null)
			{
				OnNotifyBegin_DelegateCached = new FOnMontagePlayNotifyDelegate();
				OnNotifyBegin_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnNotifyBegin_Offset));
			}
			return OnNotifyBegin_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BGUPlayMontageCallbackProxy:OnNotifyEnd")]
	public FOnMontagePlayNotifyDelegate OnNotifyEnd
	{
		get
		{
			CheckDestroyed();
			if (!OnNotifyEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUPlayMontageCallbackProxy:OnNotifyEnd");
				return new FOnMontagePlayNotifyDelegate();
			}
			if (OnNotifyEnd_DelegateCached == null)
			{
				OnNotifyEnd_DelegateCached = new FOnMontagePlayNotifyDelegate();
				OnNotifyEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnNotifyEnd_Offset));
			}
			return OnNotifyEnd_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUPlayMontageCallbackProxy:PlayMontage")]
	public unsafe bool PlayMontage(USkeletalMeshComponent InSkeletalMeshComponent, UAnimMontage MontageToPlay, float PlayRate, float StartingPosition, bool bSnapShot, FName StartingSection, FName ExceptAdditiveSlot)
	{
		CheckDestroyed();
		if (!PlayMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlayMontageCallbackProxy:PlayMontage");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PlayMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PlayMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, PlayMontage_InSkeletalMeshComponent_Offset), 0, PlayMontage_InSkeletalMeshComponent_PropertyAddress.Address, InSkeletalMeshComponent);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, PlayMontage_MontageToPlay_Offset), 0, PlayMontage_MontageToPlay_PropertyAddress.Address, MontageToPlay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayMontage_PlayRate_Offset), 0, PlayMontage_PlayRate_PropertyAddress.Address, PlayRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayMontage_StartingPosition_Offset), 0, PlayMontage_StartingPosition_PropertyAddress.Address, StartingPosition);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PlayMontage_bSnapShot_Offset), 0, PlayMontage_bSnapShot_PropertyAddress.Address, bSnapShot);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PlayMontage_StartingSection_Offset), 0, PlayMontage_StartingSection_PropertyAddress.Address, StartingSection);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, PlayMontage_ExceptAdditiveSlot_Offset), 0, PlayMontage_ExceptAdditiveSlot_PropertyAddress.Address, ExceptAdditiveSlot);
		NativeReflection.InvokeFunctionOptimized(base.Address, PlayMontage_FunctionAddress, intPtr, PlayMontage_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PlayMontage_ReturnValue_Offset), 0, PlayMontage_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUPlayMontageCallbackProxy:CreateProxyObjectForPlayMontage")]
	public unsafe static UBGUPlayMontageCallbackProxy CreateProxyObjectForPlayMontage(int ReqIdx, UAnimMontage MontageToPlay)
	{
		if (!CreateProxyObjectForPlayMontage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUPlayMontageCallbackProxy:CreateProxyObjectForPlayMontage");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateProxyObjectForPlayMontage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateProxyObjectForPlayMontage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateProxyObjectForPlayMontage_ReqIdx_Offset), 0, CreateProxyObjectForPlayMontage_ReqIdx_PropertyAddress.Address, ReqIdx);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, CreateProxyObjectForPlayMontage_MontageToPlay_Offset), 0, CreateProxyObjectForPlayMontage_MontageToPlay_PropertyAddress.Address, MontageToPlay);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateProxyObjectForPlayMontage_FunctionAddress, intPtr, CreateProxyObjectForPlayMontage_ParamsSize);
		return UObjectMarshaler<UBGUPlayMontageCallbackProxy>.FromNative(IntPtr.Add(intPtr, CreateProxyObjectForPlayMontage_ReturnValue_Offset), 0, CreateProxyObjectForPlayMontage_ReturnValue_PropertyAddress.Address);
	}

	static UBGUPlayMontageCallbackProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUPlayMontageCallbackProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUPlayMontageCallbackProxy));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUPlayMontageCallbackProxy");
		OnCompleted_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnCompleted");
		OnCompleted_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnCompleted", Classes.FMulticastDelegateProperty);
		OnBlendOut_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnBlendOut");
		OnBlendOut_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnBlendOut", Classes.FMulticastDelegateProperty);
		OnInterrupted_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnInterrupted");
		OnInterrupted_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnInterrupted", Classes.FMulticastDelegateProperty);
		OnNotifyBegin_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnNotifyBegin");
		OnNotifyBegin_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnNotifyBegin", Classes.FMulticastDelegateProperty);
		OnNotifyEnd_Offset = NativeReflectionCached.GetPropertyOffset(classAddress, "OnNotifyEnd");
		OnNotifyEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(classAddress, "OnNotifyEnd", Classes.FMulticastDelegateProperty);
		PlayMontage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PlayMontage");
		PlayMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_InSkeletalMeshComponent_PropertyAddress, PlayMontage_FunctionAddress, "InSkeletalMeshComponent");
		PlayMontage_InSkeletalMeshComponent_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "InSkeletalMeshComponent");
		PlayMontage_InSkeletalMeshComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "InSkeletalMeshComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_MontageToPlay_PropertyAddress, PlayMontage_FunctionAddress, "MontageToPlay");
		PlayMontage_MontageToPlay_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "MontageToPlay");
		PlayMontage_MontageToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "MontageToPlay", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_PlayRate_PropertyAddress, PlayMontage_FunctionAddress, "PlayRate");
		PlayMontage_PlayRate_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "PlayRate");
		PlayMontage_PlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "PlayRate", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_StartingPosition_PropertyAddress, PlayMontage_FunctionAddress, "StartingPosition");
		PlayMontage_StartingPosition_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "StartingPosition");
		PlayMontage_StartingPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "StartingPosition", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_bSnapShot_PropertyAddress, PlayMontage_FunctionAddress, "bSnapShot");
		PlayMontage_bSnapShot_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "bSnapShot");
		PlayMontage_bSnapShot_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "bSnapShot", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_StartingSection_PropertyAddress, PlayMontage_FunctionAddress, "StartingSection");
		PlayMontage_StartingSection_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "StartingSection");
		PlayMontage_StartingSection_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "StartingSection", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_ExceptAdditiveSlot_PropertyAddress, PlayMontage_FunctionAddress, "ExceptAdditiveSlot");
		PlayMontage_ExceptAdditiveSlot_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "ExceptAdditiveSlot");
		PlayMontage_ExceptAdditiveSlot_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "ExceptAdditiveSlot", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayMontage_ReturnValue_PropertyAddress, PlayMontage_FunctionAddress, "ReturnValue");
		PlayMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PlayMontage_FunctionAddress, "ReturnValue");
		PlayMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PlayMontage_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PlayMontage_IsValid = PlayMontage_FunctionAddress != IntPtr.Zero && PlayMontage_InSkeletalMeshComponent_IsValid && PlayMontage_MontageToPlay_IsValid && PlayMontage_PlayRate_IsValid && PlayMontage_StartingPosition_IsValid && PlayMontage_bSnapShot_IsValid && PlayMontage_StartingSection_IsValid && PlayMontage_ExceptAdditiveSlot_IsValid && PlayMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlayMontageCallbackProxy:PlayMontage", PlayMontage_IsValid);
		CreateProxyObjectForPlayMontage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateProxyObjectForPlayMontage");
		CreateProxyObjectForPlayMontage_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateProxyObjectForPlayMontage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateProxyObjectForPlayMontage_ReqIdx_PropertyAddress, CreateProxyObjectForPlayMontage_FunctionAddress, "ReqIdx");
		CreateProxyObjectForPlayMontage_ReqIdx_Offset = NativeReflectionCached.GetPropertyOffset(CreateProxyObjectForPlayMontage_FunctionAddress, "ReqIdx");
		CreateProxyObjectForPlayMontage_ReqIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateProxyObjectForPlayMontage_FunctionAddress, "ReqIdx", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateProxyObjectForPlayMontage_MontageToPlay_PropertyAddress, CreateProxyObjectForPlayMontage_FunctionAddress, "MontageToPlay");
		CreateProxyObjectForPlayMontage_MontageToPlay_Offset = NativeReflectionCached.GetPropertyOffset(CreateProxyObjectForPlayMontage_FunctionAddress, "MontageToPlay");
		CreateProxyObjectForPlayMontage_MontageToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateProxyObjectForPlayMontage_FunctionAddress, "MontageToPlay", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateProxyObjectForPlayMontage_ReturnValue_PropertyAddress, CreateProxyObjectForPlayMontage_FunctionAddress, "ReturnValue");
		CreateProxyObjectForPlayMontage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateProxyObjectForPlayMontage_FunctionAddress, "ReturnValue");
		CreateProxyObjectForPlayMontage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateProxyObjectForPlayMontage_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateProxyObjectForPlayMontage_IsValid = CreateProxyObjectForPlayMontage_FunctionAddress != IntPtr.Zero && CreateProxyObjectForPlayMontage_ReqIdx_IsValid && CreateProxyObjectForPlayMontage_MontageToPlay_IsValid && CreateProxyObjectForPlayMontage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUPlayMontageCallbackProxy:CreateProxyObjectForPlayMontage", CreateProxyObjectForPlayMontage_IsValid);
	}
}
