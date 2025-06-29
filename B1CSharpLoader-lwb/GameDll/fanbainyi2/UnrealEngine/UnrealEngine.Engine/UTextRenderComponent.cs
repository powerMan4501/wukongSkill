using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.TextRenderComponent", "Engine", UnrealModuleType.Engine)]
public class UTextRenderComponent : UPrimitiveComponent
{
	private static bool Text_IsValid;

	private static int Text_Offset;

	private FText Text_TextCached;

	private static bool TextMaterial_IsValid;

	private static int TextMaterial_Offset;

	private static bool Font_IsValid;

	private static int Font_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool VerticalAlignment_IsValid;

	private static FFieldAddress VerticalAlignment_PropertyAddress;

	private static int VerticalAlignment_Offset;

	private static bool TextRenderColor_IsValid;

	private static int TextRenderColor_Offset;

	private static bool XScale_IsValid;

	private static int XScale_Offset;

	private static bool YScale_IsValid;

	private static int YScale_Offset;

	private static bool WorldSize_IsValid;

	private static int WorldSize_Offset;

	private static bool HorizSpacingAdjust_IsValid;

	private static int HorizSpacingAdjust_Offset;

	private static bool VertSpacingAdjust_IsValid;

	private static int VertSpacingAdjust_Offset;

	private static bool AlwaysRenderAsText_IsValid;

	private static FFieldAddress AlwaysRenderAsText_PropertyAddress;

	private static int AlwaysRenderAsText_Offset;

	private static bool SetYScale_IsValid;

	private static IntPtr SetYScale_FunctionAddress;

	private static int SetYScale_ParamsSize;

	private static bool SetYScale_Value_IsValid;

	private static FFieldAddress SetYScale_Value_PropertyAddress;

	private static int SetYScale_Value_Offset;

	private static bool SetXScale_IsValid;

	private static IntPtr SetXScale_FunctionAddress;

	private static int SetXScale_ParamsSize;

	private static bool SetXScale_Value_IsValid;

	private static FFieldAddress SetXScale_Value_PropertyAddress;

	private static int SetXScale_Value_Offset;

	private static bool SetWorldSize_IsValid;

	private static IntPtr SetWorldSize_FunctionAddress;

	private static int SetWorldSize_ParamsSize;

	private static bool SetWorldSize_Value_IsValid;

	private static FFieldAddress SetWorldSize_Value_PropertyAddress;

	private static int SetWorldSize_Value_Offset;

	private static bool SetVertSpacingAdjust_IsValid;

	private static IntPtr SetVertSpacingAdjust_FunctionAddress;

	private static int SetVertSpacingAdjust_ParamsSize;

	private static bool SetVertSpacingAdjust_Value_IsValid;

	private static FFieldAddress SetVertSpacingAdjust_Value_PropertyAddress;

	private static int SetVertSpacingAdjust_Value_Offset;

	private static bool SetVerticalAlignment_IsValid;

	private static IntPtr SetVerticalAlignment_FunctionAddress;

	private static int SetVerticalAlignment_ParamsSize;

	private static bool SetVerticalAlignment_Value_IsValid;

	private static FFieldAddress SetVerticalAlignment_Value_PropertyAddress;

	private static int SetVerticalAlignment_Value_Offset;

	private static bool SetTextRenderColor_IsValid;

	private static IntPtr SetTextRenderColor_FunctionAddress;

	private static int SetTextRenderColor_ParamsSize;

	private static bool SetTextRenderColor_Value_IsValid;

	private static FFieldAddress SetTextRenderColor_Value_PropertyAddress;

	private static int SetTextRenderColor_Value_Offset;

	private static bool SetTextMaterial_IsValid;

	private static IntPtr SetTextMaterial_FunctionAddress;

	private static int SetTextMaterial_ParamsSize;

	private static bool SetTextMaterial_Material_IsValid;

	private static FFieldAddress SetTextMaterial_Material_PropertyAddress;

	private static int SetTextMaterial_Material_Offset;

	private static bool SetHorizSpacingAdjust_IsValid;

	private static IntPtr SetHorizSpacingAdjust_FunctionAddress;

	private static int SetHorizSpacingAdjust_ParamsSize;

	private static bool SetHorizSpacingAdjust_Value_IsValid;

	private static FFieldAddress SetHorizSpacingAdjust_Value_PropertyAddress;

