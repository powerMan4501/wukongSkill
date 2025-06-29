using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSUIMiscUtil")]
public class GSUIMiscUtil : UBlueprintFunctionLibrary
{
	private static readonly FName ParamNameInBGScrPosSize;

	private static readonly FName ParamNameInCoverScrPos;

	private static readonly FName ParamNameInCoverRefScale;

	private static bool GSUpdateABSMatCoverPos_IsValid;

	private static IntPtr GSUpdateABSMatCoverPos_FunctionAddress;

	private static int GSUpdateABSMatCoverPos_ParamsSize;

	private static bool GSUpdateABSMatCoverPos_RefABSDynamicInst_IsValid;

	private static int GSUpdateABSMatCoverPos_RefABSDynamicInst_Offset;

	private static bool GSUpdateABSMatCoverPos_ScreenRefPos_IsValid;

	private static int GSUpdateABSMatCoverPos_ScreenRefPos_Offset;

	private static FFieldAddress GSUpdateABSMatCoverPos_ScreenRefPos_PropertyAddress;

	private static bool GSUpdateABSMatSrcPosSize_IsValid;

	private static IntPtr GSUpdateABSMatSrcPosSize_FunctionAddress;

	private static int GSUpdateABSMatSrcPosSize_ParamsSize;

	private static bool GSUpdateABSMatSrcPosSize_RefWidget_IsValid;

	private static int GSUpdateABSMatSrcPosSize_RefWidget_Offset;

	private static bool GSUpdateABSMatSrcPosSize_RefABSDynamicInst_IsValid;

	private static int GSUpdateABSMatSrcPosSize_RefABSDynamicInst_Offset;

	private static bool GSUpdateABSMatCoverPosForImg_IsValid;

	private static IntPtr GSUpdateABSMatCoverPosForImg_FunctionAddress;

	private static int GSUpdateABSMatCoverPosForImg_ParamsSize;

	private static bool GSUpdateABSMatCoverPosForImg_RefImage_IsValid;

	private static int GSUpdateABSMatCoverPosForImg_RefImage_Offset;

	private static bool GSUpdateABSMatCoverPosForImg_ScreenRefPos_IsValid;

	private static int GSUpdateABSMatCoverPosForImg_ScreenRefPos_Offset;

	private static FFieldAddress GSUpdateABSMatCoverPosForImg_ScreenRefPos_PropertyAddress;

	private static bool GSUpdateABSMatSrcPosSizeForImg_IsValid;

	private static IntPtr GSUpdateABSMatSrcPosSizeForImg_FunctionAddress;

	private static int GSUpdateABSMatSrcPosSizeForImg_ParamsSize;

	private static bool GSUpdateABSMatSrcPosSizeForImg_RefImage_IsValid;

	private static int GSUpdateABSMatSrcPosSizeForImg_RefImage_Offset;

