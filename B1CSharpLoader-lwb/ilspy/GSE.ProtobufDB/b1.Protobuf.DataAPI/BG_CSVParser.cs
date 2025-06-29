using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using b1.Protobuf.BG_ParserManager;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1.Protobuf.DataAPI;

public class BG_CSVParser
{
	protected enum OPERATION
	{
		CREATE_REPEATED_OBJECT,
		CREATE_SIMPLE_REPEATED_OBJECT,
		CREATE_DEEP_REPEATED_OBJECT,
		CREATE_BOTH_REPEATED_OBJECT,
		CREATE_OBJECT_WITH_DEEP_REPEATED_OBJECT,
		SET_SIMPLE_REPEATED_VALUE,
		SET_REPEATED_VALUE_IN_OBJECT,
		NUM_INFLUENCE_DELIMITER,
		CREATE_OBJECT,
		SET_VALUE,
		SET_REPEATED_VALUE,
		SET_DEEP_REPEATED_VALUE,
		SET_OBJECT_VALUE
	}

	private readonly string _noteKeyword = "Note-";

	private readonly string _numKeyword = ".num";

	private readonly string _IDKeyword = "ID";

	private readonly int _xlsmBaseLine = 2;

	private List<string> _propertyList = new List<string>();

	private List<string> _typeList = new List<string>();

	private MethodInfo _writeToMethod;

	private Dictionary<ushort, OPERATION> _indexToOperation = new Dictionary<ushort, OPERATION>();

	private List<int> _noteColumns = new List<int>();

	private List<int> _numColumns = new List<int>();

	private Dictionary<int, string> _numDict = new Dictionary<int, string>();

	private Dictionary<int, int> _idMap = new Dictionary<int, int>();

	private string _trackColIndex = "";

	private int _trackRowIndex;

	private string _trackValue = "";

	private string _trackProperty = "";

	private string _trackType;

	private bool _isCreatingNewDataFile;

	private string _className;

	private string _classItem;

	private int _baseTotalPropertiesNum;

	private bool _isLocalMode;

	private object MessageObject;

	private object MessageRepeatedListObj;

	private readonly Dictionary<string, int> _subPropertiesNumDict = new Dictionary<string, int>();

	private readonly Dictionary<string, int> _propertyNums = new Dictionary<string, int>();

	private readonly Dictionary<string, List<string>> _structLists = new Dictionary<string, List<string>>();

	private IBG_TableToolP4Helper _p4Helper = BG_TableToolP4HelperCreator.CreateP4HelperInstance();

