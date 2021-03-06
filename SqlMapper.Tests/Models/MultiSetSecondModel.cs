﻿using System;
using SqlMapper.Common;

namespace SqlMapper.Tests.Models
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    public class MultiSetSecondModel
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        [Mapping(ColumnName = "Col21")]
        public int FirstColumn { get; set; }

        [Mapping(ColumnName = "Col22")]
        public string SecondColumn { get; set; }

        [Mapping(ColumnName = "Col23")]
        public DateTime ThirdColumn { get; set; }


#pragma warning disable 659
        public override bool Equals(object obj)
#pragma warning restore 659
        {
            var instance = obj as MultiSetSecondModel;

            return FirstColumn == instance?.FirstColumn
                   && SecondColumn == instance.SecondColumn
                   && ThirdColumn == instance.ThirdColumn;
        }
    }
}