using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSRoundRect", "UnrealExtent", UnrealModuleType.Game)]
public class UGSRoundRect : UOverlay
{
	private static bool CalcMappingRoundRectPoint_IsValid;

	private IntPtr CalcMappingRoundRectPoint_InstanceFunctionAddress;

	private static IntPtr CalcMappingRoundRectPoint_FunctionAddress;

	private static int CalcMappingRoundRectPoint_ParamsSize;

	private static bool CalcMappingRoundRectPoint_PosInViewPort_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_PosInViewPort_PropertyAddress;

	private static int CalcMappingRoundRectPoint_PosInViewPort_Offset;

	private static bool CalcMappingRoundRectPoint_IsInFront_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_IsInFront_PropertyAddress;

	private static int CalcMappingRoundRectPoint_IsInFront_Offset;

	private static bool CalcMappingRoundRectPoint_InnerContentRectSize_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_InnerContentRectSize_PropertyAddress;

	private static int CalcMappingRoundRectPoint_InnerContentRectSize_Offset;

	private static bool CalcMappingRoundRectPoint_InnerContentRectAlign_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_InnerContentRectAlign_PropertyAddress;

	private static int CalcMappingRoundRectPoint_InnerContentRectAlign_Offset;

	private static bool CalcMappingRoundRectPoint_IsOuter_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_IsOuter_PropertyAddress;

	private static int CalcMappingRoundRectPoint_IsOuter_Offset;

	private static bool CalcMappingRoundRectPoint_BorderPosRefRoundRect_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_BorderPosRefRoundRect_PropertyAddress;

	private static int CalcMappingRoundRectPoint_BorderPosRefRoundRect_Offset;

	private static bool CalcMappingRoundRectPoint_RectAngle_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_RectAngle_PropertyAddress;

	private static int CalcMappingRoundRectPoint_RectAngle_Offset;

	private static bool CalcMappingRoundRectPoint_OutIndicatorType_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_OutIndicatorType_PropertyAddress;

	private static int CalcMappingRoundRectPoint_OutIndicatorType_Offset;

	private static bool CalcMappingRoundRectPoint_ReturnValue_IsValid;

	private static FFieldAddress CalcMappingRoundRectPoint_ReturnValue_PropertyAddress;

	private static int CalcMappingRoundRectPoint_ReturnValue_Offset;