	public bool ParseCSVFile(string filePath, bool bEnableOffice365Mode, bool bEnableValidationMode = false)
	{
		string[] array = filePath.Split('\\');
		string text = array[array.Length - 1].Split('.')[0];
		string[] array2 = text.Split('_');
		string[] array3 = array2[0].Split('-');
		string text2 = "";
		if (array3.Length > 1)
		{
			_className = array3[0];
			text2 = "-" + array3[1];
		}
		else
		{
			_className = array2[0];
		}
		if (array2.Length > 1)
		{
			_ = array2[1];
		}
		string text3 = (BG_ProtobufDataLoader.Get().IsRuntimeData(text) ? BG_ProtobufDataLoader.Get().GetRunTimeDataFolderFullPath() : BG_ProtobufDataLoader.Get().GetDataFolderFullPath());
		FileStream fileStream = null;
		object obj = null;
		int num = 0;
		bool flag = false;
		int result;
		string text4 = (int.TryParse(array2[array2.Length - 1], out result) ? array2[array2.Length - 1] : string.Empty);
		_classItem = _className + text4;
		string text5 = _classItem + text2;
		string filePath2 = text3 + text5 + ".data";
		string[] propertiesArray = new string[0];
		string text6 = "";
		if (!bEnableOffice365Mode)
		{
			text6 = filePath.Replace("CSV\\", string.Empty).Replace(".csv", ".xlsm");
		}
		else
		{
			string[] array4 = filePath.Split('\\');
			string[] array5 = array4[array4.Length - 1].Split('_');
			string text7 = array5[array5.Length - 1];
			text6 = (BG_ProtobufDataLoader.Get().GetLocalOneDriveTableFolder() + text7).Replace(".csv", ".xlsm");
		}
		BG_ParserStatusManager.Get().LocalProcessModesDict.TryGetValue(text6, out _isLocalMode);
		if (GetDatabaseType(_className) == null)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！数据库中不存在" + _className + "的类型，请确定build_proto.bat是否有运行, 或者GSE.ProtobugDB是否为最新****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！ ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "数据库中不存在" + _className + "的类型;";
			return flag;
		}
		try
		{
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================");
			BG_ParserStatusManager.Get().ProcessLogs.Add("开始解析：" + filePath);
			if (!_isLocalMode)
			{
				if (!CheckoutQuery(in filePath2, in filePath, in _classItem, bEnableOffice365Mode))
				{
					return false;
				}
			}
			else
			{
				_changeFileToReadOnly(in filePath2, false);
			}
			Encoding encoding = GetEncoding(filePath);
			string[] array6 = File.ReadAllLines(filePath, encoding);
			if (array6.Count() == 0)
			{
				throw new EmptyFileException();
			}
			MessageObject = Activator.CreateInstance(GetDatabaseType("TB" + _className));
			if (MessageObject == null)
			{
				throw new InvalidProtoMessageException("TB" + _className);
			}
			MessageRepeatedListObj = GetProtoMessageRepeatedList(in MessageObject);
			_writeToMethod = _getExtensionMethodByName(typeof(IMessage).Assembly, typeof(IMessage), "WriteTo");
			string[] array7 = array6;
			foreach (string input in array7)
			{
				_trackRowIndex = ++num + _xlsmBaseLine;
				string pattern = ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";
				propertiesArray = Regex.Split(input, pattern);
				switch (num)
				{
				case 1:
					_processPropertyName(ref propertiesArray, bEnableValidationMode);
					_rowValidationChecking(propertiesArray);
					break;
				case 2:
					_rowValidationChecking(propertiesArray);
					_processType(ref propertiesArray);
					break;
				default:
					_rowValidationChecking(propertiesArray);
					obj = Activator.CreateInstance(GetDatabaseType(_className));
					_processData(in propertiesArray, ref obj, bEnableValidationMode);
					_addToRepeatedList(ref MessageRepeatedListObj, in obj);
					break;
				}
			}
			ProhibitModifyVerification(MessageObject, _className, filePath2);
			using (fileStream = File.Create(filePath2))
			{
				_writeToProtobuf(ref MessageObject, ref fileStream);
			}
			flag = true;
		}
		catch (Exception ex) when (ex is NotSupportedException || ex.InnerException is FormatException || ex is FormatException)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！无法将第" + _trackRowIndex + "行第" + _trackColIndex + "列的值[" + _trackValue + "]转换为" + _trackType + "类型。请确认此处的值是否符合类型规范。****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 出现数据错误，解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "第" + _trackRowIndex + "行第" + _trackColIndex + "列的值出现数据错误";
		}
		catch (FileNotFoundException)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！未找到" + filePath + "！请确认该文件存在。 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！ ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "未找到" + filePath;
		}
		catch (IOException)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！" + filePath + "正由另一进程使用，请关闭此文件后再进行转表。 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = filePath + "正由另一进程使用";
		}
		catch (InconsistentTargetTypeException ex4)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！第" + _trackRowIndex + "行第" + _trackColIndex + "列定义值的目标类型为" + ex4.TargetType + "，与数据.py定义的" + ex4.SourceType + "不符合。这可能是 ：****\n");
			BG_ParserStatusManager.Get().ProcessLogs.Add("1. 策划在填写Excel表时有操作失误，改变了数据类型。");
			BG_ParserStatusManager.Get().ProcessLogs.Add("2. 数据库被修改，改变了数据类型。");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "第" + _trackRowIndex + "行第" + _trackColIndex + "列目标类型与定义不符合";
		}
		catch (UnknowTypeException ex5)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！第" + _trackRowIndex + "行第" + _trackColIndex.ToString() + "列出现未知数据类型[" + ex5.UnknowType + "]，这可能是：****\n");
			BG_ParserStatusManager.Get().ProcessLogs.Add("1. 程序员定义数据类型时出错.");
			BG_ParserStatusManager.Get().ProcessLogs.Add("2. 策划在填写Excel表时有操作失误，改变了数据类型。");
			BG_ParserStatusManager.Get().ProcessLogs.Add("3. 该行某列处有无效字符，导致系统尝试解析正常数据和无效字符列之间的类型。提示:csv文件中该行一共有" + propertiesArray.Count() + "列。");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "第" + _trackRowIndex + "行第" + _trackColIndex + "列出现未知数据类型";
		}
		catch (UnknowPropertyException)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！第3行出现未知属性[" + _trackProperty + "]（可通过搜索定位），这可能是 ****：\n");
			BG_ParserStatusManager.Get().ProcessLogs.Add("1. 程序员定义属性名字时引入无效字符出错.");
			BG_ParserStatusManager.Get().ProcessLogs.Add("2. 策划在填写Excel表时有操作失误，改变了属性的字符。");
			BG_ParserStatusManager.Get().ProcessLogs.Add("3. 该行某列处有无效字符，导致系统尝试解析正常数据和无效字符列之间的属性。提示:csv文件中该行一共有" + propertiesArray.Count() + "列。");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "第" + _trackRowIndex + "行第" + _trackColIndex + "列出现未知属性";
		}
		catch (IncorrectPropertyNumberException ex7)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！转表工具检测到" + ex7.PropertyOwner + "基础属性列数(一个嵌套结构或数组算一个属性)应为" + ex7.OwnerPropertyNum + "。但Excel表中该属性的列数为" + ex7.ActualPropertyNum + " ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 转表要求这两个数字相同，文件完整性校验失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = ex7.PropertyOwner + "基础属性列数(一个嵌套结构或数组算一个属性)应为" + ex7.OwnerPropertyNum;
		}
		catch (InvalidNumCommentException)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！第" + _trackRowIndex + "行第" + _trackColIndex + "列的.num数值[" + _trackValue + "]无法被解析为整形或者此数据为负数，此处的值不正确。 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "第" + _trackRowIndex + "行第" + _trackColIndex + "列的.num数值[" + _trackValue + "]无法被解析为整形或者此数据为负数";
		}
		catch (UnauthorizedAccessException ex9)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add(ex9.Message);
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 请确认该文件被checked out或者未被占用。 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "该文件被checked out或者被占用";
		}
		catch (InvalidRowException)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！第" + _trackRowIndex + "行没有有效ID数据，系统判定该行为无效数据。 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("**** 请检查此行及后续行中是否有无效数据（提示，可在CSV文件中查看） ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "第" + _trackRowIndex + "行没有有效ID数据，系统判定该行为无效数据";
		}
		catch (DuplicatePropertyException ex11)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！出现重复列" + ex11.DuplicatedProperty + "! ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "出现重复列" + ex11.DuplicatedProperty;
		}
		catch (EmptyFileException)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！当前CSV文件无数据！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "当前CSV文件无数据";
		}
		catch (DuplicatedIDException ex13)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！出现重复的ID！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！在第" + _trackRowIndex + "行出现重复ID值(" + ex13.DuplicatedID + ") ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "第" + _trackRowIndex + "行出现重复ID值(" + ex13.DuplicatedID + ")";
		}
		catch (InvalidProtoMessageException ex14)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 无法创建" + ex14.ClassName + "对象 ****:\n" + ex14);
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 请确认生成的.cs文件是否正确，解析文件失败 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "无法创建" + ex14.ClassName + "对象";
		}
		catch (ModifyRuleVerificationException ex15)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 未通过表格规则校验 ****:\n" + ex15);
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误原因：" + ex15.ErrorReason + " ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 请与shaowei确认修改是否合法 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "表格规则校验失败：" + ex15.ErrorReason;
		}
		catch (Exception ex16)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件出现异常 ****:\n" + ex16);
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 解析文件失败 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			flag = false;
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().FailureBriefDescription = "解析文件出现异常";
		}
		if (flag)
		{
			if (_isCreatingNewDataFile && !_isLocalMode)
			{
				flag = ProcessFileCheckout(in filePath2);
				_isCreatingNewDataFile = false;
			}
			else if (_isLocalMode)
			{
				_changeFileToReadOnly(in filePath2, false);
			}
			if (flag)
			{
				FileInfo fileInfo = new FileInfo(filePath2);
				BG_ParserStatusManager.Get().ProcessLogs.Add("\n操作时间：" + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString());
				BG_ParserStatusManager.Get().ProcessLogs.Add(_classItem + ".data文件大小：" + fileInfo.Length + "字节");
				BG_ParserStatusManager.Get().ProcessLogs.Add("\n解析成功！");
				BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_SUCCEEDED;
				BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
			}
		}
		return flag;
	}

	private Encoding GetEncoding(string filePath)
	{
		using StreamReader streamReader = new StreamReader(filePath, Encoding.Default, detectEncodingFromByteOrderMarks: true);
		if (streamReader.Peek() >= 0)
		{
			streamReader.Read();
		}
		return streamReader.CurrentEncoding;
	}

	private void _changeFileToReadOnly(in string filePath, in bool isToReadonly)
	{
		if (!File.Exists(filePath))
		{
			return;
		}
		FileAttributes attributes = File.GetAttributes(filePath);
		new FileInfo(filePath);
		if (!isToReadonly)
		{
			if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
			{
				attributes &= ~FileAttributes.ReadOnly;
				File.SetAttributes(filePath, attributes);
			}
		}
		else
		{
			attributes &= FileAttributes.ReadOnly;
			File.SetAttributes(filePath, attributes);
		}
	}

	private bool CheckoutQuery(in string dataFile, in string fileFullPath, in string classItem, bool bEnableOffice365Mode)
	{
		bool bFileConversionStatus = true;
		if (!bEnableOffice365Mode)
		{
			string targetFile = fileFullPath.Replace("\\CSV", string.Empty).Replace(".csv", ".xlsm");
			bFileConversionStatus &= ProcessFileCheckout(in targetFile);
		}
		if (bFileConversionStatus && File.Exists(dataFile))
		{
			bFileConversionStatus &= ProcessFileCheckout(in dataFile);
		}
		if (!bFileConversionStatus)
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("**** 转表失败！****");
			BG_ParserStatusManager.Get().ProcessStatusDict[classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
		}
		return bFileConversionStatus & _updateConversionLog(in classItem, in bFileConversionStatus);
	}

	private bool ProcessFileCheckout(in string targetFile)
	{
		bool result = false;
		if (!(_p4Helper.IsUseExternalP4Config() ? _p4Helper.IsP4Connecting() : UGSFunclibPerforceSourceControlModule.IsSourceControlEnabled()))
		{
			if (_p4Helper.IsUseExternalP4Config())
			{
				BG_ParserStatusManager.Get().ProcessLogs.Add(_p4Helper.GetLastOutput());
			}
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================");
			BG_ParserStatusManager.Get().ProcessLogs.Add("**** P4未能连接！请将Unreal连接至P4！****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================");
			BG_ParserStatusManager.Get().FailureBriefDescription = "P4未能连接";
		}
		else if (!(_p4Helper.IsUseExternalP4Config() ? _p4Helper.CheckOutFile(targetFile) : UGSFunclibPerforceSourceControlModule.CheckOutOrAddFile(targetFile)))
		{
			if (_p4Helper.IsUseExternalP4Config())
			{
				BG_ParserStatusManager.Get().ProcessLogs.Add(_p4Helper.GetLastOutput());
			}
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！无法Checkout文件" + targetFile + "! ****");
			BG_ParserStatusManager.Get().FailureBriefDescription = "无法Checkout文件";
			UGSFunclibPerforceSourceControlModule.QueryFileState(out var inState, targetFile);
			string checkedOutOther = inState.CheckedOutOther;
			if (checkedOutOther != "")
			{
				BG_ParserStatusManager.Get().ProcessLogs.Add("**** 该文件已被" + checkedOutOther + "迁出-_-请直接联系该用户以解锁文件~ ****");
				BG_ParserStatusManager.Get().FailureBriefDescription = "文件已被" + checkedOutOther + "迁出";
			}
			BG_ParserStatusManager.Get().ProcessStatusDict[_classItem] = FILE_PROCESS_STATUS.PROCESS_FAILED;
		}
		else
		{
			BG_ParserStatusManager.Get().ProcessLogs.Add("\nCheckout成功:" + targetFile);
			result = true;
		}
		return result;
	}

	private MethodInfo _getExtensionMethodByName(Assembly assembly, Type baseType, string targetMethodName)
	{
		foreach (MethodInfo item in from type in assembly.GetTypes()
			where type.IsSealed && !type.IsGenericType && !type.IsNested
			from method in type.GetMethods(BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic)
			where method.IsDefined(typeof(ExtensionAttribute), inherit: false)
			where method.GetParameters()[0].ParameterType == baseType
			select method)
		{
			if (item.Name == targetMethodName)
			{
				return item;
			}
		}
		return null;
	}

	private bool _updateConversionLog(in string classItem, in bool bFileConversionStatus)
	{
		bool flag = false;
		try
		{
			string path = BG_ProtobufDataLoader.Get().GetTableRootPath() + "\\" + BG_ParserStatusManager.Get().StatusLog;
			if (!File.Exists(path))
			{
				using (File.Create(path))
				{
				}
			}
			string[] array = File.ReadAllLines(path);
			bool flag2 = false;
			string text = classItem;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Contains(text))
				{
					array[i] = text + ":" + bFileConversionStatus;
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				List<string> list = array.ToList();
				list.Add(text + ":" + bFileConversionStatus);
				array = list.ToArray();
			}
			File.WriteAllLines(path, array);
			flag = true;
		}
		catch (Exception)
		{
			flag = false;
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================");
			BG_ParserStatusManager.Get().ProcessLogs.Add("\n**** 错误！无法同步转表日志文件: " + BG_ProtobufDataLoader.Get().GetTableRootPath() + "\\" + BG_ParserStatusManager.Get().StatusLog + " ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("**** 请确认该文件存在并且有权限被修改 ****");
			BG_ParserStatusManager.Get().ProcessLogs.Add("=======================================\n");
		}
		return flag;
	}

	private void _processData(in string[] dataArray, ref object obj, bool bEnableValidationMode)
	{
		ushort index = 0;
		object baseTempObj = null;
		string baseRepeatedProperty = "";
		string value = "";
		string text = "";
		string text2 = "";
		int result = -1;
		int num = -1;
		bool flag = false;
		string[] array = dataArray;
		for (int i = 0; i < array.Length; i++)
		{
			string value2 = array[i];
			IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("b.CSVParser.ShippingMode");
			if (consoleVariable != null && consoleVariable.GetInt() != 0 && BG_ProtobufDataLoader.Get().GetIgnoreFieldsMap().TryGetValue(_className, out var value3) && value3.Contains(_propertyList[index]))
			{
				index++;
				continue;
			}
			if (_isNotedColumn(index))
			{
				index++;
				continue;
			}
			if (_isNumColumn(index) && _numDict.TryGetValue(index, out value))
			{
				if (value2 == "")
				{
					result = 0;
				}
				else if (!int.TryParse(value2, out result) || result < 0)
				{
					throw new InvalidNumCommentException();
				}
				if (value.Split('.').Count() == 1 && index + 1 < dataArray.Count() && _propertyList[index + 1].Split('.').Count() > 1)
				{
					text = value;
					text2 = _propertyList[index + 1];
					num = result;
					result = -1;
				}
				index++;
				continue;
			}
			if (text != "" && _propertyList[index].Contains(text))
			{
				flag = true;
				if (_propertyList[index] == text2)
				{
					num--;
				}
				if (num < 0)
				{
					index++;
					continue;
				}
			}
			if (_propertyList[index] == value)
			{
				flag = true;
				if (--result < 0)
				{
					index++;
					continue;
				}
			}
			if (!flag)
			{
				text = "";
				value = "";
				result = -1;
				num = -1;
			}
			_setPropertyValue(in index, ref obj, ref baseTempObj, ref baseRepeatedProperty, _propertyList[index], _typeList[index], in value2, bEnableValidationMode);
			index++;
		}
		_checkRepeatedField(ref obj, ref baseTempObj, in baseRepeatedProperty);
		_setDataGuard(ref obj);
	}

	private void _setPropertyValue(in ushort index, ref object dataObj, ref object baseTempObj, ref string baseRepeatedProperty, in string propertyString, in string typeString, in string value, bool bEnableValidationMode)
	{
		_trackColIndex = _getColumnString(index);
		string[] array = propertyString.Split('.');
		PropertyInfo propertyInfo = dataObj.GetType().GetProperty(array[0]);
		if (propertyInfo == null)
		{
			_trackProperty = array[0];
			throw new UnknowPropertyException();
		}
		Type databaseType = GetDatabaseType(typeString);
		if (databaseType == null)
		{
			throw new UnknowTypeException(in typeString);
		}
		TypeConverter typeConverter = TypeDescriptor.GetConverter(propertyInfo.PropertyType);
		_trackProperty = array[array.Length - 1];
		object dataValue = null;
		switch (_indexToOperation[index])
		{
		case OPERATION.SET_VALUE:
			_checkRepeatedField(ref dataObj, ref baseTempObj, in baseRepeatedProperty);
			_checkDataVadility(in propertyInfo, in typeConverter, in value, out dataValue, databaseType, bEnableValidationMode);
			propertyInfo.SetValue(dataObj, dataValue);
			break;
		case OPERATION.SET_REPEATED_VALUE:
			propertyInfo = baseTempObj.GetType().GetProperty(_trackProperty);
			_checkDataVadility(in propertyInfo, TypeDescriptor.GetConverter(propertyInfo.PropertyType), in value, out dataValue, databaseType, bEnableValidationMode);
			propertyInfo.SetValue(baseTempObj, dataValue);
			break;
		case OPERATION.SET_SIMPLE_REPEATED_VALUE:
		{
			object repeatedObj = propertyInfo.GetValue(dataObj);
			Type type = _getRepeatedFieldItemType(in repeatedObj);
			_checkDataVadility(in propertyInfo, TypeDescriptor.GetConverter(type), in value, out dataValue, databaseType, bEnableValidationMode, type);
			_addToRepeatedList(ref repeatedObj, in dataValue);
			break;
		}
		case OPERATION.CREATE_SIMPLE_REPEATED_OBJECT:
		{
			_checkRepeatedField(ref dataObj, ref baseTempObj, in baseRepeatedProperty);
			baseRepeatedProperty = array[0];
			propertyInfo = dataObj.GetType().GetProperty(baseRepeatedProperty);
			object repeatedObj = propertyInfo.GetValue(dataObj);
			Type type = _getRepeatedFieldItemType(in repeatedObj);
			_checkDataVadility(in propertyInfo, TypeDescriptor.GetConverter(type), in value, out dataValue, databaseType, bEnableValidationMode, type);
			_addToRepeatedList(ref repeatedObj, in dataValue);
			break;
		}
		case OPERATION.CREATE_REPEATED_OBJECT:
			_checkRepeatedField(ref dataObj, ref baseTempObj, in baseRepeatedProperty);
			baseRepeatedProperty = array[0];
			baseTempObj = Activator.CreateInstance(_getRepeatedFieldItemType(in dataObj, in baseRepeatedProperty));
			propertyInfo = baseTempObj.GetType().GetProperty(_trackProperty);
			_checkDataVadility(in propertyInfo, TypeDescriptor.GetConverter(databaseType), in value, out dataValue, databaseType, bEnableValidationMode);
			propertyInfo.SetValue(baseTempObj, dataValue);
			break;
		case OPERATION.SET_DEEP_REPEATED_VALUE:
		{
			PropertyInfo property = baseTempObj.GetType().GetProperty(_trackProperty);
			object repeatedObj = property.GetValue(baseTempObj);
			Type type = _getRepeatedFieldItemType(in repeatedObj);
			_checkDataVadility(in property, TypeDescriptor.GetConverter(type), in value, out dataValue, databaseType, bEnableValidationMode, type);
			_addToRepeatedList(ref repeatedObj, in dataValue);
			break;
		}
		case OPERATION.CREATE_BOTH_REPEATED_OBJECT:
		{
			_checkRepeatedField(ref dataObj, ref baseTempObj, in baseRepeatedProperty);
			baseRepeatedProperty = array[0];
			baseTempObj = Activator.CreateInstance(_getRepeatedFieldItemType(in dataObj, in baseRepeatedProperty));
			PropertyInfo property = baseTempObj.GetType().GetProperty(_trackProperty);
			object repeatedObj = Activator.CreateInstance(property.PropertyType);
			Type type = _getRepeatedFieldItemType(in repeatedObj);
			_checkDataVadility(in property, TypeDescriptor.GetConverter(type), in value, out dataValue, databaseType, bEnableValidationMode, type);
			_addToRepeatedList(ref repeatedObj, in dataValue);
			break;
		}
		case OPERATION.CREATE_DEEP_REPEATED_OBJECT:
		{
			PropertyInfo property = baseTempObj.GetType().GetProperty(_trackProperty);
			object repeatedObj = property.GetValue(baseTempObj);
			Type type = _getRepeatedFieldItemType(in repeatedObj);
			_checkDataVadility(in property, TypeDescriptor.GetConverter(type), in value, out dataValue, databaseType, bEnableValidationMode, type);
			_addToRepeatedList(ref repeatedObj, in dataValue);
			break;
		}
		case OPERATION.CREATE_OBJECT:
		{
			_checkRepeatedField(ref dataObj, ref baseTempObj, in baseRepeatedProperty);
			propertyInfo.SetValue(dataObj, Activator.CreateInstance(propertyInfo.PropertyType));
			PropertyInfo property = propertyInfo.GetValue(dataObj).GetType().GetProperty(_trackProperty);
			_checkDataVadility(in property, TypeDescriptor.GetConverter(databaseType), in value, out dataValue, databaseType, bEnableValidationMode);
			property.SetValue(propertyInfo.GetValue(dataObj), dataValue);
			break;
		}
		case OPERATION.SET_OBJECT_VALUE:
		{
			PropertyInfo property = propertyInfo.GetValue(dataObj).GetType().GetProperty(_trackProperty);
			_checkDataVadility(in property, TypeDescriptor.GetConverter(databaseType), in value, out dataValue, databaseType, bEnableValidationMode);
			property.SetValue(propertyInfo.GetValue(dataObj), dataValue);
			break;
		}
		case OPERATION.CREATE_OBJECT_WITH_DEEP_REPEATED_OBJECT:
		{
			_checkRepeatedField(ref dataObj, ref baseTempObj, in baseRepeatedProperty);
			propertyInfo.SetValue(dataObj, Activator.CreateInstance(propertyInfo.PropertyType));
			PropertyInfo property = propertyInfo.GetValue(dataObj).GetType().GetProperty(_trackProperty);
			object repeatedObj = property.GetValue(propertyInfo.GetValue(dataObj));
			Type type = _getRepeatedFieldItemType(in repeatedObj);
			_checkDataVadility(in property, TypeDescriptor.GetConverter(type), in value, out dataValue, databaseType, bEnableValidationMode, type);
			_addToRepeatedList(ref repeatedObj, in dataValue);
			property.SetValue(propertyInfo.GetValue(dataObj), repeatedObj);
			break;
		}
		case OPERATION.SET_REPEATED_VALUE_IN_OBJECT:
		{
			PropertyInfo property = propertyInfo.GetValue(dataObj).GetType().GetProperty(_trackProperty);
			object repeatedObj = property.GetValue(propertyInfo.GetValue(dataObj));
			Type type = _getRepeatedFieldItemType(in repeatedObj);
			_checkDataVadility(in propertyInfo, TypeDescriptor.GetConverter(type), in value, out dataValue, databaseType, bEnableValidationMode, type);
			_addToRepeatedList(ref repeatedObj, in dataValue);
			break;
		}
		case OPERATION.NUM_INFLUENCE_DELIMITER:
			break;
		}
	}

	private Type _getRepeatedFieldItemType(in object containerObject, in string property)
	{
		return _getRepeatedFieldItemType(containerObject.GetType().GetProperty(property).GetValue(containerObject));
	}

	private void _setDataGuard(ref object dataObj)
	{
		PropertyInfo property = dataObj.GetType().GetProperty(BG_ProtobufDataLoader.Get().DataGuard);
		if (property != null)
		{
			property.SetValue(dataObj, BG_ProtobufDataLoader.Get().DataGuard);
		}
	}

	private Type _getRepeatedFieldItemType(in object repeatedObj)
	{
		object obj = repeatedObj.GetType().GetMethod("GetEnumerator").Invoke(repeatedObj, new object[0]);
		object obj2 = obj.GetType().GetMethod("GetType").Invoke(obj, new object[0]);
		object obj3 = obj2.GetType().GetMethod("GetGenericArguments").Invoke(obj2, new object[0]);
		object obj4 = obj3.GetType().GetMethod("GetValue", new Type[1] { typeof(int) }).Invoke(obj3, new object[1] { 0 });
		object value = obj4.GetType().GetProperty("FullName").GetValue(obj4);
		return GetDatabaseType(value.ToString(), isFullName: true);
	}

	private void _addToRepeatedList(ref object repeatedObj, in object valueObj)
	{
		if (repeatedObj != null && valueObj != null)
		{
			repeatedObj.GetType().GetMethod("Add", new Type[1] { valueObj.GetType() }).Invoke(repeatedObj, new object[1] { valueObj });
		}
	}

	private void _checkRepeatedField(ref object dataObj, ref object baseRepeatedObj, in string baseRepeatedProperty)
	{
		if (baseRepeatedObj != null)
		{
			object value = dataObj.GetType().GetProperty(baseRepeatedProperty).GetValue(dataObj);
			value.GetType().GetMethod("Add", new Type[1] { baseRepeatedObj.GetType() }).Invoke(value, new object[1] { baseRepeatedObj });
			baseRepeatedObj = null;
		}
	}

	private string _commaProcess(in string value)
	{
		int num = value.Length - value.Replace(",", "").Length;
		string text = value;
		if (num > 0)
		{
			char[] chArray = text.ToCharArray();
			text = string.Join("", chArray.Where((char item, int index) => index != 0 && index != chArray.Length - 1));
		}
		return text;
	}

	private string _lineBreakProcess(in string value)
	{
		return value.Replace("<br>", Environment.NewLine);
	}

	private void _checkDataVadility(in PropertyInfo propertyInfo, in TypeConverter typeConverter, in string value, out object dataValue, Type targetType, bool bEnableValidationMode, Type deepRepeatedType = null)
	{
		_trackValue = value;
		if (propertyInfo == null)
		{
			throw new UnknowPropertyException();
		}
		Type type = deepRepeatedType ?? propertyInfo.PropertyType;
		_trackType = type.ToString();
		if (!type.Equals(targetType))
		{
			throw new InconsistentTargetTypeException(propertyInfo.PropertyType.ToString(), targetType.ToString());
		}
		if (string.IsNullOrWhiteSpace(value))
		{
			if (type == typeof(string))
			{
				dataValue = typeConverter.ConvertFromString(null);
			}
			else
			{
				dataValue = Activator.CreateInstance(type);
			}
		}
		else if (type == typeof(string))
		{
			dataValue = typeConverter.ConvertFromString(_lineBreakProcess(_commaProcess(in value)));
			if (dataValue != null && FPackageName.ParseExportTextPath(dataValue.ToString(), out var _, out var objectPath) && BG_ProtobufDataLoader.Get().GetRedirectorMap().TryGetValue(objectPath, out var value2))
			{
				if (objectPath.EndsWith("_C"))
				{
					value2 += "_C";
				}
				dataValue = typeConverter.ConvertFromString(value2);
			}
		}
		else if (type.IsEnum)
		{
			int enumCnValue = EnumInfo.GetEnumCnValue(BG_ProtobufDataLoader.Get().ProjName, type.Name, value);
			if (bEnableValidationMode)
			{
				dataValue = typeConverter.ConvertFromString((enumCnValue == -1) ? "0" : enumCnValue.ToString());
			}
			else
			{
				dataValue = typeConverter.ConvertFromString((enumCnValue == -1) ? value : enumCnValue.ToString());
			}
		}
		else
		{
			dataValue = typeConverter.ConvertFromString(value);
		}
	}

	private string _getColumnString(int index)
	{
		string text = "";
		if (index < 26)
		{
			return Convert.ToChar(65 + index).ToString();
		}
		text = Convert.ToChar(65 + index / 26 - 1).ToString();
		return text + Convert.ToChar(65 + index % 26);
	}

	private void _processType(ref string[] typeArray)
	{
		ushort num = 0;
		string[] array = typeArray;
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('_');
			_trackColIndex = _getColumnString(num);
			if (_isNotedColumn(num) || _isNumColumn(num))
			{
				_typeList.Add("Excel Helper");
				num++;
				continue;
			}
			string unknowType = (_trackType = array2[array2.Length - 1]);
			if (unknowType.Contains("int"))
			{
				if (unknowType == "int" || unknowType == "uint")
				{
					throw new UnknowTypeException(in unknowType);
				}
				unknowType = unknowType.Replace("int", "Int");
				unknowType = unknowType.Replace("uInt", "UInt");
				unknowType = "System." + unknowType;
			}
			else if (unknowType == "float")
			{
				unknowType = "System.Single";
			}
			else if (unknowType == "string")
			{
				unknowType = "System.String";
			}
			else if (!(GetDatabaseType(unknowType) != null))
			{
				throw new UnknowTypeException(in unknowType);
			}
			_typeList.Add(unknowType);
			num++;
		}
	}

	private void _processPropertyName(ref string[] propertiesArray, bool bEnableValidationMode)
	{
		ushort index = 0;
		List<string> lastFields = new List<string>();
		List<string> list = new List<string>();
		object baseObj = Activator.CreateInstance(GetDatabaseType(_className));
		_baseTotalPropertiesNum = baseObj.GetType().GetProperties().Count() - 1;
		if (baseObj.GetType().GetProperty(BG_ProtobufDataLoader.Get().DataGuard) != null)
		{
			_baseTotalPropertiesNum--;
		}
		string[] array = propertiesArray;
		for (int i = 0; i < array.Length; i++)
		{
			string duplicatedProperty = array[i];
			if (duplicatedProperty.Contains(_noteKeyword))
			{
				_noteColumns.Add(index);
				_propertyList.Add(duplicatedProperty);
				index++;
				continue;
			}
			if (duplicatedProperty.Contains(_numKeyword))
			{
				string[] array2 = duplicatedProperty.Split('.');
				_ = array2[array2.Length - 1];
				for (int j = 0; j < array2.Count(); j++)
				{
					array2[j] = array2[j].Split('_')[0];
				}
				string targetField = string.Join(".", array2.Where((string val) => val != "num"));
				_numColumns.Add(index);
				_numDict[index] = targetField;
				_propertyList.Add(duplicatedProperty);
				_populateSubPropertiesRecord(in targetField, ref baseObj);
				index++;
				continue;
			}
			if (duplicatedProperty.Contains('.'))
			{
				string targetField2 = duplicatedProperty.Split('.')[0];
				_populateSubPropertiesRecord(in targetField2, ref baseObj);
			}
			if (!list.Contains(duplicatedProperty))
			{
				list.Add(duplicatedProperty);
				string[] array3 = duplicatedProperty.Split('.');
				string text = "";
				_trackColIndex = _getColumnString(index);
				if (duplicatedProperty == "" || duplicatedProperty.Length < 2)
				{
					throw new UnknowPropertyException();
				}
				string pattern = "__(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)";
				List<string> currentFields = new List<string>();
				bool isRepeatedObject = false;
				string[] array4 = array3;
				for (int num = 0; num < array4.Length; num++)
				{
					string[] array5 = Regex.Split(array4[num], pattern);
					string text2 = _capitalizeString(array5[0]);
					currentFields.Add((array5.Count() > 1) ? (text2 + "_" + array5[array5.Count() - 1]) : text2);
					isRepeatedObject |= array5.Count() > 1;
					text = ((text == "") ? text2 : (text + "." + text2));
				}
				_prepareIntegrityCheck(ref currentFields);
				_populateIndexOperations(ref currentFields, ref lastFields, in index, in isRepeatedObject);
				_propertyList.Add(text);
				lastFields.Clear();
				lastFields.AddRange(currentFields);
				index++;
				continue;
			}
			throw new DuplicatePropertyException(in duplicatedProperty);
		}
		if (bEnableValidationMode)
		{
			_executeIntegrityCheck();
		}
	}

	private void _populateSubPropertiesRecord(in string targetField, ref object baseObj)
	{
		if (_subPropertiesNumDict.ContainsKey(targetField))
		{
			return;
		}
		string text = targetField.Split('.')[0];
		PropertyInfo property = baseObj.GetType().GetProperty(text);
		if (property != null)
		{
			Type type = ((!typeof(IEnumerable).IsAssignableFrom(property.PropertyType)) ? property.PropertyType : _getRepeatedFieldItemType(property.GetValue(baseObj)));
			if (type.Namespace != "System")
			{
				object obj = Activator.CreateInstance(type);
				_subPropertiesNumDict[text] = obj.GetType().GetProperties().Count() - 1;
			}
		}
	}

	private void _populateIndexOperations(ref List<string> currentFields, ref List<string> lastFields, in ushort index, in bool isRepeatedObject)
	{
		switch (currentFields.Count)
		{
		case 1:
			if (isRepeatedObject)
			{
				if (lastFields.Count == 0)
				{
					_indexToOperation.Add(index, OPERATION.CREATE_SIMPLE_REPEATED_OBJECT);
				}
				else if (currentFields[0].Split('_')[0] == lastFields[0].Split('_')[0])
				{
					_indexToOperation.Add(index, OPERATION.SET_SIMPLE_REPEATED_VALUE);
				}
				else
				{
					_indexToOperation.Add(index, OPERATION.CREATE_SIMPLE_REPEATED_OBJECT);
				}
			}
			else
			{
				_indexToOperation.Add(index, OPERATION.SET_VALUE);
			}
			break;
		case 2:
			if (isRepeatedObject)
			{
				if (currentFields[0] == lastFields[0])
				{
					if (currentFields[1].Split('_').Count() > 1)
					{
						if (currentFields[0].Split('_').Count() <= 1)
						{
							_indexToOperation.Add(index, OPERATION.SET_REPEATED_VALUE_IN_OBJECT);
						}
						else if (currentFields[1].Split('_')[0] == lastFields[1].Split('_')[0])
						{
							_indexToOperation.Add(index, OPERATION.SET_DEEP_REPEATED_VALUE);
						}
						else
						{
							_indexToOperation.Add(index, OPERATION.CREATE_DEEP_REPEATED_OBJECT);
						}
					}
					else
					{
						_indexToOperation.Add(index, OPERATION.SET_REPEATED_VALUE);
					}
				}
				else if (currentFields[0].Split('_').Count() > 1 && currentFields[1].Split('_').Count() > 1)
				{
					_indexToOperation.Add(index, OPERATION.CREATE_BOTH_REPEATED_OBJECT);
				}
				else if (currentFields[0].Split('_').Count() == 1 && currentFields[1].Split('_').Count() > 1)
				{
					if (lastFields.Count() <= 1 || currentFields[1].Split('_')[0] != lastFields[1].Split('_')[0])
					{
						_indexToOperation.Add(index, OPERATION.CREATE_OBJECT_WITH_DEEP_REPEATED_OBJECT);
					}
					else
					{
						_indexToOperation.Add(index, OPERATION.SET_REPEATED_VALUE_IN_OBJECT);
					}
				}
				else
				{
					_indexToOperation.Add(index, OPERATION.CREATE_REPEATED_OBJECT);
				}
			}
			else if (currentFields[0] != lastFields[0])
			{
				_indexToOperation.Add(index, OPERATION.CREATE_OBJECT);
			}
			else
			{
				_indexToOperation.Add(index, OPERATION.SET_OBJECT_VALUE);
			}
			break;
		}
	}

	private void _prepareIntegrityCheck(ref List<string> currentFields)
	{
		string key = ((currentFields.Count() > 1) ? currentFields[0] : _className);
		if (currentFields[0].Contains('_') || (currentFields.Count() > 1 && !currentFields[0].Contains('_')))
		{
			string item = currentFields[0].Split('_')[0];
			if (!_structLists.ContainsKey(_className))
			{
				_structLists[_className] = new List<string> { item };
			}
			else if (!_structLists[_className].Contains(item))
			{
				_structLists[_className].Add(item);
			}
		}
		if (currentFields.Count() > 1 && currentFields[1].Split('_').Count() > 1)
		{
			string item = currentFields[1].Split('_')[0];
			if (!_structLists.ContainsKey(key))
			{
				_structLists[key] = new List<string> { item };
			}
			else if (!_structLists[key].Contains(item))
			{
				_structLists[key].Add(item);
			}
		}
		else if (currentFields.Count != 1 || !currentFields[0].Contains('_'))
		{
			if (!_propertyNums.ContainsKey(key))
			{
				_propertyNums[key] = 1;
			}
			else
			{
				_propertyNums[key]++;
			}
		}
	}

	private void _executeIntegrityCheck()
	{
		foreach (KeyValuePair<string, int> propertyNum in _propertyNums)
		{
			string propertyOwner = propertyNum.Key;
			int num = (_structLists.ContainsKey(propertyOwner) ? _structLists[propertyOwner].Count() : 0);
			int actualPropertyNum = propertyNum.Value + num;
			if (propertyOwner == _className)
			{
				if (actualPropertyNum != _baseTotalPropertiesNum)
				{
					throw new IncorrectPropertyNumberException(in propertyOwner, in _baseTotalPropertiesNum, in actualPropertyNum);
				}
				continue;
			}
			string key = propertyOwner.Split('_')[0];
			if (actualPropertyNum != _subPropertiesNumDict[key])
			{
				throw new IncorrectPropertyNumberException(in propertyOwner, _subPropertiesNumDict[propertyOwner.Split('_')[0]], in actualPropertyNum);
			}
		}
	}

	private string _capitalizeString(string str)
	{
		return str[0].ToString().ToUpper() + str.Substring(1);
	}

	private bool _isNotedColumn(int inColumnIndex)
	{
		return _noteColumns.FindAll((int val) => val == inColumnIndex).Count > 0;
	}

	private bool _isNumColumn(int inColumnIndex)
	{
		return _numColumns.FindAll((int val) => val == inColumnIndex).Count > 0;
	}

	private void _rowValidationChecking(string[] inRow)
	{
		int num = _propertyList.FindIndex((string val) => val.Equals(_IDKeyword, StringComparison.OrdinalIgnoreCase));
		int duplicatedID = -1;
		if (inRow.Where((string val) => val.ToString() != "").Count() < 2 && (num == -1 || !int.TryParse(inRow[num], out duplicatedID)))
		{
			throw new InvalidRowException();
		}
		if (num != -1 && int.TryParse(inRow[num], out duplicatedID))
		{
			if (_idMap.TryGetValue(duplicatedID, out var _))
			{
				throw new DuplicatedIDException(in duplicatedID);
			}
			_idMap[duplicatedID] = 1;
		}
	}

	private void _writeToProtobuf(ref object obj, ref FileStream fs)
	{
		if (_writeToMethod != null)
		{
			_writeToMethod.Invoke(obj, new object[2] { obj, fs });
		}
	}

	private Type GetDatabaseType(string typeString, bool isFullName = false)
	{
		return BG_ProtobufDataLoader.Get().GetDatabaseType(typeString, isFullName);
	}

	private object GetProtoMessageRepeatedList(in object obj)
	{
		return obj.GetType().GetProperty("List").GetValue(obj);
	}

	private void ProhibitModifyVerification(object NewTableDataObj, string TableName, string OldDataPath)
	{
		if (File.Exists(FPaths.Combine(FPaths.ProjectDir, "GSDataTable", "ZTable_RuleVerification", "TableVerificationRule.json")))
		{
			TableRuleValidator tableRuleValidator = new TableRuleValidator();
			if (!tableRuleValidator.ExecValidation(TableName, null, (IMessage)NewTableDataObj, null, GetDatabaseType("TB" + _className), out var ErrorReason))
			{
				ErrorReason = "与发布版本对比: " + ErrorReason;
				BGW_LogUtil.LogError("[BG_CSVParser] ProhibitModifyVerification " + ErrorReason);
				throw new ModifyRuleVerificationException(in ErrorReason);
			}
			if (!tableRuleValidator.ExecValidation(TableName, OldDataPath, (IMessage)NewTableDataObj, null, GetDatabaseType("TB" + _className), out var ErrorReason2))
			{
				ErrorReason2 = "与本地版本对比: " + ErrorReason2;
				BGW_LogUtil.LogError("[BG_CSVParser] ProhibitModifyVerification " + ErrorReason2);
				throw new ModifyRuleVerificationException(in ErrorReason2);
			}
		}
	}
}
