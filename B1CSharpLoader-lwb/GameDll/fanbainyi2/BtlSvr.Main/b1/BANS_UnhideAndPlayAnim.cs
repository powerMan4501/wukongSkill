using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Unhide and Play Animation")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_UnhideAndPlayAnim")]
internal class BANS_UnhideAndPlayAnim : BANS_GSBase
{
	private static bool SKTag_IsValid;

	private static int SKTag_Offset;

	private static bool AnimationToPlay_IsValid;

	private static int AnimationToPlay_Offset;

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
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_UnhideAndPlayAnim:SKTag")]
	public FName SKTag
	{
		get
		{
			CheckDestroyed();
			if (!SKTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_UnhideAndPlayAnim:SKTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SKTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SKTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_UnhideAndPlayAnim:SKTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SKTag_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_UnhideAndPlayAnim:AnimationToPlay")]
	public UAnimationAsset AnimationToPlay
	{
		get
		{
			CheckDestroyed();
			if (!AnimationToPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_UnhideAndPlayAnim:AnimationToPlay");
				return null;
			}
			return UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(base.Address, AnimationToPlay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimationToPlay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_UnhideAndPlayAnim:AnimationToPlay");
			}
			else
			{
				UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(base.Address, AnimationToPlay_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_UnhideAndPlayAnim:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		foreach (UActorComponent item in bGUCharacterCS.GetComponentsByTag(UClass.GetClass<USkeletalMeshComponent>(), SKTag))
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
			if (!(uSkeletalMeshComponent == null))
			{
				uSkeletalMeshComponent.SetHiddenInGame(NewHidden: false);
				uSkeletalMeshComponent.PlayAnimation(AnimationToPlay, bLooping: false);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_UnhideAndPlayAnim:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.World))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		foreach (UActorComponent item in bGUCharacterCS.GetComponentsByTag(UClass.GetClass<USkeletalMeshComponent>(), SKTag))
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
			if (!(uSkeletalMeshComponent == null))
			{
				uSkeletalMeshComponent.Stop();
				uSkeletalMeshComponent.SetHiddenInGame(NewHidden: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_UnhideAndPlayAnim:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_UnhideAndPlayAnim bANS_UnhideAndPlayAnim = GCHelper.Find<b1.BANS_UnhideAndPlayAnim>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_UnhideAndPlayAnim.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_UnhideAndPlayAnim:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_UnhideAndPlayAnim bANS_UnhideAndPlayAnim = GCHelper.Find<b1.BANS_UnhideAndPlayAnim>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_UnhideAndPlayAnim.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_UnhideAndPlayAnim");
		SKTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "SKTag");
		SKTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SKTag", Classes.FNameProperty);
		AnimationToPlay_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimationToPlay");
		AnimationToPlay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimationToPlay", Classes.FObjectProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_UnhideAndPlayAnim:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_UnhideAndPlayAnim:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_UnhideAndPlayAnim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_UnhideAndPlayAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_UnhideAndPlayAnim));
	}
}
