using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAIT_ResetSceneItem")]
[USharpPath("/Script/b1-Managed.BAIT_ResetSceneItem")]
internal class BAIT_ResetSceneItem : BAIT_Base
{
	private static bool SceneActorTags_IsValid;

	private static int SceneActorTags_Offset;

	private static FFieldAddress SceneActorTags_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SceneActorTags_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_ResetSceneItem:SceneActorTags")]
	public TArrayReadWrite<FName> SceneActorTags
	{
		get
		{
			CheckDestroyed();
			if (!SceneActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_ResetSceneItem:SceneActorTags");
				return null;
			}
			if (SceneActorTags_Marshaler == null)
			{
				SceneActorTags_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SceneActorTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SceneActorTags_Marshaler.FromNative(IntPtr.Add(base.Address, SceneActorTags_Offset));
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BUS_EventCollectionCS.Get(OwnerActor)?.Evt_ResetSceneItemsByTag.Invoke(SceneActorTags.ToList());
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ResetSceneItem");
		NativeReflection.GetPropertyRef(ref SceneActorTags_PropertyAddress, unrealStruct, "SceneActorTags");
		SceneActorTags_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneActorTags");
		SceneActorTags_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneActorTags", Classes.FArrayProperty);
	}

	static BAIT_ResetSceneItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ResetSceneItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ResetSceneItem));
	}
}
