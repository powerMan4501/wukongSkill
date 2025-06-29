using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.CircularThrobber", "UMG", UnrealModuleType.Engine)]
public class UCircularThrobber : UWidget
{
	private static bool NumberOfPieces_IsValid;

	private static int NumberOfPieces_Offset;

	private static bool Period_IsValid;

	private static int Period_Offset;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool Image_IsValid;

	private static int Image_Offset;

	private static bool SetRadius_IsValid;

	private static IntPtr SetRadius_FunctionAddress;

	private static int SetRadius_ParamsSize;

	private static bool SetRadius_InRadius_IsValid;

	private static FFieldAddress SetRadius_InRadius_PropertyAddress;

	private static int SetRadius_InRadius_Offset;

	private static bool SetPeriod_IsValid;

	private static IntPtr SetPeriod_FunctionAddress;

	private static int SetPeriod_ParamsSize;

	private static bool SetPeriod_InPeriod_IsValid;

	private static FFieldAddress SetPeriod_InPeriod_PropertyAddress;

	private static int SetPeriod_InPeriod_Offset;

	private static bool SetNumberOfPieces_IsValid;

	private static IntPtr SetNumberOfPieces_FunctionAddress;

	private static int SetNumberOfPieces_ParamsSize;

	private static bool SetNumberOfPieces_InNumberOfPieces_IsValid;

	private static FFieldAddress SetNumberOfPieces_InNumberOfPieces_PropertyAddress;

	private static int SetNumberOfPieces_InNumberOfPieces_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.CircularThrobber:NumberOfPieces")]
	public int NumberOfPieces
	{
		get
		{
			CheckDestroyed();
			if (!NumberOfPieces_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CircularThrobber:NumberOfPieces");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, NumberOfPieces_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NumberOfPieces_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CircularThrobber:NumberOfPieces");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, NumberOfPieces_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.CircularThrobber:Period")]
	public float Period
	{
		get
		{
			CheckDestroyed();
			if (!Period_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CircularThrobber:Period");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Period_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Period_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CircularThrobber:Period");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Period_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.CircularThrobber:Radius")]
	public float Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CircularThrobber:Radius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CircularThrobber:Radius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.CircularThrobber:Image")]
	public FSlateBrush Image
	{
		get
		{
			CheckDestroyed();
			if (!Image_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CircularThrobber:Image");
				return default(FSlateBrush);
			}
			return FSlateBrush.FromNative(IntPtr.Add(base.Address, Image_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Image_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.CircularThrobber:Image");
			}
			else
			{
				FSlateBrush.ToNative(IntPtr.Add(base.Address, Image_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CircularThrobber:SetRadius")]
	public unsafe void SetRadius(float InRadius)
	{
		CheckDestroyed();
		if (!SetRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CircularThrobber:SetRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRadius_InRadius_Offset), 0, SetRadius_InRadius_PropertyAddress.Address, InRadius);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRadius_FunctionAddress, intPtr, SetRadius_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CircularThrobber:SetPeriod")]
	public unsafe void SetPeriod(float InPeriod)
	{
		CheckDestroyed();
		if (!SetPeriod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CircularThrobber:SetPeriod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPeriod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPeriod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetPeriod_InPeriod_Offset), 0, SetPeriod_InPeriod_PropertyAddress.Address, InPeriod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPeriod_FunctionAddress, intPtr, SetPeriod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.CircularThrobber:SetNumberOfPieces")]
	public unsafe void SetNumberOfPieces(int InNumberOfPieces)
	{
		CheckDestroyed();
		if (!SetNumberOfPieces_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.CircularThrobber:SetNumberOfPieces");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumberOfPieces_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumberOfPieces_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumberOfPieces_InNumberOfPieces_Offset), 0, SetNumberOfPieces_InNumberOfPieces_PropertyAddress.Address, InNumberOfPieces);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNumberOfPieces_FunctionAddress, intPtr, SetNumberOfPieces_ParamsSize);
	}

	static UCircularThrobber()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCircularThrobber)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCircularThrobber));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.CircularThrobber");
		NumberOfPieces_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumberOfPieces");
		NumberOfPieces_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumberOfPieces", Classes.FIntProperty);
		Period_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Period");
		Period_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Period", Classes.FFloatProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		Image_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Image");
		Image_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Image", Classes.FStructProperty);
		SetRadius_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRadius");
		SetRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRadius_InRadius_PropertyAddress, SetRadius_FunctionAddress, "InRadius");
		SetRadius_InRadius_Offset = NativeReflectionCached.GetPropertyOffset(SetRadius_FunctionAddress, "InRadius");
		SetRadius_InRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRadius_FunctionAddress, "InRadius", Classes.FFloatProperty);
		SetRadius_IsValid = SetRadius_FunctionAddress != IntPtr.Zero && SetRadius_InRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CircularThrobber:SetRadius", SetRadius_IsValid);
		SetPeriod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPeriod");
		SetPeriod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPeriod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPeriod_InPeriod_PropertyAddress, SetPeriod_FunctionAddress, "InPeriod");
		SetPeriod_InPeriod_Offset = NativeReflectionCached.GetPropertyOffset(SetPeriod_FunctionAddress, "InPeriod");
		SetPeriod_InPeriod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPeriod_FunctionAddress, "InPeriod", Classes.FFloatProperty);
		SetPeriod_IsValid = SetPeriod_FunctionAddress != IntPtr.Zero && SetPeriod_InPeriod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CircularThrobber:SetPeriod", SetPeriod_IsValid);
		SetNumberOfPieces_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNumberOfPieces");
		SetNumberOfPieces_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumberOfPieces_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumberOfPieces_InNumberOfPieces_PropertyAddress, SetNumberOfPieces_FunctionAddress, "InNumberOfPieces");
		SetNumberOfPieces_InNumberOfPieces_Offset = NativeReflectionCached.GetPropertyOffset(SetNumberOfPieces_FunctionAddress, "InNumberOfPieces");
		SetNumberOfPieces_InNumberOfPieces_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumberOfPieces_FunctionAddress, "InNumberOfPieces", Classes.FIntProperty);
		SetNumberOfPieces_IsValid = SetNumberOfPieces_FunctionAddress != IntPtr.Zero && SetNumberOfPieces_InNumberOfPieces_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.CircularThrobber:SetNumberOfPieces", SetNumberOfPieces_IsValid);
	}
}
