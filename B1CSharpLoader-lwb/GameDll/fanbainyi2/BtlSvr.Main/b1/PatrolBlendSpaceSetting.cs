using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting")]
public struct PatrolBlendSpaceSetting
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:UseExPatrol")]
	public bool UseExPatrol;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:BSRunFwdPatrol")]
	public UBlendSpace BSRunFwdPatrol;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:BSRunBwdPatrol")]
	public UBlendSpace BSRunBwdPatrol;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:BSRunLeftPatrol")]
	public UBlendSpace BSRunLeftPatrol;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:BSRunRightPatrol")]
	public UBlendSpace BSRunRightPatrol;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:BSJogFwdSlopeLeanPatrol")]
	public UBlendSpace BSJogFwdSlopeLeanPatrol;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:BSJogBwdSlopeLeanPatrol")]
	public UBlendSpace BSJogBwdSlopeLeanPatrol;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:BSJogLeftSlopeLeanPatrol")]
	public UBlendSpace BSJogLeftSlopeLeanPatrol;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PatrolBlendSpaceSetting:BSJogRightSlopeLeanPatrol")]
	public UBlendSpace BSJogRightSlopeLeanPatrol;

	private static int PatrolBlendSpaceSetting_StructSize;

	private static int PatrolBlendSpaceSetting_IsValid;

	private static bool UseExPatrol_IsValid;

	private static int UseExPatrol_Offset;

	private static FFieldAddress UseExPatrol_PropertyAddress;

	private static bool BSRunFwdPatrol_IsValid;

	private static int BSRunFwdPatrol_Offset;

	private static bool BSRunBwdPatrol_IsValid;

	private static int BSRunBwdPatrol_Offset;

	private static bool BSRunLeftPatrol_IsValid;

	private static int BSRunLeftPatrol_Offset;

	private static bool BSRunRightPatrol_IsValid;

	private static int BSRunRightPatrol_Offset;

	private static bool BSJogFwdSlopeLeanPatrol_IsValid;

	private static int BSJogFwdSlopeLeanPatrol_Offset;

	private static bool BSJogBwdSlopeLeanPatrol_IsValid;

	private static int BSJogBwdSlopeLeanPatrol_Offset;

	private static bool BSJogLeftSlopeLeanPatrol_IsValid;

	private static int BSJogLeftSlopeLeanPatrol_Offset;

	private static bool BSJogRightSlopeLeanPatrol_IsValid;

	private static int BSJogRightSlopeLeanPatrol_Offset;

	public PatrolBlendSpaceSetting Copy()
	{
		return this;
	}

	public static PatrolBlendSpaceSetting FromNative(IntPtr nativeBuffer)
	{
		return new PatrolBlendSpaceSetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, PatrolBlendSpaceSetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static PatrolBlendSpaceSetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new PatrolBlendSpaceSetting(IntPtr.Add(nativeBuffer, arrayIndex * PatrolBlendSpaceSetting_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, PatrolBlendSpaceSetting value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PatrolBlendSpaceSetting_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PatrolBlendSpaceSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PatrolBlendSpaceSetting");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseExPatrol_Offset), 0, UseExPatrol_PropertyAddress.Address, UseExPatrol);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunFwdPatrol_Offset), BSRunFwdPatrol);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunBwdPatrol_Offset), BSRunBwdPatrol);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunLeftPatrol_Offset), BSRunLeftPatrol);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSRunRightPatrol_Offset), BSRunRightPatrol);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSJogFwdSlopeLeanPatrol_Offset), BSJogFwdSlopeLeanPatrol);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSJogBwdSlopeLeanPatrol_Offset), BSJogBwdSlopeLeanPatrol);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSJogLeftSlopeLeanPatrol_Offset), BSJogLeftSlopeLeanPatrol);
		UObjectMarshaler<UBlendSpace>.ToNative(IntPtr.Add(nativeStruct, BSJogRightSlopeLeanPatrol_Offset), BSJogRightSlopeLeanPatrol);
	}

	public PatrolBlendSpaceSetting(IntPtr nativeStruct)
	{
		if (PatrolBlendSpaceSetting_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PatrolBlendSpaceSetting");
			UseExPatrol = false;
			BSRunFwdPatrol = null;
			BSRunBwdPatrol = null;
			BSRunLeftPatrol = null;
			BSRunRightPatrol = null;
			BSJogFwdSlopeLeanPatrol = null;
			BSJogBwdSlopeLeanPatrol = null;
			BSJogLeftSlopeLeanPatrol = null;
			BSJogRightSlopeLeanPatrol = null;
		}
		else
		{
			UseExPatrol = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseExPatrol_Offset), 0, UseExPatrol_PropertyAddress.Address);
			BSRunFwdPatrol = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunFwdPatrol_Offset));
			BSRunBwdPatrol = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunBwdPatrol_Offset));
			BSRunLeftPatrol = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunLeftPatrol_Offset));
			BSRunRightPatrol = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSRunRightPatrol_Offset));
			BSJogFwdSlopeLeanPatrol = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSJogFwdSlopeLeanPatrol_Offset));
			BSJogBwdSlopeLeanPatrol = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSJogBwdSlopeLeanPatrol_Offset));
			BSJogLeftSlopeLeanPatrol = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSJogLeftSlopeLeanPatrol_Offset));
			BSJogRightSlopeLeanPatrol = UObjectMarshaler<UBlendSpace>.FromNative(IntPtr.Add(nativeStruct, BSJogRightSlopeLeanPatrol_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PatrolBlendSpaceSetting");
		PatrolBlendSpaceSetting_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UseExPatrol_PropertyAddress, intPtr, "UseExPatrol");
		UseExPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseExPatrol");
		UseExPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseExPatrol", Classes.FBoolProperty);
		BSRunFwdPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunFwdPatrol");
		BSRunFwdPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunFwdPatrol", Classes.FObjectProperty);
		BSRunBwdPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunBwdPatrol");
		BSRunBwdPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunBwdPatrol", Classes.FObjectProperty);
		BSRunLeftPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunLeftPatrol");
		BSRunLeftPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunLeftPatrol", Classes.FObjectProperty);
		BSRunRightPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSRunRightPatrol");
		BSRunRightPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSRunRightPatrol", Classes.FObjectProperty);
		BSJogFwdSlopeLeanPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJogFwdSlopeLeanPatrol");
		BSJogFwdSlopeLeanPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJogFwdSlopeLeanPatrol", Classes.FObjectProperty);
		BSJogBwdSlopeLeanPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJogBwdSlopeLeanPatrol");
		BSJogBwdSlopeLeanPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJogBwdSlopeLeanPatrol", Classes.FObjectProperty);
		BSJogLeftSlopeLeanPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJogLeftSlopeLeanPatrol");
		BSJogLeftSlopeLeanPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJogLeftSlopeLeanPatrol", Classes.FObjectProperty);
		BSJogRightSlopeLeanPatrol_Offset = NativeReflection.GetPropertyOffset(intPtr, "BSJogRightSlopeLeanPatrol");
		BSJogRightSlopeLeanPatrol_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BSJogRightSlopeLeanPatrol", Classes.FObjectProperty);
		PatrolBlendSpaceSetting_IsValid = ((intPtr != IntPtr.Zero && UseExPatrol_IsValid && BSRunFwdPatrol_IsValid && BSRunBwdPatrol_IsValid && BSRunLeftPatrol_IsValid && BSRunRightPatrol_IsValid && BSJogFwdSlopeLeanPatrol_IsValid && BSJogBwdSlopeLeanPatrol_IsValid && BSJogLeftSlopeLeanPatrol_IsValid && BSJogRightSlopeLeanPatrol_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PatrolBlendSpaceSetting", (byte)PatrolBlendSpaceSetting_IsValid != 0);
	}

	static PatrolBlendSpaceSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PatrolBlendSpaceSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PatrolBlendSpaceSetting));
	}
}
