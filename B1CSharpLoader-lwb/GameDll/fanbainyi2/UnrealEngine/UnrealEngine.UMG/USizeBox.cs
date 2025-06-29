using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.SizeBox", "UMG", UnrealModuleType.Engine)]
public class USizeBox : UContentWidget
{
	private static bool WidthOverride_IsValid;

	private static int WidthOverride_Offset;

	private static bool HeightOverride_IsValid;

	private static int HeightOverride_Offset;

	private static bool MinDesiredWidth_IsValid;

	private static int MinDesiredWidth_Offset;

	private static bool MinDesiredHeight_IsValid;

	private static int MinDesiredHeight_Offset;

	private static bool MaxDesiredWidth_IsValid;

	private static int MaxDesiredWidth_Offset;

	private static bool MaxDesiredHeight_IsValid;

	private static int MaxDesiredHeight_Offset;

	private static bool MinAspectRatio_IsValid;

	private static int MinAspectRatio_Offset;

	private static bool MaxAspectRatio_IsValid;

	private static int MaxAspectRatio_Offset;

	private static bool SetWidthOverride_IsValid;

	private static IntPtr SetWidthOverride_FunctionAddress;

	private static int SetWidthOverride_ParamsSize;

	private static bool SetWidthOverride_InWidthOverride_IsValid;

	private static FFieldAddress SetWidthOverride_InWidthOverride_PropertyAddress;

	private static int SetWidthOverride_InWidthOverride_Offset;

	private static bool SetMinDesiredWidth_IsValid;

	private static IntPtr SetMinDesiredWidth_FunctionAddress;

	private static int SetMinDesiredWidth_ParamsSize;

	private static bool SetMinDesiredWidth_InMinDesiredWidth_IsValid;

	private static FFieldAddress SetMinDesiredWidth_InMinDesiredWidth_PropertyAddress;

	private static int SetMinDesiredWidth_InMinDesiredWidth_Offset;

	private static bool SetMinDesiredHeight_IsValid;

	private static IntPtr SetMinDesiredHeight_FunctionAddress;

	private static int SetMinDesiredHeight_ParamsSize;

	private static bool SetMinDesiredHeight_InMinDesiredHeight_IsValid;

	private static FFieldAddress SetMinDesiredHeight_InMinDesiredHeight_PropertyAddress;

	private static int SetMinDesiredHeight_InMinDesiredHeight_Offset;

	private static bool SetMinAspectRatio_IsValid;

	private static IntPtr SetMinAspectRatio_FunctionAddress;

	private static int SetMinAspectRatio_ParamsSize;

	private static bool SetMinAspectRatio_InMinAspectRatio_IsValid;

	private static FFieldAddress SetMinAspectRatio_InMinAspectRatio_PropertyAddress;

	private static int SetMinAspectRatio_InMinAspectRatio_Offset;

	private static bool SetMaxDesiredWidth_IsValid;

	private static IntPtr SetMaxDesiredWidth_FunctionAddress;

	private static int SetMaxDesiredWidth_ParamsSize;

	private static bool SetMaxDesiredWidth_InMaxDesiredWidth_IsValid;

	private static FFieldAddress SetMaxDesiredWidth_InMaxDesiredWidth_PropertyAddress;

	private static int SetMaxDesiredWidth_InMaxDesiredWidth_Offset;

	private static bool SetMaxDesiredHeight_IsValid;

	private static IntPtr SetMaxDesiredHeight_FunctionAddress;

	private static int SetMaxDesiredHeight_ParamsSize;

	private static bool SetMaxDesiredHeight_InMaxDesiredHeight_IsValid;

	private static FFieldAddress SetMaxDesiredHeight_InMaxDesiredHeight_PropertyAddress;

	private static int SetMaxDesiredHeight_InMaxDesiredHeight_Offset;

	private static bool SetMaxAspectRatio_IsValid;

