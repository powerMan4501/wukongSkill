using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS PlayDummyAnim")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSPlayDummyAnim")]
internal class BANS_GSPlayDummyAnim : BANS_GSBase
{
	private static bool AnimSeq_IsValid;

	private static int AnimSeq_Offset;

	private static bool bLoop_IsValid;

	private static int bLoop_Offset;

	private static FFieldAddress bLoop_PropertyAddress;

	private static bool DummySKMeshCompTag_IsValid;

	private static int DummySKMeshCompTag_Offset;

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

	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayDummyAnim:AnimSeq")]
	public UAnimSequence AnimSeq
	{
		get
		{
			CheckDestroyed();
			if (!AnimSeq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayDummyAnim:AnimSeq");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimSeq_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimSeq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayDummyAnim:AnimSeq");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimSeq_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayDummyAnim:bLoop")]
	public bool bLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayDummyAnim:bLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoop_Offset), 0, bLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayDummyAnim:bLoop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bLoop_Offset), 0, bLoop_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[Tooltip("骨骼网格组件需要挂在主Mesh下，且加上此Tag，才能被读取到")]
	[USharpPath("/Script/b1-Managed.BANS_GSPlayDummyAnim:DummySKMeshCompTag")]
	public FName DummySKMeshCompTag
	{
		get
		{
			CheckDestroyed();
			if (!DummySKMeshCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayDummyAnim:DummySKMeshCompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DummySKMeshCompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DummySKMeshCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPlayDummyAnim:DummySKMeshCompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DummySKMeshCompTag_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		DummySKMeshCompTag = B1GlobalFNames.DummySK;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPlayDummyAnim:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (actorStreamingLevelWorld == null || AnimSeq == null || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (!(aCharacter != null))
		{
			return;
		}
		aCharacter.Mesh.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
		foreach (USceneComponent item in Children)
		{
			if (!item.ComponentTags.Contains(DummySKMeshCompTag))
			{
				continue;
			}
			USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
			if (uSkeletalMeshComponent != null)
			{
				BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_MovementData, BUC_MovementData>(owner);
				uSkeletalMeshComponent.PlayAnimation(AnimSeq, bLoop);
				if (!bLoop)
				{
					BUS_EventCollectionCS.Get(aCharacter)?.Evt_OnDummyMeshChange.Invoke(uSkeletalMeshComponent, bAdd: true, TotalDuration);
				}
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPlayDummyAnim:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null)
		{
			return;
		}
		UWorld actorStreamingLevelWorld = BGU_UnrealWorldUtil.GetActorStreamingLevelWorld(owner);
		if (actorStreamingLevelWorld == null || AnimSeq == null || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(actorStreamingLevelWorld))
		{
			return;
		}
		ACharacter aCharacter = owner as ACharacter;
		if (!(aCharacter != null))
		{
			return;
		}
		aCharacter.Mesh.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
		foreach (USceneComponent item in Children)
		{
			if (item.ComponentTags.Contains(DummySKMeshCompTag))
			{
				USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
				if (uSkeletalMeshComponent != null)
				{
					uSkeletalMeshComponent.Stop();
					BUS_EventCollectionCS.Get(aCharacter)?.Evt_OnDummyMeshChange.Invoke(uSkeletalMeshComponent, bAdd: false, 0f);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPlayDummyAnim:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPlayDummyAnim bANS_GSPlayDummyAnim = GCHelper.Find<b1.BANS_GSPlayDummyAnim>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSPlayDummyAnim.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPlayDummyAnim:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPlayDummyAnim bANS_GSPlayDummyAnim = GCHelper.Find<b1.BANS_GSPlayDummyAnim>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSPlayDummyAnim.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPlayDummyAnim");
		AnimSeq_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimSeq");
		AnimSeq_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimSeq", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bLoop_PropertyAddress, intPtr, "bLoop");
		bLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLoop");
		bLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLoop", Classes.FBoolProperty);
		DummySKMeshCompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "DummySKMeshCompTag");
		DummySKMeshCompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DummySKMeshCompTag", Classes.FNameProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPlayDummyAnim:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPlayDummyAnim:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSPlayDummyAnim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSPlayDummyAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSPlayDummyAnim));
	}
}
