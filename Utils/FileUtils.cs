using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SyncSpirit.Utils
{
    class FileUtils
    {
        //const will cause error.
        public static readonly string[] FILE_UNITS = { "B", "KB", "MB", "GB", "TB" };
        public const int NUM_BASE = 1024;

        public static string GetSizeUnit(string size)
        {
            long sizeNum = 0;
            try
            {
                sizeNum = long.Parse(size);
            }
            catch (Exception e)
            {
                e.ToString();
            }

            int index = 0;
            while (sizeNum / NUM_BASE >= 1)
            {
                index++;
            }
            if (index >= FILE_UNITS.Length)
                return "UNK";
            else
                return FILE_UNITS[index];

        }

        public static string GetSizeWithUnit(string size)
        {
            string sizeWithUnit = "";
            string unit = "";

            float sizeNum = 0;
            try
            {
                sizeNum = float.Parse(size);
            }
            catch (Exception e)
            {
                e.ToString();
            }

            int index = 0;
            while (sizeNum > NUM_BASE)
            {
                if (index >= FILE_UNITS.Length)
                {
                    index = FILE_UNITS.Length - 1;
                    sizeNum *= NUM_BASE;
                    break;
                }
                else
                {
                    sizeNum = sizeNum / NUM_BASE;
                    index++;
                }
            }

            unit = FILE_UNITS[index];
            sizeWithUnit = sizeNum.ToString("F2") + " " + unit;
            return sizeWithUnit;
        }
    }
}
