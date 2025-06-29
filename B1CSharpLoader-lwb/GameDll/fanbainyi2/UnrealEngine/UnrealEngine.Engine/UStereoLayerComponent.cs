using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.StereoLayerComponent", "Engine", UnrealModuleType.Engine)]
public class UStereoLayerComponent : USceneComponent
{
	private static bool LiveTexture_IsValid;

	private static FFieldAddress LiveTexture_PropertyAddress;

	private static int LiveTexture_Offset;

	private static bool SupportsDepth_IsValid;

	private static FFieldAddress SupportsDepth_PropertyAddress;

	private static int SupportsDepth_Offset;

	private static bool NoAlphaChannel_IsValid;

	private static FFieldAddress NoAlphaChannel_PropertyAddress;

	private static int NoAlphaChannel_Offset;

	private static bool Texture_IsValid;

	private static int Texture_Offset;

	private static bool LeftTexture_IsValid;

	private static int LeftTexture_Offset;

	private static bool QuadPreserveTextureRatio_IsValid;

	private static FFieldAddress QuadPreserveTextureRatio_PropertyAddress;

	private static int QuadPreserveTextureRatio_Offset;

	private static bool QuadSize_IsValid;

	private static int QuadSize_Offset;

	private static bool UVRect_IsValid;

	private static int UVRect_Offset;

	private static bool StereoLayerType_IsValid;

	private static FFieldAddress StereoLayerType_PropertyAddress;

	private static int StereoLayerType_Offset;

	private static bool Shape_IsValid;

	private static int Shape_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool SetUVRect_IsValid;

	private static IntPtr SetUVRect_FunctionAddress;

	private static int SetUVRect_ParamsSize;

	private static bool SetUVRect_InUVRect_IsValid;

	private static FFieldAddress SetUVRect_InUVRect_PropertyAddress;

	private static int SetUVRect_InUVRect_Offset;

	private static bool SetTexture_IsValid;

	private static IntPtr SetTexture_FunctionAddress;

	private static int SetTexture_ParamsSize;

	private static bool SetTexture_InTexture_IsValid;

	private static FFieldAddress SetTexture_InTexture_PropertyAddress;

	private static int SetTexture_InTexture_Offset;

	private static bool SetQuadSize_IsValid;

	private static IntPtr SetQuadSize_FunctionAddress;

	private static int SetQuadSize_ParamsSize;

	private static bool SetQuadSize_InQuadSize_IsValid;

	private static FFieldAddress SetQuadSize_InQuadSize_PropertyAddress;

	private static int SetQuadSize_InQuadSize_Offset;

	private static bool SetPriority_IsValid;

	private static IntPtr SetPriority_FunctionAddress;

	private static int SetPriority_ParamsSize;

	private static bool SetPriority_InPriority_IsValid;

	private static FFieldAddress SetPriority_InPriority_PropertyAddress;

	private static int SetPriority_InPriority_Offset;

	private static bool SetLeftTexture_IsValid;

	private static IntPtr SetLeftTexture_FunctionAddress;

	private static int SetLeftTexture_ParamsSize;

	private static bool SetLeftTexture_InTexture_IsValid;

	private static FFieldAddress SetLeftTexture_InTexture_PropertyAddress;

	private static int SetLeftTexture_InTexture_Offset;

	private static bool MarkTextureForUpdate_IsValid;

	private static IntPtr MarkTextureForUpdate_FunctionAddress;

	private static int MarkTextureForUpdate_ParamsSize;

	private static bool GetUVRect_IsValid;

	private static IntPtr GetUVRect_FunctionAddress;

	private static int GetUVRect_ParamsSize;

	private static bool GetUVRect_ReturnValue_IsValid;

	private static FFieldAddress GetUVRect_ReturnValue_PropertyAddress;

	private static int GetUVRect_ReturnValue_Offset;

	private static bool GetTexture_IsValid;

	private static IntPtr GetTexture_FunctionAddress;

	private static int GetTexture_ParamsSize;

	private static bool GetTexture_ReturnValue_IsValid;

	private static FFieldAddress GetTexture_ReturnValue_PropertyAddress;

