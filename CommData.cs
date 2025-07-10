using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    public static class CommData
    {
        // 词性标签字典（完整版）
        public static readonly Dictionary<string, string> PosTags = new Dictionary<string, string>
        {
            {"", "所有词性"},
            {"a", "形容词"}, {"ad", "副形词"}, {"ag", "形语素"}, {"an", "名形词"},
            {"b", "区别词"},
            {"c", "连词"},
            {"d", "副词"}, {"df", ""}, {"dg", "副语素"},
            {"e", "叹词"},
            {"f", "方位词"},
            {"g", "语素"},
            {"h", "前接成分"},
            {"i", "成语"},
            {"j", "简称略语"},
            {"k", "后接成分"},
            {"l", "习用语"},
            {"m", "数词"}, {"mg", ""}, {"mq", ""},
            {"n", "名词"}, {"ng", "名语素"}, {"nr", "人名"}, {"nrfg", ""},
            {"nrt", ""}, {"ns", "地名"}, {"nt", "机构团体"}, {"nz", "其他专名"},
            {"o", "拟声词"},
            {"p", "介词"},
            {"q", "量词"},
            {"r", "代词"}, {"rg", ""}, {"rr", ""}, {"rz", ""},
            {"s", "处所词"},
            {"t", "时间词"}, {"tg", "时语素"},
            {"u", "助词"}, {"ud", "结构助词"}, {"ug", "时态助词"}, {"uj", ""},
            {"ul", "时态助词"}, {"uv", "结构助词"}, {"uz", ""},
            {"v", "动词"}, {"vd", "副动词"}, {"vg", "动语素"}, {"vi", "不及物动词"},
            {"vn", "名动词"}, {"vq", ""},
            {"x", "非语素字"},
            {"y", "语气词"},
            {"z", "状态词"}, {"zg", ""}
        };
    }
}