	private static int SetHorizSpacingAdjust_Value_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_Value_IsValid;

	private static FFieldAddress SetHorizontalAlignment_Value_PropertyAddress;

	private static int SetHorizontalAlignment_Value_Offset;

	private static bool SetFont_IsValid;

	private static IntPtr SetFont_FunctionAddress;

	private static int SetFont_ParamsSize;

	private static bool SetFont_Value_IsValid;

	private static FFieldAddress SetFont_Value_PropertyAddress;

	private static int SetFont_Value_Offset;

	private static bool SetText_IsValid;

	private static IntPtr SetText_FunctionAddress;

	private static int SetText_ParamsSize;

	private static bool SetText_Value_IsValid;

	private static FFieldAddress SetText_Value_PropertyAddress;

	private static int SetText_Value_Offset;

	private static bool GetTextWorldSize_IsValid;

	private static IntPtr GetTextWorldSize_FunctionAddress;

	private static int GetTextWorldSize_ParamsSize;

	private static bool GetTextWorldSize_ReturnValue_IsValid;

	private static FFieldAddress GetTextWorldSize_ReturnValue_PropertyAddress;

	private static int GetTextWorldSize_ReturnValue_Offset;

	private static bool GetTextLocalSize_IsValid;

	private static IntPtr GetTextLocalSize_FunctionAddress;

	private static int GetTextLocalSize_ParamsSize;

	private static bool GetTextLocalSize_ReturnValue_IsValid;

	private static FFieldAddress GetTextLocalSize_ReturnValue_PropertyAddress;

