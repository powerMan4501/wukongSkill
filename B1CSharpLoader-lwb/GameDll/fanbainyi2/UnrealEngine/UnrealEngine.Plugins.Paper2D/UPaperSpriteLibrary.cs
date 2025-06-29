using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/Paper2D.PaperSpriteBlueprintLibrary", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperSpriteLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool MakeBrushFromSprite_IsValid;

	private static IntPtr MakeBrushFromSprite_FunctionAddress;

	private static int MakeBrushFromSprite_ParamsSize;

	private static bool MakeBrushFromSprite_Sprite_IsValid;

	private static FFieldAddress MakeBrushFromSprite_Sprite_PropertyAddress;

	private static int MakeBrushFromSprite_Sprite_Offset;

	private static bool MakeBrushFromSprite_Width_IsValid;

	private static FFieldAddress MakeBrushFromSprite_Width_PropertyAddress;

	private static int MakeBrushFromSprite_Width_Offset;

	private static bool MakeBrushFromSprite_Height_IsValid;

	private static FFieldAddress MakeBrushFromSprite_Height_PropertyAddress;

	private static int MakeBrushFromSprite_Height_Offset;

	private static bool MakeBrushFromSprite_ReturnValue_IsValid;

	private static FFieldAddress MakeBrushFromSprite_ReturnValue_PropertyAddress;

	private static int MakeBrushFromSprite_ReturnValue_Offset;

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/Paper2D.PaperSpriteBlueprintLibrary:MakeBrushFromSprite")]
	public unsafe static FSlateBrush MakeBrushFromSprite(UPaperSprite Sprite, int Width, int Height)
	{
		if (!MakeBrushFromSprite_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperSpriteBlueprintLibrary:MakeBrushFromSprite");
			return default(FSlateBrush);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeBrushFromSprite_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeBrushFromSprite_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPaperSprite>.ToNative(IntPtr.Add(intPtr, MakeBrushFromSprite_Sprite_Offset), 0, MakeBrushFromSprite_Sprite_PropertyAddress.Address, Sprite);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeBrushFromSprite_Width_Offset), 0, MakeBrushFromSprite_Width_PropertyAddress.Address, Width);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, MakeBrushFromSprite_Height_Offset), 0, MakeBrushFromSprite_Height_PropertyAddress.Address, Height);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeBrushFromSprite_FunctionAddress, intPtr, MakeBrushFromSprite_ParamsSize);
		FSlateBrush result = FSlateBrush.FromNative(IntPtr.Add(intPtr, MakeBrushFromSprite_ReturnValue_Offset), 0, MakeBrushFromSprite_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(MakeBrushFromSprite_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UPaperSpriteLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperSpriteLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperSpriteLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Paper2D.PaperSpriteBlueprintLibrary");
		MakeBrushFromSprite_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeBrushFromSprite");
		MakeBrushFromSprite_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeBrushFromSprite_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromSprite_Sprite_PropertyAddress, MakeBrushFromSprite_FunctionAddress, "Sprite");
		MakeBrushFromSprite_Sprite_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromSprite_FunctionAddress, "Sprite");
		MakeBrushFromSprite_Sprite_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromSprite_FunctionAddress, "Sprite", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromSprite_Width_PropertyAddress, MakeBrushFromSprite_FunctionAddress, "Width");
		MakeBrushFromSprite_Width_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromSprite_FunctionAddress, "Width");
		MakeBrushFromSprite_Width_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromSprite_FunctionAddress, "Width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromSprite_Height_PropertyAddress, MakeBrushFromSprite_FunctionAddress, "Height");
		MakeBrushFromSprite_Height_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromSprite_FunctionAddress, "Height");
		MakeBrushFromSprite_Height_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromSprite_FunctionAddress, "Height", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeBrushFromSprite_ReturnValue_PropertyAddress, MakeBrushFromSprite_FunctionAddress, "ReturnValue");
		MakeBrushFromSprite_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeBrushFromSprite_FunctionAddress, "ReturnValue");
		MakeBrushFromSprite_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeBrushFromSprite_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		MakeBrushFromSprite_IsValid = MakeBrushFromSprite_FunctionAddress != IntPtr.Zero && MakeBrushFromSprite_Sprite_IsValid && MakeBrushFromSprite_Width_IsValid && MakeBrushFromSprite_Height_IsValid && MakeBrushFromSprite_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperSpriteBlueprintLibrary:MakeBrushFromSprite", MakeBrushFromSprite_IsValid);
	}
}