	private static IntPtr SetMaxAspectRatio_FunctionAddress;

	private static int SetMaxAspectRatio_ParamsSize;

	private static bool SetMaxAspectRatio_InMaxAspectRatio_IsValid;

	private static FFieldAddress SetMaxAspectRatio_InMaxAspectRatio_PropertyAddress;

	private static int SetMaxAspectRatio_InMaxAspectRatio_Offset;

	private static bool SetHeightOverride_IsValid;

	private static IntPtr SetHeightOverride_FunctionAddress;

	private static int SetHeightOverride_ParamsSize;

	private static bool SetHeightOverride_InHeightOverride_IsValid;

	private static FFieldAddress SetHeightOverride_InHeightOverride_PropertyAddress;

	private static int SetHeightOverride_InHeightOverride_Offset;

	private static bool ClearWidthOverride_IsValid;

	private static IntPtr ClearWidthOverride_FunctionAddress;

	private static int ClearWidthOverride_ParamsSize;

	private static bool ClearMinDesiredWidth_IsValid;

	private static IntPtr ClearMinDesiredWidth_FunctionAddress;

	private static int ClearMinDesiredWidth_ParamsSize;

	private static bool ClearMinDesiredHeight_IsValid;

	private static IntPtr ClearMinDesiredHeight_FunctionAddress;

	private static int ClearMinDesiredHeight_ParamsSize;

	private static bool ClearMinAspectRatio_IsValid;

	private static IntPtr ClearMinAspectRatio_FunctionAddress;

	private static int ClearMinAspectRatio_ParamsSize;

	private static bool ClearMaxDesiredWidth_IsValid;

	private static IntPtr ClearMaxDesiredWidth_FunctionAddress;

	private static int ClearMaxDesiredWidth_ParamsSize;

	private static bool ClearMaxDesiredHeight_IsValid;

	private static IntPtr ClearMaxDesiredHeight_FunctionAddress;

	private static int ClearMaxDesiredHeight_ParamsSize;

	private static bool ClearMaxAspectRatio_IsValid;

	private static IntPtr ClearMaxAspectRatio_FunctionAddress;

	private static int ClearMaxAspectRatio_ParamsSize;

	private static bool ClearHeightOverride_IsValid;

	private static IntPtr ClearHeightOverride_FunctionAddress;

