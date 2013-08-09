using System;
using System.ComponentModel.DataAnnotations;

namespace jQuery.Validation.Unobtrusive.Native.Demos.Models
{
    public class RangeModel
    {
        [Range(typeof(short), "10", "20")]
        public short Short { get; set; }
        [Range(10, 20)]
        public int Integer { get; set; }
        [Range(typeof(long), "10", "20")]
        public long Long { get; set; }
        [Range(typeof(byte), "10", "20")]
        public byte Byte { get; set; }
        [Range(typeof(decimal), "10", "20")]
        public decimal Decimal { get; set; }
        [Range(typeof(float), "10", "20")]
        public float Single { get; set; }
        [Range(10D, 20D)]
        public double Double { get; set; }

        [Range(typeof(DateTime), "2012-06-13", "2012-06-15")]
        public DateTime DateTime { get; set; }
    }
}