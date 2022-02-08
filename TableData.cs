using System;
using System.IO;
using System.Data;

namespace assignment
{
    class tabledata
    {
        class DataTableProgram
        {
            public static DataTable CSVtoDataTable(string strFilePath)
            {
                DataTable dt = new DataTable();
                using (StreamReader SR = new StreamReader(strFilePath))
                {
                    string[] headers = SR.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dt.Columns.Add(header);
                    }
                    while (!SR.EndOfStream)
                    {
                        string[] rows = SR.ReadLine().Split(',');
                        DataRow dr = dt.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dr[i] = rows[i];
                        }
                        dt.Rows.Add(dr);
                    }

                }


                return dt;
            }
        }
    }
}
