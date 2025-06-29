using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Overlay;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Overlay.OverlayItem", "Overlay", UnrealModuleType.Engine)]
public struct FOverlayItem
{
	private static bool StartTime_IsValid;

	private static int StartTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160532997uL)]
	[UMetaPath("/Script/Overlay.OverlayItem:StartTime")]
	public FTimespan StartTime;

	private static bool EndTime_IsValid;

	private static int EndTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160532997uL)]
	[UMetaPath("/Script/Overlay.OverlayItem:EndTime")]
	public FTimespan EndTime;

	private static bool Text_IsValid;

	private static int Text_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/Overlay.OverlayItem:Text")]
	public string Text;

	private static bool Position_IsValid;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Overlay.OverlayItem:Position")]
	public FVector2D Position;

	private static bool FOverlayItem_IsValid;

	private static int FOverlayItem_StructSize;

	public FOverlayItem Copy()
	{
		return this;
	}

	public static FOverlayItem FromNative(IntPtr nativeBuffer)
	{
		return new FOverlayItem(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FOverlayItem value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FOverlayItem FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FOverlayItem(nativeBuffer + arrayIndex * FOverlayItem_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FOverlayItem value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FOverlayItem_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FOverlayItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Overlay.OverlayItem");
			return;
		}
		FTimespan.ToNative(IntPtr.Add(nativeStruct, StartTime_Offset), StartTime);
		FTimespan.ToNative(IntPtr.Add(nativeStruct, EndTime_Offset), EndTime);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Text_Offset), Text);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), Position);
	}

	public FOverlayItem(IntPtr nativeStruct)
	{
		if (!FOverlayItem_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Overlay.OverlayItem");
			StartTime = default(FTimespan);
			EndTime = default(FTimespan);
			Text = FStringMarshaler.DefaultString;
			Position = default(FVector2D);
		}
		else
		{
			StartTime = FTimespan.FromNative(IntPtr.Add(nativeStruct, StartTime_Offset));
			EndTime = FTimespan.FromNative(IntPtr.Add(nativeStruct, EndTime_Offset));
			Text = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Text_Offset));
			Position = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Position_Offset));
		}
	}

	static FOverlayItem()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FOverlayItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FOverlayItem));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Overlay.OverlayItem");
		FOverlayItem_StructSize = NativeReflection.GetStructSize(intPtr);
		StartTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartTime");
		StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartTime", Classes.FStructProperty);
		EndTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EndTime");
		EndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EndTime", Classes.FStructProperty);
		Text_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Text");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Text", Classes.FStrProperty);
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FStructProperty);
		FOverlayItem_IsValid = intPtr != IntPtr.Zero && StartTime_IsValid && EndTime_IsValid && Text_IsValid && Position_IsValid;
		NativeReflection.LogStructIsValid("/Script/Overlay.OverlayItem", FOverlayItem_IsValid);
	}
}
