using System;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/UMG.WidgetNavigationData", "UMG", UnrealModuleType.Engine)]
public struct FWidgetNavigationData
{
	private static bool Rule_IsValid;

	private static FFieldAddress Rule_PropertyAddress;

	private static int Rule_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WidgetNavigationData:Rule")]
	public EUINavigationRule Rule;

	private static bool WidgetToFocus_IsValid;

	private static int WidgetToFocus_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.WidgetNavigationData:WidgetToFocus")]
	public FName WidgetToFocus;

	private static bool FWidgetNavigationData_IsValid;

	private static int FWidgetNavigationData_StructSize;

	public FWidgetNavigationData Copy()
	{
		return this;
	}

	public static FWidgetNavigationData FromNative(IntPtr nativeBuffer)
	{
		return new FWidgetNavigationData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWidgetNavigationData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWidgetNavigationData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWidgetNavigationData(nativeBuffer + arrayIndex * FWidgetNavigationData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWidgetNavigationData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWidgetNavigationData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWidgetNavigationData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.WidgetNavigationData");
			return;
		}
		EnumMarshaler<EUINavigationRule>.ToNative(IntPtr.Add(nativeStruct, Rule_Offset), 0, Rule_PropertyAddress.Address, Rule);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, WidgetToFocus_Offset), WidgetToFocus);
	}

	public FWidgetNavigationData(IntPtr nativeStruct)
	{
		if (!FWidgetNavigationData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UMG.WidgetNavigationData");
			Rule = EUINavigationRule.Escape;
			WidgetToFocus = default(FName);
		}
		else
		{
			Rule = EnumMarshaler<EUINavigationRule>.FromNative(IntPtr.Add(nativeStruct, Rule_Offset), 0, Rule_PropertyAddress.Address);
			WidgetToFocus = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, WidgetToFocus_Offset));
		}
	}

	static FWidgetNavigationData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWidgetNavigationData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWidgetNavigationData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UMG.WidgetNavigationData");
		FWidgetNavigationData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Rule_PropertyAddress, intPtr, "Rule");
		Rule_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rule");
		Rule_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rule", Classes.FEnumProperty);
		WidgetToFocus_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidgetToFocus");
		WidgetToFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidgetToFocus", Classes.FNameProperty);
		FWidgetNavigationData_IsValid = intPtr != IntPtr.Zero && Rule_IsValid && WidgetToFocus_IsValid;
		NativeReflection.LogStructIsValid("/Script/UMG.WidgetNavigationData", FWidgetNavigationData_IsValid);
	}
}
