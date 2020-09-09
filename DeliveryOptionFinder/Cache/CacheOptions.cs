namespace DeliveryOptionFinder.Cache
{
    public class CacheOptions
    {


        /*
         *  Hard coded here, usually in .net Core use the IOption feauture
         *  "CacheOptions": {
                "LocalCacheName": "LocalRedis",
                "CacheAddress": "localhost:6379",
                "CacheTimeSpanInMinutes": "10"
              },
         * 
         */
        public int CacheTimeSpanInMinutes => 10;
        public string LocalCacheName => "LocalRedis";
        public string CacheAddress => "localhost:6379";
    }
}