	[UFunction(Flags = 146933760u)]
	[UMetaPath("/Script/UnrealExtent.GSRoundRect:CalcMappingRoundRectPoint")]
	public unsafe bool CalcMappingRoundRectPoint(FVector2D PosInViewPort, bool IsInFront, FVector2D InnerContentRectSize, FVector2D InnerContentRectAlign, bool IsOuter, out FVector2D BorderPosRefRoundRect, out float RectAngle, out int OutIndicatorType)
	{
		CheckDestroyed();
		if (!CalcMappingRoundRectPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRoundRect:CalcMappingRoundRectPoint");
			BorderPosRefRoundRect = default(FVector2D);
			RectAngle = 0f;
			OutIndicatorType = 0;
			return false;
		}
		if (CalcMappingRoundRectPoint_InstanceFunctionAddress == IntPtr.Zero)
		{
			CalcMappingRoundRectPoint_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CalcMappingRoundRectPoint");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcMappingRoundRectPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcMappingRoundRectPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_PosInViewPort_Offset), 0, CalcMappingRoundRectPoint_PosInViewPort_PropertyAddress.Address, PosInViewPort);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_IsInFront_Offset), 0, CalcMappingRoundRectPoint_IsInFront_PropertyAddress.Address, IsInFront);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_InnerContentRectSize_Offset), 0, CalcMappingRoundRectPoint_InnerContentRectSize_PropertyAddress.Address, InnerContentRectSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_InnerContentRectAlign_Offset), 0, CalcMappingRoundRectPoint_InnerContentRectAlign_PropertyAddress.Address, InnerContentRectAlign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_IsOuter_Offset), 0, CalcMappingRoundRectPoint_IsOuter_PropertyAddress.Address, IsOuter);
		NativeReflection.InvokeFunctionOptimized(base.Address, CalcMappingRoundRectPoint_InstanceFunctionAddress, intPtr, CalcMappingRoundRectPoint_ParamsSize);
		BorderPosRefRoundRect = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_BorderPosRefRoundRect_Offset), 0, CalcMappingRoundRectPoint_BorderPosRefRoundRect_PropertyAddress.Address);
		RectAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_RectAngle_Offset), 0, CalcMappingRoundRectPoint_RectAngle_PropertyAddress.Address);
		OutIndicatorType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_OutIndicatorType_Offset), 0, CalcMappingRoundRectPoint_OutIndicatorType_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_ReturnValue_Offset), 0, CalcMappingRoundRectPoint_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool CalcMappingRoundRectPoint_Implementation(FVector2D PosInViewPort, bool IsInFront, FVector2D InnerContentRectSize, FVector2D InnerContentRectAlign, bool IsOuter, out FVector2D BorderPosRefRoundRect, out float RectAngle, out int OutIndicatorType)
	{
		CheckDestroyed();
		if (!CalcMappingRoundRectPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRoundRect:CalcMappingRoundRectPoint");
			BorderPosRefRoundRect = default(FVector2D);
			RectAngle = 0f;
			OutIndicatorType = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalcMappingRoundRectPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalcMappingRoundRectPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_PosInViewPort_Offset), 0, CalcMappingRoundRectPoint_PosInViewPort_PropertyAddress.Address, PosInViewPort);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_IsInFront_Offset), 0, CalcMappingRoundRectPoint_IsInFront_PropertyAddress.Address, IsInFront);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_InnerContentRectSize_Offset), 0, CalcMappingRoundRectPoint_InnerContentRectSize_PropertyAddress.Address, InnerContentRectSize);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_InnerContentRectAlign_Offset), 0, CalcMappingRoundRectPoint_InnerContentRectAlign_PropertyAddress.Address, InnerContentRectAlign);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_IsOuter_Offset), 0, CalcMappingRoundRectPoint_IsOuter_PropertyAddress.Address, IsOuter);
		NativeReflection.InvokeFunctionOptimized(base.Address, CalcMappingRoundRectPoint_FunctionAddress, intPtr, CalcMappingRoundRectPoint_ParamsSize);
		BorderPosRefRoundRect = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_BorderPosRefRoundRect_Offset), 0, CalcMappingRoundRectPoint_BorderPosRefRoundRect_PropertyAddress.Address);
		RectAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_RectAngle_Offset), 0, CalcMappingRoundRectPoint_RectAngle_PropertyAddress.Address);
		OutIndicatorType = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_OutIndicatorType_Offset), 0, CalcMappingRoundRectPoint_OutIndicatorType_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CalcMappingRoundRectPoint_ReturnValue_Offset), 0, CalcMappingRoundRectPoint_ReturnValue_PropertyAddress.Address);
	}

	static UGSRoundRect()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSRoundRect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSRoundRect));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/UnrealExtent.GSRoundRect");
		CalcMappingRoundRectPoint_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CalcMappingRoundRectPoint");
		CalcMappingRoundRectPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(CalcMappingRoundRectPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_PosInViewPort_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "PosInViewPort");
		CalcMappingRoundRectPoint_PosInViewPort_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "PosInViewPort");
		CalcMappingRoundRectPoint_PosInViewPort_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "PosInViewPort", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_IsInFront_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "IsInFront");
		CalcMappingRoundRectPoint_IsInFront_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "IsInFront");
		CalcMappingRoundRectPoint_IsInFront_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "IsInFront", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_InnerContentRectSize_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectSize");
		CalcMappingRoundRectPoint_InnerContentRectSize_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectSize");
		CalcMappingRoundRectPoint_InnerContentRectSize_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_InnerContentRectAlign_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectAlign");
		CalcMappingRoundRectPoint_InnerContentRectAlign_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectAlign");
		CalcMappingRoundRectPoint_InnerContentRectAlign_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "InnerContentRectAlign", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_IsOuter_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "IsOuter");
		CalcMappingRoundRectPoint_IsOuter_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "IsOuter");
		CalcMappingRoundRectPoint_IsOuter_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "IsOuter", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_BorderPosRefRoundRect_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "BorderPosRefRoundRect");
		CalcMappingRoundRectPoint_BorderPosRefRoundRect_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "BorderPosRefRoundRect");
		CalcMappingRoundRectPoint_BorderPosRefRoundRect_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "BorderPosRefRoundRect", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_RectAngle_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "RectAngle");
		CalcMappingRoundRectPoint_RectAngle_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "RectAngle");
		CalcMappingRoundRectPoint_RectAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "RectAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_OutIndicatorType_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "OutIndicatorType");
		CalcMappingRoundRectPoint_OutIndicatorType_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "OutIndicatorType");
		CalcMappingRoundRectPoint_OutIndicatorType_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "OutIndicatorType", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CalcMappingRoundRectPoint_ReturnValue_PropertyAddress, CalcMappingRoundRectPoint_FunctionAddress, "ReturnValue");
		CalcMappingRoundRectPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CalcMappingRoundRectPoint_FunctionAddress, "ReturnValue");
		CalcMappingRoundRectPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CalcMappingRoundRectPoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CalcMappingRoundRectPoint_IsValid = CalcMappingRoundRectPoint_FunctionAddress != IntPtr.Zero && CalcMappingRoundRectPoint_PosInViewPort_IsValid && CalcMappingRoundRectPoint_IsInFront_IsValid && CalcMappingRoundRectPoint_InnerContentRectSize_IsValid && CalcMappingRoundRectPoint_InnerContentRectAlign_IsValid && CalcMappingRoundRectPoint_IsOuter_IsValid && CalcMappingRoundRectPoint_BorderPosRefRoundRect_IsValid && CalcMappingRoundRectPoint_RectAngle_IsValid && CalcMappingRoundRectPoint_OutIndicatorType_IsValid && CalcMappingRoundRectPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRoundRect:CalcMappingRoundRectPoint", CalcMappingRoundRectPoint_IsValid);
	}
}
