using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.Plugins.SimpleCharts;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/SimpleCharts.ChartBase", "SimpleCharts", UnrealModuleType.GamePlugin)]
public class UChartBase : UWidget
{
	private static bool useDirtyRect_IsValid;

	private static FFieldAddress useDirtyRect_PropertyAddress;

	private static int useDirtyRect_Offset;

	private static bool Theme_IsValid;

	private static FFieldAddress Theme_PropertyAddress;

	private static int Theme_Offset;

	private static bool AxisStyleWithTheme_IsValid;

	private static FFieldAddress AxisStyleWithTheme_PropertyAddress;

	private static int AxisStyleWithTheme_Offset;

	private static bool title_text_IsValid;

	private static int title_text_Offset;

	private static bool title_show_IsValid;

	private static FFieldAddress title_show_PropertyAddress;

	private static int title_show_Offset;

	private static bool title_position_IsValid;

	private static FFieldAddress title_position_PropertyAddress;

	private static int title_position_Offset;

	private static bool title_fontSize_IsValid;

	private static int title_fontSize_Offset;

	private static bool title_color_IsValid;

	private static int title_color_Offset;

	private static bool legend_show_IsValid;

	private static FFieldAddress legend_show_PropertyAddress;

	private static int legend_show_Offset;

	private static bool legend_position_IsValid;

	private static FFieldAddress legend_position_PropertyAddress;

	private static int legend_position_Offset;

	private static bool legend_orient_IsValid;

	private static FFieldAddress legend_orient_PropertyAddress;

	private static int legend_orient_Offset;

	private static bool legend_color_IsValid;

	private static int legend_color_Offset;

	private static bool legend_fontSize_IsValid;

	private static int legend_fontSize_Offset;

	private static bool AxisData_IsValid;

	private static FFieldAddress AxisData_PropertyAddress;

	private static int AxisData_Offset;

	private TArrayReadWriteMarshaler<string> AxisData_MarshalerCached;

	private static bool IsXAxis_IsValid;

	private static FFieldAddress IsXAxis_PropertyAddress;

	private static int IsXAxis_Offset;

	private static bool boundaryGap_IsValid;

	private static FFieldAddress boundaryGap_PropertyAddress;

	private static int boundaryGap_Offset;

	private static bool XaxisLabel_IsValid;

	private static int XaxisLabel_Offset;

	private static bool XaxisLine_IsValid;

	private static int XaxisLine_Offset;

	private static bool XsplitLine_IsValid;

	private static int XsplitLine_Offset;

	private static bool YaxisLabel_IsValid;

	private static int YaxisLabel_Offset;

	private static bool YaxisLine_IsValid;

	private static int YaxisLine_Offset;

	private static bool YsplitLine_IsValid;

	private static int YsplitLine_Offset;

	private static bool tooltip_type_IsValid;

	private static FFieldAddress tooltip_type_PropertyAddress;

	private static int tooltip_type_Offset;

	private static bool tooltip_trigger_IsValid;

	private static FFieldAddress tooltip_trigger_PropertyAddress;

	private static int tooltip_trigger_Offset;

	private static bool text_color_IsValid;

	private static int text_color_Offset;

	private static bool tip_backgroundColor_IsValid;

	private static int tip_backgroundColor_Offset;

	private static bool use_custom_color_IsValid;

	private static FFieldAddress use_custom_color_PropertyAddress;

	private static int use_custom_color_Offset;

	private static bool custom_color_IsValid;

	private static FFieldAddress custom_color_PropertyAddress;

	private static int custom_color_Offset;

	private TArrayReadWriteMarshaler<FColor> custom_color_MarshalerCached;

	private static bool UpdateChart_IsValid;

	private static IntPtr UpdateChart_FunctionAddress;

	private static int UpdateChart_ParamsSize;

	private static bool SetYAxisStyle_IsValid;

	private static IntPtr SetYAxisStyle_FunctionAddress;

	private static int SetYAxisStyle_ParamsSize;

	private static bool SetYAxisStyle_Yaxis_Label_IsValid;

	private static FFieldAddress SetYAxisStyle_Yaxis_Label_PropertyAddress;

	private static int SetYAxisStyle_Yaxis_Label_Offset;

	private static bool SetYAxisStyle_Yaxis_Line_IsValid;

	private static FFieldAddress SetYAxisStyle_Yaxis_Line_PropertyAddress;

	private static int SetYAxisStyle_Yaxis_Line_Offset;

	private static bool SetYAxisStyle_Ysplit_Line_IsValid;

	private static FFieldAddress SetYAxisStyle_Ysplit_Line_PropertyAddress;

	private static int SetYAxisStyle_Ysplit_Line_Offset;

	private static bool SetXAxisStyle_IsValid;

	private static IntPtr SetXAxisStyle_FunctionAddress;

	private static int SetXAxisStyle_ParamsSize;

	private static bool SetXAxisStyle_Xaxis_Label_IsValid;

	private static FFieldAddress SetXAxisStyle_Xaxis_Label_PropertyAddress;

	private static int SetXAxisStyle_Xaxis_Label_Offset;

	private static bool SetXAxisStyle_Xaxis_Line_IsValid;

	private static FFieldAddress SetXAxisStyle_Xaxis_Line_PropertyAddress;

	private static int SetXAxisStyle_Xaxis_Line_Offset;

