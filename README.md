# FreEPPlus
FreEPPlus is a free alternative to create Office Open XML format (xlsx) spreadsheets without the use of associated interops in .NET 8.0.

FreEPPlus is forked from [rimland/EPPlus](https://github.com/rimland/EPPlus/) which is in turned forked from [JanKallman/EPPlus](https://github.com/JanKallman/EPPlus) to bring it to a later version of .NET and maintain a free alternative to reading and modifying spreadsheets in C#. Alternatively, [EPPlus](https://www.epplussoftware.com/) is a successful library with commercial support and licensing.

## Added Features
* .NET 8.0 compatible
* Introduction of `ExcelColumnAttribute` to decorate output class with both name of Excel Number format.

# Historical Readme

## Continuous Version of EPPlus Free Edition 4.5.3.3
**The [JanKallman/EPPlus](https://github.com/JanKallman/EPPlus) repository has been archived by the owner. So I fork it to my repository and continue to maintain the source code.**

---
**This repository has moved to https://github.com/EPPlusSoftware/EPPlus.** 

**The code in this archive represents the final version of EPPlus under LGPL. There will be no more activity here.**  

EPPlus will from version 5 switch license from **LGPL** to [Polyform Noncommercial 1.0.0]( https://polyformproject.org/licenses/noncommercial/1.0.0/) license.  
With the new license EPPlus is still free to use in some cases, but will require a commercial license to be used in a commercial business.

More information on the license change on [our website]( https://www.epplussoftware.com)
***
Create advanced Excel spreadsheets using .NET, without the need of interop.

EPPlus is a .NET library that reads and writes Excel files using the Office Open XML format (xlsx). 
EPPlus has no dependencies other than .NET.
 
### EPPlus supports:
* Cell Ranges 
* Cell styling (Border, Color, Fill, Font, Number, Alignments) 
* Data validation 
* Conditional formatting 
* Charts 
* Pictures 
* Shapes 
* Comments 
* Tables 
* Pivot tables 
* Protection 
* Encryption 
* VBA 
* Formula calculation 
* Many more... 

### Overview
This project started with the source from ExcelPackage. It was a great project to start from.
It had the basic functionality needed to read and write a spreadsheet.
Advantages over other:
EPPlus uses dictionaries to access cell data, making performance a lot better.
Complete integration with .NET 

### Support
All support is currently referred to [Stack overflow](https://stackoverflow.com/questions/tagged/epplus). 
A tutorial is available in the wiki and the sample project can be downloaded with each version. 
The old site at [Codeplex](http://epplus.codeplex.com) also contains material that can be helpful. 
Bugs and new feature requests can be added to the issues tracker. 

### License
The project is licensed under the GNU Library General Public License (LGPL). 
