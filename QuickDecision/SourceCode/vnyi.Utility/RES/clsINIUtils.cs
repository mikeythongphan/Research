using System;
using System.IO;

namespace vnyi.Utility.RES
{
	public class clsINIUtils
	{
		public static string ReadParamFileINI(string fileName,string ParamName)
		{
			StreamReader sr = new StreamReader(fileName);
            string res = ReadParamFileINI(sr, ParamName);
			if(sr != null) sr.Close();
			return res;
		}

        public static string ReadParamFileINI(StreamReader sr, string ParamName)
		{
			if(sr == null) return null;
			string[] res = null;

			string line	= sr.ReadLine();
			while(line != null)
			{
				res = GetParam(line);
				if(res[0].Trim().ToUpper() == ParamName.ToUpper() && res[1] != null)
				{
					return res[1].Trim();
				}
				line = sr.ReadLine();
			}
			return null;
		}

		private static string[] GetParam(string line)
		{
			return line.Split('=');
		}

		public static string GetCheatPass()
		{
			try
			{
				StreamReader fileINI = new StreamReader("TTCT.INI");
				string sCheatPass = ReadParamFileINI(fileINI,"KH");
				if(sCheatPass == null) sCheatPass = "vnyi";
				int num		= Int32.Parse(ReadParamFileINI(fileINI,"NUM"));
				int numnum	= Int32.Parse(ReadParamFileINI(fileINI,"NUMNUM"));
				if(num == 0) return null;
				for(int i = 0;i<num;i++) sCheatPass = "vnyi" + sCheatPass;
				for(int i = 0;i<numnum;i++) sCheatPass = sCheatPass + "vnyi";
				return sCheatPass;
			}
			catch
			{
				return string.Empty;
			}
		}
	}
}