	private static bool SetXAxisStyle_Xsplit_Line_IsValid;

	private static FFieldAddress SetXAxisStyle_Xsplit_Line_PropertyAddress;

	private static int SetXAxisStyle_Xsplit_Line_Offset;

	private static bool SetTooltipStyle_IsValid;

	private static IntPtr SetTooltipStyle_FunctionAddress;

	private static int SetTooltipStyle_ParamsSize;

	private static bool SetTooltipStyle_trigger_IsValid;

	private static FFieldAddress SetTooltipStyle_trigger_PropertyAddress;

	private static int SetTooltipStyle_trigger_Offset;

	private static bool SetTooltipStyle_tooltip_IsValid;

	private static FFieldAddress SetTooltipStyle_tooltip_PropertyAddress;

	private static int SetTooltipStyle_tooltip_Offset;

	private static bool SetTooltipStyle_textcolor_IsValid;

	private static FFieldAddress SetTooltipStyle_textcolor_PropertyAddress;

	private static int SetTooltipStyle_textcolor_Offset;

	private static bool SetTooltipStyle_backgroundcolor_IsValid;

	private static FFieldAddress SetTooltipStyle_backgroundcolor_PropertyAddress;

	private static int SetTooltipStyle_backgroundcolor_Offset;

	private static bool SetTitle_IsValid;

	private static IntPtr SetTitle_FunctionAddress;

	private static int SetTitle_ParamsSize;

	private static bool SetTitle_text_IsValid;

	private static FFieldAddress SetTitle_text_PropertyAddress;

	private static int SetTitle_text_Offset;

	private static bool SetTitle_show_IsValid;

	private static FFieldAddress SetTitle_show_PropertyAddress;

	private static int SetTitle_show_Offset;

	private static bool SetTitle_position_IsValid;

	private static FFieldAddress SetTitle_position_PropertyAddress;

	private static int SetTitle_position_Offset;

	private static bool SetTitle_fontSize_IsValid;

	private static FFieldAddress SetTitle_fontSize_PropertyAddress;

	private static int SetTitle_fontSize_Offset;

	private static bool SetTitle_color_IsValid;

	private static FFieldAddress SetTitle_color_PropertyAddress;

	private static int SetTitle_color_Offset;

	private static bool SetTheme_IsValid;

	private static IntPtr SetTheme_FunctionAddress;

	private static int SetTheme_ParamsSize;

	private static bool SetTheme_ChartTheme_IsValid;

	private static FFieldAddress SetTheme_ChartTheme_PropertyAddress;

	private static int SetTheme_ChartTheme_Offset;

	private static bool SetTheme_Axis_Style_With_Theme_IsValid;

	private static FFieldAddress SetTheme_Axis_Style_With_Theme_PropertyAddress;

	private static int SetTheme_Axis_Style_With_Theme_Offset;

	private static bool SetCustomColor_IsValid;

	private static IntPtr SetCustomColor_FunctionAddress;

	private static int SetCustomColor_ParamsSize;

	private static bool SetCustomColor_active_IsValid;

	private static FFieldAddress SetCustomColor_active_PropertyAddress;

	private static int SetCustomColor_active_Offset;

	private static bool SetCustomColor_custom_color_IsValid;

	private static FFieldAddress SetCustomColor_custom_color_PropertyAddress;

	private static int SetCustomColor_custom_color_Offset;

	private static bool SetAxis_IsValid;

	private static IntPtr SetAxis_FunctionAddress;

	private static int SetAxis_ParamsSize;

	private static bool SetAxis_XAxis_IsValid;

	private static FFieldAddress SetAxis_XAxis_PropertyAddress;

	private static int SetAxis_XAxis_Offset;

	private static bool SetAxis_Axis_Data_IsValid;

	private static FFieldAddress SetAxis_Axis_Data_PropertyAddress;

	private static int SetAxis_Axis_Data_Offset;

	private static bool SetAnim_IsValid;

	private static IntPtr SetAnim_FunctionAddress;

	private static int SetAnim_ParamsSize;

	private static bool SetAnim_active_IsValid;

	private static FFieldAddress SetAnim_active_PropertyAddress;

