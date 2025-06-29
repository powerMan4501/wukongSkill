using System;
using UnrealEngine.GameplayTasks;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/AIModule.AITask_MoveTo", "AIModule", UnrealModuleType.Engine)]
public class UAITask_MoveTo : UAITask
{
	private static bool OnRequestFailed_IsValid;

	private static int OnRequestFailed_Offset;

	private FGenericGameplayTaskDelegate OnRequestFailed_DelegateCached;

	private static bool OnMoveFinished_IsValid;

	private static int OnMoveFinished_Offset;

	private FMoveTaskCompletedSignature OnMoveFinished_DelegateCached;

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/AIModule.AITask_MoveTo:OnRequestFailed")]
	protected FGenericGameplayTaskDelegate OnRequestFailed
	{
		get
		{
			CheckDestroyed();
			if (!OnRequestFailed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AITask_MoveTo:OnRequestFailed");
				return new FGenericGameplayTaskDelegate();
			}
			if (OnRequestFailed_DelegateCached == null)
			{
				OnRequestFailed_DelegateCached = new FGenericGameplayTaskDelegate();
				OnRequestFailed_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnRequestFailed_Offset));
			}
			return OnRequestFailed_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/AIModule.AITask_MoveTo:OnMoveFinished")]
	protected FMoveTaskCompletedSignature OnMoveFinished
	{
		get
		{
			CheckDestroyed();
			if (!OnMoveFinished_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AITask_MoveTo:OnMoveFinished");
				return new FMoveTaskCompletedSignature();
			}
			if (OnMoveFinished_DelegateCached == null)
			{
				OnMoveFinished_DelegateCached = new FMoveTaskCompletedSignature();
				OnMoveFinished_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMoveFinished_Offset));
			}
			return OnMoveFinished_DelegateCached;
		}
	}

	static UAITask_MoveTo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAITask_MoveTo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAITask_MoveTo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AIModule.AITask_MoveTo");
		OnRequestFailed_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnRequestFailed");
		OnRequestFailed_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnRequestFailed", Classes.FMulticastDelegateProperty);
		OnMoveFinished_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnMoveFinished");
		OnMoveFinished_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnMoveFinished", Classes.FMulticastDelegateProperty);
	}
}
