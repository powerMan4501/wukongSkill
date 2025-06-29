using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSDisplayDebug;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/GSDisplayDebug.GSDebugInfo", "GSDisplayDebug", UnrealModuleType.GamePlugin)]
public struct FGSDebugInfo
{
	private static bool DebugLine_IsValid;

	private static int DebugLine_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/GSDisplayDebug.GSDebugInfo:DebugLine")]
	public string DebugLine;

	private static bool DebugColor_IsValid;

	private static int DebugColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSDisplayDebug.GSDebugInfo:DebugColor")]
	public FColor DebugColor;

	private static bool FGSDebugInfo_IsValid;

	private static int FGSDebugInfo_StructSize;

	public FGSDebugInfo Copy()
	{
		return this;
	}

	public static FGSDebugInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGSDebugInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSDebugInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSDebugInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSDebugInfo(nativeBuffer + arrayIndex * FGSDebugInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSDebugInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSDebugInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSDisplayDebug.GSDebugInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, DebugLine_Offset), DebugLine);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, DebugColor_Offset), DebugColor);
	}

	public FGSDebugInfo(IntPtr nativeStruct)
	{
		if (!FGSDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSDisplayDebug.GSDebugInfo");
			DebugLine = FStringMarshaler.DefaultString;
			DebugColor = default(FColor);
		}
		else
		{
			DebugLine = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, DebugLine_Offset));
			DebugColor = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, DebugColor_Offset));
		}
	}

	static FGSDebugInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSDebugInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSDebugInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSDisplayDebug.GSDebugInfo");
		FGSDebugInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		DebugLine_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugLine");
		DebugLine_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugLine", Classes.FStrProperty);
		DebugColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugColor");
		DebugColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugColor", Classes.FStructProperty);
		FGSDebugInfo_IsValid = intPtr != IntPtr.Zero && DebugLine_IsValid && DebugColor_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSDisplayDebug.GSDebugInfo", FGSDebugInfo_IsValid);
	}
}
