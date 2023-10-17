using System;

namespace FreEPPlus;

/// <summary>
///     Create a header title and number format to a column
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class ExcelColumnAttribute : Attribute
{
    /// <summary>
    ///     Set the header of a column
    /// </summary>
    /// <param name="name">Name of column</param>
    public ExcelColumnAttribute(string name)
    {
        Name = name;
    }

    /// <summary>
    /// Set name and format of a cell
    /// </summary>
    /// <param name="name">Name</param>
    /// <param name="numberFormat">Excel supported format</param>
    public ExcelColumnAttribute(string name, string numberFormat)
    {
        Name = name;
        NumberFormat = numberFormat;
    }

    /// <summary>
    ///     Text to appear as the header of the column
    /// </summary>
    public string Name { get; }

#nullable enable
    /// <summary>
    ///     Number format of the cell
    /// </summary>
    public string? NumberFormat { get; }
}