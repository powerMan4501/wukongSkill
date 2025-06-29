using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("AddPostProcessMat")]
[Tooltip("添加一个后处理材质")]
[USharpPath("/Script/b1-Managed.BANS_GSAddPostProcessMat")]
internal class BANS_GSAddPostProcessMat : BANS_GSBase
{
	private static bool PostProcessMatSetting_IsValid;

	private static int PostProcessMatSetting_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[BlueprintReadWrite]
	[Category("Post Process")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAddPostProcessMat:PostProcessMatSetting")]
	public BGWDataAsset_PostProcessMatSetting PostProcessMatSetting
	{
		get
		{
			CheckDestroyed();
			if (!PostProcessMatSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAddPostProcessMat:PostProcessMatSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_PostProcessMatSetting>.FromNative(IntPtr.Add(base.Address, PostProcessMatSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PostProcessMatSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAddPostProcessMat:PostProcessMatSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_PostProcessMatSetting>.ToNative(IntPtr.Add(base.Address, PostProcessMatSetting_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAddPostProcessMat:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null) && !(PostProcessMatSetting == null))
		{
			BPS_EventCollectionCS.GetLocal(owner)?.Evt_AddPostProcessMat.Invoke(EPostProcessSource.AnimNotify, (int)GetUniqueID(), owner, PostProcessMatSetting);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAddPostProcessMat:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BPS_EventCollectionCS.GetLocal(owner)?.Evt_RemovePostProcessMat.Invoke(EPostProcessSource.AnimNotify, (int)GetUniqueID());
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAddPostProcessMat:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAddPostProcessMat bANS_GSAddPostProcessMat = GCHelper.Find<b1.BANS_GSAddPostProcessMat>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAddPostProcessMat.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAddPostProcessMat:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAddPostProcessMat bANS_GSAddPostProcessMat = GCHelper.Find<b1.BANS_GSAddPostProcessMat>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAddPostProcessMat.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAddPostProcessMat");
		PostProcessMatSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "PostProcessMatSetting");
		PostProcessMatSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PostProcessMatSetting", Classes.FObjectProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAddPostProcessMat:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAddPostProcessMat:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAddPostProcessMat()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAddPostProcessMat)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAddPostProcessMat));
	}
}
