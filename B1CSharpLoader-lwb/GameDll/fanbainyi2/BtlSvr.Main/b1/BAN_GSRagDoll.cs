using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Replace Rag Doll")]
[USharpPath("/Script/b1-Managed.BAN_GSRagDoll")]
internal class BAN_GSRagDoll : BAN_GSBase
{
	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BAN_GSRagDoll:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		USkeletalMeshComponent meshComp = NotifyParam.MeshComp;
		if (meshComp?.GetOwner() != null)
		{
			BGUCharacterCS bGUCharacterCS = meshComp.GetOwner() as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_EnableTransUnitPhysicsAsset.Invoke();
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSRagDoll:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSRagDoll bAN_GSRagDoll = GCHelper.Find<b1.BAN_GSRagDoll>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSRagDoll.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSRagDoll");
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSRagDoll:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSRagDoll()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSRagDoll)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSRagDoll));
	}
}
