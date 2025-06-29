using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN GSMagicallyChangeFadeOut")]
[USharpPath("/Script/b1-Managed.BAN_GSMagicallyChangeFadeOut")]
internal class BAN_GSMagicallyChangeFadeOut : BAN_GSBase
{
	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BAN_GSMagicallyChangeFadeOut:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(owner))
		{
			BUS_EventCollectionCS.Get(owner).Evt_OnMagicallyChangeFadeOut.Invoke();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSMagicallyChangeFadeOut:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSMagicallyChangeFadeOut bAN_GSMagicallyChangeFadeOut = GCHelper.Find<b1.BAN_GSMagicallyChangeFadeOut>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSMagicallyChangeFadeOut.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSMagicallyChangeFadeOut");
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSMagicallyChangeFadeOut:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSMagicallyChangeFadeOut()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSMagicallyChangeFadeOut)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSMagicallyChangeFadeOut));
	}
}
