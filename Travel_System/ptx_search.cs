using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PTXHttpClientExtension;
using System.Net;
using System.Net.Http;

using Newtonsoft.Json;

namespace Travel_System
{
    public class OperatorName
    {
        public string Zh_tw { get; set; }
        public string En { get; set; }
    }

    public class Operator
    {
        public string OperatorID { get; set; }
        public OperatorName OperatorName { get; set; }
        public string OperatorCode { get; set; }
        public string OperatorNo { get; set; }
    }

    public class SubRouteName
    {
        public string Zh_tw { get; set; }
        public string En { get; set; }
    }

    public class SubRoute
    {
        public string SubRouteUID { get; set; }
        public string SubRouteID { get; set; }
        public List<string> OperatorIDs { get; set; }
        public SubRouteName SubRouteName { get; set; }
        public string Headsign { get; set; }
        public string HeadsignEn { get; set; }
        public int Direction { get; set; }
        public string FirstBusTime { get; set; }
        public string LastBusTime { get; set; }
        public string HolidayFirstBusTime { get; set; }
        public string HolidayLastBusTime { get; set; }
    }

    public class RouteName
    {
        public string Zh_tw { get; set; }
        public string En { get; set; }
    }

    public class BusInfo
    {
        public string RouteUID { get; set; }
        public string RouteID { get; set; }
        public bool HasSubRoutes { get; set; }
        public List<Operator> Operators { get; set; }
        public string AuthorityID { get; set; }
        public string ProviderID { get; set; }
        public List<SubRoute> SubRoutes { get; set; }
        public int BusRouteType { get; set; }
        public RouteName RouteName { get; set; }
        public string DepartureStopNameZh { get; set; }
        public string DepartureStopNameEn { get; set; }
        public string DestinationStopNameZh { get; set; }
        public string DestinationStopNameEn { get; set; }
        public string TicketPriceDescriptionZh { get; set; }
        public string TicketPriceDescriptionEn { get; set; }
        public string FareBufferZoneDescriptionZh { get; set; }
        public string FareBufferZoneDescriptionEn { get; set; }
        public string RouteMapImageUrl { get; set; }
        public string City { get; set; }
        public string CityCode { get; set; }
        public string UpdateTime { get; set; }
        public int VersionID { get; set; }
    }

    public class ServiceDay
    {
        public int Sunday { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
        public int NationalHolidays { get; set; }
    }

    public class DatePeriod
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class SpecialDay
    {
        public List<string> Dates { get; set; }
        public DatePeriod DatePeriod { get; set; }
        public int ServiceStatus { get; set; }
        public string Description { get; set; }
    }

    public class StopName
    {
        public string Zh_tw { get; set; }
        public string En { get; set; }
    }

    public class StopTime
    {
        public int StopSequence { get; set; }
        public string StopUID { get; set; }
        public string StopID { get; set; }
        public StopName StopName { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
    }

    public class Timetable
    {
        public string TripID { get; set; }
        public ServiceDay ServiceDay { get; set; }
        public List<SpecialDay> SpecialDays { get; set; }
        public List<StopTime> StopTimes { get; set; }
    }

    public class ServiceDay2
    {
        public int Sunday { get; set; }
        public int Monday { get; set; }
        public int Tuesday { get; set; }
        public int Wednesday { get; set; }
        public int Thursday { get; set; }
        public int Friday { get; set; }
        public int Saturday { get; set; }
        public int NationalHolidays { get; set; }
    }

    public class DatePeriod2
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }

    public class SpecialDay2
    {
        public List<string> Dates { get; set; }
        public DatePeriod2 DatePeriod { get; set; }
        public int ServiceStatus { get; set; }
        public string Description { get; set; }
    }

    public class Frequency
    {
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int MinHeadwayMins { get; set; }
        public int MaxHeadwayMins { get; set; }
        public ServiceDay2 ServiceDay { get; set; }
        public List<SpecialDay2> SpecialDays { get; set; }
    }

    public class BusSchedule
    {
        public string RouteUID { get; set; }
        public string RouteID { get; set; }
        public RouteName RouteName { get; set; }
        public string SubRouteUID { get; set; }
        public string SubRouteID { get; set; }
        public SubRouteName SubRouteName { get; set; }
        public int Direction { get; set; }
        public string OperatorID { get; set; }
        public string OperatorCode { get; set; }
        public List<Timetable> Timetables { get; set; }
        public List<Frequency> Frequencys { get; set; }
        public string UpdateTime { get; set; }
        public int VersionID { get; set; }
    }

    public class ptx_search
    {
        //請替換為串接使用的 appID 與 appKey
        public const string appID = "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF";
        public const string appKey = "FFFFFFFF-FFFF-FFFF-FFFF-FFFFFFFFFFFF";

        public const string baseAddress = "http://ptx.transportdata.tw/";
        public static string requestUri = "";


