---
name: excel-data-processing
description: This skill provides instructions for importing, reading, and manipulating Excel files (.xlsx, .xls) within a .NET Clean Architecture environment. It is strictly limited to using **ClosedXML** and **ExcelDataReader**.
---

## Constraints & Requirements
* **Primary Libraries:** Use only `ClosedXML` for creating/editing and `ExcelDataReader` for high-performance reading.
* **Architecture Placement:** * Interfaces should reside in the **Application Layer**.
    * Concrete implementations must reside in the **Infrastructure Layer**.
* **No Interop:** Do not use `Microsoft.Office.Interop.Excel`.
* **No Other Third-Party Libraries:** Avoid EPPlus, NPOI, or IronXL.

## Implementation Guidelines

### 1. Reading (ExcelDataReader)
Use `ExcelReaderFactory` for memory-efficient stream reading. 
* Ensure the `System.Text.Encoding.CodePages` provider is registered if handling legacy `.xls` files.
* Prefer `AsDataSet()` for quick mapping or `Read()` loops for large datasets.

### 2. Writing & Styling (ClosedXML)
Use `XLWorkbook` for generating reports or updating existing spreadsheets.
* Focus on strongly-typed cell access: `worksheet.Cell(row, col).Value = data;`.
* Use `IXLTable` for automatic filtering and styling of data ranges.

## Example Usage Context
When a user asks to "Import user list from Excel," generate a service in the Infrastructure layer that utilizes `ExcelDataReader` to stream the file into a DTO defined in the Application layer.