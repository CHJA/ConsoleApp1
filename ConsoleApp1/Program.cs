using System;
using System.Collections.Generic;

using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        public static IDictionary<string, object> Dict = new Dictionary<string, object>()
        {
            {"yjxxbh","预警信息编号"},
                {"fwzh","发文字号"},
                {"yjjsdw","预警接受单位"},
                {"yjfbsj","预警发布时间"},
                {"fbrxm","发布人姓名"},
                {"fbdw","发布单位"},
                {"fbdwjgdm","发布单位机构代码"},
                {"zdrybh","重点人员编号"},
                {"zdrylbbj","重点人员类别标记"},
                {"zdryxl","重点人员细类"},
                {"zdryxm","重点人员姓名"},
                {"sfzh","身份证号"},
                {"dtxxlb","动态信息类别"},
                {"hdfssj","活动发生时间"},
                {"hdfsddqh","活动发生地点区划"},
                {"hdfsddxz","活动发生地点详址"},
                {"hdfsddssshcs","活动发生地点所属社会场所"},
                {"hdfsddssshcsdm","活动发生地点所属社会场所代码"},
                {"hdfsddssgajg","活动发生地点所属公安机关"},
                {"hdfsddssgajgjgdm","活动发生地点所属公安机关代码"},
                {"hdxgxx","活动相关信息"},
                {"ldxxbh","联动信息编号"},
                {"shapeminx","PGIS地图X轴坐标"},
                {"shapeminy","PGIS地图Y轴坐标"},
                {"rksj","入库时间"}
        };

        public static IDictionary<string,object> ContainerHT { get; set; }

        public static string BtnStatus;// { get; set; }
        public static int BtnStytle = 222;// { get; set; }

        public static DataTable DataTable { get; set; }

        static void Main(string[] args)
        {
            #region before 201710
            /*
            int ml = 0;
            int sp = 0;
            int len = 7000;
            int tlen = 2000;
            int step = 30;

            //ml = ((len + tlen) + sp + tlen - step) % (len + tlen);
            //sp = ml - tlen;

            // Timer timer = new Timer(100);

            ml = -2000;

            //while (true)
            //{
            //    ml = ((len + tlen) + sp + tlen - step) % (len + tlen);
            //    sp = ml - tlen;
            //    Console.WriteLine(ml + "<----->" + sp);
            //}

            //string str = "八十";
            //int bs = 0;
            //try
            //{
            //    bs = Convert.ToInt32(str);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}

            //Console.WriteLine(str + "<----->" + bs);

            //Console.WriteLine("DBNull.Value=" + DBNull.Value.ToString() + "<--->" + "len=" + DBNull.Value.ToString().Length);
            //Console.WriteLine("".Length);
            */
            #endregion

            #region before 20171024
            /*
            DateTime d = new DateTime(2017, 8, 31, 15, 45, 34);
            string date = d.ToString("Mdd");
            DateTime d1 = d - TimeSpan.FromDays(70);
            string date1 = d1.ToString("Mdd");

            DataSource ds = new DataSource();
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            dt = ds.CreateDataTable();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("========================1");
            dt.Columns[0].ColumnName = "date";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine(dt.Rows[i]["date"]);
            }
            Console.WriteLine("=======================2");
            dt1 = ds.CreateDataTable().Clone();

            string expr = "date<=" + date + "AND date>=" + date1;
            string order = "date ASC";
            DataRow[] foundRows = dt.Select(expr, order);

            foreach (var r in foundRows)
            {
                dt1.ImportRow(r);
            }
            Console.WriteLine("dt1 的行数=" + dt1.Rows.Count);
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt1.Rows[i][j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=======================3");

            Console.WriteLine(date);
            Console.WriteLine(date1);
            */
            #endregion

            #region 20171027
            /*
            DataSet ds = new DataSet("ds");
            DataTable dt = new DataTable
            {
                TableName = "dt",

            };
            dt.Columns.Add("c1", typeof(string));
            dt.Rows.Add("this is 1");
            dt.Rows.Add("this is 2");
            dt.Rows.Add("this is 3");
            dt.Rows.Add("this is 4");
            dt.Rows.Add("this is 5");

            if (!ds.Tables.Contains("dt"))
            {
                ds.Tables.Add(dt);
                dt.TableName = "dt1";
            }
            else
            {
                Console.WriteLine("!!!");
            }

            dt.TableName = "dt2";
            dt.Rows[0][0] = "what?";
            dt.TableName = "dt";

            DataTable dt1 = new DataTable
            {
                TableName = "dt1",

            };
            dt1.Columns.Add("c1", typeof(string));
            dt1.Rows.Add("this is 11");
            dt1.Rows.Add("this is 12");
            dt1.Rows.Add("this is 13");
            dt1.Rows.Add("this is 14");
            dt1.Rows.Add("this is 15");

            ds.Tables.Add(dt1);

            if (!ds.Tables.Contains("dt1"))
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("has");
            }



            DataTable dt3 = dt1.Clone();

            DataTable dt2 = new DataTable
            {
                TableName = "dt2",

            };
            dt2.Columns.Add("c1", typeof(string));
            dt2.Columns.Add("c2", typeof(string));
            dt2.Rows.Add("this is 21");
            dt2.Rows.Add("this is 22");
            dt2.Rows.Add("this is 23");
            dt2.Rows.Add("this is 24");
            dt2.Rows.Add("this is 25");
            dt3 = dt2.Clone();
            dt3.Reset();
            dt2.Reset();
            dt2 = dt3.Clone();
            dt2.Columns.Add("c1", typeof(string));
            dt2.Columns.Add("c2", typeof(string));

            dt2.Rows.Add("this is 21");
            dt2.Rows.Add("this is 22");
            dt2.Rows.Add("this is 23");
            dt2.Rows.Add("this is 24");
            dt2.Rows.Add("this is 25");

            Console.WriteLine(dt3.TableName);
            Console.WriteLine(dt2.TableName);
            Console.WriteLine(dt2?.Rows[0][0]?.ToString() + "sssssssss");

            Console.WriteLine(ds.Tables.Count);
            Console.WriteLine(ds.Tables[0].TableName.ToString());
            Console.WriteLine(ds.Tables[0].Rows[0][0]);
            Console.WriteLine(ds.Tables[0].Rows[1][0]);
            Console.WriteLine(ds.Tables[0].Rows[2][0]);

            DataSet ds1 = new DataSet();
            Console.WriteLine(ds1.Tables.Count);
            */
            #endregion

            #region 20171101
            //DataSource data = new DataSource();
            //DataTable dataTable = data.CreateDataTable();

            //var TB = from tb in dataTable.AsEnumerable()
            //         let dc = tb.Field<int>(0)
            //         let dp1 = Convert.ToInt32(DateTime.Now.ToString("Mdd"))
            //         let dp2 = Convert.ToInt32(DateTime.Now.AddDays(-30).ToString("Mdd"))
            //         where dc >= dp1 && dc <= dp2
            //         select tb;

            //if (TB == null)
            //{
            //    Console.WriteLine("TB is NullReference");
            //    return;
            //}

            //if (TB.Count() == 0)
            //{
            //    Console.WriteLine(TB.Count());
            //    Console.ReadKey();
            //}

            //DataTable dt = TB.CopyToDataTable();

            //List<string> list = new List<string>();

            //foreach (var item in dt.AsEnumerable())
            //{
            //    list.Add(item[0].ToString());

            //    Console.WriteLine(item[0].ToString() + "\t" + item[1].ToString() + "\t" + item[2].ToString()
            //        + "\t" + item[3].ToString() + "\t" + item[4].ToString());
            //}
            #endregion

            #region 20171102
            /*
            string s = JsonConvert.SerializeObject(Dict);

            Console.WriteLine(s);

            ContainerHT = new Dictionary<string,object>();   
            ContainerHT = JsonConvert.DeserializeObject<Dictionary<string,object>>(s);

            Console.WriteLine(containerHT.Count);

            foreach (var item in containerHT)
            {
                Console.WriteLine("{0},{1}",item.Key,item.Value);
            }
            */
            #endregion

            #region 20171104
            /*
            string[] sArr = { "0", "0", "0" };
            BtnStatus = string.Join(",",sArr);
            Console.WriteLine("BtnStatus:{0}", BtnStatus);
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.WriteLine("stusArr[{0}]:{1}", i, sArr[i]);
            }

            sArr[0] = "1";
            sArr[1] = "1";
            sArr[2] = "0";
            Console.WriteLine("BtnStatus:{0}", BtnStatus);
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.WriteLine("stusArr[{0}]:{1}", i, sArr[i]);
            }

            BtnStatus = string.Join(",", sArr);
            sArr = BtnStatus.Split(',');
            Console.WriteLine("BtnStatus:{0}", BtnStatus);
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.WriteLine("stusArr[{0}]:{1}", i, sArr[i]);
            }

            int a = 0, b = 0, c = 0;
            a = BtnStytle / 100;
            b = (BtnStytle - a * 100) / 10;
            c = BtnStytle - a * 100 - b * 10;

            Console.WriteLine("a:{0},b:{1},c:{2}",a,b,c);

            if (true)
            {

            }
            */
            #endregion

            #region 20171206
            //DataTable = new DataTable();

            //foreach (var item in DataTable.AsEnumerable())
            //{
            //    DataColumn column = new DataColumn("", typeof(string));

            //}


            //int x = 20;
            //int y = 235;

            //decimal z = Convert.ToDecimal(y / x);
            //Console.WriteLine(z);
            #endregion

            #region 20171207
            //unsafe
            //{
            //    int var = 20;
            //    int* p = &var;

            //    Console.WriteLine($"Data is: {var}");
            //    Console.WriteLine("Data is: {0} ", p->ToString());
            //    Console.WriteLine($"Address is {(int)p}");

            //    int[] list = { 10, 100, 200 };
            //    fixed (int* ptr = list)

            //        /* 显示指针中数组地址 */
            //        for (int i = 0; i < 3; i++)
            //        {
            //            Console.WriteLine("Address of list[{0}]={1}", i, (int)(ptr + i));
            //            Console.WriteLine("Value of list[{0}]={1}", i, *(ptr + i));
            //        }
            //}
            #endregion

            #region MyRegion20171207
            // 
            #endregion

            #region 2018年1月3日
            // 解决月度数据没有年份导致排序出现空集的问题
            /*
            var year = DateTime.Now.Year.ToString();
            Console.WriteLine(year);

            int[,] arr = new int[,] 
            {
                { 101 , 1700 , 1000  , 1000  , 1000  },
                { 102 , 1000 , 1200  , 1000  , 2850  },
                { 102 , 1000 , 1200  , 1000  , 2850  }
            };
            int rank = arr.Rank;

            Console.WriteLine("维数：" + rank);

            DataSource data = new DataSource();
            DataTable table = data.CreateDataTable();

            //for (int i = 0; i < table.Rows.Count; i++)
            //{
            //    for (int j = 0; j < table.Columns.Count; j++)
            //    {
            //        Console.Write(table.Rows[i][j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            var currDate = Convert.ToInt32(DateTime.Now.ToString("Mdd"));

            int Year = 0;
            var currYear = DateTime.Now.Year;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                var x = Convert.ToInt32(table.Rows[i][0]);
                if (currDate >= x)
                {
                    Year = currYear;
                }
                else
                {
                    Year = currYear - 1;
                }

                if (x.ToString().Length == 3)
                {
                    table.Rows[i][0] = Convert.ToInt32(Year.ToString() + "0" + x.ToString());
                }
                else if (x.ToString().Length == 4)
                {
                    table.Rows[i][0] = Convert.ToInt32(Year.ToString() + x.ToString());
                }
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                Console.WriteLine(table.Rows[i][0]);
            }
            */
            #endregion

            #region 2018年1月14日
            //

            #endregion

            Console.ReadLine();

        }
    }
}
