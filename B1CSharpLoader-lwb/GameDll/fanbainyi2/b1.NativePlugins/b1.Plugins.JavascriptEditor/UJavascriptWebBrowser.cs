using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.JavascriptEditor;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public class UJavascriptWebBrowser : UWidget
{
	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:OnUrlChanged__DelegateSignature")]
	public class FOnUrlChanged : FMulticastDelegate<FOnUrlChanged.Signature>
	{
		public delegate void Signature(FText Text);

		private static bool OnUrlChanged__DelegateSignature_IsValid;

		private static IntPtr OnUrlChanged__DelegateSignature_FunctionAddress;

		private static int OnUrlChanged__DelegateSignature_ParamsSize;

		private static bool OnUrlChanged__DelegateSignature_Text_IsValid;

		private static FFieldAddress OnUrlChanged__DelegateSignature_Text_PropertyAddress;

		private static int OnUrlChanged__DelegateSignature_Text_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnUrlChanged()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnUrlChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptWebBrowser:OnUrlChanged__DelegateSignature");
			OnUrlChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUrlChanged__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnUrlChanged__DelegateSignature_Text_PropertyAddress, OnUrlChanged__DelegateSignature_FunctionAddress, "Text");
			OnUrlChanged__DelegateSignature_Text_Offset = NativeReflectionCached.GetPropertyOffset(OnUrlChanged__DelegateSignature_FunctionAddress, "Text");
			OnUrlChanged__DelegateSignature_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(OnUrlChanged__DelegateSignature_FunctionAddress, "Text", Classes.FTextProperty);
			OnUrlChanged__DelegateSignature_IsValid = OnUrlChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnUrlChanged__DelegateSignature_Text_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptWebBrowser:OnUrlChanged__DelegateSignature", OnUrlChanged__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FText Text)
		{
			if (!OnUrlChanged__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:OnUrlChanged__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnUrlChanged__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUrlChanged__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnUrlChanged__DelegateSignature_Text_PropertyAddress.Address, intPtr);
				FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnUrlChanged__DelegateSignature_Text_Offset), 0, OnUrlChanged__DelegateSignature_Text_PropertyAddress.Address, Text);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnUrlChanged__DelegateSignature_Text_PropertyAddress.Address, intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:OnBeforePopup__DelegateSignature")]
	public class FOnBeforePopup : FMulticastDelegate<FOnBeforePopup.Signature>
	{
		public delegate void Signature(string URL, string Frame);

		private static bool OnBeforePopup__DelegateSignature_IsValid;

		private static IntPtr OnBeforePopup__DelegateSignature_FunctionAddress;

		private static int OnBeforePopup__DelegateSignature_ParamsSize;

		private static bool OnBeforePopup__DelegateSignature_URL_IsValid;

		private static FFieldAddress OnBeforePopup__DelegateSignature_URL_PropertyAddress;

		private static int OnBeforePopup__DelegateSignature_URL_Offset;

		private static bool OnBeforePopup__DelegateSignature_Frame_IsValid;

		private static FFieldAddress OnBeforePopup__DelegateSignature_Frame_PropertyAddress;

		private static int OnBeforePopup__DelegateSignature_Frame_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnBeforePopup()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnBeforePopup__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/JavascriptEditor.JavascriptWebBrowser:OnBeforePopup__DelegateSignature");
			OnBeforePopup__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnBeforePopup__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnBeforePopup__DelegateSignature_URL_PropertyAddress, OnBeforePopup__DelegateSignature_FunctionAddress, "URL");
			OnBeforePopup__DelegateSignature_URL_Offset = NativeReflectionCached.GetPropertyOffset(OnBeforePopup__DelegateSignature_FunctionAddress, "URL");
			OnBeforePopup__DelegateSignature_URL_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeforePopup__DelegateSignature_FunctionAddress, "URL", Classes.FStrProperty);
			NativeReflectionCached.GetPropertyRef(ref OnBeforePopup__DelegateSignature_Frame_PropertyAddress, OnBeforePopup__DelegateSignature_FunctionAddress, "Frame");
			OnBeforePopup__DelegateSignature_Frame_Offset = NativeReflectionCached.GetPropertyOffset(OnBeforePopup__DelegateSignature_FunctionAddress, "Frame");
			OnBeforePopup__DelegateSignature_Frame_IsValid = NativeReflectionCached.ValidatePropertyClass(OnBeforePopup__DelegateSignature_FunctionAddress, "Frame", Classes.FStrProperty);
			OnBeforePopup__DelegateSignature_IsValid = OnBeforePopup__DelegateSignature_FunctionAddress != IntPtr.Zero && OnBeforePopup__DelegateSignature_URL_IsValid && OnBeforePopup__DelegateSignature_Frame_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptWebBrowser:OnBeforePopup__DelegateSignature", OnBeforePopup__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(string URL, string Frame)
		{
			if (!OnBeforePopup__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:OnBeforePopup__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnBeforePopup__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnBeforePopup__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnBeforePopup__DelegateSignature_URL_Offset), 0, OnBeforePopup__DelegateSignature_URL_PropertyAddress.Address, URL);
				FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnBeforePopup__DelegateSignature_Frame_Offset), 0, OnBeforePopup__DelegateSignature_Frame_PropertyAddress.Address, Frame);
				ProcessDelegate(intPtr);
				NativeReflection.DestroyValue_InContainer(OnBeforePopup__DelegateSignature_URL_PropertyAddress.Address, intPtr);
				NativeReflection.DestroyValue_InContainer(OnBeforePopup__DelegateSignature_Frame_PropertyAddress.Address, intPtr);
			}
		}
	}

	private static bool OnUrlChanged_IsValid;

	private static int OnUrlChanged_Offset;

	private FOnUrlChanged OnUrlChanged_DelegateCached;

	private static bool OnBeforePopup_IsValid;

	private static int OnBeforePopup_Offset;

	private FOnBeforePopup OnBeforePopup_DelegateCached;

	private static bool LoadURL_IsValid;

	private static IntPtr LoadURL_FunctionAddress;

	private static int LoadURL_ParamsSize;

	private static bool LoadURL_NewURL_IsValid;

	private static FFieldAddress LoadURL_NewURL_PropertyAddress;

	private static int LoadURL_NewURL_Offset;

	private static bool LoadString_IsValid;

	private static IntPtr LoadString_FunctionAddress;

	private static int LoadString_ParamsSize;

	private static bool LoadString_Contents_IsValid;

	private static FFieldAddress LoadString_Contents_PropertyAddress;

	private static int LoadString_Contents_Offset;

	private static bool LoadString_DummyURL_IsValid;

	private static FFieldAddress LoadString_DummyURL_PropertyAddress;

	private static int LoadString_DummyURL_Offset;

	private static bool GetUrl_IsValid;

	private static IntPtr GetUrl_FunctionAddress;

	private static int GetUrl_ParamsSize;

	private static bool GetUrl_ReturnValue_IsValid;

	private static FFieldAddress GetUrl_ReturnValue_PropertyAddress;

	private static int GetUrl_ReturnValue_Offset;

	private static bool GetTitleText_IsValid;

	private static IntPtr GetTitleText_FunctionAddress;

	private static int GetTitleText_ParamsSize;

	private static bool GetTitleText_ReturnValue_IsValid;

	private static FFieldAddress GetTitleText_ReturnValue_PropertyAddress;

	private static int GetTitleText_ReturnValue_Offset;

	private static bool ExecuteJavascript_IsValid;

	private static IntPtr ExecuteJavascript_FunctionAddress;

	private static int ExecuteJavascript_ParamsSize;

	private static bool ExecuteJavascript_ScriptText_IsValid;

	private static FFieldAddress ExecuteJavascript_ScriptText_PropertyAddress;

	private static int ExecuteJavascript_ScriptText_Offset;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:OnUrlChanged")]
	public FOnUrlChanged OnUrlChanged
	{
		get
		{
			CheckDestroyed();
			if (!OnUrlChanged_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:OnUrlChanged");
				return new FOnUrlChanged();
			}
			if (OnUrlChanged_DelegateCached == null)
			{
				OnUrlChanged_DelegateCached = new FOnUrlChanged();
				OnUrlChanged_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnUrlChanged_Offset));
			}
			return OnUrlChanged_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:OnBeforePopup")]
	public FOnBeforePopup OnBeforePopup
	{
		get
		{
			CheckDestroyed();
			if (!OnBeforePopup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:OnBeforePopup");
				return new FOnBeforePopup();
			}
			if (OnBeforePopup_DelegateCached == null)
			{
				OnBeforePopup_DelegateCached = new FOnBeforePopup();
				OnBeforePopup_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnBeforePopup_Offset));
			}
			return OnBeforePopup_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:LoadURL")]
	public unsafe void LoadURL(string NewURL)
	{
		CheckDestroyed();
		if (!LoadURL_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:LoadURL");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadURL_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadURL_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadURL_NewURL_Offset), 0, LoadURL_NewURL_PropertyAddress.Address, NewURL);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoadURL_FunctionAddress, intPtr, LoadURL_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadURL_NewURL_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:LoadString")]
	public unsafe void LoadString(string Contents, string DummyURL)
	{
		CheckDestroyed();
		if (!LoadString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:LoadString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadString_Contents_Offset), 0, LoadString_Contents_PropertyAddress.Address, Contents);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadString_DummyURL_Offset), 0, LoadString_DummyURL_PropertyAddress.Address, DummyURL);
		NativeReflection.InvokeFunctionOptimized(base.Address, LoadString_FunctionAddress, intPtr, LoadString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadString_Contents_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(LoadString_DummyURL_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:GetUrl")]
	public unsafe string GetUrl()
	{
		CheckDestroyed();
		if (!GetUrl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:GetUrl");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUrl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUrl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUrl_FunctionAddress, intPtr, GetUrl_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetUrl_ReturnValue_Offset), 0, GetUrl_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetUrl_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:GetTitleText")]
	public unsafe string GetTitleText()
	{
		CheckDestroyed();
		if (!GetTitleText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:GetTitleText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTitleText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTitleText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTitleText_FunctionAddress, intPtr, GetTitleText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTitleText_ReturnValue_Offset), 0, GetTitleText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTitleText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptWebBrowser:ExecuteJavascript")]
	public unsafe void ExecuteJavascript(string ScriptText)
	{
		CheckDestroyed();
		if (!ExecuteJavascript_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/JavascriptEditor.JavascriptWebBrowser:ExecuteJavascript");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteJavascript_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteJavascript_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExecuteJavascript_ScriptText_Offset), 0, ExecuteJavascript_ScriptText_PropertyAddress.Address, ScriptText);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExecuteJavascript_FunctionAddress, intPtr, ExecuteJavascript_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExecuteJavascript_ScriptText_PropertyAddress.Address, intPtr);
	}

	static UJavascriptWebBrowser()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptWebBrowser)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptWebBrowser));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/JavascriptEditor.JavascriptWebBrowser");
		OnUrlChanged_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnUrlChanged");
		OnUrlChanged_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnUrlChanged", Classes.FMulticastDelegateProperty);
		OnBeforePopup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnBeforePopup");
		OnBeforePopup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnBeforePopup", Classes.FMulticastDelegateProperty);
		LoadURL_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LoadURL");
		LoadURL_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadURL_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadURL_NewURL_PropertyAddress, LoadURL_FunctionAddress, "NewURL");
		LoadURL_NewURL_Offset = NativeReflectionCached.GetPropertyOffset(LoadURL_FunctionAddress, "NewURL");
		LoadURL_NewURL_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadURL_FunctionAddress, "NewURL", Classes.FStrProperty);
		LoadURL_IsValid = LoadURL_FunctionAddress != IntPtr.Zero && LoadURL_NewURL_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptWebBrowser:LoadURL", LoadURL_IsValid);
		LoadString_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LoadString");
		LoadString_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadString_Contents_PropertyAddress, LoadString_FunctionAddress, "Contents");
		LoadString_Contents_Offset = NativeReflectionCached.GetPropertyOffset(LoadString_FunctionAddress, "Contents");
		LoadString_Contents_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadString_FunctionAddress, "Contents", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadString_DummyURL_PropertyAddress, LoadString_FunctionAddress, "DummyURL");
		LoadString_DummyURL_Offset = NativeReflectionCached.GetPropertyOffset(LoadString_FunctionAddress, "DummyURL");
		LoadString_DummyURL_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadString_FunctionAddress, "DummyURL", Classes.FStrProperty);
		LoadString_IsValid = LoadString_FunctionAddress != IntPtr.Zero && LoadString_Contents_IsValid && LoadString_DummyURL_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptWebBrowser:LoadString", LoadString_IsValid);
		GetUrl_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetUrl");
		GetUrl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUrl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUrl_ReturnValue_PropertyAddress, GetUrl_FunctionAddress, "ReturnValue");
		GetUrl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUrl_FunctionAddress, "ReturnValue");
		GetUrl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUrl_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetUrl_IsValid = GetUrl_FunctionAddress != IntPtr.Zero && GetUrl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptWebBrowser:GetUrl", GetUrl_IsValid);
		GetTitleText_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTitleText");
		GetTitleText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTitleText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTitleText_ReturnValue_PropertyAddress, GetTitleText_FunctionAddress, "ReturnValue");
		GetTitleText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTitleText_FunctionAddress, "ReturnValue");
		GetTitleText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTitleText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTitleText_IsValid = GetTitleText_FunctionAddress != IntPtr.Zero && GetTitleText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptWebBrowser:GetTitleText", GetTitleText_IsValid);
		ExecuteJavascript_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ExecuteJavascript");
		ExecuteJavascript_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteJavascript_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExecuteJavascript_ScriptText_PropertyAddress, ExecuteJavascript_FunctionAddress, "ScriptText");
		ExecuteJavascript_ScriptText_Offset = NativeReflectionCached.GetPropertyOffset(ExecuteJavascript_FunctionAddress, "ScriptText");
		ExecuteJavascript_ScriptText_IsValid = NativeReflectionCached.ValidatePropertyClass(ExecuteJavascript_FunctionAddress, "ScriptText", Classes.FStrProperty);
		ExecuteJavascript_IsValid = ExecuteJavascript_FunctionAddress != IntPtr.Zero && ExecuteJavascript_ScriptText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/JavascriptEditor.JavascriptWebBrowser:ExecuteJavascript", ExecuteJavascript_IsValid);
	}
}
