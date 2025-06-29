using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("Notify Actor")]
[UClass]
[Placeable(false)]
[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NotifyActor")]
public class BED_ProcessStateNode_NotifyActor : BED_ProcessStateNode
{
	private static bool NotifyTags_IsValid;

	private static int NotifyTags_Offset;

	[UProperty]
	[EditDefaultsOnly]
	[Category("NotifyActor")]
	[USharpPath("/Script/b1-Managed.BED_ProcessStateNode_NotifyActor:NotifyTags")]
	protected FGameplayTagContainer NotifyTags
	{
		get
		{
			CheckDestroyed();
			if (!NotifyTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NotifyActor:NotifyTags");
				return default(FGameplayTagContainer);
			}
			return FGameplayTagContainer.FromNative(IntPtr.Add(base.Address, NotifyTags_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotifyTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_ProcessStateNode_NotifyActor:NotifyTags");
			}
			else
			{
				FGameplayTagContainer.ToNative(IntPtr.Add(base.Address, NotifyTags_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		base.Category = "Notify";
		base.NodeStyle = ECalliopeNodeStyle.Default;
	}

	public override string GetNodeName()
	{
		return "Process.State.NotifyActor";
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_ProcessStateNode_NotifyActor");
		NotifyTags_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NotifyTags");
		NotifyTags_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NotifyTags", Classes.FStructProperty);
	}

	static BED_ProcessStateNode_NotifyActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_ProcessStateNode_NotifyActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_ProcessStateNode_NotifyActor));
	}
}
