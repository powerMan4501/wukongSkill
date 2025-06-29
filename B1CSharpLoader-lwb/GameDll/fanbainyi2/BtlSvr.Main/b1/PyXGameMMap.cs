using System.IO.MemoryMappedFiles;
using System.Text;

namespace b1;

public class PyXGameMMap
{
	private const int MMAP_SIZE = 10485760;

	private const string GAME_TO_PY_MAP = "GameToPyMap";

	private const string PY_TO_GAME_MAP = "PyToGameMap";

	private MemoryMappedFile GameToPyMMapFile;

	private MemoryMappedFile PyToGameMMapFile;

	private MemoryMappedViewAccessor GameToPyAccessor;

	private MemoryMappedViewAccessor PyToGameAccessor;

	public PyXGameMMap()
	{
		GameToPyMMapFile = MemoryMappedFile.CreateOrOpen("GameToPyMap", 10485760L);
		PyToGameMMapFile = MemoryMappedFile.CreateOrOpen("PyToGameMap", 10485760L);
		GameToPyAccessor = GameToPyMMapFile.CreateViewAccessor();
		PyToGameAccessor = PyToGameMMapFile.CreateViewAccessor();
	}

	private void WriteStrTo(string str, MemoryMappedViewAccessor target_accessor)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(str);
		target_accessor.WriteArray(4L, bytes, 0, bytes.Length);
		target_accessor.Write(0L, bytes.Length);
	}

	private string RecvStrFromMM(MemoryMappedViewAccessor target_accessor)
	{
		int num = target_accessor.ReadInt32(0L);
		if (num > 0)
		{
			byte[] array = new byte[num];
			target_accessor.ReadArray(4L, array, 0, num);
			string result = Encoding.UTF8.GetString(array);
			target_accessor.Write(0L, 0);
			return result;
		}
		return null;
	}

	private bool IsWithMsg(MemoryMappedViewAccessor target_accessor)
	{
		return target_accessor.ReadInt32(0L) > 0;
	}

	public bool SendMsgStrToPy(string str)
	{
		if (IsWithMsg(GameToPyAccessor))
		{
			return false;
		}
		WriteStrTo(str, GameToPyAccessor);
		return true;
	}

	public string RecvMsgStrFromPy()
	{
		return RecvStrFromMM(PyToGameAccessor);
	}

	public void Close()
	{
		GameToPyMMapFile.Dispose();
		PyToGameMMapFile.Dispose();
	}
}
