using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Spacer", "UMG", UnrealModuleType.Engine)]
public class USpacer : UWidget
{
	private static bool Size_IsValid;

	private static int Size_Offset;

	private static bool SetSize_IsValid;

	private static IntPtr SetSize_FunctionAddress;

	private static int SetSize_ParamsSize;

	private static bool SetSize_InSize_IsValid;

	private static FFieldAddress SetSize_InSize_PropertyAddress;

	private static int SetSize_InSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Spacer:Size")]
	public FVector2D Size
	{
		get
		{
			CheckDestroyed();
			if (!Size_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Spacer:Size");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Size_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Size_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Spacer:Size");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Size_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Spacer:SetSize")]
	public unsafe void SetSize(FVector2D InSize)
	{
		CheckDestroyed();
		if (!SetSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Spacer:SetSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetSize_InSize_Offset), 0, SetSize_InSize_PropertyAddress.Address, InSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSize_FunctionAddress, intPtr, SetSize_ParamsSize);
	}

	static USpacer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USpacer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USpacer));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.Spacer");
		Size_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Size", Classes.FStructProperty);
		SetSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSize");
		SetSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSize_InSize_PropertyAddress, SetSize_FunctionAddress, "InSize");
		SetSize_InSize_Offset = NativeReflectionCached.GetPropertyOffset(SetSize_FunctionAddress, "InSize");
		SetSize_InSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSize_FunctionAddress, "InSize", Classes.FStructProperty);
		SetSize_IsValid = SetSize_FunctionAddress != IntPtr.Zero && SetSize_InSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Spacer:SetSize", SetSize_IsValid);
	}
}
