USE [master]
GO
/****** Object:  Database [doctorPortal]    Script Date: 4/28/2020 7:00:41 PM ******/
CREATE DATABASE [doctorPortal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'doctorPortal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\doctorPortal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'doctorPortal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\doctorPortal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [doctorPortal] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [doctorPortal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [doctorPortal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [doctorPortal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [doctorPortal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [doctorPortal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [doctorPortal] SET ARITHABORT OFF 
GO
ALTER DATABASE [doctorPortal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [doctorPortal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [doctorPortal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [doctorPortal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [doctorPortal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [doctorPortal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [doctorPortal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [doctorPortal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [doctorPortal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [doctorPortal] SET  ENABLE_BROKER 
GO
ALTER DATABASE [doctorPortal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [doctorPortal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [doctorPortal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [doctorPortal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [doctorPortal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [doctorPortal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [doctorPortal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [doctorPortal] SET RECOVERY FULL 
GO
ALTER DATABASE [doctorPortal] SET  MULTI_USER 
GO
ALTER DATABASE [doctorPortal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [doctorPortal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [doctorPortal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [doctorPortal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [doctorPortal] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'doctorPortal', N'ON'
GO
ALTER DATABASE [doctorPortal] SET QUERY_STORE = OFF
GO
USE [doctorPortal]
GO
/****** Object:  Table [dbo].[account]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[account](
	[acct_id] [int] IDENTITY(1,1) NOT NULL,
	[acct_user] [varchar](100) NULL,
	[acct_pass] [varchar](100) NULL,
	[acct_email] [varchar](100) NULL,
	[card_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[acct_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appointments]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointments](
	[apt_id] [int] NOT NULL,
	[apt_date] [date] NULL,
	[apt_time] [datetime] NULL,
	[apt_reason] [varchar](200) NULL,
	[patient_id] [int] NULL,
	[doctor_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[apt_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[biling]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[biling](
	[bill_id] [int] NOT NULL,
	[bill_date] [date] NULL,
	[bill_dueDate] [date] NULL,
	[bill_ammount] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[diagnosis]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[diagnosis](
	[diagnosis_id] [int] NOT NULL,
	[diagnosis_category] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[diagnosis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[doctor]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[doctor](
	[doctor_id] [int] NOT NULL,
	[doctor_name] [varchar](50) NULL,
	[doctor_phone] [varchar](50) NULL,
	[doctor_email] [varchar](50) NULL,
	[doctor_office_city] [varchar](50) NULL,
	[doctor_office_state] [varchar](50) NULL,
	[doctor_office_zip] [varchar](10) NULL,
	[doctor_specialty] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmergencyContact]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmergencyContact](
	[emerCon_id] [int] IDENTITY(1,1) NOT NULL,
	[emerCon_name] [varchar](100) NULL,
	[emerCon_phone] [varchar](100) NULL,
	[emerCon_relation] [varchar](100) NULL,
	[emerCon_email] [varchar](100) NULL,
	[patient_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[emerCon_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[insurance]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[insurance](
	[ins_id] [int] NOT NULL,
	[ins_provider] [varchar](50) NULL,
	[ins_phoneNumber] [varchar](20) NULL,
	[ins_pol_holder_name] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ins_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[patient_id] [int] IDENTITY(1,1) NOT NULL,
	[patient_fName] [varchar](100) NULL,
	[patient_lName] [varchar](100) NULL,
	[patient_gender] [char](1) NULL,
	[patient_address] [varchar](100) NULL,
	[patient_age] [varchar](3) NULL,
	[patient_city] [varchar](50) NULL,
	[patient_state] [char](3) NULL,
	[patient_zip] [varchar](10) NULL,
	[patient_phone] [varchar](20) NULL,
	[account_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[paymentCard]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[paymentCard](
	[card_id] [int] NOT NULL,
	[card_num] [varchar](20) NULL,
	[card_expire] [date] NULL,
	[card_csc] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[card_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[payments]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[payments](
	[bill_id] [int] NULL,
	[card_id] [int] NULL,
	[pay_status] [varchar](40) NULL,
	[pay_method] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pharmacy]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pharmacy](
	[phar_id] [int] NOT NULL,
	[phar_name] [varchar](50) NULL,
	[phar_address] [varchar](100) NULL,
	[phar_city] [varchar](50) NULL,
	[phar_state] [varchar](20) NULL,
	[phar_zip] [varchar](10) NULL,
	[phar_phone] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[phar_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prescription]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prescription](
	[prescription_id] [int] NOT NULL,
	[prescription_name] [varchar](100) NULL,
	[phar_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[prescription_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[records]    Script Date: 4/28/2020 7:00:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[records](
	[record_ID] [int] NOT NULL,
	[record_allergies] [varchar](50) NULL,
	[record_diagnosis_id] [int] NULL,
	[record_shots] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[record_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[account] ON 

INSERT [dbo].[account] ([acct_id], [acct_user], [acct_pass], [acct_email], [card_id]) VALUES (1, N'newUser', N'382819', N'newUser@email.com', 1)
INSERT [dbo].[account] ([acct_id], [acct_user], [acct_pass], [acct_email], [card_id]) VALUES (2, N'randomUser', N'akewerj3421', N'randomUser@email.com', 76)
SET IDENTITY_INSERT [dbo].[account] OFF
SET IDENTITY_INSERT [dbo].[EmergencyContact] ON 

INSERT [dbo].[EmergencyContact] ([emerCon_id], [emerCon_name], [emerCon_phone], [emerCon_relation], [emerCon_email], [patient_id]) VALUES (1, N'Jacob''s friend', N'123-472-8532', N'Friend', N'jacobIsAwesome@email.com', 1)
INSERT [dbo].[EmergencyContact] ([emerCon_id], [emerCon_name], [emerCon_phone], [emerCon_relation], [emerCon_email], [patient_id]) VALUES (2, N'Jacob''s mom', N'123-482-3222', N'Mother', N'jacobIsAdorable@email.com', 1)
INSERT [dbo].[EmergencyContact] ([emerCon_id], [emerCon_name], [emerCon_phone], [emerCon_relation], [emerCon_email], [patient_id]) VALUES (3, N'Madison''s father', N'123-477-8534', N'Father', N'father@email.com', 2)
SET IDENTITY_INSERT [dbo].[EmergencyContact] OFF
SET IDENTITY_INSERT [dbo].[patient] ON 

INSERT [dbo].[patient] ([patient_id], [patient_fName], [patient_lName], [patient_gender], [patient_address], [patient_age], [patient_city], [patient_state], [patient_zip], [patient_phone], [account_id]) VALUES (1, N'Jacob', N'Jacobson', N'M', N'A fake address', N'24', N'Fake city', NULL, N'12384', N'423-284-1842', 1)
INSERT [dbo].[patient] ([patient_id], [patient_fName], [patient_lName], [patient_gender], [patient_address], [patient_age], [patient_city], [patient_state], [patient_zip], [patient_phone], [account_id]) VALUES (2, N'Maddison', N'Square', N'F', N'Another fake address', N'18', N'Fake snobby city', NULL, N'84829', N'423-283-1242', 2)
SET IDENTITY_INSERT [dbo].[patient] OFF
ALTER TABLE [dbo].[appointments]  WITH CHECK ADD FOREIGN KEY([doctor_id])
REFERENCES [dbo].[doctor] ([doctor_id])
GO
ALTER TABLE [dbo].[appointments]  WITH CHECK ADD FOREIGN KEY([patient_id])
REFERENCES [dbo].[patient] ([patient_id])
GO
ALTER TABLE [dbo].[EmergencyContact]  WITH CHECK ADD FOREIGN KEY([patient_id])
REFERENCES [dbo].[patient] ([patient_id])
GO
ALTER TABLE [dbo].[patient]  WITH CHECK ADD FOREIGN KEY([account_id])
REFERENCES [dbo].[account] ([acct_id])
GO
ALTER TABLE [dbo].[payments]  WITH CHECK ADD FOREIGN KEY([bill_id])
REFERENCES [dbo].[biling] ([bill_id])
GO
ALTER TABLE [dbo].[payments]  WITH CHECK ADD FOREIGN KEY([card_id])
REFERENCES [dbo].[paymentCard] ([card_id])
GO
ALTER TABLE [dbo].[prescription]  WITH CHECK ADD FOREIGN KEY([phar_id])
REFERENCES [dbo].[pharmacy] ([phar_id])
GO
USE [master]
GO
ALTER DATABASE [doctorPortal] SET  READ_WRITE 
GO
