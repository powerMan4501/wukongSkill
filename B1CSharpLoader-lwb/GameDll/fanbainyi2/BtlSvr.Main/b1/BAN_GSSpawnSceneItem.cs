using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Spawn Scene Item")]
[USharpPath("/Script/b1-Managed.BAN_GSSpawnSceneItem")]
public class BAN_GSSpawnSceneItem : BAN_GSBase
{
	private static bool SceneItemTag_IsValid;

	private static int SceneItemTag_Offset;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

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

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSSpawnSceneItem:SceneItemTag")]
	public FName SceneItemTag
	{
		get
		{
			CheckDestroyed();
			if (!SceneItemTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnSceneItem:SceneItemTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SceneItemTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneItemTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnSceneItem:SceneItemTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SceneItemTag_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSSpawnSceneItem:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnSceneItem:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSSpawnSceneItem:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSpawnSceneItem:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSSpawnSceneItem:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		base.GSNotifyCS_Implementation(NotifyParam);
		ABGUCharacter aBGUCharacter = NotifyParam.owner as ABGUCharacter;
		if (aBGUCharacter == null || aBGUCharacter.IsNullOrDestroyed())
		{
			return;
		}
		UWorld world = NotifyParam.owner.World;
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(world))
		{
			return;
		}
		FVector socketLocation = aBGUCharacter.Mesh.GetSocketLocation(SocketName);
		UGameplayStatics.GetAllActorsOfClassWithTag(aBGUCharacter, UClass.GetClass<BGUSceneItemBase>(), SceneItemTag, out var OutActors);
		BGUSceneItemBase bGUSceneItemBase = null;
		if (OutActors.Count == 0)
		{
			bGUSceneItemBase = UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(world, UClass.GetClass(typeof(BGUSceneItemBase)), FTransform.Identity, ESpawnActorCollisionHandlingMethod.AlwaysSpawn, aBGUCharacter) as BGUSceneItemBase;
			if (bGUSceneItemBase != null)
			{
				bGUSceneItemBase.Tags.Add(SceneItemTag);
				UBGUFunctionLibrary.BGUFinishSpawningActor(bGUSceneItemBase, FTransform.Identity);
			}
		}
		else
		{
			if (OutActors.Count > 1)
			{
				for (int i = 1; i < OutActors.Count; i++)
				{
					BGU_UnrealWorldUtil.DestroyActor(OutActors[i]);
				}
			}
			bGUSceneItemBase = OutActors[0] as BGUSceneItemBase;
		}
		if (!(bGUSceneItemBase == null))
		{
			bGUSceneItemBase.SetActorLocation(socketLocation, bSweep: false, out var _, bTeleport: true);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSpawnSceneItem:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSSpawnSceneItem bAN_GSSpawnSceneItem = GCHelper.Find<BAN_GSSpawnSceneItem>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSSpawnSceneItem.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSSpawnSceneItem:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSSpawnSceneItem bAN_GSSpawnSceneItem = GCHelper.Find<BAN_GSSpawnSceneItem>(obj);
		bool value = bAN_GSSpawnSceneItem.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSSpawnSceneItem");
		SceneItemTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneItemTag");
		SceneItemTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneItemTag", Classes.FNameProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSpawnSceneItem:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSSpawnSceneItem:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSSpawnSceneItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSSpawnSceneItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSSpawnSceneItem));
	}
}
