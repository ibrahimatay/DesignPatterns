﻿using System;

namespace DesignPatterns.Proxy
{
    public class Weather
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string CityCode { get; set; }
        public string CountyCode { get; set; }
    }
}