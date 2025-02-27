USE [master]
GO
/****** Object:  Database [Courseware]    Script Date: 07-May-16 1:23:55 PM ******/
CREATE DATABASE [Courseware]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Courseware', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Courseware.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Courseware_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Courseware_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Courseware] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Courseware].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Courseware] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Courseware] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Courseware] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Courseware] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Courseware] SET ARITHABORT OFF 
GO
ALTER DATABASE [Courseware] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Courseware] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Courseware] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Courseware] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Courseware] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Courseware] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Courseware] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Courseware] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Courseware] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Courseware] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Courseware] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Courseware] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Courseware] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Courseware] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Courseware] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Courseware] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Courseware] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Courseware] SET RECOVERY FULL 
GO
ALTER DATABASE [Courseware] SET  MULTI_USER 
GO
ALTER DATABASE [Courseware] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Courseware] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Courseware] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Courseware] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Courseware] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Courseware', N'ON'
GO
USE [Courseware]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Author](
	[author_id] [int] IDENTITY(1,1) NOT NULL,
	[author_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[author_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Books]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Books](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](100) NOT NULL,
	[author_id] [int] NOT NULL,
	[category_id] [int] NOT NULL,
	[sub_category_id] [int] NOT NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Category](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[cat_name] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Classes]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Classes](
	[class_id] [int] IDENTITY(1,1) NOT NULL,
	[course_id] [int] NOT NULL,
	[description] [varchar](5000) NOT NULL,
	[courseOutline] [varchar](5000) NOT NULL,
	[image_path] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Course_Material]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course_Material](
	[mat_id] [int] IDENTITY(1,1) NOT NULL,
	[course_id] [int] NOT NULL,
	[file_id] [int] NOT NULL,
	[uploadBy] [int] NOT NULL,
	[type] [int] NULL,
 CONSTRAINT [PK_Course_Material] PRIMARY KEY CLUSTERED 
(
	[mat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Courses]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Courses](
	[course_id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [varchar](50) NOT NULL,
	[credits] [int] NOT NULL,
	[description] [varchar](200) NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Files]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Files](
	[file_id] [int] IDENTITY(1,1) NOT NULL,
	[file_path] [varchar](50) NOT NULL,
	[uploadTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Files] PRIMARY KEY CLUSTERED 
(
	[file_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Magzines]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Magzines](
	[mag_id] [int] IDENTITY(1,1) NOT NULL,
	[mag_file_id] [int] NOT NULL,
	[mag_img_id] [int] NOT NULL,
	[mag_name] [varchar](50) NOT NULL,
	[mag_cat_id] [int] NOT NULL,
 CONSTRAINT [PK_Magzines] PRIMARY KEY CLUSTERED 
(
	[mag_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Magzines_Category]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Magzines_Category](
	[mag_cat_id] [int] IDENTITY(1,1) NOT NULL,
	[mag_cat_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Magzines_Category] PRIMARY KEY CLUSTERED 
(
	[mag_cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[News]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[News](
	[news_id] [int] IDENTITY(1,1) NOT NULL,
	[news_text] [text] NOT NULL,
	[news_images] [varchar](50) NOT NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[news_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Posts](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[PostedBy] [int] NOT NULL,
	[PostDesc] [varchar](500) NULL,
	[postTime] [datetime] NOT NULL,
	[global] [int] NOT NULL,
	[class_id] [int] NOT NULL,
	[file_id] [int] NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[std_id] [int] NOT NULL,
	[class_id] [int] NOT NULL,
	[ta] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[std_id] ASC,
	[class_id] ASC,
	[ta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SubCategory]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubCategory](
	[sub_cat_id] [int] IDENTITY(1,1) NOT NULL,
	[sub_cat_name] [varchar](100) NULL,
 CONSTRAINT [PK_SubCategory] PRIMARY KEY CLUSTERED 
(
	[sub_cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[Teacher_id] [int] NOT NULL,
	[class_id] [int] NOT NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[Teacher_id] ASC,
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[User]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[firstName] [varchar](50) NOT NULL,
	[lastName] [varchar](50) NOT NULL,
	[gender] [int] NOT NULL CONSTRAINT [DF_User_gender]  DEFAULT ((0)),
	[dob] [date] NOT NULL CONSTRAINT [DF_User_dob]  DEFAULT (getdate()),
	[account] [int] NOT NULL CONSTRAINT [DF_User_account]  DEFAULT ((0)),
	[onCreated] [datetime] NOT NULL CONSTRAINT [DF_User_onCreated]  DEFAULT (getdate()),
	[isActive] [int] NOT NULL CONSTRAINT [DF_User_isActive]  DEFAULT ((1)),
	[image] [varchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User_log]    Script Date: 07-May-16 1:23:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_log](
	[log_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[time] [datetime] NOT NULL
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Files] ADD  CONSTRAINT [DF_Files_uploadTime]  DEFAULT (getdate()) FOR [uploadTime]
GO
ALTER TABLE [dbo].[Posts] ADD  CONSTRAINT [DF_Posts_postTime]  DEFAULT (getdate()) FOR [postTime]
GO
ALTER TABLE [dbo].[Posts] ADD  CONSTRAINT [DF_Posts_global]  DEFAULT ((0)) FOR [global]
GO
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_ta]  DEFAULT ((0)) FOR [ta]
GO
ALTER TABLE [dbo].[User_log] ADD  CONSTRAINT [DF_User_log_time]  DEFAULT (getdate()) FOR [time]
GO
USE [master]
GO
ALTER DATABASE [Courseware] SET  READ_WRITE 
GO
