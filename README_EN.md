<h1 align="center">Dyplom_MVC</h1>
<h3 align="center">Engineering Thesis - Accounting Logic Designer</h3>

<p align="left">
  A web-based application that enables users to create simple logical layouts for accounting processes and financial workflows.
  <a href=https://apd.pbs.edu.pl/diplomas/24914/>Link to University Archive with Complete Thesis</a>
</p>
<img src="https://i.pinimg.com/736x/73/f9/ce/73f9cee0abf464c65d9caaf807a15458.jpg">

<h3 align="left">Languages and Tools:</h3>
<p align="left"> 
  <a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> 
    <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/> 
  </a> 
  <a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> 
    <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/> 
  </a> 
</p>

## Project Overview

This MVC (Model-View-Controller) application provides a visual interface for designing accounting workflows and financial transaction logic. It allows accountants and financial professionals to:

- **Create logical process flows** for accounting transactions
- **Define business rules** for financial operations
- **Manage accounting workflows** with drag-and-drop interface
- **Document financial processes** in a structured format

## Architecture

The application follows the MVC pattern with:
- **Models**: Data structures representing accounting entities (transactions, accounts, entries)
- **Views**: User interface for workflow design and visualization
- **Controllers**: Business logic handlers for accounting operations

## Features

### Accounting Logic Components
- Transaction templates for common accounting entries
- Account mapping and reconciliation tools
- Workflow validation for compliance with accounting standards
- Audit trail logging for financial transactions

### User Experience
- Intuitive visual layout designer
- Real-time workflow preview
- Template library for standard accounting processes
- Export functionality for documentation

## Technologies Used

- **Language**: C# (.NET Framework/Core)
- **Architecture**: ASP.NET MVC
- **Database**: SQL Server
- **Frontend**: JavaScript, HTML5, CSS3
- **Additional Libraries**: Popper.js for UI enhancements

## Getting Started

### Prerequisites
- .NET Framework 4.7+ or .NET Core 5.0+
- Visual Studio 2019 or later
- SQL Server 2016 or later

### Installation
1. Clone the repository
2. Open `Dyplom.sln` in Visual Studio
3. Restore NuGet packages
4. Configure database connection string
5. Run database migrations
6. Build and run the application

## Business Logic

### Accounting Module
The application processes accounting transactions through a defined workflow:

1. **Transaction Entry**: Users define the type and nature of the accounting transaction
2. **Account Assignment**: System maps transaction to appropriate general ledger accounts
3. **Amount Allocation**: Distribute amounts across debit/credit sides
4. **Validation**: Check for accounting principles compliance (debit = credit)
5. **Recording**: Store transaction in audit trail
6. **Reporting**: Generate accounting reports and statements

### Financial Workflow Rules
- All transactions must balance (double-entry accounting principle)
- Account codes must reference valid chart of accounts
- Amounts must be validated against authorization limits
- Timestamp tracking for audit compliance

## Contribution

For contributions related to accounting logic enhancements:
- Ensure compliance with accounting standards (GAAP/IFRS)
- Add appropriate comments in English
- Include accounting context in all business logic changes
- Test with sample accounting scenarios

## License

This project is an academic thesis work. Refer to the University Archive for licensing terms.

## Author

Created as an Engineering Thesis project at Politechnika Bydgoska

---
**Note**: For accounting-related questions or modifications, please reference relevant accounting standards and consult with accounting professionals.