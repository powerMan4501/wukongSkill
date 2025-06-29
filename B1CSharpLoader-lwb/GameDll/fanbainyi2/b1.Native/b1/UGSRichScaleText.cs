using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;
using UnrealEngine.SlateCore;

namespace b1;

[UClass(Flags = (ClassFlags)819986592uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSRichScaleText", "UnrealExtent", UnrealModuleType.Game)]
public class UGSRichScaleText : UGSRichTextBlock
{
	private static bool GSWidthOverride_IsValid;

	private static int GSWidthOverride_Offset;

	private static bool GSHeightOverride_IsValid;

	private static int GSHeightOverride_Offset;

	private static bool GSMinDesiredWidth_IsValid;

	private static int GSMinDesiredWidth_Offset;

	private static bool GSMinDesiredHeight_IsValid;

	private static int GSMinDesiredHeight_Offset;

	private static bool GSMaxDesiredWidth_IsValid;

	private static int GSMaxDesiredWidth_Offset;

	private static bool GSMaxDesiredHeight_IsValid;

	private static int GSMaxDesiredHeight_Offset;

	private static bool GSMinAspectRatio_IsValid;

	private static int GSMinAspectRatio_Offset;

	private static bool GSMaxAspectRatio_IsValid;

	private static int GSMaxAspectRatio_Offset;

	private static bool Stretch_IsValid;

	private static FFieldAddress Stretch_PropertyAddress;

	private static int Stretch_Offset;

	private static bool StretchDirection_IsValid;

	private static FFieldAddress StretchDirection_PropertyAddress;

	private static int StretchDirection_Offset;

	private static bool UserSpecifiedScale_IsValid;

	private static int UserSpecifiedScale_Offset;

	private static bool IgnoreInheritedScale_IsValid;

	private static FFieldAddress IgnoreInheritedScale_PropertyAddress;

	private static int IgnoreInheritedScale_Offset;

	private static bool HorizontalAlignment_IsValid;

	private static FFieldAddress HorizontalAlignment_PropertyAddress;

	private static int HorizontalAlignment_Offset;

	private static bool VerticalAlignment_IsValid;

	private static FFieldAddress VerticalAlignment_PropertyAddress;

	private static int VerticalAlignment_Offset;

	private static bool SetVerticalAlignment_IsValid;

	private static IntPtr SetVerticalAlignment_FunctionAddress;

	private static int SetVerticalAlignment_ParamsSize;

	private static bool SetVerticalAlignment_InVerticalAlignment_IsValid;

	private static FFieldAddress SetVerticalAlignment_InVerticalAlignment_PropertyAddress;

	private static int SetVerticalAlignment_InVerticalAlignment_Offset;

	private static bool SetUserSpecifiedScale_IsValid;

	private static IntPtr SetUserSpecifiedScale_FunctionAddress;

	private static int SetUserSpecifiedScale_ParamsSize;

	private static bool SetUserSpecifiedScale_InUserSpecifiedScale_IsValid;

	private static FFieldAddress SetUserSpecifiedScale_InUserSpecifiedScale_PropertyAddress;

	private static int SetUserSpecifiedScale_InUserSpecifiedScale_Offset;

	private static bool SetStretchDirection_IsValid;

	private static IntPtr SetStretchDirection_FunctionAddress;

	private static int SetStretchDirection_ParamsSize;

	private static bool SetStretchDirection_InStretchDirection_IsValid;

	private static FFieldAddress SetStretchDirection_InStretchDirection_PropertyAddress;

	private static int SetStretchDirection_InStretchDirection_Offset;

	private static bool SetStretch_IsValid;

	private static IntPtr SetStretch_FunctionAddress;

	private static int SetStretch_ParamsSize;

	private static bool SetStretch_InStretch_IsValid;

	private static FFieldAddress SetStretch_InStretch_PropertyAddress;

	private static int SetStretch_InStretch_Offset;

	private static bool SetIgnoreInheritedScale_IsValid;

	private static IntPtr SetIgnoreInheritedScale_FunctionAddress;

	private static int SetIgnoreInheritedScale_ParamsSize;

	private static bool SetIgnoreInheritedScale_bInIgnoreInheritedScale_IsValid;

	private static FFieldAddress SetIgnoreInheritedScale_bInIgnoreInheritedScale_PropertyAddress;

	private static int SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset;

	private static bool SetHorizontalAlignment_IsValid;

	private static IntPtr SetHorizontalAlignment_FunctionAddress;

	private static int SetHorizontalAlignment_ParamsSize;

	private static bool SetHorizontalAlignment_InHorizontalAlignment_IsValid;

	private static FFieldAddress SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress;

	private static int SetHorizontalAlignment_InHorizontalAlignment_Offset;

	private static bool SetGSWidthOverride_IsValid;

	private static IntPtr SetGSWidthOverride_FunctionAddress;

	private static int SetGSWidthOverride_ParamsSize;

	private static bool SetGSWidthOverride_InGSWidthOverride_IsValid;

	private static FFieldAddress SetGSWidthOverride_InGSWidthOverride_PropertyAddress;

	private static int SetGSWidthOverride_InGSWidthOverride_Offset;

	private static bool SetGSMinDesiredWidth_IsValid;

	private static IntPtr SetGSMinDesiredWidth_FunctionAddress;

	private static int SetGSMinDesiredWidth_ParamsSize;

	private static bool SetGSMinDesiredWidth_InGSMinDesiredWidth_IsValid;

	private static FFieldAddress SetGSMinDesiredWidth_InGSMinDesiredWidth_PropertyAddress;

	private static int SetGSMinDesiredWidth_InGSMinDesiredWidth_Offset;

	private static bool SetGSMinDesiredHeight_IsValid;

	private static IntPtr SetGSMinDesiredHeight_FunctionAddress;

	private static int SetGSMinDesiredHeight_ParamsSize;

	private static bool SetGSMinDesiredHeight_InGSMinDesiredHeight_IsValid;

	private static FFieldAddress SetGSMinDesiredHeight_InGSMinDesiredHeight_PropertyAddress;

	private static int SetGSMinDesiredHeight_InGSMinDesiredHeight_Offset;

	private static bool SetGSMinAspectRatio_IsValid;

	private static IntPtr SetGSMinAspectRatio_FunctionAddress;

	private static int SetGSMinAspectRatio_ParamsSize;

	private static bool SetGSMinAspectRatio_InGSMinAspectRatio_IsValid;

	private static FFieldAddress SetGSMinAspectRatio_InGSMinAspectRatio_PropertyAddress;

	private static int SetGSMinAspectRatio_InGSMinAspectRatio_Offset;

	private static bool SetGSMaxDesiredWidth_IsValid;

	private static IntPtr SetGSMaxDesiredWidth_FunctionAddress;

	private static int SetGSMaxDesiredWidth_ParamsSize;

	private static bool SetGSMaxDesiredWidth_InGSMaxDesiredWidth_IsValid;

	private static FFieldAddress SetGSMaxDesiredWidth_InGSMaxDesiredWidth_PropertyAddress;

	private static int SetGSMaxDesiredWidth_InGSMaxDesiredWidth_Offset;

	private static bool SetGSMaxDesiredHeight_IsValid;

	private static IntPtr SetGSMaxDesiredHeight_FunctionAddress;

	private static int SetGSMaxDesiredHeight_ParamsSize;

	private static bool SetGSMaxDesiredHeight_InGSMaxDesiredHeight_IsValid;

	private static FFieldAddress SetGSMaxDesiredHeight_InGSMaxDesiredHeight_PropertyAddress;

	private static int SetGSMaxDesiredHeight_InGSMaxDesiredHeight_Offset;

	private static bool SetGSMaxAspectRatio_IsValid;

	private static IntPtr SetGSMaxAspectRatio_FunctionAddress;

	private static int SetGSMaxAspectRatio_ParamsSize;

	private static bool SetGSMaxAspectRatio_InGSMaxAspectRatio_IsValid;

	private static FFieldAddress SetGSMaxAspectRatio_InGSMaxAspectRatio_PropertyAddress;

	private static int SetGSMaxAspectRatio_InGSMaxAspectRatio_Offset;

	private static bool SetGSHeightOverride_IsValid;

	private static IntPtr SetGSHeightOverride_FunctionAddress;

	private static int SetGSHeightOverride_ParamsSize;

	private static bool SetGSHeightOverride_InGSHeightOverride_IsValid;

	private static FFieldAddress SetGSHeightOverride_InGSHeightOverride_PropertyAddress;

	private static int SetGSHeightOverride_InGSHeightOverride_Offset;

	private static bool ClearGSWidthOverride_IsValid;

	private static IntPtr ClearGSWidthOverride_FunctionAddress;

	private static int ClearGSWidthOverride_ParamsSize;

	private static bool ClearGSMinDesiredWidth_IsValid;

	private static IntPtr ClearGSMinDesiredWidth_FunctionAddress;

	private static int ClearGSMinDesiredWidth_ParamsSize;

	private static bool ClearGSMinDesiredHeight_IsValid;

	private static IntPtr ClearGSMinDesiredHeight_FunctionAddress;

	private static int ClearGSMinDesiredHeight_ParamsSize;

	private static bool ClearGSMinAspectRatio_IsValid;

	private static IntPtr ClearGSMinAspectRatio_FunctionAddress;

	private static int ClearGSMinAspectRatio_ParamsSize;

	private static bool ClearGSMaxDesiredWidth_IsValid;

	private static IntPtr ClearGSMaxDesiredWidth_FunctionAddress;

	private static int ClearGSMaxDesiredWidth_ParamsSize;

	private static bool ClearGSMaxDesiredHeight_IsValid;

	private static IntPtr ClearGSMaxDesiredHeight_FunctionAddress;

	private static int ClearGSMaxDesiredHeight_ParamsSize;

	private static bool ClearGSMaxAspectRatio_IsValid;

	private static IntPtr ClearGSMaxAspectRatio_FunctionAddress;

	private static int ClearGSMaxAspectRatio_ParamsSize;

	private static bool ClearGSHeightOverride_IsValid;

	private static IntPtr ClearGSHeightOverride_FunctionAddress;

	private static int ClearGSHeightOverride_ParamsSize;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:GSWidthOverride")]
	public float GSWidthOverride
	{
		get
		{
			CheckDestroyed();
			if (!GSWidthOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSWidthOverride");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GSWidthOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSWidthOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSWidthOverride");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GSWidthOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:GSHeightOverride")]
	public float GSHeightOverride
	{
		get
		{
			CheckDestroyed();
			if (!GSHeightOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSHeightOverride");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GSHeightOverride_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSHeightOverride_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSHeightOverride");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GSHeightOverride_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:GSMinDesiredWidth")]
	public float GSMinDesiredWidth
	{
		get
		{
			CheckDestroyed();
			if (!GSMinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMinDesiredWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GSMinDesiredWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSMinDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMinDesiredWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GSMinDesiredWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:GSMinDesiredHeight")]
	public float GSMinDesiredHeight
	{
		get
		{
			CheckDestroyed();
			if (!GSMinDesiredHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMinDesiredHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GSMinDesiredHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSMinDesiredHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMinDesiredHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GSMinDesiredHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:GSMaxDesiredWidth")]
	public float GSMaxDesiredWidth
	{
		get
		{
			CheckDestroyed();
			if (!GSMaxDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMaxDesiredWidth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GSMaxDesiredWidth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSMaxDesiredWidth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMaxDesiredWidth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GSMaxDesiredWidth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:GSMaxDesiredHeight")]
	public float GSMaxDesiredHeight
	{
		get
		{
			CheckDestroyed();
			if (!GSMaxDesiredHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMaxDesiredHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GSMaxDesiredHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSMaxDesiredHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMaxDesiredHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GSMaxDesiredHeight_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:GSMinAspectRatio")]
	public float GSMinAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!GSMinAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMinAspectRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GSMinAspectRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSMinAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMinAspectRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GSMinAspectRatio_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:GSMaxAspectRatio")]
	public float GSMaxAspectRatio
	{
		get
		{
			CheckDestroyed();
			if (!GSMaxAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMaxAspectRatio");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, GSMaxAspectRatio_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSMaxAspectRatio_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:GSMaxAspectRatio");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, GSMaxAspectRatio_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:Stretch")]
	public EStretch Stretch
	{
		get
		{
			CheckDestroyed();
			if (!Stretch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:Stretch");
				return EStretch.None;
			}
			return EnumMarshaler<EStretch>.FromNative(IntPtr.Add(base.Address, Stretch_Offset), 0, Stretch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Stretch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:Stretch");
			}
			else
			{
				EnumMarshaler<EStretch>.ToNative(IntPtr.Add(base.Address, Stretch_Offset), 0, Stretch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:StretchDirection")]
	public EStretchDirection StretchDirection
	{
		get
		{
			CheckDestroyed();
			if (!StretchDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:StretchDirection");
				return EStretchDirection.Both;
			}
			return EnumMarshaler<EStretchDirection>.FromNative(IntPtr.Add(base.Address, StretchDirection_Offset), 0, StretchDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StretchDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:StretchDirection");
			}
			else
			{
				EnumMarshaler<EStretchDirection>.ToNative(IntPtr.Add(base.Address, StretchDirection_Offset), 0, StretchDirection_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:UserSpecifiedScale")]
	public float UserSpecifiedScale
	{
		get
		{
			CheckDestroyed();
			if (!UserSpecifiedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:UserSpecifiedScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UserSpecifiedScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UserSpecifiedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:UserSpecifiedScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UserSpecifiedScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:IgnoreInheritedScale")]
	public bool IgnoreInheritedScale
	{
		get
		{
			CheckDestroyed();
			if (!IgnoreInheritedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:IgnoreInheritedScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IgnoreInheritedScale_Offset), 0, IgnoreInheritedScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IgnoreInheritedScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:IgnoreInheritedScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IgnoreInheritedScale_Offset), 0, IgnoreInheritedScale_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:HorizontalAlignment")]
	public EHorizontalAlignment HorizontalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:HorizontalAlignment");
				return EHorizontalAlignment.HAlign_Fill;
			}
			return EnumMarshaler<EHorizontalAlignment>.FromNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!HorizontalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:HorizontalAlignment");
			}
			else
			{
				EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(base.Address, HorizontalAlignment_Offset), 0, HorizontalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:VerticalAlignment")]
	public EVerticalAlignment VerticalAlignment
	{
		get
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:VerticalAlignment");
				return EVerticalAlignment.VAlign_Fill;
			}
			return EnumMarshaler<EVerticalAlignment>.FromNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!VerticalAlignment_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSRichScaleText:VerticalAlignment");
			}
			else
			{
				EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(base.Address, VerticalAlignment_Offset), 0, VerticalAlignment_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetVerticalAlignment")]
	public unsafe void SetVerticalAlignment(EVerticalAlignment InVerticalAlignment)
	{
		CheckDestroyed();
		if (!SetVerticalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetVerticalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVerticalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVerticalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EVerticalAlignment>.ToNative(IntPtr.Add(intPtr, SetVerticalAlignment_InVerticalAlignment_Offset), 0, SetVerticalAlignment_InVerticalAlignment_PropertyAddress.Address, InVerticalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVerticalAlignment_FunctionAddress, intPtr, SetVerticalAlignment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetUserSpecifiedScale")]
	public unsafe void SetUserSpecifiedScale(float InUserSpecifiedScale)
	{
		CheckDestroyed();
		if (!SetUserSpecifiedScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetUserSpecifiedScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUserSpecifiedScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUserSpecifiedScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetUserSpecifiedScale_InUserSpecifiedScale_Offset), 0, SetUserSpecifiedScale_InUserSpecifiedScale_PropertyAddress.Address, InUserSpecifiedScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUserSpecifiedScale_FunctionAddress, intPtr, SetUserSpecifiedScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetStretchDirection")]
	public unsafe void SetStretchDirection(EStretchDirection InStretchDirection)
	{
		CheckDestroyed();
		if (!SetStretchDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetStretchDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStretchDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStretchDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EStretchDirection>.ToNative(IntPtr.Add(intPtr, SetStretchDirection_InStretchDirection_Offset), 0, SetStretchDirection_InStretchDirection_PropertyAddress.Address, InStretchDirection);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStretchDirection_FunctionAddress, intPtr, SetStretchDirection_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetStretch")]
	public unsafe void SetStretch(EStretch InStretch)
	{
		CheckDestroyed();
		if (!SetStretch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetStretch");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStretch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStretch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EStretch>.ToNative(IntPtr.Add(intPtr, SetStretch_InStretch_Offset), 0, SetStretch_InStretch_PropertyAddress.Address, InStretch);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStretch_FunctionAddress, intPtr, SetStretch_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetIgnoreInheritedScale")]
	public unsafe void SetIgnoreInheritedScale(bool bInIgnoreInheritedScale)
	{
		CheckDestroyed();
		if (!SetIgnoreInheritedScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetIgnoreInheritedScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIgnoreInheritedScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIgnoreInheritedScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset), 0, SetIgnoreInheritedScale_bInIgnoreInheritedScale_PropertyAddress.Address, bInIgnoreInheritedScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIgnoreInheritedScale_FunctionAddress, intPtr, SetIgnoreInheritedScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetHorizontalAlignment")]
	public unsafe void SetHorizontalAlignment(EHorizontalAlignment InHorizontalAlignment)
	{
		CheckDestroyed();
		if (!SetHorizontalAlignment_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetHorizontalAlignment");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetHorizontalAlignment_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetHorizontalAlignment_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EHorizontalAlignment>.ToNative(IntPtr.Add(intPtr, SetHorizontalAlignment_InHorizontalAlignment_Offset), 0, SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress.Address, InHorizontalAlignment);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetHorizontalAlignment_FunctionAddress, intPtr, SetHorizontalAlignment_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetGSWidthOverride")]
	public unsafe void SetGSWidthOverride(float InGSWidthOverride)
	{
		CheckDestroyed();
		if (!SetGSWidthOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetGSWidthOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSWidthOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSWidthOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSWidthOverride_InGSWidthOverride_Offset), 0, SetGSWidthOverride_InGSWidthOverride_PropertyAddress.Address, InGSWidthOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSWidthOverride_FunctionAddress, intPtr, SetGSWidthOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetGSMinDesiredWidth")]
	public unsafe void SetGSMinDesiredWidth(float InGSMinDesiredWidth)
	{
		CheckDestroyed();
		if (!SetGSMinDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetGSMinDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSMinDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSMinDesiredWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSMinDesiredWidth_InGSMinDesiredWidth_Offset), 0, SetGSMinDesiredWidth_InGSMinDesiredWidth_PropertyAddress.Address, InGSMinDesiredWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSMinDesiredWidth_FunctionAddress, intPtr, SetGSMinDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetGSMinDesiredHeight")]
	public unsafe void SetGSMinDesiredHeight(float InGSMinDesiredHeight)
	{
		CheckDestroyed();
		if (!SetGSMinDesiredHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetGSMinDesiredHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSMinDesiredHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSMinDesiredHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSMinDesiredHeight_InGSMinDesiredHeight_Offset), 0, SetGSMinDesiredHeight_InGSMinDesiredHeight_PropertyAddress.Address, InGSMinDesiredHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSMinDesiredHeight_FunctionAddress, intPtr, SetGSMinDesiredHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetGSMinAspectRatio")]
	public unsafe void SetGSMinAspectRatio(float InGSMinAspectRatio)
	{
		CheckDestroyed();
		if (!SetGSMinAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetGSMinAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSMinAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSMinAspectRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSMinAspectRatio_InGSMinAspectRatio_Offset), 0, SetGSMinAspectRatio_InGSMinAspectRatio_PropertyAddress.Address, InGSMinAspectRatio);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSMinAspectRatio_FunctionAddress, intPtr, SetGSMinAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetGSMaxDesiredWidth")]
	public unsafe void SetGSMaxDesiredWidth(float InGSMaxDesiredWidth)
	{
		CheckDestroyed();
		if (!SetGSMaxDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetGSMaxDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSMaxDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSMaxDesiredWidth_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSMaxDesiredWidth_InGSMaxDesiredWidth_Offset), 0, SetGSMaxDesiredWidth_InGSMaxDesiredWidth_PropertyAddress.Address, InGSMaxDesiredWidth);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSMaxDesiredWidth_FunctionAddress, intPtr, SetGSMaxDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetGSMaxDesiredHeight")]
	public unsafe void SetGSMaxDesiredHeight(float InGSMaxDesiredHeight)
	{
		CheckDestroyed();
		if (!SetGSMaxDesiredHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetGSMaxDesiredHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSMaxDesiredHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSMaxDesiredHeight_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSMaxDesiredHeight_InGSMaxDesiredHeight_Offset), 0, SetGSMaxDesiredHeight_InGSMaxDesiredHeight_PropertyAddress.Address, InGSMaxDesiredHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSMaxDesiredHeight_FunctionAddress, intPtr, SetGSMaxDesiredHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetGSMaxAspectRatio")]
	public unsafe void SetGSMaxAspectRatio(float InGSMaxAspectRatio)
	{
		CheckDestroyed();
		if (!SetGSMaxAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetGSMaxAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSMaxAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSMaxAspectRatio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSMaxAspectRatio_InGSMaxAspectRatio_Offset), 0, SetGSMaxAspectRatio_InGSMaxAspectRatio_PropertyAddress.Address, InGSMaxAspectRatio);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSMaxAspectRatio_FunctionAddress, intPtr, SetGSMaxAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:SetGSHeightOverride")]
	public unsafe void SetGSHeightOverride(float InGSHeightOverride)
	{
		CheckDestroyed();
		if (!SetGSHeightOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:SetGSHeightOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGSHeightOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGSHeightOverride_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetGSHeightOverride_InGSHeightOverride_Offset), 0, SetGSHeightOverride_InGSHeightOverride_PropertyAddress.Address, InGSHeightOverride);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetGSHeightOverride_FunctionAddress, intPtr, SetGSHeightOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:ClearGSWidthOverride")]
	public unsafe void ClearGSWidthOverride()
	{
		CheckDestroyed();
		if (!ClearGSWidthOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:ClearGSWidthOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearGSWidthOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearGSWidthOverride_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearGSWidthOverride_FunctionAddress, argsSize: ClearGSWidthOverride_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:ClearGSMinDesiredWidth")]
	public unsafe void ClearGSMinDesiredWidth()
	{
		CheckDestroyed();
		if (!ClearGSMinDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:ClearGSMinDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearGSMinDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearGSMinDesiredWidth_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearGSMinDesiredWidth_FunctionAddress, argsSize: ClearGSMinDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:ClearGSMinDesiredHeight")]
	public unsafe void ClearGSMinDesiredHeight()
	{
		CheckDestroyed();
		if (!ClearGSMinDesiredHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:ClearGSMinDesiredHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearGSMinDesiredHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearGSMinDesiredHeight_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearGSMinDesiredHeight_FunctionAddress, argsSize: ClearGSMinDesiredHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:ClearGSMinAspectRatio")]
	public unsafe void ClearGSMinAspectRatio()
	{
		CheckDestroyed();
		if (!ClearGSMinAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:ClearGSMinAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearGSMinAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearGSMinAspectRatio_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearGSMinAspectRatio_FunctionAddress, argsSize: ClearGSMinAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxDesiredWidth")]
	public unsafe void ClearGSMaxDesiredWidth()
	{
		CheckDestroyed();
		if (!ClearGSMaxDesiredWidth_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxDesiredWidth");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearGSMaxDesiredWidth_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearGSMaxDesiredWidth_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearGSMaxDesiredWidth_FunctionAddress, argsSize: ClearGSMaxDesiredWidth_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxDesiredHeight")]
	public unsafe void ClearGSMaxDesiredHeight()
	{
		CheckDestroyed();
		if (!ClearGSMaxDesiredHeight_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxDesiredHeight");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearGSMaxDesiredHeight_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearGSMaxDesiredHeight_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearGSMaxDesiredHeight_FunctionAddress, argsSize: ClearGSMaxDesiredHeight_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxAspectRatio")]
	public unsafe void ClearGSMaxAspectRatio()
	{
		CheckDestroyed();
		if (!ClearGSMaxAspectRatio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxAspectRatio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearGSMaxAspectRatio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearGSMaxAspectRatio_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearGSMaxAspectRatio_FunctionAddress, argsSize: ClearGSMaxAspectRatio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSRichScaleText:ClearGSHeightOverride")]
	public unsafe void ClearGSHeightOverride()
	{
		CheckDestroyed();
		if (!ClearGSHeightOverride_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSRichScaleText:ClearGSHeightOverride");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearGSHeightOverride_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearGSHeightOverride_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ClearGSHeightOverride_FunctionAddress, argsSize: ClearGSHeightOverride_ParamsSize);
	}

	static UGSRichScaleText()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSRichScaleText)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSRichScaleText));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.GSRichScaleText");
		GSWidthOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSWidthOverride");
		GSWidthOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSWidthOverride", Classes.FFloatProperty);
		GSHeightOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSHeightOverride");
		GSHeightOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSHeightOverride", Classes.FFloatProperty);
		GSMinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSMinDesiredWidth");
		GSMinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSMinDesiredWidth", Classes.FFloatProperty);
		GSMinDesiredHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSMinDesiredHeight");
		GSMinDesiredHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSMinDesiredHeight", Classes.FFloatProperty);
		GSMaxDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSMaxDesiredWidth");
		GSMaxDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSMaxDesiredWidth", Classes.FFloatProperty);
		GSMaxDesiredHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSMaxDesiredHeight");
		GSMaxDesiredHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSMaxDesiredHeight", Classes.FFloatProperty);
		GSMinAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSMinAspectRatio");
		GSMinAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSMinAspectRatio", Classes.FFloatProperty);
		GSMaxAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSMaxAspectRatio");
		GSMaxAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSMaxAspectRatio", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Stretch_PropertyAddress, intPtr, "Stretch");
		Stretch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Stretch");
		Stretch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Stretch", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref StretchDirection_PropertyAddress, intPtr, "StretchDirection");
		StretchDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StretchDirection");
		StretchDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StretchDirection", Classes.FByteProperty);
		UserSpecifiedScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserSpecifiedScale");
		UserSpecifiedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserSpecifiedScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreInheritedScale_PropertyAddress, intPtr, "IgnoreInheritedScale");
		IgnoreInheritedScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IgnoreInheritedScale");
		IgnoreInheritedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IgnoreInheritedScale", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HorizontalAlignment_PropertyAddress, intPtr, "HorizontalAlignment");
		HorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HorizontalAlignment");
		HorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HorizontalAlignment", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref VerticalAlignment_PropertyAddress, intPtr, "VerticalAlignment");
		VerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VerticalAlignment");
		VerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVerticalAlignment");
		SetVerticalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVerticalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVerticalAlignment_InVerticalAlignment_PropertyAddress, SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment");
		SetVerticalAlignment_InVerticalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVerticalAlignment_FunctionAddress, "InVerticalAlignment", Classes.FByteProperty);
		SetVerticalAlignment_IsValid = SetVerticalAlignment_FunctionAddress != IntPtr.Zero && SetVerticalAlignment_InVerticalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetVerticalAlignment", SetVerticalAlignment_IsValid);
		SetUserSpecifiedScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUserSpecifiedScale");
		SetUserSpecifiedScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUserSpecifiedScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUserSpecifiedScale_InUserSpecifiedScale_PropertyAddress, SetUserSpecifiedScale_FunctionAddress, "InUserSpecifiedScale");
		SetUserSpecifiedScale_InUserSpecifiedScale_Offset = NativeReflectionCached.GetPropertyOffset(SetUserSpecifiedScale_FunctionAddress, "InUserSpecifiedScale");
		SetUserSpecifiedScale_InUserSpecifiedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserSpecifiedScale_FunctionAddress, "InUserSpecifiedScale", Classes.FFloatProperty);
		SetUserSpecifiedScale_IsValid = SetUserSpecifiedScale_FunctionAddress != IntPtr.Zero && SetUserSpecifiedScale_InUserSpecifiedScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetUserSpecifiedScale", SetUserSpecifiedScale_IsValid);
		SetStretchDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStretchDirection");
		SetStretchDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStretchDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStretchDirection_InStretchDirection_PropertyAddress, SetStretchDirection_FunctionAddress, "InStretchDirection");
		SetStretchDirection_InStretchDirection_Offset = NativeReflectionCached.GetPropertyOffset(SetStretchDirection_FunctionAddress, "InStretchDirection");
		SetStretchDirection_InStretchDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStretchDirection_FunctionAddress, "InStretchDirection", Classes.FByteProperty);
		SetStretchDirection_IsValid = SetStretchDirection_FunctionAddress != IntPtr.Zero && SetStretchDirection_InStretchDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetStretchDirection", SetStretchDirection_IsValid);
		SetStretch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetStretch");
		SetStretch_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStretch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStretch_InStretch_PropertyAddress, SetStretch_FunctionAddress, "InStretch");
		SetStretch_InStretch_Offset = NativeReflectionCached.GetPropertyOffset(SetStretch_FunctionAddress, "InStretch");
		SetStretch_InStretch_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStretch_FunctionAddress, "InStretch", Classes.FByteProperty);
		SetStretch_IsValid = SetStretch_FunctionAddress != IntPtr.Zero && SetStretch_InStretch_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetStretch", SetStretch_IsValid);
		SetIgnoreInheritedScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIgnoreInheritedScale");
		SetIgnoreInheritedScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIgnoreInheritedScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIgnoreInheritedScale_bInIgnoreInheritedScale_PropertyAddress, SetIgnoreInheritedScale_FunctionAddress, "bInIgnoreInheritedScale");
		SetIgnoreInheritedScale_bInIgnoreInheritedScale_Offset = NativeReflectionCached.GetPropertyOffset(SetIgnoreInheritedScale_FunctionAddress, "bInIgnoreInheritedScale");
		SetIgnoreInheritedScale_bInIgnoreInheritedScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIgnoreInheritedScale_FunctionAddress, "bInIgnoreInheritedScale", Classes.FBoolProperty);
		SetIgnoreInheritedScale_IsValid = SetIgnoreInheritedScale_FunctionAddress != IntPtr.Zero && SetIgnoreInheritedScale_bInIgnoreInheritedScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetIgnoreInheritedScale", SetIgnoreInheritedScale_IsValid);
		SetHorizontalAlignment_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetHorizontalAlignment");
		SetHorizontalAlignment_ParamsSize = NativeReflection.GetFunctionParamsSize(SetHorizontalAlignment_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetHorizontalAlignment_InHorizontalAlignment_PropertyAddress, SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_Offset = NativeReflectionCached.GetPropertyOffset(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment");
		SetHorizontalAlignment_InHorizontalAlignment_IsValid = NativeReflectionCached.ValidatePropertyClass(SetHorizontalAlignment_FunctionAddress, "InHorizontalAlignment", Classes.FByteProperty);
		SetHorizontalAlignment_IsValid = SetHorizontalAlignment_FunctionAddress != IntPtr.Zero && SetHorizontalAlignment_InHorizontalAlignment_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetHorizontalAlignment", SetHorizontalAlignment_IsValid);
		SetGSWidthOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSWidthOverride");
		SetGSWidthOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSWidthOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSWidthOverride_InGSWidthOverride_PropertyAddress, SetGSWidthOverride_FunctionAddress, "InGSWidthOverride");
		SetGSWidthOverride_InGSWidthOverride_Offset = NativeReflectionCached.GetPropertyOffset(SetGSWidthOverride_FunctionAddress, "InGSWidthOverride");
		SetGSWidthOverride_InGSWidthOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSWidthOverride_FunctionAddress, "InGSWidthOverride", Classes.FFloatProperty);
		SetGSWidthOverride_IsValid = SetGSWidthOverride_FunctionAddress != IntPtr.Zero && SetGSWidthOverride_InGSWidthOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetGSWidthOverride", SetGSWidthOverride_IsValid);
		SetGSMinDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSMinDesiredWidth");
		SetGSMinDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSMinDesiredWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSMinDesiredWidth_InGSMinDesiredWidth_PropertyAddress, SetGSMinDesiredWidth_FunctionAddress, "InGSMinDesiredWidth");
		SetGSMinDesiredWidth_InGSMinDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetGSMinDesiredWidth_FunctionAddress, "InGSMinDesiredWidth");
		SetGSMinDesiredWidth_InGSMinDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSMinDesiredWidth_FunctionAddress, "InGSMinDesiredWidth", Classes.FFloatProperty);
		SetGSMinDesiredWidth_IsValid = SetGSMinDesiredWidth_FunctionAddress != IntPtr.Zero && SetGSMinDesiredWidth_InGSMinDesiredWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetGSMinDesiredWidth", SetGSMinDesiredWidth_IsValid);
		SetGSMinDesiredHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSMinDesiredHeight");
		SetGSMinDesiredHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSMinDesiredHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSMinDesiredHeight_InGSMinDesiredHeight_PropertyAddress, SetGSMinDesiredHeight_FunctionAddress, "InGSMinDesiredHeight");
		SetGSMinDesiredHeight_InGSMinDesiredHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetGSMinDesiredHeight_FunctionAddress, "InGSMinDesiredHeight");
		SetGSMinDesiredHeight_InGSMinDesiredHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSMinDesiredHeight_FunctionAddress, "InGSMinDesiredHeight", Classes.FFloatProperty);
		SetGSMinDesiredHeight_IsValid = SetGSMinDesiredHeight_FunctionAddress != IntPtr.Zero && SetGSMinDesiredHeight_InGSMinDesiredHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetGSMinDesiredHeight", SetGSMinDesiredHeight_IsValid);
		SetGSMinAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSMinAspectRatio");
		SetGSMinAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSMinAspectRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSMinAspectRatio_InGSMinAspectRatio_PropertyAddress, SetGSMinAspectRatio_FunctionAddress, "InGSMinAspectRatio");
		SetGSMinAspectRatio_InGSMinAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(SetGSMinAspectRatio_FunctionAddress, "InGSMinAspectRatio");
		SetGSMinAspectRatio_InGSMinAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSMinAspectRatio_FunctionAddress, "InGSMinAspectRatio", Classes.FFloatProperty);
		SetGSMinAspectRatio_IsValid = SetGSMinAspectRatio_FunctionAddress != IntPtr.Zero && SetGSMinAspectRatio_InGSMinAspectRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetGSMinAspectRatio", SetGSMinAspectRatio_IsValid);
		SetGSMaxDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSMaxDesiredWidth");
		SetGSMaxDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSMaxDesiredWidth_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSMaxDesiredWidth_InGSMaxDesiredWidth_PropertyAddress, SetGSMaxDesiredWidth_FunctionAddress, "InGSMaxDesiredWidth");
		SetGSMaxDesiredWidth_InGSMaxDesiredWidth_Offset = NativeReflectionCached.GetPropertyOffset(SetGSMaxDesiredWidth_FunctionAddress, "InGSMaxDesiredWidth");
		SetGSMaxDesiredWidth_InGSMaxDesiredWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSMaxDesiredWidth_FunctionAddress, "InGSMaxDesiredWidth", Classes.FFloatProperty);
		SetGSMaxDesiredWidth_IsValid = SetGSMaxDesiredWidth_FunctionAddress != IntPtr.Zero && SetGSMaxDesiredWidth_InGSMaxDesiredWidth_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetGSMaxDesiredWidth", SetGSMaxDesiredWidth_IsValid);
		SetGSMaxDesiredHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSMaxDesiredHeight");
		SetGSMaxDesiredHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSMaxDesiredHeight_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSMaxDesiredHeight_InGSMaxDesiredHeight_PropertyAddress, SetGSMaxDesiredHeight_FunctionAddress, "InGSMaxDesiredHeight");
		SetGSMaxDesiredHeight_InGSMaxDesiredHeight_Offset = NativeReflectionCached.GetPropertyOffset(SetGSMaxDesiredHeight_FunctionAddress, "InGSMaxDesiredHeight");
		SetGSMaxDesiredHeight_InGSMaxDesiredHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSMaxDesiredHeight_FunctionAddress, "InGSMaxDesiredHeight", Classes.FFloatProperty);
		SetGSMaxDesiredHeight_IsValid = SetGSMaxDesiredHeight_FunctionAddress != IntPtr.Zero && SetGSMaxDesiredHeight_InGSMaxDesiredHeight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetGSMaxDesiredHeight", SetGSMaxDesiredHeight_IsValid);
		SetGSMaxAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSMaxAspectRatio");
		SetGSMaxAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSMaxAspectRatio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSMaxAspectRatio_InGSMaxAspectRatio_PropertyAddress, SetGSMaxAspectRatio_FunctionAddress, "InGSMaxAspectRatio");
		SetGSMaxAspectRatio_InGSMaxAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(SetGSMaxAspectRatio_FunctionAddress, "InGSMaxAspectRatio");
		SetGSMaxAspectRatio_InGSMaxAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSMaxAspectRatio_FunctionAddress, "InGSMaxAspectRatio", Classes.FFloatProperty);
		SetGSMaxAspectRatio_IsValid = SetGSMaxAspectRatio_FunctionAddress != IntPtr.Zero && SetGSMaxAspectRatio_InGSMaxAspectRatio_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetGSMaxAspectRatio", SetGSMaxAspectRatio_IsValid);
		SetGSHeightOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSHeightOverride");
		SetGSHeightOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSHeightOverride_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGSHeightOverride_InGSHeightOverride_PropertyAddress, SetGSHeightOverride_FunctionAddress, "InGSHeightOverride");
		SetGSHeightOverride_InGSHeightOverride_Offset = NativeReflectionCached.GetPropertyOffset(SetGSHeightOverride_FunctionAddress, "InGSHeightOverride");
		SetGSHeightOverride_InGSHeightOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGSHeightOverride_FunctionAddress, "InGSHeightOverride", Classes.FFloatProperty);
		SetGSHeightOverride_IsValid = SetGSHeightOverride_FunctionAddress != IntPtr.Zero && SetGSHeightOverride_InGSHeightOverride_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:SetGSHeightOverride", SetGSHeightOverride_IsValid);
		ClearGSWidthOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGSWidthOverride");
		ClearGSWidthOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGSWidthOverride_FunctionAddress);
		ClearGSWidthOverride_IsValid = ClearGSWidthOverride_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:ClearGSWidthOverride", ClearGSWidthOverride_IsValid);
		ClearGSMinDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGSMinDesiredWidth");
		ClearGSMinDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGSMinDesiredWidth_FunctionAddress);
		ClearGSMinDesiredWidth_IsValid = ClearGSMinDesiredWidth_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:ClearGSMinDesiredWidth", ClearGSMinDesiredWidth_IsValid);
		ClearGSMinDesiredHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGSMinDesiredHeight");
		ClearGSMinDesiredHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGSMinDesiredHeight_FunctionAddress);
		ClearGSMinDesiredHeight_IsValid = ClearGSMinDesiredHeight_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:ClearGSMinDesiredHeight", ClearGSMinDesiredHeight_IsValid);
		ClearGSMinAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGSMinAspectRatio");
		ClearGSMinAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGSMinAspectRatio_FunctionAddress);
		ClearGSMinAspectRatio_IsValid = ClearGSMinAspectRatio_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:ClearGSMinAspectRatio", ClearGSMinAspectRatio_IsValid);
		ClearGSMaxDesiredWidth_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGSMaxDesiredWidth");
		ClearGSMaxDesiredWidth_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGSMaxDesiredWidth_FunctionAddress);
		ClearGSMaxDesiredWidth_IsValid = ClearGSMaxDesiredWidth_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxDesiredWidth", ClearGSMaxDesiredWidth_IsValid);
		ClearGSMaxDesiredHeight_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGSMaxDesiredHeight");
		ClearGSMaxDesiredHeight_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGSMaxDesiredHeight_FunctionAddress);
		ClearGSMaxDesiredHeight_IsValid = ClearGSMaxDesiredHeight_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxDesiredHeight", ClearGSMaxDesiredHeight_IsValid);
		ClearGSMaxAspectRatio_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGSMaxAspectRatio");
		ClearGSMaxAspectRatio_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGSMaxAspectRatio_FunctionAddress);
		ClearGSMaxAspectRatio_IsValid = ClearGSMaxAspectRatio_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:ClearGSMaxAspectRatio", ClearGSMaxAspectRatio_IsValid);
		ClearGSHeightOverride_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClearGSHeightOverride");
		ClearGSHeightOverride_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearGSHeightOverride_FunctionAddress);
		ClearGSHeightOverride_IsValid = ClearGSHeightOverride_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSRichScaleText:ClearGSHeightOverride", ClearGSHeightOverride_IsValid);
	}
}
