using System;
using System.Linq;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS PausePhysics")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSPausePhysics")]
internal class BANS_GSPausePhysics : BANS_GSBase
{
	public bool OriginalEnableRBAN;

	private static bool IncludeChildren_IsValid;

	private static int IncludeChildren_Offset;

	private static FFieldAddress IncludeChildren_PropertyAddress;

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

	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("是否包含子物体")]
	[DisplayName("包含子物体")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSPausePhysics:IncludeChildren")]
	public bool IncludeChildren
	{
		get
		{
			CheckDestroyed();
			if (!IncludeChildren_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPausePhysics:IncludeChildren");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeChildren_Offset), 0, IncludeChildren_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeChildren_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSPausePhysics:IncludeChildren");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeChildren_Offset), 0, IncludeChildren_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.CanBePlacedInASCS = true;
		base.CanUseQueuedType = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		OriginalEnableRBAN = meshComp.GetAllowRigidBodyAnimNode();
		meshComp.SetAllBodiesPhysicsBlendWeight(0f);
		if (OriginalEnableRBAN)
		{
			meshComp.SetAllowRigidBodyAnimNode(bInAllow: false, bReinitAnim: false);
		}
		if (!IncludeChildren)
		{
			return;
		}
		meshComp.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
		foreach (USkeletalMeshComponent item in Children.OfType<USkeletalMeshComponent>())
		{
			item.SetAllBodiesPhysicsBlendWeight(0f);
			if (OriginalEnableRBAN)
			{
				item.SetAllowRigidBodyAnimNode(bInAllow: false, bReinitAnim: false);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		meshComp.SetAllBodiesPhysicsBlendWeight(1f);
		if (OriginalEnableRBAN)
		{
			meshComp.SetAllowRigidBodyAnimNode(bInAllow: true, bReinitAnim: false);
		}
		if (!IncludeChildren)
		{
			return;
		}
		meshComp.GetChildrenComponents(bIncludeAllDescendants: false, out var Children);
		foreach (USkeletalMeshComponent item in Children.OfType<USkeletalMeshComponent>())
		{
			item.SetAllBodiesPhysicsBlendWeight(1f);
			if (OriginalEnableRBAN)
			{
				item.SetAllowRigidBodyAnimNode(bInAllow: true, bReinitAnim: false);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPausePhysics bANS_GSPausePhysics = GCHelper.Find<b1.BANS_GSPausePhysics>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSPausePhysics.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPausePhysics bANS_GSPausePhysics = GCHelper.Find<b1.BANS_GSPausePhysics>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSPausePhysics.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSPausePhysics bANS_GSPausePhysics = GCHelper.Find<b1.BANS_GSPausePhysics>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSPausePhysics.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSPausePhysics");
		NativeReflection.GetPropertyRef(ref IncludeChildren_PropertyAddress, intPtr, "IncludeChildren");
		IncludeChildren_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncludeChildren");
		IncludeChildren_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncludeChildren", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSPausePhysics:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSPausePhysics()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSPausePhysics)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSPausePhysics));
	}
}