	private static int SetAnim_active_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:useDirtyRect")]
	public bool useDirtyRect
	{
		get
		{
			CheckDestroyed();
			if (!useDirtyRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:useDirtyRect");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, useDirtyRect_Offset), 0, useDirtyRect_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!useDirtyRect_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:useDirtyRect");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, useDirtyRect_Offset), 0, useDirtyRect_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:Theme")]
	public EChartTheme Theme
	{
		get
		{
			CheckDestroyed();
			if (!Theme_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:Theme");
				return EChartTheme.Azul;
			}
			return EnumMarshaler<EChartTheme>.FromNative(IntPtr.Add(base.Address, Theme_Offset), 0, Theme_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Theme_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:Theme");
			}
			else
			{
				EnumMarshaler<EChartTheme>.ToNative(IntPtr.Add(base.Address, Theme_Offset), 0, Theme_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:AxisStyleWithTheme")]
	public bool AxisStyleWithTheme
	{
		get
		{
			CheckDestroyed();
			if (!AxisStyleWithTheme_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:AxisStyleWithTheme");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AxisStyleWithTheme_Offset), 0, AxisStyleWithTheme_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AxisStyleWithTheme_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:AxisStyleWithTheme");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AxisStyleWithTheme_Offset), 0, AxisStyleWithTheme_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:title_text")]
	public string title_text
	{
		get
		{
			CheckDestroyed();
			if (!title_text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_text");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, title_text_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!title_text_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_text");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, title_text_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:title_show")]
	public bool title_show
	{
		get
		{
			CheckDestroyed();
			if (!title_show_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_show");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, title_show_Offset), 0, title_show_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!title_show_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_show");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, title_show_Offset), 0, title_show_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:title_position")]
	public EPosition title_position
	{
		get
		{
			CheckDestroyed();
			if (!title_position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_position");
				return EPosition.Center;
			}
			return EnumMarshaler<EPosition>.FromNative(IntPtr.Add(base.Address, title_position_Offset), 0, title_position_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!title_position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_position");
			}
			else
			{
				EnumMarshaler<EPosition>.ToNative(IntPtr.Add(base.Address, title_position_Offset), 0, title_position_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:title_fontSize")]
	public int title_fontSize
	{
		get
		{
			CheckDestroyed();
			if (!title_fontSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_fontSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, title_fontSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!title_fontSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_fontSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, title_fontSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:title_color")]
	public FColor title_color
	{
		get
		{
			CheckDestroyed();
			if (!title_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_color");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, title_color_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!title_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:title_color");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, title_color_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:legend_show")]
	public bool legend_show
	{
		get
		{
			CheckDestroyed();
			if (!legend_show_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_show");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, legend_show_Offset), 0, legend_show_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!legend_show_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_show");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, legend_show_Offset), 0, legend_show_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:legend_position")]
	public EPosition legend_position
	{
		get
		{
			CheckDestroyed();
			if (!legend_position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_position");
				return EPosition.Center;
			}
			return EnumMarshaler<EPosition>.FromNative(IntPtr.Add(base.Address, legend_position_Offset), 0, legend_position_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!legend_position_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_position");
			}
			else
			{
				EnumMarshaler<EPosition>.ToNative(IntPtr.Add(base.Address, legend_position_Offset), 0, legend_position_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:legend_orient")]
	public EOrient legend_orient
	{
		get
		{
			CheckDestroyed();
			if (!legend_orient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_orient");
				return EOrient.Horizontal;
			}
			return EnumMarshaler<EOrient>.FromNative(IntPtr.Add(base.Address, legend_orient_Offset), 0, legend_orient_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!legend_orient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_orient");
			}
			else
			{
				EnumMarshaler<EOrient>.ToNative(IntPtr.Add(base.Address, legend_orient_Offset), 0, legend_orient_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:legend_color")]
	public FColor legend_color
	{
		get
		{
			CheckDestroyed();
			if (!legend_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_color");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, legend_color_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!legend_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_color");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, legend_color_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:legend_fontSize")]
	public int legend_fontSize
	{
		get
		{
			CheckDestroyed();
			if (!legend_fontSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_fontSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, legend_fontSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!legend_fontSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:legend_fontSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, legend_fontSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:AxisData")]
	public TArrayReadWrite<string> AxisData
	{
		get
		{
			CheckDestroyed();
			if (!AxisData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:AxisData");
				return null;
			}
			if (AxisData_MarshalerCached == null)
			{
				AxisData_MarshalerCached = new TArrayReadWriteMarshaler<string>(1, AxisData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return AxisData_MarshalerCached.FromNative(IntPtr.Add(base.Address, AxisData_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:IsXAxis")]
	public bool IsXAxis
	{
		get
		{
			CheckDestroyed();
			if (!IsXAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:IsXAxis");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsXAxis_Offset), 0, IsXAxis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsXAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:IsXAxis");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsXAxis_Offset), 0, IsXAxis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:boundaryGap")]
	public bool boundaryGap
	{
		get
		{
			CheckDestroyed();
			if (!boundaryGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:boundaryGap");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, boundaryGap_Offset), 0, boundaryGap_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!boundaryGap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:boundaryGap");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, boundaryGap_Offset), 0, boundaryGap_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:XaxisLabel")]
	public FaxisLabel XaxisLabel
	{
		get
		{
			CheckDestroyed();
			if (!XaxisLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:XaxisLabel");
				return default(FaxisLabel);
			}
			return FaxisLabel.FromNative(IntPtr.Add(base.Address, XaxisLabel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XaxisLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:XaxisLabel");
			}
			else
			{
				FaxisLabel.ToNative(IntPtr.Add(base.Address, XaxisLabel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:XaxisLine")]
	public FLineStyle XaxisLine
	{
		get
		{
			CheckDestroyed();
			if (!XaxisLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:XaxisLine");
				return default(FLineStyle);
			}
			return FLineStyle.FromNative(IntPtr.Add(base.Address, XaxisLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XaxisLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:XaxisLine");
			}
			else
			{
				FLineStyle.ToNative(IntPtr.Add(base.Address, XaxisLine_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:XsplitLine")]
	public FLineStyle XsplitLine
	{
		get
		{
			CheckDestroyed();
			if (!XsplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:XsplitLine");
				return default(FLineStyle);
			}
			return FLineStyle.FromNative(IntPtr.Add(base.Address, XsplitLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XsplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:XsplitLine");
			}
			else
			{
				FLineStyle.ToNative(IntPtr.Add(base.Address, XsplitLine_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:YaxisLabel")]
	public FaxisLabel YaxisLabel
	{
		get
		{
			CheckDestroyed();
			if (!YaxisLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:YaxisLabel");
				return default(FaxisLabel);
			}
			return FaxisLabel.FromNative(IntPtr.Add(base.Address, YaxisLabel_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YaxisLabel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:YaxisLabel");
			}
			else
			{
				FaxisLabel.ToNative(IntPtr.Add(base.Address, YaxisLabel_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:YaxisLine")]
	public FLineStyle YaxisLine
	{
		get
		{
			CheckDestroyed();
			if (!YaxisLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:YaxisLine");
				return default(FLineStyle);
			}
			return FLineStyle.FromNative(IntPtr.Add(base.Address, YaxisLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YaxisLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:YaxisLine");
			}
			else
			{
				FLineStyle.ToNative(IntPtr.Add(base.Address, YaxisLine_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:YsplitLine")]
	public FLineStyle YsplitLine
	{
		get
		{
			CheckDestroyed();
			if (!YsplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:YsplitLine");
				return default(FLineStyle);
			}
			return FLineStyle.FromNative(IntPtr.Add(base.Address, YsplitLine_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YsplitLine_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:YsplitLine");
			}
			else
			{
				FLineStyle.ToNative(IntPtr.Add(base.Address, YsplitLine_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:tooltip_type")]
	public ETooltipType tooltip_type
	{
		get
		{
			CheckDestroyed();
			if (!tooltip_type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:tooltip_type");
				return ETooltipType.Line;
			}
			return EnumMarshaler<ETooltipType>.FromNative(IntPtr.Add(base.Address, tooltip_type_Offset), 0, tooltip_type_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!tooltip_type_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:tooltip_type");
			}
			else
			{
				EnumMarshaler<ETooltipType>.ToNative(IntPtr.Add(base.Address, tooltip_type_Offset), 0, tooltip_type_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:tooltip_trigger")]
	public ETriggerType tooltip_trigger
	{
		get
		{
			CheckDestroyed();
			if (!tooltip_trigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:tooltip_trigger");
				return ETriggerType.Item;
			}
			return EnumMarshaler<ETriggerType>.FromNative(IntPtr.Add(base.Address, tooltip_trigger_Offset), 0, tooltip_trigger_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!tooltip_trigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:tooltip_trigger");
			}
			else
			{
				EnumMarshaler<ETriggerType>.ToNative(IntPtr.Add(base.Address, tooltip_trigger_Offset), 0, tooltip_trigger_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:text_color")]
	public FColor text_color
	{
		get
		{
			CheckDestroyed();
			if (!text_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:text_color");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, text_color_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!text_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:text_color");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, text_color_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:tip_backgroundColor")]
	public FColor tip_backgroundColor
	{
		get
		{
			CheckDestroyed();
			if (!tip_backgroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:tip_backgroundColor");
				return default(FColor);
			}
			return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(base.Address, tip_backgroundColor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!tip_backgroundColor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:tip_backgroundColor");
			}
			else
			{
				BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(base.Address, tip_backgroundColor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:use_custom_color")]
	public bool use_custom_color
	{
		get
		{
			CheckDestroyed();
			if (!use_custom_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:use_custom_color");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, use_custom_color_Offset), 0, use_custom_color_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!use_custom_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:use_custom_color");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, use_custom_color_Offset), 0, use_custom_color_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:custom_color")]
	public TArrayReadWrite<FColor> custom_color
	{
		get
		{
			CheckDestroyed();
			if (!custom_color_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/SimpleCharts.ChartBase:custom_color");
				return null;
			}
			if (custom_color_MarshalerCached == null)
			{
				custom_color_MarshalerCached = new TArrayReadWriteMarshaler<FColor>(1, custom_color_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative);
			}
			return custom_color_MarshalerCached.FromNative(IntPtr.Add(base.Address, custom_color_Offset));
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:UpdateChart")]
	public unsafe void UpdateChart()
	{
		CheckDestroyed();
		if (!UpdateChart_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:UpdateChart");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateChart_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateChart_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateChart_FunctionAddress, argsSize: UpdateChart_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:SetYAxisStyle")]
	public unsafe void SetYAxisStyle(FaxisLabel Yaxis_Label, FLineStyle Yaxis_Line, FLineStyle Ysplit_Line)
	{
		CheckDestroyed();
		if (!SetYAxisStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:SetYAxisStyle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetYAxisStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetYAxisStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetYAxisStyle_Yaxis_Label_PropertyAddress.Address, intPtr);
		FaxisLabel.ToNative(IntPtr.Add(intPtr, SetYAxisStyle_Yaxis_Label_Offset), 0, SetYAxisStyle_Yaxis_Label_PropertyAddress.Address, Yaxis_Label);
		NativeReflection.InitializeValue_InContainer(SetYAxisStyle_Yaxis_Line_PropertyAddress.Address, intPtr);
		FLineStyle.ToNative(IntPtr.Add(intPtr, SetYAxisStyle_Yaxis_Line_Offset), 0, SetYAxisStyle_Yaxis_Line_PropertyAddress.Address, Yaxis_Line);
		NativeReflection.InitializeValue_InContainer(SetYAxisStyle_Ysplit_Line_PropertyAddress.Address, intPtr);
		FLineStyle.ToNative(IntPtr.Add(intPtr, SetYAxisStyle_Ysplit_Line_Offset), 0, SetYAxisStyle_Ysplit_Line_PropertyAddress.Address, Ysplit_Line);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetYAxisStyle_FunctionAddress, intPtr, SetYAxisStyle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetYAxisStyle_Yaxis_Label_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:SetXAxisStyle")]
	public unsafe void SetXAxisStyle(FaxisLabel Xaxis_Label, FLineStyle Xaxis_Line, FLineStyle Xsplit_Line)
	{
		CheckDestroyed();
		if (!SetXAxisStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:SetXAxisStyle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetXAxisStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetXAxisStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetXAxisStyle_Xaxis_Label_PropertyAddress.Address, intPtr);
		FaxisLabel.ToNative(IntPtr.Add(intPtr, SetXAxisStyle_Xaxis_Label_Offset), 0, SetXAxisStyle_Xaxis_Label_PropertyAddress.Address, Xaxis_Label);
		NativeReflection.InitializeValue_InContainer(SetXAxisStyle_Xaxis_Line_PropertyAddress.Address, intPtr);
		FLineStyle.ToNative(IntPtr.Add(intPtr, SetXAxisStyle_Xaxis_Line_Offset), 0, SetXAxisStyle_Xaxis_Line_PropertyAddress.Address, Xaxis_Line);
		NativeReflection.InitializeValue_InContainer(SetXAxisStyle_Xsplit_Line_PropertyAddress.Address, intPtr);
		FLineStyle.ToNative(IntPtr.Add(intPtr, SetXAxisStyle_Xsplit_Line_Offset), 0, SetXAxisStyle_Xsplit_Line_PropertyAddress.Address, Xsplit_Line);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetXAxisStyle_FunctionAddress, intPtr, SetXAxisStyle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetXAxisStyle_Xaxis_Label_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:SetTooltipStyle")]
	public unsafe void SetTooltipStyle(ETriggerType trigger, ETooltipType tooltip, FLinearColor textcolor, FLinearColor backgroundcolor)
	{
		CheckDestroyed();
		if (!SetTooltipStyle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:SetTooltipStyle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTooltipStyle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTooltipStyle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETriggerType>.ToNative(IntPtr.Add(intPtr, SetTooltipStyle_trigger_Offset), 0, SetTooltipStyle_trigger_PropertyAddress.Address, trigger);
		EnumMarshaler<ETooltipType>.ToNative(IntPtr.Add(intPtr, SetTooltipStyle_tooltip_Offset), 0, SetTooltipStyle_tooltip_PropertyAddress.Address, tooltip);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetTooltipStyle_textcolor_Offset), 0, SetTooltipStyle_textcolor_PropertyAddress.Address, textcolor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetTooltipStyle_backgroundcolor_Offset), 0, SetTooltipStyle_backgroundcolor_PropertyAddress.Address, backgroundcolor);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTooltipStyle_FunctionAddress, intPtr, SetTooltipStyle_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:SetTitle")]
	public unsafe void SetTitle(string text, bool show, EPosition position, int fontSize, FLinearColor color)
	{
		CheckDestroyed();
		if (!SetTitle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:SetTitle");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTitle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTitle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetTitle_text_Offset), 0, SetTitle_text_PropertyAddress.Address, text);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTitle_show_Offset), 0, SetTitle_show_PropertyAddress.Address, show);
		EnumMarshaler<EPosition>.ToNative(IntPtr.Add(intPtr, SetTitle_position_Offset), 0, SetTitle_position_PropertyAddress.Address, position);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTitle_fontSize_Offset), 0, SetTitle_fontSize_PropertyAddress.Address, fontSize);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, SetTitle_color_Offset), 0, SetTitle_color_PropertyAddress.Address, color);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTitle_FunctionAddress, intPtr, SetTitle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTitle_text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:SetTheme")]
	public unsafe void SetTheme(EChartTheme ChartTheme, bool Axis_Style_With_Theme)
	{
		CheckDestroyed();
		if (!SetTheme_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:SetTheme");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTheme_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTheme_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EChartTheme>.ToNative(IntPtr.Add(intPtr, SetTheme_ChartTheme_Offset), 0, SetTheme_ChartTheme_PropertyAddress.Address, ChartTheme);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetTheme_Axis_Style_With_Theme_Offset), 0, SetTheme_Axis_Style_With_Theme_PropertyAddress.Address, Axis_Style_With_Theme);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetTheme_FunctionAddress, intPtr, SetTheme_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:SetCustomColor")]
	public unsafe void SetCustomColor(bool active, List<FColor> custom_color)
	{
		CheckDestroyed();
		if (!SetCustomColor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:SetCustomColor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCustomColor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCustomColor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetCustomColor_active_Offset), 0, SetCustomColor_active_PropertyAddress.Address, active);
		new TArrayCopyMarshaler<FColor>(1, SetCustomColor_custom_color_PropertyAddress, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.FromNative, CachedMarshalingDelegates<FColor, BlittableTypeMarshaler<FColor>>.ToNative).ToNative(IntPtr.Add(intPtr, SetCustomColor_custom_color_Offset), custom_color);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetCustomColor_FunctionAddress, intPtr, SetCustomColor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetCustomColor_custom_color_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:SetAxis")]
	public unsafe void SetAxis(bool XAxis, List<string> Axis_Data)
	{
		CheckDestroyed();
		if (!SetAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:SetAxis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAxis_XAxis_Offset), 0, SetAxis_XAxis_PropertyAddress.Address, XAxis);
		new TArrayCopyMarshaler<string>(1, SetAxis_Axis_Data_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetAxis_Axis_Data_Offset), Axis_Data);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAxis_FunctionAddress, intPtr, SetAxis_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetAxis_Axis_Data_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/SimpleCharts.ChartBase:SetAnim")]
	public unsafe void SetAnim(bool active)
	{
		CheckDestroyed();
		if (!SetAnim_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SimpleCharts.ChartBase:SetAnim");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAnim_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAnim_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAnim_active_Offset), 0, SetAnim_active_PropertyAddress.Address, active);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAnim_FunctionAddress, intPtr, SetAnim_ParamsSize);
	}

	static UChartBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UChartBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UChartBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/SimpleCharts.ChartBase");
		NativeReflectionCached.GetPropertyRef(ref useDirtyRect_PropertyAddress, intPtr, "useDirtyRect");
		useDirtyRect_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "useDirtyRect");
		useDirtyRect_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "useDirtyRect", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Theme_PropertyAddress, intPtr, "Theme");
		Theme_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Theme");
		Theme_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Theme", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AxisStyleWithTheme_PropertyAddress, intPtr, "AxisStyleWithTheme");
		AxisStyleWithTheme_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AxisStyleWithTheme");
		AxisStyleWithTheme_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AxisStyleWithTheme", Classes.FBoolProperty);
		title_text_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "title_text");
		title_text_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "title_text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref title_show_PropertyAddress, intPtr, "title_show");
		title_show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "title_show");
		title_show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "title_show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref title_position_PropertyAddress, intPtr, "title_position");
		title_position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "title_position");
		title_position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "title_position", Classes.FEnumProperty);
		title_fontSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "title_fontSize");
		title_fontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "title_fontSize", Classes.FIntProperty);
		title_color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "title_color");
		title_color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "title_color", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref legend_show_PropertyAddress, intPtr, "legend_show");
		legend_show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "legend_show");
		legend_show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "legend_show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref legend_position_PropertyAddress, intPtr, "legend_position");
		legend_position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "legend_position");
		legend_position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "legend_position", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref legend_orient_PropertyAddress, intPtr, "legend_orient");
		legend_orient_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "legend_orient");
		legend_orient_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "legend_orient", Classes.FEnumProperty);
		legend_color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "legend_color");
		legend_color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "legend_color", Classes.FStructProperty);
		legend_fontSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "legend_fontSize");
		legend_fontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "legend_fontSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AxisData_PropertyAddress, intPtr, "AxisData");
		AxisData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AxisData");
		AxisData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AxisData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsXAxis_PropertyAddress, intPtr, "IsXAxis");
		IsXAxis_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IsXAxis");
		IsXAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IsXAxis", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref boundaryGap_PropertyAddress, intPtr, "boundaryGap");
		boundaryGap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "boundaryGap");
		boundaryGap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "boundaryGap", Classes.FBoolProperty);
		XaxisLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XaxisLabel");
		XaxisLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XaxisLabel", Classes.FStructProperty);
		XaxisLine_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XaxisLine");
		XaxisLine_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XaxisLine", Classes.FStructProperty);
		XsplitLine_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XsplitLine");
		XsplitLine_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XsplitLine", Classes.FStructProperty);
		YaxisLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YaxisLabel");
		YaxisLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YaxisLabel", Classes.FStructProperty);
		YaxisLine_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YaxisLine");
		YaxisLine_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YaxisLine", Classes.FStructProperty);
		YsplitLine_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YsplitLine");
		YsplitLine_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YsplitLine", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref tooltip_type_PropertyAddress, intPtr, "tooltip_type");
		tooltip_type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "tooltip_type");
		tooltip_type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "tooltip_type", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref tooltip_trigger_PropertyAddress, intPtr, "tooltip_trigger");
		tooltip_trigger_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "tooltip_trigger");
		tooltip_trigger_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "tooltip_trigger", Classes.FEnumProperty);
		text_color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "text_color");
		text_color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "text_color", Classes.FStructProperty);
		tip_backgroundColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "tip_backgroundColor");
		tip_backgroundColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "tip_backgroundColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref use_custom_color_PropertyAddress, intPtr, "use_custom_color");
		use_custom_color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "use_custom_color");
		use_custom_color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "use_custom_color", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref custom_color_PropertyAddress, intPtr, "custom_color");
		custom_color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "custom_color");
		custom_color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "custom_color", Classes.FArrayProperty);
		UpdateChart_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateChart");
		UpdateChart_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateChart_FunctionAddress);
		UpdateChart_IsValid = UpdateChart_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:UpdateChart", UpdateChart_IsValid);
		SetYAxisStyle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetYAxisStyle");
		SetYAxisStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetYAxisStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetYAxisStyle_Yaxis_Label_PropertyAddress, SetYAxisStyle_FunctionAddress, "Yaxis_Label");
		SetYAxisStyle_Yaxis_Label_Offset = NativeReflectionCached.GetPropertyOffset(SetYAxisStyle_FunctionAddress, "Yaxis_Label");
		SetYAxisStyle_Yaxis_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(SetYAxisStyle_FunctionAddress, "Yaxis_Label", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetYAxisStyle_Yaxis_Line_PropertyAddress, SetYAxisStyle_FunctionAddress, "Yaxis_Line");
		SetYAxisStyle_Yaxis_Line_Offset = NativeReflectionCached.GetPropertyOffset(SetYAxisStyle_FunctionAddress, "Yaxis_Line");
		SetYAxisStyle_Yaxis_Line_IsValid = NativeReflectionCached.ValidatePropertyClass(SetYAxisStyle_FunctionAddress, "Yaxis_Line", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetYAxisStyle_Ysplit_Line_PropertyAddress, SetYAxisStyle_FunctionAddress, "Ysplit_Line");
		SetYAxisStyle_Ysplit_Line_Offset = NativeReflectionCached.GetPropertyOffset(SetYAxisStyle_FunctionAddress, "Ysplit_Line");
		SetYAxisStyle_Ysplit_Line_IsValid = NativeReflectionCached.ValidatePropertyClass(SetYAxisStyle_FunctionAddress, "Ysplit_Line", Classes.FStructProperty);
		SetYAxisStyle_IsValid = SetYAxisStyle_FunctionAddress != IntPtr.Zero && SetYAxisStyle_Yaxis_Label_IsValid && SetYAxisStyle_Yaxis_Line_IsValid && SetYAxisStyle_Ysplit_Line_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:SetYAxisStyle", SetYAxisStyle_IsValid);
		SetXAxisStyle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetXAxisStyle");
		SetXAxisStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetXAxisStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetXAxisStyle_Xaxis_Label_PropertyAddress, SetXAxisStyle_FunctionAddress, "Xaxis_Label");
		SetXAxisStyle_Xaxis_Label_Offset = NativeReflectionCached.GetPropertyOffset(SetXAxisStyle_FunctionAddress, "Xaxis_Label");
		SetXAxisStyle_Xaxis_Label_IsValid = NativeReflectionCached.ValidatePropertyClass(SetXAxisStyle_FunctionAddress, "Xaxis_Label", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetXAxisStyle_Xaxis_Line_PropertyAddress, SetXAxisStyle_FunctionAddress, "Xaxis_Line");
		SetXAxisStyle_Xaxis_Line_Offset = NativeReflectionCached.GetPropertyOffset(SetXAxisStyle_FunctionAddress, "Xaxis_Line");
		SetXAxisStyle_Xaxis_Line_IsValid = NativeReflectionCached.ValidatePropertyClass(SetXAxisStyle_FunctionAddress, "Xaxis_Line", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetXAxisStyle_Xsplit_Line_PropertyAddress, SetXAxisStyle_FunctionAddress, "Xsplit_Line");
		SetXAxisStyle_Xsplit_Line_Offset = NativeReflectionCached.GetPropertyOffset(SetXAxisStyle_FunctionAddress, "Xsplit_Line");
		SetXAxisStyle_Xsplit_Line_IsValid = NativeReflectionCached.ValidatePropertyClass(SetXAxisStyle_FunctionAddress, "Xsplit_Line", Classes.FStructProperty);
		SetXAxisStyle_IsValid = SetXAxisStyle_FunctionAddress != IntPtr.Zero && SetXAxisStyle_Xaxis_Label_IsValid && SetXAxisStyle_Xaxis_Line_IsValid && SetXAxisStyle_Xsplit_Line_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:SetXAxisStyle", SetXAxisStyle_IsValid);
		SetTooltipStyle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTooltipStyle");
		SetTooltipStyle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTooltipStyle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTooltipStyle_trigger_PropertyAddress, SetTooltipStyle_FunctionAddress, "trigger");
		SetTooltipStyle_trigger_Offset = NativeReflectionCached.GetPropertyOffset(SetTooltipStyle_FunctionAddress, "trigger");
		SetTooltipStyle_trigger_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTooltipStyle_FunctionAddress, "trigger", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTooltipStyle_tooltip_PropertyAddress, SetTooltipStyle_FunctionAddress, "tooltip");
		SetTooltipStyle_tooltip_Offset = NativeReflectionCached.GetPropertyOffset(SetTooltipStyle_FunctionAddress, "tooltip");
		SetTooltipStyle_tooltip_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTooltipStyle_FunctionAddress, "tooltip", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTooltipStyle_textcolor_PropertyAddress, SetTooltipStyle_FunctionAddress, "textcolor");
		SetTooltipStyle_textcolor_Offset = NativeReflectionCached.GetPropertyOffset(SetTooltipStyle_FunctionAddress, "textcolor");
		SetTooltipStyle_textcolor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTooltipStyle_FunctionAddress, "textcolor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTooltipStyle_backgroundcolor_PropertyAddress, SetTooltipStyle_FunctionAddress, "backgroundcolor");
		SetTooltipStyle_backgroundcolor_Offset = NativeReflectionCached.GetPropertyOffset(SetTooltipStyle_FunctionAddress, "backgroundcolor");
		SetTooltipStyle_backgroundcolor_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTooltipStyle_FunctionAddress, "backgroundcolor", Classes.FStructProperty);
		SetTooltipStyle_IsValid = SetTooltipStyle_FunctionAddress != IntPtr.Zero && SetTooltipStyle_trigger_IsValid && SetTooltipStyle_tooltip_IsValid && SetTooltipStyle_textcolor_IsValid && SetTooltipStyle_backgroundcolor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:SetTooltipStyle", SetTooltipStyle_IsValid);
		SetTitle_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTitle");
		SetTitle_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTitle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTitle_text_PropertyAddress, SetTitle_FunctionAddress, "text");
		SetTitle_text_Offset = NativeReflectionCached.GetPropertyOffset(SetTitle_FunctionAddress, "text");
		SetTitle_text_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTitle_FunctionAddress, "text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTitle_show_PropertyAddress, SetTitle_FunctionAddress, "show");
		SetTitle_show_Offset = NativeReflectionCached.GetPropertyOffset(SetTitle_FunctionAddress, "show");
		SetTitle_show_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTitle_FunctionAddress, "show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTitle_position_PropertyAddress, SetTitle_FunctionAddress, "position");
		SetTitle_position_Offset = NativeReflectionCached.GetPropertyOffset(SetTitle_FunctionAddress, "position");
		SetTitle_position_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTitle_FunctionAddress, "position", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTitle_fontSize_PropertyAddress, SetTitle_FunctionAddress, "fontSize");
		SetTitle_fontSize_Offset = NativeReflectionCached.GetPropertyOffset(SetTitle_FunctionAddress, "fontSize");
		SetTitle_fontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTitle_FunctionAddress, "fontSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTitle_color_PropertyAddress, SetTitle_FunctionAddress, "color");
		SetTitle_color_Offset = NativeReflectionCached.GetPropertyOffset(SetTitle_FunctionAddress, "color");
		SetTitle_color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTitle_FunctionAddress, "color", Classes.FStructProperty);
		SetTitle_IsValid = SetTitle_FunctionAddress != IntPtr.Zero && SetTitle_text_IsValid && SetTitle_show_IsValid && SetTitle_position_IsValid && SetTitle_fontSize_IsValid && SetTitle_color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:SetTitle", SetTitle_IsValid);
		SetTheme_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetTheme");
		SetTheme_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTheme_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTheme_ChartTheme_PropertyAddress, SetTheme_FunctionAddress, "ChartTheme");
		SetTheme_ChartTheme_Offset = NativeReflectionCached.GetPropertyOffset(SetTheme_FunctionAddress, "ChartTheme");
		SetTheme_ChartTheme_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTheme_FunctionAddress, "ChartTheme", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTheme_Axis_Style_With_Theme_PropertyAddress, SetTheme_FunctionAddress, "Axis_Style_With_Theme");
		SetTheme_Axis_Style_With_Theme_Offset = NativeReflectionCached.GetPropertyOffset(SetTheme_FunctionAddress, "Axis_Style_With_Theme");
		SetTheme_Axis_Style_With_Theme_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTheme_FunctionAddress, "Axis_Style_With_Theme", Classes.FBoolProperty);
		SetTheme_IsValid = SetTheme_FunctionAddress != IntPtr.Zero && SetTheme_ChartTheme_IsValid && SetTheme_Axis_Style_With_Theme_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:SetTheme", SetTheme_IsValid);
		SetCustomColor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetCustomColor");
		SetCustomColor_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCustomColor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCustomColor_active_PropertyAddress, SetCustomColor_FunctionAddress, "active");
		SetCustomColor_active_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomColor_FunctionAddress, "active");
		SetCustomColor_active_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomColor_FunctionAddress, "active", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetCustomColor_custom_color_PropertyAddress, SetCustomColor_FunctionAddress, "custom_color");
		SetCustomColor_custom_color_Offset = NativeReflectionCached.GetPropertyOffset(SetCustomColor_FunctionAddress, "custom_color");
		SetCustomColor_custom_color_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCustomColor_FunctionAddress, "custom_color", Classes.FArrayProperty);
		SetCustomColor_IsValid = SetCustomColor_FunctionAddress != IntPtr.Zero && SetCustomColor_active_IsValid && SetCustomColor_custom_color_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:SetCustomColor", SetCustomColor_IsValid);
		SetAxis_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAxis");
		SetAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAxis_XAxis_PropertyAddress, SetAxis_FunctionAddress, "XAxis");
		SetAxis_XAxis_Offset = NativeReflectionCached.GetPropertyOffset(SetAxis_FunctionAddress, "XAxis");
		SetAxis_XAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAxis_FunctionAddress, "XAxis", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAxis_Axis_Data_PropertyAddress, SetAxis_FunctionAddress, "Axis_Data");
		SetAxis_Axis_Data_Offset = NativeReflectionCached.GetPropertyOffset(SetAxis_FunctionAddress, "Axis_Data");
		SetAxis_Axis_Data_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAxis_FunctionAddress, "Axis_Data", Classes.FArrayProperty);
		SetAxis_IsValid = SetAxis_FunctionAddress != IntPtr.Zero && SetAxis_XAxis_IsValid && SetAxis_Axis_Data_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:SetAxis", SetAxis_IsValid);
		SetAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAnim");
		SetAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAnim_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAnim_active_PropertyAddress, SetAnim_FunctionAddress, "active");
		SetAnim_active_Offset = NativeReflectionCached.GetPropertyOffset(SetAnim_FunctionAddress, "active");
		SetAnim_active_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAnim_FunctionAddress, "active", Classes.FBoolProperty);
		SetAnim_IsValid = SetAnim_FunctionAddress != IntPtr.Zero && SetAnim_active_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SimpleCharts.ChartBase:SetAnim", SetAnim_IsValid);
	}
}
