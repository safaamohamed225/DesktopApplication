# Clinic Management System (Windows Forms)

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2+-blue.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
[![C#](https://img.shields.io/badge/C%23-8.0+-239120.svg?logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)

A comprehensive desktop application designed to streamline clinic operations through efficient management of patient records, appointments, and administrative tasks. Built with Windows Forms and C#, this system provides healthcare professionals with an intuitive interface for daily clinic management.

## 🚀 Features

### 👥 Patient Management
- **Complete Patient Records**: Add, edit, and remove patient information with comprehensive data validation
- **Patient Search & Filter**: Quick search functionality with advanced filtering options
- **Medical History Tracking**: Maintain detailed medical histories and treatment records
- **Patient Demographics**: Store and manage patient contact information, insurance details, and emergency contacts

### 📅 Appointment Scheduling
- **Intelligent Scheduling**: Schedule appointments with conflict detection and availability checking
- **Multi-Provider Support**: Manage appointments across multiple healthcare providers
- **Appointment Status Tracking**: Track appointment statuses (scheduled, confirmed, completed, cancelled)
- **Recurring Appointments**: Support for recurring appointment patterns

### 📋 Medical Records Management
- **Secure Record Storage**: Maintain comprehensive medical records with data encryption
- **Visit Documentation**: Record consultation notes, diagnoses, and treatment plans
- **Prescription Management**: Track prescribed medications and dosages
- **Document Attachments**: Support for medical document and image attachments

### 🔐 User Authentication & Security
- **Role-Based Access Control**: Different permission levels for administrators, doctors, and staff
- **Secure Login System**: Username and password authentication with session management
- **Data Encryption**: Sensitive patient data encryption for HIPAA compliance
- **Audit Trail**: Track user actions and system access for security monitoring

## 🛠️ Technology Stack

| Component | Technology |
|-----------|------------|
| **Language** | C# (.NET Framework 4.7.2+) |
| **UI Framework** | Windows Forms (WinForms) |
| **Database** | Microsoft SQL Server / SQL Server Express |
| **Data Access** | ADO.NET / Entity Framework |
| **Authentication** | Custom implementation with encrypted password storage |
| **Reporting** | Crystal Reports / Microsoft Reporting Services |

## 📋 Prerequisites

Before running this application, ensure you have the following installed:

- **Windows OS**: Windows 10 or later (Windows 11 recommended)
- **.NET Framework**: Version 4.7.2 or higher
- **SQL Server**: SQL Server 2016+ or SQL Server Express (free)
- **Visual Studio**: 2019 or later (for development)
- **Memory**: Minimum 4GB RAM (8GB recommended)
- **Storage**: At least 500MB free disk space

## 🚀 Installation

### Option 1: Release Installation
1. Download the latest release from the [Releases](../../releases) page
2. Extract the ZIP file to your desired installation directory
3. Run the setup executable (`ClinicManagementSetup.exe`)
4. Follow the installation wizard instructions
5. Configure database connection on first launch

### Option 2: Development Setup
1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/clinic-management-system.git
   cd clinic-management-system
   ```

2. **Database Setup**
   ```sql
   -- Create database (run in SQL Server Management Studio)
   CREATE DATABASE ClinicManagementDB;
   ```

3. **Configure Connection String**
   - Open `App.config`
   - Update the connection string with your SQL Server details:
   ```xml
   <connectionStrings>
     <add name="ClinicDB" 
          connectionString="Server=YOUR_SERVER;Database=ClinicManagementDB;Integrated Security=true;" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Build and Run**
   - Open the solution in Visual Studio
   - Restore NuGet packages
   - Build the solution (Ctrl+Shift+B)
   - Run the application (F5)

## 📖 Usage

### Initial Setup
1. **First Launch**: The application will automatically create necessary database tables
2. **Admin Account**: Create the first administrator account using the setup wizard
3. **System Configuration**: Configure clinic details, departments, and user roles

### Core Workflows

#### Patient Registration
1. Navigate to **Patients** → **Add New Patient**
2. Fill in required patient information
3. Add insurance and emergency contact details
4. Save to create patient record

#### Appointment Booking
1. Go to **Appointments** → **Schedule New**
2. Select patient from dropdown or search
3. Choose healthcare provider and available time slot
4. Add appointment notes and save

#### Medical Record Entry
1. Select patient from patient list
2. Click **Medical Records** → **New Visit**
3. Document consultation details, diagnosis, and treatment
4. Attach any relevant documents or images

## 📁 Project Structure

```
ClinicManagementSystem/
├── src/
│   ├── Forms/                 # Windows Forms UI
│   │   ├── MainForm.cs
│   │   ├── PatientForm.cs
│   │   ├── AppointmentForm.cs
│   │   └── LoginForm.cs
│   ├── Models/                # Data models
│   │   ├── Patient.cs
│   │   ├── Appointment.cs
│   │   └── MedicalRecord.cs
│   ├── DataAccess/            # Database operations
│   │   ├── DatabaseHelper.cs
│   │   └── Repositories/
│   ├── Business/              # Business logic
│   │   ├── PatientService.cs
│   │   └── AppointmentService.cs
│   └── Utils/                 # Utility classes
├── Database/
│   ├── Scripts/               # SQL scripts
│   └── Schema/                # Database schema
├── Resources/                 # Images, icons, etc.
├── Tests/                     # Unit tests
└── Documentation/             # Additional documentation
```

## 🔧 Configuration

### Database Configuration
The application supports multiple database connection options:

- **SQL Server Express** (recommended for small clinics)
- **SQL Server Standard/Enterprise** (for larger operations)
- **Azure SQL Database** (cloud deployment)

### Security Settings
- Password complexity requirements can be configured in `App.config`
- Session timeout settings are adjustable for security compliance
- Database encryption settings for HIPAA compliance

## 🤝 Contributing

We welcome contributions from the community! Here's how you can help:

### Development Workflow
1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/amazing-feature`)
3. **Commit** your changes (`git commit -m 'Add amazing feature'`)
4. **Push** to the branch (`git push origin feature/amazing-feature`)
5. **Open** a Pull Request

### Coding Standards
- Follow C# naming conventions
- Add XML documentation for public methods
- Include unit tests for new features
- Ensure code passes all existing tests

### Bug Reports
When reporting bugs, please include:
- Operating system version
- .NET Framework version
- Steps to reproduce the issue
- Expected vs actual behavior
- Screenshots if applicable

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🆘 Support

### Documentation
- [User Manual](docs/UserManual.md)
- [Installation Guide](docs/Installation.md)
- [Database Setup](docs/DatabaseSetup.md)
- [API Documentation](docs/API.md)

### Getting Help
- **Issues**: Report bugs or request features via [GitHub Issues](../../issues)
- **Discussions**: Join community discussions in [GitHub Discussions](../../discussions)
- **Email**: Contact the maintainers at support@clinicmanagement.com

### Frequently Asked Questions

**Q: Can this system handle multiple clinic locations?**
A: Currently designed for single-location clinics. Multi-location support is planned for v2.0.

**Q: Is the system HIPAA compliant?**
A: The system includes security features that support HIPAA compliance, but full compliance requires proper deployment and configuration.

**Q: Can I customize the user interface?**
A: Yes, the UI is built with Windows Forms and can be customized. See the [Customization Guide](docs/Customization.md).

## 🔮 Roadmap

### Version 2.0 (Planned)
- [ ] Web-based interface option
- [ ] Multi-clinic support
- [ ] Advanced reporting and analytics
- [ ] Integration with external lab systems
- [ ] Mobile companion app

### Version 1.5 (In Development)
- [ ] Enhanced security features
- [ ] Improved reporting capabilities
- [ ] Backup and restore functionality
- [ ] Performance optimizations

👨‍💻 Authors & Contributors

- **[Safaa Muhammad]** - *Initial work* - [MyGitHub](https://github.com/safaamohamed225)

Special thanks to the developers — Ahmed, Bassam, and Karim — for their valuable contributions and support in building and improving this project.  



## 🙏 Acknowledgments

- Healthcare professionals who provided valuable feedback during development
- Open source community for libraries and tools
- Beta testers from local medical practices

---

**Note**: This software is intended for administrative use only and should not be used as a substitute for professional medical judgment or patient care decisions.