	private static int GetTextLocalSize_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:Text")]
	public FText Text
	{
		get
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:Text");
				return null;
			}
			if (Text_TextCached == null)
			{
				Text_TextCached = new FText(IntPtr.Add(base.Address, Text_Offset), createReference: false);
			}
			return Text_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:Text");
				return;
			}
			if (Text_TextCached == null)
			{
				Text_TextCached = new FText(IntPtr.Add(base.Address, Text_Offset), createReference: false);
			}
			Text_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:TextMaterial")]
	public UMaterialInterface TextMaterial
	{
		get
		{
			CheckDestroyed();
			if (!TextMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:TextMaterial");
				return null;
			}
			return UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(base.Address, TextMaterial_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextMaterial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:TextMaterial");
			}
			else
			{
				UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(base.Address, TextMaterial_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:Font")]
	public UFont Font
	{
		get
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:Font");
				return null;
			}
			return UObjectMarshaler<UFont>.FromNative(IntPtr.Add(base.Address, Font_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Font_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:Font");
			}
			else
			{
				UObjectMarshaler<UFont>.ToNative(IntPtr.Add(base.Address, Font_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:HorizontalAlignment")]
	public EHorizTextAligment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:HorizontalAlignment");
				return EHorizTextAligment.EHTA_Left;
			}
			return EnumMarshaler<EHorizTextAligment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizTextAligment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:VerticalAlignment")]
	public EVerticalTextAligment VerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:VerticalAlignment");
				return EVerticalTextAligment.EVRTA_TextTop;
			}
			return EnumMarshaler<EVerticalTextAligment>.FromNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:VerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalTextAligment>.ToNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:TextRenderColor")]
	public FColor TextRenderColor
	{
		get
		{
			CheckDestroyed();
			if (!TextRenderColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:TextRenderColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, TextRenderColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextRenderColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:TextRenderColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, TextRenderColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:XScale")]
	public float XScale
	{
		get
		{
			CheckDestroyed();
			if (!XScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:XScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, XScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:XScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, XScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:YScale")]
	public float YScale
	{
		get
		{
			CheckDestroyed();
			if (!YScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:YScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, YScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:YScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, YScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:WorldSize")]
	public float WorldSize
	{
		get
		{
			CheckDestroyed();
			if (!WorldSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:WorldSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WorldSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WorldSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:WorldSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WorldSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:HorizSpacingAdjust")]
	public float HorizSpacingAdjust
	{
		get
		{
			CheckDestroyed();
			if (!HorizSpacingAdjust_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:HorizSpacingAdjust");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HorizSpacingAdjust_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HorizSpacingAdjust_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:HorizSpacingAdjust");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HorizSpacingAdjust_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:VertSpacingAdjust")]
	public float VertSpacingAdjust
	{
		get
		{
			CheckDestroyed();
			if (!VertSpacingAdjust_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:VertSpacingAdjust");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VertSpacingAdjust_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VertSpacingAdjust_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:VertSpacingAdjust");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VertSpacingAdjust_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759866207043605uL)]
	[UMetaPath("/Script/Engine.TextRenderComponent:bAlwaysRenderAsText")]
	public bool AlwaysRenderAsText
	{
		get
		{
			CheckDestroyed();
			if (!AlwaysRenderAsText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:bAlwaysRenderAsText");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AlwaysRenderAsText_Offset), 0, AlwaysRenderAsText_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AlwaysRenderAsText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.TextRenderComponent:bAlwaysRenderAsText");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AlwaysRenderAsText_Offset), 0, AlwaysRenderAsText_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetYScale")]
	public unsafe void SetYScale(float Value)
	{
		CheckDestroyed();
		if (!SetYScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetYScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetYScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetYScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetYScale_Value_Offset), 0, SetYScale_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetYScale_FunctionAddress, intPtr, SetYScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetXScale")]
	public unsafe void SetXScale(float Value)
	{
		CheckDestroyed();
		if (!SetXScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetXScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetXScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetXScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetXScale_Value_Offset), 0, SetXScale_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetXScale_FunctionAddress, intPtr, SetXScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetWorldSize")]
	public unsafe void SetWorldSize(float Value)
	{
		CheckDestroyed();
		if (!SetWorldSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetWorldSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWorldSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWorldSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetWorldSize_Value_Offset), 0, SetWorldSize_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWorldSize_FunctionAddress, intPtr, SetWorldSize_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetVertSpacingAdjust")]
	public unsafe void SetVertSpacingAdjust(float Value)
	{
		CheckDestroyed();
		if (!SetVertSpacingAdjust_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetVertSpacingAdjust");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVertSpacingAdjust_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVertSpacingAdjust_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetVertSpacingAdjust_Value_Offset), 0, SetVertSpacingAdjust_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVertSpacingAdjust_FunctionAddress, intPtr, SetVertSpacingAdjust_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalTextAligment Value)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetVerticalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVerticalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVerticalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EVerticalTextAligment>.ToNative(IntPtr.Add(intPtr, SetVerticalAlignment_Value_Offset), 0, SetVerticalAlignment_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVerticalAlignment_FunctionAddress, intPtr, SetVerticalAlignment_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetTextRenderColor")]
	public unsafe void SetTextRenderColor(FColor Value)
	{
		CheckDestroyed();
		if (!SetTextRenderColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetTextRenderColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextRenderColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextRenderColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetTextRenderColor_Value_Offset), 0, SetTextRenderColor_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextRenderColor_FunctionAddress, intPtr, SetTextRenderColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetTextMaterial")]
	public unsafe void SetTextMaterial(UMaterialInterface Material)
	{
		CheckDestroyed();
		if (!SetTextMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetTextMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTextMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTextMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, SetTextMaterial_Material_Offset), 0, SetTextMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTextMaterial_FunctionAddress, intPtr, SetTextMaterial_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetHorizSpacingAdjust")]
	public unsafe void SetHorizSpacingAdjust(float Value)
	{
		CheckDestroyed();
		if (!SetHorizSpacingAdjust_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetHorizSpacingAdjust");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHorizSpacingAdjust_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHorizSpacingAdjust_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetHorizSpacingAdjust_Value_Offset), 0, SetHorizSpacingAdjust_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHorizSpacingAdjust_FunctionAddress, intPtr, SetHorizSpacingAdjust_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizTextAligment Value)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetHorizontalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHorizontalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHorizontalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EHorizTextAligment>.ToNative(IntPtr.Add(intPtr, SetHorizontalAlignment_Value_Offset), 0, SetHorizontalAlignment_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHorizontalAlignment_FunctionAddress, intPtr, SetHorizontalAlignment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:SetFont")]
	public unsafe void SetFont(UFont Value)
	{
		CheckDestroyed();
		if (!SetFont_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:SetFont");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFont_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFont_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UFont>.ToNative(IntPtr.Add(intPtr, SetFont_Value_Offset), 0, SetFont_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFont_FunctionAddress, intPtr, SetFont_ParamsSize);
	}

	[UFunction(Flags = 71435265u, OriginalName = "K2_SetText")]
	[UMetaPath("/Script/Engine.TextRenderComponent:K2_SetText")]
	public unsafe void SetText(FText Value)
	{
		CheckDestroyed();
		if (!SetText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:K2_SetText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetText_Value_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetText_Value_Offset), 0, SetText_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetText_FunctionAddress, intPtr, SetText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetText_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:GetTextWorldSize")]
	public unsafe FVector GetTextWorldSize()
	{
		CheckDestroyed();
		if (!GetTextWorldSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:GetTextWorldSize");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextWorldSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextWorldSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextWorldSize_FunctionAddress, intPtr, GetTextWorldSize_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTextWorldSize_ReturnValue_Offset), 0, GetTextWorldSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.TextRenderComponent:GetTextLocalSize")]
	public unsafe FVector GetTextLocalSize()
	{
		CheckDestroyed();
		if (!GetTextLocalSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.TextRenderComponent:GetTextLocalSize");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTextLocalSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTextLocalSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTextLocalSize_FunctionAddress, intPtr, GetTextLocalSize_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetTextLocalSize_ReturnValue_Offset), 0, GetTextLocalSize_ReturnValue_PropertyAddress.Address);
	}

	static UTextRenderComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTextRenderComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTextRenderComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.TextRenderComponent");
		Text_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Text");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Text", Classes.FTextProperty);
		TextMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextMaterial");
		TextMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextMaterial", Classes.FObjectProperty);
		Font_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Font");
		Font_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Font", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VerticalAlignment_PropertyAddress, intPtr, "VerticalAlignment");
		VerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAlignment");
		VerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAlignment", Classes.FByteProperty);
		TextRenderColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextRenderColor");
		TextRenderColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextRenderColor", Classes.FStructProperty);
		XScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XScale");
		XScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XScale", Classes.FFloatProperty);
		YScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YScale");
		YScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YScale", Classes.FFloatProperty);
		WorldSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WorldSize");
		WorldSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WorldSize", Classes.FFloatProperty);
		HorizSpacingAdjust_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizSpacingAdjust");
		HorizSpacingAdjust_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizSpacingAdjust", Classes.FFloatProperty);
		VertSpacingAdjust_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VertSpacingAdjust");
		VertSpacingAdjust_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VertSpacingAdjust", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AlwaysRenderAsText_PropertyAddress, intPtr, "bAlwaysRenderAsText");
		AlwaysRenderAsText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAlwaysRenderAsText");
		AlwaysRenderAsText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAlwaysRenderAsText", Classes.FBoolProperty);
		SetYScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetYScale");
		SetYScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetYScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetYScale_Value_PropertyAddress, SetYScale_FunctionAddress, "Value");
		SetYScale_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetYScale_FunctionAddress, "Value");
		SetYScale_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetYScale_FunctionAddress, "Value", Classes.FFloatProperty);
		SetYScale_IsValid = SetYScale_FunctionAddress != IntPtr.Zero && SetYScale_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetYScale", SetYScale_IsValid);
		SetXScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetXScale");
		SetXScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetXScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetXScale_Value_PropertyAddress, SetXScale_FunctionAddress, "Value");
		SetXScale_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetXScale_FunctionAddress, "Value");
		SetXScale_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetXScale_FunctionAddress, "Value", Classes.FFloatProperty);
		SetXScale_IsValid = SetXScale_FunctionAddress != IntPtr.Zero && SetXScale_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetXScale", SetXScale_IsValid);
		SetWorldSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWorldSize");
		SetWorldSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWorldSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWorldSize_Value_PropertyAddress, SetWorldSize_FunctionAddress, "Value");
		SetWorldSize_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetWorldSize_FunctionAddress, "Value");
		SetWorldSize_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWorldSize_FunctionAddress, "Value", Classes.FFloatProperty);
		SetWorldSize_IsValid = SetWorldSize_FunctionAddress != IntPtr.Zero && SetWorldSize_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetWorldSize", SetWorldSize_IsValid);
		SetVertSpacingAdjust_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVertSpacingAdjust");
		SetVertSpacingAdjust_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVertSpacingAdjust_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVertSpacingAdjust_Value_PropertyAddress, SetVertSpacingAdjust_FunctionAddress, "Value");
		SetVertSpacingAdjust_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVertSpacingAdjust_FunctionAddress, "Value");
		SetVertSpacingAdjust_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVertSpacingAdjust_FunctionAddress, "Value", Classes.FFloatProperty);
		SetVertSpacingAdjust_IsValid = SetVertSpacingAdjust_FunctionAddress != IntPtr.Zero && SetVertSpacingAdjust_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetVertSpacingAdjust", SetVertSpacingAdjust_IsValid);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_Value_PropertyAddress, SetVerticalAlignment_FunctionAddress, "Value");
		SetVerticalAlignment_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "Value");
		SetVerticalAlignment_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "Value", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetTextRenderColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextRenderColor");
		SetTextRenderColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextRenderColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextRenderColor_Value_PropertyAddress, SetTextRenderColor_FunctionAddress, "Value");
		SetTextRenderColor_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetTextRenderColor_FunctionAddress, "Value");
		SetTextRenderColor_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextRenderColor_FunctionAddress, "Value", Classes.FStructProperty);
		SetTextRenderColor_IsValid = SetTextRenderColor_FunctionAddress != IntPtr.Zero && SetTextRenderColor_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetTextRenderColor", SetTextRenderColor_IsValid);
		SetTextMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTextMaterial");
		SetTextMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTextMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTextMaterial_Material_PropertyAddress, SetTextMaterial_FunctionAddress, "Material");
		SetTextMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(SetTextMaterial_FunctionAddress, "Material");
		SetTextMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTextMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		SetTextMaterial_IsValid = SetTextMaterial_FunctionAddress != IntPtr.Zero && SetTextMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetTextMaterial", SetTextMaterial_IsValid);
		SetHorizSpacingAdjust_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizSpacingAdjust");
		SetHorizSpacingAdjust_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizSpacingAdjust_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizSpacingAdjust_Value_PropertyAddress, SetHorizSpacingAdjust_FunctionAddress, "Value");
		SetHorizSpacingAdjust_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizSpacingAdjust_FunctionAddress, "Value");
		SetHorizSpacingAdjust_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizSpacingAdjust_FunctionAddress, "Value", Classes.FFloatProperty);
		SetHorizSpacingAdjust_IsValid = SetHorizSpacingAdjust_FunctionAddress != IntPtr.Zero && SetHorizSpacingAdjust_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetHorizSpacingAdjust", SetHorizSpacingAdjust_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_Value_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "Value");
		SetHorizontalAlignment_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "Value");
		SetHorizontalAlignment_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "Value", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
		SetFont_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFont");
		SetFont_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFont_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFont_Value_PropertyAddress, SetFont_FunctionAddress, "Value");
		SetFont_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetFont_FunctionAddress, "Value");
		SetFont_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFont_FunctionAddress, "Value", Classes.FObjectProperty);
		SetFont_IsValid = SetFont_FunctionAddress != IntPtr.Zero && SetFont_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:SetFont", SetFont_IsValid);
		SetText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_SetText");
		SetText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetText_Value_PropertyAddress, SetText_FunctionAddress, "Value");
		SetText_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetText_FunctionAddress, "Value");
		SetText_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetText_FunctionAddress, "Value", Classes.FTextProperty);
		SetText_IsValid = SetText_FunctionAddress != IntPtr.Zero && SetText_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:K2_SetText", SetText_IsValid);
		GetTextWorldSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTextWorldSize");
		GetTextWorldSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextWorldSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextWorldSize_ReturnValue_PropertyAddress, GetTextWorldSize_FunctionAddress, "ReturnValue");
		GetTextWorldSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextWorldSize_FunctionAddress, "ReturnValue");
		GetTextWorldSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextWorldSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTextWorldSize_IsValid = GetTextWorldSize_FunctionAddress != IntPtr.Zero && GetTextWorldSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:GetTextWorldSize", GetTextWorldSize_IsValid);
		GetTextLocalSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTextLocalSize");
		GetTextLocalSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTextLocalSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTextLocalSize_ReturnValue_PropertyAddress, GetTextLocalSize_FunctionAddress, "ReturnValue");
		GetTextLocalSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTextLocalSize_FunctionAddress, "ReturnValue");
		GetTextLocalSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTextLocalSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTextLocalSize_IsValid = GetTextLocalSize_FunctionAddress != IntPtr.Zero && GetTextLocalSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.TextRenderComponent:GetTextLocalSize", GetTextLocalSize_IsValid);
	}
}
