using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyzeFinishFolder
{
	public static class Technical
	{
		public static bool IsTemp = false;
		public static bool Bool_FileName;
		public static void CheckTempFile(string File_Name_WithExt)
		{
			char CheckSmb;
			if (File_Name_WithExt.Length > 6) //Короткие файлы типа ВК.rvt
			{
				for (int i4 = File_Name_WithExt.LastIndexOf(".") - 3; i4 < File_Name_WithExt.LastIndexOf("."); i4++)
				{
					CheckSmb = File_Name_WithExt[i4];
					if (char.IsDigit(CheckSmb) == false)
					{
						IsTemp = false;
						break;
					}
					else IsTemp = true;
				}
			}
			else IsTemp = false;
		}

		public static void CheckFileName(string File_Name)
		{
			int FN_Count = File_Name.Split('-').Length;
			if (FN_Count < 2) Bool_FileName = false;

			else
			{
				bool FN_Square = false;
				bool FN_Parcel = true;

				//For [0] Square num
				string FN_SquareStr = File_Name.Split('-')[0];
				char FN_1_1 = FN_SquareStr[0];
				bool FN_Square_1 = false;
				if (char.IsLetter(FN_1_1) == true) FN_Square_1 = true;
				if (FN_SquareStr == "EKB") FN_Square_1 = true;

				bool FN_Square_2 = true;
				if (FN_SquareStr != "EKB")
                {
					foreach (char FN_1_2 in FN_SquareStr.Skip(1))
					{
						if (!char.IsDigit(FN_1_2))
						{
							FN_Square_2 = false;
							break;
						}
					}
				}

				if (FN_Square_1 == true && FN_Square_2 == true) FN_Square = true;
				//For [1] Parcel
				string FN_ParcelStr = File_Name.Split('-')[1];
				foreach (char FN_2 in FN_ParcelStr)
				{
					if (!char.IsDigit(FN_2))
					{
						FN_Parcel = false;
						break;
					}
				}
				if (FN_Square == true && FN_Parcel == true && !File_Name.Contains(' ')) Bool_FileName = true;
				else Bool_FileName = false;

			}
		}
	}
}