        public static List<BusInfo> get_info_by_city(string city_name)  // 輸入：城市名稱；輸出：公車資訊
        {
            requestUri = "/MOTC/v2/Bus/Route/City/" + city_name + "?$format=json";

            string _json;

            HttpClient _client;
            HttpClientHandler _clientHandler;

            _clientHandler = new HttpClientHandler();

            //啟用 GZip, Deflate 壓縮傳輸 / 減少傳遞的資料量
            _clientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            _client = new HttpClient(_clientHandler);
            _client.BaseAddress = new Uri(baseAddress);

            //設定 RequestHeader 驗證簽章
            _client.SetSignature(appID, appKey);

            var _response = _client.GetAsync(requestUri).Result;

            if (_response.IsSuccessStatusCode == true)
            {
                _json = _response.Content.ReadAsStringAsync().Result;
                
                return JsonConvert.DeserializeObject<List<BusInfo>>(_json);
            }
            else
            {
                return null;
            }
        }

        public static List<BusSchedule> get_schedule_by_city(string city_name)  // 輸入：城市名稱；輸出：公車時刻資訊
        {
            requestUri = "/MOTC/v2/Bus/Schedule/City/" + city_name + "?$format=json";

            string _json;

            HttpClient _client;
            HttpClientHandler _clientHandler;

            _clientHandler = new HttpClientHandler();

            //啟用 GZip, Deflate 壓縮傳輸 / 減少傳遞的資料量
            _clientHandler.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            _client = new HttpClient(_clientHandler);
            _client.BaseAddress = new Uri(baseAddress);

            //設定 RequestHeader 驗證簽章
            _client.SetSignature(appID, appKey);

            var _response = _client.GetAsync(requestUri).Result;

            if (_response.IsSuccessStatusCode == true)
            {
                _json = _response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<List<BusSchedule>>(_json);
            }
            else
            {
                return null;
            }
        }

        public static string get_image_by_depdes(List<BusInfo> businfos, string dep, string des)  // 請先跑過get_info_by_city，得到List<BusInfo>再填入第一個參數，第二個參數為起站，第三個參數為迄站，輸出路線圖片網址。
        {
            if(businfos != null)
            {
                foreach (BusInfo businfo in businfos)
                {
                    if(businfo.DepartureStopNameZh == dep && businfo.DestinationStopNameZh == des)
                    {
                        return businfo.RouteMapImageUrl;
                    }
                }
            }
            return null;
        }

        public static string get_schedule_by_depdes(List<BusInfo> businfos, List<BusSchedule> busschedules, string dep, string des)  // 請先跑過get_info_by_city，得到List<BusInfo>再填入第一個參數，以及先跑過get_schedule_by_city，得到List<BusSchedule>再填入第二個參數，第三個參數為起站，第四個參數為迄站，輸出路線班表字串。
        {
            string routeName = "";
            string temp_table = "";

            if (businfos != null)
            {
                foreach (BusInfo businfo in businfos)
                {
                    if (businfo.DepartureStopNameZh == dep && businfo.DestinationStopNameZh == des)
                    {
                        routeName = businfo.RouteName.Zh_tw;
                    }
                }
            }
            else return null;

            if (busschedules != null)
            {
                foreach (BusSchedule busschedule in busschedules)
                {
                    if (busschedule.RouteName.Zh_tw == routeName)
                    {
                        Console.WriteLine((busschedule.Direction == 0) ? "去程" : (busschedule.Direction == 1) ? "返程" : (busschedule.Direction == 2) ? "迴圈" : "未知型態");
                        Console.WriteLine("============================");
                        if (busschedule.Timetables != null)
                        {
                            foreach (Timetable timetable in busschedule.Timetables)
                            {
                                foreach (StopTime stopTime in timetable.StopTimes)
                                {
                                    Console.WriteLine("由" + stopTime.StopName.Zh_tw + "出發");
                                    Console.WriteLine("到站:" + stopTime.ArrivalTime);
                                    Console.WriteLine("離站:" + stopTime.DepartureTime);
                                }
                            }
                        }
                        else
                        {
                            foreach (Frequency frequency in busschedule.Frequencys)
                            {
                                Console.WriteLine("============================");
                                Console.WriteLine("最早時間:" + frequency.StartTime);
                                Console.WriteLine("最晚時間:" + frequency.EndTime);
                                Console.WriteLine("最小班距:" + frequency.MinHeadwayMins);
                                Console.WriteLine("最大班距:" + frequency.MaxHeadwayMins);
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                    }
                }
            }
            return null;
        }
    }
}

// 使用方式： (寫在你想要呼叫的地方，不要寫在這裡，此程式檔(ptx_search.cs)是定義，就不動了)
/*
    List<BusInfo> businfos = ptx_search.get_info_by_city("Tainan");
    if(businfos != null)
    {
        foreach(BusInfo businfo in businfos)
        {
            Console.WriteLine(businfo.RouteMapImageUrl + " " + businfo.DepartureStopNameZh + "->" + businfo.DestinationStopNameZh);
        }
        Console.WriteLine(ptx_search.get_image_by_depdes(businfos, "安平", "大灣"));
    }
    List<BusSchedule> busschedules = ptx_search.get_schedule_by_city("Tainan");
    ptx_search.get_schedule_by_depdes(businfos, busschedules, "安平", "大灣");
*/
