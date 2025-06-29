using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass(Flags = (ClassFlags)819986592uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.GSTextBlock", "UnrealExtent", UnrealModuleType.Game)]
public class UGSTextBlock : UTextBlock
{
	private static bool UseIndent_IsValid;

	private static FFieldAddress UseIndent_PropertyAddress;

	private static int UseIndent_Offset;

	private static bool Ellipsis_IsValid;

	private static int Ellipsis_Offset;

	private static bool DefaultIndentSize_IsValid;

	private static int DefaultIndentSize_Offset;

	private static bool Content_IsValid;

	private static int Content_Offset;

	private FText Content_TextCached;

	private static bool SetUseIndent_IsValid;

	private static IntPtr SetUseIndent_FunctionAddress;

	private static int SetUseIndent_ParamsSize;

	private static bool SetUseIndent_InUseIndent_IsValid;

	private static FFieldAddress SetUseIndent_InUseIndent_PropertyAddress;

	private static int SetUseIndent_InUseIndent_Offset;

	private static bool SetDefaultIndentSize_IsValid;

	private static IntPtr SetDefaultIndentSize_FunctionAddress;

	private static int SetDefaultIndentSize_ParamsSize;

	private static bool SetDefaultIndentSize_InDefaultIndentSize_IsValid;

	private static FFieldAddress SetDefaultIndentSize_InDefaultIndentSize_PropertyAddress;

	private static int SetDefaultIndentSize_InDefaultIndentSize_Offset;

	private static bool OnTextPrePaint_IsValid;

	private IntPtr OnTextPrePaint_InstanceFunctionAddress;

	private static IntPtr OnTextPrePaint_FunctionAddress;

	private static int OnTextPrePaint_ParamsSize;

	private static bool NativeCheckText_IsValid;

	private static IntPtr NativeCheckText_FunctionAddress;

	private static int NativeCheckText_ParamsSize;

	private static bool MakeContentDirty_IsValid;

	private static IntPtr MakeContentDirty_FunctionAddress;

	private static int MakeContentDirty_ParamsSize;

	private static bool GetUseIndent_IsValid;

	private static IntPtr GetUseIndent_FunctionAddress;

	private static int GetUseIndent_ParamsSize;

	private static bool GetUseIndent_ReturnValue_IsValid;

	private static FFieldAddress GetUseIndent_ReturnValue_PropertyAddress;

	private static int GetUseIndent_ReturnValue_Offset;

	private static bool GetDefaultIndentSize_IsValid;

	private static IntPtr GetDefaultIndentSize_FunctionAddress;

	private static int GetDefaultIndentSize_ParamsSize;

	private static bool GetDefaultIndentSize_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultIndentSize_ReturnValue_PropertyAddress;

	private static int GetDefaultIndentSize_ReturnValue_Offset;

	private static bool GetContent_IsValid;

	private static IntPtr GetContent_FunctionAddress;

	private static int GetContent_ParamsSize;

	private static bool GetContent_ReturnValue_IsValid;

	private static FFieldAddress GetContent_ReturnValue_PropertyAddress;

	private static int GetContent_ReturnValue_Offset;

	private static bool ApplyText_IsValid;

	private static IntPtr ApplyText_FunctionAddress;

	private static int ApplyText_ParamsSize;

	private static bool ApplyText_InText_IsValid;

	private static FFieldAddress ApplyText_InText_PropertyAddress;

	private static int ApplyText_InText_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:UseIndent")]
	public bool UseIndent
	{
		get
		{
			CheckDestroyed();
			if (!UseIndent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTextBlock:UseIndent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseIndent_Offset), 0, UseIndent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseIndent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTextBlock:UseIndent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseIndent_Offset), 0, UseIndent_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:Ellipsis")]
	public string Ellipsis
	{
		get
		{
			CheckDestroyed();
			if (!Ellipsis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTextBlock:Ellipsis");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Ellipsis_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Ellipsis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTextBlock:Ellipsis");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Ellipsis_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:DefaultIndentSize")]
	public float DefaultIndentSize
	{
		get
		{
			CheckDestroyed();
			if (!DefaultIndentSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTextBlock:DefaultIndentSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DefaultIndentSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultIndentSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTextBlock:DefaultIndentSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DefaultIndentSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:Content")]
	public FText Content
	{
		get
		{
			CheckDestroyed();
			if (!Content_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTextBlock:Content");
				return null;
			}
			if (Content_TextCached == null)
			{
				Content_TextCached = new FText(IntPtr.Add(base.Address, Content_Offset), createReference: false);
			}
			return Content_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!Content_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.GSTextBlock:Content");
				return;
			}
			if (Content_TextCached == null)
			{
				Content_TextCached = new FText(IntPtr.Add(base.Address, Content_Offset), createReference: false);
			}
			Content_TextCached.CopyFrom(value);
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:SetUseIndent")]
	public unsafe void SetUseIndent(bool InUseIndent)
	{
		CheckDestroyed();
		if (!SetUseIndent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:SetUseIndent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUseIndent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUseIndent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetUseIndent_InUseIndent_Offset), 0, SetUseIndent_InUseIndent_PropertyAddress.Address, InUseIndent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUseIndent_FunctionAddress, intPtr, SetUseIndent_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:SetDefaultIndentSize")]
	public unsafe void SetDefaultIndentSize(float InDefaultIndentSize)
	{
		CheckDestroyed();
		if (!SetDefaultIndentSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:SetDefaultIndentSize");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDefaultIndentSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDefaultIndentSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetDefaultIndentSize_InDefaultIndentSize_Offset), 0, SetDefaultIndentSize_InDefaultIndentSize_PropertyAddress.Address, InDefaultIndentSize);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDefaultIndentSize_FunctionAddress, intPtr, SetDefaultIndentSize_ParamsSize);
	}

	[UFunction(Flags = 134351880u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:OnTextPrePaint")]
	public unsafe void OnTextPrePaint()
	{
		CheckDestroyed();
		if (!OnTextPrePaint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:OnTextPrePaint");
			return;
		}
		if (OnTextPrePaint_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTextPrePaint_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTextPrePaint");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTextPrePaint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTextPrePaint_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnTextPrePaint_InstanceFunctionAddress, argsSize: OnTextPrePaint_ParamsSize);
	}

	protected unsafe virtual void OnTextPrePaint_Implementation()
	{
		CheckDestroyed();
		if (!OnTextPrePaint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:OnTextPrePaint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTextPrePaint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTextPrePaint_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnTextPrePaint_FunctionAddress, argsSize: OnTextPrePaint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:NativeCheckText")]
	public unsafe void NativeCheckText()
	{
		CheckDestroyed();
		if (!NativeCheckText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:NativeCheckText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NativeCheckText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NativeCheckText_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: NativeCheckText_FunctionAddress, argsSize: NativeCheckText_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:MakeContentDirty")]
	public unsafe void MakeContentDirty()
	{
		CheckDestroyed();
		if (!MakeContentDirty_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:MakeContentDirty");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeContentDirty_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeContentDirty_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: MakeContentDirty_FunctionAddress, argsSize: MakeContentDirty_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:GetUseIndent")]
	public unsafe bool GetUseIndent()
	{
		CheckDestroyed();
		if (!GetUseIndent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:GetUseIndent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUseIndent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUseIndent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUseIndent_FunctionAddress, intPtr, GetUseIndent_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetUseIndent_ReturnValue_Offset), 0, GetUseIndent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:GetDefaultIndentSize")]
	public unsafe float GetDefaultIndentSize()
	{
		CheckDestroyed();
		if (!GetDefaultIndentSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:GetDefaultIndentSize");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultIndentSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultIndentSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultIndentSize_FunctionAddress, intPtr, GetDefaultIndentSize_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDefaultIndentSize_ReturnValue_Offset), 0, GetDefaultIndentSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:GetContent")]
	public unsafe string GetContent()
	{
		CheckDestroyed();
		if (!GetContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:GetContent");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetContent_FunctionAddress, intPtr, GetContent_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetContent_ReturnValue_Offset), 0, GetContent_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetContent_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UnrealExtent.GSTextBlock:ApplyText")]
	public unsafe void ApplyText(FText InText)
	{
		CheckDestroyed();
		if (!ApplyText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSTextBlock:ApplyText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ApplyText_InText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ApplyText_InText_Offset), 0, ApplyText_InText_PropertyAddress.Address, InText);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyText_FunctionAddress, intPtr, ApplyText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ApplyText_InText_PropertyAddress.Address, intPtr);
	}

	static UGSTextBlock()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSTextBlock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSTextBlock));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UnrealExtent.GSTextBlock");
		NativeReflectionCached.GetPropertyRef(ref UseIndent_PropertyAddress, intPtr, "UseIndent");
		UseIndent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UseIndent");
		UseIndent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UseIndent", Classes.FBoolProperty);
		Ellipsis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Ellipsis");
		Ellipsis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Ellipsis", Classes.FStrProperty);
		DefaultIndentSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultIndentSize");
		DefaultIndentSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultIndentSize", Classes.FFloatProperty);
		Content_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Content");
		Content_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Content", Classes.FTextProperty);
		SetUseIndent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUseIndent");
		SetUseIndent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUseIndent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUseIndent_InUseIndent_PropertyAddress, SetUseIndent_FunctionAddress, "InUseIndent");
		SetUseIndent_InUseIndent_Offset = NativeReflectionCached.GetPropertyOffset(SetUseIndent_FunctionAddress, "InUseIndent");
		SetUseIndent_InUseIndent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUseIndent_FunctionAddress, "InUseIndent", Classes.FBoolProperty);
		SetUseIndent_IsValid = SetUseIndent_FunctionAddress != IntPtr.Zero && SetUseIndent_InUseIndent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:SetUseIndent", SetUseIndent_IsValid);
		SetDefaultIndentSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDefaultIndentSize");
		SetDefaultIndentSize_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDefaultIndentSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDefaultIndentSize_InDefaultIndentSize_PropertyAddress, SetDefaultIndentSize_FunctionAddress, "InDefaultIndentSize");
		SetDefaultIndentSize_InDefaultIndentSize_Offset = NativeReflectionCached.GetPropertyOffset(SetDefaultIndentSize_FunctionAddress, "InDefaultIndentSize");
		SetDefaultIndentSize_InDefaultIndentSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDefaultIndentSize_FunctionAddress, "InDefaultIndentSize", Classes.FFloatProperty);
		SetDefaultIndentSize_IsValid = SetDefaultIndentSize_FunctionAddress != IntPtr.Zero && SetDefaultIndentSize_InDefaultIndentSize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:SetDefaultIndentSize", SetDefaultIndentSize_IsValid);
		OnTextPrePaint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTextPrePaint");
		OnTextPrePaint_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTextPrePaint_FunctionAddress);
		OnTextPrePaint_IsValid = OnTextPrePaint_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:OnTextPrePaint", OnTextPrePaint_IsValid);
		NativeCheckText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NativeCheckText");
		NativeCheckText_ParamsSize = NativeReflection.GetFunctionParamsSize(NativeCheckText_FunctionAddress);
		NativeCheckText_IsValid = NativeCheckText_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:NativeCheckText", NativeCheckText_IsValid);
		MakeContentDirty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MakeContentDirty");
		MakeContentDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeContentDirty_FunctionAddress);
		MakeContentDirty_IsValid = MakeContentDirty_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:MakeContentDirty", MakeContentDirty_IsValid);
		GetUseIndent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUseIndent");
		GetUseIndent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUseIndent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUseIndent_ReturnValue_PropertyAddress, GetUseIndent_FunctionAddress, "ReturnValue");
		GetUseIndent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUseIndent_FunctionAddress, "ReturnValue");
		GetUseIndent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUseIndent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetUseIndent_IsValid = GetUseIndent_FunctionAddress != IntPtr.Zero && GetUseIndent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:GetUseIndent", GetUseIndent_IsValid);
		GetDefaultIndentSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultIndentSize");
		GetDefaultIndentSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultIndentSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultIndentSize_ReturnValue_PropertyAddress, GetDefaultIndentSize_FunctionAddress, "ReturnValue");
		GetDefaultIndentSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultIndentSize_FunctionAddress, "ReturnValue");
		GetDefaultIndentSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultIndentSize_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDefaultIndentSize_IsValid = GetDefaultIndentSize_FunctionAddress != IntPtr.Zero && GetDefaultIndentSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:GetDefaultIndentSize", GetDefaultIndentSize_IsValid);
		GetContent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetContent");
		GetContent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetContent_ReturnValue_PropertyAddress, GetContent_FunctionAddress, "ReturnValue");
		GetContent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetContent_FunctionAddress, "ReturnValue");
		GetContent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetContent_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetContent_IsValid = GetContent_FunctionAddress != IntPtr.Zero && GetContent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:GetContent", GetContent_IsValid);
		ApplyText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ApplyText");
		ApplyText_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyText_InText_PropertyAddress, ApplyText_FunctionAddress, "InText");
		ApplyText_InText_Offset = NativeReflectionCached.GetPropertyOffset(ApplyText_FunctionAddress, "InText");
		ApplyText_InText_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyText_FunctionAddress, "InText", Classes.FTextProperty);
		ApplyText_IsValid = ApplyText_FunctionAddress != IntPtr.Zero && ApplyText_InText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSTextBlock:ApplyText", ApplyText_IsValid);
	}
}
