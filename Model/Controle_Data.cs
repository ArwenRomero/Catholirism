﻿using System.ComponentModel.DataAnnotations;

namespace Catholirism.Model;
public class DataFuturaAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is DateTime data)
        {
            return data.Date > DateTime.Today;
        }
        return false;
    }
}
