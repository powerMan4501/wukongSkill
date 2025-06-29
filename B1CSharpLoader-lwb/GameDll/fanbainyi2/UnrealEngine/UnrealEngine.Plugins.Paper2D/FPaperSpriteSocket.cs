using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperSpriteSocket", "Paper2D", UnrealModuleType.EnginePlugin)]
public struct FPaperSpriteSocket
{
	private static bool LocalTransform_IsValid;

	private static int LocalTransform_Offset;

	[UProperty(Flags = (PropFlags)4503669420589077uL)]
	[UMetaPath("/Script/Paper2D.PaperSpriteSocket:LocalTransform")]
	public FTransform LocalTransform;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Paper2D.PaperSpriteSocket:SocketName")]
	public FName SocketName;

	private static bool FPaperSpriteSocket_IsValid;

	private static int FPaperSpriteSocket_StructSize;

	public FPaperSpriteSocket Copy()
	{
		return this;
	}

	public static FPaperSpriteSocket FromNative(IntPtr nativeBuffer)
	{
		return new FPaperSpriteSocket(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPaperSpriteSocket value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPaperSpriteSocket FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPaperSpriteSocket(nativeBuffer + arrayIndex * FPaperSpriteSocket_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPaperSpriteSocket value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPaperSpriteSocket_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPaperSpriteSocket_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.PaperSpriteSocket");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, LocalTransform_Offset), LocalTransform);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, SocketName_Offset), SocketName);
	}

	public FPaperSpriteSocket(IntPtr nativeStruct)
	{
		if (!FPaperSpriteSocket_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Paper2D.PaperSpriteSocket");
			LocalTransform = default(FTransform);
			SocketName = default(FName);
		}
		else
		{
			LocalTransform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, LocalTransform_Offset));
			SocketName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, SocketName_Offset));
		}
	}

	static FPaperSpriteSocket()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPaperSpriteSocket)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPaperSpriteSocket));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Paper2D.PaperSpriteSocket");
		FPaperSpriteSocket_StructSize = NativeReflection.GetStructSize(intPtr);
		LocalTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LocalTransform");
		LocalTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LocalTransform", Classes.FStructProperty);
		SocketName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		FPaperSpriteSocket_IsValid = intPtr != IntPtr.Zero && LocalTransform_IsValid && SocketName_IsValid;
		NativeReflection.LogStructIsValid("/Script/Paper2D.PaperSpriteSocket", FPaperSpriteSocket_IsValid);
	}
}
