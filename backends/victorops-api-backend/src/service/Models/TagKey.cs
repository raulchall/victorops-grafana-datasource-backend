using System;
using System.Collections.Generic;

namespace VictorOpsBackendApi.Models
{
    public class TagKey
    {
        public string type { get; set; }
        public string text { get; set; }
    }

    public class TagValue
    {
        public string text { get; set; }
    }

    public class QueryRequest
    {
        /*
        {
            "range": { "from": "2015-12-22T03:06:13.851Z", "to": "2015-12-22T06:48:24.137Z" },
            "interval": "5s",
            "targets": [
                { "refId": "B", "target": "upper_75" },
                { "refId": "A", "target": "upper_90" }
            ],
            "format": "json",
            "maxDataPoints": 2495 //decided by the panel
        }
        */
        public DatetimeRange range { get; set;}
        public string interval { get; set;}
        public ICollection<Target> targets { get; set;}
        public string format { get; set;}
        public int maxDataPoints { get; set;}
    }

    public class Target
    {
        public string refId { get; set;}
        public string target { get; set;}
    }

    public class DatetimeRange 
    {
        public DateTime from { get; set;}
        public DateTime to { get; set;}
    }

    public class RawRange 
    {
        public string from { get; set;}
        public string to { get; set;}
    }

    public class TableQueryResponse
    {
        public ICollection<TableQueryResult> results { get; set; }
    }

    public class TableQueryResult
    {
        /*
        {
            "columns": [
            {
                "text": "Time",
                "type": "time",
                "sort": true,
                "desc": true,
            },
            {
                "text": "mean",
            },
            {
                "text": "sum",
            }
            ],
            "rows": [
            [
                1457425380000,
                null,
                null
            ]
            ],
            "type": "table"
        }
        */
        public ICollection<TableQueryColumn> columns { get; set; }
        public ICollection<ICollection<string>> rows { get; set; }
        public string type { get; set; }
    }

    public class TableQueryColumn
    {
        /*
        {
            "text": "Time",
            "type": "time",
            "sort": true,
            "desc": true,
        }
        */
        public string text { get; set; }
        public string type { get; set; }
        public bool sort { get; set; }
        public bool desc { get; set; }
    }

    public class AnnotationRequest
    {
        /*
       {
            "range": { "from": "2016-03-04T04:07:55.144Z", "to": "2016-03-04T07:07:55.144Z" },
            "rangeRaw": { "from": "now-3h", to: "now" },
            "annotation": {
                "datasource": "generic datasource",
                "enable": true,
                "name": "annotation name"
            },
            "dashboard": DashboardModel
        }
        */
        public DatetimeRange range { get; set; }
        public RawRange rangeRaw { get; set; }
        public Annotation annotation { get; set; }
        public string dashboard { get; set; }
    }

    public class Annotation 
    {
        public string datasource { get; set; }
        public bool enable { get; set; }
        public string name { get; set; }
    }

    public class AnnotationResponse 
    {
        public ICollection<AnnotationResult> results { get; set; }
    }

    public class AnnotationResult 
    {
        /*
        {
            "annotation": {
            "name": "annotation name", //should match the annotation name in grafana
            "enabled": true,
            "datasource": "generic datasource",
            },
            "title": "Cluster outage",
            "time": 1457075272576,
            "text": "Joe causes brain split",
            "tags": ["joe", "cluster", "failure"]
        }
        */

        public Annotation annotation { get; set; }
        public string title { get; set; }
        public DateTime time { get; set; }
        public string text { get; set; }
        public ICollection<string> tags { get; set; }
    }

    public class SearchResponse 
    {
        public ICollection<string> data { get; set; }
    }
}