namespace Summer
{
    //使用map reduce模式，每次转换属性时，先map一次，然后在reduce一次。不断循环这个过程
    //直到得到想要的数据，或者循环次数超过上限    
    public class AttrData
    {
        //使用跟服务器一样的属性枚举
        public int _attr_type;
        public int _attr_value;
    }

    public class AttrDataSet
    {
        public List<AttrData> _whole_attr_group;
    }

    //从策划配置表读过来的属性枚举，需要转换成跟服务器一样的属性枚举
    public class AttrShuffleData
    {        
        public int _src_attr_type;
        public int _dest_attr_type;
        public float _attr_ratio;
    }

    public class Transfer
    {
        //根据属性id的大小排好序
        public List<AttrShuffleData> _sorted_shuffle_data;

        public List<AttrDataSet> Map(AttrDataSet set)
        {
            
        }

        public AttrDataSet Reduce(List<AttrDataSet> set)
        {

        }

        public AttrDataSet Map(AttrData data)
        {

        }

    }
}