	private static int GetTexture_ReturnValue_Offset;

	private static bool GetQuadSize_IsValid;

	private static IntPtr GetQuadSize_FunctionAddress;

	private static int GetQuadSize_ParamsSize;

	private static bool GetQuadSize_ReturnValue_IsValid;

	private static FFieldAddress GetQuadSize_ReturnValue_PropertyAddress;

	private static int GetQuadSize_ReturnValue_Offset;

	private static bool GetPriority_IsValid;

	private static IntPtr GetPriority_FunctionAddress;

	private static int GetPriority_ParamsSize;

	private static bool GetPriority_ReturnValue_IsValid;

	private static FFieldAddress GetPriority_ReturnValue_PropertyAddress;

	private static int GetPriority_ReturnValue_Offset;

	private static bool GetLeftTexture_IsValid;

	private static IntPtr GetLeftTexture_FunctionAddress;

	private static int GetLeftTexture_ParamsSize;

	private static bool GetLeftTexture_ReturnValue_IsValid;

	private static FFieldAddress GetLeftTexture_ReturnValue_PropertyAddress;

	private static int GetLeftTexture_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:bLiveTexture")]
	public bool LiveTexture
	{
		get
		{
			CheckDestroyed();
			if (!LiveTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:bLiveTexture");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, LiveTexture_Offset), 0, LiveTexture_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!LiveTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:bLiveTexture");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, LiveTexture_Offset), 0, LiveTexture_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:bSupportsDepth")]
	public bool SupportsDepth
	{
		get
		{
			CheckDestroyed();
			if (!SupportsDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:bSupportsDepth");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SupportsDepth_Offset), 0, SupportsDepth_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SupportsDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:bSupportsDepth");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SupportsDepth_Offset), 0, SupportsDepth_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:bNoAlphaChannel")]
	public bool NoAlphaChannel
	{
		get
		{
			CheckDestroyed();
			if (!NoAlphaChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:bNoAlphaChannel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NoAlphaChannel_Offset), 0, NoAlphaChannel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NoAlphaChannel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:bNoAlphaChannel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NoAlphaChannel_Offset), 0, NoAlphaChannel_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:Texture")]
	protected UTexture Texture
	{
		get
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:Texture");
				return null;
			}
			return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(base.Address, Texture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Texture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:Texture");
			}
			else
			{
				UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(base.Address, Texture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861510165uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:LeftTexture")]
	protected UTexture LeftTexture
	{
		get
		{
			CheckDestroyed();
			if (!LeftTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:LeftTexture");
				return null;
			}
			return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(base.Address, LeftTexture_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftTexture_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:LeftTexture");
			}
			else
			{
				UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(base.Address, LeftTexture_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:bQuadPreserveTextureRatio")]
	public bool QuadPreserveTextureRatio
	{
		get
		{
			CheckDestroyed();
			if (!QuadPreserveTextureRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:bQuadPreserveTextureRatio");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, QuadPreserveTextureRatio_Offset), 0, QuadPreserveTextureRatio_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!QuadPreserveTextureRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:bQuadPreserveTextureRatio");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, QuadPreserveTextureRatio_Offset), 0, QuadPreserveTextureRatio_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:QuadSize")]
	protected FVector2D QuadSize
	{
		get
		{
			CheckDestroyed();
			if (!QuadSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:QuadSize");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, QuadSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QuadSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:QuadSize");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, QuadSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)9016065140982301uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:UVRect")]
	protected FBox2D UVRect
	{
		get
		{
			CheckDestroyed();
			if (!UVRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:UVRect");
				return default(FBox2D);
			}
			return BlittableTypeMarshaler<FBox2D>.FromNative(IntPtr.Add(base.Address, UVRect_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UVRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:UVRect");
			}
			else
			{
				BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(base.Address, UVRect_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:StereoLayerType")]
	protected EStereoLayerType StereoLayerType
	{
		get
		{
			CheckDestroyed();
			if (!StereoLayerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:StereoLayerType");
				return EStereoLayerType.SLT_WorldLocked;
			}
			return EnumMarshaler<EStereoLayerType>.FromNative(IntPtr.Add(base.Address, StereoLayerType_Offset), 0, StereoLayerType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StereoLayerType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:StereoLayerType");
			}
			else
			{
				EnumMarshaler<EStereoLayerType>.ToNative(IntPtr.Add(base.Address, StereoLayerType_Offset), 0, StereoLayerType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12956714849010205uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:Shape")]
	protected UStereoLayerShape Shape
	{
		get
		{
			CheckDestroyed();
			if (!Shape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:Shape");
				return null;
			}
			return UObjectMarshaler<UStereoLayerShape>.FromNative(IntPtr.Add(base.Address, Shape_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Shape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:Shape");
			}
			else
			{
				UObjectMarshaler<UStereoLayerShape>.ToNative(IntPtr.Add(base.Address, Shape_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667549uL)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:Priority")]
	protected int Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:Priority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.StereoLayerComponent:Priority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:SetUVRect")]
	public unsafe void SetUVRect(FBox2D InUVRect)
	{
		CheckDestroyed();
		if (!SetUVRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:SetUVRect");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUVRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUVRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FBox2D>.ToNative(IntPtr.Add(intPtr, SetUVRect_InUVRect_Offset), 0, SetUVRect_InUVRect_PropertyAddress.Address, InUVRect);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUVRect_FunctionAddress, intPtr, SetUVRect_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:SetTexture")]
	public unsafe void SetTexture(UTexture InTexture)
	{
		CheckDestroyed();
		if (!SetTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:SetTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetTexture_InTexture_Offset), 0, SetTexture_InTexture_PropertyAddress.Address, InTexture);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTexture_FunctionAddress, intPtr, SetTexture_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:SetQuadSize")]
	public unsafe void SetQuadSize(FVector2D InQuadSize)
	{
		CheckDestroyed();
		if (!SetQuadSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:SetQuadSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetQuadSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetQuadSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetQuadSize_InQuadSize_Offset), 0, SetQuadSize_InQuadSize_PropertyAddress.Address, InQuadSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetQuadSize_FunctionAddress, intPtr, SetQuadSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:SetPriority")]
	public unsafe void SetPriority(int InPriority)
	{
		CheckDestroyed();
		if (!SetPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:SetPriority");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPriority_InPriority_Offset), 0, SetPriority_InPriority_PropertyAddress.Address, InPriority);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPriority_FunctionAddress, intPtr, SetPriority_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:SetLeftTexture")]
	public unsafe void SetLeftTexture(UTexture InTexture)
	{
		CheckDestroyed();
		if (!SetLeftTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:SetLeftTexture");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLeftTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLeftTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTexture>.ToNative(IntPtr.Add(intPtr, SetLeftTexture_InTexture_Offset), 0, SetLeftTexture_InTexture_PropertyAddress.Address, InTexture);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLeftTexture_FunctionAddress, intPtr, SetLeftTexture_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:MarkTextureForUpdate")]
	public unsafe void MarkTextureForUpdate()
	{
		CheckDestroyed();
		if (!MarkTextureForUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:MarkTextureForUpdate");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkTextureForUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkTextureForUpdate_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: MarkTextureForUpdate_FunctionAddress, argsSize: MarkTextureForUpdate_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:GetUVRect")]
	public unsafe FBox2D GetUVRect()
	{
		CheckDestroyed();
		if (!GetUVRect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:GetUVRect");
			return default(FBox2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUVRect_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUVRect_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUVRect_FunctionAddress, intPtr, GetUVRect_ParamsSize);
		return BlittableTypeMarshaler<FBox2D>.FromNative(IntPtr.Add(intPtr, GetUVRect_ReturnValue_Offset), 0, GetUVRect_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:GetTexture")]
	public unsafe UTexture GetTexture()
	{
		CheckDestroyed();
		if (!GetTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:GetTexture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTexture_FunctionAddress, intPtr, GetTexture_ParamsSize);
		return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(intPtr, GetTexture_ReturnValue_Offset), 0, GetTexture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:GetQuadSize")]
	public unsafe FVector2D GetQuadSize()
	{
		CheckDestroyed();
		if (!GetQuadSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:GetQuadSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetQuadSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetQuadSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetQuadSize_FunctionAddress, intPtr, GetQuadSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetQuadSize_ReturnValue_Offset), 0, GetQuadSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:GetPriority")]
	public unsafe int GetPriority()
	{
		CheckDestroyed();
		if (!GetPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:GetPriority");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPriority_FunctionAddress, intPtr, GetPriority_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPriority_ReturnValue_Offset), 0, GetPriority_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.StereoLayerComponent:GetLeftTexture")]
	public unsafe UTexture GetLeftTexture()
	{
		CheckDestroyed();
		if (!GetLeftTexture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.StereoLayerComponent:GetLeftTexture");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLeftTexture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLeftTexture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLeftTexture_FunctionAddress, intPtr, GetLeftTexture_ParamsSize);
		return UObjectMarshaler<UTexture>.FromNative(IntPtr.Add(intPtr, GetLeftTexture_ReturnValue_Offset), 0, GetLeftTexture_ReturnValue_PropertyAddress.Address);
	}

	static UStereoLayerComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStereoLayerComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStereoLayerComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.StereoLayerComponent");
		NativeReflectionCached.GetPropertyRef(ref LiveTexture_PropertyAddress, intPtr, "bLiveTexture");
		LiveTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bLiveTexture");
		LiveTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bLiveTexture", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SupportsDepth_PropertyAddress, intPtr, "bSupportsDepth");
		SupportsDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSupportsDepth");
		SupportsDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSupportsDepth", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NoAlphaChannel_PropertyAddress, intPtr, "bNoAlphaChannel");
		NoAlphaChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNoAlphaChannel");
		NoAlphaChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNoAlphaChannel", Classes.FBoolProperty);
		Texture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Texture");
		Texture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Texture", Classes.FObjectProperty);
		LeftTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftTexture");
		LeftTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref QuadPreserveTextureRatio_PropertyAddress, intPtr, "bQuadPreserveTextureRatio");
		QuadPreserveTextureRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bQuadPreserveTextureRatio");
		QuadPreserveTextureRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bQuadPreserveTextureRatio", Classes.FBoolProperty);
		QuadSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "QuadSize");
		QuadSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "QuadSize", Classes.FStructProperty);
		UVRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UVRect");
		UVRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UVRect", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StereoLayerType_PropertyAddress, intPtr, "StereoLayerType");
		StereoLayerType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StereoLayerType");
		StereoLayerType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StereoLayerType", Classes.FByteProperty);
		Shape_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Shape");
		Shape_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Shape", Classes.FObjectProperty);
		Priority_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		SetUVRect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUVRect");
		SetUVRect_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUVRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUVRect_InUVRect_PropertyAddress, SetUVRect_FunctionAddress, "InUVRect");
		SetUVRect_InUVRect_Offset = NativeReflectionCached.GetPropertyOffset(SetUVRect_FunctionAddress, "InUVRect");
		SetUVRect_InUVRect_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUVRect_FunctionAddress, "InUVRect", Classes.FStructProperty);
		SetUVRect_IsValid = SetUVRect_FunctionAddress != IntPtr.Zero && SetUVRect_InUVRect_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:SetUVRect", SetUVRect_IsValid);
		SetTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTexture");
		SetTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTexture_InTexture_PropertyAddress, SetTexture_FunctionAddress, "InTexture");
		SetTexture_InTexture_Offset = NativeReflectionCached.GetPropertyOffset(SetTexture_FunctionAddress, "InTexture");
		SetTexture_InTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTexture_FunctionAddress, "InTexture", Classes.FObjectProperty);
		SetTexture_IsValid = SetTexture_FunctionAddress != IntPtr.Zero && SetTexture_InTexture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:SetTexture", SetTexture_IsValid);
		SetQuadSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetQuadSize");
		SetQuadSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetQuadSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetQuadSize_InQuadSize_PropertyAddress, SetQuadSize_FunctionAddress, "InQuadSize");
		SetQuadSize_InQuadSize_Offset = NativeReflectionCached.GetPropertyOffset(SetQuadSize_FunctionAddress, "InQuadSize");
		SetQuadSize_InQuadSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetQuadSize_FunctionAddress, "InQuadSize", Classes.FStructProperty);
		SetQuadSize_IsValid = SetQuadSize_FunctionAddress != IntPtr.Zero && SetQuadSize_InQuadSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:SetQuadSize", SetQuadSize_IsValid);
		SetPriority_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPriority");
		SetPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPriority_InPriority_PropertyAddress, SetPriority_FunctionAddress, "InPriority");
		SetPriority_InPriority_Offset = NativeReflectionCached.GetPropertyOffset(SetPriority_FunctionAddress, "InPriority");
		SetPriority_InPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPriority_FunctionAddress, "InPriority", Classes.FIntProperty);
		SetPriority_IsValid = SetPriority_FunctionAddress != IntPtr.Zero && SetPriority_InPriority_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:SetPriority", SetPriority_IsValid);
		SetLeftTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLeftTexture");
		SetLeftTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLeftTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLeftTexture_InTexture_PropertyAddress, SetLeftTexture_FunctionAddress, "InTexture");
		SetLeftTexture_InTexture_Offset = NativeReflectionCached.GetPropertyOffset(SetLeftTexture_FunctionAddress, "InTexture");
		SetLeftTexture_InTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLeftTexture_FunctionAddress, "InTexture", Classes.FObjectProperty);
		SetLeftTexture_IsValid = SetLeftTexture_FunctionAddress != IntPtr.Zero && SetLeftTexture_InTexture_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:SetLeftTexture", SetLeftTexture_IsValid);
		MarkTextureForUpdate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MarkTextureForUpdate");
		MarkTextureForUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkTextureForUpdate_FunctionAddress);
		MarkTextureForUpdate_IsValid = MarkTextureForUpdate_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:MarkTextureForUpdate", MarkTextureForUpdate_IsValid);
		GetUVRect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUVRect");
		GetUVRect_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUVRect_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUVRect_ReturnValue_PropertyAddress, GetUVRect_FunctionAddress, "ReturnValue");
		GetUVRect_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUVRect_FunctionAddress, "ReturnValue");
		GetUVRect_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUVRect_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetUVRect_IsValid = GetUVRect_FunctionAddress != IntPtr.Zero && GetUVRect_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:GetUVRect", GetUVRect_IsValid);
		GetTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTexture");
		GetTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTexture_ReturnValue_PropertyAddress, GetTexture_FunctionAddress, "ReturnValue");
		GetTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTexture_FunctionAddress, "ReturnValue");
		GetTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTexture_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetTexture_IsValid = GetTexture_FunctionAddress != IntPtr.Zero && GetTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:GetTexture", GetTexture_IsValid);
		GetQuadSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetQuadSize");
		GetQuadSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetQuadSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetQuadSize_ReturnValue_PropertyAddress, GetQuadSize_FunctionAddress, "ReturnValue");
		GetQuadSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetQuadSize_FunctionAddress, "ReturnValue");
		GetQuadSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetQuadSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetQuadSize_IsValid = GetQuadSize_FunctionAddress != IntPtr.Zero && GetQuadSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:GetQuadSize", GetQuadSize_IsValid);
		GetPriority_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPriority");
		GetPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPriority_ReturnValue_PropertyAddress, GetPriority_FunctionAddress, "ReturnValue");
		GetPriority_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPriority_FunctionAddress, "ReturnValue");
		GetPriority_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPriority_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPriority_IsValid = GetPriority_FunctionAddress != IntPtr.Zero && GetPriority_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:GetPriority", GetPriority_IsValid);
		GetLeftTexture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetLeftTexture");
		GetLeftTexture_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLeftTexture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLeftTexture_ReturnValue_PropertyAddress, GetLeftTexture_FunctionAddress, "ReturnValue");
		GetLeftTexture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLeftTexture_FunctionAddress, "ReturnValue");
		GetLeftTexture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLeftTexture_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetLeftTexture_IsValid = GetLeftTexture_FunctionAddress != IntPtr.Zero && GetLeftTexture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.StereoLayerComponent:GetLeftTexture", GetLeftTexture_IsValid);
	}
}
