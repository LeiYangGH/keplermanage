//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 管理系统
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    public partial class TiDan
    {
        [DisplayName("发货方式")]
        public string FHFS { get; set; }

        //仿照着把其他列的中文名称加上
        [DisplayName("车牌号")]
        public string CPH { get; set; }
        [DisplayName("流水号")]
        public string LSH { get; set; }
        [DisplayName("铅封号")]
        public string QFH { get; set; }
        [DisplayName("提单号")]
        public string TDH { get; set; }
        [DisplayName("应发量")]
        public Nullable<int> YFL { get; set; }
        [DisplayName("实发量")]
        public Nullable<int> SFL { get; set; }
        [DisplayName("操作员")]
        public string CZY { get; set; }
        [DisplayName("合同号")]
        public string HTH { get; set; }
        [DisplayName("产品罐号")]
        public string CPGH { get; set; }
        [DisplayName("批次号")]
        public string PCH { get; set; }
        [DisplayName("货位号")]
        public string HWH { get; set; }
        [DisplayName("皮重")]
        public Nullable<int> PZ { get; set; }
        [DisplayName("毛重")]
        public Nullable<int> MZ { get; set; }
        [DisplayName("净重")]
        public Nullable<int> JZ { get; set; }
        [DisplayName("物料名称")]
        public string WLMC { get; set; }
        [DisplayName("航次")]
        public string HC { get; set; }
        [DisplayName("发货单位")]
        public string FHDW { get; set; }
        [DisplayName("收货单位")]
        public string SHDW { get; set; }
        [DisplayName("流向")]
        public string LX { get; set; }
        [DisplayName("开始时间")]
        public Nullable<System.DateTime> KSSJ { get; set; }
        [DisplayName("结束时间")]
        public Nullable<System.DateTime> JSSJ { get; set; }
        [DisplayName("备注")]
        public string BZ { get; set; }
    }
}
