using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;

namespace UnrealEngine.UMG;

[Abstract]
[UClass(Flags = (ClassFlags)821035169uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UMG.Widget", "UMG", UnrealModuleType.Engine)]
public class UWidget : UVisual
{
	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:OnReply__DelegateSignature")]
	public class FOnReply : FDelegate<FOnReply.Signature>
	{
		public delegate FEventReply Signature();

		private static bool OnReply__DelegateSignature_IsValid;

		private static IntPtr OnReply__DelegateSignature_FunctionAddress;

		private static int OnReply__DelegateSignature_ParamsSize;

		private static bool OnReply__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnReply__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnReply__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnReply()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnReply__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:OnReply__DelegateSignature");
			OnReply__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnReply__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnReply__DelegateSignature_ReturnValue_PropertyAddress, OnReply__DelegateSignature_FunctionAddress, "ReturnValue");
			OnReply__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnReply__DelegateSignature_FunctionAddress, "ReturnValue");
			OnReply__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnReply__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			OnReply__DelegateSignature_IsValid = OnReply__DelegateSignature_FunctionAddress != IntPtr.Zero && OnReply__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:OnReply__DelegateSignature", OnReply__DelegateSignature_IsValid);
		}

		private unsafe FEventReply Invoker()
		{
			if (!OnReply__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:OnReply__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnReply__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnReply__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnReply__DelegateSignature_ReturnValue_Offset), 0, OnReply__DelegateSignature_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(OnReply__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return null;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:OnPointerEvent__DelegateSignature")]
	public class FOnPointerEvent : FDelegate<FOnPointerEvent.Signature>
	{
		public delegate FEventReply Signature(FGeometry MyGeometry, FPointerEvent MouseEvent);

		private static bool OnPointerEvent__DelegateSignature_IsValid;

		private static IntPtr OnPointerEvent__DelegateSignature_FunctionAddress;

		private static int OnPointerEvent__DelegateSignature_ParamsSize;

		private static bool OnPointerEvent__DelegateSignature_MyGeometry_IsValid;

		private static FFieldAddress OnPointerEvent__DelegateSignature_MyGeometry_PropertyAddress;

		private static int OnPointerEvent__DelegateSignature_MyGeometry_Offset;

		private static bool OnPointerEvent__DelegateSignature_MouseEvent_IsValid;

		private static FFieldAddress OnPointerEvent__DelegateSignature_MouseEvent_PropertyAddress;

		private static int OnPointerEvent__DelegateSignature_MouseEvent_Offset;

		private static bool OnPointerEvent__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnPointerEvent__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnPointerEvent__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnPointerEvent()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnPointerEvent__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:OnPointerEvent__DelegateSignature");
			OnPointerEvent__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPointerEvent__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnPointerEvent__DelegateSignature_MyGeometry_PropertyAddress, OnPointerEvent__DelegateSignature_FunctionAddress, "MyGeometry");
			OnPointerEvent__DelegateSignature_MyGeometry_Offset = NativeReflectionCached.GetPropertyOffset(OnPointerEvent__DelegateSignature_FunctionAddress, "MyGeometry");
			OnPointerEvent__DelegateSignature_MyGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPointerEvent__DelegateSignature_FunctionAddress, "MyGeometry", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnPointerEvent__DelegateSignature_MouseEvent_PropertyAddress, OnPointerEvent__DelegateSignature_FunctionAddress, "MouseEvent");
			OnPointerEvent__DelegateSignature_MouseEvent_Offset = NativeReflectionCached.GetPropertyOffset(OnPointerEvent__DelegateSignature_FunctionAddress, "MouseEvent");
			OnPointerEvent__DelegateSignature_MouseEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPointerEvent__DelegateSignature_FunctionAddress, "MouseEvent", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnPointerEvent__DelegateSignature_ReturnValue_PropertyAddress, OnPointerEvent__DelegateSignature_FunctionAddress, "ReturnValue");
			OnPointerEvent__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnPointerEvent__DelegateSignature_FunctionAddress, "ReturnValue");
			OnPointerEvent__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnPointerEvent__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			OnPointerEvent__DelegateSignature_IsValid = OnPointerEvent__DelegateSignature_FunctionAddress != IntPtr.Zero && OnPointerEvent__DelegateSignature_MyGeometry_IsValid && OnPointerEvent__DelegateSignature_MouseEvent_IsValid && OnPointerEvent__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:OnPointerEvent__DelegateSignature", OnPointerEvent__DelegateSignature_IsValid);
		}

		private unsafe FEventReply Invoker(FGeometry MyGeometry, FPointerEvent MouseEvent)
		{
			if (!OnPointerEvent__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:OnPointerEvent__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnPointerEvent__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPointerEvent__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnPointerEvent__DelegateSignature_MyGeometry_PropertyAddress.Address, intPtr);
				StructAsClassMarshaler<FGeometry>.ToNative(IntPtr.Add(intPtr, OnPointerEvent__DelegateSignature_MyGeometry_Offset), 0, OnPointerEvent__DelegateSignature_MyGeometry_PropertyAddress.Address, MyGeometry);
				NativeReflection.InitializeValue_InContainer(OnPointerEvent__DelegateSignature_MouseEvent_PropertyAddress.Address, intPtr);
				StructAsClassMarshaler<FPointerEvent>.ToNative(IntPtr.Add(intPtr, OnPointerEvent__DelegateSignature_MouseEvent_Offset), 0, OnPointerEvent__DelegateSignature_MouseEvent_PropertyAddress.Address, MouseEvent);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnPointerEvent__DelegateSignature_MouseEvent_PropertyAddress.Address, intPtr);
				FEventReply result = StructAsClassMarshaler<FEventReply>.FromNative(IntPtr.Add(intPtr, OnPointerEvent__DelegateSignature_ReturnValue_Offset), 0, OnPointerEvent__DelegateSignature_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(OnPointerEvent__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return null;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetWidget__DelegateSignature")]
	public class FGetWidget : FDelegate<FGetWidget.Signature>
	{
		public delegate UWidget Signature();

		private static bool GetWidget__DelegateSignature_IsValid;

		private static IntPtr GetWidget__DelegateSignature_FunctionAddress;

		private static int GetWidget__DelegateSignature_ParamsSize;

		private static bool GetWidget__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetWidget__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetWidget__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetWidget()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetWidget__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetWidget__DelegateSignature");
			GetWidget__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidget__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetWidget__DelegateSignature_ReturnValue_PropertyAddress, GetWidget__DelegateSignature_FunctionAddress, "ReturnValue");
			GetWidget__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidget__DelegateSignature_FunctionAddress, "ReturnValue");
			GetWidget__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidget__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			GetWidget__DelegateSignature_IsValid = GetWidget__DelegateSignature_FunctionAddress != IntPtr.Zero && GetWidget__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetWidget__DelegateSignature", GetWidget__DelegateSignature_IsValid);
		}

		private unsafe UWidget Invoker()
		{
			if (!GetWidget__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetWidget__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetWidget__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidget__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GetWidget__DelegateSignature_ReturnValue_Offset), 0, GetWidget__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetText__DelegateSignature")]
	public class FGetText : FDelegate<FGetText.Signature>
	{
		public delegate string Signature();

		private static bool GetText__DelegateSignature_IsValid;

		private static IntPtr GetText__DelegateSignature_FunctionAddress;

		private static int GetText__DelegateSignature_ParamsSize;

		private static bool GetText__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetText__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetText__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetText()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetText__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetText__DelegateSignature");
			GetText__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetText__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetText__DelegateSignature_ReturnValue_PropertyAddress, GetText__DelegateSignature_FunctionAddress, "ReturnValue");
			GetText__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetText__DelegateSignature_FunctionAddress, "ReturnValue");
			GetText__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetText__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FTextProperty);
			GetText__DelegateSignature_IsValid = GetText__DelegateSignature_FunctionAddress != IntPtr.Zero && GetText__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetText__DelegateSignature", GetText__DelegateSignature_IsValid);
		}

		private unsafe string Invoker()
		{
			if (!GetText__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetText__DelegateSignature");
				return FStringMarshaler.DefaultString;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetText__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetText__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetText__DelegateSignature_ReturnValue_Offset), 0, GetText__DelegateSignature_ReturnValue_PropertyAddress.Address);
				string result = fText.ToString();
				NativeReflection.DestroyValue_InContainer(GetText__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return FStringMarshaler.DefaultString;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetSlateVisibility__DelegateSignature")]
	public class FGetSlateVisibility : FDelegate<FGetSlateVisibility.Signature>
	{
		public delegate ESlateVisibility Signature();

		private static bool GetSlateVisibility__DelegateSignature_IsValid;

		private static IntPtr GetSlateVisibility__DelegateSignature_FunctionAddress;

		private static int GetSlateVisibility__DelegateSignature_ParamsSize;

		private static bool GetSlateVisibility__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetSlateVisibility__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetSlateVisibility__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetSlateVisibility()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetSlateVisibility__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetSlateVisibility__DelegateSignature");
			GetSlateVisibility__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSlateVisibility__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetSlateVisibility__DelegateSignature_ReturnValue_PropertyAddress, GetSlateVisibility__DelegateSignature_FunctionAddress, "ReturnValue");
			GetSlateVisibility__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSlateVisibility__DelegateSignature_FunctionAddress, "ReturnValue");
			GetSlateVisibility__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSlateVisibility__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
			GetSlateVisibility__DelegateSignature_IsValid = GetSlateVisibility__DelegateSignature_FunctionAddress != IntPtr.Zero && GetSlateVisibility__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetSlateVisibility__DelegateSignature", GetSlateVisibility__DelegateSignature_IsValid);
		}

		private unsafe ESlateVisibility Invoker()
		{
			if (!GetSlateVisibility__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetSlateVisibility__DelegateSignature");
				return ESlateVisibility.Visible;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetSlateVisibility__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSlateVisibility__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return EnumMarshaler<ESlateVisibility>.FromNative(IntPtr.Add(intPtr, GetSlateVisibility__DelegateSignature_ReturnValue_Offset), 0, GetSlateVisibility__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return ESlateVisibility.Visible;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetSlateColor__DelegateSignature")]
	public class FGetSlateColor : FDelegate<FGetSlateColor.Signature>
	{
		public delegate FSlateColor Signature();

		private static bool GetSlateColor__DelegateSignature_IsValid;

		private static IntPtr GetSlateColor__DelegateSignature_FunctionAddress;

		private static int GetSlateColor__DelegateSignature_ParamsSize;

		private static bool GetSlateColor__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetSlateColor__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetSlateColor__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetSlateColor()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetSlateColor__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetSlateColor__DelegateSignature");
			GetSlateColor__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSlateColor__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetSlateColor__DelegateSignature_ReturnValue_PropertyAddress, GetSlateColor__DelegateSignature_FunctionAddress, "ReturnValue");
			GetSlateColor__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSlateColor__DelegateSignature_FunctionAddress, "ReturnValue");
			GetSlateColor__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSlateColor__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			GetSlateColor__DelegateSignature_IsValid = GetSlateColor__DelegateSignature_FunctionAddress != IntPtr.Zero && GetSlateColor__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetSlateColor__DelegateSignature", GetSlateColor__DelegateSignature_IsValid);
		}

		private unsafe FSlateColor Invoker()
		{
			if (!GetSlateColor__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetSlateColor__DelegateSignature");
				return default(FSlateColor);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetSlateColor__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSlateColor__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				FSlateColor result = FSlateColor.FromNative(IntPtr.Add(intPtr, GetSlateColor__DelegateSignature_ReturnValue_Offset), 0, GetSlateColor__DelegateSignature_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(GetSlateColor__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return default(FSlateColor);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetSlateBrush__DelegateSignature")]
	public class FGetSlateBrush : FDelegate<FGetSlateBrush.Signature>
	{
		public delegate FSlateBrush Signature();

		private static bool GetSlateBrush__DelegateSignature_IsValid;

		private static IntPtr GetSlateBrush__DelegateSignature_FunctionAddress;

		private static int GetSlateBrush__DelegateSignature_ParamsSize;

		private static bool GetSlateBrush__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetSlateBrush__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetSlateBrush__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetSlateBrush()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetSlateBrush__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetSlateBrush__DelegateSignature");
			GetSlateBrush__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSlateBrush__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetSlateBrush__DelegateSignature_ReturnValue_PropertyAddress, GetSlateBrush__DelegateSignature_FunctionAddress, "ReturnValue");
			GetSlateBrush__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSlateBrush__DelegateSignature_FunctionAddress, "ReturnValue");
			GetSlateBrush__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSlateBrush__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			GetSlateBrush__DelegateSignature_IsValid = GetSlateBrush__DelegateSignature_FunctionAddress != IntPtr.Zero && GetSlateBrush__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetSlateBrush__DelegateSignature", GetSlateBrush__DelegateSignature_IsValid);
		}

		private unsafe FSlateBrush Invoker()
		{
			if (!GetSlateBrush__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetSlateBrush__DelegateSignature");
				return default(FSlateBrush);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetSlateBrush__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSlateBrush__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				FSlateBrush result = FSlateBrush.FromNative(IntPtr.Add(intPtr, GetSlateBrush__DelegateSignature_ReturnValue_Offset), 0, GetSlateBrush__DelegateSignature_ReturnValue_PropertyAddress.Address);
				NativeReflection.DestroyValue_InContainer(GetSlateBrush__DelegateSignature_ReturnValue_PropertyAddress.Address, intPtr);
				return result;
			}
			return default(FSlateBrush);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetMouseCursor__DelegateSignature")]
	public class FGetMouseCursor : FDelegate<FGetMouseCursor.Signature>
	{
		public delegate EMouseCursor Signature();

		private static bool GetMouseCursor__DelegateSignature_IsValid;

		private static IntPtr GetMouseCursor__DelegateSignature_FunctionAddress;

		private static int GetMouseCursor__DelegateSignature_ParamsSize;

		private static bool GetMouseCursor__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetMouseCursor__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetMouseCursor__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetMouseCursor()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetMouseCursor__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetMouseCursor__DelegateSignature");
			GetMouseCursor__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMouseCursor__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetMouseCursor__DelegateSignature_ReturnValue_PropertyAddress, GetMouseCursor__DelegateSignature_FunctionAddress, "ReturnValue");
			GetMouseCursor__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMouseCursor__DelegateSignature_FunctionAddress, "ReturnValue");
			GetMouseCursor__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMouseCursor__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FByteProperty);
			GetMouseCursor__DelegateSignature_IsValid = GetMouseCursor__DelegateSignature_FunctionAddress != IntPtr.Zero && GetMouseCursor__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetMouseCursor__DelegateSignature", GetMouseCursor__DelegateSignature_IsValid);
		}

		private unsafe EMouseCursor Invoker()
		{
			if (!GetMouseCursor__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetMouseCursor__DelegateSignature");
				return EMouseCursor.None;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetMouseCursor__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMouseCursor__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return EnumMarshaler<EMouseCursor>.FromNative(IntPtr.Add(intPtr, GetMouseCursor__DelegateSignature_ReturnValue_Offset), 0, GetMouseCursor__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return EMouseCursor.None;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetLinearColor__DelegateSignature")]
	public class FGetLinearColor : FDelegate<FGetLinearColor.Signature>
	{
		public delegate FLinearColor Signature();

		private static bool GetLinearColor__DelegateSignature_IsValid;

		private static IntPtr GetLinearColor__DelegateSignature_FunctionAddress;

		private static int GetLinearColor__DelegateSignature_ParamsSize;

		private static bool GetLinearColor__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetLinearColor__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetLinearColor__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetLinearColor()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetLinearColor__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetLinearColor__DelegateSignature");
			GetLinearColor__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearColor__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetLinearColor__DelegateSignature_ReturnValue_PropertyAddress, GetLinearColor__DelegateSignature_FunctionAddress, "ReturnValue");
			GetLinearColor__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearColor__DelegateSignature_FunctionAddress, "ReturnValue");
			GetLinearColor__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearColor__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			GetLinearColor__DelegateSignature_IsValid = GetLinearColor__DelegateSignature_FunctionAddress != IntPtr.Zero && GetLinearColor__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetLinearColor__DelegateSignature", GetLinearColor__DelegateSignature_IsValid);
		}

		private unsafe FLinearColor Invoker()
		{
			if (!GetLinearColor__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetLinearColor__DelegateSignature");
				return default(FLinearColor);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetLinearColor__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearColor__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetLinearColor__DelegateSignature_ReturnValue_Offset), 0, GetLinearColor__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return default(FLinearColor);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetInt32__DelegateSignature")]
	public class FGetInt32 : FDelegate<FGetInt32.Signature>
	{
		public delegate int Signature();

		private static bool GetInt32__DelegateSignature_IsValid;

		private static IntPtr GetInt32__DelegateSignature_FunctionAddress;

		private static int GetInt32__DelegateSignature_ParamsSize;

		private static bool GetInt32__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetInt32__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetInt32__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetInt32()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetInt32__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetInt32__DelegateSignature");
			GetInt32__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInt32__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetInt32__DelegateSignature_ReturnValue_PropertyAddress, GetInt32__DelegateSignature_FunctionAddress, "ReturnValue");
			GetInt32__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32__DelegateSignature_FunctionAddress, "ReturnValue");
			GetInt32__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FIntProperty);
			GetInt32__DelegateSignature_IsValid = GetInt32__DelegateSignature_FunctionAddress != IntPtr.Zero && GetInt32__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetInt32__DelegateSignature", GetInt32__DelegateSignature_IsValid);
		}

		private unsafe int Invoker()
		{
			if (!GetInt32__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetInt32__DelegateSignature");
				return 0;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetInt32__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInt32__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetInt32__DelegateSignature_ReturnValue_Offset), 0, GetInt32__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return 0;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetFloat__DelegateSignature")]
	public class FGetFloat : FDelegate<FGetFloat.Signature>
	{
		public delegate float Signature();

		private static bool GetFloat__DelegateSignature_IsValid;

		private static IntPtr GetFloat__DelegateSignature_FunctionAddress;

		private static int GetFloat__DelegateSignature_ParamsSize;

		private static bool GetFloat__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetFloat__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetFloat__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetFloat()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetFloat__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetFloat__DelegateSignature");
			GetFloat__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloat__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetFloat__DelegateSignature_ReturnValue_PropertyAddress, GetFloat__DelegateSignature_FunctionAddress, "ReturnValue");
			GetFloat__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat__DelegateSignature_FunctionAddress, "ReturnValue");
			GetFloat__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
			GetFloat__DelegateSignature_IsValid = GetFloat__DelegateSignature_FunctionAddress != IntPtr.Zero && GetFloat__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetFloat__DelegateSignature", GetFloat__DelegateSignature_IsValid);
		}

		private unsafe float Invoker()
		{
			if (!GetFloat__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetFloat__DelegateSignature");
				return 0f;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetFloat__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloat__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloat__DelegateSignature_ReturnValue_Offset), 0, GetFloat__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return 0f;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetCheckBoxState__DelegateSignature")]
	public class FGetCheckBoxState : FDelegate<FGetCheckBoxState.Signature>
	{
		public delegate ECheckBoxState Signature();

		private static bool GetCheckBoxState__DelegateSignature_IsValid;

		private static IntPtr GetCheckBoxState__DelegateSignature_FunctionAddress;

		private static int GetCheckBoxState__DelegateSignature_ParamsSize;

		private static bool GetCheckBoxState__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetCheckBoxState__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetCheckBoxState__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetCheckBoxState()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetCheckBoxState__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetCheckBoxState__DelegateSignature");
			GetCheckBoxState__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCheckBoxState__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetCheckBoxState__DelegateSignature_ReturnValue_PropertyAddress, GetCheckBoxState__DelegateSignature_FunctionAddress, "ReturnValue");
			GetCheckBoxState__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCheckBoxState__DelegateSignature_FunctionAddress, "ReturnValue");
			GetCheckBoxState__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCheckBoxState__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
			GetCheckBoxState__DelegateSignature_IsValid = GetCheckBoxState__DelegateSignature_FunctionAddress != IntPtr.Zero && GetCheckBoxState__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetCheckBoxState__DelegateSignature", GetCheckBoxState__DelegateSignature_IsValid);
		}

		private unsafe ECheckBoxState Invoker()
		{
			if (!GetCheckBoxState__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetCheckBoxState__DelegateSignature");
				return ECheckBoxState.Unchecked;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetCheckBoxState__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCheckBoxState__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return EnumMarshaler<ECheckBoxState>.FromNative(IntPtr.Add(intPtr, GetCheckBoxState__DelegateSignature_ReturnValue_Offset), 0, GetCheckBoxState__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return ECheckBoxState.Unchecked;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GetBool__DelegateSignature")]
	public class FGetBool : FDelegate<FGetBool.Signature>
	{
		public delegate bool Signature();

		private static bool GetBool__DelegateSignature_IsValid;

		private static IntPtr GetBool__DelegateSignature_FunctionAddress;

		private static int GetBool__DelegateSignature_ParamsSize;

		private static bool GetBool__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GetBool__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GetBool__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGetBool()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GetBool__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GetBool__DelegateSignature");
			GetBool__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBool__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GetBool__DelegateSignature_ReturnValue_PropertyAddress, GetBool__DelegateSignature_FunctionAddress, "ReturnValue");
			GetBool__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBool__DelegateSignature_FunctionAddress, "ReturnValue");
			GetBool__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			GetBool__DelegateSignature_IsValid = GetBool__DelegateSignature_FunctionAddress != IntPtr.Zero && GetBool__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetBool__DelegateSignature", GetBool__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker()
		{
			if (!GetBool__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetBool__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GetBool__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBool__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				ProcessDelegate(intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBool__DelegateSignature_ReturnValue_Offset), 0, GetBool__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GenerateWidgetForString__DelegateSignature")]
	public class FGenerateWidgetForString : FDelegate<FGenerateWidgetForString.Signature>
	{
		public delegate UWidget Signature(string Item);

		private static bool GenerateWidgetForString__DelegateSignature_IsValid;

		private static IntPtr GenerateWidgetForString__DelegateSignature_FunctionAddress;

		private static int GenerateWidgetForString__DelegateSignature_ParamsSize;

		private static bool GenerateWidgetForString__DelegateSignature_Item_IsValid;

		private static FFieldAddress GenerateWidgetForString__DelegateSignature_Item_PropertyAddress;

		private static int GenerateWidgetForString__DelegateSignature_Item_Offset;

		private static bool GenerateWidgetForString__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GenerateWidgetForString__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GenerateWidgetForString__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGenerateWidgetForString()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GenerateWidgetForString__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GenerateWidgetForString__DelegateSignature");
			GenerateWidgetForString__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateWidgetForString__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GenerateWidgetForString__DelegateSignature_Item_PropertyAddress, GenerateWidgetForString__DelegateSignature_FunctionAddress, "Item");
			GenerateWidgetForString__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWidgetForString__DelegateSignature_FunctionAddress, "Item");
			GenerateWidgetForString__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWidgetForString__DelegateSignature_FunctionAddress, "Item", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref GenerateWidgetForString__DelegateSignature_ReturnValue_PropertyAddress, GenerateWidgetForString__DelegateSignature_FunctionAddress, "ReturnValue");
			GenerateWidgetForString__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWidgetForString__DelegateSignature_FunctionAddress, "ReturnValue");
			GenerateWidgetForString__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWidgetForString__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			GenerateWidgetForString__DelegateSignature_IsValid = GenerateWidgetForString__DelegateSignature_FunctionAddress != IntPtr.Zero && GenerateWidgetForString__DelegateSignature_Item_IsValid && GenerateWidgetForString__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GenerateWidgetForString__DelegateSignature", GenerateWidgetForString__DelegateSignature_IsValid);
		}

		private unsafe UWidget Invoker(string Item)
		{
			if (!GenerateWidgetForString__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GenerateWidgetForString__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GenerateWidgetForString__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateWidgetForString__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenerateWidgetForString__DelegateSignature_Item_Offset), 0, GenerateWidgetForString__DelegateSignature_Item_PropertyAddress.Address, Item);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(GenerateWidgetForString__DelegateSignature_Item_PropertyAddress.Address, intPtr);
				return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GenerateWidgetForString__DelegateSignature_ReturnValue_Offset), 0, GenerateWidgetForString__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/UMG.Widget:GenerateWidgetForObject__DelegateSignature")]
	public class FGenerateWidgetForObject : FDelegate<FGenerateWidgetForObject.Signature>
	{
		public delegate UWidget Signature(UObject Item);

		private static bool GenerateWidgetForObject__DelegateSignature_IsValid;

		private static IntPtr GenerateWidgetForObject__DelegateSignature_FunctionAddress;

		private static int GenerateWidgetForObject__DelegateSignature_ParamsSize;

		private static bool GenerateWidgetForObject__DelegateSignature_Item_IsValid;

		private static FFieldAddress GenerateWidgetForObject__DelegateSignature_Item_PropertyAddress;

		private static int GenerateWidgetForObject__DelegateSignature_Item_Offset;

		private static bool GenerateWidgetForObject__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress GenerateWidgetForObject__DelegateSignature_ReturnValue_PropertyAddress;

		private static int GenerateWidgetForObject__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FGenerateWidgetForObject()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			GenerateWidgetForObject__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/UMG.Widget:GenerateWidgetForObject__DelegateSignature");
			GenerateWidgetForObject__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateWidgetForObject__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref GenerateWidgetForObject__DelegateSignature_Item_PropertyAddress, GenerateWidgetForObject__DelegateSignature_FunctionAddress, "Item");
			GenerateWidgetForObject__DelegateSignature_Item_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWidgetForObject__DelegateSignature_FunctionAddress, "Item");
			GenerateWidgetForObject__DelegateSignature_Item_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWidgetForObject__DelegateSignature_FunctionAddress, "Item", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref GenerateWidgetForObject__DelegateSignature_ReturnValue_PropertyAddress, GenerateWidgetForObject__DelegateSignature_FunctionAddress, "ReturnValue");
			GenerateWidgetForObject__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GenerateWidgetForObject__DelegateSignature_FunctionAddress, "ReturnValue");
			GenerateWidgetForObject__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateWidgetForObject__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
			GenerateWidgetForObject__DelegateSignature_IsValid = GenerateWidgetForObject__DelegateSignature_FunctionAddress != IntPtr.Zero && GenerateWidgetForObject__DelegateSignature_Item_IsValid && GenerateWidgetForObject__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GenerateWidgetForObject__DelegateSignature", GenerateWidgetForObject__DelegateSignature_IsValid);
		}

		private unsafe UWidget Invoker(UObject Item)
		{
			if (!GenerateWidgetForObject__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GenerateWidgetForObject__DelegateSignature");
				return null;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(GenerateWidgetForObject__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateWidgetForObject__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GenerateWidgetForObject__DelegateSignature_Item_Offset), 0, GenerateWidgetForObject__DelegateSignature_Item_PropertyAddress.Address, Item);
				ProcessDelegate(intPtr);
				return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(intPtr, GenerateWidgetForObject__DelegateSignature_ReturnValue_Offset), 0, GenerateWidgetForObject__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return null;
		}
	}

	private static bool Slot_IsValid;

	private static int Slot_Offset;

	private static bool ToolTipText_IsValid;

	private static int ToolTipText_Offset;

	private FText ToolTipText_TextCached;

	private static bool ToolTipWidget_IsValid;

	private static int ToolTipWidget_Offset;

	private static bool RenderTransform_IsValid;

	private static int RenderTransform_Offset;

	private static bool RenderTransformPivot_IsValid;

	private static int RenderTransformPivot_Offset;

	private static bool IsEnabled_IsValid;

	private static FFieldAddress IsEnabled_PropertyAddress;

	private static int IsEnabled_Offset;

	private static bool IsVolatile_IsValid;

	private static FFieldAddress IsVolatile_PropertyAddress;

	private static int IsVolatile_Offset;

	private static bool Cursor_IsValid;

	private static FFieldAddress Cursor_PropertyAddress;

	private static int Cursor_Offset;

	private static bool Navigation_IsValid;

	private static int Navigation_Offset;

	private static bool SetVisibility_IsValid;

	private static IntPtr SetVisibility_FunctionAddress;

	private static int SetVisibility_ParamsSize;

	private static bool SetVisibility_InVisibility_IsValid;

	private static FFieldAddress SetVisibility_InVisibility_PropertyAddress;

	private static int SetVisibility_InVisibility_Offset;

	private static bool SetUserFocus_IsValid;

	private static IntPtr SetUserFocus_FunctionAddress;

	private static int SetUserFocus_ParamsSize;

	private static bool SetUserFocus_PlayerController_IsValid;

	private static FFieldAddress SetUserFocus_PlayerController_PropertyAddress;

	private static int SetUserFocus_PlayerController_Offset;

	private static bool SetToolTipText_IsValid;

	private static IntPtr SetToolTipText_FunctionAddress;

	private static int SetToolTipText_ParamsSize;

	private static bool SetToolTipText_InToolTipText_IsValid;

	private static FFieldAddress SetToolTipText_InToolTipText_PropertyAddress;

	private static int SetToolTipText_InToolTipText_Offset;

	private static bool SetToolTip_IsValid;

	private static IntPtr SetToolTip_FunctionAddress;

	private static int SetToolTip_ParamsSize;

	private static bool SetToolTip_Widget_IsValid;

	private static FFieldAddress SetToolTip_Widget_PropertyAddress;

	private static int SetToolTip_Widget_Offset;

	private static bool SetRenderTranslation_IsValid;

	private static IntPtr SetRenderTranslation_FunctionAddress;

	private static int SetRenderTranslation_ParamsSize;

	private static bool SetRenderTranslation_Translation_IsValid;

	private static FFieldAddress SetRenderTranslation_Translation_PropertyAddress;

	private static int SetRenderTranslation_Translation_Offset;

	private static bool SetRenderTransformPivot_IsValid;

	private static IntPtr SetRenderTransformPivot_FunctionAddress;

	private static int SetRenderTransformPivot_ParamsSize;

	private static bool SetRenderTransformPivot_Pivot_IsValid;

	private static FFieldAddress SetRenderTransformPivot_Pivot_PropertyAddress;

	private static int SetRenderTransformPivot_Pivot_Offset;

	private static bool SetRenderTransformAngle_IsValid;

	private static IntPtr SetRenderTransformAngle_FunctionAddress;

	private static int SetRenderTransformAngle_ParamsSize;

	private static bool SetRenderTransformAngle_Angle_IsValid;

	private static FFieldAddress SetRenderTransformAngle_Angle_PropertyAddress;

	private static int SetRenderTransformAngle_Angle_Offset;

	private static bool SetRenderTransform_IsValid;

	private static IntPtr SetRenderTransform_FunctionAddress;

	private static int SetRenderTransform_ParamsSize;

	private static bool SetRenderTransform_InTransform_IsValid;

	private static FFieldAddress SetRenderTransform_InTransform_PropertyAddress;

	private static int SetRenderTransform_InTransform_Offset;

	private static bool SetRenderShear_IsValid;

	private static IntPtr SetRenderShear_FunctionAddress;

	private static int SetRenderShear_ParamsSize;

	private static bool SetRenderShear_Shear_IsValid;

	private static FFieldAddress SetRenderShear_Shear_PropertyAddress;

	private static int SetRenderShear_Shear_Offset;

	private static bool SetRenderScale_IsValid;

	private static IntPtr SetRenderScale_FunctionAddress;

	private static int SetRenderScale_ParamsSize;

	private static bool SetRenderScale_Scale_IsValid;

	private static FFieldAddress SetRenderScale_Scale_PropertyAddress;

	private static int SetRenderScale_Scale_Offset;

	private static bool SetRenderOpacity_IsValid;

	private static IntPtr SetRenderOpacity_FunctionAddress;

	private static int SetRenderOpacity_ParamsSize;

	private static bool SetRenderOpacity_InOpacity_IsValid;

	private static FFieldAddress SetRenderOpacity_InOpacity_PropertyAddress;

	private static int SetRenderOpacity_InOpacity_Offset;

	private static bool SetPixelSnappingMethod_IsValid;

	private static IntPtr SetPixelSnappingMethod_FunctionAddress;

	private static int SetPixelSnappingMethod_ParamsSize;

	private static bool SetPixelSnappingMethod_InPixelSnappingMethod_IsValid;

	private static FFieldAddress SetPixelSnappingMethod_InPixelSnappingMethod_PropertyAddress;

	private static int SetPixelSnappingMethod_InPixelSnappingMethod_Offset;

	private static bool SetNavigationRuleExplicit_IsValid;

	private static IntPtr SetNavigationRuleExplicit_FunctionAddress;

	private static int SetNavigationRuleExplicit_ParamsSize;

	private static bool SetNavigationRuleExplicit_Direction_IsValid;

	private static FFieldAddress SetNavigationRuleExplicit_Direction_PropertyAddress;

	private static int SetNavigationRuleExplicit_Direction_Offset;

	private static bool SetNavigationRuleExplicit_InWidget_IsValid;

	private static FFieldAddress SetNavigationRuleExplicit_InWidget_PropertyAddress;

	private static int SetNavigationRuleExplicit_InWidget_Offset;

	private static bool SetNavigationRuleCustomBoundary_IsValid;

	private static IntPtr SetNavigationRuleCustomBoundary_FunctionAddress;

	private static int SetNavigationRuleCustomBoundary_ParamsSize;

	private static bool SetNavigationRuleCustomBoundary_Direction_IsValid;

	private static FFieldAddress SetNavigationRuleCustomBoundary_Direction_PropertyAddress;

	private static int SetNavigationRuleCustomBoundary_Direction_Offset;

	private static bool SetNavigationRuleCustomBoundary_InCustomDelegate_IsValid;

	private static FFieldAddress SetNavigationRuleCustomBoundary_InCustomDelegate_PropertyAddress;

	private static int SetNavigationRuleCustomBoundary_InCustomDelegate_Offset;

	private static bool SetNavigationRuleCustom_IsValid;

	private static IntPtr SetNavigationRuleCustom_FunctionAddress;

	private static int SetNavigationRuleCustom_ParamsSize;

	private static bool SetNavigationRuleCustom_Direction_IsValid;

	private static FFieldAddress SetNavigationRuleCustom_Direction_PropertyAddress;

	private static int SetNavigationRuleCustom_Direction_Offset;

	private static bool SetNavigationRuleCustom_InCustomDelegate_IsValid;

	private static FFieldAddress SetNavigationRuleCustom_InCustomDelegate_PropertyAddress;

	private static int SetNavigationRuleCustom_InCustomDelegate_Offset;

	private static bool SetNavigationRuleBase_IsValid;

	private static IntPtr SetNavigationRuleBase_FunctionAddress;

	private static int SetNavigationRuleBase_ParamsSize;

	private static bool SetNavigationRuleBase_Direction_IsValid;

	private static FFieldAddress SetNavigationRuleBase_Direction_PropertyAddress;

	private static int SetNavigationRuleBase_Direction_Offset;

	private static bool SetNavigationRuleBase_Rule_IsValid;

	private static FFieldAddress SetNavigationRuleBase_Rule_PropertyAddress;

	private static int SetNavigationRuleBase_Rule_Offset;

	private static bool SetNavigationRule_IsValid;

	private static IntPtr SetNavigationRule_FunctionAddress;

	private static int SetNavigationRule_ParamsSize;

	private static bool SetNavigationRule_Direction_IsValid;

	private static FFieldAddress SetNavigationRule_Direction_PropertyAddress;

	private static int SetNavigationRule_Direction_Offset;

	private static bool SetNavigationRule_Rule_IsValid;

	private static FFieldAddress SetNavigationRule_Rule_PropertyAddress;

	private static int SetNavigationRule_Rule_Offset;

	private static bool SetNavigationRule_WidgetToFocus_IsValid;

	private static FFieldAddress SetNavigationRule_WidgetToFocus_PropertyAddress;

	private static int SetNavigationRule_WidgetToFocus_Offset;

	private static bool SetKeyboardFocus_IsValid;

	private static IntPtr SetKeyboardFocus_FunctionAddress;

	private static int SetKeyboardFocus_ParamsSize;

	private static bool SetIsEnabled_IsValid;

	private static IntPtr SetIsEnabled_FunctionAddress;

	private static int SetIsEnabled_ParamsSize;

	private static bool SetIsEnabled_bInIsEnabled_IsValid;

	private static FFieldAddress SetIsEnabled_bInIsEnabled_PropertyAddress;

	private static int SetIsEnabled_bInIsEnabled_Offset;

	private static bool SetFocus_IsValid;

	private static IntPtr SetFocus_FunctionAddress;

	private static int SetFocus_ParamsSize;

	private static bool SetCursor_IsValid;

	private static IntPtr SetCursor_FunctionAddress;

	private static int SetCursor_ParamsSize;

	private static bool SetCursor_InCursor_IsValid;

	private static FFieldAddress SetCursor_InCursor_PropertyAddress;

	private static int SetCursor_InCursor_Offset;

	private static bool SetClipping_IsValid;

	private static IntPtr SetClipping_FunctionAddress;

	private static int SetClipping_ParamsSize;

	private static bool SetClipping_InClipping_IsValid;

	private static FFieldAddress SetClipping_InClipping_PropertyAddress;

	private static int SetClipping_InClipping_Offset;

	private static bool SetAllNavigationRules_IsValid;

	private static IntPtr SetAllNavigationRules_FunctionAddress;

	private static int SetAllNavigationRules_ParamsSize;

	private static bool SetAllNavigationRules_Rule_IsValid;

	private static FFieldAddress SetAllNavigationRules_Rule_PropertyAddress;

	private static int SetAllNavigationRules_Rule_Offset;

	private static bool SetAllNavigationRules_WidgetToFocus_IsValid;

	private static FFieldAddress SetAllNavigationRules_WidgetToFocus_PropertyAddress;

	private static int SetAllNavigationRules_WidgetToFocus_Offset;

	private static bool ResetCursor_IsValid;

	private static IntPtr ResetCursor_FunctionAddress;

	private static int ResetCursor_ParamsSize;

	private static bool RemoveFromParent_IsValid;

	private static IntPtr RemoveFromParent_FunctionAddress;

	private static int RemoveFromParent_ParamsSize;

	private static bool IsVisible_IsValid;

	private static IntPtr IsVisible_FunctionAddress;

	private static int IsVisible_ParamsSize;

	private static bool IsVisible_ReturnValue_IsValid;

	private static FFieldAddress IsVisible_ReturnValue_PropertyAddress;

	private static int IsVisible_ReturnValue_Offset;

	private static bool IsHovered_IsValid;

	private static IntPtr IsHovered_FunctionAddress;

	private static int IsHovered_ParamsSize;

	private static bool IsHovered_ReturnValue_IsValid;

	private static FFieldAddress IsHovered_ReturnValue_PropertyAddress;

	private static int IsHovered_ReturnValue_Offset;

	private static bool InvalidateLayoutAndVolatility_IsValid;

	private static IntPtr InvalidateLayoutAndVolatility_FunctionAddress;

	private static int InvalidateLayoutAndVolatility_ParamsSize;

	private static bool HasUserFocusedDescendants_IsValid;

	private static IntPtr HasUserFocusedDescendants_FunctionAddress;

	private static int HasUserFocusedDescendants_ParamsSize;

	private static bool HasUserFocusedDescendants_PlayerController_IsValid;

	private static FFieldAddress HasUserFocusedDescendants_PlayerController_PropertyAddress;

	private static int HasUserFocusedDescendants_PlayerController_Offset;

	private static bool HasUserFocusedDescendants_ReturnValue_IsValid;

	private static FFieldAddress HasUserFocusedDescendants_ReturnValue_PropertyAddress;

	private static int HasUserFocusedDescendants_ReturnValue_Offset;

	private static bool HasUserFocus_IsValid;

	private static IntPtr HasUserFocus_FunctionAddress;

	private static int HasUserFocus_ParamsSize;

	private static bool HasUserFocus_PlayerController_IsValid;

	private static FFieldAddress HasUserFocus_PlayerController_PropertyAddress;

	private static int HasUserFocus_PlayerController_Offset;

	private static bool HasUserFocus_ReturnValue_IsValid;

	private static FFieldAddress HasUserFocus_ReturnValue_PropertyAddress;

	private static int HasUserFocus_ReturnValue_Offset;

	private static bool HasMouseCaptureByUser_IsValid;

	private static IntPtr HasMouseCaptureByUser_FunctionAddress;

	private static int HasMouseCaptureByUser_ParamsSize;

	private static bool HasMouseCaptureByUser_UserIndex_IsValid;

	private static FFieldAddress HasMouseCaptureByUser_UserIndex_PropertyAddress;

	private static int HasMouseCaptureByUser_UserIndex_Offset;

	private static bool HasMouseCaptureByUser_PointerIndex_IsValid;

	private static FFieldAddress HasMouseCaptureByUser_PointerIndex_PropertyAddress;

	private static int HasMouseCaptureByUser_PointerIndex_Offset;

	private static bool HasMouseCaptureByUser_ReturnValue_IsValid;

	private static FFieldAddress HasMouseCaptureByUser_ReturnValue_PropertyAddress;

	private static int HasMouseCaptureByUser_ReturnValue_Offset;

	private static bool HasMouseCapture_IsValid;

	private static IntPtr HasMouseCapture_FunctionAddress;

	private static int HasMouseCapture_ParamsSize;

	private static bool HasMouseCapture_ReturnValue_IsValid;

	private static FFieldAddress HasMouseCapture_ReturnValue_PropertyAddress;

	private static int HasMouseCapture_ReturnValue_Offset;

	private static bool HasKeyboardFocus_IsValid;

	private static IntPtr HasKeyboardFocus_FunctionAddress;

	private static int HasKeyboardFocus_ParamsSize;

	private static bool HasKeyboardFocus_ReturnValue_IsValid;

	private static FFieldAddress HasKeyboardFocus_ReturnValue_PropertyAddress;

	private static int HasKeyboardFocus_ReturnValue_Offset;

	private static bool HasFocusedDescendants_IsValid;

	private static IntPtr HasFocusedDescendants_FunctionAddress;

	private static int HasFocusedDescendants_ParamsSize;

	private static bool HasFocusedDescendants_ReturnValue_IsValid;

	private static FFieldAddress HasFocusedDescendants_ReturnValue_PropertyAddress;

	private static int HasFocusedDescendants_ReturnValue_Offset;

	private static bool HasAnyUserFocus_IsValid;

	private static IntPtr HasAnyUserFocus_FunctionAddress;

	private static int HasAnyUserFocus_ParamsSize;

	private static bool HasAnyUserFocus_ReturnValue_IsValid;

	private static FFieldAddress HasAnyUserFocus_ReturnValue_PropertyAddress;

	private static int HasAnyUserFocus_ReturnValue_Offset;

	private static bool GetVisibility_IsValid;

	private static IntPtr GetVisibility_FunctionAddress;

	private static int GetVisibility_ParamsSize;

	private static bool GetVisibility_ReturnValue_IsValid;

	private static FFieldAddress GetVisibility_ReturnValue_PropertyAddress;

	private static int GetVisibility_ReturnValue_Offset;

	private static bool GetTickSpaceGeometry_IsValid;

	private static IntPtr GetTickSpaceGeometry_FunctionAddress;

	private static int GetTickSpaceGeometry_ParamsSize;

	private static bool GetTickSpaceGeometry_ReturnValue_IsValid;

	private static FFieldAddress GetTickSpaceGeometry_ReturnValue_PropertyAddress;

	private static int GetTickSpaceGeometry_ReturnValue_Offset;

	private static bool GetRenderTransformAngle_IsValid;

	private static IntPtr GetRenderTransformAngle_FunctionAddress;

	private static int GetRenderTransformAngle_ParamsSize;

	private static bool GetRenderTransformAngle_ReturnValue_IsValid;

	private static FFieldAddress GetRenderTransformAngle_ReturnValue_PropertyAddress;

	private static int GetRenderTransformAngle_ReturnValue_Offset;

	private static bool GetRenderOpacity_IsValid;

	private static IntPtr GetRenderOpacity_FunctionAddress;

	private static int GetRenderOpacity_ParamsSize;

	private static bool GetRenderOpacity_ReturnValue_IsValid;

	private static FFieldAddress GetRenderOpacity_ReturnValue_PropertyAddress;

	private static int GetRenderOpacity_ReturnValue_Offset;

	private static bool GetPixelSnappingMethod_IsValid;

	private static IntPtr GetPixelSnappingMethod_FunctionAddress;

	private static int GetPixelSnappingMethod_ParamsSize;

	private static bool GetPixelSnappingMethod_ReturnValue_IsValid;

	private static FFieldAddress GetPixelSnappingMethod_ReturnValue_PropertyAddress;

	private static int GetPixelSnappingMethod_ReturnValue_Offset;

	private static bool GetParent_IsValid;

	private static IntPtr GetParent_FunctionAddress;

	private static int GetParent_ParamsSize;

	private static bool GetParent_ReturnValue_IsValid;

	private static FFieldAddress GetParent_ReturnValue_PropertyAddress;

	private static int GetParent_ReturnValue_Offset;

	private static bool GetPaintSpaceGeometry_IsValid;

	private static IntPtr GetPaintSpaceGeometry_FunctionAddress;

	private static int GetPaintSpaceGeometry_ParamsSize;

	private static bool GetPaintSpaceGeometry_ReturnValue_IsValid;

	private static FFieldAddress GetPaintSpaceGeometry_ReturnValue_PropertyAddress;

	private static int GetPaintSpaceGeometry_ReturnValue_Offset;

	private static bool GetOwningPlayer_IsValid;

	private static IntPtr GetOwningPlayer_FunctionAddress;

	private static int GetOwningPlayer_ParamsSize;

	private static bool GetOwningPlayer_ReturnValue_IsValid;

	private static FFieldAddress GetOwningPlayer_ReturnValue_PropertyAddress;

	private static int GetOwningPlayer_ReturnValue_Offset;

	private static bool GetOwningLocalPlayer_IsValid;

	private static IntPtr GetOwningLocalPlayer_FunctionAddress;

	private static int GetOwningLocalPlayer_ParamsSize;

	private static bool GetOwningLocalPlayer_ReturnValue_IsValid;

	private static FFieldAddress GetOwningLocalPlayer_ReturnValue_PropertyAddress;

	private static int GetOwningLocalPlayer_ReturnValue_Offset;

	private static bool GetIsEnabled_IsValid;

	private static IntPtr GetIsEnabled_FunctionAddress;

	private static int GetIsEnabled_ParamsSize;

	private static bool GetIsEnabled_ReturnValue_IsValid;

	private static FFieldAddress GetIsEnabled_ReturnValue_PropertyAddress;

	private static int GetIsEnabled_ReturnValue_Offset;

	private static bool GetGameInstance_IsValid;

	private static IntPtr GetGameInstance_FunctionAddress;

	private static int GetGameInstance_ParamsSize;

	private static bool GetGameInstance_ReturnValue_IsValid;

	private static FFieldAddress GetGameInstance_ReturnValue_PropertyAddress;

	private static int GetGameInstance_ReturnValue_Offset;

	private static bool GetDesiredSize_IsValid;

	private static IntPtr GetDesiredSize_FunctionAddress;

	private static int GetDesiredSize_ParamsSize;

	private static bool GetDesiredSize_ReturnValue_IsValid;

	private static FFieldAddress GetDesiredSize_ReturnValue_PropertyAddress;

	private static int GetDesiredSize_ReturnValue_Offset;

	private static bool GetClipping_IsValid;

	private static IntPtr GetClipping_FunctionAddress;

	private static int GetClipping_ParamsSize;

	private static bool GetClipping_ReturnValue_IsValid;

	private static FFieldAddress GetClipping_ReturnValue_PropertyAddress;

	private static int GetClipping_ReturnValue_Offset;

	private static bool GetCachedGeometry_IsValid;

	private static IntPtr GetCachedGeometry_FunctionAddress;

	private static int GetCachedGeometry_ParamsSize;

	private static bool GetCachedGeometry_ReturnValue_IsValid;

	private static FFieldAddress GetCachedGeometry_ReturnValue_PropertyAddress;

	private static int GetCachedGeometry_ReturnValue_Offset;

	private static bool GetAccessibleText_IsValid;

	private static IntPtr GetAccessibleText_FunctionAddress;

	private static int GetAccessibleText_ParamsSize;

	private static bool GetAccessibleText_ReturnValue_IsValid;

	private static FFieldAddress GetAccessibleText_ReturnValue_PropertyAddress;

	private static int GetAccessibleText_ReturnValue_Offset;

	private static bool GetAccessibleSummaryText_IsValid;

	private static IntPtr GetAccessibleSummaryText_FunctionAddress;

	private static int GetAccessibleSummaryText_ParamsSize;

	private static bool GetAccessibleSummaryText_ReturnValue_IsValid;

	private static FFieldAddress GetAccessibleSummaryText_ReturnValue_PropertyAddress;

	private static int GetAccessibleSummaryText_ReturnValue_Offset;

	private static bool ForceVolatile_IsValid;

	private static IntPtr ForceVolatile_FunctionAddress;

	private static int ForceVolatile_ParamsSize;

	private static bool ForceVolatile_bForce_IsValid;

	private static FFieldAddress ForceVolatile_bForce_PropertyAddress;

	private static int ForceVolatile_bForce_Offset;

	private static bool ForceLayoutPrepass_IsValid;

	private static IntPtr ForceLayoutPrepass_FunctionAddress;

	private static int ForceLayoutPrepass_ParamsSize;

	[UProperty(Flags = (PropFlags)8514687839240733uL)]
	[UMetaPath("/Script/UMG.Widget:Slot")]
	public UPanelSlot Slot
	{
		get
		{
			CheckDestroyed();
			if (!Slot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:Slot");
				return null;
			}
			return UObjectMarshaler<UPanelSlot>.FromNative(IntPtr.Add(base.Address, Slot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Slot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:Slot");
			}
			else
			{
				UObjectMarshaler<UPanelSlot>.ToNative(IntPtr.Add(base.Address, Slot_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/UMG.Widget:ToolTipText")]
	public FText ToolTipText
	{
		get
		{
			CheckDestroyed();
			if (!ToolTipText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:ToolTipText");
				return null;
			}
			if (ToolTipText_TextCached == null)
			{
				ToolTipText_TextCached = new FText(IntPtr.Add(base.Address, ToolTipText_Offset), createReference: false);
			}
			return ToolTipText_TextCached;
		}
		set
		{
			CheckDestroyed();
			if (!ToolTipText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:ToolTipText");
				return;
			}
			if (ToolTipText_TextCached == null)
			{
				ToolTipText_TextCached = new FText(IntPtr.Add(base.Address, ToolTipText_Offset), createReference: false);
			}
			ToolTipText_TextCached.CopyFrom(value);
		}
	}

	[UProperty(Flags = (PropFlags)7885767188283933uL)]
	[UMetaPath("/Script/UMG.Widget:ToolTipWidget")]
	public UWidget ToolTipWidget
	{
		get
		{
			CheckDestroyed();
			if (!ToolTipWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:ToolTipWidget");
				return null;
			}
			return UObjectMarshaler<UWidget>.FromNative(IntPtr.Add(base.Address, ToolTipWidget_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ToolTipWidget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:ToolTipWidget");
			}
			else
			{
				UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(base.Address, ToolTipWidget_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847253uL)]
	[UMetaPath("/Script/UMG.Widget:RenderTransform")]
	public FWidgetTransform RenderTransform
	{
		get
		{
			CheckDestroyed();
			if (!RenderTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:RenderTransform");
				return default(FWidgetTransform);
			}
			return FWidgetTransform.FromNative(IntPtr.Add(base.Address, RenderTransform_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderTransform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:RenderTransform");
			}
			else
			{
				FWidgetTransform.ToNative(IntPtr.Add(base.Address, RenderTransform_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/UMG.Widget:RenderTransformPivot")]
	public FVector2D RenderTransformPivot
	{
		get
		{
			CheckDestroyed();
			if (!RenderTransformPivot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:RenderTransformPivot");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, RenderTransformPivot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RenderTransformPivot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:RenderTransformPivot");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, RenderTransformPivot_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/UMG.Widget:bIsEnabled")]
	public bool IsEnabled
	{
		get
		{
			CheckDestroyed();
			if (!IsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:bIsEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsEnabled_Offset), 0, IsEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:bIsEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsEnabled_Offset), 0, IsEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267863880925205uL)]
	[UMetaPath("/Script/UMG.Widget:bIsVolatile")]
	protected bool IsVolatile
	{
		get
		{
			CheckDestroyed();
			if (!IsVolatile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:bIsVolatile");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsVolatile_Offset), 0, IsVolatile_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsVolatile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:bIsVolatile");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsVolatile_Offset), 0, IsVolatile_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785941uL)]
	[UMetaPath("/Script/UMG.Widget:Cursor")]
	public EMouseCursor Cursor
	{
		get
		{
			CheckDestroyed();
			if (!Cursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:Cursor");
				return EMouseCursor.None;
			}
			return EnumMarshaler<EMouseCursor>.FromNative(IntPtr.Add(base.Address, Cursor_Offset), 0, Cursor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Cursor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:Cursor");
			}
			else
			{
				EnumMarshaler<EMouseCursor>.ToNative(IntPtr.Add(base.Address, Cursor_Offset), 0, Cursor_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)8444319095063069uL)]
	[UMetaPath("/Script/UMG.Widget:Navigation")]
	public UWidgetNavigation Navigation
	{
		get
		{
			CheckDestroyed();
			if (!Navigation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:Navigation");
				return null;
			}
			return UObjectMarshaler<UWidgetNavigation>.FromNative(IntPtr.Add(base.Address, Navigation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Navigation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UMG.Widget:Navigation");
			}
			else
			{
				UObjectMarshaler<UWidgetNavigation>.ToNative(IntPtr.Add(base.Address, Navigation_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Widget:SetVisibility")]
	public unsafe void SetVisibility(ESlateVisibility InVisibility)
	{
		CheckDestroyed();
		if (!SetVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESlateVisibility>.ToNative(IntPtr.Add(intPtr, SetVisibility_InVisibility_Offset), 0, SetVisibility_InVisibility_PropertyAddress.Address, InVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVisibility_FunctionAddress, intPtr, SetVisibility_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetUserFocus")]
	public unsafe void SetUserFocus(APlayerController PlayerController)
	{
		CheckDestroyed();
		if (!SetUserFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetUserFocus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUserFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUserFocus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, SetUserFocus_PlayerController_Offset), 0, SetUserFocus_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUserFocus_FunctionAddress, intPtr, SetUserFocus_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/UMG.Widget:SetToolTipText")]
	public unsafe void SetToolTipText(FText InToolTipText)
	{
		CheckDestroyed();
		if (!SetToolTipText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetToolTipText");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetToolTipText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetToolTipText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetToolTipText_InToolTipText_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetToolTipText_InToolTipText_Offset), 0, SetToolTipText_InToolTipText_PropertyAddress.Address, InToolTipText);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetToolTipText_FunctionAddress, intPtr, SetToolTipText_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetToolTipText_InToolTipText_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetToolTip")]
	public unsafe void SetToolTip(UWidget Widget)
	{
		CheckDestroyed();
		if (!SetToolTip_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetToolTip");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetToolTip_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetToolTip_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetToolTip_Widget_Offset), 0, SetToolTip_Widget_PropertyAddress.Address, Widget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetToolTip_FunctionAddress, intPtr, SetToolTip_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Widget:SetRenderTranslation")]
	public unsafe void SetRenderTranslation(FVector2D Translation)
	{
		CheckDestroyed();
		if (!SetRenderTranslation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetRenderTranslation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderTranslation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderTranslation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetRenderTranslation_Translation_Offset), 0, SetRenderTranslation_Translation_PropertyAddress.Address, Translation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderTranslation_FunctionAddress, intPtr, SetRenderTranslation_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Widget:SetRenderTransformPivot")]
	public unsafe void SetRenderTransformPivot(FVector2D Pivot)
	{
		CheckDestroyed();
		if (!SetRenderTransformPivot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetRenderTransformPivot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderTransformPivot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderTransformPivot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetRenderTransformPivot_Pivot_Offset), 0, SetRenderTransformPivot_Pivot_PropertyAddress.Address, Pivot);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderTransformPivot_FunctionAddress, intPtr, SetRenderTransformPivot_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetRenderTransformAngle")]
	public unsafe void SetRenderTransformAngle(float Angle)
	{
		CheckDestroyed();
		if (!SetRenderTransformAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetRenderTransformAngle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderTransformAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderTransformAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRenderTransformAngle_Angle_Offset), 0, SetRenderTransformAngle_Angle_PropertyAddress.Address, Angle);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderTransformAngle_FunctionAddress, intPtr, SetRenderTransformAngle_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetRenderTransform")]
	public unsafe void SetRenderTransform(FWidgetTransform InTransform)
	{
		CheckDestroyed();
		if (!SetRenderTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetRenderTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRenderTransform_InTransform_PropertyAddress.Address, intPtr);
		FWidgetTransform.ToNative(IntPtr.Add(intPtr, SetRenderTransform_InTransform_Offset), 0, SetRenderTransform_InTransform_PropertyAddress.Address, InTransform);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderTransform_FunctionAddress, intPtr, SetRenderTransform_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Widget:SetRenderShear")]
	public unsafe void SetRenderShear(FVector2D Shear)
	{
		CheckDestroyed();
		if (!SetRenderShear_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetRenderShear");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderShear_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderShear_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetRenderShear_Shear_Offset), 0, SetRenderShear_Shear_PropertyAddress.Address, Shear);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderShear_FunctionAddress, intPtr, SetRenderShear_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/UMG.Widget:SetRenderScale")]
	public unsafe void SetRenderScale(FVector2D Scale)
	{
		CheckDestroyed();
		if (!SetRenderScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetRenderScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetRenderScale_Scale_Offset), 0, SetRenderScale_Scale_PropertyAddress.Address, Scale);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderScale_FunctionAddress, intPtr, SetRenderScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetRenderOpacity")]
	public unsafe void SetRenderOpacity(float InOpacity)
	{
		CheckDestroyed();
		if (!SetRenderOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetRenderOpacity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRenderOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRenderOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetRenderOpacity_InOpacity_Offset), 0, SetRenderOpacity_InOpacity_PropertyAddress.Address, InOpacity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRenderOpacity_FunctionAddress, intPtr, SetRenderOpacity_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetPixelSnappingMethod")]
	public unsafe void SetPixelSnappingMethod(EPixelSnappingMethod InPixelSnappingMethod)
	{
		CheckDestroyed();
		if (!SetPixelSnappingMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetPixelSnappingMethod");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPixelSnappingMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPixelSnappingMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EPixelSnappingMethod>.ToNative(IntPtr.Add(intPtr, SetPixelSnappingMethod_InPixelSnappingMethod_Offset), 0, SetPixelSnappingMethod_InPixelSnappingMethod_PropertyAddress.Address, InPixelSnappingMethod);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPixelSnappingMethod_FunctionAddress, intPtr, SetPixelSnappingMethod_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetNavigationRuleExplicit")]
	public unsafe void SetNavigationRuleExplicit(EUINavigation Direction, UWidget InWidget)
	{
		CheckDestroyed();
		if (!SetNavigationRuleExplicit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetNavigationRuleExplicit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavigationRuleExplicit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavigationRuleExplicit_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigation>.ToNative(IntPtr.Add(intPtr, SetNavigationRuleExplicit_Direction_Offset), 0, SetNavigationRuleExplicit_Direction_PropertyAddress.Address, Direction);
		UObjectMarshaler<UWidget>.ToNative(IntPtr.Add(intPtr, SetNavigationRuleExplicit_InWidget_Offset), 0, SetNavigationRuleExplicit_InWidget_PropertyAddress.Address, InWidget);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavigationRuleExplicit_FunctionAddress, intPtr, SetNavigationRuleExplicit_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetNavigationRuleCustomBoundary")]
	public unsafe void SetNavigationRuleCustomBoundary(EUINavigation Direction, FCustomWidgetNavigationDelegate InCustomDelegate)
	{
		CheckDestroyed();
		if (!SetNavigationRuleCustomBoundary_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetNavigationRuleCustomBoundary");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavigationRuleCustomBoundary_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavigationRuleCustomBoundary_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigation>.ToNative(IntPtr.Add(intPtr, SetNavigationRuleCustomBoundary_Direction_Offset), 0, SetNavigationRuleCustomBoundary_Direction_PropertyAddress.Address, Direction);
		FDelegateMarshaler<FCustomWidgetNavigationDelegate>.ToNative(IntPtr.Add(intPtr, SetNavigationRuleCustomBoundary_InCustomDelegate_Offset), 0, SetNavigationRuleCustomBoundary_InCustomDelegate_PropertyAddress.Address, InCustomDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavigationRuleCustomBoundary_FunctionAddress, intPtr, SetNavigationRuleCustomBoundary_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetNavigationRuleCustom")]
	public unsafe void SetNavigationRuleCustom(EUINavigation Direction, FCustomWidgetNavigationDelegate InCustomDelegate)
	{
		CheckDestroyed();
		if (!SetNavigationRuleCustom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetNavigationRuleCustom");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavigationRuleCustom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavigationRuleCustom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigation>.ToNative(IntPtr.Add(intPtr, SetNavigationRuleCustom_Direction_Offset), 0, SetNavigationRuleCustom_Direction_PropertyAddress.Address, Direction);
		FDelegateMarshaler<FCustomWidgetNavigationDelegate>.ToNative(IntPtr.Add(intPtr, SetNavigationRuleCustom_InCustomDelegate_Offset), 0, SetNavigationRuleCustom_InCustomDelegate_PropertyAddress.Address, InCustomDelegate);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavigationRuleCustom_FunctionAddress, intPtr, SetNavigationRuleCustom_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetNavigationRuleBase")]
	public unsafe void SetNavigationRuleBase(EUINavigation Direction, EUINavigationRule Rule)
	{
		CheckDestroyed();
		if (!SetNavigationRuleBase_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetNavigationRuleBase");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavigationRuleBase_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavigationRuleBase_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigation>.ToNative(IntPtr.Add(intPtr, SetNavigationRuleBase_Direction_Offset), 0, SetNavigationRuleBase_Direction_PropertyAddress.Address, Direction);
		EnumMarshaler<EUINavigationRule>.ToNative(IntPtr.Add(intPtr, SetNavigationRuleBase_Rule_Offset), 0, SetNavigationRuleBase_Rule_PropertyAddress.Address, Rule);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavigationRuleBase_FunctionAddress, intPtr, SetNavigationRuleBase_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetNavigationRule")]
	public unsafe void SetNavigationRule(EUINavigation Direction, EUINavigationRule Rule, FName WidgetToFocus)
	{
		CheckDestroyed();
		if (!SetNavigationRule_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetNavigationRule");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNavigationRule_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNavigationRule_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigation>.ToNative(IntPtr.Add(intPtr, SetNavigationRule_Direction_Offset), 0, SetNavigationRule_Direction_PropertyAddress.Address, Direction);
		EnumMarshaler<EUINavigationRule>.ToNative(IntPtr.Add(intPtr, SetNavigationRule_Rule_Offset), 0, SetNavigationRule_Rule_PropertyAddress.Address, Rule);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetNavigationRule_WidgetToFocus_Offset), 0, SetNavigationRule_WidgetToFocus_PropertyAddress.Address, WidgetToFocus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetNavigationRule_FunctionAddress, intPtr, SetNavigationRule_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetKeyboardFocus")]
	public unsafe void SetKeyboardFocus()
	{
		CheckDestroyed();
		if (!SetKeyboardFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetKeyboardFocus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetKeyboardFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetKeyboardFocus_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetKeyboardFocus_FunctionAddress, argsSize: SetKeyboardFocus_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Widget:SetIsEnabled")]
	public unsafe void SetIsEnabled(bool bInIsEnabled)
	{
		CheckDestroyed();
		if (!SetIsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetIsEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIsEnabled_bInIsEnabled_Offset), 0, SetIsEnabled_bInIsEnabled_PropertyAddress.Address, bInIsEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetIsEnabled_FunctionAddress, intPtr, SetIsEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetFocus")]
	public unsafe void SetFocus()
	{
		CheckDestroyed();
		if (!SetFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetFocus");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFocus_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetFocus_FunctionAddress, argsSize: SetFocus_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetCursor")]
	public unsafe void SetCursor(EMouseCursor InCursor)
	{
		CheckDestroyed();
		if (!SetCursor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetCursor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCursor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCursor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EMouseCursor>.ToNative(IntPtr.Add(intPtr, SetCursor_InCursor_Offset), 0, SetCursor_InCursor_PropertyAddress.Address, InCursor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCursor_FunctionAddress, intPtr, SetCursor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetClipping")]
	public unsafe void SetClipping(EWidgetClipping InClipping)
	{
		CheckDestroyed();
		if (!SetClipping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetClipping");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetClipping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetClipping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EWidgetClipping>.ToNative(IntPtr.Add(intPtr, SetClipping_InClipping_Offset), 0, SetClipping_InClipping_PropertyAddress.Address, InClipping);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetClipping_FunctionAddress, intPtr, SetClipping_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:SetAllNavigationRules")]
	public unsafe void SetAllNavigationRules(EUINavigationRule Rule, FName WidgetToFocus)
	{
		CheckDestroyed();
		if (!SetAllNavigationRules_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:SetAllNavigationRules");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllNavigationRules_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllNavigationRules_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EUINavigationRule>.ToNative(IntPtr.Add(intPtr, SetAllNavigationRules_Rule_Offset), 0, SetAllNavigationRules_Rule_PropertyAddress.Address, Rule);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAllNavigationRules_WidgetToFocus_Offset), 0, SetAllNavigationRules_WidgetToFocus_PropertyAddress.Address, WidgetToFocus);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAllNavigationRules_FunctionAddress, intPtr, SetAllNavigationRules_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:ResetCursor")]
	public unsafe void ResetCursor()
	{
		CheckDestroyed();
		if (!ResetCursor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:ResetCursor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetCursor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetCursor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetCursor_FunctionAddress, argsSize: ResetCursor_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/UMG.Widget:RemoveFromParent")]
	public unsafe void RemoveFromParent()
	{
		CheckDestroyed();
		if (!RemoveFromParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:RemoveFromParent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveFromParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveFromParent_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: RemoveFromParent_FunctionAddress, argsSize: RemoveFromParent_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:IsVisible")]
	public unsafe bool IsVisible()
	{
		CheckDestroyed();
		if (!IsVisible_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:IsVisible");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVisible_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVisible_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVisible_FunctionAddress, intPtr, IsVisible_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVisible_ReturnValue_Offset), 0, IsVisible_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/UMG.Widget:IsHovered")]
	public unsafe bool IsHovered()
	{
		CheckDestroyed();
		if (!IsHovered_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:IsHovered");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsHovered_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsHovered_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsHovered_FunctionAddress, intPtr, IsHovered_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsHovered_ReturnValue_Offset), 0, IsHovered_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:InvalidateLayoutAndVolatility")]
	public unsafe void InvalidateLayoutAndVolatility()
	{
		CheckDestroyed();
		if (!InvalidateLayoutAndVolatility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:InvalidateLayoutAndVolatility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InvalidateLayoutAndVolatility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InvalidateLayoutAndVolatility_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InvalidateLayoutAndVolatility_FunctionAddress, argsSize: InvalidateLayoutAndVolatility_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:HasUserFocusedDescendants")]
	public unsafe bool HasUserFocusedDescendants(APlayerController PlayerController)
	{
		CheckDestroyed();
		if (!HasUserFocusedDescendants_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:HasUserFocusedDescendants");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasUserFocusedDescendants_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasUserFocusedDescendants_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, HasUserFocusedDescendants_PlayerController_Offset), 0, HasUserFocusedDescendants_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasUserFocusedDescendants_FunctionAddress, intPtr, HasUserFocusedDescendants_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasUserFocusedDescendants_ReturnValue_Offset), 0, HasUserFocusedDescendants_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:HasUserFocus")]
	public unsafe bool HasUserFocus(APlayerController PlayerController)
	{
		CheckDestroyed();
		if (!HasUserFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:HasUserFocus");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasUserFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasUserFocus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, HasUserFocus_PlayerController_Offset), 0, HasUserFocus_PlayerController_PropertyAddress.Address, PlayerController);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasUserFocus_FunctionAddress, intPtr, HasUserFocus_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasUserFocus_ReturnValue_Offset), 0, HasUserFocus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:HasMouseCaptureByUser")]
	public unsafe bool HasMouseCaptureByUser(int UserIndex, int PointerIndex = -1)
	{
		CheckDestroyed();
		if (!HasMouseCaptureByUser_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:HasMouseCaptureByUser");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMouseCaptureByUser_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMouseCaptureByUser_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, HasMouseCaptureByUser_UserIndex_Offset), 0, HasMouseCaptureByUser_UserIndex_PropertyAddress.Address, UserIndex);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, HasMouseCaptureByUser_PointerIndex_Offset), 0, HasMouseCaptureByUser_PointerIndex_PropertyAddress.Address, PointerIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasMouseCaptureByUser_FunctionAddress, intPtr, HasMouseCaptureByUser_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMouseCaptureByUser_ReturnValue_Offset), 0, HasMouseCaptureByUser_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:HasMouseCapture")]
	public unsafe bool HasMouseCapture()
	{
		CheckDestroyed();
		if (!HasMouseCapture_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:HasMouseCapture");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasMouseCapture_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasMouseCapture_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasMouseCapture_FunctionAddress, intPtr, HasMouseCapture_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasMouseCapture_ReturnValue_Offset), 0, HasMouseCapture_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:HasKeyboardFocus")]
	public unsafe bool HasKeyboardFocus()
	{
		CheckDestroyed();
		if (!HasKeyboardFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:HasKeyboardFocus");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasKeyboardFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasKeyboardFocus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasKeyboardFocus_FunctionAddress, intPtr, HasKeyboardFocus_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasKeyboardFocus_ReturnValue_Offset), 0, HasKeyboardFocus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:HasFocusedDescendants")]
	public unsafe bool HasFocusedDescendants()
	{
		CheckDestroyed();
		if (!HasFocusedDescendants_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:HasFocusedDescendants");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasFocusedDescendants_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasFocusedDescendants_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasFocusedDescendants_FunctionAddress, intPtr, HasFocusedDescendants_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasFocusedDescendants_ReturnValue_Offset), 0, HasFocusedDescendants_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:HasAnyUserFocus")]
	public unsafe bool HasAnyUserFocus()
	{
		CheckDestroyed();
		if (!HasAnyUserFocus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:HasAnyUserFocus");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAnyUserFocus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAnyUserFocus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAnyUserFocus_FunctionAddress, intPtr, HasAnyUserFocus_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAnyUserFocus_ReturnValue_Offset), 0, HasAnyUserFocus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetVisibility")]
	public unsafe ESlateVisibility GetVisibility()
	{
		CheckDestroyed();
		if (!GetVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetVisibility");
			return ESlateVisibility.Visible;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVisibility_FunctionAddress, intPtr, GetVisibility_ParamsSize);
		return EnumMarshaler<ESlateVisibility>.FromNative(IntPtr.Add(intPtr, GetVisibility_ReturnValue_Offset), 0, GetVisibility_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetTickSpaceGeometry")]
	public unsafe FGeometry GetTickSpaceGeometry()
	{
		CheckDestroyed();
		if (!GetTickSpaceGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetTickSpaceGeometry");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTickSpaceGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTickSpaceGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTickSpaceGeometry_FunctionAddress, intPtr, GetTickSpaceGeometry_ParamsSize);
		return StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(intPtr, GetTickSpaceGeometry_ReturnValue_Offset), 0, GetTickSpaceGeometry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetRenderTransformAngle")]
	public unsafe float GetRenderTransformAngle()
	{
		CheckDestroyed();
		if (!GetRenderTransformAngle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetRenderTransformAngle");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRenderTransformAngle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRenderTransformAngle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRenderTransformAngle_FunctionAddress, intPtr, GetRenderTransformAngle_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRenderTransformAngle_ReturnValue_Offset), 0, GetRenderTransformAngle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetRenderOpacity")]
	public unsafe float GetRenderOpacity()
	{
		CheckDestroyed();
		if (!GetRenderOpacity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetRenderOpacity");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRenderOpacity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRenderOpacity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRenderOpacity_FunctionAddress, intPtr, GetRenderOpacity_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRenderOpacity_ReturnValue_Offset), 0, GetRenderOpacity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetPixelSnappingMethod")]
	public unsafe EPixelSnappingMethod GetPixelSnappingMethod()
	{
		CheckDestroyed();
		if (!GetPixelSnappingMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetPixelSnappingMethod");
			return EPixelSnappingMethod.Inherit;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPixelSnappingMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPixelSnappingMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPixelSnappingMethod_FunctionAddress, intPtr, GetPixelSnappingMethod_ParamsSize);
		return EnumMarshaler<EPixelSnappingMethod>.FromNative(IntPtr.Add(intPtr, GetPixelSnappingMethod_ReturnValue_Offset), 0, GetPixelSnappingMethod_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetParent")]
	public unsafe UPanelWidget GetParent()
	{
		CheckDestroyed();
		if (!GetParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetParent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetParent_FunctionAddress, intPtr, GetParent_ParamsSize);
		return UObjectMarshaler<UPanelWidget>.FromNative(IntPtr.Add(intPtr, GetParent_ReturnValue_Offset), 0, GetParent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetPaintSpaceGeometry")]
	public unsafe FGeometry GetPaintSpaceGeometry()
	{
		CheckDestroyed();
		if (!GetPaintSpaceGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetPaintSpaceGeometry");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPaintSpaceGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPaintSpaceGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPaintSpaceGeometry_FunctionAddress, intPtr, GetPaintSpaceGeometry_ParamsSize);
		return StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(intPtr, GetPaintSpaceGeometry_ReturnValue_Offset), 0, GetPaintSpaceGeometry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418248u)]
	[UMetaPath("/Script/UMG.Widget:GetOwningPlayer")]
	public unsafe APlayerController GetOwningPlayer()
	{
		CheckDestroyed();
		if (!GetOwningPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetOwningPlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwningPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwningPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwningPlayer_FunctionAddress, intPtr, GetOwningPlayer_ParamsSize);
		return UObjectMarshaler<APlayerController>.FromNative(IntPtr.Add(intPtr, GetOwningPlayer_ReturnValue_Offset), 0, GetOwningPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418248u)]
	[UMetaPath("/Script/UMG.Widget:GetOwningLocalPlayer")]
	public unsafe ULocalPlayer GetOwningLocalPlayer()
	{
		CheckDestroyed();
		if (!GetOwningLocalPlayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetOwningLocalPlayer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOwningLocalPlayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOwningLocalPlayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOwningLocalPlayer_FunctionAddress, intPtr, GetOwningLocalPlayer_ParamsSize);
		return UObjectMarshaler<ULocalPlayer>.FromNative(IntPtr.Add(intPtr, GetOwningLocalPlayer_ReturnValue_Offset), 0, GetOwningLocalPlayer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetIsEnabled")]
	public unsafe bool GetIsEnabled()
	{
		CheckDestroyed();
		if (!GetIsEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetIsEnabled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIsEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIsEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetIsEnabled_FunctionAddress, intPtr, GetIsEnabled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetIsEnabled_ReturnValue_Offset), 0, GetIsEnabled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418249u)]
	[UMetaPath("/Script/UMG.Widget:GetGameInstance")]
	public unsafe UGameInstance GetGameInstance()
	{
		CheckDestroyed();
		if (!GetGameInstance_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetGameInstance");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameInstance_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameInstance_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGameInstance_FunctionAddress, intPtr, GetGameInstance_ParamsSize);
		return UObjectMarshaler<UGameInstance>.FromNative(IntPtr.Add(intPtr, GetGameInstance_ReturnValue_Offset), 0, GetGameInstance_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/UMG.Widget:GetDesiredSize")]
	public unsafe FVector2D GetDesiredSize()
	{
		CheckDestroyed();
		if (!GetDesiredSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetDesiredSize");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDesiredSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDesiredSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDesiredSize_FunctionAddress, intPtr, GetDesiredSize_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetDesiredSize_ReturnValue_Offset), 0, GetDesiredSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetClipping")]
	public unsafe EWidgetClipping GetClipping()
	{
		CheckDestroyed();
		if (!GetClipping_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetClipping");
			return EWidgetClipping.Inherit;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetClipping_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetClipping_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetClipping_FunctionAddress, intPtr, GetClipping_ParamsSize);
		return EnumMarshaler<EWidgetClipping>.FromNative(IntPtr.Add(intPtr, GetClipping_ReturnValue_Offset), 0, GetClipping_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetCachedGeometry")]
	public unsafe FGeometry GetCachedGeometry()
	{
		CheckDestroyed();
		if (!GetCachedGeometry_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetCachedGeometry");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCachedGeometry_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCachedGeometry_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCachedGeometry_FunctionAddress, intPtr, GetCachedGeometry_ParamsSize);
		return StructAsClassMarshaler<FGeometry>.FromNative(IntPtr.Add(intPtr, GetCachedGeometry_ReturnValue_Offset), 0, GetCachedGeometry_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetAccessibleText")]
	public unsafe string GetAccessibleText()
	{
		CheckDestroyed();
		if (!GetAccessibleText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetAccessibleText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAccessibleText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAccessibleText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAccessibleText_FunctionAddress, intPtr, GetAccessibleText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetAccessibleText_ReturnValue_Offset), 0, GetAccessibleText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetAccessibleText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/UMG.Widget:GetAccessibleSummaryText")]
	public unsafe string GetAccessibleSummaryText()
	{
		CheckDestroyed();
		if (!GetAccessibleSummaryText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:GetAccessibleSummaryText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAccessibleSummaryText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAccessibleSummaryText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAccessibleSummaryText_FunctionAddress, intPtr, GetAccessibleSummaryText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetAccessibleSummaryText_ReturnValue_Offset), 0, GetAccessibleSummaryText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetAccessibleSummaryText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:ForceVolatile")]
	public unsafe void ForceVolatile(bool bForce)
	{
		CheckDestroyed();
		if (!ForceVolatile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:ForceVolatile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceVolatile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceVolatile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ForceVolatile_bForce_Offset), 0, ForceVolatile_bForce_PropertyAddress.Address, bForce);
		NativeReflection.InvokeFunctionOptimized(base.Address, ForceVolatile_FunctionAddress, intPtr, ForceVolatile_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/UMG.Widget:ForceLayoutPrepass")]
	public unsafe void ForceLayoutPrepass()
	{
		CheckDestroyed();
		if (!ForceLayoutPrepass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UMG.Widget:ForceLayoutPrepass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceLayoutPrepass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceLayoutPrepass_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceLayoutPrepass_FunctionAddress, argsSize: ForceLayoutPrepass_ParamsSize);
	}

	static UWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/UMG.Widget");
		Slot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Slot");
		Slot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Slot", Classes.FObjectProperty);
		ToolTipText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ToolTipText");
		ToolTipText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ToolTipText", Classes.FTextProperty);
		ToolTipWidget_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ToolTipWidget");
		ToolTipWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ToolTipWidget", Classes.FObjectProperty);
		RenderTransform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderTransform");
		RenderTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderTransform", Classes.FStructProperty);
		RenderTransformPivot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RenderTransformPivot");
		RenderTransformPivot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RenderTransformPivot", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsEnabled_PropertyAddress, intPtr, "bIsEnabled");
		IsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsEnabled");
		IsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsVolatile_PropertyAddress, intPtr, "bIsVolatile");
		IsVolatile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsVolatile");
		IsVolatile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsVolatile", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Cursor_PropertyAddress, intPtr, "Cursor");
		Cursor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Cursor");
		Cursor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Cursor", Classes.FByteProperty);
		Navigation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Navigation");
		Navigation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Navigation", Classes.FObjectProperty);
		SetVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVisibility");
		SetVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVisibility_InVisibility_PropertyAddress, SetVisibility_FunctionAddress, "InVisibility");
		SetVisibility_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetVisibility_FunctionAddress, "InVisibility");
		SetVisibility_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVisibility_FunctionAddress, "InVisibility", Classes.FEnumProperty);
		SetVisibility_IsValid = SetVisibility_FunctionAddress != IntPtr.Zero && SetVisibility_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetVisibility", SetVisibility_IsValid);
		SetUserFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUserFocus");
		SetUserFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUserFocus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUserFocus_PlayerController_PropertyAddress, SetUserFocus_FunctionAddress, "PlayerController");
		SetUserFocus_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(SetUserFocus_FunctionAddress, "PlayerController");
		SetUserFocus_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUserFocus_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		SetUserFocus_IsValid = SetUserFocus_FunctionAddress != IntPtr.Zero && SetUserFocus_PlayerController_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetUserFocus", SetUserFocus_IsValid);
		SetToolTipText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetToolTipText");
		SetToolTipText_ParamsSize = NativeReflection.GetFunctionParamsSize(SetToolTipText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetToolTipText_InToolTipText_PropertyAddress, SetToolTipText_FunctionAddress, "InToolTipText");
		SetToolTipText_InToolTipText_Offset = NativeReflectionCached.GetPropertyOffset(SetToolTipText_FunctionAddress, "InToolTipText");
		SetToolTipText_InToolTipText_IsValid = NativeReflectionCached.ValidatePropertyClass(SetToolTipText_FunctionAddress, "InToolTipText", Classes.FTextProperty);
		SetToolTipText_IsValid = SetToolTipText_FunctionAddress != IntPtr.Zero && SetToolTipText_InToolTipText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetToolTipText", SetToolTipText_IsValid);
		SetToolTip_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetToolTip");
		SetToolTip_ParamsSize = NativeReflection.GetFunctionParamsSize(SetToolTip_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetToolTip_Widget_PropertyAddress, SetToolTip_FunctionAddress, "Widget");
		SetToolTip_Widget_Offset = NativeReflectionCached.GetPropertyOffset(SetToolTip_FunctionAddress, "Widget");
		SetToolTip_Widget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetToolTip_FunctionAddress, "Widget", Classes.FObjectProperty);
		SetToolTip_IsValid = SetToolTip_FunctionAddress != IntPtr.Zero && SetToolTip_Widget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetToolTip", SetToolTip_IsValid);
		SetRenderTranslation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderTranslation");
		SetRenderTranslation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderTranslation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderTranslation_Translation_PropertyAddress, SetRenderTranslation_FunctionAddress, "Translation");
		SetRenderTranslation_Translation_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderTranslation_FunctionAddress, "Translation");
		SetRenderTranslation_Translation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderTranslation_FunctionAddress, "Translation", Classes.FStructProperty);
		SetRenderTranslation_IsValid = SetRenderTranslation_FunctionAddress != IntPtr.Zero && SetRenderTranslation_Translation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetRenderTranslation", SetRenderTranslation_IsValid);
		SetRenderTransformPivot_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderTransformPivot");
		SetRenderTransformPivot_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderTransformPivot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderTransformPivot_Pivot_PropertyAddress, SetRenderTransformPivot_FunctionAddress, "Pivot");
		SetRenderTransformPivot_Pivot_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderTransformPivot_FunctionAddress, "Pivot");
		SetRenderTransformPivot_Pivot_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderTransformPivot_FunctionAddress, "Pivot", Classes.FStructProperty);
		SetRenderTransformPivot_IsValid = SetRenderTransformPivot_FunctionAddress != IntPtr.Zero && SetRenderTransformPivot_Pivot_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetRenderTransformPivot", SetRenderTransformPivot_IsValid);
		SetRenderTransformAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderTransformAngle");
		SetRenderTransformAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderTransformAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderTransformAngle_Angle_PropertyAddress, SetRenderTransformAngle_FunctionAddress, "Angle");
		SetRenderTransformAngle_Angle_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderTransformAngle_FunctionAddress, "Angle");
		SetRenderTransformAngle_Angle_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderTransformAngle_FunctionAddress, "Angle", Classes.FFloatProperty);
		SetRenderTransformAngle_IsValid = SetRenderTransformAngle_FunctionAddress != IntPtr.Zero && SetRenderTransformAngle_Angle_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetRenderTransformAngle", SetRenderTransformAngle_IsValid);
		SetRenderTransform_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderTransform");
		SetRenderTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderTransform_InTransform_PropertyAddress, SetRenderTransform_FunctionAddress, "InTransform");
		SetRenderTransform_InTransform_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderTransform_FunctionAddress, "InTransform");
		SetRenderTransform_InTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderTransform_FunctionAddress, "InTransform", Classes.FStructProperty);
		SetRenderTransform_IsValid = SetRenderTransform_FunctionAddress != IntPtr.Zero && SetRenderTransform_InTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetRenderTransform", SetRenderTransform_IsValid);
		SetRenderShear_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderShear");
		SetRenderShear_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderShear_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderShear_Shear_PropertyAddress, SetRenderShear_FunctionAddress, "Shear");
		SetRenderShear_Shear_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderShear_FunctionAddress, "Shear");
		SetRenderShear_Shear_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderShear_FunctionAddress, "Shear", Classes.FStructProperty);
		SetRenderShear_IsValid = SetRenderShear_FunctionAddress != IntPtr.Zero && SetRenderShear_Shear_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetRenderShear", SetRenderShear_IsValid);
		SetRenderScale_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderScale");
		SetRenderScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderScale_Scale_PropertyAddress, SetRenderScale_FunctionAddress, "Scale");
		SetRenderScale_Scale_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderScale_FunctionAddress, "Scale");
		SetRenderScale_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderScale_FunctionAddress, "Scale", Classes.FStructProperty);
		SetRenderScale_IsValid = SetRenderScale_FunctionAddress != IntPtr.Zero && SetRenderScale_Scale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetRenderScale", SetRenderScale_IsValid);
		SetRenderOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRenderOpacity");
		SetRenderOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRenderOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRenderOpacity_InOpacity_PropertyAddress, SetRenderOpacity_FunctionAddress, "InOpacity");
		SetRenderOpacity_InOpacity_Offset = NativeReflectionCached.GetPropertyOffset(SetRenderOpacity_FunctionAddress, "InOpacity");
		SetRenderOpacity_InOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRenderOpacity_FunctionAddress, "InOpacity", Classes.FFloatProperty);
		SetRenderOpacity_IsValid = SetRenderOpacity_FunctionAddress != IntPtr.Zero && SetRenderOpacity_InOpacity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetRenderOpacity", SetRenderOpacity_IsValid);
		SetPixelSnappingMethod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPixelSnappingMethod");
		SetPixelSnappingMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPixelSnappingMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPixelSnappingMethod_InPixelSnappingMethod_PropertyAddress, SetPixelSnappingMethod_FunctionAddress, "InPixelSnappingMethod");
		SetPixelSnappingMethod_InPixelSnappingMethod_Offset = NativeReflectionCached.GetPropertyOffset(SetPixelSnappingMethod_FunctionAddress, "InPixelSnappingMethod");
		SetPixelSnappingMethod_InPixelSnappingMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPixelSnappingMethod_FunctionAddress, "InPixelSnappingMethod", Classes.FEnumProperty);
		SetPixelSnappingMethod_IsValid = SetPixelSnappingMethod_FunctionAddress != IntPtr.Zero && SetPixelSnappingMethod_InPixelSnappingMethod_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetPixelSnappingMethod", SetPixelSnappingMethod_IsValid);
		SetNavigationRuleExplicit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavigationRuleExplicit");
		SetNavigationRuleExplicit_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationRuleExplicit_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRuleExplicit_Direction_PropertyAddress, SetNavigationRuleExplicit_FunctionAddress, "Direction");
		SetNavigationRuleExplicit_Direction_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRuleExplicit_FunctionAddress, "Direction");
		SetNavigationRuleExplicit_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRuleExplicit_FunctionAddress, "Direction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRuleExplicit_InWidget_PropertyAddress, SetNavigationRuleExplicit_FunctionAddress, "InWidget");
		SetNavigationRuleExplicit_InWidget_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRuleExplicit_FunctionAddress, "InWidget");
		SetNavigationRuleExplicit_InWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRuleExplicit_FunctionAddress, "InWidget", Classes.FObjectProperty);
		SetNavigationRuleExplicit_IsValid = SetNavigationRuleExplicit_FunctionAddress != IntPtr.Zero && SetNavigationRuleExplicit_Direction_IsValid && SetNavigationRuleExplicit_InWidget_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetNavigationRuleExplicit", SetNavigationRuleExplicit_IsValid);
		SetNavigationRuleCustomBoundary_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavigationRuleCustomBoundary");
		SetNavigationRuleCustomBoundary_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationRuleCustomBoundary_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRuleCustomBoundary_Direction_PropertyAddress, SetNavigationRuleCustomBoundary_FunctionAddress, "Direction");
		SetNavigationRuleCustomBoundary_Direction_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRuleCustomBoundary_FunctionAddress, "Direction");
		SetNavigationRuleCustomBoundary_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRuleCustomBoundary_FunctionAddress, "Direction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRuleCustomBoundary_InCustomDelegate_PropertyAddress, SetNavigationRuleCustomBoundary_FunctionAddress, "InCustomDelegate");
		SetNavigationRuleCustomBoundary_InCustomDelegate_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRuleCustomBoundary_FunctionAddress, "InCustomDelegate");
		SetNavigationRuleCustomBoundary_InCustomDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRuleCustomBoundary_FunctionAddress, "InCustomDelegate", Classes.FDelegateProperty);
		SetNavigationRuleCustomBoundary_IsValid = SetNavigationRuleCustomBoundary_FunctionAddress != IntPtr.Zero && SetNavigationRuleCustomBoundary_Direction_IsValid && SetNavigationRuleCustomBoundary_InCustomDelegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetNavigationRuleCustomBoundary", SetNavigationRuleCustomBoundary_IsValid);
		SetNavigationRuleCustom_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavigationRuleCustom");
		SetNavigationRuleCustom_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationRuleCustom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRuleCustom_Direction_PropertyAddress, SetNavigationRuleCustom_FunctionAddress, "Direction");
		SetNavigationRuleCustom_Direction_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRuleCustom_FunctionAddress, "Direction");
		SetNavigationRuleCustom_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRuleCustom_FunctionAddress, "Direction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRuleCustom_InCustomDelegate_PropertyAddress, SetNavigationRuleCustom_FunctionAddress, "InCustomDelegate");
		SetNavigationRuleCustom_InCustomDelegate_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRuleCustom_FunctionAddress, "InCustomDelegate");
		SetNavigationRuleCustom_InCustomDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRuleCustom_FunctionAddress, "InCustomDelegate", Classes.FDelegateProperty);
		SetNavigationRuleCustom_IsValid = SetNavigationRuleCustom_FunctionAddress != IntPtr.Zero && SetNavigationRuleCustom_Direction_IsValid && SetNavigationRuleCustom_InCustomDelegate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetNavigationRuleCustom", SetNavigationRuleCustom_IsValid);
		SetNavigationRuleBase_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavigationRuleBase");
		SetNavigationRuleBase_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationRuleBase_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRuleBase_Direction_PropertyAddress, SetNavigationRuleBase_FunctionAddress, "Direction");
		SetNavigationRuleBase_Direction_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRuleBase_FunctionAddress, "Direction");
		SetNavigationRuleBase_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRuleBase_FunctionAddress, "Direction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRuleBase_Rule_PropertyAddress, SetNavigationRuleBase_FunctionAddress, "Rule");
		SetNavigationRuleBase_Rule_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRuleBase_FunctionAddress, "Rule");
		SetNavigationRuleBase_Rule_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRuleBase_FunctionAddress, "Rule", Classes.FEnumProperty);
		SetNavigationRuleBase_IsValid = SetNavigationRuleBase_FunctionAddress != IntPtr.Zero && SetNavigationRuleBase_Direction_IsValid && SetNavigationRuleBase_Rule_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetNavigationRuleBase", SetNavigationRuleBase_IsValid);
		SetNavigationRule_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetNavigationRule");
		SetNavigationRule_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNavigationRule_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRule_Direction_PropertyAddress, SetNavigationRule_FunctionAddress, "Direction");
		SetNavigationRule_Direction_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRule_FunctionAddress, "Direction");
		SetNavigationRule_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRule_FunctionAddress, "Direction", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRule_Rule_PropertyAddress, SetNavigationRule_FunctionAddress, "Rule");
		SetNavigationRule_Rule_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRule_FunctionAddress, "Rule");
		SetNavigationRule_Rule_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRule_FunctionAddress, "Rule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNavigationRule_WidgetToFocus_PropertyAddress, SetNavigationRule_FunctionAddress, "WidgetToFocus");
		SetNavigationRule_WidgetToFocus_Offset = NativeReflectionCached.GetPropertyOffset(SetNavigationRule_FunctionAddress, "WidgetToFocus");
		SetNavigationRule_WidgetToFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNavigationRule_FunctionAddress, "WidgetToFocus", Classes.FNameProperty);
		SetNavigationRule_IsValid = SetNavigationRule_FunctionAddress != IntPtr.Zero && SetNavigationRule_Direction_IsValid && SetNavigationRule_Rule_IsValid && SetNavigationRule_WidgetToFocus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetNavigationRule", SetNavigationRule_IsValid);
		SetKeyboardFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetKeyboardFocus");
		SetKeyboardFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetKeyboardFocus_FunctionAddress);
		SetKeyboardFocus_IsValid = SetKeyboardFocus_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetKeyboardFocus", SetKeyboardFocus_IsValid);
		SetIsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetIsEnabled");
		SetIsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIsEnabled_bInIsEnabled_PropertyAddress, SetIsEnabled_FunctionAddress, "bInIsEnabled");
		SetIsEnabled_bInIsEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetIsEnabled_FunctionAddress, "bInIsEnabled");
		SetIsEnabled_bInIsEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIsEnabled_FunctionAddress, "bInIsEnabled", Classes.FBoolProperty);
		SetIsEnabled_IsValid = SetIsEnabled_FunctionAddress != IntPtr.Zero && SetIsEnabled_bInIsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetIsEnabled", SetIsEnabled_IsValid);
		SetFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFocus");
		SetFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFocus_FunctionAddress);
		SetFocus_IsValid = SetFocus_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetFocus", SetFocus_IsValid);
		SetCursor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCursor");
		SetCursor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCursor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCursor_InCursor_PropertyAddress, SetCursor_FunctionAddress, "InCursor");
		SetCursor_InCursor_Offset = NativeReflectionCached.GetPropertyOffset(SetCursor_FunctionAddress, "InCursor");
		SetCursor_InCursor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCursor_FunctionAddress, "InCursor", Classes.FByteProperty);
		SetCursor_IsValid = SetCursor_FunctionAddress != IntPtr.Zero && SetCursor_InCursor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetCursor", SetCursor_IsValid);
		SetClipping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetClipping");
		SetClipping_ParamsSize = NativeReflection.GetFunctionParamsSize(SetClipping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetClipping_InClipping_PropertyAddress, SetClipping_FunctionAddress, "InClipping");
		SetClipping_InClipping_Offset = NativeReflectionCached.GetPropertyOffset(SetClipping_FunctionAddress, "InClipping");
		SetClipping_InClipping_IsValid = NativeReflectionCached.ValidatePropertyClass(SetClipping_FunctionAddress, "InClipping", Classes.FEnumProperty);
		SetClipping_IsValid = SetClipping_FunctionAddress != IntPtr.Zero && SetClipping_InClipping_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetClipping", SetClipping_IsValid);
		SetAllNavigationRules_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAllNavigationRules");
		SetAllNavigationRules_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllNavigationRules_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllNavigationRules_Rule_PropertyAddress, SetAllNavigationRules_FunctionAddress, "Rule");
		SetAllNavigationRules_Rule_Offset = NativeReflectionCached.GetPropertyOffset(SetAllNavigationRules_FunctionAddress, "Rule");
		SetAllNavigationRules_Rule_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllNavigationRules_FunctionAddress, "Rule", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllNavigationRules_WidgetToFocus_PropertyAddress, SetAllNavigationRules_FunctionAddress, "WidgetToFocus");
		SetAllNavigationRules_WidgetToFocus_Offset = NativeReflectionCached.GetPropertyOffset(SetAllNavigationRules_FunctionAddress, "WidgetToFocus");
		SetAllNavigationRules_WidgetToFocus_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllNavigationRules_FunctionAddress, "WidgetToFocus", Classes.FNameProperty);
		SetAllNavigationRules_IsValid = SetAllNavigationRules_FunctionAddress != IntPtr.Zero && SetAllNavigationRules_Rule_IsValid && SetAllNavigationRules_WidgetToFocus_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:SetAllNavigationRules", SetAllNavigationRules_IsValid);
		ResetCursor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetCursor");
		ResetCursor_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetCursor_FunctionAddress);
		ResetCursor_IsValid = ResetCursor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:ResetCursor", ResetCursor_IsValid);
		RemoveFromParent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RemoveFromParent");
		RemoveFromParent_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveFromParent_FunctionAddress);
		RemoveFromParent_IsValid = RemoveFromParent_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:RemoveFromParent", RemoveFromParent_IsValid);
		IsVisible_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsVisible");
		IsVisible_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVisible_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVisible_ReturnValue_PropertyAddress, IsVisible_FunctionAddress, "ReturnValue");
		IsVisible_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVisible_FunctionAddress, "ReturnValue");
		IsVisible_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVisible_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVisible_IsValid = IsVisible_FunctionAddress != IntPtr.Zero && IsVisible_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:IsVisible", IsVisible_IsValid);
		IsHovered_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsHovered");
		IsHovered_ParamsSize = NativeReflection.GetFunctionParamsSize(IsHovered_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsHovered_ReturnValue_PropertyAddress, IsHovered_FunctionAddress, "ReturnValue");
		IsHovered_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsHovered_FunctionAddress, "ReturnValue");
		IsHovered_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsHovered_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsHovered_IsValid = IsHovered_FunctionAddress != IntPtr.Zero && IsHovered_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:IsHovered", IsHovered_IsValid);
		InvalidateLayoutAndVolatility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InvalidateLayoutAndVolatility");
		InvalidateLayoutAndVolatility_ParamsSize = NativeReflection.GetFunctionParamsSize(InvalidateLayoutAndVolatility_FunctionAddress);
		InvalidateLayoutAndVolatility_IsValid = InvalidateLayoutAndVolatility_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:InvalidateLayoutAndVolatility", InvalidateLayoutAndVolatility_IsValid);
		HasUserFocusedDescendants_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasUserFocusedDescendants");
		HasUserFocusedDescendants_ParamsSize = NativeReflection.GetFunctionParamsSize(HasUserFocusedDescendants_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasUserFocusedDescendants_PlayerController_PropertyAddress, HasUserFocusedDescendants_FunctionAddress, "PlayerController");
		HasUserFocusedDescendants_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(HasUserFocusedDescendants_FunctionAddress, "PlayerController");
		HasUserFocusedDescendants_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(HasUserFocusedDescendants_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasUserFocusedDescendants_ReturnValue_PropertyAddress, HasUserFocusedDescendants_FunctionAddress, "ReturnValue");
		HasUserFocusedDescendants_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasUserFocusedDescendants_FunctionAddress, "ReturnValue");
		HasUserFocusedDescendants_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasUserFocusedDescendants_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasUserFocusedDescendants_IsValid = HasUserFocusedDescendants_FunctionAddress != IntPtr.Zero && HasUserFocusedDescendants_PlayerController_IsValid && HasUserFocusedDescendants_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:HasUserFocusedDescendants", HasUserFocusedDescendants_IsValid);
		HasUserFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasUserFocus");
		HasUserFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(HasUserFocus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasUserFocus_PlayerController_PropertyAddress, HasUserFocus_FunctionAddress, "PlayerController");
		HasUserFocus_PlayerController_Offset = NativeReflectionCached.GetPropertyOffset(HasUserFocus_FunctionAddress, "PlayerController");
		HasUserFocus_PlayerController_IsValid = NativeReflectionCached.ValidatePropertyClass(HasUserFocus_FunctionAddress, "PlayerController", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasUserFocus_ReturnValue_PropertyAddress, HasUserFocus_FunctionAddress, "ReturnValue");
		HasUserFocus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasUserFocus_FunctionAddress, "ReturnValue");
		HasUserFocus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasUserFocus_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasUserFocus_IsValid = HasUserFocus_FunctionAddress != IntPtr.Zero && HasUserFocus_PlayerController_IsValid && HasUserFocus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:HasUserFocus", HasUserFocus_IsValid);
		HasMouseCaptureByUser_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasMouseCaptureByUser");
		HasMouseCaptureByUser_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMouseCaptureByUser_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMouseCaptureByUser_UserIndex_PropertyAddress, HasMouseCaptureByUser_FunctionAddress, "UserIndex");
		HasMouseCaptureByUser_UserIndex_Offset = NativeReflectionCached.GetPropertyOffset(HasMouseCaptureByUser_FunctionAddress, "UserIndex");
		HasMouseCaptureByUser_UserIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMouseCaptureByUser_FunctionAddress, "UserIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HasMouseCaptureByUser_PointerIndex_PropertyAddress, HasMouseCaptureByUser_FunctionAddress, "PointerIndex");
		HasMouseCaptureByUser_PointerIndex_Offset = NativeReflectionCached.GetPropertyOffset(HasMouseCaptureByUser_FunctionAddress, "PointerIndex");
		HasMouseCaptureByUser_PointerIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMouseCaptureByUser_FunctionAddress, "PointerIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HasMouseCaptureByUser_ReturnValue_PropertyAddress, HasMouseCaptureByUser_FunctionAddress, "ReturnValue");
		HasMouseCaptureByUser_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMouseCaptureByUser_FunctionAddress, "ReturnValue");
		HasMouseCaptureByUser_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMouseCaptureByUser_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMouseCaptureByUser_IsValid = HasMouseCaptureByUser_FunctionAddress != IntPtr.Zero && HasMouseCaptureByUser_UserIndex_IsValid && HasMouseCaptureByUser_PointerIndex_IsValid && HasMouseCaptureByUser_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:HasMouseCaptureByUser", HasMouseCaptureByUser_IsValid);
		HasMouseCapture_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasMouseCapture");
		HasMouseCapture_ParamsSize = NativeReflection.GetFunctionParamsSize(HasMouseCapture_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasMouseCapture_ReturnValue_PropertyAddress, HasMouseCapture_FunctionAddress, "ReturnValue");
		HasMouseCapture_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasMouseCapture_FunctionAddress, "ReturnValue");
		HasMouseCapture_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasMouseCapture_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasMouseCapture_IsValid = HasMouseCapture_FunctionAddress != IntPtr.Zero && HasMouseCapture_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:HasMouseCapture", HasMouseCapture_IsValid);
		HasKeyboardFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasKeyboardFocus");
		HasKeyboardFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(HasKeyboardFocus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasKeyboardFocus_ReturnValue_PropertyAddress, HasKeyboardFocus_FunctionAddress, "ReturnValue");
		HasKeyboardFocus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasKeyboardFocus_FunctionAddress, "ReturnValue");
		HasKeyboardFocus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasKeyboardFocus_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasKeyboardFocus_IsValid = HasKeyboardFocus_FunctionAddress != IntPtr.Zero && HasKeyboardFocus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:HasKeyboardFocus", HasKeyboardFocus_IsValid);
		HasFocusedDescendants_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasFocusedDescendants");
		HasFocusedDescendants_ParamsSize = NativeReflection.GetFunctionParamsSize(HasFocusedDescendants_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasFocusedDescendants_ReturnValue_PropertyAddress, HasFocusedDescendants_FunctionAddress, "ReturnValue");
		HasFocusedDescendants_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasFocusedDescendants_FunctionAddress, "ReturnValue");
		HasFocusedDescendants_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasFocusedDescendants_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasFocusedDescendants_IsValid = HasFocusedDescendants_FunctionAddress != IntPtr.Zero && HasFocusedDescendants_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:HasFocusedDescendants", HasFocusedDescendants_IsValid);
		HasAnyUserFocus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasAnyUserFocus");
		HasAnyUserFocus_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAnyUserFocus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAnyUserFocus_ReturnValue_PropertyAddress, HasAnyUserFocus_FunctionAddress, "ReturnValue");
		HasAnyUserFocus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAnyUserFocus_FunctionAddress, "ReturnValue");
		HasAnyUserFocus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAnyUserFocus_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAnyUserFocus_IsValid = HasAnyUserFocus_FunctionAddress != IntPtr.Zero && HasAnyUserFocus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:HasAnyUserFocus", HasAnyUserFocus_IsValid);
		GetVisibility_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetVisibility");
		GetVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVisibility_ReturnValue_PropertyAddress, GetVisibility_FunctionAddress, "ReturnValue");
		GetVisibility_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVisibility_FunctionAddress, "ReturnValue");
		GetVisibility_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVisibility_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetVisibility_IsValid = GetVisibility_FunctionAddress != IntPtr.Zero && GetVisibility_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetVisibility", GetVisibility_IsValid);
		GetTickSpaceGeometry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTickSpaceGeometry");
		GetTickSpaceGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTickSpaceGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTickSpaceGeometry_ReturnValue_PropertyAddress, GetTickSpaceGeometry_FunctionAddress, "ReturnValue");
		GetTickSpaceGeometry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTickSpaceGeometry_FunctionAddress, "ReturnValue");
		GetTickSpaceGeometry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTickSpaceGeometry_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetTickSpaceGeometry_IsValid = GetTickSpaceGeometry_FunctionAddress != IntPtr.Zero && GetTickSpaceGeometry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetTickSpaceGeometry", GetTickSpaceGeometry_IsValid);
		GetRenderTransformAngle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRenderTransformAngle");
		GetRenderTransformAngle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRenderTransformAngle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRenderTransformAngle_ReturnValue_PropertyAddress, GetRenderTransformAngle_FunctionAddress, "ReturnValue");
		GetRenderTransformAngle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRenderTransformAngle_FunctionAddress, "ReturnValue");
		GetRenderTransformAngle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRenderTransformAngle_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRenderTransformAngle_IsValid = GetRenderTransformAngle_FunctionAddress != IntPtr.Zero && GetRenderTransformAngle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetRenderTransformAngle", GetRenderTransformAngle_IsValid);
		GetRenderOpacity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRenderOpacity");
		GetRenderOpacity_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRenderOpacity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRenderOpacity_ReturnValue_PropertyAddress, GetRenderOpacity_FunctionAddress, "ReturnValue");
		GetRenderOpacity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRenderOpacity_FunctionAddress, "ReturnValue");
		GetRenderOpacity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRenderOpacity_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRenderOpacity_IsValid = GetRenderOpacity_FunctionAddress != IntPtr.Zero && GetRenderOpacity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetRenderOpacity", GetRenderOpacity_IsValid);
		GetPixelSnappingMethod_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPixelSnappingMethod");
		GetPixelSnappingMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPixelSnappingMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPixelSnappingMethod_ReturnValue_PropertyAddress, GetPixelSnappingMethod_FunctionAddress, "ReturnValue");
		GetPixelSnappingMethod_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPixelSnappingMethod_FunctionAddress, "ReturnValue");
		GetPixelSnappingMethod_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPixelSnappingMethod_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetPixelSnappingMethod_IsValid = GetPixelSnappingMethod_FunctionAddress != IntPtr.Zero && GetPixelSnappingMethod_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetPixelSnappingMethod", GetPixelSnappingMethod_IsValid);
		GetParent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetParent");
		GetParent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetParent_ReturnValue_PropertyAddress, GetParent_FunctionAddress, "ReturnValue");
		GetParent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetParent_FunctionAddress, "ReturnValue");
		GetParent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetParent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetParent_IsValid = GetParent_FunctionAddress != IntPtr.Zero && GetParent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetParent", GetParent_IsValid);
		GetPaintSpaceGeometry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPaintSpaceGeometry");
		GetPaintSpaceGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPaintSpaceGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPaintSpaceGeometry_ReturnValue_PropertyAddress, GetPaintSpaceGeometry_FunctionAddress, "ReturnValue");
		GetPaintSpaceGeometry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPaintSpaceGeometry_FunctionAddress, "ReturnValue");
		GetPaintSpaceGeometry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPaintSpaceGeometry_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPaintSpaceGeometry_IsValid = GetPaintSpaceGeometry_FunctionAddress != IntPtr.Zero && GetPaintSpaceGeometry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetPaintSpaceGeometry", GetPaintSpaceGeometry_IsValid);
		GetOwningPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwningPlayer");
		GetOwningPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwningPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwningPlayer_ReturnValue_PropertyAddress, GetOwningPlayer_FunctionAddress, "ReturnValue");
		GetOwningPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningPlayer_FunctionAddress, "ReturnValue");
		GetOwningPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningPlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwningPlayer_IsValid = GetOwningPlayer_FunctionAddress != IntPtr.Zero && GetOwningPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetOwningPlayer", GetOwningPlayer_IsValid);
		GetOwningLocalPlayer_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOwningLocalPlayer");
		GetOwningLocalPlayer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOwningLocalPlayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOwningLocalPlayer_ReturnValue_PropertyAddress, GetOwningLocalPlayer_FunctionAddress, "ReturnValue");
		GetOwningLocalPlayer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOwningLocalPlayer_FunctionAddress, "ReturnValue");
		GetOwningLocalPlayer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOwningLocalPlayer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetOwningLocalPlayer_IsValid = GetOwningLocalPlayer_FunctionAddress != IntPtr.Zero && GetOwningLocalPlayer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetOwningLocalPlayer", GetOwningLocalPlayer_IsValid);
		GetIsEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetIsEnabled");
		GetIsEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIsEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIsEnabled_ReturnValue_PropertyAddress, GetIsEnabled_FunctionAddress, "ReturnValue");
		GetIsEnabled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIsEnabled_FunctionAddress, "ReturnValue");
		GetIsEnabled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIsEnabled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetIsEnabled_IsValid = GetIsEnabled_FunctionAddress != IntPtr.Zero && GetIsEnabled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetIsEnabled", GetIsEnabled_IsValid);
		GetGameInstance_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGameInstance");
		GetGameInstance_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameInstance_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameInstance_ReturnValue_PropertyAddress, GetGameInstance_FunctionAddress, "ReturnValue");
		GetGameInstance_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGameInstance_FunctionAddress, "ReturnValue");
		GetGameInstance_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameInstance_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetGameInstance_IsValid = GetGameInstance_FunctionAddress != IntPtr.Zero && GetGameInstance_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetGameInstance", GetGameInstance_IsValid);
		GetDesiredSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDesiredSize");
		GetDesiredSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDesiredSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDesiredSize_ReturnValue_PropertyAddress, GetDesiredSize_FunctionAddress, "ReturnValue");
		GetDesiredSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDesiredSize_FunctionAddress, "ReturnValue");
		GetDesiredSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDesiredSize_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDesiredSize_IsValid = GetDesiredSize_FunctionAddress != IntPtr.Zero && GetDesiredSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetDesiredSize", GetDesiredSize_IsValid);
		GetClipping_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetClipping");
		GetClipping_ParamsSize = NativeReflection.GetFunctionParamsSize(GetClipping_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetClipping_ReturnValue_PropertyAddress, GetClipping_FunctionAddress, "ReturnValue");
		GetClipping_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetClipping_FunctionAddress, "ReturnValue");
		GetClipping_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetClipping_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetClipping_IsValid = GetClipping_FunctionAddress != IntPtr.Zero && GetClipping_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetClipping", GetClipping_IsValid);
		GetCachedGeometry_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCachedGeometry");
		GetCachedGeometry_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCachedGeometry_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCachedGeometry_ReturnValue_PropertyAddress, GetCachedGeometry_FunctionAddress, "ReturnValue");
		GetCachedGeometry_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCachedGeometry_FunctionAddress, "ReturnValue");
		GetCachedGeometry_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCachedGeometry_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetCachedGeometry_IsValid = GetCachedGeometry_FunctionAddress != IntPtr.Zero && GetCachedGeometry_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetCachedGeometry", GetCachedGeometry_IsValid);
		GetAccessibleText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAccessibleText");
		GetAccessibleText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAccessibleText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAccessibleText_ReturnValue_PropertyAddress, GetAccessibleText_FunctionAddress, "ReturnValue");
		GetAccessibleText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAccessibleText_FunctionAddress, "ReturnValue");
		GetAccessibleText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAccessibleText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetAccessibleText_IsValid = GetAccessibleText_FunctionAddress != IntPtr.Zero && GetAccessibleText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetAccessibleText", GetAccessibleText_IsValid);
		GetAccessibleSummaryText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAccessibleSummaryText");
		GetAccessibleSummaryText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAccessibleSummaryText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAccessibleSummaryText_ReturnValue_PropertyAddress, GetAccessibleSummaryText_FunctionAddress, "ReturnValue");
		GetAccessibleSummaryText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAccessibleSummaryText_FunctionAddress, "ReturnValue");
		GetAccessibleSummaryText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAccessibleSummaryText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetAccessibleSummaryText_IsValid = GetAccessibleSummaryText_FunctionAddress != IntPtr.Zero && GetAccessibleSummaryText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:GetAccessibleSummaryText", GetAccessibleSummaryText_IsValid);
		ForceVolatile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceVolatile");
		ForceVolatile_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceVolatile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceVolatile_bForce_PropertyAddress, ForceVolatile_FunctionAddress, "bForce");
		ForceVolatile_bForce_Offset = NativeReflectionCached.GetPropertyOffset(ForceVolatile_FunctionAddress, "bForce");
		ForceVolatile_bForce_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceVolatile_FunctionAddress, "bForce", Classes.FBoolProperty);
		ForceVolatile_IsValid = ForceVolatile_FunctionAddress != IntPtr.Zero && ForceVolatile_bForce_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:ForceVolatile", ForceVolatile_IsValid);
		ForceLayoutPrepass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceLayoutPrepass");
		ForceLayoutPrepass_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceLayoutPrepass_FunctionAddress);
		ForceLayoutPrepass_IsValid = ForceLayoutPrepass_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UMG.Widget:ForceLayoutPrepass", ForceLayoutPrepass_IsValid);
	}
}