	[Category("GSUIMiscUtil")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatSrcPosSizeForImg")]
	public static void GSUpdateABSMatSrcPosSizeForImg(UImage RefImage)
	{
		UMaterialInstanceDynamic dynamicMaterial = RefImage.GetDynamicMaterial();
		if (!(dynamicMaterial == null))
		{
			GSUpdateABSMatSrcPosSize(RefImage, dynamicMaterial);
		}
	}

	[UFunction]
	[Category("GSUIMiscUtil")]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatCoverPosForImg")]
	public static void GSUpdateABSMatCoverPosForImg(UImage RefImage, FVector2D ScreenRefPos)
	{
		RefImage.GetDynamicMaterial().SetVectorParameterValue(ParamNameInCoverScrPos, new FLinearColor(ScreenRefPos.X, ScreenRefPos.Y, 0f, 0f));
	}

	[BlueprintCallable]
	[Category("GSUIMiscUtil")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatSrcPosSize")]
	public static void GSUpdateABSMatSrcPosSize(UWidget RefWidget, UMaterialInstanceDynamic RefABSDynamicInst)
	{
		float viewPortScale = UGSE_UMGFuncLib.GetViewPortScale(RefWidget);
		FVector2D widgetAbsolutePosition = UGSE_UMGFuncLib.GetWidgetAbsolutePosition(RefWidget);
		FVector2D widgetAbsoluteSize = UGSE_UMGFuncLib.GetWidgetAbsoluteSize(RefWidget);
		RefABSDynamicInst.SetVectorParameterValue(ParamNameInBGScrPosSize, new FLinearColor(widgetAbsolutePosition.X, widgetAbsolutePosition.Y, widgetAbsoluteSize.X, widgetAbsoluteSize.Y));
		RefABSDynamicInst.SetScalarParameterValue(ParamNameInCoverRefScale, viewPortScale);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("GSUIMiscUtil")]
	[USharpPath("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatCoverPos")]
	public static void GSUpdateABSMatCoverPos(UMaterialInstanceDynamic RefABSDynamicInst, FVector2D ScreenRefPos)
	{
		RefABSDynamicInst.SetVectorParameterValue(ParamNameInCoverScrPos, new FLinearColor(ScreenRefPos.X, ScreenRefPos.Y, 0f, 0f));
	}

	static GSUIMiscUtil()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSUIMiscUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSUIMiscUtil));
		ParamNameInBGScrPosSize = new FName("InBGScrPosSize");
		ParamNameInCoverScrPos = new FName("InCoverScrPos");
		ParamNameInCoverRefScale = new FName("InCoverRefScale");
	}

	[UFunctionInvoker("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatCoverPos")]
	private static void GSUpdateABSMatCoverPos__Invoker(IntPtr buffer, IntPtr obj)
	{
		UMaterialInstanceDynamic refABSDynamicInst = UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(buffer, GSUpdateABSMatCoverPos_RefABSDynamicInst_Offset));
		FVector2D screenRefPos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, GSUpdateABSMatCoverPos_ScreenRefPos_Offset));
		GSUpdateABSMatCoverPos(refABSDynamicInst, screenRefPos);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatSrcPosSize")]
	private static void GSUpdateABSMatSrcPosSize__Invoker(IntPtr buffer, IntPtr obj)
	{
		UWidget refWidget = UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(buffer, GSUpdateABSMatSrcPosSize_RefWidget_Offset));
		UMaterialInstanceDynamic refABSDynamicInst = UObjectMarshaler<UMaterialInstanceDynamic>.FromNative(IntPtr.Add(buffer, GSUpdateABSMatSrcPosSize_RefABSDynamicInst_Offset));
		GSUpdateABSMatSrcPosSize(refWidget, refABSDynamicInst);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatCoverPosForImg")]
	private static void GSUpdateABSMatCoverPosForImg__Invoker(IntPtr buffer, IntPtr obj)
	{
		UImage refImage = UObjectMarshaler<UImage>.FromNative(IntPtr.Add(buffer, GSUpdateABSMatCoverPosForImg_RefImage_Offset));
		FVector2D screenRefPos = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(buffer, GSUpdateABSMatCoverPosForImg_ScreenRefPos_Offset));
		GSUpdateABSMatCoverPosForImg(refImage, screenRefPos);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatSrcPosSizeForImg")]
	private static void GSUpdateABSMatSrcPosSizeForImg__Invoker(IntPtr buffer, IntPtr obj)
	{
		UImage refImage = UObjectMarshaler<UImage>.FromNative(IntPtr.Add(buffer, GSUpdateABSMatSrcPosSizeForImg_RefImage_Offset));
		GSUpdateABSMatSrcPosSizeForImg(refImage);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.GSUIMiscUtil");
		GSUpdateABSMatCoverPos_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSUpdateABSMatCoverPos");
		GSUpdateABSMatCoverPos_ParamsSize = NativeReflection.GetFunctionParamsSize(GSUpdateABSMatCoverPos_FunctionAddress);
		GSUpdateABSMatCoverPos_RefABSDynamicInst_Offset = NativeReflection.GetPropertyOffset(GSUpdateABSMatCoverPos_FunctionAddress, "RefABSDynamicInst");
		GSUpdateABSMatCoverPos_RefABSDynamicInst_IsValid = NativeReflection.ValidatePropertyClass(GSUpdateABSMatCoverPos_FunctionAddress, "RefABSDynamicInst", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GSUpdateABSMatCoverPos_ScreenRefPos_PropertyAddress, GSUpdateABSMatCoverPos_FunctionAddress, "ScreenRefPos");
		GSUpdateABSMatCoverPos_ScreenRefPos_Offset = NativeReflection.GetPropertyOffset(GSUpdateABSMatCoverPos_FunctionAddress, "ScreenRefPos");
		GSUpdateABSMatCoverPos_ScreenRefPos_IsValid = NativeReflection.ValidatePropertyClass(GSUpdateABSMatCoverPos_FunctionAddress, "ScreenRefPos", Classes.FStructProperty);
		GSUpdateABSMatCoverPos_IsValid = GSUpdateABSMatCoverPos_FunctionAddress != IntPtr.Zero && GSUpdateABSMatCoverPos_RefABSDynamicInst_IsValid && GSUpdateABSMatCoverPos_ScreenRefPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatCoverPos", GSUpdateABSMatCoverPos_IsValid);
		GSUpdateABSMatSrcPosSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSUpdateABSMatSrcPosSize");
		GSUpdateABSMatSrcPosSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GSUpdateABSMatSrcPosSize_FunctionAddress);
		GSUpdateABSMatSrcPosSize_RefWidget_Offset = NativeReflection.GetPropertyOffset(GSUpdateABSMatSrcPosSize_FunctionAddress, "RefWidget");
		GSUpdateABSMatSrcPosSize_RefWidget_IsValid = NativeReflection.ValidatePropertyClass(GSUpdateABSMatSrcPosSize_FunctionAddress, "RefWidget", Classes.FObjectProperty);
		GSUpdateABSMatSrcPosSize_RefABSDynamicInst_Offset = NativeReflection.GetPropertyOffset(GSUpdateABSMatSrcPosSize_FunctionAddress, "RefABSDynamicInst");
		GSUpdateABSMatSrcPosSize_RefABSDynamicInst_IsValid = NativeReflection.ValidatePropertyClass(GSUpdateABSMatSrcPosSize_FunctionAddress, "RefABSDynamicInst", Classes.FObjectProperty);
		GSUpdateABSMatSrcPosSize_IsValid = GSUpdateABSMatSrcPosSize_FunctionAddress != IntPtr.Zero && GSUpdateABSMatSrcPosSize_RefWidget_IsValid && GSUpdateABSMatSrcPosSize_RefABSDynamicInst_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatSrcPosSize", GSUpdateABSMatSrcPosSize_IsValid);
		GSUpdateABSMatCoverPosForImg_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSUpdateABSMatCoverPosForImg");
		GSUpdateABSMatCoverPosForImg_ParamsSize = NativeReflection.GetFunctionParamsSize(GSUpdateABSMatCoverPosForImg_FunctionAddress);
		GSUpdateABSMatCoverPosForImg_RefImage_Offset = NativeReflection.GetPropertyOffset(GSUpdateABSMatCoverPosForImg_FunctionAddress, "RefImage");
		GSUpdateABSMatCoverPosForImg_RefImage_IsValid = NativeReflection.ValidatePropertyClass(GSUpdateABSMatCoverPosForImg_FunctionAddress, "RefImage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref GSUpdateABSMatCoverPosForImg_ScreenRefPos_PropertyAddress, GSUpdateABSMatCoverPosForImg_FunctionAddress, "ScreenRefPos");
		GSUpdateABSMatCoverPosForImg_ScreenRefPos_Offset = NativeReflection.GetPropertyOffset(GSUpdateABSMatCoverPosForImg_FunctionAddress, "ScreenRefPos");
		GSUpdateABSMatCoverPosForImg_ScreenRefPos_IsValid = NativeReflection.ValidatePropertyClass(GSUpdateABSMatCoverPosForImg_FunctionAddress, "ScreenRefPos", Classes.FStructProperty);
		GSUpdateABSMatCoverPosForImg_IsValid = GSUpdateABSMatCoverPosForImg_FunctionAddress != IntPtr.Zero && GSUpdateABSMatCoverPosForImg_RefImage_IsValid && GSUpdateABSMatCoverPosForImg_ScreenRefPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatCoverPosForImg", GSUpdateABSMatCoverPosForImg_IsValid);
		GSUpdateABSMatSrcPosSizeForImg_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSUpdateABSMatSrcPosSizeForImg");
		GSUpdateABSMatSrcPosSizeForImg_ParamsSize = NativeReflection.GetFunctionParamsSize(GSUpdateABSMatSrcPosSizeForImg_FunctionAddress);
		GSUpdateABSMatSrcPosSizeForImg_RefImage_Offset = NativeReflection.GetPropertyOffset(GSUpdateABSMatSrcPosSizeForImg_FunctionAddress, "RefImage");
		GSUpdateABSMatSrcPosSizeForImg_RefImage_IsValid = NativeReflection.ValidatePropertyClass(GSUpdateABSMatSrcPosSizeForImg_FunctionAddress, "RefImage", Classes.FObjectProperty);
		GSUpdateABSMatSrcPosSizeForImg_IsValid = GSUpdateABSMatSrcPosSizeForImg_FunctionAddress != IntPtr.Zero && GSUpdateABSMatSrcPosSizeForImg_RefImage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSUIMiscUtil:GSUpdateABSMatSrcPosSizeForImg", GSUpdateABSMatSrcPosSizeForImg_IsValid);
	}
}
