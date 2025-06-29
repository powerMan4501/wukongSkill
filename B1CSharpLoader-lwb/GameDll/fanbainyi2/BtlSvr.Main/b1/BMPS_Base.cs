using System;
using b1.Plugins.CalliopeWin64;
using UnrealEngine.Runtime;

namespace b1;

[Abstract]
[UClass]
[USharpPath("/Script/b1-Managed.BMPS_Base")]
public class BMPS_Base : UCalliopeMoviePipelineSetting
{
	private static bool GetFooterTextCS_IsValid;

	private static IntPtr GetFooterTextCS_FunctionAddress;

	private static int GetFooterTextCS_ParamsSize;

	private static bool GetFooterTextCS_ReturnValue_IsValid;

	private static int GetFooterTextCS_ReturnValue_Offset;

	private static FFieldAddress GetFooterTextCS_ReturnValue_PropertyAddress;

	private static bool GetCategoryTextCS_IsValid;

	private static IntPtr GetCategoryTextCS_FunctionAddress;

	private static int GetCategoryTextCS_ParamsSize;

	private static bool GetCategoryTextCS_ReturnValue_IsValid;

	private static int GetCategoryTextCS_ReturnValue_Offset;

	private static FFieldAddress GetCategoryTextCS_ReturnValue_PropertyAddress;

	[USharpPath("/Script/b1-Managed.BMPS_Base:GetCategoryTextCS")]
	protected override string GetCategoryTextCS_Implementation()
	{
		return "GSSettings";
	}

	[USharpPath("/Script/b1-Managed.BMPS_Base:GetFooterTextCS")]
	protected override string GetFooterTextCS_Implementation()
	{
		return "未提供描述";
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_Base:GetFooterTextCS")]
	private static void GetFooterTextCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_Base bMPS_Base = GCHelper.Find<BMPS_Base>(obj);
		string footerTextCS_Implementation = bMPS_Base.GetFooterTextCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetFooterTextCS_ReturnValue_Offset), footerTextCS_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BMPS_Base:GetCategoryTextCS")]
	private static void GetCategoryTextCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BMPS_Base bMPS_Base = GCHelper.Find<BMPS_Base>(obj);
		string categoryTextCS_Implementation = bMPS_Base.GetCategoryTextCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetCategoryTextCS_ReturnValue_Offset), categoryTextCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BMPS_Base");
		GetFooterTextCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetFooterTextCS");
		GetFooterTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFooterTextCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetFooterTextCS_ReturnValue_PropertyAddress, GetFooterTextCS_FunctionAddress, "ReturnValue");
		GetFooterTextCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetFooterTextCS_FunctionAddress, "ReturnValue");
		GetFooterTextCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetFooterTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetFooterTextCS_IsValid = GetFooterTextCS_FunctionAddress != IntPtr.Zero && GetFooterTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_Base:GetFooterTextCS", GetFooterTextCS_IsValid);
		GetCategoryTextCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCategoryTextCS");
		GetCategoryTextCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCategoryTextCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetCategoryTextCS_ReturnValue_PropertyAddress, GetCategoryTextCS_FunctionAddress, "ReturnValue");
		GetCategoryTextCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCategoryTextCS_FunctionAddress, "ReturnValue");
		GetCategoryTextCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCategoryTextCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetCategoryTextCS_IsValid = GetCategoryTextCS_FunctionAddress != IntPtr.Zero && GetCategoryTextCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BMPS_Base:GetCategoryTextCS", GetCategoryTextCS_IsValid);
	}

	static BMPS_Base()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BMPS_Base)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BMPS_Base));
	}
}
