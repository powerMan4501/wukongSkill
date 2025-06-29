using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN PlayDummyAnim")]
[USharpPath("/Script/b1-Managed.BAN_GSPlayDummyAnim")]
internal class BAN_GSPlayDummyAnim : BAN_GSBase
{
	private static bool AnimSeq_IsValid;

	private static int AnimSeq_Offset;

	private static bool bLoop_IsValid;

	private static int bLoop_Offset;

	private static FFieldAddress bLoop_PropertyAddress;

	private static bool DummySKMeshCompTag_IsValid;

	private static int DummySKMeshCompTag_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayDummyAnim:AnimSeq")]
	public UAnimSequence AnimSeq
	{
		get
		{
			CheckDestroyed();
			if (!AnimSeq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayDummyAnim:AnimSeq");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimSeq_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimSeq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayDummyAnim:AnimSeq");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimSeq_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayDummyAnim:bLoop")]
	public bool bLoop
	{
		get
		{
			CheckDestroyed();
			if (!bLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayDummyAnim:bLoop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bLoop_Offset), 0, bLoop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bLoop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayDummyAnim:bLoop");
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
	[USharpPath("/Script/b1-Managed.BAN_GSPlayDummyAnim:DummySKMeshCompTag")]
	public FName DummySKMeshCompTag
	{
		get
		{
			CheckDestroyed();
			if (!DummySKMeshCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayDummyAnim:DummySKMeshCompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DummySKMeshCompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DummySKMeshCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayDummyAnim:DummySKMeshCompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DummySKMeshCompTag_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayDummyAnim:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayDummyAnim:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
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
					BUS_EventCollectionCS.Get(aCharacter)?.Evt_OnDummyMeshChange.Invoke(uSkeletalMeshComponent, bAdd: true, AnimSeq.GetPlayLength());
				}
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		DummySKMeshCompTag = B1GlobalFNames.DummySK;
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayDummyAnim:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSPlayDummyAnim bAN_GSPlayDummyAnim = GCHelper.Find<b1.BAN_GSPlayDummyAnim>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSPlayDummyAnim.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayDummyAnim:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSPlayDummyAnim bAN_GSPlayDummyAnim = GCHelper.Find<b1.BAN_GSPlayDummyAnim>(obj);
		bool value = bAN_GSPlayDummyAnim.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayDummyAnim");
		AnimSeq_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimSeq");
		AnimSeq_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimSeq", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bLoop_PropertyAddress, intPtr, "bLoop");
		bLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "bLoop");
		bLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bLoop", Classes.FBoolProperty);
		DummySKMeshCompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "DummySKMeshCompTag");
		DummySKMeshCompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DummySKMeshCompTag", Classes.FNameProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayDummyAnim:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayDummyAnim:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSPlayDummyAnim()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSPlayDummyAnim)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSPlayDummyAnim));
	}
}
