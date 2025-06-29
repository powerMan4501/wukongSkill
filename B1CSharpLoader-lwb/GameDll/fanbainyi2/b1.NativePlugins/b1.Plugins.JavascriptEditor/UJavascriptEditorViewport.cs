using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AdvancedPreviewScene;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;
using UnrealEngine.UnrealEd;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptEditorViewport : UPanelWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportTrackingStopped__DelegateSignature")]
	public class FOnViewportTrackingStopped : FDelegate<FOnViewportTrackingStopped.Signature>
	{
		public delegate void Signature(UJavascriptEditorViewport Instance);

		private static bool OnViewportTrackingStopped__DelegateSignature_IsValid;

		private static IntPtr OnViewportTrackingStopped__DelegateSignature_FunctionAddress;

		private static int OnViewportTrackingStopped__DelegateSignature_ParamsSize;

		private static bool OnViewportTrackingStopped__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnViewportTrackingStopped__DelegateSignature_Instance_PropertyAddress;

		private static int OnViewportTrackingStopped__DelegateSignature_Instance_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnViewportTrackingStopped()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnViewportTrackingStopped__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportTrackingStopped__DelegateSignature");
			OnViewportTrackingStopped__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewportTrackingStopped__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnViewportTrackingStopped__DelegateSignature_Instance_PropertyAddress, OnViewportTrackingStopped__DelegateSignature_FunctionAddress, "Instance");
			OnViewportTrackingStopped__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportTrackingStopped__DelegateSignature_FunctionAddress, "Instance");
			OnViewportTrackingStopped__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportTrackingStopped__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			OnViewportTrackingStopped__DelegateSignature_IsValid = OnViewportTrackingStopped__DelegateSignature_FunctionAddress != IntPtr.Zero && OnViewportTrackingStopped__DelegateSignature_Instance_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportTrackingStopped__DelegateSignature", OnViewportTrackingStopped__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UJavascriptEditorViewport Instance)
		{
			if (!OnViewportTrackingStopped__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportTrackingStopped__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnViewportTrackingStopped__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewportTrackingStopped__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnViewportTrackingStopped__DelegateSignature_Instance_Offset), 0, OnViewportTrackingStopped__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportTrackingStarted__DelegateSignature")]
	public class FOnViewportTrackingStarted : FDelegate<FOnViewportTrackingStarted.Signature>
	{
		public delegate void Signature(FJavascriptInputEventState InputState, bool bIsDraggingWidget, bool bNudge, UJavascriptEditorViewport Instance);

		private static bool OnViewportTrackingStarted__DelegateSignature_IsValid;

		private static IntPtr OnViewportTrackingStarted__DelegateSignature_FunctionAddress;

		private static int OnViewportTrackingStarted__DelegateSignature_ParamsSize;

		private static bool OnViewportTrackingStarted__DelegateSignature_InputState_IsValid;

		private static FFieldAddress OnViewportTrackingStarted__DelegateSignature_InputState_PropertyAddress;

		private static int OnViewportTrackingStarted__DelegateSignature_InputState_Offset;

		private static bool OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_IsValid;

		private static FFieldAddress OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_PropertyAddress;

		private static int OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_Offset;

		private static bool OnViewportTrackingStarted__DelegateSignature_bNudge_IsValid;

		private static FFieldAddress OnViewportTrackingStarted__DelegateSignature_bNudge_PropertyAddress;

		private static int OnViewportTrackingStarted__DelegateSignature_bNudge_Offset;

		private static bool OnViewportTrackingStarted__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnViewportTrackingStarted__DelegateSignature_Instance_PropertyAddress;

		private static int OnViewportTrackingStarted__DelegateSignature_Instance_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnViewportTrackingStarted()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnViewportTrackingStarted__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportTrackingStarted__DelegateSignature");
			OnViewportTrackingStarted__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewportTrackingStarted__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnViewportTrackingStarted__DelegateSignature_InputState_PropertyAddress, OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "InputState");
			OnViewportTrackingStarted__DelegateSignature_InputState_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "InputState");
			OnViewportTrackingStarted__DelegateSignature_InputState_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "InputState", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_PropertyAddress, OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "bIsDraggingWidget");
			OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "bIsDraggingWidget");
			OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "bIsDraggingWidget", Classes.FBoolProperty);
			NativeReflectionCached.GetPropertyRef(ref OnViewportTrackingStarted__DelegateSignature_bNudge_PropertyAddress, OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "bNudge");
			OnViewportTrackingStarted__DelegateSignature_bNudge_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "bNudge");
			OnViewportTrackingStarted__DelegateSignature_bNudge_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "bNudge", Classes.FBoolProperty);
			NativeReflectionCached.GetPropertyRef(ref OnViewportTrackingStarted__DelegateSignature_Instance_PropertyAddress, OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "Instance");
			OnViewportTrackingStarted__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "Instance");
			OnViewportTrackingStarted__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportTrackingStarted__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			OnViewportTrackingStarted__DelegateSignature_IsValid = OnViewportTrackingStarted__DelegateSignature_FunctionAddress != IntPtr.Zero && OnViewportTrackingStarted__DelegateSignature_InputState_IsValid && OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_IsValid && OnViewportTrackingStarted__DelegateSignature_bNudge_IsValid && OnViewportTrackingStarted__DelegateSignature_Instance_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportTrackingStarted__DelegateSignature", OnViewportTrackingStarted__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FJavascriptInputEventState InputState, bool bIsDraggingWidget, bool bNudge, UJavascriptEditorViewport Instance)
		{
			if (!OnViewportTrackingStarted__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportTrackingStarted__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnViewportTrackingStarted__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewportTrackingStarted__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnViewportTrackingStarted__DelegateSignature_InputState_PropertyAddress.Address, intPtr);
				FJavascriptInputEventState.ToNative(IntPtr.Add(intPtr, OnViewportTrackingStarted__DelegateSignature_InputState_Offset), 0, OnViewportTrackingStarted__DelegateSignature_InputState_PropertyAddress.Address, InputState);
				BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_Offset), 0, OnViewportTrackingStarted__DelegateSignature_bIsDraggingWidget_PropertyAddress.Address, bIsDraggingWidget);
				BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnViewportTrackingStarted__DelegateSignature_bNudge_Offset), 0, OnViewportTrackingStarted__DelegateSignature_bNudge_PropertyAddress.Address, bNudge);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnViewportTrackingStarted__DelegateSignature_Instance_Offset), 0, OnViewportTrackingStarted__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportDrawCanvas__DelegateSignature")]
	public class FOnViewportDrawCanvas : FDelegate<FOnViewportDrawCanvas.Signature>
	{
		public delegate void Signature(UCanvas Canvas, UJavascriptEditorViewport Instance);

		private static bool OnViewportDrawCanvas__DelegateSignature_IsValid;

		private static IntPtr OnViewportDrawCanvas__DelegateSignature_FunctionAddress;

		private static int OnViewportDrawCanvas__DelegateSignature_ParamsSize;

		private static bool OnViewportDrawCanvas__DelegateSignature_Canvas_IsValid;

		private static FFieldAddress OnViewportDrawCanvas__DelegateSignature_Canvas_PropertyAddress;

		private static int OnViewportDrawCanvas__DelegateSignature_Canvas_Offset;

		private static bool OnViewportDrawCanvas__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnViewportDrawCanvas__DelegateSignature_Instance_PropertyAddress;

		private static int OnViewportDrawCanvas__DelegateSignature_Instance_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnViewportDrawCanvas()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnViewportDrawCanvas__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportDrawCanvas__DelegateSignature");
			OnViewportDrawCanvas__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewportDrawCanvas__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnViewportDrawCanvas__DelegateSignature_Canvas_PropertyAddress, OnViewportDrawCanvas__DelegateSignature_FunctionAddress, "Canvas");
			OnViewportDrawCanvas__DelegateSignature_Canvas_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportDrawCanvas__DelegateSignature_FunctionAddress, "Canvas");
			OnViewportDrawCanvas__DelegateSignature_Canvas_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportDrawCanvas__DelegateSignature_FunctionAddress, "Canvas", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnViewportDrawCanvas__DelegateSignature_Instance_PropertyAddress, OnViewportDrawCanvas__DelegateSignature_FunctionAddress, "Instance");
			OnViewportDrawCanvas__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportDrawCanvas__DelegateSignature_FunctionAddress, "Instance");
			OnViewportDrawCanvas__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportDrawCanvas__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			OnViewportDrawCanvas__DelegateSignature_IsValid = OnViewportDrawCanvas__DelegateSignature_FunctionAddress != IntPtr.Zero && OnViewportDrawCanvas__DelegateSignature_Canvas_IsValid && OnViewportDrawCanvas__DelegateSignature_Instance_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportDrawCanvas__DelegateSignature", OnViewportDrawCanvas__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(UCanvas Canvas, UJavascriptEditorViewport Instance)
		{
			if (!OnViewportDrawCanvas__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportDrawCanvas__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnViewportDrawCanvas__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewportDrawCanvas__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UCanvas>.ToNative(IntPtr.Add(intPtr, OnViewportDrawCanvas__DelegateSignature_Canvas_Offset), 0, OnViewportDrawCanvas__DelegateSignature_Canvas_PropertyAddress.Address, Canvas);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnViewportDrawCanvas__DelegateSignature_Instance_Offset), 0, OnViewportDrawCanvas__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportDraw__DelegateSignature")]
	public class FOnViewportDraw : FDelegate<FOnViewportDraw.Signature>
	{
		public delegate void Signature(FJavascriptPDI PDI, UJavascriptEditorViewport Instance);

		private static bool OnViewportDraw__DelegateSignature_IsValid;

		private static IntPtr OnViewportDraw__DelegateSignature_FunctionAddress;

		private static int OnViewportDraw__DelegateSignature_ParamsSize;

		private static bool OnViewportDraw__DelegateSignature_PDI_IsValid;

		private static FFieldAddress OnViewportDraw__DelegateSignature_PDI_PropertyAddress;

		private static int OnViewportDraw__DelegateSignature_PDI_Offset;

		private static bool OnViewportDraw__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnViewportDraw__DelegateSignature_Instance_PropertyAddress;

		private static int OnViewportDraw__DelegateSignature_Instance_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnViewportDraw()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnViewportDraw__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportDraw__DelegateSignature");
			OnViewportDraw__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewportDraw__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnViewportDraw__DelegateSignature_PDI_PropertyAddress, OnViewportDraw__DelegateSignature_FunctionAddress, "PDI");
			OnViewportDraw__DelegateSignature_PDI_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportDraw__DelegateSignature_FunctionAddress, "PDI");
			OnViewportDraw__DelegateSignature_PDI_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportDraw__DelegateSignature_FunctionAddress, "PDI", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnViewportDraw__DelegateSignature_Instance_PropertyAddress, OnViewportDraw__DelegateSignature_FunctionAddress, "Instance");
			OnViewportDraw__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportDraw__DelegateSignature_FunctionAddress, "Instance");
			OnViewportDraw__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportDraw__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			OnViewportDraw__DelegateSignature_IsValid = OnViewportDraw__DelegateSignature_FunctionAddress != IntPtr.Zero && OnViewportDraw__DelegateSignature_PDI_IsValid && OnViewportDraw__DelegateSignature_Instance_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportDraw__DelegateSignature", OnViewportDraw__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FJavascriptPDI PDI, UJavascriptEditorViewport Instance)
		{
			if (!OnViewportDraw__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportDraw__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnViewportDraw__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewportDraw__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<FJavascriptPDI>.ToNative(IntPtr.Add(intPtr, OnViewportDraw__DelegateSignature_PDI_Offset), 0, OnViewportDraw__DelegateSignature_PDI_PropertyAddress.Address, PDI);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnViewportDraw__DelegateSignature_Instance_Offset), 0, OnViewportDraw__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportClick__DelegateSignature")]
	public class FOnViewportClick : FDelegate<FOnViewportClick.Signature>
	{
		public delegate void Signature(FJavascriptViewportClick ViewportClick, FJavascriptHitProxy HitProxy, UJavascriptEditorViewport Instance);

		private static bool OnViewportClick__DelegateSignature_IsValid;

		private static IntPtr OnViewportClick__DelegateSignature_FunctionAddress;

		private static int OnViewportClick__DelegateSignature_ParamsSize;

		private static bool OnViewportClick__DelegateSignature_ViewportClick_IsValid;

		private static FFieldAddress OnViewportClick__DelegateSignature_ViewportClick_PropertyAddress;

		private static int OnViewportClick__DelegateSignature_ViewportClick_Offset;

		private static bool OnViewportClick__DelegateSignature_HitProxy_IsValid;

		private static FFieldAddress OnViewportClick__DelegateSignature_HitProxy_PropertyAddress;

		private static int OnViewportClick__DelegateSignature_HitProxy_Offset;

		private static bool OnViewportClick__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnViewportClick__DelegateSignature_Instance_PropertyAddress;

		private static int OnViewportClick__DelegateSignature_Instance_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnViewportClick()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnViewportClick__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportClick__DelegateSignature");
			OnViewportClick__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnViewportClick__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnViewportClick__DelegateSignature_ViewportClick_PropertyAddress, OnViewportClick__DelegateSignature_FunctionAddress, "ViewportClick");
			OnViewportClick__DelegateSignature_ViewportClick_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportClick__DelegateSignature_FunctionAddress, "ViewportClick");
			OnViewportClick__DelegateSignature_ViewportClick_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportClick__DelegateSignature_FunctionAddress, "ViewportClick", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnViewportClick__DelegateSignature_HitProxy_PropertyAddress, OnViewportClick__DelegateSignature_FunctionAddress, "HitProxy");
			OnViewportClick__DelegateSignature_HitProxy_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportClick__DelegateSignature_FunctionAddress, "HitProxy");
			OnViewportClick__DelegateSignature_HitProxy_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportClick__DelegateSignature_FunctionAddress, "HitProxy", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnViewportClick__DelegateSignature_Instance_PropertyAddress, OnViewportClick__DelegateSignature_FunctionAddress, "Instance");
			OnViewportClick__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnViewportClick__DelegateSignature_FunctionAddress, "Instance");
			OnViewportClick__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnViewportClick__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			OnViewportClick__DelegateSignature_IsValid = OnViewportClick__DelegateSignature_FunctionAddress != IntPtr.Zero && OnViewportClick__DelegateSignature_ViewportClick_IsValid && OnViewportClick__DelegateSignature_HitProxy_IsValid && OnViewportClick__DelegateSignature_Instance_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportClick__DelegateSignature", OnViewportClick__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FJavascriptViewportClick ViewportClick, FJavascriptHitProxy HitProxy, UJavascriptEditorViewport Instance)
		{
			if (!OnViewportClick__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnViewportClick__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnViewportClick__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnViewportClick__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<FJavascriptViewportClick>.ToNative(IntPtr.Add(intPtr, OnViewportClick__DelegateSignature_ViewportClick_Offset), 0, OnViewportClick__DelegateSignature_ViewportClick_PropertyAddress.Address, ViewportClick);
				BlittableTypeMarshaler<FJavascriptHitProxy>.ToNative(IntPtr.Add(intPtr, OnViewportClick__DelegateSignature_HitProxy_Offset), 0, OnViewportClick__DelegateSignature_HitProxy_PropertyAddress.Address, HitProxy);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnViewportClick__DelegateSignature_Instance_Offset), 0, OnViewportClick__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseMove__DelegateSignature")]
	public class FOnMouseMove : FDelegate<FOnMouseMove.Signature>
	{
		public delegate bool Signature(int x, int y, UJavascriptEditorViewport Instance);

		private static bool OnMouseMove__DelegateSignature_IsValid;

		private static IntPtr OnMouseMove__DelegateSignature_FunctionAddress;

		private static int OnMouseMove__DelegateSignature_ParamsSize;

		private static bool OnMouseMove__DelegateSignature_x_IsValid;

		private static FFieldAddress OnMouseMove__DelegateSignature_x_PropertyAddress;

		private static int OnMouseMove__DelegateSignature_x_Offset;

		private static bool OnMouseMove__DelegateSignature_y_IsValid;

		private static FFieldAddress OnMouseMove__DelegateSignature_y_PropertyAddress;

		private static int OnMouseMove__DelegateSignature_y_Offset;

		private static bool OnMouseMove__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnMouseMove__DelegateSignature_Instance_PropertyAddress;

		private static int OnMouseMove__DelegateSignature_Instance_Offset;

		private static bool OnMouseMove__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnMouseMove__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnMouseMove__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnMouseMove()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnMouseMove__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseMove__DelegateSignature");
			OnMouseMove__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseMove__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnMouseMove__DelegateSignature_x_PropertyAddress, OnMouseMove__DelegateSignature_FunctionAddress, "x");
			OnMouseMove__DelegateSignature_x_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseMove__DelegateSignature_FunctionAddress, "x");
			OnMouseMove__DelegateSignature_x_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseMove__DelegateSignature_FunctionAddress, "x", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMouseMove__DelegateSignature_y_PropertyAddress, OnMouseMove__DelegateSignature_FunctionAddress, "y");
			OnMouseMove__DelegateSignature_y_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseMove__DelegateSignature_FunctionAddress, "y");
			OnMouseMove__DelegateSignature_y_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseMove__DelegateSignature_FunctionAddress, "y", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMouseMove__DelegateSignature_Instance_PropertyAddress, OnMouseMove__DelegateSignature_FunctionAddress, "Instance");
			OnMouseMove__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseMove__DelegateSignature_FunctionAddress, "Instance");
			OnMouseMove__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseMove__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMouseMove__DelegateSignature_ReturnValue_PropertyAddress, OnMouseMove__DelegateSignature_FunctionAddress, "ReturnValue");
			OnMouseMove__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseMove__DelegateSignature_FunctionAddress, "ReturnValue");
			OnMouseMove__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseMove__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			OnMouseMove__DelegateSignature_IsValid = OnMouseMove__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMouseMove__DelegateSignature_x_IsValid && OnMouseMove__DelegateSignature_y_IsValid && OnMouseMove__DelegateSignature_Instance_IsValid && OnMouseMove__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseMove__DelegateSignature", OnMouseMove__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker(int x, int y, UJavascriptEditorViewport Instance)
		{
			if (!OnMouseMove__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseMove__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnMouseMove__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseMove__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnMouseMove__DelegateSignature_x_Offset), 0, OnMouseMove__DelegateSignature_x_PropertyAddress.Address, x);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnMouseMove__DelegateSignature_y_Offset), 0, OnMouseMove__DelegateSignature_y_PropertyAddress.Address, y);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnMouseMove__DelegateSignature_Instance_Offset), 0, OnMouseMove__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnMouseMove__DelegateSignature_ReturnValue_Offset), 0, OnMouseMove__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseLeave__DelegateSignature")]
	public class FOnMouseLeave : FDelegate<FOnMouseLeave.Signature>
	{
		public delegate bool Signature(UJavascriptEditorViewport Instance);

		private static bool OnMouseLeave__DelegateSignature_IsValid;

		private static IntPtr OnMouseLeave__DelegateSignature_FunctionAddress;

		private static int OnMouseLeave__DelegateSignature_ParamsSize;

		private static bool OnMouseLeave__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnMouseLeave__DelegateSignature_Instance_PropertyAddress;

		private static int OnMouseLeave__DelegateSignature_Instance_Offset;

		private static bool OnMouseLeave__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnMouseLeave__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnMouseLeave__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnMouseLeave()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnMouseLeave__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseLeave__DelegateSignature");
			OnMouseLeave__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseLeave__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnMouseLeave__DelegateSignature_Instance_PropertyAddress, OnMouseLeave__DelegateSignature_FunctionAddress, "Instance");
			OnMouseLeave__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseLeave__DelegateSignature_FunctionAddress, "Instance");
			OnMouseLeave__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseLeave__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMouseLeave__DelegateSignature_ReturnValue_PropertyAddress, OnMouseLeave__DelegateSignature_FunctionAddress, "ReturnValue");
			OnMouseLeave__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseLeave__DelegateSignature_FunctionAddress, "ReturnValue");
			OnMouseLeave__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseLeave__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			OnMouseLeave__DelegateSignature_IsValid = OnMouseLeave__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMouseLeave__DelegateSignature_Instance_IsValid && OnMouseLeave__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseLeave__DelegateSignature", OnMouseLeave__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker(UJavascriptEditorViewport Instance)
		{
			if (!OnMouseLeave__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseLeave__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnMouseLeave__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseLeave__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnMouseLeave__DelegateSignature_Instance_Offset), 0, OnMouseLeave__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnMouseLeave__DelegateSignature_ReturnValue_Offset), 0, OnMouseLeave__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseEnter__DelegateSignature")]
	public class FOnMouseEnter : FDelegate<FOnMouseEnter.Signature>
	{
		public delegate bool Signature(int x, int y, UJavascriptEditorViewport Instance);

		private static bool OnMouseEnter__DelegateSignature_IsValid;

		private static IntPtr OnMouseEnter__DelegateSignature_FunctionAddress;

		private static int OnMouseEnter__DelegateSignature_ParamsSize;

		private static bool OnMouseEnter__DelegateSignature_x_IsValid;

		private static FFieldAddress OnMouseEnter__DelegateSignature_x_PropertyAddress;

		private static int OnMouseEnter__DelegateSignature_x_Offset;

		private static bool OnMouseEnter__DelegateSignature_y_IsValid;

		private static FFieldAddress OnMouseEnter__DelegateSignature_y_PropertyAddress;

		private static int OnMouseEnter__DelegateSignature_y_Offset;

		private static bool OnMouseEnter__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnMouseEnter__DelegateSignature_Instance_PropertyAddress;

		private static int OnMouseEnter__DelegateSignature_Instance_Offset;

		private static bool OnMouseEnter__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnMouseEnter__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnMouseEnter__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnMouseEnter()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnMouseEnter__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseEnter__DelegateSignature");
			OnMouseEnter__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMouseEnter__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnMouseEnter__DelegateSignature_x_PropertyAddress, OnMouseEnter__DelegateSignature_FunctionAddress, "x");
			OnMouseEnter__DelegateSignature_x_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseEnter__DelegateSignature_FunctionAddress, "x");
			OnMouseEnter__DelegateSignature_x_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseEnter__DelegateSignature_FunctionAddress, "x", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMouseEnter__DelegateSignature_y_PropertyAddress, OnMouseEnter__DelegateSignature_FunctionAddress, "y");
			OnMouseEnter__DelegateSignature_y_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseEnter__DelegateSignature_FunctionAddress, "y");
			OnMouseEnter__DelegateSignature_y_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseEnter__DelegateSignature_FunctionAddress, "y", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMouseEnter__DelegateSignature_Instance_PropertyAddress, OnMouseEnter__DelegateSignature_FunctionAddress, "Instance");
			OnMouseEnter__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseEnter__DelegateSignature_FunctionAddress, "Instance");
			OnMouseEnter__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseEnter__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnMouseEnter__DelegateSignature_ReturnValue_PropertyAddress, OnMouseEnter__DelegateSignature_FunctionAddress, "ReturnValue");
			OnMouseEnter__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnMouseEnter__DelegateSignature_FunctionAddress, "ReturnValue");
			OnMouseEnter__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMouseEnter__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			OnMouseEnter__DelegateSignature_IsValid = OnMouseEnter__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMouseEnter__DelegateSignature_x_IsValid && OnMouseEnter__DelegateSignature_y_IsValid && OnMouseEnter__DelegateSignature_Instance_IsValid && OnMouseEnter__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseEnter__DelegateSignature", OnMouseEnter__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker(int x, int y, UJavascriptEditorViewport Instance)
		{
			if (!OnMouseEnter__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseEnter__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnMouseEnter__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMouseEnter__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnMouseEnter__DelegateSignature_x_Offset), 0, OnMouseEnter__DelegateSignature_x_PropertyAddress.Address, x);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnMouseEnter__DelegateSignature_y_Offset), 0, OnMouseEnter__DelegateSignature_y_PropertyAddress.Address, y);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnMouseEnter__DelegateSignature_Instance_Offset), 0, OnMouseEnter__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnMouseEnter__DelegateSignature_ReturnValue_Offset), 0, OnMouseEnter__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputWidgetDelta__DelegateSignature")]
	public class FOnInputWidgetDelta : FDelegate<FOnInputWidgetDelta.Signature>
	{
		public delegate bool Signature(out FVector Drag, out FRotator Rot, out FVector Scale, UJavascriptEditorViewport Instance);

		private static bool OnInputWidgetDelta__DelegateSignature_IsValid;

		private static IntPtr OnInputWidgetDelta__DelegateSignature_FunctionAddress;

		private static int OnInputWidgetDelta__DelegateSignature_ParamsSize;

		private static bool OnInputWidgetDelta__DelegateSignature_Drag_IsValid;

		private static FFieldAddress OnInputWidgetDelta__DelegateSignature_Drag_PropertyAddress;

		private static int OnInputWidgetDelta__DelegateSignature_Drag_Offset;

		private static bool OnInputWidgetDelta__DelegateSignature_Rot_IsValid;

		private static FFieldAddress OnInputWidgetDelta__DelegateSignature_Rot_PropertyAddress;

		private static int OnInputWidgetDelta__DelegateSignature_Rot_Offset;

		private static bool OnInputWidgetDelta__DelegateSignature_Scale_IsValid;

		private static FFieldAddress OnInputWidgetDelta__DelegateSignature_Scale_PropertyAddress;

		private static int OnInputWidgetDelta__DelegateSignature_Scale_Offset;

		private static bool OnInputWidgetDelta__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnInputWidgetDelta__DelegateSignature_Instance_PropertyAddress;

		private static int OnInputWidgetDelta__DelegateSignature_Instance_Offset;

		private static bool OnInputWidgetDelta__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnInputWidgetDelta__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnInputWidgetDelta__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnInputWidgetDelta()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnInputWidgetDelta__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputWidgetDelta__DelegateSignature");
			OnInputWidgetDelta__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputWidgetDelta__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnInputWidgetDelta__DelegateSignature_Drag_PropertyAddress, OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Drag");
			OnInputWidgetDelta__DelegateSignature_Drag_Offset = NativeReflectionCached.GetPropertyOffset(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Drag");
			OnInputWidgetDelta__DelegateSignature_Drag_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Drag", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputWidgetDelta__DelegateSignature_Rot_PropertyAddress, OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Rot");
			OnInputWidgetDelta__DelegateSignature_Rot_Offset = NativeReflectionCached.GetPropertyOffset(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Rot");
			OnInputWidgetDelta__DelegateSignature_Rot_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Rot", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputWidgetDelta__DelegateSignature_Scale_PropertyAddress, OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Scale");
			OnInputWidgetDelta__DelegateSignature_Scale_Offset = NativeReflectionCached.GetPropertyOffset(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Scale");
			OnInputWidgetDelta__DelegateSignature_Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Scale", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputWidgetDelta__DelegateSignature_Instance_PropertyAddress, OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Instance");
			OnInputWidgetDelta__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Instance");
			OnInputWidgetDelta__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputWidgetDelta__DelegateSignature_ReturnValue_PropertyAddress, OnInputWidgetDelta__DelegateSignature_FunctionAddress, "ReturnValue");
			OnInputWidgetDelta__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "ReturnValue");
			OnInputWidgetDelta__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputWidgetDelta__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			OnInputWidgetDelta__DelegateSignature_IsValid = OnInputWidgetDelta__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInputWidgetDelta__DelegateSignature_Drag_IsValid && OnInputWidgetDelta__DelegateSignature_Rot_IsValid && OnInputWidgetDelta__DelegateSignature_Scale_IsValid && OnInputWidgetDelta__DelegateSignature_Instance_IsValid && OnInputWidgetDelta__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputWidgetDelta__DelegateSignature", OnInputWidgetDelta__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker(out FVector Drag, out FRotator Rot, out FVector Scale, UJavascriptEditorViewport Instance)
		{
			if (!OnInputWidgetDelta__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputWidgetDelta__DelegateSignature");
				Drag = default(FVector);
				Rot = default(FRotator);
				Scale = default(FVector);
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnInputWidgetDelta__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputWidgetDelta__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnInputWidgetDelta__DelegateSignature_Instance_Offset), 0, OnInputWidgetDelta__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				Drag = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, OnInputWidgetDelta__DelegateSignature_Drag_Offset), 0, OnInputWidgetDelta__DelegateSignature_Drag_PropertyAddress.Address);
				Rot = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, OnInputWidgetDelta__DelegateSignature_Rot_Offset), 0, OnInputWidgetDelta__DelegateSignature_Rot_PropertyAddress.Address);
				Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, OnInputWidgetDelta__DelegateSignature_Scale_Offset), 0, OnInputWidgetDelta__DelegateSignature_Scale_PropertyAddress.Address);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnInputWidgetDelta__DelegateSignature_ReturnValue_Offset), 0, OnInputWidgetDelta__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			Drag = default(FVector);
			Rot = default(FRotator);
			Scale = default(FVector);
			return false;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputKey__DelegateSignature")]
	public class FOnInputKey : FDelegate<FOnInputKey.Signature>
	{
		public delegate bool Signature(int ControllerId, FKey Key, EInputEventType Event, UJavascriptEditorViewport Instance);

		private static bool OnInputKey__DelegateSignature_IsValid;

		private static IntPtr OnInputKey__DelegateSignature_FunctionAddress;

		private static int OnInputKey__DelegateSignature_ParamsSize;

		private static bool OnInputKey__DelegateSignature_ControllerId_IsValid;

		private static FFieldAddress OnInputKey__DelegateSignature_ControllerId_PropertyAddress;

		private static int OnInputKey__DelegateSignature_ControllerId_Offset;

		private static bool OnInputKey__DelegateSignature_Key_IsValid;

		private static FFieldAddress OnInputKey__DelegateSignature_Key_PropertyAddress;

		private static int OnInputKey__DelegateSignature_Key_Offset;

		private static bool OnInputKey__DelegateSignature_Event_IsValid;

		private static FFieldAddress OnInputKey__DelegateSignature_Event_PropertyAddress;

		private static int OnInputKey__DelegateSignature_Event_Offset;

		private static bool OnInputKey__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnInputKey__DelegateSignature_Instance_PropertyAddress;

		private static int OnInputKey__DelegateSignature_Instance_Offset;

		private static bool OnInputKey__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnInputKey__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnInputKey__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnInputKey()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnInputKey__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputKey__DelegateSignature");
			OnInputKey__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputKey__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnInputKey__DelegateSignature_ControllerId_PropertyAddress, OnInputKey__DelegateSignature_FunctionAddress, "ControllerId");
			OnInputKey__DelegateSignature_ControllerId_Offset = NativeReflectionCached.GetPropertyOffset(OnInputKey__DelegateSignature_FunctionAddress, "ControllerId");
			OnInputKey__DelegateSignature_ControllerId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputKey__DelegateSignature_FunctionAddress, "ControllerId", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputKey__DelegateSignature_Key_PropertyAddress, OnInputKey__DelegateSignature_FunctionAddress, "Key");
			OnInputKey__DelegateSignature_Key_Offset = NativeReflectionCached.GetPropertyOffset(OnInputKey__DelegateSignature_FunctionAddress, "Key");
			OnInputKey__DelegateSignature_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputKey__DelegateSignature_FunctionAddress, "Key", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputKey__DelegateSignature_Event_PropertyAddress, OnInputKey__DelegateSignature_FunctionAddress, "Event");
			OnInputKey__DelegateSignature_Event_Offset = NativeReflectionCached.GetPropertyOffset(OnInputKey__DelegateSignature_FunctionAddress, "Event");
			OnInputKey__DelegateSignature_Event_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputKey__DelegateSignature_FunctionAddress, "Event", Classes.FByteProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputKey__DelegateSignature_Instance_PropertyAddress, OnInputKey__DelegateSignature_FunctionAddress, "Instance");
			OnInputKey__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnInputKey__DelegateSignature_FunctionAddress, "Instance");
			OnInputKey__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputKey__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputKey__DelegateSignature_ReturnValue_PropertyAddress, OnInputKey__DelegateSignature_FunctionAddress, "ReturnValue");
			OnInputKey__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnInputKey__DelegateSignature_FunctionAddress, "ReturnValue");
			OnInputKey__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputKey__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			OnInputKey__DelegateSignature_IsValid = OnInputKey__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInputKey__DelegateSignature_ControllerId_IsValid && OnInputKey__DelegateSignature_Key_IsValid && OnInputKey__DelegateSignature_Event_IsValid && OnInputKey__DelegateSignature_Instance_IsValid && OnInputKey__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputKey__DelegateSignature", OnInputKey__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker(int ControllerId, FKey Key, EInputEventType Event, UJavascriptEditorViewport Instance)
		{
			if (!OnInputKey__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputKey__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnInputKey__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputKey__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnInputKey__DelegateSignature_ControllerId_Offset), 0, OnInputKey__DelegateSignature_ControllerId_PropertyAddress.Address, ControllerId);
				NativeReflection.InitializeValue_InContainer(OnInputKey__DelegateSignature_Key_PropertyAddress.Address, intPtr);
				FKey.ToNative(IntPtr.Add(intPtr, OnInputKey__DelegateSignature_Key_Offset), 0, OnInputKey__DelegateSignature_Key_PropertyAddress.Address, Key);
				EnumMarshaler<EInputEventType>.ToNative(IntPtr.Add(intPtr, OnInputKey__DelegateSignature_Event_Offset), 0, OnInputKey__DelegateSignature_Event_PropertyAddress.Address, Event);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnInputKey__DelegateSignature_Instance_Offset), 0, OnInputKey__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnInputKey__DelegateSignature_Key_PropertyAddress.Address, intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnInputKey__DelegateSignature_ReturnValue_Offset), 0, OnInputKey__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputAxis__DelegateSignature")]
	public class FOnInputAxis : FDelegate<FOnInputAxis.Signature>
	{
		public delegate bool Signature(int ControllerId, FKey Key, float Delta, float DeltaTime, UJavascriptEditorViewport Instance);

		private static bool OnInputAxis__DelegateSignature_IsValid;

		private static IntPtr OnInputAxis__DelegateSignature_FunctionAddress;

		private static int OnInputAxis__DelegateSignature_ParamsSize;

		private static bool OnInputAxis__DelegateSignature_ControllerId_IsValid;

		private static FFieldAddress OnInputAxis__DelegateSignature_ControllerId_PropertyAddress;

		private static int OnInputAxis__DelegateSignature_ControllerId_Offset;

		private static bool OnInputAxis__DelegateSignature_Key_IsValid;

		private static FFieldAddress OnInputAxis__DelegateSignature_Key_PropertyAddress;

		private static int OnInputAxis__DelegateSignature_Key_Offset;

		private static bool OnInputAxis__DelegateSignature_Delta_IsValid;

		private static FFieldAddress OnInputAxis__DelegateSignature_Delta_PropertyAddress;

		private static int OnInputAxis__DelegateSignature_Delta_Offset;

		private static bool OnInputAxis__DelegateSignature_DeltaTime_IsValid;

		private static FFieldAddress OnInputAxis__DelegateSignature_DeltaTime_PropertyAddress;

		private static int OnInputAxis__DelegateSignature_DeltaTime_Offset;

		private static bool OnInputAxis__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnInputAxis__DelegateSignature_Instance_PropertyAddress;

		private static int OnInputAxis__DelegateSignature_Instance_Offset;

		private static bool OnInputAxis__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnInputAxis__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnInputAxis__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnInputAxis()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnInputAxis__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputAxis__DelegateSignature");
			OnInputAxis__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnInputAxis__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnInputAxis__DelegateSignature_ControllerId_PropertyAddress, OnInputAxis__DelegateSignature_FunctionAddress, "ControllerId");
			OnInputAxis__DelegateSignature_ControllerId_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxis__DelegateSignature_FunctionAddress, "ControllerId");
			OnInputAxis__DelegateSignature_ControllerId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxis__DelegateSignature_FunctionAddress, "ControllerId", Classes.FIntProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputAxis__DelegateSignature_Key_PropertyAddress, OnInputAxis__DelegateSignature_FunctionAddress, "Key");
			OnInputAxis__DelegateSignature_Key_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxis__DelegateSignature_FunctionAddress, "Key");
			OnInputAxis__DelegateSignature_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxis__DelegateSignature_FunctionAddress, "Key", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputAxis__DelegateSignature_Delta_PropertyAddress, OnInputAxis__DelegateSignature_FunctionAddress, "Delta");
			OnInputAxis__DelegateSignature_Delta_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxis__DelegateSignature_FunctionAddress, "Delta");
			OnInputAxis__DelegateSignature_Delta_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxis__DelegateSignature_FunctionAddress, "Delta", Classes.FFloatProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputAxis__DelegateSignature_DeltaTime_PropertyAddress, OnInputAxis__DelegateSignature_FunctionAddress, "DeltaTime");
			OnInputAxis__DelegateSignature_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxis__DelegateSignature_FunctionAddress, "DeltaTime");
			OnInputAxis__DelegateSignature_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxis__DelegateSignature_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputAxis__DelegateSignature_Instance_PropertyAddress, OnInputAxis__DelegateSignature_FunctionAddress, "Instance");
			OnInputAxis__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxis__DelegateSignature_FunctionAddress, "Instance");
			OnInputAxis__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxis__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnInputAxis__DelegateSignature_ReturnValue_PropertyAddress, OnInputAxis__DelegateSignature_FunctionAddress, "ReturnValue");
			OnInputAxis__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnInputAxis__DelegateSignature_FunctionAddress, "ReturnValue");
			OnInputAxis__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnInputAxis__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
			OnInputAxis__DelegateSignature_IsValid = OnInputAxis__DelegateSignature_FunctionAddress != IntPtr.Zero && OnInputAxis__DelegateSignature_ControllerId_IsValid && OnInputAxis__DelegateSignature_Key_IsValid && OnInputAxis__DelegateSignature_Delta_IsValid && OnInputAxis__DelegateSignature_DeltaTime_IsValid && OnInputAxis__DelegateSignature_Instance_IsValid && OnInputAxis__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputAxis__DelegateSignature", OnInputAxis__DelegateSignature_IsValid);
		}

		private unsafe bool Invoker(int ControllerId, FKey Key, float Delta, float DeltaTime, UJavascriptEditorViewport Instance)
		{
			if (!OnInputAxis__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputAxis__DelegateSignature");
				return false;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnInputAxis__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnInputAxis__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnInputAxis__DelegateSignature_ControllerId_Offset), 0, OnInputAxis__DelegateSignature_ControllerId_PropertyAddress.Address, ControllerId);
				NativeReflection.InitializeValue_InContainer(OnInputAxis__DelegateSignature_Key_PropertyAddress.Address, intPtr);
				FKey.ToNative(IntPtr.Add(intPtr, OnInputAxis__DelegateSignature_Key_Offset), 0, OnInputAxis__DelegateSignature_Key_PropertyAddress.Address, Key);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputAxis__DelegateSignature_Delta_Offset), 0, OnInputAxis__DelegateSignature_Delta_PropertyAddress.Address, Delta);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnInputAxis__DelegateSignature_DeltaTime_Offset), 0, OnInputAxis__DelegateSignature_DeltaTime_PropertyAddress.Address, DeltaTime);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnInputAxis__DelegateSignature_Instance_Offset), 0, OnInputAxis__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnInputAxis__DelegateSignature_Key_PropertyAddress.Address, intPtr);
				return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OnInputAxis__DelegateSignature_ReturnValue_Offset), 0, OnInputAxis__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return false;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetRotation__DelegateSignature")]
	public class FOnGetWidgetRotation : FDelegate<FOnGetWidgetRotation.Signature>
	{
		public delegate FRotator Signature(UJavascriptEditorViewport Instance);

		private static bool OnGetWidgetRotation__DelegateSignature_IsValid;

		private static IntPtr OnGetWidgetRotation__DelegateSignature_FunctionAddress;

		private static int OnGetWidgetRotation__DelegateSignature_ParamsSize;

		private static bool OnGetWidgetRotation__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnGetWidgetRotation__DelegateSignature_Instance_PropertyAddress;

		private static int OnGetWidgetRotation__DelegateSignature_Instance_Offset;

		private static bool OnGetWidgetRotation__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnGetWidgetRotation__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnGetWidgetRotation__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGetWidgetRotation()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGetWidgetRotation__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetRotation__DelegateSignature");
			OnGetWidgetRotation__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetWidgetRotation__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGetWidgetRotation__DelegateSignature_Instance_PropertyAddress, OnGetWidgetRotation__DelegateSignature_FunctionAddress, "Instance");
			OnGetWidgetRotation__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnGetWidgetRotation__DelegateSignature_FunctionAddress, "Instance");
			OnGetWidgetRotation__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetWidgetRotation__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnGetWidgetRotation__DelegateSignature_ReturnValue_PropertyAddress, OnGetWidgetRotation__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetWidgetRotation__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGetWidgetRotation__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetWidgetRotation__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetWidgetRotation__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			OnGetWidgetRotation__DelegateSignature_IsValid = OnGetWidgetRotation__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetWidgetRotation__DelegateSignature_Instance_IsValid && OnGetWidgetRotation__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetRotation__DelegateSignature", OnGetWidgetRotation__DelegateSignature_IsValid);
		}

		private unsafe FRotator Invoker(UJavascriptEditorViewport Instance)
		{
			if (!OnGetWidgetRotation__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetRotation__DelegateSignature");
				return default(FRotator);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGetWidgetRotation__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetWidgetRotation__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnGetWidgetRotation__DelegateSignature_Instance_Offset), 0, OnGetWidgetRotation__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, OnGetWidgetRotation__DelegateSignature_ReturnValue_Offset), 0, OnGetWidgetRotation__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return default(FRotator);
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetMode__DelegateSignature")]
	public class FOnGetWidgetMode : FDelegate<FOnGetWidgetMode.Signature>
	{
		public delegate EJavascriptWidgetMode Signature(UJavascriptEditorViewport Instance);

		private static bool OnGetWidgetMode__DelegateSignature_IsValid;

		private static IntPtr OnGetWidgetMode__DelegateSignature_FunctionAddress;

		private static int OnGetWidgetMode__DelegateSignature_ParamsSize;

		private static bool OnGetWidgetMode__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnGetWidgetMode__DelegateSignature_Instance_PropertyAddress;

		private static int OnGetWidgetMode__DelegateSignature_Instance_Offset;

		private static bool OnGetWidgetMode__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnGetWidgetMode__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnGetWidgetMode__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGetWidgetMode()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGetWidgetMode__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetMode__DelegateSignature");
			OnGetWidgetMode__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetWidgetMode__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGetWidgetMode__DelegateSignature_Instance_PropertyAddress, OnGetWidgetMode__DelegateSignature_FunctionAddress, "Instance");
			OnGetWidgetMode__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnGetWidgetMode__DelegateSignature_FunctionAddress, "Instance");
			OnGetWidgetMode__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetWidgetMode__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnGetWidgetMode__DelegateSignature_ReturnValue_PropertyAddress, OnGetWidgetMode__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetWidgetMode__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGetWidgetMode__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetWidgetMode__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetWidgetMode__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
			OnGetWidgetMode__DelegateSignature_IsValid = OnGetWidgetMode__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetWidgetMode__DelegateSignature_Instance_IsValid && OnGetWidgetMode__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetMode__DelegateSignature", OnGetWidgetMode__DelegateSignature_IsValid);
		}

		private unsafe EJavascriptWidgetMode Invoker(UJavascriptEditorViewport Instance)
		{
			if (!OnGetWidgetMode__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetMode__DelegateSignature");
				return EJavascriptWidgetMode.WM_Translate;
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGetWidgetMode__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetWidgetMode__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnGetWidgetMode__DelegateSignature_Instance_Offset), 0, OnGetWidgetMode__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				return EnumMarshaler<EJavascriptWidgetMode>.FromNative(IntPtr.Add(intPtr, OnGetWidgetMode__DelegateSignature_ReturnValue_Offset), 0, OnGetWidgetMode__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return EJavascriptWidgetMode.WM_Translate;
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetLocation__DelegateSignature")]
	public class FOnGetWidgetLocation : FDelegate<FOnGetWidgetLocation.Signature>
	{
		public delegate FVector Signature(UJavascriptEditorViewport Instance);

		private static bool OnGetWidgetLocation__DelegateSignature_IsValid;

		private static IntPtr OnGetWidgetLocation__DelegateSignature_FunctionAddress;

		private static int OnGetWidgetLocation__DelegateSignature_ParamsSize;

		private static bool OnGetWidgetLocation__DelegateSignature_Instance_IsValid;

		private static FFieldAddress OnGetWidgetLocation__DelegateSignature_Instance_PropertyAddress;

		private static int OnGetWidgetLocation__DelegateSignature_Instance_Offset;

		private static bool OnGetWidgetLocation__DelegateSignature_ReturnValue_IsValid;

		private static FFieldAddress OnGetWidgetLocation__DelegateSignature_ReturnValue_PropertyAddress;

		private static int OnGetWidgetLocation__DelegateSignature_ReturnValue_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnGetWidgetLocation()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnGetWidgetLocation__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetLocation__DelegateSignature");
			OnGetWidgetLocation__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnGetWidgetLocation__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnGetWidgetLocation__DelegateSignature_Instance_PropertyAddress, OnGetWidgetLocation__DelegateSignature_FunctionAddress, "Instance");
			OnGetWidgetLocation__DelegateSignature_Instance_Offset = NativeReflectionCached.GetPropertyOffset(OnGetWidgetLocation__DelegateSignature_FunctionAddress, "Instance");
			OnGetWidgetLocation__DelegateSignature_Instance_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetWidgetLocation__DelegateSignature_FunctionAddress, "Instance", Classes.FObjectProperty);
			NativeReflectionCached.GetPropertyRef(ref OnGetWidgetLocation__DelegateSignature_ReturnValue_PropertyAddress, OnGetWidgetLocation__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetWidgetLocation__DelegateSignature_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OnGetWidgetLocation__DelegateSignature_FunctionAddress, "ReturnValue");
			OnGetWidgetLocation__DelegateSignature_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnGetWidgetLocation__DelegateSignature_FunctionAddress, "ReturnValue", Classes.FStructProperty);
			OnGetWidgetLocation__DelegateSignature_IsValid = OnGetWidgetLocation__DelegateSignature_FunctionAddress != IntPtr.Zero && OnGetWidgetLocation__DelegateSignature_Instance_IsValid && OnGetWidgetLocation__DelegateSignature_ReturnValue_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetLocation__DelegateSignature", OnGetWidgetLocation__DelegateSignature_IsValid);
		}

		private unsafe FVector Invoker(UJavascriptEditorViewport Instance)
		{
			if (!OnGetWidgetLocation__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetLocation__DelegateSignature");
				return default(FVector);
			}
			if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnGetWidgetLocation__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnGetWidgetLocation__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				UObjectMarshaler<UJavascriptEditorViewport>.ToNative(IntPtr.Add(intPtr, OnGetWidgetLocation__DelegateSignature_Instance_Offset), 0, OnGetWidgetLocation__DelegateSignature_Instance_PropertyAddress.Address, Instance);
				ProcessDelegate(intPtr);
				return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, OnGetWidgetLocation__DelegateSignature_ReturnValue_Offset), 0, OnGetWidgetLocation__DelegateSignature_ReturnValue_PropertyAddress.Address);
			}
			return default(FVector);
		}
	}

	private static bool OnClick_IsValid;

	private static int OnClick_Offset;

	private FOnViewportClick OnClick_DelegateCached;

	private static bool OnTrackingStarted_IsValid;

	private static int OnTrackingStarted_Offset;

	private FOnViewportTrackingStarted OnTrackingStarted_DelegateCached;

	private static bool OnTrackingStopped_IsValid;

	private static int OnTrackingStopped_Offset;

	private FOnViewportTrackingStopped OnTrackingStopped_DelegateCached;

	private static bool OnInputWidgetDelta_IsValid;

	private static int OnInputWidgetDelta_Offset;

	private FOnInputWidgetDelta OnInputWidgetDelta_DelegateCached;

	private static bool OnInputKey_IsValid;

	private static int OnInputKey_Offset;

	private FOnInputKey OnInputKey_DelegateCached;

	private static bool OnInputAxis_IsValid;

	private static int OnInputAxis_Offset;

	private FOnInputAxis OnInputAxis_DelegateCached;

	private static bool OnMouseEnter_IsValid;

	private static int OnMouseEnter_Offset;

	private FOnMouseEnter OnMouseEnter_DelegateCached;

	private static bool OnMouseMove_IsValid;

	private static int OnMouseMove_Offset;

	private FOnMouseMove OnMouseMove_DelegateCached;

	private static bool OnMouseLeave_IsValid;

	private static int OnMouseLeave_Offset;

	private FOnMouseLeave OnMouseLeave_DelegateCached;

	private static bool OnDraw_IsValid;

	private static int OnDraw_Offset;

	private FOnViewportDraw OnDraw_DelegateCached;

	private static bool OnDrawCanvas_IsValid;

	private static int OnDrawCanvas_Offset;

	private FOnViewportDrawCanvas OnDrawCanvas_DelegateCached;

	private static bool OnGetWidgetLocation_IsValid;

	private static int OnGetWidgetLocation_Offset;

	private FOnGetWidgetLocation OnGetWidgetLocation_DelegateCached;

	private static bool OnGetWidgetRotation_IsValid;

	private static int OnGetWidgetRotation_Offset;

	private FOnGetWidgetRotation OnGetWidgetRotation_DelegateCached;

	private static bool OnGetWidgetMode_IsValid;

	private static int OnGetWidgetMode_Offset;

	private FOnGetWidgetMode OnGetWidgetMode_DelegateCached;

	private static bool SetWidgetMode_IsValid;

	private static IntPtr SetWidgetMode_FunctionAddress;

	private static int SetWidgetMode_ParamsSize;

	private static bool SetWidgetMode_WidgetMode_IsValid;

	private static FFieldAddress SetWidgetMode_WidgetMode_PropertyAddress;

	private static int SetWidgetMode_WidgetMode_Offset;

	private static bool SetViewRotation_IsValid;

	private static IntPtr SetViewRotation_FunctionAddress;

	private static int SetViewRotation_ParamsSize;

	private static bool SetViewRotation_ViewRotation_IsValid;

	private static FFieldAddress SetViewRotation_ViewRotation_PropertyAddress;

	private static int SetViewRotation_ViewRotation_Offset;

	private static bool SetViewportType_IsValid;

	private static IntPtr SetViewportType_FunctionAddress;

	private static int SetViewportType_ParamsSize;

	private static bool SetViewportType_InViewportType_IsValid;

	private static FFieldAddress SetViewportType_InViewportType_PropertyAddress;

	private static int SetViewportType_InViewportType_Offset;

	private static bool SetViewMode_IsValid;

	private static IntPtr SetViewMode_FunctionAddress;

	private static int SetViewMode_ParamsSize;

	private static bool SetViewMode_InViewModeIndex_IsValid;

	private static FFieldAddress SetViewMode_InViewModeIndex_PropertyAddress;

	private static int SetViewMode_InViewModeIndex_Offset;

	private static bool SetViewLocation_IsValid;

	private static IntPtr SetViewLocation_FunctionAddress;

	private static int SetViewLocation_ParamsSize;

	private static bool SetViewLocation_ViewLocation_IsValid;

	private static FFieldAddress SetViewLocation_ViewLocation_PropertyAddress;

	private static int SetViewLocation_ViewLocation_Offset;

	private static bool SetViewFOV_IsValid;

	private static IntPtr SetViewFOV_FunctionAddress;

	private static int SetViewFOV_ParamsSize;

	private static bool SetViewFOV_InViewFOV_IsValid;

	private static FFieldAddress SetViewFOV_InViewFOV_PropertyAddress;

	private static int SetViewFOV_InViewFOV_Offset;

	private static bool SetSkyBrightness_IsValid;

	private static IntPtr SetSkyBrightness_FunctionAddress;

	private static int SetSkyBrightness_ParamsSize;

	private static bool SetSkyBrightness_SkyBrightness_IsValid;

	private static FFieldAddress SetSkyBrightness_SkyBrightness_PropertyAddress;

	private static int SetSkyBrightness_SkyBrightness_Offset;

	private static bool SetSimulatePhysics_IsValid;

	private static IntPtr SetSimulatePhysics_FunctionAddress;

	private static int SetSimulatePhysics_ParamsSize;

	private static bool SetSimulatePhysics_bShouldSimulatePhysics_IsValid;

	private static FFieldAddress SetSimulatePhysics_bShouldSimulatePhysics_PropertyAddress;

	private static int SetSimulatePhysics_bShouldSimulatePhysics_Offset;

	private static bool SetRealtime_IsValid;

	private static IntPtr SetRealtime_FunctionAddress;

	private static int SetRealtime_ParamsSize;

	private static bool SetRealtime_bInRealtime_IsValid;

	private static FFieldAddress SetRealtime_bInRealtime_PropertyAddress;

	private static int SetRealtime_bInRealtime_Offset;

	private static bool SetRealtime_bStoreCurrentValue_IsValid;

	private static FFieldAddress SetRealtime_bStoreCurrentValue_PropertyAddress;

	private static int SetRealtime_bStoreCurrentValue_Offset;

	private static bool SetProfileIndex_IsValid;

	private static IntPtr SetProfileIndex_FunctionAddress;

	private static int SetProfileIndex_ParamsSize;

	private static bool SetProfileIndex_InProfileIndex_IsValid;

	private static FFieldAddress SetProfileIndex_InProfileIndex_PropertyAddress;

	private static int SetProfileIndex_InProfileIndex_Offset;

	private static bool SetLightLocation_IsValid;

	private static IntPtr SetLightLocation_FunctionAddress;

	private static int SetLightLocation_ParamsSize;

	private static bool SetLightLocation_InLightPos_IsValid;

	private static FFieldAddress SetLightLocation_InLightPos_PropertyAddress;

	private static int SetLightLocation_InLightPos_Offset;

	private static bool SetLightDirection_IsValid;

	private static IntPtr SetLightDirection_FunctionAddress;

	private static int SetLightDirection_ParamsSize;

	private static bool SetLightDirection_InLightDir_IsValid;

	private static FFieldAddress SetLightDirection_InLightDir_PropertyAddress;

	private static int SetLightDirection_InLightDir_Offset;

	private static bool SetLightColor_IsValid;

	private static IntPtr SetLightColor_FunctionAddress;

	private static int SetLightColor_ParamsSize;

	private static bool SetLightColor_LightColor_IsValid;

	private static FFieldAddress SetLightColor_LightColor_PropertyAddress;

	private static int SetLightColor_LightColor_Offset;

	private static bool SetLightBrightness_IsValid;

	private static IntPtr SetLightBrightness_FunctionAddress;

	private static int SetLightBrightness_ParamsSize;

	private static bool SetLightBrightness_LightBrightness_IsValid;

	private static FFieldAddress SetLightBrightness_LightBrightness_PropertyAddress;

	private static int SetLightBrightness_LightBrightness_Offset;

	private static bool SetFloorOffset_IsValid;

	private static IntPtr SetFloorOffset_FunctionAddress;

	private static int SetFloorOffset_ParamsSize;

	private static bool SetFloorOffset_InFloorOffset_IsValid;

	private static FFieldAddress SetFloorOffset_InFloorOffset_PropertyAddress;

	private static int SetFloorOffset_InFloorOffset_Offset;

	private static bool SetEngineShowFlags_IsValid;

	private static IntPtr SetEngineShowFlags_FunctionAddress;

	private static int SetEngineShowFlags_ParamsSize;

	private static bool SetEngineShowFlags_In_IsValid;

	private static FFieldAddress SetEngineShowFlags_In_PropertyAddress;

	private static int SetEngineShowFlags_In_Offset;

	private static bool SetEngineShowFlags_ReturnValue_IsValid;

	private static FFieldAddress SetEngineShowFlags_ReturnValue_PropertyAddress;

	private static int SetEngineShowFlags_ReturnValue_Offset;

	private static bool SetCameraSpeedSetting_IsValid;

	private static IntPtr SetCameraSpeedSetting_FunctionAddress;

	private static int SetCameraSpeedSetting_ParamsSize;

	private static bool SetCameraSpeedSetting_SpeedSetting_IsValid;

	private static FFieldAddress SetCameraSpeedSetting_SpeedSetting_PropertyAddress;

	private static int SetCameraSpeedSetting_SpeedSetting_Offset;

	private static bool SetBackgroundColor_IsValid;

	private static IntPtr SetBackgroundColor_FunctionAddress;

	private static int SetBackgroundColor_ParamsSize;

	private static bool SetBackgroundColor_BackgroundColor_IsValid;

	private static FFieldAddress SetBackgroundColor_BackgroundColor_PropertyAddress;

	private static int SetBackgroundColor_BackgroundColor_Offset;

	private static bool RestoreRealtime_IsValid;

	private static IntPtr RestoreRealtime_FunctionAddress;

	private static int RestoreRealtime_ParamsSize;

	private static bool RestoreRealtime_bAllowDisable_IsValid;

	private static FFieldAddress RestoreRealtime_bAllowDisable_PropertyAddress;

	private static int RestoreRealtime_bAllowDisable_Offset;

	private static bool Redraw_IsValid;

	private static IntPtr Redraw_FunctionAddress;

	private static int Redraw_ParamsSize;

	private static bool ProjectWorldToScreen_IsValid;

	private static IntPtr ProjectWorldToScreen_FunctionAddress;

	private static int ProjectWorldToScreen_ParamsSize;

	private static bool ProjectWorldToScreen_WorldPosition_IsValid;

	private static FFieldAddress ProjectWorldToScreen_WorldPosition_PropertyAddress;

	private static int ProjectWorldToScreen_WorldPosition_Offset;

	private static bool ProjectWorldToScreen_OutScreenPosition_IsValid;

	private static FFieldAddress ProjectWorldToScreen_OutScreenPosition_PropertyAddress;

	private static int ProjectWorldToScreen_OutScreenPosition_Offset;

	private static bool OverridePostProcessSettings_IsValid;

	private static IntPtr OverridePostProcessSettings_FunctionAddress;

	private static int OverridePostProcessSettings_ParamsSize;

	private static bool OverridePostProcessSettings_PostProcessSettings_IsValid;

	private static FFieldAddress OverridePostProcessSettings_PostProcessSettings_PropertyAddress;

	private static int OverridePostProcessSettings_PostProcessSettings_Offset;

	private static bool OverridePostProcessSettings_Weight_IsValid;

	private static FFieldAddress OverridePostProcessSettings_Weight_PropertyAddress;

	private static int OverridePostProcessSettings_Weight_Offset;

	private static bool GetWidgetMode_IsValid;

	private static IntPtr GetWidgetMode_FunctionAddress;

	private static int GetWidgetMode_ParamsSize;

	private static bool GetWidgetMode_ReturnValue_IsValid;

	private static FFieldAddress GetWidgetMode_ReturnValue_PropertyAddress;

	private static int GetWidgetMode_ReturnValue_Offset;

	private static bool GetViewRotation_IsValid;

	private static IntPtr GetViewRotation_FunctionAddress;

	private static int GetViewRotation_ParamsSize;

	private static bool GetViewRotation_ReturnValue_IsValid;

	private static FFieldAddress GetViewRotation_ReturnValue_PropertyAddress;

	private static int GetViewRotation_ReturnValue_Offset;

	private static bool GetViewportWorld_IsValid;

	private static IntPtr GetViewportWorld_FunctionAddress;

	private static int GetViewportWorld_ParamsSize;

	private static bool GetViewportWorld_ReturnValue_IsValid;

	private static FFieldAddress GetViewportWorld_ReturnValue_PropertyAddress;

	private static int GetViewportWorld_ReturnValue_Offset;

	private static bool GetViewLocation_IsValid;

	private static IntPtr GetViewLocation_FunctionAddress;

	private static int GetViewLocation_ParamsSize;

	private static bool GetViewLocation_ReturnValue_IsValid;

	private static FFieldAddress GetViewLocation_ReturnValue_PropertyAddress;

	private static int GetViewLocation_ReturnValue_Offset;

	private static bool GetViewFOV_IsValid;

	private static IntPtr GetViewFOV_FunctionAddress;

	private static int GetViewFOV_ParamsSize;

	private static bool GetViewFOV_ReturnValue_IsValid;

	private static FFieldAddress GetViewFOV_ReturnValue_PropertyAddress;

	private static int GetViewFOV_ReturnValue_Offset;

	private static bool GetSkyComponent_IsValid;

	private static IntPtr GetSkyComponent_FunctionAddress;

	private static int GetSkyComponent_ParamsSize;

	private static bool GetSkyComponent_ReturnValue_IsValid;

	private static FFieldAddress GetSkyComponent_ReturnValue_PropertyAddress;

	private static int GetSkyComponent_ReturnValue_Offset;

	private static bool GetFloorMeshComponent_IsValid;

	private static IntPtr GetFloorMeshComponent_FunctionAddress;

	private static int GetFloorMeshComponent_ParamsSize;

	private static bool GetFloorMeshComponent_ReturnValue_IsValid;

	private static FFieldAddress GetFloorMeshComponent_ReturnValue_PropertyAddress;

	private static int GetFloorMeshComponent_ReturnValue_Offset;

	private static bool GetEngineShowFlags_IsValid;

	private static IntPtr GetEngineShowFlags_FunctionAddress;

	private static int GetEngineShowFlags_ParamsSize;

	private static bool GetEngineShowFlags_ReturnValue_IsValid;

	private static FFieldAddress GetEngineShowFlags_ReturnValue_PropertyAddress;

	private static int GetEngineShowFlags_ReturnValue_Offset;

	private static bool GetDefaultSphereReflectionComponent_IsValid;

	private static IntPtr GetDefaultSphereReflectionComponent_FunctionAddress;

	private static int GetDefaultSphereReflectionComponent_ParamsSize;

	private static bool GetDefaultSphereReflectionComponent_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultSphereReflectionComponent_ReturnValue_PropertyAddress;

	private static int GetDefaultSphereReflectionComponent_ReturnValue_Offset;

	private static bool GetDefaultSkySphereComponent_IsValid;

	private static IntPtr GetDefaultSkySphereComponent_FunctionAddress;

	private static int GetDefaultSkySphereComponent_ParamsSize;

	private static bool GetDefaultSkySphereComponent_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultSkySphereComponent_ReturnValue_PropertyAddress;

	private static int GetDefaultSkySphereComponent_ReturnValue_Offset;

	private static bool GetDefaultSkyLightComponent_IsValid;

	private static IntPtr GetDefaultSkyLightComponent_FunctionAddress;

	private static int GetDefaultSkyLightComponent_ParamsSize;

	private static bool GetDefaultSkyLightComponent_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultSkyLightComponent_ReturnValue_PropertyAddress;

	private static int GetDefaultSkyLightComponent_ReturnValue_Offset;

	private static bool GetDefaultPostProcessComponent_IsValid;

	private static IntPtr GetDefaultPostProcessComponent_FunctionAddress;

	private static int GetDefaultPostProcessComponent_ParamsSize;

	private static bool GetDefaultPostProcessComponent_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultPostProcessComponent_ReturnValue_PropertyAddress;

	private static int GetDefaultPostProcessComponent_ReturnValue_Offset;

	private static bool GetDefaultInstancedSkyMaterial_IsValid;

	private static IntPtr GetDefaultInstancedSkyMaterial_FunctionAddress;

	private static int GetDefaultInstancedSkyMaterial_ParamsSize;

	private static bool GetDefaultInstancedSkyMaterial_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultInstancedSkyMaterial_ReturnValue_PropertyAddress;

	private static int GetDefaultInstancedSkyMaterial_ReturnValue_Offset;

	private static bool GetDefaultDirectionalLightComponent_IsValid;

	private static IntPtr GetDefaultDirectionalLightComponent_FunctionAddress;

	private static int GetDefaultDirectionalLightComponent_ParamsSize;

	private static bool GetDefaultDirectionalLightComponent_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultDirectionalLightComponent_ReturnValue_PropertyAddress;

	private static int GetDefaultDirectionalLightComponent_ReturnValue_Offset;

	private static bool GetDefaultAssetViewerSettings_IsValid;

	private static IntPtr GetDefaultAssetViewerSettings_FunctionAddress;

	private static int GetDefaultAssetViewerSettings_ParamsSize;

	private static bool GetDefaultAssetViewerSettings_ReturnValue_IsValid;

	private static FFieldAddress GetDefaultAssetViewerSettings_ReturnValue_PropertyAddress;

	private static int GetDefaultAssetViewerSettings_ReturnValue_Offset;

	private static bool GetCurrentProfileIndex_IsValid;

	private static IntPtr GetCurrentProfileIndex_FunctionAddress;

	private static int GetCurrentProfileIndex_ParamsSize;

	private static bool GetCurrentProfileIndex_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentProfileIndex_ReturnValue_PropertyAddress;

	private static int GetCurrentProfileIndex_ReturnValue_Offset;

	private static bool GetCameraSpeedSetting_IsValid;

	private static IntPtr GetCameraSpeedSetting_FunctionAddress;

	private static int GetCameraSpeedSetting_ParamsSize;

	private static bool GetCameraSpeedSetting_ReturnValue_IsValid;

	private static FFieldAddress GetCameraSpeedSetting_ReturnValue_PropertyAddress;

	private static int GetCameraSpeedSetting_ReturnValue_Offset;

	private static bool DeprojectScreenToWorld_IsValid;

	private static IntPtr DeprojectScreenToWorld_FunctionAddress;

	private static int DeprojectScreenToWorld_ParamsSize;

	private static bool DeprojectScreenToWorld_ScreenPosition_IsValid;

	private static FFieldAddress DeprojectScreenToWorld_ScreenPosition_PropertyAddress;

	private static int DeprojectScreenToWorld_ScreenPosition_Offset;

	private static bool DeprojectScreenToWorld_OutRayOrigin_IsValid;

	private static FFieldAddress DeprojectScreenToWorld_OutRayOrigin_PropertyAddress;

	private static int DeprojectScreenToWorld_OutRayOrigin_Offset;

	private static bool DeprojectScreenToWorld_OutRayDirection_IsValid;

	private static FFieldAddress DeprojectScreenToWorld_OutRayDirection_PropertyAddress;

	private static int DeprojectScreenToWorld_OutRayDirection_Offset;

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnClick")]
	public FOnViewportClick OnClick
	{
		get
		{
			CheckDestroyed();
			if (!OnClick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnClick");
				return new FOnViewportClick();
			}
			if (OnClick_DelegateCached == null)
			{
				OnClick_DelegateCached = new FOnViewportClick();
				OnClick_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnClick_Offset));
			}
			return OnClick_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnTrackingStarted")]
	public FOnViewportTrackingStarted OnTrackingStarted
	{
		get
		{
			CheckDestroyed();
			if (!OnTrackingStarted_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnTrackingStarted");
				return new FOnViewportTrackingStarted();
			}
			if (OnTrackingStarted_DelegateCached == null)
			{
				OnTrackingStarted_DelegateCached = new FOnViewportTrackingStarted();
				OnTrackingStarted_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTrackingStarted_Offset));
			}
			return OnTrackingStarted_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnTrackingStopped")]
	public FOnViewportTrackingStopped OnTrackingStopped
	{
		get
		{
			CheckDestroyed();
			if (!OnTrackingStopped_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnTrackingStopped");
				return new FOnViewportTrackingStopped();
			}
			if (OnTrackingStopped_DelegateCached == null)
			{
				OnTrackingStopped_DelegateCached = new FOnViewportTrackingStopped();
				OnTrackingStopped_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnTrackingStopped_Offset));
			}
			return OnTrackingStopped_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputWidgetDelta")]
	public FOnInputWidgetDelta OnInputWidgetDelta
	{
		get
		{
			CheckDestroyed();
			if (!OnInputWidgetDelta_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputWidgetDelta");
				return new FOnInputWidgetDelta();
			}
			if (OnInputWidgetDelta_DelegateCached == null)
			{
				OnInputWidgetDelta_DelegateCached = new FOnInputWidgetDelta();
				OnInputWidgetDelta_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputWidgetDelta_Offset));
			}
			return OnInputWidgetDelta_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputKey")]
	public FOnInputKey OnInputKey
	{
		get
		{
			CheckDestroyed();
			if (!OnInputKey_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputKey");
				return new FOnInputKey();
			}
			if (OnInputKey_DelegateCached == null)
			{
				OnInputKey_DelegateCached = new FOnInputKey();
				OnInputKey_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputKey_Offset));
			}
			return OnInputKey_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputAxis")]
	public FOnInputAxis OnInputAxis
	{
		get
		{
			CheckDestroyed();
			if (!OnInputAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnInputAxis");
				return new FOnInputAxis();
			}
			if (OnInputAxis_DelegateCached == null)
			{
				OnInputAxis_DelegateCached = new FOnInputAxis();
				OnInputAxis_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnInputAxis_Offset));
			}
			return OnInputAxis_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseEnter")]
	public FOnMouseEnter OnMouseEnter
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseEnter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseEnter");
				return new FOnMouseEnter();
			}
			if (OnMouseEnter_DelegateCached == null)
			{
				OnMouseEnter_DelegateCached = new FOnMouseEnter();
				OnMouseEnter_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseEnter_Offset));
			}
			return OnMouseEnter_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseMove")]
	public FOnMouseMove OnMouseMove
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseMove");
				return new FOnMouseMove();
			}
			if (OnMouseMove_DelegateCached == null)
			{
				OnMouseMove_DelegateCached = new FOnMouseMove();
				OnMouseMove_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseMove_Offset));
			}
			return OnMouseMove_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseLeave")]
	public FOnMouseLeave OnMouseLeave
	{
		get
		{
			CheckDestroyed();
			if (!OnMouseLeave_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnMouseLeave");
				return new FOnMouseLeave();
			}
			if (OnMouseLeave_DelegateCached == null)
			{
				OnMouseLeave_DelegateCached = new FOnMouseLeave();
				OnMouseLeave_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnMouseLeave_Offset));
			}
			return OnMouseLeave_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnDraw")]
	public FOnViewportDraw OnDraw
	{
		get
		{
			CheckDestroyed();
			if (!OnDraw_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnDraw");
				return new FOnViewportDraw();
			}
			if (OnDraw_DelegateCached == null)
			{
				OnDraw_DelegateCached = new FOnViewportDraw();
				OnDraw_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDraw_Offset));
			}
			return OnDraw_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnDrawCanvas")]
	public FOnViewportDrawCanvas OnDrawCanvas
	{
		get
		{
			CheckDestroyed();
			if (!OnDrawCanvas_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnDrawCanvas");
				return new FOnViewportDrawCanvas();
			}
			if (OnDrawCanvas_DelegateCached == null)
			{
				OnDrawCanvas_DelegateCached = new FOnViewportDrawCanvas();
				OnDrawCanvas_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDrawCanvas_Offset));
			}
			return OnDrawCanvas_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetLocation")]
	public FOnGetWidgetLocation OnGetWidgetLocation
	{
		get
		{
			CheckDestroyed();
			if (!OnGetWidgetLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetLocation");
				return new FOnGetWidgetLocation();
			}
			if (OnGetWidgetLocation_DelegateCached == null)
			{
				OnGetWidgetLocation_DelegateCached = new FOnGetWidgetLocation();
				OnGetWidgetLocation_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetWidgetLocation_Offset));
			}
			return OnGetWidgetLocation_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetRotation")]
	public FOnGetWidgetRotation OnGetWidgetRotation
	{
		get
		{
			CheckDestroyed();
			if (!OnGetWidgetRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetRotation");
				return new FOnGetWidgetRotation();
			}
			if (OnGetWidgetRotation_DelegateCached == null)
			{
				OnGetWidgetRotation_DelegateCached = new FOnGetWidgetRotation();
				OnGetWidgetRotation_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetWidgetRotation_Offset));
			}
			return OnGetWidgetRotation_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503668347372033uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetMode")]
	public FOnGetWidgetMode OnGetWidgetMode
	{
		get
		{
			CheckDestroyed();
			if (!OnGetWidgetMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OnGetWidgetMode");
				return new FOnGetWidgetMode();
			}
			if (OnGetWidgetMode_DelegateCached == null)
			{
				OnGetWidgetMode_DelegateCached = new FOnGetWidgetMode();
				OnGetWidgetMode_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnGetWidgetMode_Offset));
			}
			return OnGetWidgetMode_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetWidgetMode")]
	public unsafe void SetWidgetMode(EJavascriptWidgetMode WidgetMode)
	{
		CheckDestroyed();
		if (!SetWidgetMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetWidgetMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetWidgetMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetWidgetMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EJavascriptWidgetMode>.ToNative(IntPtr.Add(intPtr, SetWidgetMode_WidgetMode_Offset), 0, SetWidgetMode_WidgetMode_PropertyAddress.Address, WidgetMode);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetWidgetMode_FunctionAddress, intPtr, SetWidgetMode_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewRotation")]
	public unsafe void SetViewRotation(FRotator ViewRotation)
	{
		CheckDestroyed();
		if (!SetViewRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewRotation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetViewRotation_ViewRotation_Offset), 0, SetViewRotation_ViewRotation_PropertyAddress.Address, ViewRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewRotation_FunctionAddress, intPtr, SetViewRotation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewportType")]
	public unsafe void SetViewportType(ELevelViewportType InViewportType)
	{
		CheckDestroyed();
		if (!SetViewportType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewportType");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewportType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewportType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELevelViewportType>.ToNative(IntPtr.Add(intPtr, SetViewportType_InViewportType_Offset), 0, SetViewportType_InViewportType_PropertyAddress.Address, InViewportType);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewportType_FunctionAddress, intPtr, SetViewportType_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewMode")]
	public unsafe void SetViewMode(EViewModeIndex InViewModeIndex)
	{
		CheckDestroyed();
		if (!SetViewMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EViewModeIndex>.ToNative(IntPtr.Add(intPtr, SetViewMode_InViewModeIndex_Offset), 0, SetViewMode_InViewModeIndex_PropertyAddress.Address, InViewModeIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewMode_FunctionAddress, intPtr, SetViewMode_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewLocation")]
	public unsafe void SetViewLocation(FVector ViewLocation)
	{
		CheckDestroyed();
		if (!SetViewLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetViewLocation_ViewLocation_Offset), 0, SetViewLocation_ViewLocation_PropertyAddress.Address, ViewLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewLocation_FunctionAddress, intPtr, SetViewLocation_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewFOV")]
	public unsafe void SetViewFOV(float InViewFOV)
	{
		CheckDestroyed();
		if (!SetViewFOV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewFOV");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetViewFOV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetViewFOV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetViewFOV_InViewFOV_Offset), 0, SetViewFOV_InViewFOV_PropertyAddress.Address, InViewFOV);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetViewFOV_FunctionAddress, intPtr, SetViewFOV_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetSkyBrightness")]
	public unsafe void SetSkyBrightness(float SkyBrightness)
	{
		CheckDestroyed();
		if (!SetSkyBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetSkyBrightness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSkyBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSkyBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetSkyBrightness_SkyBrightness_Offset), 0, SetSkyBrightness_SkyBrightness_PropertyAddress.Address, SkyBrightness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSkyBrightness_FunctionAddress, intPtr, SetSkyBrightness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetSimulatePhysics")]
	public unsafe void SetSimulatePhysics(bool bShouldSimulatePhysics)
	{
		CheckDestroyed();
		if (!SetSimulatePhysics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetSimulatePhysics");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSimulatePhysics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSimulatePhysics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSimulatePhysics_bShouldSimulatePhysics_Offset), 0, SetSimulatePhysics_bShouldSimulatePhysics_PropertyAddress.Address, bShouldSimulatePhysics);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSimulatePhysics_FunctionAddress, intPtr, SetSimulatePhysics_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetRealtime")]
	public unsafe void SetRealtime(bool bInRealtime, bool bStoreCurrentValue)
	{
		CheckDestroyed();
		if (!SetRealtime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetRealtime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRealtime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRealtime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRealtime_bInRealtime_Offset), 0, SetRealtime_bInRealtime_PropertyAddress.Address, bInRealtime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetRealtime_bStoreCurrentValue_Offset), 0, SetRealtime_bStoreCurrentValue_PropertyAddress.Address, bStoreCurrentValue);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRealtime_FunctionAddress, intPtr, SetRealtime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetProfileIndex")]
	public unsafe void SetProfileIndex(int InProfileIndex)
	{
		CheckDestroyed();
		if (!SetProfileIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetProfileIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetProfileIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetProfileIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetProfileIndex_InProfileIndex_Offset), 0, SetProfileIndex_InProfileIndex_PropertyAddress.Address, InProfileIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetProfileIndex_FunctionAddress, intPtr, SetProfileIndex_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightLocation")]
	public unsafe void SetLightLocation(FVector InLightPos)
	{
		CheckDestroyed();
		if (!SetLightLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetLightLocation_InLightPos_Offset), 0, SetLightLocation_InLightPos_PropertyAddress.Address, InLightPos);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightLocation_FunctionAddress, intPtr, SetLightLocation_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightDirection")]
	public unsafe void SetLightDirection(FRotator InLightDir)
	{
		CheckDestroyed();
		if (!SetLightDirection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightDirection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightDirection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightDirection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, SetLightDirection_InLightDir_Offset), 0, SetLightDirection_InLightDir_PropertyAddress.Address, InLightDir);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightDirection_FunctionAddress, intPtr, SetLightDirection_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightColor")]
	public unsafe void SetLightColor(FColor LightColor)
	{
		CheckDestroyed();
		if (!SetLightColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetLightColor_LightColor_Offset), 0, SetLightColor_LightColor_PropertyAddress.Address, LightColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightColor_FunctionAddress, intPtr, SetLightColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightBrightness")]
	public unsafe void SetLightBrightness(float LightBrightness)
	{
		CheckDestroyed();
		if (!SetLightBrightness_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightBrightness");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLightBrightness_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLightBrightness_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetLightBrightness_LightBrightness_Offset), 0, SetLightBrightness_LightBrightness_PropertyAddress.Address, LightBrightness);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLightBrightness_FunctionAddress, intPtr, SetLightBrightness_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetFloorOffset")]
	public unsafe void SetFloorOffset(float InFloorOffset)
	{
		CheckDestroyed();
		if (!SetFloorOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetFloorOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFloorOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFloorOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetFloorOffset_InFloorOffset_Offset), 0, SetFloorOffset_InFloorOffset_PropertyAddress.Address, InFloorOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetFloorOffset_FunctionAddress, intPtr, SetFloorOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetEngineShowFlags")]
	public unsafe bool SetEngineShowFlags(string In)
	{
		CheckDestroyed();
		if (!SetEngineShowFlags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetEngineShowFlags");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEngineShowFlags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEngineShowFlags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetEngineShowFlags_In_Offset), 0, SetEngineShowFlags_In_PropertyAddress.Address, In);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEngineShowFlags_FunctionAddress, intPtr, SetEngineShowFlags_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetEngineShowFlags_In_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetEngineShowFlags_ReturnValue_Offset), 0, SetEngineShowFlags_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetCameraSpeedSetting")]
	public unsafe void SetCameraSpeedSetting(int SpeedSetting)
	{
		CheckDestroyed();
		if (!SetCameraSpeedSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetCameraSpeedSetting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCameraSpeedSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCameraSpeedSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCameraSpeedSetting_SpeedSetting_Offset), 0, SetCameraSpeedSetting_SpeedSetting_PropertyAddress.Address, SpeedSetting);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCameraSpeedSetting_FunctionAddress, intPtr, SetCameraSpeedSetting_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:SetBackgroundColor")]
	public unsafe void SetBackgroundColor(FLinearColor BackgroundColor)
	{
		CheckDestroyed();
		if (!SetBackgroundColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:SetBackgroundColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBackgroundColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBackgroundColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetBackgroundColor_BackgroundColor_Offset), 0, SetBackgroundColor_BackgroundColor_PropertyAddress.Address, BackgroundColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBackgroundColor_FunctionAddress, intPtr, SetBackgroundColor_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:RestoreRealtime")]
	public unsafe void RestoreRealtime(bool bAllowDisable)
	{
		CheckDestroyed();
		if (!RestoreRealtime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:RestoreRealtime");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RestoreRealtime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RestoreRealtime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RestoreRealtime_bAllowDisable_Offset), 0, RestoreRealtime_bAllowDisable_PropertyAddress.Address, bAllowDisable);
		NativeReflection.InvokeFunctionOptimized(base.Address, RestoreRealtime_FunctionAddress, intPtr, RestoreRealtime_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:Redraw")]
	public unsafe void Redraw()
	{
		CheckDestroyed();
		if (!Redraw_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:Redraw");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Redraw_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Redraw_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Redraw_FunctionAddress, argsSize: Redraw_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:ProjectWorldToScreen")]
	public unsafe void ProjectWorldToScreen(FVector WorldPosition, out FVector2D OutScreenPosition)
	{
		CheckDestroyed();
		if (!ProjectWorldToScreen_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:ProjectWorldToScreen");
			OutScreenPosition = default(FVector2D);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProjectWorldToScreen_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProjectWorldToScreen_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ProjectWorldToScreen_WorldPosition_Offset), 0, ProjectWorldToScreen_WorldPosition_PropertyAddress.Address, WorldPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProjectWorldToScreen_FunctionAddress, intPtr, ProjectWorldToScreen_ParamsSize);
		OutScreenPosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, ProjectWorldToScreen_OutScreenPosition_Offset), 0, ProjectWorldToScreen_OutScreenPosition_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:OverridePostProcessSettings")]
	public unsafe void OverridePostProcessSettings(FPostProcessSettings PostProcessSettings, float Weight)
	{
		CheckDestroyed();
		if (!OverridePostProcessSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:OverridePostProcessSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OverridePostProcessSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OverridePostProcessSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OverridePostProcessSettings_PostProcessSettings_PropertyAddress.Address, intPtr);
		FPostProcessSettings.ToNative(IntPtr.Add(intPtr, OverridePostProcessSettings_PostProcessSettings_Offset), 0, OverridePostProcessSettings_PostProcessSettings_PropertyAddress.Address, PostProcessSettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OverridePostProcessSettings_Weight_Offset), 0, OverridePostProcessSettings_Weight_PropertyAddress.Address, Weight);
		NativeReflection.InvokeFunctionOptimized(base.Address, OverridePostProcessSettings_FunctionAddress, intPtr, OverridePostProcessSettings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OverridePostProcessSettings_PostProcessSettings_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetWidgetMode")]
	public unsafe EJavascriptWidgetMode GetWidgetMode()
	{
		CheckDestroyed();
		if (!GetWidgetMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetWidgetMode");
			return EJavascriptWidgetMode.WM_Translate;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWidgetMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWidgetMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWidgetMode_FunctionAddress, intPtr, GetWidgetMode_ParamsSize);
		return EnumMarshaler<EJavascriptWidgetMode>.FromNative(IntPtr.Add(intPtr, GetWidgetMode_ReturnValue_Offset), 0, GetWidgetMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewRotation")]
	public unsafe FRotator GetViewRotation()
	{
		CheckDestroyed();
		if (!GetViewRotation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewRotation");
			return default(FRotator);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewRotation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewRotation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewRotation_FunctionAddress, intPtr, GetViewRotation_ParamsSize);
		return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, GetViewRotation_ReturnValue_Offset), 0, GetViewRotation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewportWorld")]
	public unsafe UWorld GetViewportWorld()
	{
		CheckDestroyed();
		if (!GetViewportWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewportWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewportWorld_FunctionAddress, intPtr, GetViewportWorld_ParamsSize);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, GetViewportWorld_ReturnValue_Offset), 0, GetViewportWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewLocation")]
	public unsafe FVector GetViewLocation()
	{
		CheckDestroyed();
		if (!GetViewLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewLocation");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewLocation_FunctionAddress, intPtr, GetViewLocation_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetViewLocation_ReturnValue_Offset), 0, GetViewLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewFOV")]
	public unsafe float GetViewFOV()
	{
		CheckDestroyed();
		if (!GetViewFOV_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewFOV");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewFOV_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewFOV_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewFOV_FunctionAddress, intPtr, GetViewFOV_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetViewFOV_ReturnValue_Offset), 0, GetViewFOV_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetSkyComponent")]
	public unsafe UStaticMeshComponent GetSkyComponent()
	{
		CheckDestroyed();
		if (!GetSkyComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetSkyComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSkyComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSkyComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSkyComponent_FunctionAddress, intPtr, GetSkyComponent_ParamsSize);
		return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(intPtr, GetSkyComponent_ReturnValue_Offset), 0, GetSkyComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetFloorMeshComponent")]
	public unsafe UStaticMeshComponent GetFloorMeshComponent()
	{
		CheckDestroyed();
		if (!GetFloorMeshComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetFloorMeshComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloorMeshComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloorMeshComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetFloorMeshComponent_FunctionAddress, intPtr, GetFloorMeshComponent_ParamsSize);
		return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(intPtr, GetFloorMeshComponent_ReturnValue_Offset), 0, GetFloorMeshComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetEngineShowFlags")]
	public unsafe string GetEngineShowFlags()
	{
		CheckDestroyed();
		if (!GetEngineShowFlags_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetEngineShowFlags");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEngineShowFlags_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEngineShowFlags_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEngineShowFlags_FunctionAddress, intPtr, GetEngineShowFlags_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetEngineShowFlags_ReturnValue_Offset), 0, GetEngineShowFlags_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetEngineShowFlags_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSphereReflectionComponent")]
	public unsafe USphereReflectionCaptureComponent GetDefaultSphereReflectionComponent()
	{
		CheckDestroyed();
		if (!GetDefaultSphereReflectionComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSphereReflectionComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultSphereReflectionComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultSphereReflectionComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultSphereReflectionComponent_FunctionAddress, intPtr, GetDefaultSphereReflectionComponent_ParamsSize);
		return UObjectMarshaler<USphereReflectionCaptureComponent>.FromNative(IntPtr.Add(intPtr, GetDefaultSphereReflectionComponent_ReturnValue_Offset), 0, GetDefaultSphereReflectionComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSkySphereComponent")]
	public unsafe UStaticMeshComponent GetDefaultSkySphereComponent()
	{
		CheckDestroyed();
		if (!GetDefaultSkySphereComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSkySphereComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultSkySphereComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultSkySphereComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultSkySphereComponent_FunctionAddress, intPtr, GetDefaultSkySphereComponent_ParamsSize);
		return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(intPtr, GetDefaultSkySphereComponent_ReturnValue_Offset), 0, GetDefaultSkySphereComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSkyLightComponent")]
	public unsafe USkyLightComponent GetDefaultSkyLightComponent()
	{
		CheckDestroyed();
		if (!GetDefaultSkyLightComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSkyLightComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultSkyLightComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultSkyLightComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultSkyLightComponent_FunctionAddress, intPtr, GetDefaultSkyLightComponent_ParamsSize);
		return UObjectMarshaler<USkyLightComponent>.FromNative(IntPtr.Add(intPtr, GetDefaultSkyLightComponent_ReturnValue_Offset), 0, GetDefaultSkyLightComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultPostProcessComponent")]
	public unsafe UPostProcessComponent GetDefaultPostProcessComponent()
	{
		CheckDestroyed();
		if (!GetDefaultPostProcessComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultPostProcessComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultPostProcessComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultPostProcessComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultPostProcessComponent_FunctionAddress, intPtr, GetDefaultPostProcessComponent_ParamsSize);
		return UObjectMarshaler<UPostProcessComponent>.FromNative(IntPtr.Add(intPtr, GetDefaultPostProcessComponent_ReturnValue_Offset), 0, GetDefaultPostProcessComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultInstancedSkyMaterial")]
	public unsafe UMaterialInstanceConstant GetDefaultInstancedSkyMaterial()
	{
		CheckDestroyed();
		if (!GetDefaultInstancedSkyMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultInstancedSkyMaterial");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultInstancedSkyMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultInstancedSkyMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultInstancedSkyMaterial_FunctionAddress, intPtr, GetDefaultInstancedSkyMaterial_ParamsSize);
		return UObjectMarshaler<UMaterialInstanceConstant>.FromNative(IntPtr.Add(intPtr, GetDefaultInstancedSkyMaterial_ReturnValue_Offset), 0, GetDefaultInstancedSkyMaterial_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultDirectionalLightComponent")]
	public unsafe UDirectionalLightComponent GetDefaultDirectionalLightComponent()
	{
		CheckDestroyed();
		if (!GetDefaultDirectionalLightComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultDirectionalLightComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultDirectionalLightComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultDirectionalLightComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultDirectionalLightComponent_FunctionAddress, intPtr, GetDefaultDirectionalLightComponent_ParamsSize);
		return UObjectMarshaler<UDirectionalLightComponent>.FromNative(IntPtr.Add(intPtr, GetDefaultDirectionalLightComponent_ReturnValue_Offset), 0, GetDefaultDirectionalLightComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultAssetViewerSettings")]
	public unsafe UAssetViewerSettings GetDefaultAssetViewerSettings()
	{
		CheckDestroyed();
		if (!GetDefaultAssetViewerSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultAssetViewerSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDefaultAssetViewerSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDefaultAssetViewerSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDefaultAssetViewerSettings_FunctionAddress, intPtr, GetDefaultAssetViewerSettings_ParamsSize);
		return UObjectMarshaler<UAssetViewerSettings>.FromNative(IntPtr.Add(intPtr, GetDefaultAssetViewerSettings_ReturnValue_Offset), 0, GetDefaultAssetViewerSettings_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetCurrentProfileIndex")]
	public unsafe int GetCurrentProfileIndex()
	{
		CheckDestroyed();
		if (!GetCurrentProfileIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetCurrentProfileIndex");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentProfileIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentProfileIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentProfileIndex_FunctionAddress, intPtr, GetCurrentProfileIndex_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCurrentProfileIndex_ReturnValue_Offset), 0, GetCurrentProfileIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:GetCameraSpeedSetting")]
	public unsafe int GetCameraSpeedSetting()
	{
		CheckDestroyed();
		if (!GetCameraSpeedSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:GetCameraSpeedSetting");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCameraSpeedSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCameraSpeedSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCameraSpeedSetting_FunctionAddress, intPtr, GetCameraSpeedSetting_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetCameraSpeedSetting_ReturnValue_Offset), 0, GetCameraSpeedSetting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptEditorViewport:DeprojectScreenToWorld")]
	public unsafe void DeprojectScreenToWorld(FVector2D ScreenPosition, out FVector OutRayOrigin, out FVector OutRayDirection)
	{
		CheckDestroyed();
		if (!DeprojectScreenToWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptEditorViewport:DeprojectScreenToWorld");
			OutRayOrigin = default(FVector);
			OutRayDirection = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeprojectScreenToWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeprojectScreenToWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, DeprojectScreenToWorld_ScreenPosition_Offset), 0, DeprojectScreenToWorld_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, DeprojectScreenToWorld_FunctionAddress, intPtr, DeprojectScreenToWorld_ParamsSize);
		OutRayOrigin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, DeprojectScreenToWorld_OutRayOrigin_Offset), 0, DeprojectScreenToWorld_OutRayOrigin_PropertyAddress.Address);
		OutRayDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, DeprojectScreenToWorld_OutRayDirection_Offset), 0, DeprojectScreenToWorld_OutRayDirection_PropertyAddress.Address);
	}

	static UJavascriptEditorViewport()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptEditorViewport)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptEditorViewport));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptEditorViewport");
		OnClick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnClick");
		OnClick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnClick", Classes.FDelegateProperty);
		OnTrackingStarted_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTrackingStarted");
		OnTrackingStarted_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTrackingStarted", Classes.FDelegateProperty);
		OnTrackingStopped_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnTrackingStopped");
		OnTrackingStopped_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnTrackingStopped", Classes.FDelegateProperty);
		OnInputWidgetDelta_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInputWidgetDelta");
		OnInputWidgetDelta_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInputWidgetDelta", Classes.FDelegateProperty);
		OnInputKey_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInputKey");
		OnInputKey_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInputKey", Classes.FDelegateProperty);
		OnInputAxis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnInputAxis");
		OnInputAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnInputAxis", Classes.FDelegateProperty);
		OnMouseEnter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseEnter");
		OnMouseEnter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseEnter", Classes.FDelegateProperty);
		OnMouseMove_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseMove");
		OnMouseMove_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseMove", Classes.FDelegateProperty);
		OnMouseLeave_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnMouseLeave");
		OnMouseLeave_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnMouseLeave", Classes.FDelegateProperty);
		OnDraw_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDraw");
		OnDraw_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDraw", Classes.FDelegateProperty);
		OnDrawCanvas_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDrawCanvas");
		OnDrawCanvas_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDrawCanvas", Classes.FDelegateProperty);
		OnGetWidgetLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetWidgetLocation");
		OnGetWidgetLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetWidgetLocation", Classes.FDelegateProperty);
		OnGetWidgetRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetWidgetRotation");
		OnGetWidgetRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetWidgetRotation", Classes.FDelegateProperty);
		OnGetWidgetMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnGetWidgetMode");
		OnGetWidgetMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnGetWidgetMode", Classes.FDelegateProperty);
		SetWidgetMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetWidgetMode");
		SetWidgetMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetWidgetMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetWidgetMode_WidgetMode_PropertyAddress, SetWidgetMode_FunctionAddress, "WidgetMode");
		SetWidgetMode_WidgetMode_Offset = NativeReflectionCached.GetPropertyOffset(SetWidgetMode_FunctionAddress, "WidgetMode");
		SetWidgetMode_WidgetMode_IsValid = NativeReflectionCached.ValidatePropertyClass(SetWidgetMode_FunctionAddress, "WidgetMode", Classes.FEnumProperty);
		SetWidgetMode_IsValid = SetWidgetMode_FunctionAddress != IntPtr.Zero && SetWidgetMode_WidgetMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetWidgetMode", SetWidgetMode_IsValid);
		SetViewRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewRotation");
		SetViewRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewRotation_ViewRotation_PropertyAddress, SetViewRotation_FunctionAddress, "ViewRotation");
		SetViewRotation_ViewRotation_Offset = NativeReflectionCached.GetPropertyOffset(SetViewRotation_FunctionAddress, "ViewRotation");
		SetViewRotation_ViewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewRotation_FunctionAddress, "ViewRotation", Classes.FStructProperty);
		SetViewRotation_IsValid = SetViewRotation_FunctionAddress != IntPtr.Zero && SetViewRotation_ViewRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewRotation", SetViewRotation_IsValid);
		SetViewportType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewportType");
		SetViewportType_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewportType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewportType_InViewportType_PropertyAddress, SetViewportType_FunctionAddress, "InViewportType");
		SetViewportType_InViewportType_Offset = NativeReflectionCached.GetPropertyOffset(SetViewportType_FunctionAddress, "InViewportType");
		SetViewportType_InViewportType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewportType_FunctionAddress, "InViewportType", Classes.FByteProperty);
		SetViewportType_IsValid = SetViewportType_FunctionAddress != IntPtr.Zero && SetViewportType_InViewportType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewportType", SetViewportType_IsValid);
		SetViewMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewMode");
		SetViewMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewMode_InViewModeIndex_PropertyAddress, SetViewMode_FunctionAddress, "InViewModeIndex");
		SetViewMode_InViewModeIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetViewMode_FunctionAddress, "InViewModeIndex");
		SetViewMode_InViewModeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewMode_FunctionAddress, "InViewModeIndex", Classes.FByteProperty);
		SetViewMode_IsValid = SetViewMode_FunctionAddress != IntPtr.Zero && SetViewMode_InViewModeIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewMode", SetViewMode_IsValid);
		SetViewLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewLocation");
		SetViewLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewLocation_ViewLocation_PropertyAddress, SetViewLocation_FunctionAddress, "ViewLocation");
		SetViewLocation_ViewLocation_Offset = NativeReflectionCached.GetPropertyOffset(SetViewLocation_FunctionAddress, "ViewLocation");
		SetViewLocation_ViewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewLocation_FunctionAddress, "ViewLocation", Classes.FStructProperty);
		SetViewLocation_IsValid = SetViewLocation_FunctionAddress != IntPtr.Zero && SetViewLocation_ViewLocation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewLocation", SetViewLocation_IsValid);
		SetViewFOV_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetViewFOV");
		SetViewFOV_ParamsSize = NativeReflection.GetFunctionParamsSize(SetViewFOV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetViewFOV_InViewFOV_PropertyAddress, SetViewFOV_FunctionAddress, "InViewFOV");
		SetViewFOV_InViewFOV_Offset = NativeReflectionCached.GetPropertyOffset(SetViewFOV_FunctionAddress, "InViewFOV");
		SetViewFOV_InViewFOV_IsValid = NativeReflectionCached.ValidatePropertyClass(SetViewFOV_FunctionAddress, "InViewFOV", Classes.FFloatProperty);
		SetViewFOV_IsValid = SetViewFOV_FunctionAddress != IntPtr.Zero && SetViewFOV_InViewFOV_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetViewFOV", SetViewFOV_IsValid);
		SetSkyBrightness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSkyBrightness");
		SetSkyBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSkyBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSkyBrightness_SkyBrightness_PropertyAddress, SetSkyBrightness_FunctionAddress, "SkyBrightness");
		SetSkyBrightness_SkyBrightness_Offset = NativeReflectionCached.GetPropertyOffset(SetSkyBrightness_FunctionAddress, "SkyBrightness");
		SetSkyBrightness_SkyBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSkyBrightness_FunctionAddress, "SkyBrightness", Classes.FFloatProperty);
		SetSkyBrightness_IsValid = SetSkyBrightness_FunctionAddress != IntPtr.Zero && SetSkyBrightness_SkyBrightness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetSkyBrightness", SetSkyBrightness_IsValid);
		SetSimulatePhysics_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSimulatePhysics");
		SetSimulatePhysics_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSimulatePhysics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSimulatePhysics_bShouldSimulatePhysics_PropertyAddress, SetSimulatePhysics_FunctionAddress, "bShouldSimulatePhysics");
		SetSimulatePhysics_bShouldSimulatePhysics_Offset = NativeReflectionCached.GetPropertyOffset(SetSimulatePhysics_FunctionAddress, "bShouldSimulatePhysics");
		SetSimulatePhysics_bShouldSimulatePhysics_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSimulatePhysics_FunctionAddress, "bShouldSimulatePhysics", Classes.FBoolProperty);
		SetSimulatePhysics_IsValid = SetSimulatePhysics_FunctionAddress != IntPtr.Zero && SetSimulatePhysics_bShouldSimulatePhysics_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetSimulatePhysics", SetSimulatePhysics_IsValid);
		SetRealtime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRealtime");
		SetRealtime_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRealtime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRealtime_bInRealtime_PropertyAddress, SetRealtime_FunctionAddress, "bInRealtime");
		SetRealtime_bInRealtime_Offset = NativeReflectionCached.GetPropertyOffset(SetRealtime_FunctionAddress, "bInRealtime");
		SetRealtime_bInRealtime_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRealtime_FunctionAddress, "bInRealtime", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetRealtime_bStoreCurrentValue_PropertyAddress, SetRealtime_FunctionAddress, "bStoreCurrentValue");
		SetRealtime_bStoreCurrentValue_Offset = NativeReflectionCached.GetPropertyOffset(SetRealtime_FunctionAddress, "bStoreCurrentValue");
		SetRealtime_bStoreCurrentValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRealtime_FunctionAddress, "bStoreCurrentValue", Classes.FBoolProperty);
		SetRealtime_IsValid = SetRealtime_FunctionAddress != IntPtr.Zero && SetRealtime_bInRealtime_IsValid && SetRealtime_bStoreCurrentValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetRealtime", SetRealtime_IsValid);
		SetProfileIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetProfileIndex");
		SetProfileIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(SetProfileIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetProfileIndex_InProfileIndex_PropertyAddress, SetProfileIndex_FunctionAddress, "InProfileIndex");
		SetProfileIndex_InProfileIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetProfileIndex_FunctionAddress, "InProfileIndex");
		SetProfileIndex_InProfileIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetProfileIndex_FunctionAddress, "InProfileIndex", Classes.FIntProperty);
		SetProfileIndex_IsValid = SetProfileIndex_FunctionAddress != IntPtr.Zero && SetProfileIndex_InProfileIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetProfileIndex", SetProfileIndex_IsValid);
		SetLightLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightLocation");
		SetLightLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightLocation_InLightPos_PropertyAddress, SetLightLocation_FunctionAddress, "InLightPos");
		SetLightLocation_InLightPos_Offset = NativeReflectionCached.GetPropertyOffset(SetLightLocation_FunctionAddress, "InLightPos");
		SetLightLocation_InLightPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightLocation_FunctionAddress, "InLightPos", Classes.FStructProperty);
		SetLightLocation_IsValid = SetLightLocation_FunctionAddress != IntPtr.Zero && SetLightLocation_InLightPos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightLocation", SetLightLocation_IsValid);
		SetLightDirection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightDirection");
		SetLightDirection_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightDirection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightDirection_InLightDir_PropertyAddress, SetLightDirection_FunctionAddress, "InLightDir");
		SetLightDirection_InLightDir_Offset = NativeReflectionCached.GetPropertyOffset(SetLightDirection_FunctionAddress, "InLightDir");
		SetLightDirection_InLightDir_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightDirection_FunctionAddress, "InLightDir", Classes.FStructProperty);
		SetLightDirection_IsValid = SetLightDirection_FunctionAddress != IntPtr.Zero && SetLightDirection_InLightDir_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightDirection", SetLightDirection_IsValid);
		SetLightColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightColor");
		SetLightColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightColor_LightColor_PropertyAddress, SetLightColor_FunctionAddress, "LightColor");
		SetLightColor_LightColor_Offset = NativeReflectionCached.GetPropertyOffset(SetLightColor_FunctionAddress, "LightColor");
		SetLightColor_LightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightColor_FunctionAddress, "LightColor", Classes.FStructProperty);
		SetLightColor_IsValid = SetLightColor_FunctionAddress != IntPtr.Zero && SetLightColor_LightColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightColor", SetLightColor_IsValid);
		SetLightBrightness_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetLightBrightness");
		SetLightBrightness_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLightBrightness_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLightBrightness_LightBrightness_PropertyAddress, SetLightBrightness_FunctionAddress, "LightBrightness");
		SetLightBrightness_LightBrightness_Offset = NativeReflectionCached.GetPropertyOffset(SetLightBrightness_FunctionAddress, "LightBrightness");
		SetLightBrightness_LightBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLightBrightness_FunctionAddress, "LightBrightness", Classes.FFloatProperty);
		SetLightBrightness_IsValid = SetLightBrightness_FunctionAddress != IntPtr.Zero && SetLightBrightness_LightBrightness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetLightBrightness", SetLightBrightness_IsValid);
		SetFloorOffset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetFloorOffset");
		SetFloorOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFloorOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFloorOffset_InFloorOffset_PropertyAddress, SetFloorOffset_FunctionAddress, "InFloorOffset");
		SetFloorOffset_InFloorOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetFloorOffset_FunctionAddress, "InFloorOffset");
		SetFloorOffset_InFloorOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFloorOffset_FunctionAddress, "InFloorOffset", Classes.FFloatProperty);
		SetFloorOffset_IsValid = SetFloorOffset_FunctionAddress != IntPtr.Zero && SetFloorOffset_InFloorOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetFloorOffset", SetFloorOffset_IsValid);
		SetEngineShowFlags_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetEngineShowFlags");
		SetEngineShowFlags_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEngineShowFlags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEngineShowFlags_In_PropertyAddress, SetEngineShowFlags_FunctionAddress, "In");
		SetEngineShowFlags_In_Offset = NativeReflectionCached.GetPropertyOffset(SetEngineShowFlags_FunctionAddress, "In");
		SetEngineShowFlags_In_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEngineShowFlags_FunctionAddress, "In", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEngineShowFlags_ReturnValue_PropertyAddress, SetEngineShowFlags_FunctionAddress, "ReturnValue");
		SetEngineShowFlags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetEngineShowFlags_FunctionAddress, "ReturnValue");
		SetEngineShowFlags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEngineShowFlags_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetEngineShowFlags_IsValid = SetEngineShowFlags_FunctionAddress != IntPtr.Zero && SetEngineShowFlags_In_IsValid && SetEngineShowFlags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetEngineShowFlags", SetEngineShowFlags_IsValid);
		SetCameraSpeedSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCameraSpeedSetting");
		SetCameraSpeedSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCameraSpeedSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCameraSpeedSetting_SpeedSetting_PropertyAddress, SetCameraSpeedSetting_FunctionAddress, "SpeedSetting");
		SetCameraSpeedSetting_SpeedSetting_Offset = NativeReflectionCached.GetPropertyOffset(SetCameraSpeedSetting_FunctionAddress, "SpeedSetting");
		SetCameraSpeedSetting_SpeedSetting_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCameraSpeedSetting_FunctionAddress, "SpeedSetting", Classes.FIntProperty);
		SetCameraSpeedSetting_IsValid = SetCameraSpeedSetting_FunctionAddress != IntPtr.Zero && SetCameraSpeedSetting_SpeedSetting_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetCameraSpeedSetting", SetCameraSpeedSetting_IsValid);
		SetBackgroundColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetBackgroundColor");
		SetBackgroundColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBackgroundColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBackgroundColor_BackgroundColor_PropertyAddress, SetBackgroundColor_FunctionAddress, "BackgroundColor");
		SetBackgroundColor_BackgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(SetBackgroundColor_FunctionAddress, "BackgroundColor");
		SetBackgroundColor_BackgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBackgroundColor_FunctionAddress, "BackgroundColor", Classes.FStructProperty);
		SetBackgroundColor_IsValid = SetBackgroundColor_FunctionAddress != IntPtr.Zero && SetBackgroundColor_BackgroundColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:SetBackgroundColor", SetBackgroundColor_IsValid);
		RestoreRealtime_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RestoreRealtime");
		RestoreRealtime_ParamsSize = NativeReflection.GetFunctionParamsSize(RestoreRealtime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RestoreRealtime_bAllowDisable_PropertyAddress, RestoreRealtime_FunctionAddress, "bAllowDisable");
		RestoreRealtime_bAllowDisable_Offset = NativeReflectionCached.GetPropertyOffset(RestoreRealtime_FunctionAddress, "bAllowDisable");
		RestoreRealtime_bAllowDisable_IsValid = NativeReflectionCached.ValidatePropertyClass(RestoreRealtime_FunctionAddress, "bAllowDisable", Classes.FBoolProperty);
		RestoreRealtime_IsValid = RestoreRealtime_FunctionAddress != IntPtr.Zero && RestoreRealtime_bAllowDisable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:RestoreRealtime", RestoreRealtime_IsValid);
		Redraw_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Redraw");
		Redraw_ParamsSize = NativeReflection.GetFunctionParamsSize(Redraw_FunctionAddress);
		Redraw_IsValid = Redraw_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:Redraw", Redraw_IsValid);
		ProjectWorldToScreen_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProjectWorldToScreen");
		ProjectWorldToScreen_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectWorldToScreen_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldToScreen_WorldPosition_PropertyAddress, ProjectWorldToScreen_FunctionAddress, "WorldPosition");
		ProjectWorldToScreen_WorldPosition_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldToScreen_FunctionAddress, "WorldPosition");
		ProjectWorldToScreen_WorldPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldToScreen_FunctionAddress, "WorldPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectWorldToScreen_OutScreenPosition_PropertyAddress, ProjectWorldToScreen_FunctionAddress, "OutScreenPosition");
		ProjectWorldToScreen_OutScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(ProjectWorldToScreen_FunctionAddress, "OutScreenPosition");
		ProjectWorldToScreen_OutScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(ProjectWorldToScreen_FunctionAddress, "OutScreenPosition", Classes.FStructProperty);
		ProjectWorldToScreen_IsValid = ProjectWorldToScreen_FunctionAddress != IntPtr.Zero && ProjectWorldToScreen_WorldPosition_IsValid && ProjectWorldToScreen_OutScreenPosition_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:ProjectWorldToScreen", ProjectWorldToScreen_IsValid);
		OverridePostProcessSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OverridePostProcessSettings");
		OverridePostProcessSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(OverridePostProcessSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OverridePostProcessSettings_PostProcessSettings_PropertyAddress, OverridePostProcessSettings_FunctionAddress, "PostProcessSettings");
		OverridePostProcessSettings_PostProcessSettings_Offset = NativeReflectionCached.GetPropertyOffset(OverridePostProcessSettings_FunctionAddress, "PostProcessSettings");
		OverridePostProcessSettings_PostProcessSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(OverridePostProcessSettings_FunctionAddress, "PostProcessSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OverridePostProcessSettings_Weight_PropertyAddress, OverridePostProcessSettings_FunctionAddress, "Weight");
		OverridePostProcessSettings_Weight_Offset = NativeReflectionCached.GetPropertyOffset(OverridePostProcessSettings_FunctionAddress, "Weight");
		OverridePostProcessSettings_Weight_IsValid = NativeReflectionCached.ValidatePropertyClass(OverridePostProcessSettings_FunctionAddress, "Weight", Classes.FFloatProperty);
		OverridePostProcessSettings_IsValid = OverridePostProcessSettings_FunctionAddress != IntPtr.Zero && OverridePostProcessSettings_PostProcessSettings_IsValid && OverridePostProcessSettings_Weight_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:OverridePostProcessSettings", OverridePostProcessSettings_IsValid);
		GetWidgetMode_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetWidgetMode");
		GetWidgetMode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWidgetMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWidgetMode_ReturnValue_PropertyAddress, GetWidgetMode_FunctionAddress, "ReturnValue");
		GetWidgetMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWidgetMode_FunctionAddress, "ReturnValue");
		GetWidgetMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWidgetMode_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetWidgetMode_IsValid = GetWidgetMode_FunctionAddress != IntPtr.Zero && GetWidgetMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetWidgetMode", GetWidgetMode_IsValid);
		GetViewRotation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewRotation");
		GetViewRotation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewRotation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewRotation_ReturnValue_PropertyAddress, GetViewRotation_FunctionAddress, "ReturnValue");
		GetViewRotation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewRotation_FunctionAddress, "ReturnValue");
		GetViewRotation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewRotation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewRotation_IsValid = GetViewRotation_FunctionAddress != IntPtr.Zero && GetViewRotation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewRotation", GetViewRotation_IsValid);
		GetViewportWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewportWorld");
		GetViewportWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportWorld_ReturnValue_PropertyAddress, GetViewportWorld_FunctionAddress, "ReturnValue");
		GetViewportWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportWorld_FunctionAddress, "ReturnValue");
		GetViewportWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportWorld_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetViewportWorld_IsValid = GetViewportWorld_FunctionAddress != IntPtr.Zero && GetViewportWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewportWorld", GetViewportWorld_IsValid);
		GetViewLocation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewLocation");
		GetViewLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewLocation_ReturnValue_PropertyAddress, GetViewLocation_FunctionAddress, "ReturnValue");
		GetViewLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewLocation_FunctionAddress, "ReturnValue");
		GetViewLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewLocation_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetViewLocation_IsValid = GetViewLocation_FunctionAddress != IntPtr.Zero && GetViewLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewLocation", GetViewLocation_IsValid);
		GetViewFOV_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetViewFOV");
		GetViewFOV_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewFOV_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewFOV_ReturnValue_PropertyAddress, GetViewFOV_FunctionAddress, "ReturnValue");
		GetViewFOV_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewFOV_FunctionAddress, "ReturnValue");
		GetViewFOV_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewFOV_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetViewFOV_IsValid = GetViewFOV_FunctionAddress != IntPtr.Zero && GetViewFOV_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetViewFOV", GetViewFOV_IsValid);
		GetSkyComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSkyComponent");
		GetSkyComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSkyComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSkyComponent_ReturnValue_PropertyAddress, GetSkyComponent_FunctionAddress, "ReturnValue");
		GetSkyComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSkyComponent_FunctionAddress, "ReturnValue");
		GetSkyComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSkyComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSkyComponent_IsValid = GetSkyComponent_FunctionAddress != IntPtr.Zero && GetSkyComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetSkyComponent", GetSkyComponent_IsValid);
		GetFloorMeshComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetFloorMeshComponent");
		GetFloorMeshComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloorMeshComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloorMeshComponent_ReturnValue_PropertyAddress, GetFloorMeshComponent_FunctionAddress, "ReturnValue");
		GetFloorMeshComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloorMeshComponent_FunctionAddress, "ReturnValue");
		GetFloorMeshComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloorMeshComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetFloorMeshComponent_IsValid = GetFloorMeshComponent_FunctionAddress != IntPtr.Zero && GetFloorMeshComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetFloorMeshComponent", GetFloorMeshComponent_IsValid);
		GetEngineShowFlags_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetEngineShowFlags");
		GetEngineShowFlags_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEngineShowFlags_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEngineShowFlags_ReturnValue_PropertyAddress, GetEngineShowFlags_FunctionAddress, "ReturnValue");
		GetEngineShowFlags_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEngineShowFlags_FunctionAddress, "ReturnValue");
		GetEngineShowFlags_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEngineShowFlags_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetEngineShowFlags_IsValid = GetEngineShowFlags_FunctionAddress != IntPtr.Zero && GetEngineShowFlags_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetEngineShowFlags", GetEngineShowFlags_IsValid);
		GetDefaultSphereReflectionComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultSphereReflectionComponent");
		GetDefaultSphereReflectionComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultSphereReflectionComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultSphereReflectionComponent_ReturnValue_PropertyAddress, GetDefaultSphereReflectionComponent_FunctionAddress, "ReturnValue");
		GetDefaultSphereReflectionComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultSphereReflectionComponent_FunctionAddress, "ReturnValue");
		GetDefaultSphereReflectionComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultSphereReflectionComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultSphereReflectionComponent_IsValid = GetDefaultSphereReflectionComponent_FunctionAddress != IntPtr.Zero && GetDefaultSphereReflectionComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSphereReflectionComponent", GetDefaultSphereReflectionComponent_IsValid);
		GetDefaultSkySphereComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultSkySphereComponent");
		GetDefaultSkySphereComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultSkySphereComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultSkySphereComponent_ReturnValue_PropertyAddress, GetDefaultSkySphereComponent_FunctionAddress, "ReturnValue");
		GetDefaultSkySphereComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultSkySphereComponent_FunctionAddress, "ReturnValue");
		GetDefaultSkySphereComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultSkySphereComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultSkySphereComponent_IsValid = GetDefaultSkySphereComponent_FunctionAddress != IntPtr.Zero && GetDefaultSkySphereComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSkySphereComponent", GetDefaultSkySphereComponent_IsValid);
		GetDefaultSkyLightComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultSkyLightComponent");
		GetDefaultSkyLightComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultSkyLightComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultSkyLightComponent_ReturnValue_PropertyAddress, GetDefaultSkyLightComponent_FunctionAddress, "ReturnValue");
		GetDefaultSkyLightComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultSkyLightComponent_FunctionAddress, "ReturnValue");
		GetDefaultSkyLightComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultSkyLightComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultSkyLightComponent_IsValid = GetDefaultSkyLightComponent_FunctionAddress != IntPtr.Zero && GetDefaultSkyLightComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultSkyLightComponent", GetDefaultSkyLightComponent_IsValid);
		GetDefaultPostProcessComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultPostProcessComponent");
		GetDefaultPostProcessComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultPostProcessComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultPostProcessComponent_ReturnValue_PropertyAddress, GetDefaultPostProcessComponent_FunctionAddress, "ReturnValue");
		GetDefaultPostProcessComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultPostProcessComponent_FunctionAddress, "ReturnValue");
		GetDefaultPostProcessComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultPostProcessComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultPostProcessComponent_IsValid = GetDefaultPostProcessComponent_FunctionAddress != IntPtr.Zero && GetDefaultPostProcessComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultPostProcessComponent", GetDefaultPostProcessComponent_IsValid);
		GetDefaultInstancedSkyMaterial_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultInstancedSkyMaterial");
		GetDefaultInstancedSkyMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultInstancedSkyMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultInstancedSkyMaterial_ReturnValue_PropertyAddress, GetDefaultInstancedSkyMaterial_FunctionAddress, "ReturnValue");
		GetDefaultInstancedSkyMaterial_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultInstancedSkyMaterial_FunctionAddress, "ReturnValue");
		GetDefaultInstancedSkyMaterial_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultInstancedSkyMaterial_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultInstancedSkyMaterial_IsValid = GetDefaultInstancedSkyMaterial_FunctionAddress != IntPtr.Zero && GetDefaultInstancedSkyMaterial_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultInstancedSkyMaterial", GetDefaultInstancedSkyMaterial_IsValid);
		GetDefaultDirectionalLightComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultDirectionalLightComponent");
		GetDefaultDirectionalLightComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultDirectionalLightComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultDirectionalLightComponent_ReturnValue_PropertyAddress, GetDefaultDirectionalLightComponent_FunctionAddress, "ReturnValue");
		GetDefaultDirectionalLightComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultDirectionalLightComponent_FunctionAddress, "ReturnValue");
		GetDefaultDirectionalLightComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultDirectionalLightComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultDirectionalLightComponent_IsValid = GetDefaultDirectionalLightComponent_FunctionAddress != IntPtr.Zero && GetDefaultDirectionalLightComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultDirectionalLightComponent", GetDefaultDirectionalLightComponent_IsValid);
		GetDefaultAssetViewerSettings_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDefaultAssetViewerSettings");
		GetDefaultAssetViewerSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDefaultAssetViewerSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDefaultAssetViewerSettings_ReturnValue_PropertyAddress, GetDefaultAssetViewerSettings_FunctionAddress, "ReturnValue");
		GetDefaultAssetViewerSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDefaultAssetViewerSettings_FunctionAddress, "ReturnValue");
		GetDefaultAssetViewerSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDefaultAssetViewerSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDefaultAssetViewerSettings_IsValid = GetDefaultAssetViewerSettings_FunctionAddress != IntPtr.Zero && GetDefaultAssetViewerSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetDefaultAssetViewerSettings", GetDefaultAssetViewerSettings_IsValid);
		GetCurrentProfileIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentProfileIndex");
		GetCurrentProfileIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentProfileIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentProfileIndex_ReturnValue_PropertyAddress, GetCurrentProfileIndex_FunctionAddress, "ReturnValue");
		GetCurrentProfileIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentProfileIndex_FunctionAddress, "ReturnValue");
		GetCurrentProfileIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentProfileIndex_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCurrentProfileIndex_IsValid = GetCurrentProfileIndex_FunctionAddress != IntPtr.Zero && GetCurrentProfileIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetCurrentProfileIndex", GetCurrentProfileIndex_IsValid);
		GetCameraSpeedSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCameraSpeedSetting");
		GetCameraSpeedSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCameraSpeedSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCameraSpeedSetting_ReturnValue_PropertyAddress, GetCameraSpeedSetting_FunctionAddress, "ReturnValue");
		GetCameraSpeedSetting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCameraSpeedSetting_FunctionAddress, "ReturnValue");
		GetCameraSpeedSetting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCameraSpeedSetting_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetCameraSpeedSetting_IsValid = GetCameraSpeedSetting_FunctionAddress != IntPtr.Zero && GetCameraSpeedSetting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:GetCameraSpeedSetting", GetCameraSpeedSetting_IsValid);
		DeprojectScreenToWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DeprojectScreenToWorld");
		DeprojectScreenToWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(DeprojectScreenToWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeprojectScreenToWorld_ScreenPosition_PropertyAddress, DeprojectScreenToWorld_FunctionAddress, "ScreenPosition");
		DeprojectScreenToWorld_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectScreenToWorld_FunctionAddress, "ScreenPosition");
		DeprojectScreenToWorld_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectScreenToWorld_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeprojectScreenToWorld_OutRayOrigin_PropertyAddress, DeprojectScreenToWorld_FunctionAddress, "OutRayOrigin");
		DeprojectScreenToWorld_OutRayOrigin_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectScreenToWorld_FunctionAddress, "OutRayOrigin");
		DeprojectScreenToWorld_OutRayOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectScreenToWorld_FunctionAddress, "OutRayOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DeprojectScreenToWorld_OutRayDirection_PropertyAddress, DeprojectScreenToWorld_FunctionAddress, "OutRayDirection");
		DeprojectScreenToWorld_OutRayDirection_Offset = NativeReflectionCached.GetPropertyOffset(DeprojectScreenToWorld_FunctionAddress, "OutRayDirection");
		DeprojectScreenToWorld_OutRayDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(DeprojectScreenToWorld_FunctionAddress, "OutRayDirection", Classes.FStructProperty);
		DeprojectScreenToWorld_IsValid = DeprojectScreenToWorld_FunctionAddress != IntPtr.Zero && DeprojectScreenToWorld_ScreenPosition_IsValid && DeprojectScreenToWorld_OutRayOrigin_IsValid && DeprojectScreenToWorld_OutRayDirection_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptEditorViewport:DeprojectScreenToWorld", DeprojectScreenToWorld_IsValid);
	}
}