	private static int ClearHeightOverride_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SizeBox:WidthOverride")]
	public float WidthOverride
	{
		get
		{
			CheckDestroyed();
			if (!WidthOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:WidthOverride");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WidthOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WidthOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:WidthOverride");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WidthOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SizeBox:HeightOverride")]
	public float HeightOverride
	{
		get
		{
			CheckDestroyed();
			if (!HeightOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:HeightOverride");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeightOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:HeightOverride");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeightOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SizeBox:MinDesiredWidth")]
	public float MinDesiredWidth
	{
		get
		{
			CheckDestroyed();
			if (!MinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MinDesiredWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDesiredWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MinDesiredWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDesiredWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SizeBox:MinDesiredHeight")]
	public float MinDesiredHeight
	{
		get
		{
			CheckDestroyed();
			if (!MinDesiredHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MinDesiredHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDesiredHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDesiredHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MinDesiredHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDesiredHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SizeBox:MaxDesiredWidth")]
	public float MaxDesiredWidth
	{
		get
		{
			CheckDestroyed();
			if (!MaxDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MaxDesiredWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDesiredWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MaxDesiredWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDesiredWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SizeBox:MaxDesiredHeight")]
	public float MaxDesiredHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxDesiredHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MaxDesiredHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDesiredHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDesiredHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MaxDesiredHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDesiredHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SizeBox:MinAspectRatio")]
	public float MinAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!MinAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MinAspectRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAspectRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MinAspectRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAspectRatio_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.SizeBox:MaxAspectRatio")]
	public float MaxAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!MaxAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MaxAspectRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAspectRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.SizeBox:MaxAspectRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAspectRatio_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:SetWidthOverride")]
	public unsafe void SetWidthOverride(float InWidthOverride)
	{
		CheckDestroyed();
		if (!SetWidthOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:SetWidthOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWidthOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWidthOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWidthOverride_InWidthOverride_Offset), 0, SetWidthOverride_InWidthOverride_PropertyAddress.Address, InWidthOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWidthOverride_FunctionAddress, intPtr, SetWidthOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:SetMinDesiredWidth")]
	public unsafe void SetMinDesiredWidth(float InMinDesiredWidth)
	{
		CheckDestroyed();
		if (!SetMinDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:SetMinDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinDesiredWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinDesiredWidth_InMinDesiredWidth_Offset), 0, SetMinDesiredWidth_InMinDesiredWidth_PropertyAddress.Address, InMinDesiredWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinDesiredWidth_FunctionAddress, intPtr, SetMinDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:SetMinDesiredHeight")]
	public unsafe void SetMinDesiredHeight(float InMinDesiredHeight)
	{
		CheckDestroyed();
		if (!SetMinDesiredHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:SetMinDesiredHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinDesiredHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinDesiredHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinDesiredHeight_InMinDesiredHeight_Offset), 0, SetMinDesiredHeight_InMinDesiredHeight_PropertyAddress.Address, InMinDesiredHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinDesiredHeight_FunctionAddress, intPtr, SetMinDesiredHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:SetMinAspectRatio")]
	public unsafe void SetMinAspectRatio(float InMinAspectRatio)
	{
		CheckDestroyed();
		if (!SetMinAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:SetMinAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMinAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMinAspectRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMinAspectRatio_InMinAspectRatio_Offset), 0, SetMinAspectRatio_InMinAspectRatio_PropertyAddress.Address, InMinAspectRatio);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMinAspectRatio_FunctionAddress, intPtr, SetMinAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:SetMaxDesiredWidth")]
	public unsafe void SetMaxDesiredWidth(float InMaxDesiredWidth)
	{
		CheckDestroyed();
		if (!SetMaxDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:SetMaxDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxDesiredWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaxDesiredWidth_InMaxDesiredWidth_Offset), 0, SetMaxDesiredWidth_InMaxDesiredWidth_PropertyAddress.Address, InMaxDesiredWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxDesiredWidth_FunctionAddress, intPtr, SetMaxDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:SetMaxDesiredHeight")]
	public unsafe void SetMaxDesiredHeight(float InMaxDesiredHeight)
	{
		CheckDestroyed();
		if (!SetMaxDesiredHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:SetMaxDesiredHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxDesiredHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxDesiredHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaxDesiredHeight_InMaxDesiredHeight_Offset), 0, SetMaxDesiredHeight_InMaxDesiredHeight_PropertyAddress.Address, InMaxDesiredHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxDesiredHeight_FunctionAddress, intPtr, SetMaxDesiredHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:SetMaxAspectRatio")]
	public unsafe void SetMaxAspectRatio(float InMaxAspectRatio)
	{
		CheckDestroyed();
		if (!SetMaxAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:SetMaxAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMaxAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMaxAspectRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetMaxAspectRatio_InMaxAspectRatio_Offset), 0, SetMaxAspectRatio_InMaxAspectRatio_PropertyAddress.Address, InMaxAspectRatio);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetMaxAspectRatio_FunctionAddress, intPtr, SetMaxAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:SetHeightOverride")]
	public unsafe void SetHeightOverride(float InHeightOverride)
	{
		CheckDestroyed();
		if (!SetHeightOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:SetHeightOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHeightOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHeightOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetHeightOverride_InHeightOverride_Offset), 0, SetHeightOverride_InHeightOverride_PropertyAddress.Address, InHeightOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHeightOverride_FunctionAddress, intPtr, SetHeightOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:ClearWidthOverride")]
	public unsafe void ClearWidthOverride()
	{
		CheckDestroyed();
		if (!ClearWidthOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:ClearWidthOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearWidthOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearWidthOverride_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearWidthOverride_FunctionAddress, argsSize: ClearWidthOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:ClearMinDesiredWidth")]
	public unsafe void ClearMinDesiredWidth()
	{
		CheckDestroyed();
		if (!ClearMinDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:ClearMinDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMinDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMinDesiredWidth_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMinDesiredWidth_FunctionAddress, argsSize: ClearMinDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:ClearMinDesiredHeight")]
	public unsafe void ClearMinDesiredHeight()
	{
		CheckDestroyed();
		if (!ClearMinDesiredHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:ClearMinDesiredHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMinDesiredHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMinDesiredHeight_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMinDesiredHeight_FunctionAddress, argsSize: ClearMinDesiredHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:ClearMinAspectRatio")]
	public unsafe void ClearMinAspectRatio()
	{
		CheckDestroyed();
		if (!ClearMinAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:ClearMinAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMinAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMinAspectRatio_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMinAspectRatio_FunctionAddress, argsSize: ClearMinAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:ClearMaxDesiredWidth")]
	public unsafe void ClearMaxDesiredWidth()
	{
		CheckDestroyed();
		if (!ClearMaxDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:ClearMaxDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMaxDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMaxDesiredWidth_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMaxDesiredWidth_FunctionAddress, argsSize: ClearMaxDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:ClearMaxDesiredHeight")]
	public unsafe void ClearMaxDesiredHeight()
	{
		CheckDestroyed();
		if (!ClearMaxDesiredHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:ClearMaxDesiredHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMaxDesiredHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMaxDesiredHeight_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMaxDesiredHeight_FunctionAddress, argsSize: ClearMaxDesiredHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:ClearMaxAspectRatio")]
	public unsafe void ClearMaxAspectRatio()
	{
		CheckDestroyed();
		if (!ClearMaxAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:ClearMaxAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMaxAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMaxAspectRatio_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearMaxAspectRatio_FunctionAddress, argsSize: ClearMaxAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.SizeBox:ClearHeightOverride")]
	public unsafe void ClearHeightOverride()
	{
		CheckDestroyed();
		if (!ClearHeightOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.SizeBox:ClearHeightOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearHeightOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearHeightOverride_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearHeightOverride_FunctionAddress, argsSize: ClearHeightOverride_ParamsSize);
	}

	static USizeBox()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USizeBox)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USizeBox));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.SizeBox");
		WidthOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WidthOverride");
		WidthOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WidthOverride", Classes.FFloatProperty);
		HeightOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeightOverride");
		HeightOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeightOverride", Classes.FFloatProperty);
		MinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinDesiredWidth");
		MinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinDesiredWidth", Classes.FFloatProperty);
		MinDesiredHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinDesiredHeight");
		MinDesiredHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinDesiredHeight", Classes.FFloatProperty);
		MaxDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDesiredWidth");
		MaxDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDesiredWidth", Classes.FFloatProperty);
		MaxDesiredHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxDesiredHeight");
		MaxDesiredHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxDesiredHeight", Classes.FFloatProperty);
		MinAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinAspectRatio");
		MinAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinAspectRatio", Classes.FFloatProperty);
		MaxAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxAspectRatio");
		MaxAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxAspectRatio", Classes.FFloatProperty);
		SetWidthOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWidthOverride");
		SetWidthOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWidthOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWidthOverride_InWidthOverride_PropertyAddress, SetWidthOverride_FunctionAddress, "InWidthOverride");
		SetWidthOverride_InWidthOverride_Offset = NativeReflectionCached.GetPropertyOffset(SetWidthOverride_FunctionAddress, "InWidthOverride");
		SetWidthOverride_InWidthOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWidthOverride_FunctionAddress, "InWidthOverride", Classes.FFloatProperty);
		SetWidthOverride_IsValid = SetWidthOverride_FunctionAddress != IntPtr.Zero && SetWidthOverride_InWidthOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:SetWidthOverride", SetWidthOverride_IsValid);
		SetMinDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinDesiredWidth");
		SetMinDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinDesiredWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinDesiredWidth_InMinDesiredWidth_PropertyAddress, SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth");
		SetMinDesiredWidth_InMinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth");
		SetMinDesiredWidth_InMinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinDesiredWidth_FunctionAddress, "InMinDesiredWidth", Classes.FFloatProperty);
		SetMinDesiredWidth_IsValid = SetMinDesiredWidth_FunctionAddress != IntPtr.Zero && SetMinDesiredWidth_InMinDesiredWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:SetMinDesiredWidth", SetMinDesiredWidth_IsValid);
		SetMinDesiredHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinDesiredHeight");
		SetMinDesiredHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinDesiredHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinDesiredHeight_InMinDesiredHeight_PropertyAddress, SetMinDesiredHeight_FunctionAddress, "InMinDesiredHeight");
		SetMinDesiredHeight_InMinDesiredHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetMinDesiredHeight_FunctionAddress, "InMinDesiredHeight");
		SetMinDesiredHeight_InMinDesiredHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinDesiredHeight_FunctionAddress, "InMinDesiredHeight", Classes.FFloatProperty);
		SetMinDesiredHeight_IsValid = SetMinDesiredHeight_FunctionAddress != IntPtr.Zero && SetMinDesiredHeight_InMinDesiredHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:SetMinDesiredHeight", SetMinDesiredHeight_IsValid);
		SetMinAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMinAspectRatio");
		SetMinAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMinAspectRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMinAspectRatio_InMinAspectRatio_PropertyAddress, SetMinAspectRatio_FunctionAddress, "InMinAspectRatio");
		SetMinAspectRatio_InMinAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(SetMinAspectRatio_FunctionAddress, "InMinAspectRatio");
		SetMinAspectRatio_InMinAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMinAspectRatio_FunctionAddress, "InMinAspectRatio", Classes.FFloatProperty);
		SetMinAspectRatio_IsValid = SetMinAspectRatio_FunctionAddress != IntPtr.Zero && SetMinAspectRatio_InMinAspectRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:SetMinAspectRatio", SetMinAspectRatio_IsValid);
		SetMaxDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaxDesiredWidth");
		SetMaxDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxDesiredWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxDesiredWidth_InMaxDesiredWidth_PropertyAddress, SetMaxDesiredWidth_FunctionAddress, "InMaxDesiredWidth");
		SetMaxDesiredWidth_InMaxDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxDesiredWidth_FunctionAddress, "InMaxDesiredWidth");
		SetMaxDesiredWidth_InMaxDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxDesiredWidth_FunctionAddress, "InMaxDesiredWidth", Classes.FFloatProperty);
		SetMaxDesiredWidth_IsValid = SetMaxDesiredWidth_FunctionAddress != IntPtr.Zero && SetMaxDesiredWidth_InMaxDesiredWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:SetMaxDesiredWidth", SetMaxDesiredWidth_IsValid);
		SetMaxDesiredHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaxDesiredHeight");
		SetMaxDesiredHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxDesiredHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxDesiredHeight_InMaxDesiredHeight_PropertyAddress, SetMaxDesiredHeight_FunctionAddress, "InMaxDesiredHeight");
		SetMaxDesiredHeight_InMaxDesiredHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxDesiredHeight_FunctionAddress, "InMaxDesiredHeight");
		SetMaxDesiredHeight_InMaxDesiredHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxDesiredHeight_FunctionAddress, "InMaxDesiredHeight", Classes.FFloatProperty);
		SetMaxDesiredHeight_IsValid = SetMaxDesiredHeight_FunctionAddress != IntPtr.Zero && SetMaxDesiredHeight_InMaxDesiredHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:SetMaxDesiredHeight", SetMaxDesiredHeight_IsValid);
		SetMaxAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaxAspectRatio");
		SetMaxAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxAspectRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMaxAspectRatio_InMaxAspectRatio_PropertyAddress, SetMaxAspectRatio_FunctionAddress, "InMaxAspectRatio");
		SetMaxAspectRatio_InMaxAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(SetMaxAspectRatio_FunctionAddress, "InMaxAspectRatio");
		SetMaxAspectRatio_InMaxAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMaxAspectRatio_FunctionAddress, "InMaxAspectRatio", Classes.FFloatProperty);
		SetMaxAspectRatio_IsValid = SetMaxAspectRatio_FunctionAddress != IntPtr.Zero && SetMaxAspectRatio_InMaxAspectRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:SetMaxAspectRatio", SetMaxAspectRatio_IsValid);
		SetHeightOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHeightOverride");
		SetHeightOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHeightOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHeightOverride_InHeightOverride_PropertyAddress, SetHeightOverride_FunctionAddress, "InHeightOverride");
		SetHeightOverride_InHeightOverride_Offset = NativeReflectionCached.GetPropertyOffset(SetHeightOverride_FunctionAddress, "InHeightOverride");
		SetHeightOverride_InHeightOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHeightOverride_FunctionAddress, "InHeightOverride", Classes.FFloatProperty);
		SetHeightOverride_IsValid = SetHeightOverride_FunctionAddress != IntPtr.Zero && SetHeightOverride_InHeightOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:SetHeightOverride", SetHeightOverride_IsValid);
		ClearWidthOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearWidthOverride");
		ClearWidthOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearWidthOverride_FunctionAddress);
		ClearWidthOverride_IsValid = ClearWidthOverride_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:ClearWidthOverride", ClearWidthOverride_IsValid);
		ClearMinDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMinDesiredWidth");
		ClearMinDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMinDesiredWidth_FunctionAddress);
		ClearMinDesiredWidth_IsValid = ClearMinDesiredWidth_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:ClearMinDesiredWidth", ClearMinDesiredWidth_IsValid);
		ClearMinDesiredHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMinDesiredHeight");
		ClearMinDesiredHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMinDesiredHeight_FunctionAddress);
		ClearMinDesiredHeight_IsValid = ClearMinDesiredHeight_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:ClearMinDesiredHeight", ClearMinDesiredHeight_IsValid);
		ClearMinAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMinAspectRatio");
		ClearMinAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMinAspectRatio_FunctionAddress);
		ClearMinAspectRatio_IsValid = ClearMinAspectRatio_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:ClearMinAspectRatio", ClearMinAspectRatio_IsValid);
		ClearMaxDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMaxDesiredWidth");
		ClearMaxDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMaxDesiredWidth_FunctionAddress);
		ClearMaxDesiredWidth_IsValid = ClearMaxDesiredWidth_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:ClearMaxDesiredWidth", ClearMaxDesiredWidth_IsValid);
		ClearMaxDesiredHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMaxDesiredHeight");
		ClearMaxDesiredHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMaxDesiredHeight_FunctionAddress);
		ClearMaxDesiredHeight_IsValid = ClearMaxDesiredHeight_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:ClearMaxDesiredHeight", ClearMaxDesiredHeight_IsValid);
		ClearMaxAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearMaxAspectRatio");
		ClearMaxAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMaxAspectRatio_FunctionAddress);
		ClearMaxAspectRatio_IsValid = ClearMaxAspectRatio_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:ClearMaxAspectRatio", ClearMaxAspectRatio_IsValid);
		ClearHeightOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearHeightOverride");
		ClearHeightOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearHeightOverride_FunctionAddress);
		ClearHeightOverride_IsValid = ClearHeightOverride_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.SizeBox:ClearHeightOverride", ClearHeightOverride_IsValid);
	}
}
