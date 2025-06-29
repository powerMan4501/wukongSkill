using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[Abstract]
[USharpPath("/Script/b1-Managed.DispLibDBCCustomEventDataAssetBase")]
public abstract class DispLibDBCCustomEventDataAssetBase : UBGWDataAsset
{
	public abstract DispLibDBCCustomEventType GetEventType();

	public abstract bool AllowOverrideTriggerMode();

	public abstract DispLibDBCCustomEventTriggerMode GetDefaultTriggerMode();

	public abstract bool AllowOverrideEndMode();

	public abstract DispLibDBCEndMode GetDefaultEndMode();

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLibDBCCustomEventDataAssetBase");
	}

	static DispLibDBCCustomEventDataAssetBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLibDBCCustomEventDataAssetBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLibDBCCustomEventDataAssetBase));
	}
}
