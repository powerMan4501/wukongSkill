using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/UMG.AsyncTaskDownloadImage", "UMG", UnrealModuleType.Engine)]
public class UAsyncTaskDownloadImage : UBlueprintAsyncActionBase
{
	private static bool OnSuccess_IsValid;

	private static int OnSuccess_Offset;

	private FDownloadImageDelegate OnSuccess_DelegateCached;

	private static bool OnFail_IsValid;

	private static int OnFail_Offset;

	private FDownloadImageDelegate OnFail_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.AsyncTaskDownloadImage:OnSuccess")]
	public FDownloadImageDelegate OnSuccess
	{
		get
		{
			CheckDestroyed();
			if (!OnSuccess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.AsyncTaskDownloadImage:OnSuccess");
				return new FDownloadImageDelegate();
			}
			if (OnSuccess_DelegateCached == null)
			{
				OnSuccess_DelegateCached = new FDownloadImageDelegate();
				OnSuccess_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnSuccess_Offset));
			}
			return OnSuccess_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/UMG.AsyncTaskDownloadImage:OnFail")]
	public FDownloadImageDelegate OnFail
	{
		get
		{
			CheckDestroyed();
			if (!OnFail_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.AsyncTaskDownloadImage:OnFail");
				return new FDownloadImageDelegate();
			}
			if (OnFail_DelegateCached == null)
			{
				OnFail_DelegateCached = new FDownloadImageDelegate();
				OnFail_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnFail_Offset));
			}
			return OnFail_DelegateCached;
		}
	}

	static UAsyncTaskDownloadImage()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAsyncTaskDownloadImage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAsyncTaskDownloadImage));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UMG.AsyncTaskDownloadImage");
		OnSuccess_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnSuccess");
		OnSuccess_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnSuccess", Classes.FMulticastDelegateProperty);
		OnFail_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "OnFail");
		OnFail_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "OnFail", Classes.FMulticastDelegateProperty);
	}
}
