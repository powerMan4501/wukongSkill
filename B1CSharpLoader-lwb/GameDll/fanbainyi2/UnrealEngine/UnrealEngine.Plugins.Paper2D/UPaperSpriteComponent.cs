using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Paper2D;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Paper2D.PaperSpriteComponent", "Paper2D", UnrealModuleType.EnginePlugin)]
public class UPaperSpriteComponent : UMeshComponent
{
	private static bool SourceSprite_IsValid;

	private static int SourceSprite_Offset;

	private static bool SpriteColor_IsValid;

	private static int SpriteColor_Offset;

	private static bool SetSpriteColor_IsValid;

	private static IntPtr SetSpriteColor_FunctionAddress;

	private static int SetSpriteColor_ParamsSize;

	private static bool SetSpriteColor_NewColor_IsValid;

	private static FFieldAddress SetSpriteColor_NewColor_PropertyAddress;

	private static int SetSpriteColor_NewColor_Offset;

	private static bool SetSprite_IsValid;

	private static IntPtr SetSprite_FunctionAddress;

	private static int SetSprite_ParamsSize;

	private static bool SetSprite_NewSprite_IsValid;

	private static FFieldAddress SetSprite_NewSprite_PropertyAddress;

	private static int SetSprite_NewSprite_Offset;

	private static bool SetSprite_ReturnValue_IsValid;

	private static FFieldAddress SetSprite_ReturnValue_PropertyAddress;

	private static int SetSprite_ReturnValue_Offset;

	private static bool GetSprite_IsValid;

	private static IntPtr GetSprite_FunctionAddress;

	private static int GetSprite_ParamsSize;

	private static bool GetSprite_ReturnValue_IsValid;

	private static FFieldAddress GetSprite_ReturnValue_PropertyAddress;

	private static int GetSprite_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/Paper2D.PaperSpriteComponent:SourceSprite")]
	protected UPaperSprite SourceSprite
	{
		get
		{
			CheckDestroyed();
			if (!SourceSprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSpriteComponent:SourceSprite");
				return null;
			}
			return UObjectMarshaler<UPaperSprite>.FromNative(IntPtr.Add(base.Address, SourceSprite_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SourceSprite_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSpriteComponent:SourceSprite");
			}
			else
			{
				UObjectMarshaler<UPaperSprite>.ToNative(IntPtr.Add(base.Address, SourceSprite_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267873544602133uL)]
	[UMetaPath("/Script/Paper2D.PaperSpriteComponent:SpriteColor")]
	protected FLinearColor SpriteColor
	{
		get
		{
			CheckDestroyed();
			if (!SpriteColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSpriteComponent:SpriteColor");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, SpriteColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpriteColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Paper2D.PaperSpriteComponent:SpriteColor");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, SpriteColor_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Paper2D.PaperSpriteComponent:SetSpriteColor")]
	public unsafe void SetSpriteColor(FLinearColor NewColor)
	{
		CheckDestroyed();
		if (!SetSpriteColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperSpriteComponent:SetSpriteColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSpriteColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSpriteColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetSpriteColor_NewColor_Offset), 0, SetSpriteColor_NewColor_PropertyAddress.Address, NewColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSpriteColor_FunctionAddress, intPtr, SetSpriteColor_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Paper2D.PaperSpriteComponent:SetSprite")]
	public unsafe bool SetSprite(UPaperSprite NewSprite)
	{
		CheckDestroyed();
		if (!SetSprite_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperSpriteComponent:SetSprite");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSprite_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSprite_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPaperSprite>.ToNative(IntPtr.Add(intPtr, SetSprite_NewSprite_Offset), 0, SetSprite_NewSprite_PropertyAddress.Address, NewSprite);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSprite_FunctionAddress, intPtr, SetSprite_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetSprite_ReturnValue_Offset), 0, SetSprite_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676416u)]
	[UMetaPath("/Script/Paper2D.PaperSpriteComponent:GetSprite")]
	public unsafe UPaperSprite GetSprite()
	{
		CheckDestroyed();
		if (!GetSprite_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Paper2D.PaperSpriteComponent:GetSprite");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSprite_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSprite_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSprite_FunctionAddress, intPtr, GetSprite_ParamsSize);
		return UObjectMarshaler<UPaperSprite>.FromNative(IntPtr.Add(intPtr, GetSprite_ReturnValue_Offset), 0, GetSprite_ReturnValue_PropertyAddress.Address);
	}

	static UPaperSpriteComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPaperSpriteComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPaperSpriteComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Paper2D.PaperSpriteComponent");
		SourceSprite_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceSprite");
		SourceSprite_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceSprite", Classes.FObjectProperty);
		SpriteColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpriteColor");
		SpriteColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpriteColor", Classes.FStructProperty);
		SetSpriteColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSpriteColor");
		SetSpriteColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSpriteColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSpriteColor_NewColor_PropertyAddress, SetSpriteColor_FunctionAddress, "NewColor");
		SetSpriteColor_NewColor_Offset = NativeReflectionCached.GetPropertyOffset(SetSpriteColor_FunctionAddress, "NewColor");
		SetSpriteColor_NewColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSpriteColor_FunctionAddress, "NewColor", Classes.FStructProperty);
		SetSpriteColor_IsValid = SetSpriteColor_FunctionAddress != IntPtr.Zero && SetSpriteColor_NewColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperSpriteComponent:SetSpriteColor", SetSpriteColor_IsValid);
		SetSprite_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSprite");
		SetSprite_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSprite_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSprite_NewSprite_PropertyAddress, SetSprite_FunctionAddress, "NewSprite");
		SetSprite_NewSprite_Offset = NativeReflectionCached.GetPropertyOffset(SetSprite_FunctionAddress, "NewSprite");
		SetSprite_NewSprite_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSprite_FunctionAddress, "NewSprite", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSprite_ReturnValue_PropertyAddress, SetSprite_FunctionAddress, "ReturnValue");
		SetSprite_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetSprite_FunctionAddress, "ReturnValue");
		SetSprite_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSprite_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetSprite_IsValid = SetSprite_FunctionAddress != IntPtr.Zero && SetSprite_NewSprite_IsValid && SetSprite_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperSpriteComponent:SetSprite", SetSprite_IsValid);
		GetSprite_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSprite");
		GetSprite_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSprite_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSprite_ReturnValue_PropertyAddress, GetSprite_FunctionAddress, "ReturnValue");
		GetSprite_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSprite_FunctionAddress, "ReturnValue");
		GetSprite_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSprite_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSprite_IsValid = GetSprite_FunctionAddress != IntPtr.Zero && GetSprite_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Paper2D.PaperSpriteComponent:GetSprite", GetSprite_IsValid);
	}
}
