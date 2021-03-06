﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class 详细信息列表
    {

        private DataTable m_dataTable = new DataTable();
        public DataTable InputDataTable { get; set; }

        void InitializeSampleData()
        {
            DataTable dt = new DataTable();

            for (int i = 0; i < 25; i++)
            {
                dt.Columns.Add("c" + i, typeof(string));
            }

            dt.Rows.Add("43020017082309464399", "株公情报常字[预警指令](2017)第9464403号", "430203000000", "20170823195251", "株洲市公安局", "株洲市公安局", "430203000000", "650103199507171818", null, "涉疆关注人员", "别热叶克·马德", "650103199507171818", "101007", "20170823163846", "430206", "芦淞区迎新街2村B栋10号", "株洲市芦凇区梦颖时代网络服务有限公司", "43020310000069", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:030\",\"下网时间\":\"20170823191451\"}", "430200231012017080009245147", "113.17958", "27.79783", "20170823195251");

            dt.Rows.Add("43020017082309464403", "株公情报常字[预警指令](2017)第9464407号", "430204000000", "20170823202253", "株洲市公安局", "株洲市公安局", "430204000000", "653221198908141915", null, "涉疆关注人员", "合力力·艾合麦提托合提", "653221198908141915", "101007", "20170823175723", "430204", "石峰区响石花园6栋201号", "株洲市石峰区金满地茶餐网吧", "43020410000017", "株洲市石峰分局", "430204000000", "{\"上网座位\":\"座位号:039\",\"下网时间\":\"20170823193651\"}", "430200231012017080009245151", null, null, "20170823202253");

            dt.Rows.Add("43020017082309464409", "株公情报常字[预警指令](2017)第9464413号", "430203430000", "20170823205254", "株洲市公安局", "株洲市公安局", "430200000000", "653222198003013069", null, "涉疆关注人员", "阿则古丽·阿卜杜拉", "653222198003013069", "101005", "20170823201800", "430203", "建设南路255号", "(芦淞区)金龙大酒店", "4302030043", "株洲市芦淞分局", "430203000000", "{\"入住房号\":\"1205\",\"退房时间\":\"\"}", "430200231012017080009245157", null, null, "20170823205254");

            dt.Rows.Add("43020017082309464410", "株公情报常字[预警指令](2017)第9464414号", "430203430000", "20170823205254", "株洲市公安局", "株洲市公安局", "430200000000", "653222197107102918", null, "涉疆关注人员", "麦麦提·乌尤普", "653222197107102918", "101005", "20170823201700", "430203", "建设南路255号", "(芦淞区)金龙大酒店", "4302030043", "株洲市芦淞分局", "430203000000", "{\"入住房号\":\"1205\",\"退房时间\":\"\"}", "430200231012017080009245158", null, null, "20170823205254");

            dt.Rows.Add("43020017082409464507", "株公情报常字[预警指令](2017)第9464511号", "430211000000", "20170824092330", "株洲市公安局", "株洲市公安局", "430211000000", "653223198403202914", null, "涉疆关注人员", "麦麦提阿卜拉·麦麦提", "653223198403202914", "101007", "20170824043642", "430211", "天元区天伦东路天健华庭6号", "株洲市天元区天伦东路象牙塔网络会所", "43021110000006", "株洲市天元分局", "430211000000", "{\"上网座位\":\"座位号:073\",\"下网时间\":\"20170824083715\"}", "430200231012017080009245255", "113.13218", "27.8302", "20170824092330");

            dt.Rows.Add("43020017082509464733", "株公情报常字[预警指令](2017)第9464737号", "430203000000", "20170825155454", "株洲市公安局", "株洲市公安局", "430203000000", "653222199309100274", null, "涉疆关注人员", "阿卜杜力艾海提·图尔荪托合提", "653222199309100274", "101007", "20170825152110", "430203", "钟鼓岭湖南金凤凰珠宝有限公司负101门面", "株洲市芦淞区蓝魔网络会所", "43020310025346", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:100\",\"下网时间\":\"\"}", "430200231012017080009245481", null, null, "20170825155454");

            dt.Rows.Add("43020017082509464742", "株公情报常字[预警指令](2017)第9464746号", "430203000000", "20170825175458", "株洲市公安局", "株洲市公安局", "430203000000", "653222199309100274", null, "涉疆关注人员", "阿卜杜力艾海提·图尔荪托合提", "653222199309100274", "101007", "20170825152110", "430203", "钟鼓岭湖南金凤凰珠宝有限公司负101门面", "株洲市芦淞区蓝魔网络会所", "43020310025346", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:100\",\"下网时间\":\"20170825171320\"}", "430200231012017080009245490", null, null, "20170825175458");

            dt.Rows.Add("43020017082509464781", "株公情报常字[预警指令](2017)第9464785号", "430203000000", "20170825212507", "株洲市公安局", "株洲市公安局", "430203000000", "653222199605144175", null, "涉疆关注人员", "努尔麦麦提·图然尼亚", "653222199605144175", "101007", "20170825204554", "430206", "芦淞区董家段中心路七号", "株洲市芦凇区飞船网吧", "43020310000051", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:042\",\"下网时间\":\"\"}", "430200231012017080009245529", "113.18253", "27.79923", "20170825212507");

            dt.Rows.Add("43020017082509464792", "株公情报常字[预警指令](2017)第9464796号", "430203000000", "20170825222510", "株洲市公安局", "株洲市公安局", "430203000000", "653222199605144175", null, "涉疆关注人员", "努尔麦麦提·图然尼亚", "653222199605144175", "101007", "20170825204554", "430206", "芦淞区董家段中心路七号", "株洲市芦凇区飞船网吧", "43020310000051", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:042\",\"下网时间\":\"20170825215514\"}", "430200231012017080009245540", "113.18253", "27.79923", "20170825222510");

            dt.Rows.Add("43020017082809465271", "株公情报常字[预警指令](2017)第9465275号", "430203430000", "20170828162809", "株洲市公安局", "株洲市公安局", "430200000000", "653222197304080084", null, "涉疆关注人员", "阿丽屯古丽·玉苏普", "653222197304080084", "101005", "20170823201700", "430203", "建设南路255号", "(芦淞区)金龙大酒店", "4302030043", "株洲市芦淞分局", "430203000000", "{\"入住房号\":\"1205\",\"退房时间\":\"20170824120300\"}", "430200231012017080009246019", null, null, "20170828162809");

            dt.Rows.Add("43020017082909465426", "株公情报常字[预警指令](2017)第9465430号", "430203000000", "20170829055841", "株洲市公安局", "株洲市公安局", "430203000000", "654221198509101044", null, "涉疆关注人员", "也尔生古丽·阿德力哈", "654221198509101044", "101007", "20170829053753", "430203", "芦淞区人民中路湘中化工厂门面", "株洲市芦凇区东方网络会所", "43020310000050", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:001\",\"下网时间\":\"\"}", "430200231012017080009246174", "113.15621", "27.97918", "20170829055841");

            dt.Rows.Add("43020017082909465426", "株公情报常字[预警指令](2017)第9465430号", "430203000000", "20170829055841", "株洲市公安局", "株洲市公安局", "430203000000", "654221198509101044", null, "涉疆关注人员", "也尔生古丽·阿德力哈", "654221198509101044", "101007", "20170829053753", "430203", "芦淞区人民中路湘中化工厂门面", "株洲市芦凇区东方网络会所", "43020310000050", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:001\",\"下网时间\":\"\"}", "430200231012017080009246174", "113.13883", "27.8525", "20170829055841");

            dt.Rows.Add("43020017082909465440", "株公情报常字[预警指令](2017)第9465444号", "430203000000", "20170829085849", "株洲市公安局", "株洲市公安局", "430203000000", "654221198509101044", null, "涉疆关注人员", "也尔生古丽·阿德力哈", "654221198509101044", "101007", "20170829053753", "430203", "芦淞区人民中路湘中化工厂门面", "株洲市芦凇区东方网络会所", "43020310000050", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:001\",\"下网时间\":\"20170829080545\"}", "430200231012017080009246188", "113.15621", "27.97918", "20170829085849");

            dt.Rows.Add("43020017082909465440", "株公情报常字[预警指令](2017)第9465444号", "430203000000", "20170829085849", "株洲市公安局", "株洲市公安局", "430203000000", "654221198509101044", null, "涉疆关注人员", "也尔生古丽·阿德力哈", "654221198509101044", "101007", "20170829053753", "430203", "芦淞区人民中路湘中化工厂门面", "株洲市芦凇区东方网络会所", "43020310000050", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:001\",\"下网时间\":\"20170829080545\"}", "430200231012017080009246188", "113.13883", "27.8525", "20170829085849");

            dt.Rows.Add("43020017083009465618", "株公情报常字[预警指令](2017)第9465622号", "430203000000", "20170830042939", "株洲市公安局", "株洲市公安局", "430203000000", "654221198509101044", null, "涉疆关注人员", "也尔生古丽·阿德力哈", "654221198509101044", "101007", "20170830035900", "430203", "芦淞区建设中路36号", "株洲市芦凇区象牙塔网络会所旗舰店", "43020310000001", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:027\",\"下网时间\":\"\"}", "430200231012017080009246366", "113.14108", "27.84623", "20170830042939");

            dt.Rows.Add("43020017083009465628", "株公情报常字[预警指令](2017)第9465632号", "430203000000", "20170830082947", "株洲市公安局", "株洲市公安局", "430203000000", "654221198509101044", null, "涉疆关注人员", "也尔生古丽·阿德力哈", "654221198509101044", "101007", "20170830035900", "430203", "芦淞区建设中路36号", "株洲市芦凇区象牙塔网络会所旗舰店", "43020310000001", "株洲市芦淞分局", "430203000000", "{\"上网座位\":\"座位号:027\",\"下网时间\":\"20170830075229\"}", "430200231012017080009246376", "113.14108", "27.84623", "20170830082947");

            dt.Rows.Add("43020017090209465892", "株公情报常字[预警指令](2017)第9465896号", "430202420000", "20170902160305", "株洲市公安局", "株洲市公安局", "430200000000", "653221199911021978", null, "涉疆关注人员", "希尔艾力·伊米尔", "653221199911021978", "101005", "20170902153300", "430202", "株洲市荷塘区文化路775号", "(荷塘区)金域半岛大酒店", "4302020556", "株洲市荷塘分局", "430202000000", "{\"入住房号\":\"1106\",\"退房时间\":\"\"}", "430200231012017090009246640", null, null, "20170902160305");

            dt.Rows.Add("43020017090209465893", "株公情报常字[预警指令](2017)第9465897号", "430202420000", "20170902160305", "株洲市公安局", "株洲市公安局", "430200000000", "65322119801008191X", null, "涉疆关注人员", "麦麦提敏·伊敏托合提", "65322119801008191X", "101005", "20170902153200", "430202", "株洲市荷塘区文化路775号", "(荷塘区)金域半岛大酒店", "4302020556", "株洲市荷塘分局", "430202000000", "{\"入住房号\":\"1106\",\"退房时间\":\"\"}", "430200231012017090009246641", null, null, "20170902160305");

            dt.Rows.Add("43020017090309465981", "株公情报常字[预警指令](2017)第9465985号", "430202420000", "20170903200417", "株洲市公安局", "株洲市公安局", "430200000000", "65322219840425033X", null, "涉疆关注人员", "麦麦提艾力·麦托合提", "65322219840425033X", "101005", "20170902151600", "430202", "株洲市荷塘区文化路775号", "(荷塘区)金域半岛大酒店", "4302020556", "株洲市荷塘分局", "430202000000", "{\"入住房号\":\"1106\",\"退房时间\":\"20170903192100\"}", "430200231012017090009246729", null, null, "20170903200417");

            dt.Rows.Add("43020017090309465986", "株公情报常字[预警指令](2017)第9465990号", "430211430000", "20170903230425", "株洲市公安局", "株洲市公安局", "430200000000", "650203199512240027", null, "涉疆关注人员", "祖菲拉·地力木拉提", "650203199512240027", "101005", "20170903224300", "430211", "天元区泰山西路湖南工业大学新校区D栋", "(天元区)天天向上商务宾馆", "4302111224", "株洲市天元分局", "430211000000", "{\"入住房号\":\"8232\",\"退房时间\":\"\"}", "430200231012017090009246734", null, null, "20170903230425");

            dt.Rows.Add("43020017090509466096", "株公情报常字[预警指令](2017)第9466100号", "430203440000", "20170905103555", "株洲市公安局", "株洲市公安局", "430200000000", "653223198009121913", null, "涉疆关注人员", "吾吉麦麦提·努尔麦提", "653223198009121913", "101005", "20170601152600", "430203", "沿江南路81号", "(芦淞区)清兴商务宾馆", "4302030789", "株洲市芦淞分局", "430203000000", "{\"入住房号\":\"8309\",\"退房时间\":\"20170602063100\"}", "430200231012017090009246844", null, null, "20170905103555");

            m_dataTable = dt;
        }


    }


    public class KeyPersonnel
    {
        public string YJXXBH { get; set; } // 1-预警信息编号
        public string FWZH { get; set; } // 2-发文字号
        public string YJJSDW { get; set; } // 3-预警接受单位
        public string YJFBSJ { get; set; } // 4-预警发布时间
        public string FBRXM { get; set; } // 5-发布人姓名
        public string FBDW { get; set; } // 6-发布单位
        public string FBDWJGDM { get; set; } // 7-发布单位机构代码
        public string ZDRYBH { get; set; } // 8-重点人员编号
        public string ZDRYLBBJ { get; set; } // 9-重点人员类别标记
        public string ZDRYXL { get; set; } // 10-重点人员细类
        public string ZDRYXM { get; set; } // 11-重点人员姓名----1
        public string SFZH { get; set; } // 12-身份证号----2
        public string DTXXLB { get; set; } // 13-动态信息类别
        public string HDFSSJ { get; set; } // 14-活动发生时间----3
        public string HDFSDDQH { get; set; } // 15-活动发生地点区划
        public string HDFSDDXZ { get; set; } // 16-活动发生地点详址----4
        public string HDFSDDSSSHCS { get; set; } // 17-活动发生地点所属社会场所
        public string HDFSDDSSSHCSDM { get; set; } // 18-活动发生地点所属社会场所代码
        public string HDFSDDSSGAJG { get; set; } // 19-活动发生地点所属公安机关
        public string HDFSDDSSGAJGJGDM { get; set; } // 20-活动发生地点所属公安机关代码
        public string HDXGXX { get; set; } // 21-活动相关信息----5
        public string LDXXBH { get; set; } // 22-联动信息编号
        public string SHAPEMINX { get; set; } // 23-PGIS地图X轴坐标
        public string SHAPEMINY { get; set; } // 24-PGIS地图Y轴坐标
        public string RKSJ { get; set; } // 25-入库时间

    }

    public class MonitorTypeOfKP : KeyPersonnel
    {
        public string MonitoringType { get; set; }

    }
}
