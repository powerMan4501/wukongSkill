using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ForceVisibleStateCustomMode")]
public struct BUC_DispLibUtil_ForceVisibleStateCustomMode
{
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "如果外部请求给出的优先级与此参数相同，则执行以下行为，否则执行默认行为")]
	[DisplayName("目标请求优先级")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ForceVisibleStateCustomMode:RequestATKPriority")]
	public int RequestATKPriority;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("行为")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_ForceVisibleStateCustomMode:Mode")]
	public DispLibDBCNiagaraForceVisibleStateMode Mode;

	private static int BUC_DispLibUtil_ForceVisibleStateCustomMode_StructSize;

	private static int BUC_DispLibUtil_ForceVisibleStateCustomMode_IsValid;

	private static bool RequestATKPriority_IsValid;

	private static int RequestATKPriority_Offset;

	private static bool Mode_IsValid;

	private static int Mode_Offset;

	private static FFieldAddress Mode_PropertyAddress;

	public BUC_DispLibUtil_ForceVisibleStateCustomMode Copy()
	{
		return this;
	}

	public static BUC_DispLibUtil_ForceVisibleStateCustomMode FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibUtil_ForceVisibleStateCustomMode(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibUtil_ForceVisibleStateCustomMode value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibUtil_ForceVisibleStateCustomMode FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibUtil_ForceVisibleStateCustomMode(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ForceVisibleStateCustomMode_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibUtil_ForceVisibleStateCustomMode value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibUtil_ForceVisibleStateCustomMode_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ForceVisibleStateCustomMode_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ForceVisibleStateCustomMode");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RequestATKPriority_Offset), RequestATKPriority);
		EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
	}

	public BUC_DispLibUtil_ForceVisibleStateCustomMode(IntPtr nativeStruct)
	{
		if (BUC_DispLibUtil_ForceVisibleStateCustomMode_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibUtil_ForceVisibleStateCustomMode");
			RequestATKPriority = 0;
			Mode = DispLibDBCNiagaraForceVisibleStateMode.ImmdSetCompVisibleState;
		}
		else
		{
			RequestATKPriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RequestATKPriority_Offset));
			Mode = EnumMarshaler<DispLibDBCNiagaraForceVisibleStateMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_ForceVisibleStateCustomMode");
		BUC_DispLibUtil_ForceVisibleStateCustomMode_StructSize = NativeReflection.GetStructSize(intPtr);
		RequestATKPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "RequestATKPriority");
		RequestATKPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RequestATKPriority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		BUC_DispLibUtil_ForceVisibleStateCustomMode_IsValid = ((intPtr != IntPtr.Zero && RequestATKPriority_IsValid && Mode_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibUtil_ForceVisibleStateCustomMode", (byte)BUC_DispLibUtil_ForceVisibleStateCustomMode_IsValid != 0);
	}

	static BUC_DispLibUtil_ForceVisibleStateCustomMode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_ForceVisibleStateCustomMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_ForceVisibleStateCustomMode));
	}
}
